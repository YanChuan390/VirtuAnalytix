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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D49B4", Offset = "0x8D49B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D49B4", Offset = "0x8D49B4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5460", Offset = "0x8D5460")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5460", Offset = "0x8D5460")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D54B8", Offset = "0x8D54B8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D54B8", Offset = "0x8D54B8")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5510", Offset = "0x8D5510")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5548", Offset = "0x8D5548")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5580", Offset = "0x8D5580")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D55B8", Offset = "0x8D55B8")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D55F0", Offset = "0x8D55F0")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5628", Offset = "0x8D5628")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5660", Offset = "0x8D5660")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5698", Offset = "0x8D5698")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D56A8", Offset = "0x8D56A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D56D8", Offset = "0x8D56D8")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1D1C6A4", Offset = "0x1D1C6A4", VA = "0x1D1C6A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD760", Offset = "0x8DD760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1D1C6AC", Offset = "0x1D1C6AC", VA = "0x1D1C6AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD770", Offset = "0x8DD770")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1D1C6B8", Offset = "0x1D1C6B8", VA = "0x1D1C6B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD780", Offset = "0x8DD780")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1D1C6C0", Offset = "0x1D1C6C0", VA = "0x1D1C6C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD790", Offset = "0x8DD790")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1D1C6C8", Offset = "0x1D1C6C8", VA = "0x1D1C6C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD7A0", Offset = "0x8DD7A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1D1C6D0", Offset = "0x1D1C6D0", VA = "0x1D1C6D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD7B0", Offset = "0x8DD7B0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1D1C584", Offset = "0x1D1C584", VA = "0x1D1C584")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD680", Offset = "0x8DD680")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1D1C5CC", Offset = "0x1D1C5CC", VA = "0x1D1C5CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD6B8", Offset = "0x8DD6B8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1D1C614", Offset = "0x1D1C614", VA = "0x1D1C614")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD6F0", Offset = "0x8DD6F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1D1C65C", Offset = "0x1D1C65C", VA = "0x1D1C65C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD728", Offset = "0x8DD728")]
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
		[Address(RVA = "0x1D1C6D8", Offset = "0x1D1C6D8", VA = "0x1D1C6D8")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1D1C6DC", Offset = "0x1D1C6DC", VA = "0x1D1C6DC")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1D1C6E0", Offset = "0x1D1C6E0", VA = "0x1D1C6E0")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1D1C6E4", Offset = "0x1D1C6E4", VA = "0x1D1C6E4")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D56E8", Offset = "0x8D56E8")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5720", Offset = "0x8D5720")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5758", Offset = "0x8D5758")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5790", Offset = "0x8D5790")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D57C8", Offset = "0x8D57C8")]
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
		[Address(RVA = "0x1DA6EB4", Offset = "0x1DA6EB4", VA = "0x1DA6EB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1DA72A4", Offset = "0x1DA72A4", VA = "0x1DA72A4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1DA72AC", Offset = "0x1DA72AC", VA = "0x1DA72AC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1DA73BC", Offset = "0x1DA73BC", VA = "0x1DA73BC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1DA7438", Offset = "0x1DA7438", VA = "0x1DA7438", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1DA74B4", Offset = "0x1DA74B4", VA = "0x1DA74B4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1DA70FC", Offset = "0x1DA70FC", VA = "0x1DA70FC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1DA71D0", Offset = "0x1DA71D0", VA = "0x1DA71D0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1DA7530", Offset = "0x1DA7530", VA = "0x1DA7530")]
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
		[Address(RVA = "0x1A92114", Offset = "0x1A92114", VA = "0x1A92114")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1D1B97C", Offset = "0x1D1B97C", VA = "0x1D1B97C")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1D1BBD8", Offset = "0x1D1BBD8", VA = "0x1D1BBD8")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1D1BBB8", Offset = "0x1D1BBB8", VA = "0x1D1BBB8")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1D1C184", Offset = "0x1D1C184", VA = "0x1D1C184")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1D1D960", Offset = "0x1D1D960", VA = "0x1D1D960")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1D1F218", Offset = "0x1D1F218", VA = "0x1D1F218")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1D1D3B4", Offset = "0x1D1D3B4", VA = "0x1D1D3B4")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1D1D9A8", Offset = "0x1D1D9A8", VA = "0x1D1D9A8")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1D1CEE4", Offset = "0x1D1CEE4", VA = "0x1D1CEE4")]
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
		[Address(RVA = "0x1D1C7D0", Offset = "0x1D1C7D0", VA = "0x1D1C7D0")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1D1CA3C", Offset = "0x1D1CA3C", VA = "0x1D1CA3C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1D1C934", Offset = "0x1D1C934", VA = "0x1D1C934")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1D1CBB8", Offset = "0x1D1CBB8", VA = "0x1D1CBB8")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1D1D148", Offset = "0x1D1D148", VA = "0x1D1D148")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1D1D244", Offset = "0x1D1D244", VA = "0x1D1D244")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1D1D340", Offset = "0x1D1D340", VA = "0x1D1D340")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1D1D2B8", Offset = "0x1D1D2B8", VA = "0x1D1D2B8")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1D1D5AC", Offset = "0x1D1D5AC", VA = "0x1D1D5AC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1D1D660", Offset = "0x1D1D660", VA = "0x1D1D660")]
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
		[Address(RVA = "0x1D1D9AC", Offset = "0x1D1D9AC", VA = "0x1D1D9AC")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1D1DA1C", Offset = "0x1D1DA1C", VA = "0x1D1DA1C")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1D1E4B0", Offset = "0x1D1E4B0", VA = "0x1D1E4B0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1D1E564", Offset = "0x1D1E564", VA = "0x1D1E564")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1D1E454", Offset = "0x1D1E454", VA = "0x1D1E454")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1D1E65C", Offset = "0x1D1E65C", VA = "0x1D1E65C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1D1E6A4", Offset = "0x1D1E6A4", VA = "0x1D1E6A4")]
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
		[Address(RVA = "0x1D1E6AC", Offset = "0x1D1E6AC", VA = "0x1D1E6AC")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1D1E838", Offset = "0x1D1E838", VA = "0x1D1E838")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1D1E84C", Offset = "0x1D1E84C", VA = "0x1D1E84C")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1D1EB38", Offset = "0x1D1EB38", VA = "0x1D1EB38")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1D1E744", Offset = "0x1D1E744", VA = "0x1D1E744")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1D1EDEC", Offset = "0x1D1EDEC", VA = "0x1D1EDEC")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1D1EE60", Offset = "0x1D1EE60", VA = "0x1D1EE60")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1D1F014", Offset = "0x1D1F014", VA = "0x1D1F014")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5800", Offset = "0x8D5800")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5838", Offset = "0x8D5838")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5838", Offset = "0x8D5838")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5890", Offset = "0x8D5890")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5890", Offset = "0x8D5890")]
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
		[Address(RVA = "0x1E13730", Offset = "0x1E13730", VA = "0x1E13730")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1E13C0C", Offset = "0x1E13C0C", VA = "0x1E13C0C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1E13C28", Offset = "0x1E13C28", VA = "0x1E13C28", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1E13D04", Offset = "0x1E13D04", VA = "0x1E13D04", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1E13DE0", Offset = "0x1E13DE0", VA = "0x1E13DE0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1E13FB0", Offset = "0x1E13FB0", VA = "0x1E13FB0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1E142E8", Offset = "0x1E142E8", VA = "0x1E142E8")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1E143C4", Offset = "0x1E143C4", VA = "0x1E143C4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D58E4", Offset = "0x8D58E4")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D591C", Offset = "0x8D591C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D5954", Offset = "0x8D5954")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D598C", Offset = "0x8D598C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D59C4", Offset = "0x8D59C4")]
		public float blockedOffset;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D59DC", Offset = "0x8D59DC")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D59EC", Offset = "0x8D59EC")]
		private float <y>k__BackingField;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D59FC", Offset = "0x8D59FC")]
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
			[Address(RVA = "0x1D27E10", Offset = "0x1D27E10", VA = "0x1D27E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD7C0", Offset = "0x8DD7C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1D27E18", Offset = "0x1D27E18", VA = "0x1D27E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD7D0", Offset = "0x8DD7D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1D27E20", Offset = "0x1D27E20", VA = "0x1D27E20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD7E0", Offset = "0x8DD7E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1D27E28", Offset = "0x1D27E28", VA = "0x1D27E28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD7F0", Offset = "0x8DD7F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1D27E30", Offset = "0x1D27E30", VA = "0x1D27E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD800", Offset = "0x8DD800")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1D27E38", Offset = "0x1D27E38", VA = "0x1D27E38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD810", Offset = "0x8DD810")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1D28714", Offset = "0x1D28714", VA = "0x1D28714")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1D27E40", Offset = "0x1D27E40", VA = "0x1D27E40")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1D27E7C", Offset = "0x1D27E7C", VA = "0x1D27E7C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1D27E84", Offset = "0x1D27E84", VA = "0x1D27E84", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1D27F88", Offset = "0x1D27F88", VA = "0x1D27F88", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1D27FE4", Offset = "0x1D27FE4", VA = "0x1D27FE4", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1D2804C", Offset = "0x1D2804C", VA = "0x1D2804C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1D280B0", Offset = "0x1D280B0", VA = "0x1D280B0")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1D27FBC", Offset = "0x1D27FBC", VA = "0x1D27FBC")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1D28230", Offset = "0x1D28230", VA = "0x1D28230")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1D286E4", Offset = "0x1D286E4", VA = "0x1D286E4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1D28784", Offset = "0x1D28784", VA = "0x1D28784")]
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
		[Address(RVA = "0x1D28830", Offset = "0x1D28830", VA = "0x1D28830")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1D28868", Offset = "0x1D28868", VA = "0x1D28868")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1D28A10", Offset = "0x1D28A10", VA = "0x1D28A10")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1D28A40", Offset = "0x1D28A40", VA = "0x1D28A40")]
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
		[Address(RVA = "0x1D1C18C", Offset = "0x1D1C18C", VA = "0x1D1C18C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1D1C1B0", Offset = "0x1D1C1B0", VA = "0x1D1C1B0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1D1C1E8", Offset = "0x1D1C1E8", VA = "0x1D1C1E8")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1D1C2D8", Offset = "0x1D1C2D8", VA = "0x1D1C2D8")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1D1C280", Offset = "0x1D1C280", VA = "0x1D1C280")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1D1C370", Offset = "0x1D1C370", VA = "0x1D1C370")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1D1C3B8", Offset = "0x1D1C3B8", VA = "0x1D1C3B8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1D1C57C", Offset = "0x1D1C57C", VA = "0x1D1C57C")]
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
			[Address(RVA = "0x1A9AEC8", Offset = "0x1A9AEC8", VA = "0x1A9AEC8")]
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
			[Address(RVA = "0x1D20CBC", Offset = "0x1D20CBC", VA = "0x1D20CBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1D20F28", Offset = "0x1D20F28", VA = "0x1D20F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1D20C70", Offset = "0x1D20C70", VA = "0x1D20C70")]
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
		[Address(RVA = "0x1D21194", Offset = "0x1D21194", VA = "0x1D21194")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1D214B0", Offset = "0x1D214B0", VA = "0x1D214B0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1D2171C", Offset = "0x1D2171C", VA = "0x1D2171C")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1D2179C", Offset = "0x1D2179C", VA = "0x1D2179C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1D21844", Offset = "0x1D21844", VA = "0x1D21844")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1D21364", Offset = "0x1D21364", VA = "0x1D21364")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1D21680", Offset = "0x1D21680", VA = "0x1D21680")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1D22074", Offset = "0x1D22074", VA = "0x1D22074")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1D21E7C", Offset = "0x1D21E7C", VA = "0x1D21E7C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1D21F78", Offset = "0x1D21F78", VA = "0x1D21F78")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1D21A5C", Offset = "0x1D21A5C", VA = "0x1D21A5C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1D21B0C", Offset = "0x1D21B0C", VA = "0x1D21B0C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1D21BBC", Offset = "0x1D21BBC", VA = "0x1D21BBC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1D21C6C", Offset = "0x1D21C6C", VA = "0x1D21C6C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1D21D1C", Offset = "0x1D21D1C", VA = "0x1D21D1C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1D21DCC", Offset = "0x1D21DCC", VA = "0x1D21DCC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1D2227C", Offset = "0x1D2227C", VA = "0x1D2227C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1D21974", Offset = "0x1D21974", VA = "0x1D21974")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1D221EC", Offset = "0x1D221EC", VA = "0x1D221EC")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1D222E8", Offset = "0x1D222E8", VA = "0x1D222E8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1D223BC", Offset = "0x1D223BC", VA = "0x1D223BC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1D22174", Offset = "0x1D22174", VA = "0x1D22174")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1D22100", Offset = "0x1D22100", VA = "0x1D22100")]
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
				[Address(RVA = "0x1A9AF54", Offset = "0x1A9AF54", VA = "0x1A9AF54")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1A9AF40", Offset = "0x1A9AF40", VA = "0x1A9AF40")]
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
			[Address(RVA = "0x1D24400", Offset = "0x1D24400", VA = "0x1D24400", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1D247E8", Offset = "0x1D247E8", VA = "0x1D247E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1D247F8", Offset = "0x1D247F8", VA = "0x1D247F8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1D24C20", Offset = "0x1D24C20", VA = "0x1D24C20", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1D25054", Offset = "0x1D25054", VA = "0x1D25054")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1D25640", Offset = "0x1D25640", VA = "0x1D25640")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1D25268", Offset = "0x1D25268", VA = "0x1D25268")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1D20044", Offset = "0x1D20044", VA = "0x1D20044")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1D25E40", Offset = "0x1D25E40", VA = "0x1D25E40")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1D263A0", Offset = "0x1D263A0", VA = "0x1D263A0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1D26194", Offset = "0x1D26194", VA = "0x1D26194")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1D26010", Offset = "0x1D26010", VA = "0x1D26010")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1D25EE0", Offset = "0x1D25EE0", VA = "0x1D25EE0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1D262A0", Offset = "0x1D262A0", VA = "0x1D262A0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1D26498", Offset = "0x1D26498", VA = "0x1D26498")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1D26FBC", Offset = "0x1D26FBC", VA = "0x1D26FBC")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1D26A44", Offset = "0x1D26A44", VA = "0x1D26A44")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1D27264", Offset = "0x1D27264", VA = "0x1D27264")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1D26DB0", Offset = "0x1D26DB0", VA = "0x1D26DB0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1D2726C", Offset = "0x1D2726C", VA = "0x1D2726C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1D27274", Offset = "0x1D27274", VA = "0x1D27274")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1D2743C", Offset = "0x1D2743C", VA = "0x1D2743C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1D275F8", Offset = "0x1D275F8", VA = "0x1D275F8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1D204A0", Offset = "0x1D204A0", VA = "0x1D204A0")]
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
		[Address(RVA = "0x1D9B6F8", Offset = "0x1D9B6F8", VA = "0x1D9B6F8")]
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
		[Address(RVA = "0x1D9BF84", Offset = "0x1D9BF84", VA = "0x1D9BF84")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1D9C0CC", Offset = "0x1D9C0CC", VA = "0x1D9C0CC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1E1161C", Offset = "0x1E1161C", VA = "0x1E1161C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1E11808", Offset = "0x1E11808", VA = "0x1E11808")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1E116B4", Offset = "0x1E116B4", VA = "0x1E116B4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1E11928", Offset = "0x1E11928", VA = "0x1E11928")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1E11A54", Offset = "0x1E11A54", VA = "0x1E11A54")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1E11CA0", Offset = "0x1E11CA0", VA = "0x1E11CA0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1E11DA8", Offset = "0x1E11DA8", VA = "0x1E11DA8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1E11F1C", Offset = "0x1E11F1C", VA = "0x1E11F1C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1E122F8", Offset = "0x1E122F8", VA = "0x1E122F8")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1E120BC", Offset = "0x1E120BC", VA = "0x1E120BC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1E124AC", Offset = "0x1E124AC", VA = "0x1E124AC")]
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
		[Address(RVA = "0x1E2E7DC", Offset = "0x1E2E7DC", VA = "0x1E2E7DC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1E2E848", Offset = "0x1E2E848", VA = "0x1E2E848")]
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
		[Address(RVA = "0x1B9BF4C", Offset = "0x1B9BF4C", VA = "0x1B9BF4C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1B9C8F8", Offset = "0x1B9C8F8", VA = "0x1B9C8F8")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1B9C96C", Offset = "0x1B9C96C", VA = "0x1B9C96C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1B9C360", Offset = "0x1B9C360", VA = "0x1B9C360")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1B9C36C", Offset = "0x1B9C36C", VA = "0x1B9C36C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1B9C390", Offset = "0x1B9C390", VA = "0x1B9C390")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1B9C3CC", Offset = "0x1B9C3CC", VA = "0x1B9C3CC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1B9C3E4", Offset = "0x1B9C3E4", VA = "0x1B9C3E4")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1B9C3F8", Offset = "0x1B9C3F8", VA = "0x1B9C3F8")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1B9C40C", Offset = "0x1B9C40C", VA = "0x1B9C40C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1B9C41C", Offset = "0x1B9C41C", VA = "0x1B9C41C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1B9C464", Offset = "0x1B9C464", VA = "0x1B9C464")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1B9C49C", Offset = "0x1B9C49C", VA = "0x1B9C49C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1B9C4C4", Offset = "0x1B9C4C4", VA = "0x1B9C4C4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1B9C9F8", Offset = "0x1B9C9F8", VA = "0x1B9C9F8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1B9C4F8", Offset = "0x1B9C4F8", VA = "0x1B9C4F8")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1B9C520", Offset = "0x1B9C520", VA = "0x1B9C520")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1B9C550", Offset = "0x1B9C550", VA = "0x1B9C550")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1B9C584", Offset = "0x1B9C584", VA = "0x1B9C584")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1B9C5C8", Offset = "0x1B9C5C8", VA = "0x1B9C5C8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1B9C62C", Offset = "0x1B9C62C", VA = "0x1B9C62C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1B9C690", Offset = "0x1B9C690", VA = "0x1B9C690")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1B9C6E4", Offset = "0x1B9C6E4", VA = "0x1B9C6E4")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1B9C738", Offset = "0x1B9C738", VA = "0x1B9C738")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1B9C774", Offset = "0x1B9C774", VA = "0x1B9C774")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1B9C7AC", Offset = "0x1B9C7AC", VA = "0x1B9C7AC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1B9CA2C", Offset = "0x1B9CA2C", VA = "0x1B9CA2C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1B9C7F4", Offset = "0x1B9C7F4", VA = "0x1B9C7F4")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1B9C888", Offset = "0x1B9C888", VA = "0x1B9C888")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1B9C8B8", Offset = "0x1B9C8B8", VA = "0x1B9C8B8")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1B9CAC0", Offset = "0x1B9CAC0", VA = "0x1B9CAC0")]
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
		[Address(RVA = "0x1B9CB7C", Offset = "0x1B9CB7C", VA = "0x1B9CB7C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1B9CBE8", Offset = "0x1B9CBE8", VA = "0x1B9CBE8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1B9CC54", Offset = "0x1B9CC54", VA = "0x1B9CC54")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1B9CCAC", Offset = "0x1B9CCAC", VA = "0x1B9CCAC")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1B9CD78", Offset = "0x1B9CD78", VA = "0x1B9CD78")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1B9CCC4", Offset = "0x1B9CCC4", VA = "0x1B9CCC4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1B9CD90", Offset = "0x1B9CD90", VA = "0x1B9CD90")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1B9CE34", Offset = "0x1B9CE34", VA = "0x1B9CE34")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1B9CE60", Offset = "0x1B9CE60", VA = "0x1B9CE60")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1B9CEB0", Offset = "0x1B9CEB0", VA = "0x1B9CEB0")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1B9CF1C", Offset = "0x1B9CF1C", VA = "0x1B9CF1C")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1B9D030", Offset = "0x1B9D030", VA = "0x1B9D030")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1B9D128", Offset = "0x1B9D128", VA = "0x1B9D128")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1B9D184", Offset = "0x1B9D184", VA = "0x1B9D184")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1BA37E8", Offset = "0x1BA37E8", VA = "0x1BA37E8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1BA3844", Offset = "0x1BA3844", VA = "0x1BA3844")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1BA38D4", Offset = "0x1BA38D4", VA = "0x1BA38D4")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1BA3A34", Offset = "0x1BA3A34", VA = "0x1BA3A34")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1BA3AF0", Offset = "0x1BA3AF0", VA = "0x1BA3AF0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1BA3BAC", Offset = "0x1BA3BAC", VA = "0x1BA3BAC")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1BA3D58", Offset = "0x1BA3D58", VA = "0x1BA3D58")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1BA3DA8", Offset = "0x1BA3DA8", VA = "0x1BA3DA8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1BA3DF8", Offset = "0x1BA3DF8", VA = "0x1BA3DF8")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1BA3EA0", Offset = "0x1BA3EA0", VA = "0x1BA3EA0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1B9BB88", Offset = "0x1B9BB88", VA = "0x1B9BB88")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1BA3F48", Offset = "0x1BA3F48", VA = "0x1BA3F48")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1B9BC68", Offset = "0x1B9BC68", VA = "0x1B9BC68")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1BA3018", Offset = "0x1BA3018", VA = "0x1BA3018")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1BA3F9C", Offset = "0x1BA3F9C", VA = "0x1BA3F9C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1BA412C", Offset = "0x1BA412C", VA = "0x1BA412C")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1BA4220", Offset = "0x1BA4220", VA = "0x1BA4220")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1BA432C", Offset = "0x1BA432C", VA = "0x1BA432C")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1BA4418", Offset = "0x1BA4418", VA = "0x1BA4418")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5A1C", Offset = "0x8D5A1C")]
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
			[Address(RVA = "0x1A91C40", Offset = "0x1A91C40", VA = "0x1A91C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1A91F4C", Offset = "0x1A91F4C", VA = "0x1A91F4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1A91B00", Offset = "0x1A91B00", VA = "0x1A91B00")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1A91BA0", Offset = "0x1A91BA0", VA = "0x1A91BA0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1A91BA4", Offset = "0x1A91BA4", VA = "0x1A91BA4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1A91BA8", Offset = "0x1A91BA8", VA = "0x1A91BA8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1A91BAC", Offset = "0x1A91BAC", VA = "0x1A91BAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1A91C3C", Offset = "0x1A91C3C", VA = "0x1A91C3C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1A91BE4", Offset = "0x1A91BE4", VA = "0x1A91BE4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1A91F00", Offset = "0x1A91F00", VA = "0x1A91F00")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1A91D2C", Offset = "0x1A91D2C", VA = "0x1A91D2C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1A92004", Offset = "0x1A92004", VA = "0x1A92004")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1A92060", Offset = "0x1A92060", VA = "0x1A92060")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1A920BC", Offset = "0x1A920BC", VA = "0x1A920BC")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1A92104", Offset = "0x1A92104", VA = "0x1A92104")]
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
		[Address(RVA = "0x1A92778", Offset = "0x1A92778", VA = "0x1A92778")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1A92838", Offset = "0x1A92838", VA = "0x1A92838")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1A928F8", Offset = "0x1A928F8", VA = "0x1A928F8")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1A929B8", Offset = "0x1A929B8", VA = "0x1A929B8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V2Tools
	{
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1A947EC", Offset = "0x1A947EC", VA = "0x1A947EC")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1A947F4", Offset = "0x1A947F4", VA = "0x1A947F4")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1A94844", Offset = "0x1A94844", VA = "0x1A94844")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1A94898", Offset = "0x1A94898", VA = "0x1A94898")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1A94970", Offset = "0x1A94970", VA = "0x1A94970")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1A94A04", Offset = "0x1A94A04", VA = "0x1A94A04")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1A94A28", Offset = "0x1A94A28", VA = "0x1A94A28")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1A94A70", Offset = "0x1A94A70", VA = "0x1A94A70")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1A94AFC", Offset = "0x1A94AFC", VA = "0x1A94AFC")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1A94B5C", Offset = "0x1A94B5C", VA = "0x1A94B5C")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1A94BBC", Offset = "0x1A94BBC", VA = "0x1A94BBC")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1A94CD8", Offset = "0x1A94CD8", VA = "0x1A94CD8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1A94D78", Offset = "0x1A94D78", VA = "0x1A94D78")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1A94DB4", Offset = "0x1A94DB4", VA = "0x1A94DB4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1A94DF8", Offset = "0x1A94DF8", VA = "0x1A94DF8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1A94E94", Offset = "0x1A94E94", VA = "0x1A94E94")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1A94FF0", Offset = "0x1A94FF0", VA = "0x1A94FF0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1A9516C", Offset = "0x1A9516C", VA = "0x1A9516C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1A952F0", Offset = "0x1A952F0", VA = "0x1A952F0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1A953AC", Offset = "0x1A953AC", VA = "0x1A953AC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1A954AC", Offset = "0x1A954AC", VA = "0x1A954AC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1A95534", Offset = "0x1A95534", VA = "0x1A95534")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1A955D0", Offset = "0x1A955D0", VA = "0x1A955D0")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1A95674", Offset = "0x1A95674", VA = "0x1A95674")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1A95664", Offset = "0x1A95664", VA = "0x1A95664")]
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
		[Address(RVA = "0x1A9A734", Offset = "0x1A9A734", VA = "0x1A9A734")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1A9A7CC", Offset = "0x1A9A7CC", VA = "0x1A9A7CC")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4A24", Offset = "0x8D4A24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4A24", Offset = "0x8D4A24")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1D1F724", Offset = "0x1D1F724", VA = "0x1D1F724")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD890", Offset = "0x8DD890")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1D1F76C", Offset = "0x1D1F76C", VA = "0x1D1F76C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD8C8", Offset = "0x8DD8C8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1D1F7B4", Offset = "0x1D1F7B4", VA = "0x1D1F7B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD900", Offset = "0x8DD900")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1D1F7FC", Offset = "0x1D1F7FC", VA = "0x1D1F7FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD938", Offset = "0x8DD938")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1D1F844", Offset = "0x1D1F844", VA = "0x1D1F844")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1D1F8E0", Offset = "0x1D1F8E0", VA = "0x1D1F8E0")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1D1F900", Offset = "0x1D1F900", VA = "0x1D1F900")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1D1F930", Offset = "0x1D1F930", VA = "0x1D1F930")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1D1F960", Offset = "0x1D1F960", VA = "0x1D1F960")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1D1F9A0", Offset = "0x1D1F9A0", VA = "0x1D1F9A0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1D1F9E4", Offset = "0x1D1F9E4", VA = "0x1D1F9E4")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1D1FA08", Offset = "0x1D1FA08", VA = "0x1D1FA08")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1D1FA2C", Offset = "0x1D1FA2C", VA = "0x1D1FA2C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1D1FA54", Offset = "0x1D1FA54", VA = "0x1D1FA54")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1D1FA80", Offset = "0x1D1FA80", VA = "0x1D1FA80")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1D1FAAC", Offset = "0x1D1FAAC", VA = "0x1D1FAAC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1D1F864", Offset = "0x1D1F864", VA = "0x1D1F864")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1D1FAD4", Offset = "0x1D1FAD4", VA = "0x1D1FAD4")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1D1FAE0", Offset = "0x1D1FAE0", VA = "0x1D1FAE0")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1D1FAEC", Offset = "0x1D1FAEC", VA = "0x1D1FAEC")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1D1FDD0", Offset = "0x1D1FDD0", VA = "0x1D1FDD0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1D1FE78", Offset = "0x1D1FE78", VA = "0x1D1FE78", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1D20258", Offset = "0x1D20258", VA = "0x1D20258", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1D203E4", Offset = "0x1D203E4", VA = "0x1D203E4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1D20418", Offset = "0x1D20418", VA = "0x1D20418")]
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
			[Address(RVA = "0x1D1FC8C", Offset = "0x1D1FC8C", VA = "0x1D1FC8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1D20680", Offset = "0x1D20680", VA = "0x1D20680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1D20134", Offset = "0x1D20134", VA = "0x1D20134")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1D2050C", Offset = "0x1D2050C", VA = "0x1D2050C")]
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
			[Address(RVA = "0x1D9B700", Offset = "0x1D9B700", VA = "0x1D9B700")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1D9B76C", Offset = "0x1D9B76C", VA = "0x1D9B76C")]
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
		[Address(RVA = "0x1D9B774", Offset = "0x1D9B774", VA = "0x1D9B774", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1D9B834", Offset = "0x1D9B834", VA = "0x1D9B834")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1D9B83C", Offset = "0x1D9B83C", VA = "0x1D9B83C")]
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
			[Address(RVA = "0x1D9B970", Offset = "0x1D9B970", VA = "0x1D9B970")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1D9B868", Offset = "0x1D9B868", VA = "0x1D9B868", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1D9B9AC", Offset = "0x1D9B9AC", VA = "0x1D9B9AC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1D9B9B4", Offset = "0x1D9B9B4", VA = "0x1D9B9B4")]
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
		[Address(RVA = "0x1D9B9E0", Offset = "0x1D9B9E0", VA = "0x1D9B9E0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1D9BA60", Offset = "0x1D9BA60", VA = "0x1D9BA60")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1D9BA68", Offset = "0x1D9BA68", VA = "0x1D9BA68")]
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
			[Address(RVA = "0x1D9BB9C", Offset = "0x1D9BB9C", VA = "0x1D9BB9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1D9BA94", Offset = "0x1D9BA94", VA = "0x1D9BA94", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1D9BBD8", Offset = "0x1D9BBD8", VA = "0x1D9BBD8")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1D9BBE0", Offset = "0x1D9BBE0", VA = "0x1D9BBE0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5A54", Offset = "0x8D5A54")]
		public float positionWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5A6C", Offset = "0x8D5A6C")]
		public float rotationWeight;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1D9BC0C", Offset = "0x1D9BC0C", VA = "0x1D9BC0C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1D9BC78", Offset = "0x1D9BC78", VA = "0x1D9BC78")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1D9BCCC", Offset = "0x1D9BCCC", VA = "0x1D9BCCC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1D9BF7C", Offset = "0x1D9BF7C", VA = "0x1D9BF7C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5A84", Offset = "0x8D5A84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5A84", Offset = "0x8D5A84")]
		public float weight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5AD8", Offset = "0x8D5AD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5AD8", Offset = "0x8D5AD8")]
		public float rotationWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5B2C", Offset = "0x8D5B2C")]
		public DOF rotationDOF;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5B64", Offset = "0x8D5B64")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5B9C", Offset = "0x8D5B9C")]
		public Transform bone1;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5BD4", Offset = "0x8D5BD4")]
		public Transform bone2;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5C0C", Offset = "0x8D5C0C")]
		public Transform bone3;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5C44", Offset = "0x8D5C44")]
		public Transform tip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5C7C", Offset = "0x8D5C7C")]
		public Transform target;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5CB4", Offset = "0x8D5CB4")]
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
			[Address(RVA = "0x1DA5050", Offset = "0x1DA5050", VA = "0x1DA5050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD970", Offset = "0x8DD970")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x1DA5058", Offset = "0x1DA5058", VA = "0x1DA5058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD980", Offset = "0x8DD980")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1DA5064", Offset = "0x1DA5064", VA = "0x1DA5064")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1DA5084", Offset = "0x1DA5084", VA = "0x1DA5084")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1DA50A4", Offset = "0x1DA50A4", VA = "0x1DA50A4")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1DA50C4", Offset = "0x1DA50C4", VA = "0x1DA50C4")]
			set
			{
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1DA50E4", Offset = "0x1DA50E4", VA = "0x1DA50E4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1DA51EC", Offset = "0x1DA51EC", VA = "0x1DA51EC")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1DA5764", Offset = "0x1DA5764", VA = "0x1DA5764")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1DA583C", Offset = "0x1DA583C", VA = "0x1DA583C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1DA5900", Offset = "0x1DA5900", VA = "0x1DA5900")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1DA5D84", Offset = "0x1DA5D84", VA = "0x1DA5D84")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5CC4", Offset = "0x8D5CC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5CC4", Offset = "0x8D5CC4")]
		public float weight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5D18", Offset = "0x8D5D18")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x1DA5D94", Offset = "0x1DA5D94", VA = "0x1DA5D94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD990", Offset = "0x8DD990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x1DA5D9C", Offset = "0x1DA5D9C", VA = "0x1DA5D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD9A0", Offset = "0x8DD9A0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1DA5DA8", Offset = "0x1DA5DA8", VA = "0x1DA5DA8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1DA5E30", Offset = "0x1DA5E30", VA = "0x1DA5E30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DD9B0", Offset = "0x8DD9B0")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1DA6168", Offset = "0x1DA6168", VA = "0x1DA6168")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1DA62E0", Offset = "0x1DA62E0", VA = "0x1DA62E0")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1DA606C", Offset = "0x1DA606C", VA = "0x1DA606C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1DA6450", Offset = "0x1DA6450", VA = "0x1DA6450", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1DA6510", Offset = "0x1DA6510", VA = "0x1DA6510")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1DA6588", Offset = "0x1DA6588", VA = "0x1DA6588")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1DA65FC", Offset = "0x1DA65FC", VA = "0x1DA65FC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1DA6664", Offset = "0x1DA6664", VA = "0x1DA6664", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1DA6668", Offset = "0x1DA6668", VA = "0x1DA6668", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1DA667C", Offset = "0x1DA667C", VA = "0x1DA667C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5D28", Offset = "0x8D5D28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D5D28", Offset = "0x8D5D28")]
		public float weight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5D7C", Offset = "0x8D5D7C")]
		public Grounding solver;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5DB4", Offset = "0x8D5DB4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1DA7A90", Offset = "0x1DA7A90", VA = "0x1DA7A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD9E8", Offset = "0x8DD9E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1DA7A98", Offset = "0x1DA7A98", VA = "0x1DA7A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD9F8", Offset = "0x8DD9F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x600016E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1DA7AA4", Offset = "0x1DA7AA4", VA = "0x1DA7AA4")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1DA7C50", Offset = "0x1DA7C50", VA = "0x1DA7C50")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1DA7B50", Offset = "0x1DA7B50", VA = "0x1DA7B50")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1DA7C84", Offset = "0x1DA7C84", VA = "0x1DA7C84")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000175")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000176")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1DA7DC0", Offset = "0x1DA7DC0", VA = "0x1DA7DC0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4A84", Offset = "0x8D4A84")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4A84", Offset = "0x8D4A84")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5DC4", Offset = "0x8D5DC4")]
		public BipedIK ik;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5DFC", Offset = "0x8D5DFC")]
		public float spineBend;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5E34", Offset = "0x8D5E34")]
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
		[Address(RVA = "0x1DA7E2C", Offset = "0x1DA7E2C", VA = "0x1DA7E2C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDA08", Offset = "0x8DDA08")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1DA7E74", Offset = "0x1DA7E74", VA = "0x1DA7E74", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDA40", Offset = "0x8DDA40")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1DA7EBC", Offset = "0x1DA7EBC", VA = "0x1DA7EBC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1DA7EFC", Offset = "0x1DA7EFC", VA = "0x1DA7EFC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1DA7FA8", Offset = "0x1DA7FA8", VA = "0x1DA7FA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1DA8008", Offset = "0x1DA8008", VA = "0x1DA8008")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1DA82CC", Offset = "0x1DA82CC", VA = "0x1DA82CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1DA8320", Offset = "0x1DA8320", VA = "0x1DA8320")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1DA873C", Offset = "0x1DA873C", VA = "0x1DA873C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1DA8810", Offset = "0x1DA8810", VA = "0x1DA8810")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1DA8950", Offset = "0x1DA8950", VA = "0x1DA8950")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1DA8AE0", Offset = "0x1DA8AE0", VA = "0x1DA8AE0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4AE4", Offset = "0x8D4AE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4AE4", Offset = "0x8D4AE4")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class SpineEffector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5F14", Offset = "0x8D5F14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5F4C", Offset = "0x8D5F4C")]
			public float horizontalWeight;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5F84", Offset = "0x8D5F84")]
			public float verticalWeight;

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x1A9BCA0", Offset = "0x1A9BCA0", VA = "0x1A9BCA0")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000197")]
			[Address(RVA = "0x1A9BCB0", Offset = "0x1A9BCB0", VA = "0x1A9BCB0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5E6C", Offset = "0x8D5E6C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5EA4", Offset = "0x8D5EA4")]
		public float spineBend;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5EDC", Offset = "0x8D5EDC")]
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
		[Address(RVA = "0x1DA8F18", Offset = "0x1DA8F18", VA = "0x1DA8F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDA78", Offset = "0x8DDA78")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1DA8F60", Offset = "0x1DA8F60", VA = "0x1DA8F60", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDAB0", Offset = "0x8DDAB0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1DA8FA8", Offset = "0x1DA8FA8", VA = "0x1DA8FA8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDAE8", Offset = "0x8DDAE8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1DA8FF0", Offset = "0x1DA8FF0", VA = "0x1DA8FF0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1DA9030", Offset = "0x1DA9030", VA = "0x1DA9030")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1DA90C4", Offset = "0x1DA90C4", VA = "0x1DA90C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1DA9344", Offset = "0x1DA9344", VA = "0x1DA9344")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1DA9350", Offset = "0x1DA9350", VA = "0x1DA9350")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1DA912C", Offset = "0x1DA912C", VA = "0x1DA912C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1DA935C", Offset = "0x1DA935C", VA = "0x1DA935C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1DA967C", Offset = "0x1DA967C", VA = "0x1DA967C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1DA978C", Offset = "0x1DA978C", VA = "0x1DA978C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1DA98E4", Offset = "0x1DA98E4", VA = "0x1DA98E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1DA99F8", Offset = "0x1DA99F8", VA = "0x1DA99F8")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4B44", Offset = "0x8D4B44")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4B44", Offset = "0x8D4B44")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5FBC", Offset = "0x8D5FBC")]
		public Transform pelvis;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D5FF4", Offset = "0x8D5FF4")]
		public Transform characterRoot;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D602C", Offset = "0x8D602C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D602C", Offset = "0x8D602C")]
		public float rootRotationWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6080", Offset = "0x8D6080")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D60B8", Offset = "0x8D60B8")]
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
		[Address(RVA = "0x1DA9A80", Offset = "0x1DA9A80", VA = "0x1DA9A80", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDB20", Offset = "0x8DDB20")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1DA9AC8", Offset = "0x1DA9AC8", VA = "0x1DA9AC8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDB58", Offset = "0x8DDB58")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1DA9B10", Offset = "0x1DA9B10", VA = "0x1DA9B10", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1DA9B2C", Offset = "0x1DA9B2C", VA = "0x1DA9B2C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1DA9D60", Offset = "0x1DA9D60", VA = "0x1DA9D60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1DA9E5C", Offset = "0x1DA9E5C", VA = "0x1DA9E5C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1DAA2B0", Offset = "0x1DAA2B0", VA = "0x1DAA2B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1DAA6BC", Offset = "0x1DAA6BC", VA = "0x1DAA6BC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1DAA84C", Offset = "0x1DAA84C", VA = "0x1DAA84C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1DAAB50", Offset = "0x1DAAB50", VA = "0x1DAAB50")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1DAAC9C", Offset = "0x1DAAC9C", VA = "0x1DAAC9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1DAAE84", Offset = "0x1DAAE84", VA = "0x1DAAE84")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4BA4", Offset = "0x8D4BA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4BA4", Offset = "0x8D4BA4")]
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
			[Address(RVA = "0x1A9BCF8", Offset = "0x1A9BCF8", VA = "0x1A9BCF8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D60F0", Offset = "0x8D60F0")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6128", Offset = "0x8D6128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6128", Offset = "0x8D6128")]
		public float rootRotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D617C", Offset = "0x8D617C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D617C", Offset = "0x8D617C")]
		public float minRootRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D61D4", Offset = "0x8D61D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D61D4", Offset = "0x8D61D4")]
		public float maxRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D622C", Offset = "0x8D622C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6264", Offset = "0x8D6264")]
		public float maxLegOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D629C", Offset = "0x8D629C")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D62D4", Offset = "0x8D62D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D62D4", Offset = "0x8D62D4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6328", Offset = "0x8D6328")]
		public Transform characterRoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6360", Offset = "0x8D6360")]
		public Transform pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6398", Offset = "0x8D6398")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D63D0", Offset = "0x8D63D0")]
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
		[Address(RVA = "0x1DAAF0C", Offset = "0x1DAAF0C", VA = "0x1DAAF0C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDB90", Offset = "0x8DDB90")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1DAAF54", Offset = "0x1DAAF54", VA = "0x1DAAF54", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDBC8", Offset = "0x8DDBC8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1DAAF9C", Offset = "0x1DAAF9C", VA = "0x1DAAF9C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1DAAFD8", Offset = "0x1DAAFD8", VA = "0x1DAAFD8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1DAB104", Offset = "0x1DAB104", VA = "0x1DAB104")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1DAB308", Offset = "0x1DAB308", VA = "0x1DAB308")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1DAB370", Offset = "0x1DAB370", VA = "0x1DAB370")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1DAB3D4", Offset = "0x1DAB3D4", VA = "0x1DAB3D4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1DAB708", Offset = "0x1DAB708", VA = "0x1DAB708")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1DABA4C", Offset = "0x1DABA4C", VA = "0x1DABA4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1DABB44", Offset = "0x1DABB44", VA = "0x1DABB44")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1DABF10", Offset = "0x1DABF10", VA = "0x1DABF10")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1DAC534", Offset = "0x1DAC534", VA = "0x1DAC534")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1DAC704", Offset = "0x1DAC704", VA = "0x1DAC704")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1DAC7E0", Offset = "0x1DAC7E0", VA = "0x1DAC7E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1DACA28", Offset = "0x1DACA28", VA = "0x1DACA28")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1DACA60", Offset = "0x1DACA60", VA = "0x1DACA60")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1DACC40", Offset = "0x1DACC40", VA = "0x1DACC40")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4C04", Offset = "0x8D4C04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4C04", Offset = "0x8D4C04")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6418", Offset = "0x8D6418")]
		public VRIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1E0F5C0", Offset = "0x1E0F5C0", VA = "0x1E0F5C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDC00", Offset = "0x8DDC00")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1E0F608", Offset = "0x1E0F608", VA = "0x1E0F608", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDC38", Offset = "0x8DDC38")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1E0F650", Offset = "0x1E0F650", VA = "0x1E0F650", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDC70", Offset = "0x8DDC70")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1E0F698", Offset = "0x1E0F698", VA = "0x1E0F698", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1E0F73C", Offset = "0x1E0F73C", VA = "0x1E0F73C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1E0F7D0", Offset = "0x1E0F7D0", VA = "0x1E0F7D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1E0F830", Offset = "0x1E0F830", VA = "0x1E0F830")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1E0FCD8", Offset = "0x1E0FCD8", VA = "0x1E0FCD8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1E10138", Offset = "0x1E10138", VA = "0x1E10138")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1E101C8", Offset = "0x1E101C8", VA = "0x1E101C8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1E10384", Offset = "0x1E10384", VA = "0x1E10384")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1E104DC", Offset = "0x1E104DC", VA = "0x1E104DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1E1065C", Offset = "0x1E1065C", VA = "0x1E1065C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D68FC", Offset = "0x8D68FC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D690C", Offset = "0x8D690C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D691C", Offset = "0x8D691C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D692C", Offset = "0x8D692C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D693C", Offset = "0x8D693C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D694C", Offset = "0x8D694C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D695C", Offset = "0x8D695C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D696C", Offset = "0x8D696C")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D697C", Offset = "0x8D697C")]
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
				[Address(RVA = "0x1A9BD38", Offset = "0x1A9BD38", VA = "0x1A9BD38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD48", Offset = "0x8DDD48")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x1A9BD40", Offset = "0x1A9BD40", VA = "0x1A9BD40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD58", Offset = "0x8DDD58")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x1A9BD4C", Offset = "0x1A9BD4C", VA = "0x1A9BD4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD68", Offset = "0x8DDD68")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x1A9BD58", Offset = "0x1A9BD58", VA = "0x1A9BD58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD78", Offset = "0x8DDD78")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x1A9BD64", Offset = "0x1A9BD64", VA = "0x1A9BD64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD88", Offset = "0x8DDD88")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x1A9BD6C", Offset = "0x1A9BD6C", VA = "0x1A9BD6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD98", Offset = "0x8DDD98")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x1A9BD78", Offset = "0x1A9BD78", VA = "0x1A9BD78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDDA8", Offset = "0x8DDDA8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x1A9BD80", Offset = "0x1A9BD80", VA = "0x1A9BD80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDDB8", Offset = "0x8DDDB8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x1A9BD88", Offset = "0x1A9BD88", VA = "0x1A9BD88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDDC8", Offset = "0x8DDDC8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x1A9BD94", Offset = "0x1A9BD94", VA = "0x1A9BD94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDDD8", Offset = "0x8DDDD8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x1A9BDA0", Offset = "0x1A9BDA0", VA = "0x1A9BDA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDDE8", Offset = "0x8DDDE8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x1A9BDA8", Offset = "0x1A9BDA8", VA = "0x1A9BDA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDDF8", Offset = "0x8DDDF8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x1A9BDB0", Offset = "0x1A9BDB0", VA = "0x1A9BDB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE08", Offset = "0x8DDE08")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x1A9BDB8", Offset = "0x1A9BDB8", VA = "0x1A9BDB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE18", Offset = "0x8DDE18")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x1A9BDC0", Offset = "0x1A9BDC0", VA = "0x1A9BDC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE28", Offset = "0x8DDE28")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x1A9BDD8", Offset = "0x1A9BDD8", VA = "0x1A9BDD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE38", Offset = "0x8DDE38")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x1A9BDF8", Offset = "0x1A9BDF8", VA = "0x1A9BDF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE48", Offset = "0x8DDE48")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x1A9BE10", Offset = "0x1A9BE10", VA = "0x1A9BE10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE58", Offset = "0x8DDE58")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x1A9BE30", Offset = "0x1A9BE30", VA = "0x1A9BE30")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001F4")]
				[Address(RVA = "0x1A9CFF4", Offset = "0x1A9CFF4", VA = "0x1A9CFF4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001FD")]
				[Address(RVA = "0x1A9D158", Offset = "0x1A9D158", VA = "0x1A9D158")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x1A9BE78", Offset = "0x1A9BE78", VA = "0x1A9BE78")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x1A9BE8C", Offset = "0x1A9BE8C", VA = "0x1A9BE8C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x1A9BF00", Offset = "0x1A9BF00", VA = "0x1A9BF00")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x1A9BF4C", Offset = "0x1A9BF4C", VA = "0x1A9BF4C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x1A9BFBC", Offset = "0x1A9BFBC", VA = "0x1A9BFBC")]
			public void Process()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1A9CC68", Offset = "0x1A9CC68", VA = "0x1A9CC68")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x1A9C808", Offset = "0x1A9C808", VA = "0x1A9C808")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x1A9D088", Offset = "0x1A9D088", VA = "0x1A9D088")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x1A9CAA8", Offset = "0x1A9CAA8", VA = "0x1A9CAA8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1A9CB34", Offset = "0x1A9CB34", VA = "0x1A9CB34")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1A9D0F8", Offset = "0x1A9D0F8", VA = "0x1A9D0F8")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1A9D01C", Offset = "0x1A9D01C", VA = "0x1A9D01C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1A9D1EC", Offset = "0x1A9D1EC", VA = "0x1A9D1EC")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1A9D278", Offset = "0x1A9D278", VA = "0x1A9D278")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003F")]
		public class Pelvis
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D698C", Offset = "0x8D698C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D699C", Offset = "0x8D699C")]
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
				[Address(RVA = "0x1A9D2BC", Offset = "0x1A9D2BC", VA = "0x1A9D2BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE68", Offset = "0x8DDE68")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x1A9D2C8", Offset = "0x1A9D2C8", VA = "0x1A9D2C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE78", Offset = "0x8DDE78")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x1A9D2D4", Offset = "0x1A9D2D4", VA = "0x1A9D2D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE88", Offset = "0x8DDE88")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000202")]
				[Address(RVA = "0x1A9D2DC", Offset = "0x1A9D2DC", VA = "0x1A9D2DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDE98", Offset = "0x8DDE98")]
				private set
				{
				}
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1A9D2E4", Offset = "0x1A9D2E4", VA = "0x1A9D2E4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x1A9D354", Offset = "0x1A9D354", VA = "0x1A9D354")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x1A9D2F4", Offset = "0x1A9D2F4", VA = "0x1A9D2F4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x1A9D3C0", Offset = "0x1A9D3C0", VA = "0x1A9D3C0")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1A9D560", Offset = "0x1A9D560", VA = "0x1A9D560")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6450", Offset = "0x8D6450")]
		public LayerMask layers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6488", Offset = "0x8D6488")]
		public float maxStep;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D64C0", Offset = "0x8D64C0")]
		public float heightOffset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D64F8", Offset = "0x8D64F8")]
		public float footSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6530", Offset = "0x8D6530")]
		public float footRadius;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6568", Offset = "0x8D6568")]
		public float footCenterOffset;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D65B4", Offset = "0x8D65B4")]
		public float prediction;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D65EC", Offset = "0x8D65EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D65EC", Offset = "0x8D65EC")]
		public float footRotationWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6640", Offset = "0x8D6640")]
		public float footRotationSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6678", Offset = "0x8D6678")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6678", Offset = "0x8D6678")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D66D0", Offset = "0x8D66D0")]
		public bool rotateSolver;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6708", Offset = "0x8D6708")]
		public float pelvisSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6740", Offset = "0x8D6740")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6740", Offset = "0x8D6740")]
		public float pelvisDamper;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6794", Offset = "0x8D6794")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D67CC", Offset = "0x8D67CC")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6804", Offset = "0x8D6804")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D683C", Offset = "0x8D683C")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6874", Offset = "0x8D6874")]
		public Quality quality;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D68AC", Offset = "0x8D68AC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D68BC", Offset = "0x8D68BC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D68CC", Offset = "0x8D68CC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D68DC", Offset = "0x8D68DC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D68EC", Offset = "0x8D68EC")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1E106B8", Offset = "0x1E106B8", VA = "0x1E106B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDCA8", Offset = "0x8DDCA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1E106C0", Offset = "0x1E106C0", VA = "0x1E106C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDCB8", Offset = "0x8DDCB8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x1E106C8", Offset = "0x1E106C8", VA = "0x1E106C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDCC8", Offset = "0x8DDCC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x1E106D0", Offset = "0x1E106D0", VA = "0x1E106D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDCD8", Offset = "0x8DDCD8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x1E106D8", Offset = "0x1E106D8", VA = "0x1E106D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDCE8", Offset = "0x8DDCE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x1E106E0", Offset = "0x1E106E0", VA = "0x1E106E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDCF8", Offset = "0x8DDCF8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1E106EC", Offset = "0x1E106EC", VA = "0x1E106EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD08", Offset = "0x8DDD08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x1E106F4", Offset = "0x1E106F4", VA = "0x1E106F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD18", Offset = "0x8DDD18")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1E106FC", Offset = "0x1E106FC", VA = "0x1E106FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD28", Offset = "0x8DDD28")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1E10714", Offset = "0x1E10714", VA = "0x1E10714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DDD38", Offset = "0x8DDD38")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1E10734", Offset = "0x1E10734", VA = "0x1E10734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1E109D4", Offset = "0x1E109D4", VA = "0x1E109D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1E10C98", Offset = "0x1E10C98", VA = "0x1E10C98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1E10788", Offset = "0x1E10788", VA = "0x1E10788")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1E10A18", Offset = "0x1E10A18", VA = "0x1E10A18")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1E0FA50", Offset = "0x1E0FA50", VA = "0x1E0FA50")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1E0FEC8", Offset = "0x1E0FEC8", VA = "0x1E0FEC8")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1E10B38", Offset = "0x1E10B38", VA = "0x1E10B38")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1E0F6B0", Offset = "0x1E0F6B0", VA = "0x1E0F6B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1E10B20", Offset = "0x1E10B20", VA = "0x1E10B20")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1E10D18", Offset = "0x1E10D18", VA = "0x1E10D18")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1E10DA8", Offset = "0x1E10DA8", VA = "0x1E10DA8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1E10E64", Offset = "0x1E10E64", VA = "0x1E10E64")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1E10EE0", Offset = "0x1E10EE0", VA = "0x1E10EE0")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4C64", Offset = "0x8D4C64")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4C64", Offset = "0x8D4C64")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1D19D90", Offset = "0x1D19D90", VA = "0x1D19D90", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDEA8", Offset = "0x8DDEA8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1D19DD8", Offset = "0x1D19DD8", VA = "0x1D19DD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDEE0", Offset = "0x8DDEE0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1D19E20", Offset = "0x1D19E20", VA = "0x1D19E20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDF18", Offset = "0x8DDF18")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1D19E68", Offset = "0x1D19E68", VA = "0x1D19E68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDF50", Offset = "0x8DDF50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1D19EB0", Offset = "0x1D19EB0", VA = "0x1D19EB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDF88", Offset = "0x8DDF88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1D19EF8", Offset = "0x1D19EF8", VA = "0x1D19EF8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1D19F00", Offset = "0x1D19F00", VA = "0x1D19F00")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4CC4", Offset = "0x8D4CC4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4CC4", Offset = "0x8D4CC4")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1D1B7F0", Offset = "0x1D1B7F0", VA = "0x1D1B7F0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDFC0", Offset = "0x8DDFC0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1D1B838", Offset = "0x1D1B838", VA = "0x1D1B838", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DDFF8", Offset = "0x8DDFF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1D1B880", Offset = "0x1D1B880", VA = "0x1D1B880")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE030", Offset = "0x8DE030")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1D1B8C8", Offset = "0x1D1B8C8", VA = "0x1D1B8C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE068", Offset = "0x8DE068")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1D1B910", Offset = "0x1D1B910", VA = "0x1D1B910", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1D1B918", Offset = "0x1D1B918", VA = "0x1D1B918")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4D24", Offset = "0x8D4D24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4D24", Offset = "0x8D4D24")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1D27C84", Offset = "0x1D27C84", VA = "0x1D27C84", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE0A0", Offset = "0x8DE0A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1D27CCC", Offset = "0x1D27CCC", VA = "0x1D27CCC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE0D8", Offset = "0x8DE0D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1D27D14", Offset = "0x1D27D14", VA = "0x1D27D14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE110", Offset = "0x8DE110")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1D27D5C", Offset = "0x1D27D5C", VA = "0x1D27D5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE148", Offset = "0x8DE148")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1D27DA4", Offset = "0x1D27DA4", VA = "0x1D27DA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1D27DAC", Offset = "0x1D27DAC", VA = "0x1D27DAC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4D84", Offset = "0x8D4D84")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4D84", Offset = "0x8D4D84")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1D9D778", Offset = "0x1D9D778", VA = "0x1D9D778", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE180", Offset = "0x8DE180")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1D9D7C0", Offset = "0x1D9D7C0", VA = "0x1D9D7C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE1B8", Offset = "0x8DE1B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1D9D808", Offset = "0x1D9D808", VA = "0x1D9D808")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE1F0", Offset = "0x8DE1F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1D9D850", Offset = "0x1D9D850", VA = "0x1D9D850")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE228", Offset = "0x8DE228")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1D9D898", Offset = "0x1D9D898", VA = "0x1D9D898", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1D9D8A0", Offset = "0x1D9D8A0", VA = "0x1D9D8A0")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4DE4", Offset = "0x8D4DE4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4DE4", Offset = "0x8D4DE4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1D9DDC4", Offset = "0x1D9DDC4", VA = "0x1D9DDC4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE260", Offset = "0x8DE260")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1D9DE0C", Offset = "0x1D9DE0C", VA = "0x1D9DE0C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE298", Offset = "0x8DE298")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1D9DE54", Offset = "0x1D9DE54", VA = "0x1D9DE54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE2D0", Offset = "0x8DE2D0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1D9DE9C", Offset = "0x1D9DE9C", VA = "0x1D9DE9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE308", Offset = "0x8DE308")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1D9DEE4", Offset = "0x1D9DEE4", VA = "0x1D9DEE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1D9DEEC", Offset = "0x1D9DEEC", VA = "0x1D9DEEC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4E44", Offset = "0x8D4E44")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4E44", Offset = "0x8D4E44")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1DA66E0", Offset = "0x1DA66E0", VA = "0x1DA66E0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE340", Offset = "0x8DE340")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1DA6728", Offset = "0x1DA6728", VA = "0x1DA6728", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE378", Offset = "0x8DE378")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1DA6770", Offset = "0x1DA6770", VA = "0x1DA6770")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE3B0", Offset = "0x8DE3B0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1DA67B8", Offset = "0x1DA67B8", VA = "0x1DA67B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE3E8", Offset = "0x8DE3E8")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1DA6800", Offset = "0x1DA6800", VA = "0x1DA6800")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE420", Offset = "0x8DE420")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1DA6848", Offset = "0x1DA6848", VA = "0x1DA6848")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE458", Offset = "0x8DE458")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1DA6890", Offset = "0x1DA6890", VA = "0x1DA6890")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1DA68B4", Offset = "0x1DA68B4", VA = "0x1DA68B4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1DA68BC", Offset = "0x1DA68BC", VA = "0x1DA68BC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1DA6A98", Offset = "0x1DA6A98", VA = "0x1DA6A98")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1DA6D2C", Offset = "0x1DA6D2C", VA = "0x1DA6D2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE490", Offset = "0x8DE490")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1DA6D4C", Offset = "0x1DA6D4C", VA = "0x1DA6D4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE4C8", Offset = "0x8DE4C8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1DA6E24", Offset = "0x1DA6E24", VA = "0x1DA6E24")]
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
		[Address(RVA = "0x1E14454", Offset = "0x1E14454", VA = "0x1E14454", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1E14548", Offset = "0x1E14548", VA = "0x1E14548", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1E14734", Offset = "0x1E14734", VA = "0x1E14734", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000238")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000239")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1E14794", Offset = "0x1E14794", VA = "0x1E14794")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D69AC", Offset = "0x8D69AC")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D69E4", Offset = "0x8D69E4")]
		public Animator animator;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1E16D04", Offset = "0x1E16D04", VA = "0x1E16D04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1E16D9C", Offset = "0x1E16D9C", VA = "0x1E16D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1E16E0C", Offset = "0x1E16E0C", VA = "0x1E16E0C")]
		private void Update()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1E16EC8", Offset = "0x1E16EC8", VA = "0x1E16EC8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1E16F04", Offset = "0x1E16F04", VA = "0x1E16F04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1E16E40", Offset = "0x1E16E40", VA = "0x1E16E40")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1E16F90", Offset = "0x1E16F90", VA = "0x1E16F90")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4EA4", Offset = "0x8D4EA4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4EA4", Offset = "0x8D4EA4")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1B9D1B4", Offset = "0x1B9D1B4", VA = "0x1B9D1B4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE500", Offset = "0x8DE500")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1B9D1FC", Offset = "0x1B9D1FC", VA = "0x1B9D1FC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE538", Offset = "0x8DE538")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1B9D244", Offset = "0x1B9D244", VA = "0x1B9D244")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE570", Offset = "0x8DE570")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1B9D28C", Offset = "0x1B9D28C", VA = "0x1B9D28C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE5A8", Offset = "0x8DE5A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1B9D2D4", Offset = "0x1B9D2D4", VA = "0x1B9D2D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1B9D2DC", Offset = "0x1B9D2DC", VA = "0x1B9D2DC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4F04", Offset = "0x8D4F04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4F04", Offset = "0x8D4F04")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1B9D340", Offset = "0x1B9D340", VA = "0x1B9D340", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE5E0", Offset = "0x8DE5E0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1B9D388", Offset = "0x1B9D388", VA = "0x1B9D388", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE618", Offset = "0x8DE618")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1B9D3D0", Offset = "0x1B9D3D0", VA = "0x1B9D3D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE650", Offset = "0x8DE650")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1B9D418", Offset = "0x1B9D418", VA = "0x1B9D418")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE688", Offset = "0x8DE688")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1B9D460", Offset = "0x1B9D460", VA = "0x1B9D460", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1B9D468", Offset = "0x1B9D468", VA = "0x1B9D468")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4F64", Offset = "0x8D4F64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4F64", Offset = "0x8D4F64")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1B9DE54", Offset = "0x1B9DE54", VA = "0x1B9DE54", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE6C0", Offset = "0x8DE6C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1B9DE9C", Offset = "0x1B9DE9C", VA = "0x1B9DE9C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE6F8", Offset = "0x8DE6F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1B9DEE4", Offset = "0x1B9DEE4", VA = "0x1B9DEE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE730", Offset = "0x8DE730")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1B9DF2C", Offset = "0x1B9DF2C", VA = "0x1B9DF2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE768", Offset = "0x8DE768")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1B9DF74", Offset = "0x1B9DF74", VA = "0x1B9DF74", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1B9DF7C", Offset = "0x1B9DF7C", VA = "0x1B9DF7C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D4FC4", Offset = "0x8D4FC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D4FC4", Offset = "0x8D4FC4")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1A929C0", Offset = "0x1A929C0", VA = "0x1A929C0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE7A0", Offset = "0x8DE7A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1A92A08", Offset = "0x1A92A08", VA = "0x1A92A08", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE7D8", Offset = "0x8DE7D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1A92A50", Offset = "0x1A92A50", VA = "0x1A92A50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE810", Offset = "0x8DE810")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1A92A98", Offset = "0x1A92A98", VA = "0x1A92A98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE848", Offset = "0x8DE848")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1A92AE0", Offset = "0x1A92AE0", VA = "0x1A92AE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1A92AE8", Offset = "0x1A92AE8", VA = "0x1A92AE8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D5024", Offset = "0x8D5024")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6AD0", Offset = "0x8D6AD0")]
			public Transform chest;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6B08", Offset = "0x8D6B08")]
			public Transform neck;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6B40", Offset = "0x8D6B40")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6B78", Offset = "0x8D6B78")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6BB0", Offset = "0x8D6BB0")]
			public Transform leftThigh;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6BE8", Offset = "0x8D6BE8")]
			public Transform leftCalf;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6C20", Offset = "0x8D6C20")]
			public Transform leftFoot;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6C58", Offset = "0x8D6C58")]
			public Transform leftToes;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6C90", Offset = "0x8D6C90")]
			public Transform rightThigh;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6CC8", Offset = "0x8D6CC8")]
			public Transform rightCalf;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6D00", Offset = "0x8D6D00")]
			public Transform rightFoot;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6D38", Offset = "0x8D6D38")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x2143998", Offset = "0x2143998", VA = "0x2143998")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x2143E10", Offset = "0x2143E10", VA = "0x2143E10")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2143550", Offset = "0x2143550", VA = "0x2143550")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2144288", Offset = "0x2144288", VA = "0x2144288")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2144624", Offset = "0x2144624", VA = "0x2144624")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x8D6A1C", Offset = "0x8D6A1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6A1C", Offset = "0x8D6A1C")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6A98", Offset = "0x8D6A98")]
		public IKSolverVR solver;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1A956F4", Offset = "0x1A956F4", VA = "0x1A956F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE880", Offset = "0x8DE880")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1A9573C", Offset = "0x1A9573C", VA = "0x1A9573C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE8B8", Offset = "0x8DE8B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1A95784", Offset = "0x1A95784", VA = "0x1A95784")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE8F0", Offset = "0x8DE8F0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1A957CC", Offset = "0x1A957CC", VA = "0x1A957CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE928", Offset = "0x8DE928")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1A957F8", Offset = "0x1A957F8", VA = "0x1A957F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DE960", Offset = "0x8DE960")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1A95820", Offset = "0x1A95820", VA = "0x1A95820", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1A95828", Offset = "0x1A95828", VA = "0x1A95828", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1A958A8", Offset = "0x1A958A8", VA = "0x1A958A8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1A95A14", Offset = "0x1A95A14", VA = "0x1A95A14")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6D70", Offset = "0x8D6D70")]
		public float pull;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6D88", Offset = "0x8D6D88")]
		public float pin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1D9D904", Offset = "0x1D9D904", VA = "0x1D9D904")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1D9D9D4", Offset = "0x1D9D9D4", VA = "0x1D9D9D4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1D9D9F4", Offset = "0x1D9D9F4", VA = "0x1D9D9F4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1D9DC68", Offset = "0x1D9DC68", VA = "0x1D9DC68")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1D9DAC8", Offset = "0x1D9DAC8", VA = "0x1D9DAC8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1D9DD60", Offset = "0x1D9DD60", VA = "0x1D9DD60")]
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
		[Address(RVA = "0x1D9DF50", Offset = "0x1D9DF50", VA = "0x1D9DF50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1D9E3B4", Offset = "0x1D9E3B4", VA = "0x1D9E3B4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1D9E570", Offset = "0x1D9E570", VA = "0x1D9E570")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1D9E67C", Offset = "0x1D9E67C", VA = "0x1D9E67C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D73E0", Offset = "0x8D73E0")]
			public Transform transform;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7418", Offset = "0x8D7418")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7418", Offset = "0x8D7418")]
			public float weight;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1A9B0D0", Offset = "0x1A9B0D0", VA = "0x1A9B0D0")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1A9B10C", Offset = "0x1A9B10C", VA = "0x1A9B10C")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1A9B164", Offset = "0x1A9B164", VA = "0x1A9B164")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1A9B19C", Offset = "0x1A9B19C", VA = "0x1A9B19C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6DA0", Offset = "0x8D6DA0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6DD8", Offset = "0x8D6DD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6DD8", Offset = "0x8D6DD8")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D6DD8", Offset = "0x8D6DD8")]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6E50", Offset = "0x8D6E50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6E50", Offset = "0x8D6E50")]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6EA4", Offset = "0x8D6EA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6EA4", Offset = "0x8D6EA4")]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6EF8", Offset = "0x8D6EF8")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6F30", Offset = "0x8D6F30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D6F30", Offset = "0x8D6F30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6F30", Offset = "0x8D6F30")]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6FA8", Offset = "0x8D6FA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6FA8", Offset = "0x8D6FA8")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D6FFC", Offset = "0x8D6FFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D6FFC", Offset = "0x8D6FFC")]
		public float headClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7050", Offset = "0x8D7050")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7050", Offset = "0x8D7050")]
		public float bendWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D70A4", Offset = "0x8D70A4")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D70DC", Offset = "0x8D70DC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D70DC", Offset = "0x8D70DC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D70DC", Offset = "0x8D70DC")]
		public float CCDWeight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7154", Offset = "0x8D7154")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7154", Offset = "0x8D7154")]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D71A8", Offset = "0x8D71A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D71A8", Offset = "0x8D71A8")]
		public float damper;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7200", Offset = "0x8D7200")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D7238", Offset = "0x8D7238")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7238", Offset = "0x8D7238")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7238", Offset = "0x8D7238")]
		public float postStretchWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D72B0", Offset = "0x8D72B0")]
		public float maxStretch;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D72E8", Offset = "0x8D72E8")]
		public float stretchDamper;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7320", Offset = "0x8D7320")]
		public bool fixHead;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7358", Offset = "0x8D7358")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8D7390", Offset = "0x8D7390")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D73C8", Offset = "0x8D73C8")]
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
		[Address(RVA = "0x1D9E684", Offset = "0x1D9E684", VA = "0x1D9E684")]
		private void Start()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1D9E9B8", Offset = "0x1D9E9B8", VA = "0x1D9E9B8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1D9EE58", Offset = "0x1D9EE58", VA = "0x1D9EE58")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1D9F224", Offset = "0x1D9F224", VA = "0x1D9F224")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1D9F9B0", Offset = "0x1D9F9B0", VA = "0x1D9F9B0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1D9FC90", Offset = "0x1D9FC90", VA = "0x1D9FC90")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1D9FF94", Offset = "0x1D9FF94", VA = "0x1D9FF94")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1DA0768", Offset = "0x1DA0768", VA = "0x1DA0768")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1D9F794", Offset = "0x1D9F794", VA = "0x1D9F794")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1DA0930", Offset = "0x1DA0930", VA = "0x1DA0930")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1DA0680", Offset = "0x1DA0680", VA = "0x1DA0680")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1DA05B4", Offset = "0x1DA05B4", VA = "0x1DA05B4")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1DA0BB4", Offset = "0x1DA0BB4", VA = "0x1DA0BB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1DA0E84", Offset = "0x1DA0E84", VA = "0x1DA0E84")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7504", Offset = "0x8D7504")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7514", Offset = "0x8D7514")]
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
				[Address(RVA = "0x1A9B258", Offset = "0x1A9B258", VA = "0x1A9B258")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE998", Offset = "0x8DE998")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x1A9B260", Offset = "0x1A9B260", VA = "0x1A9B260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE9A8", Offset = "0x8DE9A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x1A9B268", Offset = "0x1A9B268", VA = "0x1A9B268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE9B8", Offset = "0x8DE9B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x1A9B270", Offset = "0x1A9B270", VA = "0x1A9B270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE9C8", Offset = "0x8DE9C8")]
				private set
				{
				}
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1A9B27C", Offset = "0x1A9B27C", VA = "0x1A9B27C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1A9B2C8", Offset = "0x1A9B2C8", VA = "0x1A9B2C8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x1A9B320", Offset = "0x1A9B320", VA = "0x1A9B320")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1A9B4C4", Offset = "0x1A9B4C4", VA = "0x1A9B4C4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D746C", Offset = "0x8D746C")]
		public float pin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7484", Offset = "0x8D7484")]
		public float pull;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D749C", Offset = "0x8D749C")]
		public float push;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D74B4", Offset = "0x8D74B4")]
		public float pushParent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D74CC", Offset = "0x8D74CC")]
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
		[Address(RVA = "0x1DA1560", Offset = "0x1DA1560", VA = "0x1DA1560")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1DA164C", Offset = "0x1DA164C", VA = "0x1DA164C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1DA1778", Offset = "0x1DA1778", VA = "0x1DA1778")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1DA18A4", Offset = "0x1DA18A4", VA = "0x1DA18A4")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1DA197C", Offset = "0x1DA197C", VA = "0x1DA197C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1DA1A94", Offset = "0x1DA1A94", VA = "0x1DA1A94")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1DA2110", Offset = "0x1DA2110", VA = "0x1DA2110")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1DA1C24", Offset = "0x1DA1C24", VA = "0x1DA1C24")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1DA2500", Offset = "0x1DA2500", VA = "0x1DA2500")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1DA2760", Offset = "0x1DA2760", VA = "0x1DA2760")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1DA29CC", Offset = "0x1DA29CC", VA = "0x1DA29CC")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1DA2D70", Offset = "0x1DA2D70", VA = "0x1DA2D70")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1DA3204", Offset = "0x1DA3204", VA = "0x1DA3204")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1DA3428", Offset = "0x1DA3428", VA = "0x1DA3428")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1DA3194", Offset = "0x1DA3194", VA = "0x1DA3194")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1DA2BFC", Offset = "0x1DA2BFC", VA = "0x1DA2BFC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1DA3118", Offset = "0x1DA3118", VA = "0x1DA3118")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1DA3510", Offset = "0x1DA3510", VA = "0x1DA3510")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1DA3038", Offset = "0x1DA3038", VA = "0x1DA3038")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1DA3310", Offset = "0x1DA3310", VA = "0x1DA3310")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7524", Offset = "0x8D7524")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D753C", Offset = "0x8D753C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x1E14984", Offset = "0x1E14984", VA = "0x1E14984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE9D8", Offset = "0x8DE9D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1E1498C", Offset = "0x1E1498C", VA = "0x1E1498C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE9E8", Offset = "0x8DE9E8")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1E1479C", Offset = "0x1E1479C", VA = "0x1E1479C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1E14998", Offset = "0x1E14998", VA = "0x1E14998")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1E149D8", Offset = "0x1E149D8", VA = "0x1E149D8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1E14A38", Offset = "0x1E14A38", VA = "0x1E14A38")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1E14A44", Offset = "0x1E14A44", VA = "0x1E14A44")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1E14DBC", Offset = "0x1E14DBC", VA = "0x1E14DBC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1E14FAC", Offset = "0x1E14FAC", VA = "0x1E14FAC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1E152F8", Offset = "0x1E152F8", VA = "0x1E152F8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1E14C7C", Offset = "0x1E14C7C", VA = "0x1E14C7C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1E14D1C", Offset = "0x1E14D1C", VA = "0x1E14D1C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D754C", Offset = "0x8D754C")]
		public float positionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7564", Offset = "0x8D7564")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D757C", Offset = "0x8D757C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D758C", Offset = "0x8D758C")]
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
			[Address(RVA = "0x1E157D8", Offset = "0x1E157D8", VA = "0x1E157D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DE9F8", Offset = "0x8DE9F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1E157E0", Offset = "0x1E157E0", VA = "0x1E157E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA08", Offset = "0x8DEA08")]
			private set
			{
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1E15770", Offset = "0x1E15770", VA = "0x1E15770")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1E157EC", Offset = "0x1E157EC", VA = "0x1E157EC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1E1587C", Offset = "0x1E1587C", VA = "0x1E1587C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1E15990", Offset = "0x1E15990", VA = "0x1E15990")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1E15AC0", Offset = "0x1E15AC0", VA = "0x1E15AC0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1E15DDC", Offset = "0x1E15DDC", VA = "0x1E15DDC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1E1605C", Offset = "0x1E1605C", VA = "0x1E1605C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1E16128", Offset = "0x1E16128", VA = "0x1E16128")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1E161D0", Offset = "0x1E161D0", VA = "0x1E161D0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1E166F8", Offset = "0x1E166F8", VA = "0x1E166F8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1E16724", Offset = "0x1E16724", VA = "0x1E16724")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1E16878", Offset = "0x1E16878", VA = "0x1E16878")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1E16AF0", Offset = "0x1E16AF0", VA = "0x1E16AF0")]
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
				[Address(RVA = "0x1A90BA8", Offset = "0x1A90BA8", VA = "0x1A90BA8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x1A9E968", Offset = "0x1A9E968", VA = "0x1A9E968")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002D8")]
				[Address(RVA = "0x1A9ED0C", Offset = "0x1A9ED0C", VA = "0x1A9ED0C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1A9E89C", Offset = "0x1A9E89C", VA = "0x1A9E89C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1A9E8C8", Offset = "0x1A9E8C8", VA = "0x1A9E8C8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1A9E918", Offset = "0x1A9E918", VA = "0x1A9E918")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1A9E978", Offset = "0x1A9E978", VA = "0x1A9E978")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1A9EA00", Offset = "0x1A9EA00", VA = "0x1A9EA00")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1A9EA08", Offset = "0x1A9EA08", VA = "0x1A9EA08")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1A9EAE0", Offset = "0x1A9EAE0", VA = "0x1A9EAE0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1A9EB58", Offset = "0x1A9EB58", VA = "0x1A9EB58")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x1A9EBF0", Offset = "0x1A9EBF0", VA = "0x1A9EBF0")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1A9EE4C", Offset = "0x1A9EE4C", VA = "0x1A9EE4C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1A9EE84", Offset = "0x1A9EE84", VA = "0x1A9EE84")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1A9EEBC", Offset = "0x1A9EEBC", VA = "0x1A9EEBC")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1A9EEE4", Offset = "0x1A9EEE4", VA = "0x1A9EEE4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1A9EFD0", Offset = "0x1A9EFD0", VA = "0x1A9EFD0")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1A9F15C", Offset = "0x1A9F15C", VA = "0x1A9F15C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1A9F18C", Offset = "0x1A9F18C", VA = "0x1A9F18C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1A9F254", Offset = "0x1A9F254", VA = "0x1A9F254")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1A9F2C4", Offset = "0x1A9F2C4", VA = "0x1A9F2C4")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x1A9F414", Offset = "0x1A9F414", VA = "0x1A9F414")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1A9F564", Offset = "0x1A9F564", VA = "0x1A9F564")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x1A9F5E4", Offset = "0x1A9F5E4", VA = "0x1A9F5E4")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1A9F04C", Offset = "0x1A9F04C", VA = "0x1A9F04C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x1A9F71C", Offset = "0x1A9F71C", VA = "0x1A9F71C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1E16F98", Offset = "0x1E16F98", VA = "0x1E16F98", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1E16FA0", Offset = "0x1E16FA0", VA = "0x1E16FA0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1E16FA4", Offset = "0x1E16FA4", VA = "0x1E16FA4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1E170E8", Offset = "0x1E170E8", VA = "0x1E170E8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1E17158", Offset = "0x1E17158", VA = "0x1E17158")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D75A4", Offset = "0x8D75A4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1E17160", Offset = "0x1E17160", VA = "0x1E17160", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1E17208", Offset = "0x1E17208", VA = "0x1E17208")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1E17274", Offset = "0x1E17274", VA = "0x1E17274")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1E172F4", Offset = "0x1E172F4", VA = "0x1E172F4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1E17310", Offset = "0x1E17310", VA = "0x1E17310")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1E17330", Offset = "0x1E17330", VA = "0x1E17330", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1E173B8", Offset = "0x1E173B8", VA = "0x1E173B8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1E173D4", Offset = "0x1E173D4", VA = "0x1E173D4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D75BC", Offset = "0x8D75BC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D75D4", Offset = "0x8D75D4")]
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
		[Address(RVA = "0x1E173FC", Offset = "0x1E173FC", VA = "0x1E173FC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1E17480", Offset = "0x1E17480", VA = "0x1E17480")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1E1755C", Offset = "0x1E1755C", VA = "0x1E1755C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1E17780", Offset = "0x1E17780", VA = "0x1E17780")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1E17844", Offset = "0x1E17844", VA = "0x1E17844")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1E17934", Offset = "0x1E17934", VA = "0x1E17934")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1E17940", Offset = "0x1E17940", VA = "0x1E17940")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1E179F4", Offset = "0x1E179F4", VA = "0x1E179F4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1E17AB8", Offset = "0x1E17AB8", VA = "0x1E17AB8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1E17CF8", Offset = "0x1E17CF8", VA = "0x1E17CF8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1E17D6C", Offset = "0x1E17D6C", VA = "0x1E17D6C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D75EC", Offset = "0x8D75EC")]
		public int iterations;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7604", Offset = "0x8D7604")]
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
		[Address(RVA = "0x1E17EE8", Offset = "0x1E17EE8", VA = "0x1E17EE8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1E1824C", Offset = "0x1E1824C", VA = "0x1E1824C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1E18330", Offset = "0x1E18330", VA = "0x1E18330")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1E18448", Offset = "0x1E18448", VA = "0x1E18448")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1E18458", Offset = "0x1E18458", VA = "0x1E18458")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1E184C4", Offset = "0x1E184C4", VA = "0x1E184C4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1E18548", Offset = "0x1E18548", VA = "0x1E18548", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1E18B20", Offset = "0x1E18B20", VA = "0x1E18B20")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1E18B58", Offset = "0x1E18B58", VA = "0x1E18B58")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1E18DDC", Offset = "0x1E18DDC", VA = "0x1E18DDC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1E190DC", Offset = "0x1E190DC", VA = "0x1E190DC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1E191C8", Offset = "0x1E191C8", VA = "0x1E191C8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1E19290", Offset = "0x1E19290", VA = "0x1E19290")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D76D8", Offset = "0x8D76D8")]
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
			[Address(RVA = "0x1AA0228", Offset = "0x1AA0228", VA = "0x1AA0228")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1AA0278", Offset = "0x1AA0278", VA = "0x1AA0278")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1AA0318", Offset = "0x1AA0318", VA = "0x1AA0318")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x1AA0350", Offset = "0x1AA0350", VA = "0x1AA0350")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1AA0388", Offset = "0x1AA0388", VA = "0x1AA0388")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x1AA03D8", Offset = "0x1AA03D8", VA = "0x1AA03D8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1A9FE08", Offset = "0x1A9FE08", VA = "0x1A9FE08")]
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
				[Address(RVA = "0x1A9F738", Offset = "0x1A9F738", VA = "0x1A9F738")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000318")]
				[Address(RVA = "0x1A9F834", Offset = "0x1A9F834", VA = "0x1A9F834")]
				set
				{
				}
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1A9F8B8", Offset = "0x1A9F8B8", VA = "0x1A9F8B8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1A9FA68", Offset = "0x1A9FA68", VA = "0x1A9FA68")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1A9FC3C", Offset = "0x1A9FC3C", VA = "0x1A9FC3C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1A9FD9C", Offset = "0x1A9FD9C", VA = "0x1A9FD9C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1A9FDC4", Offset = "0x1A9FDC4", VA = "0x1A9FDC4")]
			public Bone()
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1A9FE44", Offset = "0x1A9FE44", VA = "0x1A9FE44")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1A9FE94", Offset = "0x1A9FE94", VA = "0x1A9FE94")]
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
			[Address(RVA = "0x1AA01C4", Offset = "0x1AA01C4", VA = "0x1AA01C4")]
			public Node()
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1AA01C8", Offset = "0x1AA01C8", VA = "0x1AA01C8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1AA01F0", Offset = "0x1AA01F0", VA = "0x1AA01F0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D763C", Offset = "0x8D763C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D763C", Offset = "0x8D763C")]
		public float IKPositionWeight;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7690", Offset = "0x8D7690")]
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
			[Address(RVA = "0x1E195C0", Offset = "0x1E195C0", VA = "0x1E195C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA18", Offset = "0x8DEA18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1E195C8", Offset = "0x1E195C8", VA = "0x1E195C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA28", Offset = "0x8DEA28")]
			private set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1E194F0", Offset = "0x1E194F0", VA = "0x1E194F0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FB")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1E145B8", Offset = "0x1E145B8", VA = "0x1E145B8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1E144D8", Offset = "0x1E144D8", VA = "0x1E144D8")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1E19568", Offset = "0x1E19568", VA = "0x1E19568", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1E19574", Offset = "0x1E19574", VA = "0x1E19574")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1E19580", Offset = "0x1E19580", VA = "0x1E19580")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1E19588", Offset = "0x1E19588", VA = "0x1E19588")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1E195B8", Offset = "0x1E195B8", VA = "0x1E195B8")]
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
		[Address(RVA = "0x1E195D4", Offset = "0x1E195D4", VA = "0x1E195D4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1E195EC", Offset = "0x1E195EC", VA = "0x1E195EC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1E19724", Offset = "0x1E19724", VA = "0x1E19724")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1E197CC", Offset = "0x1E197CC", VA = "0x1E197CC")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1E19A54", Offset = "0x1E19A54", VA = "0x1E19A54")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D76F0", Offset = "0x8D76F0")]
		public float poleWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7708", Offset = "0x8D7708")]
		public float clampWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7720", Offset = "0x8D7720")]
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
			[Address(RVA = "0x1E19AE8", Offset = "0x1E19AE8", VA = "0x1E19AE8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1E19B24", Offset = "0x1E19B24", VA = "0x1E19B24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1E1A5B4", Offset = "0x1E1A5B4", VA = "0x1E1A5B4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1E1A998", Offset = "0x1E1A998", VA = "0x1E1A998", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1E19A6C", Offset = "0x1E19A6C", VA = "0x1E19A6C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1E19B60", Offset = "0x1E19B60", VA = "0x1E19B60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1E19D80", Offset = "0x1E19D80", VA = "0x1E19D80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1E1A500", Offset = "0x1E1A500", VA = "0x1E1A500")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1E1A290", Offset = "0x1E1A290", VA = "0x1E1A290")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1E1A5BC", Offset = "0x1E1A5BC", VA = "0x1E1A5BC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1E1AA0C", Offset = "0x1E1AA0C", VA = "0x1E1AA0C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7738", Offset = "0x8D7738")]
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
		[Address(RVA = "0x1E1AA60", Offset = "0x1E1AA60", VA = "0x1E1AA60", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1E1ADFC", Offset = "0x1E1ADFC", VA = "0x1E1ADFC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1E1AE68", Offset = "0x1E1AE68", VA = "0x1E1AE68", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1E1AFC0", Offset = "0x1E1AFC0", VA = "0x1E1AFC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1E1B154", Offset = "0x1E1B154", VA = "0x1E1B154", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1E1B1B0", Offset = "0x1E1B1B0", VA = "0x1E1B1B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1E1B220", Offset = "0x1E1B220", VA = "0x1E1B220", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1E1B590", Offset = "0x1E1B590", VA = "0x1E1B590", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1E1B5BC", Offset = "0x1E1B5BC", VA = "0x1E1B5BC")]
		private void Solve()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1E1B284", Offset = "0x1E1B284", VA = "0x1E1B284")]
		private void Read()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1E1B62C", Offset = "0x1E1B62C", VA = "0x1E1B62C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1E1B7B8", Offset = "0x1E1B7B8", VA = "0x1E1B7B8")]
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
		[Address(RVA = "0x1E1B91C", Offset = "0x1E1B91C", VA = "0x1E1B91C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1E1B9CC", Offset = "0x1E1B9CC", VA = "0x1E1B9CC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1E1BA50", Offset = "0x1E1BA50", VA = "0x1E1BA50", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1E1BC80", Offset = "0x1E1BC80", VA = "0x1E1BC80")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1E1C25C", Offset = "0x1E1C25C", VA = "0x1E1C25C")]
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
			[Address(RVA = "0x1E1D16C", Offset = "0x1E1D16C", VA = "0x1E1D16C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1E1C264", Offset = "0x1E1C264", VA = "0x1E1C264")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1E1C828", Offset = "0x1E1C828", VA = "0x1E1C828")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1E1C968", Offset = "0x1E1C968", VA = "0x1E1C968", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1E1C9FC", Offset = "0x1E1C9FC", VA = "0x1E1C9FC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1E1CED8", Offset = "0x1E1CED8", VA = "0x1E1CED8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1E1D174", Offset = "0x1E1D174", VA = "0x1E1D174")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1E1C340", Offset = "0x1E1C340", VA = "0x1E1C340")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1E1C914", Offset = "0x1E1C914", VA = "0x1E1C914")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1E1D110", Offset = "0x1E1D110", VA = "0x1E1D110")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1E1C69C", Offset = "0x1E1C69C", VA = "0x1E1C69C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1E1D7C4", Offset = "0x1E1D7C4", VA = "0x1E1D7C4")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1E1D838", Offset = "0x1E1D838", VA = "0x1E1D838")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1E1D900", Offset = "0x1E1D900", VA = "0x1E1D900")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1E1D9B0", Offset = "0x1E1D9B0", VA = "0x1E1D9B0")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1E1CC88", Offset = "0x1E1CC88", VA = "0x1E1CC88")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1E1CDB0", Offset = "0x1E1CDB0", VA = "0x1E1CDB0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1E1DAB4", Offset = "0x1E1DAB4", VA = "0x1E1DAB4")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1E1D394", Offset = "0x1E1D394", VA = "0x1E1D394")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1E1C904", Offset = "0x1E1C904", VA = "0x1E1C904")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1E1E044", Offset = "0x1E1E044", VA = "0x1E1E044")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1E1DBF8", Offset = "0x1E1DBF8", VA = "0x1E1DBF8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1E1D1F0", Offset = "0x1E1D1F0", VA = "0x1E1D1F0")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1E1D2D0", Offset = "0x1E1D2D0", VA = "0x1E1D2D0")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1E1E110", Offset = "0x1E1E110", VA = "0x1E1E110")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7750", Offset = "0x8D7750")]
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
		[Address(RVA = "0x1E1E190", Offset = "0x1E1E190", VA = "0x1E1E190", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1E1E7D0", Offset = "0x1E1E7D0", VA = "0x1E1E7D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1E1E868", Offset = "0x1E1E868", VA = "0x1E1E868", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1E1E908", Offset = "0x1E1E908", VA = "0x1E1E908", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1E1EA04", Offset = "0x1E1EA04", VA = "0x1E1EA04")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1E1EAA0", Offset = "0x1E1EAA0", VA = "0x1E1EAA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1E1EED0", Offset = "0x1E1EED0", VA = "0x1E1EED0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1E1F0C8", Offset = "0x1E1F0C8", VA = "0x1E1F0C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1E1EF7C", Offset = "0x1E1EF7C", VA = "0x1E1EF7C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1E1EC8C", Offset = "0x1E1EC8C", VA = "0x1E1EC8C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1E1F160", Offset = "0x1E1F160", VA = "0x1E1F160")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7768", Offset = "0x8D7768")]
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
		[Address(RVA = "0x1E1F1D4", Offset = "0x1E1F1D4", VA = "0x1E1F1D4")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1E1F2C4", Offset = "0x1E1F2C4", VA = "0x1E1F2C4")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1E1F320", Offset = "0x1E1F320", VA = "0x1E1F320")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1E15714", Offset = "0x1E15714", VA = "0x1E15714")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1E14BFC", Offset = "0x1E14BFC", VA = "0x1E14BFC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1E1F450", Offset = "0x1E1F450", VA = "0x1E1F450", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1E1F5F4", Offset = "0x1E1F5F4", VA = "0x1E1F5F4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1E1F764", Offset = "0x1E1F764", VA = "0x1E1F764", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1E1F96C", Offset = "0x1E1F96C", VA = "0x1E1F96C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1E1FA44", Offset = "0x1E1FA44", VA = "0x1E1FA44", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1E1FB24", Offset = "0x1E1FB24", VA = "0x1E1FB24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1E1FC94", Offset = "0x1E1FC94", VA = "0x1E1FC94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1E1FDF4", Offset = "0x1E1FDF4", VA = "0x1E1FDF4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1E20034", Offset = "0x1E20034", VA = "0x1E20034", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1E20300", Offset = "0x1E20300", VA = "0x1E20300", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1E20344", Offset = "0x1E20344", VA = "0x1E20344", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1E20428", Offset = "0x1E20428", VA = "0x1E20428")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7780", Offset = "0x8D7780")]
		public float spineStiffness;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7798", Offset = "0x8D7798")]
		public float pullBodyVertical;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D77B0", Offset = "0x8D77B0")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D77C8", Offset = "0x8D77C8")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x1E21534", Offset = "0x1E21534", VA = "0x1E21534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x1E2167C", Offset = "0x1E2167C", VA = "0x1E2167C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x1E21684", Offset = "0x1E21684", VA = "0x1E21684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1E2168C", Offset = "0x1E2168C", VA = "0x1E2168C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x1E21694", Offset = "0x1E21694", VA = "0x1E21694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1E2169C", Offset = "0x1E2169C", VA = "0x1E2169C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1E216A4", Offset = "0x1E216A4", VA = "0x1E216A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1E216AC", Offset = "0x1E216AC", VA = "0x1E216AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1E216B4", Offset = "0x1E216B4", VA = "0x1E216B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x1E216BC", Offset = "0x1E216BC", VA = "0x1E216BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1E216F4", Offset = "0x1E216F4", VA = "0x1E216F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1E2172C", Offset = "0x1E2172C", VA = "0x1E2172C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1E21764", Offset = "0x1E21764", VA = "0x1E21764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1E2179C", Offset = "0x1E2179C", VA = "0x1E2179C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1E217D0", Offset = "0x1E217D0", VA = "0x1E217D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1E21808", Offset = "0x1E21808", VA = "0x1E21808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1E21840", Offset = "0x1E21840", VA = "0x1E21840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1E21878", Offset = "0x1E21878", VA = "0x1E21878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1E23744", Offset = "0x1E23744", VA = "0x1E23744")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA38", Offset = "0x8DEA38")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x1E23750", Offset = "0x1E23750", VA = "0x1E23750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA48", Offset = "0x8DEA48")]
			private set
			{
			}
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1E218AC", Offset = "0x1E218AC", VA = "0x1E218AC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1E219B8", Offset = "0x1E219B8", VA = "0x1E219B8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1E21900", Offset = "0x1E21900", VA = "0x1E21900")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1E21A44", Offset = "0x1E21A44", VA = "0x1E21A44")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1E2153C", Offset = "0x1E2153C", VA = "0x1E2153C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1E21B14", Offset = "0x1E21B14", VA = "0x1E21B14")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1E21BCC", Offset = "0x1E21BCC", VA = "0x1E21BCC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1E21C80", Offset = "0x1E21C80", VA = "0x1E21C80")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1E21D34", Offset = "0x1E21D34", VA = "0x1E21D34")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1E21D3C", Offset = "0x1E21D3C", VA = "0x1E21D3C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1E21D70", Offset = "0x1E21D70", VA = "0x1E21D70")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1E21E38", Offset = "0x1E21E38", VA = "0x1E21E38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1E21FE0", Offset = "0x1E21FE0", VA = "0x1E21FE0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1E231C0", Offset = "0x1E231C0", VA = "0x1E231C0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1E235D4", Offset = "0x1E235D4", VA = "0x1E235D4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1E23634", Offset = "0x1E23634", VA = "0x1E23634")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1E2345C", Offset = "0x1E2345C", VA = "0x1E2345C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1E23518", Offset = "0x1E23518", VA = "0x1E23518")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1E2375C", Offset = "0x1E2375C", VA = "0x1E2375C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1E23834", Offset = "0x1E23834", VA = "0x1E23834", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1E23934", Offset = "0x1E23934", VA = "0x1E23934")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1E23A5C", Offset = "0x1E23A5C", VA = "0x1E23A5C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1E23BA0", Offset = "0x1E23BA0", VA = "0x1E23BA0")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1E23CD0", Offset = "0x1E23CD0", VA = "0x1E23CD0", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1E23F14", Offset = "0x1E23F14", VA = "0x1E23F14", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1E23F9C", Offset = "0x1E23F9C", VA = "0x1E23F9C")]
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
			[Address(RVA = "0x1E2480C", Offset = "0x1E2480C", VA = "0x1E2480C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1E24814", Offset = "0x1E24814", VA = "0x1E24814", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1E2481C", Offset = "0x1E2481C", VA = "0x1E2481C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1E24CA4", Offset = "0x1E24CA4", VA = "0x1E24CA4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1E24D6C", Offset = "0x1E24D6C", VA = "0x1E24D6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1E23FAC", Offset = "0x1E23FAC", VA = "0x1E23FAC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1E24148", Offset = "0x1E24148", VA = "0x1E24148")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1E24280", Offset = "0x1E24280", VA = "0x1E24280", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1E242EC", Offset = "0x1E242EC", VA = "0x1E242EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1E2436C", Offset = "0x1E2436C", VA = "0x1E2436C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1E24714", Offset = "0x1E24714", VA = "0x1E24714", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1E2471C", Offset = "0x1E2471C", VA = "0x1E2471C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1E24824", Offset = "0x1E24824", VA = "0x1E24824", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1E24828", Offset = "0x1E24828", VA = "0x1E24828", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1E2482C", Offset = "0x1E2482C", VA = "0x1E2482C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1E24DC0", Offset = "0x1E24DC0", VA = "0x1E24DC0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1E250D8", Offset = "0x1E250D8", VA = "0x1E250D8")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1E252CC", Offset = "0x1E252CC", VA = "0x1E252CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D77D8", Offset = "0x8D77D8")]
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
		[Address(RVA = "0x1E25338", Offset = "0x1E25338", VA = "0x1E25338", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1E256D8", Offset = "0x1E256D8", VA = "0x1E256D8")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1E25748", Offset = "0x1E25748", VA = "0x1E25748", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1E258A0", Offset = "0x1E258A0", VA = "0x1E258A0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1E25A34", Offset = "0x1E25A34", VA = "0x1E25A34", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1E25A90", Offset = "0x1E25A90", VA = "0x1E25A90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1E25B00", Offset = "0x1E25B00", VA = "0x1E25B00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1E25E70", Offset = "0x1E25E70", VA = "0x1E25E70", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1E25E9C", Offset = "0x1E25E9C", VA = "0x1E25E9C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1E25B64", Offset = "0x1E25B64", VA = "0x1E25B64")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1E25F34", Offset = "0x1E25F34", VA = "0x1E25F34")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1E260C0", Offset = "0x1E260C0", VA = "0x1E260C0")]
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
			[Address(RVA = "0x1AA066C", Offset = "0x1AA066C", VA = "0x1AA066C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D77F0", Offset = "0x8D77F0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7808", Offset = "0x8D7808")]
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
			[Address(RVA = "0x1E2733C", Offset = "0x1E2733C", VA = "0x1E2733C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1E26218", Offset = "0x1E26218", VA = "0x1E26218")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1E26268", Offset = "0x1E26268", VA = "0x1E26268")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1E262B4", Offset = "0x1E262B4", VA = "0x1E262B4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1E26788", Offset = "0x1E26788", VA = "0x1E26788", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1E270D0", Offset = "0x1E270D0", VA = "0x1E270D0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1E2717C", Offset = "0x1E2717C", VA = "0x1E2717C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1E272B8", Offset = "0x1E272B8", VA = "0x1E272B8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1E265B0", Offset = "0x1E265B0", VA = "0x1E265B0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1E2686C", Offset = "0x1E2686C", VA = "0x1E2686C")]
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
				[Address(RVA = "0x1AA08F8", Offset = "0x1AA08F8", VA = "0x1AA08F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1AA06CC", Offset = "0x1AA06CC", VA = "0x1AA06CC")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1AA06D0", Offset = "0x1AA06D0", VA = "0x1AA06D0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1AA06F8", Offset = "0x1AA06F8", VA = "0x1AA06F8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1AA07F0", Offset = "0x1AA07F0", VA = "0x1AA07F0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7820", Offset = "0x8D7820")]
		public float bodyWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7838", Offset = "0x8D7838")]
		public float headWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7850", Offset = "0x8D7850")]
		public float eyesWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7868", Offset = "0x8D7868")]
		public float clampWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7880", Offset = "0x8D7880")]
		public float clampWeightHead;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7898", Offset = "0x8D7898")]
		public float clampWeightEyes;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D78B0", Offset = "0x8D78B0")]
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
			[Address(RVA = "0x1E27AEC", Offset = "0x1E27AEC", VA = "0x1E27AEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1E27CBC", Offset = "0x1E27CBC", VA = "0x1E27CBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1E27BCC", Offset = "0x1E27BCC", VA = "0x1E27BCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1E27CE0", Offset = "0x1E27CE0", VA = "0x1E27CE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1E27BDC", Offset = "0x1E27BDC", VA = "0x1E27BDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1E27D58", Offset = "0x1E27D58", VA = "0x1E27D58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1E27358", Offset = "0x1E27358", VA = "0x1E27358")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1E27388", Offset = "0x1E27388", VA = "0x1E27388")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1E273E0", Offset = "0x1E273E0", VA = "0x1E273E0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1E2745C", Offset = "0x1E2745C", VA = "0x1E2745C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1E274F4", Offset = "0x1E274F4", VA = "0x1E274F4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1E275B4", Offset = "0x1E275B4", VA = "0x1E275B4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1E276B0", Offset = "0x1E276B0", VA = "0x1E276B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1E277DC", Offset = "0x1E277DC", VA = "0x1E277DC")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1E277E8", Offset = "0x1E277E8", VA = "0x1E277E8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1E2792C", Offset = "0x1E2792C", VA = "0x1E2792C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1E27D7C", Offset = "0x1E27D7C", VA = "0x1E27D7C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1E27FBC", Offset = "0x1E27FBC", VA = "0x1E27FBC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1E28158", Offset = "0x1E28158", VA = "0x1E28158")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1E28388", Offset = "0x1E28388", VA = "0x1E28388", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1E2865C", Offset = "0x1E2865C", VA = "0x1E2865C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1E2872C", Offset = "0x1E2872C", VA = "0x1E2872C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1E288CC", Offset = "0x1E288CC", VA = "0x1E288CC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1E28AF0", Offset = "0x1E28AF0", VA = "0x1E28AF0")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1E28EA4", Offset = "0x1E28EA4", VA = "0x1E28EA4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1E28204", Offset = "0x1E28204", VA = "0x1E28204")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1E29114", Offset = "0x1E29114", VA = "0x1E29114")]
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
			[Address(RVA = "0x1AA0934", Offset = "0x1AA0934", VA = "0x1AA0934")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1AA0A30", Offset = "0x1AA0A30", VA = "0x1AA0A30")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1AA0A60", Offset = "0x1AA0A60", VA = "0x1AA0A60")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1AA0A9C", Offset = "0x1AA0A9C", VA = "0x1AA0A9C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D78C8", Offset = "0x8D78C8")]
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
		[Address(RVA = "0x1E29320", Offset = "0x1E29320", VA = "0x1E29320")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1E2947C", Offset = "0x1E2947C", VA = "0x1E2947C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1E295C0", Offset = "0x1E295C0", VA = "0x1E295C0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1E295CC", Offset = "0x1E295CC", VA = "0x1E295CC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1E295FC", Offset = "0x1E295FC", VA = "0x1E295FC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1E29608", Offset = "0x1E29608", VA = "0x1E29608")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1E29610", Offset = "0x1E29610", VA = "0x1E29610", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1E29710", Offset = "0x1E29710", VA = "0x1E29710", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1E2982C", Offset = "0x1E2982C", VA = "0x1E2982C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1E29878", Offset = "0x1E29878", VA = "0x1E29878", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1E298D8", Offset = "0x1E298D8", VA = "0x1E298D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1E29CA0", Offset = "0x1E29CA0", VA = "0x1E29CA0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1E29CF8", Offset = "0x1E29CF8", VA = "0x1E29CF8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1E2A0B4", Offset = "0x1E2A0B4", VA = "0x1E2A0B4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1E2A21C", Offset = "0x1E2A21C", VA = "0x1E2A21C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1E2A384", Offset = "0x1E2A384", VA = "0x1E2A384")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1E2A2F8", Offset = "0x1E2A2F8", VA = "0x1E2A2F8")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1E2A488", Offset = "0x1E2A488", VA = "0x1E2A488", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1E2AC5C", Offset = "0x1E2AC5C", VA = "0x1E2AC5C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1E2AC60", Offset = "0x1E2AC60", VA = "0x1E2AC60", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1E2AC64", Offset = "0x1E2AC64", VA = "0x1E2AC64", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1E2AA74", Offset = "0x1E2AA74", VA = "0x1E2AA74")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1E271EC", Offset = "0x1E271EC", VA = "0x1E271EC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7B04", Offset = "0x8D7B04")]
			public Transform target;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7B3C", Offset = "0x8D7B3C")]
			public Transform bendGoal;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7B74", Offset = "0x8D7B74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7B74", Offset = "0x8D7B74")]
			public float positionWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7BC8", Offset = "0x8D7BC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7BC8", Offset = "0x8D7BC8")]
			public float rotationWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7C1C", Offset = "0x8D7C1C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7C54", Offset = "0x8D7C54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7C54", Offset = "0x8D7C54")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7CA8", Offset = "0x8D7CA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7CA8", Offset = "0x8D7CA8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7CFC", Offset = "0x8D7CFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7CFC", Offset = "0x8D7CFC")]
			public float bendGoalWeight;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7D50", Offset = "0x8D7D50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7D50", Offset = "0x8D7D50")]
			public float swivelOffset;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7DAC", Offset = "0x8D7DAC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7DE4", Offset = "0x8D7DE4")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7E1C", Offset = "0x8D7E1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7E1C", Offset = "0x8D7E1C")]
			public float armLengthMlp;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7E74", Offset = "0x8D7E74")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7EEC", Offset = "0x8D7EEC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7EFC", Offset = "0x8D7EFC")]
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
				[Address(RVA = "0x1E8876C", Offset = "0x1E8876C", VA = "0x1E8876C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA78", Offset = "0x8DEA78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x1E88778", Offset = "0x1E88778", VA = "0x1E88778")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA88", Offset = "0x8DEA88")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x1E88784", Offset = "0x1E88784", VA = "0x1E88784")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA98", Offset = "0x8DEA98")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x1E88790", Offset = "0x1E88790", VA = "0x1E88790")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEAA8", Offset = "0x8DEAA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x1E8879C", Offset = "0x1E8879C", VA = "0x1E8879C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x1E887D0", Offset = "0x1E887D0", VA = "0x1E887D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x1E88810", Offset = "0x1E88810", VA = "0x1E88810")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x1E8885C", Offset = "0x1E8885C", VA = "0x1E8885C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x1E888A8", Offset = "0x1E888A8", VA = "0x1E888A8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1E891EC", Offset = "0x1E891EC", VA = "0x1E891EC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x1E893A8", Offset = "0x1E893A8", VA = "0x1E893A8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x1E893CC", Offset = "0x1E893CC", VA = "0x1E893CC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1E8966C", Offset = "0x1E8966C", VA = "0x1E8966C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1E8B100", Offset = "0x1E8B100", VA = "0x1E8B100", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1E8B12C", Offset = "0x1E8B12C", VA = "0x1E8B12C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1E8A600", Offset = "0x1E8A600", VA = "0x1E8A600")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1E8A7B8", Offset = "0x1E8A7B8", VA = "0x1E8A7B8")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1E8B34C", Offset = "0x1E8B34C", VA = "0x1E8B34C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x1E8B470", Offset = "0x1E8B470", VA = "0x1E8B470")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7F0C", Offset = "0x8D7F0C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7F1C", Offset = "0x8D7F1C")]
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
				[Address(RVA = "0x1E8B5C8", Offset = "0x1E8B5C8", VA = "0x1E8B5C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEAB8", Offset = "0x8DEAB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x1E8B5D0", Offset = "0x1E8B5D0", VA = "0x1E8B5D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEAC8", Offset = "0x8DEAC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x1E8B5D8", Offset = "0x1E8B5D8", VA = "0x1E8B5D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEAD8", Offset = "0x8DEAD8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x1E8B5E0", Offset = "0x1E8B5E0", VA = "0x1E8B5E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEAE8", Offset = "0x8DEAE8")]
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
			[Address(RVA = "0x1E8B5E8", Offset = "0x1E8B5E8", VA = "0x1E8B5E8")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x1E8B5F0", Offset = "0x1E8B5F0", VA = "0x1E8B5F0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x1E8B8B0", Offset = "0x1E8B8B0", VA = "0x1E8B8B0")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x1E8B944", Offset = "0x1E8B944", VA = "0x1E8B944")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x1E8BB14", Offset = "0x1E8BB14", VA = "0x1E8BB14")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x1E8BB68", Offset = "0x1E8BB68", VA = "0x1E8BB68")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1E8AFC0", Offset = "0x1E8AFC0", VA = "0x1E8AFC0")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1E8BCA0", Offset = "0x1E8BCA0", VA = "0x1E8BCA0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1E8BDE0", Offset = "0x1E8BDE0", VA = "0x1E8BDE0")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600044F")]
			[Address(RVA = "0x1E8B554", Offset = "0x1E8B554", VA = "0x1E8B554")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D7F3C", Offset = "0x8D7F3C")]
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
				[Address(RVA = "0x1E8BE08", Offset = "0x1E8BE08", VA = "0x1E8BE08")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x1E8BE1C", Offset = "0x1E8BE1C", VA = "0x1E8BE1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEAF8", Offset = "0x8DEAF8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1E8BE24", Offset = "0x1E8BE24", VA = "0x1E8BE24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB08", Offset = "0x8DEB08")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1E8BE2C", Offset = "0x1E8BE2C", VA = "0x1E8BE2C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1E8BF64", Offset = "0x1E8BF64", VA = "0x1E8BF64")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1E8BFAC", Offset = "0x1E8BFAC", VA = "0x1E8BFAC")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1E8C178", Offset = "0x1E8C178", VA = "0x1E8C178")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1E8C2EC", Offset = "0x1E8C2EC", VA = "0x1E8C2EC")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1E8C444", Offset = "0x1E8C444", VA = "0x1E8C444")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7F4C", Offset = "0x8D7F4C")]
			public Transform target;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7F84", Offset = "0x8D7F84")]
			public Transform bendGoal;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7FBC", Offset = "0x8D7FBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D7FBC", Offset = "0x8D7FBC")]
			public float positionWeight;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8010", Offset = "0x8D8010")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8010", Offset = "0x8D8010")]
			public float rotationWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8064", Offset = "0x8D8064")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8064", Offset = "0x8D8064")]
			public float bendGoalWeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D80B8", Offset = "0x8D80B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D80B8", Offset = "0x8D80B8")]
			public float swivelOffset;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8114", Offset = "0x8D8114")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8114", Offset = "0x8D8114")]
			public float bendToTargetWeight;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8168", Offset = "0x8D8168")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8168", Offset = "0x8D8168")]
			public float legLengthMlp;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D81C0", Offset = "0x8D81C0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8268", Offset = "0x8D8268")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8278", Offset = "0x8D8278")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8288", Offset = "0x8D8288")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8298", Offset = "0x8D8298")]
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
				[Address(RVA = "0x1E8C580", Offset = "0x1E8C580", VA = "0x1E8C580")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB18", Offset = "0x8DEB18")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x1E8C58C", Offset = "0x1E8C58C", VA = "0x1E8C58C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB28", Offset = "0x8DEB28")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x1E8C598", Offset = "0x1E8C598", VA = "0x1E8C598")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB38", Offset = "0x8DEB38")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x1E8C5A4", Offset = "0x1E8C5A4", VA = "0x1E8C5A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB48", Offset = "0x8DEB48")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x1E8C5B0", Offset = "0x1E8C5B0", VA = "0x1E8C5B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB58", Offset = "0x8DEB58")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x1E8C5B8", Offset = "0x1E8C5B8", VA = "0x1E8C5B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB68", Offset = "0x8DEB68")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1E8C5C4", Offset = "0x1E8C5C4", VA = "0x1E8C5C4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x1E8C5F8", Offset = "0x1E8C5F8", VA = "0x1E8C5F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x1E8C630", Offset = "0x1E8C630", VA = "0x1E8C630")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x1E8C668", Offset = "0x1E8C668", VA = "0x1E8C668")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x1E8C6A0", Offset = "0x1E8C6A0", VA = "0x1E8C6A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x1E8C6E0", Offset = "0x1E8C6E0", VA = "0x1E8C6E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB78", Offset = "0x8DEB78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x1E8C6EC", Offset = "0x1E8C6EC", VA = "0x1E8C6EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB88", Offset = "0x8DEB88")]
				private set
				{
				}
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x1E8C6F8", Offset = "0x1E8C6F8", VA = "0x1E8C6F8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1E8CCD4", Offset = "0x1E8CCD4", VA = "0x1E8CCD4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x1E8D2A8", Offset = "0x1E8D2A8", VA = "0x1E8D2A8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1E8D258", Offset = "0x1E8D258", VA = "0x1E8D258")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1E8D0E8", Offset = "0x1E8D0E8", VA = "0x1E8D0E8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1E8D690", Offset = "0x1E8D690", VA = "0x1E8D690")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1E8DB4C", Offset = "0x1E8DB4C", VA = "0x1E8DB4C")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1E8D82C", Offset = "0x1E8D82C", VA = "0x1E8D82C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x1E8DE44", Offset = "0x1E8DE44", VA = "0x1E8DE44", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x1E8E060", Offset = "0x1E8E060", VA = "0x1E8E060", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x1E8E0AC", Offset = "0x1E8E0AC", VA = "0x1E8E0AC")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D82A8", Offset = "0x8D82A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D82A8", Offset = "0x8D82A8")]
			public float weight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D82FC", Offset = "0x8D82FC")]
			public float footDistance;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8334", Offset = "0x8D8334")]
			public float stepThreshold;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D836C", Offset = "0x8D836C")]
			public float angleThreshold;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D83A4", Offset = "0x8D83A4")]
			public float comAngleMlp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D83DC", Offset = "0x8D83DC")]
			public float maxVelocity;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8414", Offset = "0x8D8414")]
			public float velocityFactor;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D844C", Offset = "0x8D844C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D844C", Offset = "0x8D844C")]
			public float maxLegStretch;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D84A4", Offset = "0x8D84A4")]
			public float rootSpeed;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D84DC", Offset = "0x8D84DC")]
			public float stepSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8514", Offset = "0x8D8514")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D854C", Offset = "0x8D854C")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8584", Offset = "0x8D8584")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D85BC", Offset = "0x8D85BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D85BC", Offset = "0x8D85BC")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8614", Offset = "0x8D8614")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D864C", Offset = "0x8D864C")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8684", Offset = "0x8D8684")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D86FC", Offset = "0x8D86FC")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8734", Offset = "0x8D8734")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D876C", Offset = "0x8D876C")]
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
				[Address(RVA = "0x1E8E17C", Offset = "0x1E8E17C", VA = "0x1E8E17C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEB98", Offset = "0x8DEB98")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x1E8E188", Offset = "0x1E8E188", VA = "0x1E8E188")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEBA8", Offset = "0x8DEBA8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x1E8FD98", Offset = "0x1E8FD98", VA = "0x1E8FD98")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x1E8FDD8", Offset = "0x1E8FDD8", VA = "0x1E8FDD8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x1E8FE1C", Offset = "0x1E8FE1C", VA = "0x1E8FE1C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x1E8FE5C", Offset = "0x1E8FE5C", VA = "0x1E8FE5C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1E8E194", Offset = "0x1E8E194", VA = "0x1E8E194")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x1E8E450", Offset = "0x1E8E450", VA = "0x1E8E450")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x1E8E620", Offset = "0x1E8E620", VA = "0x1E8E620")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x1E8E684", Offset = "0x1E8E684", VA = "0x1E8E684")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1E8E8CC", Offset = "0x1E8E8CC", VA = "0x1E8E8CC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1E8E990", Offset = "0x1E8E990", VA = "0x1E8E990")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1E8FB10", Offset = "0x1E8FB10", VA = "0x1E8FB10")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1E8FC48", Offset = "0x1E8FC48", VA = "0x1E8FC48")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1E8FCCC", Offset = "0x1E8FCCC", VA = "0x1E8FCCC")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1E8FEA0", Offset = "0x1E8FEA0", VA = "0x1E8FEA0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D877C", Offset = "0x8D877C")]
			public Transform headTarget;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D87B4", Offset = "0x8D87B4")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D87EC", Offset = "0x8D87EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D87EC", Offset = "0x8D87EC")]
			public float positionWeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8840", Offset = "0x8D8840")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8840", Offset = "0x8D8840")]
			public float rotationWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8894", Offset = "0x8D8894")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8894", Offset = "0x8D8894")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D88E8", Offset = "0x8D88E8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D88E8", Offset = "0x8D88E8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D893C", Offset = "0x8D893C")]
			public Transform chestGoal;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8974", Offset = "0x8D8974")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8974", Offset = "0x8D8974")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D89C8", Offset = "0x8D89C8")]
			public float minHeadHeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8A00", Offset = "0x8D8A00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8A00", Offset = "0x8D8A00")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8A54", Offset = "0x8D8A54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8A54", Offset = "0x8D8A54")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8AA8", Offset = "0x8D8AA8")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8D8AA8", Offset = "0x8D8AA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8AA8", Offset = "0x8D8AA8")]
			public float neckStiffness;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8B20", Offset = "0x8D8B20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8B20", Offset = "0x8D8B20")]
			public float rotateChestByHands;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8B74", Offset = "0x8D8B74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8B74", Offset = "0x8D8B74")]
			public float chestClampWeight;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8BC8", Offset = "0x8D8BC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8BC8", Offset = "0x8D8BC8")]
			public float headClampWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8C1C", Offset = "0x8D8C1C")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8C54", Offset = "0x8D8C54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8C54", Offset = "0x8D8C54")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8CA8", Offset = "0x8D8CA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8CA8", Offset = "0x8D8CA8")]
			public float maxRootAngle;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8D00", Offset = "0x8D8D00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8D00", Offset = "0x8D8D00")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8E3C", Offset = "0x8D8E3C")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D8E4C", Offset = "0x8D8E4C")]
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
				[Address(RVA = "0x1E8FA90", Offset = "0x1E8FA90", VA = "0x1E8FA90")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x1E8FF98", Offset = "0x1E8FF98", VA = "0x1E8FF98")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x1E8FFD8", Offset = "0x1E8FFD8", VA = "0x1E8FFD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x1E9002C", Offset = "0x1E9002C", VA = "0x1E9002C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x1E8FAD0", Offset = "0x1E8FAD0", VA = "0x1E8FAD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x1E9006C", Offset = "0x1E9006C", VA = "0x1E9006C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEBB8", Offset = "0x8DEBB8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x1E90080", Offset = "0x1E90080", VA = "0x1E90080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEBC8", Offset = "0x8DEBC8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x1E90094", Offset = "0x1E90094", VA = "0x1E90094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEBD8", Offset = "0x8DEBD8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x1E900A8", Offset = "0x1E900A8", VA = "0x1E900A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEBE8", Offset = "0x8DEBE8")]
				private set
				{
				}
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1E900BC", Offset = "0x1E900BC", VA = "0x1E900BC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1E90AC8", Offset = "0x1E90AC8", VA = "0x1E90AC8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1E90CD4", Offset = "0x1E90CD4", VA = "0x1E90CD4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1E91120", Offset = "0x1E91120", VA = "0x1E91120")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1E9155C", Offset = "0x1E9155C", VA = "0x1E9155C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x1E91CCC", Offset = "0x1E91CCC", VA = "0x1E91CCC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1E9234C", Offset = "0x1E9234C", VA = "0x1E9234C")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1E928D0", Offset = "0x1E928D0", VA = "0x1E928D0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x1E92AAC", Offset = "0x1E92AAC", VA = "0x1E92AAC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1E912B8", Offset = "0x1E912B8", VA = "0x1E912B8")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1E9209C", Offset = "0x1E9209C", VA = "0x1E9209C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1E91974", Offset = "0x1E91974", VA = "0x1E91974")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1E92B44", Offset = "0x1E92B44", VA = "0x1E92B44")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1E92178", Offset = "0x1E92178", VA = "0x1E92178")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1E91E48", Offset = "0x1E91E48", VA = "0x1E91E48")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x1E92D38", Offset = "0x1E92D38", VA = "0x1E92D38")]
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
			[Address(RVA = "0x1E89150", Offset = "0x1E89150", VA = "0x1E89150")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x1E891CC", Offset = "0x1E891CC", VA = "0x1E891CC")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x1E92EA8", Offset = "0x1E92EA8", VA = "0x1E92EA8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1E8B6C0", Offset = "0x1E8B6C0", VA = "0x1E8B6C0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x1E8B9EC", Offset = "0x1E8B9EC", VA = "0x1E8B9EC")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1E9302C", Offset = "0x1E9302C", VA = "0x1E9302C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1E8A67C", Offset = "0x1E8A67C", VA = "0x1E8A67C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1E9318C", Offset = "0x1E9318C", VA = "0x1E9318C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1E8ABBC", Offset = "0x1E8ABBC", VA = "0x1E8ABBC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1E93244", Offset = "0x1E93244", VA = "0x1E93244")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1E92540", Offset = "0x1E92540", VA = "0x1E92540")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1E933AC", Offset = "0x1E933AC", VA = "0x1E933AC")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1E9341C", Offset = "0x1E9341C", VA = "0x1E9341C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D78E0", Offset = "0x8D78E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D78E0", Offset = "0x8D78E0")]
		public int LOD;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7934", Offset = "0x8D7934")]
		public float scale;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D796C", Offset = "0x8D796C")]
		public bool plantFeet;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D79A4", Offset = "0x8D79A4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D79B4", Offset = "0x8D79B4")]
		public Spine spine;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D79EC", Offset = "0x8D79EC")]
		public Arm leftArm;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7A24", Offset = "0x8D7A24")]
		public Arm rightArm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7A5C", Offset = "0x8D7A5C")]
		public Leg leftLeg;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7A94", Offset = "0x8D7A94")]
		public Leg rightLeg;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D7ACC", Offset = "0x8D7ACC")]
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
			[Address(RVA = "0x1E2E464", Offset = "0x1E2E464", VA = "0x1E2E464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA58", Offset = "0x8DEA58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1E2E46C", Offset = "0x1E2E46C", VA = "0x1E2E46C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEA68", Offset = "0x8DEA68")]
			private set
			{
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1E2AC68", Offset = "0x1E2AC68", VA = "0x1E2AC68")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1E2B0CC", Offset = "0x1E2B0CC", VA = "0x1E2B0CC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1E2AF78", Offset = "0x1E2AF78", VA = "0x1E2AF78")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1E2B430", Offset = "0x1E2B430", VA = "0x1E2B430")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1E2B574", Offset = "0x1E2B574", VA = "0x1E2B574")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1E2B5A4", Offset = "0x1E2B5A4", VA = "0x1E2B5A4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1E2B654", Offset = "0x1E2B654", VA = "0x1E2B654")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1E2B73C", Offset = "0x1E2B73C", VA = "0x1E2B73C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1E2BEA4", Offset = "0x1E2BEA4", VA = "0x1E2BEA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1E2C014", Offset = "0x1E2C014", VA = "0x1E2C014", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1E2C218", Offset = "0x1E2C218", VA = "0x1E2C218", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1E2C294", Offset = "0x1E2C294", VA = "0x1E2C294", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1E2C310", Offset = "0x1E2C310", VA = "0x1E2C310", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1E2C4E8", Offset = "0x1E2C4E8", VA = "0x1E2C4E8")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1E2B310", Offset = "0x1E2B310", VA = "0x1E2B310")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1E2B830", Offset = "0x1E2B830", VA = "0x1E2B830")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1E2C6A8", Offset = "0x1E2C6A8", VA = "0x1E2C6A8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1E2C6F0", Offset = "0x1E2C6F0", VA = "0x1E2C6F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1E2DB94", Offset = "0x1E2DB94", VA = "0x1E2DB94")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1E2B994", Offset = "0x1E2B994", VA = "0x1E2B994")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1E2CA64", Offset = "0x1E2CA64", VA = "0x1E2CA64")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1E2DF44", Offset = "0x1E2DF44", VA = "0x1E2DF44")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1E2DF8C", Offset = "0x1E2DF8C", VA = "0x1E2DF8C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1E2DA44", Offset = "0x1E2DA44", VA = "0x1E2DA44")]
		private void Write()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1E2DFD0", Offset = "0x1E2DFD0", VA = "0x1E2DFD0")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1E2E474", Offset = "0x1E2E474", VA = "0x1E2E474")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8E5C", Offset = "0x8D8E5C")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1A92BD0", Offset = "0x1A92BD0", VA = "0x1A92BD0")]
		public void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1A93244", Offset = "0x1A93244", VA = "0x1A93244")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1A936D4", Offset = "0x1A936D4", VA = "0x1A936D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1A93798", Offset = "0x1A93798", VA = "0x1A93798")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1A938A4", Offset = "0x1A938A4", VA = "0x1A938A4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8E94", Offset = "0x8D8E94")]
		public Transform transform;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8ECC", Offset = "0x8D8ECC")]
		public Transform parent;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8F04", Offset = "0x8D8F04")]
		public Transform[] children;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8F3C", Offset = "0x8D8F3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8F3C", Offset = "0x8D8F3C")]
		public float weight;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8F90", Offset = "0x8D8F90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8F90", Offset = "0x8D8F90")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D8FE4", Offset = "0x8D8FE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D8FE4", Offset = "0x8D8FE4")]
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
		[Address(RVA = "0x1A93900", Offset = "0x1A93900", VA = "0x1A93900")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1A92D9C", Offset = "0x1A92D9C", VA = "0x1A92D9C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1A93308", Offset = "0x1A93308", VA = "0x1A93308")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9040", Offset = "0x8D9040")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9050", Offset = "0x8D9050")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D9060", Offset = "0x8D9060")]
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
			[Address(RVA = "0x1E2F238", Offset = "0x1E2F238", VA = "0x1E2F238")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEBF8", Offset = "0x8DEBF8")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1E2F240", Offset = "0x1E2F240", VA = "0x1E2F240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEC08", Offset = "0x8DEC08")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1E2F248", Offset = "0x1E2F248", VA = "0x1E2F248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEC18", Offset = "0x8DEC18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1E2F250", Offset = "0x1E2F250", VA = "0x1E2F250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEC28", Offset = "0x8DEC28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1E2F25C", Offset = "0x1E2F25C", VA = "0x1E2F25C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEC38", Offset = "0x8DEC38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1E2F264", Offset = "0x1E2F264", VA = "0x1E2F264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEC48", Offset = "0x8DEC48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1E2F26C", Offset = "0x1E2F26C", VA = "0x1E2F26C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1E30A40", Offset = "0x1E30A40", VA = "0x1E30A40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1E2F2D8", Offset = "0x1E2F2D8", VA = "0x1E2F2D8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1E2F364", Offset = "0x1E2F364", VA = "0x1E2F364")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1E2F3F8", Offset = "0x1E2F3F8", VA = "0x1E2F3F8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1E2F554", Offset = "0x1E2F554", VA = "0x1E2F554")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1E2F890", Offset = "0x1E2F890", VA = "0x1E2F890")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1E2F94C", Offset = "0x1E2F94C", VA = "0x1E2F94C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1E2F9A4", Offset = "0x1E2F9A4", VA = "0x1E2F9A4")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1E2FDD4", Offset = "0x1E2FDD4", VA = "0x1E2FDD4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1E3041C", Offset = "0x1E3041C", VA = "0x1E3041C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1E30660", Offset = "0x1E30660", VA = "0x1E30660")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1E308E8", Offset = "0x1E308E8", VA = "0x1E308E8")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1E30A7C", Offset = "0x1E30A7C", VA = "0x1E30A7C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9070", Offset = "0x8D9070")]
		public LookAtIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D90A8", Offset = "0x8D90A8")]
		public float lerpSpeed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D90E0", Offset = "0x8D90E0")]
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
		[Address(RVA = "0x1E30CA8", Offset = "0x1E30CA8", VA = "0x1E30CA8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1E30DC4", Offset = "0x1E30DC4", VA = "0x1E30DC4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1E30E68", Offset = "0x1E30E68", VA = "0x1E30E68")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1E31060", Offset = "0x1E31060", VA = "0x1E31060")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1E31154", Offset = "0x1E31154", VA = "0x1E31154")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1E3121C", Offset = "0x1E3121C", VA = "0x1E3121C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D505C", Offset = "0x8D505C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D505C", Offset = "0x8D505C")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class InteractionEvent
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D91F0", Offset = "0x8D91F0")]
			public float time;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9228", Offset = "0x8D9228")]
			public bool pause;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9260", Offset = "0x8D9260")]
			public bool pickUp;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9298", Offset = "0x8D9298")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D92D0", Offset = "0x8D92D0")]
			public Message[] messages;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9308", Offset = "0x8D9308")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1E93BC8", Offset = "0x1E93BC8", VA = "0x1E93BC8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x1E93D9C", Offset = "0x1E93D9C", VA = "0x1E93D9C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9340", Offset = "0x8D9340")]
			public string function;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9378", Offset = "0x8D9378")]
			public GameObject recipient;

			[Token(Token = "0x4000467")]
			private const string empty = "";

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1E93C98", Offset = "0x1E93C98", VA = "0x1E93C98")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1E93DA4", Offset = "0x1E93DA4", VA = "0x1E93DA4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D93B0", Offset = "0x8D93B0")]
			public Animator animator;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D93E8", Offset = "0x8D93E8")]
			public Animation animation;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9420", Offset = "0x8D9420")]
			public string animationState;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9458", Offset = "0x8D9458")]
			public float crossfadeTime;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9490", Offset = "0x8D9490")]
			public int layer;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D94C8", Offset = "0x8D94C8")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400046E")]
			private const string empty = "";

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x1E93934", Offset = "0x1E93934", VA = "0x1E93934")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1E93A24", Offset = "0x1E93A24", VA = "0x1E93A24")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x1E93AD8", Offset = "0x1E93AD8", VA = "0x1E93AD8")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x1E93BB4", Offset = "0x1E93BB4", VA = "0x1E93BB4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9500", Offset = "0x8D9500")]
			public Type type;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9538", Offset = "0x8D9538")]
			public AnimationCurve curve;

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x1E93DE8", Offset = "0x1E93DE8", VA = "0x1E93DE8")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x1E93E14", Offset = "0x1E93E14", VA = "0x1E93E14")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9570", Offset = "0x8D9570")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D95A8", Offset = "0x8D95A8")]
			public float multiplier;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D95E0", Offset = "0x8D95E0")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x1E93DAC", Offset = "0x1E93DAC", VA = "0x1E93DAC")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x1E93E04", Offset = "0x1E93E04", VA = "0x1E93E04")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9128", Offset = "0x8D9128")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9160", Offset = "0x8D9160")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9198", Offset = "0x8D9198")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D91D0", Offset = "0x8D91D0")]
		private float <length>k__BackingField;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D91E0", Offset = "0x8D91E0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1B960C8", Offset = "0x1B960C8", VA = "0x1B960C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEE18", Offset = "0x8DEE18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1B960D0", Offset = "0x1B960D0", VA = "0x1B960D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEE28", Offset = "0x8DEE28")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1B960D8", Offset = "0x1B960D8", VA = "0x1B960D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEE38", Offset = "0x8DEE38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1B960E0", Offset = "0x1B960E0", VA = "0x1B960E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DEE48", Offset = "0x8DEE48")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x1B96334", Offset = "0x1B96334", VA = "0x1B96334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1B962A8", Offset = "0x1B962A8", VA = "0x1B962A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1B95E88", Offset = "0x1B95E88", VA = "0x1B95E88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEC58", Offset = "0x8DEC58")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1B95ED0", Offset = "0x1B95ED0", VA = "0x1B95ED0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEC90", Offset = "0x8DEC90")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1B95F18", Offset = "0x1B95F18", VA = "0x1B95F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DECC8", Offset = "0x8DECC8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1B95F60", Offset = "0x1B95F60", VA = "0x1B95F60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DED00", Offset = "0x8DED00")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1B95FA8", Offset = "0x1B95FA8", VA = "0x1B95FA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DED38", Offset = "0x8DED38")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1B95FF0", Offset = "0x1B95FF0", VA = "0x1B95FF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DED70", Offset = "0x8DED70")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1B96038", Offset = "0x1B96038", VA = "0x1B96038")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEDA8", Offset = "0x8DEDA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1B96080", Offset = "0x1B96080", VA = "0x1B96080")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEDE0", Offset = "0x8DEDE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1B960E8", Offset = "0x1B960E8", VA = "0x1B960E8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1B963C0", Offset = "0x1B963C0", VA = "0x1B963C0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1B9652C", Offset = "0x1B9652C", VA = "0x1B9652C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1B965E0", Offset = "0x1B965E0", VA = "0x1B965E0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1B965E8", Offset = "0x1B965E8", VA = "0x1B965E8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1B9679C", Offset = "0x1B9679C", VA = "0x1B9679C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1B967A4", Offset = "0x1B967A4", VA = "0x1B967A4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1B9716C", Offset = "0x1B9716C", VA = "0x1B9716C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1B9738C", Offset = "0x1B9738C", VA = "0x1B9738C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1B96C70", Offset = "0x1B96C70", VA = "0x1B96C70")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1B9672C", Offset = "0x1B9672C", VA = "0x1B9672C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1B97104", Offset = "0x1B97104", VA = "0x1B97104")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1B97390", Offset = "0x1B97390", VA = "0x1B97390")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1B973F8", Offset = "0x1B973F8", VA = "0x1B973F8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D50BC", Offset = "0x8D50BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D50BC", Offset = "0x8D50BC")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9618", Offset = "0x8D9618")]
		public string targetTag;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9650", Offset = "0x8D9650")]
		public float fadeInTime;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9688", Offset = "0x8D9688")]
		public float speed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D96C0", Offset = "0x8D96C0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8D96F8", Offset = "0x8D96F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D96F8", Offset = "0x8D96F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8D96F8", Offset = "0x8D96F8")]
		public Collider characterCollider;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x8D977C", Offset = "0x8D977C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D977C", Offset = "0x8D977C")]
		public Transform FPSCamera;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D97DC", Offset = "0x8D97DC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9814", Offset = "0x8D9814")]
		public float camRaycastDistance;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D984C", Offset = "0x8D984C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D985C", Offset = "0x8D985C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8D985C", Offset = "0x8D985C")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D98BC", Offset = "0x8D98BC")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D98F4", Offset = "0x8D98F4")]
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
			[Address(RVA = "0x1B97694", Offset = "0x1B97694", VA = "0x1B97694")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x1B99338", Offset = "0x1B99338", VA = "0x1B99338")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x1B99340", Offset = "0x1B99340", VA = "0x1B99340")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x1B99348", Offset = "0x1B99348", VA = "0x1B99348")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF018", Offset = "0x8DF018")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x1B99350", Offset = "0x1B99350", VA = "0x1B99350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF028", Offset = "0x8DF028")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x1B99358", Offset = "0x1B99358", VA = "0x1B99358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF038", Offset = "0x8DF038")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x1B99360", Offset = "0x1B99360", VA = "0x1B99360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF048", Offset = "0x8DF048")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1B97454", Offset = "0x1B97454", VA = "0x1B97454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEE58", Offset = "0x8DEE58")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1B9749C", Offset = "0x1B9749C", VA = "0x1B9749C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEE90", Offset = "0x8DEE90")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1B974E4", Offset = "0x1B974E4", VA = "0x1B974E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEEC8", Offset = "0x8DEEC8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1B9752C", Offset = "0x1B9752C", VA = "0x1B9752C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEF00", Offset = "0x8DEF00")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1B97574", Offset = "0x1B97574", VA = "0x1B97574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEF38", Offset = "0x8DEF38")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1B975BC", Offset = "0x1B975BC", VA = "0x1B975BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEF70", Offset = "0x8DEF70")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1B97604", Offset = "0x1B97604", VA = "0x1B97604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEFA8", Offset = "0x8DEFA8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1B9764C", Offset = "0x1B9764C", VA = "0x1B9764C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DEFE0", Offset = "0x8DEFE0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1B9783C", Offset = "0x1B9783C", VA = "0x1B9783C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1B9790C", Offset = "0x1B9790C", VA = "0x1B9790C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1B979DC", Offset = "0x1B979DC", VA = "0x1B979DC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1B97A8C", Offset = "0x1B97A8C", VA = "0x1B97A8C")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1B97B88", Offset = "0x1B97B88", VA = "0x1B97B88")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1B97CA4", Offset = "0x1B97CA4", VA = "0x1B97CA4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1B97D38", Offset = "0x1B97D38", VA = "0x1B97D38")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1B97DCC", Offset = "0x1B97DCC", VA = "0x1B97DCC")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1B97E60", Offset = "0x1B97E60", VA = "0x1B97E60")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1B97ED8", Offset = "0x1B97ED8", VA = "0x1B97ED8")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1B97F50", Offset = "0x1B97F50", VA = "0x1B97F50")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1B97FBC", Offset = "0x1B97FBC", VA = "0x1B97FBC")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1B98048", Offset = "0x1B98048", VA = "0x1B98048")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1B980DC", Offset = "0x1B980DC", VA = "0x1B980DC")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1B981A8", Offset = "0x1B981A8", VA = "0x1B981A8")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1B98480", Offset = "0x1B98480", VA = "0x1B98480")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1B98660", Offset = "0x1B98660", VA = "0x1B98660")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1B988F4", Offset = "0x1B988F4", VA = "0x1B988F4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1B98BCC", Offset = "0x1B98BCC", VA = "0x1B98BCC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1B98C10", Offset = "0x1B98C10", VA = "0x1B98C10")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1B98C88", Offset = "0x1B98C88", VA = "0x1B98C88")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1B98DA4", Offset = "0x1B98DA4", VA = "0x1B98DA4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1B98F48", Offset = "0x1B98F48", VA = "0x1B98F48")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1B991EC", Offset = "0x1B991EC", VA = "0x1B991EC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1B98A08", Offset = "0x1B98A08", VA = "0x1B98A08")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1B9936C", Offset = "0x1B9936C", VA = "0x1B9936C")]
		public void Start()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1B99ADC", Offset = "0x1B99ADC", VA = "0x1B99ADC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1B99AFC", Offset = "0x1B99AFC", VA = "0x1B99AFC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1B99B18", Offset = "0x1B99B18", VA = "0x1B99B18")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1B99B34", Offset = "0x1B99B34", VA = "0x1B99B34")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1B99B98", Offset = "0x1B99B98", VA = "0x1B99B98")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1B99CD4", Offset = "0x1B99CD4", VA = "0x1B99CD4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1B99DE4", Offset = "0x1B99DE4", VA = "0x1B99DE4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1B9A188", Offset = "0x1B9A188", VA = "0x1B9A188")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1B9A288", Offset = "0x1B9A288", VA = "0x1B9A288")]
		public void Update()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1B9A4E8", Offset = "0x1B9A4E8", VA = "0x1B9A4E8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1B99840", Offset = "0x1B99840", VA = "0x1B99840")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1B9A624", Offset = "0x1B9A624", VA = "0x1B9A624")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1B9A754", Offset = "0x1B9A754", VA = "0x1B9A754")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1B9A7EC", Offset = "0x1B9A7EC", VA = "0x1B9A7EC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1B9A8C8", Offset = "0x1B9A8C8", VA = "0x1B9A8C8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1B9A8E4", Offset = "0x1B9A8E4", VA = "0x1B9A8E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1B97744", Offset = "0x1B97744", VA = "0x1B97744")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1B98350", Offset = "0x1B98350", VA = "0x1B98350")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1B9AC4C", Offset = "0x1B9AC4C", VA = "0x1B9AC4C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D511C", Offset = "0x8D511C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D511C", Offset = "0x8D511C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9B50", Offset = "0x8D9B50")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9B88", Offset = "0x8D9B88")]
			public float multiplier;

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1E94480", Offset = "0x1E94480", VA = "0x1E94480")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9904", Offset = "0x8D9904")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D993C", Offset = "0x8D993C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9974", Offset = "0x8D9974")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D99AC", Offset = "0x8D99AC")]
		public Transform pivot;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D99E4", Offset = "0x8D99E4")]
		public RotationMode rotationMode;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9A1C", Offset = "0x8D9A1C")]
		public Vector3 twistAxis;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9A54", Offset = "0x8D9A54")]
		public float twistWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9A8C", Offset = "0x8D9A8C")]
		public float swingWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9AC4", Offset = "0x8D9AC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9AC4", Offset = "0x8D9AC4")]
		public float threeDOFWeight;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9B18", Offset = "0x8D9B18")]
		public bool rotateOnce;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1B9B39C", Offset = "0x1B9B39C", VA = "0x1B9B39C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF058", Offset = "0x8DF058")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1B9B3E4", Offset = "0x1B9B3E4", VA = "0x1B9B3E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF090", Offset = "0x8DF090")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1B9B42C", Offset = "0x1B9B42C", VA = "0x1B9B42C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF0C8", Offset = "0x8DF0C8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1B9B474", Offset = "0x1B9B474", VA = "0x1B9B474")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF100", Offset = "0x8DF100")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1B9B4BC", Offset = "0x1B9B4BC", VA = "0x1B9B4BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF138", Offset = "0x8DF138")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1B9B504", Offset = "0x1B9B504", VA = "0x1B9B504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF170", Offset = "0x8DF170")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1B9B54C", Offset = "0x1B9B54C", VA = "0x1B9B54C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF1A8", Offset = "0x8DF1A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1B9B594", Offset = "0x1B9B594", VA = "0x1B9B594")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF1E0", Offset = "0x8DF1E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1B96C00", Offset = "0x1B96C00", VA = "0x1B96C00")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1B9B5DC", Offset = "0x1B9B5DC", VA = "0x1B9B5DC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1B9B674", Offset = "0x1B9B674", VA = "0x1B9B674")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1B9BD3C", Offset = "0x1B9BD3C", VA = "0x1B9BD3C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D517C", Offset = "0x8D517C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D517C", Offset = "0x8D517C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9BF8", Offset = "0x8D9BF8")]
			public bool use;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9C30", Offset = "0x8D9C30")]
			public Vector2 offset;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9C68", Offset = "0x8D9C68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9C68", Offset = "0x8D9C68")]
			public float angleOffset;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9CC4", Offset = "0x8D9CC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9CC4", Offset = "0x8D9CC4")]
			public float maxAngle;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9D1C", Offset = "0x8D9D1C")]
			public float radius;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9D54", Offset = "0x8D9D54")]
			public bool orbit;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9D8C", Offset = "0x8D9D8C")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x1E947F0", Offset = "0x1E947F0", VA = "0x1E947F0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600054A")]
				[Address(RVA = "0x1E947FC", Offset = "0x1E947FC", VA = "0x1E947FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1E94884", Offset = "0x1E94884", VA = "0x1E94884")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1E94CC8", Offset = "0x1E94CC8", VA = "0x1E94CC8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9DC4", Offset = "0x8D9DC4")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9DFC", Offset = "0x8D9DFC")]
			public Vector3 direction;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9E34", Offset = "0x8D9E34")]
			public float maxDistance;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8D9E6C", Offset = "0x8D9E6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9E6C", Offset = "0x8D9E6C")]
			public float maxAngle;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9EC4", Offset = "0x8D9EC4")]
			public bool fixYAxis;

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x1E94488", Offset = "0x1E94488", VA = "0x1E94488")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1E9457C", Offset = "0x1E9457C", VA = "0x1E9457C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x1E947A4", Offset = "0x1E947A4", VA = "0x1E947A4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9FC4", Offset = "0x8D9FC4")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9FFC", Offset = "0x8D9FFC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000552")]
				[Address(RVA = "0x2144E98", Offset = "0x2144E98", VA = "0x2144E98")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9F1C", Offset = "0x8D9F1C")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9F54", Offset = "0x8D9F54")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9F8C", Offset = "0x8D9F8C")]
			public Interaction[] interactions;

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x1E94CDC", Offset = "0x1E94CDC", VA = "0x1E94CDC")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1E94D90", Offset = "0x1E94D90", VA = "0x1E94D90")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8D9BC0", Offset = "0x8D9BC0")]
		public Range[] ranges;

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1B9BD88", Offset = "0x1B9BD88", VA = "0x1B9BD88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF218", Offset = "0x8DF218")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1B9BDD0", Offset = "0x1B9BDD0", VA = "0x1B9BDD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF250", Offset = "0x8DF250")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1B9BE18", Offset = "0x1B9BE18", VA = "0x1B9BE18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF288", Offset = "0x8DF288")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1B9BE60", Offset = "0x1B9BE60", VA = "0x1B9BE60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF2C0", Offset = "0x8DF2C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1B9BEA8", Offset = "0x1B9BEA8", VA = "0x1B9BEA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF2F8", Offset = "0x8DF2F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1B99FB4", Offset = "0x1B99FB4", VA = "0x1B99FB4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1B9BEF0", Offset = "0x1B9BEF0", VA = "0x1B9BEF0")]
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
			[Address(RVA = "0x1A9B844", Offset = "0x1A9B844", VA = "0x1A9B844")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1A9B880", Offset = "0x1A9B880", VA = "0x1A9B880")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x1A9B8D0", Offset = "0x1A9B8D0", VA = "0x1A9B8D0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x1A9B91C", Offset = "0x1A9B91C", VA = "0x1A9B91C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1DA7594", Offset = "0x1DA7594", VA = "0x1DA7594", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF330", Offset = "0x8DF330")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1DA7910", Offset = "0x1DA7910", VA = "0x1DA7910", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1DA7914", Offset = "0x1DA7914", VA = "0x1DA7914", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1DA7A1C", Offset = "0x1DA7A1C", VA = "0x1DA7A1C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1DA78A4", Offset = "0x1DA78A4", VA = "0x1DA78A4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1DA7804", Offset = "0x1DA7804", VA = "0x1DA7804")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1DA7A88", Offset = "0x1DA7A88", VA = "0x1DA7A88")]
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
		[Address(RVA = "0x1E10F34", Offset = "0x1E10F34", VA = "0x1E10F34", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1E10FFC", Offset = "0x1E10FFC", VA = "0x1E10FFC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1E111B8", Offset = "0x1E111B8", VA = "0x1E111B8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1E112B4", Offset = "0x1E112B4", VA = "0x1E112B4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1E11054", Offset = "0x1E11054", VA = "0x1E11054")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1E11614", Offset = "0x1E11614", VA = "0x1E11614")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA034", Offset = "0x8DA034")]
		public float weight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA04C", Offset = "0x8DA04C")]
		public float localRotationWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA064", Offset = "0x8DA064")]
		public float localPositionWeight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000564")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1BA3724", Offset = "0x1BA3724", VA = "0x1BA3724")]
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
		[Address(RVA = "0x1BA3730", Offset = "0x1BA3730", VA = "0x1BA3730", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1BA3784", Offset = "0x1BA3784", VA = "0x1BA3784", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1BA37C0", Offset = "0x1BA37C0", VA = "0x1BA37C0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1BA37D8", Offset = "0x1BA37D8", VA = "0x1BA37D8")]
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
			[Address(RVA = "0x1E96D00", Offset = "0x1E96D00", VA = "0x1E96D00")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x1E96E70", Offset = "0x1E96E70", VA = "0x1E96E70")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1E96F50", Offset = "0x1E96F50", VA = "0x1E96F50")]
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
			[Address(RVA = "0x1E96B10", Offset = "0x1E96B10", VA = "0x1E96B10")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1E96B70", Offset = "0x1E96B70", VA = "0x1E96B70")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1E96CB0", Offset = "0x1E96CB0", VA = "0x1E96CB0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D51DC", Offset = "0x8D51DC")]
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
				[Address(RVA = "0x1E96AC0", Offset = "0x1E96AC0", VA = "0x1E96AC0", Slot = "4")]
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
				[Address(RVA = "0x1E96B08", Offset = "0x1E96B08", VA = "0x1E96B08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x1E968A4", Offset = "0x1E968A4", VA = "0x1E968A4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1E968D0", Offset = "0x1E968D0", VA = "0x1E968D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1E968D4", Offset = "0x1E968D4", VA = "0x1E968D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1E96AC8", Offset = "0x1E96AC8", VA = "0x1E96AC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA07C", Offset = "0x8DA07C")]
		public IK ik;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA0B4", Offset = "0x8DA0B4")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA0EC", Offset = "0x8DA0EC")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA124", Offset = "0x8DA124")]
		public float applyVelocity;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA15C", Offset = "0x8DA15C")]
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
			[Address(RVA = "0x1BA44AC", Offset = "0x1BA44AC", VA = "0x1BA44AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1BA4E34", Offset = "0x1BA4E34", VA = "0x1BA4E34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1BA4474", Offset = "0x1BA4474", VA = "0x1BA4474")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1BA4524", Offset = "0x1BA4524", VA = "0x1BA4524")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1BA4654", Offset = "0x1BA4654", VA = "0x1BA4654")]
		public void Start()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1BA45E8", Offset = "0x1BA45E8", VA = "0x1BA45E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DF368", Offset = "0x8DF368")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1BA4A70", Offset = "0x1BA4A70", VA = "0x1BA4A70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1BA4CBC", Offset = "0x1BA4CBC", VA = "0x1BA4CBC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1BA4D78", Offset = "0x1BA4D78", VA = "0x1BA4D78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1BA4FB4", Offset = "0x1BA4FB4", VA = "0x1BA4FB4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1BA4DF8", Offset = "0x1BA4DF8", VA = "0x1BA4DF8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1BA4F70", Offset = "0x1BA4F70", VA = "0x1BA4F70")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1BA5054", Offset = "0x1BA5054", VA = "0x1BA5054")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1BA4FE8", Offset = "0x1BA4FE8", VA = "0x1BA4FE8")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1BA457C", Offset = "0x1BA457C", VA = "0x1BA457C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1BA4CFC", Offset = "0x1BA4CFC", VA = "0x1BA4CFC")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1BA5280", Offset = "0x1BA5280", VA = "0x1BA5280")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1BA5398", Offset = "0x1BA5398", VA = "0x1BA5398")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DA1A4", Offset = "0x8DA1A4")]
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
			[Address(RVA = "0x1BA6AB4", Offset = "0x1BA6AB4", VA = "0x1BA6AB4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1BA6AC0", Offset = "0x1BA6AC0", VA = "0x1BA6AC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x1BA6ADC", Offset = "0x1BA6ADC", VA = "0x1BA6ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF418", Offset = "0x8DF418")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x1BA6AE4", Offset = "0x1BA6AE4", VA = "0x1BA6AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF428", Offset = "0x8DF428")]
			private set
			{
			}
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1BA67B4", Offset = "0x1BA67B4", VA = "0x1BA67B4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1BA67FC", Offset = "0x1BA67FC", VA = "0x1BA67FC")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1BA6814", Offset = "0x1BA6814", VA = "0x1BA6814")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1BA6A0C", Offset = "0x1BA6A0C", VA = "0x1BA6A0C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1BA6A7C", Offset = "0x1BA6A7C", VA = "0x1BA6A7C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000594")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1BA6934", Offset = "0x1BA6934", VA = "0x1BA6934")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1BA6AF0", Offset = "0x1BA6AF0", VA = "0x1BA6AF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1BA6AF4", Offset = "0x1BA6AF4", VA = "0x1BA6AF4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1BA6B28", Offset = "0x1BA6B28", VA = "0x1BA6B28")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1BA6BA4", Offset = "0x1BA6BA4", VA = "0x1BA6BA4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1BA6D38", Offset = "0x1BA6D38", VA = "0x1BA6D38")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1BA6DA8", Offset = "0x1BA6DA8", VA = "0x1BA6DA8")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D51EC", Offset = "0x8D51EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D51EC", Offset = "0x8D51EC")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA1B4", Offset = "0x8DA1B4")]
		public float limit;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA1D0", Offset = "0x8DA1D0")]
		public float twistLimit;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1BA6DDC", Offset = "0x1BA6DDC", VA = "0x1BA6DDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF438", Offset = "0x8DF438")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1BA6E24", Offset = "0x1BA6E24", VA = "0x1BA6E24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF470", Offset = "0x8DF470")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1BA6E6C", Offset = "0x1BA6E6C", VA = "0x1BA6E6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF4A8", Offset = "0x8DF4A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1BA6EB4", Offset = "0x1BA6EB4", VA = "0x1BA6EB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF4E0", Offset = "0x8DF4E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1BA6EFC", Offset = "0x1BA6EFC", VA = "0x1BA6EFC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1BA6F40", Offset = "0x1BA6F40", VA = "0x1BA6F40")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1BA7100", Offset = "0x1BA7100", VA = "0x1BA7100")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D524C", Offset = "0x8D524C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D524C", Offset = "0x8D524C")]
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
		[Address(RVA = "0x1BA7140", Offset = "0x1BA7140", VA = "0x1BA7140")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF518", Offset = "0x8DF518")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1BA7188", Offset = "0x1BA7188", VA = "0x1BA7188")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF550", Offset = "0x8DF550")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1BA71D0", Offset = "0x1BA71D0", VA = "0x1BA71D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF588", Offset = "0x8DF588")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1BA7218", Offset = "0x1BA7218", VA = "0x1BA7218")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF5C0", Offset = "0x8DF5C0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1BA7260", Offset = "0x1BA7260", VA = "0x1BA7260", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1BA7264", Offset = "0x1BA7264", VA = "0x1BA7264")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1BA73E8", Offset = "0x1BA73E8", VA = "0x1BA73E8")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D52AC", Offset = "0x8D52AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D52AC", Offset = "0x8D52AC")]
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
				[Address(RVA = "0x1E97584", Offset = "0x1E97584", VA = "0x1E97584")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x1E975BC", Offset = "0x1E975BC", VA = "0x1E975BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x1E975F8", Offset = "0x1E975F8", VA = "0x1E975F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x1E97634", Offset = "0x1E97634", VA = "0x1E97634")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x1E977AC", Offset = "0x1E977AC", VA = "0x1E977AC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x1E97670", Offset = "0x1E97670", VA = "0x1E97670")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x1E977BC", Offset = "0x1E977BC", VA = "0x1E977BC")]
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
			[Address(RVA = "0x1E97548", Offset = "0x1E97548", VA = "0x1E97548")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA1FC", Offset = "0x8DA1FC")]
		public float twistLimit;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA218", Offset = "0x8DA218")]
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
		[Address(RVA = "0x1BA7430", Offset = "0x1BA7430", VA = "0x1BA7430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF5F8", Offset = "0x8DF5F8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1BA7478", Offset = "0x1BA7478", VA = "0x1BA7478")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF630", Offset = "0x8DF630")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1BA74C0", Offset = "0x1BA74C0", VA = "0x1BA74C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF668", Offset = "0x8DF668")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1BA7508", Offset = "0x1BA7508", VA = "0x1BA7508")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF6A0", Offset = "0x8DF6A0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1BA7550", Offset = "0x1BA7550", VA = "0x1BA7550")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1BA79F0", Offset = "0x1BA79F0", VA = "0x1BA79F0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1BA7A84", Offset = "0x1BA7A84", VA = "0x1BA7A84")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1BA7FB0", Offset = "0x1BA7FB0", VA = "0x1BA7FB0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1BA75EC", Offset = "0x1BA75EC", VA = "0x1BA75EC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1BA8330", Offset = "0x1BA8330", VA = "0x1BA8330")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1BA873C", Offset = "0x1BA873C", VA = "0x1BA873C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1BA8780", Offset = "0x1BA8780", VA = "0x1BA8780")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1BA87E0", Offset = "0x1BA87E0", VA = "0x1BA87E0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1BA7D40", Offset = "0x1BA7D40", VA = "0x1BA7D40")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1BA884C", Offset = "0x1BA884C", VA = "0x1BA884C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1BA8928", Offset = "0x1BA8928", VA = "0x1BA8928")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x8D530C", Offset = "0x8D530C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8D530C", Offset = "0x8D530C")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA260", Offset = "0x8DA260")]
		public float twistLimit;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1A90024", Offset = "0x1A90024", VA = "0x1A90024")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF6D8", Offset = "0x8DF6D8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1A9006C", Offset = "0x1A9006C", VA = "0x1A9006C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF710", Offset = "0x8DF710")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1A900B4", Offset = "0x1A900B4", VA = "0x1A900B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF748", Offset = "0x8DF748")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1A900FC", Offset = "0x1A900FC", VA = "0x1A900FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8DF780", Offset = "0x8DF780")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1A90144", Offset = "0x1A90144", VA = "0x1A90144")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1A90160", Offset = "0x1A90160", VA = "0x1A90160", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1A90200", Offset = "0x1A90200", VA = "0x1A90200")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1A9043C", Offset = "0x1A9043C", VA = "0x1A9043C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D536C", Offset = "0x8D536C")]
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
				[Address(RVA = "0x1A9A97C", Offset = "0x1A9A97C", VA = "0x1A9A97C", Slot = "4")]
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
				[Address(RVA = "0x1A9A9C4", Offset = "0x1A9A9C4", VA = "0x1A9A9C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1A9A88C", Offset = "0x1A9A88C", VA = "0x1A9A88C")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1A9A8B8", Offset = "0x1A9A8B8", VA = "0x1A9A8B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1A9A8BC", Offset = "0x1A9A8BC", VA = "0x1A9A8BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1A9A984", Offset = "0x1A9A984", VA = "0x1A9A984", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA28C", Offset = "0x8DA28C")]
		public AimIK ik;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA2C4", Offset = "0x8DA2C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA2C4", Offset = "0x8DA2C4")]
		public float weight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA318", Offset = "0x8DA318")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DA318", Offset = "0x8DA318")]
		public Transform target;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA378", Offset = "0x8DA378")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA3B0", Offset = "0x8DA3B0")]
		public float weightSmoothTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DA3E8", Offset = "0x8DA3E8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA3E8", Offset = "0x8DA3E8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA448", Offset = "0x8DA448")]
		public float maxRadiansDelta;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA480", Offset = "0x8DA480")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA4B8", Offset = "0x8DA4B8")]
		public float slerpSpeed;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA4F0", Offset = "0x8DA4F0")]
		public float smoothDampTime;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA528", Offset = "0x8DA528")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA560", Offset = "0x8DA560")]
		public float minDistance;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA598", Offset = "0x8DA598")]
		public Vector3 offset;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DA5D0", Offset = "0x8DA5D0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DA5D0", Offset = "0x8DA5D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA5D0", Offset = "0x8DA5D0")]
		public float maxRootAngle;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA64C", Offset = "0x8DA64C")]
		public bool turnToTarget;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA684", Offset = "0x8DA684")]
		public float turnToTargetTime;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DA6BC", Offset = "0x8DA6BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA6BC", Offset = "0x8DA6BC")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA71C", Offset = "0x8DA71C")]
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
			[Address(RVA = "0x1D191F4", Offset = "0x1D191F4", VA = "0x1D191F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1D1916C", Offset = "0x1D1916C", VA = "0x1D1916C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1D19284", Offset = "0x1D19284", VA = "0x1D19284")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1D19958", Offset = "0x1D19958", VA = "0x1D19958")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1D19A44", Offset = "0x1D19A44", VA = "0x1D19A44")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1D19C94", Offset = "0x1D19C94", VA = "0x1D19C94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DF7B8", Offset = "0x8DF7B8")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1D19D00", Offset = "0x1D19D00", VA = "0x1D19D00")]
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
			[Address(RVA = "0x1A9A9CC", Offset = "0x1A9A9CC", VA = "0x1A9A9CC")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1A9AB58", Offset = "0x1A9AB58", VA = "0x1A9AB58")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1A9AB60", Offset = "0x1A9AB60", VA = "0x1A9AB60")]
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
		[Address(RVA = "0x1D19F64", Offset = "0x1D19F64", VA = "0x1D19F64")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1D1A044", Offset = "0x1D1A044", VA = "0x1D1A044")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1D1A0B0", Offset = "0x1D1A0B0", VA = "0x1D1A0B0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA8DC", Offset = "0x8DA8DC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA914", Offset = "0x8DA914")]
				public float weight;

				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x2144A7C", Offset = "0x2144A7C", VA = "0x2144A7C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA78C", Offset = "0x8DA78C")]
			public Transform transform;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA7C4", Offset = "0x8DA7C4")]
			public Transform relativeTo;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA7FC", Offset = "0x8DA7FC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA834", Offset = "0x8DA834")]
			public float verticalWeight;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA86C", Offset = "0x8DA86C")]
			public float horizontalWeight;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA8A4", Offset = "0x8DA8A4")]
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
			[Address(RVA = "0x1A9AB7C", Offset = "0x1A9AB7C", VA = "0x1A9AB7C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1A9AEA0", Offset = "0x1A9AEA0", VA = "0x1A9AEA0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1A9AEB0", Offset = "0x1A9AEB0", VA = "0x1A9AEB0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA754", Offset = "0x8DA754")]
		public Body[] bodies;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1D1A1C0", Offset = "0x1D1A1C0", VA = "0x1D1A1C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1D1A30C", Offset = "0x1D1A30C", VA = "0x1D1A30C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA94C", Offset = "0x8DA94C")]
		public float tiltSpeed;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA984", Offset = "0x8DA984")]
		public float tiltSensitivity;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA9BC", Offset = "0x8DA9BC")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DA9F4", Offset = "0x8DA9F4")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1D27664", Offset = "0x1D27664", VA = "0x1D27664", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1D276AC", Offset = "0x1D276AC", VA = "0x1D276AC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1D27864", Offset = "0x1D27864", VA = "0x1D27864")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DAA2C", Offset = "0x8DAA2C")]
		public float weight;

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1D27878", Offset = "0x1D27878", VA = "0x1D27878")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1D27940", Offset = "0x1D27940", VA = "0x1D27940")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1D27B68", Offset = "0x1D27B68", VA = "0x1D27B68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1D27C74", Offset = "0x1D27C74", VA = "0x1D27C74")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAA44", Offset = "0x8DAA44")]
		public Animator animator;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAA7C", Offset = "0x8DAA7C")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAAC4", Offset = "0x8DAAC4")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009F")]
		public IK ik
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1D9C100", Offset = "0x1D9C100", VA = "0x1D9C100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF868", Offset = "0x8DF868")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1D9C108", Offset = "0x1D9C108", VA = "0x1D9C108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF878", Offset = "0x8DF878")]
			private set
			{
			}
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1D9C110", Offset = "0x1D9C110", VA = "0x1D9C110")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1D9C2AC", Offset = "0x1D9C2AC", VA = "0x1D9C2AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1D9C538", Offset = "0x1D9C538", VA = "0x1D9C538")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1D9C680", Offset = "0x1D9C680", VA = "0x1D9C680")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1D9C84C", Offset = "0x1D9C84C", VA = "0x1D9C84C")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1D9CA7C", Offset = "0x1D9CA7C", VA = "0x1D9CA7C")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1D9CD18", Offset = "0x1D9CD18", VA = "0x1D9CD18")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x8D538C", Offset = "0x8D538C")]
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
			[Address(RVA = "0x1D9C3A4", Offset = "0x1D9C3A4", VA = "0x1D9C3A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1D9C6F8", Offset = "0x1D9C6F8", VA = "0x1D9C6F8")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1D9C3C8", Offset = "0x1D9C3C8", VA = "0x1D9C3C8")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1D9CD74", Offset = "0x1D9CD74", VA = "0x1D9CD74")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAB44", Offset = "0x8DAB44")]
			public string name;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAB7C", Offset = "0x8DAB7C")]
			public Collider collider;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DABB4", Offset = "0x8DABB4")]
			private float crossFadeTime;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAC00", Offset = "0x8DAC00")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAC10", Offset = "0x8DAC10")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAC20", Offset = "0x8DAC20")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAC30", Offset = "0x8DAC30")]
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
				[Address(RVA = "0x1A9D568", Offset = "0x1A9D568", VA = "0x1A9D568")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A3")]
			protected float crossFader
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x1A9D57C", Offset = "0x1A9D57C", VA = "0x1A9D57C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF888", Offset = "0x8DF888")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x1A9D584", Offset = "0x1A9D584", VA = "0x1A9D584")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF898", Offset = "0x8DF898")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected float timer
			{
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x1A9D58C", Offset = "0x1A9D58C", VA = "0x1A9D58C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF8A8", Offset = "0x8DF8A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x1A9D594", Offset = "0x1A9D594", VA = "0x1A9D594")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF8B8", Offset = "0x8DF8B8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected Vector3 force
			{
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x1A9D59C", Offset = "0x1A9D59C", VA = "0x1A9D59C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF8C8", Offset = "0x8DF8C8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x1A9D5A8", Offset = "0x1A9D5A8", VA = "0x1A9D5A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF8D8", Offset = "0x8DF8D8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x1A9D5B4", Offset = "0x1A9D5B4", VA = "0x1A9D5B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF8E8", Offset = "0x8DF8E8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000603")]
				[Address(RVA = "0x1A9D5C0", Offset = "0x1A9D5C0", VA = "0x1A9D5C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF8F8", Offset = "0x8DF8F8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1A9D5CC", Offset = "0x1A9D5CC", VA = "0x1A9D5CC")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1A9D700", Offset = "0x1A9D700", VA = "0x1A9D700")]
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
			[Address(RVA = "0x1A9D7D4", Offset = "0x1A9D7D4", VA = "0x1A9D7D4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DACE8", Offset = "0x8DACE8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400055C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAD20", Offset = "0x8DAD20")]
				public float weight;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x2144BEC", Offset = "0x2144BEC", VA = "0x2144BEC")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x2144C9C", Offset = "0x2144C9C", VA = "0x2144C9C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x2144CB0", Offset = "0x2144CB0", VA = "0x2144CB0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAC40", Offset = "0x8DAC40")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAC78", Offset = "0x8DAC78")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DACB0", Offset = "0x8DACB0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x1A9DB00", Offset = "0x1A9DB00", VA = "0x1A9DB00", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1A9DC30", Offset = "0x1A9DC30", VA = "0x1A9DC30", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1A9DC9C", Offset = "0x1A9DC9C", VA = "0x1A9DC9C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1A9DE04", Offset = "0x1A9DE04", VA = "0x1A9DE04")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DADC8", Offset = "0x8DADC8")]
				public Transform bone;

				[Token(Token = "0x4000563")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAE00", Offset = "0x8DAE00")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DAE00", Offset = "0x8DAE00")]
				public float weight;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000615")]
				[Address(RVA = "0x2144A84", Offset = "0x2144A84", VA = "0x2144A84")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000616")]
				[Address(RVA = "0x2144B9C", Offset = "0x2144B9C", VA = "0x2144B9C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000617")]
				[Address(RVA = "0x2144BA8", Offset = "0x2144BA8", VA = "0x2144BA8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAD58", Offset = "0x8DAD58")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAD90", Offset = "0x8DAD90")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1A9D7E8", Offset = "0x1A9D7E8", VA = "0x1A9D7E8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1A9D88C", Offset = "0x1A9D88C", VA = "0x1A9D88C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x1A9D8F8", Offset = "0x1A9D8F8", VA = "0x1A9D8F8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1A9DAEC", Offset = "0x1A9DAEC", VA = "0x1A9DAEC")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAAD4", Offset = "0x8DAAD4")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAB0C", Offset = "0x8DAB0C")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A1")]
		public bool inProgress
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1E124B4", Offset = "0x1E124B4", VA = "0x1E124B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1E12584", Offset = "0x1E12584", VA = "0x1E12584", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1E12660", Offset = "0x1E12660", VA = "0x1E12660")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1E128BC", Offset = "0x1E128BC", VA = "0x1E128BC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAEC4", Offset = "0x8DAEC4")]
			public string name;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAEFC", Offset = "0x8DAEFC")]
			public Collider collider;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAF34", Offset = "0x8DAF34")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAF80", Offset = "0x8DAF80")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAF90", Offset = "0x8DAF90")]
			private float <timer>k__BackingField;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAFA0", Offset = "0x8DAFA0")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DAFB0", Offset = "0x8DAFB0")]
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
				[Address(RVA = "0x1A9DE18", Offset = "0x1A9DE18", VA = "0x1A9DE18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF908", Offset = "0x8DF908")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x1A9DE20", Offset = "0x1A9DE20", VA = "0x1A9DE20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF918", Offset = "0x8DF918")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected float timer
			{
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x1A9DE28", Offset = "0x1A9DE28", VA = "0x1A9DE28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF928", Offset = "0x8DF928")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x1A9DE30", Offset = "0x1A9DE30", VA = "0x1A9DE30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF938", Offset = "0x8DF938")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 force
			{
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x1A9DE38", Offset = "0x1A9DE38", VA = "0x1A9DE38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF948", Offset = "0x8DF948")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x1A9DE44", Offset = "0x1A9DE44", VA = "0x1A9DE44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF958", Offset = "0x8DF958")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x1A9DE50", Offset = "0x1A9DE50", VA = "0x1A9DE50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF968", Offset = "0x8DF968")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000622")]
				[Address(RVA = "0x1A9DE5C", Offset = "0x1A9DE5C", VA = "0x1A9DE5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DF978", Offset = "0x8DF978")]
				private set
				{
				}
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1A9DE68", Offset = "0x1A9DE68", VA = "0x1A9DE68")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1A9DFB0", Offset = "0x1A9DFB0", VA = "0x1A9DFB0")]
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
			[Address(RVA = "0x1A9E098", Offset = "0x1A9E098", VA = "0x1A9E098")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB068", Offset = "0x8DB068")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB0A0", Offset = "0x8DB0A0")]
				public float weight;

				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600062D")]
				[Address(RVA = "0x2144CB8", Offset = "0x2144CB8", VA = "0x2144CB8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600062E")]
				[Address(RVA = "0x2144D48", Offset = "0x2144D48", VA = "0x2144D48")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600062F")]
				[Address(RVA = "0x2144D5C", Offset = "0x2144D5C", VA = "0x2144D5C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAFC0", Offset = "0x8DAFC0")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAFF8", Offset = "0x8DAFF8")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB030", Offset = "0x8DB030")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1A9E0AC", Offset = "0x1A9E0AC", VA = "0x1A9E0AC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1A9E25C", Offset = "0x1A9E25C", VA = "0x1A9E25C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1A9E2C8", Offset = "0x1A9E2C8", VA = "0x1A9E2C8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1A9E468", Offset = "0x1A9E468", VA = "0x1A9E468")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB148", Offset = "0x8DB148")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400057E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DB180", Offset = "0x8DB180")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB180", Offset = "0x8DB180")]
				public float weight;

				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000634")]
				[Address(RVA = "0x2144D64", Offset = "0x2144D64", VA = "0x2144D64")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000635")]
				[Address(RVA = "0x2144E40", Offset = "0x2144E40", VA = "0x2144E40")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000636")]
				[Address(RVA = "0x2144E4C", Offset = "0x2144E4C", VA = "0x2144E4C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB0D8", Offset = "0x8DB0D8")]
			public int curveIndex;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB110", Offset = "0x8DB110")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1A9E484", Offset = "0x1A9E484", VA = "0x1A9E484", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1A9E568", Offset = "0x1A9E568", VA = "0x1A9E568", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1A9E5D4", Offset = "0x1A9E5D4", VA = "0x1A9E5D4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1A9E888", Offset = "0x1A9E888", VA = "0x1A9E888")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAE54", Offset = "0x8DAE54")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DAE8C", Offset = "0x8DAE8C")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1E12C10", Offset = "0x1E12C10", VA = "0x1E12C10", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1E12CE4", Offset = "0x1E12CE4", VA = "0x1E12CE4")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1E12F48", Offset = "0x1E12F48", VA = "0x1E12F48")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB3B0", Offset = "0x8DB3B0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB3E8", Offset = "0x8DB3E8")]
				public float weight;

				[Token(Token = "0x600063D")]
				[Address(RVA = "0x2144E90", Offset = "0x2144E90", VA = "0x2144E90")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB244", Offset = "0x8DB244")]
			public Transform transform;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB27C", Offset = "0x8DB27C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB2B4", Offset = "0x8DB2B4")]
			public float speed;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB2EC", Offset = "0x8DB2EC")]
			public float acceleration;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DB324", Offset = "0x8DB324")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB324", Offset = "0x8DB324")]
			public float matchVelocity;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB378", Offset = "0x8DB378")]
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
			[Address(RVA = "0x1E935A4", Offset = "0x1E935A4", VA = "0x1E935A4")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1E9365C", Offset = "0x1E9365C", VA = "0x1E9365C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x1E93918", Offset = "0x1E93918", VA = "0x1E93918")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB1D4", Offset = "0x8DB1D4")]
		public Body[] bodies;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB20C", Offset = "0x8DB20C")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1E2E698", Offset = "0x1E2E698", VA = "0x1E2E698")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1E2E714", Offset = "0x1E2E714", VA = "0x1E2E714", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1E2E7D4", Offset = "0x1E2E7D4", VA = "0x1E2E7D4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DB420", Offset = "0x8DB420")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB420", Offset = "0x8DB420")]
		public Transform target;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DB480", Offset = "0x8DB480")]
		public float weight;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB498", Offset = "0x8DB498")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB4D0", Offset = "0x8DB4D0")]
		public float weightSmoothTime;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DB508", Offset = "0x8DB508")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB508", Offset = "0x8DB508")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB568", Offset = "0x8DB568")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB5A0", Offset = "0x8DB5A0")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB5D8", Offset = "0x8DB5D8")]
		public float slerpSpeed;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB610", Offset = "0x8DB610")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB648", Offset = "0x8DB648")]
		public float minDistance;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DB680", Offset = "0x8DB680")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB680", Offset = "0x8DB680")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DB680", Offset = "0x8DB680")]
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
			[Address(RVA = "0x1B9D540", Offset = "0x1B9D540", VA = "0x1B9D540")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1B9D4CC", Offset = "0x1B9D4CC", VA = "0x1B9D4CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1B9D5D0", Offset = "0x1B9D5D0", VA = "0x1B9D5D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1B9DB00", Offset = "0x1B9DB00", VA = "0x1B9DB00")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1B9DBEC", Offset = "0x1B9DBEC", VA = "0x1B9DBEC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1B9DDE4", Offset = "0x1B9DDE4", VA = "0x1B9DDE4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB76C", Offset = "0x8DB76C")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB7A4", Offset = "0x8DB7A4")]
			public float spring;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB7DC", Offset = "0x8DB7DC")]
			public bool x;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB814", Offset = "0x8DB814")]
			public bool y;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB84C", Offset = "0x8DB84C")]
			public bool z;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB884", Offset = "0x8DB884")]
			public float minX;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB8BC", Offset = "0x8DB8BC")]
			public float maxX;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB8F4", Offset = "0x8DB8F4")]
			public float minY;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB92C", Offset = "0x8DB92C")]
			public float maxY;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB964", Offset = "0x8DB964")]
			public float minZ;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB99C", Offset = "0x8DB99C")]
			public float maxZ;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x1E95CD0", Offset = "0x1E95CD0", VA = "0x1E95CD0")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1E95E28", Offset = "0x1E95E28", VA = "0x1E95E28")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1E95EA0", Offset = "0x1E95EA0", VA = "0x1E95EA0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1E95EF8", Offset = "0x1E95EF8", VA = "0x1E95EF8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D53E0", Offset = "0x8D53E0")]
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
				[Address(RVA = "0x1E95C80", Offset = "0x1E95C80", VA = "0x1E95C80", Slot = "4")]
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
				[Address(RVA = "0x1E95CC8", Offset = "0x1E95CC8", VA = "0x1E95CC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1E95B00", Offset = "0x1E95B00", VA = "0x1E95B00")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1E95B2C", Offset = "0x1E95B2C", VA = "0x1E95B2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1E95B30", Offset = "0x1E95B30", VA = "0x1E95B30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1E95C88", Offset = "0x1E95C88", VA = "0x1E95C88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB6FC", Offset = "0x8DB6FC")]
		public float weight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB734", Offset = "0x8DB734")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1BA0F08", Offset = "0x1BA0F08", VA = "0x1BA0F08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000645")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1B9FCF8", Offset = "0x1B9FCF8", VA = "0x1B9FCF8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1BA0F34", Offset = "0x1BA0F34", VA = "0x1BA0F34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DF988", Offset = "0x8DF988")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1BA0FA0", Offset = "0x1BA0FA0", VA = "0x1BA0FA0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1BA107C", Offset = "0x1BA107C", VA = "0x1BA107C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1BA0068", Offset = "0x1BA0068", VA = "0x1BA0068", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1BA0188", Offset = "0x1BA0188", VA = "0x1BA0188")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D53F0", Offset = "0x8D53F0")]
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
				[Address(RVA = "0x1E96080", Offset = "0x1E96080", VA = "0x1E96080", Slot = "4")]
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
				[Address(RVA = "0x1E960C8", Offset = "0x1E960C8", VA = "0x1E960C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1E95F00", Offset = "0x1E95F00", VA = "0x1E95F00")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x1E95F2C", Offset = "0x1E95F2C", VA = "0x1E95F2C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1E95F30", Offset = "0x1E95F30", VA = "0x1E95F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1E96088", Offset = "0x1E96088", VA = "0x1E96088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DB9D4", Offset = "0x8DB9D4")]
		public float weight;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBA0C", Offset = "0x8DBA0C")]
		public VRIK ik;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		protected float deltaTime
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1BA113C", Offset = "0x1BA113C", VA = "0x1BA113C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000657")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1BA1168", Offset = "0x1BA1168", VA = "0x1BA1168", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1BA1194", Offset = "0x1BA1194", VA = "0x1BA1194")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DFA38", Offset = "0x8DFA38")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1BA1200", Offset = "0x1BA1200", VA = "0x1BA1200")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1BA12DC", Offset = "0x1BA12DC", VA = "0x1BA12DC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1BA13E8", Offset = "0x1BA13E8", VA = "0x1BA13E8")]
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
			[Address(RVA = "0x1E960D0", Offset = "0x1E960D0", VA = "0x1E960D0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1E962EC", Offset = "0x1E962EC", VA = "0x1E962EC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1BA13F8", Offset = "0x1BA13F8", VA = "0x1BA13F8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1BA14BC", Offset = "0x1BA14BC", VA = "0x1BA14BC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1BA1578", Offset = "0x1BA1578", VA = "0x1BA1578")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBC20", Offset = "0x8DBC20")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBC58", Offset = "0x8DBC58")]
				public float weight;

				[Token(Token = "0x600066E")]
				[Address(RVA = "0x2144EA0", Offset = "0x2144EA0", VA = "0x2144EA0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBA7C", Offset = "0x8DBA7C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBAB4", Offset = "0x8DBAB4")]
			public Transform raycastTo;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBAEC", Offset = "0x8DBAEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DBAEC", Offset = "0x8DBAEC")]
			public float raycastRadius;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBB40", Offset = "0x8DBB40")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBB78", Offset = "0x8DBB78")]
			public float smoothTimeIn;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBBB0", Offset = "0x8DBBB0")]
			public float smoothTimeOut;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBBE8", Offset = "0x8DBBE8")]
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
			[Address(RVA = "0x1E962F4", Offset = "0x1E962F4", VA = "0x1E962F4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1E96438", Offset = "0x1E96438", VA = "0x1E96438")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1E96530", Offset = "0x1E96530", VA = "0x1E96530")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1E96700", Offset = "0x1E96700", VA = "0x1E96700")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBA44", Offset = "0x8DBA44")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1BA1F20", Offset = "0x1BA1F20", VA = "0x1BA1F20", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1BA1FA8", Offset = "0x1BA1FA8", VA = "0x1BA1FA8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBFE4", Offset = "0x8DBFE4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC01C", Offset = "0x8DC01C")]
				public float weight;

				[Token(Token = "0x600067E")]
				[Address(RVA = "0x2144EA8", Offset = "0x2144EA8", VA = "0x2144EA8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBEE8", Offset = "0x8DBEE8")]
			public Vector3 offset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBF20", Offset = "0x8DBF20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DBF20", Offset = "0x8DBF20")]
			public float additivity;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBF74", Offset = "0x8DBF74")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBFAC", Offset = "0x8DBFAC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1E970F4", Offset = "0x1E970F4", VA = "0x1E970F4")]
			public void Start()
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x1E97144", Offset = "0x1E97144", VA = "0x1E97144")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x1E97308", Offset = "0x1E97308", VA = "0x1E97308")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBC90", Offset = "0x8DBC90")]
		public AimIK aimIK;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBCC8", Offset = "0x8DBCC8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBD00", Offset = "0x8DBD00")]
		public Handedness handedness;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBD38", Offset = "0x8DBD38")]
		public bool twoHanded;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBD70", Offset = "0x8DBD70")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBDA8", Offset = "0x8DBDA8")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBDE0", Offset = "0x8DBDE0")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBE18", Offset = "0x8DBE18")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBE50", Offset = "0x8DBE50")]
		public float blendTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DBE88", Offset = "0x8DBE88")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8DBE88", Offset = "0x8DBE88")]
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
			[Address(RVA = "0x1BA5680", Offset = "0x1BA5680", VA = "0x1BA5680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1BA60F8", Offset = "0x1BA60F8", VA = "0x1BA60F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1BA6138", Offset = "0x1BA6138", VA = "0x1BA6138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1BA60B8", Offset = "0x1BA60B8", VA = "0x1BA60B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1BA60D8", Offset = "0x1BA60D8", VA = "0x1BA60D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1BA56B0", Offset = "0x1BA56B0", VA = "0x1BA56B0")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1BA56DC", Offset = "0x1BA56DC", VA = "0x1BA56DC")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1BA5824", Offset = "0x1BA5824", VA = "0x1BA5824", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1BA6178", Offset = "0x1BA6178", VA = "0x1BA6178")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1BA622C", Offset = "0x1BA622C", VA = "0x1BA622C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1BA6268", Offset = "0x1BA6268", VA = "0x1BA6268", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1BA6420", Offset = "0x1BA6420", VA = "0x1BA6420")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC054", Offset = "0x8DC054")]
		public float weight;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC08C", Offset = "0x8DC08C")]
		public float offset;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1A9064C", Offset = "0x1A9064C", VA = "0x1A9064C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1A90738", Offset = "0x1A90738", VA = "0x1A90738")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1A90820", Offset = "0x1A90820", VA = "0x1A90820")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1A90B70", Offset = "0x1A90B70", VA = "0x1A90B70")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1A90BE4", Offset = "0x1A90BE4", VA = "0x1A90BE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1A90CE4", Offset = "0x1A90CE4", VA = "0x1A90CE4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC0C4", Offset = "0x8DC0C4")]
			public float scaleMlp;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC0FC", Offset = "0x8DC0FC")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC134", Offset = "0x8DC134")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC16C", Offset = "0x8DC16C")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC1A4", Offset = "0x8DC1A4")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC1DC", Offset = "0x8DC1DC")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC214", Offset = "0x8DC214")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8DC24C", Offset = "0x8DC24C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC24C", Offset = "0x8DC24C")]
			public Vector3 headOffset;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC29C", Offset = "0x8DC29C")]
			public Vector3 handOffset;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC2D4", Offset = "0x8DC2D4")]
			public float footForwardOffset;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC30C", Offset = "0x8DC30C")]
			public float footInwardOffset;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC344", Offset = "0x8DC344")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC344", Offset = "0x8DC344")]
			public float footHeadingOffset;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC3A0", Offset = "0x8DC3A0")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC3B8", Offset = "0x8DC3B8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x2144634", Offset = "0x2144634", VA = "0x2144634")]
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
				[Address(RVA = "0x2144EB0", Offset = "0x2144EB0", VA = "0x2144EB0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000697")]
				[Address(RVA = "0x2144F70", Offset = "0x2144F70", VA = "0x2144F70")]
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
			[Address(RVA = "0x214462C", Offset = "0x214462C", VA = "0x214462C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1A9790C", Offset = "0x1A9790C", VA = "0x1A9790C")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1A97988", Offset = "0x1A97988", VA = "0x1A97988")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1A97AC0", Offset = "0x1A97AC0", VA = "0x1A97AC0")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1A979D4", Offset = "0x1A979D4", VA = "0x1A979D4")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1A95C18", Offset = "0x1A95C18", VA = "0x1A95C18")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1A97AD8", Offset = "0x1A97AD8", VA = "0x1A97AD8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1A96E24", Offset = "0x1A96E24", VA = "0x1A96E24")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1A982C4", Offset = "0x1A982C4", VA = "0x1A982C4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1A986D4", Offset = "0x1A986D4", VA = "0x1A986D4")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1A988E8", Offset = "0x1A988E8", VA = "0x1A988E8")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1A98F8C", Offset = "0x1A98F8C", VA = "0x1A98F8C")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1A98D38", Offset = "0x1A98D38", VA = "0x1A98D38")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1A991FC", Offset = "0x1A991FC", VA = "0x1A991FC")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1A99458", Offset = "0x1A99458", VA = "0x1A99458")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1A99548", Offset = "0x1A99548", VA = "0x1A99548")]
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
		[Address(RVA = "0x1A99864", Offset = "0x1A99864", VA = "0x1A99864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1A998B8", Offset = "0x1A998B8", VA = "0x1A998B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1A998EC", Offset = "0x1A998EC", VA = "0x1A998EC")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1A99A28", Offset = "0x1A99A28", VA = "0x1A99A28")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DC3D0", Offset = "0x8DC3D0")]
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
			[Address(RVA = "0x1A9A118", Offset = "0x1A9A118", VA = "0x1A9A118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFAE8", Offset = "0x8DFAE8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1A9A124", Offset = "0x1A9A124", VA = "0x1A9A124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFAF8", Offset = "0x8DFAF8")]
			private set
			{
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1A9A130", Offset = "0x1A9A130", VA = "0x1A9A130")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1A980CC", Offset = "0x1A980CC", VA = "0x1A980CC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1A98550", Offset = "0x1A98550", VA = "0x1A98550")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1A9A210", Offset = "0x1A9A210", VA = "0x1A9A210")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1A9A62C", Offset = "0x1A9A62C", VA = "0x1A9A62C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1A9A72C", Offset = "0x1A9A72C", VA = "0x1A9A72C")]
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
			[Address(RVA = "0x1A9B6DC", Offset = "0x1A9B6DC", VA = "0x1A9B6DC")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1A9B83C", Offset = "0x1A9B83C", VA = "0x1A9B83C")]
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
		[Address(RVA = "0x1DA3C40", Offset = "0x1DA3C40", VA = "0x1DA3C40")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1DA3C94", Offset = "0x1DA3C94", VA = "0x1DA3C94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1DA3D10", Offset = "0x1DA3D10", VA = "0x1DA3D10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1DA3DE8", Offset = "0x1DA3DE8", VA = "0x1DA3DE8")]
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
		[Address(RVA = "0x1D190E0", Offset = "0x1D190E0", VA = "0x1D190E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1D19164", Offset = "0x1D19164", VA = "0x1D19164")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC3F0", Offset = "0x8DC3F0")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1D1A114", Offset = "0x1D1A114", VA = "0x1D1A114")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1D1A18C", Offset = "0x1D1A18C", VA = "0x1D1A18C")]
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
		[Address(RVA = "0x1A9044C", Offset = "0x1A9044C", VA = "0x1A9044C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1A90490", Offset = "0x1A90490", VA = "0x1A90490")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1A90644", Offset = "0x1A90644", VA = "0x1A90644")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC428", Offset = "0x8DC428")]
		public AimPoser aimPoser;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC460", Offset = "0x8DC460")]
		public AimIK aim;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC498", Offset = "0x8DC498")]
		public LookAtIK lookAt;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC4D0", Offset = "0x8DC4D0")]
		public Animator animator;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC508", Offset = "0x8DC508")]
		public float crossfadeTime;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC540", Offset = "0x8DC540")]
		public float minAimDistance;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1A90CF8", Offset = "0x1A90CF8", VA = "0x1A90CF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1A90D3C", Offset = "0x1A90D3C", VA = "0x1A90D3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1A90EA4", Offset = "0x1A90EA4", VA = "0x1A90EA4")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1A91034", Offset = "0x1A91034", VA = "0x1A91034")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1A91170", Offset = "0x1A91170", VA = "0x1A91170")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1A911EC", Offset = "0x1A911EC", VA = "0x1A911EC")]
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
		[Address(RVA = "0x1A92184", Offset = "0x1A92184", VA = "0x1A92184")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1A922F4", Offset = "0x1A922F4", VA = "0x1A922F4")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1A92488", Offset = "0x1A92488", VA = "0x1A92488")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8DC578", Offset = "0x8DC578")]
		public Animator animator;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8DC5B0", Offset = "0x8DC5B0")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC5E8", Offset = "0x8DC5E8")]
		public float lookAtWeight;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC600", Offset = "0x8DC600")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC618", Offset = "0x8DC618")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC630", Offset = "0x8DC630")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC648", Offset = "0x8DC648")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC660", Offset = "0x8DC660")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC678", Offset = "0x8DC678")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8DC690", Offset = "0x8DC690")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC6C8", Offset = "0x8DC6C8")]
		public float footPositionWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC6E0", Offset = "0x8DC6E0")]
		public float footRotationWeight;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x8DC6F8", Offset = "0x8DC6F8")]
		public Transform handTargetBiped;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC730", Offset = "0x8DC730")]
		public float handPositionWeight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC748", Offset = "0x8DC748")]
		public float handRotationWeight;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1D20848", Offset = "0x1D20848", VA = "0x1D20848")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1D20C50", Offset = "0x1D20C50", VA = "0x1D20C50")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DC760", Offset = "0x8DC760")]
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
			[Address(RVA = "0x1B9DFE0", Offset = "0x1B9DFE0", VA = "0x1B9DFE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFB08", Offset = "0x8DFB08")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1B9DFEC", Offset = "0x1B9DFEC", VA = "0x1B9DFEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFB18", Offset = "0x8DFB18")]
			private set
			{
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1B9DFF8", Offset = "0x1B9DFF8", VA = "0x1B9DFF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1B9E034", Offset = "0x1B9E034", VA = "0x1B9E034")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1B9E8A8", Offset = "0x1B9E8A8", VA = "0x1B9E8A8")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1B9E658", Offset = "0x1B9E658", VA = "0x1B9E658")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1B9E9A4", Offset = "0x1B9E9A4", VA = "0x1B9E9A4")]
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
			[Address(RVA = "0x1B9E9D0", Offset = "0x1B9E9D0", VA = "0x1B9E9D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1B9EA54", Offset = "0x1B9EA54", VA = "0x1B9EA54")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1B9EC78", Offset = "0x1B9EC78", VA = "0x1B9EC78")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5400", Offset = "0x8D5400")]
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
				[Address(RVA = "0x1E95848", Offset = "0x1E95848", VA = "0x1E95848", Slot = "4")]
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
				[Address(RVA = "0x1E95890", Offset = "0x1E95890", VA = "0x1E95890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1E95558", Offset = "0x1E95558", VA = "0x1E95558")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1E95584", Offset = "0x1E95584", VA = "0x1E95584", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1E95588", Offset = "0x1E95588", VA = "0x1E95588", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1E95850", Offset = "0x1E95850", VA = "0x1E95850", Slot = "8")]
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
			[Address(RVA = "0x1B9EC8C", Offset = "0x1B9EC8C", VA = "0x1B9EC8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 position
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1B9E970", Offset = "0x1B9E970", VA = "0x1B9E970")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1B9ECA0", Offset = "0x1B9ECA0", VA = "0x1B9ECA0")]
			set
			{
			}
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1B9ECF0", Offset = "0x1B9ECF0", VA = "0x1B9ECF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1B9EEE4", Offset = "0x1B9EEE4", VA = "0x1B9EEE4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1B9F080", Offset = "0x1B9F080", VA = "0x1B9F080")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1B9F2A8", Offset = "0x1B9F2A8", VA = "0x1B9F2A8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1B9F51C", Offset = "0x1B9F51C", VA = "0x1B9F51C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1B9F694", Offset = "0x1B9F694", VA = "0x1B9F694")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1B9F200", Offset = "0x1B9F200", VA = "0x1B9F200")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DFB28", Offset = "0x8DFB28")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1B9F890", Offset = "0x1B9F890", VA = "0x1B9F890")]
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
		[Address(RVA = "0x1B9F8F4", Offset = "0x1B9F8F4", VA = "0x1B9F8F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1B9F9B4", Offset = "0x1B9F9B4", VA = "0x1B9F9B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1B9FC08", Offset = "0x1B9FC08", VA = "0x1B9FC08")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC830", Offset = "0x8DC830")]
			public int animationLayer;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC868", Offset = "0x8DC868")]
			public string animationState;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC8A0", Offset = "0x8DC8A0")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC8D8", Offset = "0x8DC8D8")]
			public Transform warpFrom;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC910", Offset = "0x8DC910")]
			public Transform warpTo;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC948", Offset = "0x8DC948")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC770", Offset = "0x8DC770")]
		public Animator animator;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC7A8", Offset = "0x8DC7A8")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x8DC7E0", Offset = "0x8DC7E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC7E0", Offset = "0x8DC7E0")]
		public Warp[] warps;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1D1A314", Offset = "0x1D1A314", VA = "0x1D1A314", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1D1A340", Offset = "0x1D1A340", VA = "0x1D1A340")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1D1A580", Offset = "0x1D1A580", VA = "0x1D1A580", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1D1A844", Offset = "0x1D1A844", VA = "0x1D1A844")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1D1A8E4", Offset = "0x1D1A8E4", VA = "0x1D1A8E4")]
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
		[Address(RVA = "0x1D1A8EC", Offset = "0x1D1A8EC", VA = "0x1D1A8EC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1D1A940", Offset = "0x1D1A940", VA = "0x1D1A940")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1D1AADC", Offset = "0x1D1AADC", VA = "0x1D1AADC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1D1ACE4", Offset = "0x1D1ACE4", VA = "0x1D1ACE4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC980", Offset = "0x8DC980")]
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
		[Address(RVA = "0x1D1ACF8", Offset = "0x1D1ACF8", VA = "0x1D1ACF8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1D1AE84", Offset = "0x1D1AE84", VA = "0x1D1AE84", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1D1AF00", Offset = "0x1D1AF00", VA = "0x1D1AF00")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1D1AFF4", Offset = "0x1D1AFF4", VA = "0x1D1AFF4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1D1B03C", Offset = "0x1D1B03C", VA = "0x1D1B03C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1D1B428", Offset = "0x1D1B428", VA = "0x1D1B428")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1D1B2B0", Offset = "0x1D1B2B0", VA = "0x1D1B2B0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1D1B684", Offset = "0x1D1B684", VA = "0x1D1B684")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1D1B790", Offset = "0x1D1B790", VA = "0x1D1B790")]
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
		[Address(RVA = "0x1D2979C", Offset = "0x1D2979C", VA = "0x1D2979C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1D297F8", Offset = "0x1D297F8", VA = "0x1D297F8", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1D29A34", Offset = "0x1D29A34", VA = "0x1D29A34")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1D29B28", Offset = "0x1D29B28", VA = "0x1D29B28")]
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
			[Address(RVA = "0x1D2A54C", Offset = "0x1D2A54C", VA = "0x1D2A54C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1D2A5D0", Offset = "0x1D2A5D0", VA = "0x1D2A5D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1D2A354", Offset = "0x1D2A354", VA = "0x1D2A354")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1D2A3C0", Offset = "0x1D2A3C0", VA = "0x1D2A3C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1D2A654", Offset = "0x1D2A654", VA = "0x1D2A654")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DC998", Offset = "0x8DC998")]
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
		[Address(RVA = "0x1D9CDF4", Offset = "0x1D9CDF4", VA = "0x1D9CDF4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1D9D254", Offset = "0x1D9D254", VA = "0x1D9D254")]
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
		[Address(RVA = "0x1D9D25C", Offset = "0x1D9D25C", VA = "0x1D9D25C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1D9D304", Offset = "0x1D9D304", VA = "0x1D9D304")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1D9D688", Offset = "0x1D9D688", VA = "0x1D9D688")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1D9D734", Offset = "0x1D9D734", VA = "0x1D9D734")]
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
			[Address(RVA = "0x1A9B1C4", Offset = "0x1A9B1C4", VA = "0x1A9B1C4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1A9B248", Offset = "0x1A9B248", VA = "0x1A9B248")]
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
		[Address(RVA = "0x1DA1000", Offset = "0x1DA1000", VA = "0x1DA1000")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1DA1158", Offset = "0x1DA1158", VA = "0x1DA1158")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1DA11FC", Offset = "0x1DA11FC", VA = "0x1DA11FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1DA1200", Offset = "0x1DA1200", VA = "0x1DA1200")]
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
		[Address(RVA = "0x1DA1210", Offset = "0x1DA1210", VA = "0x1DA1210")]
		private void Start()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1DA1284", Offset = "0x1DA1284", VA = "0x1DA1284")]
		private void Update()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1DA1358", Offset = "0x1DA1358", VA = "0x1DA1358")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC9B0", Offset = "0x8DC9B0")]
		public Transform target;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DC9E8", Offset = "0x8DC9E8")]
		public Transform pin;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCA20", Offset = "0x8DCA20")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCA58", Offset = "0x8DCA58")]
		public AimIK aim;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCA90", Offset = "0x8DCA90")]
		public float weight;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCAC8", Offset = "0x8DCAC8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCB00", Offset = "0x8DCB00")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1DA1360", Offset = "0x1DA1360", VA = "0x1DA1360")]
		private void Start()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1DA13B4", Offset = "0x1DA13B4", VA = "0x1DA13B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1DA1558", Offset = "0x1DA1558", VA = "0x1DA1558")]
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
		[Address(RVA = "0x1DA35FC", Offset = "0x1DA35FC", VA = "0x1DA35FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1DA36C4", Offset = "0x1DA36C4", VA = "0x1DA36C4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1DA3754", Offset = "0x1DA3754", VA = "0x1DA3754")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1DA3B2C", Offset = "0x1DA3B2C", VA = "0x1DA3B2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1DA3C38", Offset = "0x1DA3C38", VA = "0x1DA3C38")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCB38", Offset = "0x8DCB38")]
		public float aimWeight;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCB50", Offset = "0x8DCB50")]
		public float sightWeight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCB68", Offset = "0x8DCB68")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCB84", Offset = "0x8DCB84")]
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
		[Address(RVA = "0x1DA3DF0", Offset = "0x1DA3DF0", VA = "0x1DA3DF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1DA3FB4", Offset = "0x1DA3FB4", VA = "0x1DA3FB4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1DA3FC0", Offset = "0x1DA3FC0", VA = "0x1DA3FC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1DA4240", Offset = "0x1DA4240", VA = "0x1DA4240")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1DA4510", Offset = "0x1DA4510", VA = "0x1DA4510")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1DA4088", Offset = "0x1DA4088", VA = "0x1DA4088")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1DA4E04", Offset = "0x1DA4E04", VA = "0x1DA4E04")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCB9C", Offset = "0x8DCB9C")]
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
		[Address(RVA = "0x1DA4E24", Offset = "0x1DA4E24", VA = "0x1DA4E24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1DA4E9C", Offset = "0x1DA4E9C", VA = "0x1DA4E9C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1DA4F88", Offset = "0x1DA4F88", VA = "0x1DA4F88")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1DA5040", Offset = "0x1DA5040", VA = "0x1DA5040")]
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
		[Address(RVA = "0x1E128C4", Offset = "0x1E128C4", VA = "0x1E128C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1E12A1C", Offset = "0x1E12A1C", VA = "0x1E12A1C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1E12C00", Offset = "0x1E12C00", VA = "0x1E12C00")]
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
		[Address(RVA = "0x1E1329C", Offset = "0x1E1329C", VA = "0x1E1329C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1E133E4", Offset = "0x1E133E4", VA = "0x1E133E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1E13720", Offset = "0x1E13720", VA = "0x1E13720")]
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
		[Address(RVA = "0x1E2E8B4", Offset = "0x1E2E8B4", VA = "0x1E2E8B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1E2E9F0", Offset = "0x1E2E9F0", VA = "0x1E2E9F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1E2EAFC", Offset = "0x1E2EAFC", VA = "0x1E2EAFC")]
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
		[Address(RVA = "0x1E2EB04", Offset = "0x1E2EB04", VA = "0x1E2EB04")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1E2F230", Offset = "0x1E2F230", VA = "0x1E2F230")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCBB4", Offset = "0x8DCBB4")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCBEC", Offset = "0x8DCBEC")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1B9B008", Offset = "0x1B9B008", VA = "0x1B9B008")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1B9B05C", Offset = "0x1B9B05C", VA = "0x1B9B05C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1B9B394", Offset = "0x1B9B394", VA = "0x1B9B394")]
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
				[Address(RVA = "0x1E954EC", Offset = "0x1E954EC", VA = "0x1E954EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1E94DA0", Offset = "0x1E94DA0", VA = "0x1E94DA0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1E94DC0", Offset = "0x1E94DC0", VA = "0x1E94DC0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1E95358", Offset = "0x1E95358", VA = "0x1E95358")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1E95544", Offset = "0x1E95544", VA = "0x1E95544")]
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
		[Address(RVA = "0x1B9CAC8", Offset = "0x1B9CAC8", VA = "0x1B9CAC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1B9CB04", Offset = "0x1B9CB04", VA = "0x1B9CB04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1B9CB6C", Offset = "0x1B9CB6C", VA = "0x1B9CB6C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCD04", Offset = "0x8DCD04")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCD3C", Offset = "0x8DCD3C")]
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
			[Address(RVA = "0x1E95898", Offset = "0x1E95898", VA = "0x1E95898")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1E9596C", Offset = "0x1E9596C", VA = "0x1E9596C")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1E959A8", Offset = "0x1E959A8", VA = "0x1E959A8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1E95A40", Offset = "0x1E95A40", VA = "0x1E95A40")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1E95AB4", Offset = "0x1E95AB4", VA = "0x1E95AB4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCC24", Offset = "0x8DCC24")]
		public Mode mode;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCC5C", Offset = "0x8DCC5C")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCC94", Offset = "0x8DCC94")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCCCC", Offset = "0x8DCCCC")]
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
		[Address(RVA = "0x1B9FC10", Offset = "0x1B9FC10", VA = "0x1B9FC10", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1B9FD24", Offset = "0x1B9FD24", VA = "0x1B9FD24")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1B9FDB4", Offset = "0x1B9FDB4", VA = "0x1B9FDB4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1B9FEC8", Offset = "0x1B9FEC8", VA = "0x1B9FEC8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x1B9FF54", Offset = "0x1B9FF54", VA = "0x1B9FF54", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1BA0174", Offset = "0x1BA0174", VA = "0x1BA0174")]
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
		[Address(RVA = "0x1BA0198", Offset = "0x1BA0198", VA = "0x1BA0198")]
		private void Start()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1BA020C", Offset = "0x1BA020C", VA = "0x1BA020C")]
		private void Update()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1BA02E8", Offset = "0x1BA02E8", VA = "0x1BA02E8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1BA03A8", Offset = "0x1BA03A8", VA = "0x1BA03A8")]
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
			[Address(RVA = "0x1E95AF0", Offset = "0x1E95AF0", VA = "0x1E95AF0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1BA0C60", Offset = "0x1BA0C60", VA = "0x1BA0C60", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1BA0D6C", Offset = "0x1BA0D6C", VA = "0x1BA0D6C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x1BA0EF8", Offset = "0x1BA0EF8", VA = "0x1BA0EF8")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCD84", Offset = "0x8DCD84")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCD84", Offset = "0x8DCD84")]
		public float weight;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCDD8", Offset = "0x8DCDD8")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCE10", Offset = "0x8DCE10")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCE5C", Offset = "0x8DCE5C")]
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
		[Address(RVA = "0x1BA15D4", Offset = "0x1BA15D4", VA = "0x1BA15D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1BA1898", Offset = "0x1BA1898", VA = "0x1BA1898")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1BA1EE0", Offset = "0x1BA1EE0", VA = "0x1BA1EE0")]
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
			[Address(RVA = "0x1BA24BC", Offset = "0x1BA24BC", VA = "0x1BA24BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private bool holdingLeft
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1BA25A0", Offset = "0x1BA25A0", VA = "0x1BA25A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool holdingRight
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1BA24F4", Offset = "0x1BA24F4", VA = "0x1BA24F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x1BA1FB8", Offset = "0x1BA1FB8", VA = "0x1BA1FB8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000744")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1BA264C", Offset = "0x1BA264C", VA = "0x1BA264C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1BA27D4", Offset = "0x1BA27D4", VA = "0x1BA27D4")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1BA2958", Offset = "0x1BA2958", VA = "0x1BA2958")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1BA2A34", Offset = "0x1BA2A34", VA = "0x1BA2A34")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1BA2B74", Offset = "0x1BA2B74", VA = "0x1BA2B74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1BA2CE4", Offset = "0x1BA2CE4", VA = "0x1BA2CE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1BA2EB0", Offset = "0x1BA2EB0", VA = "0x1BA2EB0")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1BA2EC4", Offset = "0x1BA2EC4", VA = "0x1BA2EC4", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1BA3128", Offset = "0x1BA3128", VA = "0x1BA3128")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1BA313C", Offset = "0x1BA313C", VA = "0x1BA313C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1BA3270", Offset = "0x1BA3270", VA = "0x1BA3270")]
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
		[Address(RVA = "0x1BA5484", Offset = "0x1BA5484", VA = "0x1BA5484")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1BA5564", Offset = "0x1BA5564", VA = "0x1BA5564")]
		private void Update()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1BA5678", Offset = "0x1BA5678", VA = "0x1BA5678")]
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
		[Address(RVA = "0x1BA6490", Offset = "0x1BA6490", VA = "0x1BA6490")]
		private void Start()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1BA64E4", Offset = "0x1BA64E4", VA = "0x1BA64E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1BA653C", Offset = "0x1BA653C", VA = "0x1BA653C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1BA661C", Offset = "0x1BA661C", VA = "0x1BA661C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5410", Offset = "0x8D5410")]
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
				[Address(RVA = "0x1E974F8", Offset = "0x1E974F8", VA = "0x1E974F8", Slot = "4")]
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
				[Address(RVA = "0x1E97540", Offset = "0x1E97540", VA = "0x1E97540", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1E9731C", Offset = "0x1E9731C", VA = "0x1E9731C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1E97348", Offset = "0x1E97348", VA = "0x1E97348", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1E9734C", Offset = "0x1E9734C", VA = "0x1E9734C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1E97500", Offset = "0x1E97500", VA = "0x1E97500", Slot = "8")]
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
		[Address(RVA = "0x1BA662C", Offset = "0x1BA662C", VA = "0x1BA662C")]
		private void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1BA66E0", Offset = "0x1BA66E0", VA = "0x1BA66E0")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1BA6728", Offset = "0x1BA6728", VA = "0x1BA6728")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DFBD8", Offset = "0x8DFBD8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1BA67A4", Offset = "0x1BA67A4", VA = "0x1BA67A4")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5420", Offset = "0x8D5420")]
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
				[Address(RVA = "0x1E97A64", Offset = "0x1E97A64", VA = "0x1E97A64", Slot = "4")]
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
				[Address(RVA = "0x1E97AAC", Offset = "0x1E97AAC", VA = "0x1E97AAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1E9790C", Offset = "0x1E9790C", VA = "0x1E9790C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1E97938", Offset = "0x1E97938", VA = "0x1E97938", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x1E9793C", Offset = "0x1E9793C", VA = "0x1E9793C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1E97A6C", Offset = "0x1E97A6C", VA = "0x1E97A6C", Slot = "8")]
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
		[Address(RVA = "0x1A919E0", Offset = "0x1A919E0", VA = "0x1A919E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x1A91A8C", Offset = "0x1A91A8C", VA = "0x1A91A8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DFC88", Offset = "0x8DFC88")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1A91AF8", Offset = "0x1A91AF8", VA = "0x1A91AF8")]
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
			[Address(RVA = "0x1E97AB4", Offset = "0x1E97AB4", VA = "0x1E97AB4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1E97D4C", Offset = "0x1E97D4C", VA = "0x1E97D4C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1E97E38", Offset = "0x1E97E38", VA = "0x1E97E38")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1E982CC", Offset = "0x1E982CC", VA = "0x1E982CC")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x1E983C0", Offset = "0x1E983C0", VA = "0x1E983C0")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x1E98458", Offset = "0x1E98458", VA = "0x1E98458")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x1E984EC", Offset = "0x1E984EC", VA = "0x1E984EC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x1E98580", Offset = "0x1E98580", VA = "0x1E98580")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x1E986EC", Offset = "0x1E986EC", VA = "0x1E986EC")]
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
		[Address(RVA = "0x1A924B8", Offset = "0x1A924B8", VA = "0x1A924B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1A92534", Offset = "0x1A92534", VA = "0x1A92534")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1A925A4", Offset = "0x1A925A4", VA = "0x1A925A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1A9266C", Offset = "0x1A9266C", VA = "0x1A9266C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCEA8", Offset = "0x8DCEA8")]
		public Transform to;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCEE0", Offset = "0x8DCEE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCEE0", Offset = "0x8DCEE0")]
		public float transferMotion;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1A92674", Offset = "0x1A92674", VA = "0x1A92674")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1A926B0", Offset = "0x1A926B0", VA = "0x1A926B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1A92764", Offset = "0x1A92764", VA = "0x1A92764")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCF34", Offset = "0x8DCF34")]
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
		[Address(RVA = "0x1A93998", Offset = "0x1A93998", VA = "0x1A93998")]
		private void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1A93B78", Offset = "0x1A93B78", VA = "0x1A93B78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1A93D68", Offset = "0x1A93D68", VA = "0x1A93D68")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1A93E34", Offset = "0x1A93E34", VA = "0x1A93E34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1A93F34", Offset = "0x1A93F34", VA = "0x1A93F34")]
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
		[Address(RVA = "0x1A941D0", Offset = "0x1A941D0", VA = "0x1A941D0", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1A9455C", Offset = "0x1A9455C", VA = "0x1A9455C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1A947C8", Offset = "0x1A947C8", VA = "0x1A947C8")]
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
		[Address(RVA = "0x1DA8B68", Offset = "0x1DA8B68", VA = "0x1DA8B68")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1DA8E90", Offset = "0x1DA8E90", VA = "0x1DA8E90")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1DA8F10", Offset = "0x1DA8F10", VA = "0x1DA8F10")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5430", Offset = "0x8D5430")]
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
				[Address(RVA = "0x1E96854", Offset = "0x1E96854", VA = "0x1E96854", Slot = "4")]
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
				[Address(RVA = "0x1E9689C", Offset = "0x1E9689C", VA = "0x1E9689C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1E96714", Offset = "0x1E96714", VA = "0x1E96714")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1E96740", Offset = "0x1E96740", VA = "0x1E96740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1E96744", Offset = "0x1E96744", VA = "0x1E96744", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1E9685C", Offset = "0x1E9685C", VA = "0x1E9685C", Slot = "8")]
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
		[Address(RVA = "0x1BA3284", Offset = "0x1BA3284", VA = "0x1BA3284")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1BA33B0", Offset = "0x1BA33B0", VA = "0x1BA33B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1BA3344", Offset = "0x1BA3344", VA = "0x1BA3344")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DFD38", Offset = "0x8DFD38")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1BA3534", Offset = "0x1BA3534", VA = "0x1BA3534")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1BA3620", Offset = "0x1BA3620", VA = "0x1BA3620")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1BA3708", Offset = "0x1BA3708", VA = "0x1BA3708")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DCF6C", Offset = "0x8DCF6C")]
		public float weight;

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1D1F5E8", Offset = "0x1D1F5E8", VA = "0x1D1F5E8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1D1F65C", Offset = "0x1D1F65C", VA = "0x1D1F65C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1D1F714", Offset = "0x1D1F714", VA = "0x1D1F714")]
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
			[Address(RVA = "0x214341C", Offset = "0x214341C", VA = "0x214341C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x2143548", Offset = "0x2143548", VA = "0x2143548")]
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
		[Address(RVA = "0x1A92B4C", Offset = "0x1A92B4C", VA = "0x1A92B4C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1A92BC8", Offset = "0x1A92BC8", VA = "0x1A92BC8")]
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
		[Address(RVA = "0x1E12F50", Offset = "0x1E12F50", VA = "0x1E12F50")]
		private void Update()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1E130A8", Offset = "0x1E130A8", VA = "0x1E130A8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1E1328C", Offset = "0x1E1328C", VA = "0x1E1328C")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCF84", Offset = "0x8DCF84")]
		public VRIK ik;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCFBC", Offset = "0x8DCFBC")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DCFF4", Offset = "0x8DCFF4")]
		public Transform headTracker;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD02C", Offset = "0x8DD02C")]
		public Transform bodyTracker;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD064", Offset = "0x8DD064")]
		public Transform leftHandTracker;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD09C", Offset = "0x8DD09C")]
		public Transform rightHandTracker;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD0D4", Offset = "0x8DD0D4")]
		public Transform leftFootTracker;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD10C", Offset = "0x8DD10C")]
		public Transform rightFootTracker;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD144", Offset = "0x8DD144")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1A95AA4", Offset = "0x1A95AA4", VA = "0x1A95AA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1A97924", Offset = "0x1A97924", VA = "0x1A97924")]
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
		[Address(RVA = "0x1A99A40", Offset = "0x1A99A40", VA = "0x1A99A40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1A99A9C", Offset = "0x1A99A9C", VA = "0x1A99A9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1A99C24", Offset = "0x1A99C24", VA = "0x1A99C24")]
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
		[Address(RVA = "0x1A99C58", Offset = "0x1A99C58", VA = "0x1A99C58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x1A9A0DC", Offset = "0x1A9A0DC", VA = "0x1A9A0DC")]
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
			[Address(RVA = "0x1D28A80", Offset = "0x1D28A80", VA = "0x1D28A80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1D28A5C", Offset = "0x1D28A5C", VA = "0x1D28A5C", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1D28A88", Offset = "0x1D28A88", VA = "0x1D28A88")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1D28AEC", Offset = "0x1D28AEC", VA = "0x1D28AEC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1D28C84", Offset = "0x1D28C84", VA = "0x1D28C84", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1D28EA8", Offset = "0x1D28EA8", VA = "0x1D28EA8", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1D28C94", Offset = "0x1D28C94", VA = "0x1D28C94")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1D28EB8", Offset = "0x1D28EB8", VA = "0x1D28EB8")]
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
		[Address(RVA = "0x1D28ED0", Offset = "0x1D28ED0", VA = "0x1D28ED0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1D28F2C", Offset = "0x1D28F2C", VA = "0x1D28F2C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1D28FC8", Offset = "0x1D28FC8", VA = "0x1D28FC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1D290E0", Offset = "0x1D290E0", VA = "0x1D290E0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8DD1AC", Offset = "0x8DD1AC")]
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
			[Address(RVA = "0x1D29194", Offset = "0x1D29194", VA = "0x1D29194", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1D290F8", Offset = "0x1D290F8", VA = "0x1D290F8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1D29178", Offset = "0x1D29178", VA = "0x1D29178", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1D2928C", Offset = "0x1D2928C", VA = "0x1D2928C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1D29670", Offset = "0x1D29670", VA = "0x1D29670")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1D29778", Offset = "0x1D29778", VA = "0x1D29778")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD1F0", Offset = "0x8DD1F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD1F0", Offset = "0x8DD1F0")]
		public Transform gravityTarget;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD250", Offset = "0x8DD250")]
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
		[Address(RVA = "0x1D29B4C", Offset = "0x1D29B4C", VA = "0x1D29B4C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1D29C7C", Offset = "0x1D29C7C", VA = "0x1D29C7C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1D29E34", Offset = "0x1D29E34", VA = "0x1D29E34", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1D29FE4", Offset = "0x1D29FE4", VA = "0x1D29FE4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1D2A048", Offset = "0x1D2A048", VA = "0x1D2A048")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1D2A168", Offset = "0x1D2A168", VA = "0x1D2A168")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1D2A28C", Offset = "0x1D2A28C", VA = "0x1D2A28C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1D2A2B0", Offset = "0x1D2A2B0", VA = "0x1D2A2B0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1D2A2D4", Offset = "0x1D2A2D4", VA = "0x1D2A2D4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1D2A334", Offset = "0x1D2A334", VA = "0x1D2A334")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8D5440", Offset = "0x8D5440")]
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
				[Address(RVA = "0x1A9B080", Offset = "0x1A9B080", VA = "0x1A9B080", Slot = "4")]
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
				[Address(RVA = "0x1A9B0C8", Offset = "0x1A9B0C8", VA = "0x1A9B0C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1A9AF5C", Offset = "0x1A9AF5C", VA = "0x1A9AF5C")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1A9AF88", Offset = "0x1A9AF88", VA = "0x1A9AF88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1A9AF8C", Offset = "0x1A9AF8C", VA = "0x1A9AF8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1A9B088", Offset = "0x1A9B088", VA = "0x1A9B088", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD288", Offset = "0x8DD288")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD2C0", Offset = "0x8DD2C0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD2F8", Offset = "0x8DD2F8")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD330", Offset = "0x8DD330")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD368", Offset = "0x8DD368")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x8DD3A0", Offset = "0x8DD3A0")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD3D8", Offset = "0x8DD3D8")]
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
			[Address(RVA = "0x1D2A65C", Offset = "0x1D2A65C", VA = "0x1D2A65C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFDE8", Offset = "0x8DFDE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1D2A664", Offset = "0x1D2A664", VA = "0x1D2A664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFDF8", Offset = "0x8DFDF8")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1D2A670", Offset = "0x1D2A670", VA = "0x1D2A670", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1D2A7B0", Offset = "0x1D2A7B0", VA = "0x1D2A7B0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1D2A840", Offset = "0x1D2A840", VA = "0x1D2A840", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1D2A908", Offset = "0x1D2A908", VA = "0x1D2A908")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1D2B50C", Offset = "0x1D2B50C", VA = "0x1D2B50C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1D2B764", Offset = "0x1D2B764", VA = "0x1D2B764", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1D2AE00", Offset = "0x1D2AE00", VA = "0x1D2AE00")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1D2B840", Offset = "0x1D2B840", VA = "0x1D2B840")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1D2BCE8", Offset = "0x1D2BCE8", VA = "0x1D2BCE8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1D2B594", Offset = "0x1D2B594", VA = "0x1D2B594")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1D2BD88", Offset = "0x1D2BD88", VA = "0x1D2BD88", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1D2C0C4", Offset = "0x1D2C0C4", VA = "0x1D2C0C4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x1D2C1B4", Offset = "0x1D2C1B4", VA = "0x1D2C1B4", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1D2C314", Offset = "0x1D2C314", VA = "0x1D2C314")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DFE08", Offset = "0x8DFE08")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1D2B164", Offset = "0x1D2B164", VA = "0x1D2B164")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x1D2C3A4", Offset = "0x1D2C3A4", VA = "0x1D2C3A4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD3E8", Offset = "0x8DD3E8")]
		public CameraController cameraController;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD420", Offset = "0x8DD420")]
		public float accelerationTime;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD458", Offset = "0x8DD458")]
		public float turnTime;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD490", Offset = "0x8DD490")]
		public bool walkByDefault;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD4C8", Offset = "0x8DD4C8")]
		public RotationMode rotationMode;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD500", Offset = "0x8DD500")]
		public float moveSpeed;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD538", Offset = "0x8DD538")]
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
			[Address(RVA = "0x1A91200", Offset = "0x1A91200", VA = "0x1A91200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFEB8", Offset = "0x8DFEB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1A91208", Offset = "0x1A91208", VA = "0x1A91208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFEC8", Offset = "0x8DFEC8")]
			private set
			{
			}
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1A91214", Offset = "0x1A91214", VA = "0x1A91214")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1A912A4", Offset = "0x1A912A4", VA = "0x1A912A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1A91764", Offset = "0x1A91764", VA = "0x1A91764")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1A912F8", Offset = "0x1A912F8", VA = "0x1A912F8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1A91578", Offset = "0x1A91578", VA = "0x1A91578")]
		private void Move()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x1A917A0", Offset = "0x1A917A0", VA = "0x1A917A0")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1A9183C", Offset = "0x1A9183C", VA = "0x1A9183C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1A918C0", Offset = "0x1A918C0", VA = "0x1A918C0")]
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
		[Address(RVA = "0x1A93F3C", Offset = "0x1A93F3C", VA = "0x1A93F3C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1A93FB8", Offset = "0x1A93FB8", VA = "0x1A93FB8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1A9417C", Offset = "0x1A9417C", VA = "0x1A9417C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1A941A4", Offset = "0x1A941A4", VA = "0x1A941A4")]
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
		[Address(RVA = "0x1A93F80", Offset = "0x1A93F80", VA = "0x1A93F80", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1A942C0", Offset = "0x1A942C0", VA = "0x1A942C0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x1A941C0", Offset = "0x1A941C0", VA = "0x1A941C0")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x1D1B7AC", Offset = "0x1D1B7AC", VA = "0x1D1B7AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1D1B7E8", Offset = "0x1D1B7E8", VA = "0x1D1B7E8")]
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
		[Address(RVA = "0x1A918E8", Offset = "0x1A918E8", VA = "0x1A918E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1A9191C", Offset = "0x1A9191C", VA = "0x1A9191C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1A919CC", Offset = "0x1A919CC", VA = "0x1A919CC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD548", Offset = "0x8DD548")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD580", Offset = "0x8DD580")]
		public float cornerRadius;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD5B8", Offset = "0x8DD5B8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD5F0", Offset = "0x8DD5F0")]
		public float maxSampleDistance;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8DD628", Offset = "0x8DD628")]
		public float nextPathInterval;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD660", Offset = "0x8DD660")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DD670", Offset = "0x8DD670")]
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
			[Address(RVA = "0x1BA03BC", Offset = "0x1BA03BC", VA = "0x1BA03BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFED8", Offset = "0x8DFED8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1BA03C8", Offset = "0x1BA03C8", VA = "0x1BA03C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFEE8", Offset = "0x8DFEE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public State state
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1BA03D4", Offset = "0x1BA03D4", VA = "0x1BA03D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFEF8", Offset = "0x8DFEF8")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x1BA03DC", Offset = "0x1BA03DC", VA = "0x1BA03DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DFF08", Offset = "0x8DFF08")]
			private set
			{
			}
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1BA03E4", Offset = "0x1BA03E4", VA = "0x1BA03E4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1BA0494", Offset = "0x1BA0494", VA = "0x1BA0494")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1BA0880", Offset = "0x1BA0880", VA = "0x1BA0880")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1BA08FC", Offset = "0x1BA08FC", VA = "0x1BA08FC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1BA083C", Offset = "0x1BA083C", VA = "0x1BA083C")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1BA086C", Offset = "0x1BA086C", VA = "0x1BA086C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1BA0A48", Offset = "0x1BA0A48", VA = "0x1BA0A48")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1BA0BF8", Offset = "0x1BA0BF8", VA = "0x1BA0BF8")]
		public Navigator()
		{
		}
	}
}
