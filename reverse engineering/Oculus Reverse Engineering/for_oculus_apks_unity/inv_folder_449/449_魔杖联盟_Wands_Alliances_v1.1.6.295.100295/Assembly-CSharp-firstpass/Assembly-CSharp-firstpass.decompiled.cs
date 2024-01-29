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
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4C6C", Offset = "0xCB4C6C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4C6C", Offset = "0xCB4C6C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5728", Offset = "0xCB5728")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5728", Offset = "0xCB5728")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5780", Offset = "0xCB5780")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5780", Offset = "0xCB5780")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB57D8", Offset = "0xCB57D8")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5810", Offset = "0xCB5810")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5848", Offset = "0xCB5848")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5880", Offset = "0xCB5880")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB58B8", Offset = "0xCB58B8")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB58F0", Offset = "0xCB58F0")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5928", Offset = "0xCB5928")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5960", Offset = "0xCB5960")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5970", Offset = "0xCB5970")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB59A0", Offset = "0xCB59A0")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x29A6FF4", Offset = "0x29A6FF4", VA = "0x29A6FF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC798", Offset = "0xCBC798")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x29A6FFC", Offset = "0x29A6FFC", VA = "0x29A6FFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC7A8", Offset = "0xCBC7A8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x29A7008", Offset = "0x29A7008", VA = "0x29A7008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC7B8", Offset = "0xCBC7B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x29A7010", Offset = "0x29A7010", VA = "0x29A7010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC7C8", Offset = "0xCBC7C8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x29A7018", Offset = "0x29A7018", VA = "0x29A7018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC7D8", Offset = "0xCBC7D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x29A7020", Offset = "0x29A7020", VA = "0x29A7020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC7E8", Offset = "0xCBC7E8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x29A6ED4", Offset = "0x29A6ED4", VA = "0x29A6ED4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC6B8", Offset = "0xCBC6B8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x29A6F1C", Offset = "0x29A6F1C", VA = "0x29A6F1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC6F0", Offset = "0xCBC6F0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x29A6F64", Offset = "0x29A6F64", VA = "0x29A6F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC728", Offset = "0xCBC728")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x29A6FAC", Offset = "0x29A6FAC", VA = "0x29A6FAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC760", Offset = "0xCBC760")]
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
		[Address(RVA = "0x29A7028", Offset = "0x29A7028", VA = "0x29A7028")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x29A702C", Offset = "0x29A702C", VA = "0x29A702C")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x29A7030", Offset = "0x29A7030", VA = "0x29A7030")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x29A7034", Offset = "0x29A7034", VA = "0x29A7034")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB59B0", Offset = "0xCB59B0")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB59E8", Offset = "0xCB59E8")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5A20", Offset = "0xCB5A20")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5A58", Offset = "0xCB5A58")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5A90", Offset = "0xCB5A90")]
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
		[Address(RVA = "0x2A33EEC", Offset = "0x2A33EEC", VA = "0x2A33EEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A342DC", Offset = "0x2A342DC", VA = "0x2A342DC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A342E4", Offset = "0x2A342E4", VA = "0x2A342E4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A343F4", Offset = "0x2A343F4", VA = "0x2A343F4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A34470", Offset = "0x2A34470", VA = "0x2A34470", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A344EC", Offset = "0x2A344EC", VA = "0x2A344EC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A34134", Offset = "0x2A34134", VA = "0x2A34134")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A34208", Offset = "0x2A34208", VA = "0x2A34208")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A34568", Offset = "0x2A34568", VA = "0x2A34568")]
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
		[Address(RVA = "0x294A478", Offset = "0x294A478", VA = "0x294A478")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x29A62CC", Offset = "0x29A62CC", VA = "0x29A62CC")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x29A6528", Offset = "0x29A6528", VA = "0x29A6528")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x29A6508", Offset = "0x29A6508", VA = "0x29A6508")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x29A6AD4", Offset = "0x29A6AD4", VA = "0x29A6AD4")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x29A82B0", Offset = "0x29A82B0", VA = "0x29A82B0")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x29A9B68", Offset = "0x29A9B68", VA = "0x29A9B68")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x29A7D04", Offset = "0x29A7D04", VA = "0x29A7D04")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x29A82F8", Offset = "0x29A82F8", VA = "0x29A82F8")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x29A7834", Offset = "0x29A7834", VA = "0x29A7834")]
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
		[Address(RVA = "0x29A7120", Offset = "0x29A7120", VA = "0x29A7120")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x29A738C", Offset = "0x29A738C", VA = "0x29A738C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x29A7284", Offset = "0x29A7284", VA = "0x29A7284")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x29A7508", Offset = "0x29A7508", VA = "0x29A7508")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x29A7A98", Offset = "0x29A7A98", VA = "0x29A7A98")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x29A7B94", Offset = "0x29A7B94", VA = "0x29A7B94")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x29A7C90", Offset = "0x29A7C90", VA = "0x29A7C90")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x29A7C08", Offset = "0x29A7C08", VA = "0x29A7C08")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x29A7EFC", Offset = "0x29A7EFC", VA = "0x29A7EFC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x29A7FB0", Offset = "0x29A7FB0", VA = "0x29A7FB0")]
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
		[Address(RVA = "0x29A82FC", Offset = "0x29A82FC", VA = "0x29A82FC")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x29A836C", Offset = "0x29A836C", VA = "0x29A836C")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x29A8E00", Offset = "0x29A8E00", VA = "0x29A8E00")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x29A8EB4", Offset = "0x29A8EB4", VA = "0x29A8EB4")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x29A8DA4", Offset = "0x29A8DA4", VA = "0x29A8DA4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x29A8FAC", Offset = "0x29A8FAC", VA = "0x29A8FAC")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x29A8FF4", Offset = "0x29A8FF4", VA = "0x29A8FF4")]
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
		[Address(RVA = "0x29A8FFC", Offset = "0x29A8FFC", VA = "0x29A8FFC")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x29A9188", Offset = "0x29A9188", VA = "0x29A9188")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x29A919C", Offset = "0x29A919C", VA = "0x29A919C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x29A9488", Offset = "0x29A9488", VA = "0x29A9488")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x29A9094", Offset = "0x29A9094", VA = "0x29A9094")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x29A973C", Offset = "0x29A973C", VA = "0x29A973C")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x29A97B0", Offset = "0x29A97B0", VA = "0x29A97B0")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x29A9964", Offset = "0x29A9964", VA = "0x29A9964")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5AC8", Offset = "0xCB5AC8")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5B00", Offset = "0xCB5B00")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5B00", Offset = "0xCB5B00")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5B58", Offset = "0xCB5B58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5B58", Offset = "0xCB5B58")]
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
		[Address(RVA = "0x2A3D014", Offset = "0x2A3D014", VA = "0x2A3D014")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2A3D4F0", Offset = "0x2A3D4F0", VA = "0x2A3D4F0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A3D50C", Offset = "0x2A3D50C", VA = "0x2A3D50C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A3D5E8", Offset = "0x2A3D5E8", VA = "0x2A3D5E8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A3D6C4", Offset = "0x2A3D6C4", VA = "0x2A3D6C4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A3D894", Offset = "0x2A3D894", VA = "0x2A3D894", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A3DBCC", Offset = "0x2A3DBCC", VA = "0x2A3DBCC")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A3DCA8", Offset = "0x2A3DCA8", VA = "0x2A3DCA8")]
		public HumanoidBaker()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public enum Axis
	{
		[Token(Token = "0x4000051")]
		X,
		[Token(Token = "0x4000052")]
		Y,
		[Token(Token = "0x4000053")]
		Z
	}
	[Token(Token = "0x200000D")]
	public class AxisTools
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x29A6ADC", Offset = "0x29A6ADC", VA = "0x29A6ADC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x29A6B00", Offset = "0x29A6B00", VA = "0x29A6B00")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x29A6B38", Offset = "0x29A6B38", VA = "0x29A6B38")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x29A6C28", Offset = "0x29A6C28", VA = "0x29A6C28")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x29A6BD0", Offset = "0x29A6BD0", VA = "0x29A6BD0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x29A6CC0", Offset = "0x29A6CC0", VA = "0x29A6CC0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x29A6D08", Offset = "0x29A6D08", VA = "0x29A6D08")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x29A6ECC", Offset = "0x29A6ECC", VA = "0x29A6ECC")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200000F")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x295238C", Offset = "0x295238C", VA = "0x295238C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000004")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x29AB3AC", Offset = "0x29AB3AC", VA = "0x29AB3AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x29AB618", Offset = "0x29AB618", VA = "0x29AB618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x29AB360", Offset = "0x29AB360", VA = "0x29AB360")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000011")]
		public enum BoneType
		{
			[Token(Token = "0x400006E")]
			Unassigned,
			[Token(Token = "0x400006F")]
			Spine,
			[Token(Token = "0x4000070")]
			Head,
			[Token(Token = "0x4000071")]
			Arm,
			[Token(Token = "0x4000072")]
			Leg,
			[Token(Token = "0x4000073")]
			Tail,
			[Token(Token = "0x4000074")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000012")]
		public enum BoneSide
		{
			[Token(Token = "0x4000076")]
			Center,
			[Token(Token = "0x4000077")]
			Left,
			[Token(Token = "0x4000078")]
			Right
		}

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x29AB884", Offset = "0x29AB884", VA = "0x29AB884")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x29ABBA0", Offset = "0x29ABBA0", VA = "0x29ABBA0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x29ABE0C", Offset = "0x29ABE0C", VA = "0x29ABE0C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x29ABE8C", Offset = "0x29ABE8C", VA = "0x29ABE8C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x29ABF34", Offset = "0x29ABF34", VA = "0x29ABF34")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x29ABA54", Offset = "0x29ABA54", VA = "0x29ABA54")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x29ABD70", Offset = "0x29ABD70", VA = "0x29ABD70")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x29AC764", Offset = "0x29AC764", VA = "0x29AC764")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x29AC56C", Offset = "0x29AC56C", VA = "0x29AC56C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x29AC668", Offset = "0x29AC668", VA = "0x29AC668")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x29AC14C", Offset = "0x29AC14C", VA = "0x29AC14C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x29AC1FC", Offset = "0x29AC1FC", VA = "0x29AC1FC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x29AC2AC", Offset = "0x29AC2AC", VA = "0x29AC2AC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x29AC35C", Offset = "0x29AC35C", VA = "0x29AC35C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x29AC40C", Offset = "0x29AC40C", VA = "0x29AC40C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x29AC4BC", Offset = "0x29AC4BC", VA = "0x29AC4BC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x29AC96C", Offset = "0x29AC96C", VA = "0x29AC96C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x29AC064", Offset = "0x29AC064", VA = "0x29AC064")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x29AC8DC", Offset = "0x29AC8DC", VA = "0x29AC8DC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x29AC9D8", Offset = "0x29AC9D8", VA = "0x29AC9D8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x29ACAAC", Offset = "0x29ACAAC", VA = "0x29ACAAC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x29AC864", Offset = "0x29AC864", VA = "0x29AC864")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x29AC7F0", Offset = "0x29AC7F0", VA = "0x29AC7F0")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public class BipedReferences
	{
		[Token(Token = "0x2000014")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000008")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000085")]
				[Address(RVA = "0x2952418", Offset = "0x2952418", VA = "0x2952418")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2952404", Offset = "0x2952404", VA = "0x2952404")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000006")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x29AEAF0", Offset = "0x29AEAF0", VA = "0x29AEAF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool isEmpty
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x29AEED8", Offset = "0x29AEED8", VA = "0x29AEED8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x29AEEE8", Offset = "0x29AEEE8", VA = "0x29AEEE8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x29AF310", Offset = "0x29AF310", VA = "0x29AF310", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x29AF744", Offset = "0x29AF744", VA = "0x29AF744")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x29AFD30", Offset = "0x29AFD30", VA = "0x29AFD30")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x29AF958", Offset = "0x29AF958", VA = "0x29AF958")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x29AA854", Offset = "0x29AA854", VA = "0x29AA854")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x29B0530", Offset = "0x29B0530", VA = "0x29B0530")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x29B0A90", Offset = "0x29B0A90", VA = "0x29B0A90")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x29B0884", Offset = "0x29B0884", VA = "0x29B0884")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x29B0700", Offset = "0x29B0700", VA = "0x29B0700")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x29B05D0", Offset = "0x29B05D0", VA = "0x29B05D0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x29B0990", Offset = "0x29B0990", VA = "0x29B0990")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x29B0B88", Offset = "0x29B0B88", VA = "0x29B0B88")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x29B16AC", Offset = "0x29B16AC", VA = "0x29B16AC")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x29B1134", Offset = "0x29B1134", VA = "0x29B1134")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x29B1954", Offset = "0x29B1954", VA = "0x29B1954")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x29B14A0", Offset = "0x29B14A0", VA = "0x29B14A0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x29B195C", Offset = "0x29B195C", VA = "0x29B195C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x29B1964", Offset = "0x29B1964", VA = "0x29B1964")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x29B1B2C", Offset = "0x29B1B2C", VA = "0x29B1B2C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x29B1CE8", Offset = "0x29B1CE8", VA = "0x29B1CE8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x29AAFB0", Offset = "0x29AAFB0", VA = "0x29AAFB0")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x29B2540", Offset = "0x29B2540", VA = "0x29B2540")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x29B2AC0", Offset = "0x29B2AC0", VA = "0x29B2AC0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x29B2C08", Offset = "0x29B2C08", VA = "0x29B2C08")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Hierarchy
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2A3BA2C", Offset = "0x2A3BA2C", VA = "0x2A3BA2C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2A3BC18", Offset = "0x2A3BC18", VA = "0x2A3BC18")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2A3BAC4", Offset = "0x2A3BAC4", VA = "0x2A3BAC4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2A3BD38", Offset = "0x2A3BD38", VA = "0x2A3BD38")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A3BE64", Offset = "0x2A3BE64", VA = "0x2A3BE64")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A3C0B0", Offset = "0x2A3C0B0", VA = "0x2A3C0B0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A3C1B8", Offset = "0x2A3C1B8", VA = "0x2A3C1B8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A3C32C", Offset = "0x2A3C32C", VA = "0x2A3C32C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A3C708", Offset = "0x2A3C708", VA = "0x2A3C708")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A3C4CC", Offset = "0x2A3C4CC", VA = "0x2A3C4CC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A3C8BC", Offset = "0x2A3C8BC", VA = "0x2A3C8BC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x29F0E20", Offset = "0x29F0E20", VA = "0x29F0E20")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x29F0E8C", Offset = "0x29F0E8C", VA = "0x29F0E8C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000092")]
		None,
		[Token(Token = "0x4000093")]
		InOutCubic,
		[Token(Token = "0x4000094")]
		InOutQuintic,
		[Token(Token = "0x4000095")]
		InOutSine,
		[Token(Token = "0x4000096")]
		InQuintic,
		[Token(Token = "0x4000097")]
		InQuartic,
		[Token(Token = "0x4000098")]
		InCubic,
		[Token(Token = "0x4000099")]
		InQuadratic,
		[Token(Token = "0x400009A")]
		InElastic,
		[Token(Token = "0x400009B")]
		InElasticSmall,
		[Token(Token = "0x400009C")]
		InElasticBig,
		[Token(Token = "0x400009D")]
		InSine,
		[Token(Token = "0x400009E")]
		InBack,
		[Token(Token = "0x400009F")]
		OutQuintic,
		[Token(Token = "0x40000A0")]
		OutQuartic,
		[Token(Token = "0x40000A1")]
		OutCubic,
		[Token(Token = "0x40000A2")]
		OutInCubic,
		[Token(Token = "0x40000A3")]
		OutInQuartic,
		[Token(Token = "0x40000A4")]
		OutElastic,
		[Token(Token = "0x40000A5")]
		OutElasticSmall,
		[Token(Token = "0x40000A6")]
		OutElasticBig,
		[Token(Token = "0x40000A7")]
		OutSine,
		[Token(Token = "0x40000A8")]
		OutBack,
		[Token(Token = "0x40000A9")]
		OutBackCubic,
		[Token(Token = "0x40000AA")]
		OutBackQuartic,
		[Token(Token = "0x40000AB")]
		BackInCubic,
		[Token(Token = "0x40000AC")]
		BackInQuartic
	}
	[Token(Token = "0x200001A")]
	public class Interp
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x29F3BF8", Offset = "0x29F3BF8", VA = "0x29F3BF8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x29F95BC", Offset = "0x29F95BC", VA = "0x29F95BC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x29F9630", Offset = "0x29F9630", VA = "0x29F9630")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x29F9024", Offset = "0x29F9024", VA = "0x29F9024")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x29F9030", Offset = "0x29F9030", VA = "0x29F9030")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x29F9054", Offset = "0x29F9054", VA = "0x29F9054")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x29F9090", Offset = "0x29F9090", VA = "0x29F9090")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x29F90A8", Offset = "0x29F90A8", VA = "0x29F90A8")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x29F90BC", Offset = "0x29F90BC", VA = "0x29F90BC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x29F90D0", Offset = "0x29F90D0", VA = "0x29F90D0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x29F90E0", Offset = "0x29F90E0", VA = "0x29F90E0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x29F9128", Offset = "0x29F9128", VA = "0x29F9128")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x29F9160", Offset = "0x29F9160", VA = "0x29F9160")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x29F9188", Offset = "0x29F9188", VA = "0x29F9188")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x29F96BC", Offset = "0x29F96BC", VA = "0x29F96BC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x29F91BC", Offset = "0x29F91BC", VA = "0x29F91BC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x29F91E4", Offset = "0x29F91E4", VA = "0x29F91E4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x29F9214", Offset = "0x29F9214", VA = "0x29F9214")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x29F9248", Offset = "0x29F9248", VA = "0x29F9248")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x29F928C", Offset = "0x29F928C", VA = "0x29F928C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x29F92F0", Offset = "0x29F92F0", VA = "0x29F92F0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x29F9354", Offset = "0x29F9354", VA = "0x29F9354")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x29F93A8", Offset = "0x29F93A8", VA = "0x29F93A8")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x29F93FC", Offset = "0x29F93FC", VA = "0x29F93FC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x29F9438", Offset = "0x29F9438", VA = "0x29F9438")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x29F9470", Offset = "0x29F9470", VA = "0x29F9470")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x29F96F0", Offset = "0x29F96F0", VA = "0x29F96F0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x29F94B8", Offset = "0x29F94B8", VA = "0x29F94B8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x29F954C", Offset = "0x29F954C", VA = "0x29F954C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x29F957C", Offset = "0x29F957C", VA = "0x29F957C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x29F9784", Offset = "0x29F9784", VA = "0x29F9784")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x29F978C", Offset = "0x29F978C", VA = "0x29F978C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x29F97F8", Offset = "0x29F97F8", VA = "0x29F97F8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x29F9864", Offset = "0x29F9864", VA = "0x29F9864")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x29F98BC", Offset = "0x29F98BC", VA = "0x29F98BC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x29F9988", Offset = "0x29F9988", VA = "0x29F9988")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x29F98D4", Offset = "0x29F98D4", VA = "0x29F98D4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x29F99A0", Offset = "0x29F99A0", VA = "0x29F99A0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x29F9A44", Offset = "0x29F9A44", VA = "0x29F9A44")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x29F9A70", Offset = "0x29F9A70", VA = "0x29F9A70")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x29F9AC0", Offset = "0x29F9AC0", VA = "0x29F9AC0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x29F9B2C", Offset = "0x29F9B2C", VA = "0x29F9B2C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x29F9C40", Offset = "0x29F9C40", VA = "0x29F9C40")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x29F9D38", Offset = "0x29F9D38", VA = "0x29F9D38")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x29F9D94", Offset = "0x29F9D94", VA = "0x29F9D94")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	public static class QuaTools
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x29FBD20", Offset = "0x29FBD20", VA = "0x29FBD20")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x29FBD7C", Offset = "0x29FBD7C", VA = "0x29FBD7C")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x29FBE0C", Offset = "0x29FBE0C", VA = "0x29FBE0C")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x29FBF6C", Offset = "0x29FBF6C", VA = "0x29FBF6C")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x29FC028", Offset = "0x29FC028", VA = "0x29FC028")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x29FC0E4", Offset = "0x29FC0E4", VA = "0x29FC0E4")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x29FC290", Offset = "0x29FC290", VA = "0x29FC290")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x29FC2E0", Offset = "0x29FC2E0", VA = "0x29FC2E0")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x29FC330", Offset = "0x29FC330", VA = "0x29FC330")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x29FC3D8", Offset = "0x29FC3D8", VA = "0x29FC3D8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x29F8C60", Offset = "0x29F8C60", VA = "0x29F8C60")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x29FC480", Offset = "0x29FC480", VA = "0x29FC480")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x29F8D40", Offset = "0x29F8D40", VA = "0x29F8D40")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x29FC4D4", Offset = "0x29FC4D4", VA = "0x29FC4D4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x29FC5E4", Offset = "0x29FC5E4", VA = "0x29FC5E4")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x29FC774", Offset = "0x29FC774", VA = "0x29FC774")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x29FC868", Offset = "0x29FC868", VA = "0x29FC868")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x29FC974", Offset = "0x29FC974", VA = "0x29FC974")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x29FCA60", Offset = "0x29FCA60", VA = "0x29FCA60")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200001E")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x60000D6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000D8")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5BBC", Offset = "0xCB5BBC")]
		public bool fixTransforms;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x2A01660", Offset = "0x2A01660", VA = "0x2A01660")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2A0196C", Offset = "0x2A0196C", VA = "0x2A0196C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2A01520", Offset = "0x2A01520", VA = "0x2A01520")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2A015C0", Offset = "0x2A015C0", VA = "0x2A015C0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2A015C4", Offset = "0x2A015C4", VA = "0x2A015C4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2A015C8", Offset = "0x2A015C8", VA = "0x2A015C8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2A015CC", Offset = "0x2A015CC", VA = "0x2A015CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2A0165C", Offset = "0x2A0165C", VA = "0x2A0165C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2A01604", Offset = "0x2A01604", VA = "0x2A01604")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2A01920", Offset = "0x2A01920", VA = "0x2A01920")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2A0174C", Offset = "0x2A0174C", VA = "0x2A0174C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2A01A24", Offset = "0x2A01A24", VA = "0x2A01A24")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2A01A80", Offset = "0x2A01A80", VA = "0x2A01A80")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2A01ADC", Offset = "0x2A01ADC", VA = "0x2A01ADC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x29FBD10", Offset = "0x29FBD10", VA = "0x29FBD10")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x294A4E8", Offset = "0x294A4E8", VA = "0x294A4E8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x294A5A8", Offset = "0x294A5A8", VA = "0x294A5A8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x294A668", Offset = "0x294A668", VA = "0x294A668")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x294A728", Offset = "0x294A728", VA = "0x294A728")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class V2Tools
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x294C550", Offset = "0x294C550", VA = "0x294C550")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x294C558", Offset = "0x294C558", VA = "0x294C558")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x294C5A8", Offset = "0x294C5A8", VA = "0x294C5A8")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x294C5FC", Offset = "0x294C5FC", VA = "0x294C5FC")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x294C6D4", Offset = "0x294C6D4", VA = "0x294C6D4")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000022")]
	public static class V3Tools
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x294C768", Offset = "0x294C768", VA = "0x294C768")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x294C78C", Offset = "0x294C78C", VA = "0x294C78C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x294C7D4", Offset = "0x294C7D4", VA = "0x294C7D4")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x294C860", Offset = "0x294C860", VA = "0x294C860")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x294C8C0", Offset = "0x294C8C0", VA = "0x294C8C0")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x294C920", Offset = "0x294C920", VA = "0x294C920")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x294CA3C", Offset = "0x294CA3C", VA = "0x294CA3C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x294CADC", Offset = "0x294CADC", VA = "0x294CADC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x294CB18", Offset = "0x294CB18", VA = "0x294CB18")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x294CB5C", Offset = "0x294CB5C", VA = "0x294CB5C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x294CBF8", Offset = "0x294CBF8", VA = "0x294CBF8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x294CD54", Offset = "0x294CD54", VA = "0x294CD54")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x294CED0", Offset = "0x294CED0", VA = "0x294CED0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x294D054", Offset = "0x294D054", VA = "0x294D054")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x294D110", Offset = "0x294D110", VA = "0x294D110")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x294D210", Offset = "0x294D210", VA = "0x294D210")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x294D298", Offset = "0x294D298", VA = "0x294D298")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x294D334", Offset = "0x294D334", VA = "0x294D334")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x294D3D8", Offset = "0x294D3D8", VA = "0x294D3D8")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x294D3C8", Offset = "0x294D3C8", VA = "0x294D3C8")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000023")]
	public static class Warning
	{
		[Token(Token = "0x2000024")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2951BF8", Offset = "0x2951BF8", VA = "0x2951BF8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2951C90", Offset = "0x2951C90", VA = "0x2951C90")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x2000025")]
	public class Navigator
	{
		[Token(Token = "0x2000026")]
		public enum State
		{
			[Token(Token = "0x40000C7")]
			Idle,
			[Token(Token = "0x40000C8")]
			Seeking,
			[Token(Token = "0x40000C9")]
			OnPath
		}

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5BF4", Offset = "0xCB5BF4")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5C2C", Offset = "0xCB5C2C")]
		public float cornerRadius;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5C64", Offset = "0xCB5C64")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5C9C", Offset = "0xCB5C9C")]
		public float maxSampleDistance;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5CD4", Offset = "0xCB5CD4")]
		public float nextPathInterval;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5D0C", Offset = "0xCB5D0C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5D1C", Offset = "0xCB5D1C")]
		private State <state>k__BackingField;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700000C")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x29FABF0", Offset = "0x29FABF0", VA = "0x29FABF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC868", Offset = "0xCBC868")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x29FABFC", Offset = "0x29FABFC", VA = "0x29FABFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC878", Offset = "0xCBC878")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public State state
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x29FAC08", Offset = "0x29FAC08", VA = "0x29FAC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC888", Offset = "0xCBC888")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x29FAC10", Offset = "0x29FAC10", VA = "0x29FAC10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC898", Offset = "0xCBC898")]
			private set
			{
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x29FAC18", Offset = "0x29FAC18", VA = "0x29FAC18")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x29FACC8", Offset = "0x29FACC8", VA = "0x29FACC8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x29FB0B4", Offset = "0x29FB0B4", VA = "0x29FB0B4")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x29FB130", Offset = "0x29FB130", VA = "0x29FB130")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x29FB070", Offset = "0x29FB070", VA = "0x29FB070")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x29FB0A0", Offset = "0x29FB0A0", VA = "0x29FB0A0")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x29FB27C", Offset = "0x29FB27C", VA = "0x29FB27C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x29FB42C", Offset = "0x29FB42C", VA = "0x29FB42C")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4CDC", Offset = "0xCB4CDC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4CDC", Offset = "0xCB4CDC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x29A9F38", Offset = "0x29A9F38", VA = "0x29A9F38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC8A8", Offset = "0xCBC8A8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x29A9F80", Offset = "0x29A9F80", VA = "0x29A9F80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC8E0", Offset = "0xCBC8E0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x29A9FC8", Offset = "0x29A9FC8", VA = "0x29A9FC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC918", Offset = "0xCBC918")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x29AA010", Offset = "0x29AA010", VA = "0x29AA010")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC950", Offset = "0xCBC950")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x29AA058", Offset = "0x29AA058", VA = "0x29AA058")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x29AA0F4", Offset = "0x29AA0F4", VA = "0x29AA0F4")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x29AA114", Offset = "0x29AA114", VA = "0x29AA114")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x29AA144", Offset = "0x29AA144", VA = "0x29AA144")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x29AA174", Offset = "0x29AA174", VA = "0x29AA174")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x29AA1B4", Offset = "0x29AA1B4", VA = "0x29AA1B4")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x29AA1F8", Offset = "0x29AA1F8", VA = "0x29AA1F8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x29AA21C", Offset = "0x29AA21C", VA = "0x29AA21C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x29AA240", Offset = "0x29AA240", VA = "0x29AA240")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x29AA268", Offset = "0x29AA268", VA = "0x29AA268")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x29AA294", Offset = "0x29AA294", VA = "0x29AA294")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x29AA2C0", Offset = "0x29AA2C0", VA = "0x29AA2C0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x29AA078", Offset = "0x29AA078", VA = "0x29AA078")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x29AA2E8", Offset = "0x29AA2E8", VA = "0x29AA2E8")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x29AA2F4", Offset = "0x29AA2F4", VA = "0x29AA2F4")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x29AA300", Offset = "0x29AA300", VA = "0x29AA300")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x29AA5E4", Offset = "0x29AA5E4", VA = "0x29AA5E4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x29AA68C", Offset = "0x29AA68C", VA = "0x29AA68C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x29AAABC", Offset = "0x29AAABC", VA = "0x29AAABC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x29AAEF4", Offset = "0x29AAEF4", VA = "0x29AAEF4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x29AAF28", Offset = "0x29AAF28", VA = "0x29AAF28")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700000E")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x29AA4A0", Offset = "0x29AA4A0", VA = "0x29AA4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x29AB190", Offset = "0x29AB190", VA = "0x29AB190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x29AA944", Offset = "0x29AA944", VA = "0x29AA944")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x29AB01C", Offset = "0x29AB01C", VA = "0x29AB01C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000010")]
		public bool isValid
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x29B2548", Offset = "0x29B2548", VA = "0x29B2548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x29B25B4", Offset = "0x29B25B4", VA = "0x29B25B4")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x29B25BC", Offset = "0x29B25BC", VA = "0x29B25BC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x29B267C", Offset = "0x29B267C", VA = "0x29B267C")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x29B2684", Offset = "0x29B2684", VA = "0x29B2684")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000011")]
		private bool positionChanged
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x29B27B8", Offset = "0x29B27B8", VA = "0x29B27B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x29B26B0", Offset = "0x29B26B0", VA = "0x29B26B0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x29B27F4", Offset = "0x29B27F4", VA = "0x29B27F4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x29B27FC", Offset = "0x29B27FC", VA = "0x29B27FC")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x29B2828", Offset = "0x29B2828", VA = "0x29B2828", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x29B28A8", Offset = "0x29B28A8", VA = "0x29B28A8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x29B28B0", Offset = "0x29B28B0", VA = "0x29B28B0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000012")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x29B29E4", Offset = "0x29B29E4", VA = "0x29B29E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x29B28DC", Offset = "0x29B28DC", VA = "0x29B28DC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x29B2A20", Offset = "0x29B2A20", VA = "0x29B2A20")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x29B2A28", Offset = "0x29B2A28", VA = "0x29B2A28")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class Constraints
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5D2C", Offset = "0xCB5D2C")]
		public float positionWeight;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5D44", Offset = "0xCB5D44")]
		public float rotationWeight;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x29B2A54", Offset = "0x29B2A54", VA = "0x29B2A54")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x29AAA68", Offset = "0x29AAA68", VA = "0x29AAA68")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x29AAC44", Offset = "0x29AAC44", VA = "0x29AAC44")]
		public void Update()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x29AB358", Offset = "0x29AB358", VA = "0x29AB358")]
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
			[Token(Token = "0x40000FF")]
			One,
			[Token(Token = "0x4000100")]
			Three
		}

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5D5C", Offset = "0xCB5D5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5D5C", Offset = "0xCB5D5C")]
		public float weight;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5DB0", Offset = "0xCB5DB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5DB0", Offset = "0xCB5DB0")]
		public float rotationWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5E04", Offset = "0xCB5E04")]
		public DOF rotationDOF;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5E3C", Offset = "0xCB5E3C")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5E74", Offset = "0xCB5E74")]
		public Transform bone1;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5EAC", Offset = "0xCB5EAC")]
		public Transform bone2;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5EE4", Offset = "0xCB5EE4")]
		public Transform bone3;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5F1C", Offset = "0xCB5F1C")]
		public Transform tip;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5F54", Offset = "0xCB5F54")]
		public Transform target;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5F8C", Offset = "0xCB5F8C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000013")]
		public bool initiated
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2A31E9C", Offset = "0x2A31E9C", VA = "0x2A31E9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC988", Offset = "0xCBC988")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2A31EA4", Offset = "0x2A31EA4", VA = "0x2A31EA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC998", Offset = "0xCBC998")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2A31EB0", Offset = "0x2A31EB0", VA = "0x2A31EB0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2A31ED0", Offset = "0x2A31ED0", VA = "0x2A31ED0")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2A31EF0", Offset = "0x2A31EF0", VA = "0x2A31EF0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2A31F10", Offset = "0x2A31F10", VA = "0x2A31F10")]
			set
			{
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2A31F30", Offset = "0x2A31F30", VA = "0x2A31F30")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2A32038", Offset = "0x2A32038", VA = "0x2A32038")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2A32728", Offset = "0x2A32728", VA = "0x2A32728")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2A32800", Offset = "0x2A32800", VA = "0x2A32800")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2A328C4", Offset = "0x2A328C4", VA = "0x2A328C4")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2A32DB4", Offset = "0x2A32DB4", VA = "0x2A32DB4")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB5F9C", Offset = "0xCB5F9C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB5F9C", Offset = "0xCB5F9C")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5FF0", Offset = "0xCB5FF0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000016")]
		public bool initiated
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2A32DC4", Offset = "0x2A32DC4", VA = "0x2A32DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC9A8", Offset = "0xCBC9A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2A32DCC", Offset = "0x2A32DCC", VA = "0x2A32DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC9B8", Offset = "0xCBC9B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2A32DD8", Offset = "0x2A32DD8", VA = "0x2A32DD8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2A32E60", Offset = "0x2A32E60", VA = "0x2A32E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBC9C8", Offset = "0xCBC9C8")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2A33198", Offset = "0x2A33198", VA = "0x2A33198")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2A33310", Offset = "0x2A33310", VA = "0x2A33310")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2A3309C", Offset = "0x2A3309C", VA = "0x2A3309C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2A33480", Offset = "0x2A33480", VA = "0x2A33480", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2A33540", Offset = "0x2A33540", VA = "0x2A33540")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2A335B8", Offset = "0x2A335B8", VA = "0x2A335B8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2A3362C", Offset = "0x2A3362C", VA = "0x2A3362C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2A33694", Offset = "0x2A33694", VA = "0x2A33694", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2A33698", Offset = "0x2A33698", VA = "0x2A33698", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2A336AC", Offset = "0x2A336AC", VA = "0x2A336AC")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB6000", Offset = "0xCB6000")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6000", Offset = "0xCB6000")]
		public float weight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6054", Offset = "0xCB6054")]
		public Grounding solver;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB608C", Offset = "0xCB608C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2A34AC8", Offset = "0x2A34AC8", VA = "0x2A34AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCA00", Offset = "0xCBCA00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2A34AD0", Offset = "0x2A34AD0", VA = "0x2A34AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCA10", Offset = "0xCBCA10")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000164")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2A34ADC", Offset = "0x2A34ADC", VA = "0x2A34ADC")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2A34C88", Offset = "0x2A34C88", VA = "0x2A34C88")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2A34B88", Offset = "0x2A34B88", VA = "0x2A34B88")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2A34CBC", Offset = "0x2A34CBC", VA = "0x2A34CBC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600016C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2A34DF8", Offset = "0x2A34DF8", VA = "0x2A34DF8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4D3C", Offset = "0xCB4D3C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4D3C", Offset = "0xCB4D3C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB609C", Offset = "0xCB609C")]
		public BipedIK ik;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB60D4", Offset = "0xCB60D4")]
		public float spineBend;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB610C", Offset = "0xCB610C")]
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

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2A34F08", Offset = "0x2A34F08", VA = "0x2A34F08", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCA20", Offset = "0xCBCA20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2A34F50", Offset = "0x2A34F50", VA = "0x2A34F50", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCA58", Offset = "0xCBCA58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2A34F98", Offset = "0x2A34F98", VA = "0x2A34F98", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2A35060", Offset = "0x2A35060", VA = "0x2A35060")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2A3510C", Offset = "0x2A3510C", VA = "0x2A3510C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2A3516C", Offset = "0x2A3516C", VA = "0x2A3516C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2A356B4", Offset = "0x2A356B4", VA = "0x2A356B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2A35708", Offset = "0x2A35708", VA = "0x2A35708")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2A35D8C", Offset = "0x2A35D8C", VA = "0x2A35D8C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2A35EA4", Offset = "0x2A35EA4", VA = "0x2A35EA4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2A35FE4", Offset = "0x2A35FE4", VA = "0x2A35FE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2A36174", Offset = "0x2A36174", VA = "0x2A36174")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4D9C", Offset = "0xCB4D9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4D9C", Offset = "0xCB4D9C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB61EC", Offset = "0xCB61EC")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6224", Offset = "0xCB6224")]
			public float horizontalWeight;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB625C", Offset = "0xCB625C")]
			public float verticalWeight;

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x2952E44", Offset = "0x2952E44", VA = "0x2952E44")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2952E54", Offset = "0x2952E54", VA = "0x2952E54")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6144", Offset = "0xCB6144")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB617C", Offset = "0xCB617C")]
		public float spineBend;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB61B4", Offset = "0xCB61B4")]
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

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2A361FC", Offset = "0x2A361FC", VA = "0x2A361FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCA90", Offset = "0xCBCA90")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2A36244", Offset = "0x2A36244", VA = "0x2A36244", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCAC8", Offset = "0xCBCAC8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2A3628C", Offset = "0x2A3628C", VA = "0x2A3628C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCB00", Offset = "0xCBCB00")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2A362D4", Offset = "0x2A362D4", VA = "0x2A362D4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2A36310", Offset = "0x2A36310", VA = "0x2A36310")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2A363A4", Offset = "0x2A363A4", VA = "0x2A363A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2A36620", Offset = "0x2A36620", VA = "0x2A36620")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2A3662C", Offset = "0x2A3662C", VA = "0x2A3662C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2A3640C", Offset = "0x2A3640C", VA = "0x2A3640C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2A36638", Offset = "0x2A36638", VA = "0x2A36638")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2A36954", Offset = "0x2A36954", VA = "0x2A36954")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2A36A64", Offset = "0x2A36A64", VA = "0x2A36A64")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2A36BBC", Offset = "0x2A36BBC", VA = "0x2A36BBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2A36CD0", Offset = "0x2A36CD0", VA = "0x2A36CD0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4DFC", Offset = "0xCB4DFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4DFC", Offset = "0xCB4DFC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6294", Offset = "0xCB6294")]
		public Transform pelvis;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB62CC", Offset = "0xCB62CC")]
		public Transform characterRoot;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB6304", Offset = "0xCB6304")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6304", Offset = "0xCB6304")]
		public float rootRotationWeight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6358", Offset = "0xCB6358")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6390", Offset = "0xCB6390")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2A36D58", Offset = "0x2A36D58", VA = "0x2A36D58", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCB38", Offset = "0xCBCB38")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2A36DA0", Offset = "0x2A36DA0", VA = "0x2A36DA0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCB70", Offset = "0xCBCB70")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2A36DE8", Offset = "0x2A36DE8", VA = "0x2A36DE8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2A36E00", Offset = "0x2A36E00", VA = "0x2A36E00")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2A37034", Offset = "0x2A37034", VA = "0x2A37034")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2A37130", Offset = "0x2A37130", VA = "0x2A37130")]
		private void Update()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2A376E0", Offset = "0x2A376E0", VA = "0x2A376E0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2A37AE8", Offset = "0x2A37AE8", VA = "0x2A37AE8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2A37C74", Offset = "0x2A37C74", VA = "0x2A37C74")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2A37F78", Offset = "0x2A37F78", VA = "0x2A37F78")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2A380C4", Offset = "0x2A380C4", VA = "0x2A380C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2A382AC", Offset = "0x2A382AC", VA = "0x2A382AC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4E5C", Offset = "0xCB4E5C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4E5C", Offset = "0xCB4E5C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000039")]
		public struct Foot
		{
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2952E9C", Offset = "0x2952E9C", VA = "0x2952E9C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB63C8", Offset = "0xCB63C8")]
		public Grounding forelegSolver;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB6400", Offset = "0xCB6400")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6400", Offset = "0xCB6400")]
		public float rootRotationWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6454", Offset = "0xCB6454")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB6454", Offset = "0xCB6454")]
		public float minRootRotation;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB64AC", Offset = "0xCB64AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB64AC", Offset = "0xCB64AC")]
		public float maxRootRotation;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6504", Offset = "0xCB6504")]
		public float rootRotationSpeed;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB653C", Offset = "0xCB653C")]
		public float maxLegOffset;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6574", Offset = "0xCB6574")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB65AC", Offset = "0xCB65AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB65AC", Offset = "0xCB65AC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6600", Offset = "0xCB6600")]
		public Transform characterRoot;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6638", Offset = "0xCB6638")]
		public Transform pelvis;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6670", Offset = "0xCB6670")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB66A8", Offset = "0xCB66A8")]
		public Transform head;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2A38334", Offset = "0x2A38334", VA = "0x2A38334", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCBA8", Offset = "0xCBCBA8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2A3837C", Offset = "0x2A3837C", VA = "0x2A3837C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCBE0", Offset = "0xCBCBE0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2A383C4", Offset = "0x2A383C4", VA = "0x2A383C4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2A383F8", Offset = "0x2A383F8", VA = "0x2A383F8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2A38524", Offset = "0x2A38524", VA = "0x2A38524")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2A38728", Offset = "0x2A38728", VA = "0x2A38728")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2A38790", Offset = "0x2A38790", VA = "0x2A38790")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2A387F4", Offset = "0x2A387F4", VA = "0x2A387F4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2A38B20", Offset = "0x2A38B20", VA = "0x2A38B20")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2A38E64", Offset = "0x2A38E64", VA = "0x2A38E64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2A38F5C", Offset = "0x2A38F5C", VA = "0x2A38F5C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2A39328", Offset = "0x2A39328", VA = "0x2A39328")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2A39944", Offset = "0x2A39944", VA = "0x2A39944")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2A39B14", Offset = "0x2A39B14", VA = "0x2A39B14")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2A39BF0", Offset = "0x2A39BF0", VA = "0x2A39BF0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2A39E38", Offset = "0x2A39E38", VA = "0x2A39E38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2A39E70", Offset = "0x2A39E70", VA = "0x2A39E70")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2A3A050", Offset = "0x2A3A050", VA = "0x2A3A050")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4EBC", Offset = "0xCB4EBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4EBC", Offset = "0xCB4EBC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB66F0", Offset = "0xCB66F0")]
		public VRIK ik;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2A3A150", Offset = "0x2A3A150", VA = "0x2A3A150")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCC18", Offset = "0xCBCC18")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2A3A198", Offset = "0x2A3A198", VA = "0x2A3A198", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCC50", Offset = "0xCBCC50")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2A3A1E0", Offset = "0x2A3A1E0", VA = "0x2A3A1E0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCC88", Offset = "0xCBCC88")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2A3A228", Offset = "0x2A3A228", VA = "0x2A3A228", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2A3A240", Offset = "0x2A3A240", VA = "0x2A3A240")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2A3A2D4", Offset = "0x2A3A2D4", VA = "0x2A3A2D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2A3A334", Offset = "0x2A3A334", VA = "0x2A3A334")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2A3A554", Offset = "0x2A3A554", VA = "0x2A3A554")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2A3A744", Offset = "0x2A3A744", VA = "0x2A3A744")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2A3A7D4", Offset = "0x2A3A7D4", VA = "0x2A3A7D4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2A3A990", Offset = "0x2A3A990", VA = "0x2A3A990")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2A3AAE8", Offset = "0x2A3AAE8", VA = "0x2A3AAE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2A3AC68", Offset = "0x2A3AC68", VA = "0x2A3AC68")]
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
			[Token(Token = "0x4000166")]
			Fastest,
			[Token(Token = "0x4000167")]
			Simple,
			[Token(Token = "0x4000168")]
			Best
		}

		[Token(Token = "0x200003D")]
		public class Leg
		{
			[Token(Token = "0x4000169")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6BD4", Offset = "0xCB6BD4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6BE4", Offset = "0xCB6BE4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6BF4", Offset = "0xCB6BF4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C04", Offset = "0xCB6C04")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C14", Offset = "0xCB6C14")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C24", Offset = "0xCB6C24")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C34", Offset = "0xCB6C34")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C44", Offset = "0xCB6C44")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C54", Offset = "0xCB6C54")]
			private RaycastHit <capsuleHit>k__BackingField;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000020")]
			public bool isGrounded
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x2952EDC", Offset = "0x2952EDC", VA = "0x2952EDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD60", Offset = "0xCBCD60")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x2952EE4", Offset = "0x2952EE4", VA = "0x2952EE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD70", Offset = "0xCBCD70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x2952EF0", Offset = "0x2952EF0", VA = "0x2952EF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD80", Offset = "0xCBCD80")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x2952EFC", Offset = "0x2952EFC", VA = "0x2952EFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD90", Offset = "0xCBCD90")]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public bool initiated
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x2952F08", Offset = "0x2952F08", VA = "0x2952F08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCDA0", Offset = "0xCBCDA0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x2952F10", Offset = "0x2952F10", VA = "0x2952F10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCDB0", Offset = "0xCBCDB0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public float heightFromGround
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x2952F1C", Offset = "0x2952F1C", VA = "0x2952F1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCDC0", Offset = "0xCBCDC0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x2952F24", Offset = "0x2952F24", VA = "0x2952F24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCDD0", Offset = "0xCBCDD0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x2952F2C", Offset = "0x2952F2C", VA = "0x2952F2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCDE0", Offset = "0xCBCDE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x2952F38", Offset = "0x2952F38", VA = "0x2952F38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCDF0", Offset = "0xCBCDF0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public Transform transform
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x2952F44", Offset = "0x2952F44", VA = "0x2952F44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE00", Offset = "0xCBCE00")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x2952F4C", Offset = "0x2952F4C", VA = "0x2952F4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE10", Offset = "0xCBCE10")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public float IKOffset
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x2952F54", Offset = "0x2952F54", VA = "0x2952F54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE20", Offset = "0xCBCE20")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x2952F5C", Offset = "0x2952F5C", VA = "0x2952F5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE30", Offset = "0xCBCE30")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x2952F64", Offset = "0x2952F64", VA = "0x2952F64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE40", Offset = "0xCBCE40")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x2952F7C", Offset = "0x2952F7C", VA = "0x2952F7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE50", Offset = "0xCBCE50")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x2952F9C", Offset = "0x2952F9C", VA = "0x2952F9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE60", Offset = "0xCBCE60")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x2952FB4", Offset = "0x2952FB4", VA = "0x2952FB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE70", Offset = "0xCBCE70")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x2952FD4", Offset = "0x2952FD4", VA = "0x2952FD4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002A")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x2954198", Offset = "0x2954198", VA = "0x2954198")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002B")]
			private float rootYOffset
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x29542FC", Offset = "0x29542FC", VA = "0x29542FC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x295301C", Offset = "0x295301C", VA = "0x295301C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2953030", Offset = "0x2953030", VA = "0x2953030")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x29530A4", Offset = "0x29530A4", VA = "0x29530A4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x29530F0", Offset = "0x29530F0", VA = "0x29530F0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x2953160", Offset = "0x2953160", VA = "0x2953160")]
			public void Process()
			{
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2953E0C", Offset = "0x2953E0C", VA = "0x2953E0C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x29539AC", Offset = "0x29539AC", VA = "0x29539AC")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x295422C", Offset = "0x295422C", VA = "0x295422C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x2953C4C", Offset = "0x2953C4C", VA = "0x2953C4C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x2953CD8", Offset = "0x2953CD8", VA = "0x2953CD8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x295429C", Offset = "0x295429C", VA = "0x295429C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x29541C0", Offset = "0x29541C0", VA = "0x29541C0")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2954390", Offset = "0x2954390", VA = "0x2954390")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x295441C", Offset = "0x295441C", VA = "0x295441C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C64", Offset = "0xCB6C64")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6C74", Offset = "0xCB6C74")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000180")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002C")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001F5")]
				[Address(RVA = "0x2954460", Offset = "0x2954460", VA = "0x2954460")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE80", Offset = "0xCBCE80")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x295446C", Offset = "0x295446C", VA = "0x295446C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCE90", Offset = "0xCBCE90")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public float heightOffset
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0x2954478", Offset = "0x2954478", VA = "0x2954478")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCEA0", Offset = "0xCBCEA0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0x2954480", Offset = "0x2954480", VA = "0x2954480")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCEB0", Offset = "0xCBCEB0")]
				private set
				{
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x2954488", Offset = "0x2954488", VA = "0x2954488")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x29544F8", Offset = "0x29544F8", VA = "0x29544F8")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x2954498", Offset = "0x2954498", VA = "0x2954498")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x2954564", Offset = "0x2954564", VA = "0x2954564")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x2954704", Offset = "0x2954704", VA = "0x2954704")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6728", Offset = "0xCB6728")]
		public LayerMask layers;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6760", Offset = "0xCB6760")]
		public float maxStep;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6798", Offset = "0xCB6798")]
		public float heightOffset;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB67D0", Offset = "0xCB67D0")]
		public float footSpeed;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6808", Offset = "0xCB6808")]
		public float footRadius;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6840", Offset = "0xCB6840")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB688C", Offset = "0xCB688C")]
		public float prediction;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB68C4", Offset = "0xCB68C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB68C4", Offset = "0xCB68C4")]
		public float footRotationWeight;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6918", Offset = "0xCB6918")]
		public float footRotationSpeed;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6950", Offset = "0xCB6950")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB6950", Offset = "0xCB6950")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB69A8", Offset = "0xCB69A8")]
		public bool rotateSolver;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB69E0", Offset = "0xCB69E0")]
		public float pelvisSpeed;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6A18", Offset = "0xCB6A18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB6A18", Offset = "0xCB6A18")]
		public float pelvisDamper;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6A6C", Offset = "0xCB6A6C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6AA4", Offset = "0xCB6AA4")]
		public float liftPelvisWeight;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6ADC", Offset = "0xCB6ADC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6B14", Offset = "0xCB6B14")]
		public bool overstepFallsDown;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6B4C", Offset = "0xCB6B4C")]
		public Quality quality;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6B84", Offset = "0xCB6B84")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6B94", Offset = "0xCB6B94")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6BA4", Offset = "0xCB6BA4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6BB4", Offset = "0xCB6BB4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB6BC4", Offset = "0xCB6BC4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000018")]
		public Leg[] legs
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2A3ACC0", Offset = "0x2A3ACC0", VA = "0x2A3ACC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCCC0", Offset = "0xCBCCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2A3ACC8", Offset = "0x2A3ACC8", VA = "0x2A3ACC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCCD0", Offset = "0xCBCCD0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2A3ACD0", Offset = "0x2A3ACD0", VA = "0x2A3ACD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCCE0", Offset = "0xCBCCE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2A3ACD8", Offset = "0x2A3ACD8", VA = "0x2A3ACD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCCF0", Offset = "0xCBCCF0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2A3ACE0", Offset = "0x2A3ACE0", VA = "0x2A3ACE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD00", Offset = "0xCBCD00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2A3ACE8", Offset = "0x2A3ACE8", VA = "0x2A3ACE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD10", Offset = "0xCBCD10")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Transform root
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2A3ACF4", Offset = "0x2A3ACF4", VA = "0x2A3ACF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD20", Offset = "0xCBCD20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2A3ACFC", Offset = "0x2A3ACFC", VA = "0x2A3ACFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD30", Offset = "0xCBCD30")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2A3AD04", Offset = "0x2A3AD04", VA = "0x2A3AD04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD40", Offset = "0xCBCD40")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x2A3AD1C", Offset = "0x2A3AD1C", VA = "0x2A3AD1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBCD50", Offset = "0xCBCD50")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2A3AD3C", Offset = "0x2A3AD3C", VA = "0x2A3AD3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 up
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2A35E60", Offset = "0x2A35E60", VA = "0x2A35E60")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001F")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2A3B0FC", Offset = "0x2A3B0FC", VA = "0x2A3B0FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2A3AD90", Offset = "0x2A3AD90", VA = "0x2A3AD90")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2A3AFDC", Offset = "0x2A3AFDC", VA = "0x2A3AFDC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2A3542C", Offset = "0x2A3542C", VA = "0x2A3542C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2A35B1C", Offset = "0x2A35B1C", VA = "0x2A35B1C")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2A37580", Offset = "0x2A37580", VA = "0x2A37580")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2A34FD4", Offset = "0x2A34FD4", VA = "0x2A34FD4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2A3B0E4", Offset = "0x2A3B0E4", VA = "0x2A3B0E4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2A3B17C", Offset = "0x2A3B17C", VA = "0x2A3B17C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2A3B20C", Offset = "0x2A3B20C", VA = "0x2A3B20C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2A3B2C8", Offset = "0x2A3B2C8", VA = "0x2A3B2C8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2A34EB4", Offset = "0x2A34EB4", VA = "0x2A34EB4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4F1C", Offset = "0xCB4F1C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4F1C", Offset = "0xCB4F1C")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x29A5C68", Offset = "0x29A5C68", VA = "0x29A5C68", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCEC0", Offset = "0xCBCEC0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x29A5CB0", Offset = "0x29A5CB0", VA = "0x29A5CB0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCEF8", Offset = "0xCBCEF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x29A5CF8", Offset = "0x29A5CF8", VA = "0x29A5CF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCF30", Offset = "0xCBCF30")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x29A5D40", Offset = "0x29A5D40", VA = "0x29A5D40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCF68", Offset = "0xCBCF68")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x29A5D88", Offset = "0x29A5D88", VA = "0x29A5D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCFA0", Offset = "0xCBCFA0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x29A5DD0", Offset = "0x29A5DD0", VA = "0x29A5DD0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x29A5DD8", Offset = "0x29A5DD8", VA = "0x29A5DD8")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4F7C", Offset = "0xCB4F7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4F7C", Offset = "0xCB4F7C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x29A6140", Offset = "0x29A6140", VA = "0x29A6140", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBCFD8", Offset = "0xCBCFD8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x29A6188", Offset = "0x29A6188", VA = "0x29A6188", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD010", Offset = "0xCBD010")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x29A61D0", Offset = "0x29A61D0", VA = "0x29A61D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD048", Offset = "0xCBD048")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x29A6218", Offset = "0x29A6218", VA = "0x29A6218")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD080", Offset = "0xCBD080")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x29A6260", Offset = "0x29A6260", VA = "0x29A6260", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x29A6268", Offset = "0x29A6268", VA = "0x29A6268")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB4FDC", Offset = "0xCB4FDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB4FDC", Offset = "0xCB4FDC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x29B2374", Offset = "0x29B2374", VA = "0x29B2374", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD0B8", Offset = "0xCBD0B8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x29B23BC", Offset = "0x29B23BC", VA = "0x29B23BC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD0F0", Offset = "0xCBD0F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x29B2404", Offset = "0x29B2404", VA = "0x29B2404")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD128", Offset = "0xCBD128")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x29B244C", Offset = "0x29B244C", VA = "0x29B244C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD160", Offset = "0xCBD160")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x29B2494", Offset = "0x29B2494", VA = "0x29B2494", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x29B249C", Offset = "0x29B249C", VA = "0x29B249C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB503C", Offset = "0xCB503C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB503C", Offset = "0xCB503C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x29B3C00", Offset = "0x29B3C00", VA = "0x29B3C00", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD198", Offset = "0xCBD198")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x29B3C48", Offset = "0x29B3C48", VA = "0x29B3C48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD1D0", Offset = "0xCBD1D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x29B3C90", Offset = "0x29B3C90", VA = "0x29B3C90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD208", Offset = "0xCBD208")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x29B3CD8", Offset = "0x29B3CD8", VA = "0x29B3CD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD240", Offset = "0xCBD240")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x29B3D20", Offset = "0x29B3D20", VA = "0x29B3D20", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x29B3D28", Offset = "0x29B3D28", VA = "0x29B3D28")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB509C", Offset = "0xCB509C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB509C", Offset = "0xCB509C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x29B424C", Offset = "0x29B424C", VA = "0x29B424C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD278", Offset = "0xCBD278")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x29B4294", Offset = "0x29B4294", VA = "0x29B4294", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD2B0", Offset = "0xCBD2B0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x29B42DC", Offset = "0x29B42DC", VA = "0x29B42DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD2E8", Offset = "0xCBD2E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x29B4324", Offset = "0x29B4324", VA = "0x29B4324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD320", Offset = "0xCBD320")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x29B436C", Offset = "0x29B436C", VA = "0x29B436C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x29B4374", Offset = "0x29B4374", VA = "0x29B4374")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB50FC", Offset = "0xCB50FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB50FC", Offset = "0xCB50FC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2A33710", Offset = "0x2A33710", VA = "0x2A33710", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD358", Offset = "0xCBD358")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2A33758", Offset = "0x2A33758", VA = "0x2A33758", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD390", Offset = "0xCBD390")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2A337A0", Offset = "0x2A337A0", VA = "0x2A337A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD3C8", Offset = "0xCBD3C8")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2A337E8", Offset = "0x2A337E8", VA = "0x2A337E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD400", Offset = "0xCBD400")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2A33830", Offset = "0x2A33830", VA = "0x2A33830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD438", Offset = "0xCBD438")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2A33878", Offset = "0x2A33878", VA = "0x2A33878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD470", Offset = "0xCBD470")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2A338C0", Offset = "0x2A338C0", VA = "0x2A338C0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2A338E4", Offset = "0x2A338E4", VA = "0x2A338E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2A338EC", Offset = "0x2A338EC", VA = "0x2A338EC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2A33AC8", Offset = "0x2A33AC8", VA = "0x2A33AC8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2A33D5C", Offset = "0x2A33D5C", VA = "0x2A33D5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD4A8", Offset = "0xCBD4A8")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2A33D7C", Offset = "0x2A33D7C", VA = "0x2A33D7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD4E0", Offset = "0xCBD4E0")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2A33E54", Offset = "0x2A33E54", VA = "0x2A33E54")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600022A")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2A3DD38", Offset = "0x2A3DD38", VA = "0x2A3DD38", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2A3DDBC", Offset = "0x2A3DDBC", VA = "0x2A3DDBC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2A3DE2C", Offset = "0x2A3DE2C", VA = "0x2A3DE2C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600022E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600022F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2A33EE4", Offset = "0x2A33EE4", VA = "0x2A33EE4")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6C84", Offset = "0xCB6C84")]
		public IK[] IKComponents;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6CBC", Offset = "0xCB6CBC")]
		public Animator animator;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700002E")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2A403A8", Offset = "0x2A403A8", VA = "0x2A403A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2A40440", Offset = "0x2A40440", VA = "0x2A40440")]
		private void Start()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2A404B0", Offset = "0x2A404B0", VA = "0x2A404B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2A4056C", Offset = "0x2A4056C", VA = "0x2A4056C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2A405A8", Offset = "0x2A405A8", VA = "0x2A405A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2A404E4", Offset = "0x2A404E4", VA = "0x2A404E4")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2A40634", Offset = "0x2A40634", VA = "0x2A40634")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB515C", Offset = "0xCB515C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB515C", Offset = "0xCB515C")]
	public class LegIK : IK
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x29F9DC4", Offset = "0x29F9DC4", VA = "0x29F9DC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD518", Offset = "0xCBD518")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x29F9E0C", Offset = "0x29F9E0C", VA = "0x29F9E0C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD550", Offset = "0xCBD550")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x29F9E54", Offset = "0x29F9E54", VA = "0x29F9E54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD588", Offset = "0xCBD588")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x29F9E9C", Offset = "0x29F9E9C", VA = "0x29F9E9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD5C0", Offset = "0xCBD5C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x29F9EE4", Offset = "0x29F9EE4", VA = "0x29F9EE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x29F9EEC", Offset = "0x29F9EEC", VA = "0x29F9EEC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB51BC", Offset = "0xCB51BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB51BC", Offset = "0xCB51BC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x29F9F50", Offset = "0x29F9F50", VA = "0x29F9F50", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD5F8", Offset = "0xCBD5F8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x29F9F98", Offset = "0x29F9F98", VA = "0x29F9F98", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD630", Offset = "0xCBD630")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x29F9FE0", Offset = "0x29F9FE0", VA = "0x29F9FE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD668", Offset = "0xCBD668")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x29FA028", Offset = "0x29FA028", VA = "0x29FA028")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD6A0", Offset = "0xCBD6A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x29FA070", Offset = "0x29FA070", VA = "0x29FA070", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x29FA078", Offset = "0x29FA078", VA = "0x29FA078")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB521C", Offset = "0xCB521C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB521C", Offset = "0xCB521C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x29FAA64", Offset = "0x29FAA64", VA = "0x29FAA64", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD6D8", Offset = "0xCBD6D8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x29FAAAC", Offset = "0x29FAAAC", VA = "0x29FAAAC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD710", Offset = "0xCBD710")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x29FAAF4", Offset = "0x29FAAF4", VA = "0x29FAAF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD748", Offset = "0xCBD748")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x29FAB3C", Offset = "0x29FAB3C", VA = "0x29FAB3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD780", Offset = "0xCBD780")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x29FAB84", Offset = "0x29FAB84", VA = "0x29FAB84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x29FAB8C", Offset = "0x29FAB8C", VA = "0x29FAB8C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB527C", Offset = "0xCB527C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB527C", Offset = "0xCB527C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x294A730", Offset = "0x294A730", VA = "0x294A730", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD7B8", Offset = "0xCBD7B8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x294A778", Offset = "0x294A778", VA = "0x294A778", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD7F0", Offset = "0xCBD7F0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x294A7C0", Offset = "0x294A7C0", VA = "0x294A7C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD828", Offset = "0xCBD828")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x294A808", Offset = "0x294A808", VA = "0x294A808")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD860", Offset = "0xCBD860")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x294A850", Offset = "0x294A850", VA = "0x294A850", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x294A858", Offset = "0x294A858", VA = "0x294A858")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB52DC", Offset = "0xCB52DC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200004C")]
		public class References
		{
			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6DA8", Offset = "0xCB6DA8")]
			public Transform chest;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6DE0", Offset = "0xCB6DE0")]
			public Transform neck;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6E18", Offset = "0xCB6E18")]
			public Transform leftShoulder;

			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6E50", Offset = "0xCB6E50")]
			public Transform rightShoulder;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6E88", Offset = "0xCB6E88")]
			public Transform leftThigh;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6EC0", Offset = "0xCB6EC0")]
			public Transform leftCalf;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6EF8", Offset = "0xCB6EF8")]
			public Transform leftFoot;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6F30", Offset = "0xCB6F30")]
			public Transform leftToes;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6F68", Offset = "0xCB6F68")]
			public Transform rightThigh;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6FA0", Offset = "0xCB6FA0")]
			public Transform rightCalf;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6FD8", Offset = "0xCB6FD8")]
			public Transform rightFoot;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7010", Offset = "0xCB7010")]
			public Transform rightToes;

			[Token(Token = "0x1700002F")]
			public bool isFilled
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x2DFFF28", Offset = "0x2DFFF28", VA = "0x2DFFF28")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000030")]
			public bool isEmpty
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x2E003A0", Offset = "0x2E003A0", VA = "0x2E003A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2DFFAE0", Offset = "0x2DFFAE0", VA = "0x2DFFAE0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2E00818", Offset = "0x2E00818", VA = "0x2E00818")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2E00BB4", Offset = "0x2E00BB4", VA = "0x2E00BB4")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xCB6CF4", Offset = "0xCB6CF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6CF4", Offset = "0xCB6CF4")]
		public References references;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB6D70", Offset = "0xCB6D70")]
		public IKSolverVR solver;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x294D458", Offset = "0x294D458", VA = "0x294D458", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD898", Offset = "0xCBD898")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x294D4A0", Offset = "0x294D4A0", VA = "0x294D4A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD8D0", Offset = "0xCBD8D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x294D4E8", Offset = "0x294D4E8", VA = "0x294D4E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD908", Offset = "0xCBD908")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x294D530", Offset = "0x294D530", VA = "0x294D530")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD940", Offset = "0xCBD940")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x294D55C", Offset = "0x294D55C", VA = "0x294D55C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBD978", Offset = "0xCBD978")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x294D584", Offset = "0x294D584", VA = "0x294D584", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x294D58C", Offset = "0x294D58C", VA = "0x294D58C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x294D60C", Offset = "0x294D60C", VA = "0x294D60C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x294D778", Offset = "0x294D778", VA = "0x294D778")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7048", Offset = "0xCB7048")]
		public float pull;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7060", Offset = "0xCB7060")]
		public float pin;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x29B3D8C", Offset = "0x29B3D8C", VA = "0x29B3D8C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x29B3E5C", Offset = "0x29B3E5C", VA = "0x29B3E5C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x29B3E7C", Offset = "0x29B3E7C", VA = "0x29B3E7C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x29B40F0", Offset = "0x29B40F0", VA = "0x29B40F0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x29B3F50", Offset = "0x29B3F50", VA = "0x29B3F50")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x29B41E8", Offset = "0x29B41E8", VA = "0x29B41E8")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x29B43D8", Offset = "0x29B43D8", VA = "0x29B43D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x29B483C", Offset = "0x29B483C", VA = "0x29B483C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x29B49F8", Offset = "0x29B49F8", VA = "0x29B49F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x29B4B04", Offset = "0x29B4B04", VA = "0x29B4B04")]
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
			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB76B8", Offset = "0xCB76B8")]
			public Transform transform;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB76F0", Offset = "0xCB76F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB76F0", Offset = "0xCB76F0")]
			public float weight;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x2952420", Offset = "0x2952420", VA = "0x2952420")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x295245C", Offset = "0x295245C", VA = "0x295245C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x29524B4", Offset = "0x29524B4", VA = "0x29524B4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x29524EC", Offset = "0x29524EC", VA = "0x29524EC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7078", Offset = "0xCB7078")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCB70B0", Offset = "0xCB70B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB70B0", Offset = "0xCB70B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB70B0", Offset = "0xCB70B0")]
		public float positionWeight;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7128", Offset = "0xCB7128")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7128", Offset = "0xCB7128")]
		public float bodyWeight;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB717C", Offset = "0xCB717C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB717C", Offset = "0xCB717C")]
		public float thighWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB71D0", Offset = "0xCB71D0")]
		public bool handsPullBody;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCB7208", Offset = "0xCB7208")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7208", Offset = "0xCB7208")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7208", Offset = "0xCB7208")]
		public float rotationWeight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7280", Offset = "0xCB7280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7280", Offset = "0xCB7280")]
		public float bodyClampWeight;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB72D4", Offset = "0xCB72D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB72D4", Offset = "0xCB72D4")]
		public float headClampWeight;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7328", Offset = "0xCB7328")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7328", Offset = "0xCB7328")]
		public float bendWeight;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB737C", Offset = "0xCB737C")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCB73B4", Offset = "0xCB73B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB73B4", Offset = "0xCB73B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB73B4", Offset = "0xCB73B4")]
		public float CCDWeight;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB742C", Offset = "0xCB742C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB742C", Offset = "0xCB742C")]
		public float roll;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7480", Offset = "0xCB7480")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7480", Offset = "0xCB7480")]
		public float damper;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB74D8", Offset = "0xCB74D8")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCB7510", Offset = "0xCB7510")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7510", Offset = "0xCB7510")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7510", Offset = "0xCB7510")]
		public float postStretchWeight;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7588", Offset = "0xCB7588")]
		public float maxStretch;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB75C0", Offset = "0xCB75C0")]
		public float stretchDamper;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB75F8", Offset = "0xCB75F8")]
		public bool fixHead;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7630", Offset = "0xCB7630")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xCB7668", Offset = "0xCB7668")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB76A0", Offset = "0xCB76A0")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x29B4B0C", Offset = "0x29B4B0C", VA = "0x29B4B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x29B4E40", Offset = "0x29B4E40", VA = "0x29B4E40")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x29B52E0", Offset = "0x29B52E0", VA = "0x29B52E0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x29B56AC", Offset = "0x29B56AC", VA = "0x29B56AC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x29B5E38", Offset = "0x29B5E38", VA = "0x29B5E38")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x29B6118", Offset = "0x29B6118", VA = "0x29B6118")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x29B641C", Offset = "0x29B641C", VA = "0x29B641C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x29B6BF0", Offset = "0x29B6BF0", VA = "0x29B6BF0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x29B5C1C", Offset = "0x29B5C1C", VA = "0x29B5C1C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x29B6DB8", Offset = "0x29B6DB8", VA = "0x29B6DB8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x29B6B08", Offset = "0x29B6B08", VA = "0x29B6B08")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x29B6A3C", Offset = "0x29B6A3C", VA = "0x29B6A3C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x29B703C", Offset = "0x29B703C", VA = "0x29B703C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x29B730C", Offset = "0x29B730C", VA = "0x29B730C")]
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
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB77DC", Offset = "0xCB77DC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB77EC", Offset = "0xCB77EC")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000031")]
			public float nominalDistance
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0x2952514", Offset = "0x2952514", VA = "0x2952514")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBD9B0", Offset = "0xCBD9B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x295251C", Offset = "0x295251C", VA = "0x295251C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBD9C0", Offset = "0xCBD9C0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public bool isRigid
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0x2952524", Offset = "0x2952524", VA = "0x2952524")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBD9D0", Offset = "0xCBD9D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000291")]
				[Address(RVA = "0x295252C", Offset = "0x295252C", VA = "0x295252C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBD9E0", Offset = "0xCBD9E0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x2952538", Offset = "0x2952538", VA = "0x2952538")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x2952584", Offset = "0x2952584", VA = "0x2952584")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x29525DC", Offset = "0x29525DC", VA = "0x29525DC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2952780", Offset = "0x2952780", VA = "0x2952780")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000053")]
		public enum Smoothing
		{
			[Token(Token = "0x400020A")]
			None,
			[Token(Token = "0x400020B")]
			Exponential,
			[Token(Token = "0x400020C")]
			Cubic
		}

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7744", Offset = "0xCB7744")]
		public float pin;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB775C", Offset = "0xCB775C")]
		public float pull;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7774", Offset = "0xCB7774")]
		public float push;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB778C", Offset = "0xCB778C")]
		public float pushParent;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB77A4", Offset = "0xCB77A4")]
		public float reach;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001FE")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x29B7488", Offset = "0x29B7488", VA = "0x29B7488")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x29B7574", Offset = "0x29B7574", VA = "0x29B7574")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x29B76A0", Offset = "0x29B76A0", VA = "0x29B76A0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x29B77CC", Offset = "0x29B77CC", VA = "0x29B77CC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x29B78A4", Offset = "0x29B78A4", VA = "0x29B78A4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x29B79BC", Offset = "0x29B79BC", VA = "0x29B79BC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x29B8038", Offset = "0x29B8038", VA = "0x29B8038")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x29B7B4C", Offset = "0x29B7B4C", VA = "0x29B7B4C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x29B8428", Offset = "0x29B8428", VA = "0x29B8428")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x29B8688", Offset = "0x29B8688", VA = "0x29B8688")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x29B88F4", Offset = "0x29B88F4", VA = "0x29B88F4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x29B8C98", Offset = "0x29B8C98", VA = "0x29B8C98")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x29B912C", Offset = "0x29B912C", VA = "0x29B912C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x29B9350", Offset = "0x29B9350", VA = "0x29B9350")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x29B90BC", Offset = "0x29B90BC", VA = "0x29B90BC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x29B8B24", Offset = "0x29B8B24", VA = "0x29B8B24")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x29B9040", Offset = "0x29B9040", VA = "0x29B9040")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x29B9438", Offset = "0x29B9438", VA = "0x29B9438")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x29B8F60", Offset = "0x29B8F60", VA = "0x29B8F60")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x29B9238", Offset = "0x29B9238", VA = "0x29B9238")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB77FC", Offset = "0xCB77FC")]
		public float weight;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB7814", Offset = "0xCB7814")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000033")]
		public bool initiated
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x2A3E074", Offset = "0x2A3E074", VA = "0x2A3E074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBD9F0", Offset = "0xCBD9F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2A3E07C", Offset = "0x2A3E07C", VA = "0x2A3E07C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA00", Offset = "0xCBDA00")]
			private set
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x2A3DE8C", Offset = "0x2A3DE8C", VA = "0x2A3DE8C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2A3E088", Offset = "0x2A3E088", VA = "0x2A3E088")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2A3E0C8", Offset = "0x2A3E0C8", VA = "0x2A3E0C8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2A3E128", Offset = "0x2A3E128", VA = "0x2A3E128")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2A3E134", Offset = "0x2A3E134", VA = "0x2A3E134")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2A3E448", Offset = "0x2A3E448", VA = "0x2A3E448")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2A3E638", Offset = "0x2A3E638", VA = "0x2A3E638")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2A3E984", Offset = "0x2A3E984", VA = "0x2A3E984")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2A3E2F8", Offset = "0x2A3E2F8", VA = "0x2A3E2F8")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2A3E3A0", Offset = "0x2A3E3A0", VA = "0x2A3E3A0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKEffector
	{
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7824", Offset = "0xCB7824")]
		public float positionWeight;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB783C", Offset = "0xCB783C")]
		public float rotationWeight;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB7854", Offset = "0xCB7854")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7864", Offset = "0xCB7864")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000034")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x2A3EE20", Offset = "0x2A3EE20", VA = "0x2A3EE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA10", Offset = "0xCBDA10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x2A3EE28", Offset = "0x2A3EE28", VA = "0x2A3EE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA20", Offset = "0xCBDA20")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2A3EDB8", Offset = "0x2A3EDB8", VA = "0x2A3EDB8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2A3EE34", Offset = "0x2A3EE34", VA = "0x2A3EE34")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2A3EEC4", Offset = "0x2A3EEC4", VA = "0x2A3EEC4")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2A3EFD8", Offset = "0x2A3EFD8", VA = "0x2A3EFD8")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2A3F108", Offset = "0x2A3F108", VA = "0x2A3F108")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2A3F424", Offset = "0x2A3F424", VA = "0x2A3F424")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2A3F6B8", Offset = "0x2A3F6B8", VA = "0x2A3F6B8")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2A3F78C", Offset = "0x2A3F78C", VA = "0x2A3F78C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2A3F834", Offset = "0x2A3F834", VA = "0x2A3F834")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2A3FD70", Offset = "0x2A3FD70", VA = "0x2A3FD70")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2A3FD9C", Offset = "0x2A3FD9C", VA = "0x2A3FD9C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2A3FEFC", Offset = "0x2A3FEFC", VA = "0x2A3FEFC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2A40188", Offset = "0x2A40188", VA = "0x2A40188")]
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
			[Token(Token = "0x400023F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000243")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000035")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002B7")]
				[Address(RVA = "0x2955A6C", Offset = "0x2955A6C", VA = "0x2955A6C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000036")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002BA")]
				[Address(RVA = "0x2955B48", Offset = "0x2955B48", VA = "0x2955B48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000037")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x2955EEC", Offset = "0x2955EEC", VA = "0x2955EEC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2955A40", Offset = "0x2955A40", VA = "0x2955A40")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2955AA8", Offset = "0x2955AA8", VA = "0x2955AA8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2955AF8", Offset = "0x2955AF8", VA = "0x2955AF8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2955B58", Offset = "0x2955B58", VA = "0x2955B58")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2955BE0", Offset = "0x2955BE0", VA = "0x2955BE0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2955BE8", Offset = "0x2955BE8", VA = "0x2955BE8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2955CC0", Offset = "0x2955CC0", VA = "0x2955CC0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2955D38", Offset = "0x2955D38", VA = "0x2955D38")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2955DD0", Offset = "0x2955DD0", VA = "0x2955DD0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x295602C", Offset = "0x295602C", VA = "0x295602C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2956064", Offset = "0x2956064", VA = "0x2956064")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x295609C", Offset = "0x295609C", VA = "0x295609C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x29560C4", Offset = "0x29560C4", VA = "0x29560C4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x29561B0", Offset = "0x29561B0", VA = "0x29561B0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x295633C", Offset = "0x295633C", VA = "0x295633C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x295636C", Offset = "0x295636C", VA = "0x295636C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x2956434", Offset = "0x2956434", VA = "0x2956434")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x29564A4", Offset = "0x29564A4", VA = "0x29564A4")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x29565F4", Offset = "0x29565F4", VA = "0x29565F4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2956744", Offset = "0x2956744", VA = "0x2956744")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x29567C4", Offset = "0x29567C4", VA = "0x29567C4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x295622C", Offset = "0x295622C", VA = "0x295622C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x29568FC", Offset = "0x29568FC", VA = "0x29568FC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2A4063C", Offset = "0x2A4063C", VA = "0x2A4063C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2A40644", Offset = "0x2A40644", VA = "0x2A40644", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2A40648", Offset = "0x2A40648", VA = "0x2A40648")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2A4078C", Offset = "0x2A4078C", VA = "0x2A4078C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2A407FC", Offset = "0x2A407FC", VA = "0x2A407FC")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB787C", Offset = "0xCB787C")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2A40804", Offset = "0x2A40804", VA = "0x2A40804", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2A408AC", Offset = "0x2A408AC", VA = "0x2A408AC")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x2A40918", Offset = "0x2A40918", VA = "0x2A40918")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x2A40998", Offset = "0x2A40998", VA = "0x2A40998")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2A409B4", Offset = "0x2A409B4", VA = "0x2A409B4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x2A409D4", Offset = "0x2A409D4", VA = "0x2A409D4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2A40A5C", Offset = "0x2A40A5C", VA = "0x2A40A5C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2A40A78", Offset = "0x2A40A78", VA = "0x2A40A78")]
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
			[Token(Token = "0x4000264")]
			Parent,
			[Token(Token = "0x4000265")]
			Bone1,
			[Token(Token = "0x4000266")]
			Bone2,
			[Token(Token = "0x4000267")]
			Bone3
		}

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7894", Offset = "0xCB7894")]
		public float maintainRotationWeight;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB78AC", Offset = "0xCB78AC")]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2A40AA0", Offset = "0x2A40AA0", VA = "0x2A40AA0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2A40B24", Offset = "0x2A40B24", VA = "0x2A40B24")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2A40C00", Offset = "0x2A40C00", VA = "0x2A40C00")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2A40E24", Offset = "0x2A40E24", VA = "0x2A40E24")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2A40EE8", Offset = "0x2A40EE8", VA = "0x2A40EE8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2A40FD8", Offset = "0x2A40FD8", VA = "0x2A40FD8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2A40FE4", Offset = "0x2A40FE4", VA = "0x2A40FE4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2A41098", Offset = "0x2A41098", VA = "0x2A41098")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2A4115C", Offset = "0x2A4115C", VA = "0x2A4115C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2A4139C", Offset = "0x2A4139C", VA = "0x2A4139C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2A41410", Offset = "0x2A41410", VA = "0x2A41410")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB78C4", Offset = "0xCB78C4")]
		public int iterations;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB78DC", Offset = "0xCB78DC")]
		public float twistWeight;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2A41590", Offset = "0x2A41590", VA = "0x2A41590", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2A418F4", Offset = "0x2A418F4", VA = "0x2A418F4")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2A419D8", Offset = "0x2A419D8", VA = "0x2A419D8")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x2A41AF0", Offset = "0x2A41AF0", VA = "0x2A41AF0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2A41B00", Offset = "0x2A41B00", VA = "0x2A41B00")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2A41B6C", Offset = "0x2A41B6C", VA = "0x2A41B6C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2A41BF0", Offset = "0x2A41BF0", VA = "0x2A41BF0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2A421C8", Offset = "0x2A421C8", VA = "0x2A421C8")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x2A42200", Offset = "0x2A42200", VA = "0x2A42200")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2A42484", Offset = "0x2A42484", VA = "0x2A42484")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2A4278C", Offset = "0x2A4278C", VA = "0x2A4278C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2A42878", Offset = "0x2A42878", VA = "0x2A42878")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2A42940", Offset = "0x2A42940", VA = "0x2A42940")]
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
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB79B0", Offset = "0xCB79B0")]
			public float weight;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2957458", Offset = "0x2957458", VA = "0x2957458")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x29574A8", Offset = "0x29574A8", VA = "0x29574A8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2957548", Offset = "0x2957548", VA = "0x2957548")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2957580", Offset = "0x2957580", VA = "0x2957580")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x29575B8", Offset = "0x29575B8", VA = "0x29575B8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2957608", Offset = "0x2957608", VA = "0x2957608")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2956FE8", Offset = "0x2956FE8", VA = "0x2956FE8")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public class Bone : Point
		{
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000039")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x2956918", Offset = "0x2956918", VA = "0x2956918")]
				get
				{
					return null;
				}
				[Token(Token = "0x600030E")]
				[Address(RVA = "0x2956A14", Offset = "0x2956A14", VA = "0x2956A14")]
				set
				{
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x2956A98", Offset = "0x2956A98", VA = "0x2956A98")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x2956C48", Offset = "0x2956C48", VA = "0x2956C48")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2956E1C", Offset = "0x2956E1C", VA = "0x2956E1C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2956F7C", Offset = "0x2956F7C", VA = "0x2956F7C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x2956FA4", Offset = "0x2956FA4", VA = "0x2956FA4")]
			public Bone()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x2957024", Offset = "0x2957024", VA = "0x2957024")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2957074", Offset = "0x2957074", VA = "0x2957074")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class Node : Point
		{
			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x29573F4", Offset = "0x29573F4", VA = "0x29573F4")]
			public Node()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x29573F8", Offset = "0x29573F8", VA = "0x29573F8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2957420", Offset = "0x2957420", VA = "0x2957420")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000060")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000061")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7914", Offset = "0xCB7914")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7914", Offset = "0xCB7914")]
		public float IKPositionWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB7968", Offset = "0xCB7968")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000038")]
		public bool initiated
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x2A42C78", Offset = "0x2A42C78", VA = "0x2A42C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA30", Offset = "0xCBDA30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x2A42C80", Offset = "0x2A42C80", VA = "0x2A42C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA40", Offset = "0xCBDA40")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2A42BA8", Offset = "0x2A42BA8", VA = "0x2A42BA8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2A325AC", Offset = "0x2A325AC", VA = "0x2A325AC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2A32D44", Offset = "0x2A32D44", VA = "0x2A32D44")]
		public void Update()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2A42C20", Offset = "0x2A42C20", VA = "0x2A42C20", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2A42C2C", Offset = "0x2A42C2C", VA = "0x2A42C2C")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2A42C38", Offset = "0x2A42C38", VA = "0x2A42C38")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2A42C40", Offset = "0x2A42C40", VA = "0x2A42C40")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2A42C70", Offset = "0x2A42C70", VA = "0x2A42C70")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60002FC")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60002FD")]
		public abstract void FixTransforms();

		[Token(Token = "0x60002FE")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60002FF")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000300")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2A42C8C", Offset = "0x2A42C8C", VA = "0x2A42C8C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x2A42CA4", Offset = "0x2A42CA4", VA = "0x2A42CA4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2A42DDC", Offset = "0x2A42DDC", VA = "0x2A42DDC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x2A42E84", Offset = "0x2A42E84", VA = "0x2A42E84")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2A4310C", Offset = "0x2A4310C", VA = "0x2A4310C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB79C8", Offset = "0xCB79C8")]
		public float poleWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB79E0", Offset = "0xCB79E0")]
		public float clampWeight;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB79F8", Offset = "0xCB79F8")]
		public int clampSmoothing;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003A")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2977384", Offset = "0x2977384", VA = "0x2977384")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x29773C0", Offset = "0x29773C0", VA = "0x29773C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003C")]
		protected override int minBones
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x2977E4C", Offset = "0x2977E4C", VA = "0x2977E4C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2978230", Offset = "0x2978230", VA = "0x2978230", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2977308", Offset = "0x2977308", VA = "0x2977308")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x29773FC", Offset = "0x29773FC", VA = "0x29773FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x297761C", Offset = "0x297761C", VA = "0x297761C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x2977D98", Offset = "0x2977D98", VA = "0x2977D98")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2977B28", Offset = "0x2977B28", VA = "0x2977B28")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x2977E54", Offset = "0x2977E54", VA = "0x2977E54")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x29782A4", Offset = "0x29782A4", VA = "0x29782A4")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7A10", Offset = "0xCB7A10")]
		public float IKRotationWeight;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x2978360", Offset = "0x2978360", VA = "0x2978360", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2978700", Offset = "0x2978700", VA = "0x2978700")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2978770", Offset = "0x2978770", VA = "0x2978770", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x29788C8", Offset = "0x29788C8", VA = "0x29788C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2978A5C", Offset = "0x2978A5C", VA = "0x2978A5C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2978AB8", Offset = "0x2978AB8", VA = "0x2978AB8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2978B28", Offset = "0x2978B28", VA = "0x2978B28", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2978E98", Offset = "0x2978E98", VA = "0x2978E98", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2978EC4", Offset = "0x2978EC4", VA = "0x2978EC4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2978B8C", Offset = "0x2978B8C", VA = "0x2978B8C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2978F34", Offset = "0x2978F34", VA = "0x2978F34")]
		private void Write()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x29790C0", Offset = "0x29790C0", VA = "0x29790C0")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2979218", Offset = "0x2979218", VA = "0x2979218")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x29792C8", Offset = "0x29792C8", VA = "0x29792C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x29797C0", Offset = "0x29797C0", VA = "0x29797C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2979DB8", Offset = "0x2979DB8", VA = "0x2979DB8")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x297A394", Offset = "0x297A394", VA = "0x297A394")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700003E")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x297B2C0", Offset = "0x297B2C0", VA = "0x297B2C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x297A398", Offset = "0x297A398", VA = "0x297A398")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x297A958", Offset = "0x297A958", VA = "0x297A958")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x297AA94", Offset = "0x297AA94", VA = "0x297AA94", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x297AB28", Offset = "0x297AB28", VA = "0x297AB28", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x297B000", Offset = "0x297B000", VA = "0x297B000", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x297B2C8", Offset = "0x297B2C8", VA = "0x297B2C8")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x297A470", Offset = "0x297A470", VA = "0x297A470")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x297AA40", Offset = "0x297AA40", VA = "0x297AA40")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x297B264", Offset = "0x297B264", VA = "0x297B264")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x297A7CC", Offset = "0x297A7CC", VA = "0x297A7CC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x297B918", Offset = "0x297B918", VA = "0x297B918")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x297B98C", Offset = "0x297B98C", VA = "0x297B98C")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x297BA54", Offset = "0x297BA54", VA = "0x297BA54")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x297BB04", Offset = "0x297BB04", VA = "0x297BB04")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x297ADB0", Offset = "0x297ADB0", VA = "0x297ADB0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x297AED8", Offset = "0x297AED8", VA = "0x297AED8")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x297BC08", Offset = "0x297BC08", VA = "0x297BC08")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x297B4E8", Offset = "0x297B4E8", VA = "0x297B4E8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x297AA30", Offset = "0x297AA30", VA = "0x297AA30")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x297C198", Offset = "0x297C198", VA = "0x297C198")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x297BD4C", Offset = "0x297BD4C", VA = "0x297BD4C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x297B344", Offset = "0x297B344", VA = "0x297B344")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x297B424", Offset = "0x297B424", VA = "0x297B424")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x297C264", Offset = "0x297C264", VA = "0x297C264")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7A28", Offset = "0xCB7A28")]
		public float rootPin;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x297C2E0", Offset = "0x297C2E0", VA = "0x297C2E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x297C920", Offset = "0x297C920", VA = "0x297C920", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x297C9B8", Offset = "0x297C9B8", VA = "0x297C9B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x297CA58", Offset = "0x297CA58", VA = "0x297CA58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x297CB54", Offset = "0x297CB54", VA = "0x297CB54")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x297CBF0", Offset = "0x297CBF0", VA = "0x297CBF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x297D020", Offset = "0x297D020", VA = "0x297D020", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x297D218", Offset = "0x297D218", VA = "0x297D218", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x297D0CC", Offset = "0x297D0CC", VA = "0x297D0CC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x297CDDC", Offset = "0x297CDDC", VA = "0x297CDDC")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x297D2B0", Offset = "0x297D2B0", VA = "0x297D2B0")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7A40", Offset = "0xCB7A40")]
		public int iterations;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x297D314", Offset = "0x297D314", VA = "0x297D314")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x297D404", Offset = "0x297D404", VA = "0x297D404")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x297D460", Offset = "0x297D460", VA = "0x297D460")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x297D590", Offset = "0x297D590", VA = "0x297D590")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x297D5EC", Offset = "0x297D5EC", VA = "0x297D5EC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x297D66C", Offset = "0x297D66C", VA = "0x297D66C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x297D810", Offset = "0x297D810", VA = "0x297D810", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x297D980", Offset = "0x297D980", VA = "0x297D980", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x297DB8C", Offset = "0x297DB8C", VA = "0x297DB8C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x297DC64", Offset = "0x297DC64", VA = "0x297DC64", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x297DD50", Offset = "0x297DD50", VA = "0x297DD50", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x297DEC4", Offset = "0x297DEC4", VA = "0x297DEC4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x297E01C", Offset = "0x297E01C", VA = "0x297E01C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x297E268", Offset = "0x297E268", VA = "0x297E268", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x297E544", Offset = "0x297E544", VA = "0x297E544", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x297E588", Offset = "0x297E588", VA = "0x297E588", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x297E678", Offset = "0x297E678", VA = "0x297E678")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002C1")]
		Body,
		[Token(Token = "0x40002C2")]
		LeftShoulder,
		[Token(Token = "0x40002C3")]
		RightShoulder,
		[Token(Token = "0x40002C4")]
		LeftThigh,
		[Token(Token = "0x40002C5")]
		RightThigh,
		[Token(Token = "0x40002C6")]
		LeftHand,
		[Token(Token = "0x40002C7")]
		RightHand,
		[Token(Token = "0x40002C8")]
		LeftFoot,
		[Token(Token = "0x40002C9")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002CB")]
		LeftArm,
		[Token(Token = "0x40002CC")]
		RightArm,
		[Token(Token = "0x40002CD")]
		LeftLeg,
		[Token(Token = "0x40002CE")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7A58", Offset = "0xCB7A58")]
		public float spineStiffness;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7A70", Offset = "0xCB7A70")]
		public float pullBodyVertical;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7A88", Offset = "0xCB7A88")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB7AA0", Offset = "0xCB7AA0")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700003F")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x297E77C", Offset = "0x297E77C", VA = "0x297E77C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x297E8C4", Offset = "0x297E8C4", VA = "0x297E8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x297E8CC", Offset = "0x297E8CC", VA = "0x297E8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x297E8D4", Offset = "0x297E8D4", VA = "0x297E8D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x297E8DC", Offset = "0x297E8DC", VA = "0x297E8DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x297E8E4", Offset = "0x297E8E4", VA = "0x297E8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x297E8EC", Offset = "0x297E8EC", VA = "0x297E8EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x297E8F4", Offset = "0x297E8F4", VA = "0x297E8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x297E8FC", Offset = "0x297E8FC", VA = "0x297E8FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x297E904", Offset = "0x297E904", VA = "0x297E904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x297E93C", Offset = "0x297E93C", VA = "0x297E93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x297E974", Offset = "0x297E974", VA = "0x297E974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x297E9AC", Offset = "0x297E9AC", VA = "0x297E9AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x297E9E4", Offset = "0x297E9E4", VA = "0x297E9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x297EA18", Offset = "0x297EA18", VA = "0x297EA18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x297EA50", Offset = "0x297EA50", VA = "0x297EA50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x297EA88", Offset = "0x297EA88", VA = "0x297EA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x297EAC0", Offset = "0x297EAC0", VA = "0x297EAC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x2980988", Offset = "0x2980988", VA = "0x2980988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA50", Offset = "0xCBDA50")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x2980994", Offset = "0x2980994", VA = "0x2980994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA60", Offset = "0xCBDA60")]
			private set
			{
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x297EAF4", Offset = "0x297EAF4", VA = "0x297EAF4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x297EC00", Offset = "0x297EC00", VA = "0x297EC00")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x297EB48", Offset = "0x297EB48", VA = "0x297EB48")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x297EC8C", Offset = "0x297EC8C", VA = "0x297EC8C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x297E784", Offset = "0x297E784", VA = "0x297E784")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x297ED5C", Offset = "0x297ED5C", VA = "0x297ED5C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x297EE14", Offset = "0x297EE14", VA = "0x297EE14")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x297EEC8", Offset = "0x297EEC8", VA = "0x297EEC8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x297EF7C", Offset = "0x297EF7C", VA = "0x297EF7C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x297EF84", Offset = "0x297EF84", VA = "0x297EF84")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x297EFB8", Offset = "0x297EFB8", VA = "0x297EFB8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x297F080", Offset = "0x297F080", VA = "0x297F080", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x297F224", Offset = "0x297F224", VA = "0x297F224")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x2980404", Offset = "0x2980404", VA = "0x2980404")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2980818", Offset = "0x2980818", VA = "0x2980818")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x2980878", Offset = "0x2980878", VA = "0x2980878")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x29806A0", Offset = "0x29806A0", VA = "0x29806A0")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x298075C", Offset = "0x298075C", VA = "0x298075C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x29809A0", Offset = "0x29809A0", VA = "0x29809A0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2980A78", Offset = "0x2980A78", VA = "0x2980A78", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2980B74", Offset = "0x2980B74", VA = "0x2980B74")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2980C9C", Offset = "0x2980C9C", VA = "0x2980C9C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2980DE0", Offset = "0x2980DE0", VA = "0x2980DE0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x2980F10", Offset = "0x2980F10", VA = "0x2980F10", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x2981150", Offset = "0x2981150", VA = "0x2981150", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x29811D4", Offset = "0x29811D4", VA = "0x29811D4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000052")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x2981A40", Offset = "0x2981A40", VA = "0x2981A40", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000053")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x2981A48", Offset = "0x2981A48", VA = "0x2981A48", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x2981A50", Offset = "0x2981A50", VA = "0x2981A50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x2981A60", Offset = "0x2981A60", VA = "0x2981A60", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000056")]
		protected float positionOffset
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x2979D64", Offset = "0x2979D64", VA = "0x2979D64")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x29811E0", Offset = "0x29811E0", VA = "0x29811E0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x298137C", Offset = "0x298137C", VA = "0x298137C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x29814B4", Offset = "0x29814B4", VA = "0x29814B4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2981520", Offset = "0x2981520", VA = "0x2981520", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x29815A0", Offset = "0x29815A0", VA = "0x29815A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2981948", Offset = "0x2981948", VA = "0x2981948", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2981950", Offset = "0x2981950", VA = "0x2981950", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2981A58", Offset = "0x2981A58", VA = "0x2981A58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2981A5C", Offset = "0x2981A5C", VA = "0x2981A5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2979348", Offset = "0x2979348", VA = "0x2979348")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2979A4C", Offset = "0x2979A4C", VA = "0x2979A4C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2981B28", Offset = "0x2981B28", VA = "0x2981B28")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x29782F4", Offset = "0x29782F4", VA = "0x29782F4")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7AB0", Offset = "0xCB7AB0")]
		public float IKRotationWeight;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2981D1C", Offset = "0x2981D1C", VA = "0x2981D1C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x29820BC", Offset = "0x29820BC", VA = "0x29820BC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x298212C", Offset = "0x298212C", VA = "0x298212C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2982284", Offset = "0x2982284", VA = "0x2982284", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2982418", Offset = "0x2982418", VA = "0x2982418", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2982474", Offset = "0x2982474", VA = "0x2982474", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x29824E4", Offset = "0x29824E4", VA = "0x29824E4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2982854", Offset = "0x2982854", VA = "0x2982854", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2982880", Offset = "0x2982880", VA = "0x2982880")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2982548", Offset = "0x2982548", VA = "0x2982548")]
		private void Read()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2982918", Offset = "0x2982918", VA = "0x2982918")]
		private void Write()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2982AA4", Offset = "0x2982AA4", VA = "0x2982AA4")]
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
			[Token(Token = "0x40002F9")]
			Animation,
			[Token(Token = "0x40002FA")]
			Target,
			[Token(Token = "0x40002FB")]
			Parent,
			[Token(Token = "0x40002FC")]
			Arm,
			[Token(Token = "0x40002FD")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200006F")]
		public struct AxisDirection
		{
			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x295789C", Offset = "0x295789C", VA = "0x295789C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7AC8", Offset = "0xCB7AC8")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7AE0", Offset = "0xCB7AE0")]
		public float bendModifierWeight;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000057")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x2983D20", Offset = "0x2983D20", VA = "0x2983D20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2982BFC", Offset = "0x2982BFC", VA = "0x2982BFC")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2982C4C", Offset = "0x2982C4C", VA = "0x2982C4C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2982C98", Offset = "0x2982C98", VA = "0x2982C98", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x298316C", Offset = "0x298316C", VA = "0x298316C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2983AB4", Offset = "0x2983AB4", VA = "0x2983AB4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2983B60", Offset = "0x2983B60", VA = "0x2983B60")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2983C9C", Offset = "0x2983C9C", VA = "0x2983C9C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2982F94", Offset = "0x2982F94", VA = "0x2982F94")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2983250", Offset = "0x2983250", VA = "0x2983250")]
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
			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x1700005E")]
			public Vector3 forward
			{
				[Token(Token = "0x60003E8")]
				[Address(RVA = "0x2957B28", Offset = "0x2957B28", VA = "0x2957B28")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x29578FC", Offset = "0x29578FC", VA = "0x29578FC")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x2957900", Offset = "0x2957900", VA = "0x2957900")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x2957928", Offset = "0x2957928", VA = "0x2957928")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x2957A20", Offset = "0x2957A20", VA = "0x2957A20")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7AF8", Offset = "0xCB7AF8")]
		public float bodyWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7B10", Offset = "0xCB7B10")]
		public float headWeight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7B28", Offset = "0xCB7B28")]
		public float eyesWeight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7B40", Offset = "0xCB7B40")]
		public float clampWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7B58", Offset = "0xCB7B58")]
		public float clampWeightHead;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7B70", Offset = "0xCB7B70")]
		public float clampWeightEyes;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7B88", Offset = "0xCB7B88")]
		public int clampSmoothing;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000058")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x29844D0", Offset = "0x29844D0", VA = "0x29844D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x29846A0", Offset = "0x29846A0", VA = "0x29846A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x29845B0", Offset = "0x29845B0", VA = "0x29845B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x29846C4", Offset = "0x29846C4", VA = "0x29846C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x29845C0", Offset = "0x29845C0", VA = "0x29845C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x298473C", Offset = "0x298473C", VA = "0x298473C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2983D3C", Offset = "0x2983D3C", VA = "0x2983D3C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2983D6C", Offset = "0x2983D6C", VA = "0x2983D6C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2983DC4", Offset = "0x2983DC4", VA = "0x2983DC4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2983E40", Offset = "0x2983E40", VA = "0x2983E40")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2983ED8", Offset = "0x2983ED8", VA = "0x2983ED8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2983F98", Offset = "0x2983F98", VA = "0x2983F98")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2984094", Offset = "0x2984094", VA = "0x2984094", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x29841C0", Offset = "0x29841C0", VA = "0x29841C0")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x29841CC", Offset = "0x29841CC", VA = "0x29841CC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2984310", Offset = "0x2984310", VA = "0x2984310", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2984760", Offset = "0x2984760", VA = "0x2984760", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x29849A0", Offset = "0x29849A0", VA = "0x29849A0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2984B3C", Offset = "0x2984B3C", VA = "0x2984B3C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2984D6C", Offset = "0x2984D6C", VA = "0x2984D6C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2985040", Offset = "0x2985040", VA = "0x2985040", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2985110", Offset = "0x2985110", VA = "0x2985110")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x29852B0", Offset = "0x29852B0", VA = "0x29852B0")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x29854D4", Offset = "0x29854D4", VA = "0x29854D4")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2985888", Offset = "0x2985888", VA = "0x2985888")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2984BE8", Offset = "0x2984BE8", VA = "0x2984BE8")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2985AF8", Offset = "0x2985AF8", VA = "0x2985AF8")]
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
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x2957B64", Offset = "0x2957B64", VA = "0x2957B64")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x2957C60", Offset = "0x2957C60", VA = "0x2957C60")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x2957C90", Offset = "0x2957C90", VA = "0x2957C90")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x2957CCC", Offset = "0x2957CCC", VA = "0x2957CCC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7BA0", Offset = "0xCB7BA0")]
		public float IKRotationWeight;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2985D04", Offset = "0x2985D04", VA = "0x2985D04")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2985E60", Offset = "0x2985E60", VA = "0x2985E60")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2985FA4", Offset = "0x2985FA4", VA = "0x2985FA4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2985FB0", Offset = "0x2985FB0", VA = "0x2985FB0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2985FE0", Offset = "0x2985FE0", VA = "0x2985FE0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2985FEC", Offset = "0x2985FEC", VA = "0x2985FEC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2985FF4", Offset = "0x2985FF4", VA = "0x2985FF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x29860F4", Offset = "0x29860F4", VA = "0x29860F4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2986210", Offset = "0x2986210", VA = "0x2986210", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x298625C", Offset = "0x298625C", VA = "0x298625C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x29862BC", Offset = "0x29862BC", VA = "0x29862BC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2986684", Offset = "0x2986684", VA = "0x2986684")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x29866DC", Offset = "0x29866DC", VA = "0x29866DC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2986A98", Offset = "0x2986A98", VA = "0x2986A98")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2986C00", Offset = "0x2986C00", VA = "0x2986C00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2986D68", Offset = "0x2986D68", VA = "0x2986D68")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2986CDC", Offset = "0x2986CDC", VA = "0x2986CDC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2986E6C", Offset = "0x2986E6C", VA = "0x2986E6C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2987640", Offset = "0x2987640", VA = "0x2987640", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2987644", Offset = "0x2987644", VA = "0x2987644", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2987648", Offset = "0x2987648", VA = "0x2987648", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2987458", Offset = "0x2987458", VA = "0x2987458")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2983BD0", Offset = "0x2983BD0", VA = "0x2983BD0")]
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
				[Token(Token = "0x4000361")]
				YawPitch,
				[Token(Token = "0x4000362")]
				FromTo
			}

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7DDC", Offset = "0xCB7DDC")]
			public Transform target;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7E14", Offset = "0xCB7E14")]
			public Transform bendGoal;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7E4C", Offset = "0xCB7E4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7E4C", Offset = "0xCB7E4C")]
			public float positionWeight;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7EA0", Offset = "0xCB7EA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7EA0", Offset = "0xCB7EA0")]
			public float rotationWeight;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7EF4", Offset = "0xCB7EF4")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7F2C", Offset = "0xCB7F2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7F2C", Offset = "0xCB7F2C")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7F80", Offset = "0xCB7F80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7F80", Offset = "0xCB7F80")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7FD4", Offset = "0xCB7FD4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7FD4", Offset = "0xCB7FD4")]
			public float bendGoalWeight;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8028", Offset = "0xCB8028")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8028", Offset = "0xCB8028")]
			public float swivelOffset;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8084", Offset = "0xCB8084")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB80BC", Offset = "0xCB80BC")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB80F4", Offset = "0xCB80F4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB80F4", Offset = "0xCB80F4")]
			public float armLengthMlp;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB814C", Offset = "0xCB814C")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB81C4", Offset = "0xCB81C4")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB81D4", Offset = "0xCB81D4")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400035E")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400035F")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000060")]
			public Vector3 position
			{
				[Token(Token = "0x6000420")]
				[Address(RVA = "0x2957CD0", Offset = "0x2957CD0", VA = "0x2957CD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA90", Offset = "0xCBDA90")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x2957CDC", Offset = "0x2957CDC", VA = "0x2957CDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDAA0", Offset = "0xCBDAA0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000061")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x2957CE8", Offset = "0x2957CE8", VA = "0x2957CE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDAB0", Offset = "0xCBDAB0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x2957CF4", Offset = "0x2957CF4", VA = "0x2957CF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDAC0", Offset = "0xCBDAC0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000062")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0x2957D00", Offset = "0x2957D00", VA = "0x2957D00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x2957D34", Offset = "0x2957D34", VA = "0x2957D34")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x2957D74", Offset = "0x2957D74", VA = "0x2957D74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x2957DC0", Offset = "0x2957DC0", VA = "0x2957DC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2957E0C", Offset = "0x2957E0C", VA = "0x2957E0C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x29586CC", Offset = "0x29586CC", VA = "0x29586CC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x2958884", Offset = "0x2958884", VA = "0x2958884", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x29588A8", Offset = "0x29588A8", VA = "0x29588A8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x2958B48", Offset = "0x2958B48", VA = "0x2958B48")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x295A0B8", Offset = "0x295A0B8", VA = "0x295A0B8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x295A0E4", Offset = "0x295A0E4", VA = "0x295A0E4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x2959AF4", Offset = "0x2959AF4", VA = "0x2959AF4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x2959B70", Offset = "0x2959B70", VA = "0x2959B70")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x295A304", Offset = "0x295A304", VA = "0x295A304")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x295A428", Offset = "0x295A428", VA = "0x295A428")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000077")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB81E4", Offset = "0xCB81E4")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB81F4", Offset = "0xCB81F4")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000066")]
			public float sqrMag
			{
				[Token(Token = "0x6000438")]
				[Address(RVA = "0x295A580", Offset = "0x295A580", VA = "0x295A580")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDAD0", Offset = "0xCBDAD0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000439")]
				[Address(RVA = "0x295A588", Offset = "0x295A588", VA = "0x295A588")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDAE0", Offset = "0xCBDAE0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public float mag
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x295A590", Offset = "0x295A590", VA = "0x295A590")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDAF0", Offset = "0xCBDAF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x295A598", Offset = "0x295A598", VA = "0x295A598")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB00", Offset = "0xCBDB00")]
				private set
				{
				}
			}

			[Token(Token = "0x6000433")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000434")]
			public abstract void PreSolve();

			[Token(Token = "0x6000435")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000436")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000437")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x295A5A0", Offset = "0x295A5A0", VA = "0x295A5A0")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x295A5A8", Offset = "0x295A5A8", VA = "0x295A5A8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x295A67C", Offset = "0x295A67C", VA = "0x295A67C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x295A710", Offset = "0x295A710", VA = "0x295A710")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x295A7BC", Offset = "0x295A7BC", VA = "0x295A7BC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x295A810", Offset = "0x295A810", VA = "0x295A810")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2959F74", Offset = "0x2959F74", VA = "0x2959F74")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x295A94C", Offset = "0x295A94C", VA = "0x295A94C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x295AA8C", Offset = "0x295AA8C", VA = "0x295AA8C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x295A50C", Offset = "0x295A50C", VA = "0x295A50C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public class Footstep
		{
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB8214", Offset = "0xCB8214")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000068")]
			public bool isStepping
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x2DF4740", Offset = "0x2DF4740", VA = "0x2DF4740")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000069")]
			public float stepProgress
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x2DF4754", Offset = "0x2DF4754", VA = "0x2DF4754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB10", Offset = "0xCBDB10")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x2DF475C", Offset = "0x2DF475C", VA = "0x2DF475C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB20", Offset = "0xCBDB20")]
				private set
				{
				}
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2DF4764", Offset = "0x2DF4764", VA = "0x2DF4764")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2DF489C", Offset = "0x2DF489C", VA = "0x2DF489C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2DF48E4", Offset = "0x2DF48E4", VA = "0x2DF48E4")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2DF4AB0", Offset = "0x2DF4AB0", VA = "0x2DF4AB0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2DF4C24", Offset = "0x2DF4C24", VA = "0x2DF4C24")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x2DF4D7C", Offset = "0x2DF4D7C", VA = "0x2DF4D7C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8224", Offset = "0xCB8224")]
			public Transform target;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB825C", Offset = "0xCB825C")]
			public Transform bendGoal;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8294", Offset = "0xCB8294")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8294", Offset = "0xCB8294")]
			public float positionWeight;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB82E8", Offset = "0xCB82E8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB82E8", Offset = "0xCB82E8")]
			public float rotationWeight;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB833C", Offset = "0xCB833C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB833C", Offset = "0xCB833C")]
			public float bendGoalWeight;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8390", Offset = "0xCB8390")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8390", Offset = "0xCB8390")]
			public float swivelOffset;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB83EC", Offset = "0xCB83EC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB83EC", Offset = "0xCB83EC")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8440", Offset = "0xCB8440")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8440", Offset = "0xCB8440")]
			public float legLengthMlp;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8498", Offset = "0xCB8498")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB8540", Offset = "0xCB8540")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB8550", Offset = "0xCB8550")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB8560", Offset = "0xCB8560")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB8570", Offset = "0xCB8570")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006A")]
			public Vector3 position
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x2DF4EB8", Offset = "0x2DF4EB8", VA = "0x2DF4EB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB30", Offset = "0xCBDB30")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x2DF4EC4", Offset = "0x2DF4EC4", VA = "0x2DF4EC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB40", Offset = "0xCBDB40")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2DF4ED0", Offset = "0x2DF4ED0", VA = "0x2DF4ED0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB50", Offset = "0xCBDB50")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x2DF4EDC", Offset = "0x2DF4EDC", VA = "0x2DF4EDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB60", Offset = "0xCBDB60")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public bool hasToes
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x2DF4EE8", Offset = "0x2DF4EE8", VA = "0x2DF4EE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB70", Offset = "0xCBDB70")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x2DF4EF0", Offset = "0x2DF4EF0", VA = "0x2DF4EF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB80", Offset = "0xCBDB80")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x2DF4EFC", Offset = "0x2DF4EFC", VA = "0x2DF4EFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x2DF4F30", Offset = "0x2DF4F30", VA = "0x2DF4F30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x2DF4F68", Offset = "0x2DF4F68", VA = "0x2DF4F68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x2DF4FA0", Offset = "0x2DF4FA0", VA = "0x2DF4FA0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x2DF4FD8", Offset = "0x2DF4FD8", VA = "0x2DF4FD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x2DF5018", Offset = "0x2DF5018", VA = "0x2DF5018")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDB90", Offset = "0xCBDB90")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x2DF5024", Offset = "0x2DF5024", VA = "0x2DF5024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDBA0", Offset = "0xCBDBA0")]
				private set
				{
				}
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x2DF5030", Offset = "0x2DF5030", VA = "0x2DF5030", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2DF56A8", Offset = "0x2DF56A8", VA = "0x2DF56A8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x2DF5C7C", Offset = "0x2DF5C7C", VA = "0x2DF5C7C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2DF5C2C", Offset = "0x2DF5C2C", VA = "0x2DF5C2C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2DF5ABC", Offset = "0x2DF5ABC", VA = "0x2DF5ABC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2DF6064", Offset = "0x2DF6064", VA = "0x2DF6064")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2DF6928", Offset = "0x2DF6928", VA = "0x2DF6928")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x2DF6204", Offset = "0x2DF6204", VA = "0x2DF6204")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x2DF6C20", Offset = "0x2DF6C20", VA = "0x2DF6C20", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x2DF6E3C", Offset = "0x2DF6E3C", VA = "0x2DF6E3C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x2DF6E88", Offset = "0x2DF6E88", VA = "0x2DF6E88")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Locomotion
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8580", Offset = "0xCB8580")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8580", Offset = "0xCB8580")]
			public float weight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB85D4", Offset = "0xCB85D4")]
			public float footDistance;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB860C", Offset = "0xCB860C")]
			public float stepThreshold;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8644", Offset = "0xCB8644")]
			public float angleThreshold;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB867C", Offset = "0xCB867C")]
			public float comAngleMlp;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB86B4", Offset = "0xCB86B4")]
			public float maxVelocity;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB86EC", Offset = "0xCB86EC")]
			public float velocityFactor;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8724", Offset = "0xCB8724")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8724", Offset = "0xCB8724")]
			public float maxLegStretch;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB877C", Offset = "0xCB877C")]
			public float rootSpeed;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB87B4", Offset = "0xCB87B4")]
			public float stepSpeed;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB87EC", Offset = "0xCB87EC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8824", Offset = "0xCB8824")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB885C", Offset = "0xCB885C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8894", Offset = "0xCB8894")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8894", Offset = "0xCB8894")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB88EC", Offset = "0xCB88EC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8924", Offset = "0xCB8924")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB895C", Offset = "0xCB895C")]
			public Vector3 offset;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB89D4", Offset = "0xCB89D4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8A0C", Offset = "0xCB8A0C")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB8A44", Offset = "0xCB8A44")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x17000073")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x2DF6F5C", Offset = "0x2DF6F5C", VA = "0x2DF6F5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDBB0", Offset = "0xCBDBB0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x2DF6F68", Offset = "0x2DF6F68", VA = "0x2DF6F68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDBC0", Offset = "0xCBDBC0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x2DF8B78", Offset = "0x2DF8B78", VA = "0x2DF8B78")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x2DF8BB8", Offset = "0x2DF8BB8", VA = "0x2DF8BB8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000076")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x2DF8BFC", Offset = "0x2DF8BFC", VA = "0x2DF8BFC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000077")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x2DF8C3C", Offset = "0x2DF8C3C", VA = "0x2DF8C3C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2DF6F74", Offset = "0x2DF6F74", VA = "0x2DF6F74")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2DF7230", Offset = "0x2DF7230", VA = "0x2DF7230")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x2DF7400", Offset = "0x2DF7400", VA = "0x2DF7400")]
			public void Relax()
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2DF7464", Offset = "0x2DF7464", VA = "0x2DF7464")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2DF76AC", Offset = "0x2DF76AC", VA = "0x2DF76AC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2DF7770", Offset = "0x2DF7770", VA = "0x2DF7770")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x2DF88F0", Offset = "0x2DF88F0", VA = "0x2DF88F0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x2DF8A28", Offset = "0x2DF8A28", VA = "0x2DF8A28")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x2DF8AAC", Offset = "0x2DF8AAC", VA = "0x2DF8AAC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x2DF8C80", Offset = "0x2DF8C80", VA = "0x2DF8C80")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8A54", Offset = "0xCB8A54")]
			public Transform headTarget;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8A8C", Offset = "0xCB8A8C")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8AC4", Offset = "0xCB8AC4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8AC4", Offset = "0xCB8AC4")]
			public float positionWeight;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8B18", Offset = "0xCB8B18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8B18", Offset = "0xCB8B18")]
			public float rotationWeight;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8B6C", Offset = "0xCB8B6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8B6C", Offset = "0xCB8B6C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8BC0", Offset = "0xCB8BC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8BC0", Offset = "0xCB8BC0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8C14", Offset = "0xCB8C14")]
			public Transform chestGoal;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8C4C", Offset = "0xCB8C4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8C4C", Offset = "0xCB8C4C")]
			public float chestGoalWeight;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8CA0", Offset = "0xCB8CA0")]
			public float minHeadHeight;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8CD8", Offset = "0xCB8CD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8CD8", Offset = "0xCB8CD8")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8D2C", Offset = "0xCB8D2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8D2C", Offset = "0xCB8D2C")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCB8D80", Offset = "0xCB8D80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8D80", Offset = "0xCB8D80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8D80", Offset = "0xCB8D80")]
			public float neckStiffness;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8DF8", Offset = "0xCB8DF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8DF8", Offset = "0xCB8DF8")]
			public float rotateChestByHands;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8E4C", Offset = "0xCB8E4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8E4C", Offset = "0xCB8E4C")]
			public float chestClampWeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8EA0", Offset = "0xCB8EA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8EA0", Offset = "0xCB8EA0")]
			public float headClampWeight;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8EF4", Offset = "0xCB8EF4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8F2C", Offset = "0xCB8F2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8F2C", Offset = "0xCB8F2C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8F80", Offset = "0xCB8F80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8F80", Offset = "0xCB8F80")]
			public float maxRootAngle;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB8FD8", Offset = "0xCB8FD8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB8FD8", Offset = "0xCB8FD8")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9114", Offset = "0xCB9114")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9124", Offset = "0xCB9124")]
			private Quaternion <anchorRelativeToHead>k__BackingField;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x17000078")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x2DF8870", Offset = "0x2DF8870", VA = "0x2DF8870")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x2DF8D78", Offset = "0x2DF8D78", VA = "0x2DF8D78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x2DF8DB8", Offset = "0x2DF8DB8", VA = "0x2DF8DB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone neck
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x2DF8E0C", Offset = "0x2DF8E0C", VA = "0x2DF8E0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone head
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x2DF88B0", Offset = "0x2DF88B0", VA = "0x2DF88B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x2DF8E4C", Offset = "0x2DF8E4C", VA = "0x2DF8E4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDBD0", Offset = "0xCBDBD0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047D")]
				[Address(RVA = "0x2DF8E60", Offset = "0x2DF8E60", VA = "0x2DF8E60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDBE0", Offset = "0xCBDBE0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0x2DF8E74", Offset = "0x2DF8E74", VA = "0x2DF8E74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDBF0", Offset = "0xCBDBF0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047F")]
				[Address(RVA = "0x2DF8E88", Offset = "0x2DF8E88", VA = "0x2DF8E88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC00", Offset = "0xCBDC00")]
				private set
				{
				}
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x2DF8E9C", Offset = "0x2DF8E9C", VA = "0x2DF8E9C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x2DF98A8", Offset = "0x2DF98A8", VA = "0x2DF98A8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x2DF9AB4", Offset = "0x2DF9AB4", VA = "0x2DF9AB4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x2DF9F00", Offset = "0x2DF9F00", VA = "0x2DF9F00")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x2DFA33C", Offset = "0x2DFA33C", VA = "0x2DFA33C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x2DFAAB0", Offset = "0x2DFAAB0", VA = "0x2DFAAB0")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x2DFB134", Offset = "0x2DFB134", VA = "0x2DFB134")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x2DFB6B8", Offset = "0x2DFB6B8", VA = "0x2DFB6B8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x2DFB894", Offset = "0x2DFB894", VA = "0x2DFB894", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x2DFA098", Offset = "0x2DFA098", VA = "0x2DFA098")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x2DFAE80", Offset = "0x2DFAE80", VA = "0x2DFAE80")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2DFA754", Offset = "0x2DFA754", VA = "0x2DFA754")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2DFB92C", Offset = "0x2DFB92C", VA = "0x2DFB92C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x2DFAF60", Offset = "0x2DFAF60", VA = "0x2DFAF60")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2DFAC2C", Offset = "0x2DFAC2C", VA = "0x2DFAC2C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2DFBC48", Offset = "0x2DFBC48", VA = "0x2DFBC48")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public enum PositionOffset
		{
			[Token(Token = "0x40003EA")]
			Pelvis,
			[Token(Token = "0x40003EB")]
			Chest,
			[Token(Token = "0x40003EC")]
			Head,
			[Token(Token = "0x40003ED")]
			LeftHand,
			[Token(Token = "0x40003EE")]
			RightHand,
			[Token(Token = "0x40003EF")]
			LeftFoot,
			[Token(Token = "0x40003F0")]
			RightFoot,
			[Token(Token = "0x40003F1")]
			LeftHeel,
			[Token(Token = "0x40003F2")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public enum RotationOffset
		{
			[Token(Token = "0x40003F4")]
			Pelvis,
			[Token(Token = "0x40003F5")]
			Chest,
			[Token(Token = "0x40003F6")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class VirtualBone
		{
			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2DF560C", Offset = "0x2DF560C", VA = "0x2DF560C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2DF5688", Offset = "0x2DF5688", VA = "0x2DF5688")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x2DFBDBC", Offset = "0x2DFBDBC", VA = "0x2DFBDBC")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2DFBF40", Offset = "0x2DFBF40", VA = "0x2DFBF40")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x2DFBB20", Offset = "0x2DFBB20", VA = "0x2DFBB20")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x2DFC130", Offset = "0x2DFC130", VA = "0x2DFC130")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x2DFC290", Offset = "0x2DFC290", VA = "0x2DFC290")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x2DFC3CC", Offset = "0x2DFC3CC", VA = "0x2DFC3CC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x2DF6524", Offset = "0x2DF6524", VA = "0x2DF6524")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x2DFC484", Offset = "0x2DFC484", VA = "0x2DFC484")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x2DFB328", Offset = "0x2DFB328", VA = "0x2DFB328")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x2DFC5EC", Offset = "0x2DFC5EC", VA = "0x2DFC5EC")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x2DFC65C", Offset = "0x2DFC65C", VA = "0x2DFC65C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB7BB8", Offset = "0xCB7BB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7BB8", Offset = "0xCB7BB8")]
		public int LOD;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7C0C", Offset = "0xCB7C0C")]
		public float scale;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7C44", Offset = "0xCB7C44")]
		public bool plantFeet;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB7C7C", Offset = "0xCB7C7C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7C8C", Offset = "0xCB7C8C")]
		public Spine spine;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7CC4", Offset = "0xCB7CC4")]
		public Arm leftArm;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7CFC", Offset = "0xCB7CFC")]
		public Arm rightArm;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7D34", Offset = "0xCB7D34")]
		public Leg leftLeg;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7D6C", Offset = "0xCB7D6C")]
		public Leg rightLeg;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB7DA4", Offset = "0xCB7DA4")]
		public Locomotion locomotion;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700005F")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x298AE48", Offset = "0x298AE48", VA = "0x298AE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA70", Offset = "0xCBDA70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x298AE50", Offset = "0x298AE50", VA = "0x298AE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDA80", Offset = "0xCBDA80")]
			private set
			{
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x298764C", Offset = "0x298764C", VA = "0x298764C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2987AB0", Offset = "0x2987AB0", VA = "0x2987AB0")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x298795C", Offset = "0x298795C", VA = "0x298795C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2987E14", Offset = "0x2987E14", VA = "0x2987E14")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2987F58", Offset = "0x2987F58", VA = "0x2987F58")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2987F88", Offset = "0x2987F88", VA = "0x2987F88")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2988038", Offset = "0x2988038", VA = "0x2988038")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2988120", Offset = "0x2988120", VA = "0x2988120")]
		public void Reset()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2988888", Offset = "0x2988888", VA = "0x2988888", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x29889F8", Offset = "0x29889F8", VA = "0x29889F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2988BFC", Offset = "0x2988BFC", VA = "0x2988BFC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2988C78", Offset = "0x2988C78", VA = "0x2988C78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2988CF4", Offset = "0x2988CF4", VA = "0x2988CF4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2988ECC", Offset = "0x2988ECC", VA = "0x2988ECC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2987CF4", Offset = "0x2987CF4", VA = "0x2987CF4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2988214", Offset = "0x2988214", VA = "0x2988214")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x298908C", Offset = "0x298908C", VA = "0x298908C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x29890D4", Offset = "0x29890D4", VA = "0x29890D4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x298A578", Offset = "0x298A578", VA = "0x298A578")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2988378", Offset = "0x2988378", VA = "0x2988378")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2989448", Offset = "0x2989448", VA = "0x2989448")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x298A928", Offset = "0x298A928", VA = "0x298A928")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x298A970", Offset = "0x298A970", VA = "0x298A970")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x298A428", Offset = "0x298A428", VA = "0x298A428")]
		private void Write()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x298A9B4", Offset = "0x298A9B4", VA = "0x298A9B4")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x298AE58", Offset = "0x298AE58", VA = "0x298AE58")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9134", Offset = "0xCB9134")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x294A8BC", Offset = "0x294A8BC", VA = "0x294A8BC")]
		public void Start()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x294AF9C", Offset = "0x294AF9C", VA = "0x294AF9C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x294B42C", Offset = "0x294B42C", VA = "0x294B42C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x294B4F0", Offset = "0x294B4F0", VA = "0x294B4F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x294B604", Offset = "0x294B604", VA = "0x294B604")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class TwistSolver
	{
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB916C", Offset = "0xCB916C")]
		public Transform transform;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB91A4", Offset = "0xCB91A4")]
		public Transform parent;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB91DC", Offset = "0xCB91DC")]
		public Transform[] children;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9214", Offset = "0xCB9214")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB9214", Offset = "0xCB9214")]
		public float weight;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB9268", Offset = "0xCB9268")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9268", Offset = "0xCB9268")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB92BC", Offset = "0xCB92BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB92BC", Offset = "0xCB92BC")]
		public float twistAngleOffset;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x294B660", Offset = "0x294B660", VA = "0x294B660")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x294AA94", Offset = "0x294AA94", VA = "0x294AA94")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x294B060", Offset = "0x294B060", VA = "0x294B060")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class InteractionEffector
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9318", Offset = "0xCB9318")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9328", Offset = "0xCB9328")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9338", Offset = "0xCB9338")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700007F")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x29F0EF8", Offset = "0x29F0EF8", VA = "0x29F0EF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC10", Offset = "0xCBDC10")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x29F0F00", Offset = "0x29F0F00", VA = "0x29F0F00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC20", Offset = "0xCBDC20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool isPaused
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x29F0F08", Offset = "0x29F0F08", VA = "0x29F0F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC30", Offset = "0xCBDC30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x29F0F10", Offset = "0x29F0F10", VA = "0x29F0F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC40", Offset = "0xCBDC40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x29F0F1C", Offset = "0x29F0F1C", VA = "0x29F0F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC50", Offset = "0xCBDC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x29F0F24", Offset = "0x29F0F24", VA = "0x29F0F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDC60", Offset = "0xCBDC60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool inInteraction
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x29F0F2C", Offset = "0x29F0F2C", VA = "0x29F0F2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public float progress
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x29F3490", Offset = "0x29F3490", VA = "0x29F3490")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x29F0F98", Offset = "0x29F0F98", VA = "0x29F0F98")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x29F1024", Offset = "0x29F1024", VA = "0x29F1024")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x29F10BC", Offset = "0x29F10BC", VA = "0x29F10BC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x29F1234", Offset = "0x29F1234", VA = "0x29F1234")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x29F1598", Offset = "0x29F1598", VA = "0x29F1598")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x29F1654", Offset = "0x29F1654", VA = "0x29F1654")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x29F16AC", Offset = "0x29F16AC", VA = "0x29F16AC")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x29F21C4", Offset = "0x29F21C4", VA = "0x29F21C4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x29F2C58", Offset = "0x29F2C58", VA = "0x29F2C58")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x29F2E9C", Offset = "0x29F2E9C", VA = "0x29F2E9C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x29F333C", Offset = "0x29F333C", VA = "0x29F333C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x29F35F0", Offset = "0x29F35F0", VA = "0x29F35F0")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9348", Offset = "0xCB9348")]
		public LookAtIK ik;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9380", Offset = "0xCB9380")]
		public float lerpSpeed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB93B8", Offset = "0xCB93B8")]
		public float weightSpeed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x29F3814", Offset = "0x29F3814", VA = "0x29F3814")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x29F3930", Offset = "0x29F3930", VA = "0x29F3930")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x29F39D4", Offset = "0x29F39D4", VA = "0x29F39D4")]
		public void Update()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x29F400C", Offset = "0x29F400C", VA = "0x29F400C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x29F4100", Offset = "0x29F4100", VA = "0x29F4100")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x29F41C8", Offset = "0x29F41C8", VA = "0x29F41C8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB5314", Offset = "0xCB5314")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB5314", Offset = "0xCB5314")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB94C8", Offset = "0xCB94C8")]
			public float time;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9500", Offset = "0xCB9500")]
			public bool pause;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9538", Offset = "0xCB9538")]
			public bool pickUp;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9570", Offset = "0xCB9570")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB95A8", Offset = "0xCB95A8")]
			public Message[] messages;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB95E0", Offset = "0xCB95E0")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x2DFCE08", Offset = "0x2DFCE08", VA = "0x2DFCE08")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x2DFCFDC", Offset = "0x2DFCFDC", VA = "0x2DFCFDC")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class Message
		{
			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9618", Offset = "0xCB9618")]
			public string function;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9650", Offset = "0xCB9650")]
			public GameObject recipient;

			[Token(Token = "0x4000449")]
			private const string empty = "";

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x2DFCED8", Offset = "0x2DFCED8", VA = "0x2DFCED8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x2DFCFE4", Offset = "0x2DFCFE4", VA = "0x2DFCFE4")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class AnimatorEvent
		{
			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9688", Offset = "0xCB9688")]
			public Animator animator;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB96C0", Offset = "0xCB96C0")]
			public Animation animation;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB96F8", Offset = "0xCB96F8")]
			public string animationState;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9730", Offset = "0xCB9730")]
			public float crossfadeTime;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9768", Offset = "0xCB9768")]
			public int layer;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB97A0", Offset = "0xCB97A0")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000450")]
			private const string empty = "";

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x2DFCB74", Offset = "0x2DFCB74", VA = "0x2DFCB74")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x2DFCC64", Offset = "0x2DFCC64", VA = "0x2DFCC64")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x2DFCD18", Offset = "0x2DFCD18", VA = "0x2DFCD18")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x2DFCDF4", Offset = "0x2DFCDF4", VA = "0x2DFCDF4")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000088")]
			public enum Type
			{
				[Token(Token = "0x4000454")]
				PositionWeight,
				[Token(Token = "0x4000455")]
				RotationWeight,
				[Token(Token = "0x4000456")]
				PositionOffsetX,
				[Token(Token = "0x4000457")]
				PositionOffsetY,
				[Token(Token = "0x4000458")]
				PositionOffsetZ,
				[Token(Token = "0x4000459")]
				Pull,
				[Token(Token = "0x400045A")]
				Reach,
				[Token(Token = "0x400045B")]
				RotateBoneWeight,
				[Token(Token = "0x400045C")]
				Push,
				[Token(Token = "0x400045D")]
				PushParent,
				[Token(Token = "0x400045E")]
				PoserWeight,
				[Token(Token = "0x400045F")]
				BendGoalWeight
			}

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB97D8", Offset = "0xCB97D8")]
			public Type type;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9810", Offset = "0xCB9810")]
			public AnimationCurve curve;

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x2DFD028", Offset = "0x2DFD028", VA = "0x2DFD028")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2DFD054", Offset = "0x2DFD054", VA = "0x2DFD054")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class Multiplier
		{
			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9848", Offset = "0xCB9848")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9880", Offset = "0xCB9880")]
			public float multiplier;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB98B8", Offset = "0xCB98B8")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x2DFCFEC", Offset = "0x2DFCFEC", VA = "0x2DFCFEC")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x2DFD044", Offset = "0x2DFD044", VA = "0x2DFD044")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9400", Offset = "0xCB9400")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9438", Offset = "0xCB9438")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9470", Offset = "0xCB9470")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB94A8", Offset = "0xCB94A8")]
		private float <length>k__BackingField;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB94B8", Offset = "0xCB94B8")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000084")]
		public float length
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x29F441C", Offset = "0x29F441C", VA = "0x29F441C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDE30", Offset = "0xCBDE30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x29F4424", Offset = "0x29F4424", VA = "0x29F4424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDE40", Offset = "0xCBDE40")]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x29F442C", Offset = "0x29F442C", VA = "0x29F442C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDE50", Offset = "0xCBDE50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x29F4434", Offset = "0x29F4434", VA = "0x29F4434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBDE60", Offset = "0xCBDE60")]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x29F45FC", Offset = "0x29F45FC", VA = "0x29F45FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x29F34CC", Offset = "0x29F34CC", VA = "0x29F34CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x29F41DC", Offset = "0x29F41DC", VA = "0x29F41DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDC70", Offset = "0xCBDC70")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x29F4224", Offset = "0x29F4224", VA = "0x29F4224")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDCA8", Offset = "0xCBDCA8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x29F426C", Offset = "0x29F426C", VA = "0x29F426C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDCE0", Offset = "0xCBDCE0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x29F42B4", Offset = "0x29F42B4", VA = "0x29F42B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDD18", Offset = "0xCBDD18")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x29F42FC", Offset = "0x29F42FC", VA = "0x29F42FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDD50", Offset = "0xCBDD50")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x29F4344", Offset = "0x29F4344", VA = "0x29F4344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDD88", Offset = "0xCBDD88")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x29F438C", Offset = "0x29F438C", VA = "0x29F438C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDDC0", Offset = "0xCBDDC0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x29F43D4", Offset = "0x29F43D4", VA = "0x29F43D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDDF8", Offset = "0xCBDDF8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x29F443C", Offset = "0x29F443C", VA = "0x29F443C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x29F4688", Offset = "0x29F4688", VA = "0x29F4688")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x29F1BFC", Offset = "0x29F1BFC", VA = "0x29F1BFC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x29F47F4", Offset = "0x29F47F4", VA = "0x29F47F4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x29F1AB0", Offset = "0x29F1AB0", VA = "0x29F1AB0")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x29F1BF4", Offset = "0x29F1BF4", VA = "0x29F1BF4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x29F27FC", Offset = "0x29F27FC", VA = "0x29F27FC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x29F311C", Offset = "0x29F311C", VA = "0x29F311C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x29F4DD8", Offset = "0x29F4DD8", VA = "0x29F4DD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x29F48DC", Offset = "0x29F48DC", VA = "0x29F48DC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x29F47FC", Offset = "0x29F47FC", VA = "0x29F47FC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x29F4D70", Offset = "0x29F4D70", VA = "0x29F4D70")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x29F4DDC", Offset = "0x29F4DDC", VA = "0x29F4DDC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x29F4E44", Offset = "0x29F4E44", VA = "0x29F4E44")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB5374", Offset = "0xCB5374")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB5374", Offset = "0xCB5374")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB98F0", Offset = "0xCB98F0")]
		public string targetTag;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9928", Offset = "0xCB9928")]
		public float fadeInTime;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9960", Offset = "0xCB9960")]
		public float speed;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9998", Offset = "0xCB9998")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCB99D0", Offset = "0xCB99D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB99D0", Offset = "0xCB99D0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCB99D0", Offset = "0xCB99D0")]
		public Collider characterCollider;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9A54", Offset = "0xCB9A54")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xCB9A54", Offset = "0xCB9A54")]
		public Transform FPSCamera;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9AB4", Offset = "0xCB9AB4")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9AEC", Offset = "0xCB9AEC")]
		public float camRaycastDistance;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9B24", Offset = "0xCB9B24")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9B34", Offset = "0xCB9B34")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCB9B34", Offset = "0xCB9B34")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9B94", Offset = "0xCB9B94")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB9BCC", Offset = "0xCB9BCC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000088")]
		public bool inInteraction
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x29F50E0", Offset = "0x29F50E0", VA = "0x29F50E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x29F6D8C", Offset = "0x29F6D8C", VA = "0x29F6D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x29F6D94", Offset = "0x29F6D94", VA = "0x29F6D94")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x29F6D9C", Offset = "0x29F6D9C", VA = "0x29F6D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE030", Offset = "0xCBE030")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x29F6DA4", Offset = "0x29F6DA4", VA = "0x29F6DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE040", Offset = "0xCBE040")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x29F6DAC", Offset = "0x29F6DAC", VA = "0x29F6DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE050", Offset = "0xCBE050")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x29F6DB4", Offset = "0x29F6DB4", VA = "0x29F6DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE060", Offset = "0xCBE060")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x29F4EA0", Offset = "0x29F4EA0", VA = "0x29F4EA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDE70", Offset = "0xCBDE70")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x29F4EE8", Offset = "0x29F4EE8", VA = "0x29F4EE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDEA8", Offset = "0xCBDEA8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x29F4F30", Offset = "0x29F4F30", VA = "0x29F4F30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDEE0", Offset = "0xCBDEE0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x29F4F78", Offset = "0x29F4F78", VA = "0x29F4F78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDF18", Offset = "0xCBDF18")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x29F4FC0", Offset = "0x29F4FC0", VA = "0x29F4FC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDF50", Offset = "0xCBDF50")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x29F5008", Offset = "0x29F5008", VA = "0x29F5008")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDF88", Offset = "0xCBDF88")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x29F5050", Offset = "0x29F5050", VA = "0x29F5050")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDFC0", Offset = "0xCBDFC0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x29F5098", Offset = "0x29F5098", VA = "0x29F5098")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBDFF8", Offset = "0xCBDFF8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x29F5284", Offset = "0x29F5284", VA = "0x29F5284")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x29F5350", Offset = "0x29F5350", VA = "0x29F5350")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x29F541C", Offset = "0x29F541C", VA = "0x29F541C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x29F54C8", Offset = "0x29F54C8", VA = "0x29F54C8")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x29F55C0", Offset = "0x29F55C0", VA = "0x29F55C0")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x29F56D8", Offset = "0x29F56D8", VA = "0x29F56D8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x29F5768", Offset = "0x29F5768", VA = "0x29F5768")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x29F57F8", Offset = "0x29F57F8", VA = "0x29F57F8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x29F5888", Offset = "0x29F5888", VA = "0x29F5888")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x29F58FC", Offset = "0x29F58FC", VA = "0x29F58FC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x29F5970", Offset = "0x29F5970", VA = "0x29F5970")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x29F59D8", Offset = "0x29F59D8", VA = "0x29F59D8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x29F5A64", Offset = "0x29F5A64", VA = "0x29F5A64")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x29F5B18", Offset = "0x29F5B18", VA = "0x29F5B18")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x29F5BFC", Offset = "0x29F5BFC", VA = "0x29F5BFC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x29F5ED4", Offset = "0x29F5ED4", VA = "0x29F5ED4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x29F60B4", Offset = "0x29F60B4", VA = "0x29F60B4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x29F6348", Offset = "0x29F6348", VA = "0x29F6348")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x29F6620", Offset = "0x29F6620", VA = "0x29F6620")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x29F6664", Offset = "0x29F6664", VA = "0x29F6664")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x29F66DC", Offset = "0x29F66DC", VA = "0x29F66DC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x29F67F8", Offset = "0x29F67F8", VA = "0x29F67F8")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x29F699C", Offset = "0x29F699C", VA = "0x29F699C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x29F6C40", Offset = "0x29F6C40", VA = "0x29F6C40")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x29F645C", Offset = "0x29F645C", VA = "0x29F645C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x29F6DC0", Offset = "0x29F6DC0", VA = "0x29F6DC0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x29F752C", Offset = "0x29F752C", VA = "0x29F752C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x29F754C", Offset = "0x29F754C", VA = "0x29F754C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x29F7568", Offset = "0x29F7568", VA = "0x29F7568")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x29F7584", Offset = "0x29F7584", VA = "0x29F7584")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x29F75E4", Offset = "0x29F75E4", VA = "0x29F75E4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x29F7720", Offset = "0x29F7720", VA = "0x29F7720")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x29F7830", Offset = "0x29F7830", VA = "0x29F7830")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x29F7BD4", Offset = "0x29F7BD4", VA = "0x29F7BD4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x29F7CD4", Offset = "0x29F7CD4", VA = "0x29F7CD4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x29F7F30", Offset = "0x29F7F30", VA = "0x29F7F30")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x29F7290", Offset = "0x29F7290", VA = "0x29F7290")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x29F806C", Offset = "0x29F806C", VA = "0x29F806C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x29F8194", Offset = "0x29F8194", VA = "0x29F8194")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x29F8228", Offset = "0x29F8228", VA = "0x29F8228")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x29F82FC", Offset = "0x29F82FC", VA = "0x29F82FC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x29F8314", Offset = "0x29F8314", VA = "0x29F8314")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x29F518C", Offset = "0x29F518C", VA = "0x29F518C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x29F5DA4", Offset = "0x29F5DA4", VA = "0x29F5DA4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x29F867C", Offset = "0x29F867C", VA = "0x29F867C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB53D4", Offset = "0xCB53D4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB53D4", Offset = "0xCB53D4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public enum RotationMode
		{
			[Token(Token = "0x4000488")]
			TwoDOF,
			[Token(Token = "0x4000489")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class Multiplier
		{
			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9E28", Offset = "0xCB9E28")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9E60", Offset = "0xCB9E60")]
			public float multiplier;

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x2DFD770", Offset = "0x2DFD770", VA = "0x2DFD770")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9BDC", Offset = "0xCB9BDC")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9C14", Offset = "0xCB9C14")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9C4C", Offset = "0xCB9C4C")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9C84", Offset = "0xCB9C84")]
		public Transform pivot;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9CBC", Offset = "0xCB9CBC")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9CF4", Offset = "0xCB9CF4")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9D2C", Offset = "0xCB9D2C")]
		public float twistWeight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9D64", Offset = "0xCB9D64")]
		public float swingWeight;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9D9C", Offset = "0xCB9D9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB9D9C", Offset = "0xCB9D9C")]
		public float threeDOFWeight;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9DF0", Offset = "0xCB9DF0")]
		public bool rotateOnce;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x29F8A20", Offset = "0x29F8A20", VA = "0x29F8A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE070", Offset = "0xCBE070")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x29F8A68", Offset = "0x29F8A68", VA = "0x29F8A68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE0A8", Offset = "0xCBE0A8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x29F8AB0", Offset = "0x29F8AB0", VA = "0x29F8AB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE0E0", Offset = "0xCBE0E0")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x29F8AF8", Offset = "0x29F8AF8", VA = "0x29F8AF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE118", Offset = "0xCBE118")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x29F8B40", Offset = "0x29F8B40", VA = "0x29F8B40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE150", Offset = "0xCBE150")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x29F8B88", Offset = "0x29F8B88", VA = "0x29F8B88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE188", Offset = "0xCBE188")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x29F8BD0", Offset = "0x29F8BD0", VA = "0x29F8BD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE1C0", Offset = "0xCBE1C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x29F8C18", Offset = "0x29F8C18", VA = "0x29F8C18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE1F8", Offset = "0xCBE1F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x29F486C", Offset = "0x29F486C", VA = "0x29F486C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x29F3558", Offset = "0x29F3558", VA = "0x29F3558")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x29F1CB0", Offset = "0x29F1CB0", VA = "0x29F1CB0")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x29F8E14", Offset = "0x29F8E14", VA = "0x29F8E14")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB5434", Offset = "0xCB5434")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB5434", Offset = "0xCB5434")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class CharacterPosition
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9ED0", Offset = "0xCB9ED0")]
			public bool use;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9F08", Offset = "0xCB9F08")]
			public Vector2 offset;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB9F40", Offset = "0xCB9F40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9F40", Offset = "0xCB9F40")]
			public float angleOffset;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCB9F9C", Offset = "0xCB9F9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9F9C", Offset = "0xCB9F9C")]
			public float maxAngle;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9FF4", Offset = "0xCB9FF4")]
			public float radius;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA02C", Offset = "0xCBA02C")]
			public bool orbit;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA064", Offset = "0xCBA064")]
			public bool fixYAxis;

			[Token(Token = "0x1700008C")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x2DFDAE0", Offset = "0x2DFDAE0", VA = "0x2DFDAE0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x2DFDAEC", Offset = "0x2DFDAEC", VA = "0x2DFDAEC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x2DFDB74", Offset = "0x2DFDB74", VA = "0x2DFDB74")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x2DFDFB8", Offset = "0x2DFDFB8", VA = "0x2DFDFB8")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class CameraPosition
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA09C", Offset = "0xCBA09C")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA0D4", Offset = "0xCBA0D4")]
			public Vector3 direction;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA10C", Offset = "0xCBA10C")]
			public float maxDistance;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA144", Offset = "0xCBA144")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA144", Offset = "0xCBA144")]
			public float maxAngle;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA19C", Offset = "0xCBA19C")]
			public bool fixYAxis;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x2DFD778", Offset = "0x2DFD778", VA = "0x2DFD778")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2DFD86C", Offset = "0x2DFD86C", VA = "0x2DFD86C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x2DFDA94", Offset = "0x2DFDA94", VA = "0x2DFDA94")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000094")]
			public class Interaction
			{
				[Token(Token = "0x400049E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA29C", Offset = "0xCBA29C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400049F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA2D4", Offset = "0xCBA2D4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000548")]
				[Address(RVA = "0x2E0147C", Offset = "0x2E0147C", VA = "0x2E0147C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA1F4", Offset = "0xCBA1F4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA22C", Offset = "0xCBA22C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA264", Offset = "0xCBA264")]
			public Interaction[] interactions;

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x2DFDFCC", Offset = "0x2DFDFCC", VA = "0x2DFDFCC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x2DFE080", Offset = "0x2DFE080", VA = "0x2DFE080")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCB9E98", Offset = "0xCB9E98")]
		public Range[] ranges;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x29F8E60", Offset = "0x29F8E60", VA = "0x29F8E60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE230", Offset = "0xCBE230")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x29F8EA8", Offset = "0x29F8EA8", VA = "0x29F8EA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE268", Offset = "0xCBE268")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x29F8EF0", Offset = "0x29F8EF0", VA = "0x29F8EF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE2A0", Offset = "0xCBE2A0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x29F8F38", Offset = "0x29F8F38", VA = "0x29F8F38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE2D8", Offset = "0xCBE2D8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x29F8F80", Offset = "0x29F8F80", VA = "0x29F8F80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE310", Offset = "0xCBE310")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x29F7A00", Offset = "0x29F7A00", VA = "0x29F7A00")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x29F8FC8", Offset = "0x29F8FC8", VA = "0x29F8FC8")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000096")]
		public class Map
		{
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x2952998", Offset = "0x2952998", VA = "0x2952998")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x29529D4", Offset = "0x29529D4", VA = "0x29529D4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x2952A24", Offset = "0x2952A24", VA = "0x2952A24")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x2952A70", Offset = "0x2952A70", VA = "0x2952A70")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2A345CC", Offset = "0x2A345CC", VA = "0x2A345CC", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE348", Offset = "0xCBE348")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2A34948", Offset = "0x2A34948", VA = "0x2A34948", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2A3494C", Offset = "0x2A3494C", VA = "0x2A3494C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2A34A54", Offset = "0x2A34A54", VA = "0x2A34A54", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x2A348DC", Offset = "0x2A348DC", VA = "0x2A348DC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2A3483C", Offset = "0x2A3483C", VA = "0x2A3483C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2A34AC0", Offset = "0x2A34AC0", VA = "0x2A34AC0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2A3B344", Offset = "0x2A3B344", VA = "0x2A3B344", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2A3B40C", Offset = "0x2A3B40C", VA = "0x2A3B40C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2A3B5C8", Offset = "0x2A3B5C8", VA = "0x2A3B5C8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2A3B6C4", Offset = "0x2A3B6C4", VA = "0x2A3B6C4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2A3B464", Offset = "0x2A3B464", VA = "0x2A3B464")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2A3BA24", Offset = "0x2A3BA24", VA = "0x2A3BA24")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA30C", Offset = "0xCBA30C")]
		public float weight;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA324", Offset = "0xCBA324")]
		public float localRotationWeight;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA33C", Offset = "0xCBA33C")]
		public float localPositionWeight;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600055A")]
		public abstract void AutoMapping();

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x29FBC44", Offset = "0x29FBC44", VA = "0x29FBC44")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600055C")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600055D")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600055E")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x29FBC50", Offset = "0x29FBC50", VA = "0x29FBC50", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x29FBCA4", Offset = "0x29FBCA4", VA = "0x29FBCA4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x29FBCE0", Offset = "0x29FBCE0", VA = "0x29FBCE0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x29FBCF8", Offset = "0x29FBCF8", VA = "0x29FBCF8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200009A")]
		public class Rigidbone
		{
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x2DFF100", Offset = "0x2DFF100", VA = "0x2DFF100")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x2DFF270", Offset = "0x2DFF270", VA = "0x2DFF270")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x2DFF350", Offset = "0x2DFF350", VA = "0x2DFF350")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009B")]
		public class Child
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000578")]
			[Address(RVA = "0x2DFEF10", Offset = "0x2DFEF10", VA = "0x2DFEF10")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x2DFEF70", Offset = "0x2DFEF70", VA = "0x2DFEF70")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x2DFF0B0", Offset = "0x2DFF0B0", VA = "0x2DFF0B0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5494", Offset = "0xCB5494")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000090")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600057E")]
				[Address(RVA = "0x2DFEEC0", Offset = "0x2DFEEC0", VA = "0x2DFEEC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000580")]
				[Address(RVA = "0x2DFEF08", Offset = "0x2DFEF08", VA = "0x2DFEF08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2DFECA4", Offset = "0x2DFECA4", VA = "0x2DFECA4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2DFECD0", Offset = "0x2DFECD0", VA = "0x2DFECD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x2DFECD4", Offset = "0x2DFECD4", VA = "0x2DFECD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x2DFEEC8", Offset = "0x2DFEEC8", VA = "0x2DFEEC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA354", Offset = "0xCBA354")]
		public IK ik;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA38C", Offset = "0xCBA38C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA3C4", Offset = "0xCBA3C4")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA3FC", Offset = "0xCBA3FC")]
		public float applyVelocity;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA434", Offset = "0xCBA434")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700008E")]
		private bool isRagdoll
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x29FCAF4", Offset = "0x29FCAF4", VA = "0x29FCAF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		private bool ikUsed
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x29FD47C", Offset = "0x29FD47C", VA = "0x29FD47C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x29FCABC", Offset = "0x29FCABC", VA = "0x29FCABC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x29FCB6C", Offset = "0x29FCB6C", VA = "0x29FCB6C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x29FCC9C", Offset = "0x29FCC9C", VA = "0x29FCC9C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x29FCC30", Offset = "0x29FCC30", VA = "0x29FCC30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCBE380", Offset = "0xCBE380")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x29FD0B8", Offset = "0x29FD0B8", VA = "0x29FD0B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x29FD304", Offset = "0x29FD304", VA = "0x29FD304")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x29FD3C0", Offset = "0x29FD3C0", VA = "0x29FD3C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x29FD5FC", Offset = "0x29FD5FC", VA = "0x29FD5FC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x29FD440", Offset = "0x29FD440", VA = "0x29FD440")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x29FD5B8", Offset = "0x29FD5B8", VA = "0x29FD5B8")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x29FD69C", Offset = "0x29FD69C", VA = "0x29FD69C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x29FD630", Offset = "0x29FD630", VA = "0x29FD630")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x29FCBC4", Offset = "0x29FCBC4", VA = "0x29FCBC4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x29FD344", Offset = "0x29FD344", VA = "0x29FD344")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x29FD8C8", Offset = "0x29FD8C8", VA = "0x29FD8C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x29FD9E0", Offset = "0x29FD9E0", VA = "0x29FD9E0")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBA47C", Offset = "0xCBA47C")]
		private bool <defaultLocalRotationOverride>k__BackingField;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000092")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x29FEBDC", Offset = "0x29FEBDC", VA = "0x29FEBDC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000093")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x29FEBE8", Offset = "0x29FEBE8", VA = "0x29FEBE8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x29FEC04", Offset = "0x29FEC04", VA = "0x29FEC04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE430", Offset = "0xCBE430")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x29FEC0C", Offset = "0x29FEC0C", VA = "0x29FEC0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE440", Offset = "0xCBE440")]
			private set
			{
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x29FE8DC", Offset = "0x29FE8DC", VA = "0x29FE8DC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x29FE924", Offset = "0x29FE924", VA = "0x29FE924")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x29FE93C", Offset = "0x29FE93C", VA = "0x29FE93C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x29FEB34", Offset = "0x29FEB34", VA = "0x29FEB34")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x29FEBA4", Offset = "0x29FEBA4", VA = "0x29FEBA4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600058A")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x29FEA5C", Offset = "0x29FEA5C", VA = "0x29FEA5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x29FEC18", Offset = "0x29FEC18", VA = "0x29FEC18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x29FEC1C", Offset = "0x29FEC1C", VA = "0x29FEC1C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x29FEC50", Offset = "0x29FEC50", VA = "0x29FEC50")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x29FECCC", Offset = "0x29FECCC", VA = "0x29FECCC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x29FEE60", Offset = "0x29FEE60", VA = "0x29FEE60")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x29FEED0", Offset = "0x29FEED0", VA = "0x29FEED0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB54A4", Offset = "0xCB54A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB54A4", Offset = "0xCB54A4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA48C", Offset = "0xCBA48C")]
		public float limit;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA4A8", Offset = "0xCBA4A8")]
		public float twistLimit;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x29FEF04", Offset = "0x29FEF04", VA = "0x29FEF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE450", Offset = "0xCBE450")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x29FEF4C", Offset = "0x29FEF4C", VA = "0x29FEF4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE488", Offset = "0xCBE488")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x29FEF94", Offset = "0x29FEF94", VA = "0x29FEF94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE4C0", Offset = "0xCBE4C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x29FEFDC", Offset = "0x29FEFDC", VA = "0x29FEFDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE4F8", Offset = "0xCBE4F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x29FF024", Offset = "0x29FF024", VA = "0x29FF024", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x29FF068", Offset = "0x29FF068", VA = "0x29FF068")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x29FF228", Offset = "0x29FF228", VA = "0x29FF228")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB5504", Offset = "0xCB5504")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB5504", Offset = "0xCB5504")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x29FF268", Offset = "0x29FF268", VA = "0x29FF268")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE530", Offset = "0xCBE530")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x29FF2B0", Offset = "0x29FF2B0", VA = "0x29FF2B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE568", Offset = "0xCBE568")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x29FF2F8", Offset = "0x29FF2F8", VA = "0x29FF2F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE5A0", Offset = "0xCBE5A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x29FF340", Offset = "0x29FF340", VA = "0x29FF340")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE5D8", Offset = "0xCBE5D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x29FF388", Offset = "0x29FF388", VA = "0x29FF388", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x29FF38C", Offset = "0x29FF38C", VA = "0x29FF38C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x29FF510", Offset = "0x29FF510", VA = "0x29FF510")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB5564", Offset = "0xCB5564")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB5564", Offset = "0xCB5564")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
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

			[Token(Token = "0x17000095")]
			public Vector3 o
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0x2DFF758", Offset = "0x2DFF758", VA = "0x2DFF758")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 a
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x2DFF790", Offset = "0x2DFF790", VA = "0x2DFF790")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 b
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x2DFF7CC", Offset = "0x2DFF7CC", VA = "0x2DFF7CC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 c
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x2DFF808", Offset = "0x2DFF808", VA = "0x2DFF808")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public bool isValid
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x2DFF980", Offset = "0x2DFF980", VA = "0x2DFF980")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2DFF844", Offset = "0x2DFF844", VA = "0x2DFF844")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x2DFF990", Offset = "0x2DFF990", VA = "0x2DFF990")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class LimitPoint
		{
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x2DFF71C", Offset = "0x2DFF71C", VA = "0x2DFF71C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA4D4", Offset = "0xCBA4D4")]
		public float twistLimit;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA4F0", Offset = "0xCBA4F0")]
		public int smoothIterations;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x29FF558", Offset = "0x29FF558", VA = "0x29FF558")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE610", Offset = "0xCBE610")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x29FF5A0", Offset = "0x29FF5A0", VA = "0x29FF5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE648", Offset = "0xCBE648")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x29FF5E8", Offset = "0x29FF5E8", VA = "0x29FF5E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE680", Offset = "0xCBE680")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x29FF630", Offset = "0x29FF630", VA = "0x29FF630")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE6B8", Offset = "0xCBE6B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x29FF678", Offset = "0x29FF678", VA = "0x29FF678")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x29FFB18", Offset = "0x29FFB18", VA = "0x29FFB18", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x29FFBAC", Offset = "0x29FFBAC", VA = "0x29FFBAC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2A000D8", Offset = "0x2A000D8", VA = "0x2A000D8")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x29FF714", Offset = "0x29FF714", VA = "0x29FF714")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x2A00458", Offset = "0x2A00458", VA = "0x2A00458")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2A00864", Offset = "0x2A00864", VA = "0x2A00864")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2A008A8", Offset = "0x2A008A8", VA = "0x2A008A8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2A00908", Offset = "0x2A00908", VA = "0x2A00908")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x29FFE68", Offset = "0x29FFE68", VA = "0x29FFE68")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2A00974", Offset = "0x2A00974", VA = "0x2A00974")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2A00A50", Offset = "0x2A00A50", VA = "0x2A00A50")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xCB55C4", Offset = "0xCB55C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCB55C4", Offset = "0xCB55C4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA538", Offset = "0xCBA538")]
		public float twistLimit;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2A00AC4", Offset = "0x2A00AC4", VA = "0x2A00AC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE6F0", Offset = "0xCBE6F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2A00B0C", Offset = "0x2A00B0C", VA = "0x2A00B0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE728", Offset = "0xCBE728")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2A00B54", Offset = "0x2A00B54", VA = "0x2A00B54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE760", Offset = "0xCBE760")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2A00B9C", Offset = "0x2A00B9C", VA = "0x2A00B9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xCBE798", Offset = "0xCBE798")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2A00BE4", Offset = "0x2A00BE4", VA = "0x2A00BE4")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2A00C00", Offset = "0x2A00C00", VA = "0x2A00C00", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2A00C44", Offset = "0x2A00C44", VA = "0x2A00C44")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2A00E68", Offset = "0x2A00E68", VA = "0x2A00E68")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5624", Offset = "0xCB5624")]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005CA")]
				[Address(RVA = "0x2951E40", Offset = "0x2951E40", VA = "0x2951E40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005CC")]
				[Address(RVA = "0x2951E88", Offset = "0x2951E88", VA = "0x2951E88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x2951D50", Offset = "0x2951D50", VA = "0x2951D50")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2951D7C", Offset = "0x2951D7C", VA = "0x2951D7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2951D80", Offset = "0x2951D80", VA = "0x2951D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x2951E48", Offset = "0x2951E48", VA = "0x2951E48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA564", Offset = "0xCBA564")]
		public AimIK ik;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA59C", Offset = "0xCBA59C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA59C", Offset = "0xCBA59C")]
		public float weight;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBA5F0", Offset = "0xCBA5F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA5F0", Offset = "0xCBA5F0")]
		public Transform target;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA650", Offset = "0xCBA650")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA688", Offset = "0xCBA688")]
		public float weightSmoothTime;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA6C0", Offset = "0xCBA6C0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBA6C0", Offset = "0xCBA6C0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA720", Offset = "0xCBA720")]
		public float maxRadiansDelta;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA758", Offset = "0xCBA758")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA790", Offset = "0xCBA790")]
		public float slerpSpeed;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA7C8", Offset = "0xCBA7C8")]
		public float smoothDampTime;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA800", Offset = "0xCBA800")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA838", Offset = "0xCBA838")]
		public float minDistance;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA870", Offset = "0xCBA870")]
		public Vector3 offset;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBA8A8", Offset = "0xCBA8A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA8A8", Offset = "0xCBA8A8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBA8A8", Offset = "0xCBA8A8")]
		public float maxRootAngle;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA924", Offset = "0xCBA924")]
		public bool turnToTarget;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA95C", Offset = "0xCBA95C")]
		public float turnToTargetTime;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBA994", Offset = "0xCBA994")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA994", Offset = "0xCBA994")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBA9F4", Offset = "0xCBA9F4")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700009A")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x29A50CC", Offset = "0x29A50CC", VA = "0x29A50CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x29A5044", Offset = "0x29A5044", VA = "0x29A5044")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x29A515C", Offset = "0x29A515C", VA = "0x29A515C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x29A5830", Offset = "0x29A5830", VA = "0x29A5830")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x29A591C", Offset = "0x29A591C", VA = "0x29A591C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x29A5B6C", Offset = "0x29A5B6C", VA = "0x29A5B6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCBE7D0", Offset = "0xCBE7D0")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x29A5BD8", Offset = "0x29A5BD8", VA = "0x29A5BD8")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Pose
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x2951E90", Offset = "0x2951E90", VA = "0x2951E90")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x295201C", Offset = "0x295201C", VA = "0x295201C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2952024", Offset = "0x2952024", VA = "0x2952024")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x29A5E3C", Offset = "0x29A5E3C", VA = "0x29A5E3C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x29A5F1C", Offset = "0x29A5F1C", VA = "0x29A5F1C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x29A5F88", Offset = "0x29A5F88", VA = "0x29A5F88")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000AA")]
			public class EffectorLink
			{
				[Token(Token = "0x400051E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBABB4", Offset = "0xCBABB4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400051F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBABEC", Offset = "0xCBABEC")]
				public float weight;

				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x2E01060", Offset = "0x2E01060", VA = "0x2E01060")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAA64", Offset = "0xCBAA64")]
			public Transform transform;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAA9C", Offset = "0xCBAA9C")]
			public Transform relativeTo;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAAD4", Offset = "0xCBAAD4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAB0C", Offset = "0xCBAB0C")]
			public float verticalWeight;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAB44", Offset = "0xCBAB44")]
			public float horizontalWeight;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAB7C", Offset = "0xCBAB7C")]
			public float speed;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x2952040", Offset = "0x2952040", VA = "0x2952040")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x2952364", Offset = "0x2952364", VA = "0x2952364")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x2952374", Offset = "0x2952374", VA = "0x2952374")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAA2C", Offset = "0xCBAA2C")]
		public Body[] bodies;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x29A5FEC", Offset = "0x29A5FEC", VA = "0x29A5FEC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x29A6138", Offset = "0x29A6138", VA = "0x29A6138")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAC24", Offset = "0xCBAC24")]
		public float tiltSpeed;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAC5C", Offset = "0xCBAC5C")]
		public float tiltSensitivity;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAC94", Offset = "0xCBAC94")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBACCC", Offset = "0xCBACCC")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x29B1D54", Offset = "0x29B1D54", VA = "0x29B1D54", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x29B1D9C", Offset = "0x29B1D9C", VA = "0x29B1D9C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x29B1F54", Offset = "0x29B1F54", VA = "0x29B1F54")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBAD04", Offset = "0xCBAD04")]
		public float weight;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x29B1F68", Offset = "0x29B1F68", VA = "0x29B1F68")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x29B2030", Offset = "0x29B2030", VA = "0x29B2030")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x29B2258", Offset = "0x29B2258", VA = "0x29B2258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x29B2364", Offset = "0x29B2364", VA = "0x29B2364")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAD1C", Offset = "0xCBAD1C")]
		public Animator animator;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAD54", Offset = "0xCBAD54")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBAD9C", Offset = "0xCBAD9C")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009D")]
		public IK ik
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x29B2C3C", Offset = "0x29B2C3C", VA = "0x29B2C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE880", Offset = "0xCBE880")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x29B2C44", Offset = "0x29B2C44", VA = "0x29B2C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE890", Offset = "0xCBE890")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x29B2C4C", Offset = "0x29B2C4C", VA = "0x29B2C4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x29B2DE8", Offset = "0x29B2DE8", VA = "0x29B2DE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x29B3074", Offset = "0x29B3074", VA = "0x29B3074")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x29B31BC", Offset = "0x29B31BC", VA = "0x29B31BC")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x29B3388", Offset = "0x29B3388", VA = "0x29B3388")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x29B35B8", Offset = "0x29B35B8", VA = "0x29B35B8")]
		public void Update()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x29B3854", Offset = "0x29B3854", VA = "0x29B3854")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xCB5644", Offset = "0xCB5644")]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x1700009E")]
		public bool poseStored
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x29B2EE0", Offset = "0x29B2EE0", VA = "0x29B2EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x29B3234", Offset = "0x29B3234", VA = "0x29B3234")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x29B2F04", Offset = "0x29B2F04", VA = "0x29B2F04")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x29B38B0", Offset = "0x29B38B0", VA = "0x29B38B0")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAE1C", Offset = "0xCBAE1C")]
			public string name;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAE54", Offset = "0xCBAE54")]
			public Collider collider;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAE8C", Offset = "0xCBAE8C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBAED8", Offset = "0xCBAED8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBAEE8", Offset = "0xCBAEE8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBAEF8", Offset = "0xCBAEF8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBAF08", Offset = "0xCBAF08")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A0")]
			public bool inProgress
			{
				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x295470C", Offset = "0x295470C", VA = "0x295470C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			protected float crossFader
			{
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x2954720", Offset = "0x2954720", VA = "0x2954720")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE8A0", Offset = "0xCBE8A0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x2954728", Offset = "0x2954728", VA = "0x2954728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE8B0", Offset = "0xCBE8B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected float timer
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0x2954730", Offset = "0x2954730", VA = "0x2954730")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE8C0", Offset = "0xCBE8C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x2954738", Offset = "0x2954738", VA = "0x2954738")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE8D0", Offset = "0xCBE8D0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 force
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x2954740", Offset = "0x2954740", VA = "0x2954740")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE8E0", Offset = "0xCBE8E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x295474C", Offset = "0x295474C", VA = "0x295474C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE8F0", Offset = "0xCBE8F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected Vector3 point
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x2954758", Offset = "0x2954758", VA = "0x2954758")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE900", Offset = "0xCBE900")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x2954764", Offset = "0x2954764", VA = "0x2954764")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE910", Offset = "0xCBE910")]
				private set
				{
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x2954770", Offset = "0x2954770", VA = "0x2954770")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x29548A4", Offset = "0x29548A4", VA = "0x29548A4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005FC")]
			protected abstract float GetLength();

			[Token(Token = "0x60005FD")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60005FE")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x2954978", Offset = "0x2954978", VA = "0x2954978")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B2")]
			public class EffectorLink
			{
				[Token(Token = "0x400053D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAFC0", Offset = "0xCBAFC0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAFF8", Offset = "0xCBAFF8")]
				public float weight;

				[Token(Token = "0x400053F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000540")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000604")]
				[Address(RVA = "0x2E011D0", Offset = "0x2E011D0", VA = "0x2E011D0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000605")]
				[Address(RVA = "0x2E01280", Offset = "0x2E01280", VA = "0x2E01280")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000606")]
				[Address(RVA = "0x2E01294", Offset = "0x2E01294", VA = "0x2E01294")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAF18", Offset = "0xCBAF18")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAF50", Offset = "0xCBAF50")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBAF88", Offset = "0xCBAF88")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x2954CA4", Offset = "0x2954CA4", VA = "0x2954CA4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x2954DD4", Offset = "0x2954DD4", VA = "0x2954DD4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2954E40", Offset = "0x2954E40", VA = "0x2954E40", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x2954FA8", Offset = "0x2954FA8", VA = "0x2954FA8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B4")]
			public class BoneLink
			{
				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB0A0", Offset = "0xCBB0A0")]
				public Transform bone;

				[Token(Token = "0x4000545")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB0D8", Offset = "0xCBB0D8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBB0D8", Offset = "0xCBB0D8")]
				public float weight;

				[Token(Token = "0x4000546")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000547")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600060B")]
				[Address(RVA = "0x2E01068", Offset = "0x2E01068", VA = "0x2E01068")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600060C")]
				[Address(RVA = "0x2E01180", Offset = "0x2E01180", VA = "0x2E01180")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060D")]
				[Address(RVA = "0x2E0118C", Offset = "0x2E0118C", VA = "0x2E0118C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB030", Offset = "0xCBB030")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB068", Offset = "0xCBB068")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x295498C", Offset = "0x295498C", VA = "0x295498C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x2954A30", Offset = "0x2954A30", VA = "0x2954A30", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x2954A9C", Offset = "0x2954A9C", VA = "0x2954A9C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x2954C90", Offset = "0x2954C90", VA = "0x2954C90")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBADAC", Offset = "0xCBADAC")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBADE4", Offset = "0xCBADE4")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009F")]
		public bool inProgress
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2A3C8C4", Offset = "0x2A3C8C4", VA = "0x2A3C8C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2A3C994", Offset = "0x2A3C994", VA = "0x2A3C994", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2A3CA70", Offset = "0x2A3CA70", VA = "0x2A3CA70")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2A3CCCC", Offset = "0x2A3CCCC", VA = "0x2A3CCCC")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public abstract class Offset
		{
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB19C", Offset = "0xCBB19C")]
			public string name;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB1D4", Offset = "0xCBB1D4")]
			public Collider collider;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB20C", Offset = "0xCBB20C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBB258", Offset = "0xCBB258")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBB268", Offset = "0xCBB268")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBB278", Offset = "0xCBB278")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBB288", Offset = "0xCBB288")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A5")]
			protected float crossFader
			{
				[Token(Token = "0x6000611")]
				[Address(RVA = "0x2954FBC", Offset = "0x2954FBC", VA = "0x2954FBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE920", Offset = "0xCBE920")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x2954FC4", Offset = "0x2954FC4", VA = "0x2954FC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE930", Offset = "0xCBE930")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x2954FCC", Offset = "0x2954FCC", VA = "0x2954FCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE940", Offset = "0xCBE940")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000614")]
				[Address(RVA = "0x2954FD4", Offset = "0x2954FD4", VA = "0x2954FD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE950", Offset = "0xCBE950")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x2954FDC", Offset = "0x2954FDC", VA = "0x2954FDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE960", Offset = "0xCBE960")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x2954FE8", Offset = "0x2954FE8", VA = "0x2954FE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE970", Offset = "0xCBE970")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x2954FF4", Offset = "0x2954FF4", VA = "0x2954FF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE980", Offset = "0xCBE980")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x2955000", Offset = "0x2955000", VA = "0x2955000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBE990", Offset = "0xCBE990")]
				private set
				{
				}
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x295500C", Offset = "0x295500C", VA = "0x295500C")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x2955154", Offset = "0x2955154", VA = "0x2955154")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600061B")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x600061C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600061D")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x295523C", Offset = "0x295523C", VA = "0x295523C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B8")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000558")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB340", Offset = "0xCBB340")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000559")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB378", Offset = "0xCBB378")]
				public float weight;

				[Token(Token = "0x400055A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000623")]
				[Address(RVA = "0x2E0129C", Offset = "0x2E0129C", VA = "0x2E0129C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000624")]
				[Address(RVA = "0x2E0132C", Offset = "0x2E0132C", VA = "0x2E0132C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000625")]
				[Address(RVA = "0x2E01340", Offset = "0x2E01340", VA = "0x2E01340")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB298", Offset = "0xCBB298")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB2D0", Offset = "0xCBB2D0")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB308", Offset = "0xCBB308")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x2955250", Offset = "0x2955250", VA = "0x2955250", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x2955400", Offset = "0x2955400", VA = "0x2955400", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x295546C", Offset = "0x295546C", VA = "0x295546C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x295560C", Offset = "0x295560C", VA = "0x295560C")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B9")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BA")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB420", Offset = "0xCBB420")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBB458", Offset = "0xCBB458")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB458", Offset = "0xCBB458")]
				public float weight;

				[Token(Token = "0x4000561")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000562")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600062A")]
				[Address(RVA = "0x2E01348", Offset = "0x2E01348", VA = "0x2E01348")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600062B")]
				[Address(RVA = "0x2E01424", Offset = "0x2E01424", VA = "0x2E01424")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600062C")]
				[Address(RVA = "0x2E01430", Offset = "0x2E01430", VA = "0x2E01430")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB3B0", Offset = "0xCBB3B0")]
			public int curveIndex;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB3E8", Offset = "0xCBB3E8")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x2955628", Offset = "0x2955628", VA = "0x2955628", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x295570C", Offset = "0x295570C", VA = "0x295570C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x2955778", Offset = "0x2955778", VA = "0x2955778", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x2955A2C", Offset = "0x2955A2C", VA = "0x2955A2C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB12C", Offset = "0xCBB12C")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB164", Offset = "0xCBB164")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2A3CCD4", Offset = "0x2A3CCD4", VA = "0x2A3CCD4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2A3CDA8", Offset = "0x2A3CDA8", VA = "0x2A3CDA8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x2A3D00C", Offset = "0x2A3D00C", VA = "0x2A3D00C")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BD")]
			public class EffectorLink
			{
				[Token(Token = "0x4000570")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB688", Offset = "0xCBB688")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000571")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB6C0", Offset = "0xCBB6C0")]
				public float weight;

				[Token(Token = "0x6000633")]
				[Address(RVA = "0x2E01474", Offset = "0x2E01474", VA = "0x2E01474")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB51C", Offset = "0xCBB51C")]
			public Transform transform;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB554", Offset = "0xCBB554")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB58C", Offset = "0xCBB58C")]
			public float speed;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB5C4", Offset = "0xCBB5C4")]
			public float acceleration;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB5FC", Offset = "0xCBB5FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBB5FC", Offset = "0xCBB5FC")]
			public float matchVelocity;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB650", Offset = "0xCBB650")]
			public float gravity;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x2DFC7E4", Offset = "0x2DFC7E4", VA = "0x2DFC7E4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x2DFC89C", Offset = "0x2DFC89C", VA = "0x2DFC89C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x2DFCB58", Offset = "0x2DFCB58", VA = "0x2DFCB58")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB4AC", Offset = "0xCBB4AC")]
		public Body[] bodies;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB4E4", Offset = "0xCBB4E4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x29F0BDC", Offset = "0x29F0BDC", VA = "0x29F0BDC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x29F0C58", Offset = "0x29F0C58", VA = "0x29F0C58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x29F0E00", Offset = "0x29F0E00", VA = "0x29F0E00")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB6F8", Offset = "0xCBB6F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBB6F8", Offset = "0xCBB6F8")]
		public Transform target;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBB758", Offset = "0xCBB758")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB770", Offset = "0xCBB770")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB7A8", Offset = "0xCBB7A8")]
		public float weightSmoothTime;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBB7E0", Offset = "0xCBB7E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB7E0", Offset = "0xCBB7E0")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB840", Offset = "0xCBB840")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB878", Offset = "0xCBB878")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB8B0", Offset = "0xCBB8B0")]
		public float slerpSpeed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB8E8", Offset = "0xCBB8E8")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB920", Offset = "0xCBB920")]
		public float minDistance;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCBB958", Offset = "0xCBB958")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB958", Offset = "0xCBB958")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBB958", Offset = "0xCBB958")]
		public float maxRootAngle;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000A9")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x29FA150", Offset = "0x29FA150", VA = "0x29FA150")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x29FA0DC", Offset = "0x29FA0DC", VA = "0x29FA0DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x29FA1E0", Offset = "0x29FA1E0", VA = "0x29FA1E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x29FA710", Offset = "0x29FA710", VA = "0x29FA710")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x29FA7FC", Offset = "0x29FA7FC", VA = "0x29FA7FC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x29FA9F4", Offset = "0x29FA9F4", VA = "0x29FA9F4")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBA44", Offset = "0xCBBA44")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBA7C", Offset = "0xCBBA7C")]
			public float spring;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBAB4", Offset = "0xCBBAB4")]
			public bool x;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBAEC", Offset = "0xCBBAEC")]
			public bool y;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBB24", Offset = "0xCBBB24")]
			public bool z;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBB5C", Offset = "0xCBBB5C")]
			public float minX;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBB94", Offset = "0xCBBB94")]
			public float maxX;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBBCC", Offset = "0xCBBBCC")]
			public float minY;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBC04", Offset = "0xCBBC04")]
			public float maxY;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBC3C", Offset = "0xCBBC3C")]
			public float minZ;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBC74", Offset = "0xCBBC74")]
			public float maxZ;

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x2DFE260", Offset = "0x2DFE260", VA = "0x2DFE260")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x2DFE3B8", Offset = "0x2DFE3B8", VA = "0x2DFE3B8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x2DFE430", Offset = "0x2DFE430", VA = "0x2DFE430")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x2DFE488", Offset = "0x2DFE488", VA = "0x2DFE488")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB5698", Offset = "0xCB5698")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x2DFE210", Offset = "0x2DFE210", VA = "0x2DFE210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x2DFE258", Offset = "0x2DFE258", VA = "0x2DFE258", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x2DFE090", Offset = "0x2DFE090", VA = "0x2DFE090")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x2DFE0BC", Offset = "0x2DFE0BC", VA = "0x2DFE0BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x2DFE0C0", Offset = "0x2DFE0C0", VA = "0x2DFE0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x2DFE218", Offset = "0x2DFE218", VA = "0x2DFE218", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBB9D4", Offset = "0xCBB9D4")]
		public float weight;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBA0C", Offset = "0xCBBA0C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AA")]
		protected float deltaTime
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x29F0D14", Offset = "0x29F0D14", VA = "0x29F0D14")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600063B")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x29FB494", Offset = "0x29FB494", VA = "0x29FB494", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x29FB4C0", Offset = "0x29FB4C0", VA = "0x29FB4C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCBE9A0", Offset = "0xCBE9A0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x29FB52C", Offset = "0x29FB52C", VA = "0x29FB52C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x29F0D40", Offset = "0x29F0D40", VA = "0x29F0D40")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x29FB608", Offset = "0x29FB608", VA = "0x29FB608", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x29F0E10", Offset = "0x29F0E10", VA = "0x29F0E10")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB56A8", Offset = "0xCB56A8")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x2DFE610", Offset = "0x2DFE610", VA = "0x2DFE610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000658")]
				[Address(RVA = "0x2DFE658", Offset = "0x2DFE658", VA = "0x2DFE658", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2DFE490", Offset = "0x2DFE490", VA = "0x2DFE490")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x2DFE4BC", Offset = "0x2DFE4BC", VA = "0x2DFE4BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x2DFE4C0", Offset = "0x2DFE4C0", VA = "0x2DFE4C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x2DFE618", Offset = "0x2DFE618", VA = "0x2DFE618", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBCAC", Offset = "0xCBBCAC")]
		public float weight;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBCE4", Offset = "0xCBBCE4")]
		public VRIK ik;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AD")]
		protected float deltaTime
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x29FB714", Offset = "0x29FB714", VA = "0x29FB714")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600064D")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x29FB740", Offset = "0x29FB740", VA = "0x29FB740", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x29FB76C", Offset = "0x29FB76C", VA = "0x29FB76C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCBEA50", Offset = "0xCBEA50")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x29FB7D8", Offset = "0x29FB7D8", VA = "0x29FB7D8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x29FB8B4", Offset = "0x29FB8B4", VA = "0x29FB8B4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x29FB9C0", Offset = "0x29FB9C0", VA = "0x29FB9C0")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public class EffectorLink
		{
			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x2DFE660", Offset = "0x2DFE660", VA = "0x2DFE660")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x2DFE87C", Offset = "0x2DFE87C", VA = "0x2DFE87C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x29FB9D0", Offset = "0x29FB9D0", VA = "0x29FB9D0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x29FBA94", Offset = "0x29FBA94", VA = "0x29FBA94")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x29FBB50", Offset = "0x29FBB50", VA = "0x29FBB50")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000C8")]
			public class EffectorLink
			{
				[Token(Token = "0x40005AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBEF8", Offset = "0xCBBEF8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBF30", Offset = "0xCBBF30")]
				public float weight;

				[Token(Token = "0x6000664")]
				[Address(RVA = "0x2E01484", Offset = "0x2E01484", VA = "0x2E01484")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBD54", Offset = "0xCBBD54")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBD8C", Offset = "0xCBBD8C")]
			public Transform raycastTo;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBDC4", Offset = "0xCBBDC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBBDC4", Offset = "0xCBBDC4")]
			public float raycastRadius;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBE18", Offset = "0xCBBE18")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBE50", Offset = "0xCBBE50")]
			public float smoothTimeIn;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBE88", Offset = "0xCBBE88")]
			public float smoothTimeOut;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBEC0", Offset = "0xCBBEC0")]
			public LayerMask layers;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x2DFE884", Offset = "0x2DFE884", VA = "0x2DFE884")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x2DFE9C8", Offset = "0x2DFE9C8", VA = "0x2DFE9C8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x2DFEAC0", Offset = "0x2DFEAC0", VA = "0x2DFEAC0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x2DFEC90", Offset = "0x2DFEC90", VA = "0x2DFEC90")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBD1C", Offset = "0xCBBD1C")]
		public Avoider[] avoiders;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x29FBBAC", Offset = "0x29FBBAC", VA = "0x29FBBAC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x29FBC34", Offset = "0x29FBC34", VA = "0x29FBC34")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000CB")]
			public class EffectorLink
			{
				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC2BC", Offset = "0xCBC2BC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC2F4", Offset = "0xCBC2F4")]
				public float weight;

				[Token(Token = "0x6000674")]
				[Address(RVA = "0x2E0148C", Offset = "0x2E0148C", VA = "0x2E0148C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC1C0", Offset = "0xCBC1C0")]
			public Vector3 offset;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBC1F8", Offset = "0xCBC1F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC1F8", Offset = "0xCBC1F8")]
			public float additivity;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC24C", Offset = "0xCBC24C")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC284", Offset = "0xCBC284")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2DFF4F4", Offset = "0x2DFF4F4", VA = "0x2DFF4F4")]
			public void Start()
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x2DFF544", Offset = "0x2DFF544", VA = "0x2DFF544")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x2DFF708", Offset = "0x2DFF708", VA = "0x2DFF708")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum Handedness
		{
			[Token(Token = "0x40005CF")]
			Right,
			[Token(Token = "0x40005D0")]
			Left
		}

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBF68", Offset = "0xCBBF68")]
		public AimIK aimIK;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBFA0", Offset = "0xCBBFA0")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBBFD8", Offset = "0xCBBFD8")]
		public Handedness handedness;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC010", Offset = "0xCBC010")]
		public bool twoHanded;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC048", Offset = "0xCBC048")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC080", Offset = "0xCBC080")]
		public float magnitudeRandom;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC0B8", Offset = "0xCBC0B8")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC0F0", Offset = "0xCBC0F0")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC128", Offset = "0xCBC128")]
		public float blendTime;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC160", Offset = "0xCBC160")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCBC160", Offset = "0xCBC160")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B0")]
		public bool isFinished
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x29FDACC", Offset = "0x29FDACC", VA = "0x29FDACC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x29FE544", Offset = "0x29FE544", VA = "0x29FE544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x29FE584", Offset = "0x29FE584", VA = "0x29FE584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform primaryHand
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x29FE504", Offset = "0x29FE504", VA = "0x29FE504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x29FE524", Offset = "0x29FE524", VA = "0x29FE524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x29FDAFC", Offset = "0x29FDAFC", VA = "0x29FDAFC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x29FDB28", Offset = "0x29FDB28", VA = "0x29FDB28")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x29FDC70", Offset = "0x29FDC70", VA = "0x29FDC70", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x29FE5C4", Offset = "0x29FE5C4", VA = "0x29FE5C4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x29FE678", Offset = "0x29FE678", VA = "0x29FE678")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x29FE6B4", Offset = "0x29FE6B4", VA = "0x29FE6B4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x29FE86C", Offset = "0x29FE86C", VA = "0x29FE86C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC32C", Offset = "0xCBC32C")]
		public float weight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC364", Offset = "0xCBC364")]
		public float offset;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2A00EA4", Offset = "0x2A00EA4", VA = "0x2A00EA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2A00F8C", Offset = "0x2A00F8C", VA = "0x2A00F8C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2A01074", Offset = "0x2A01074", VA = "0x2A01074")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2A013C8", Offset = "0x2A013C8", VA = "0x2A013C8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x2A01400", Offset = "0x2A01400", VA = "0x2A01400")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2A0150C", Offset = "0x2A0150C", VA = "0x2A0150C")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class Settings
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC39C", Offset = "0xCBC39C")]
			public float scaleMlp;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC3D4", Offset = "0xCBC3D4")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC40C", Offset = "0xCBC40C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC444", Offset = "0xCBC444")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC47C", Offset = "0xCBC47C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC4B4", Offset = "0xCBC4B4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC4EC", Offset = "0xCBC4EC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC524", Offset = "0xCBC524")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xCBC524", Offset = "0xCBC524")]
			public Vector3 headOffset;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC574", Offset = "0xCBC574")]
			public Vector3 handOffset;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC5AC", Offset = "0xCBC5AC")]
			public float footForwardOffset;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC5E4", Offset = "0xCBC5E4")]
			public float footInwardOffset;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCBC61C", Offset = "0xCBC61C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBC61C", Offset = "0xCBC61C")]
			public float footHeadingOffset;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBC678", Offset = "0xCBC678")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCBC690", Offset = "0xCBC690")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x2E00BC4", Offset = "0x2E00BC4", VA = "0x2E00BC4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000D1")]
			public class Target
			{
				[Token(Token = "0x40005EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40005F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40005F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x600068C")]
				[Address(RVA = "0x2E01494", Offset = "0x2E01494", VA = "0x2E01494")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600068D")]
				[Address(RVA = "0x2E01554", Offset = "0x2E01554", VA = "0x2E01554")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x2E00BBC", Offset = "0x2E00BBC", VA = "0x2E00BBC")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x294D808", Offset = "0x294D808", VA = "0x294D808")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x294D820", Offset = "0x294D820", VA = "0x294D820")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x294D958", Offset = "0x294D958", VA = "0x294D958")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x294D86C", Offset = "0x294D86C", VA = "0x294D86C")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x294D970", Offset = "0x294D970", VA = "0x294D970")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x294EB7C", Offset = "0x294EB7C", VA = "0x294EB7C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x294F368", Offset = "0x294F368", VA = "0x294F368")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x294FE50", Offset = "0x294FE50", VA = "0x294FE50")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2950260", Offset = "0x2950260", VA = "0x2950260")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2950474", Offset = "0x2950474", VA = "0x2950474")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2950B18", Offset = "0x2950B18", VA = "0x2950B18")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x29508C4", Offset = "0x29508C4", VA = "0x29508C4")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2950D88", Offset = "0x2950D88", VA = "0x2950D88")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2950FE4", Offset = "0x2950FE4", VA = "0x2950FE4")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x29510D4", Offset = "0x29510D4", VA = "0x29510D4")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D2")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x29513F0", Offset = "0x29513F0", VA = "0x29513F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2951444", Offset = "0x2951444", VA = "0x2951444")]
		private void Update()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2951478", Offset = "0x2951478", VA = "0x2951478")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x29515B4", Offset = "0x29515B4", VA = "0x29515B4")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBC6A8", Offset = "0xCBC6A8")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B5")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x29515CC", Offset = "0x29515CC", VA = "0x29515CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBEB00", Offset = "0xCBEB00")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x29515D8", Offset = "0x29515D8", VA = "0x29515D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCBEB10", Offset = "0xCBEB10")]
			private set
			{
			}
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x29515E4", Offset = "0x29515E4", VA = "0x29515E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x294F170", Offset = "0x294F170", VA = "0x294F170")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x29500DC", Offset = "0x29500DC", VA = "0x29500DC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x29516CC", Offset = "0x29516CC", VA = "0x29516CC")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2951AE8", Offset = "0x2951AE8", VA = "0x2951AE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x2951BF0", Offset = "0x2951BF0", VA = "0x2951BF0")]
		public VRIKRootController()
		{
		}
	}
}
namespace Cortopia.CortopiaExtensions
{
	[Token(Token = "0x20000D4")]
	public static class ColorExtensions
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x29B2500", Offset = "0x29B2500", VA = "0x29B2500")]
		public static Color WithR(this Color color, float value)
		{
			return default(Color);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x29B2508", Offset = "0x29B2508", VA = "0x29B2508")]
		public static Color WithG(this Color color, float value)
		{
			return default(Color);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x29B2510", Offset = "0x29B2510", VA = "0x29B2510")]
		public static Color WithB(this Color color, float value)
		{
			return default(Color);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x29B2518", Offset = "0x29B2518", VA = "0x29B2518")]
		public static Color WithA(this Color color, float value)
		{
			return default(Color);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x29B2520", Offset = "0x29B2520", VA = "0x29B2520")]
		public static Color WithRGB(this Color color, Color other)
		{
			return default(Color);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x29B2530", Offset = "0x29B2530", VA = "0x29B2530")]
		public static Color WithRGB(this Color color, float r, float g, float b)
		{
			return default(Color);
		}
	}
	[Token(Token = "0x20000D5")]
	public static class ExtensionMethods
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB56D8", Offset = "0xCB56D8")]
		private sealed class <>c__17<T>
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__17<T> <>9;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__17_0;

			[Token(Token = "0x60006B5")]
			public <>c__17()
			{
			}

			[Token(Token = "0x60006B6")]
			internal string <ToFormattedString>b__17_0(T p)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCB56E8", Offset = "0xCB56E8")]
		private sealed class <>c__18<TK, TV>
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__18<TK, TV> <>9;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TK, TV>, string> <>9__18_0;

			[Token(Token = "0x60006B8")]
			public <>c__18()
			{
			}

			[Token(Token = "0x60006B9")]
			internal string <ToFormattedString>b__18_0(KeyValuePair<TK, TV> p)
			{
				return null;
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x29B3930", Offset = "0x29B3930", VA = "0x29B3930")]
		public static int Wrap(this int value, int min, int max)
		{
			return default(int);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x29B394C", Offset = "0x29B394C", VA = "0x29B394C")]
		public static float Wrap(this float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x29B3968", Offset = "0x29B3968", VA = "0x29B3968")]
		public static bool IsWithinBounds(this float value, float minValue, float maxValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x29B3980", Offset = "0x29B3980", VA = "0x29B3980")]
		public static bool IsWithinBounds(this int value, int minValue, int maxValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x29B3998", Offset = "0x29B3998", VA = "0x29B3998")]
		public static string SplitCase(this string value)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x29B3A94", Offset = "0x29B3A94", VA = "0x29B3A94")]
		public static string UppercaseFirst(this string value)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x29B3B84", Offset = "0x29B3B84", VA = "0x29B3B84")]
		public static string Truncate(this string value, int maxLength)
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x29B3BE4", Offset = "0x29B3BE4", VA = "0x29B3BE4")]
		public static bool IsNullOrEmpty(this string value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A8")]
		public static T GetRandomElement<T>(this IEnumerable<T> enumerable)
		{
			return (T)null;
		}

		[Token(Token = "0x60006A9")]
		public static T GetRandomElement<T>(this List<T> list, T excludedElement)
		{
			return (T)null;
		}

		[Token(Token = "0x60006AA")]
		public static T GetRandomElement<T>(this List<T> list, IEnumerable<T> excludedElements)
		{
			return (T)null;
		}

		[Token(Token = "0x60006AB")]
		public static List<T> GetRandomElements<T>(this IEnumerable<T> enumerable, int amount)
		{
			return null;
		}

		[Token(Token = "0x60006AC")]
		public static T GetRandomElement<T>(this T[] array, T excludedElement)
		{
			return (T)null;
		}

		[Token(Token = "0x60006AD")]
		public static KeyValuePair<TK, TV> GetRandomElement<TK, TV>(this IDictionary<TK, TV> dictionary)
		{
			return default(KeyValuePair<TK, TV>);
		}

		[Token(Token = "0x60006AE")]
		public static List<T> Exclude<T>(this List<T> list, T excludedElement)
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		public static bool IsEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B0")]
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		public static string ToFormattedString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60006B2")]
		public static string ToFormattedString<TK, TV>(this IDictionary<TK, TV> dictionary)
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		public static bool ContainsFlag<T>(this Enum e, T mask) where T : struct, IConvertible
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000D8")]
	public enum ResetBehaviour
	{
		[Token(Token = "0x4000600")]
		Position = 1,
		[Token(Token = "0x4000601")]
		Rotation = 2,
		[Token(Token = "0x4000602")]
		Scale = 4,
		[Token(Token = "0x4000603")]
		PositionAndRotation = 3,
		[Token(Token = "0x4000604")]
		All = 7
	}
	[Token(Token = "0x20000D9")]
	public static class StringExtensions
	{
		[Token(Token = "0x4000605")]
		private const int NotFound = -1;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] NewLines;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2949A78", Offset = "0x2949A78", VA = "0x2949A78")]
		public static string Substring(this string text, string start, string end)
		{
			return null;
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2949B48", Offset = "0x2949B48", VA = "0x2949B48")]
		public static string Substring(this string text, string start, char end)
		{
			return null;
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2949C14", Offset = "0x2949C14", VA = "0x2949C14")]
		public static string[] Split(this string text, string separator)
		{
			return null;
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2949CCC", Offset = "0x2949CCC", VA = "0x2949CCC")]
		public static string[] Split(this string text, params string[] separator)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2949CE8", Offset = "0x2949CE8", VA = "0x2949CE8")]
		public static int IndexAfter(this string text, char value, int startIndex = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2949D14", Offset = "0x2949D14", VA = "0x2949D14")]
		public static int IndexAfter(this string text, string value, int startIndex = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x2949D58", Offset = "0x2949D58", VA = "0x2949D58")]
		public static int IndexOfNewLine(this string text, int startIndex = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2949E54", Offset = "0x2949E54", VA = "0x2949E54")]
		public static int LastIndexOfNewLine(this string text, int startIndex = 0)
		{
			return default(int);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2949F50", Offset = "0x2949F50", VA = "0x2949F50")]
		public static bool Contains(this string text, string toCheck, StringComparison comparison)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x2949F74", Offset = "0x2949F74", VA = "0x2949F74")]
		public static string GetAssetNameFromPath(this string path)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x294A03C", Offset = "0x294A03C", VA = "0x294A03C")]
		public static string ToPascalCase(this string text)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x294A17C", Offset = "0x294A17C", VA = "0x294A17C")]
		public static string ToPascalCase(this string text, bool lettersDigitsOnly)
		{
			return null;
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x294A214", Offset = "0x294A214", VA = "0x294A214")]
		public static string LettersAndDigits(this string text)
		{
			return null;
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x294A2B4", Offset = "0x294A2B4", VA = "0x294A2B4")]
		public static string ReplaceAt(this string text, string replace, int index, int length = 1)
		{
			return null;
		}
	}
	[Token(Token = "0x20000DA")]
	public static class UnityExtensionMethods
	{
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x294B6F8", Offset = "0x294B6F8", VA = "0x294B6F8")]
		public static void SetPositionAndRotation(this Transform transform, Transform otherTransform)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x294B78C", Offset = "0x294B78C", VA = "0x294B78C")]
		public static void SetLocalPositionAndRotation(this Transform transform, Transform otherTransform)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x294B7E4", Offset = "0x294B7E4", VA = "0x294B7E4")]
		public static void SetLocalPositionAndRotation(this Transform transform, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x294B848", Offset = "0x294B848", VA = "0x294B848")]
		public static bool IsPrefab(this GameObject gameObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x294B88C", Offset = "0x294B88C", VA = "0x294B88C")]
		public static Transform RetrieveOrCreateChild(this Transform transform, string childName, bool includeInactive = false)
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x294BA10", Offset = "0x294BA10", VA = "0x294BA10")]
		public static Transform RetrieveChild(this Transform transform, string childName, bool includeInactive = false, bool includePartials = false)
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x294BB70", Offset = "0x294BB70", VA = "0x294BB70")]
		public static void SetParent(this Transform transform, Transform parent, ResetBehaviour resetBehaviour)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x294BC94", Offset = "0x294BC94", VA = "0x294BC94")]
		public static List<Transform> RetrieveChildren(this Transform transform, string childName, bool includeInactive = false, bool includePartials = false)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x294BE20", Offset = "0x294BE20", VA = "0x294BE20")]
		public static Transform FindFirstChildWithName(this Transform transform, string childName)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x294C170", Offset = "0x294C170", VA = "0x294C170")]
		public static bool HasParameterOfType(this Animator animator, string parameterName, AnimatorControllerParameterType parameterType)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D3")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		public static T GetOrAddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		public static T GetOrAddComponent<T>(this Transform transform) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x294C234", Offset = "0x294C234", VA = "0x294C234")]
		public static float GetRoll(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x294C264", Offset = "0x294C264", VA = "0x294C264")]
		public static float GetPitch(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x294C294", Offset = "0x294C294", VA = "0x294C294")]
		public static float GetYaw(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x294C2AC", Offset = "0x294C2AC", VA = "0x294C2AC")]
		public static bool IsValid(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x294C2DC", Offset = "0x294C2DC", VA = "0x294C2DC")]
		public static bool IsValidThorough(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x294C388", Offset = "0x294C388", VA = "0x294C388")]
		public static bool AlmostEquals(this Vector3 first, Vector3 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x294C3D4", Offset = "0x294C3D4", VA = "0x294C3D4")]
		public static bool AlmostEquals(this Vector2 first, Vector2 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x294C410", Offset = "0x294C410", VA = "0x294C410")]
		public static bool AlmostEquals(this Quaternion first, Quaternion second, float maxAngle)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x294C474", Offset = "0x294C474", VA = "0x294C474")]
		public static bool AlmostEquals(this float first, float second, float floatDiff)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x294C484", Offset = "0x294C484", VA = "0x294C484")]
		public static float InverseLerp(this Vector3 value, Vector3 min, Vector3 max)
		{
			return default(float);
		}
	}
}
