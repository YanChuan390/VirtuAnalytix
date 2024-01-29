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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DBE2C", Offset = "0x10DBE2C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DBE2C", Offset = "0x10DBE2C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCE60", Offset = "0x10DCE60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DCE60", Offset = "0x10DCE60")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DCEB8", Offset = "0x10DCEB8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCEB8", Offset = "0x10DCEB8")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCF10", Offset = "0x10DCF10")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCF48", Offset = "0x10DCF48")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCF80", Offset = "0x10DCF80")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCFB8", Offset = "0x10DCFB8")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DCFF0", Offset = "0x10DCFF0")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD028", Offset = "0x10DD028")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD060", Offset = "0x10DD060")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD098", Offset = "0x10DD098")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD0A8", Offset = "0x10DD0A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD128", Offset = "0x10DD128")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2FC133C", Offset = "0x2FC133C", VA = "0x2FC133C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E50B4", Offset = "0x10E50B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2FC1344", Offset = "0x2FC1344", VA = "0x2FC1344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E50C4", Offset = "0x10E50C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2FC1350", Offset = "0x2FC1350", VA = "0x2FC1350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E50D4", Offset = "0x10E50D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2FC1358", Offset = "0x2FC1358", VA = "0x2FC1358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E50E4", Offset = "0x10E50E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2FC1360", Offset = "0x2FC1360", VA = "0x2FC1360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E50F4", Offset = "0x10E50F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2FC1368", Offset = "0x2FC1368", VA = "0x2FC1368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5104", Offset = "0x10E5104")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2FC121C", Offset = "0x2FC121C", VA = "0x2FC121C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E4FD4", Offset = "0x10E4FD4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2FC1264", Offset = "0x2FC1264", VA = "0x2FC1264")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E500C", Offset = "0x10E500C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2FC12AC", Offset = "0x2FC12AC", VA = "0x2FC12AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5044", Offset = "0x10E5044")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2FC12F4", Offset = "0x2FC12F4", VA = "0x2FC12F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E507C", Offset = "0x10E507C")]
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
		[Address(RVA = "0x2FC1370", Offset = "0x2FC1370", VA = "0x2FC1370")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2FC1374", Offset = "0x2FC1374", VA = "0x2FC1374")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2FC1378", Offset = "0x2FC1378", VA = "0x2FC1378")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2FC137C", Offset = "0x2FC137C", VA = "0x2FC137C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD138", Offset = "0x10DD138")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD170", Offset = "0x10DD170")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD1A8", Offset = "0x10DD1A8")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD1E0", Offset = "0x10DD1E0")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD218", Offset = "0x10DD218")]
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
		[Address(RVA = "0x3070748", Offset = "0x3070748", VA = "0x3070748")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3070B38", Offset = "0x3070B38", VA = "0x3070B38", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3070B40", Offset = "0x3070B40", VA = "0x3070B40", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3070C50", Offset = "0x3070C50", VA = "0x3070C50", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3070CCC", Offset = "0x3070CCC", VA = "0x3070CCC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3070D48", Offset = "0x3070D48", VA = "0x3070D48", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3070990", Offset = "0x3070990", VA = "0x3070990")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3070A64", Offset = "0x3070A64", VA = "0x3070A64")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3070DC4", Offset = "0x3070DC4", VA = "0x3070DC4")]
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
		[Address(RVA = "0x2D71578", Offset = "0x2D71578", VA = "0x2D71578")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2FC0614", Offset = "0x2FC0614", VA = "0x2FC0614")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2FC0870", Offset = "0x2FC0870", VA = "0x2FC0870")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2FC0850", Offset = "0x2FC0850", VA = "0x2FC0850")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2FC0E1C", Offset = "0x2FC0E1C", VA = "0x2FC0E1C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2FC2514", Offset = "0x2FC2514", VA = "0x2FC2514")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2FC3DCC", Offset = "0x2FC3DCC", VA = "0x2FC3DCC")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2FC1F68", Offset = "0x2FC1F68", VA = "0x2FC1F68")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2FC255C", Offset = "0x2FC255C", VA = "0x2FC255C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2FC1A98", Offset = "0x2FC1A98", VA = "0x2FC1A98")]
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
		[Address(RVA = "0x2FC1468", Offset = "0x2FC1468", VA = "0x2FC1468")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2FC16D4", Offset = "0x2FC16D4", VA = "0x2FC16D4")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2FC15CC", Offset = "0x2FC15CC", VA = "0x2FC15CC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2FC1850", Offset = "0x2FC1850", VA = "0x2FC1850")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2FC1CFC", Offset = "0x2FC1CFC", VA = "0x2FC1CFC")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2FC1DF8", Offset = "0x2FC1DF8", VA = "0x2FC1DF8")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2FC1EF4", Offset = "0x2FC1EF4", VA = "0x2FC1EF4")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2FC1E6C", Offset = "0x2FC1E6C", VA = "0x2FC1E6C")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2FC2160", Offset = "0x2FC2160", VA = "0x2FC2160")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2FC2214", Offset = "0x2FC2214", VA = "0x2FC2214")]
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
		[Address(RVA = "0x2FC2560", Offset = "0x2FC2560", VA = "0x2FC2560")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2FC25D0", Offset = "0x2FC25D0", VA = "0x2FC25D0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2FC3064", Offset = "0x2FC3064", VA = "0x2FC3064")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2FC3118", Offset = "0x2FC3118", VA = "0x2FC3118")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2FC3008", Offset = "0x2FC3008", VA = "0x2FC3008")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2FC3210", Offset = "0x2FC3210", VA = "0x2FC3210")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2FC3258", Offset = "0x2FC3258", VA = "0x2FC3258")]
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
		[Address(RVA = "0x2FC3260", Offset = "0x2FC3260", VA = "0x2FC3260")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2FC33EC", Offset = "0x2FC33EC", VA = "0x2FC33EC")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2FC3400", Offset = "0x2FC3400", VA = "0x2FC3400")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2FC36EC", Offset = "0x2FC36EC", VA = "0x2FC36EC")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2FC32F8", Offset = "0x2FC32F8", VA = "0x2FC32F8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2FC39A0", Offset = "0x2FC39A0", VA = "0x2FC39A0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2FC3A14", Offset = "0x2FC3A14", VA = "0x2FC3A14")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2FC3BC8", Offset = "0x2FC3BC8", VA = "0x2FC3BC8")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD250", Offset = "0x10DD250")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD288", Offset = "0x10DD288")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD288", Offset = "0x10DD288")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD2E0", Offset = "0x10DD2E0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD2E0", Offset = "0x10DD2E0")]
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
		[Address(RVA = "0x30DEF78", Offset = "0x30DEF78", VA = "0x30DEF78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x30DF454", Offset = "0x30DF454", VA = "0x30DF454", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x30DF470", Offset = "0x30DF470", VA = "0x30DF470", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x30DF54C", Offset = "0x30DF54C", VA = "0x30DF54C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x30DF628", Offset = "0x30DF628", VA = "0x30DF628", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x30DF7F8", Offset = "0x30DF7F8", VA = "0x30DF7F8", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x30DFAC0", Offset = "0x30DFAC0", VA = "0x30DFAC0")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x30DFB9C", Offset = "0x30DFB9C", VA = "0x30DFB9C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10DD334", Offset = "0x10DD334")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10DD36C", Offset = "0x10DD36C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10DD3A4", Offset = "0x10DD3A4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10DD3DC", Offset = "0x10DD3DC")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD414", Offset = "0x10DD414")]
		public float blockedOffset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD42C", Offset = "0x10DD42C")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD43C", Offset = "0x10DD43C")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD44C", Offset = "0x10DD44C")]
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
			[Address(RVA = "0x2FCC5B8", Offset = "0x2FCC5B8", VA = "0x2FCC5B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5114", Offset = "0x10E5114")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2FCC5C0", Offset = "0x2FCC5C0", VA = "0x2FCC5C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5124", Offset = "0x10E5124")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2FCC5C8", Offset = "0x2FCC5C8", VA = "0x2FCC5C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5134", Offset = "0x10E5134")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2FCC5D0", Offset = "0x2FCC5D0", VA = "0x2FCC5D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5144", Offset = "0x10E5144")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2FCC5D8", Offset = "0x2FCC5D8", VA = "0x2FCC5D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5154", Offset = "0x10E5154")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2FCC5E0", Offset = "0x2FCC5E0", VA = "0x2FCC5E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E5164", Offset = "0x10E5164")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2FCCE68", Offset = "0x2FCCE68", VA = "0x2FCCE68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2FCC5E8", Offset = "0x2FCC5E8", VA = "0x2FCC5E8")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2FCC624", Offset = "0x2FCC624", VA = "0x2FCC624")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2FCC62C", Offset = "0x2FCC62C", VA = "0x2FCC62C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2FCC730", Offset = "0x2FCC730", VA = "0x2FCC730", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2FCC78C", Offset = "0x2FCC78C", VA = "0x2FCC78C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2FCC7F4", Offset = "0x2FCC7F4", VA = "0x2FCC7F4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2FCC858", Offset = "0x2FCC858", VA = "0x2FCC858")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2FCC764", Offset = "0x2FCC764", VA = "0x2FCC764")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2FCC9D8", Offset = "0x2FCC9D8", VA = "0x2FCC9D8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2FCCE38", Offset = "0x2FCCE38", VA = "0x2FCCE38")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2FCCED8", Offset = "0x2FCCED8", VA = "0x2FCCED8")]
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
		[Address(RVA = "0x2FCCF7C", Offset = "0x2FCCF7C", VA = "0x2FCCF7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2FCCFB4", Offset = "0x2FCCFB4", VA = "0x2FCCFB4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2FCD15C", Offset = "0x2FCD15C", VA = "0x2FCD15C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2FCD18C", Offset = "0x2FCD18C", VA = "0x2FCD18C")]
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
		[Address(RVA = "0x2FC0E24", Offset = "0x2FC0E24", VA = "0x2FC0E24")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2FC0E48", Offset = "0x2FC0E48", VA = "0x2FC0E48")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2FC0E80", Offset = "0x2FC0E80", VA = "0x2FC0E80")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2FC0F70", Offset = "0x2FC0F70", VA = "0x2FC0F70")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2FC0F18", Offset = "0x2FC0F18", VA = "0x2FC0F18")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2FC1008", Offset = "0x2FC1008", VA = "0x2FC1008")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2FC1050", Offset = "0x2FC1050", VA = "0x2FC1050")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2FC1214", Offset = "0x2FC1214", VA = "0x2FC1214")]
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
			[Address(RVA = "0x2D7865C", Offset = "0x2D7865C", VA = "0x2D7865C")]
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
			[Address(RVA = "0x2FC5870", Offset = "0x2FC5870", VA = "0x2FC5870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2FC5ADC", Offset = "0x2FC5ADC", VA = "0x2FC5ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2FC5824", Offset = "0x2FC5824", VA = "0x2FC5824")]
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
		[Address(RVA = "0x2FC5D48", Offset = "0x2FC5D48", VA = "0x2FC5D48")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2FC6064", Offset = "0x2FC6064", VA = "0x2FC6064")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2FC62D0", Offset = "0x2FC62D0", VA = "0x2FC62D0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2FC6350", Offset = "0x2FC6350", VA = "0x2FC6350")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2FC63F8", Offset = "0x2FC63F8", VA = "0x2FC63F8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2FC5F18", Offset = "0x2FC5F18", VA = "0x2FC5F18")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2FC6234", Offset = "0x2FC6234", VA = "0x2FC6234")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2FC6C28", Offset = "0x2FC6C28", VA = "0x2FC6C28")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2FC6A30", Offset = "0x2FC6A30", VA = "0x2FC6A30")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2FC6B2C", Offset = "0x2FC6B2C", VA = "0x2FC6B2C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2FC6610", Offset = "0x2FC6610", VA = "0x2FC6610")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2FC66C0", Offset = "0x2FC66C0", VA = "0x2FC66C0")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2FC6770", Offset = "0x2FC6770", VA = "0x2FC6770")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2FC6820", Offset = "0x2FC6820", VA = "0x2FC6820")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x2FC68D0", Offset = "0x2FC68D0", VA = "0x2FC68D0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2FC6980", Offset = "0x2FC6980", VA = "0x2FC6980")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2FC6E30", Offset = "0x2FC6E30", VA = "0x2FC6E30")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2FC6528", Offset = "0x2FC6528", VA = "0x2FC6528")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2FC6DA0", Offset = "0x2FC6DA0", VA = "0x2FC6DA0")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2FC6E9C", Offset = "0x2FC6E9C", VA = "0x2FC6E9C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2FC6F70", Offset = "0x2FC6F70", VA = "0x2FC6F70")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2FC6D28", Offset = "0x2FC6D28", VA = "0x2FC6D28")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2FC6CB4", Offset = "0x2FC6CB4", VA = "0x2FC6CB4")]
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
				[Address(RVA = "0x2D786E8", Offset = "0x2D786E8", VA = "0x2D786E8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2D786D4", Offset = "0x2D786D4", VA = "0x2D786D4")]
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
			[Address(RVA = "0x2FC8FB4", Offset = "0x2FC8FB4", VA = "0x2FC8FB4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x2FC939C", Offset = "0x2FC939C", VA = "0x2FC939C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2FC93AC", Offset = "0x2FC93AC", VA = "0x2FC93AC", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2FC97D4", Offset = "0x2FC97D4", VA = "0x2FC97D4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2FC9C08", Offset = "0x2FC9C08", VA = "0x2FC9C08")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2FCA1F4", Offset = "0x2FCA1F4", VA = "0x2FCA1F4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2FC9E1C", Offset = "0x2FC9E1C", VA = "0x2FC9E1C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2FC4BF8", Offset = "0x2FC4BF8", VA = "0x2FC4BF8")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2FCA9F4", Offset = "0x2FCA9F4", VA = "0x2FCA9F4")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2FCAF54", Offset = "0x2FCAF54", VA = "0x2FCAF54")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2FCAD48", Offset = "0x2FCAD48", VA = "0x2FCAD48")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2FCABC4", Offset = "0x2FCABC4", VA = "0x2FCABC4")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2FCAA94", Offset = "0x2FCAA94", VA = "0x2FCAA94")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2FCAE54", Offset = "0x2FCAE54", VA = "0x2FCAE54")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2FCB04C", Offset = "0x2FCB04C", VA = "0x2FCB04C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2FCBB70", Offset = "0x2FCBB70", VA = "0x2FCBB70")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2FCB5F8", Offset = "0x2FCB5F8", VA = "0x2FCB5F8")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2FCBE18", Offset = "0x2FCBE18", VA = "0x2FCBE18")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2FCB964", Offset = "0x2FCB964", VA = "0x2FCB964")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2FCBE20", Offset = "0x2FCBE20", VA = "0x2FCBE20")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2FCBE28", Offset = "0x2FCBE28", VA = "0x2FCBE28")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2FCBFF0", Offset = "0x2FCBFF0", VA = "0x2FCBFF0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2FCC1AC", Offset = "0x2FCC1AC", VA = "0x2FCC1AC")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2FC5054", Offset = "0x2FC5054", VA = "0x2FC5054")]
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
		[Address(RVA = "0x3065CA0", Offset = "0x3065CA0", VA = "0x3065CA0")]
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
		[Address(RVA = "0x306652C", Offset = "0x306652C", VA = "0x306652C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x3066674", Offset = "0x3066674", VA = "0x3066674")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x30DCE64", Offset = "0x30DCE64", VA = "0x30DCE64")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x30DD050", Offset = "0x30DD050", VA = "0x30DD050")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x30DCEFC", Offset = "0x30DCEFC", VA = "0x30DCEFC")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x30DD170", Offset = "0x30DD170", VA = "0x30DD170")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x30DD29C", Offset = "0x30DD29C", VA = "0x30DD29C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x30DD4E8", Offset = "0x30DD4E8", VA = "0x30DD4E8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x30DD5F0", Offset = "0x30DD5F0", VA = "0x30DD5F0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x30DD764", Offset = "0x30DD764", VA = "0x30DD764")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x30DDB40", Offset = "0x30DDB40", VA = "0x30DDB40")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x30DD904", Offset = "0x30DD904", VA = "0x30DD904")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x30DDCF4", Offset = "0x30DDCF4", VA = "0x30DDCF4")]
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
		[Address(RVA = "0x3095C50", Offset = "0x3095C50", VA = "0x3095C50")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3095CBC", Offset = "0x3095CBC", VA = "0x3095CBC")]
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
		[Address(RVA = "0x2EF6A68", Offset = "0x2EF6A68", VA = "0x2EF6A68")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2EF7414", Offset = "0x2EF7414", VA = "0x2EF7414")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2EF7488", Offset = "0x2EF7488", VA = "0x2EF7488")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2EF6E7C", Offset = "0x2EF6E7C", VA = "0x2EF6E7C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2EF6E88", Offset = "0x2EF6E88", VA = "0x2EF6E88")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2EF6EAC", Offset = "0x2EF6EAC", VA = "0x2EF6EAC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2EF6EE8", Offset = "0x2EF6EE8", VA = "0x2EF6EE8")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2EF6F00", Offset = "0x2EF6F00", VA = "0x2EF6F00")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2EF6F14", Offset = "0x2EF6F14", VA = "0x2EF6F14")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2EF6F28", Offset = "0x2EF6F28", VA = "0x2EF6F28")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2EF6F38", Offset = "0x2EF6F38", VA = "0x2EF6F38")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2EF6F80", Offset = "0x2EF6F80", VA = "0x2EF6F80")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2EF6FB8", Offset = "0x2EF6FB8", VA = "0x2EF6FB8")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2EF6FE0", Offset = "0x2EF6FE0", VA = "0x2EF6FE0")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2EF7514", Offset = "0x2EF7514", VA = "0x2EF7514")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2EF7014", Offset = "0x2EF7014", VA = "0x2EF7014")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2EF703C", Offset = "0x2EF703C", VA = "0x2EF703C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2EF706C", Offset = "0x2EF706C", VA = "0x2EF706C")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2EF70A0", Offset = "0x2EF70A0", VA = "0x2EF70A0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2EF70E4", Offset = "0x2EF70E4", VA = "0x2EF70E4")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2EF7148", Offset = "0x2EF7148", VA = "0x2EF7148")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2EF71AC", Offset = "0x2EF71AC", VA = "0x2EF71AC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2EF7200", Offset = "0x2EF7200", VA = "0x2EF7200")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2EF7254", Offset = "0x2EF7254", VA = "0x2EF7254")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2EF7290", Offset = "0x2EF7290", VA = "0x2EF7290")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2EF72C8", Offset = "0x2EF72C8", VA = "0x2EF72C8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2EF7548", Offset = "0x2EF7548", VA = "0x2EF7548")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2EF7310", Offset = "0x2EF7310", VA = "0x2EF7310")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2EF73A4", Offset = "0x2EF73A4", VA = "0x2EF73A4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2EF73D4", Offset = "0x2EF73D4", VA = "0x2EF73D4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2EF75DC", Offset = "0x2EF75DC", VA = "0x2EF75DC")]
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
		[Address(RVA = "0x2EF7698", Offset = "0x2EF7698", VA = "0x2EF7698")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2EF7704", Offset = "0x2EF7704", VA = "0x2EF7704")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2EF7770", Offset = "0x2EF7770", VA = "0x2EF7770")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2EF77C8", Offset = "0x2EF77C8", VA = "0x2EF77C8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2EF7894", Offset = "0x2EF7894", VA = "0x2EF7894")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2EF77E0", Offset = "0x2EF77E0", VA = "0x2EF77E0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2EF78AC", Offset = "0x2EF78AC", VA = "0x2EF78AC")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2EF7950", Offset = "0x2EF7950", VA = "0x2EF7950")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2EF797C", Offset = "0x2EF797C", VA = "0x2EF797C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2EF79CC", Offset = "0x2EF79CC", VA = "0x2EF79CC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2EF7A38", Offset = "0x2EF7A38", VA = "0x2EF7A38")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2EF7B4C", Offset = "0x2EF7B4C", VA = "0x2EF7B4C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2EF7C44", Offset = "0x2EF7C44", VA = "0x2EF7C44")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2EF7CA0", Offset = "0x2EF7CA0", VA = "0x2EF7CA0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2EFDE9C", Offset = "0x2EFDE9C", VA = "0x2EFDE9C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2EFDEEC", Offset = "0x2EFDEEC", VA = "0x2EFDEEC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2EFDF3C", Offset = "0x2EFDF3C", VA = "0x2EFDF3C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2EFDFE4", Offset = "0x2EFDFE4", VA = "0x2EFDFE4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2EF6778", Offset = "0x2EF6778", VA = "0x2EF6778")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2EFE08C", Offset = "0x2EFE08C", VA = "0x2EFE08C")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2EFE0E0", Offset = "0x2EFE0E0", VA = "0x2EFE0E0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2EFD6CC", Offset = "0x2EFD6CC", VA = "0x2EFD6CC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2EFE1B4", Offset = "0x2EFE1B4", VA = "0x2EFE1B4")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2EFE344", Offset = "0x2EFE344", VA = "0x2EFE344")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2EFE438", Offset = "0x2EFE438", VA = "0x2EFE438")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2EFE544", Offset = "0x2EFE544", VA = "0x2EFE544")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2EFE630", Offset = "0x2EFE630", VA = "0x2EFE630")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD46C", Offset = "0x10DD46C")]
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
			[Address(RVA = "0x2D710A4", Offset = "0x2D710A4", VA = "0x2D710A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2D713B0", Offset = "0x2D713B0", VA = "0x2D713B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2D70F64", Offset = "0x2D70F64", VA = "0x2D70F64")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2D71004", Offset = "0x2D71004", VA = "0x2D71004", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2D71008", Offset = "0x2D71008", VA = "0x2D71008", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2D7100C", Offset = "0x2D7100C", VA = "0x2D7100C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2D71010", Offset = "0x2D71010", VA = "0x2D71010")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2D710A0", Offset = "0x2D710A0", VA = "0x2D710A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2D71048", Offset = "0x2D71048", VA = "0x2D71048")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2D71364", Offset = "0x2D71364", VA = "0x2D71364")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2D71190", Offset = "0x2D71190", VA = "0x2D71190")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2D71468", Offset = "0x2D71468", VA = "0x2D71468")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2D714C4", Offset = "0x2D714C4", VA = "0x2D714C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2D71520", Offset = "0x2D71520", VA = "0x2D71520")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2D71568", Offset = "0x2D71568", VA = "0x2D71568")]
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
		[Address(RVA = "0x2D71BDC", Offset = "0x2D71BDC", VA = "0x2D71BDC")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2D71C9C", Offset = "0x2D71C9C", VA = "0x2D71C9C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2D71D5C", Offset = "0x2D71D5C", VA = "0x2D71D5C")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2D71E1C", Offset = "0x2D71E1C", VA = "0x2D71E1C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V3Tools
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2D737C4", Offset = "0x2D737C4", VA = "0x2D737C4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2D73864", Offset = "0x2D73864", VA = "0x2D73864")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2D738A0", Offset = "0x2D738A0", VA = "0x2D738A0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2D738E4", Offset = "0x2D738E4", VA = "0x2D738E4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2D73980", Offset = "0x2D73980", VA = "0x2D73980")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2D73ADC", Offset = "0x2D73ADC", VA = "0x2D73ADC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2D73C58", Offset = "0x2D73C58", VA = "0x2D73C58")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2D73DDC", Offset = "0x2D73DDC", VA = "0x2D73DDC")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2D73E98", Offset = "0x2D73E98", VA = "0x2D73E98")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2D73F98", Offset = "0x2D73F98", VA = "0x2D73F98")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2D74020", Offset = "0x2D74020", VA = "0x2D74020")]
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
		[Address(RVA = "0x2D77EC8", Offset = "0x2D77EC8", VA = "0x2D77EC8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2D77F60", Offset = "0x2D77F60", VA = "0x2D77F60")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DBE9C", Offset = "0x10DBE9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DBE9C", Offset = "0x10DBE9C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2FC42D8", Offset = "0x2FC42D8", VA = "0x2FC42D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E51E4", Offset = "0x10E51E4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2FC4320", Offset = "0x2FC4320", VA = "0x2FC4320")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E521C", Offset = "0x10E521C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2FC4368", Offset = "0x2FC4368", VA = "0x2FC4368")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5254", Offset = "0x10E5254")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2FC43B0", Offset = "0x2FC43B0", VA = "0x2FC43B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E528C", Offset = "0x10E528C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2FC43F8", Offset = "0x2FC43F8", VA = "0x2FC43F8")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2FC4494", Offset = "0x2FC4494", VA = "0x2FC4494")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2FC44B4", Offset = "0x2FC44B4", VA = "0x2FC44B4")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2FC44E4", Offset = "0x2FC44E4", VA = "0x2FC44E4")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2FC4514", Offset = "0x2FC4514", VA = "0x2FC4514")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2FC4554", Offset = "0x2FC4554", VA = "0x2FC4554")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2FC4598", Offset = "0x2FC4598", VA = "0x2FC4598")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2FC45BC", Offset = "0x2FC45BC", VA = "0x2FC45BC")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2FC45E0", Offset = "0x2FC45E0", VA = "0x2FC45E0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2FC4608", Offset = "0x2FC4608", VA = "0x2FC4608")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2FC4634", Offset = "0x2FC4634", VA = "0x2FC4634")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2FC4660", Offset = "0x2FC4660", VA = "0x2FC4660")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2FC4418", Offset = "0x2FC4418", VA = "0x2FC4418")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2FC4688", Offset = "0x2FC4688", VA = "0x2FC4688")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2FC4694", Offset = "0x2FC4694", VA = "0x2FC4694")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2FC46A0", Offset = "0x2FC46A0", VA = "0x2FC46A0")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2FC4984", Offset = "0x2FC4984", VA = "0x2FC4984", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2FC4A2C", Offset = "0x2FC4A2C", VA = "0x2FC4A2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2FC4E0C", Offset = "0x2FC4E0C", VA = "0x2FC4E0C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2FC4F98", Offset = "0x2FC4F98", VA = "0x2FC4F98")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2FC4FCC", Offset = "0x2FC4FCC", VA = "0x2FC4FCC")]
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
			[Address(RVA = "0x2FC4840", Offset = "0x2FC4840", VA = "0x2FC4840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x2FC5234", Offset = "0x2FC5234", VA = "0x2FC5234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2FC4CE8", Offset = "0x2FC4CE8", VA = "0x2FC4CE8")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2FC50C0", Offset = "0x2FC50C0", VA = "0x2FC50C0")]
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
			[Address(RVA = "0x3065CA8", Offset = "0x3065CA8", VA = "0x3065CA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x3065D14", Offset = "0x3065D14", VA = "0x3065D14")]
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
		[Address(RVA = "0x3065D1C", Offset = "0x3065D1C", VA = "0x3065D1C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3065DDC", Offset = "0x3065DDC", VA = "0x3065DDC")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x3065DE4", Offset = "0x3065DE4", VA = "0x3065DE4")]
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
			[Address(RVA = "0x3065F18", Offset = "0x3065F18", VA = "0x3065F18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x3065E10", Offset = "0x3065E10", VA = "0x3065E10", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x3065F54", Offset = "0x3065F54", VA = "0x3065F54")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x3065F5C", Offset = "0x3065F5C", VA = "0x3065F5C")]
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
		[Address(RVA = "0x3065F88", Offset = "0x3065F88", VA = "0x3065F88", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x3066008", Offset = "0x3066008", VA = "0x3066008")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x3066010", Offset = "0x3066010", VA = "0x3066010")]
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
			[Address(RVA = "0x3066144", Offset = "0x3066144", VA = "0x3066144")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x306603C", Offset = "0x306603C", VA = "0x306603C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x3066180", Offset = "0x3066180", VA = "0x3066180")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x3066188", Offset = "0x3066188", VA = "0x3066188")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD4A4", Offset = "0x10DD4A4")]
		public float positionWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD4BC", Offset = "0x10DD4BC")]
		public float rotationWeight;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x30661B4", Offset = "0x30661B4", VA = "0x30661B4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x3066220", Offset = "0x3066220", VA = "0x3066220")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x3066274", Offset = "0x3066274", VA = "0x3066274")]
		public void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x3066524", Offset = "0x3066524", VA = "0x3066524")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD4D4", Offset = "0x10DD4D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD4D4", Offset = "0x10DD4D4")]
		public float weight;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD528", Offset = "0x10DD528")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD528", Offset = "0x10DD528")]
		public float rotationWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD57C", Offset = "0x10DD57C")]
		public DOF rotationDOF;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD5B4", Offset = "0x10DD5B4")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD5EC", Offset = "0x10DD5EC")]
		public Transform bone1;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD624", Offset = "0x10DD624")]
		public Transform bone2;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD65C", Offset = "0x10DD65C")]
		public Transform bone3;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD694", Offset = "0x10DD694")]
		public Transform tip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD6CC", Offset = "0x10DD6CC")]
		public Transform target;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD704", Offset = "0x10DD704")]
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
			[Address(RVA = "0x306E8F4", Offset = "0x306E8F4", VA = "0x306E8F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E52C4", Offset = "0x10E52C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x306E8FC", Offset = "0x306E8FC", VA = "0x306E8FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E52D4", Offset = "0x10E52D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x306E908", Offset = "0x306E908", VA = "0x306E908")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x306E928", Offset = "0x306E928", VA = "0x306E928")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x306E948", Offset = "0x306E948", VA = "0x306E948")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x306E968", Offset = "0x306E968", VA = "0x306E968")]
			set
			{
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x306E988", Offset = "0x306E988", VA = "0x306E988")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x306EA90", Offset = "0x306EA90", VA = "0x306EA90")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x306EF34", Offset = "0x306EF34", VA = "0x306EF34")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x306F00C", Offset = "0x306F00C", VA = "0x306F00C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x306F0D0", Offset = "0x306F0D0", VA = "0x306F0D0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x306F618", Offset = "0x306F618", VA = "0x306F618")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD714", Offset = "0x10DD714")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD714", Offset = "0x10DD714")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD768", Offset = "0x10DD768")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x306F628", Offset = "0x306F628", VA = "0x306F628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E52E4", Offset = "0x10E52E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x306F630", Offset = "0x306F630", VA = "0x306F630")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E52F4", Offset = "0x10E52F4")]
			private set
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x306F63C", Offset = "0x306F63C", VA = "0x306F63C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x306F6C4", Offset = "0x306F6C4", VA = "0x306F6C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5304", Offset = "0x10E5304")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x306F9FC", Offset = "0x306F9FC", VA = "0x306F9FC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x306FB74", Offset = "0x306FB74", VA = "0x306FB74")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x306F900", Offset = "0x306F900", VA = "0x306F900")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x306FCE4", Offset = "0x306FCE4", VA = "0x306FCE4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x306FDA4", Offset = "0x306FDA4", VA = "0x306FDA4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x306FE1C", Offset = "0x306FE1C", VA = "0x306FE1C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x306FE90", Offset = "0x306FE90", VA = "0x306FE90")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x306FEF8", Offset = "0x306FEF8", VA = "0x306FEF8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x306FEFC", Offset = "0x306FEFC", VA = "0x306FEFC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x306FF10", Offset = "0x306FF10", VA = "0x306FF10")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DD778", Offset = "0x10DD778")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD778", Offset = "0x10DD778")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD7CC", Offset = "0x10DD7CC")]
		public Grounding solver;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DD804", Offset = "0x10DD804")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x3071324", Offset = "0x3071324", VA = "0x3071324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E533C", Offset = "0x10E533C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x307132C", Offset = "0x307132C", VA = "0x307132C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E534C", Offset = "0x10E534C")]
			protected set
			{
			}
		}

		[Token(Token = "0x600015A")]
		public abstract void ResetPosition();

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x3071338", Offset = "0x3071338", VA = "0x3071338")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x30714E4", Offset = "0x30714E4", VA = "0x30714E4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x30713E4", Offset = "0x30713E4", VA = "0x30713E4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x3071518", Offset = "0x3071518", VA = "0x3071518")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000162")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x3071654", Offset = "0x3071654", VA = "0x3071654")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DBEFC", Offset = "0x10DBEFC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DBEFC", Offset = "0x10DBEFC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD814", Offset = "0x10DD814")]
		public BipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD84C", Offset = "0x10DD84C")]
		public float spineBend;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD884", Offset = "0x10DD884")]
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
		[Address(RVA = "0x30716C0", Offset = "0x30716C0", VA = "0x30716C0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E535C", Offset = "0x10E535C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x3071708", Offset = "0x3071708", VA = "0x3071708", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5394", Offset = "0x10E5394")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x3071750", Offset = "0x3071750", VA = "0x3071750", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x3071790", Offset = "0x3071790", VA = "0x3071790")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x307183C", Offset = "0x307183C", VA = "0x307183C")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x307189C", Offset = "0x307189C", VA = "0x307189C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x3071B60", Offset = "0x3071B60", VA = "0x3071B60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x3071BB4", Offset = "0x3071BB4", VA = "0x3071BB4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3071FB0", Offset = "0x3071FB0", VA = "0x3071FB0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x3072084", Offset = "0x3072084", VA = "0x3072084")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x30721C4", Offset = "0x30721C4", VA = "0x30721C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x3072354", Offset = "0x3072354", VA = "0x3072354")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DBF5C", Offset = "0x10DBF5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DBF5C", Offset = "0x10DBF5C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD964", Offset = "0x10DD964")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD99C", Offset = "0x10DD99C")]
			public float horizontalWeight;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD9D4", Offset = "0x10DD9D4")]
			public float verticalWeight;

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2D79434", Offset = "0x2D79434", VA = "0x2D79434")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2D79444", Offset = "0x2D79444", VA = "0x2D79444")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD8BC", Offset = "0x10DD8BC")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD8F4", Offset = "0x10DD8F4")]
		public float spineBend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DD92C", Offset = "0x10DD92C")]
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
		[Address(RVA = "0x307278C", Offset = "0x307278C", VA = "0x307278C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E53CC", Offset = "0x10E53CC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x30727D4", Offset = "0x30727D4", VA = "0x30727D4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5404", Offset = "0x10E5404")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x307281C", Offset = "0x307281C", VA = "0x307281C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E543C", Offset = "0x10E543C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x3072864", Offset = "0x3072864", VA = "0x3072864", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x30728A4", Offset = "0x30728A4", VA = "0x30728A4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x3072938", Offset = "0x3072938", VA = "0x3072938")]
		private void Update()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x3072BB8", Offset = "0x3072BB8", VA = "0x3072BB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x3072BC4", Offset = "0x3072BC4", VA = "0x3072BC4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x30729A0", Offset = "0x30729A0", VA = "0x30729A0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x3072BD0", Offset = "0x3072BD0", VA = "0x3072BD0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x3072EF0", Offset = "0x3072EF0", VA = "0x3072EF0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x3073000", Offset = "0x3073000", VA = "0x3073000")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x3073158", Offset = "0x3073158", VA = "0x3073158")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x307326C", Offset = "0x307326C", VA = "0x307326C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DBFBC", Offset = "0x10DBFBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DBFBC", Offset = "0x10DBFBC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDA0C", Offset = "0x10DDA0C")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDA44", Offset = "0x10DDA44")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDA7C", Offset = "0x10DDA7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DDA7C", Offset = "0x10DDA7C")]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDAD0", Offset = "0x10DDAD0")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDB08", Offset = "0x10DDB08")]
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
		[Address(RVA = "0x30732F4", Offset = "0x30732F4", VA = "0x30732F4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5474", Offset = "0x10E5474")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x307333C", Offset = "0x307333C", VA = "0x307333C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E54AC", Offset = "0x10E54AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x3073384", Offset = "0x3073384", VA = "0x3073384", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x30733A0", Offset = "0x30733A0", VA = "0x30733A0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x30735D4", Offset = "0x30735D4", VA = "0x30735D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x30736D0", Offset = "0x30736D0", VA = "0x30736D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3073B1C", Offset = "0x3073B1C", VA = "0x3073B1C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x3073F28", Offset = "0x3073F28", VA = "0x3073F28")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x30740B8", Offset = "0x30740B8", VA = "0x30740B8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x30743BC", Offset = "0x30743BC", VA = "0x30743BC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3074508", Offset = "0x3074508", VA = "0x3074508")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x30746F0", Offset = "0x30746F0", VA = "0x30746F0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC01C", Offset = "0x10DC01C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC01C", Offset = "0x10DC01C")]
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
			[Address(RVA = "0x2D7948C", Offset = "0x2D7948C", VA = "0x2D7948C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDB40", Offset = "0x10DDB40")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDB78", Offset = "0x10DDB78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DDB78", Offset = "0x10DDB78")]
		public float rootRotationWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DDBCC", Offset = "0x10DDBCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDBCC", Offset = "0x10DDBCC")]
		public float minRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DDC24", Offset = "0x10DDC24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDC24", Offset = "0x10DDC24")]
		public float maxRootRotation;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDC7C", Offset = "0x10DDC7C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDCB4", Offset = "0x10DDCB4")]
		public float maxLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDCEC", Offset = "0x10DDCEC")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DDD24", Offset = "0x10DDD24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDD24", Offset = "0x10DDD24")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDD78", Offset = "0x10DDD78")]
		public Transform characterRoot;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDDB0", Offset = "0x10DDDB0")]
		public Transform pelvis;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDDE8", Offset = "0x10DDDE8")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDE20", Offset = "0x10DDE20")]
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
		[Address(RVA = "0x3074778", Offset = "0x3074778", VA = "0x3074778", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E54E4", Offset = "0x10E54E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x30747C0", Offset = "0x30747C0", VA = "0x30747C0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E551C", Offset = "0x10E551C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x3074808", Offset = "0x3074808", VA = "0x3074808", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3074844", Offset = "0x3074844", VA = "0x3074844")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3074970", Offset = "0x3074970", VA = "0x3074970")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x3074B74", Offset = "0x3074B74", VA = "0x3074B74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x3074BDC", Offset = "0x3074BDC", VA = "0x3074BDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3074C40", Offset = "0x3074C40", VA = "0x3074C40")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3074F74", Offset = "0x3074F74", VA = "0x3074F74")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x30752B8", Offset = "0x30752B8", VA = "0x30752B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x30753B0", Offset = "0x30753B0", VA = "0x30753B0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x307577C", Offset = "0x307577C", VA = "0x307577C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x3075DA0", Offset = "0x3075DA0", VA = "0x3075DA0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x3075F70", Offset = "0x3075F70", VA = "0x3075F70")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x307604C", Offset = "0x307604C", VA = "0x307604C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3076294", Offset = "0x3076294", VA = "0x3076294")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x30762CC", Offset = "0x30762CC", VA = "0x30762CC")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x30764AC", Offset = "0x30764AC", VA = "0x30764AC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC07C", Offset = "0x10DC07C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC07C", Offset = "0x10DC07C")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDE68", Offset = "0x10DDE68")]
		public VRIK ik;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x30DAE30", Offset = "0x30DAE30", VA = "0x30DAE30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5554", Offset = "0x10E5554")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x30DAE78", Offset = "0x30DAE78", VA = "0x30DAE78", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E558C", Offset = "0x10E558C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x30DAEC0", Offset = "0x30DAEC0", VA = "0x30DAEC0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E55C4", Offset = "0x10E55C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x30DAF08", Offset = "0x30DAF08", VA = "0x30DAF08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x30DAFAC", Offset = "0x30DAFAC", VA = "0x30DAFAC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x30DB040", Offset = "0x30DB040", VA = "0x30DB040")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x30DB0A0", Offset = "0x30DB0A0", VA = "0x30DB0A0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x30DB548", Offset = "0x30DB548", VA = "0x30DB548")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x30DB980", Offset = "0x30DB980", VA = "0x30DB980")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x30DBA10", Offset = "0x30DBA10", VA = "0x30DBA10")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x30DBBCC", Offset = "0x30DBBCC", VA = "0x30DBBCC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x30DBD24", Offset = "0x30DBD24", VA = "0x30DBD24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x30DBEA4", Offset = "0x30DBEA4", VA = "0x30DBEA4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE34C", Offset = "0x10DE34C")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE35C", Offset = "0x10DE35C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE36C", Offset = "0x10DE36C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE37C", Offset = "0x10DE37C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE38C", Offset = "0x10DE38C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE39C", Offset = "0x10DE39C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE3AC", Offset = "0x10DE3AC")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE3BC", Offset = "0x10DE3BC")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE3CC", Offset = "0x10DE3CC")]
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
				[Address(RVA = "0x2D794CC", Offset = "0x2D794CC", VA = "0x2D794CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E569C", Offset = "0x10E569C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x2D794D4", Offset = "0x2D794D4", VA = "0x2D794D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E56AC", Offset = "0x10E56AC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x2D794E0", Offset = "0x2D794E0", VA = "0x2D794E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E56BC", Offset = "0x10E56BC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x2D794EC", Offset = "0x2D794EC", VA = "0x2D794EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E56CC", Offset = "0x10E56CC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x2D794F8", Offset = "0x2D794F8", VA = "0x2D794F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E56DC", Offset = "0x10E56DC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x2D79500", Offset = "0x2D79500", VA = "0x2D79500")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E56EC", Offset = "0x10E56EC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x2D7950C", Offset = "0x2D7950C", VA = "0x2D7950C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E56FC", Offset = "0x10E56FC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x2D79514", Offset = "0x2D79514", VA = "0x2D79514")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E570C", Offset = "0x10E570C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x2D7951C", Offset = "0x2D7951C", VA = "0x2D7951C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E571C", Offset = "0x10E571C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x2D79528", Offset = "0x2D79528", VA = "0x2D79528")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E572C", Offset = "0x10E572C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x2D79534", Offset = "0x2D79534", VA = "0x2D79534")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E573C", Offset = "0x10E573C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x2D7953C", Offset = "0x2D7953C", VA = "0x2D7953C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E574C", Offset = "0x10E574C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x2D79544", Offset = "0x2D79544", VA = "0x2D79544")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E575C", Offset = "0x10E575C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x2D7954C", Offset = "0x2D7954C", VA = "0x2D7954C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E576C", Offset = "0x10E576C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x2D79554", Offset = "0x2D79554", VA = "0x2D79554")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E577C", Offset = "0x10E577C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x2D7956C", Offset = "0x2D7956C", VA = "0x2D7956C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E578C", Offset = "0x10E578C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x2D7958C", Offset = "0x2D7958C", VA = "0x2D7958C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E579C", Offset = "0x10E579C")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x2D795A4", Offset = "0x2D795A4", VA = "0x2D795A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E57AC", Offset = "0x10E57AC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x2D795C4", Offset = "0x2D795C4", VA = "0x2D795C4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x2D7A5BC", Offset = "0x2D7A5BC", VA = "0x2D7A5BC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x2D7A720", Offset = "0x2D7A720", VA = "0x2D7A720")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x2D7960C", Offset = "0x2D7960C", VA = "0x2D7960C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x2D79620", Offset = "0x2D79620", VA = "0x2D79620")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2D79694", Offset = "0x2D79694", VA = "0x2D79694")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2D796E0", Offset = "0x2D796E0", VA = "0x2D796E0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2D79750", Offset = "0x2D79750", VA = "0x2D79750")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x2D7A234", Offset = "0x2D7A234", VA = "0x2D7A234")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x2D79DD8", Offset = "0x2D79DD8", VA = "0x2D79DD8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x2D7A650", Offset = "0x2D7A650", VA = "0x2D7A650")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x2D7A074", Offset = "0x2D7A074", VA = "0x2D7A074")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2D7A100", Offset = "0x2D7A100", VA = "0x2D7A100")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x2D7A6C0", Offset = "0x2D7A6C0", VA = "0x2D7A6C0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x2D7A5E4", Offset = "0x2D7A5E4", VA = "0x2D7A5E4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x2D7A7B4", Offset = "0x2D7A7B4", VA = "0x2D7A7B4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x2D7A840", Offset = "0x2D7A840", VA = "0x2D7A840")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE3DC", Offset = "0x10DE3DC")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE3EC", Offset = "0x10DE3EC")]
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
				[Address(RVA = "0x2D7A884", Offset = "0x2D7A884", VA = "0x2D7A884")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E57BC", Offset = "0x10E57BC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x2D7A890", Offset = "0x2D7A890", VA = "0x2D7A890")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E57CC", Offset = "0x10E57CC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x2D7A89C", Offset = "0x2D7A89C", VA = "0x2D7A89C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E57DC", Offset = "0x10E57DC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x2D7A8A4", Offset = "0x2D7A8A4", VA = "0x2D7A8A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E57EC", Offset = "0x10E57EC")]
				private set
				{
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x2D7A8AC", Offset = "0x2D7A8AC", VA = "0x2D7A8AC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x2D7A91C", Offset = "0x2D7A91C", VA = "0x2D7A91C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x2D7A8BC", Offset = "0x2D7A8BC", VA = "0x2D7A8BC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2D7A988", Offset = "0x2D7A988", VA = "0x2D7A988")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x2D7AB28", Offset = "0x2D7AB28", VA = "0x2D7AB28")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDEA0", Offset = "0x10DDEA0")]
		public LayerMask layers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDED8", Offset = "0x10DDED8")]
		public float maxStep;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDF10", Offset = "0x10DDF10")]
		public float heightOffset;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDF48", Offset = "0x10DDF48")]
		public float footSpeed;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDF80", Offset = "0x10DDF80")]
		public float footRadius;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DDFB8", Offset = "0x10DDFB8")]
		public float footCenterOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE004", Offset = "0x10DE004")]
		public float prediction;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE03C", Offset = "0x10DE03C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE03C", Offset = "0x10DE03C")]
		public float footRotationWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE090", Offset = "0x10DE090")]
		public float footRotationSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE0C8", Offset = "0x10DE0C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE0C8", Offset = "0x10DE0C8")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE120", Offset = "0x10DE120")]
		public bool rotateSolver;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE158", Offset = "0x10DE158")]
		public float pelvisSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE190", Offset = "0x10DE190")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE190", Offset = "0x10DE190")]
		public float pelvisDamper;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE1E4", Offset = "0x10DE1E4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE21C", Offset = "0x10DE21C")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE254", Offset = "0x10DE254")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE28C", Offset = "0x10DE28C")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE2C4", Offset = "0x10DE2C4")]
		public Quality quality;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE2FC", Offset = "0x10DE2FC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE30C", Offset = "0x10DE30C")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE31C", Offset = "0x10DE31C")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE32C", Offset = "0x10DE32C")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DE33C", Offset = "0x10DE33C")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x30DBF00", Offset = "0x30DBF00", VA = "0x30DBF00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E55FC", Offset = "0x10E55FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x30DBF08", Offset = "0x30DBF08", VA = "0x30DBF08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E560C", Offset = "0x10E560C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x30DBF10", Offset = "0x30DBF10", VA = "0x30DBF10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E561C", Offset = "0x10E561C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x30DBF18", Offset = "0x30DBF18", VA = "0x30DBF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E562C", Offset = "0x10E562C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x30DBF20", Offset = "0x30DBF20", VA = "0x30DBF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E563C", Offset = "0x10E563C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x30DBF28", Offset = "0x30DBF28", VA = "0x30DBF28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E564C", Offset = "0x10E564C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x30DBF34", Offset = "0x30DBF34", VA = "0x30DBF34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E565C", Offset = "0x10E565C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x30DBF3C", Offset = "0x30DBF3C", VA = "0x30DBF3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E566C", Offset = "0x10E566C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x30DBF44", Offset = "0x30DBF44", VA = "0x30DBF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E567C", Offset = "0x10E567C")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x30DBF5C", Offset = "0x30DBF5C", VA = "0x30DBF5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E568C", Offset = "0x10E568C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x30DBF7C", Offset = "0x30DBF7C", VA = "0x30DBF7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x30DC21C", Offset = "0x30DC21C", VA = "0x30DC21C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x30DC4E0", Offset = "0x30DC4E0", VA = "0x30DC4E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x30DBFD0", Offset = "0x30DBFD0", VA = "0x30DBFD0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x30DC260", Offset = "0x30DC260", VA = "0x30DC260")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x30DB2C0", Offset = "0x30DB2C0", VA = "0x30DB2C0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x30DB738", Offset = "0x30DB738", VA = "0x30DB738")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x30DC380", Offset = "0x30DC380", VA = "0x30DC380")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x30DAF20", Offset = "0x30DAF20", VA = "0x30DAF20")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x30DC368", Offset = "0x30DC368", VA = "0x30DC368")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x30DC560", Offset = "0x30DC560", VA = "0x30DC560")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x30DC5F0", Offset = "0x30DC5F0", VA = "0x30DC5F0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x30DC6AC", Offset = "0x30DC6AC", VA = "0x30DC6AC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x30DC728", Offset = "0x30DC728", VA = "0x30DC728")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC0DC", Offset = "0x10DC0DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC0DC", Offset = "0x10DC0DC")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2FBEA28", Offset = "0x2FBEA28", VA = "0x2FBEA28", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E57FC", Offset = "0x10E57FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2FBEA70", Offset = "0x2FBEA70", VA = "0x2FBEA70", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5834", Offset = "0x10E5834")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2FBEAB8", Offset = "0x2FBEAB8", VA = "0x2FBEAB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E586C", Offset = "0x10E586C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2FBEB00", Offset = "0x2FBEB00", VA = "0x2FBEB00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E58A4", Offset = "0x10E58A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2FBEB48", Offset = "0x2FBEB48", VA = "0x2FBEB48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E58DC", Offset = "0x10E58DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2FBEB90", Offset = "0x2FBEB90", VA = "0x2FBEB90", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2FBEB98", Offset = "0x2FBEB98", VA = "0x2FBEB98")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC13C", Offset = "0x10DC13C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC13C", Offset = "0x10DC13C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2FC0488", Offset = "0x2FC0488", VA = "0x2FC0488", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5914", Offset = "0x10E5914")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2FC04D0", Offset = "0x2FC04D0", VA = "0x2FC04D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E594C", Offset = "0x10E594C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2FC0518", Offset = "0x2FC0518", VA = "0x2FC0518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5984", Offset = "0x10E5984")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2FC0560", Offset = "0x2FC0560", VA = "0x2FC0560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E59BC", Offset = "0x10E59BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2FC05A8", Offset = "0x2FC05A8", VA = "0x2FC05A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2FC05B0", Offset = "0x2FC05B0", VA = "0x2FC05B0")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC19C", Offset = "0x10DC19C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC19C", Offset = "0x10DC19C")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2FCC42C", Offset = "0x2FCC42C", VA = "0x2FCC42C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E59F4", Offset = "0x10E59F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2FCC474", Offset = "0x2FCC474", VA = "0x2FCC474", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5A2C", Offset = "0x10E5A2C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2FCC4BC", Offset = "0x2FCC4BC", VA = "0x2FCC4BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5A64", Offset = "0x10E5A64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2FCC504", Offset = "0x2FCC504", VA = "0x2FCC504")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5A9C", Offset = "0x10E5A9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2FCC54C", Offset = "0x2FCC54C", VA = "0x2FCC54C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2FCC554", Offset = "0x2FCC554", VA = "0x2FCC554")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC1FC", Offset = "0x10DC1FC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC1FC", Offset = "0x10DC1FC")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3067190", Offset = "0x3067190", VA = "0x3067190", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5AD4", Offset = "0x10E5AD4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x30671D8", Offset = "0x30671D8", VA = "0x30671D8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5B0C", Offset = "0x10E5B0C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x3067220", Offset = "0x3067220", VA = "0x3067220")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5B44", Offset = "0x10E5B44")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x3067268", Offset = "0x3067268", VA = "0x3067268")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5B7C", Offset = "0x10E5B7C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x30672B0", Offset = "0x30672B0", VA = "0x30672B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x30672B8", Offset = "0x30672B8", VA = "0x30672B8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC25C", Offset = "0x10DC25C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC25C", Offset = "0x10DC25C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x30677DC", Offset = "0x30677DC", VA = "0x30677DC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5BB4", Offset = "0x10E5BB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x3067824", Offset = "0x3067824", VA = "0x3067824", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5BEC", Offset = "0x10E5BEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x306786C", Offset = "0x306786C", VA = "0x306786C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5C24", Offset = "0x10E5C24")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x30678B4", Offset = "0x30678B4", VA = "0x30678B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5C5C", Offset = "0x10E5C5C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x30678FC", Offset = "0x30678FC", VA = "0x30678FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3067904", Offset = "0x3067904", VA = "0x3067904")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC2BC", Offset = "0x10DC2BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC2BC", Offset = "0x10DC2BC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x306FF74", Offset = "0x306FF74", VA = "0x306FF74", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5C94", Offset = "0x10E5C94")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x306FFBC", Offset = "0x306FFBC", VA = "0x306FFBC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5CCC", Offset = "0x10E5CCC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3070004", Offset = "0x3070004", VA = "0x3070004")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5D04", Offset = "0x10E5D04")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x307004C", Offset = "0x307004C", VA = "0x307004C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5D3C", Offset = "0x10E5D3C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3070094", Offset = "0x3070094", VA = "0x3070094")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5D74", Offset = "0x10E5D74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x30700DC", Offset = "0x30700DC", VA = "0x30700DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5DAC", Offset = "0x10E5DAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x3070124", Offset = "0x3070124", VA = "0x3070124")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x3070148", Offset = "0x3070148", VA = "0x3070148", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x3070150", Offset = "0x3070150", VA = "0x3070150")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x307032C", Offset = "0x307032C", VA = "0x307032C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x30705C0", Offset = "0x30705C0", VA = "0x30705C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5DE4", Offset = "0x10E5DE4")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x30705E0", Offset = "0x30705E0", VA = "0x30705E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5E1C", Offset = "0x10E5E1C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x30706B8", Offset = "0x30706B8", VA = "0x30706B8")]
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
		[Address(RVA = "0x30DFC2C", Offset = "0x30DFC2C", VA = "0x30DFC2C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x30DFD20", Offset = "0x30DFD20", VA = "0x30DFD20", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x30DFF04", Offset = "0x30DFF04", VA = "0x30DFF04", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000225")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x30DFF64", Offset = "0x30DFF64", VA = "0x30DFF64")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE3FC", Offset = "0x10DE3FC")]
		public IK[] IKComponents;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE434", Offset = "0x10DE434")]
		public Animator animator;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x30E24D4", Offset = "0x30E24D4", VA = "0x30E24D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x30E256C", Offset = "0x30E256C", VA = "0x30E256C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x30E25DC", Offset = "0x30E25DC", VA = "0x30E25DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x30E2698", Offset = "0x30E2698", VA = "0x30E2698")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x30E26D4", Offset = "0x30E26D4", VA = "0x30E26D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x30E2610", Offset = "0x30E2610", VA = "0x30E2610")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x30E2760", Offset = "0x30E2760", VA = "0x30E2760")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC31C", Offset = "0x10DC31C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC31C", Offset = "0x10DC31C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2EF7CD0", Offset = "0x2EF7CD0", VA = "0x2EF7CD0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5E54", Offset = "0x10E5E54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2EF7D18", Offset = "0x2EF7D18", VA = "0x2EF7D18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5E8C", Offset = "0x10E5E8C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2EF7D60", Offset = "0x2EF7D60", VA = "0x2EF7D60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5EC4", Offset = "0x10E5EC4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2EF7DA8", Offset = "0x2EF7DA8", VA = "0x2EF7DA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5EFC", Offset = "0x10E5EFC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2EF7DF0", Offset = "0x2EF7DF0", VA = "0x2EF7DF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2EF7DF8", Offset = "0x2EF7DF8", VA = "0x2EF7DF8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC37C", Offset = "0x10DC37C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC37C", Offset = "0x10DC37C")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2EF7E5C", Offset = "0x2EF7E5C", VA = "0x2EF7E5C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5F34", Offset = "0x10E5F34")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2EF7EA4", Offset = "0x2EF7EA4", VA = "0x2EF7EA4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5F6C", Offset = "0x10E5F6C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2EF7EEC", Offset = "0x2EF7EEC", VA = "0x2EF7EEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5FA4", Offset = "0x10E5FA4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2EF7F34", Offset = "0x2EF7F34", VA = "0x2EF7F34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E5FDC", Offset = "0x10E5FDC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2EF7F7C", Offset = "0x2EF7F7C", VA = "0x2EF7F7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2EF7F84", Offset = "0x2EF7F84", VA = "0x2EF7F84")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC3DC", Offset = "0x10DC3DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC3DC", Offset = "0x10DC3DC")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2EF895C", Offset = "0x2EF895C", VA = "0x2EF895C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6014", Offset = "0x10E6014")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2EF89A4", Offset = "0x2EF89A4", VA = "0x2EF89A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E604C", Offset = "0x10E604C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2EF89EC", Offset = "0x2EF89EC", VA = "0x2EF89EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6084", Offset = "0x10E6084")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2EF8A34", Offset = "0x2EF8A34", VA = "0x2EF8A34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E60BC", Offset = "0x10E60BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2EF8A7C", Offset = "0x2EF8A7C", VA = "0x2EF8A7C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2EF8A84", Offset = "0x2EF8A84", VA = "0x2EF8A84")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC43C", Offset = "0x10DC43C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC43C", Offset = "0x10DC43C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2D71E24", Offset = "0x2D71E24", VA = "0x2D71E24", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E60F4", Offset = "0x10E60F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2D71E6C", Offset = "0x2D71E6C", VA = "0x2D71E6C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E612C", Offset = "0x10E612C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2D71EB4", Offset = "0x2D71EB4", VA = "0x2D71EB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6164", Offset = "0x10E6164")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2D71EFC", Offset = "0x2D71EFC", VA = "0x2D71EFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E619C", Offset = "0x10E619C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2D71F44", Offset = "0x2D71F44", VA = "0x2D71F44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2D71F4C", Offset = "0x2D71F4C", VA = "0x2D71F4C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC49C", Offset = "0x10DC49C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE518", Offset = "0x10DE518")]
			public Transform chest;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE550", Offset = "0x10DE550")]
			public Transform neck;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE588", Offset = "0x10DE588")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE5C0", Offset = "0x10DE5C0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE5F8", Offset = "0x10DE5F8")]
			public Transform leftThigh;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE630", Offset = "0x10DE630")]
			public Transform leftCalf;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE668", Offset = "0x10DE668")]
			public Transform leftFoot;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE6A0", Offset = "0x10DE6A0")]
			public Transform leftToes;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE6D8", Offset = "0x10DE6D8")]
			public Transform rightThigh;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE710", Offset = "0x10DE710")]
			public Transform rightCalf;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE748", Offset = "0x10DE748")]
			public Transform rightFoot;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE780", Offset = "0x10DE780")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x30D97D8", Offset = "0x30D97D8", VA = "0x30D97D8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x30D9C50", Offset = "0x30D9C50", VA = "0x30D9C50")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x30D9390", Offset = "0x30D9390", VA = "0x30D9390")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x30DA0C8", Offset = "0x30DA0C8", VA = "0x30DA0C8")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x30DA464", Offset = "0x30DA464", VA = "0x30DA464")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE46C", Offset = "0x10DE46C")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x10DE46C", Offset = "0x10DE46C")]
		public References references;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE4E0", Offset = "0x10DE4E0")]
		public IKSolverVR solver;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2D740BC", Offset = "0x2D740BC", VA = "0x2D740BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E61D4", Offset = "0x10E61D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2D74104", Offset = "0x2D74104", VA = "0x2D74104", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E620C", Offset = "0x10E620C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2D7414C", Offset = "0x2D7414C", VA = "0x2D7414C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6244", Offset = "0x10E6244")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2D74194", Offset = "0x2D74194", VA = "0x2D74194")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E627C", Offset = "0x10E627C")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2D741C0", Offset = "0x2D741C0", VA = "0x2D741C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E62B4", Offset = "0x10E62B4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2D741E8", Offset = "0x2D741E8", VA = "0x2D741E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2D741F0", Offset = "0x2D741F0", VA = "0x2D741F0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2D74270", Offset = "0x2D74270", VA = "0x2D74270", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2D743DC", Offset = "0x2D743DC", VA = "0x2D743DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE7B8", Offset = "0x10DE7B8")]
		public float pull;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE7D0", Offset = "0x10DE7D0")]
		public float pin;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x306731C", Offset = "0x306731C", VA = "0x306731C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x30673EC", Offset = "0x30673EC", VA = "0x30673EC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x306740C", Offset = "0x306740C", VA = "0x306740C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x3067680", Offset = "0x3067680", VA = "0x3067680")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x30674E0", Offset = "0x30674E0", VA = "0x30674E0")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3067778", Offset = "0x3067778", VA = "0x3067778")]
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
		[Address(RVA = "0x3067968", Offset = "0x3067968", VA = "0x3067968")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3067DCC", Offset = "0x3067DCC", VA = "0x3067DCC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3067F88", Offset = "0x3067F88", VA = "0x3067F88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3068094", Offset = "0x3068094", VA = "0x3068094")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEE28", Offset = "0x10DEE28")]
			public Transform transform;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEE60", Offset = "0x10DEE60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEE60", Offset = "0x10DEE60")]
			public float weight;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2D78864", Offset = "0x2D78864", VA = "0x2D78864")]
			public BendBone()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2D788A0", Offset = "0x2D788A0", VA = "0x2D788A0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2D788F8", Offset = "0x2D788F8", VA = "0x2D788F8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2D78930", Offset = "0x2D78930", VA = "0x2D78930")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE7E8", Offset = "0x10DE7E8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE820", Offset = "0x10DE820")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10DE820", Offset = "0x10DE820")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE820", Offset = "0x10DE820")]
		public float positionWeight;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE898", Offset = "0x10DE898")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE898", Offset = "0x10DE898")]
		public float bodyWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE8EC", Offset = "0x10DE8EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE8EC", Offset = "0x10DE8EC")]
		public float thighWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE940", Offset = "0x10DE940")]
		public bool handsPullBody;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10DE978", Offset = "0x10DE978")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE978", Offset = "0x10DE978")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE978", Offset = "0x10DE978")]
		public float rotationWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DE9F0", Offset = "0x10DE9F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DE9F0", Offset = "0x10DE9F0")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEA44", Offset = "0x10DEA44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEA44", Offset = "0x10DEA44")]
		public float headClampWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEA98", Offset = "0x10DEA98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEA98", Offset = "0x10DEA98")]
		public float bendWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEAEC", Offset = "0x10DEAEC")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10DEB24", Offset = "0x10DEB24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEB24", Offset = "0x10DEB24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEB24", Offset = "0x10DEB24")]
		public float CCDWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEB9C", Offset = "0x10DEB9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEB9C", Offset = "0x10DEB9C")]
		public float roll;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEBF0", Offset = "0x10DEBF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEBF0", Offset = "0x10DEBF0")]
		public float damper;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEC48", Offset = "0x10DEC48")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10DEC80", Offset = "0x10DEC80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEC80", Offset = "0x10DEC80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEC80", Offset = "0x10DEC80")]
		public float postStretchWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DECF8", Offset = "0x10DECF8")]
		public float maxStretch;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DED30", Offset = "0x10DED30")]
		public float stretchDamper;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DED68", Offset = "0x10DED68")]
		public bool fixHead;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DEDA0", Offset = "0x10DEDA0")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10DEDD8", Offset = "0x10DEDD8")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEE10", Offset = "0x10DEE10")]
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
		[Address(RVA = "0x306809C", Offset = "0x306809C", VA = "0x306809C")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x30683D0", Offset = "0x30683D0", VA = "0x30683D0")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3068870", Offset = "0x3068870", VA = "0x3068870")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x3068C3C", Offset = "0x3068C3C", VA = "0x3068C3C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x30693C8", Offset = "0x30693C8", VA = "0x30693C8")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x30696A8", Offset = "0x30696A8", VA = "0x30696A8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x30699AC", Offset = "0x30699AC", VA = "0x30699AC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x306A180", Offset = "0x306A180", VA = "0x306A180")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x30691AC", Offset = "0x30691AC", VA = "0x30691AC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x306A348", Offset = "0x306A348", VA = "0x306A348")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x306A098", Offset = "0x306A098", VA = "0x306A098")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x3069FCC", Offset = "0x3069FCC", VA = "0x3069FCC")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x306A5CC", Offset = "0x306A5CC", VA = "0x306A5CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x306A89C", Offset = "0x306A89C", VA = "0x306A89C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DEF4C", Offset = "0x10DEF4C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DEF5C", Offset = "0x10DEF5C")]
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
				[Address(RVA = "0x2D789EC", Offset = "0x2D789EC", VA = "0x2D789EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E62EC", Offset = "0x10E62EC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x2D789F4", Offset = "0x2D789F4", VA = "0x2D789F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E62FC", Offset = "0x10E62FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x2D789FC", Offset = "0x2D789FC", VA = "0x2D789FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E630C", Offset = "0x10E630C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x2D78A04", Offset = "0x2D78A04", VA = "0x2D78A04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E631C", Offset = "0x10E631C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x2D78A10", Offset = "0x2D78A10", VA = "0x2D78A10")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x2D78A5C", Offset = "0x2D78A5C", VA = "0x2D78A5C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x2D78AB4", Offset = "0x2D78AB4", VA = "0x2D78AB4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x2D78C58", Offset = "0x2D78C58", VA = "0x2D78C58")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEEB4", Offset = "0x10DEEB4")]
		public float pin;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEECC", Offset = "0x10DEECC")]
		public float pull;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEEE4", Offset = "0x10DEEE4")]
		public float push;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEEFC", Offset = "0x10DEEFC")]
		public float pushParent;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEF14", Offset = "0x10DEF14")]
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
		[Address(RVA = "0x306AF78", Offset = "0x306AF78", VA = "0x306AF78")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x306B064", Offset = "0x306B064", VA = "0x306B064")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x306B190", Offset = "0x306B190", VA = "0x306B190")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x306B2BC", Offset = "0x306B2BC", VA = "0x306B2BC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x306B394", Offset = "0x306B394", VA = "0x306B394")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x306B4AC", Offset = "0x306B4AC", VA = "0x306B4AC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x306BB28", Offset = "0x306BB28", VA = "0x306BB28")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x306B63C", Offset = "0x306B63C", VA = "0x306B63C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x306BF18", Offset = "0x306BF18", VA = "0x306BF18")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x306C178", Offset = "0x306C178", VA = "0x306C178")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x306C3E4", Offset = "0x306C3E4", VA = "0x306C3E4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x306C788", Offset = "0x306C788", VA = "0x306C788")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x306CC1C", Offset = "0x306CC1C", VA = "0x306CC1C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x306CE40", Offset = "0x306CE40", VA = "0x306CE40")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x306CBAC", Offset = "0x306CBAC", VA = "0x306CBAC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x306C614", Offset = "0x306C614", VA = "0x306C614")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x306CB30", Offset = "0x306CB30", VA = "0x306CB30")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x306CF28", Offset = "0x306CF28", VA = "0x306CF28")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x306CA50", Offset = "0x306CA50", VA = "0x306CA50")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x306CD28", Offset = "0x306CD28", VA = "0x306CD28")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEF6C", Offset = "0x10DEF6C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DEF84", Offset = "0x10DEF84")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x30E0154", Offset = "0x30E0154", VA = "0x30E0154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E632C", Offset = "0x10E632C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x30E015C", Offset = "0x30E015C", VA = "0x30E015C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E633C", Offset = "0x10E633C")]
			private set
			{
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x30DFF6C", Offset = "0x30DFF6C", VA = "0x30DFF6C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x30E0168", Offset = "0x30E0168", VA = "0x30E0168")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x30E01A8", Offset = "0x30E01A8", VA = "0x30E01A8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x30E0208", Offset = "0x30E0208", VA = "0x30E0208")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x30E0214", Offset = "0x30E0214", VA = "0x30E0214")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x30E058C", Offset = "0x30E058C", VA = "0x30E058C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x30E077C", Offset = "0x30E077C", VA = "0x30E077C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x30E0AC8", Offset = "0x30E0AC8", VA = "0x30E0AC8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x30E044C", Offset = "0x30E044C", VA = "0x30E044C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x30E04EC", Offset = "0x30E04EC", VA = "0x30E04EC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEF94", Offset = "0x10DEF94")]
		public float positionWeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEFAC", Offset = "0x10DEFAC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DEFC4", Offset = "0x10DEFC4")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEFD4", Offset = "0x10DEFD4")]
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
			[Address(RVA = "0x30E0FA8", Offset = "0x30E0FA8", VA = "0x30E0FA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E634C", Offset = "0x10E634C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x30E0FB0", Offset = "0x30E0FB0", VA = "0x30E0FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E635C", Offset = "0x10E635C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x30E0F40", Offset = "0x30E0F40", VA = "0x30E0F40")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x30E0FBC", Offset = "0x30E0FBC", VA = "0x30E0FBC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x30E104C", Offset = "0x30E104C", VA = "0x30E104C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x30E1160", Offset = "0x30E1160", VA = "0x30E1160")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x30E1290", Offset = "0x30E1290", VA = "0x30E1290")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x30E15AC", Offset = "0x30E15AC", VA = "0x30E15AC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x30E182C", Offset = "0x30E182C", VA = "0x30E182C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x30E18F8", Offset = "0x30E18F8", VA = "0x30E18F8")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x30E19A0", Offset = "0x30E19A0", VA = "0x30E19A0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x30E1EC8", Offset = "0x30E1EC8", VA = "0x30E1EC8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x30E1EF4", Offset = "0x30E1EF4", VA = "0x30E1EF4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x30E2048", Offset = "0x30E2048", VA = "0x30E2048")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x30E22C0", Offset = "0x30E22C0", VA = "0x30E22C0")]
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
				[Address(RVA = "0x2D7000C", Offset = "0x2D7000C", VA = "0x2D7000C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x2D7BF30", Offset = "0x2D7BF30", VA = "0x2D7BF30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x2D7C2D4", Offset = "0x2D7C2D4", VA = "0x2D7C2D4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x2D7BE64", Offset = "0x2D7BE64", VA = "0x2D7BE64")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2D7BE90", Offset = "0x2D7BE90", VA = "0x2D7BE90")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2D7BEE0", Offset = "0x2D7BEE0", VA = "0x2D7BEE0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x2D7BF40", Offset = "0x2D7BF40", VA = "0x2D7BF40")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x2D7BFC8", Offset = "0x2D7BFC8", VA = "0x2D7BFC8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x2D7BFD0", Offset = "0x2D7BFD0", VA = "0x2D7BFD0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2D7C0A8", Offset = "0x2D7C0A8", VA = "0x2D7C0A8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2D7C120", Offset = "0x2D7C120", VA = "0x2D7C120")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2D7C1B8", Offset = "0x2D7C1B8", VA = "0x2D7C1B8")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x2D7C414", Offset = "0x2D7C414", VA = "0x2D7C414")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x2D7C44C", Offset = "0x2D7C44C", VA = "0x2D7C44C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x2D7C484", Offset = "0x2D7C484", VA = "0x2D7C484")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2D7C4AC", Offset = "0x2D7C4AC", VA = "0x2D7C4AC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2D7C598", Offset = "0x2D7C598", VA = "0x2D7C598")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x2D7C724", Offset = "0x2D7C724", VA = "0x2D7C724")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x2D7C754", Offset = "0x2D7C754", VA = "0x2D7C754")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x2D7C81C", Offset = "0x2D7C81C", VA = "0x2D7C81C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x2D7C88C", Offset = "0x2D7C88C", VA = "0x2D7C88C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x2D7C9DC", Offset = "0x2D7C9DC", VA = "0x2D7C9DC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2D7CB2C", Offset = "0x2D7CB2C", VA = "0x2D7CB2C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x2D7CBAC", Offset = "0x2D7CBAC", VA = "0x2D7CBAC")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x2D7C614", Offset = "0x2D7C614", VA = "0x2D7C614")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x2D7CCE4", Offset = "0x2D7CCE4", VA = "0x2D7CCE4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x30E2768", Offset = "0x30E2768", VA = "0x30E2768", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x30E2770", Offset = "0x30E2770", VA = "0x30E2770", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x30E2774", Offset = "0x30E2774", VA = "0x30E2774")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x30E28B8", Offset = "0x30E28B8", VA = "0x30E28B8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x30E2928", Offset = "0x30E2928", VA = "0x30E2928")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DEFEC", Offset = "0x10DEFEC")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x30E2930", Offset = "0x30E2930", VA = "0x30E2930", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x30E29D8", Offset = "0x30E29D8", VA = "0x30E29D8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x30E2A44", Offset = "0x30E2A44", VA = "0x30E2A44")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x30E2AC4", Offset = "0x30E2AC4", VA = "0x30E2AC4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x30E2AE0", Offset = "0x30E2AE0", VA = "0x30E2AE0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x30E2B00", Offset = "0x30E2B00", VA = "0x30E2B00", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x30E2B88", Offset = "0x30E2B88", VA = "0x30E2B88")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x30E2BA4", Offset = "0x30E2BA4", VA = "0x30E2BA4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF004", Offset = "0x10DF004")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF01C", Offset = "0x10DF01C")]
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
		[Address(RVA = "0x30E2BCC", Offset = "0x30E2BCC", VA = "0x30E2BCC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x30E2C50", Offset = "0x30E2C50", VA = "0x30E2C50")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x30E2D2C", Offset = "0x30E2D2C", VA = "0x30E2D2C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x30E2F50", Offset = "0x30E2F50", VA = "0x30E2F50")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x30E3014", Offset = "0x30E3014", VA = "0x30E3014")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x30E3104", Offset = "0x30E3104", VA = "0x30E3104")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x30E3110", Offset = "0x30E3110", VA = "0x30E3110")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x30E31C4", Offset = "0x30E31C4", VA = "0x30E31C4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x30E3288", Offset = "0x30E3288", VA = "0x30E3288", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x30E34C8", Offset = "0x30E34C8", VA = "0x30E34C8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x30E353C", Offset = "0x30E353C", VA = "0x30E353C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF034", Offset = "0x10DF034")]
		public int iterations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF04C", Offset = "0x10DF04C")]
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
		[Address(RVA = "0x30E36B8", Offset = "0x30E36B8", VA = "0x30E36B8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x30E3A1C", Offset = "0x30E3A1C", VA = "0x30E3A1C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x30E3B00", Offset = "0x30E3B00", VA = "0x30E3B00")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x30E3C18", Offset = "0x30E3C18", VA = "0x30E3C18")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x30E3C28", Offset = "0x30E3C28", VA = "0x30E3C28")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x30E3C94", Offset = "0x30E3C94", VA = "0x30E3C94")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x30E3D18", Offset = "0x30E3D18", VA = "0x30E3D18", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x30E42F0", Offset = "0x30E42F0", VA = "0x30E42F0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x30E4328", Offset = "0x30E4328", VA = "0x30E4328")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x30E45AC", Offset = "0x30E45AC", VA = "0x30E45AC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x30E48AC", Offset = "0x30E48AC", VA = "0x30E48AC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x30E4998", Offset = "0x30E4998", VA = "0x30E4998")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x30E4A60", Offset = "0x30E4A60", VA = "0x30E4A60")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF110", Offset = "0x10DF110")]
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
			[Address(RVA = "0x2D7D7F0", Offset = "0x2D7D7F0", VA = "0x2D7D7F0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x2D7D840", Offset = "0x2D7D840", VA = "0x2D7D840")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x2D7D8E0", Offset = "0x2D7D8E0", VA = "0x2D7D8E0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x2D7D918", Offset = "0x2D7D918", VA = "0x2D7D918")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x2D7D950", Offset = "0x2D7D950", VA = "0x2D7D950")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x2D7D9A0", Offset = "0x2D7D9A0", VA = "0x2D7D9A0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x2D7D3D0", Offset = "0x2D7D3D0", VA = "0x2D7D3D0")]
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
				[Address(RVA = "0x2D7CD00", Offset = "0x2D7CD00", VA = "0x2D7CD00")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x2D7CDFC", Offset = "0x2D7CDFC", VA = "0x2D7CDFC")]
				set
				{
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x2D7CE80", Offset = "0x2D7CE80", VA = "0x2D7CE80")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x2D7D030", Offset = "0x2D7D030", VA = "0x2D7D030")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2D7D204", Offset = "0x2D7D204", VA = "0x2D7D204")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x2D7D364", Offset = "0x2D7D364", VA = "0x2D7D364")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2D7D38C", Offset = "0x2D7D38C", VA = "0x2D7D38C")]
			public Bone()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2D7D40C", Offset = "0x2D7D40C", VA = "0x2D7D40C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x2D7D45C", Offset = "0x2D7D45C", VA = "0x2D7D45C")]
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
			[Address(RVA = "0x2D7D78C", Offset = "0x2D7D78C", VA = "0x2D7D78C")]
			public Node()
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x2D7D790", Offset = "0x2D7D790", VA = "0x2D7D790")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x2D7D7B8", Offset = "0x2D7D7B8", VA = "0x2D7D7B8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF074", Offset = "0x10DF074")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF074", Offset = "0x10DF074")]
		public float IKPositionWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF0C8", Offset = "0x10DF0C8")]
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
			[Address(RVA = "0x30E4D90", Offset = "0x30E4D90", VA = "0x30E4D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E636C", Offset = "0x10E636C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x30E4D98", Offset = "0x30E4D98", VA = "0x30E4D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E637C", Offset = "0x10E637C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x30E4CC0", Offset = "0x30E4CC0", VA = "0x30E4CC0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x30DFD90", Offset = "0x30DFD90", VA = "0x30DFD90")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x30DFCB0", Offset = "0x30DFCB0", VA = "0x30DFCB0")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x30E4D38", Offset = "0x30E4D38", VA = "0x30E4D38", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x30E4D44", Offset = "0x30E4D44", VA = "0x30E4D44")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x30E4D50", Offset = "0x30E4D50", VA = "0x30E4D50")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x30E4D58", Offset = "0x30E4D58", VA = "0x30E4D58")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x30E4D88", Offset = "0x30E4D88", VA = "0x30E4D88")]
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
		[Address(RVA = "0x30E4DA4", Offset = "0x30E4DA4", VA = "0x30E4DA4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x30E4DBC", Offset = "0x30E4DBC", VA = "0x30E4DBC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x30E4EF4", Offset = "0x30E4EF4", VA = "0x30E4EF4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x30E4F9C", Offset = "0x30E4F9C", VA = "0x30E4F9C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x30E5224", Offset = "0x30E5224", VA = "0x30E5224")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF128", Offset = "0x10DF128")]
		public float poleWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF140", Offset = "0x10DF140")]
		public float clampWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF158", Offset = "0x10DF158")]
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
			[Address(RVA = "0x30E52B8", Offset = "0x30E52B8", VA = "0x30E52B8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x30E52F4", Offset = "0x30E52F4", VA = "0x30E52F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x30E5D84", Offset = "0x30E5D84", VA = "0x30E5D84", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x30E6168", Offset = "0x30E6168", VA = "0x30E6168", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x30E523C", Offset = "0x30E523C", VA = "0x30E523C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x30E5330", Offset = "0x30E5330", VA = "0x30E5330", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x30E5550", Offset = "0x30E5550", VA = "0x30E5550", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x30E5CD0", Offset = "0x30E5CD0", VA = "0x30E5CD0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x30E5A60", Offset = "0x30E5A60", VA = "0x30E5A60")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x30E5D8C", Offset = "0x30E5D8C", VA = "0x30E5D8C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x30E61DC", Offset = "0x30E61DC", VA = "0x30E61DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF170", Offset = "0x10DF170")]
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
		[Address(RVA = "0x30E6230", Offset = "0x30E6230", VA = "0x30E6230", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x30E65CC", Offset = "0x30E65CC", VA = "0x30E65CC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x30E6638", Offset = "0x30E6638", VA = "0x30E6638", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x30E6790", Offset = "0x30E6790", VA = "0x30E6790", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x30E6924", Offset = "0x30E6924", VA = "0x30E6924", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x30E6980", Offset = "0x30E6980", VA = "0x30E6980", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x30E69F0", Offset = "0x30E69F0", VA = "0x30E69F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x30E6D60", Offset = "0x30E6D60", VA = "0x30E6D60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x30E6D8C", Offset = "0x30E6D8C", VA = "0x30E6D8C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x30E6A54", Offset = "0x30E6A54", VA = "0x30E6A54")]
		private void Read()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x30E6DF8", Offset = "0x30E6DF8", VA = "0x30E6DF8")]
		private void Write()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x30E6F84", Offset = "0x30E6F84", VA = "0x30E6F84")]
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
		[Address(RVA = "0x30E70E8", Offset = "0x30E70E8", VA = "0x30E70E8")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x30E7198", Offset = "0x30E7198", VA = "0x30E7198", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x30E721C", Offset = "0x30E721C", VA = "0x30E721C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x30E744C", Offset = "0x30E744C", VA = "0x30E744C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x30E7A28", Offset = "0x30E7A28", VA = "0x30E7A28")]
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
			[Address(RVA = "0x30E8938", Offset = "0x30E8938", VA = "0x30E8938", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x30E7A30", Offset = "0x30E7A30", VA = "0x30E7A30")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x30E7FF4", Offset = "0x30E7FF4", VA = "0x30E7FF4")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x30E8134", Offset = "0x30E8134", VA = "0x30E8134", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x30E81C8", Offset = "0x30E81C8", VA = "0x30E81C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x30E86A4", Offset = "0x30E86A4", VA = "0x30E86A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x30E8940", Offset = "0x30E8940", VA = "0x30E8940")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x30E7B0C", Offset = "0x30E7B0C", VA = "0x30E7B0C")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x30E80E0", Offset = "0x30E80E0", VA = "0x30E80E0")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x30E88DC", Offset = "0x30E88DC", VA = "0x30E88DC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x30E7E68", Offset = "0x30E7E68", VA = "0x30E7E68")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x30E8F90", Offset = "0x30E8F90", VA = "0x30E8F90")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x30E9004", Offset = "0x30E9004", VA = "0x30E9004")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x30E90CC", Offset = "0x30E90CC", VA = "0x30E90CC")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x30E917C", Offset = "0x30E917C", VA = "0x30E917C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x30E8454", Offset = "0x30E8454", VA = "0x30E8454")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x30E857C", Offset = "0x30E857C", VA = "0x30E857C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x30E9280", Offset = "0x30E9280", VA = "0x30E9280")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x30E8B60", Offset = "0x30E8B60", VA = "0x30E8B60")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x30E80D0", Offset = "0x30E80D0", VA = "0x30E80D0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x30E9810", Offset = "0x30E9810", VA = "0x30E9810")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x30E93C4", Offset = "0x30E93C4", VA = "0x30E93C4")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x30E89BC", Offset = "0x30E89BC", VA = "0x30E89BC")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x30E8A9C", Offset = "0x30E8A9C", VA = "0x30E8A9C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x30E98DC", Offset = "0x30E98DC", VA = "0x30E98DC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF188", Offset = "0x10DF188")]
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
		[Address(RVA = "0x30E995C", Offset = "0x30E995C", VA = "0x30E995C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x30E9F9C", Offset = "0x30E9F9C", VA = "0x30E9F9C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x30EA034", Offset = "0x30EA034", VA = "0x30EA034", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x30EA0D4", Offset = "0x30EA0D4", VA = "0x30EA0D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x30EA1D0", Offset = "0x30EA1D0", VA = "0x30EA1D0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x30EA26C", Offset = "0x30EA26C", VA = "0x30EA26C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x30EA69C", Offset = "0x30EA69C", VA = "0x30EA69C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x30EA894", Offset = "0x30EA894", VA = "0x30EA894", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x30EA748", Offset = "0x30EA748", VA = "0x30EA748")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x30EA458", Offset = "0x30EA458", VA = "0x30EA458")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x30EA92C", Offset = "0x30EA92C", VA = "0x30EA92C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF1A0", Offset = "0x10DF1A0")]
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
		[Address(RVA = "0x30EA9A0", Offset = "0x30EA9A0", VA = "0x30EA9A0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x30EAA90", Offset = "0x30EAA90", VA = "0x30EAA90")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x30EAAEC", Offset = "0x30EAAEC", VA = "0x30EAAEC")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x30E0EE4", Offset = "0x30E0EE4", VA = "0x30E0EE4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x30E03CC", Offset = "0x30E03CC", VA = "0x30E03CC")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x30EAC1C", Offset = "0x30EAC1C", VA = "0x30EAC1C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x30EADC0", Offset = "0x30EADC0", VA = "0x30EADC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x30EAF30", Offset = "0x30EAF30", VA = "0x30EAF30", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x30EB138", Offset = "0x30EB138", VA = "0x30EB138", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x30EB210", Offset = "0x30EB210", VA = "0x30EB210", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x30EB2F0", Offset = "0x30EB2F0", VA = "0x30EB2F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x30EB460", Offset = "0x30EB460", VA = "0x30EB460", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x30EB5C0", Offset = "0x30EB5C0", VA = "0x30EB5C0", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x30EB800", Offset = "0x30EB800", VA = "0x30EB800", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x30EBACC", Offset = "0x30EBACC", VA = "0x30EBACC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x30EBB10", Offset = "0x30EBB10", VA = "0x30EBB10", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x30EBBF4", Offset = "0x30EBBF4", VA = "0x30EBBF4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF1B8", Offset = "0x10DF1B8")]
		public float spineStiffness;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF1D0", Offset = "0x10DF1D0")]
		public float pullBodyVertical;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF1E8", Offset = "0x10DF1E8")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF200", Offset = "0x10DF200")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x3088658", Offset = "0x3088658", VA = "0x3088658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x30887A0", Offset = "0x30887A0", VA = "0x30887A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x30887A8", Offset = "0x30887A8", VA = "0x30887A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x30887B0", Offset = "0x30887B0", VA = "0x30887B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x30887B8", Offset = "0x30887B8", VA = "0x30887B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x30887C0", Offset = "0x30887C0", VA = "0x30887C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x30887C8", Offset = "0x30887C8", VA = "0x30887C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x30887D0", Offset = "0x30887D0", VA = "0x30887D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x30887D8", Offset = "0x30887D8", VA = "0x30887D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x30887E0", Offset = "0x30887E0", VA = "0x30887E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x3088818", Offset = "0x3088818", VA = "0x3088818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x3088850", Offset = "0x3088850", VA = "0x3088850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x3088888", Offset = "0x3088888", VA = "0x3088888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x30888C0", Offset = "0x30888C0", VA = "0x30888C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x30888F4", Offset = "0x30888F4", VA = "0x30888F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x308892C", Offset = "0x308892C", VA = "0x308892C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x3088964", Offset = "0x3088964", VA = "0x3088964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x308899C", Offset = "0x308899C", VA = "0x308899C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x308A868", Offset = "0x308A868", VA = "0x308A868")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E638C", Offset = "0x10E638C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x308A874", Offset = "0x308A874", VA = "0x308A874")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E639C", Offset = "0x10E639C")]
			private set
			{
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x30889D0", Offset = "0x30889D0", VA = "0x30889D0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x3088ADC", Offset = "0x3088ADC", VA = "0x3088ADC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x3088A24", Offset = "0x3088A24", VA = "0x3088A24")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x3088B68", Offset = "0x3088B68", VA = "0x3088B68")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x3088660", Offset = "0x3088660", VA = "0x3088660")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x3088C38", Offset = "0x3088C38", VA = "0x3088C38")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x3088CF0", Offset = "0x3088CF0", VA = "0x3088CF0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x3088DA4", Offset = "0x3088DA4", VA = "0x3088DA4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x3088E58", Offset = "0x3088E58", VA = "0x3088E58")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x3088E60", Offset = "0x3088E60", VA = "0x3088E60")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x3088E94", Offset = "0x3088E94", VA = "0x3088E94")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x3088F5C", Offset = "0x3088F5C", VA = "0x3088F5C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x3089104", Offset = "0x3089104", VA = "0x3089104")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x308A2E4", Offset = "0x308A2E4", VA = "0x308A2E4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x308A6F8", Offset = "0x308A6F8", VA = "0x308A6F8")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x308A758", Offset = "0x308A758", VA = "0x308A758")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x308A580", Offset = "0x308A580", VA = "0x308A580")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x308A63C", Offset = "0x308A63C", VA = "0x308A63C")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x308A880", Offset = "0x308A880", VA = "0x308A880")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x308A958", Offset = "0x308A958", VA = "0x308A958", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x308AA58", Offset = "0x308AA58", VA = "0x308AA58")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x308AB80", Offset = "0x308AB80", VA = "0x308AB80")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x308ACC4", Offset = "0x308ACC4", VA = "0x308ACC4")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x308ADF4", Offset = "0x308ADF4", VA = "0x308ADF4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x308B038", Offset = "0x308B038", VA = "0x308B038", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x308B0C0", Offset = "0x308B0C0", VA = "0x308B0C0")]
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
			[Address(RVA = "0x308B930", Offset = "0x308B930", VA = "0x308B930", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x308B938", Offset = "0x308B938", VA = "0x308B938", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x308B940", Offset = "0x308B940", VA = "0x308B940", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x308BDC8", Offset = "0x308BDC8", VA = "0x308BDC8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x308BE90", Offset = "0x308BE90", VA = "0x308BE90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x308B0D0", Offset = "0x308B0D0", VA = "0x308B0D0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x308B26C", Offset = "0x308B26C", VA = "0x308B26C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x308B3A4", Offset = "0x308B3A4", VA = "0x308B3A4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x308B410", Offset = "0x308B410", VA = "0x308B410", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x308B490", Offset = "0x308B490", VA = "0x308B490", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x308B838", Offset = "0x308B838", VA = "0x308B838", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x308B840", Offset = "0x308B840", VA = "0x308B840", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x308B948", Offset = "0x308B948", VA = "0x308B948", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x308B94C", Offset = "0x308B94C", VA = "0x308B94C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x308B950", Offset = "0x308B950", VA = "0x308B950")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x308BEE4", Offset = "0x308BEE4", VA = "0x308BEE4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x308C1FC", Offset = "0x308C1FC", VA = "0x308C1FC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x308C3F0", Offset = "0x308C3F0", VA = "0x308C3F0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF210", Offset = "0x10DF210")]
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
		[Address(RVA = "0x308C45C", Offset = "0x308C45C", VA = "0x308C45C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x308C7FC", Offset = "0x308C7FC", VA = "0x308C7FC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x308C86C", Offset = "0x308C86C", VA = "0x308C86C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x308C9C4", Offset = "0x308C9C4", VA = "0x308C9C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x308CB58", Offset = "0x308CB58", VA = "0x308CB58", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x308CBB4", Offset = "0x308CBB4", VA = "0x308CBB4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x308CC24", Offset = "0x308CC24", VA = "0x308CC24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x308CF94", Offset = "0x308CF94", VA = "0x308CF94", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x308CFC0", Offset = "0x308CFC0", VA = "0x308CFC0")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x308CC88", Offset = "0x308CC88", VA = "0x308CC88")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x308D054", Offset = "0x308D054", VA = "0x308D054")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x308D1E0", Offset = "0x308D1E0", VA = "0x308D1E0")]
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
			[Address(RVA = "0x2D7DC34", Offset = "0x2D7DC34", VA = "0x2D7DC34")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF228", Offset = "0x10DF228")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF240", Offset = "0x10DF240")]
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
			[Address(RVA = "0x308E45C", Offset = "0x308E45C", VA = "0x308E45C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x308D338", Offset = "0x308D338", VA = "0x308D338")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x308D388", Offset = "0x308D388", VA = "0x308D388")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x308D3D4", Offset = "0x308D3D4", VA = "0x308D3D4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x308D8A8", Offset = "0x308D8A8", VA = "0x308D8A8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x308E1F0", Offset = "0x308E1F0", VA = "0x308E1F0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x308E29C", Offset = "0x308E29C", VA = "0x308E29C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x308E3D8", Offset = "0x308E3D8", VA = "0x308E3D8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x308D6D0", Offset = "0x308D6D0", VA = "0x308D6D0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x308D98C", Offset = "0x308D98C", VA = "0x308D98C")]
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
				[Address(RVA = "0x2D7DEC0", Offset = "0x2D7DEC0", VA = "0x2D7DEC0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2D7DC94", Offset = "0x2D7DC94", VA = "0x2D7DC94")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x2D7DC98", Offset = "0x2D7DC98", VA = "0x2D7DC98")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2D7DCC0", Offset = "0x2D7DCC0", VA = "0x2D7DCC0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x2D7DDB8", Offset = "0x2D7DDB8", VA = "0x2D7DDB8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF258", Offset = "0x10DF258")]
		public float bodyWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF270", Offset = "0x10DF270")]
		public float headWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF288", Offset = "0x10DF288")]
		public float eyesWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF2A0", Offset = "0x10DF2A0")]
		public float clampWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF2B8", Offset = "0x10DF2B8")]
		public float clampWeightHead;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF2D0", Offset = "0x10DF2D0")]
		public float clampWeightEyes;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF2E8", Offset = "0x10DF2E8")]
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
			[Address(RVA = "0x308EBFC", Offset = "0x308EBFC", VA = "0x308EBFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x308EDCC", Offset = "0x308EDCC", VA = "0x308EDCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x308ECDC", Offset = "0x308ECDC", VA = "0x308ECDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x308EDF0", Offset = "0x308EDF0", VA = "0x308EDF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x308ECEC", Offset = "0x308ECEC", VA = "0x308ECEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x308EE68", Offset = "0x308EE68", VA = "0x308EE68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x308E478", Offset = "0x308E478", VA = "0x308E478")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x308E4A8", Offset = "0x308E4A8", VA = "0x308E4A8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x308E500", Offset = "0x308E500", VA = "0x308E500")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x308E57C", Offset = "0x308E57C", VA = "0x308E57C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x308E614", Offset = "0x308E614", VA = "0x308E614")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x308E6D4", Offset = "0x308E6D4", VA = "0x308E6D4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x308E7D0", Offset = "0x308E7D0", VA = "0x308E7D0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x308E8FC", Offset = "0x308E8FC", VA = "0x308E8FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x308EA3C", Offset = "0x308EA3C", VA = "0x308EA3C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x308EE8C", Offset = "0x308EE8C", VA = "0x308EE8C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x308F0CC", Offset = "0x308F0CC", VA = "0x308F0CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x308F268", Offset = "0x308F268", VA = "0x308F268")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x308F498", Offset = "0x308F498", VA = "0x308F498", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x308F76C", Offset = "0x308F76C", VA = "0x308F76C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x308F83C", Offset = "0x308F83C", VA = "0x308F83C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x308F9DC", Offset = "0x308F9DC", VA = "0x308F9DC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x308FC00", Offset = "0x308FC00", VA = "0x308FC00")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x308FFB4", Offset = "0x308FFB4", VA = "0x308FFB4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x308F314", Offset = "0x308F314", VA = "0x308F314")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x3090224", Offset = "0x3090224", VA = "0x3090224")]
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
			[Address(RVA = "0x2D7DEFC", Offset = "0x2D7DEFC", VA = "0x2D7DEFC")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x2D7DFF8", Offset = "0x2D7DFF8", VA = "0x2D7DFF8")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x2D7E028", Offset = "0x2D7E028", VA = "0x2D7E028")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x2D7E064", Offset = "0x2D7E064", VA = "0x2D7E064")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF300", Offset = "0x10DF300")]
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
		[Address(RVA = "0x3090430", Offset = "0x3090430", VA = "0x3090430")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x309058C", Offset = "0x309058C", VA = "0x309058C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x30906D0", Offset = "0x30906D0", VA = "0x30906D0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x30906DC", Offset = "0x30906DC", VA = "0x30906DC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x309070C", Offset = "0x309070C", VA = "0x309070C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x3090718", Offset = "0x3090718", VA = "0x3090718")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x3090720", Offset = "0x3090720", VA = "0x3090720", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x3090820", Offset = "0x3090820", VA = "0x3090820", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x309093C", Offset = "0x309093C", VA = "0x309093C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x3090988", Offset = "0x3090988", VA = "0x3090988", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x30909E8", Offset = "0x30909E8", VA = "0x30909E8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x3090DB0", Offset = "0x3090DB0", VA = "0x3090DB0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x3090E08", Offset = "0x3090E08", VA = "0x3090E08")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x30911C4", Offset = "0x30911C4", VA = "0x30911C4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x309132C", Offset = "0x309132C", VA = "0x309132C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x3091494", Offset = "0x3091494", VA = "0x3091494")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x3091408", Offset = "0x3091408", VA = "0x3091408")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x3091598", Offset = "0x3091598", VA = "0x3091598", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x3091D6C", Offset = "0x3091D6C", VA = "0x3091D6C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x3091D70", Offset = "0x3091D70", VA = "0x3091D70", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x3091D74", Offset = "0x3091D74", VA = "0x3091D74", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x3091B84", Offset = "0x3091B84", VA = "0x3091B84")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x308E30C", Offset = "0x308E30C", VA = "0x308E30C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF504", Offset = "0x10DF504")]
			public Transform target;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF53C", Offset = "0x10DF53C")]
			public Transform bendGoal;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF574", Offset = "0x10DF574")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF574", Offset = "0x10DF574")]
			public float positionWeight;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF5C8", Offset = "0x10DF5C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF5C8", Offset = "0x10DF5C8")]
			public float rotationWeight;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF61C", Offset = "0x10DF61C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF654", Offset = "0x10DF654")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF654", Offset = "0x10DF654")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF6A8", Offset = "0x10DF6A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF6A8", Offset = "0x10DF6A8")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF6FC", Offset = "0x10DF6FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF6FC", Offset = "0x10DF6FC")]
			public float bendGoalWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF750", Offset = "0x10DF750")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF750", Offset = "0x10DF750")]
			public float swivelOffset;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF7AC", Offset = "0x10DF7AC")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF7E4", Offset = "0x10DF7E4")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF81C", Offset = "0x10DF81C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF81C", Offset = "0x10DF81C")]
			public float armLengthMlp;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF874", Offset = "0x10DF874")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF8EC", Offset = "0x10DF8EC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF8FC", Offset = "0x10DF8FC")]
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
				[Address(RVA = "0x2D7E068", Offset = "0x2D7E068", VA = "0x2D7E068")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E63CC", Offset = "0x10E63CC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x2D7E074", Offset = "0x2D7E074", VA = "0x2D7E074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E63DC", Offset = "0x10E63DC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x2D7E080", Offset = "0x2D7E080", VA = "0x2D7E080")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E63EC", Offset = "0x10E63EC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x2D7E08C", Offset = "0x2D7E08C", VA = "0x2D7E08C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E63FC", Offset = "0x10E63FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x2D7E098", Offset = "0x2D7E098", VA = "0x2D7E098")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x2D7E0CC", Offset = "0x2D7E0CC", VA = "0x2D7E0CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x2D7E10C", Offset = "0x2D7E10C", VA = "0x2D7E10C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x2D7E158", Offset = "0x2D7E158", VA = "0x2D7E158")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x2D7E1A4", Offset = "0x2D7E1A4", VA = "0x2D7E1A4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x2D7E9CC", Offset = "0x2D7E9CC", VA = "0x2D7E9CC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x2D7EB84", Offset = "0x2D7EB84", VA = "0x2D7EB84", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x2D7EBA8", Offset = "0x2D7EBA8", VA = "0x2D7EBA8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x2D7EE48", Offset = "0x2D7EE48", VA = "0x2D7EE48")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x2D80264", Offset = "0x2D80264", VA = "0x2D80264", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x2D80290", Offset = "0x2D80290", VA = "0x2D80290", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x2D7FDE4", Offset = "0x2D7FDE4", VA = "0x2D7FDE4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x2D7FE60", Offset = "0x2D7FE60", VA = "0x2D7FE60")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2D804B0", Offset = "0x2D804B0", VA = "0x2D804B0")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x2D805D4", Offset = "0x2D805D4", VA = "0x2D805D4")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF90C", Offset = "0x10DF90C")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF91C", Offset = "0x10DF91C")]
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
				[Address(RVA = "0x30CBA84", Offset = "0x30CBA84", VA = "0x30CBA84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E640C", Offset = "0x10E640C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x30CBA8C", Offset = "0x30CBA8C", VA = "0x30CBA8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E641C", Offset = "0x10E641C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x30CBA94", Offset = "0x30CBA94", VA = "0x30CBA94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E642C", Offset = "0x10E642C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000432")]
				[Address(RVA = "0x30CBA9C", Offset = "0x30CBA9C", VA = "0x30CBA9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E643C", Offset = "0x10E643C")]
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
			[Address(RVA = "0x30CBAA4", Offset = "0x30CBAA4", VA = "0x30CBAA4")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x30CBAAC", Offset = "0x30CBAAC", VA = "0x30CBAAC")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x30CBD6C", Offset = "0x30CBD6C", VA = "0x30CBD6C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x30CBE00", Offset = "0x30CBE00", VA = "0x30CBE00")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x30CBFD0", Offset = "0x30CBFD0", VA = "0x30CBFD0")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x30CC024", Offset = "0x30CC024", VA = "0x30CC024")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x30CC15C", Offset = "0x30CC15C", VA = "0x30CC15C")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x30CC29C", Offset = "0x30CC29C", VA = "0x30CC29C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x30CC3DC", Offset = "0x30CC3DC", VA = "0x30CC3DC")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x30CC404", Offset = "0x30CC404", VA = "0x30CC404")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF93C", Offset = "0x10DF93C")]
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
				[Address(RVA = "0x30CC478", Offset = "0x30CC478", VA = "0x30CC478")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x30CC48C", Offset = "0x30CC48C", VA = "0x30CC48C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E644C", Offset = "0x10E644C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x30CC494", Offset = "0x30CC494", VA = "0x30CC494")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E645C", Offset = "0x10E645C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x30CC49C", Offset = "0x30CC49C", VA = "0x30CC49C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x30CC5D4", Offset = "0x30CC5D4", VA = "0x30CC5D4")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x30CC61C", Offset = "0x30CC61C", VA = "0x30CC61C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x30CC7E0", Offset = "0x30CC7E0", VA = "0x30CC7E0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x30CC954", Offset = "0x30CC954", VA = "0x30CC954")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x30CCAAC", Offset = "0x30CCAAC", VA = "0x30CCAAC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF94C", Offset = "0x10DF94C")]
			public Transform target;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF984", Offset = "0x10DF984")]
			public Transform bendGoal;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF9BC", Offset = "0x10DF9BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF9BC", Offset = "0x10DF9BC")]
			public float positionWeight;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFA10", Offset = "0x10DFA10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFA10", Offset = "0x10DFA10")]
			public float rotationWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFA64", Offset = "0x10DFA64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFA64", Offset = "0x10DFA64")]
			public float bendGoalWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFAB8", Offset = "0x10DFAB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFAB8", Offset = "0x10DFAB8")]
			public float swivelOffset;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFB14", Offset = "0x10DFB14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFB14", Offset = "0x10DFB14")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFB68", Offset = "0x10DFB68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFB68", Offset = "0x10DFB68")]
			public float legLengthMlp;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFBC0", Offset = "0x10DFBC0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DFC68", Offset = "0x10DFC68")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DFC78", Offset = "0x10DFC78")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DFC88", Offset = "0x10DFC88")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DFC98", Offset = "0x10DFC98")]
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
				[Address(RVA = "0x30CCBE8", Offset = "0x30CCBE8", VA = "0x30CCBE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E646C", Offset = "0x10E646C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x30CCBF4", Offset = "0x30CCBF4", VA = "0x30CCBF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E647C", Offset = "0x10E647C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x30CCC00", Offset = "0x30CCC00", VA = "0x30CCC00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E648C", Offset = "0x10E648C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x30CCC0C", Offset = "0x30CCC0C", VA = "0x30CCC0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E649C", Offset = "0x10E649C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x30CCC18", Offset = "0x30CCC18", VA = "0x30CCC18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E64AC", Offset = "0x10E64AC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x30CCC20", Offset = "0x30CCC20", VA = "0x30CCC20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E64BC", Offset = "0x10E64BC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x30CCC2C", Offset = "0x30CCC2C", VA = "0x30CCC2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x30CCC60", Offset = "0x30CCC60", VA = "0x30CCC60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x30CCC98", Offset = "0x30CCC98", VA = "0x30CCC98")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x30CCCD0", Offset = "0x30CCCD0", VA = "0x30CCCD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x30CCD08", Offset = "0x30CCD08", VA = "0x30CCD08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x30CCD48", Offset = "0x30CCD48", VA = "0x30CCD48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E64CC", Offset = "0x10E64CC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x30CCD54", Offset = "0x30CCD54", VA = "0x30CCD54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E64DC", Offset = "0x10E64DC")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x30CCD60", Offset = "0x30CCD60", VA = "0x30CCD60", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x30CD3D8", Offset = "0x30CD3D8", VA = "0x30CD3D8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x30CD994", Offset = "0x30CD994", VA = "0x30CD994", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x30CD944", Offset = "0x30CD944", VA = "0x30CD944")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x30CD7D4", Offset = "0x30CD7D4", VA = "0x30CD7D4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x30CDD7C", Offset = "0x30CDD7C", VA = "0x30CDD7C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x30CE628", Offset = "0x30CE628", VA = "0x30CE628")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x30CDF04", Offset = "0x30CDF04", VA = "0x30CDF04")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x30CE920", Offset = "0x30CE920", VA = "0x30CE920", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x30CEB3C", Offset = "0x30CEB3C", VA = "0x30CEB3C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x30CEB88", Offset = "0x30CEB88", VA = "0x30CEB88")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFCA8", Offset = "0x10DFCA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFCA8", Offset = "0x10DFCA8")]
			public float weight;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFCFC", Offset = "0x10DFCFC")]
			public float footDistance;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFD34", Offset = "0x10DFD34")]
			public float stepThreshold;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFD6C", Offset = "0x10DFD6C")]
			public float angleThreshold;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFDA4", Offset = "0x10DFDA4")]
			public float comAngleMlp;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFDDC", Offset = "0x10DFDDC")]
			public float maxVelocity;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFE14", Offset = "0x10DFE14")]
			public float velocityFactor;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFE4C", Offset = "0x10DFE4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFE4C", Offset = "0x10DFE4C")]
			public float maxLegStretch;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFEA4", Offset = "0x10DFEA4")]
			public float rootSpeed;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFEDC", Offset = "0x10DFEDC")]
			public float stepSpeed;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFF14", Offset = "0x10DFF14")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFF4C", Offset = "0x10DFF4C")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFF84", Offset = "0x10DFF84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DFF84", Offset = "0x10DFF84")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DFFDC", Offset = "0x10DFFDC")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0014", Offset = "0x10E0014")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E004C", Offset = "0x10E004C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E00C4", Offset = "0x10E00C4")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E00FC", Offset = "0x10E00FC")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E0134", Offset = "0x10E0134")]
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
				[Address(RVA = "0x30CEC58", Offset = "0x30CEC58", VA = "0x30CEC58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E64EC", Offset = "0x10E64EC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x30CEC64", Offset = "0x30CEC64", VA = "0x30CEC64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E64FC", Offset = "0x10E64FC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x30D0750", Offset = "0x30D0750", VA = "0x30D0750")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x30D0790", Offset = "0x30D0790", VA = "0x30D0790")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x30D07D4", Offset = "0x30D07D4", VA = "0x30D07D4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x30D0814", Offset = "0x30D0814", VA = "0x30D0814")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x30CEC70", Offset = "0x30CEC70", VA = "0x30CEC70")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x30CEF10", Offset = "0x30CEF10", VA = "0x30CEF10")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x30CF0E0", Offset = "0x30CF0E0", VA = "0x30CF0E0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x30CF328", Offset = "0x30CF328", VA = "0x30CF328")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x30CF3EC", Offset = "0x30CF3EC", VA = "0x30CF3EC")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x30D04C8", Offset = "0x30D04C8", VA = "0x30D04C8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x30D0600", Offset = "0x30D0600", VA = "0x30D0600")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x30D0684", Offset = "0x30D0684", VA = "0x30D0684")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x30D0858", Offset = "0x30D0858", VA = "0x30D0858")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0144", Offset = "0x10E0144")]
			public Transform headTarget;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E017C", Offset = "0x10E017C")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E01B4", Offset = "0x10E01B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E01B4", Offset = "0x10E01B4")]
			public float positionWeight;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E0208", Offset = "0x10E0208")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0208", Offset = "0x10E0208")]
			public float rotationWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E025C", Offset = "0x10E025C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E025C", Offset = "0x10E025C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E02B0", Offset = "0x10E02B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E02B0", Offset = "0x10E02B0")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0304", Offset = "0x10E0304")]
			public Transform chestGoal;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E033C", Offset = "0x10E033C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E033C", Offset = "0x10E033C")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0390", Offset = "0x10E0390")]
			public float minHeadHeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E03C8", Offset = "0x10E03C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E03C8", Offset = "0x10E03C8")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E041C", Offset = "0x10E041C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E041C", Offset = "0x10E041C")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0470", Offset = "0x10E0470")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x10E0470", Offset = "0x10E0470")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E0470", Offset = "0x10E0470")]
			public float neckStiffness;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E04E8", Offset = "0x10E04E8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E04E8", Offset = "0x10E04E8")]
			public float rotateChestByHands;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E053C", Offset = "0x10E053C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E053C", Offset = "0x10E053C")]
			public float chestClampWeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0590", Offset = "0x10E0590")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E0590", Offset = "0x10E0590")]
			public float headClampWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E05E4", Offset = "0x10E05E4")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E061C", Offset = "0x10E061C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E061C", Offset = "0x10E061C")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0670", Offset = "0x10E0670")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E0670", Offset = "0x10E0670")]
			public float maxRootAngle;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E06C8", Offset = "0x10E06C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E06C8", Offset = "0x10E06C8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E0804", Offset = "0x10E0804")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E0814", Offset = "0x10E0814")]
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
				[Address(RVA = "0x30D0448", Offset = "0x30D0448", VA = "0x30D0448")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x30D0944", Offset = "0x30D0944", VA = "0x30D0944")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x30D0984", Offset = "0x30D0984", VA = "0x30D0984")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x30D09D8", Offset = "0x30D09D8", VA = "0x30D09D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x30D0488", Offset = "0x30D0488", VA = "0x30D0488")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x30D0A18", Offset = "0x30D0A18", VA = "0x30D0A18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E650C", Offset = "0x10E650C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x30D0A2C", Offset = "0x30D0A2C", VA = "0x30D0A2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E651C", Offset = "0x10E651C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x30D0A40", Offset = "0x30D0A40", VA = "0x30D0A40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E652C", Offset = "0x10E652C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x30D0A54", Offset = "0x30D0A54", VA = "0x30D0A54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E653C", Offset = "0x10E653C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x30D0A68", Offset = "0x30D0A68", VA = "0x30D0A68", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x30D1474", Offset = "0x30D1474", VA = "0x30D1474", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x30D1680", Offset = "0x30D1680", VA = "0x30D1680", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x30D1AC4", Offset = "0x30D1AC4", VA = "0x30D1AC4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x30D1F00", Offset = "0x30D1F00", VA = "0x30D1F00")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x30D2654", Offset = "0x30D2654", VA = "0x30D2654")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x30D2CD4", Offset = "0x30D2CD4", VA = "0x30D2CD4")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x30D32D4", Offset = "0x30D32D4", VA = "0x30D32D4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x30D34B0", Offset = "0x30D34B0", VA = "0x30D34B0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x30D1C5C", Offset = "0x30D1C5C", VA = "0x30D1C5C")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x30D2A24", Offset = "0x30D2A24", VA = "0x30D2A24")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x30D2310", Offset = "0x30D2310", VA = "0x30D2310")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x30D3548", Offset = "0x30D3548", VA = "0x30D3548")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x30D2B00", Offset = "0x30D2B00", VA = "0x30D2B00")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x30D27D0", Offset = "0x30D27D0", VA = "0x30D27D0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x30D373C", Offset = "0x30D373C", VA = "0x30D373C")]
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
			[Address(RVA = "0x30CD33C", Offset = "0x30CD33C", VA = "0x30CD33C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x30CD3B8", Offset = "0x30CD3B8", VA = "0x30CD3B8")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x30D38AC", Offset = "0x30D38AC", VA = "0x30D38AC")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x30CBB7C", Offset = "0x30CBB7C", VA = "0x30CBB7C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x30CBEA8", Offset = "0x30CBEA8", VA = "0x30CBEA8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x30D3A30", Offset = "0x30D3A30", VA = "0x30D3A30")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x30D3B90", Offset = "0x30D3B90", VA = "0x30D3B90")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x30D3CCC", Offset = "0x30D3CCC", VA = "0x30D3CCC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x30CE224", Offset = "0x30CE224", VA = "0x30CE224")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x30D3D84", Offset = "0x30D3D84", VA = "0x30D3D84")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x30D2F44", Offset = "0x30D2F44", VA = "0x30D2F44")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x30D3EEC", Offset = "0x30D3EEC", VA = "0x30D3EEC")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x30D3F5C", Offset = "0x30D3F5C", VA = "0x30D3F5C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10DF318", Offset = "0x10DF318")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF318", Offset = "0x10DF318")]
		public int LOD;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF36C", Offset = "0x10DF36C")]
		public bool plantFeet;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DF3A4", Offset = "0x10DF3A4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF3B4", Offset = "0x10DF3B4")]
		public Spine spine;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF3EC", Offset = "0x10DF3EC")]
		public Arm leftArm;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF424", Offset = "0x10DF424")]
		public Arm rightArm;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF45C", Offset = "0x10DF45C")]
		public Leg leftLeg;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF494", Offset = "0x10DF494")]
		public Leg rightLeg;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10DF4CC", Offset = "0x10DF4CC")]
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
			[Address(RVA = "0x30958E0", Offset = "0x30958E0", VA = "0x30958E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E63AC", Offset = "0x10E63AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x30958E8", Offset = "0x30958E8", VA = "0x30958E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E63BC", Offset = "0x10E63BC")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3091D78", Offset = "0x3091D78", VA = "0x3091D78")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x30921DC", Offset = "0x30921DC", VA = "0x30921DC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x3092088", Offset = "0x3092088", VA = "0x3092088")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x309293C", Offset = "0x309293C", VA = "0x309293C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x3092A80", Offset = "0x3092A80", VA = "0x3092A80")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x3092AB0", Offset = "0x3092AB0", VA = "0x3092AB0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x3092B60", Offset = "0x3092B60", VA = "0x3092B60")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x3092C48", Offset = "0x3092C48", VA = "0x3092C48")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x30933AC", Offset = "0x30933AC", VA = "0x30933AC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x309351C", Offset = "0x309351C", VA = "0x309351C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x3093720", Offset = "0x3093720", VA = "0x3093720", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x309379C", Offset = "0x309379C", VA = "0x309379C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3093818", Offset = "0x3093818", VA = "0x3093818", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x30939F0", Offset = "0x30939F0", VA = "0x30939F0")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x3092410", Offset = "0x3092410", VA = "0x3092410")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x3092500", Offset = "0x3092500", VA = "0x3092500")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x309281C", Offset = "0x309281C", VA = "0x309281C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x3092D3C", Offset = "0x3092D3C", VA = "0x3092D3C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x3093BB0", Offset = "0x3093BB0", VA = "0x3093BB0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3093BF8", Offset = "0x3093BF8", VA = "0x3093BF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3095010", Offset = "0x3095010", VA = "0x3095010")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x3092EA0", Offset = "0x3092EA0", VA = "0x3092EA0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x3093F6C", Offset = "0x3093F6C", VA = "0x3093F6C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x30953C0", Offset = "0x30953C0", VA = "0x30953C0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x3095408", Offset = "0x3095408", VA = "0x3095408")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3094EC0", Offset = "0x3094EC0", VA = "0x3094EC0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x309544C", Offset = "0x309544C", VA = "0x309544C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x30958F0", Offset = "0x30958F0", VA = "0x30958F0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0824", Offset = "0x10E0824")]
		public Transform parent;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E085C", Offset = "0x10E085C")]
		public Transform child;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0894", Offset = "0x10E0894")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E0894", Offset = "0x10E0894")]
		public float weight;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E08E8", Offset = "0x10E08E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E08E8", Offset = "0x10E08E8")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E093C", Offset = "0x10E093C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E093C", Offset = "0x10E093C")]
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
		[Address(RVA = "0x2D72034", Offset = "0x2D72034", VA = "0x2D72034")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2D72350", Offset = "0x2D72350", VA = "0x2D72350")]
		private void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2D7270C", Offset = "0x2D7270C", VA = "0x2D7270C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2D72790", Offset = "0x2D72790", VA = "0x2D72790")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2D72814", Offset = "0x2D72814", VA = "0x2D72814")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2D72920", Offset = "0x2D72920", VA = "0x2D72920")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E0998", Offset = "0x10E0998")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E09A8", Offset = "0x10E09A8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E09B8", Offset = "0x10E09B8")]
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
			[Address(RVA = "0x30966AC", Offset = "0x30966AC", VA = "0x30966AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E654C", Offset = "0x10E654C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x30966B4", Offset = "0x30966B4", VA = "0x30966B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E655C", Offset = "0x10E655C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x30966BC", Offset = "0x30966BC", VA = "0x30966BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E656C", Offset = "0x10E656C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x30966C4", Offset = "0x30966C4", VA = "0x30966C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E657C", Offset = "0x10E657C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x30966D0", Offset = "0x30966D0", VA = "0x30966D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E658C", Offset = "0x10E658C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x30966D8", Offset = "0x30966D8", VA = "0x30966D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E659C", Offset = "0x10E659C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x30966E0", Offset = "0x30966E0", VA = "0x30966E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x3097E58", Offset = "0x3097E58", VA = "0x3097E58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x309674C", Offset = "0x309674C", VA = "0x309674C")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x30967D8", Offset = "0x30967D8", VA = "0x30967D8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x3096874", Offset = "0x3096874", VA = "0x3096874")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x30969D0", Offset = "0x30969D0", VA = "0x30969D0")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x3096D0C", Offset = "0x3096D0C", VA = "0x3096D0C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3096DC8", Offset = "0x3096DC8", VA = "0x3096DC8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x3096E20", Offset = "0x3096E20", VA = "0x3096E20")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x3097260", Offset = "0x3097260", VA = "0x3097260")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x309787C", Offset = "0x309787C", VA = "0x309787C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x3097AC0", Offset = "0x3097AC0", VA = "0x3097AC0")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3097D00", Offset = "0x3097D00", VA = "0x3097D00")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3097E94", Offset = "0x3097E94", VA = "0x3097E94")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E09C8", Offset = "0x10E09C8")]
		public LookAtIK ik;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0A00", Offset = "0x10E0A00")]
		public float lerpSpeed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0A38", Offset = "0x10E0A38")]
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
		[Address(RVA = "0x309808C", Offset = "0x309808C", VA = "0x309808C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x30981A8", Offset = "0x30981A8", VA = "0x30981A8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x309824C", Offset = "0x309824C", VA = "0x309824C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x3098444", Offset = "0x3098444", VA = "0x3098444")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x3098538", Offset = "0x3098538", VA = "0x3098538")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x3098600", Offset = "0x3098600", VA = "0x3098600")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC4D4", Offset = "0x10DC4D4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC4D4", Offset = "0x10DC4D4")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0B48", Offset = "0x10E0B48")]
			public float time;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0B80", Offset = "0x10E0B80")]
			public bool pause;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0BB8", Offset = "0x10E0BB8")]
			public bool pickUp;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0BF0", Offset = "0x10E0BF0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0C28", Offset = "0x10E0C28")]
			public Message[] messages;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0C60", Offset = "0x10E0C60")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x30D4708", Offset = "0x30D4708", VA = "0x30D4708")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x30D48DC", Offset = "0x30D48DC", VA = "0x30D48DC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0C98", Offset = "0x10E0C98")]
			public string function;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0CD0", Offset = "0x10E0CD0")]
			public GameObject recipient;

			[Token(Token = "0x400045C")]
			private const string empty = "";

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x30D47D8", Offset = "0x30D47D8", VA = "0x30D47D8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x30D48E4", Offset = "0x30D48E4", VA = "0x30D48E4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0D08", Offset = "0x10E0D08")]
			public Animator animator;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0D40", Offset = "0x10E0D40")]
			public Animation animation;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0D78", Offset = "0x10E0D78")]
			public string animationState;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0DB0", Offset = "0x10E0DB0")]
			public float crossfadeTime;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0DE8", Offset = "0x10E0DE8")]
			public int layer;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0E20", Offset = "0x10E0E20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000463")]
			private const string empty = "";

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x30D4474", Offset = "0x30D4474", VA = "0x30D4474")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x30D4564", Offset = "0x30D4564", VA = "0x30D4564")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x30D4618", Offset = "0x30D4618", VA = "0x30D4618")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x30D46F4", Offset = "0x30D46F4", VA = "0x30D46F4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0E58", Offset = "0x10E0E58")]
			public Type type;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0E90", Offset = "0x10E0E90")]
			public AnimationCurve curve;

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x30D4928", Offset = "0x30D4928", VA = "0x30D4928")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x30D4954", Offset = "0x30D4954", VA = "0x30D4954")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0EC8", Offset = "0x10E0EC8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0F00", Offset = "0x10E0F00")]
			public float multiplier;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0F38", Offset = "0x10E0F38")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x30D48EC", Offset = "0x30D48EC", VA = "0x30D48EC")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x30D4944", Offset = "0x30D4944", VA = "0x30D4944")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0A80", Offset = "0x10E0A80")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0AB8", Offset = "0x10E0AB8")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0AF0", Offset = "0x10E0AF0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E0B28", Offset = "0x10E0B28")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E0B38", Offset = "0x10E0B38")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x2EF0DB4", Offset = "0x2EF0DB4", VA = "0x2EF0DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E676C", Offset = "0x10E676C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x2EF0DBC", Offset = "0x2EF0DBC", VA = "0x2EF0DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E677C", Offset = "0x10E677C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x2EF0DC4", Offset = "0x2EF0DC4", VA = "0x2EF0DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E678C", Offset = "0x10E678C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x2EF0DCC", Offset = "0x2EF0DCC", VA = "0x2EF0DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E679C", Offset = "0x10E679C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x2EF1020", Offset = "0x2EF1020", VA = "0x2EF1020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x2EF0F94", Offset = "0x2EF0F94", VA = "0x2EF0F94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2EF0B74", Offset = "0x2EF0B74", VA = "0x2EF0B74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E65AC", Offset = "0x10E65AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2EF0BBC", Offset = "0x2EF0BBC", VA = "0x2EF0BBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E65E4", Offset = "0x10E65E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2EF0C04", Offset = "0x2EF0C04", VA = "0x2EF0C04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E661C", Offset = "0x10E661C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2EF0C4C", Offset = "0x2EF0C4C", VA = "0x2EF0C4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6654", Offset = "0x10E6654")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2EF0C94", Offset = "0x2EF0C94", VA = "0x2EF0C94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E668C", Offset = "0x10E668C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2EF0CDC", Offset = "0x2EF0CDC", VA = "0x2EF0CDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E66C4", Offset = "0x10E66C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2EF0D24", Offset = "0x2EF0D24", VA = "0x2EF0D24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E66FC", Offset = "0x10E66FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2EF0D6C", Offset = "0x2EF0D6C", VA = "0x2EF0D6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6734", Offset = "0x10E6734")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2EF0DD4", Offset = "0x2EF0DD4", VA = "0x2EF0DD4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2EF10AC", Offset = "0x2EF10AC", VA = "0x2EF10AC")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2EF1238", Offset = "0x2EF1238", VA = "0x2EF1238")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2EF12EC", Offset = "0x2EF12EC", VA = "0x2EF12EC")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2EF12F4", Offset = "0x2EF12F4", VA = "0x2EF12F4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2EF14B0", Offset = "0x2EF14B0", VA = "0x2EF14B0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2EF14B8", Offset = "0x2EF14B8", VA = "0x2EF14B8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2EF1E80", Offset = "0x2EF1E80", VA = "0x2EF1E80")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2EF20A0", Offset = "0x2EF20A0", VA = "0x2EF20A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2EF1984", Offset = "0x2EF1984", VA = "0x2EF1984")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2EF1440", Offset = "0x2EF1440", VA = "0x2EF1440")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2EF1E18", Offset = "0x2EF1E18", VA = "0x2EF1E18")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2EF20A4", Offset = "0x2EF20A4", VA = "0x2EF20A4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2EF210C", Offset = "0x2EF210C", VA = "0x2EF210C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC534", Offset = "0x10DC534")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC534", Offset = "0x10DC534")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0F70", Offset = "0x10E0F70")]
		public string targetTag;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0FA8", Offset = "0x10E0FA8")]
		public float fadeInTime;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E0FE0", Offset = "0x10E0FE0")]
		public float speed;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1018", Offset = "0x10E1018")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x10E1050", Offset = "0x10E1050")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E1050", Offset = "0x10E1050")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1050", Offset = "0x10E1050")]
		public Collider characterCollider;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x10E10D4", Offset = "0x10E10D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E10D4", Offset = "0x10E10D4")]
		public Transform FPSCamera;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1134", Offset = "0x10E1134")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E116C", Offset = "0x10E116C")]
		public float camRaycastDistance;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E11A4", Offset = "0x10E11A4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E11B4", Offset = "0x10E11B4")]
		[SerializeField]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10E11B4", Offset = "0x10E11B4")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1214", Offset = "0x10E1214")]
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
			[Address(RVA = "0x2EF23A8", Offset = "0x2EF23A8", VA = "0x2EF23A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x2EF404C", Offset = "0x2EF404C", VA = "0x2EF404C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x2EF4054", Offset = "0x2EF4054", VA = "0x2EF4054")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x2EF405C", Offset = "0x2EF405C", VA = "0x2EF405C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E696C", Offset = "0x10E696C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x2EF4064", Offset = "0x2EF4064", VA = "0x2EF4064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E697C", Offset = "0x10E697C")]
			private set
			{
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2EF2168", Offset = "0x2EF2168", VA = "0x2EF2168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E67AC", Offset = "0x10E67AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2EF21B0", Offset = "0x2EF21B0", VA = "0x2EF21B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E67E4", Offset = "0x10E67E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2EF21F8", Offset = "0x2EF21F8", VA = "0x2EF21F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E681C", Offset = "0x10E681C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2EF2240", Offset = "0x2EF2240", VA = "0x2EF2240")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6854", Offset = "0x10E6854")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2EF2288", Offset = "0x2EF2288", VA = "0x2EF2288")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E688C", Offset = "0x10E688C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2EF22D0", Offset = "0x2EF22D0", VA = "0x2EF22D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E68C4", Offset = "0x10E68C4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2EF2318", Offset = "0x2EF2318", VA = "0x2EF2318")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E68FC", Offset = "0x10E68FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x2EF2360", Offset = "0x2EF2360", VA = "0x2EF2360")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6934", Offset = "0x10E6934")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2EF2550", Offset = "0x2EF2550", VA = "0x2EF2550")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x2EF2620", Offset = "0x2EF2620", VA = "0x2EF2620")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2EF26F0", Offset = "0x2EF26F0", VA = "0x2EF26F0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2EF27A0", Offset = "0x2EF27A0", VA = "0x2EF27A0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2EF289C", Offset = "0x2EF289C", VA = "0x2EF289C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2EF29B8", Offset = "0x2EF29B8", VA = "0x2EF29B8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2EF2A4C", Offset = "0x2EF2A4C", VA = "0x2EF2A4C")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2EF2AE0", Offset = "0x2EF2AE0", VA = "0x2EF2AE0")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2EF2B74", Offset = "0x2EF2B74", VA = "0x2EF2B74")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2EF2BEC", Offset = "0x2EF2BEC", VA = "0x2EF2BEC")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2EF2C64", Offset = "0x2EF2C64", VA = "0x2EF2C64")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2EF2CD0", Offset = "0x2EF2CD0", VA = "0x2EF2CD0")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2EF2D5C", Offset = "0x2EF2D5C", VA = "0x2EF2D5C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2EF2DF0", Offset = "0x2EF2DF0", VA = "0x2EF2DF0")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2EF2EBC", Offset = "0x2EF2EBC", VA = "0x2EF2EBC")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2EF3194", Offset = "0x2EF3194", VA = "0x2EF3194")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2EF3374", Offset = "0x2EF3374", VA = "0x2EF3374")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2EF3608", Offset = "0x2EF3608", VA = "0x2EF3608")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2EF38E0", Offset = "0x2EF38E0", VA = "0x2EF38E0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2EF3924", Offset = "0x2EF3924", VA = "0x2EF3924")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2EF399C", Offset = "0x2EF399C", VA = "0x2EF399C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2EF3AB8", Offset = "0x2EF3AB8", VA = "0x2EF3AB8")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2EF3C5C", Offset = "0x2EF3C5C", VA = "0x2EF3C5C")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2EF3F00", Offset = "0x2EF3F00", VA = "0x2EF3F00")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2EF371C", Offset = "0x2EF371C", VA = "0x2EF371C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2EF406C", Offset = "0x2EF406C", VA = "0x2EF406C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2EF47DC", Offset = "0x2EF47DC", VA = "0x2EF47DC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2EF47FC", Offset = "0x2EF47FC", VA = "0x2EF47FC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2EF4818", Offset = "0x2EF4818", VA = "0x2EF4818")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2EF4834", Offset = "0x2EF4834", VA = "0x2EF4834")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2EF4898", Offset = "0x2EF4898", VA = "0x2EF4898")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2EF49D4", Offset = "0x2EF49D4", VA = "0x2EF49D4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2EF4AE4", Offset = "0x2EF4AE4", VA = "0x2EF4AE4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2EF4E88", Offset = "0x2EF4E88", VA = "0x2EF4E88")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2EF4F88", Offset = "0x2EF4F88", VA = "0x2EF4F88")]
		public void Update()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2EF521C", Offset = "0x2EF521C", VA = "0x2EF521C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2EF4540", Offset = "0x2EF4540", VA = "0x2EF4540")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2EF5358", Offset = "0x2EF5358", VA = "0x2EF5358")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2EF5488", Offset = "0x2EF5488", VA = "0x2EF5488")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2EF5520", Offset = "0x2EF5520", VA = "0x2EF5520")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2EF55FC", Offset = "0x2EF55FC", VA = "0x2EF55FC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2EF5618", Offset = "0x2EF5618", VA = "0x2EF5618")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2EF2458", Offset = "0x2EF2458", VA = "0x2EF2458")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2EF3064", Offset = "0x2EF3064", VA = "0x2EF3064")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2EF5980", Offset = "0x2EF5980", VA = "0x2EF5980")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC594", Offset = "0x10DC594")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC594", Offset = "0x10DC594")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Multiplier
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E140C", Offset = "0x10E140C")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1444", Offset = "0x10E1444")]
			public float multiplier;

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x30D4FC0", Offset = "0x30D4FC0", VA = "0x30D4FC0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E124C", Offset = "0x10E124C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1284", Offset = "0x10E1284")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E12BC", Offset = "0x10E12BC")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E12F4", Offset = "0x10E12F4")]
		public Transform pivot;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E132C", Offset = "0x10E132C")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1364", Offset = "0x10E1364")]
		public float twistWeight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E139C", Offset = "0x10E139C")]
		public float swingWeight;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E13D4", Offset = "0x10E13D4")]
		public bool rotateOnce;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2EF60D0", Offset = "0x2EF60D0", VA = "0x2EF60D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E698C", Offset = "0x10E698C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2EF6118", Offset = "0x2EF6118", VA = "0x2EF6118")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E69C4", Offset = "0x10E69C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2EF6160", Offset = "0x2EF6160", VA = "0x2EF6160")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E69FC", Offset = "0x10E69FC")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2EF61A8", Offset = "0x2EF61A8", VA = "0x2EF61A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6A34", Offset = "0x10E6A34")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2EF61F0", Offset = "0x2EF61F0", VA = "0x2EF61F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6A6C", Offset = "0x10E6A6C")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2EF6238", Offset = "0x2EF6238", VA = "0x2EF6238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6AA4", Offset = "0x10E6AA4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x2EF6280", Offset = "0x2EF6280", VA = "0x2EF6280")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6ADC", Offset = "0x10E6ADC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2EF62C8", Offset = "0x2EF62C8", VA = "0x2EF62C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6B14", Offset = "0x10E6B14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x2EF1914", Offset = "0x2EF1914", VA = "0x2EF1914")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2EF6310", Offset = "0x2EF6310", VA = "0x2EF6310")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x2EF63A8", Offset = "0x2EF63A8", VA = "0x2EF63A8")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2EF6858", Offset = "0x2EF6858", VA = "0x2EF6858")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC5F4", Offset = "0x10DC5F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC5F4", Offset = "0x10DC5F4")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class CharacterPosition
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E14B4", Offset = "0x10E14B4")]
			public bool use;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E14EC", Offset = "0x10E14EC")]
			public Vector2 offset;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1524", Offset = "0x10E1524")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1524", Offset = "0x10E1524")]
			public float angleOffset;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1580", Offset = "0x10E1580")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1580", Offset = "0x10E1580")]
			public float maxAngle;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E15D8", Offset = "0x10E15D8")]
			public float radius;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1610", Offset = "0x10E1610")]
			public bool orbit;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1648", Offset = "0x10E1648")]
			public bool fixYAxis;

			[Token(Token = "0x1700008D")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x30D5330", Offset = "0x30D5330", VA = "0x30D5330")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x30D533C", Offset = "0x30D533C", VA = "0x30D533C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x30D53C4", Offset = "0x30D53C4", VA = "0x30D53C4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x30D5808", Offset = "0x30D5808", VA = "0x30D5808")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1680", Offset = "0x10E1680")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E16B8", Offset = "0x10E16B8")]
			public Vector3 direction;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E16F0", Offset = "0x10E16F0")]
			public float maxDistance;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1728", Offset = "0x10E1728")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1728", Offset = "0x10E1728")]
			public float maxAngle;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1780", Offset = "0x10E1780")]
			public bool fixYAxis;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x30D4FC8", Offset = "0x30D4FC8", VA = "0x30D4FC8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x30D50BC", Offset = "0x30D50BC", VA = "0x30D50BC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x30D52E4", Offset = "0x30D52E4", VA = "0x30D52E4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E18D0", Offset = "0x10E18D0")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1908", Offset = "0x10E1908")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600053B")]
				[Address(RVA = "0x30DACF8", Offset = "0x30DACF8", VA = "0x30DACF8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1828", Offset = "0x10E1828")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1860", Offset = "0x10E1860")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1898", Offset = "0x10E1898")]
			public Interaction[] interactions;

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x30D581C", Offset = "0x30D581C", VA = "0x30D581C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x30D58D0", Offset = "0x30D58D0", VA = "0x30D58D0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E147C", Offset = "0x10E147C")]
		public Range[] ranges;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2EF68A0", Offset = "0x2EF68A0", VA = "0x2EF68A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6B4C", Offset = "0x10E6B4C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2EF68E8", Offset = "0x2EF68E8", VA = "0x2EF68E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6B84", Offset = "0x10E6B84")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2EF6930", Offset = "0x2EF6930", VA = "0x2EF6930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6BBC", Offset = "0x10E6BBC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2EF6978", Offset = "0x2EF6978", VA = "0x2EF6978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6BF4", Offset = "0x10E6BF4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2EF69C0", Offset = "0x2EF69C0", VA = "0x2EF69C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6C2C", Offset = "0x10E6C2C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2EF6A08", Offset = "0x2EF6A08", VA = "0x2EF6A08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2EF4CB4", Offset = "0x2EF4CB4", VA = "0x2EF4CB4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2EF6A0C", Offset = "0x2EF6A0C", VA = "0x2EF6A0C")]
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
			[Address(RVA = "0x2D78FD8", Offset = "0x2D78FD8", VA = "0x2D78FD8")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x2D79014", Offset = "0x2D79014", VA = "0x2D79014")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x2D79064", Offset = "0x2D79064", VA = "0x2D79064")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x2D790B0", Offset = "0x2D790B0", VA = "0x2D790B0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x3070E28", Offset = "0x3070E28", VA = "0x3070E28", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6C64", Offset = "0x10E6C64")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x30711A4", Offset = "0x30711A4", VA = "0x30711A4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x30711A8", Offset = "0x30711A8", VA = "0x30711A8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x30712B0", Offset = "0x30712B0", VA = "0x30712B0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x3071138", Offset = "0x3071138", VA = "0x3071138")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x3071098", Offset = "0x3071098", VA = "0x3071098")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x307131C", Offset = "0x307131C", VA = "0x307131C")]
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
		[Address(RVA = "0x30DC77C", Offset = "0x30DC77C", VA = "0x30DC77C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x30DC844", Offset = "0x30DC844", VA = "0x30DC844", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x30DCA00", Offset = "0x30DCA00", VA = "0x30DCA00", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x30DCAFC", Offset = "0x30DCAFC", VA = "0x30DCAFC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x30DC89C", Offset = "0x30DC89C", VA = "0x30DC89C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x30DCE5C", Offset = "0x30DCE5C", VA = "0x30DCE5C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1940", Offset = "0x10E1940")]
		public float weight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1958", Offset = "0x10E1958")]
		public float localRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1970", Offset = "0x10E1970")]
		public float localPositionWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600054D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2EFDDD8", Offset = "0x2EFDDD8", VA = "0x2EFDDD8")]
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
		[Address(RVA = "0x2EFDDE4", Offset = "0x2EFDDE4", VA = "0x2EFDDE4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x2EFDE38", Offset = "0x2EFDE38", VA = "0x2EFDE38", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x2EFDE74", Offset = "0x2EFDE74", VA = "0x2EFDE74", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2EFDE8C", Offset = "0x2EFDE8C", VA = "0x2EFDE8C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DC654", Offset = "0x10DC654")]
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
			[Address(RVA = "0x30D7840", Offset = "0x30D7840", VA = "0x30D7840")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x30D79B0", Offset = "0x30D79B0", VA = "0x30D79B0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x30D7A90", Offset = "0x30D7A90", VA = "0x30D7A90")]
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
			[Address(RVA = "0x30D7650", Offset = "0x30D7650", VA = "0x30D7650")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x30D76B0", Offset = "0x30D76B0", VA = "0x30D76B0")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x30D77F0", Offset = "0x30D77F0", VA = "0x30D77F0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DC6B4", Offset = "0x10DC6B4")]
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
				[Address(RVA = "0x30D7600", Offset = "0x30D7600", VA = "0x30D7600", Slot = "4")]
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
				[Address(RVA = "0x30D7648", Offset = "0x30D7648", VA = "0x30D7648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x30D73E4", Offset = "0x30D73E4", VA = "0x30D73E4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x30D7410", Offset = "0x30D7410", VA = "0x30D7410", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x30D7414", Offset = "0x30D7414", VA = "0x30D7414", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x30D7608", Offset = "0x30D7608", VA = "0x30D7608", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1988", Offset = "0x10E1988")]
		public IK ik;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E19C0", Offset = "0x10E19C0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E19F8", Offset = "0x10E19F8")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1A30", Offset = "0x10E1A30")]
		public float applyVelocity;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1A68", Offset = "0x10E1A68")]
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
			[Address(RVA = "0x2EFE6C4", Offset = "0x2EFE6C4", VA = "0x2EFE6C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x2EFF04C", Offset = "0x2EFF04C", VA = "0x2EFF04C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2EFE68C", Offset = "0x2EFE68C", VA = "0x2EFE68C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2EFE73C", Offset = "0x2EFE73C", VA = "0x2EFE73C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2EFE86C", Offset = "0x2EFE86C", VA = "0x2EFE86C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2EFE800", Offset = "0x2EFE800", VA = "0x2EFE800")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E6C9C", Offset = "0x10E6C9C")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x2EFEC88", Offset = "0x2EFEC88", VA = "0x2EFEC88")]
		private void Update()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2EFEED4", Offset = "0x2EFEED4", VA = "0x2EFEED4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2EFEF90", Offset = "0x2EFEF90", VA = "0x2EFEF90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2EFF1CC", Offset = "0x2EFF1CC", VA = "0x2EFF1CC")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2EFF010", Offset = "0x2EFF010", VA = "0x2EFF010")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2EFF188", Offset = "0x2EFF188", VA = "0x2EFF188")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2EFF26C", Offset = "0x2EFF26C", VA = "0x2EFF26C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2EFF200", Offset = "0x2EFF200", VA = "0x2EFF200")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2EFE794", Offset = "0x2EFE794", VA = "0x2EFE794")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2EFEF14", Offset = "0x2EFEF14", VA = "0x2EFEF14")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2EFF498", Offset = "0x2EFF498", VA = "0x2EFF498")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2EFF5B0", Offset = "0x2EFF5B0", VA = "0x2EFF5B0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1AB0", Offset = "0x10E1AB0")]
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
			[Address(RVA = "0x2F00CCC", Offset = "0x2F00CCC", VA = "0x2F00CCC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x2F00CD8", Offset = "0x2F00CD8", VA = "0x2F00CD8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x2F00CF4", Offset = "0x2F00CF4", VA = "0x2F00CF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E6D4C", Offset = "0x10E6D4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2F00CFC", Offset = "0x2F00CFC", VA = "0x2F00CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E6D5C", Offset = "0x10E6D5C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2F009CC", Offset = "0x2F009CC", VA = "0x2F009CC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2F00A14", Offset = "0x2F00A14", VA = "0x2F00A14")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x2F00A2C", Offset = "0x2F00A2C", VA = "0x2F00A2C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x2F00C24", Offset = "0x2F00C24", VA = "0x2F00C24")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2F00C94", Offset = "0x2F00C94", VA = "0x2F00C94")]
		public void Disable()
		{
		}

		[Token(Token = "0x600057D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x2F00B4C", Offset = "0x2F00B4C", VA = "0x2F00B4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2F00D08", Offset = "0x2F00D08", VA = "0x2F00D08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2F00D0C", Offset = "0x2F00D0C", VA = "0x2F00D0C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2F00D40", Offset = "0x2F00D40", VA = "0x2F00D40")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2F00DBC", Offset = "0x2F00DBC", VA = "0x2F00DBC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2F00F50", Offset = "0x2F00F50", VA = "0x2F00F50")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2F00FC0", Offset = "0x2F00FC0", VA = "0x2F00FC0")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC6C4", Offset = "0x10DC6C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC6C4", Offset = "0x10DC6C4")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1AC0", Offset = "0x10E1AC0")]
		public float limit;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1ADC", Offset = "0x10E1ADC")]
		public float twistLimit;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2F00FF4", Offset = "0x2F00FF4", VA = "0x2F00FF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6D6C", Offset = "0x10E6D6C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2F0103C", Offset = "0x2F0103C", VA = "0x2F0103C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6DA4", Offset = "0x10E6DA4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x2F01084", Offset = "0x2F01084", VA = "0x2F01084")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6DDC", Offset = "0x10E6DDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2F010CC", Offset = "0x2F010CC", VA = "0x2F010CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6E14", Offset = "0x10E6E14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2F01114", Offset = "0x2F01114", VA = "0x2F01114", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2F01158", Offset = "0x2F01158", VA = "0x2F01158")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2F01318", Offset = "0x2F01318", VA = "0x2F01318")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC724", Offset = "0x10DC724")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC724", Offset = "0x10DC724")]
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
		[Address(RVA = "0x2F01358", Offset = "0x2F01358", VA = "0x2F01358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6E4C", Offset = "0x10E6E4C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2F013A0", Offset = "0x2F013A0", VA = "0x2F013A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6E84", Offset = "0x10E6E84")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2F013E8", Offset = "0x2F013E8", VA = "0x2F013E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6EBC", Offset = "0x10E6EBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2F01430", Offset = "0x2F01430", VA = "0x2F01430")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6EF4", Offset = "0x10E6EF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2F01478", Offset = "0x2F01478", VA = "0x2F01478", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2F014A0", Offset = "0x2F014A0", VA = "0x2F014A0")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2F0169C", Offset = "0x2F0169C", VA = "0x2F0169C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC784", Offset = "0x10DC784")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC784", Offset = "0x10DC784")]
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
				[Address(RVA = "0x30D80C4", Offset = "0x30D80C4", VA = "0x30D80C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x30D80FC", Offset = "0x30D80FC", VA = "0x30D80FC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x30D8138", Offset = "0x30D8138", VA = "0x30D8138")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x30D8174", Offset = "0x30D8174", VA = "0x30D8174")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x30D82EC", Offset = "0x30D82EC", VA = "0x30D82EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x30D81B0", Offset = "0x30D81B0", VA = "0x30D81B0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x30D82FC", Offset = "0x30D82FC", VA = "0x30D82FC")]
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
			[Address(RVA = "0x30D8088", Offset = "0x30D8088", VA = "0x30D8088")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1B08", Offset = "0x10E1B08")]
		public float twistLimit;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1B24", Offset = "0x10E1B24")]
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
		[Address(RVA = "0x2F016F4", Offset = "0x2F016F4", VA = "0x2F016F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6F2C", Offset = "0x10E6F2C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2F0173C", Offset = "0x2F0173C", VA = "0x2F0173C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6F64", Offset = "0x10E6F64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2F01784", Offset = "0x2F01784", VA = "0x2F01784")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6F9C", Offset = "0x10E6F9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2F017CC", Offset = "0x2F017CC", VA = "0x2F017CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E6FD4", Offset = "0x10E6FD4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2F01814", Offset = "0x2F01814", VA = "0x2F01814")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2F01CB4", Offset = "0x2F01CB4", VA = "0x2F01CB4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2F01D48", Offset = "0x2F01D48", VA = "0x2F01D48")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2F02274", Offset = "0x2F02274", VA = "0x2F02274")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2F018B0", Offset = "0x2F018B0", VA = "0x2F018B0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2F025F4", Offset = "0x2F025F4", VA = "0x2F025F4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2F02A00", Offset = "0x2F02A00", VA = "0x2F02A00")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2F02A44", Offset = "0x2F02A44", VA = "0x2F02A44")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2F02AA4", Offset = "0x2F02AA4", VA = "0x2F02AA4")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2F02004", Offset = "0x2F02004", VA = "0x2F02004")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2F02B10", Offset = "0x2F02B10", VA = "0x2F02B10")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2F02BEC", Offset = "0x2F02BEC", VA = "0x2F02BEC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x10DC7E4", Offset = "0x10DC7E4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x10DC7E4", Offset = "0x10DC7E4")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1BE4", Offset = "0x10E1BE4")]
		public float twistLimit;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public AnimationCurve spline;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2D6F488", Offset = "0x2D6F488", VA = "0x2D6F488")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E700C", Offset = "0x10E700C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2D6F4D0", Offset = "0x2D6F4D0", VA = "0x2D6F4D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E7044", Offset = "0x10E7044")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2D6F518", Offset = "0x2D6F518", VA = "0x2D6F518")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E707C", Offset = "0x10E707C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2D6F560", Offset = "0x2D6F560", VA = "0x2D6F560")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x10E70B4", Offset = "0x10E70B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2D6F5A8", Offset = "0x2D6F5A8", VA = "0x2D6F5A8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2D6F5C4", Offset = "0x2D6F5C4", VA = "0x2D6F5C4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2D6F664", Offset = "0x2D6F664", VA = "0x2D6F664")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x2D6F8A0", Offset = "0x2D6F8A0", VA = "0x2D6F8A0")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DC844", Offset = "0x10DC844")]
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
				[Address(RVA = "0x2D78110", Offset = "0x2D78110", VA = "0x2D78110", Slot = "4")]
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
				[Address(RVA = "0x2D78158", Offset = "0x2D78158", VA = "0x2D78158", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x2D78020", Offset = "0x2D78020", VA = "0x2D78020")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x2D7804C", Offset = "0x2D7804C", VA = "0x2D7804C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x2D78050", Offset = "0x2D78050", VA = "0x2D78050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2D78118", Offset = "0x2D78118", VA = "0x2D78118", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1C38", Offset = "0x10E1C38")]
		public AimIK ik;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1C70", Offset = "0x10E1C70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1C70", Offset = "0x10E1C70")]
		public float weight;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1CC4", Offset = "0x10E1CC4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E1CC4", Offset = "0x10E1CC4")]
		public Transform target;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1D24", Offset = "0x10E1D24")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1D5C", Offset = "0x10E1D5C")]
		public float weightSmoothTime;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E1D94", Offset = "0x10E1D94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1D94", Offset = "0x10E1D94")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1DF4", Offset = "0x10E1DF4")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1E2C", Offset = "0x10E1E2C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1E64", Offset = "0x10E1E64")]
		public float slerpSpeed;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1E9C", Offset = "0x10E1E9C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1ED4", Offset = "0x10E1ED4")]
		public float minDistance;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1F0C", Offset = "0x10E1F0C")]
		public Vector3 offset;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E1F44", Offset = "0x10E1F44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1F44", Offset = "0x10E1F44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E1F44", Offset = "0x10E1F44")]
		public float maxRootAngle;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1FC0", Offset = "0x10E1FC0")]
		public bool turnToTarget;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E1FF8", Offset = "0x10E1FF8")]
		public float turnToTargetTime;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2030", Offset = "0x10E2030")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E2030", Offset = "0x10E2030")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2090", Offset = "0x10E2090")]
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
			[Address(RVA = "0x2FBE008", Offset = "0x2FBE008", VA = "0x2FBE008")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x2FBDF80", Offset = "0x2FBDF80", VA = "0x2FBDF80")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x2FBE098", Offset = "0x2FBE098", VA = "0x2FBE098")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x2FBE5F0", Offset = "0x2FBE5F0", VA = "0x2FBE5F0")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x2FBE6DC", Offset = "0x2FBE6DC", VA = "0x2FBE6DC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2FBE92C", Offset = "0x2FBE92C", VA = "0x2FBE92C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E70EC", Offset = "0x10E70EC")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2FBE998", Offset = "0x2FBE998", VA = "0x2FBE998")]
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
			[Address(RVA = "0x2D78160", Offset = "0x2D78160", VA = "0x2D78160")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x2D782EC", Offset = "0x2D782EC", VA = "0x2D782EC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x2D782F4", Offset = "0x2D782F4", VA = "0x2D782F4")]
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
		[Address(RVA = "0x2FBEBFC", Offset = "0x2FBEBFC", VA = "0x2FBEBFC")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x2FBECDC", Offset = "0x2FBECDC", VA = "0x2FBECDC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x2FBED48", Offset = "0x2FBED48", VA = "0x2FBED48")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2250", Offset = "0x10E2250")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2288", Offset = "0x10E2288")]
				public float weight;

				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x30DA8DC", Offset = "0x30DA8DC", VA = "0x30DA8DC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2100", Offset = "0x10E2100")]
			public Transform transform;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2138", Offset = "0x10E2138")]
			public Transform relativeTo;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2170", Offset = "0x10E2170")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E21A8", Offset = "0x10E21A8")]
			public float verticalWeight;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E21E0", Offset = "0x10E21E0")]
			public float horizontalWeight;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2218", Offset = "0x10E2218")]
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
			[Address(RVA = "0x2D78310", Offset = "0x2D78310", VA = "0x2D78310")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2D78634", Offset = "0x2D78634", VA = "0x2D78634")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x2D78644", Offset = "0x2D78644", VA = "0x2D78644")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E20C8", Offset = "0x10E20C8")]
		public Body[] bodies;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x2FBEE58", Offset = "0x2FBEE58", VA = "0x2FBEE58", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x2FBEFA4", Offset = "0x2FBEFA4", VA = "0x2FBEFA4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E22C0", Offset = "0x10E22C0")]
		public float tiltSpeed;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E22F8", Offset = "0x10E22F8")]
		public float tiltSensitivity;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2330", Offset = "0x10E2330")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2368", Offset = "0x10E2368")]
		public OffsetPose poseRight;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x2FCC218", Offset = "0x2FCC218", VA = "0x2FCC218", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x2FCC260", Offset = "0x2FCC260", VA = "0x2FCC260", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x2FCC418", Offset = "0x2FCC418", VA = "0x2FCC418")]
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
		[Address(RVA = "0x30666A8", Offset = "0x30666A8", VA = "0x30666A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x3066738", Offset = "0x3066738", VA = "0x3066738")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x3066804", Offset = "0x3066804", VA = "0x3066804")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2410", Offset = "0x10E2410")]
			public string name;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2448", Offset = "0x10E2448")]
			public Collider collider;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2480", Offset = "0x10E2480")]
			private float crossFadeTime;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E24CC", Offset = "0x10E24CC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E24DC", Offset = "0x10E24DC")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E24EC", Offset = "0x10E24EC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E24FC", Offset = "0x10E24FC")]
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
				[Address(RVA = "0x2D7AB30", Offset = "0x2D7AB30", VA = "0x2D7AB30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x2D7AB44", Offset = "0x2D7AB44", VA = "0x2D7AB44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E719C", Offset = "0x10E719C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x2D7AB4C", Offset = "0x2D7AB4C", VA = "0x2D7AB4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E71AC", Offset = "0x10E71AC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x2D7AB54", Offset = "0x2D7AB54", VA = "0x2D7AB54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E71BC", Offset = "0x10E71BC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x2D7AB5C", Offset = "0x2D7AB5C", VA = "0x2D7AB5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E71CC", Offset = "0x10E71CC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x2D7AB64", Offset = "0x2D7AB64", VA = "0x2D7AB64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E71DC", Offset = "0x10E71DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x2D7AB70", Offset = "0x2D7AB70", VA = "0x2D7AB70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E71EC", Offset = "0x10E71EC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x2D7AB7C", Offset = "0x2D7AB7C", VA = "0x2D7AB7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E71FC", Offset = "0x10E71FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x2D7AB88", Offset = "0x2D7AB88", VA = "0x2D7AB88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E720C", Offset = "0x10E720C")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x2D7AB94", Offset = "0x2D7AB94", VA = "0x2D7AB94")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x2D7ACC8", Offset = "0x2D7ACC8", VA = "0x2D7ACC8")]
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
			[Address(RVA = "0x2D7AD9C", Offset = "0x2D7AD9C", VA = "0x2D7AD9C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E25B4", Offset = "0x10E25B4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000542")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E25EC", Offset = "0x10E25EC")]
				public float weight;

				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x30DAA4C", Offset = "0x30DAA4C", VA = "0x30DAA4C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x30DAAFC", Offset = "0x30DAAFC", VA = "0x30DAAFC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x30DAB10", Offset = "0x30DAB10", VA = "0x30DAB10")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E250C", Offset = "0x10E250C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2544", Offset = "0x10E2544")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E257C", Offset = "0x10E257C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x2D7B0C8", Offset = "0x2D7B0C8", VA = "0x2D7B0C8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x2D7B1F8", Offset = "0x2D7B1F8", VA = "0x2D7B1F8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x2D7B264", Offset = "0x2D7B264", VA = "0x2D7B264", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x2D7B3CC", Offset = "0x2D7B3CC", VA = "0x2D7B3CC")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2694", Offset = "0x10E2694")]
				public Transform bone;

				[Token(Token = "0x4000549")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E26CC", Offset = "0x10E26CC")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E26CC", Offset = "0x10E26CC")]
				public float weight;

				[Token(Token = "0x400054A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x30DA8E4", Offset = "0x30DA8E4", VA = "0x30DA8E4")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x30DA9FC", Offset = "0x30DA9FC", VA = "0x30DA9FC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x30DAA08", Offset = "0x30DAA08", VA = "0x30DAA08")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2624", Offset = "0x10E2624")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E265C", Offset = "0x10E265C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x2D7ADB0", Offset = "0x2D7ADB0", VA = "0x2D7ADB0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2D7AE54", Offset = "0x2D7AE54", VA = "0x2D7AE54", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x2D7AEC0", Offset = "0x2D7AEC0", VA = "0x2D7AEC0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x2D7B0B4", Offset = "0x2D7B0B4", VA = "0x2D7B0B4")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E23A0", Offset = "0x10E23A0")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E23D8", Offset = "0x10E23D8")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x30DDCFC", Offset = "0x30DDCFC", VA = "0x30DDCFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x30DDDCC", Offset = "0x30DDDCC", VA = "0x30DDDCC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x30DDEA8", Offset = "0x30DDEA8", VA = "0x30DDEA8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x30DE104", Offset = "0x30DE104", VA = "0x30DE104")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2790", Offset = "0x10E2790")]
			public string name;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E27C8", Offset = "0x10E27C8")]
			public Collider collider;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2800", Offset = "0x10E2800")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E284C", Offset = "0x10E284C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E285C", Offset = "0x10E285C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E286C", Offset = "0x10E286C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E287C", Offset = "0x10E287C")]
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
				[Address(RVA = "0x2D7B3E0", Offset = "0x2D7B3E0", VA = "0x2D7B3E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E721C", Offset = "0x10E721C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x2D7B3E8", Offset = "0x2D7B3E8", VA = "0x2D7B3E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E722C", Offset = "0x10E722C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x2D7B3F0", Offset = "0x2D7B3F0", VA = "0x2D7B3F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E723C", Offset = "0x10E723C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x2D7B3F8", Offset = "0x2D7B3F8", VA = "0x2D7B3F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E724C", Offset = "0x10E724C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x2D7B400", Offset = "0x2D7B400", VA = "0x2D7B400")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E725C", Offset = "0x10E725C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x2D7B40C", Offset = "0x2D7B40C", VA = "0x2D7B40C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E726C", Offset = "0x10E726C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x2D7B418", Offset = "0x2D7B418", VA = "0x2D7B418")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E727C", Offset = "0x10E727C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x2D7B424", Offset = "0x2D7B424", VA = "0x2D7B424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E728C", Offset = "0x10E728C")]
				private set
				{
				}
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x2D7B430", Offset = "0x2D7B430", VA = "0x2D7B430")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x2D7B578", Offset = "0x2D7B578", VA = "0x2D7B578")]
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
			[Address(RVA = "0x2D7B660", Offset = "0x2D7B660", VA = "0x2D7B660")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2934", Offset = "0x10E2934")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E296C", Offset = "0x10E296C")]
				public float weight;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x30DAB18", Offset = "0x30DAB18", VA = "0x30DAB18")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x30DABA8", Offset = "0x30DABA8", VA = "0x30DABA8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060A")]
				[Address(RVA = "0x30DABBC", Offset = "0x30DABBC", VA = "0x30DABBC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E288C", Offset = "0x10E288C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E28C4", Offset = "0x10E28C4")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E28FC", Offset = "0x10E28FC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x2D7B674", Offset = "0x2D7B674", VA = "0x2D7B674", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x2D7B824", Offset = "0x2D7B824", VA = "0x2D7B824", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x2D7B890", Offset = "0x2D7B890", VA = "0x2D7B890", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x2D7BA30", Offset = "0x2D7BA30", VA = "0x2D7BA30")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2A14", Offset = "0x10E2A14")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2A4C", Offset = "0x10E2A4C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E2A4C", Offset = "0x10E2A4C")]
				public float weight;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x30DABC4", Offset = "0x30DABC4", VA = "0x30DABC4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x30DACA0", Offset = "0x30DACA0", VA = "0x30DACA0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x30DACAC", Offset = "0x30DACAC", VA = "0x30DACAC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E29A4", Offset = "0x10E29A4")]
			public int curveIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E29DC", Offset = "0x10E29DC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x2D7BA4C", Offset = "0x2D7BA4C", VA = "0x2D7BA4C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x2D7BB30", Offset = "0x2D7BB30", VA = "0x2D7BB30", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x2D7BB9C", Offset = "0x2D7BB9C", VA = "0x2D7BB9C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x2D7BE50", Offset = "0x2D7BE50", VA = "0x2D7BE50")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2720", Offset = "0x10E2720")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2758", Offset = "0x10E2758")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x30DE458", Offset = "0x30DE458", VA = "0x30DE458", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x30DE52C", Offset = "0x30DE52C", VA = "0x30DE52C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x30DE790", Offset = "0x30DE790", VA = "0x30DE790")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2C7C", Offset = "0x10E2C7C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2CB4", Offset = "0x10E2CB4")]
				public float weight;

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x30DACF0", Offset = "0x30DACF0", VA = "0x30DACF0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2B10", Offset = "0x10E2B10")]
			public Transform transform;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2B48", Offset = "0x10E2B48")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2B80", Offset = "0x10E2B80")]
			public float speed;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2BB8", Offset = "0x10E2BB8")]
			public float acceleration;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2BF0", Offset = "0x10E2BF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E2BF0", Offset = "0x10E2BF0")]
			public float matchVelocity;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2C44", Offset = "0x10E2C44")]
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
			[Address(RVA = "0x30D40E4", Offset = "0x30D40E4", VA = "0x30D40E4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x30D419C", Offset = "0x30D419C", VA = "0x30D419C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x30D4458", Offset = "0x30D4458", VA = "0x30D4458")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2AA0", Offset = "0x10E2AA0")]
		public Body[] bodies;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2AD8", Offset = "0x10E2AD8")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x3095B0C", Offset = "0x3095B0C", VA = "0x3095B0C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x3095B88", Offset = "0x3095B88", VA = "0x3095B88", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x3095C48", Offset = "0x3095C48", VA = "0x3095C48")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E2CEC", Offset = "0x10E2CEC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2CEC", Offset = "0x10E2CEC")]
		public Transform target;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E2D4C", Offset = "0x10E2D4C")]
		public float weight;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2D64", Offset = "0x10E2D64")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2D9C", Offset = "0x10E2D9C")]
		public float weightSmoothTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2DD4", Offset = "0x10E2DD4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E2DD4", Offset = "0x10E2DD4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2E34", Offset = "0x10E2E34")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2E6C", Offset = "0x10E2E6C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2EA4", Offset = "0x10E2EA4")]
		public float slerpSpeed;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2EDC", Offset = "0x10E2EDC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2F14", Offset = "0x10E2F14")]
		public float minDistance;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E2F4C", Offset = "0x10E2F4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2F4C", Offset = "0x10E2F4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E2F4C", Offset = "0x10E2F4C")]
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
			[Address(RVA = "0x2EF805C", Offset = "0x2EF805C", VA = "0x2EF805C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x2EF7FE8", Offset = "0x2EF7FE8", VA = "0x2EF7FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x2EF80EC", Offset = "0x2EF80EC", VA = "0x2EF80EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x2EF8608", Offset = "0x2EF8608", VA = "0x2EF8608")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x2EF86F4", Offset = "0x2EF86F4", VA = "0x2EF86F4")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x2EF88EC", Offset = "0x2EF88EC", VA = "0x2EF88EC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3038", Offset = "0x10E3038")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3070", Offset = "0x10E3070")]
			public float spring;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E30A8", Offset = "0x10E30A8")]
			public bool x;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E30E0", Offset = "0x10E30E0")]
			public bool y;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3118", Offset = "0x10E3118")]
			public bool z;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3150", Offset = "0x10E3150")]
			public float minX;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3188", Offset = "0x10E3188")]
			public float maxX;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E31C0", Offset = "0x10E31C0")]
			public float minY;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E31F8", Offset = "0x10E31F8")]
			public float maxY;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3230", Offset = "0x10E3230")]
			public float minZ;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3268", Offset = "0x10E3268")]
			public float maxZ;

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x30D6810", Offset = "0x30D6810", VA = "0x30D6810")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x30D6968", Offset = "0x30D6968", VA = "0x30D6968")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x30D69E0", Offset = "0x30D69E0", VA = "0x30D69E0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x30D6A38", Offset = "0x30D6A38", VA = "0x30D6A38")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DC864", Offset = "0x10DC864")]
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
				[Address(RVA = "0x30D67C0", Offset = "0x30D67C0", VA = "0x30D67C0", Slot = "4")]
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
				[Address(RVA = "0x30D6808", Offset = "0x30D6808", VA = "0x30D6808", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x30D6640", Offset = "0x30D6640", VA = "0x30D6640")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x30D666C", Offset = "0x30D666C", VA = "0x30D666C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x30D6670", Offset = "0x30D6670", VA = "0x30D6670", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x30D67C8", Offset = "0x30D67C8", VA = "0x30D67C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E2FC8", Offset = "0x10E2FC8")]
		public float weight;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3000", Offset = "0x10E3000")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A9")]
		protected float deltaTime
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x2EFB984", Offset = "0x2EFB984", VA = "0x2EFB984")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000620")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x2EFA774", Offset = "0x2EFA774", VA = "0x2EFA774", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2EFB9B0", Offset = "0x2EFB9B0", VA = "0x2EFB9B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E729C", Offset = "0x10E729C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x2EFBA1C", Offset = "0x2EFBA1C", VA = "0x2EFBA1C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x2EFBAF8", Offset = "0x2EFBAF8", VA = "0x2EFBAF8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x2EFAAE4", Offset = "0x2EFAAE4", VA = "0x2EFAAE4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x2EFAC04", Offset = "0x2EFAC04", VA = "0x2EFAC04")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DC874", Offset = "0x10DC874")]
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
				[Address(RVA = "0x30D6BC0", Offset = "0x30D6BC0", VA = "0x30D6BC0", Slot = "4")]
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
				[Address(RVA = "0x30D6C08", Offset = "0x30D6C08", VA = "0x30D6C08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x30D6A40", Offset = "0x30D6A40", VA = "0x30D6A40")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x30D6A6C", Offset = "0x30D6A6C", VA = "0x30D6A6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x30D6A70", Offset = "0x30D6A70", VA = "0x30D6A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x30D6BC8", Offset = "0x30D6BC8", VA = "0x30D6BC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E32A0", Offset = "0x10E32A0")]
		public float weight;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E32D8", Offset = "0x10E32D8")]
		public VRIK ik;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x2EFBBB8", Offset = "0x2EFBBB8", VA = "0x2EFBBB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x2EFBBE4", Offset = "0x2EFBBE4", VA = "0x2EFBBE4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2EFBC10", Offset = "0x2EFBC10", VA = "0x2EFBC10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E734C", Offset = "0x10E734C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2EFBC7C", Offset = "0x2EFBC7C", VA = "0x2EFBC7C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x2EFBD58", Offset = "0x2EFBD58", VA = "0x2EFBD58", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2EFBE64", Offset = "0x2EFBE64", VA = "0x2EFBE64")]
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
			[Address(RVA = "0x30D6C10", Offset = "0x30D6C10", VA = "0x30D6C10")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x30D6E2C", Offset = "0x30D6E2C", VA = "0x30D6E2C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2EFBE74", Offset = "0x2EFBE74", VA = "0x2EFBE74")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2EFBF38", Offset = "0x2EFBF38", VA = "0x2EFBF38")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2EFBFF4", Offset = "0x2EFBFF4", VA = "0x2EFBFF4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E34EC", Offset = "0x10E34EC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3524", Offset = "0x10E3524")]
				public float weight;

				[Token(Token = "0x6000649")]
				[Address(RVA = "0x30DAD00", Offset = "0x30DAD00", VA = "0x30DAD00")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3348", Offset = "0x10E3348")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3380", Offset = "0x10E3380")]
			public Transform raycastTo;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E33B8", Offset = "0x10E33B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E33B8", Offset = "0x10E33B8")]
			public float raycastRadius;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E340C", Offset = "0x10E340C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3444", Offset = "0x10E3444")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E347C", Offset = "0x10E347C")]
			public float smoothTimeOut;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E34B4", Offset = "0x10E34B4")]
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
			[Address(RVA = "0x30D6E34", Offset = "0x30D6E34", VA = "0x30D6E34")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x30D6F78", Offset = "0x30D6F78", VA = "0x30D6F78")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x30D7070", Offset = "0x30D7070", VA = "0x30D7070")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x30D7240", Offset = "0x30D7240", VA = "0x30D7240")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3310", Offset = "0x10E3310")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x2EFC99C", Offset = "0x2EFC99C", VA = "0x2EFC99C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x2EFCA24", Offset = "0x2EFCA24", VA = "0x2EFCA24")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E38B0", Offset = "0x10E38B0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E38E8", Offset = "0x10E38E8")]
				public float weight;

				[Token(Token = "0x6000659")]
				[Address(RVA = "0x30DAD08", Offset = "0x30DAD08", VA = "0x30DAD08")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E37B4", Offset = "0x10E37B4")]
			public Vector3 offset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E37EC", Offset = "0x10E37EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E37EC", Offset = "0x10E37EC")]
			public float additivity;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3840", Offset = "0x10E3840")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3878", Offset = "0x10E3878")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x30D7C34", Offset = "0x30D7C34", VA = "0x30D7C34")]
			public void Start()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x30D7C84", Offset = "0x30D7C84", VA = "0x30D7C84")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x30D7E48", Offset = "0x30D7E48", VA = "0x30D7E48")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E355C", Offset = "0x10E355C")]
		public AimIK aimIK;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3594", Offset = "0x10E3594")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E35CC", Offset = "0x10E35CC")]
		public Handedness handedness;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3604", Offset = "0x10E3604")]
		public bool twoHanded;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E363C", Offset = "0x10E363C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3674", Offset = "0x10E3674")]
		public float magnitudeRandom;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E36AC", Offset = "0x10E36AC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E36E4", Offset = "0x10E36E4")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E371C", Offset = "0x10E371C")]
		public float blendTime;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10E3754", Offset = "0x10E3754")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3754", Offset = "0x10E3754")]
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
			[Address(RVA = "0x2EFF898", Offset = "0x2EFF898", VA = "0x2EFF898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x2F00310", Offset = "0x2F00310", VA = "0x2F00310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x2F00350", Offset = "0x2F00350", VA = "0x2F00350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x2F002D0", Offset = "0x2F002D0", VA = "0x2F002D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x2F002F0", Offset = "0x2F002F0", VA = "0x2F002F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x2EFF8C8", Offset = "0x2EFF8C8", VA = "0x2EFF8C8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x2EFF8F4", Offset = "0x2EFF8F4", VA = "0x2EFF8F4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x2EFFA3C", Offset = "0x2EFFA3C", VA = "0x2EFFA3C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2F00390", Offset = "0x2F00390", VA = "0x2F00390")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2F00444", Offset = "0x2F00444", VA = "0x2F00444")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x2F00480", Offset = "0x2F00480", VA = "0x2F00480", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x2F00638", Offset = "0x2F00638", VA = "0x2F00638")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3920", Offset = "0x10E3920")]
		public float weight;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3958", Offset = "0x10E3958")]
		public float offset;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2D6FAB0", Offset = "0x2D6FAB0", VA = "0x2D6FAB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2D6FB9C", Offset = "0x2D6FB9C", VA = "0x2D6FB9C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2D6FC84", Offset = "0x2D6FC84", VA = "0x2D6FC84")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2D6FFD4", Offset = "0x2D6FFD4", VA = "0x2D6FFD4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2D70048", Offset = "0x2D70048", VA = "0x2D70048")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2D70148", Offset = "0x2D70148", VA = "0x2D70148")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3990", Offset = "0x10E3990")]
			public float scaleMlp;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E39C8", Offset = "0x10E39C8")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3A00", Offset = "0x10E3A00")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3A38", Offset = "0x10E3A38")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3A70", Offset = "0x10E3A70")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3AA8", Offset = "0x10E3AA8")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3AE0", Offset = "0x10E3AE0")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3B18", Offset = "0x10E3B18")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3B50", Offset = "0x10E3B50")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3B88", Offset = "0x10E3B88")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10E3B88", Offset = "0x10E3B88")]
			public Vector3 headOffset;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3BD8", Offset = "0x10E3BD8")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3C10", Offset = "0x10E3C10")]
			public float footForwardOffset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3C48", Offset = "0x10E3C48")]
			public float footInwardOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3C80", Offset = "0x10E3C80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3C80", Offset = "0x10E3C80")]
			public float footHeadingOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3CDC", Offset = "0x10E3CDC")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3CF4", Offset = "0x10E3CF4")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x30DA474", Offset = "0x30DA474", VA = "0x30DA474")]
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
				[Address(RVA = "0x30DAD10", Offset = "0x30DAD10", VA = "0x30DAD10")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0x30DADD0", Offset = "0x30DADD0", VA = "0x30DADD0")]
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
			[Address(RVA = "0x30DA46C", Offset = "0x30DA46C", VA = "0x30DA46C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x2D762BC", Offset = "0x2D762BC", VA = "0x2D762BC")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x2D745D0", Offset = "0x2D745D0", VA = "0x2D745D0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x2D76418", Offset = "0x2D76418", VA = "0x2D76418")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x2D757DC", Offset = "0x2D757DC", VA = "0x2D757DC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x2D76C04", Offset = "0x2D76C04", VA = "0x2D76C04")]
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
		[Address(RVA = "0x2D76FF8", Offset = "0x2D76FF8", VA = "0x2D76FF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2D7704C", Offset = "0x2D7704C", VA = "0x2D7704C")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x2D77080", Offset = "0x2D77080", VA = "0x2D77080")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x2D771BC", Offset = "0x2D771BC", VA = "0x2D771BC")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E3D0C", Offset = "0x10E3D0C")]
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
			[Address(RVA = "0x2D778AC", Offset = "0x2D778AC", VA = "0x2D778AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E73FC", Offset = "0x10E73FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x2D778B8", Offset = "0x2D778B8", VA = "0x2D778B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E740C", Offset = "0x10E740C")]
			private set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2D778C4", Offset = "0x2D778C4", VA = "0x2D778C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2D76A0C", Offset = "0x2D76A0C", VA = "0x2D76A0C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x2D76E74", Offset = "0x2D76E74", VA = "0x2D76E74")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x2D779A4", Offset = "0x2D779A4", VA = "0x2D779A4")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x2D77DC0", Offset = "0x2D77DC0", VA = "0x2D77DC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x2D77EC0", Offset = "0x2D77EC0", VA = "0x2D77EC0")]
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
			[Address(RVA = "0x2D78E70", Offset = "0x2D78E70", VA = "0x2D78E70")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x2D78FD0", Offset = "0x2D78FD0", VA = "0x2D78FD0")]
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
		[Address(RVA = "0x306D658", Offset = "0x306D658", VA = "0x306D658")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x306D6AC", Offset = "0x306D6AC", VA = "0x306D6AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x306D728", Offset = "0x306D728", VA = "0x306D728")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x306D800", Offset = "0x306D800", VA = "0x306D800")]
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
		[Address(RVA = "0x2FBDEF4", Offset = "0x2FBDEF4", VA = "0x2FBDEF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2FBDF78", Offset = "0x2FBDF78", VA = "0x2FBDF78")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3D54", Offset = "0x10E3D54")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x2FBEDAC", Offset = "0x2FBEDAC", VA = "0x2FBEDAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2FBEE24", Offset = "0x2FBEE24", VA = "0x2FBEE24")]
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
		[Address(RVA = "0x2D6F8B0", Offset = "0x2D6F8B0", VA = "0x2D6F8B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2D6F8F4", Offset = "0x2D6F8F4", VA = "0x2D6F8F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2D6FAA8", Offset = "0x2D6FAA8", VA = "0x2D6FAA8")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3D8C", Offset = "0x10E3D8C")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3DC4", Offset = "0x10E3DC4")]
		public AimIK aim;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3DFC", Offset = "0x10E3DFC")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3E34", Offset = "0x10E3E34")]
		public Animator animator;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3E6C", Offset = "0x10E3E6C")]
		public float crossfadeTime;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E3EA4", Offset = "0x10E3EA4")]
		public float minAimDistance;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2D7015C", Offset = "0x2D7015C", VA = "0x2D7015C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2D701A0", Offset = "0x2D701A0", VA = "0x2D701A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2D70308", Offset = "0x2D70308", VA = "0x2D70308")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2D70498", Offset = "0x2D70498", VA = "0x2D70498")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2D705D4", Offset = "0x2D705D4", VA = "0x2D705D4")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2D70650", Offset = "0x2D70650", VA = "0x2D70650")]
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
		[Address(RVA = "0x2D715E8", Offset = "0x2D715E8", VA = "0x2D715E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2D71758", Offset = "0x2D71758", VA = "0x2D71758")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x2D718EC", Offset = "0x2D718EC", VA = "0x2D718EC")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10E3EDC", Offset = "0x10E3EDC")]
		public Animator animator;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10E3F14", Offset = "0x10E3F14")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3F4C", Offset = "0x10E3F4C")]
		public float lookAtWeight;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3F64", Offset = "0x10E3F64")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3F7C", Offset = "0x10E3F7C")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3F94", Offset = "0x10E3F94")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3FAC", Offset = "0x10E3FAC")]
		public float lookAtClampWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3FC4", Offset = "0x10E3FC4")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E3FDC", Offset = "0x10E3FDC")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10E3FF4", Offset = "0x10E3FF4")]
		public Transform footTargetBiped;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E402C", Offset = "0x10E402C")]
		public float footPositionWeight;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E4044", Offset = "0x10E4044")]
		public float footRotationWeight;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x10E405C", Offset = "0x10E405C")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E4094", Offset = "0x10E4094")]
		public float handPositionWeight;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E40AC", Offset = "0x10E40AC")]
		public float handRotationWeight;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x2FC53FC", Offset = "0x2FC53FC", VA = "0x2FC53FC")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x2FC5804", Offset = "0x2FC5804", VA = "0x2FC5804")]
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
		[Address(RVA = "0x2EF8AE8", Offset = "0x2EF8AE8", VA = "0x2EF8AE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x2EF92F4", Offset = "0x2EF92F4", VA = "0x2EF92F4")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2EF90A4", Offset = "0x2EF90A4", VA = "0x2EF90A4")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2EF93F0", Offset = "0x2EF93F0", VA = "0x2EF93F0")]
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
			[Address(RVA = "0x2EF941C", Offset = "0x2EF941C", VA = "0x2EF941C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x2EF94A0", Offset = "0x2EF94A0", VA = "0x2EF94A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x2EF96C4", Offset = "0x2EF96C4", VA = "0x2EF96C4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DC884", Offset = "0x10DC884")]
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
				[Address(RVA = "0x30D6388", Offset = "0x30D6388", VA = "0x30D6388", Slot = "4")]
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
				[Address(RVA = "0x30D63D0", Offset = "0x30D63D0", VA = "0x30D63D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x30D6098", Offset = "0x30D6098", VA = "0x30D6098")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x30D60C4", Offset = "0x30D60C4", VA = "0x30D60C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x30D60C8", Offset = "0x30D60C8", VA = "0x30D60C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x30D6390", Offset = "0x30D6390", VA = "0x30D6390", Slot = "8")]
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
			[Address(RVA = "0x2EF96D8", Offset = "0x2EF96D8", VA = "0x2EF96D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x2EF93BC", Offset = "0x2EF93BC", VA = "0x2EF93BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x2EF96EC", Offset = "0x2EF96EC", VA = "0x2EF96EC")]
			set
			{
			}
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x2EF973C", Offset = "0x2EF973C", VA = "0x2EF973C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2EF9930", Offset = "0x2EF9930", VA = "0x2EF9930")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x2EF9ACC", Offset = "0x2EF9ACC", VA = "0x2EF9ACC")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x2EF9CF4", Offset = "0x2EF9CF4", VA = "0x2EF9CF4")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x2EF9F98", Offset = "0x2EF9F98", VA = "0x2EF9F98")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x2EFA110", Offset = "0x2EFA110", VA = "0x2EFA110")]
		private void Update()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x2EF9C4C", Offset = "0x2EF9C4C", VA = "0x2EF9C4C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E741C", Offset = "0x10E741C")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x2EFA30C", Offset = "0x2EFA30C", VA = "0x2EFA30C")]
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
		[Address(RVA = "0x2EFA370", Offset = "0x2EFA370", VA = "0x2EFA370")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x2EFA430", Offset = "0x2EFA430", VA = "0x2EFA430")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x2EFA684", Offset = "0x2EFA684", VA = "0x2EFA684")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4184", Offset = "0x10E4184")]
			public int animationLayer;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E41BC", Offset = "0x10E41BC")]
			public string animationState;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E41F4", Offset = "0x10E41F4")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E422C", Offset = "0x10E422C")]
			public Transform warpFrom;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4264", Offset = "0x10E4264")]
			public Transform warpTo;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E429C", Offset = "0x10E429C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E40C4", Offset = "0x10E40C4")]
		public Animator animator;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E40FC", Offset = "0x10E40FC")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4134", Offset = "0x10E4134")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x10E4134", Offset = "0x10E4134")]
		public Warp[] warps;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x2FBEFAC", Offset = "0x2FBEFAC", VA = "0x2FBEFAC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x2FBEFD8", Offset = "0x2FBEFD8", VA = "0x2FBEFD8")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x2FBF218", Offset = "0x2FBF218", VA = "0x2FBF218", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x2FBF4DC", Offset = "0x2FBF4DC", VA = "0x2FBF4DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x2FBF57C", Offset = "0x2FBF57C", VA = "0x2FBF57C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DC894", Offset = "0x10DC894")]
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
		[Address(RVA = "0x2FBF584", Offset = "0x2FBF584", VA = "0x2FBF584", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x2FBF5D8", Offset = "0x2FBF5D8", VA = "0x2FBF5D8")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x2FBF774", Offset = "0x2FBF774", VA = "0x2FBF774", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x2FBF97C", Offset = "0x2FBF97C", VA = "0x2FBF97C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DC8F4", Offset = "0x10DC8F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DC8F4", Offset = "0x10DC8F4")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E42D4", Offset = "0x10E42D4")]
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
		[Address(RVA = "0x2FBF990", Offset = "0x2FBF990", VA = "0x2FBF990", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x2FBFB1C", Offset = "0x2FBFB1C", VA = "0x2FBFB1C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x2FBFB98", Offset = "0x2FBFB98", VA = "0x2FBFB98")]
		private void Read()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x2FBFC8C", Offset = "0x2FBFC8C", VA = "0x2FBFC8C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2FBFCD4", Offset = "0x2FBFCD4", VA = "0x2FBFCD4")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2FC00C0", Offset = "0x2FC00C0", VA = "0x2FC00C0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2FBFF48", Offset = "0x2FBFF48", VA = "0x2FBFF48")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2FC031C", Offset = "0x2FC031C", VA = "0x2FC031C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2FC0428", Offset = "0x2FC0428", VA = "0x2FC0428")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DC988", Offset = "0x10DC988")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x2FCDECC", Offset = "0x2FCDECC", VA = "0x2FCDECC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x2FCDF28", Offset = "0x2FCDF28", VA = "0x2FCDF28", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x2FCE164", Offset = "0x2FCE164", VA = "0x2FCE164")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x2FCE258", Offset = "0x2FCE258", VA = "0x2FCE258")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DC9E8", Offset = "0x10DC9E8")]
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
			[Address(RVA = "0x2FCEC7C", Offset = "0x2FCEC7C", VA = "0x2FCEC7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x2FCED00", Offset = "0x2FCED00", VA = "0x2FCED00")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x2FCEA84", Offset = "0x2FCEA84", VA = "0x2FCEA84")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x2FCEAF0", Offset = "0x2FCEAF0", VA = "0x2FCEAF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x2FCED84", Offset = "0x2FCED84", VA = "0x2FCED84")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E42EC", Offset = "0x10E42EC")]
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
		[Address(RVA = "0x306680C", Offset = "0x306680C", VA = "0x306680C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x3066C6C", Offset = "0x3066C6C", VA = "0x3066C6C")]
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
		[Address(RVA = "0x3066C74", Offset = "0x3066C74", VA = "0x3066C74")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x3066D1C", Offset = "0x3066D1C", VA = "0x3066D1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x30670A0", Offset = "0x30670A0", VA = "0x30670A0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x306714C", Offset = "0x306714C", VA = "0x306714C")]
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
			[Address(RVA = "0x2D78958", Offset = "0x2D78958", VA = "0x2D78958")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x2D789DC", Offset = "0x2D789DC", VA = "0x2D789DC")]
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
		[Address(RVA = "0x306AA18", Offset = "0x306AA18", VA = "0x306AA18")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x306AB70", Offset = "0x306AB70", VA = "0x306AB70")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x306AC14", Offset = "0x306AC14", VA = "0x306AC14")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x306AC18", Offset = "0x306AC18", VA = "0x306AC18")]
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
		[Address(RVA = "0x306AC28", Offset = "0x306AC28", VA = "0x306AC28")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x306AC9C", Offset = "0x306AC9C", VA = "0x306AC9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x306AD70", Offset = "0x306AD70", VA = "0x306AD70")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4304", Offset = "0x10E4304")]
		public Transform target;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E433C", Offset = "0x10E433C")]
		public Transform pin;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4374", Offset = "0x10E4374")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E43AC", Offset = "0x10E43AC")]
		public AimIK aim;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E43E4", Offset = "0x10E43E4")]
		public float weight;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E441C", Offset = "0x10E441C")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4454", Offset = "0x10E4454")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x306AD78", Offset = "0x306AD78", VA = "0x306AD78")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x306ADCC", Offset = "0x306ADCC", VA = "0x306ADCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x306AF70", Offset = "0x306AF70", VA = "0x306AF70")]
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
		[Address(RVA = "0x306D014", Offset = "0x306D014", VA = "0x306D014")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x306D0DC", Offset = "0x306D0DC", VA = "0x306D0DC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x306D16C", Offset = "0x306D16C", VA = "0x306D16C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x306D544", Offset = "0x306D544", VA = "0x306D544")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x306D650", Offset = "0x306D650", VA = "0x306D650")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E448C", Offset = "0x10E448C")]
		public float aimWeight;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E44A4", Offset = "0x10E44A4")]
		public float sightWeight;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E44BC", Offset = "0x10E44BC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E44D8", Offset = "0x10E44D8")]
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
		[Address(RVA = "0x306D808", Offset = "0x306D808", VA = "0x306D808")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x306D97C", Offset = "0x306D97C", VA = "0x306D97C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x306D988", Offset = "0x306D988", VA = "0x306D988")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x306DC08", Offset = "0x306DC08", VA = "0x306DC08")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x306DDB4", Offset = "0x306DDB4", VA = "0x306DDB4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x306DA50", Offset = "0x306DA50", VA = "0x306DA50")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x306E6A8", Offset = "0x306E6A8", VA = "0x306E6A8")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCA48", Offset = "0x10DCA48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCA48", Offset = "0x10DCA48")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E44F0", Offset = "0x10E44F0")]
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
		[Address(RVA = "0x306E6C8", Offset = "0x306E6C8", VA = "0x306E6C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x306E740", Offset = "0x306E740", VA = "0x306E740")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x306E82C", Offset = "0x306E82C", VA = "0x306E82C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x306E8E4", Offset = "0x306E8E4", VA = "0x306E8E4")]
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
		[Address(RVA = "0x30DE10C", Offset = "0x30DE10C", VA = "0x30DE10C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x30DE264", Offset = "0x30DE264", VA = "0x30DE264")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x30DE448", Offset = "0x30DE448", VA = "0x30DE448")]
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
		[Address(RVA = "0x30DEAE4", Offset = "0x30DEAE4", VA = "0x30DEAE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x30DEC2C", Offset = "0x30DEC2C", VA = "0x30DEC2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x30DEF68", Offset = "0x30DEF68", VA = "0x30DEF68")]
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
		[Address(RVA = "0x3095D28", Offset = "0x3095D28", VA = "0x3095D28")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x3095E64", Offset = "0x3095E64", VA = "0x3095E64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x3095F70", Offset = "0x3095F70", VA = "0x3095F70")]
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
		[Address(RVA = "0x3095F78", Offset = "0x3095F78", VA = "0x3095F78")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x30966A4", Offset = "0x30966A4", VA = "0x30966A4")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCADC", Offset = "0x10DCADC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4508", Offset = "0x10E4508")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4540", Offset = "0x10E4540")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x2EF5D3C", Offset = "0x2EF5D3C", VA = "0x2EF5D3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x2EF5D90", Offset = "0x2EF5D90", VA = "0x2EF5D90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x2EF60C8", Offset = "0x2EF60C8", VA = "0x2EF60C8")]
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
				[Address(RVA = "0x30D602C", Offset = "0x30D602C", VA = "0x30D602C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x30D58E0", Offset = "0x30D58E0", VA = "0x30D58E0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x30D5900", Offset = "0x30D5900", VA = "0x30D5900")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x30D5E98", Offset = "0x30D5E98", VA = "0x30D5E98")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x30D6084", Offset = "0x30D6084", VA = "0x30D6084")]
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
		[Address(RVA = "0x2EF75E4", Offset = "0x2EF75E4", VA = "0x2EF75E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x2EF7620", Offset = "0x2EF7620", VA = "0x2EF7620")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x2EF7688", Offset = "0x2EF7688", VA = "0x2EF7688")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4658", Offset = "0x10E4658")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4690", Offset = "0x10E4690")]
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
			[Address(RVA = "0x30D63D8", Offset = "0x30D63D8", VA = "0x30D63D8")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x30D64AC", Offset = "0x30D64AC", VA = "0x30D64AC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x30D64E8", Offset = "0x30D64E8", VA = "0x30D64E8")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x30D6580", Offset = "0x30D6580", VA = "0x30D6580")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x30D65F4", Offset = "0x30D65F4", VA = "0x30D65F4")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4578", Offset = "0x10E4578")]
		public Mode mode;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E45B0", Offset = "0x10E45B0")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E45E8", Offset = "0x10E45E8")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4620", Offset = "0x10E4620")]
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
		[Address(RVA = "0x2EFA68C", Offset = "0x2EFA68C", VA = "0x2EFA68C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x2EFA7A0", Offset = "0x2EFA7A0", VA = "0x2EFA7A0")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x2EFA830", Offset = "0x2EFA830", VA = "0x2EFA830", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x2EFA944", Offset = "0x2EFA944", VA = "0x2EFA944")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x2EFA9D0", Offset = "0x2EFA9D0", VA = "0x2EFA9D0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x2EFABF0", Offset = "0x2EFABF0", VA = "0x2EFABF0")]
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
		[Address(RVA = "0x2EFAC14", Offset = "0x2EFAC14", VA = "0x2EFAC14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x2EFAC88", Offset = "0x2EFAC88", VA = "0x2EFAC88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x2EFAD64", Offset = "0x2EFAD64", VA = "0x2EFAD64")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x2EFAE24", Offset = "0x2EFAE24", VA = "0x2EFAE24")]
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
			[Address(RVA = "0x30D6630", Offset = "0x30D6630", VA = "0x30D6630")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x2EFB6DC", Offset = "0x2EFB6DC", VA = "0x2EFB6DC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x2EFB7E8", Offset = "0x2EFB7E8", VA = "0x2EFB7E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x2EFB974", Offset = "0x2EFB974", VA = "0x2EFB974")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCB3C", Offset = "0x10DCB3C")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E46D8", Offset = "0x10E46D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E46D8", Offset = "0x10E46D8")]
		public float weight;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E472C", Offset = "0x10E472C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4764", Offset = "0x10E4764")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E47B0", Offset = "0x10E47B0")]
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
		[Address(RVA = "0x2EFC050", Offset = "0x2EFC050", VA = "0x2EFC050")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2EFC314", Offset = "0x2EFC314", VA = "0x2EFC314")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2EFC95C", Offset = "0x2EFC95C", VA = "0x2EFC95C")]
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
			[Address(RVA = "0x2EFCCFC", Offset = "0x2EFCCFC", VA = "0x2EFCCFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2EFCA34", Offset = "0x2EFCA34", VA = "0x2EFCA34")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000712")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2EFCD18", Offset = "0x2EFCD18", VA = "0x2EFCD18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2EFCEA0", Offset = "0x2EFCEA0", VA = "0x2EFCEA0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2EFD024", Offset = "0x2EFD024", VA = "0x2EFD024")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2EFD100", Offset = "0x2EFD100", VA = "0x2EFD100")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2EFD234", Offset = "0x2EFD234", VA = "0x2EFD234")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2EFD398", Offset = "0x2EFD398", VA = "0x2EFD398")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2EFD564", Offset = "0x2EFD564", VA = "0x2EFD564")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2EFD578", Offset = "0x2EFD578", VA = "0x2EFD578", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2EFD7DC", Offset = "0x2EFD7DC", VA = "0x2EFD7DC")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2EFD7F0", Offset = "0x2EFD7F0", VA = "0x2EFD7F0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x2EFD924", Offset = "0x2EFD924", VA = "0x2EFD924")]
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
		[Address(RVA = "0x2EFF69C", Offset = "0x2EFF69C", VA = "0x2EFF69C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2EFF77C", Offset = "0x2EFF77C", VA = "0x2EFF77C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x2EFF890", Offset = "0x2EFF890", VA = "0x2EFF890")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCB9C", Offset = "0x10DCB9C")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2F006A8", Offset = "0x2F006A8", VA = "0x2F006A8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2F006FC", Offset = "0x2F006FC", VA = "0x2F006FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2F00754", Offset = "0x2F00754", VA = "0x2F00754")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2F00834", Offset = "0x2F00834", VA = "0x2F00834")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DCBFC", Offset = "0x10DCBFC")]
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
				[Address(RVA = "0x30D8038", Offset = "0x30D8038", VA = "0x30D8038", Slot = "4")]
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
				[Address(RVA = "0x30D8080", Offset = "0x30D8080", VA = "0x30D8080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x30D7E5C", Offset = "0x30D7E5C", VA = "0x30D7E5C")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x30D7E88", Offset = "0x30D7E88", VA = "0x30D7E88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x30D7E8C", Offset = "0x30D7E8C", VA = "0x30D7E8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x30D8040", Offset = "0x30D8040", VA = "0x30D8040", Slot = "8")]
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
		[Address(RVA = "0x2F00844", Offset = "0x2F00844", VA = "0x2F00844")]
		private void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2F008F8", Offset = "0x2F008F8", VA = "0x2F008F8")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2F00940", Offset = "0x2F00940", VA = "0x2F00940")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E74CC", Offset = "0x10E74CC")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2F009BC", Offset = "0x2F009BC", VA = "0x2F009BC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCC0C", Offset = "0x10DCC0C")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DCC6C", Offset = "0x10DCC6C")]
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
				[Address(RVA = "0x30D85A4", Offset = "0x30D85A4", VA = "0x30D85A4", Slot = "4")]
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
				[Address(RVA = "0x30D85EC", Offset = "0x30D85EC", VA = "0x30D85EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x30D844C", Offset = "0x30D844C", VA = "0x30D844C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x30D8478", Offset = "0x30D8478", VA = "0x30D8478", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x30D847C", Offset = "0x30D847C", VA = "0x30D847C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x30D85AC", Offset = "0x30D85AC", VA = "0x30D85AC", Slot = "8")]
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
		[Address(RVA = "0x2D70E44", Offset = "0x2D70E44", VA = "0x2D70E44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2D70EF0", Offset = "0x2D70EF0", VA = "0x2D70EF0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E757C", Offset = "0x10E757C")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2D70F5C", Offset = "0x2D70F5C", VA = "0x2D70F5C")]
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
			[Address(RVA = "0x30D85F4", Offset = "0x30D85F4", VA = "0x30D85F4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x30D888C", Offset = "0x30D888C", VA = "0x30D888C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x30D8974", Offset = "0x30D8974", VA = "0x30D8974")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x30D8E08", Offset = "0x30D8E08", VA = "0x30D8E08")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x30D8EFC", Offset = "0x30D8EFC", VA = "0x30D8EFC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x30D8F94", Offset = "0x30D8F94", VA = "0x30D8F94")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x30D9028", Offset = "0x30D9028", VA = "0x30D9028")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x30D90BC", Offset = "0x30D90BC", VA = "0x30D90BC")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x30D9228", Offset = "0x30D9228", VA = "0x30D9228")]
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
		[Address(RVA = "0x2D7191C", Offset = "0x2D7191C", VA = "0x2D7191C")]
		private void Start()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2D71998", Offset = "0x2D71998", VA = "0x2D71998")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2D71A08", Offset = "0x2D71A08", VA = "0x2D71A08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2D71AD0", Offset = "0x2D71AD0", VA = "0x2D71AD0")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E47FC", Offset = "0x10E47FC")]
		public Transform to;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E4834", Offset = "0x10E4834")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4834", Offset = "0x10E4834")]
		public float transferMotion;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x2D71AD8", Offset = "0x2D71AD8", VA = "0x2D71AD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x2D71B14", Offset = "0x2D71B14", VA = "0x2D71B14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2D71BC8", Offset = "0x2D71BC8", VA = "0x2D71BC8")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4888", Offset = "0x10E4888")]
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
		[Address(RVA = "0x2D72970", Offset = "0x2D72970", VA = "0x2D72970")]
		private void Start()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2D72B50", Offset = "0x2D72B50", VA = "0x2D72B50")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2D72D40", Offset = "0x2D72D40", VA = "0x2D72D40")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2D72E0C", Offset = "0x2D72E0C", VA = "0x2D72E0C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2D72F0C", Offset = "0x2D72F0C", VA = "0x2D72F0C")]
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
		[Address(RVA = "0x2D731A8", Offset = "0x2D731A8", VA = "0x2D731A8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2D73534", Offset = "0x2D73534", VA = "0x2D73534")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2D737A0", Offset = "0x2D737A0", VA = "0x2D737A0")]
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
		[Address(RVA = "0x30723DC", Offset = "0x30723DC", VA = "0x30723DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x3072704", Offset = "0x3072704", VA = "0x3072704")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x3072784", Offset = "0x3072784", VA = "0x3072784")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DCC7C", Offset = "0x10DCC7C")]
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
				[Address(RVA = "0x30D7394", Offset = "0x30D7394", VA = "0x30D7394", Slot = "4")]
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
				[Address(RVA = "0x30D73DC", Offset = "0x30D73DC", VA = "0x30D73DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x30D7254", Offset = "0x30D7254", VA = "0x30D7254")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x30D7280", Offset = "0x30D7280", VA = "0x30D7280", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x30D7284", Offset = "0x30D7284", VA = "0x30D7284", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x30D739C", Offset = "0x30D739C", VA = "0x30D739C", Slot = "8")]
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
		[Address(RVA = "0x2EFD938", Offset = "0x2EFD938", VA = "0x2EFD938")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x2EFDA64", Offset = "0x2EFDA64", VA = "0x2EFDA64")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x2EFD9F8", Offset = "0x2EFD9F8", VA = "0x2EFD9F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E762C", Offset = "0x10E762C")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x2EFDBE8", Offset = "0x2EFDBE8", VA = "0x2EFDBE8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x2EFDCD4", Offset = "0x2EFDCD4", VA = "0x2EFDCD4")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x2EFDDBC", Offset = "0x2EFDDBC", VA = "0x2EFDDBC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E48C0", Offset = "0x10E48C0")]
		public float weight;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2FC419C", Offset = "0x2FC419C", VA = "0x2FC419C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2FC4210", Offset = "0x2FC4210", VA = "0x2FC4210")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2FC42C8", Offset = "0x2FC42C8", VA = "0x2FC42C8")]
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
			[Address(RVA = "0x30D925C", Offset = "0x30D925C", VA = "0x30D925C")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x30D9388", Offset = "0x30D9388", VA = "0x30D9388")]
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
		[Address(RVA = "0x2D71FB0", Offset = "0x2D71FB0", VA = "0x2D71FB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2D7202C", Offset = "0x2D7202C", VA = "0x2D7202C")]
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
		[Address(RVA = "0x30DE798", Offset = "0x30DE798", VA = "0x30DE798")]
		private void Update()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x30DE8F0", Offset = "0x30DE8F0", VA = "0x30DE8F0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x30DEAD4", Offset = "0x30DEAD4", VA = "0x30DEAD4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E48D8", Offset = "0x10E48D8")]
		public VRIK ik;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4910", Offset = "0x10E4910")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4948", Offset = "0x10E4948")]
		public Transform headTracker;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4980", Offset = "0x10E4980")]
		public Transform bodyTracker;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E49B8", Offset = "0x10E49B8")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E49F0", Offset = "0x10E49F0")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4A28", Offset = "0x10E4A28")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4A60", Offset = "0x10E4A60")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4A98", Offset = "0x10E4A98")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2D7446C", Offset = "0x2D7446C", VA = "0x2D7446C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2D763B4", Offset = "0x2D763B4", VA = "0x2D763B4")]
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
		[Address(RVA = "0x2D771D4", Offset = "0x2D771D4", VA = "0x2D771D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2D77230", Offset = "0x2D77230", VA = "0x2D77230")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2D773B8", Offset = "0x2D773B8", VA = "0x2D773B8")]
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
		[Address(RVA = "0x2D773EC", Offset = "0x2D773EC", VA = "0x2D773EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2D77870", Offset = "0x2D77870", VA = "0x2D77870")]
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
			[Address(RVA = "0x2FCD1CC", Offset = "0x2FCD1CC", VA = "0x2FCD1CC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2FCD1A8", Offset = "0x2FCD1A8", VA = "0x2FCD1A8", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2FCD1D4", Offset = "0x2FCD1D4", VA = "0x2FCD1D4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2FCD238", Offset = "0x2FCD238", VA = "0x2FCD238", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2FCD3D0", Offset = "0x2FCD3D0", VA = "0x2FCD3D0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2FCD5F4", Offset = "0x2FCD5F4", VA = "0x2FCD5F4", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x2FCD3E0", Offset = "0x2FCD3E0", VA = "0x2FCD3E0")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x2FCD604", Offset = "0x2FCD604", VA = "0x2FCD604")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCC8C", Offset = "0x10DCC8C")]
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
		[Address(RVA = "0x2FCD61C", Offset = "0x2FCD61C", VA = "0x2FCD61C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x2FCD678", Offset = "0x2FCD678", VA = "0x2FCD678", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x2FCD714", Offset = "0x2FCD714", VA = "0x2FCD714")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x2FCD82C", Offset = "0x2FCD82C", VA = "0x2FCD82C")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCCEC", Offset = "0x10DCCEC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x10E4B00", Offset = "0x10E4B00")]
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
			[Address(RVA = "0x2FCD8E0", Offset = "0x2FCD8E0", VA = "0x2FCD8E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x2FCD844", Offset = "0x2FCD844", VA = "0x2FCD844", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x2FCD8C4", Offset = "0x2FCD8C4", VA = "0x2FCD8C4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x2FCD9D8", Offset = "0x2FCD9D8", VA = "0x2FCD9D8", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x2FCDDA0", Offset = "0x2FCDDA0", VA = "0x2FCDDA0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x2FCDEA8", Offset = "0x2FCDEA8", VA = "0x2FCDEA8")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCD4C", Offset = "0x10DCD4C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCD4C", Offset = "0x10DCD4C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4B44", Offset = "0x10E4B44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4B44", Offset = "0x10E4B44")]
		public Transform gravityTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4BA4", Offset = "0x10E4BA4")]
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
		[Address(RVA = "0x2FCE27C", Offset = "0x2FCE27C", VA = "0x2FCE27C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x2FCE3AC", Offset = "0x2FCE3AC", VA = "0x2FCE3AC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x2FCE564", Offset = "0x2FCE564", VA = "0x2FCE564", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x2FCE714", Offset = "0x2FCE714", VA = "0x2FCE714")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x2FCE778", Offset = "0x2FCE778", VA = "0x2FCE778")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x2FCE898", Offset = "0x2FCE898", VA = "0x2FCE898")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x2FCE9BC", Offset = "0x2FCE9BC", VA = "0x2FCE9BC")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x2FCE9E0", Offset = "0x2FCE9E0", VA = "0x2FCE9E0")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x2FCEA04", Offset = "0x2FCEA04", VA = "0x2FCEA04")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x2FCEA64", Offset = "0x2FCEA64", VA = "0x2FCEA64")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10DCDE0", Offset = "0x10DCDE0")]
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
				[Address(RVA = "0x2D78814", Offset = "0x2D78814", VA = "0x2D78814", Slot = "4")]
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
				[Address(RVA = "0x2D7885C", Offset = "0x2D7885C", VA = "0x2D7885C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x2D786F0", Offset = "0x2D786F0", VA = "0x2D786F0")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x2D7871C", Offset = "0x2D7871C", VA = "0x2D7871C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x2D78720", Offset = "0x2D78720", VA = "0x2D78720", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x2D7881C", Offset = "0x2D7881C", VA = "0x2D7881C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4BDC", Offset = "0x10E4BDC")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4C14", Offset = "0x10E4C14")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4C4C", Offset = "0x10E4C4C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4C84", Offset = "0x10E4C84")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4CBC", Offset = "0x10E4CBC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x10E4CF4", Offset = "0x10E4CF4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E4D2C", Offset = "0x10E4D2C")]
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
			[Address(RVA = "0x2FCED8C", Offset = "0x2FCED8C", VA = "0x2FCED8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E76DC", Offset = "0x10E76DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x2FCED94", Offset = "0x2FCED94", VA = "0x2FCED94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E76EC", Offset = "0x10E76EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x2FCEDA0", Offset = "0x2FCEDA0", VA = "0x2FCEDA0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x2FCEEE0", Offset = "0x2FCEEE0", VA = "0x2FCEEE0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x2FCEF70", Offset = "0x2FCEF70", VA = "0x2FCEF70", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x2FCEFEC", Offset = "0x2FCEFEC", VA = "0x2FCEFEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x2FCFBD8", Offset = "0x2FCFBD8", VA = "0x2FCFBD8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x2FCFE30", Offset = "0x2FCFE30", VA = "0x2FCFE30", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x2FCF4E0", Offset = "0x2FCF4E0", VA = "0x2FCF4E0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x2FCFF0C", Offset = "0x2FCFF0C", VA = "0x2FCFF0C")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x2FD03B4", Offset = "0x2FD03B4", VA = "0x2FD03B4")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x2FCFC60", Offset = "0x2FCFC60", VA = "0x2FCFC60")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2FD0454", Offset = "0x2FD0454", VA = "0x2FD0454", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2FD0790", Offset = "0x2FD0790", VA = "0x2FD0790")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2FD0880", Offset = "0x2FD0880", VA = "0x2FD0880", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x2FD09E0", Offset = "0x2FD09E0", VA = "0x2FD09E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x10E76FC", Offset = "0x10E76FC")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x2FCF830", Offset = "0x2FCF830", VA = "0x2FCF830")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2FD0A70", Offset = "0x2FD0A70", VA = "0x2FD0A70")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x10DCDF0", Offset = "0x10DCDF0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4D3C", Offset = "0x10E4D3C")]
		public CameraController cameraController;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4D74", Offset = "0x10E4D74")]
		public float accelerationTime;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4DAC", Offset = "0x10E4DAC")]
		public float turnTime;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4DE4", Offset = "0x10E4DE4")]
		public bool walkByDefault;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4E1C", Offset = "0x10E4E1C")]
		public RotationMode rotationMode;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4E54", Offset = "0x10E4E54")]
		public float moveSpeed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E4E8C", Offset = "0x10E4E8C")]
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
			[Address(RVA = "0x2D70664", Offset = "0x2D70664", VA = "0x2D70664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E77AC", Offset = "0x10E77AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x2D7066C", Offset = "0x2D7066C", VA = "0x2D7066C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E77BC", Offset = "0x10E77BC")]
			private set
			{
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x2D70678", Offset = "0x2D70678", VA = "0x2D70678")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x2D70708", Offset = "0x2D70708", VA = "0x2D70708")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x2D70BC8", Offset = "0x2D70BC8", VA = "0x2D70BC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x2D7075C", Offset = "0x2D7075C", VA = "0x2D7075C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x2D709DC", Offset = "0x2D709DC", VA = "0x2D709DC")]
		private void Move()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x2D70C04", Offset = "0x2D70C04", VA = "0x2D70C04")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x2D70CA0", Offset = "0x2D70CA0", VA = "0x2D70CA0")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x2D70D24", Offset = "0x2D70D24", VA = "0x2D70D24")]
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
		[Address(RVA = "0x2D72F14", Offset = "0x2D72F14", VA = "0x2D72F14", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x2D72F90", Offset = "0x2D72F90", VA = "0x2D72F90", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x2D73154", Offset = "0x2D73154", VA = "0x2D73154")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x2D7317C", Offset = "0x2D7317C", VA = "0x2D7317C")]
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
		[Address(RVA = "0x2D72F58", Offset = "0x2D72F58", VA = "0x2D72F58", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2D73298", Offset = "0x2D73298", VA = "0x2D73298", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2D73198", Offset = "0x2D73198", VA = "0x2D73198")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2FC0444", Offset = "0x2FC0444", VA = "0x2FC0444")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2FC0480", Offset = "0x2FC0480", VA = "0x2FC0480")]
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
		[Address(RVA = "0x2D70D4C", Offset = "0x2D70D4C", VA = "0x2D70D4C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2D70D80", Offset = "0x2D70D80", VA = "0x2D70D80")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2D70E30", Offset = "0x2D70E30", VA = "0x2D70E30")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4E9C", Offset = "0x10E4E9C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4ED4", Offset = "0x10E4ED4")]
		public float cornerRadius;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4F0C", Offset = "0x10E4F0C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4F44", Offset = "0x10E4F44")]
		public float maxSampleDistance;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x10E4F7C", Offset = "0x10E4F7C")]
		public float nextPathInterval;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E4FB4", Offset = "0x10E4FB4")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E4FC4", Offset = "0x10E4FC4")]
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
			[Address(RVA = "0x2EFAE38", Offset = "0x2EFAE38", VA = "0x2EFAE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E77CC", Offset = "0x10E77CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x2EFAE44", Offset = "0x2EFAE44", VA = "0x2EFAE44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E77DC", Offset = "0x10E77DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public State state
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x2EFAE50", Offset = "0x2EFAE50", VA = "0x2EFAE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E77EC", Offset = "0x10E77EC")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x2EFAE58", Offset = "0x2EFAE58", VA = "0x2EFAE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E77FC", Offset = "0x10E77FC")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2EFAE60", Offset = "0x2EFAE60", VA = "0x2EFAE60")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2EFAF10", Offset = "0x2EFAF10", VA = "0x2EFAF10")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2EFB2FC", Offset = "0x2EFB2FC", VA = "0x2EFB2FC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2EFB378", Offset = "0x2EFB378", VA = "0x2EFB378")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2EFB2B8", Offset = "0x2EFB2B8", VA = "0x2EFB2B8")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2EFB2E8", Offset = "0x2EFB2E8", VA = "0x2EFB2E8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2EFB4C4", Offset = "0x2EFB4C4", VA = "0x2EFB4C4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x2EFB674", Offset = "0x2EFB674", VA = "0x2EFB674")]
		public Navigator()
		{
		}
	}
}
