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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE578", Offset = "0x9EE578")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE578", Offset = "0x9EE578")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF03C", Offset = "0x9EF03C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF03C", Offset = "0x9EF03C")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF094", Offset = "0x9EF094")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF094", Offset = "0x9EF094")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF0EC", Offset = "0x9EF0EC")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF124", Offset = "0x9EF124")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF15C", Offset = "0x9EF15C")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF194", Offset = "0x9EF194")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF1CC", Offset = "0x9EF1CC")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF204", Offset = "0x9EF204")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF23C", Offset = "0x9EF23C")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF274", Offset = "0x9EF274")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF284", Offset = "0x9EF284")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF2B4", Offset = "0x9EF2B4")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x224370C", Offset = "0x224370C", VA = "0x224370C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F75DC", Offset = "0x9F75DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2243714", Offset = "0x2243714", VA = "0x2243714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F75EC", Offset = "0x9F75EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2243720", Offset = "0x2243720", VA = "0x2243720")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F75FC", Offset = "0x9F75FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2243728", Offset = "0x2243728", VA = "0x2243728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F760C", Offset = "0x9F760C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2243730", Offset = "0x2243730", VA = "0x2243730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F761C", Offset = "0x9F761C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2243738", Offset = "0x2243738", VA = "0x2243738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F762C", Offset = "0x9F762C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x22435EC", Offset = "0x22435EC", VA = "0x22435EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F74FC", Offset = "0x9F74FC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2243634", Offset = "0x2243634", VA = "0x2243634")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7534", Offset = "0x9F7534")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x224367C", Offset = "0x224367C", VA = "0x224367C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F756C", Offset = "0x9F756C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x22436C4", Offset = "0x22436C4", VA = "0x22436C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F75A4", Offset = "0x9F75A4")]
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
		[Address(RVA = "0x2243740", Offset = "0x2243740", VA = "0x2243740")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2243744", Offset = "0x2243744", VA = "0x2243744")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2243748", Offset = "0x2243748", VA = "0x2243748")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x224374C", Offset = "0x224374C", VA = "0x224374C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF2C4", Offset = "0x9EF2C4")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF2FC", Offset = "0x9EF2FC")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF334", Offset = "0x9EF334")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF36C", Offset = "0x9EF36C")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF3A4", Offset = "0x9EF3A4")]
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
		[Address(RVA = "0x22DF450", Offset = "0x22DF450", VA = "0x22DF450")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x22DF854", Offset = "0x22DF854", VA = "0x22DF854", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x22DF85C", Offset = "0x22DF85C", VA = "0x22DF85C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x22DF96C", Offset = "0x22DF96C", VA = "0x22DF96C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x22DF9E8", Offset = "0x22DF9E8", VA = "0x22DF9E8", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x22DFA64", Offset = "0x22DFA64", VA = "0x22DFA64", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x22DF6AC", Offset = "0x22DF6AC", VA = "0x22DF6AC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x22DF780", Offset = "0x22DF780", VA = "0x22DF780")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x22DFAE0", Offset = "0x22DFAE0", VA = "0x22DFAE0")]
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
		[Address(RVA = "0x1F5CC4C", Offset = "0x1F5CC4C", VA = "0x1F5CC4C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x22429C0", Offset = "0x22429C0", VA = "0x22429C0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2242C28", Offset = "0x2242C28", VA = "0x2242C28")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2242C08", Offset = "0x2242C08", VA = "0x2242C08")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x22431EC", Offset = "0x22431EC", VA = "0x22431EC")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2244B00", Offset = "0x2244B00", VA = "0x2244B00")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2246430", Offset = "0x2246430", VA = "0x2246430")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2244554", Offset = "0x2244554", VA = "0x2244554")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2244B48", Offset = "0x2244B48", VA = "0x2244B48")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2244084", Offset = "0x2244084", VA = "0x2244084")]
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
		[Address(RVA = "0x2243868", Offset = "0x2243868", VA = "0x2243868")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2243B7C", Offset = "0x2243B7C", VA = "0x2243B7C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2243A20", Offset = "0x2243A20", VA = "0x2243A20")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2243D58", Offset = "0x2243D58", VA = "0x2243D58")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x22442E8", Offset = "0x22442E8", VA = "0x22442E8")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22443E4", Offset = "0x22443E4", VA = "0x22443E4")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22444E0", Offset = "0x22444E0", VA = "0x22444E0")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2244458", Offset = "0x2244458", VA = "0x2244458")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x224474C", Offset = "0x224474C", VA = "0x224474C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2244800", Offset = "0x2244800", VA = "0x2244800")]
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
		[Address(RVA = "0x2244B4C", Offset = "0x2244B4C", VA = "0x2244B4C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2244BC8", Offset = "0x2244BC8", VA = "0x2244BC8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2245664", Offset = "0x2245664", VA = "0x2245664")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2245718", Offset = "0x2245718", VA = "0x2245718")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2245600", Offset = "0x2245600", VA = "0x2245600")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2245810", Offset = "0x2245810", VA = "0x2245810")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2245858", Offset = "0x2245858", VA = "0x2245858")]
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
		[Address(RVA = "0x2245860", Offset = "0x2245860", VA = "0x2245860")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2245A50", Offset = "0x2245A50", VA = "0x2245A50")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2245A64", Offset = "0x2245A64", VA = "0x2245A64")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2245D50", Offset = "0x2245D50", VA = "0x2245D50")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x224590C", Offset = "0x224590C", VA = "0x224590C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2246004", Offset = "0x2246004", VA = "0x2246004")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2246078", Offset = "0x2246078", VA = "0x2246078")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x224622C", Offset = "0x224622C", VA = "0x224622C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF3DC", Offset = "0x9EF3DC")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF414", Offset = "0x9EF414")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF414", Offset = "0x9EF414")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF46C", Offset = "0x9EF46C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF46C", Offset = "0x9EF46C")]
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
		[Address(RVA = "0x2413EB0", Offset = "0x2413EB0", VA = "0x2413EB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2414444", Offset = "0x2414444", VA = "0x2414444", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2414460", Offset = "0x2414460", VA = "0x2414460", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x241453C", Offset = "0x241453C", VA = "0x241453C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2414618", Offset = "0x2414618", VA = "0x2414618", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x24147E8", Offset = "0x24147E8", VA = "0x24147E8", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2414B20", Offset = "0x2414B20", VA = "0x2414B20")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2414BFC", Offset = "0x2414BFC", VA = "0x2414BFC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9EF4C0", Offset = "0x9EF4C0")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9EF4F8", Offset = "0x9EF4F8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9EF530", Offset = "0x9EF530")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9EF568", Offset = "0x9EF568")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF5A0", Offset = "0x9EF5A0")]
		public float blockedOffset;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF5B8", Offset = "0x9EF5B8")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF5C8", Offset = "0x9EF5C8")]
		private float <y>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF5D8", Offset = "0x9EF5D8")]
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
			[Address(RVA = "0x224FD0C", Offset = "0x224FD0C", VA = "0x224FD0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F763C", Offset = "0x9F763C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x224FD14", Offset = "0x224FD14", VA = "0x224FD14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F764C", Offset = "0x9F764C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x224FD1C", Offset = "0x224FD1C", VA = "0x224FD1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F765C", Offset = "0x9F765C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x224FD24", Offset = "0x224FD24", VA = "0x224FD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F766C", Offset = "0x9F766C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x224FD2C", Offset = "0x224FD2C", VA = "0x224FD2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F767C", Offset = "0x9F767C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x224FD34", Offset = "0x224FD34", VA = "0x224FD34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F768C", Offset = "0x9F768C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x225061C", Offset = "0x225061C", VA = "0x225061C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x224FD3C", Offset = "0x224FD3C", VA = "0x224FD3C")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x224FD78", Offset = "0x224FD78", VA = "0x224FD78")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x224FD80", Offset = "0x224FD80", VA = "0x224FD80", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x224FE90", Offset = "0x224FE90", VA = "0x224FE90", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x224FEEC", Offset = "0x224FEEC", VA = "0x224FEEC", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x224FF54", Offset = "0x224FF54", VA = "0x224FF54", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x224FFB8", Offset = "0x224FFB8", VA = "0x224FFB8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x224FEC4", Offset = "0x224FEC4", VA = "0x224FEC4")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2250138", Offset = "0x2250138", VA = "0x2250138")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x22505EC", Offset = "0x22505EC", VA = "0x22505EC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x225068C", Offset = "0x225068C", VA = "0x225068C")]
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
		[Address(RVA = "0x2250738", Offset = "0x2250738", VA = "0x2250738")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2250770", Offset = "0x2250770", VA = "0x2250770")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2250918", Offset = "0x2250918", VA = "0x2250918")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2250948", Offset = "0x2250948", VA = "0x2250948")]
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
		[Address(RVA = "0x22431F4", Offset = "0x22431F4", VA = "0x22431F4")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2243218", Offset = "0x2243218", VA = "0x2243218")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2243250", Offset = "0x2243250", VA = "0x2243250")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2243340", Offset = "0x2243340", VA = "0x2243340")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x22432E8", Offset = "0x22432E8", VA = "0x22432E8")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x22433D8", Offset = "0x22433D8", VA = "0x22433D8")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2243420", Offset = "0x2243420", VA = "0x2243420")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x22435E4", Offset = "0x22435E4", VA = "0x22435E4")]
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
			[Address(RVA = "0x1F66144", Offset = "0x1F66144", VA = "0x1F66144")]
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
			[Address(RVA = "0x2248048", Offset = "0x2248048", VA = "0x2248048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x22482B8", Offset = "0x22482B8", VA = "0x22482B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2247FC8", Offset = "0x2247FC8", VA = "0x2247FC8")]
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
		[Address(RVA = "0x2248528", Offset = "0x2248528", VA = "0x2248528")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x224884C", Offset = "0x224884C", VA = "0x224884C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2248AC0", Offset = "0x2248AC0", VA = "0x2248AC0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2248B40", Offset = "0x2248B40", VA = "0x2248B40")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2248BE8", Offset = "0x2248BE8", VA = "0x2248BE8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2248700", Offset = "0x2248700", VA = "0x2248700")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2248A24", Offset = "0x2248A24", VA = "0x2248A24")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2249418", Offset = "0x2249418", VA = "0x2249418")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2249220", Offset = "0x2249220", VA = "0x2249220")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x224931C", Offset = "0x224931C", VA = "0x224931C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2248E00", Offset = "0x2248E00", VA = "0x2248E00")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2248EB0", Offset = "0x2248EB0", VA = "0x2248EB0")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2248F60", Offset = "0x2248F60", VA = "0x2248F60")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2249010", Offset = "0x2249010", VA = "0x2249010")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x22490C0", Offset = "0x22490C0", VA = "0x22490C0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2249170", Offset = "0x2249170", VA = "0x2249170")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2249620", Offset = "0x2249620", VA = "0x2249620")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2248D18", Offset = "0x2248D18", VA = "0x2248D18")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2249590", Offset = "0x2249590", VA = "0x2249590")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x224968C", Offset = "0x224968C", VA = "0x224968C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2249760", Offset = "0x2249760", VA = "0x2249760")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2249518", Offset = "0x2249518", VA = "0x2249518")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x22494A4", Offset = "0x22494A4", VA = "0x22494A4")]
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
				[Address(RVA = "0x1F661D0", Offset = "0x1F661D0", VA = "0x1F661D0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1F661BC", Offset = "0x1F661BC", VA = "0x1F661BC")]
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
			[Address(RVA = "0x224BFC8", Offset = "0x224BFC8", VA = "0x224BFC8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x224C3B0", Offset = "0x224C3B0", VA = "0x224C3B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x224C3C0", Offset = "0x224C3C0", VA = "0x224C3C0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x224C7E8", Offset = "0x224C7E8", VA = "0x224C7E8", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x224CC1C", Offset = "0x224CC1C", VA = "0x224CC1C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x224D2EC", Offset = "0x224D2EC", VA = "0x224D2EC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x224CE48", Offset = "0x224CE48", VA = "0x224CE48")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x224729C", Offset = "0x224729C", VA = "0x224729C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x224DB70", Offset = "0x224DB70", VA = "0x224DB70")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x224E12C", Offset = "0x224E12C", VA = "0x224E12C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x224DF0C", Offset = "0x224DF0C", VA = "0x224DF0C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x224DD88", Offset = "0x224DD88", VA = "0x224DD88")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x224DC10", Offset = "0x224DC10", VA = "0x224DC10")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x224E018", Offset = "0x224E018", VA = "0x224E018")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x224E224", Offset = "0x224E224", VA = "0x224E224")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x224EE0C", Offset = "0x224EE0C", VA = "0x224EE0C")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x224E87C", Offset = "0x224E87C", VA = "0x224E87C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x224F108", Offset = "0x224F108", VA = "0x224F108")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x224EBF4", Offset = "0x224EBF4", VA = "0x224EBF4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x224F110", Offset = "0x224F110", VA = "0x224F110")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x224F118", Offset = "0x224F118", VA = "0x224F118")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x224F2EC", Offset = "0x224F2EC", VA = "0x224F2EC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x224F4B4", Offset = "0x224F4B4", VA = "0x224F4B4")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x224771C", Offset = "0x224771C", VA = "0x224771C")]
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
		[Address(RVA = "0x22D3758", Offset = "0x22D3758", VA = "0x22D3758")]
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
		[Address(RVA = "0x22D4008", Offset = "0x22D4008", VA = "0x22D4008")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x22D4150", Offset = "0x22D4150", VA = "0x22D4150")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2411D7C", Offset = "0x2411D7C", VA = "0x2411D7C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2411F68", Offset = "0x2411F68", VA = "0x2411F68")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2411E14", Offset = "0x2411E14", VA = "0x2411E14")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2412088", Offset = "0x2412088", VA = "0x2412088")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x24121B4", Offset = "0x24121B4", VA = "0x24121B4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2412408", Offset = "0x2412408", VA = "0x2412408")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2412510", Offset = "0x2412510", VA = "0x2412510")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2412684", Offset = "0x2412684", VA = "0x2412684")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2412A60", Offset = "0x2412A60", VA = "0x2412A60")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2412824", Offset = "0x2412824", VA = "0x2412824")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2412C14", Offset = "0x2412C14", VA = "0x2412C14")]
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
		[Address(RVA = "0x240D044", Offset = "0x240D044", VA = "0x240D044")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x240D0D0", Offset = "0x240D0D0", VA = "0x240D0D0")]
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
		[Address(RVA = "0x209C418", Offset = "0x209C418", VA = "0x209C418")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x209CDC4", Offset = "0x209CDC4", VA = "0x209CDC4")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x209CE38", Offset = "0x209CE38", VA = "0x209CE38")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x209C82C", Offset = "0x209C82C", VA = "0x209C82C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x209C838", Offset = "0x209C838", VA = "0x209C838")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x209C85C", Offset = "0x209C85C", VA = "0x209C85C")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x209C898", Offset = "0x209C898", VA = "0x209C898")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x209C8B0", Offset = "0x209C8B0", VA = "0x209C8B0")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x209C8C4", Offset = "0x209C8C4", VA = "0x209C8C4")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x209C8D8", Offset = "0x209C8D8", VA = "0x209C8D8")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x209C8E8", Offset = "0x209C8E8", VA = "0x209C8E8")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x209C930", Offset = "0x209C930", VA = "0x209C930")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x209C968", Offset = "0x209C968", VA = "0x209C968")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x209C990", Offset = "0x209C990", VA = "0x209C990")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x209CEC4", Offset = "0x209CEC4", VA = "0x209CEC4")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x209C9C4", Offset = "0x209C9C4", VA = "0x209C9C4")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x209C9EC", Offset = "0x209C9EC", VA = "0x209C9EC")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x209CA1C", Offset = "0x209CA1C", VA = "0x209CA1C")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x209CA50", Offset = "0x209CA50", VA = "0x209CA50")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x209CA94", Offset = "0x209CA94", VA = "0x209CA94")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x209CAF8", Offset = "0x209CAF8", VA = "0x209CAF8")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x209CB5C", Offset = "0x209CB5C", VA = "0x209CB5C")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x209CBB0", Offset = "0x209CBB0", VA = "0x209CBB0")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x209CC04", Offset = "0x209CC04", VA = "0x209CC04")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x209CC40", Offset = "0x209CC40", VA = "0x209CC40")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x209CC78", Offset = "0x209CC78", VA = "0x209CC78")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x209CEF8", Offset = "0x209CEF8", VA = "0x209CEF8")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x209CCC0", Offset = "0x209CCC0", VA = "0x209CCC0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x209CD54", Offset = "0x209CD54", VA = "0x209CD54")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x209CD84", Offset = "0x209CD84", VA = "0x209CD84")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x209CF8C", Offset = "0x209CF8C", VA = "0x209CF8C")]
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
		[Address(RVA = "0x209D048", Offset = "0x209D048", VA = "0x209D048")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x209D0D4", Offset = "0x209D0D4", VA = "0x209D0D4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x209D164", Offset = "0x209D164", VA = "0x209D164")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x209D1BC", Offset = "0x209D1BC", VA = "0x209D1BC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x209D288", Offset = "0x209D288", VA = "0x209D288")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x209D1D4", Offset = "0x209D1D4", VA = "0x209D1D4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x209D2A0", Offset = "0x209D2A0", VA = "0x209D2A0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x209D344", Offset = "0x209D344", VA = "0x209D344")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x209D370", Offset = "0x209D370", VA = "0x209D370")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x209D3C0", Offset = "0x209D3C0", VA = "0x209D3C0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x209D42C", Offset = "0x209D42C", VA = "0x209D42C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x209D540", Offset = "0x209D540", VA = "0x209D540")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x209D638", Offset = "0x209D638", VA = "0x209D638")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x209D694", Offset = "0x209D694", VA = "0x209D694")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x20A3F0C", Offset = "0x20A3F0C", VA = "0x20A3F0C")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x20A3F68", Offset = "0x20A3F68", VA = "0x20A3F68")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x20A3FF8", Offset = "0x20A3FF8", VA = "0x20A3FF8")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x20A4158", Offset = "0x20A4158", VA = "0x20A4158")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x20A4214", Offset = "0x20A4214", VA = "0x20A4214")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x20A42D0", Offset = "0x20A42D0", VA = "0x20A42D0")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x20A447C", Offset = "0x20A447C", VA = "0x20A447C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x20A44CC", Offset = "0x20A44CC", VA = "0x20A44CC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x20A451C", Offset = "0x20A451C", VA = "0x20A451C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x20A45C4", Offset = "0x20A45C4", VA = "0x20A45C4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x209C048", Offset = "0x209C048", VA = "0x209C048")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x20A466C", Offset = "0x20A466C", VA = "0x20A466C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x209C128", Offset = "0x209C128", VA = "0x209C128")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x20A3724", Offset = "0x20A3724", VA = "0x20A3724")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x20A46C0", Offset = "0x20A46C0", VA = "0x20A46C0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x20A4850", Offset = "0x20A4850", VA = "0x20A4850")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x20A4944", Offset = "0x20A4944", VA = "0x20A4944")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x20A4A50", Offset = "0x20A4A50", VA = "0x20A4A50")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x20A4B3C", Offset = "0x20A4B3C", VA = "0x20A4B3C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF5F8", Offset = "0x9EF5F8")]
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
			[Address(RVA = "0x1F5C738", Offset = "0x1F5C738", VA = "0x1F5C738")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1F5CA84", Offset = "0x1F5CA84", VA = "0x1F5CA84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1F5C5F8", Offset = "0x1F5C5F8", VA = "0x1F5C5F8")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1F5C698", Offset = "0x1F5C698", VA = "0x1F5C698", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1F5C69C", Offset = "0x1F5C69C", VA = "0x1F5C69C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1F5C6A0", Offset = "0x1F5C6A0", VA = "0x1F5C6A0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1F5C6A4", Offset = "0x1F5C6A4", VA = "0x1F5C6A4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1F5C734", Offset = "0x1F5C734", VA = "0x1F5C734")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1F5C6DC", Offset = "0x1F5C6DC", VA = "0x1F5C6DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1F5CA38", Offset = "0x1F5CA38", VA = "0x1F5CA38")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1F5C824", Offset = "0x1F5C824", VA = "0x1F5C824")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1F5CB3C", Offset = "0x1F5CB3C", VA = "0x1F5CB3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1F5CB98", Offset = "0x1F5CB98", VA = "0x1F5CB98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1F5CBF4", Offset = "0x1F5CBF4", VA = "0x1F5CBF4")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1F5CC3C", Offset = "0x1F5CC3C", VA = "0x1F5CC3C")]
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
		[Address(RVA = "0x1F5D2B0", Offset = "0x1F5D2B0", VA = "0x1F5D2B0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1F5D370", Offset = "0x1F5D370", VA = "0x1F5D370")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1F5D430", Offset = "0x1F5D430", VA = "0x1F5D430")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1F5D4F0", Offset = "0x1F5D4F0", VA = "0x1F5D4F0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V2Tools
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1F5F45C", Offset = "0x1F5F45C", VA = "0x1F5F45C")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1F5F464", Offset = "0x1F5F464", VA = "0x1F5F464")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1F5F4B4", Offset = "0x1F5F4B4", VA = "0x1F5F4B4")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1F5F508", Offset = "0x1F5F508", VA = "0x1F5F508")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1F5F5E0", Offset = "0x1F5F5E0", VA = "0x1F5F5E0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1F5F674", Offset = "0x1F5F674", VA = "0x1F5F674")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1F5F698", Offset = "0x1F5F698", VA = "0x1F5F698")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1F5F6E0", Offset = "0x1F5F6E0", VA = "0x1F5F6E0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1F5F76C", Offset = "0x1F5F76C", VA = "0x1F5F76C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1F5F7CC", Offset = "0x1F5F7CC", VA = "0x1F5F7CC")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1F5F82C", Offset = "0x1F5F82C", VA = "0x1F5F82C")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1F5F948", Offset = "0x1F5F948", VA = "0x1F5F948")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1F5F9E8", Offset = "0x1F5F9E8", VA = "0x1F5F9E8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1F5FA24", Offset = "0x1F5FA24", VA = "0x1F5FA24")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1F5FA68", Offset = "0x1F5FA68", VA = "0x1F5FA68")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1F5FB04", Offset = "0x1F5FB04", VA = "0x1F5FB04")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1F5FC60", Offset = "0x1F5FC60", VA = "0x1F5FC60")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1F5FDDC", Offset = "0x1F5FDDC", VA = "0x1F5FDDC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1F5FF60", Offset = "0x1F5FF60", VA = "0x1F5FF60")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1F6001C", Offset = "0x1F6001C", VA = "0x1F6001C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1F6011C", Offset = "0x1F6011C", VA = "0x1F6011C")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1F601A4", Offset = "0x1F601A4", VA = "0x1F601A4")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1F60240", Offset = "0x1F60240", VA = "0x1F60240")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1F602E4", Offset = "0x1F602E4", VA = "0x1F602E4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1F602D4", Offset = "0x1F602D4", VA = "0x1F602D4")]
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
		[Address(RVA = "0x1F659A4", Offset = "0x1F659A4", VA = "0x1F659A4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1F65A3C", Offset = "0x1F65A3C", VA = "0x1F65A3C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE5E8", Offset = "0x9EE5E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE5E8", Offset = "0x9EE5E8")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x224693C", Offset = "0x224693C", VA = "0x224693C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F770C", Offset = "0x9F770C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2246984", Offset = "0x2246984", VA = "0x2246984")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7744", Offset = "0x9F7744")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x22469CC", Offset = "0x22469CC", VA = "0x22469CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F777C", Offset = "0x9F777C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2246A14", Offset = "0x2246A14", VA = "0x2246A14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F77B4", Offset = "0x9F77B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2246A5C", Offset = "0x2246A5C", VA = "0x2246A5C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2246AF8", Offset = "0x2246AF8", VA = "0x2246AF8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2246B18", Offset = "0x2246B18", VA = "0x2246B18")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2246B48", Offset = "0x2246B48", VA = "0x2246B48")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2246B78", Offset = "0x2246B78", VA = "0x2246B78")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2246BB8", Offset = "0x2246BB8", VA = "0x2246BB8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2246BFC", Offset = "0x2246BFC", VA = "0x2246BFC")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2246C20", Offset = "0x2246C20", VA = "0x2246C20")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2246C44", Offset = "0x2246C44", VA = "0x2246C44")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2246C6C", Offset = "0x2246C6C", VA = "0x2246C6C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2246C98", Offset = "0x2246C98", VA = "0x2246C98")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2246CC4", Offset = "0x2246CC4", VA = "0x2246CC4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2246A7C", Offset = "0x2246A7C", VA = "0x2246A7C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2246CEC", Offset = "0x2246CEC", VA = "0x2246CEC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2246CF8", Offset = "0x2246CF8", VA = "0x2246CF8")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2246D04", Offset = "0x2246D04", VA = "0x2246D04")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2247028", Offset = "0x2247028", VA = "0x2247028", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x22470D0", Offset = "0x22470D0", VA = "0x22470D0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x22474BC", Offset = "0x22474BC", VA = "0x22474BC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2247648", Offset = "0x2247648", VA = "0x2247648")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x224767C", Offset = "0x224767C", VA = "0x224767C")]
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
			[Address(RVA = "0x2246EA4", Offset = "0x2246EA4", VA = "0x2246EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2247974", Offset = "0x2247974", VA = "0x2247974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2247398", Offset = "0x2247398", VA = "0x2247398")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x22477A0", Offset = "0x22477A0", VA = "0x22477A0")]
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
			[Address(RVA = "0x22D3760", Offset = "0x22D3760", VA = "0x22D3760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x22D37CC", Offset = "0x22D37CC", VA = "0x22D37CC")]
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
		[Address(RVA = "0x22D37D4", Offset = "0x22D37D4", VA = "0x22D37D4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x22D3894", Offset = "0x22D3894", VA = "0x22D3894")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x22D389C", Offset = "0x22D389C", VA = "0x22D389C")]
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
			[Address(RVA = "0x22D39D8", Offset = "0x22D39D8", VA = "0x22D39D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x22D38D0", Offset = "0x22D38D0", VA = "0x22D38D0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x22D3A14", Offset = "0x22D3A14", VA = "0x22D3A14")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x22D3A1C", Offset = "0x22D3A1C", VA = "0x22D3A1C")]
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
		[Address(RVA = "0x22D3A50", Offset = "0x22D3A50", VA = "0x22D3A50", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x22D3AD0", Offset = "0x22D3AD0", VA = "0x22D3AD0")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x22D3AD8", Offset = "0x22D3AD8", VA = "0x22D3AD8")]
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
			[Address(RVA = "0x22D3C14", Offset = "0x22D3C14", VA = "0x22D3C14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x22D3B0C", Offset = "0x22D3B0C", VA = "0x22D3B0C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x22D3C50", Offset = "0x22D3C50", VA = "0x22D3C50")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x22D3C58", Offset = "0x22D3C58", VA = "0x22D3C58")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF630", Offset = "0x9EF630")]
		public float positionWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF648", Offset = "0x9EF648")]
		public float rotationWeight;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x22D3C8C", Offset = "0x22D3C8C", VA = "0x22D3C8C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x22D3CF8", Offset = "0x22D3CF8", VA = "0x22D3CF8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x22D3D50", Offset = "0x22D3D50", VA = "0x22D3D50")]
		public void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x22D4000", Offset = "0x22D4000", VA = "0x22D4000")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF660", Offset = "0x9EF660")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF660", Offset = "0x9EF660")]
		public float weight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF6B4", Offset = "0x9EF6B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF6B4", Offset = "0x9EF6B4")]
		public float rotationWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF708", Offset = "0x9EF708")]
		public DOF rotationDOF;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF740", Offset = "0x9EF740")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF778", Offset = "0x9EF778")]
		public Transform bone1;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF7B0", Offset = "0x9EF7B0")]
		public Transform bone2;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF7E8", Offset = "0x9EF7E8")]
		public Transform bone3;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF820", Offset = "0x9EF820")]
		public Transform tip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF858", Offset = "0x9EF858")]
		public Transform target;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF890", Offset = "0x9EF890")]
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
			[Address(RVA = "0x22DD494", Offset = "0x22DD494", VA = "0x22DD494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F77EC", Offset = "0x9F77EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x22DD49C", Offset = "0x22DD49C", VA = "0x22DD49C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F77FC", Offset = "0x9F77FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x22DD4A8", Offset = "0x22DD4A8", VA = "0x22DD4A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x22DD4C8", Offset = "0x22DD4C8", VA = "0x22DD4C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x22DD4E8", Offset = "0x22DD4E8", VA = "0x22DD4E8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x22DD508", Offset = "0x22DD508", VA = "0x22DD508")]
			set
			{
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x22DD528", Offset = "0x22DD528", VA = "0x22DD528")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x22DD63C", Offset = "0x22DD63C", VA = "0x22DD63C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x22DDBCC", Offset = "0x22DDBCC", VA = "0x22DDBCC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x22DDCA4", Offset = "0x22DDCA4", VA = "0x22DDCA4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x22DDD68", Offset = "0x22DDD68", VA = "0x22DDD68")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x22DE1F0", Offset = "0x22DE1F0", VA = "0x22DE1F0")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF8A0", Offset = "0x9EF8A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF8A0", Offset = "0x9EF8A0")]
		public float weight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF8F4", Offset = "0x9EF8F4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x22DE200", Offset = "0x22DE200", VA = "0x22DE200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F780C", Offset = "0x9F780C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x22DE208", Offset = "0x22DE208", VA = "0x22DE208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F781C", Offset = "0x9F781C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x22DE214", Offset = "0x22DE214", VA = "0x22DE214")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x22DE29C", Offset = "0x22DE29C", VA = "0x22DE29C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F782C", Offset = "0x9F782C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x22DE628", Offset = "0x22DE628", VA = "0x22DE628")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x22DE7EC", Offset = "0x22DE7EC", VA = "0x22DE7EC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x22DE524", Offset = "0x22DE524", VA = "0x22DE524")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x22DE978", Offset = "0x22DE978", VA = "0x22DE978", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x22DEA38", Offset = "0x22DEA38", VA = "0x22DEA38")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x22DEAB0", Offset = "0x22DEAB0", VA = "0x22DEAB0")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x22DEB24", Offset = "0x22DEB24", VA = "0x22DEB24")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x22DEB8C", Offset = "0x22DEB8C", VA = "0x22DEB8C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x22DEB90", Offset = "0x22DEB90", VA = "0x22DEB90", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x22DEBA4", Offset = "0x22DEBA4", VA = "0x22DEBA4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF904", Offset = "0x9EF904")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EF904", Offset = "0x9EF904")]
		public float weight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF958", Offset = "0x9EF958")]
		public Grounding solver;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF990", Offset = "0x9EF990")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x22E0060", Offset = "0x22E0060", VA = "0x22E0060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7864", Offset = "0x9F7864")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x22E0068", Offset = "0x22E0068", VA = "0x22E0068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7874", Offset = "0x9F7874")]
			protected set
			{
			}
		}

		[Token(Token = "0x600016E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x22E0074", Offset = "0x22E0074", VA = "0x22E0074")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x22E0220", Offset = "0x22E0220", VA = "0x22E0220")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x22E0120", Offset = "0x22E0120", VA = "0x22E0120")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x22E0254", Offset = "0x22E0254", VA = "0x22E0254")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000175")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000176")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x22E0390", Offset = "0x22E0390", VA = "0x22E0390")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE648", Offset = "0x9EE648")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE648", Offset = "0x9EE648")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF9A0", Offset = "0x9EF9A0")]
		public BipedIK ik;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EF9D8", Offset = "0x9EF9D8")]
		public float spineBend;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFA10", Offset = "0x9EFA10")]
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
		[Address(RVA = "0x22E0408", Offset = "0x22E0408", VA = "0x22E0408", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7884", Offset = "0x9F7884")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x22E0450", Offset = "0x22E0450", VA = "0x22E0450", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F78BC", Offset = "0x9F78BC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x22E0498", Offset = "0x22E0498", VA = "0x22E0498", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x22E04D8", Offset = "0x22E04D8", VA = "0x22E04D8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x22E0584", Offset = "0x22E0584", VA = "0x22E0584")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x22E05E4", Offset = "0x22E05E4", VA = "0x22E05E4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x22E0904", Offset = "0x22E0904", VA = "0x22E0904")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x22E0958", Offset = "0x22E0958", VA = "0x22E0958")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x22E0D74", Offset = "0x22E0D74", VA = "0x22E0D74")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x22E0E48", Offset = "0x22E0E48", VA = "0x22E0E48")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x22E0F88", Offset = "0x22E0F88", VA = "0x22E0F88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x22E114C", Offset = "0x22E114C", VA = "0x22E114C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE6A8", Offset = "0x9EE6A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE6A8", Offset = "0x9EE6A8")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class SpineEffector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFAF0", Offset = "0x9EFAF0")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFB28", Offset = "0x9EFB28")]
			public float horizontalWeight;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFB60", Offset = "0x9EFB60")]
			public float verticalWeight;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1F66F84", Offset = "0x1F66F84", VA = "0x1F66F84")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1F66F94", Offset = "0x1F66F94", VA = "0x1F66F94")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFA48", Offset = "0x9EFA48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFA80", Offset = "0x9EFA80")]
		public float spineBend;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFAB8", Offset = "0x9EFAB8")]
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
		[Address(RVA = "0x22E159C", Offset = "0x22E159C", VA = "0x22E159C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F78F4", Offset = "0x9F78F4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x22E15E4", Offset = "0x22E15E4", VA = "0x22E15E4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F792C", Offset = "0x9F792C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x22E162C", Offset = "0x22E162C", VA = "0x22E162C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7964", Offset = "0x9F7964")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x22E1674", Offset = "0x22E1674", VA = "0x22E1674", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x22E16B4", Offset = "0x22E16B4", VA = "0x22E16B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x22E1748", Offset = "0x22E1748", VA = "0x22E1748")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x22E1A04", Offset = "0x22E1A04", VA = "0x22E1A04")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x22E1A10", Offset = "0x22E1A10", VA = "0x22E1A10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x22E17B0", Offset = "0x22E17B0", VA = "0x22E17B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x22E1A1C", Offset = "0x22E1A1C", VA = "0x22E1A1C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x22E1D3C", Offset = "0x22E1D3C", VA = "0x22E1D3C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x22E1E4C", Offset = "0x22E1E4C", VA = "0x22E1E4C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x22E1FC8", Offset = "0x22E1FC8", VA = "0x22E1FC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x22E2100", Offset = "0x22E2100", VA = "0x22E2100")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE708", Offset = "0x9EE708")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE708", Offset = "0x9EE708")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFB98", Offset = "0x9EFB98")]
		public Transform pelvis;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFBD0", Offset = "0x9EFBD0")]
		public Transform characterRoot;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFC08", Offset = "0x9EFC08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EFC08", Offset = "0x9EFC08")]
		public float rootRotationWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFC5C", Offset = "0x9EFC5C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFC94", Offset = "0x9EFC94")]
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
		[Address(RVA = "0x22E21A0", Offset = "0x22E21A0", VA = "0x22E21A0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F799C", Offset = "0x9F799C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x22E21E8", Offset = "0x22E21E8", VA = "0x22E21E8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F79D4", Offset = "0x9F79D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x22E2230", Offset = "0x22E2230", VA = "0x22E2230", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x22E224C", Offset = "0x22E224C", VA = "0x22E224C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x22E2480", Offset = "0x22E2480", VA = "0x22E2480")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x22E257C", Offset = "0x22E257C", VA = "0x22E257C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x22E29D0", Offset = "0x22E29D0", VA = "0x22E29D0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x22E2E38", Offset = "0x22E2E38", VA = "0x22E2E38")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x22E2FC8", Offset = "0x22E2FC8", VA = "0x22E2FC8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x22E32CC", Offset = "0x22E32CC", VA = "0x22E32CC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x22E3418", Offset = "0x22E3418", VA = "0x22E3418")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x22E3624", Offset = "0x22E3624", VA = "0x22E3624")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE768", Offset = "0x9EE768")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE768", Offset = "0x9EE768")]
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
			[Address(RVA = "0x1F66FDC", Offset = "0x1F66FDC", VA = "0x1F66FDC")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFCCC", Offset = "0x9EFCCC")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EFD04", Offset = "0x9EFD04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFD04", Offset = "0x9EFD04")]
		public float rootRotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EFD58", Offset = "0x9EFD58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFD58", Offset = "0x9EFD58")]
		public float minRootRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EFDB0", Offset = "0x9EFDB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFDB0", Offset = "0x9EFDB0")]
		public float maxRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFE08", Offset = "0x9EFE08")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFE40", Offset = "0x9EFE40")]
		public float maxLegOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFE78", Offset = "0x9EFE78")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9EFEB0", Offset = "0x9EFEB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFEB0", Offset = "0x9EFEB0")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFF04", Offset = "0x9EFF04")]
		public Transform characterRoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFF3C", Offset = "0x9EFF3C")]
		public Transform pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFF74", Offset = "0x9EFF74")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFFAC", Offset = "0x9EFFAC")]
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
		[Address(RVA = "0x22E36C4", Offset = "0x22E36C4", VA = "0x22E36C4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7A0C", Offset = "0x9F7A0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x22E370C", Offset = "0x22E370C", VA = "0x22E370C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7A44", Offset = "0x9F7A44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x22E3754", Offset = "0x22E3754", VA = "0x22E3754", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x22E3790", Offset = "0x22E3790", VA = "0x22E3790")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x22E38BC", Offset = "0x22E38BC", VA = "0x22E38BC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x22E3AC0", Offset = "0x22E3AC0", VA = "0x22E3AC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x22E3B28", Offset = "0x22E3B28", VA = "0x22E3B28")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x22E3B8C", Offset = "0x22E3B8C", VA = "0x22E3B8C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x22E3EF4", Offset = "0x22E3EF4", VA = "0x22E3EF4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x22E428C", Offset = "0x22E428C", VA = "0x22E428C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x22E4384", Offset = "0x22E4384", VA = "0x22E4384")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x22E4750", Offset = "0x22E4750", VA = "0x22E4750")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x22E4D74", Offset = "0x22E4D74", VA = "0x22E4D74")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x22E4F44", Offset = "0x22E4F44", VA = "0x22E4F44")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x22E5020", Offset = "0x22E5020", VA = "0x22E5020")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x22E5268", Offset = "0x22E5268", VA = "0x22E5268")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x22E52A0", Offset = "0x22E52A0", VA = "0x22E52A0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x22E54A4", Offset = "0x22E54A4", VA = "0x22E54A4")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE7C8", Offset = "0x9EE7C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE7C8", Offset = "0x9EE7C8")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9EFFF4", Offset = "0x9EFFF4")]
		public VRIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x240FBDC", Offset = "0x240FBDC", VA = "0x240FBDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7A7C", Offset = "0x9F7A7C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x240FC24", Offset = "0x240FC24", VA = "0x240FC24", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7AB4", Offset = "0x9F7AB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x240FC6C", Offset = "0x240FC6C", VA = "0x240FC6C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7AEC", Offset = "0x9F7AEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x240FCB4", Offset = "0x240FCB4", VA = "0x240FCB4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x240FD58", Offset = "0x240FD58", VA = "0x240FD58")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x240FDEC", Offset = "0x240FDEC", VA = "0x240FDEC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x240FE4C", Offset = "0x240FE4C", VA = "0x240FE4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2410388", Offset = "0x2410388", VA = "0x2410388")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x24107E8", Offset = "0x24107E8", VA = "0x24107E8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2410878", Offset = "0x2410878", VA = "0x2410878")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2410A34", Offset = "0x2410A34", VA = "0x2410A34")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x2410BB0", Offset = "0x2410BB0", VA = "0x2410BB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2410D64", Offset = "0x2410D64", VA = "0x2410D64")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F04D8", Offset = "0x9F04D8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F04E8", Offset = "0x9F04E8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F04F8", Offset = "0x9F04F8")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0508", Offset = "0x9F0508")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0518", Offset = "0x9F0518")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0528", Offset = "0x9F0528")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0538", Offset = "0x9F0538")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0548", Offset = "0x9F0548")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0558", Offset = "0x9F0558")]
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
				[Address(RVA = "0x1F67040", Offset = "0x1F67040", VA = "0x1F67040")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7BC4", Offset = "0x9F7BC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x1F67048", Offset = "0x1F67048", VA = "0x1F67048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7BD4", Offset = "0x9F7BD4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x1F67054", Offset = "0x1F67054", VA = "0x1F67054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7BE4", Offset = "0x9F7BE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x1F67060", Offset = "0x1F67060", VA = "0x1F67060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7BF4", Offset = "0x9F7BF4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x1F6706C", Offset = "0x1F6706C", VA = "0x1F6706C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C04", Offset = "0x9F7C04")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x1F67074", Offset = "0x1F67074", VA = "0x1F67074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C14", Offset = "0x9F7C14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x1F67080", Offset = "0x1F67080", VA = "0x1F67080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C24", Offset = "0x9F7C24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x1F67088", Offset = "0x1F67088", VA = "0x1F67088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C34", Offset = "0x9F7C34")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x1F67090", Offset = "0x1F67090", VA = "0x1F67090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C44", Offset = "0x9F7C44")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x1F6709C", Offset = "0x1F6709C", VA = "0x1F6709C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C54", Offset = "0x9F7C54")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x1F670A8", Offset = "0x1F670A8", VA = "0x1F670A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C64", Offset = "0x9F7C64")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x1F670B0", Offset = "0x1F670B0", VA = "0x1F670B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C74", Offset = "0x9F7C74")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x1F670B8", Offset = "0x1F670B8", VA = "0x1F670B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C84", Offset = "0x9F7C84")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x1F670C0", Offset = "0x1F670C0", VA = "0x1F670C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7C94", Offset = "0x9F7C94")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x1F670C8", Offset = "0x1F670C8", VA = "0x1F670C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7CA4", Offset = "0x9F7CA4")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x1F670E0", Offset = "0x1F670E0", VA = "0x1F670E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7CB4", Offset = "0x9F7CB4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x1F67100", Offset = "0x1F67100", VA = "0x1F67100")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7CC4", Offset = "0x9F7CC4")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x1F67118", Offset = "0x1F67118", VA = "0x1F67118")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7CD4", Offset = "0x9F7CD4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x1F67138", Offset = "0x1F67138", VA = "0x1F67138")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x1F68318", Offset = "0x1F68318", VA = "0x1F68318")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x1F6847C", Offset = "0x1F6847C", VA = "0x1F6847C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1F67180", Offset = "0x1F67180", VA = "0x1F67180")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x1F67194", Offset = "0x1F67194", VA = "0x1F67194")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1F67224", Offset = "0x1F67224", VA = "0x1F67224")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1F67270", Offset = "0x1F67270", VA = "0x1F67270")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1F672E0", Offset = "0x1F672E0", VA = "0x1F672E0")]
			public void Process()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1F67F8C", Offset = "0x1F67F8C", VA = "0x1F67F8C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x1F67B2C", Offset = "0x1F67B2C", VA = "0x1F67B2C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x1F683AC", Offset = "0x1F683AC", VA = "0x1F683AC")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1F67DCC", Offset = "0x1F67DCC", VA = "0x1F67DCC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1F67E58", Offset = "0x1F67E58", VA = "0x1F67E58")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1F6841C", Offset = "0x1F6841C", VA = "0x1F6841C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1F68340", Offset = "0x1F68340", VA = "0x1F68340")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1F68510", Offset = "0x1F68510", VA = "0x1F68510")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1F6859C", Offset = "0x1F6859C", VA = "0x1F6859C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003F")]
		public class Pelvis
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0568", Offset = "0x9F0568")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0578", Offset = "0x9F0578")]
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
				[Address(RVA = "0x1F685E0", Offset = "0x1F685E0", VA = "0x1F685E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7CE4", Offset = "0x9F7CE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x1F685EC", Offset = "0x1F685EC", VA = "0x1F685EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7CF4", Offset = "0x9F7CF4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x1F685F8", Offset = "0x1F685F8", VA = "0x1F685F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7D04", Offset = "0x9F7D04")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x1F68600", Offset = "0x1F68600", VA = "0x1F68600")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7D14", Offset = "0x9F7D14")]
				private set
				{
				}
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1F68608", Offset = "0x1F68608", VA = "0x1F68608")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x1F68698", Offset = "0x1F68698", VA = "0x1F68698")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1F68638", Offset = "0x1F68638", VA = "0x1F68638")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1F68704", Offset = "0x1F68704", VA = "0x1F68704")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1F688A4", Offset = "0x1F688A4", VA = "0x1F688A4")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F002C", Offset = "0x9F002C")]
		public LayerMask layers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0064", Offset = "0x9F0064")]
		public float maxStep;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F009C", Offset = "0x9F009C")]
		public float heightOffset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F00D4", Offset = "0x9F00D4")]
		public float footSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F010C", Offset = "0x9F010C")]
		public float footRadius;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0144", Offset = "0x9F0144")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0190", Offset = "0x9F0190")]
		public float prediction;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F01C8", Offset = "0x9F01C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F01C8", Offset = "0x9F01C8")]
		public float footRotationWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F021C", Offset = "0x9F021C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0254", Offset = "0x9F0254")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0254", Offset = "0x9F0254")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F02AC", Offset = "0x9F02AC")]
		public bool rotateSolver;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F02E4", Offset = "0x9F02E4")]
		public float pelvisSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F031C", Offset = "0x9F031C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F031C", Offset = "0x9F031C")]
		public float pelvisDamper;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0370", Offset = "0x9F0370")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F03A8", Offset = "0x9F03A8")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F03E0", Offset = "0x9F03E0")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0418", Offset = "0x9F0418")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0450", Offset = "0x9F0450")]
		public Quality quality;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0488", Offset = "0x9F0488")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F0498", Offset = "0x9F0498")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F04A8", Offset = "0x9F04A8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F04B8", Offset = "0x9F04B8")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F04C8", Offset = "0x9F04C8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2410DCC", Offset = "0x2410DCC", VA = "0x2410DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B24", Offset = "0x9F7B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x2410DD4", Offset = "0x2410DD4", VA = "0x2410DD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B34", Offset = "0x9F7B34")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x2410DDC", Offset = "0x2410DDC", VA = "0x2410DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B44", Offset = "0x9F7B44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x2410DE4", Offset = "0x2410DE4", VA = "0x2410DE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B54", Offset = "0x9F7B54")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x2410DEC", Offset = "0x2410DEC", VA = "0x2410DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B64", Offset = "0x9F7B64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x2410DF4", Offset = "0x2410DF4", VA = "0x2410DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B74", Offset = "0x9F7B74")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x2410E00", Offset = "0x2410E00", VA = "0x2410E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B84", Offset = "0x9F7B84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x2410E08", Offset = "0x2410E08", VA = "0x2410E08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7B94", Offset = "0x9F7B94")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2410E10", Offset = "0x2410E10", VA = "0x2410E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7BA4", Offset = "0x9F7BA4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2410E28", Offset = "0x2410E28", VA = "0x2410E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7BB4", Offset = "0x9F7BB4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2410E48", Offset = "0x2410E48", VA = "0x2410E48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x24110E8", Offset = "0x24110E8", VA = "0x24110E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x24113B8", Offset = "0x24113B8", VA = "0x24113B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2410E9C", Offset = "0x2410E9C", VA = "0x2410E9C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x241112C", Offset = "0x241112C", VA = "0x241112C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x24100B8", Offset = "0x24100B8", VA = "0x24100B8")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2410578", Offset = "0x2410578", VA = "0x2410578")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2411258", Offset = "0x2411258", VA = "0x2411258")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x240FCCC", Offset = "0x240FCCC", VA = "0x240FCCC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2411240", Offset = "0x2411240", VA = "0x2411240")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2411438", Offset = "0x2411438", VA = "0x2411438")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x24114C8", Offset = "0x24114C8", VA = "0x24114C8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2411584", Offset = "0x2411584", VA = "0x2411584")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2411600", Offset = "0x2411600", VA = "0x2411600")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE828", Offset = "0x9EE828")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE828", Offset = "0x9EE828")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2240D44", Offset = "0x2240D44", VA = "0x2240D44", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7D24", Offset = "0x9F7D24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2240D8C", Offset = "0x2240D8C", VA = "0x2240D8C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7D5C", Offset = "0x9F7D5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2240DD4", Offset = "0x2240DD4", VA = "0x2240DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7D94", Offset = "0x9F7D94")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2240E1C", Offset = "0x2240E1C", VA = "0x2240E1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7DCC", Offset = "0x9F7DCC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2240E64", Offset = "0x2240E64", VA = "0x2240E64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7E04", Offset = "0x9F7E04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2240EAC", Offset = "0x2240EAC", VA = "0x2240EAC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2240EB4", Offset = "0x2240EB4", VA = "0x2240EB4")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE888", Offset = "0x9EE888")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE888", Offset = "0x9EE888")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2242828", Offset = "0x2242828", VA = "0x2242828", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7E3C", Offset = "0x9F7E3C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2242870", Offset = "0x2242870", VA = "0x2242870", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7E74", Offset = "0x9F7E74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x22428B8", Offset = "0x22428B8", VA = "0x22428B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7EAC", Offset = "0x9F7EAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2242900", Offset = "0x2242900", VA = "0x2242900")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7EE4", Offset = "0x9F7EE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2242948", Offset = "0x2242948", VA = "0x2242948", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2242950", Offset = "0x2242950", VA = "0x2242950")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE8E8", Offset = "0x9EE8E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE8E8", Offset = "0x9EE8E8")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x224FB74", Offset = "0x224FB74", VA = "0x224FB74", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7F1C", Offset = "0x9F7F1C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x224FBBC", Offset = "0x224FBBC", VA = "0x224FBBC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7F54", Offset = "0x9F7F54")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x224FC04", Offset = "0x224FC04", VA = "0x224FC04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7F8C", Offset = "0x9F7F8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x224FC4C", Offset = "0x224FC4C", VA = "0x224FC4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7FC4", Offset = "0x9F7FC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x224FC94", Offset = "0x224FC94", VA = "0x224FC94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x224FC9C", Offset = "0x224FC9C", VA = "0x224FC9C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE948", Offset = "0x9EE948")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE948", Offset = "0x9EE948")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x22D58A0", Offset = "0x22D58A0", VA = "0x22D58A0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F7FFC", Offset = "0x9F7FFC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x22D58E8", Offset = "0x22D58E8", VA = "0x22D58E8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8034", Offset = "0x9F8034")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x22D5930", Offset = "0x22D5930", VA = "0x22D5930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F806C", Offset = "0x9F806C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x22D5978", Offset = "0x22D5978", VA = "0x22D5978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F80A4", Offset = "0x9F80A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x22D59C0", Offset = "0x22D59C0", VA = "0x22D59C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x22D59C8", Offset = "0x22D59C8", VA = "0x22D59C8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EE9A8", Offset = "0x9EE9A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EE9A8", Offset = "0x9EE9A8")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x22D5F10", Offset = "0x22D5F10", VA = "0x22D5F10", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F80DC", Offset = "0x9F80DC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x22D5F58", Offset = "0x22D5F58", VA = "0x22D5F58", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8114", Offset = "0x9F8114")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x22D5FA0", Offset = "0x22D5FA0", VA = "0x22D5FA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F814C", Offset = "0x9F814C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x22D5FE8", Offset = "0x22D5FE8", VA = "0x22D5FE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8184", Offset = "0x9F8184")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x22D6030", Offset = "0x22D6030", VA = "0x22D6030", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x22D6038", Offset = "0x22D6038", VA = "0x22D6038")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEA08", Offset = "0x9EEA08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEA08", Offset = "0x9EEA08")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x22DEC14", Offset = "0x22DEC14", VA = "0x22DEC14", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F81BC", Offset = "0x9F81BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x22DEC5C", Offset = "0x22DEC5C", VA = "0x22DEC5C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F81F4", Offset = "0x9F81F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x22DECA4", Offset = "0x22DECA4", VA = "0x22DECA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F822C", Offset = "0x9F822C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x22DECEC", Offset = "0x22DECEC", VA = "0x22DECEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8264", Offset = "0x9F8264")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x22DED34", Offset = "0x22DED34", VA = "0x22DED34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F829C", Offset = "0x9F829C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x22DED7C", Offset = "0x22DED7C", VA = "0x22DED7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F82D4", Offset = "0x9F82D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x22DEDC4", Offset = "0x22DEDC4", VA = "0x22DEDC4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x22DEE08", Offset = "0x22DEE08", VA = "0x22DEE08", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x22DEE10", Offset = "0x22DEE10", VA = "0x22DEE10")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x22DEFF8", Offset = "0x22DEFF8", VA = "0x22DEFF8")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x22DF298", Offset = "0x22DF298", VA = "0x22DF298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F830C", Offset = "0x9F830C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x22DF2B8", Offset = "0x22DF2B8", VA = "0x22DF2B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8344", Offset = "0x9F8344")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x22DF3A8", Offset = "0x22DF3A8", VA = "0x22DF3A8")]
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
		[Address(RVA = "0x2414C98", Offset = "0x2414C98", VA = "0x2414C98", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2414D8C", Offset = "0x2414D8C", VA = "0x2414D8C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2414F84", Offset = "0x2414F84", VA = "0x2414F84", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000238")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000239")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2414FE4", Offset = "0x2414FE4", VA = "0x2414FE4")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0588", Offset = "0x9F0588")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F05C0", Offset = "0x9F05C0")]
		public Animator animator;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x2417664", Offset = "0x2417664", VA = "0x2417664")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x24176FC", Offset = "0x24176FC", VA = "0x24176FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x241776C", Offset = "0x241776C", VA = "0x241776C")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2417828", Offset = "0x2417828", VA = "0x2417828")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2417864", Offset = "0x2417864", VA = "0x2417864")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x24177A0", Offset = "0x24177A0", VA = "0x24177A0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x24178F0", Offset = "0x24178F0", VA = "0x24178F0")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEA68", Offset = "0x9EEA68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEA68", Offset = "0x9EEA68")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x209D6C4", Offset = "0x209D6C4", VA = "0x209D6C4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F837C", Offset = "0x9F837C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x209D70C", Offset = "0x209D70C", VA = "0x209D70C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F83B4", Offset = "0x9F83B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x209D754", Offset = "0x209D754", VA = "0x209D754")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F83EC", Offset = "0x9F83EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x209D79C", Offset = "0x209D79C", VA = "0x209D79C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8424", Offset = "0x9F8424")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x209D7E4", Offset = "0x209D7E4", VA = "0x209D7E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x209D7EC", Offset = "0x209D7EC", VA = "0x209D7EC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEAC8", Offset = "0x9EEAC8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEAC8", Offset = "0x9EEAC8")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x209D85C", Offset = "0x209D85C", VA = "0x209D85C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F845C", Offset = "0x9F845C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x209D8A4", Offset = "0x209D8A4", VA = "0x209D8A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8494", Offset = "0x9F8494")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x209D8EC", Offset = "0x209D8EC", VA = "0x209D8EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F84CC", Offset = "0x9F84CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x209D934", Offset = "0x209D934", VA = "0x209D934")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8504", Offset = "0x9F8504")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x209D97C", Offset = "0x209D97C", VA = "0x209D97C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x209D984", Offset = "0x209D984", VA = "0x209D984")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEB28", Offset = "0x9EEB28")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEB28", Offset = "0x9EEB28")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x209E390", Offset = "0x209E390", VA = "0x209E390", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F853C", Offset = "0x9F853C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x209E3D8", Offset = "0x209E3D8", VA = "0x209E3D8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8574", Offset = "0x9F8574")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x209E420", Offset = "0x209E420", VA = "0x209E420")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F85AC", Offset = "0x9F85AC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x209E468", Offset = "0x209E468", VA = "0x209E468")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F85E4", Offset = "0x9F85E4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x209E4B0", Offset = "0x209E4B0", VA = "0x209E4B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x209E4B8", Offset = "0x209E4B8", VA = "0x209E4B8")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEB88", Offset = "0x9EEB88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEB88", Offset = "0x9EEB88")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1F5D4F8", Offset = "0x1F5D4F8", VA = "0x1F5D4F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F861C", Offset = "0x9F861C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1F5D540", Offset = "0x1F5D540", VA = "0x1F5D540", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8654", Offset = "0x9F8654")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1F5D588", Offset = "0x1F5D588", VA = "0x1F5D588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F868C", Offset = "0x9F868C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1F5D5D0", Offset = "0x1F5D5D0", VA = "0x1F5D5D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F86C4", Offset = "0x9F86C4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1F5D618", Offset = "0x1F5D618", VA = "0x1F5D618", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1F5D620", Offset = "0x1F5D620", VA = "0x1F5D620")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEBE8", Offset = "0x9EEBE8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F06A4", Offset = "0x9F06A4")]
			public Transform chest;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F06DC", Offset = "0x9F06DC")]
			public Transform neck;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0714", Offset = "0x9F0714")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F074C", Offset = "0x9F074C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0784", Offset = "0x9F0784")]
			public Transform leftThigh;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F07BC", Offset = "0x9F07BC")]
			public Transform leftCalf;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F07F4", Offset = "0x9F07F4")]
			public Transform leftFoot;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F082C", Offset = "0x9F082C")]
			public Transform leftToes;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0864", Offset = "0x9F0864")]
			public Transform rightThigh;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F089C", Offset = "0x9F089C")]
			public Transform rightCalf;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F08D4", Offset = "0x9F08D4")]
			public Transform rightFoot;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F090C", Offset = "0x9F090C")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x2724E50", Offset = "0x2724E50", VA = "0x2724E50")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x27252C8", Offset = "0x27252C8", VA = "0x27252C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2724900", Offset = "0x2724900", VA = "0x2724900")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2725740", Offset = "0x2725740", VA = "0x2725740")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2725BEC", Offset = "0x2725BEC", VA = "0x2725BEC")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F05F8", Offset = "0x9F05F8")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x9F05F8", Offset = "0x9F05F8")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F066C", Offset = "0x9F066C")]
		public IKSolverVR solver;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1F60364", Offset = "0x1F60364", VA = "0x1F60364", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F86FC", Offset = "0x9F86FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1F603AC", Offset = "0x1F603AC", VA = "0x1F603AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8734", Offset = "0x9F8734")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1F603F4", Offset = "0x1F603F4", VA = "0x1F603F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F876C", Offset = "0x9F876C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1F6043C", Offset = "0x1F6043C", VA = "0x1F6043C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F87A4", Offset = "0x9F87A4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1F60468", Offset = "0x1F60468", VA = "0x1F60468")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F87DC", Offset = "0x9F87DC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1F60490", Offset = "0x1F60490", VA = "0x1F60490", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1F60498", Offset = "0x1F60498", VA = "0x1F60498", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1F60518", Offset = "0x1F60518", VA = "0x1F60518", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1F60684", Offset = "0x1F60684", VA = "0x1F60684")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0944", Offset = "0x9F0944")]
		public float pull;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F095C", Offset = "0x9F095C")]
		public float pin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x22D5A38", Offset = "0x22D5A38", VA = "0x22D5A38")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x22D5B14", Offset = "0x22D5B14", VA = "0x22D5B14")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x22D5B34", Offset = "0x22D5B34", VA = "0x22D5B34")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x22D5DA8", Offset = "0x22D5DA8", VA = "0x22D5DA8")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x22D5C08", Offset = "0x22D5C08", VA = "0x22D5C08")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x22D5EA0", Offset = "0x22D5EA0", VA = "0x22D5EA0")]
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
		[Address(RVA = "0x22D60A8", Offset = "0x22D60A8", VA = "0x22D60A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x22D6520", Offset = "0x22D6520", VA = "0x22D6520")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x22D66DC", Offset = "0x22D66DC", VA = "0x22D66DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x22D680C", Offset = "0x22D680C", VA = "0x22D680C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0FB4", Offset = "0x9F0FB4")]
			public Transform transform;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0FEC", Offset = "0x9F0FEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0FEC", Offset = "0x9F0FEC")]
			public float weight;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1F66358", Offset = "0x1F66358", VA = "0x1F66358")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1F66394", Offset = "0x1F66394", VA = "0x1F66394")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1F663F8", Offset = "0x1F663F8", VA = "0x1F663F8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1F66430", Offset = "0x1F66430", VA = "0x1F66430")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0974", Offset = "0x9F0974")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F09AC", Offset = "0x9F09AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F09AC", Offset = "0x9F09AC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F09AC", Offset = "0x9F09AC")]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0A24", Offset = "0x9F0A24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0A24", Offset = "0x9F0A24")]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0A78", Offset = "0x9F0A78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0A78", Offset = "0x9F0A78")]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0ACC", Offset = "0x9F0ACC")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0B04", Offset = "0x9F0B04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0B04", Offset = "0x9F0B04")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F0B04", Offset = "0x9F0B04")]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0B7C", Offset = "0x9F0B7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0B7C", Offset = "0x9F0B7C")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0BD0", Offset = "0x9F0BD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0BD0", Offset = "0x9F0BD0")]
		public float headClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0C24", Offset = "0x9F0C24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0C24", Offset = "0x9F0C24")]
		public float bendWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0C78", Offset = "0x9F0C78")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0CB0", Offset = "0x9F0CB0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F0CB0", Offset = "0x9F0CB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0CB0", Offset = "0x9F0CB0")]
		public float CCDWeight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0D28", Offset = "0x9F0D28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0D28", Offset = "0x9F0D28")]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0D7C", Offset = "0x9F0D7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0D7C", Offset = "0x9F0D7C")]
		public float damper;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0DD4", Offset = "0x9F0DD4")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F0E0C", Offset = "0x9F0E0C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0E0C", Offset = "0x9F0E0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0E0C", Offset = "0x9F0E0C")]
		public float postStretchWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0E84", Offset = "0x9F0E84")]
		public float maxStretch;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0EBC", Offset = "0x9F0EBC")]
		public float stretchDamper;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0EF4", Offset = "0x9F0EF4")]
		public bool fixHead;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F0F2C", Offset = "0x9F0F2C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F0F64", Offset = "0x9F0F64")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F0F9C", Offset = "0x9F0F9C")]
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
		[Address(RVA = "0x22D6814", Offset = "0x22D6814", VA = "0x22D6814")]
		private void Start()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x22D6B9C", Offset = "0x22D6B9C", VA = "0x22D6B9C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x22D7078", Offset = "0x22D7078", VA = "0x22D7078")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x22D7444", Offset = "0x22D7444", VA = "0x22D7444")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x22D7BD0", Offset = "0x22D7BD0", VA = "0x22D7BD0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x22D7EB0", Offset = "0x22D7EB0", VA = "0x22D7EB0")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x22D81B4", Offset = "0x22D81B4", VA = "0x22D81B4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x22D8988", Offset = "0x22D8988", VA = "0x22D8988")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x22D79B4", Offset = "0x22D79B4", VA = "0x22D79B4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x22D8B50", Offset = "0x22D8B50", VA = "0x22D8B50")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x22D88A0", Offset = "0x22D88A0", VA = "0x22D88A0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x22D87D4", Offset = "0x22D87D4", VA = "0x22D87D4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x22D8DD4", Offset = "0x22D8DD4", VA = "0x22D8DD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x22D9108", Offset = "0x22D9108", VA = "0x22D9108")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F10D8", Offset = "0x9F10D8")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F10E8", Offset = "0x9F10E8")]
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
				[Address(RVA = "0x1F664EC", Offset = "0x1F664EC", VA = "0x1F664EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8814", Offset = "0x9F8814")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x1F664F4", Offset = "0x1F664F4", VA = "0x1F664F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8824", Offset = "0x9F8824")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x1F664FC", Offset = "0x1F664FC", VA = "0x1F664FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8834", Offset = "0x9F8834")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x1F66504", Offset = "0x1F66504", VA = "0x1F66504")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8844", Offset = "0x9F8844")]
				private set
				{
				}
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1F66510", Offset = "0x1F66510", VA = "0x1F66510")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1F66578", Offset = "0x1F66578", VA = "0x1F66578")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1F665D0", Offset = "0x1F665D0", VA = "0x1F665D0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1F66774", Offset = "0x1F66774", VA = "0x1F66774")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1040", Offset = "0x9F1040")]
		public float pin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1058", Offset = "0x9F1058")]
		public float pull;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1070", Offset = "0x9F1070")]
		public float push;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1088", Offset = "0x9F1088")]
		public float pushParent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F10A0", Offset = "0x9F10A0")]
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
		[Address(RVA = "0x22D9864", Offset = "0x22D9864", VA = "0x22D9864")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x22D9980", Offset = "0x22D9980", VA = "0x22D9980")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x22D9AF0", Offset = "0x22D9AF0", VA = "0x22D9AF0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x22D9C2C", Offset = "0x22D9C2C", VA = "0x22D9C2C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x22D9D04", Offset = "0x22D9D04", VA = "0x22D9D04")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x22D9E28", Offset = "0x22D9E28", VA = "0x22D9E28")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x22DA4F8", Offset = "0x22DA4F8", VA = "0x22DA4F8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x22D9FC4", Offset = "0x22D9FC4", VA = "0x22D9FC4")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x22DA8E8", Offset = "0x22DA8E8", VA = "0x22DA8E8")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x22DAB48", Offset = "0x22DAB48", VA = "0x22DAB48")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x22DADB4", Offset = "0x22DADB4", VA = "0x22DADB4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x22DB158", Offset = "0x22DB158", VA = "0x22DB158")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x22DB5EC", Offset = "0x22DB5EC", VA = "0x22DB5EC")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x22DB810", Offset = "0x22DB810", VA = "0x22DB810")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x22DB57C", Offset = "0x22DB57C", VA = "0x22DB57C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x22DAFE4", Offset = "0x22DAFE4", VA = "0x22DAFE4")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x22DB500", Offset = "0x22DB500", VA = "0x22DB500")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x22DB8F8", Offset = "0x22DB8F8", VA = "0x22DB8F8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x22DB420", Offset = "0x22DB420", VA = "0x22DB420")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x22DB6F8", Offset = "0x22DB6F8", VA = "0x22DB6F8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F10F8", Offset = "0x9F10F8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1110", Offset = "0x9F1110")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x24151D4", Offset = "0x24151D4", VA = "0x24151D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8854", Offset = "0x9F8854")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x24151DC", Offset = "0x24151DC", VA = "0x24151DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8864", Offset = "0x9F8864")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2414FEC", Offset = "0x2414FEC", VA = "0x2414FEC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x24151E8", Offset = "0x24151E8", VA = "0x24151E8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2415228", Offset = "0x2415228", VA = "0x2415228")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2415290", Offset = "0x2415290", VA = "0x2415290")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x24152E0", Offset = "0x24152E0", VA = "0x24152E0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2415658", Offset = "0x2415658", VA = "0x2415658")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2415848", Offset = "0x2415848", VA = "0x2415848")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2415B94", Offset = "0x2415B94", VA = "0x2415B94")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2415518", Offset = "0x2415518", VA = "0x2415518")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x24155B8", Offset = "0x24155B8", VA = "0x24155B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1120", Offset = "0x9F1120")]
		public float positionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1138", Offset = "0x9F1138")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1150", Offset = "0x9F1150")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1160", Offset = "0x9F1160")]
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
			[Address(RVA = "0x2416074", Offset = "0x2416074", VA = "0x2416074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8874", Offset = "0x9F8874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x241607C", Offset = "0x241607C", VA = "0x241607C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8884", Offset = "0x9F8884")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x241600C", Offset = "0x241600C", VA = "0x241600C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2416088", Offset = "0x2416088", VA = "0x2416088")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2416118", Offset = "0x2416118", VA = "0x2416118")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x241625C", Offset = "0x241625C", VA = "0x241625C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x24163DC", Offset = "0x24163DC", VA = "0x24163DC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2416704", Offset = "0x2416704", VA = "0x2416704")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x24169BC", Offset = "0x24169BC", VA = "0x24169BC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2416A88", Offset = "0x2416A88", VA = "0x2416A88")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2416B30", Offset = "0x2416B30", VA = "0x2416B30")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2417058", Offset = "0x2417058", VA = "0x2417058")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2417084", Offset = "0x2417084", VA = "0x2417084")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x24171D8", Offset = "0x24171D8", VA = "0x24171D8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2417450", Offset = "0x2417450", VA = "0x2417450")]
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
				[Address(RVA = "0x1F5B628", Offset = "0x1F5B628", VA = "0x1F5B628")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x1F69CE8", Offset = "0x1F69CE8", VA = "0x1F69CE8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x1F6A0B8", Offset = "0x1F6A0B8", VA = "0x1F6A0B8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1F69BF8", Offset = "0x1F69BF8", VA = "0x1F69BF8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1F69C48", Offset = "0x1F69C48", VA = "0x1F69C48")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1F69C98", Offset = "0x1F69C98", VA = "0x1F69C98")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1F69CF8", Offset = "0x1F69CF8", VA = "0x1F69CF8")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1F69D80", Offset = "0x1F69D80", VA = "0x1F69D80")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1F69D88", Offset = "0x1F69D88", VA = "0x1F69D88")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1F69E60", Offset = "0x1F69E60", VA = "0x1F69E60")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1F69ED8", Offset = "0x1F69ED8", VA = "0x1F69ED8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1F69F9C", Offset = "0x1F69F9C", VA = "0x1F69F9C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1F6A1F8", Offset = "0x1F6A1F8", VA = "0x1F6A1F8")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1F6A230", Offset = "0x1F6A230", VA = "0x1F6A230")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1F6A268", Offset = "0x1F6A268", VA = "0x1F6A268")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1F6A290", Offset = "0x1F6A290", VA = "0x1F6A290")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1F6A37C", Offset = "0x1F6A37C", VA = "0x1F6A37C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1F6A508", Offset = "0x1F6A508", VA = "0x1F6A508")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1F6A538", Offset = "0x1F6A538", VA = "0x1F6A538")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1F6A600", Offset = "0x1F6A600", VA = "0x1F6A600")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1F6A670", Offset = "0x1F6A670", VA = "0x1F6A670")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1F6A7C0", Offset = "0x1F6A7C0", VA = "0x1F6A7C0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1F6A910", Offset = "0x1F6A910", VA = "0x1F6A910")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x1F6A990", Offset = "0x1F6A990", VA = "0x1F6A990")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1F6A3F8", Offset = "0x1F6A3F8", VA = "0x1F6A3F8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1F6AAC8", Offset = "0x1F6AAC8", VA = "0x1F6AAC8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x24178F8", Offset = "0x24178F8", VA = "0x24178F8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2417900", Offset = "0x2417900", VA = "0x2417900", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2417904", Offset = "0x2417904", VA = "0x2417904")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2417A54", Offset = "0x2417A54", VA = "0x2417A54")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2417AC4", Offset = "0x2417AC4", VA = "0x2417AC4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1178", Offset = "0x9F1178")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2417ACC", Offset = "0x2417ACC", VA = "0x2417ACC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2417B80", Offset = "0x2417B80", VA = "0x2417B80")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x2417BF8", Offset = "0x2417BF8", VA = "0x2417BF8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2417C8C", Offset = "0x2417C8C", VA = "0x2417C8C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x2417CA8", Offset = "0x2417CA8", VA = "0x2417CA8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2417CC8", Offset = "0x2417CC8", VA = "0x2417CC8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2417D60", Offset = "0x2417D60", VA = "0x2417D60")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2417D7C", Offset = "0x2417D7C", VA = "0x2417D7C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1190", Offset = "0x9F1190")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F11A8", Offset = "0x9F11A8")]
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
		[Address(RVA = "0x2417DA4", Offset = "0x2417DA4", VA = "0x2417DA4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x2417E28", Offset = "0x2417E28", VA = "0x2417E28")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2417F04", Offset = "0x2417F04", VA = "0x2417F04")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x2418128", Offset = "0x2418128", VA = "0x2418128")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x241821C", Offset = "0x241821C", VA = "0x241821C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2418348", Offset = "0x2418348", VA = "0x2418348")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x24183AC", Offset = "0x24183AC", VA = "0x24183AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2418460", Offset = "0x2418460", VA = "0x2418460")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2418524", Offset = "0x2418524", VA = "0x2418524", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x24187BC", Offset = "0x24187BC", VA = "0x24187BC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2418830", Offset = "0x2418830", VA = "0x2418830")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F11C0", Offset = "0x9F11C0")]
		public int iterations;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F11D8", Offset = "0x9F11D8")]
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
		[Address(RVA = "0x24189AC", Offset = "0x24189AC", VA = "0x24189AC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2418D18", Offset = "0x2418D18", VA = "0x2418D18")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2418E38", Offset = "0x2418E38", VA = "0x2418E38")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2418F98", Offset = "0x2418F98", VA = "0x2418F98")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2419018", Offset = "0x2419018", VA = "0x2419018")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x2419084", Offset = "0x2419084", VA = "0x2419084")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2419108", Offset = "0x2419108", VA = "0x2419108", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x241974C", Offset = "0x241974C", VA = "0x241974C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2419784", Offset = "0x2419784", VA = "0x2419784")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2419A08", Offset = "0x2419A08", VA = "0x2419A08")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2419D08", Offset = "0x2419D08", VA = "0x2419D08")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2419DF4", Offset = "0x2419DF4", VA = "0x2419DF4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2419EBC", Offset = "0x2419EBC", VA = "0x2419EBC")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F12AC", Offset = "0x9F12AC")]
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
			[Address(RVA = "0x1F6B614", Offset = "0x1F6B614", VA = "0x1F6B614")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1F6B664", Offset = "0x1F6B664", VA = "0x1F6B664")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1F6B704", Offset = "0x1F6B704", VA = "0x1F6B704")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1F6B73C", Offset = "0x1F6B73C", VA = "0x1F6B73C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1F6B774", Offset = "0x1F6B774", VA = "0x1F6B774")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1F6B7C4", Offset = "0x1F6B7C4", VA = "0x1F6B7C4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1F6B1C8", Offset = "0x1F6B1C8", VA = "0x1F6B1C8")]
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
				[Address(RVA = "0x1F6AAE4", Offset = "0x1F6AAE4", VA = "0x1F6AAE4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x1F6ABE8", Offset = "0x1F6ABE8", VA = "0x1F6ABE8")]
				set
				{
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1F6AC78", Offset = "0x1F6AC78", VA = "0x1F6AC78")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1F6AE28", Offset = "0x1F6AE28", VA = "0x1F6AE28")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1F6AFFC", Offset = "0x1F6AFFC", VA = "0x1F6AFFC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1F6B15C", Offset = "0x1F6B15C", VA = "0x1F6B15C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1F6B184", Offset = "0x1F6B184", VA = "0x1F6B184")]
			public Bone()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1F6B204", Offset = "0x1F6B204", VA = "0x1F6B204")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1F6B25C", Offset = "0x1F6B25C", VA = "0x1F6B25C")]
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
			[Address(RVA = "0x1F6B59C", Offset = "0x1F6B59C", VA = "0x1F6B59C")]
			public Node()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1F6B5A0", Offset = "0x1F6B5A0", VA = "0x1F6B5A0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1F6B5D0", Offset = "0x1F6B5D0", VA = "0x1F6B5D0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1210", Offset = "0x9F1210")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1210", Offset = "0x9F1210")]
		public float IKPositionWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1264", Offset = "0x9F1264")]
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
			[Address(RVA = "0x241A1EC", Offset = "0x241A1EC", VA = "0x241A1EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8894", Offset = "0x9F8894")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x241A1F4", Offset = "0x241A1F4", VA = "0x241A1F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F88A4", Offset = "0x9F88A4")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x241A11C", Offset = "0x241A11C", VA = "0x241A11C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2414DFC", Offset = "0x2414DFC", VA = "0x2414DFC")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2414D1C", Offset = "0x2414D1C", VA = "0x2414D1C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x241A194", Offset = "0x241A194", VA = "0x241A194", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x241A1A0", Offset = "0x241A1A0", VA = "0x241A1A0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x241A1AC", Offset = "0x241A1AC", VA = "0x241A1AC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x241A1B4", Offset = "0x241A1B4", VA = "0x241A1B4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x241A1E4", Offset = "0x241A1E4", VA = "0x241A1E4")]
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
		[Address(RVA = "0x241A200", Offset = "0x241A200", VA = "0x241A200")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x241A218", Offset = "0x241A218", VA = "0x241A218")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x241A350", Offset = "0x241A350", VA = "0x241A350")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x241A3F8", Offset = "0x241A3F8", VA = "0x241A3F8")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x241A680", Offset = "0x241A680", VA = "0x241A680")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F12C4", Offset = "0x9F12C4")]
		public float poleWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F12DC", Offset = "0x9F12DC")]
		public float clampWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F12F4", Offset = "0x9F12F4")]
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
			[Address(RVA = "0x241A714", Offset = "0x241A714", VA = "0x241A714")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x241A750", Offset = "0x241A750", VA = "0x241A750")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x241B200", Offset = "0x241B200", VA = "0x241B200", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x241B5E4", Offset = "0x241B5E4", VA = "0x241B5E4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x241A698", Offset = "0x241A698", VA = "0x241A698")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x241A78C", Offset = "0x241A78C", VA = "0x241A78C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x241A9AC", Offset = "0x241A9AC", VA = "0x241A9AC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x241B14C", Offset = "0x241B14C", VA = "0x241B14C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x241AEDC", Offset = "0x241AEDC", VA = "0x241AEDC")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x241B208", Offset = "0x241B208", VA = "0x241B208")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x241B658", Offset = "0x241B658", VA = "0x241B658")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F130C", Offset = "0x9F130C")]
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
		[Address(RVA = "0x241B6AC", Offset = "0x241B6AC", VA = "0x241B6AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x241BA90", Offset = "0x241BA90", VA = "0x241BA90")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x241BB44", Offset = "0x241BB44", VA = "0x241BB44", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x241BCD8", Offset = "0x241BCD8", VA = "0x241BCD8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x241BE6C", Offset = "0x241BE6C", VA = "0x241BE6C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x241BEC8", Offset = "0x241BEC8", VA = "0x241BEC8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x241BF38", Offset = "0x241BF38", VA = "0x241BF38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x241C2A8", Offset = "0x241C2A8", VA = "0x241C2A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x241C2D4", Offset = "0x241C2D4", VA = "0x241C2D4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x241BF9C", Offset = "0x241BF9C", VA = "0x241BF9C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x241C344", Offset = "0x241C344", VA = "0x241C344")]
		private void Write()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x241C4D0", Offset = "0x241C4D0", VA = "0x241C4D0")]
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
		[Address(RVA = "0x241C694", Offset = "0x241C694", VA = "0x241C694")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x241C744", Offset = "0x241C744", VA = "0x241C744", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x241C7C8", Offset = "0x241C7C8", VA = "0x241C7C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x241C9F8", Offset = "0x241C9F8", VA = "0x241C9F8")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x241CFD4", Offset = "0x241CFD4", VA = "0x241CFD4")]
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
			[Address(RVA = "0x241DF00", Offset = "0x241DF00", VA = "0x241DF00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x241CFDC", Offset = "0x241CFDC", VA = "0x241CFDC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x241D5A0", Offset = "0x241D5A0", VA = "0x241D5A0")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x241D6E0", Offset = "0x241D6E0", VA = "0x241D6E0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x241D774", Offset = "0x241D774", VA = "0x241D774", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x241DC6C", Offset = "0x241DC6C", VA = "0x241DC6C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x241DF08", Offset = "0x241DF08", VA = "0x241DF08")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x241D0B8", Offset = "0x241D0B8", VA = "0x241D0B8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x241D68C", Offset = "0x241D68C", VA = "0x241D68C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x241DEA4", Offset = "0x241DEA4", VA = "0x241DEA4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x241D414", Offset = "0x241D414", VA = "0x241D414")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x241E558", Offset = "0x241E558", VA = "0x241E558")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x241E5CC", Offset = "0x241E5CC", VA = "0x241E5CC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x241E694", Offset = "0x241E694", VA = "0x241E694")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x241E744", Offset = "0x241E744", VA = "0x241E744")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x241DA1C", Offset = "0x241DA1C", VA = "0x241DA1C")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x241DB44", Offset = "0x241DB44", VA = "0x241DB44")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x241E848", Offset = "0x241E848", VA = "0x241E848")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x241E128", Offset = "0x241E128", VA = "0x241E128")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x241D67C", Offset = "0x241D67C", VA = "0x241D67C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x241EDD8", Offset = "0x241EDD8", VA = "0x241EDD8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x241E98C", Offset = "0x241E98C", VA = "0x241E98C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x241DF84", Offset = "0x241DF84", VA = "0x241DF84")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x241E064", Offset = "0x241E064", VA = "0x241E064")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x241EEA4", Offset = "0x241EEA4", VA = "0x241EEA4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1324", Offset = "0x9F1324")]
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
		[Address(RVA = "0x241EF3C", Offset = "0x241EF3C", VA = "0x241EF3C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x241F5C8", Offset = "0x241F5C8", VA = "0x241F5C8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x241F660", Offset = "0x241F660", VA = "0x241F660", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x241F700", Offset = "0x241F700", VA = "0x241F700", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x241F80C", Offset = "0x241F80C", VA = "0x241F80C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x241F8A8", Offset = "0x241F8A8", VA = "0x241F8A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x241FCD8", Offset = "0x241FCD8", VA = "0x241FCD8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x241FEE8", Offset = "0x241FEE8", VA = "0x241FEE8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x241FD84", Offset = "0x241FD84", VA = "0x241FD84")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x241FA94", Offset = "0x241FA94", VA = "0x241FA94")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x241FF80", Offset = "0x241FF80", VA = "0x241FF80")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F133C", Offset = "0x9F133C")]
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
		[Address(RVA = "0x2420000", Offset = "0x2420000", VA = "0x2420000")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x24200F0", Offset = "0x24200F0", VA = "0x24200F0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x242014C", Offset = "0x242014C", VA = "0x242014C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2415FB0", Offset = "0x2415FB0", VA = "0x2415FB0")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2415498", Offset = "0x2415498", VA = "0x2415498")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x242027C", Offset = "0x242027C", VA = "0x242027C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2420428", Offset = "0x2420428", VA = "0x2420428", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2420598", Offset = "0x2420598", VA = "0x2420598", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x24207A4", Offset = "0x24207A4", VA = "0x24207A4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x242087C", Offset = "0x242087C", VA = "0x242087C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x242095C", Offset = "0x242095C", VA = "0x242095C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2420ACC", Offset = "0x2420ACC", VA = "0x2420ACC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x2420C2C", Offset = "0x2420C2C", VA = "0x2420C2C", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2420E6C", Offset = "0x2420E6C", VA = "0x2420E6C", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2421138", Offset = "0x2421138", VA = "0x2421138", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x242117C", Offset = "0x242117C", VA = "0x242117C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x2421260", Offset = "0x2421260", VA = "0x2421260")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1354", Offset = "0x9F1354")]
		public float spineStiffness;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F136C", Offset = "0x9F136C")]
		public float pullBodyVertical;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1384", Offset = "0x9F1384")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F139C", Offset = "0x9F139C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x23FF604", Offset = "0x23FF604", VA = "0x23FF604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x23FF74C", Offset = "0x23FF74C", VA = "0x23FF74C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x23FF754", Offset = "0x23FF754", VA = "0x23FF754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x23FF75C", Offset = "0x23FF75C", VA = "0x23FF75C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x23FF764", Offset = "0x23FF764", VA = "0x23FF764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x23FF76C", Offset = "0x23FF76C", VA = "0x23FF76C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x23FF774", Offset = "0x23FF774", VA = "0x23FF774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x23FF77C", Offset = "0x23FF77C", VA = "0x23FF77C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x23FF784", Offset = "0x23FF784", VA = "0x23FF784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x23FF78C", Offset = "0x23FF78C", VA = "0x23FF78C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x23FF7C4", Offset = "0x23FF7C4", VA = "0x23FF7C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x23FF7FC", Offset = "0x23FF7FC", VA = "0x23FF7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x23FF834", Offset = "0x23FF834", VA = "0x23FF834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x23FF86C", Offset = "0x23FF86C", VA = "0x23FF86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x23FF8A0", Offset = "0x23FF8A0", VA = "0x23FF8A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x23FF8D8", Offset = "0x23FF8D8", VA = "0x23FF8D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x23FF910", Offset = "0x23FF910", VA = "0x23FF910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x23FF948", Offset = "0x23FF948", VA = "0x23FF948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2401ADC", Offset = "0x2401ADC", VA = "0x2401ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F88B4", Offset = "0x9F88B4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2401AE8", Offset = "0x2401AE8", VA = "0x2401AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F88C4", Offset = "0x9F88C4")]
			private set
			{
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x23FF97C", Offset = "0x23FF97C", VA = "0x23FF97C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x23FFA88", Offset = "0x23FFA88", VA = "0x23FFA88")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x23FF9D0", Offset = "0x23FF9D0", VA = "0x23FF9D0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x23FFB14", Offset = "0x23FFB14", VA = "0x23FFB14")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x23FF60C", Offset = "0x23FF60C", VA = "0x23FF60C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x23FFBE4", Offset = "0x23FFBE4", VA = "0x23FFBE4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x23FFC9C", Offset = "0x23FFC9C", VA = "0x23FFC9C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x23FFD50", Offset = "0x23FFD50", VA = "0x23FFD50")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x23FFE04", Offset = "0x23FFE04", VA = "0x23FFE04")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x23FFE0C", Offset = "0x23FFE0C", VA = "0x23FFE0C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x23FFE40", Offset = "0x23FFE40", VA = "0x23FFE40")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x23FFF08", Offset = "0x23FFF08", VA = "0x23FFF08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x24000B4", Offset = "0x24000B4", VA = "0x24000B4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x2401558", Offset = "0x2401558", VA = "0x2401558")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x240196C", Offset = "0x240196C", VA = "0x240196C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x24019CC", Offset = "0x24019CC", VA = "0x24019CC")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x24017F4", Offset = "0x24017F4", VA = "0x24017F4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x24018B0", Offset = "0x24018B0", VA = "0x24018B0")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x2401AF4", Offset = "0x2401AF4", VA = "0x2401AF4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x2401BCC", Offset = "0x2401BCC", VA = "0x2401BCC", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x2401CCC", Offset = "0x2401CCC", VA = "0x2401CCC")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x2401DF4", Offset = "0x2401DF4", VA = "0x2401DF4")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x2401F38", Offset = "0x2401F38", VA = "0x2401F38")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x2402068", Offset = "0x2402068", VA = "0x2402068", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x24022AC", Offset = "0x24022AC", VA = "0x24022AC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x2402334", Offset = "0x2402334", VA = "0x2402334")]
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
			[Address(RVA = "0x2402BF8", Offset = "0x2402BF8", VA = "0x2402BF8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2402C00", Offset = "0x2402C00", VA = "0x2402C00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2402C08", Offset = "0x2402C08", VA = "0x2402C08", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x2403090", Offset = "0x2403090", VA = "0x2403090", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x2403158", Offset = "0x2403158", VA = "0x2403158")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x2402344", Offset = "0x2402344", VA = "0x2402344")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2402500", Offset = "0x2402500", VA = "0x2402500")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2402660", Offset = "0x2402660", VA = "0x2402660", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x24026CC", Offset = "0x24026CC", VA = "0x24026CC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x240274C", Offset = "0x240274C", VA = "0x240274C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x2402B00", Offset = "0x2402B00", VA = "0x2402B00", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x2402B08", Offset = "0x2402B08", VA = "0x2402B08", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2402C10", Offset = "0x2402C10", VA = "0x2402C10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2402C14", Offset = "0x2402C14", VA = "0x2402C14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2402C18", Offset = "0x2402C18", VA = "0x2402C18")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x24031AC", Offset = "0x24031AC", VA = "0x24031AC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x24034C4", Offset = "0x24034C4", VA = "0x24034C4")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x24036B8", Offset = "0x24036B8", VA = "0x24036B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F13AC", Offset = "0x9F13AC")]
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
		[Address(RVA = "0x2403730", Offset = "0x2403730", VA = "0x2403730", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2403B18", Offset = "0x2403B18", VA = "0x2403B18")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2403BD0", Offset = "0x2403BD0", VA = "0x2403BD0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2403D64", Offset = "0x2403D64", VA = "0x2403D64", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2403EF8", Offset = "0x2403EF8", VA = "0x2403EF8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2403F54", Offset = "0x2403F54", VA = "0x2403F54", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2403FC4", Offset = "0x2403FC4", VA = "0x2403FC4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2404334", Offset = "0x2404334", VA = "0x2404334", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2404360", Offset = "0x2404360", VA = "0x2404360")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2404028", Offset = "0x2404028", VA = "0x2404028")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x24043F8", Offset = "0x24043F8", VA = "0x24043F8")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2404584", Offset = "0x2404584", VA = "0x2404584")]
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
			[Address(RVA = "0x23A6740", Offset = "0x23A6740", VA = "0x23A6740")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F13C4", Offset = "0x9F13C4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F13DC", Offset = "0x9F13DC")]
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
			[Address(RVA = "0x24058B4", Offset = "0x24058B4", VA = "0x24058B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x240473C", Offset = "0x240473C", VA = "0x240473C")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x240478C", Offset = "0x240478C", VA = "0x240478C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x24047D8", Offset = "0x24047D8", VA = "0x24047D8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2404CAC", Offset = "0x2404CAC", VA = "0x2404CAC", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x24055F4", Offset = "0x24055F4", VA = "0x24055F4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x24056A0", Offset = "0x24056A0", VA = "0x24056A0")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2405818", Offset = "0x2405818", VA = "0x2405818")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2404AD4", Offset = "0x2404AD4", VA = "0x2404AD4")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2404D90", Offset = "0x2404D90", VA = "0x2404D90")]
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
				[Address(RVA = "0x23A69DC", Offset = "0x23A69DC", VA = "0x23A69DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x23A67A0", Offset = "0x23A67A0", VA = "0x23A67A0")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x23A67A8", Offset = "0x23A67A8", VA = "0x23A67A8")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x23A67DC", Offset = "0x23A67DC", VA = "0x23A67DC")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x23A68D4", Offset = "0x23A68D4", VA = "0x23A68D4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F13F4", Offset = "0x9F13F4")]
		public float bodyWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F140C", Offset = "0x9F140C")]
		public float headWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1424", Offset = "0x9F1424")]
		public float eyesWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F143C", Offset = "0x9F143C")]
		public float clampWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1454", Offset = "0x9F1454")]
		public float clampWeightHead;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F146C", Offset = "0x9F146C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1484", Offset = "0x9F1484")]
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
			[Address(RVA = "0x2406070", Offset = "0x2406070", VA = "0x2406070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x2406240", Offset = "0x2406240", VA = "0x2406240")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x2406150", Offset = "0x2406150", VA = "0x2406150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x2406264", Offset = "0x2406264", VA = "0x2406264")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x2406160", Offset = "0x2406160", VA = "0x2406160")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x24062DC", Offset = "0x24062DC", VA = "0x24062DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x24058D0", Offset = "0x24058D0", VA = "0x24058D0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2405900", Offset = "0x2405900", VA = "0x2405900")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2405958", Offset = "0x2405958", VA = "0x2405958")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x24059D4", Offset = "0x24059D4", VA = "0x24059D4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2405A6C", Offset = "0x2405A6C", VA = "0x2405A6C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2405B2C", Offset = "0x2405B2C", VA = "0x2405B2C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2405C28", Offset = "0x2405C28", VA = "0x2405C28", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2405D54", Offset = "0x2405D54", VA = "0x2405D54")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x2405D60", Offset = "0x2405D60", VA = "0x2405D60", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2405EA4", Offset = "0x2405EA4", VA = "0x2405EA4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2406300", Offset = "0x2406300", VA = "0x2406300", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2406570", Offset = "0x2406570", VA = "0x2406570", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x240670C", Offset = "0x240670C", VA = "0x240670C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2406970", Offset = "0x2406970", VA = "0x2406970", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2406C84", Offset = "0x2406C84", VA = "0x2406C84", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2406D54", Offset = "0x2406D54", VA = "0x2406D54")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2406EF4", Offset = "0x2406EF4", VA = "0x2406EF4")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2407118", Offset = "0x2407118", VA = "0x2407118")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x24074CC", Offset = "0x24074CC", VA = "0x24074CC")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x24067C4", Offset = "0x24067C4", VA = "0x24067C4")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x240773C", Offset = "0x240773C", VA = "0x240773C")]
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
			[Address(RVA = "0x23A6A18", Offset = "0x23A6A18", VA = "0x23A6A18")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x23A6B14", Offset = "0x23A6B14", VA = "0x23A6B14")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x23A6B44", Offset = "0x23A6B44", VA = "0x23A6B44")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x23A6B80", Offset = "0x23A6B80", VA = "0x23A6B80")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F149C", Offset = "0x9F149C")]
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
		[Address(RVA = "0x24079A0", Offset = "0x24079A0", VA = "0x24079A0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2407AFC", Offset = "0x2407AFC", VA = "0x2407AFC")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2407C40", Offset = "0x2407C40", VA = "0x2407C40")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2407C4C", Offset = "0x2407C4C", VA = "0x2407C4C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2407C7C", Offset = "0x2407C7C", VA = "0x2407C7C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2407C88", Offset = "0x2407C88", VA = "0x2407C88")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2407C90", Offset = "0x2407C90", VA = "0x2407C90", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2407DB4", Offset = "0x2407DB4", VA = "0x2407DB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2407ED0", Offset = "0x2407ED0", VA = "0x2407ED0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2407F1C", Offset = "0x2407F1C", VA = "0x2407F1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2407F7C", Offset = "0x2407F7C", VA = "0x2407F7C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2408374", Offset = "0x2408374", VA = "0x2408374")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x24083F4", Offset = "0x24083F4", VA = "0x24083F4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x24087B0", Offset = "0x24087B0", VA = "0x24087B0")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2408918", Offset = "0x2408918", VA = "0x2408918", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2408A80", Offset = "0x2408A80", VA = "0x2408A80")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x24089F4", Offset = "0x24089F4", VA = "0x24089F4")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2408B84", Offset = "0x2408B84", VA = "0x2408B84", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2409358", Offset = "0x2409358", VA = "0x2409358", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x240935C", Offset = "0x240935C", VA = "0x240935C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2409360", Offset = "0x2409360", VA = "0x2409360", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2409170", Offset = "0x2409170", VA = "0x2409170")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2405728", Offset = "0x2405728", VA = "0x2405728")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F16D8", Offset = "0x9F16D8")]
			public Transform target;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1710", Offset = "0x9F1710")]
			public Transform bendGoal;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1748", Offset = "0x9F1748")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1748", Offset = "0x9F1748")]
			public float positionWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F179C", Offset = "0x9F179C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F179C", Offset = "0x9F179C")]
			public float rotationWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F17F0", Offset = "0x9F17F0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1828", Offset = "0x9F1828")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1828", Offset = "0x9F1828")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F187C", Offset = "0x9F187C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F187C", Offset = "0x9F187C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F18D0", Offset = "0x9F18D0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F18D0", Offset = "0x9F18D0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1924", Offset = "0x9F1924")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1924", Offset = "0x9F1924")]
			public float swivelOffset;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1980", Offset = "0x9F1980")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F19B8", Offset = "0x9F19B8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F19F0", Offset = "0x9F19F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F19F0", Offset = "0x9F19F0")]
			public float armLengthMlp;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1A48", Offset = "0x9F1A48")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1AC0", Offset = "0x9F1AC0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1AD0", Offset = "0x9F1AD0")]
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
				[Address(RVA = "0x23A6B88", Offset = "0x23A6B88", VA = "0x23A6B88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F88F4", Offset = "0x9F88F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x23A6B94", Offset = "0x23A6B94", VA = "0x23A6B94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8904", Offset = "0x9F8904")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x23A6BA0", Offset = "0x23A6BA0", VA = "0x23A6BA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8914", Offset = "0x9F8914")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x23A6BAC", Offset = "0x23A6BAC", VA = "0x23A6BAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8924", Offset = "0x9F8924")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x23A6BB8", Offset = "0x23A6BB8", VA = "0x23A6BB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x23A6BEC", Offset = "0x23A6BEC", VA = "0x23A6BEC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x23A6C2C", Offset = "0x23A6C2C", VA = "0x23A6C2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x23A6C78", Offset = "0x23A6C78", VA = "0x23A6C78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x23A6CC4", Offset = "0x23A6CC4", VA = "0x23A6CC4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x23A7658", Offset = "0x23A7658", VA = "0x23A7658", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x23A7814", Offset = "0x23A7814", VA = "0x23A7814", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x23A7838", Offset = "0x23A7838", VA = "0x23A7838")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x23A7AD8", Offset = "0x23A7AD8", VA = "0x23A7AD8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x23A956C", Offset = "0x23A956C", VA = "0x23A956C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x23A9598", Offset = "0x23A9598", VA = "0x23A9598", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x23A8A6C", Offset = "0x23A8A6C", VA = "0x23A8A6C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x23A8C24", Offset = "0x23A8C24", VA = "0x23A8C24")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x23A97B8", Offset = "0x23A97B8", VA = "0x23A97B8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x23A98DC", Offset = "0x23A98DC", VA = "0x23A98DC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1AE0", Offset = "0x9F1AE0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1AF0", Offset = "0x9F1AF0")]
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
				[Address(RVA = "0x23A9A4C", Offset = "0x23A9A4C", VA = "0x23A9A4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8934", Offset = "0x9F8934")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x23A9A54", Offset = "0x23A9A54", VA = "0x23A9A54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8944", Offset = "0x9F8944")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x23A9A5C", Offset = "0x23A9A5C", VA = "0x23A9A5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8954", Offset = "0x9F8954")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x23A9A64", Offset = "0x23A9A64", VA = "0x23A9A64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8964", Offset = "0x9F8964")]
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
			[Address(RVA = "0x23A9A6C", Offset = "0x23A9A6C", VA = "0x23A9A6C")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x23A9A74", Offset = "0x23A9A74", VA = "0x23A9A74")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x23A9D34", Offset = "0x23A9D34", VA = "0x23A9D34")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x23A9DC8", Offset = "0x23A9DC8", VA = "0x23A9DC8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x23A9F98", Offset = "0x23A9F98", VA = "0x23A9F98")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x23A9FEC", Offset = "0x23A9FEC", VA = "0x23A9FEC")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x23A942C", Offset = "0x23A942C", VA = "0x23A942C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x23AA124", Offset = "0x23AA124", VA = "0x23AA124")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x23AA264", Offset = "0x23AA264", VA = "0x23AA264")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x23A99CC", Offset = "0x23A99CC", VA = "0x23A99CC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1B10", Offset = "0x9F1B10")]
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
				[Address(RVA = "0x23AA28C", Offset = "0x23AA28C", VA = "0x23AA28C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x23AA2A0", Offset = "0x23AA2A0", VA = "0x23AA2A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8974", Offset = "0x9F8974")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x23AA2A8", Offset = "0x23AA2A8", VA = "0x23AA2A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8984", Offset = "0x9F8984")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x23AA2B0", Offset = "0x23AA2B0", VA = "0x23AA2B0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x23AA3E8", Offset = "0x23AA3E8", VA = "0x23AA3E8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x23AA430", Offset = "0x23AA430", VA = "0x23AA430")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x23AA5FC", Offset = "0x23AA5FC", VA = "0x23AA5FC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x23AA770", Offset = "0x23AA770", VA = "0x23AA770")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x23AA8C8", Offset = "0x23AA8C8", VA = "0x23AA8C8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1B20", Offset = "0x9F1B20")]
			public Transform target;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1B58", Offset = "0x9F1B58")]
			public Transform bendGoal;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1B90", Offset = "0x9F1B90")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1B90", Offset = "0x9F1B90")]
			public float positionWeight;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1BE4", Offset = "0x9F1BE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1BE4", Offset = "0x9F1BE4")]
			public float rotationWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1C38", Offset = "0x9F1C38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1C38", Offset = "0x9F1C38")]
			public float bendGoalWeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1C8C", Offset = "0x9F1C8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1C8C", Offset = "0x9F1C8C")]
			public float swivelOffset;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1CE8", Offset = "0x9F1CE8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1CE8", Offset = "0x9F1CE8")]
			public float bendToTargetWeight;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1D3C", Offset = "0x9F1D3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1D3C", Offset = "0x9F1D3C")]
			public float legLengthMlp;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1D94", Offset = "0x9F1D94")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1E3C", Offset = "0x9F1E3C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1E4C", Offset = "0x9F1E4C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1E5C", Offset = "0x9F1E5C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1E6C", Offset = "0x9F1E6C")]
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
				[Address(RVA = "0x23AAA04", Offset = "0x23AAA04", VA = "0x23AAA04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8994", Offset = "0x9F8994")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x23AAA10", Offset = "0x23AAA10", VA = "0x23AAA10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F89A4", Offset = "0x9F89A4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x23AAA1C", Offset = "0x23AAA1C", VA = "0x23AAA1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F89B4", Offset = "0x9F89B4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x23AAA28", Offset = "0x23AAA28", VA = "0x23AAA28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F89C4", Offset = "0x9F89C4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x23AAA34", Offset = "0x23AAA34", VA = "0x23AAA34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F89D4", Offset = "0x9F89D4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x23AAA3C", Offset = "0x23AAA3C", VA = "0x23AAA3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F89E4", Offset = "0x9F89E4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x23AAA48", Offset = "0x23AAA48", VA = "0x23AAA48")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x23AAA7C", Offset = "0x23AAA7C", VA = "0x23AAA7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x23AAAB4", Offset = "0x23AAAB4", VA = "0x23AAAB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x23AAAEC", Offset = "0x23AAAEC", VA = "0x23AAAEC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x23AAB24", Offset = "0x23AAB24", VA = "0x23AAB24")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x23AAB64", Offset = "0x23AAB64", VA = "0x23AAB64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F89F4", Offset = "0x9F89F4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x23AAB70", Offset = "0x23AAB70", VA = "0x23AAB70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A04", Offset = "0x9F8A04")]
				private set
				{
				}
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x23AAB7C", Offset = "0x23AAB7C", VA = "0x23AAB7C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x23AB19C", Offset = "0x23AB19C", VA = "0x23AB19C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x23AB770", Offset = "0x23AB770", VA = "0x23AB770", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x23AB720", Offset = "0x23AB720", VA = "0x23AB720")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x23AB5B0", Offset = "0x23AB5B0", VA = "0x23AB5B0")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x23ABB58", Offset = "0x23ABB58", VA = "0x23ABB58")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x23AC014", Offset = "0x23AC014", VA = "0x23AC014")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x23ABCF4", Offset = "0x23ABCF4", VA = "0x23ABCF4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x23AC30C", Offset = "0x23AC30C", VA = "0x23AC30C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x23AC528", Offset = "0x23AC528", VA = "0x23AC528", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x23AC574", Offset = "0x23AC574", VA = "0x23AC574")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F1E7C", Offset = "0x9F1E7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1E7C", Offset = "0x9F1E7C")]
			public float weight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1ED0", Offset = "0x9F1ED0")]
			public float footDistance;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1F08", Offset = "0x9F1F08")]
			public float stepThreshold;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1F40", Offset = "0x9F1F40")]
			public float angleThreshold;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1F78", Offset = "0x9F1F78")]
			public float comAngleMlp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1FB0", Offset = "0x9F1FB0")]
			public float maxVelocity;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1FE8", Offset = "0x9F1FE8")]
			public float velocityFactor;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2020", Offset = "0x9F2020")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2020", Offset = "0x9F2020")]
			public float maxLegStretch;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2078", Offset = "0x9F2078")]
			public float rootSpeed;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F20B0", Offset = "0x9F20B0")]
			public float stepSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F20E8", Offset = "0x9F20E8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2120", Offset = "0x9F2120")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2158", Offset = "0x9F2158")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2190", Offset = "0x9F2190")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2190", Offset = "0x9F2190")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F21E8", Offset = "0x9F21E8")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2220", Offset = "0x9F2220")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2258", Offset = "0x9F2258")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F22D0", Offset = "0x9F22D0")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2308", Offset = "0x9F2308")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2340", Offset = "0x9F2340")]
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
				[Address(RVA = "0x23AC650", Offset = "0x23AC650", VA = "0x23AC650")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A14", Offset = "0x9F8A14")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x23AC65C", Offset = "0x23AC65C", VA = "0x23AC65C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A24", Offset = "0x9F8A24")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x23AE28C", Offset = "0x23AE28C", VA = "0x23AE28C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x23AE2CC", Offset = "0x23AE2CC", VA = "0x23AE2CC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x23AE310", Offset = "0x23AE310", VA = "0x23AE310")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x23AE350", Offset = "0x23AE350", VA = "0x23AE350")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x23AC668", Offset = "0x23AC668", VA = "0x23AC668")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x23AC944", Offset = "0x23AC944", VA = "0x23AC944")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x23ACB14", Offset = "0x23ACB14", VA = "0x23ACB14")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x23ACB78", Offset = "0x23ACB78", VA = "0x23ACB78")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x23ACDC0", Offset = "0x23ACDC0", VA = "0x23ACDC0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x23ACE84", Offset = "0x23ACE84", VA = "0x23ACE84")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x23AE004", Offset = "0x23AE004", VA = "0x23AE004")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x23AE13C", Offset = "0x23AE13C", VA = "0x23AE13C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x23AE1C0", Offset = "0x23AE1C0", VA = "0x23AE1C0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x23AE394", Offset = "0x23AE394", VA = "0x23AE394")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2350", Offset = "0x9F2350")]
			public Transform headTarget;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2388", Offset = "0x9F2388")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F23C0", Offset = "0x9F23C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F23C0", Offset = "0x9F23C0")]
			public float positionWeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2414", Offset = "0x9F2414")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2414", Offset = "0x9F2414")]
			public float rotationWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2468", Offset = "0x9F2468")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2468", Offset = "0x9F2468")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F24BC", Offset = "0x9F24BC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F24BC", Offset = "0x9F24BC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2510", Offset = "0x9F2510")]
			public Transform chestGoal;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2548", Offset = "0x9F2548")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2548", Offset = "0x9F2548")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F259C", Offset = "0x9F259C")]
			public float minHeadHeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F25D4", Offset = "0x9F25D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F25D4", Offset = "0x9F25D4")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2628", Offset = "0x9F2628")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2628", Offset = "0x9F2628")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F267C", Offset = "0x9F267C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F267C", Offset = "0x9F267C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9F267C", Offset = "0x9F267C")]
			public float neckStiffness;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F26F4", Offset = "0x9F26F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F26F4", Offset = "0x9F26F4")]
			public float rotateChestByHands;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2748", Offset = "0x9F2748")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2748", Offset = "0x9F2748")]
			public float chestClampWeight;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F279C", Offset = "0x9F279C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F279C", Offset = "0x9F279C")]
			public float headClampWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F27F0", Offset = "0x9F27F0")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2828", Offset = "0x9F2828")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2828", Offset = "0x9F2828")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F287C", Offset = "0x9F287C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F287C", Offset = "0x9F287C")]
			public float maxRootAngle;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F28D4", Offset = "0x9F28D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F28D4", Offset = "0x9F28D4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2A10", Offset = "0x9F2A10")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2A20", Offset = "0x9F2A20")]
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
				[Address(RVA = "0x23ADF84", Offset = "0x23ADF84", VA = "0x23ADF84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x23AE4B0", Offset = "0x23AE4B0", VA = "0x23AE4B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x23AE4F0", Offset = "0x23AE4F0", VA = "0x23AE4F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x23AE544", Offset = "0x23AE544", VA = "0x23AE544")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x23ADFC4", Offset = "0x23ADFC4", VA = "0x23ADFC4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x23AE584", Offset = "0x23AE584", VA = "0x23AE584")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A34", Offset = "0x9F8A34")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x23AE598", Offset = "0x23AE598", VA = "0x23AE598")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A44", Offset = "0x9F8A44")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x23AE5AC", Offset = "0x23AE5AC", VA = "0x23AE5AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A54", Offset = "0x9F8A54")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x23AE5C0", Offset = "0x23AE5C0", VA = "0x23AE5C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A64", Offset = "0x9F8A64")]
				private set
				{
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x23AE5D4", Offset = "0x23AE5D4", VA = "0x23AE5D4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x23AF020", Offset = "0x23AF020", VA = "0x23AF020", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x23AF22C", Offset = "0x23AF22C", VA = "0x23AF22C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x23AF678", Offset = "0x23AF678", VA = "0x23AF678")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x23AFAB4", Offset = "0x23AFAB4", VA = "0x23AFAB4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x23B0224", Offset = "0x23B0224", VA = "0x23B0224")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x23B08A4", Offset = "0x23B08A4", VA = "0x23B08A4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x23B0E28", Offset = "0x23B0E28", VA = "0x23B0E28", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x23B1004", Offset = "0x23B1004", VA = "0x23B1004", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x23AF810", Offset = "0x23AF810", VA = "0x23AF810")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x23B05F4", Offset = "0x23B05F4", VA = "0x23B05F4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x23AFECC", Offset = "0x23AFECC", VA = "0x23AFECC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x23B109C", Offset = "0x23B109C", VA = "0x23B109C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x23B06D0", Offset = "0x23B06D0", VA = "0x23B06D0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x23B03A0", Offset = "0x23B03A0", VA = "0x23B03A0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x23B1290", Offset = "0x23B1290", VA = "0x23B1290")]
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
			[Address(RVA = "0x23A75BC", Offset = "0x23A75BC", VA = "0x23A75BC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x23A7638", Offset = "0x23A7638", VA = "0x23A7638")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x23B1400", Offset = "0x23B1400", VA = "0x23B1400")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x23A9B44", Offset = "0x23A9B44", VA = "0x23A9B44")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x23A9E70", Offset = "0x23A9E70", VA = "0x23A9E70")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x23B1584", Offset = "0x23B1584", VA = "0x23B1584")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x23A8AE8", Offset = "0x23A8AE8", VA = "0x23A8AE8")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x23B16E4", Offset = "0x23B16E4", VA = "0x23B16E4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x23A9028", Offset = "0x23A9028", VA = "0x23A9028")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x23B179C", Offset = "0x23B179C", VA = "0x23B179C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x23B0A98", Offset = "0x23B0A98", VA = "0x23B0A98")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x23B1904", Offset = "0x23B1904", VA = "0x23B1904")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x23B1974", Offset = "0x23B1974", VA = "0x23B1974")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F14B4", Offset = "0x9F14B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F14B4", Offset = "0x9F14B4")]
		public int LOD;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1508", Offset = "0x9F1508")]
		public float scale;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1540", Offset = "0x9F1540")]
		public bool plantFeet;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F1578", Offset = "0x9F1578")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1588", Offset = "0x9F1588")]
		public Spine spine;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F15C0", Offset = "0x9F15C0")]
		public Arm leftArm;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F15F8", Offset = "0x9F15F8")]
		public Arm rightArm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1630", Offset = "0x9F1630")]
		public Leg leftLeg;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F1668", Offset = "0x9F1668")]
		public Leg rightLeg;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F16A0", Offset = "0x9F16A0")]
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
			[Address(RVA = "0x240CC18", Offset = "0x240CC18", VA = "0x240CC18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F88D4", Offset = "0x9F88D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x240CC20", Offset = "0x240CC20", VA = "0x240CC20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F88E4", Offset = "0x9F88E4")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2409364", Offset = "0x2409364", VA = "0x2409364")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2409820", Offset = "0x2409820", VA = "0x2409820")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x24096AC", Offset = "0x24096AC", VA = "0x24096AC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2409B84", Offset = "0x2409B84", VA = "0x2409B84")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2409CC8", Offset = "0x2409CC8", VA = "0x2409CC8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2409CF8", Offset = "0x2409CF8", VA = "0x2409CF8")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2409DA8", Offset = "0x2409DA8", VA = "0x2409DA8")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2409E90", Offset = "0x2409E90", VA = "0x2409E90")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x240A64C", Offset = "0x240A64C", VA = "0x240A64C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x240A7BC", Offset = "0x240A7BC", VA = "0x240A7BC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x240A9C0", Offset = "0x240A9C0", VA = "0x240A9C0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x240AA3C", Offset = "0x240AA3C", VA = "0x240AA3C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x240AAB8", Offset = "0x240AAB8", VA = "0x240AAB8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x240AC9C", Offset = "0x240AC9C", VA = "0x240AC9C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2409A64", Offset = "0x2409A64", VA = "0x2409A64")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2409F84", Offset = "0x2409F84", VA = "0x2409F84")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x240AE5C", Offset = "0x240AE5C", VA = "0x240AE5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x240AEA4", Offset = "0x240AEA4", VA = "0x240AEA4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x240C348", Offset = "0x240C348", VA = "0x240C348")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x240A0E8", Offset = "0x240A0E8", VA = "0x240A0E8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x240B218", Offset = "0x240B218", VA = "0x240B218")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x240C6F8", Offset = "0x240C6F8", VA = "0x240C6F8")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x240C740", Offset = "0x240C740", VA = "0x240C740")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x240C1F8", Offset = "0x240C1F8", VA = "0x240C1F8")]
		private void Write()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x240C784", Offset = "0x240C784", VA = "0x240C784")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x240CC28", Offset = "0x240CC28", VA = "0x240CC28")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2A30", Offset = "0x9F2A30")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1F5D714", Offset = "0x1F5D714", VA = "0x1F5D714")]
		public void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1F5DDFC", Offset = "0x1F5DDFC", VA = "0x1F5DDFC")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1F5E28C", Offset = "0x1F5E28C", VA = "0x1F5E28C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1F5E350", Offset = "0x1F5E350", VA = "0x1F5E350")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1F5E48C", Offset = "0x1F5E48C", VA = "0x1F5E48C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2A68", Offset = "0x9F2A68")]
		public Transform transform;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2AA0", Offset = "0x9F2AA0")]
		public Transform parent;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2AD8", Offset = "0x9F2AD8")]
		public Transform[] children;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2B10", Offset = "0x9F2B10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2B10", Offset = "0x9F2B10")]
		public float weight;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2B64", Offset = "0x9F2B64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2B64", Offset = "0x9F2B64")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2BB8", Offset = "0x9F2BB8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F2BB8", Offset = "0x9F2BB8")]
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
		[Address(RVA = "0x1F5E4F4", Offset = "0x1F5E4F4", VA = "0x1F5E4F4")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1F5D914", Offset = "0x1F5D914", VA = "0x1F5D914")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1F5DEC0", Offset = "0x1F5DEC0", VA = "0x1F5DEC0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2C14", Offset = "0x9F2C14")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2C24", Offset = "0x9F2C24")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2C34", Offset = "0x9F2C34")]
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
			[Address(RVA = "0x240DAE4", Offset = "0x240DAE4", VA = "0x240DAE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A74", Offset = "0x9F8A74")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x240DAEC", Offset = "0x240DAEC", VA = "0x240DAEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A84", Offset = "0x9F8A84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x240DAF4", Offset = "0x240DAF4", VA = "0x240DAF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8A94", Offset = "0x9F8A94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x240DAFC", Offset = "0x240DAFC", VA = "0x240DAFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8AA4", Offset = "0x9F8AA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x240DB08", Offset = "0x240DB08", VA = "0x240DB08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8AB4", Offset = "0x9F8AB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x240DB10", Offset = "0x240DB10", VA = "0x240DB10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8AC4", Offset = "0x9F8AC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x240DB18", Offset = "0x240DB18", VA = "0x240DB18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x240F3D0", Offset = "0x240F3D0", VA = "0x240F3D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x240DB84", Offset = "0x240DB84", VA = "0x240DB84")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x240DC1C", Offset = "0x240DC1C", VA = "0x240DC1C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x240DCD8", Offset = "0x240DCD8", VA = "0x240DCD8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x240DE34", Offset = "0x240DE34", VA = "0x240DE34")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x240E170", Offset = "0x240E170", VA = "0x240E170")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x240E22C", Offset = "0x240E22C", VA = "0x240E22C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x240E284", Offset = "0x240E284", VA = "0x240E284")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x240E700", Offset = "0x240E700", VA = "0x240E700")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x240ED90", Offset = "0x240ED90", VA = "0x240ED90")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x240EFD4", Offset = "0x240EFD4", VA = "0x240EFD4")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x240F25C", Offset = "0x240F25C", VA = "0x240F25C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x240F40C", Offset = "0x240F40C", VA = "0x240F40C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2C44", Offset = "0x9F2C44")]
		public LookAtIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2C7C", Offset = "0x9F2C7C")]
		public float lerpSpeed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2CB4", Offset = "0x9F2CB4")]
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
		[Address(RVA = "0x240F638", Offset = "0x240F638", VA = "0x240F638")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x240F760", Offset = "0x240F760", VA = "0x240F760")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x240F804", Offset = "0x240F804", VA = "0x240F804")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x240FA0C", Offset = "0x240FA0C", VA = "0x240FA0C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x240FB00", Offset = "0x240FB00", VA = "0x240FB00")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x240FBC8", Offset = "0x240FBC8", VA = "0x240FBC8")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEC20", Offset = "0x9EEC20")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEC20", Offset = "0x9EEC20")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class InteractionEvent
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2DC4", Offset = "0x9F2DC4")]
			public float time;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2DFC", Offset = "0x9F2DFC")]
			public bool pause;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2E34", Offset = "0x9F2E34")]
			public bool pickUp;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2E6C", Offset = "0x9F2E6C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2EA4", Offset = "0x9F2EA4")]
			public Message[] messages;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2EDC", Offset = "0x9F2EDC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x23B2120", Offset = "0x23B2120", VA = "0x23B2120")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x23B22F4", Offset = "0x23B22F4", VA = "0x23B22F4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2F14", Offset = "0x9F2F14")]
			public string function;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2F4C", Offset = "0x9F2F4C")]
			public GameObject recipient;

			[Token(Token = "0x4000467")]
			private const string empty = "";

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x23B21F0", Offset = "0x23B21F0", VA = "0x23B21F0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x23B22FC", Offset = "0x23B22FC", VA = "0x23B22FC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2F84", Offset = "0x9F2F84")]
			public Animator animator;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2FBC", Offset = "0x9F2FBC")]
			public Animation animation;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2FF4", Offset = "0x9F2FF4")]
			public string animationState;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F302C", Offset = "0x9F302C")]
			public float crossfadeTime;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3064", Offset = "0x9F3064")]
			public int layer;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F309C", Offset = "0x9F309C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400046E")]
			private const string empty = "";

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x23B1E8C", Offset = "0x23B1E8C", VA = "0x23B1E8C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x23B1F7C", Offset = "0x23B1F7C", VA = "0x23B1F7C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x23B2030", Offset = "0x23B2030", VA = "0x23B2030")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x23B210C", Offset = "0x23B210C", VA = "0x23B210C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F30D4", Offset = "0x9F30D4")]
			public Type type;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F310C", Offset = "0x9F310C")]
			public AnimationCurve curve;

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x23B2340", Offset = "0x23B2340", VA = "0x23B2340")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x23B236C", Offset = "0x23B236C", VA = "0x23B236C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3144", Offset = "0x9F3144")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F317C", Offset = "0x9F317C")]
			public float multiplier;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F31B4", Offset = "0x9F31B4")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x23B2304", Offset = "0x23B2304", VA = "0x23B2304")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x23B235C", Offset = "0x23B235C", VA = "0x23B235C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2CFC", Offset = "0x9F2CFC")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2D34", Offset = "0x9F2D34")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F2D6C", Offset = "0x9F2D6C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2DA4", Offset = "0x9F2DA4")]
		private float <length>k__BackingField;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F2DB4", Offset = "0x9F2DB4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x20962F8", Offset = "0x20962F8", VA = "0x20962F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8C94", Offset = "0x9F8C94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x2096300", Offset = "0x2096300", VA = "0x2096300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8CA4", Offset = "0x9F8CA4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x2096308", Offset = "0x2096308", VA = "0x2096308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8CB4", Offset = "0x9F8CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x2096310", Offset = "0x2096310", VA = "0x2096310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8CC4", Offset = "0x9F8CC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x209656C", Offset = "0x209656C", VA = "0x209656C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x20964E0", Offset = "0x20964E0", VA = "0x20964E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x20960B8", Offset = "0x20960B8", VA = "0x20960B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8AD4", Offset = "0x9F8AD4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2096100", Offset = "0x2096100", VA = "0x2096100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8B0C", Offset = "0x9F8B0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2096148", Offset = "0x2096148", VA = "0x2096148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8B44", Offset = "0x9F8B44")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2096190", Offset = "0x2096190", VA = "0x2096190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8B7C", Offset = "0x9F8B7C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x20961D8", Offset = "0x20961D8", VA = "0x20961D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8BB4", Offset = "0x9F8BB4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2096220", Offset = "0x2096220", VA = "0x2096220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8BEC", Offset = "0x9F8BEC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2096268", Offset = "0x2096268", VA = "0x2096268")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8C24", Offset = "0x9F8C24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x20962B0", Offset = "0x20962B0", VA = "0x20962B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8C5C", Offset = "0x9F8C5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2096318", Offset = "0x2096318", VA = "0x2096318")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x20965F8", Offset = "0x20965F8", VA = "0x20965F8")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2096764", Offset = "0x2096764", VA = "0x2096764")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2096818", Offset = "0x2096818", VA = "0x2096818")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2096820", Offset = "0x2096820", VA = "0x2096820")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x20969D4", Offset = "0x20969D4", VA = "0x20969D4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x20969DC", Offset = "0x20969DC", VA = "0x20969DC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x20973A4", Offset = "0x20973A4", VA = "0x20973A4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x20975C4", Offset = "0x20975C4", VA = "0x20975C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2096EA8", Offset = "0x2096EA8", VA = "0x2096EA8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2096964", Offset = "0x2096964", VA = "0x2096964")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x209733C", Offset = "0x209733C", VA = "0x209733C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x20975C8", Offset = "0x20975C8", VA = "0x20975C8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2097630", Offset = "0x2097630", VA = "0x2097630")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEC80", Offset = "0x9EEC80")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEC80", Offset = "0x9EEC80")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F31EC", Offset = "0x9F31EC")]
		public string targetTag;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3224", Offset = "0x9F3224")]
		public float fadeInTime;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F325C", Offset = "0x9F325C")]
		public float speed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3294", Offset = "0x9F3294")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F32CC", Offset = "0x9F32CC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9F32CC", Offset = "0x9F32CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F32CC", Offset = "0x9F32CC")]
		public Collider characterCollider;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3350", Offset = "0x9F3350")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9F3350", Offset = "0x9F3350")]
		public Transform FPSCamera;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F33B0", Offset = "0x9F33B0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F33E8", Offset = "0x9F33E8")]
		public float camRaycastDistance;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F3420", Offset = "0x9F3420")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3430", Offset = "0x9F3430")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9F3430", Offset = "0x9F3430")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3490", Offset = "0x9F3490")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F34C8", Offset = "0x9F34C8")]
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
			[Address(RVA = "0x20978D8", Offset = "0x20978D8", VA = "0x20978D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x20995BC", Offset = "0x20995BC", VA = "0x20995BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x20995C4", Offset = "0x20995C4", VA = "0x20995C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x20995CC", Offset = "0x20995CC", VA = "0x20995CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8E94", Offset = "0x9F8E94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x20995D4", Offset = "0x20995D4", VA = "0x20995D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8EA4", Offset = "0x9F8EA4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x20995DC", Offset = "0x20995DC", VA = "0x20995DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8EB4", Offset = "0x9F8EB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x20995E4", Offset = "0x20995E4", VA = "0x20995E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F8EC4", Offset = "0x9F8EC4")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2097698", Offset = "0x2097698", VA = "0x2097698")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8CD4", Offset = "0x9F8CD4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x20976E0", Offset = "0x20976E0", VA = "0x20976E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8D0C", Offset = "0x9F8D0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2097728", Offset = "0x2097728", VA = "0x2097728")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8D44", Offset = "0x9F8D44")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2097770", Offset = "0x2097770", VA = "0x2097770")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8D7C", Offset = "0x9F8D7C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x20977B8", Offset = "0x20977B8", VA = "0x20977B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8DB4", Offset = "0x9F8DB4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2097800", Offset = "0x2097800", VA = "0x2097800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8DEC", Offset = "0x9F8DEC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2097848", Offset = "0x2097848", VA = "0x2097848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8E24", Offset = "0x9F8E24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2097890", Offset = "0x2097890", VA = "0x2097890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8E5C", Offset = "0x9F8E5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2097A80", Offset = "0x2097A80", VA = "0x2097A80")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2097B50", Offset = "0x2097B50", VA = "0x2097B50")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2097C20", Offset = "0x2097C20", VA = "0x2097C20")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2097CD0", Offset = "0x2097CD0", VA = "0x2097CD0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2097DCC", Offset = "0x2097DCC", VA = "0x2097DCC")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2097EE8", Offset = "0x2097EE8", VA = "0x2097EE8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2097F7C", Offset = "0x2097F7C", VA = "0x2097F7C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2098010", Offset = "0x2098010", VA = "0x2098010")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x20980A4", Offset = "0x20980A4", VA = "0x20980A4")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x209811C", Offset = "0x209811C", VA = "0x209811C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2098194", Offset = "0x2098194", VA = "0x2098194")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2098200", Offset = "0x2098200", VA = "0x2098200")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x209828C", Offset = "0x209828C", VA = "0x209828C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2098320", Offset = "0x2098320", VA = "0x2098320")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x20983EC", Offset = "0x20983EC", VA = "0x20983EC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x20986C4", Offset = "0x20986C4", VA = "0x20986C4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x20988BC", Offset = "0x20988BC", VA = "0x20988BC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2098B60", Offset = "0x2098B60", VA = "0x2098B60")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2098E38", Offset = "0x2098E38", VA = "0x2098E38")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2098E7C", Offset = "0x2098E7C", VA = "0x2098E7C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2098EF4", Offset = "0x2098EF4", VA = "0x2098EF4")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2099028", Offset = "0x2099028", VA = "0x2099028")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x20991CC", Offset = "0x20991CC", VA = "0x20991CC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2099470", Offset = "0x2099470", VA = "0x2099470")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2098C74", Offset = "0x2098C74", VA = "0x2098C74")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x20995F0", Offset = "0x20995F0", VA = "0x20995F0")]
		public void Start()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2099E1C", Offset = "0x2099E1C", VA = "0x2099E1C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2099E3C", Offset = "0x2099E3C", VA = "0x2099E3C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2099E58", Offset = "0x2099E58", VA = "0x2099E58")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2099E74", Offset = "0x2099E74", VA = "0x2099E74")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2099ED8", Offset = "0x2099ED8", VA = "0x2099ED8")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x209A014", Offset = "0x209A014", VA = "0x209A014")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x209A124", Offset = "0x209A124", VA = "0x209A124")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x209A4C8", Offset = "0x209A4C8", VA = "0x209A4C8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x209A5F4", Offset = "0x209A5F4", VA = "0x209A5F4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x209A854", Offset = "0x209A854", VA = "0x209A854")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2099B68", Offset = "0x2099B68", VA = "0x2099B68")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x209A990", Offset = "0x209A990", VA = "0x209A990")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x209AAC0", Offset = "0x209AAC0", VA = "0x209AAC0")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x209AB58", Offset = "0x209AB58", VA = "0x209AB58")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x209AC34", Offset = "0x209AC34", VA = "0x209AC34")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x209AC50", Offset = "0x209AC50", VA = "0x209AC50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2097988", Offset = "0x2097988", VA = "0x2097988")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2098594", Offset = "0x2098594", VA = "0x2098594")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x209B04C", Offset = "0x209B04C", VA = "0x209B04C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EECE0", Offset = "0x9EECE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EECE0", Offset = "0x9EECE0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3724", Offset = "0x9F3724")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F375C", Offset = "0x9F375C")]
			public float multiplier;

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x23B29E0", Offset = "0x23B29E0", VA = "0x23B29E0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F34D8", Offset = "0x9F34D8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3510", Offset = "0x9F3510")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3548", Offset = "0x9F3548")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3580", Offset = "0x9F3580")]
		public Transform pivot;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F35B8", Offset = "0x9F35B8")]
		public RotationMode rotationMode;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F35F0", Offset = "0x9F35F0")]
		public Vector3 twistAxis;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3628", Offset = "0x9F3628")]
		public float twistWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3660", Offset = "0x9F3660")]
		public float swingWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3698", Offset = "0x9F3698")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3698", Offset = "0x9F3698")]
		public float threeDOFWeight;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F36EC", Offset = "0x9F36EC")]
		public bool rotateOnce;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x209B84C", Offset = "0x209B84C", VA = "0x209B84C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8ED4", Offset = "0x9F8ED4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x209B894", Offset = "0x209B894", VA = "0x209B894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8F0C", Offset = "0x9F8F0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x209B8DC", Offset = "0x209B8DC", VA = "0x209B8DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8F44", Offset = "0x9F8F44")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x209B924", Offset = "0x209B924", VA = "0x209B924")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8F7C", Offset = "0x9F8F7C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x209B96C", Offset = "0x209B96C", VA = "0x209B96C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8FB4", Offset = "0x9F8FB4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x209B9B4", Offset = "0x209B9B4", VA = "0x209B9B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F8FEC", Offset = "0x9F8FEC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x209B9FC", Offset = "0x209B9FC", VA = "0x209B9FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9024", Offset = "0x9F9024")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x209BA44", Offset = "0x209BA44", VA = "0x209BA44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F905C", Offset = "0x9F905C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2096E38", Offset = "0x2096E38", VA = "0x2096E38")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x209BA8C", Offset = "0x209BA8C", VA = "0x209BA8C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x209BB24", Offset = "0x209BB24", VA = "0x209BB24")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x209C1FC", Offset = "0x209C1FC", VA = "0x209C1FC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EED40", Offset = "0x9EED40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EED40", Offset = "0x9EED40")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F37CC", Offset = "0x9F37CC")]
			public bool use;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3804", Offset = "0x9F3804")]
			public Vector2 offset;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F383C", Offset = "0x9F383C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F383C", Offset = "0x9F383C")]
			public float angleOffset;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3898", Offset = "0x9F3898")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3898", Offset = "0x9F3898")]
			public float maxAngle;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F38F0", Offset = "0x9F38F0")]
			public float radius;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3928", Offset = "0x9F3928")]
			public bool orbit;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3960", Offset = "0x9F3960")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x23B2D50", Offset = "0x23B2D50", VA = "0x23B2D50")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0x23B2D5C", Offset = "0x23B2D5C", VA = "0x23B2D5C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x23B2DE4", Offset = "0x23B2DE4", VA = "0x23B2DE4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x23B3228", Offset = "0x23B3228", VA = "0x23B3228")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3998", Offset = "0x9F3998")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F39D0", Offset = "0x9F39D0")]
			public Vector3 direction;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3A08", Offset = "0x9F3A08")]
			public float maxDistance;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3A40", Offset = "0x9F3A40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3A40", Offset = "0x9F3A40")]
			public float maxAngle;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3A98", Offset = "0x9F3A98")]
			public bool fixYAxis;

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x23B29E8", Offset = "0x23B29E8", VA = "0x23B29E8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x23B2ADC", Offset = "0x23B2ADC", VA = "0x23B2ADC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x23B2D04", Offset = "0x23B2D04", VA = "0x23B2D04")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3B98", Offset = "0x9F3B98")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3BD0", Offset = "0x9F3BD0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000552")]
				[Address(RVA = "0x2726464", Offset = "0x2726464", VA = "0x2726464")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3AF0", Offset = "0x9F3AF0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3B28", Offset = "0x9F3B28")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3B60", Offset = "0x9F3B60")]
			public Interaction[] interactions;

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x23B323C", Offset = "0x23B323C", VA = "0x23B323C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x23B32F0", Offset = "0x23B32F0", VA = "0x23B32F0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3794", Offset = "0x9F3794")]
		public Range[] ranges;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x209C248", Offset = "0x209C248", VA = "0x209C248")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9094", Offset = "0x9F9094")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x209C290", Offset = "0x209C290", VA = "0x209C290")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F90CC", Offset = "0x9F90CC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x209C2D8", Offset = "0x209C2D8", VA = "0x209C2D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9104", Offset = "0x9F9104")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x209C320", Offset = "0x209C320", VA = "0x209C320")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F913C", Offset = "0x9F913C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x209C368", Offset = "0x209C368", VA = "0x209C368")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9174", Offset = "0x9F9174")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x209A2F4", Offset = "0x209A2F4", VA = "0x209A2F4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x209C3B0", Offset = "0x209C3B0", VA = "0x209C3B0")]
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
			[Address(RVA = "0x1F66B08", Offset = "0x1F66B08", VA = "0x1F66B08")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1F66B60", Offset = "0x1F66B60", VA = "0x1F66B60")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1F66BB0", Offset = "0x1F66BB0", VA = "0x1F66BB0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1F66BFC", Offset = "0x1F66BFC", VA = "0x1F66BFC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x22DFB50", Offset = "0x22DFB50", VA = "0x22DFB50", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F91AC", Offset = "0x9F91AC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x22DFEE0", Offset = "0x22DFEE0", VA = "0x22DFEE0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x22DFEE4", Offset = "0x22DFEE4", VA = "0x22DFEE4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x22DFFEC", Offset = "0x22DFFEC", VA = "0x22DFFEC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x22DFE74", Offset = "0x22DFE74", VA = "0x22DFE74")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x22DFDD4", Offset = "0x22DFDD4", VA = "0x22DFDD4")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x22E0058", Offset = "0x22E0058", VA = "0x22E0058")]
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
		[Address(RVA = "0x2411654", Offset = "0x2411654", VA = "0x2411654", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2411730", Offset = "0x2411730", VA = "0x2411730", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2411918", Offset = "0x2411918", VA = "0x2411918", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2411A14", Offset = "0x2411A14", VA = "0x2411A14", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2411794", Offset = "0x2411794", VA = "0x2411794")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2411D74", Offset = "0x2411D74", VA = "0x2411D74")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3C08", Offset = "0x9F3C08")]
		public float weight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3C20", Offset = "0x9F3C20")]
		public float localRotationWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3C38", Offset = "0x9F3C38")]
		public float localPositionWeight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000564")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x20A3E48", Offset = "0x20A3E48", VA = "0x20A3E48")]
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
		[Address(RVA = "0x20A3E54", Offset = "0x20A3E54", VA = "0x20A3E54", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x20A3EA8", Offset = "0x20A3EA8", VA = "0x20A3EA8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x20A3EE4", Offset = "0x20A3EE4", VA = "0x20A3EE4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x20A3EFC", Offset = "0x20A3EFC", VA = "0x20A3EFC")]
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
			[Address(RVA = "0x23B531C", Offset = "0x23B531C", VA = "0x23B531C")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x23B54E0", Offset = "0x23B54E0", VA = "0x23B54E0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x23B55C0", Offset = "0x23B55C0", VA = "0x23B55C0")]
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
			[Address(RVA = "0x23B5114", Offset = "0x23B5114", VA = "0x23B5114")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x23B518C", Offset = "0x23B518C", VA = "0x23B518C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x23B52CC", Offset = "0x23B52CC", VA = "0x23B52CC")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEDA0", Offset = "0x9EEDA0")]
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
				[Address(RVA = "0x23B50C4", Offset = "0x23B50C4", VA = "0x23B50C4", Slot = "4")]
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
				[Address(RVA = "0x23B510C", Offset = "0x23B510C", VA = "0x23B510C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x23B4E88", Offset = "0x23B4E88", VA = "0x23B4E88")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x23B4EB4", Offset = "0x23B4EB4", VA = "0x23B4EB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x23B4EB8", Offset = "0x23B4EB8", VA = "0x23B4EB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x23B50CC", Offset = "0x23B50CC", VA = "0x23B50CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3C50", Offset = "0x9F3C50")]
		public IK ik;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3C88", Offset = "0x9F3C88")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3CC0", Offset = "0x9F3CC0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3CF8", Offset = "0x9F3CF8")]
		public float applyVelocity;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3D30", Offset = "0x9F3D30")]
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
			[Address(RVA = "0x20A4BD0", Offset = "0x20A4BD0", VA = "0x20A4BD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x20A5604", Offset = "0x20A5604", VA = "0x20A5604")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x20A4B98", Offset = "0x20A4B98", VA = "0x20A4B98")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x20A4C48", Offset = "0x20A4C48", VA = "0x20A4C48")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x20A4D84", Offset = "0x20A4D84", VA = "0x20A4D84")]
		public void Start()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x20A4D0C", Offset = "0x20A4D0C", VA = "0x20A4D0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F91E4", Offset = "0x9F91E4")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x20A5240", Offset = "0x20A5240", VA = "0x20A5240")]
		private void Update()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x20A548C", Offset = "0x20A548C", VA = "0x20A548C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x20A5548", Offset = "0x20A5548", VA = "0x20A5548")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x20A5784", Offset = "0x20A5784", VA = "0x20A5784")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x20A55C8", Offset = "0x20A55C8", VA = "0x20A55C8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x20A5740", Offset = "0x20A5740", VA = "0x20A5740")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x20A5824", Offset = "0x20A5824", VA = "0x20A5824")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x20A57B8", Offset = "0x20A57B8", VA = "0x20A57B8")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x20A4CA0", Offset = "0x20A4CA0", VA = "0x20A4CA0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x20A54CC", Offset = "0x20A54CC", VA = "0x20A54CC")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x20A5A50", Offset = "0x20A5A50", VA = "0x20A5A50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x20A5B8C", Offset = "0x20A5B8C", VA = "0x20A5B8C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F3D78", Offset = "0x9F3D78")]
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
			[Address(RVA = "0x20A7364", Offset = "0x20A7364", VA = "0x20A7364")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x20A7370", Offset = "0x20A7370", VA = "0x20A7370")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x20A738C", Offset = "0x20A738C", VA = "0x20A738C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9294", Offset = "0x9F9294")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x20A7394", Offset = "0x20A7394", VA = "0x20A7394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F92A4", Offset = "0x9F92A4")]
			private set
			{
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x20A7064", Offset = "0x20A7064", VA = "0x20A7064")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x20A70AC", Offset = "0x20A70AC", VA = "0x20A70AC")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x20A70C4", Offset = "0x20A70C4", VA = "0x20A70C4")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x20A72BC", Offset = "0x20A72BC", VA = "0x20A72BC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x20A732C", Offset = "0x20A732C", VA = "0x20A732C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000594")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x20A71E4", Offset = "0x20A71E4", VA = "0x20A71E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x20A73A0", Offset = "0x20A73A0", VA = "0x20A73A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x20A73A4", Offset = "0x20A73A4", VA = "0x20A73A4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x20A73D8", Offset = "0x20A73D8", VA = "0x20A73D8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x20A7454", Offset = "0x20A7454", VA = "0x20A7454")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x20A75E8", Offset = "0x20A75E8", VA = "0x20A75E8")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x20A7658", Offset = "0x20A7658", VA = "0x20A7658")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEDB0", Offset = "0x9EEDB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEDB0", Offset = "0x9EEDB0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3D88", Offset = "0x9F3D88")]
		public float limit;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3DA4", Offset = "0x9F3DA4")]
		public float twistLimit;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x20A768C", Offset = "0x20A768C", VA = "0x20A768C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F92B4", Offset = "0x9F92B4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x20A76D4", Offset = "0x20A76D4", VA = "0x20A76D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F92EC", Offset = "0x9F92EC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x20A771C", Offset = "0x20A771C", VA = "0x20A771C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9324", Offset = "0x9F9324")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x20A7764", Offset = "0x20A7764", VA = "0x20A7764")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F935C", Offset = "0x9F935C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x20A77AC", Offset = "0x20A77AC", VA = "0x20A77AC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x20A77F0", Offset = "0x20A77F0", VA = "0x20A77F0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x20A79B0", Offset = "0x20A79B0", VA = "0x20A79B0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEE10", Offset = "0x9EEE10")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEE10", Offset = "0x9EEE10")]
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
		[Address(RVA = "0x20A79F0", Offset = "0x20A79F0", VA = "0x20A79F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9394", Offset = "0x9F9394")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x20A7A38", Offset = "0x20A7A38", VA = "0x20A7A38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F93CC", Offset = "0x9F93CC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x20A7A80", Offset = "0x20A7A80", VA = "0x20A7A80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9404", Offset = "0x9F9404")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x20A7AC8", Offset = "0x20A7AC8", VA = "0x20A7AC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F943C", Offset = "0x9F943C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x20A7B10", Offset = "0x20A7B10", VA = "0x20A7B10", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x20A7B14", Offset = "0x20A7B14", VA = "0x20A7B14")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x20A7C98", Offset = "0x20A7C98", VA = "0x20A7C98")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEE70", Offset = "0x9EEE70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEE70", Offset = "0x9EEE70")]
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
				[Address(RVA = "0x23B5C0C", Offset = "0x23B5C0C", VA = "0x23B5C0C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x23B5C44", Offset = "0x23B5C44", VA = "0x23B5C44")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x23B5C80", Offset = "0x23B5C80", VA = "0x23B5C80")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x23B5CBC", Offset = "0x23B5CBC", VA = "0x23B5CBC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x23B5E48", Offset = "0x23B5E48", VA = "0x23B5E48")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x23B5CF8", Offset = "0x23B5CF8", VA = "0x23B5CF8")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x23B5E58", Offset = "0x23B5E58", VA = "0x23B5E58")]
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
			[Address(RVA = "0x23B5BD0", Offset = "0x23B5BD0", VA = "0x23B5BD0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3DD0", Offset = "0x9F3DD0")]
		public float twistLimit;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3DEC", Offset = "0x9F3DEC")]
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
		[Address(RVA = "0x20A7CE0", Offset = "0x20A7CE0", VA = "0x20A7CE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9474", Offset = "0x9F9474")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x20A7D28", Offset = "0x20A7D28", VA = "0x20A7D28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F94AC", Offset = "0x9F94AC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x20A7D70", Offset = "0x20A7D70", VA = "0x20A7D70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F94E4", Offset = "0x9F94E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x20A7DB8", Offset = "0x20A7DB8", VA = "0x20A7DB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F951C", Offset = "0x9F951C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x20A7E00", Offset = "0x20A7E00", VA = "0x20A7E00")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x20A82FC", Offset = "0x20A82FC", VA = "0x20A82FC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x20A8390", Offset = "0x20A8390", VA = "0x20A8390")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x20A8904", Offset = "0x20A8904", VA = "0x20A8904")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x20A7EA8", Offset = "0x20A7EA8", VA = "0x20A7EA8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x20A8CB0", Offset = "0x20A8CB0", VA = "0x20A8CB0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x20A90BC", Offset = "0x20A90BC", VA = "0x20A90BC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x20A9100", Offset = "0x20A9100", VA = "0x20A9100")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x20A9160", Offset = "0x20A9160", VA = "0x20A9160")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x20A8694", Offset = "0x20A8694", VA = "0x20A8694")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x20A91CC", Offset = "0x20A91CC", VA = "0x20A91CC")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x20A92A8", Offset = "0x20A92A8", VA = "0x20A92A8")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9EEED0", Offset = "0x9EEED0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9EEED0", Offset = "0x9EEED0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3E34", Offset = "0x9F3E34")]
		public float twistLimit;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1F5AA88", Offset = "0x1F5AA88", VA = "0x1F5AA88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F9554", Offset = "0x9F9554")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1F5AAD0", Offset = "0x1F5AAD0", VA = "0x1F5AAD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F958C", Offset = "0x9F958C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1F5AB18", Offset = "0x1F5AB18", VA = "0x1F5AB18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F95C4", Offset = "0x9F95C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1F5AB60", Offset = "0x1F5AB60", VA = "0x1F5AB60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9F95FC", Offset = "0x9F95FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1F5ABA8", Offset = "0x1F5ABA8", VA = "0x1F5ABA8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1F5ABC4", Offset = "0x1F5ABC4", VA = "0x1F5ABC4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1F5AC64", Offset = "0x1F5AC64", VA = "0x1F5AC64")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1F5AEA0", Offset = "0x1F5AEA0", VA = "0x1F5AEA0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEF30", Offset = "0x9EEF30")]
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
				[Address(RVA = "0x1F65BF8", Offset = "0x1F65BF8", VA = "0x1F65BF8", Slot = "4")]
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
				[Address(RVA = "0x1F65C40", Offset = "0x1F65C40", VA = "0x1F65C40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1F65AFC", Offset = "0x1F65AFC", VA = "0x1F65AFC")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1F65B28", Offset = "0x1F65B28", VA = "0x1F65B28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1F65B2C", Offset = "0x1F65B2C", VA = "0x1F65B2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1F65C00", Offset = "0x1F65C00", VA = "0x1F65C00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3E60", Offset = "0x9F3E60")]
		public AimIK ik;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3E98", Offset = "0x9F3E98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F3E98", Offset = "0x9F3E98")]
		public float weight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3EEC", Offset = "0x9F3EEC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F3EEC", Offset = "0x9F3EEC")]
		public Transform target;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3F4C", Offset = "0x9F3F4C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3F84", Offset = "0x9F3F84")]
		public float weightSmoothTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F3FBC", Offset = "0x9F3FBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F3FBC", Offset = "0x9F3FBC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F401C", Offset = "0x9F401C")]
		public float maxRadiansDelta;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4054", Offset = "0x9F4054")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F408C", Offset = "0x9F408C")]
		public float slerpSpeed;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F40C4", Offset = "0x9F40C4")]
		public float smoothDampTime;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F40FC", Offset = "0x9F40FC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4134", Offset = "0x9F4134")]
		public float minDistance;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F416C", Offset = "0x9F416C")]
		public Vector3 offset;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F41A4", Offset = "0x9F41A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F41A4", Offset = "0x9F41A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F41A4", Offset = "0x9F41A4")]
		public float maxRootAngle;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4220", Offset = "0x9F4220")]
		public bool turnToTarget;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4258", Offset = "0x9F4258")]
		public float turnToTargetTime;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F4290", Offset = "0x9F4290")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4290", Offset = "0x9F4290")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F42F0", Offset = "0x9F42F0")]
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
			[Address(RVA = "0x224018C", Offset = "0x224018C", VA = "0x224018C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x2240100", Offset = "0x2240100", VA = "0x2240100")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x224021C", Offset = "0x224021C", VA = "0x224021C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2240900", Offset = "0x2240900", VA = "0x2240900")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x22409EC", Offset = "0x22409EC", VA = "0x22409EC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x2240C3C", Offset = "0x2240C3C", VA = "0x2240C3C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9634", Offset = "0x9F9634")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x2240CB4", Offset = "0x2240CB4", VA = "0x2240CB4")]
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
			[Address(RVA = "0x1F65C48", Offset = "0x1F65C48", VA = "0x1F65C48")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1F65DD4", Offset = "0x1F65DD4", VA = "0x1F65DD4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1F65DDC", Offset = "0x1F65DDC", VA = "0x1F65DDC")]
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
		[Address(RVA = "0x2240F24", Offset = "0x2240F24", VA = "0x2240F24")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x2241004", Offset = "0x2241004", VA = "0x2241004")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x2241070", Offset = "0x2241070", VA = "0x2241070")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F44B0", Offset = "0x9F44B0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F44E8", Offset = "0x9F44E8")]
				public float weight;

				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x2726048", Offset = "0x2726048", VA = "0x2726048")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4360", Offset = "0x9F4360")]
			public Transform transform;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4398", Offset = "0x9F4398")]
			public Transform relativeTo;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F43D0", Offset = "0x9F43D0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4408", Offset = "0x9F4408")]
			public float verticalWeight;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4440", Offset = "0x9F4440")]
			public float horizontalWeight;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4478", Offset = "0x9F4478")]
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
			[Address(RVA = "0x1F65DF8", Offset = "0x1F65DF8", VA = "0x1F65DF8")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1F6611C", Offset = "0x1F6611C", VA = "0x1F6611C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1F6612C", Offset = "0x1F6612C", VA = "0x1F6612C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4328", Offset = "0x9F4328")]
		public Body[] bodies;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x224118C", Offset = "0x224118C", VA = "0x224118C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x22412D8", Offset = "0x22412D8", VA = "0x22412D8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4520", Offset = "0x9F4520")]
		public float tiltSpeed;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4558", Offset = "0x9F4558")]
		public float tiltSensitivity;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4590", Offset = "0x9F4590")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F45C8", Offset = "0x9F45C8")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x224F520", Offset = "0x224F520", VA = "0x224F520", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x224F568", Offset = "0x224F568", VA = "0x224F568", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x224F720", Offset = "0x224F720", VA = "0x224F720")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F4600", Offset = "0x9F4600")]
		public float weight;

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x224F734", Offset = "0x224F734", VA = "0x224F734")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x224F80C", Offset = "0x224F80C", VA = "0x224F80C")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x224FA34", Offset = "0x224FA34", VA = "0x224FA34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x224FB64", Offset = "0x224FB64", VA = "0x224FB64")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4618", Offset = "0x9F4618")]
		public Animator animator;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4650", Offset = "0x9F4650")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F4698", Offset = "0x9F4698")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009F")]
		public IK ik
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x22D4184", Offset = "0x22D4184", VA = "0x22D4184")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F96E4", Offset = "0x9F96E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x22D418C", Offset = "0x22D418C", VA = "0x22D418C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F96F4", Offset = "0x9F96F4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x22D4194", Offset = "0x22D4194", VA = "0x22D4194")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x22D4350", Offset = "0x22D4350", VA = "0x22D4350")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x22D45DC", Offset = "0x22D45DC", VA = "0x22D45DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x22D4734", Offset = "0x22D4734", VA = "0x22D4734")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x22D4924", Offset = "0x22D4924", VA = "0x22D4924")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x22D4B5C", Offset = "0x22D4B5C", VA = "0x22D4B5C")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x22D4E08", Offset = "0x22D4E08", VA = "0x22D4E08")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9EEF50", Offset = "0x9EEF50")]
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
			[Address(RVA = "0x22D4448", Offset = "0x22D4448", VA = "0x22D4448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x22D47B4", Offset = "0x22D47B4", VA = "0x22D47B4")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x22D446C", Offset = "0x22D446C", VA = "0x22D446C")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x22D4E70", Offset = "0x22D4E70", VA = "0x22D4E70")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4718", Offset = "0x9F4718")]
			public string name;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4750", Offset = "0x9F4750")]
			public Collider collider;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4788", Offset = "0x9F4788")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F47D4", Offset = "0x9F47D4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F47E4", Offset = "0x9F47E4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F47F4", Offset = "0x9F47F4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F4804", Offset = "0x9F4804")]
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
				[Address(RVA = "0x1F688AC", Offset = "0x1F688AC", VA = "0x1F688AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A3")]
			protected float crossFader
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x1F688C0", Offset = "0x1F688C0", VA = "0x1F688C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9704", Offset = "0x9F9704")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x1F688C8", Offset = "0x1F688C8", VA = "0x1F688C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9714", Offset = "0x9F9714")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected float timer
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x1F688D0", Offset = "0x1F688D0", VA = "0x1F688D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9724", Offset = "0x9F9724")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x1F688D8", Offset = "0x1F688D8", VA = "0x1F688D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9734", Offset = "0x9F9734")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x1F688E0", Offset = "0x1F688E0", VA = "0x1F688E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9744", Offset = "0x9F9744")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x1F688EC", Offset = "0x1F688EC", VA = "0x1F688EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9754", Offset = "0x9F9754")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x1F688F8", Offset = "0x1F688F8", VA = "0x1F688F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9764", Offset = "0x9F9764")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x1F68904", Offset = "0x1F68904", VA = "0x1F68904")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9774", Offset = "0x9F9774")]
				private set
				{
				}
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1F68910", Offset = "0x1F68910", VA = "0x1F68910")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1F68A44", Offset = "0x1F68A44", VA = "0x1F68A44")]
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
			[Address(RVA = "0x1F68B18", Offset = "0x1F68B18", VA = "0x1F68B18")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F48BC", Offset = "0x9F48BC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400055C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F48F4", Offset = "0x9F48F4")]
				public float weight;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x27261B8", Offset = "0x27261B8", VA = "0x27261B8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2726268", Offset = "0x2726268", VA = "0x2726268")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x272627C", Offset = "0x272627C", VA = "0x272627C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4814", Offset = "0x9F4814")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F484C", Offset = "0x9F484C")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4884", Offset = "0x9F4884")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1F68E54", Offset = "0x1F68E54", VA = "0x1F68E54", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1F68F84", Offset = "0x1F68F84", VA = "0x1F68F84", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1F68FF0", Offset = "0x1F68FF0", VA = "0x1F68FF0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1F69158", Offset = "0x1F69158", VA = "0x1F69158")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F499C", Offset = "0x9F499C")]
				public Transform bone;

				[Token(Token = "0x4000563")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F49D4", Offset = "0x9F49D4")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F49D4", Offset = "0x9F49D4")]
				public float weight;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000615")]
				[Address(RVA = "0x2726050", Offset = "0x2726050", VA = "0x2726050")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000616")]
				[Address(RVA = "0x2726168", Offset = "0x2726168", VA = "0x2726168")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x2726174", Offset = "0x2726174", VA = "0x2726174")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F492C", Offset = "0x9F492C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4964", Offset = "0x9F4964")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1F68B2C", Offset = "0x1F68B2C", VA = "0x1F68B2C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1F68BD0", Offset = "0x1F68BD0", VA = "0x1F68BD0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1F68C3C", Offset = "0x1F68C3C", VA = "0x1F68C3C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1F68E40", Offset = "0x1F68E40", VA = "0x1F68E40")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F46A8", Offset = "0x9F46A8")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F46E0", Offset = "0x9F46E0")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A1")]
		public bool inProgress
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x2412C1C", Offset = "0x2412C1C", VA = "0x2412C1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2412CEC", Offset = "0x2412CEC", VA = "0x2412CEC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2412DC8", Offset = "0x2412DC8", VA = "0x2412DC8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2413024", Offset = "0x2413024", VA = "0x2413024")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4A98", Offset = "0x9F4A98")]
			public string name;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4AD0", Offset = "0x9F4AD0")]
			public Collider collider;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4B08", Offset = "0x9F4B08")]
			private float crossFadeTime;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F4B54", Offset = "0x9F4B54")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F4B64", Offset = "0x9F4B64")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F4B74", Offset = "0x9F4B74")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F4B84", Offset = "0x9F4B84")]
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
				[Address(RVA = "0x1F6916C", Offset = "0x1F6916C", VA = "0x1F6916C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9784", Offset = "0x9F9784")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x1F69174", Offset = "0x1F69174", VA = "0x1F69174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9794", Offset = "0x9F9794")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected float timer
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x1F6917C", Offset = "0x1F6917C", VA = "0x1F6917C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F97A4", Offset = "0x9F97A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x1F69184", Offset = "0x1F69184", VA = "0x1F69184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F97B4", Offset = "0x9F97B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 force
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x1F6918C", Offset = "0x1F6918C", VA = "0x1F6918C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F97C4", Offset = "0x9F97C4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1F69198", Offset = "0x1F69198", VA = "0x1F69198")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F97D4", Offset = "0x9F97D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x1F691A4", Offset = "0x1F691A4", VA = "0x1F691A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F97E4", Offset = "0x9F97E4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x1F691B0", Offset = "0x1F691B0", VA = "0x1F691B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F97F4", Offset = "0x9F97F4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1F691BC", Offset = "0x1F691BC", VA = "0x1F691BC")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1F69304", Offset = "0x1F69304", VA = "0x1F69304")]
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
			[Address(RVA = "0x1F693EC", Offset = "0x1F693EC", VA = "0x1F693EC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4C3C", Offset = "0x9F4C3C")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4C74", Offset = "0x9F4C74")]
				public float weight;

				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600062D")]
				[Address(RVA = "0x2726284", Offset = "0x2726284", VA = "0x2726284")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600062E")]
				[Address(RVA = "0x2726314", Offset = "0x2726314", VA = "0x2726314")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600062F")]
				[Address(RVA = "0x2726328", Offset = "0x2726328", VA = "0x2726328")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4B94", Offset = "0x9F4B94")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4BCC", Offset = "0x9F4BCC")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4C04", Offset = "0x9F4C04")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1F69400", Offset = "0x1F69400", VA = "0x1F69400", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1F695B0", Offset = "0x1F695B0", VA = "0x1F695B0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1F6961C", Offset = "0x1F6961C", VA = "0x1F6961C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1F697BC", Offset = "0x1F697BC", VA = "0x1F697BC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4D1C", Offset = "0x9F4D1C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400057E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4D54", Offset = "0x9F4D54")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F4D54", Offset = "0x9F4D54")]
				public float weight;

				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000634")]
				[Address(RVA = "0x2726330", Offset = "0x2726330", VA = "0x2726330")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000635")]
				[Address(RVA = "0x272640C", Offset = "0x272640C", VA = "0x272640C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000636")]
				[Address(RVA = "0x2726418", Offset = "0x2726418", VA = "0x2726418")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4CAC", Offset = "0x9F4CAC")]
			public int curveIndex;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4CE4", Offset = "0x9F4CE4")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1F697D8", Offset = "0x1F697D8", VA = "0x1F697D8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1F698BC", Offset = "0x1F698BC", VA = "0x1F698BC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1F69928", Offset = "0x1F69928", VA = "0x1F69928", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1F69BE4", Offset = "0x1F69BE4", VA = "0x1F69BE4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4A28", Offset = "0x9F4A28")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4A60", Offset = "0x9F4A60")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x2413384", Offset = "0x2413384", VA = "0x2413384", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2413458", Offset = "0x2413458", VA = "0x2413458")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x24136BC", Offset = "0x24136BC", VA = "0x24136BC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4F84", Offset = "0x9F4F84")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4FBC", Offset = "0x9F4FBC")]
				public float weight;

				[Token(Token = "0x600063D")]
				[Address(RVA = "0x272645C", Offset = "0x272645C", VA = "0x272645C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4E18", Offset = "0x9F4E18")]
			public Transform transform;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4E50", Offset = "0x9F4E50")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4E88", Offset = "0x9F4E88")]
			public float speed;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4EC0", Offset = "0x9F4EC0")]
			public float acceleration;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4EF8", Offset = "0x9F4EF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F4EF8", Offset = "0x9F4EF8")]
			public float matchVelocity;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4F4C", Offset = "0x9F4F4C")]
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
			[Address(RVA = "0x23B1AFC", Offset = "0x23B1AFC", VA = "0x23B1AFC")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x23B1BB4", Offset = "0x23B1BB4", VA = "0x23B1BB4")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x23B1E70", Offset = "0x23B1E70", VA = "0x23B1E70")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4DA8", Offset = "0x9F4DA8")]
		public Body[] bodies;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4DE0", Offset = "0x9F4DE0")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x240CF00", Offset = "0x240CF00", VA = "0x240CF00")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x240CF7C", Offset = "0x240CF7C", VA = "0x240CF7C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x240D03C", Offset = "0x240D03C", VA = "0x240D03C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F4FF4", Offset = "0x9F4FF4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F4FF4", Offset = "0x9F4FF4")]
		public Transform target;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F5054", Offset = "0x9F5054")]
		public float weight;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F506C", Offset = "0x9F506C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F50A4", Offset = "0x9F50A4")]
		public float weightSmoothTime;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F50DC", Offset = "0x9F50DC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F50DC", Offset = "0x9F50DC")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F513C", Offset = "0x9F513C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5174", Offset = "0x9F5174")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F51AC", Offset = "0x9F51AC")]
		public float slerpSpeed;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F51E4", Offset = "0x9F51E4")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F521C", Offset = "0x9F521C")]
		public float minDistance;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5254", Offset = "0x9F5254")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F5254", Offset = "0x9F5254")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F5254", Offset = "0x9F5254")]
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
			[Address(RVA = "0x209DA68", Offset = "0x209DA68", VA = "0x209DA68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x209D9F4", Offset = "0x209D9F4", VA = "0x209D9F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x209DAF8", Offset = "0x209DAF8", VA = "0x209DAF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x209E03C", Offset = "0x209E03C", VA = "0x209E03C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x209E128", Offset = "0x209E128", VA = "0x209E128")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x209E320", Offset = "0x209E320", VA = "0x209E320")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5340", Offset = "0x9F5340")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5378", Offset = "0x9F5378")]
			public float spring;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F53B0", Offset = "0x9F53B0")]
			public bool x;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F53E8", Offset = "0x9F53E8")]
			public bool y;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5420", Offset = "0x9F5420")]
			public bool z;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5458", Offset = "0x9F5458")]
			public float minX;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5490", Offset = "0x9F5490")]
			public float maxX;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F54C8", Offset = "0x9F54C8")]
			public float minY;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5500", Offset = "0x9F5500")]
			public float maxY;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5538", Offset = "0x9F5538")]
			public float minZ;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5570", Offset = "0x9F5570")]
			public float maxZ;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x23B427C", Offset = "0x23B427C", VA = "0x23B427C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x23B43D4", Offset = "0x23B43D4", VA = "0x23B43D4")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x23B444C", Offset = "0x23B444C", VA = "0x23B444C")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x23B44A4", Offset = "0x23B44A4", VA = "0x23B44A4")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEFBC", Offset = "0x9EEFBC")]
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
				[Address(RVA = "0x23B422C", Offset = "0x23B422C", VA = "0x23B422C", Slot = "4")]
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
				[Address(RVA = "0x23B4274", Offset = "0x23B4274", VA = "0x23B4274", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x23B4080", Offset = "0x23B4080", VA = "0x23B4080")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x23B40AC", Offset = "0x23B40AC", VA = "0x23B40AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x23B40B0", Offset = "0x23B40B0", VA = "0x23B40B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x23B4234", Offset = "0x23B4234", VA = "0x23B4234", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F52D0", Offset = "0x9F52D0")]
		public float weight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5308", Offset = "0x9F5308")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x20A154C", Offset = "0x20A154C", VA = "0x20A154C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000645")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x20A02A8", Offset = "0x20A02A8", VA = "0x20A02A8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x20A1578", Offset = "0x20A1578", VA = "0x20A1578")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9804", Offset = "0x9F9804")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x20A15F0", Offset = "0x20A15F0", VA = "0x20A15F0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x20A16CC", Offset = "0x20A16CC", VA = "0x20A16CC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x20A063C", Offset = "0x20A063C", VA = "0x20A063C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x20A0780", Offset = "0x20A0780", VA = "0x20A0780")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEFCC", Offset = "0x9EEFCC")]
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
				[Address(RVA = "0x23B4658", Offset = "0x23B4658", VA = "0x23B4658", Slot = "4")]
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
				[Address(RVA = "0x23B46A0", Offset = "0x23B46A0", VA = "0x23B46A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x23B44AC", Offset = "0x23B44AC", VA = "0x23B44AC")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x23B44D8", Offset = "0x23B44D8", VA = "0x23B44D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x23B44DC", Offset = "0x23B44DC", VA = "0x23B44DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x23B4660", Offset = "0x23B4660", VA = "0x23B4660", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F55A8", Offset = "0x9F55A8")]
		public float weight;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F55E0", Offset = "0x9F55E0")]
		public VRIK ik;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		protected float deltaTime
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x20A178C", Offset = "0x20A178C", VA = "0x20A178C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000657")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x20A17B8", Offset = "0x20A17B8", VA = "0x20A17B8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x20A17E4", Offset = "0x20A17E4", VA = "0x20A17E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F98B4", Offset = "0x9F98B4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x20A185C", Offset = "0x20A185C", VA = "0x20A185C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x20A1938", Offset = "0x20A1938", VA = "0x20A1938", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x20A1A68", Offset = "0x20A1A68", VA = "0x20A1A68")]
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
			[Address(RVA = "0x23B46A8", Offset = "0x23B46A8", VA = "0x23B46A8")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x23B48C4", Offset = "0x23B48C4", VA = "0x23B48C4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x20A1A78", Offset = "0x20A1A78", VA = "0x20A1A78")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x20A1B3C", Offset = "0x20A1B3C", VA = "0x20A1B3C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x20A1BF8", Offset = "0x20A1BF8", VA = "0x20A1BF8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F57F4", Offset = "0x9F57F4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F582C", Offset = "0x9F582C")]
				public float weight;

				[Token(Token = "0x600066E")]
				[Address(RVA = "0x272646C", Offset = "0x272646C", VA = "0x272646C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5650", Offset = "0x9F5650")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5688", Offset = "0x9F5688")]
			public Transform raycastTo;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F56C0", Offset = "0x9F56C0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F56C0", Offset = "0x9F56C0")]
			public float raycastRadius;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5714", Offset = "0x9F5714")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F574C", Offset = "0x9F574C")]
			public float smoothTimeIn;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5784", Offset = "0x9F5784")]
			public float smoothTimeOut;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F57BC", Offset = "0x9F57BC")]
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
			[Address(RVA = "0x23B48CC", Offset = "0x23B48CC", VA = "0x23B48CC")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x23B4A10", Offset = "0x23B4A10", VA = "0x23B4A10")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x23B4B08", Offset = "0x23B4B08", VA = "0x23B4B08")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x23B4CD8", Offset = "0x23B4CD8", VA = "0x23B4CD8")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5618", Offset = "0x9F5618")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x20A25B8", Offset = "0x20A25B8", VA = "0x20A25B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x20A2640", Offset = "0x20A2640", VA = "0x20A2640")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5BB8", Offset = "0x9F5BB8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5BF0", Offset = "0x9F5BF0")]
				public float weight;

				[Token(Token = "0x600067E")]
				[Address(RVA = "0x2726474", Offset = "0x2726474", VA = "0x2726474")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5ABC", Offset = "0x9F5ABC")]
			public Vector3 offset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5AF4", Offset = "0x9F5AF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F5AF4", Offset = "0x9F5AF4")]
			public float additivity;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5B48", Offset = "0x9F5B48")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5B80", Offset = "0x9F5B80")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x23B5764", Offset = "0x23B5764", VA = "0x23B5764")]
			public void Start()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x23B57B4", Offset = "0x23B57B4", VA = "0x23B57B4")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x23B5978", Offset = "0x23B5978", VA = "0x23B5978")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5864", Offset = "0x9F5864")]
		public AimIK aimIK;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F589C", Offset = "0x9F589C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F58D4", Offset = "0x9F58D4")]
		public Handedness handedness;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F590C", Offset = "0x9F590C")]
		public bool twoHanded;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5944", Offset = "0x9F5944")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F597C", Offset = "0x9F597C")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F59B4", Offset = "0x9F59B4")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F59EC", Offset = "0x9F59EC")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5A24", Offset = "0x9F5A24")]
		public float blendTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9F5A5C", Offset = "0x9F5A5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5A5C", Offset = "0x9F5A5C")]
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
			[Address(RVA = "0x20A5EB0", Offset = "0x20A5EB0", VA = "0x20A5EB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x20A694C", Offset = "0x20A694C", VA = "0x20A694C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x20A698C", Offset = "0x20A698C", VA = "0x20A698C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x20A690C", Offset = "0x20A690C", VA = "0x20A690C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x20A692C", Offset = "0x20A692C", VA = "0x20A692C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x20A5EE0", Offset = "0x20A5EE0", VA = "0x20A5EE0")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x20A5F0C", Offset = "0x20A5F0C", VA = "0x20A5F0C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x20A6054", Offset = "0x20A6054", VA = "0x20A6054", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x20A69CC", Offset = "0x20A69CC", VA = "0x20A69CC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x20A6A80", Offset = "0x20A6A80", VA = "0x20A6A80")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x20A6ABC", Offset = "0x20A6ABC", VA = "0x20A6ABC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x20A6CA8", Offset = "0x20A6CA8", VA = "0x20A6CA8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5C28", Offset = "0x9F5C28")]
		public float weight;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5C60", Offset = "0x9F5C60")]
		public float offset;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1F5B0B0", Offset = "0x1F5B0B0", VA = "0x1F5B0B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1F5B1B8", Offset = "0x1F5B1B8", VA = "0x1F5B1B8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1F5B2A0", Offset = "0x1F5B2A0", VA = "0x1F5B2A0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1F5B5F0", Offset = "0x1F5B5F0", VA = "0x1F5B5F0")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1F5B664", Offset = "0x1F5B664", VA = "0x1F5B664")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1F5B794", Offset = "0x1F5B794", VA = "0x1F5B794")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5C98", Offset = "0x9F5C98")]
			public float scaleMlp;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5CD0", Offset = "0x9F5CD0")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5D08", Offset = "0x9F5D08")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5D40", Offset = "0x9F5D40")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5D78", Offset = "0x9F5D78")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5DB0", Offset = "0x9F5DB0")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5DE8", Offset = "0x9F5DE8")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9F5E20", Offset = "0x9F5E20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5E20", Offset = "0x9F5E20")]
			public Vector3 headOffset;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5E70", Offset = "0x9F5E70")]
			public Vector3 handOffset;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5EA8", Offset = "0x9F5EA8")]
			public float footForwardOffset;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5EE0", Offset = "0x9F5EE0")]
			public float footInwardOffset;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F5F18", Offset = "0x9F5F18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5F18", Offset = "0x9F5F18")]
			public float footHeadingOffset;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F5F74", Offset = "0x9F5F74")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F5F8C", Offset = "0x9F5F8C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x2725BFC", Offset = "0x2725BFC", VA = "0x2725BFC")]
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
				[Address(RVA = "0x272647C", Offset = "0x272647C", VA = "0x272647C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000697")]
				[Address(RVA = "0x272653C", Offset = "0x272653C", VA = "0x272653C")]
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
			[Address(RVA = "0x2725BF4", Offset = "0x2725BF4", VA = "0x2725BF4")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1F62C68", Offset = "0x1F62C68", VA = "0x1F62C68")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1F61798", Offset = "0x1F61798", VA = "0x1F61798")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1F62DDC", Offset = "0x1F62DDC", VA = "0x1F62DDC")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1F62CF0", Offset = "0x1F62CF0", VA = "0x1F62CF0")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1F619DC", Offset = "0x1F619DC", VA = "0x1F619DC")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1F62DF4", Offset = "0x1F62DF4", VA = "0x1F62DF4")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1F60C90", Offset = "0x1F60C90", VA = "0x1F60C90")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1F63638", Offset = "0x1F63638", VA = "0x1F63638")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1F60A58", Offset = "0x1F60A58", VA = "0x1F60A58")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1F63AA8", Offset = "0x1F63AA8", VA = "0x1F63AA8")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1F64170", Offset = "0x1F64170", VA = "0x1F64170")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1F63F04", Offset = "0x1F63F04", VA = "0x1F63F04")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1F643EC", Offset = "0x1F643EC", VA = "0x1F643EC")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1F64648", Offset = "0x1F64648", VA = "0x1F64648")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1F64738", Offset = "0x1F64738", VA = "0x1F64738")]
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
		[Address(RVA = "0x1F64A54", Offset = "0x1F64A54", VA = "0x1F64A54")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1F64AB0", Offset = "0x1F64AB0", VA = "0x1F64AB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1F64AE4", Offset = "0x1F64AE4", VA = "0x1F64AE4")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1F64C20", Offset = "0x1F64C20", VA = "0x1F64C20")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F5FA4", Offset = "0x9F5FA4")]
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
			[Address(RVA = "0x1F65328", Offset = "0x1F65328", VA = "0x1F65328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9964", Offset = "0x9F9964")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1F65334", Offset = "0x1F65334", VA = "0x1F65334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9974", Offset = "0x9F9974")]
			private set
			{
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1F65340", Offset = "0x1F65340", VA = "0x1F65340")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1F63408", Offset = "0x1F63408", VA = "0x1F63408")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1F638EC", Offset = "0x1F638EC", VA = "0x1F638EC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1F65450", Offset = "0x1F65450", VA = "0x1F65450")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1F6586C", Offset = "0x1F6586C", VA = "0x1F6586C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1F6599C", Offset = "0x1F6599C", VA = "0x1F6599C")]
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
			[Address(RVA = "0x1F6698C", Offset = "0x1F6698C", VA = "0x1F6698C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1F66B00", Offset = "0x1F66B00", VA = "0x1F66B00")]
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
		[Address(RVA = "0x22DC05C", Offset = "0x22DC05C", VA = "0x22DC05C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x22DC0B8", Offset = "0x22DC0B8", VA = "0x22DC0B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x22DC134", Offset = "0x22DC134", VA = "0x22DC134")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x22DC218", Offset = "0x22DC218", VA = "0x22DC218")]
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
		[Address(RVA = "0x2240074", Offset = "0x2240074", VA = "0x2240074")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x22400F8", Offset = "0x22400F8", VA = "0x22400F8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5FC4", Offset = "0x9F5FC4")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x22410E0", Offset = "0x22410E0", VA = "0x22410E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x2241158", Offset = "0x2241158", VA = "0x2241158")]
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
		[Address(RVA = "0x1F5AEB0", Offset = "0x1F5AEB0", VA = "0x1F5AEB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1F5AEF4", Offset = "0x1F5AEF4", VA = "0x1F5AEF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1F5B0A8", Offset = "0x1F5B0A8", VA = "0x1F5B0A8")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F5FFC", Offset = "0x9F5FFC")]
		public AimPoser aimPoser;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6034", Offset = "0x9F6034")]
		public AimIK aim;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F606C", Offset = "0x9F606C")]
		public LookAtIK lookAt;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F60A4", Offset = "0x9F60A4")]
		public Animator animator;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F60DC", Offset = "0x9F60DC")]
		public float crossfadeTime;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6114", Offset = "0x9F6114")]
		public float minAimDistance;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1F5B7A8", Offset = "0x1F5B7A8", VA = "0x1F5B7A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1F5B7EC", Offset = "0x1F5B7EC", VA = "0x1F5B7EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1F5B954", Offset = "0x1F5B954", VA = "0x1F5B954")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1F5BB00", Offset = "0x1F5BB00", VA = "0x1F5BB00")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1F5BC3C", Offset = "0x1F5BC3C", VA = "0x1F5BC3C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1F5BCB8", Offset = "0x1F5BCB8", VA = "0x1F5BCB8")]
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
		[Address(RVA = "0x1F5CCBC", Offset = "0x1F5CCBC", VA = "0x1F5CCBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1F5CE2C", Offset = "0x1F5CE2C", VA = "0x1F5CE2C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1F5CFC0", Offset = "0x1F5CFC0", VA = "0x1F5CFC0")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F614C", Offset = "0x9F614C")]
		public Animator animator;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F6184", Offset = "0x9F6184")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F61BC", Offset = "0x9F61BC")]
		public float lookAtWeight;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F61D4", Offset = "0x9F61D4")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F61EC", Offset = "0x9F61EC")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6204", Offset = "0x9F6204")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F621C", Offset = "0x9F621C")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6234", Offset = "0x9F6234")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F624C", Offset = "0x9F624C")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F6264", Offset = "0x9F6264")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F629C", Offset = "0x9F629C")]
		public float footPositionWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F62B4", Offset = "0x9F62B4")]
		public float footRotationWeight;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x9F62CC", Offset = "0x9F62CC")]
		public Transform handTargetBiped;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6304", Offset = "0x9F6304")]
		public float handPositionWeight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F631C", Offset = "0x9F631C")]
		public float handRotationWeight;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2247BA0", Offset = "0x2247BA0", VA = "0x2247BA0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2247FA8", Offset = "0x2247FA8", VA = "0x2247FA8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F6334", Offset = "0x9F6334")]
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
			[Address(RVA = "0x209E528", Offset = "0x209E528", VA = "0x209E528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9984", Offset = "0x9F9984")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x209E534", Offset = "0x209E534", VA = "0x209E534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9994", Offset = "0x9F9994")]
			private set
			{
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x209E540", Offset = "0x209E540", VA = "0x209E540")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x209E57C", Offset = "0x209E57C", VA = "0x209E57C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x209EDF0", Offset = "0x209EDF0", VA = "0x209EDF0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x209EBA0", Offset = "0x209EBA0", VA = "0x209EBA0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x209EEEC", Offset = "0x209EEEC", VA = "0x209EEEC")]
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
			[Address(RVA = "0x209EF18", Offset = "0x209EF18", VA = "0x209EF18")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x209EF9C", Offset = "0x209EF9C", VA = "0x209EF9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x209F1C0", Offset = "0x209F1C0", VA = "0x209F1C0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEFDC", Offset = "0x9EEFDC")]
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
				[Address(RVA = "0x23B3DB4", Offset = "0x23B3DB4", VA = "0x23B3DB4", Slot = "4")]
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
				[Address(RVA = "0x23B3DFC", Offset = "0x23B3DFC", VA = "0x23B3DFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x23B3AB8", Offset = "0x23B3AB8", VA = "0x23B3AB8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x23B3AE4", Offset = "0x23B3AE4", VA = "0x23B3AE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x23B3AE8", Offset = "0x23B3AE8", VA = "0x23B3AE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x23B3DBC", Offset = "0x23B3DBC", VA = "0x23B3DBC", Slot = "8")]
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
			[Address(RVA = "0x209F1D4", Offset = "0x209F1D4", VA = "0x209F1D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 position
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x209EEB8", Offset = "0x209EEB8", VA = "0x209EEB8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x209F1E8", Offset = "0x209F1E8", VA = "0x209F1E8")]
			set
			{
			}
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x209F238", Offset = "0x209F238", VA = "0x209F238")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x209F464", Offset = "0x209F464", VA = "0x209F464")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x209F600", Offset = "0x209F600", VA = "0x209F600")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x209F834", Offset = "0x209F834", VA = "0x209F834")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x209FAA8", Offset = "0x209FAA8", VA = "0x209FAA8")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x209FC20", Offset = "0x209FC20", VA = "0x209FC20")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x209F780", Offset = "0x209F780", VA = "0x209F780")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F99A4", Offset = "0x9F99A4")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x209FE1C", Offset = "0x209FE1C", VA = "0x209FE1C")]
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
		[Address(RVA = "0x209FE80", Offset = "0x209FE80", VA = "0x209FE80")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x209FF50", Offset = "0x209FF50", VA = "0x209FF50")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x20A01A4", Offset = "0x20A01A4", VA = "0x20A01A4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6404", Offset = "0x9F6404")]
			public int animationLayer;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F643C", Offset = "0x9F643C")]
			public string animationState;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6474", Offset = "0x9F6474")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F64AC", Offset = "0x9F64AC")]
			public Transform warpFrom;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F64E4", Offset = "0x9F64E4")]
			public Transform warpTo;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F651C", Offset = "0x9F651C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6344", Offset = "0x9F6344")]
		public Animator animator;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F637C", Offset = "0x9F637C")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9F63B4", Offset = "0x9F63B4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F63B4", Offset = "0x9F63B4")]
		public Warp[] warps;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x22412E0", Offset = "0x22412E0", VA = "0x22412E0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x224130C", Offset = "0x224130C", VA = "0x224130C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x224154C", Offset = "0x224154C", VA = "0x224154C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x2241810", Offset = "0x2241810", VA = "0x2241810")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x22418B0", Offset = "0x22418B0", VA = "0x22418B0")]
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
		[Address(RVA = "0x22418B8", Offset = "0x22418B8", VA = "0x22418B8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x2241914", Offset = "0x2241914", VA = "0x2241914")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x2241AB0", Offset = "0x2241AB0", VA = "0x2241AB0", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x2241CB8", Offset = "0x2241CB8", VA = "0x2241CB8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6554", Offset = "0x9F6554")]
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
		[Address(RVA = "0x2241CCC", Offset = "0x2241CCC", VA = "0x2241CCC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x2241E98", Offset = "0x2241E98", VA = "0x2241E98", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x2241F14", Offset = "0x2241F14", VA = "0x2241F14")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x2242008", Offset = "0x2242008", VA = "0x2242008")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x2242050", Offset = "0x2242050", VA = "0x2242050")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x224243C", Offset = "0x224243C", VA = "0x224243C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x22422C4", Offset = "0x22422C4", VA = "0x22422C4")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x2242698", Offset = "0x2242698", VA = "0x2242698")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x22427C8", Offset = "0x22427C8", VA = "0x22427C8")]
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
		[Address(RVA = "0x22516B8", Offset = "0x22516B8", VA = "0x22516B8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x225171C", Offset = "0x225171C", VA = "0x225171C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x2251958", Offset = "0x2251958", VA = "0x2251958")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x2251A4C", Offset = "0x2251A4C", VA = "0x2251A4C")]
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
			[Address(RVA = "0x22524A8", Offset = "0x22524A8", VA = "0x22524A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x225252C", Offset = "0x225252C", VA = "0x225252C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x22522A8", Offset = "0x22522A8", VA = "0x22522A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x225231C", Offset = "0x225231C", VA = "0x225231C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x22525B0", Offset = "0x22525B0", VA = "0x22525B0")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F656C", Offset = "0x9F656C")]
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
		[Address(RVA = "0x22D4F08", Offset = "0x22D4F08", VA = "0x22D4F08", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x22D5368", Offset = "0x22D5368", VA = "0x22D5368")]
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
		[Address(RVA = "0x22D5370", Offset = "0x22D5370", VA = "0x22D5370")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x22D542C", Offset = "0x22D542C", VA = "0x22D542C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x22D57B0", Offset = "0x22D57B0", VA = "0x22D57B0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x22D585C", Offset = "0x22D585C", VA = "0x22D585C")]
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
			[Address(RVA = "0x1F66458", Offset = "0x1F66458", VA = "0x1F66458")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1F664DC", Offset = "0x1F664DC", VA = "0x1F664DC")]
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
		[Address(RVA = "0x22D92F0", Offset = "0x22D92F0", VA = "0x22D92F0")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x22D9448", Offset = "0x22D9448", VA = "0x22D9448")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x22D94EC", Offset = "0x22D94EC", VA = "0x22D94EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x22D94F0", Offset = "0x22D94F0", VA = "0x22D94F0")]
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
		[Address(RVA = "0x22D9500", Offset = "0x22D9500", VA = "0x22D9500")]
		private void Start()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x22D9574", Offset = "0x22D9574", VA = "0x22D9574")]
		private void Update()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x22D9654", Offset = "0x22D9654", VA = "0x22D9654")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6584", Offset = "0x9F6584")]
		public Transform target;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F65BC", Offset = "0x9F65BC")]
		public Transform pin;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F65F4", Offset = "0x9F65F4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F662C", Offset = "0x9F662C")]
		public AimIK aim;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6664", Offset = "0x9F6664")]
		public float weight;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F669C", Offset = "0x9F669C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F66D4", Offset = "0x9F66D4")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x22D965C", Offset = "0x22D965C", VA = "0x22D965C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x22D96B8", Offset = "0x22D96B8", VA = "0x22D96B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x22D985C", Offset = "0x22D985C", VA = "0x22D985C")]
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
		[Address(RVA = "0x22DB9E4", Offset = "0x22DB9E4", VA = "0x22DB9E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x22DBABC", Offset = "0x22DBABC", VA = "0x22DBABC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x22DBB4C", Offset = "0x22DBB4C", VA = "0x22DBB4C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x22DBF24", Offset = "0x22DBF24", VA = "0x22DBF24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x22DC054", Offset = "0x22DC054", VA = "0x22DC054")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F670C", Offset = "0x9F670C")]
		public float aimWeight;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6724", Offset = "0x9F6724")]
		public float sightWeight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F673C", Offset = "0x9F673C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6758", Offset = "0x9F6758")]
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
		[Address(RVA = "0x22DC220", Offset = "0x22DC220", VA = "0x22DC220")]
		private void Start()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x22DC3E4", Offset = "0x22DC3E4", VA = "0x22DC3E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x22DC3F0", Offset = "0x22DC3F0", VA = "0x22DC3F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x22DC670", Offset = "0x22DC670", VA = "0x22DC670")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x22DC940", Offset = "0x22DC940", VA = "0x22DC940")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x22DC4B8", Offset = "0x22DC4B8", VA = "0x22DC4B8")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x22DD234", Offset = "0x22DD234", VA = "0x22DD234")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6770", Offset = "0x9F6770")]
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
		[Address(RVA = "0x22DD254", Offset = "0x22DD254", VA = "0x22DD254")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x22DD2E0", Offset = "0x22DD2E0", VA = "0x22DD2E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x22DD3CC", Offset = "0x22DD3CC", VA = "0x22DD3CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x22DD484", Offset = "0x22DD484", VA = "0x22DD484")]
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
		[Address(RVA = "0x241302C", Offset = "0x241302C", VA = "0x241302C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2413190", Offset = "0x2413190", VA = "0x2413190")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2413374", Offset = "0x2413374", VA = "0x2413374")]
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
		[Address(RVA = "0x2413A1C", Offset = "0x2413A1C", VA = "0x2413A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2413B64", Offset = "0x2413B64", VA = "0x2413B64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2413EA0", Offset = "0x2413EA0", VA = "0x2413EA0")]
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
		[Address(RVA = "0x240D160", Offset = "0x240D160", VA = "0x240D160")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x240D29C", Offset = "0x240D29C", VA = "0x240D29C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x240D3A8", Offset = "0x240D3A8", VA = "0x240D3A8")]
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
		[Address(RVA = "0x240D3B0", Offset = "0x240D3B0", VA = "0x240D3B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x240DADC", Offset = "0x240DADC", VA = "0x240DADC")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6788", Offset = "0x9F6788")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F67C0", Offset = "0x9F67C0")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x209B4B0", Offset = "0x209B4B0", VA = "0x209B4B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x209B50C", Offset = "0x209B50C", VA = "0x209B50C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x209B844", Offset = "0x209B844", VA = "0x209B844")]
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
				[Address(RVA = "0x23B3A4C", Offset = "0x23B3A4C", VA = "0x23B3A4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x23B3300", Offset = "0x23B3300", VA = "0x23B3300")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x23B3320", Offset = "0x23B3320", VA = "0x23B3320")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x23B38B8", Offset = "0x23B38B8", VA = "0x23B38B8")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x23B3AA4", Offset = "0x23B3AA4", VA = "0x23B3AA4")]
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
		[Address(RVA = "0x209CF94", Offset = "0x209CF94", VA = "0x209CF94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x209CFD0", Offset = "0x209CFD0", VA = "0x209CFD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x209D038", Offset = "0x209D038", VA = "0x209D038")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F68D8", Offset = "0x9F68D8")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6910", Offset = "0x9F6910")]
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
			[Address(RVA = "0x23B3E04", Offset = "0x23B3E04", VA = "0x23B3E04")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x23B3EEC", Offset = "0x23B3EEC", VA = "0x23B3EEC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x23B3F28", Offset = "0x23B3F28", VA = "0x23B3F28")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x23B3FC0", Offset = "0x23B3FC0", VA = "0x23B3FC0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x23B4034", Offset = "0x23B4034", VA = "0x23B4034")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F67F8", Offset = "0x9F67F8")]
		public Mode mode;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6830", Offset = "0x9F6830")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6868", Offset = "0x9F6868")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F68A0", Offset = "0x9F68A0")]
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
		[Address(RVA = "0x20A01AC", Offset = "0x20A01AC", VA = "0x20A01AC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x20A02D4", Offset = "0x20A02D4", VA = "0x20A02D4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x20A0364", Offset = "0x20A0364", VA = "0x20A0364", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x20A0478", Offset = "0x20A0478", VA = "0x20A0478")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x20A0504", Offset = "0x20A0504", VA = "0x20A0504", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x20A076C", Offset = "0x20A076C", VA = "0x20A076C")]
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
		[Address(RVA = "0x20A0790", Offset = "0x20A0790", VA = "0x20A0790")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x20A080C", Offset = "0x20A080C", VA = "0x20A080C")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x20A08E8", Offset = "0x20A08E8", VA = "0x20A08E8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x20A09A8", Offset = "0x20A09A8", VA = "0x20A09A8")]
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
			[Address(RVA = "0x23B4070", Offset = "0x23B4070", VA = "0x23B4070")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x20A12A4", Offset = "0x20A12A4", VA = "0x20A12A4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x20A13B0", Offset = "0x20A13B0", VA = "0x20A13B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x20A153C", Offset = "0x20A153C", VA = "0x20A153C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6958", Offset = "0x9F6958")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6958", Offset = "0x9F6958")]
		public float weight;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F69AC", Offset = "0x9F69AC")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F69E4", Offset = "0x9F69E4")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6A30", Offset = "0x9F6A30")]
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
		[Address(RVA = "0x20A1C60", Offset = "0x20A1C60", VA = "0x20A1C60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x20A1F30", Offset = "0x20A1F30", VA = "0x20A1F30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x20A2578", Offset = "0x20A2578", VA = "0x20A2578")]
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
			[Address(RVA = "0x20A2B54", Offset = "0x20A2B54", VA = "0x20A2B54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private bool holdingLeft
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x20A2C38", Offset = "0x20A2C38", VA = "0x20A2C38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool holdingRight
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x20A2B8C", Offset = "0x20A2B8C", VA = "0x20A2B8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x20A2650", Offset = "0x20A2650", VA = "0x20A2650")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000744")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x20A2CE4", Offset = "0x20A2CE4", VA = "0x20A2CE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x20A2E9C", Offset = "0x20A2E9C", VA = "0x20A2E9C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x20A3020", Offset = "0x20A3020", VA = "0x20A3020")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x20A30FC", Offset = "0x20A30FC", VA = "0x20A30FC")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x20A323C", Offset = "0x20A323C", VA = "0x20A323C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x20A33AC", Offset = "0x20A33AC", VA = "0x20A33AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x20A35BC", Offset = "0x20A35BC", VA = "0x20A35BC")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x20A35D0", Offset = "0x20A35D0", VA = "0x20A35D0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x20A3834", Offset = "0x20A3834", VA = "0x20A3834")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x20A3848", Offset = "0x20A3848", VA = "0x20A3848", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x20A397C", Offset = "0x20A397C", VA = "0x20A397C")]
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
		[Address(RVA = "0x20A5CB4", Offset = "0x20A5CB4", VA = "0x20A5CB4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x20A5D94", Offset = "0x20A5D94", VA = "0x20A5D94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x20A5EA8", Offset = "0x20A5EA8", VA = "0x20A5EA8")]
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
		[Address(RVA = "0x20A6D18", Offset = "0x20A6D18", VA = "0x20A6D18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x20A6D74", Offset = "0x20A6D74", VA = "0x20A6D74")]
		private void Update()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x20A6DCC", Offset = "0x20A6DCC", VA = "0x20A6DCC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x20A6EAC", Offset = "0x20A6EAC", VA = "0x20A6EAC")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEFEC", Offset = "0x9EEFEC")]
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
				[Address(RVA = "0x23B5B80", Offset = "0x23B5B80", VA = "0x23B5B80", Slot = "4")]
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
				[Address(RVA = "0x23B5BC8", Offset = "0x23B5BC8", VA = "0x23B5BC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x23B598C", Offset = "0x23B598C", VA = "0x23B598C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x23B59B8", Offset = "0x23B59B8", VA = "0x23B59B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x23B59BC", Offset = "0x23B59BC", VA = "0x23B59BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x23B5B88", Offset = "0x23B5B88", VA = "0x23B5B88", Slot = "8")]
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
		[Address(RVA = "0x20A6EBC", Offset = "0x20A6EBC", VA = "0x20A6EBC")]
		private void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x20A6F84", Offset = "0x20A6F84", VA = "0x20A6F84")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x20A6FCC", Offset = "0x20A6FCC", VA = "0x20A6FCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9A54", Offset = "0x9F9A54")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x20A7054", Offset = "0x20A7054", VA = "0x20A7054")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EEFFC", Offset = "0x9EEFFC")]
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
				[Address(RVA = "0x23B6118", Offset = "0x23B6118", VA = "0x23B6118", Slot = "4")]
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
				[Address(RVA = "0x23B6160", Offset = "0x23B6160", VA = "0x23B6160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x23B5FA8", Offset = "0x23B5FA8", VA = "0x23B5FA8")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x23B5FD4", Offset = "0x23B5FD4", VA = "0x23B5FD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x23B5FD8", Offset = "0x23B5FD8", VA = "0x23B5FD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x23B6120", Offset = "0x23B6120", VA = "0x23B6120", Slot = "8")]
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
		[Address(RVA = "0x1F5C4C0", Offset = "0x1F5C4C0", VA = "0x1F5C4C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1F5C578", Offset = "0x1F5C578", VA = "0x1F5C578")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9B04", Offset = "0x9F9B04")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1F5C5F0", Offset = "0x1F5C5F0", VA = "0x1F5C5F0")]
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
			[Address(RVA = "0x23B6168", Offset = "0x23B6168", VA = "0x23B6168")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x23B6474", Offset = "0x23B6474", VA = "0x23B6474")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x23B6560", Offset = "0x23B6560", VA = "0x23B6560")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x23B69F4", Offset = "0x23B69F4", VA = "0x23B69F4")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x23B6AE8", Offset = "0x23B6AE8", VA = "0x23B6AE8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x23B6B80", Offset = "0x23B6B80", VA = "0x23B6B80")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x23B6C14", Offset = "0x23B6C14", VA = "0x23B6C14")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x23B6CA8", Offset = "0x23B6CA8", VA = "0x23B6CA8")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x23B6E98", Offset = "0x23B6E98", VA = "0x23B6E98")]
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
		[Address(RVA = "0x1F5CFF0", Offset = "0x1F5CFF0", VA = "0x1F5CFF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1F5D06C", Offset = "0x1F5D06C", VA = "0x1F5D06C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1F5D0DC", Offset = "0x1F5D0DC", VA = "0x1F5D0DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1F5D1A4", Offset = "0x1F5D1A4", VA = "0x1F5D1A4")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6A7C", Offset = "0x9F6A7C")]
		public Transform to;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6AB4", Offset = "0x9F6AB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6AB4", Offset = "0x9F6AB4")]
		public float transferMotion;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1F5D1AC", Offset = "0x1F5D1AC", VA = "0x1F5D1AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1F5D1E8", Offset = "0x1F5D1E8", VA = "0x1F5D1E8")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1F5D29C", Offset = "0x1F5D29C", VA = "0x1F5D29C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6B08", Offset = "0x9F6B08")]
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
		[Address(RVA = "0x1F5E598", Offset = "0x1F5E598", VA = "0x1F5E598")]
		private void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1F5E7B0", Offset = "0x1F5E7B0", VA = "0x1F5E7B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1F5E9A0", Offset = "0x1F5E9A0", VA = "0x1F5E9A0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1F5EA6C", Offset = "0x1F5EA6C", VA = "0x1F5EA6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1F5EB9C", Offset = "0x1F5EB9C", VA = "0x1F5EB9C")]
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
		[Address(RVA = "0x1F5EE40", Offset = "0x1F5EE40", VA = "0x1F5EE40", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1F5F1CC", Offset = "0x1F5F1CC", VA = "0x1F5F1CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1F5F438", Offset = "0x1F5F438", VA = "0x1F5F438")]
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
		[Address(RVA = "0x22E11EC", Offset = "0x22E11EC", VA = "0x22E11EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x22E1514", Offset = "0x22E1514", VA = "0x22E1514")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x22E1594", Offset = "0x22E1594", VA = "0x22E1594")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF00C", Offset = "0x9EF00C")]
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
				[Address(RVA = "0x23B4E38", Offset = "0x23B4E38", VA = "0x23B4E38", Slot = "4")]
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
				[Address(RVA = "0x23B4E80", Offset = "0x23B4E80", VA = "0x23B4E80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x23B4CEC", Offset = "0x23B4CEC", VA = "0x23B4CEC")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x23B4D18", Offset = "0x23B4D18", VA = "0x23B4D18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x23B4D1C", Offset = "0x23B4D1C", VA = "0x23B4D1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x23B4E40", Offset = "0x23B4E40", VA = "0x23B4E40", Slot = "8")]
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
		[Address(RVA = "0x20A3990", Offset = "0x20A3990", VA = "0x20A3990")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x20A3AD4", Offset = "0x20A3AD4", VA = "0x20A3AD4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x20A3A5C", Offset = "0x20A3A5C", VA = "0x20A3A5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9BB4", Offset = "0x9F9BB4")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x20A3C58", Offset = "0x20A3C58", VA = "0x20A3C58")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x20A3D44", Offset = "0x20A3D44", VA = "0x20A3D44")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x20A3E2C", Offset = "0x20A3E2C", VA = "0x20A3E2C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F6B40", Offset = "0x9F6B40")]
		public float weight;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2246800", Offset = "0x2246800", VA = "0x2246800")]
		private void Start()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2246874", Offset = "0x2246874", VA = "0x2246874")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x224692C", Offset = "0x224692C", VA = "0x224692C")]
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
			[Address(RVA = "0x27247B8", Offset = "0x27247B8", VA = "0x27247B8")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x27248F8", Offset = "0x27248F8", VA = "0x27248F8")]
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
		[Address(RVA = "0x1F5D690", Offset = "0x1F5D690", VA = "0x1F5D690")]
		private void Update()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1F5D70C", Offset = "0x1F5D70C", VA = "0x1F5D70C")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class VRIKAvatarScaleCalibrationOculus : MonoBehaviour
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scaleMlp;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1F6072C", Offset = "0x1F6072C", VA = "0x1F6072C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1F608A4", Offset = "0x1F608A4", VA = "0x1F608A4")]
		public VRIKAvatarScaleCalibrationOculus()
		{
		}
	}
	[Token(Token = "0x2000115")]
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
		[Address(RVA = "0x24136C4", Offset = "0x24136C4", VA = "0x24136C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2413828", Offset = "0x2413828", VA = "0x2413828")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2413A0C", Offset = "0x2413A0C", VA = "0x2413A0C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6B58", Offset = "0x9F6B58")]
		public VRIK ik;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F6B90", Offset = "0x9F6B90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6B90", Offset = "0x9F6B90")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6BF0", Offset = "0x9F6BF0")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6C28", Offset = "0x9F6C28")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F6C60", Offset = "0x9F6C60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6C60", Offset = "0x9F6C60")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6CC0", Offset = "0x9F6CC0")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6CF8", Offset = "0x9F6CF8")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6D30", Offset = "0x9F6D30")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F6D68", Offset = "0x9F6D68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6D68", Offset = "0x9F6D68")]
		public float scaleMlp;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F6DC8", Offset = "0x9F6DC8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1F608B4", Offset = "0x1F608B4", VA = "0x1F608B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1F617E4", Offset = "0x1F617E4", VA = "0x1F617E4")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6E00", Offset = "0x9F6E00")]
		public VRIK ik;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6E38", Offset = "0x9F6E38")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6E70", Offset = "0x9F6E70")]
		public Transform headTracker;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6EA8", Offset = "0x9F6EA8")]
		public Transform bodyTracker;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6EE0", Offset = "0x9F6EE0")]
		public Transform leftHandTracker;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6F18", Offset = "0x9F6F18")]
		public Transform rightHandTracker;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6F50", Offset = "0x9F6F50")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F6F88", Offset = "0x9F6F88")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F6FC0", Offset = "0x9F6FC0")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1F6185C", Offset = "0x1F6185C", VA = "0x1F6185C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x1F62C80", Offset = "0x1F62C80", VA = "0x1F62C80")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000118")]
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
		[Address(RVA = "0x1F64C38", Offset = "0x1F64C38", VA = "0x1F64C38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1F64C94", Offset = "0x1F64C94", VA = "0x1F64C94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1F64E1C", Offset = "0x1F64E1C", VA = "0x1F64E1C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000119")]
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
		[Address(RVA = "0x1F64E50", Offset = "0x1F64E50", VA = "0x1F64E50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1F652EC", Offset = "0x1F652EC", VA = "0x1F652EC")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200011A")]
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
			[Address(RVA = "0x2250988", Offset = "0x2250988", VA = "0x2250988", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2250964", Offset = "0x2250964", VA = "0x2250964", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2250990", Offset = "0x2250990", VA = "0x2250990")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x22509F4", Offset = "0x22509F4", VA = "0x22509F4", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2250B8C", Offset = "0x2250B8C", VA = "0x2250B8C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2250DB0", Offset = "0x2250DB0", VA = "0x2250DB0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2250B9C", Offset = "0x2250B9C", VA = "0x2250B9C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x2250DC0", Offset = "0x2250DC0", VA = "0x2250DC0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200011B")]
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
		[Address(RVA = "0x2250DD8", Offset = "0x2250DD8", VA = "0x2250DD8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2250E3C", Offset = "0x2250E3C", VA = "0x2250E3C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2250ED8", Offset = "0x2250ED8", VA = "0x2250ED8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x2250FF0", Offset = "0x2250FF0", VA = "0x2250FF0")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200011C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9F7028", Offset = "0x9F7028")]
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
			[Address(RVA = "0x22510B0", Offset = "0x22510B0", VA = "0x22510B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2251008", Offset = "0x2251008", VA = "0x2251008", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2251094", Offset = "0x2251094", VA = "0x2251094", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x22511A8", Offset = "0x22511A8", VA = "0x22511A8", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x225158C", Offset = "0x225158C", VA = "0x225158C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2251694", Offset = "0x2251694", VA = "0x2251694")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F706C", Offset = "0x9F706C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F706C", Offset = "0x9F706C")]
		public Transform gravityTarget;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F70CC", Offset = "0x9F70CC")]
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
		[Address(RVA = "0x2251A70", Offset = "0x2251A70", VA = "0x2251A70")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2251BA0", Offset = "0x2251BA0", VA = "0x2251BA0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2251D88", Offset = "0x2251D88", VA = "0x2251D88", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2251F38", Offset = "0x2251F38", VA = "0x2251F38")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2251F9C", Offset = "0x2251F9C", VA = "0x2251F9C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x22520BC", Offset = "0x22520BC", VA = "0x22520BC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x22521E0", Offset = "0x22521E0", VA = "0x22521E0")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2252204", Offset = "0x2252204", VA = "0x2252204")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2252228", Offset = "0x2252228", VA = "0x2252228")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2252288", Offset = "0x2252288", VA = "0x2252288")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011F")]
		public enum MoveMode
		{
			[Token(Token = "0x4000814")]
			Directional,
			[Token(Token = "0x4000815")]
			Strafe
		}

		[Token(Token = "0x2000120")]
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

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9EF01C", Offset = "0x9EF01C")]
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
				[Address(RVA = "0x1F66308", Offset = "0x1F66308", VA = "0x1F66308", Slot = "4")]
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
				[Address(RVA = "0x1F66350", Offset = "0x1F66350", VA = "0x1F66350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1F661D8", Offset = "0x1F661D8", VA = "0x1F661D8")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1F66204", Offset = "0x1F66204", VA = "0x1F66204", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1F66208", Offset = "0x1F66208", VA = "0x1F66208", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1F66310", Offset = "0x1F66310", VA = "0x1F66310", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F7104", Offset = "0x9F7104")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F713C", Offset = "0x9F713C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F7174", Offset = "0x9F7174")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F71AC", Offset = "0x9F71AC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F71E4", Offset = "0x9F71E4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9F721C", Offset = "0x9F721C")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F7254", Offset = "0x9F7254")]
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
			[Address(RVA = "0x22525B8", Offset = "0x22525B8", VA = "0x22525B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9C64", Offset = "0x9F9C64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x22525C0", Offset = "0x22525C0", VA = "0x22525C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9C74", Offset = "0x9F9C74")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x22525CC", Offset = "0x22525CC", VA = "0x22525CC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x2252734", Offset = "0x2252734", VA = "0x2252734")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x22527C4", Offset = "0x22527C4", VA = "0x22527C4", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x225288C", Offset = "0x225288C", VA = "0x225288C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x2253490", Offset = "0x2253490", VA = "0x2253490", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x22536E8", Offset = "0x22536E8", VA = "0x22536E8", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x2252D84", Offset = "0x2252D84", VA = "0x2252D84")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x22537C4", Offset = "0x22537C4", VA = "0x22537C4")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x2253C6C", Offset = "0x2253C6C", VA = "0x2253C6C")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x2253518", Offset = "0x2253518", VA = "0x2253518")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x2253D0C", Offset = "0x2253D0C", VA = "0x2253D0C", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x2254048", Offset = "0x2254048", VA = "0x2254048")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x2254138", Offset = "0x2254138", VA = "0x2254138", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x2254298", Offset = "0x2254298", VA = "0x2254298")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9F9C84", Offset = "0x9F9C84")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x22530E8", Offset = "0x22530E8", VA = "0x22530E8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x2254334", Offset = "0x2254334", VA = "0x2254334")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public enum RotationMode
		{
			[Token(Token = "0x4000831")]
			Smooth,
			[Token(Token = "0x4000832")]
			Linear
		}

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F7264", Offset = "0x9F7264")]
		public CameraController cameraController;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F729C", Offset = "0x9F729C")]
		public float accelerationTime;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F72D4", Offset = "0x9F72D4")]
		public float turnTime;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F730C", Offset = "0x9F730C")]
		public bool walkByDefault;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F7344", Offset = "0x9F7344")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F737C", Offset = "0x9F737C")]
		public float moveSpeed;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F73B4", Offset = "0x9F73B4")]
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
			[Address(RVA = "0x1F5BCCC", Offset = "0x1F5BCCC", VA = "0x1F5BCCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D34", Offset = "0x9F9D34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1F5BCD4", Offset = "0x1F5BCD4", VA = "0x1F5BCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D44", Offset = "0x9F9D44")]
			private set
			{
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1F5BCE0", Offset = "0x1F5BCE0", VA = "0x1F5BCE0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1F5BD84", Offset = "0x1F5BD84", VA = "0x1F5BD84")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1F5C244", Offset = "0x1F5C244", VA = "0x1F5C244")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1F5BDD8", Offset = "0x1F5BDD8", VA = "0x1F5BDD8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1F5C058", Offset = "0x1F5C058", VA = "0x1F5C058")]
		private void Move()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1F5C280", Offset = "0x1F5C280", VA = "0x1F5C280")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1F5C31C", Offset = "0x1F5C31C", VA = "0x1F5C31C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1F5C3A0", Offset = "0x1F5C3A0", VA = "0x1F5C3A0")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000124")]
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
		[Address(RVA = "0x1F5EBA4", Offset = "0x1F5EBA4", VA = "0x1F5EBA4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1F5EC28", Offset = "0x1F5EC28", VA = "0x1F5EC28", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1F5EDEC", Offset = "0x1F5EDEC", VA = "0x1F5EDEC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1F5EE14", Offset = "0x1F5EE14", VA = "0x1F5EE14")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000126")]
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
		[Address(RVA = "0x1F5EBE8", Offset = "0x1F5EBE8", VA = "0x1F5EBE8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x1F5EF30", Offset = "0x1F5EF30", VA = "0x1F5EF30", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1F5EE30", Offset = "0x1F5EE30", VA = "0x1F5EE30")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x22427E4", Offset = "0x22427E4", VA = "0x22427E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x2242820", Offset = "0x2242820", VA = "0x2242820")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000128")]
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
		[Address(RVA = "0x1F5C3C8", Offset = "0x1F5C3C8", VA = "0x1F5C3C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x1F5C3FC", Offset = "0x1F5C3FC", VA = "0x1F5C3FC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1F5C4AC", Offset = "0x1F5C4AC", VA = "0x1F5C4AC")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000129")]
	public class Navigator
	{
		[Token(Token = "0x200012A")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F73C4", Offset = "0x9F73C4")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F73FC", Offset = "0x9F73FC")]
		public float cornerRadius;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F7434", Offset = "0x9F7434")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F746C", Offset = "0x9F746C")]
		public float maxSampleDistance;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9F74A4", Offset = "0x9F74A4")]
		public float nextPathInterval;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F74DC", Offset = "0x9F74DC")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F74EC", Offset = "0x9F74EC")]
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
			[Address(RVA = "0x20A09BC", Offset = "0x20A09BC", VA = "0x20A09BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D54", Offset = "0x9F9D54")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x20A09C8", Offset = "0x20A09C8", VA = "0x20A09C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D64", Offset = "0x9F9D64")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public State state
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x20A09D4", Offset = "0x20A09D4", VA = "0x20A09D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D74", Offset = "0x9F9D74")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x20A09DC", Offset = "0x20A09DC", VA = "0x20A09DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9F9D84", Offset = "0x9F9D84")]
			private set
			{
			}
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x20A09E4", Offset = "0x20A09E4", VA = "0x20A09E4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x20A0AB8", Offset = "0x20A0AB8", VA = "0x20A0AB8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x20A0EB8", Offset = "0x20A0EB8", VA = "0x20A0EB8")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x20A0F34", Offset = "0x20A0F34", VA = "0x20A0F34")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x20A0E74", Offset = "0x20A0E74", VA = "0x20A0E74")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x20A0EA4", Offset = "0x20A0EA4", VA = "0x20A0EA4")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x20A1080", Offset = "0x20A1080", VA = "0x20A1080")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x20A1230", Offset = "0x20A1230", VA = "0x20A1230")]
		public Navigator()
		{
		}
	}
}
