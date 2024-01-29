using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1F8A0", Offset = "0xD1F8A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1F8A0", Offset = "0xD1F8A0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2079C", Offset = "0xD2079C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD2079C", Offset = "0xD2079C")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD207F4", Offset = "0xD207F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD207F4", Offset = "0xD207F4")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2084C", Offset = "0xD2084C")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20884", Offset = "0xD20884")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD208BC", Offset = "0xD208BC")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD208F4", Offset = "0xD208F4")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2092C", Offset = "0xD2092C")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20964", Offset = "0xD20964")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2099C", Offset = "0xD2099C")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD209D4", Offset = "0xD209D4")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD209E4", Offset = "0xD209E4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD20A14", Offset = "0xD20A14")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1F4B5B0", Offset = "0x1F4B5B0", VA = "0x1F4B5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27814", Offset = "0xD27814")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1F4B5B8", Offset = "0x1F4B5B8", VA = "0x1F4B5B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27824", Offset = "0xD27824")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1F4B5C4", Offset = "0x1F4B5C4", VA = "0x1F4B5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27834", Offset = "0xD27834")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1F4B5CC", Offset = "0x1F4B5CC", VA = "0x1F4B5CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27844", Offset = "0xD27844")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1F4B5D4", Offset = "0x1F4B5D4", VA = "0x1F4B5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27854", Offset = "0xD27854")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1F4B5DC", Offset = "0x1F4B5DC", VA = "0x1F4B5DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27864", Offset = "0xD27864")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1F4B490", Offset = "0x1F4B490", VA = "0x1F4B490")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27734", Offset = "0xD27734")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1F4B4D8", Offset = "0x1F4B4D8", VA = "0x1F4B4D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2776C", Offset = "0xD2776C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1F4B520", Offset = "0x1F4B520", VA = "0x1F4B520")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD277A4", Offset = "0xD277A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1F4B568", Offset = "0x1F4B568", VA = "0x1F4B568")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD277DC", Offset = "0xD277DC")]
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
		[Address(RVA = "0x1F4B5E4", Offset = "0x1F4B5E4", VA = "0x1F4B5E4")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1F4B5E8", Offset = "0x1F4B5E8", VA = "0x1F4B5E8")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1F4B5EC", Offset = "0x1F4B5EC", VA = "0x1F4B5EC")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1F4B5F0", Offset = "0x1F4B5F0", VA = "0x1F4B5F0")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20A24", Offset = "0xD20A24")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20A5C", Offset = "0xD20A5C")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20A94", Offset = "0xD20A94")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20ACC", Offset = "0xD20ACC")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20B04", Offset = "0xD20B04")]
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
		[Address(RVA = "0x2D406F0", Offset = "0x2D406F0", VA = "0x2D406F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2D40AF4", Offset = "0x2D40AF4", VA = "0x2D40AF4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2D40AFC", Offset = "0x2D40AFC", VA = "0x2D40AFC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2D40C0C", Offset = "0x2D40C0C", VA = "0x2D40C0C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2D40C88", Offset = "0x2D40C88", VA = "0x2D40C88", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2D40D04", Offset = "0x2D40D04", VA = "0x2D40D04", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2D4094C", Offset = "0x2D4094C", VA = "0x2D4094C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2D40A20", Offset = "0x2D40A20", VA = "0x2D40A20")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2D40D80", Offset = "0x2D40D80", VA = "0x2D40D80")]
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
		[Address(RVA = "0x2CB5920", Offset = "0x2CB5920", VA = "0x2CB5920")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1F4A864", Offset = "0x1F4A864", VA = "0x1F4A864")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1F4AACC", Offset = "0x1F4AACC", VA = "0x1F4AACC")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1F4AAAC", Offset = "0x1F4AAAC", VA = "0x1F4AAAC")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1F4B090", Offset = "0x1F4B090", VA = "0x1F4B090")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1F4C9A4", Offset = "0x1F4C9A4", VA = "0x1F4C9A4")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1F4E2D4", Offset = "0x1F4E2D4", VA = "0x1F4E2D4")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1F4C3F8", Offset = "0x1F4C3F8", VA = "0x1F4C3F8")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1F4C9EC", Offset = "0x1F4C9EC", VA = "0x1F4C9EC")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1F4BF28", Offset = "0x1F4BF28", VA = "0x1F4BF28")]
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
		[Address(RVA = "0x1F4B70C", Offset = "0x1F4B70C", VA = "0x1F4B70C")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1F4BA20", Offset = "0x1F4BA20", VA = "0x1F4BA20")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1F4B8C4", Offset = "0x1F4B8C4", VA = "0x1F4B8C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1F4BBFC", Offset = "0x1F4BBFC", VA = "0x1F4BBFC")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1F4C18C", Offset = "0x1F4C18C", VA = "0x1F4C18C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1F4C288", Offset = "0x1F4C288", VA = "0x1F4C288")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1F4C384", Offset = "0x1F4C384", VA = "0x1F4C384")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1F4C2FC", Offset = "0x1F4C2FC", VA = "0x1F4C2FC")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1F4C5F0", Offset = "0x1F4C5F0", VA = "0x1F4C5F0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1F4C6A4", Offset = "0x1F4C6A4", VA = "0x1F4C6A4")]
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
		[Address(RVA = "0x1F4C9F0", Offset = "0x1F4C9F0", VA = "0x1F4C9F0")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1F4CA6C", Offset = "0x1F4CA6C", VA = "0x1F4CA6C")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1F4D508", Offset = "0x1F4D508", VA = "0x1F4D508")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1F4D5BC", Offset = "0x1F4D5BC", VA = "0x1F4D5BC")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1F4D4A4", Offset = "0x1F4D4A4", VA = "0x1F4D4A4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1F4D6B4", Offset = "0x1F4D6B4", VA = "0x1F4D6B4")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1F4D6FC", Offset = "0x1F4D6FC", VA = "0x1F4D6FC")]
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
		[Address(RVA = "0x1F4D704", Offset = "0x1F4D704", VA = "0x1F4D704")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1F4D8F4", Offset = "0x1F4D8F4", VA = "0x1F4D8F4")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1F4D908", Offset = "0x1F4D908", VA = "0x1F4D908")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1F4DBF4", Offset = "0x1F4DBF4", VA = "0x1F4DBF4")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1F4D7B0", Offset = "0x1F4D7B0", VA = "0x1F4D7B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1F4DEA8", Offset = "0x1F4DEA8", VA = "0x1F4DEA8")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1F4DF1C", Offset = "0x1F4DF1C", VA = "0x1F4DF1C")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1F4E0D0", Offset = "0x1F4E0D0", VA = "0x1F4E0D0")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20B3C", Offset = "0xD20B3C")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD20B74", Offset = "0xD20B74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20B74", Offset = "0xD20B74")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20BCC", Offset = "0xD20BCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD20BCC", Offset = "0xD20BCC")]
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
		[Address(RVA = "0x2D49C44", Offset = "0x2D49C44", VA = "0x2D49C44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2D4A1D8", Offset = "0x2D4A1D8", VA = "0x2D4A1D8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2D4A1F4", Offset = "0x2D4A1F4", VA = "0x2D4A1F4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2D4A2D0", Offset = "0x2D4A2D0", VA = "0x2D4A2D0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2D4A3AC", Offset = "0x2D4A3AC", VA = "0x2D4A3AC", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2D4A57C", Offset = "0x2D4A57C", VA = "0x2D4A57C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2D4A8B4", Offset = "0x2D4A8B4", VA = "0x2D4A8B4")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2D4A990", Offset = "0x2D4A990", VA = "0x2D4A990")]
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
		[Address(RVA = "0x1F4B098", Offset = "0x1F4B098", VA = "0x1F4B098")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1F4B0BC", Offset = "0x1F4B0BC", VA = "0x1F4B0BC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1F4B0F4", Offset = "0x1F4B0F4", VA = "0x1F4B0F4")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1F4B1E4", Offset = "0x1F4B1E4", VA = "0x1F4B1E4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1F4B18C", Offset = "0x1F4B18C", VA = "0x1F4B18C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1F4B27C", Offset = "0x1F4B27C", VA = "0x1F4B27C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1F4B2C4", Offset = "0x1F4B2C4", VA = "0x1F4B2C4")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1F4B488", Offset = "0x1F4B488", VA = "0x1F4B488")]
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
			[Address(RVA = "0x2909288", Offset = "0x2909288", VA = "0x2909288")]
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
			[Address(RVA = "0x1F4FC90", Offset = "0x1F4FC90", VA = "0x1F4FC90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1F4FF00", Offset = "0x1F4FF00", VA = "0x1F4FF00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1F4FC10", Offset = "0x1F4FC10", VA = "0x1F4FC10")]
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
		[Address(RVA = "0x1F50170", Offset = "0x1F50170", VA = "0x1F50170")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1F50494", Offset = "0x1F50494", VA = "0x1F50494")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1F50708", Offset = "0x1F50708", VA = "0x1F50708")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1F50788", Offset = "0x1F50788", VA = "0x1F50788")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1F50830", Offset = "0x1F50830", VA = "0x1F50830")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1F50348", Offset = "0x1F50348", VA = "0x1F50348")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1F5066C", Offset = "0x1F5066C", VA = "0x1F5066C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1F51060", Offset = "0x1F51060", VA = "0x1F51060")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1F50E68", Offset = "0x1F50E68", VA = "0x1F50E68")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1F50F64", Offset = "0x1F50F64", VA = "0x1F50F64")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1F50A48", Offset = "0x1F50A48", VA = "0x1F50A48")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1F50AF8", Offset = "0x1F50AF8", VA = "0x1F50AF8")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1F50BA8", Offset = "0x1F50BA8", VA = "0x1F50BA8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1F50C58", Offset = "0x1F50C58", VA = "0x1F50C58")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1F50D08", Offset = "0x1F50D08", VA = "0x1F50D08")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1F50DB8", Offset = "0x1F50DB8", VA = "0x1F50DB8")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1F51268", Offset = "0x1F51268", VA = "0x1F51268")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1F50960", Offset = "0x1F50960", VA = "0x1F50960")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1F511D8", Offset = "0x1F511D8", VA = "0x1F511D8")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1F512D4", Offset = "0x1F512D4", VA = "0x1F512D4")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1F513A8", Offset = "0x1F513A8", VA = "0x1F513A8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1F51160", Offset = "0x1F51160", VA = "0x1F51160")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1F510EC", Offset = "0x1F510EC", VA = "0x1F510EC")]
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
				[Address(RVA = "0x2909314", Offset = "0x2909314", VA = "0x2909314")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x2909300", Offset = "0x2909300", VA = "0x2909300")]
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
			[Address(RVA = "0x1F53C10", Offset = "0x1F53C10", VA = "0x1F53C10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000007")]
		public bool isEmpty
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1F53FF8", Offset = "0x1F53FF8", VA = "0x1F53FF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1F54008", Offset = "0x1F54008", VA = "0x1F54008", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1F54430", Offset = "0x1F54430", VA = "0x1F54430", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1F54864", Offset = "0x1F54864", VA = "0x1F54864")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1F54F34", Offset = "0x1F54F34", VA = "0x1F54F34")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1F54A90", Offset = "0x1F54A90", VA = "0x1F54A90")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1F4F000", Offset = "0x1F4F000", VA = "0x1F4F000")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1F557B8", Offset = "0x1F557B8", VA = "0x1F557B8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1F55D74", Offset = "0x1F55D74", VA = "0x1F55D74")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1F55B54", Offset = "0x1F55B54", VA = "0x1F55B54")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1F559D0", Offset = "0x1F559D0", VA = "0x1F559D0")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1F55858", Offset = "0x1F55858", VA = "0x1F55858")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1F55C60", Offset = "0x1F55C60", VA = "0x1F55C60")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1F55E6C", Offset = "0x1F55E6C", VA = "0x1F55E6C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1F56A54", Offset = "0x1F56A54", VA = "0x1F56A54")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1F564C4", Offset = "0x1F564C4", VA = "0x1F564C4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1F56D50", Offset = "0x1F56D50", VA = "0x1F56D50")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1F5683C", Offset = "0x1F5683C", VA = "0x1F5683C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1F56D58", Offset = "0x1F56D58", VA = "0x1F56D58")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1F56D60", Offset = "0x1F56D60", VA = "0x1F56D60")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1F56F34", Offset = "0x1F56F34", VA = "0x1F56F34")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1F570FC", Offset = "0x1F570FC", VA = "0x1F570FC")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1F4F784", Offset = "0x1F4F784", VA = "0x1F4F784")]
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
		[Address(RVA = "0x1F58528", Offset = "0x1F58528", VA = "0x1F58528")]
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
		[Address(RVA = "0x1F611F4", Offset = "0x1F611F4", VA = "0x1F611F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1F6133C", Offset = "0x1F6133C", VA = "0x1F6133C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class Hierarchy
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2D48654", Offset = "0x2D48654", VA = "0x2D48654")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2D48840", Offset = "0x2D48840", VA = "0x2D48840")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2D486EC", Offset = "0x2D486EC", VA = "0x2D486EC")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2D48960", Offset = "0x2D48960", VA = "0x2D48960")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2D48A8C", Offset = "0x2D48A8C", VA = "0x2D48A8C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2D48CE0", Offset = "0x2D48CE0", VA = "0x2D48CE0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2D48DE8", Offset = "0x2D48DE8", VA = "0x2D48DE8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2D48F5C", Offset = "0x2D48F5C", VA = "0x2D48F5C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2D49338", Offset = "0x2D49338", VA = "0x2D49338")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2D490FC", Offset = "0x2D490FC", VA = "0x2D490FC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2D494EC", Offset = "0x2D494EC", VA = "0x2D494EC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2E2AF40", Offset = "0x2E2AF40", VA = "0x2E2AF40")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2E2AFCC", Offset = "0x2E2AFCC", VA = "0x2E2AFCC")]
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
		[Address(RVA = "0x2CAAD14", Offset = "0x2CAAD14", VA = "0x2CAAD14")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2CAB6C0", Offset = "0x2CAB6C0", VA = "0x2CAB6C0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2CAB734", Offset = "0x2CAB734", VA = "0x2CAB734")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2CAB128", Offset = "0x2CAB128", VA = "0x2CAB128")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2CAB134", Offset = "0x2CAB134", VA = "0x2CAB134")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2CAB158", Offset = "0x2CAB158", VA = "0x2CAB158")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2CAB194", Offset = "0x2CAB194", VA = "0x2CAB194")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2CAB1AC", Offset = "0x2CAB1AC", VA = "0x2CAB1AC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2CAB1C0", Offset = "0x2CAB1C0", VA = "0x2CAB1C0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2CAB1D4", Offset = "0x2CAB1D4", VA = "0x2CAB1D4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2CAB1E4", Offset = "0x2CAB1E4", VA = "0x2CAB1E4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2CAB22C", Offset = "0x2CAB22C", VA = "0x2CAB22C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2CAB264", Offset = "0x2CAB264", VA = "0x2CAB264")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2CAB28C", Offset = "0x2CAB28C", VA = "0x2CAB28C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2CAB7C0", Offset = "0x2CAB7C0", VA = "0x2CAB7C0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2CAB2C0", Offset = "0x2CAB2C0", VA = "0x2CAB2C0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2CAB2E8", Offset = "0x2CAB2E8", VA = "0x2CAB2E8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2CAB318", Offset = "0x2CAB318", VA = "0x2CAB318")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2CAB34C", Offset = "0x2CAB34C", VA = "0x2CAB34C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2CAB390", Offset = "0x2CAB390", VA = "0x2CAB390")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2CAB3F4", Offset = "0x2CAB3F4", VA = "0x2CAB3F4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2CAB458", Offset = "0x2CAB458", VA = "0x2CAB458")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2CAB4AC", Offset = "0x2CAB4AC", VA = "0x2CAB4AC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2CAB500", Offset = "0x2CAB500", VA = "0x2CAB500")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2CAB53C", Offset = "0x2CAB53C", VA = "0x2CAB53C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2CAB574", Offset = "0x2CAB574", VA = "0x2CAB574")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2CAB7F4", Offset = "0x2CAB7F4", VA = "0x2CAB7F4")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2CAB5BC", Offset = "0x2CAB5BC", VA = "0x2CAB5BC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2CAB650", Offset = "0x2CAB650", VA = "0x2CAB650")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2CAB680", Offset = "0x2CAB680", VA = "0x2CAB680")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2CAB888", Offset = "0x2CAB888", VA = "0x2CAB888")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2CAB890", Offset = "0x2CAB890", VA = "0x2CAB890")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2CAB91C", Offset = "0x2CAB91C", VA = "0x2CAB91C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2CAB9AC", Offset = "0x2CAB9AC", VA = "0x2CAB9AC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2CABA04", Offset = "0x2CABA04", VA = "0x2CABA04")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2CABAD0", Offset = "0x2CABAD0", VA = "0x2CABAD0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2CABA1C", Offset = "0x2CABA1C", VA = "0x2CABA1C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2CABAE8", Offset = "0x2CABAE8", VA = "0x2CABAE8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2CABB8C", Offset = "0x2CABB8C", VA = "0x2CABB8C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2CABBB8", Offset = "0x2CABBB8", VA = "0x2CABBB8")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2CABC08", Offset = "0x2CABC08", VA = "0x2CABC08")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2CABC74", Offset = "0x2CABC74", VA = "0x2CABC74")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2CABD88", Offset = "0x2CABD88", VA = "0x2CABD88")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2CABE80", Offset = "0x2CABE80", VA = "0x2CABE80")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2CABEDC", Offset = "0x2CABEDC", VA = "0x2CABEDC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001D")]
	public static class QuaTools
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2CAE058", Offset = "0x2CAE058", VA = "0x2CAE058")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2CAE0B4", Offset = "0x2CAE0B4", VA = "0x2CAE0B4")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2CAE144", Offset = "0x2CAE144", VA = "0x2CAE144")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2CAE2A4", Offset = "0x2CAE2A4", VA = "0x2CAE2A4")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2CAE360", Offset = "0x2CAE360", VA = "0x2CAE360")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2CAE41C", Offset = "0x2CAE41C", VA = "0x2CAE41C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2CAE5C8", Offset = "0x2CAE5C8", VA = "0x2CAE5C8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2CAE618", Offset = "0x2CAE618", VA = "0x2CAE618")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2CAE668", Offset = "0x2CAE668", VA = "0x2CAE668")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2CAE710", Offset = "0x2CAE710", VA = "0x2CAE710")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2CAE7B8", Offset = "0x2CAE7B8", VA = "0x2CAE7B8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2CAE898", Offset = "0x2CAE898", VA = "0x2CAE898")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2CAE8EC", Offset = "0x2CAE8EC", VA = "0x2CAE8EC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2CAE9C0", Offset = "0x2CAE9C0", VA = "0x2CAE9C0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2CAEAD0", Offset = "0x2CAEAD0", VA = "0x2CAEAD0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2CAEC60", Offset = "0x2CAEC60", VA = "0x2CAEC60")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2CAED54", Offset = "0x2CAED54", VA = "0x2CAED54")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2CAEE60", Offset = "0x2CAEE60", VA = "0x2CAEE60")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2CAEF4C", Offset = "0x2CAEF4C", VA = "0x2CAEF4C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20C30", Offset = "0xD20C30")]
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
			[Address(RVA = "0x2CB3DD0", Offset = "0x2CB3DD0", VA = "0x2CB3DD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x2CB411C", Offset = "0x2CB411C", VA = "0x2CB411C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2CB3C90", Offset = "0x2CB3C90", VA = "0x2CB3C90")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2CB3D30", Offset = "0x2CB3D30", VA = "0x2CB3D30", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2CB3D34", Offset = "0x2CB3D34", VA = "0x2CB3D34", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2CB3D38", Offset = "0x2CB3D38", VA = "0x2CB3D38", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2CB3D3C", Offset = "0x2CB3D3C", VA = "0x2CB3D3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2CB3DCC", Offset = "0x2CB3DCC", VA = "0x2CB3DCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2CB3D74", Offset = "0x2CB3D74", VA = "0x2CB3D74")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2CB40D0", Offset = "0x2CB40D0", VA = "0x2CB40D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2CB3EBC", Offset = "0x2CB3EBC", VA = "0x2CB3EBC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2CB41D4", Offset = "0x2CB41D4", VA = "0x2CB41D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2CB4230", Offset = "0x2CB4230", VA = "0x2CB4230")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2CB428C", Offset = "0x2CB428C", VA = "0x2CB428C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2CAE048", Offset = "0x2CAE048", VA = "0x2CAE048")]
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
		[Address(RVA = "0x2CB5990", Offset = "0x2CB5990", VA = "0x2CB5990")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2CB5A50", Offset = "0x2CB5A50", VA = "0x2CB5A50")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2CB5B10", Offset = "0x2CB5B10", VA = "0x2CB5B10")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2CB5BD0", Offset = "0x2CB5BD0", VA = "0x2CB5BD0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class V2Tools
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2CB6BF4", Offset = "0x2CB6BF4", VA = "0x2CB6BF4")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2CB6BFC", Offset = "0x2CB6BFC", VA = "0x2CB6BFC")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2CB6C4C", Offset = "0x2CB6C4C", VA = "0x2CB6C4C")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2CB6CA0", Offset = "0x2CB6CA0", VA = "0x2CB6CA0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2CB6D78", Offset = "0x2CB6D78", VA = "0x2CB6D78")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000022")]
	public static class V3Tools
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2CB6E0C", Offset = "0x2CB6E0C", VA = "0x2CB6E0C")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2CB6E30", Offset = "0x2CB6E30", VA = "0x2CB6E30")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2CB6E78", Offset = "0x2CB6E78", VA = "0x2CB6E78")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2CB6F04", Offset = "0x2CB6F04", VA = "0x2CB6F04")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2CB6F64", Offset = "0x2CB6F64", VA = "0x2CB6F64")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2CB6FC4", Offset = "0x2CB6FC4", VA = "0x2CB6FC4")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2CB70E0", Offset = "0x2CB70E0", VA = "0x2CB70E0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2CB7180", Offset = "0x2CB7180", VA = "0x2CB7180")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2CB71BC", Offset = "0x2CB71BC", VA = "0x2CB71BC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2CB7200", Offset = "0x2CB7200", VA = "0x2CB7200")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2CB729C", Offset = "0x2CB729C", VA = "0x2CB729C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2CB73F8", Offset = "0x2CB73F8", VA = "0x2CB73F8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2CB7574", Offset = "0x2CB7574", VA = "0x2CB7574")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2CB76F8", Offset = "0x2CB76F8", VA = "0x2CB76F8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2CB77B4", Offset = "0x2CB77B4", VA = "0x2CB77B4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2CB78B4", Offset = "0x2CB78B4", VA = "0x2CB78B4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2CB793C", Offset = "0x2CB793C", VA = "0x2CB793C")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2CB79D8", Offset = "0x2CB79D8", VA = "0x2CB79D8")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2CB7A7C", Offset = "0x2CB7A7C", VA = "0x2CB7A7C")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2CB7A6C", Offset = "0x2CB7A6C", VA = "0x2CB7A6C")]
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
		[Address(RVA = "0x2908AE0", Offset = "0x2908AE0", VA = "0x2908AE0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2908B78", Offset = "0x2908B78", VA = "0x2908B78")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20C68", Offset = "0xD20C68")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20CA0", Offset = "0xD20CA0")]
		public float cornerRadius;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20CD8", Offset = "0xD20CD8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20D10", Offset = "0xD20D10")]
		public float maxSampleDistance;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20D48", Offset = "0xD20D48")]
		public float nextPathInterval;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD20D80", Offset = "0xD20D80")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD20D90", Offset = "0xD20D90")]
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
			[Address(RVA = "0x2CACD7C", Offset = "0x2CACD7C", VA = "0x2CACD7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD278E4", Offset = "0xD278E4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2CACD88", Offset = "0x2CACD88", VA = "0x2CACD88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD278F4", Offset = "0xD278F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public State state
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2CACD94", Offset = "0x2CACD94", VA = "0x2CACD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27904", Offset = "0xD27904")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2CACD9C", Offset = "0x2CACD9C", VA = "0x2CACD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27914", Offset = "0xD27914")]
			private set
			{
			}
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2CACDA4", Offset = "0x2CACDA4", VA = "0x2CACDA4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2CACE78", Offset = "0x2CACE78", VA = "0x2CACE78")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2CAD278", Offset = "0x2CAD278", VA = "0x2CAD278")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2CAD2F4", Offset = "0x2CAD2F4", VA = "0x2CAD2F4")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2CAD234", Offset = "0x2CAD234", VA = "0x2CAD234")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2CAD264", Offset = "0x2CAD264", VA = "0x2CAD264")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2CAD440", Offset = "0x2CAD440", VA = "0x2CAD440")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2CAD5F0", Offset = "0x2CAD5F0", VA = "0x2CAD5F0")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1F910", Offset = "0xD1F910")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1F910", Offset = "0xD1F910")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1F4E6A4", Offset = "0x1F4E6A4", VA = "0x1F4E6A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27924", Offset = "0xD27924")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1F4E6EC", Offset = "0x1F4E6EC", VA = "0x1F4E6EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2795C", Offset = "0xD2795C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1F4E734", Offset = "0x1F4E734", VA = "0x1F4E734")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27994", Offset = "0xD27994")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1F4E77C", Offset = "0x1F4E77C", VA = "0x1F4E77C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD279CC", Offset = "0xD279CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1F4E7C4", Offset = "0x1F4E7C4", VA = "0x1F4E7C4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1F4E860", Offset = "0x1F4E860", VA = "0x1F4E860")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1F4E880", Offset = "0x1F4E880", VA = "0x1F4E880")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1F4E8B0", Offset = "0x1F4E8B0", VA = "0x1F4E8B0")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1F4E8E0", Offset = "0x1F4E8E0", VA = "0x1F4E8E0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1F4E920", Offset = "0x1F4E920", VA = "0x1F4E920")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1F4E964", Offset = "0x1F4E964", VA = "0x1F4E964")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1F4E988", Offset = "0x1F4E988", VA = "0x1F4E988")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1F4E9AC", Offset = "0x1F4E9AC", VA = "0x1F4E9AC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1F4E9D4", Offset = "0x1F4E9D4", VA = "0x1F4E9D4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1F4EA00", Offset = "0x1F4EA00", VA = "0x1F4EA00")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1F4EA2C", Offset = "0x1F4EA2C", VA = "0x1F4EA2C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1F4E7E4", Offset = "0x1F4E7E4", VA = "0x1F4E7E4")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1F4EA54", Offset = "0x1F4EA54", VA = "0x1F4EA54")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1F4EA60", Offset = "0x1F4EA60", VA = "0x1F4EA60")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1F4EA6C", Offset = "0x1F4EA6C", VA = "0x1F4EA6C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1F4ED90", Offset = "0x1F4ED90", VA = "0x1F4ED90", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1F4EE38", Offset = "0x1F4EE38", VA = "0x1F4EE38", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1F4F278", Offset = "0x1F4F278", VA = "0x1F4F278", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1F4F6B0", Offset = "0x1F4F6B0", VA = "0x1F4F6B0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1F4F6E4", Offset = "0x1F4F6E4", VA = "0x1F4F6E4")]
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
			[Address(RVA = "0x1F4EC0C", Offset = "0x1F4EC0C", VA = "0x1F4EC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x1F4F9DC", Offset = "0x1F4F9DC", VA = "0x1F4F9DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1F4F0FC", Offset = "0x1F4F0FC", VA = "0x1F4F0FC")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1F4F808", Offset = "0x1F4F808", VA = "0x1F4F808")]
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
			[Address(RVA = "0x1F58530", Offset = "0x1F58530", VA = "0x1F58530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1F5859C", Offset = "0x1F5859C", VA = "0x1F5859C")]
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
		[Address(RVA = "0x1F585A4", Offset = "0x1F585A4", VA = "0x1F585A4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1F58664", Offset = "0x1F58664", VA = "0x1F58664")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1F5866C", Offset = "0x1F5866C", VA = "0x1F5866C")]
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
			[Address(RVA = "0x1F587A8", Offset = "0x1F587A8", VA = "0x1F587A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1F586A0", Offset = "0x1F586A0", VA = "0x1F586A0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1F587E4", Offset = "0x1F587E4", VA = "0x1F587E4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1F587EC", Offset = "0x1F587EC", VA = "0x1F587EC")]
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
		[Address(RVA = "0x1F58820", Offset = "0x1F58820", VA = "0x1F58820", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1F588A0", Offset = "0x1F588A0", VA = "0x1F588A0")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1F588A8", Offset = "0x1F588A8", VA = "0x1F588A8")]
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
			[Address(RVA = "0x1F589E4", Offset = "0x1F589E4", VA = "0x1F589E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1F588DC", Offset = "0x1F588DC", VA = "0x1F588DC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1F58A20", Offset = "0x1F58A20", VA = "0x1F58A20")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1F58A28", Offset = "0x1F58A28", VA = "0x1F58A28")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD20DA0", Offset = "0xD20DA0")]
		public float positionWeight;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD20DB8", Offset = "0xD20DB8")]
		public float rotationWeight;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1F58A5C", Offset = "0x1F58A5C", VA = "0x1F58A5C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1F4F220", Offset = "0x1F4F220", VA = "0x1F4F220")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1F4F400", Offset = "0x1F4F400", VA = "0x1F4F400")]
		public void Update()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1F4FC08", Offset = "0x1F4FC08", VA = "0x1F4FC08")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20DD0", Offset = "0xD20DD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD20DD0", Offset = "0xD20DD0")]
		public float weight;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20E24", Offset = "0xD20E24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD20E24", Offset = "0xD20E24")]
		public float rotationWeight;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20E78", Offset = "0xD20E78")]
		public DOF rotationDOF;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20EB0", Offset = "0xD20EB0")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20EE8", Offset = "0xD20EE8")]
		public Transform bone1;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20F20", Offset = "0xD20F20")]
		public Transform bone2;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20F58", Offset = "0xD20F58")]
		public Transform bone3;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20F90", Offset = "0xD20F90")]
		public Transform tip;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD20FC8", Offset = "0xD20FC8")]
		public Transform target;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21000", Offset = "0xD21000")]
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
			[Address(RVA = "0x2D3E734", Offset = "0x2D3E734", VA = "0x2D3E734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27A04", Offset = "0xD27A04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2D3E73C", Offset = "0x2D3E73C", VA = "0x2D3E73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27A14", Offset = "0xD27A14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2D3E748", Offset = "0x2D3E748", VA = "0x2D3E748")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2D3E768", Offset = "0x2D3E768", VA = "0x2D3E768")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2D3E788", Offset = "0x2D3E788", VA = "0x2D3E788")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2D3E7A8", Offset = "0x2D3E7A8", VA = "0x2D3E7A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2D3E7C8", Offset = "0x2D3E7C8", VA = "0x2D3E7C8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2D3E8DC", Offset = "0x2D3E8DC", VA = "0x2D3E8DC")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2D3EE6C", Offset = "0x2D3EE6C", VA = "0x2D3EE6C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2D3EF44", Offset = "0x2D3EF44", VA = "0x2D3EF44")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2D3F008", Offset = "0x2D3F008", VA = "0x2D3F008")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2D3F490", Offset = "0x2D3F490", VA = "0x2D3F490")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21010", Offset = "0xD21010")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21010", Offset = "0xD21010")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21064", Offset = "0xD21064")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000016")]
		public bool initiated
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x2D3F4A0", Offset = "0x2D3F4A0", VA = "0x2D3F4A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27A24", Offset = "0xD27A24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2D3F4A8", Offset = "0x2D3F4A8", VA = "0x2D3F4A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27A34", Offset = "0xD27A34")]
			private set
			{
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2D3F4B4", Offset = "0x2D3F4B4", VA = "0x2D3F4B4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2D3F53C", Offset = "0x2D3F53C", VA = "0x2D3F53C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27A44", Offset = "0xD27A44")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2D3F8C8", Offset = "0x2D3F8C8", VA = "0x2D3F8C8")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2D3FA8C", Offset = "0x2D3FA8C", VA = "0x2D3FA8C")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2D3F7C4", Offset = "0x2D3F7C4", VA = "0x2D3F7C4")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x2D3FC18", Offset = "0x2D3FC18", VA = "0x2D3FC18", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2D3FCD8", Offset = "0x2D3FCD8", VA = "0x2D3FCD8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2D3FD50", Offset = "0x2D3FD50", VA = "0x2D3FD50")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2D3FDC4", Offset = "0x2D3FDC4", VA = "0x2D3FDC4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2D3FE2C", Offset = "0x2D3FE2C", VA = "0x2D3FE2C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2D3FE30", Offset = "0x2D3FE30", VA = "0x2D3FE30", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2D3FE44", Offset = "0x2D3FE44", VA = "0x2D3FE44")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21074", Offset = "0xD21074")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21074", Offset = "0xD21074")]
		public float weight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD210C8", Offset = "0xD210C8")]
		public Grounding solver;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21100", Offset = "0xD21100")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2D41300", Offset = "0x2D41300", VA = "0x2D41300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27A7C", Offset = "0xD27A7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x2D41308", Offset = "0x2D41308", VA = "0x2D41308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27A8C", Offset = "0xD27A8C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000164")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2D41314", Offset = "0x2D41314", VA = "0x2D41314")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2D414C0", Offset = "0x2D414C0", VA = "0x2D414C0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2D413C0", Offset = "0x2D413C0", VA = "0x2D413C0")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2D414F4", Offset = "0x2D414F4", VA = "0x2D414F4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600016C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2D41630", Offset = "0x2D41630", VA = "0x2D41630")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1F970", Offset = "0xD1F970")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1F970", Offset = "0xD1F970")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21110", Offset = "0xD21110")]
		public BipedIK ik;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21148", Offset = "0xD21148")]
		public float spineBend;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21180", Offset = "0xD21180")]
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
		[Address(RVA = "0x2D4174C", Offset = "0x2D4174C", VA = "0x2D4174C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27A9C", Offset = "0xD27A9C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x2D41794", Offset = "0x2D41794", VA = "0x2D41794", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27AD4", Offset = "0xD27AD4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2D417DC", Offset = "0x2D417DC", VA = "0x2D417DC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2D418A4", Offset = "0x2D418A4", VA = "0x2D418A4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2D41950", Offset = "0x2D41950", VA = "0x2D41950")]
		private void Update()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2D419B0", Offset = "0x2D419B0", VA = "0x2D419B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2D41F9C", Offset = "0x2D41F9C", VA = "0x2D41F9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2D41FF0", Offset = "0x2D41FF0", VA = "0x2D41FF0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2D42674", Offset = "0x2D42674", VA = "0x2D42674")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2D4278C", Offset = "0x2D4278C", VA = "0x2D4278C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2D428CC", Offset = "0x2D428CC", VA = "0x2D428CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2D42A90", Offset = "0x2D42A90", VA = "0x2D42A90")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1F9D0", Offset = "0xD1F9D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1F9D0", Offset = "0xD1F9D0")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000119")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21260", Offset = "0xD21260")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400011A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21298", Offset = "0xD21298")]
			public float horizontalWeight;

			[Token(Token = "0x400011B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD212D0", Offset = "0xD212D0")]
			public float verticalWeight;

			[Token(Token = "0x600018C")]
			[Address(RVA = "0x290CA38", Offset = "0x290CA38", VA = "0x290CA38")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0x290CA48", Offset = "0x290CA48", VA = "0x290CA48")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD211B8", Offset = "0xD211B8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD211F0", Offset = "0xD211F0")]
		public float spineBend;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21228", Offset = "0xD21228")]
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
		[Address(RVA = "0x2D42B30", Offset = "0x2D42B30", VA = "0x2D42B30")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27B0C", Offset = "0xD27B0C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2D42B78", Offset = "0x2D42B78", VA = "0x2D42B78", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27B44", Offset = "0xD27B44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2D42BC0", Offset = "0x2D42BC0", VA = "0x2D42BC0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27B7C", Offset = "0xD27B7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2D42C08", Offset = "0x2D42C08", VA = "0x2D42C08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2D42C44", Offset = "0x2D42C44", VA = "0x2D42C44")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2D42CD8", Offset = "0x2D42CD8", VA = "0x2D42CD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2D42F90", Offset = "0x2D42F90", VA = "0x2D42F90")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2D42F9C", Offset = "0x2D42F9C", VA = "0x2D42F9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2D42D40", Offset = "0x2D42D40", VA = "0x2D42D40")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2D42FA8", Offset = "0x2D42FA8", VA = "0x2D42FA8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2D432C4", Offset = "0x2D432C4", VA = "0x2D432C4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2D433D4", Offset = "0x2D433D4", VA = "0x2D433D4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2D43550", Offset = "0x2D43550", VA = "0x2D43550")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2D43688", Offset = "0x2D43688", VA = "0x2D43688")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FA30", Offset = "0xD1FA30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FA30", Offset = "0xD1FA30")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21308", Offset = "0xD21308")]
		public Transform pelvis;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21340", Offset = "0xD21340")]
		public Transform characterRoot;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21378", Offset = "0xD21378")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21378", Offset = "0xD21378")]
		public float rootRotationWeight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD213CC", Offset = "0xD213CC")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21404", Offset = "0xD21404")]
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
		[Address(RVA = "0x2D43728", Offset = "0x2D43728", VA = "0x2D43728", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27BB4", Offset = "0xD27BB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2D43770", Offset = "0x2D43770", VA = "0x2D43770", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27BEC", Offset = "0xD27BEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2D437B8", Offset = "0x2D437B8", VA = "0x2D437B8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2D437D0", Offset = "0x2D437D0", VA = "0x2D437D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2D43A04", Offset = "0x2D43A04", VA = "0x2D43A04")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2D43B00", Offset = "0x2D43B00", VA = "0x2D43B00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2D440B0", Offset = "0x2D440B0", VA = "0x2D440B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2D44514", Offset = "0x2D44514", VA = "0x2D44514")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2D446A0", Offset = "0x2D446A0", VA = "0x2D446A0")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2D449A4", Offset = "0x2D449A4", VA = "0x2D449A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2D44AF0", Offset = "0x2D44AF0", VA = "0x2D44AF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2D44CFC", Offset = "0x2D44CFC", VA = "0x2D44CFC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FA90", Offset = "0xD1FA90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FA90", Offset = "0xD1FA90")]
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
			[Address(RVA = "0x290CA90", Offset = "0x290CA90", VA = "0x290CA90")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2143C", Offset = "0xD2143C")]
		public Grounding forelegSolver;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21474", Offset = "0xD21474")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21474", Offset = "0xD21474")]
		public float rootRotationWeight;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD214C8", Offset = "0xD214C8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD214C8", Offset = "0xD214C8")]
		public float minRootRotation;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21520", Offset = "0xD21520")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21520", Offset = "0xD21520")]
		public float maxRootRotation;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21578", Offset = "0xD21578")]
		public float rootRotationSpeed;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD215B0", Offset = "0xD215B0")]
		public float maxLegOffset;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD215E8", Offset = "0xD215E8")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21620", Offset = "0xD21620")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21620", Offset = "0xD21620")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21674", Offset = "0xD21674")]
		public Transform characterRoot;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD216AC", Offset = "0xD216AC")]
		public Transform pelvis;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD216E4", Offset = "0xD216E4")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2171C", Offset = "0xD2171C")]
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
		[Address(RVA = "0x2D44D9C", Offset = "0x2D44D9C", VA = "0x2D44D9C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27C24", Offset = "0xD27C24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2D44DE4", Offset = "0x2D44DE4", VA = "0x2D44DE4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27C5C", Offset = "0xD27C5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2D44E2C", Offset = "0x2D44E2C", VA = "0x2D44E2C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2D44E60", Offset = "0x2D44E60", VA = "0x2D44E60")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2D44F8C", Offset = "0x2D44F8C", VA = "0x2D44F8C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2D45190", Offset = "0x2D45190", VA = "0x2D45190")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2D451F8", Offset = "0x2D451F8", VA = "0x2D451F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2D4525C", Offset = "0x2D4525C", VA = "0x2D4525C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2D455BC", Offset = "0x2D455BC", VA = "0x2D455BC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2D45954", Offset = "0x2D45954", VA = "0x2D45954")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2D45A4C", Offset = "0x2D45A4C", VA = "0x2D45A4C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2D45E18", Offset = "0x2D45E18", VA = "0x2D45E18")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2D46434", Offset = "0x2D46434", VA = "0x2D46434")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2D46604", Offset = "0x2D46604", VA = "0x2D46604")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2D466E0", Offset = "0x2D466E0", VA = "0x2D466E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2D46928", Offset = "0x2D46928", VA = "0x2D46928")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2D46960", Offset = "0x2D46960", VA = "0x2D46960")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2D46B64", Offset = "0x2D46B64", VA = "0x2D46B64")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FAF0", Offset = "0xD1FAF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FAF0", Offset = "0xD1FAF0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21764", Offset = "0xD21764")]
		public VRIK ik;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2D46C7C", Offset = "0x2D46C7C", VA = "0x2D46C7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27C94", Offset = "0xD27C94")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2D46CC4", Offset = "0x2D46CC4", VA = "0x2D46CC4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27CCC", Offset = "0xD27CCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2D46D0C", Offset = "0x2D46D0C", VA = "0x2D46D0C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27D04", Offset = "0xD27D04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2D46D54", Offset = "0x2D46D54", VA = "0x2D46D54", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2D46D6C", Offset = "0x2D46D6C", VA = "0x2D46D6C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2D46E00", Offset = "0x2D46E00", VA = "0x2D46E00")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2D46E60", Offset = "0x2D46E60", VA = "0x2D46E60")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2D470CC", Offset = "0x2D470CC", VA = "0x2D470CC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2D472BC", Offset = "0x2D472BC", VA = "0x2D472BC")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2D4734C", Offset = "0x2D4734C", VA = "0x2D4734C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2D47508", Offset = "0x2D47508", VA = "0x2D47508")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2D47684", Offset = "0x2D47684", VA = "0x2D47684")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2D47838", Offset = "0x2D47838", VA = "0x2D47838")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C48", Offset = "0xD21C48")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C58", Offset = "0xD21C58")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C68", Offset = "0xD21C68")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C78", Offset = "0xD21C78")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C88", Offset = "0xD21C88")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C98", Offset = "0xD21C98")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21CA8", Offset = "0xD21CA8")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21CB8", Offset = "0xD21CB8")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21CC8", Offset = "0xD21CC8")]
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
				[Address(RVA = "0x290CAF4", Offset = "0x290CAF4", VA = "0x290CAF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27DDC", Offset = "0xD27DDC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x290CAFC", Offset = "0x290CAFC", VA = "0x290CAFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27DEC", Offset = "0xD27DEC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000021")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x290CB08", Offset = "0x290CB08", VA = "0x290CB08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27DFC", Offset = "0xD27DFC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x290CB14", Offset = "0x290CB14", VA = "0x290CB14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E0C", Offset = "0xD27E0C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public bool initiated
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x290CB20", Offset = "0x290CB20", VA = "0x290CB20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E1C", Offset = "0xD27E1C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x290CB28", Offset = "0x290CB28", VA = "0x290CB28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E2C", Offset = "0xD27E2C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public float heightFromGround
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x290CB34", Offset = "0x290CB34", VA = "0x290CB34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E3C", Offset = "0xD27E3C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x290CB3C", Offset = "0x290CB3C", VA = "0x290CB3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E4C", Offset = "0xD27E4C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x290CB44", Offset = "0x290CB44", VA = "0x290CB44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E5C", Offset = "0xD27E5C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x290CB50", Offset = "0x290CB50", VA = "0x290CB50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E6C", Offset = "0xD27E6C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public Transform transform
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x290CB5C", Offset = "0x290CB5C", VA = "0x290CB5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E7C", Offset = "0xD27E7C")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x290CB64", Offset = "0x290CB64", VA = "0x290CB64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E8C", Offset = "0xD27E8C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public float IKOffset
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x290CB6C", Offset = "0x290CB6C", VA = "0x290CB6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27E9C", Offset = "0xD27E9C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x290CB74", Offset = "0x290CB74", VA = "0x290CB74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27EAC", Offset = "0xD27EAC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x290CB7C", Offset = "0x290CB7C", VA = "0x290CB7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27EBC", Offset = "0xD27EBC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x290CB94", Offset = "0x290CB94", VA = "0x290CB94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27ECC", Offset = "0xD27ECC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x290CBB4", Offset = "0x290CBB4", VA = "0x290CBB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27EDC", Offset = "0xD27EDC")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x290CBCC", Offset = "0x290CBCC", VA = "0x290CBCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27EEC", Offset = "0xD27EEC")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x290CBEC", Offset = "0x290CBEC", VA = "0x290CBEC")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002A")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x290DDD0", Offset = "0x290DDD0", VA = "0x290DDD0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002B")]
			private float rootYOffset
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x290DF34", Offset = "0x290DF34", VA = "0x290DF34")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x290CC34", Offset = "0x290CC34", VA = "0x290CC34")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x290CC48", Offset = "0x290CC48", VA = "0x290CC48")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x290CCD8", Offset = "0x290CCD8", VA = "0x290CCD8")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x290CD24", Offset = "0x290CD24", VA = "0x290CD24")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x290CD94", Offset = "0x290CD94", VA = "0x290CD94")]
			public void Process()
			{
			}

			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x290DA44", Offset = "0x290DA44", VA = "0x290DA44")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x290D5E0", Offset = "0x290D5E0", VA = "0x290D5E0")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x290DE64", Offset = "0x290DE64", VA = "0x290DE64")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x290D880", Offset = "0x290D880", VA = "0x290D880")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x290D90C", Offset = "0x290D90C", VA = "0x290D90C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x290DED4", Offset = "0x290DED4", VA = "0x290DED4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x290DDF8", Offset = "0x290DDF8", VA = "0x290DDF8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x290DFC8", Offset = "0x290DFC8", VA = "0x290DFC8")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x290E054", Offset = "0x290E054", VA = "0x290E054")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21CD8", Offset = "0xD21CD8")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21CE8", Offset = "0xD21CE8")]
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
				[Address(RVA = "0x290E098", Offset = "0x290E098", VA = "0x290E098")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27EFC", Offset = "0xD27EFC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x290E0A4", Offset = "0x290E0A4", VA = "0x290E0A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27F0C", Offset = "0xD27F0C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public float heightOffset
			{
				[Token(Token = "0x60001F7")]
				[Address(RVA = "0x290E0B0", Offset = "0x290E0B0", VA = "0x290E0B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27F1C", Offset = "0xD27F1C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0x290E0B8", Offset = "0x290E0B8", VA = "0x290E0B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27F2C", Offset = "0xD27F2C")]
				private set
				{
				}
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x290E0C0", Offset = "0x290E0C0", VA = "0x290E0C0")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x290E150", Offset = "0x290E150", VA = "0x290E150")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x290E0F0", Offset = "0x290E0F0", VA = "0x290E0F0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x290E1BC", Offset = "0x290E1BC", VA = "0x290E1BC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x290E35C", Offset = "0x290E35C", VA = "0x290E35C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2179C", Offset = "0xD2179C")]
		public LayerMask layers;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD217D4", Offset = "0xD217D4")]
		public float maxStep;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2180C", Offset = "0xD2180C")]
		public float heightOffset;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21844", Offset = "0xD21844")]
		public float footSpeed;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2187C", Offset = "0xD2187C")]
		public float footRadius;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD218B4", Offset = "0xD218B4")]
		public float footCenterOffset;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21900", Offset = "0xD21900")]
		public float prediction;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21938", Offset = "0xD21938")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21938", Offset = "0xD21938")]
		public float footRotationWeight;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2198C", Offset = "0xD2198C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD219C4", Offset = "0xD219C4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD219C4", Offset = "0xD219C4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21A1C", Offset = "0xD21A1C")]
		public bool rotateSolver;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21A54", Offset = "0xD21A54")]
		public float pelvisSpeed;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21A8C", Offset = "0xD21A8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD21A8C", Offset = "0xD21A8C")]
		public float pelvisDamper;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21AE0", Offset = "0xD21AE0")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21B18", Offset = "0xD21B18")]
		public float liftPelvisWeight;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21B50", Offset = "0xD21B50")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21B88", Offset = "0xD21B88")]
		public bool overstepFallsDown;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21BC0", Offset = "0xD21BC0")]
		public Quality quality;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21BF8", Offset = "0xD21BF8")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C08", Offset = "0xD21C08")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C18", Offset = "0xD21C18")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C28", Offset = "0xD21C28")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD21C38", Offset = "0xD21C38")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000018")]
		public Leg[] legs
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2D4789C", Offset = "0x2D4789C", VA = "0x2D4789C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D3C", Offset = "0xD27D3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x2D478A4", Offset = "0x2D478A4", VA = "0x2D478A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D4C", Offset = "0xD27D4C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x2D478AC", Offset = "0x2D478AC", VA = "0x2D478AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D5C", Offset = "0xD27D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2D478B4", Offset = "0x2D478B4", VA = "0x2D478B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D6C", Offset = "0xD27D6C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2D478BC", Offset = "0x2D478BC", VA = "0x2D478BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D7C", Offset = "0xD27D7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2D478C4", Offset = "0x2D478C4", VA = "0x2D478C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D8C", Offset = "0xD27D8C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Transform root
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2D478D0", Offset = "0x2D478D0", VA = "0x2D478D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27D9C", Offset = "0xD27D9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2D478D8", Offset = "0x2D478D8", VA = "0x2D478D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27DAC", Offset = "0xD27DAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2D478E0", Offset = "0x2D478E0", VA = "0x2D478E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27DBC", Offset = "0xD27DBC")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x2D478F8", Offset = "0x2D478F8", VA = "0x2D478F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27DCC", Offset = "0xD27DCC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x2D47918", Offset = "0x2D47918", VA = "0x2D47918")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 up
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2D42748", Offset = "0x2D42748", VA = "0x2D42748")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001F")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x2D47CE4", Offset = "0x2D47CE4", VA = "0x2D47CE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2D4796C", Offset = "0x2D4796C", VA = "0x2D4796C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2D47BB8", Offset = "0x2D47BB8", VA = "0x2D47BB8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2D41CCC", Offset = "0x2D41CCC", VA = "0x2D41CCC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2D42404", Offset = "0x2D42404", VA = "0x2D42404")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2D43F50", Offset = "0x2D43F50", VA = "0x2D43F50")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2D41818", Offset = "0x2D41818", VA = "0x2D41818")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2D47CCC", Offset = "0x2D47CCC", VA = "0x2D47CCC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2D47D64", Offset = "0x2D47D64", VA = "0x2D47D64")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2D47DF4", Offset = "0x2D47DF4", VA = "0x2D47DF4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2D47EB0", Offset = "0x2D47EB0", VA = "0x2D47EB0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2D416F8", Offset = "0x2D416F8", VA = "0x2D416F8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FB50", Offset = "0xD1FB50")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FB50", Offset = "0xD1FB50")]
	public class AimIK : IK
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1F4A1D4", Offset = "0x1F4A1D4", VA = "0x1F4A1D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27F3C", Offset = "0xD27F3C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1F4A21C", Offset = "0x1F4A21C", VA = "0x1F4A21C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27F74", Offset = "0xD27F74")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1F4A264", Offset = "0x1F4A264", VA = "0x1F4A264")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27FAC", Offset = "0xD27FAC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1F4A2AC", Offset = "0x1F4A2AC", VA = "0x1F4A2AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD27FE4", Offset = "0xD27FE4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1F4A2F4", Offset = "0x1F4A2F4", VA = "0x1F4A2F4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2801C", Offset = "0xD2801C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1F4A33C", Offset = "0x1F4A33C", VA = "0x1F4A33C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1F4A344", Offset = "0x1F4A344", VA = "0x1F4A344")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FBB0", Offset = "0xD1FBB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FBB0", Offset = "0xD1FBB0")]
	public class ArmIK : IK
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1F4A6CC", Offset = "0x1F4A6CC", VA = "0x1F4A6CC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28054", Offset = "0xD28054")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1F4A714", Offset = "0x1F4A714", VA = "0x1F4A714", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2808C", Offset = "0xD2808C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1F4A75C", Offset = "0x1F4A75C", VA = "0x1F4A75C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD280C4", Offset = "0xD280C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1F4A7A4", Offset = "0x1F4A7A4", VA = "0x1F4A7A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD280FC", Offset = "0xD280FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1F4A7EC", Offset = "0x1F4A7EC", VA = "0x1F4A7EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1F4A7F4", Offset = "0x1F4A7F4", VA = "0x1F4A7F4")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FC10", Offset = "0xD1FC10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FC10", Offset = "0xD1FC10")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1F577BC", Offset = "0x1F577BC", VA = "0x1F577BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28134", Offset = "0xD28134")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1F57804", Offset = "0x1F57804", VA = "0x1F57804", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2816C", Offset = "0xD2816C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1F5784C", Offset = "0x1F5784C", VA = "0x1F5784C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD281A4", Offset = "0xD281A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1F57894", Offset = "0x1F57894", VA = "0x1F57894")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD281DC", Offset = "0xD281DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1F578DC", Offset = "0x1F578DC", VA = "0x1F578DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1F578E4", Offset = "0x1F578E4", VA = "0x1F578E4")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FC70", Offset = "0xD1FC70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FC70", Offset = "0xD1FC70")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1F620F4", Offset = "0x1F620F4", VA = "0x1F620F4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28214", Offset = "0xD28214")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1F6213C", Offset = "0x1F6213C", VA = "0x1F6213C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2824C", Offset = "0xD2824C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1F62184", Offset = "0x1F62184", VA = "0x1F62184")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28284", Offset = "0xD28284")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1F621CC", Offset = "0x1F621CC", VA = "0x1F621CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD282BC", Offset = "0xD282BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1F62214", Offset = "0x1F62214", VA = "0x1F62214", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1F6221C", Offset = "0x1F6221C", VA = "0x1F6221C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FCD0", Offset = "0xD1FCD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FCD0", Offset = "0xD1FCD0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2D391D4", Offset = "0x2D391D4", VA = "0x2D391D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD282F4", Offset = "0xD282F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2D3921C", Offset = "0x2D3921C", VA = "0x2D3921C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2832C", Offset = "0xD2832C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2D39264", Offset = "0x2D39264", VA = "0x2D39264")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28364", Offset = "0xD28364")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2D392AC", Offset = "0x2D392AC", VA = "0x2D392AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2839C", Offset = "0xD2839C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2D392F4", Offset = "0x2D392F4", VA = "0x2D392F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2D392FC", Offset = "0x2D392FC", VA = "0x2D392FC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FD30", Offset = "0xD1FD30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FD30", Offset = "0xD1FD30")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2D3FEB4", Offset = "0x2D3FEB4", VA = "0x2D3FEB4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD283D4", Offset = "0xD283D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2D3FEFC", Offset = "0x2D3FEFC", VA = "0x2D3FEFC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2840C", Offset = "0xD2840C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2D3FF44", Offset = "0x2D3FF44", VA = "0x2D3FF44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28444", Offset = "0xD28444")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2D3FF8C", Offset = "0x2D3FF8C", VA = "0x2D3FF8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2847C", Offset = "0xD2847C")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2D3FFD4", Offset = "0x2D3FFD4", VA = "0x2D3FFD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD284B4", Offset = "0xD284B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2D4001C", Offset = "0x2D4001C", VA = "0x2D4001C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD284EC", Offset = "0xD284EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2D40064", Offset = "0x2D40064", VA = "0x2D40064")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2D400A8", Offset = "0x2D400A8", VA = "0x2D400A8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2D400B0", Offset = "0x2D400B0", VA = "0x2D400B0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2D40298", Offset = "0x2D40298", VA = "0x2D40298")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2D40538", Offset = "0x2D40538", VA = "0x2D40538")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28524", Offset = "0xD28524")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2D40558", Offset = "0x2D40558", VA = "0x2D40558")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2855C", Offset = "0xD2855C")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2D40648", Offset = "0x2D40648", VA = "0x2D40648")]
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
		[Address(RVA = "0x316E0C0", Offset = "0x316E0C0", VA = "0x316E0C0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x316E1B4", Offset = "0x316E1B4", VA = "0x316E1B4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x316E3AC", Offset = "0x316E3AC", VA = "0x316E3AC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600022E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600022F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x316E40C", Offset = "0x316E40C", VA = "0x316E40C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21CF8", Offset = "0xD21CF8")]
		public IK[] IKComponents;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21D30", Offset = "0xD21D30")]
		public Animator animator;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700002E")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x3170A8C", Offset = "0x3170A8C", VA = "0x3170A8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3170B24", Offset = "0x3170B24", VA = "0x3170B24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3170B94", Offset = "0x3170B94", VA = "0x3170B94")]
		private void Update()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3170C50", Offset = "0x3170C50", VA = "0x3170C50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3170C8C", Offset = "0x3170C8C", VA = "0x3170C8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3170BC8", Offset = "0x3170BC8", VA = "0x3170BC8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3170D18", Offset = "0x3170D18", VA = "0x3170D18")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FD90", Offset = "0xD1FD90")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FD90", Offset = "0xD1FD90")]
	public class LegIK : IK
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2CABF0C", Offset = "0x2CABF0C", VA = "0x2CABF0C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28594", Offset = "0xD28594")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2CABF54", Offset = "0x2CABF54", VA = "0x2CABF54", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD285CC", Offset = "0xD285CC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x2CABF9C", Offset = "0x2CABF9C", VA = "0x2CABF9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28604", Offset = "0xD28604")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x2CABFE4", Offset = "0x2CABFE4", VA = "0x2CABFE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2863C", Offset = "0xD2863C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x2CAC02C", Offset = "0x2CAC02C", VA = "0x2CAC02C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x2CAC034", Offset = "0x2CAC034", VA = "0x2CAC034")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FDF0", Offset = "0xD1FDF0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FDF0", Offset = "0xD1FDF0")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x2CAC0A4", Offset = "0x2CAC0A4", VA = "0x2CAC0A4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28674", Offset = "0xD28674")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x2CAC0EC", Offset = "0x2CAC0EC", VA = "0x2CAC0EC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD286AC", Offset = "0xD286AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x2CAC134", Offset = "0x2CAC134", VA = "0x2CAC134")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD286E4", Offset = "0xD286E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x2CAC17C", Offset = "0x2CAC17C", VA = "0x2CAC17C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2871C", Offset = "0xD2871C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x2CAC1C4", Offset = "0x2CAC1C4", VA = "0x2CAC1C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x2CAC1CC", Offset = "0x2CAC1CC", VA = "0x2CAC1CC")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FE50", Offset = "0xD1FE50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FE50", Offset = "0xD1FE50")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x2CACBD8", Offset = "0x2CACBD8", VA = "0x2CACBD8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28754", Offset = "0xD28754")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2CACC20", Offset = "0x2CACC20", VA = "0x2CACC20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2878C", Offset = "0xD2878C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2CACC68", Offset = "0x2CACC68", VA = "0x2CACC68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD287C4", Offset = "0xD287C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2CACCB0", Offset = "0x2CACCB0", VA = "0x2CACCB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD287FC", Offset = "0xD287FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2CACCF8", Offset = "0x2CACCF8", VA = "0x2CACCF8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2CACD00", Offset = "0x2CACD00", VA = "0x2CACD00")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FEB0", Offset = "0xD1FEB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FEB0", Offset = "0xD1FEB0")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2CB5BD8", Offset = "0x2CB5BD8", VA = "0x2CB5BD8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28834", Offset = "0xD28834")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2CB5C20", Offset = "0x2CB5C20", VA = "0x2CB5C20", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2886C", Offset = "0xD2886C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2CB5C68", Offset = "0x2CB5C68", VA = "0x2CB5C68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD288A4", Offset = "0xD288A4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x2CB5CB0", Offset = "0x2CB5CB0", VA = "0x2CB5CB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD288DC", Offset = "0xD288DC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x2CB5CF8", Offset = "0x2CB5CF8", VA = "0x2CB5CF8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x2CB5D00", Offset = "0x2CB5D00", VA = "0x2CB5D00")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FF10", Offset = "0xD1FF10")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21E14", Offset = "0xD21E14")]
			public Transform chest;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21E4C", Offset = "0xD21E4C")]
			public Transform neck;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21E84", Offset = "0xD21E84")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21EBC", Offset = "0xD21EBC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21EF4", Offset = "0xD21EF4")]
			public Transform leftThigh;

			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21F2C", Offset = "0xD21F2C")]
			public Transform leftCalf;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21F64", Offset = "0xD21F64")]
			public Transform leftFoot;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21F9C", Offset = "0xD21F9C")]
			public Transform leftToes;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21FD4", Offset = "0xD21FD4")]
			public Transform rightThigh;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2200C", Offset = "0xD2200C")]
			public Transform rightCalf;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22044", Offset = "0xD22044")]
			public Transform rightFoot;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2207C", Offset = "0xD2207C")]
			public Transform rightToes;

			[Token(Token = "0x1700002F")]
			public bool isFilled
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x3203E84", Offset = "0x3203E84", VA = "0x3203E84")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000030")]
			public bool isEmpty
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x32042FC", Offset = "0x32042FC", VA = "0x32042FC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000259")]
			[Address(RVA = "0x3203934", Offset = "0x3203934", VA = "0x3203934")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x3204774", Offset = "0x3204774", VA = "0x3204774")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x3204C20", Offset = "0x3204C20", VA = "0x3204C20")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21D68", Offset = "0xD21D68")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xD21D68", Offset = "0xD21D68")]
		public References references;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD21DDC", Offset = "0xD21DDC")]
		public IKSolverVR solver;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x2CB7AFC", Offset = "0x2CB7AFC", VA = "0x2CB7AFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28914", Offset = "0xD28914")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x2CB7B44", Offset = "0x2CB7B44", VA = "0x2CB7B44", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2894C", Offset = "0xD2894C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2CB7B8C", Offset = "0x2CB7B8C", VA = "0x2CB7B8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28984", Offset = "0xD28984")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2CB7BD4", Offset = "0x2CB7BD4", VA = "0x2CB7BD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD289BC", Offset = "0xD289BC")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2CB7C00", Offset = "0x2CB7C00", VA = "0x2CB7C00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD289F4", Offset = "0xD289F4")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2CB7C28", Offset = "0x2CB7C28", VA = "0x2CB7C28", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2CB7C30", Offset = "0x2CB7C30", VA = "0x2CB7C30", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2CB7CB0", Offset = "0x2CB7CB0", VA = "0x2CB7CB0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2CB7E1C", Offset = "0x2CB7E1C", VA = "0x2CB7E1C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD220B4", Offset = "0xD220B4")]
		public float pull;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD220CC", Offset = "0xD220CC")]
		public float pin;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2D38CFC", Offset = "0x2D38CFC", VA = "0x2D38CFC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2D38DD8", Offset = "0x2D38DD8", VA = "0x2D38DD8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2D38DF8", Offset = "0x2D38DF8", VA = "0x2D38DF8")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2D3906C", Offset = "0x2D3906C", VA = "0x2D3906C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2D38ECC", Offset = "0x2D38ECC", VA = "0x2D38ECC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2D39164", Offset = "0x2D39164", VA = "0x2D39164")]
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
		[Address(RVA = "0x2D3936C", Offset = "0x2D3936C", VA = "0x2D3936C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2D397E4", Offset = "0x2D397E4", VA = "0x2D397E4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2D399A0", Offset = "0x2D399A0", VA = "0x2D399A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2D39AD0", Offset = "0x2D39AD0", VA = "0x2D39AD0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22724", Offset = "0xD22724")]
			public Transform transform;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2275C", Offset = "0xD2275C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD2275C", Offset = "0xD2275C")]
			public float weight;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x290C01C", Offset = "0x290C01C", VA = "0x290C01C")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x290C058", Offset = "0x290C058", VA = "0x290C058")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x290C0BC", Offset = "0x290C0BC", VA = "0x290C0BC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x290C0F4", Offset = "0x290C0F4", VA = "0x290C0F4")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD220E4", Offset = "0xD220E4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2211C", Offset = "0xD2211C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xD2211C", Offset = "0xD2211C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD2211C", Offset = "0xD2211C")]
		public float positionWeight;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22194", Offset = "0xD22194")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22194", Offset = "0xD22194")]
		public float bodyWeight;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD221E8", Offset = "0xD221E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD221E8", Offset = "0xD221E8")]
		public float thighWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2223C", Offset = "0xD2223C")]
		public bool handsPullBody;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xD22274", Offset = "0xD22274")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22274", Offset = "0xD22274")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22274", Offset = "0xD22274")]
		public float rotationWeight;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD222EC", Offset = "0xD222EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD222EC", Offset = "0xD222EC")]
		public float bodyClampWeight;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22340", Offset = "0xD22340")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22340", Offset = "0xD22340")]
		public float headClampWeight;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22394", Offset = "0xD22394")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22394", Offset = "0xD22394")]
		public float bendWeight;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD223E8", Offset = "0xD223E8")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xD22420", Offset = "0xD22420")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22420", Offset = "0xD22420")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22420", Offset = "0xD22420")]
		public float CCDWeight;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22498", Offset = "0xD22498")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22498", Offset = "0xD22498")]
		public float roll;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD224EC", Offset = "0xD224EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD224EC", Offset = "0xD224EC")]
		public float damper;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22544", Offset = "0xD22544")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xD2257C", Offset = "0xD2257C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2257C", Offset = "0xD2257C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD2257C", Offset = "0xD2257C")]
		public float postStretchWeight;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD225F4", Offset = "0xD225F4")]
		public float maxStretch;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2262C", Offset = "0xD2262C")]
		public float stretchDamper;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22664", Offset = "0xD22664")]
		public bool fixHead;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2269C", Offset = "0xD2269C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xD226D4", Offset = "0xD226D4")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD2270C", Offset = "0xD2270C")]
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
		[Address(RVA = "0x2D39AD8", Offset = "0x2D39AD8", VA = "0x2D39AD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2D39E60", Offset = "0x2D39E60", VA = "0x2D39E60")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2D3A33C", Offset = "0x2D3A33C", VA = "0x2D3A33C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2D3A708", Offset = "0x2D3A708", VA = "0x2D3A708")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2D3AE94", Offset = "0x2D3AE94", VA = "0x2D3AE94")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2D3B174", Offset = "0x2D3B174", VA = "0x2D3B174")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2D3B478", Offset = "0x2D3B478", VA = "0x2D3B478")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2D3BC4C", Offset = "0x2D3BC4C", VA = "0x2D3BC4C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2D3AC78", Offset = "0x2D3AC78", VA = "0x2D3AC78")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2D3BE14", Offset = "0x2D3BE14", VA = "0x2D3BE14")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2D3BB64", Offset = "0x2D3BB64", VA = "0x2D3BB64")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2D3BA98", Offset = "0x2D3BA98", VA = "0x2D3BA98")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2D3C098", Offset = "0x2D3C098", VA = "0x2D3C098")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2D3C3CC", Offset = "0x2D3C3CC", VA = "0x2D3C3CC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD22848", Offset = "0xD22848")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD22858", Offset = "0xD22858")]
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
				[Address(RVA = "0x290C11C", Offset = "0x290C11C", VA = "0x290C11C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A2C", Offset = "0xD28A2C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x290C124", Offset = "0x290C124", VA = "0x290C124")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A3C", Offset = "0xD28A3C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public bool isRigid
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0x290C12C", Offset = "0x290C12C", VA = "0x290C12C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A4C", Offset = "0xD28A4C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000291")]
				[Address(RVA = "0x290C134", Offset = "0x290C134", VA = "0x290C134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A5C", Offset = "0xD28A5C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000292")]
			[Address(RVA = "0x290C140", Offset = "0x290C140", VA = "0x290C140")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0x290C1A8", Offset = "0x290C1A8", VA = "0x290C1A8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x290C200", Offset = "0x290C200", VA = "0x290C200")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x290C3A4", Offset = "0x290C3A4", VA = "0x290C3A4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD227B0", Offset = "0xD227B0")]
		public float pin;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD227C8", Offset = "0xD227C8")]
		public float pull;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD227E0", Offset = "0xD227E0")]
		public float push;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD227F8", Offset = "0xD227F8")]
		public float pushParent;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22810", Offset = "0xD22810")]
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
		[Address(RVA = "0x2D3C5B4", Offset = "0x2D3C5B4", VA = "0x2D3C5B4")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2D3C6D0", Offset = "0x2D3C6D0", VA = "0x2D3C6D0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2D3C840", Offset = "0x2D3C840", VA = "0x2D3C840")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2D3C97C", Offset = "0x2D3C97C", VA = "0x2D3C97C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x2D3CA54", Offset = "0x2D3CA54", VA = "0x2D3CA54")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x2D3CB78", Offset = "0x2D3CB78", VA = "0x2D3CB78")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2D3D248", Offset = "0x2D3D248", VA = "0x2D3D248")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2D3CD14", Offset = "0x2D3CD14", VA = "0x2D3CD14")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x2D3D638", Offset = "0x2D3D638", VA = "0x2D3D638")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x2D3D898", Offset = "0x2D3D898", VA = "0x2D3D898")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2D3DB04", Offset = "0x2D3DB04", VA = "0x2D3DB04")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2D3DEA8", Offset = "0x2D3DEA8", VA = "0x2D3DEA8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x2D3E33C", Offset = "0x2D3E33C", VA = "0x2D3E33C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x2D3E560", Offset = "0x2D3E560", VA = "0x2D3E560")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x2D3E2CC", Offset = "0x2D3E2CC", VA = "0x2D3E2CC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x2D3DD34", Offset = "0x2D3DD34", VA = "0x2D3DD34")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x2D3E250", Offset = "0x2D3E250", VA = "0x2D3E250")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x2D3E648", Offset = "0x2D3E648", VA = "0x2D3E648")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x2D3E170", Offset = "0x2D3E170", VA = "0x2D3E170")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x2D3E448", Offset = "0x2D3E448", VA = "0x2D3E448")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22868", Offset = "0xD22868")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD22880", Offset = "0xD22880")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000033")]
		public bool initiated
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x316E5FC", Offset = "0x316E5FC", VA = "0x316E5FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A6C", Offset = "0xD28A6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x316E604", Offset = "0x316E604", VA = "0x316E604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A7C", Offset = "0xD28A7C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x316E414", Offset = "0x316E414", VA = "0x316E414")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x316E610", Offset = "0x316E610", VA = "0x316E610")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x316E650", Offset = "0x316E650", VA = "0x316E650")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x316E6B8", Offset = "0x316E6B8", VA = "0x316E6B8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x316E708", Offset = "0x316E708", VA = "0x316E708")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x316EA80", Offset = "0x316EA80", VA = "0x316EA80")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x316EC70", Offset = "0x316EC70", VA = "0x316EC70")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x316EFBC", Offset = "0x316EFBC", VA = "0x316EFBC")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x316E940", Offset = "0x316E940", VA = "0x316E940")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x316E9E0", Offset = "0x316E9E0", VA = "0x316E9E0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22890", Offset = "0xD22890")]
		public float positionWeight;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD228A8", Offset = "0xD228A8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD228C0", Offset = "0xD228C0")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD228D0", Offset = "0xD228D0")]
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
			[Address(RVA = "0x316F49C", Offset = "0x316F49C", VA = "0x316F49C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A8C", Offset = "0xD28A8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x316F4A4", Offset = "0x316F4A4", VA = "0x316F4A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28A9C", Offset = "0xD28A9C")]
			private set
			{
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x316F434", Offset = "0x316F434", VA = "0x316F434")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x316F4B0", Offset = "0x316F4B0", VA = "0x316F4B0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x316F540", Offset = "0x316F540", VA = "0x316F540")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x316F684", Offset = "0x316F684", VA = "0x316F684")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x316F804", Offset = "0x316F804", VA = "0x316F804")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x316FB2C", Offset = "0x316FB2C", VA = "0x316FB2C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x316FDE4", Offset = "0x316FDE4", VA = "0x316FDE4")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x316FEB0", Offset = "0x316FEB0", VA = "0x316FEB0")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x316FF58", Offset = "0x316FF58", VA = "0x316FF58")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x3170480", Offset = "0x3170480", VA = "0x3170480")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x31704AC", Offset = "0x31704AC", VA = "0x31704AC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x3170600", Offset = "0x3170600", VA = "0x3170600")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x3170878", Offset = "0x3170878", VA = "0x3170878")]
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
				[Address(RVA = "0x290F700", Offset = "0x290F700", VA = "0x290F700")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000036")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002BA")]
				[Address(RVA = "0x290F7DC", Offset = "0x290F7DC", VA = "0x290F7DC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000037")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002CE")]
				[Address(RVA = "0x290FBAC", Offset = "0x290FBAC", VA = "0x290FBAC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x290F6B0", Offset = "0x290F6B0", VA = "0x290F6B0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x290F73C", Offset = "0x290F73C", VA = "0x290F73C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x290F78C", Offset = "0x290F78C", VA = "0x290F78C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x290F7EC", Offset = "0x290F7EC", VA = "0x290F7EC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x290F874", Offset = "0x290F874", VA = "0x290F874")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x290F87C", Offset = "0x290F87C", VA = "0x290F87C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x290F954", Offset = "0x290F954", VA = "0x290F954")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x290F9CC", Offset = "0x290F9CC", VA = "0x290F9CC")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x290FA90", Offset = "0x290FA90", VA = "0x290FA90")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x290FCEC", Offset = "0x290FCEC", VA = "0x290FCEC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x290FD24", Offset = "0x290FD24", VA = "0x290FD24")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x290FD5C", Offset = "0x290FD5C", VA = "0x290FD5C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x290FD84", Offset = "0x290FD84", VA = "0x290FD84")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x290FE70", Offset = "0x290FE70", VA = "0x290FE70")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x290FFFC", Offset = "0x290FFFC", VA = "0x290FFFC")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x291002C", Offset = "0x291002C", VA = "0x291002C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x29100F4", Offset = "0x29100F4", VA = "0x29100F4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x2910164", Offset = "0x2910164", VA = "0x2910164")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x29102B4", Offset = "0x29102B4", VA = "0x29102B4")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x2910404", Offset = "0x2910404", VA = "0x2910404")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x2910484", Offset = "0x2910484", VA = "0x2910484")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x290FEEC", Offset = "0x290FEEC", VA = "0x290FEEC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x29105BC", Offset = "0x29105BC", VA = "0x29105BC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x3170D20", Offset = "0x3170D20", VA = "0x3170D20", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x3170D28", Offset = "0x3170D28", VA = "0x3170D28", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x3170D2C", Offset = "0x3170D2C", VA = "0x3170D2C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x3170E7C", Offset = "0x3170E7C", VA = "0x3170E7C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x3170EEC", Offset = "0x3170EEC", VA = "0x3170EEC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD228E8", Offset = "0xD228E8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x3170EF4", Offset = "0x3170EF4", VA = "0x3170EF4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x3170FA8", Offset = "0x3170FA8", VA = "0x3170FA8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x3171020", Offset = "0x3171020", VA = "0x3171020")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x31710B4", Offset = "0x31710B4", VA = "0x31710B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x31710D0", Offset = "0x31710D0", VA = "0x31710D0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x31710F0", Offset = "0x31710F0", VA = "0x31710F0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x3171188", Offset = "0x3171188", VA = "0x3171188")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x31711A4", Offset = "0x31711A4", VA = "0x31711A4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22900", Offset = "0xD22900")]
		public float maintainRotationWeight;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22918", Offset = "0xD22918")]
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
		[Address(RVA = "0x31711CC", Offset = "0x31711CC", VA = "0x31711CC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x3171250", Offset = "0x3171250", VA = "0x3171250")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x317132C", Offset = "0x317132C", VA = "0x317132C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x3171550", Offset = "0x3171550", VA = "0x3171550")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x3171644", Offset = "0x3171644", VA = "0x3171644")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x3171770", Offset = "0x3171770", VA = "0x3171770")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x31717D4", Offset = "0x31717D4", VA = "0x31717D4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x3171888", Offset = "0x3171888", VA = "0x3171888")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x317194C", Offset = "0x317194C", VA = "0x317194C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x3171BE4", Offset = "0x3171BE4", VA = "0x3171BE4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x3171C58", Offset = "0x3171C58", VA = "0x3171C58")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22930", Offset = "0xD22930")]
		public int iterations;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22948", Offset = "0xD22948")]
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
		[Address(RVA = "0x3171DD4", Offset = "0x3171DD4", VA = "0x3171DD4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x3172140", Offset = "0x3172140", VA = "0x3172140")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x3172260", Offset = "0x3172260", VA = "0x3172260")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x31723C0", Offset = "0x31723C0", VA = "0x31723C0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x3172440", Offset = "0x3172440", VA = "0x3172440")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x31724AC", Offset = "0x31724AC", VA = "0x31724AC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x3172530", Offset = "0x3172530", VA = "0x3172530", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x3172B74", Offset = "0x3172B74", VA = "0x3172B74")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x3172BAC", Offset = "0x3172BAC", VA = "0x3172BAC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x3172E30", Offset = "0x3172E30", VA = "0x3172E30")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x3173130", Offset = "0x3173130", VA = "0x3173130")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x317321C", Offset = "0x317321C", VA = "0x317321C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x31732E4", Offset = "0x31732E4", VA = "0x31732E4")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22A1C", Offset = "0xD22A1C")]
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
			[Address(RVA = "0x2911108", Offset = "0x2911108", VA = "0x2911108")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x2911158", Offset = "0x2911158", VA = "0x2911158")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x29111F8", Offset = "0x29111F8", VA = "0x29111F8")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x2911230", Offset = "0x2911230", VA = "0x2911230")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x2911268", Offset = "0x2911268", VA = "0x2911268")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x29112B8", Offset = "0x29112B8", VA = "0x29112B8")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x2910CBC", Offset = "0x2910CBC", VA = "0x2910CBC")]
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
				[Address(RVA = "0x29105D8", Offset = "0x29105D8", VA = "0x29105D8")]
				get
				{
					return null;
				}
				[Token(Token = "0x600030E")]
				[Address(RVA = "0x29106DC", Offset = "0x29106DC", VA = "0x29106DC")]
				set
				{
				}
			}

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x291076C", Offset = "0x291076C", VA = "0x291076C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x291091C", Offset = "0x291091C", VA = "0x291091C")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x2910AF0", Offset = "0x2910AF0", VA = "0x2910AF0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x2910C50", Offset = "0x2910C50", VA = "0x2910C50")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x2910C78", Offset = "0x2910C78", VA = "0x2910C78")]
			public Bone()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x2910CF8", Offset = "0x2910CF8", VA = "0x2910CF8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2910D50", Offset = "0x2910D50", VA = "0x2910D50")]
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
			[Address(RVA = "0x2911090", Offset = "0x2911090", VA = "0x2911090")]
			public Node()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2911094", Offset = "0x2911094", VA = "0x2911094")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x29110C4", Offset = "0x29110C4", VA = "0x29110C4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22980", Offset = "0xD22980")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22980", Offset = "0xD22980")]
		public float IKPositionWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD229D4", Offset = "0xD229D4")]
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
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000038")]
		public bool initiated
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x3173614", Offset = "0x3173614", VA = "0x3173614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28AAC", Offset = "0xD28AAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x317361C", Offset = "0x317361C", VA = "0x317361C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28ABC", Offset = "0xD28ABC")]
			private set
			{
			}
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x3173544", Offset = "0x3173544", VA = "0x3173544")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x316E224", Offset = "0x316E224", VA = "0x316E224")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x316E144", Offset = "0x316E144", VA = "0x316E144")]
		public void Update()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x31735BC", Offset = "0x31735BC", VA = "0x31735BC", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x31735C8", Offset = "0x31735C8", VA = "0x31735C8")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x31735D4", Offset = "0x31735D4", VA = "0x31735D4")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x31735DC", Offset = "0x31735DC", VA = "0x31735DC")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x317360C", Offset = "0x317360C", VA = "0x317360C")]
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
		[Address(RVA = "0x3173628", Offset = "0x3173628", VA = "0x3173628")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x3173640", Offset = "0x3173640", VA = "0x3173640")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x3173778", Offset = "0x3173778", VA = "0x3173778")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x3173824", Offset = "0x3173824", VA = "0x3173824")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x3173AAC", Offset = "0x3173AAC", VA = "0x3173AAC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22A34", Offset = "0xD22A34")]
		public float poleWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22A4C", Offset = "0xD22A4C")]
		public float clampWeight;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22A64", Offset = "0xD22A64")]
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
			[Address(RVA = "0x3173B40", Offset = "0x3173B40", VA = "0x3173B40")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003B")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x3173B7C", Offset = "0x3173B7C", VA = "0x3173B7C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003C")]
		protected override int minBones
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x317462C", Offset = "0x317462C", VA = "0x317462C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003D")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x3174A10", Offset = "0x3174A10", VA = "0x3174A10", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x3173AC4", Offset = "0x3173AC4", VA = "0x3173AC4")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x3173BB8", Offset = "0x3173BB8", VA = "0x3173BB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x3173DD8", Offset = "0x3173DD8", VA = "0x3173DD8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x3174578", Offset = "0x3174578", VA = "0x3174578")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x3174308", Offset = "0x3174308", VA = "0x3174308")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x3174634", Offset = "0x3174634", VA = "0x3174634")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x3174A84", Offset = "0x3174A84", VA = "0x3174A84")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22A7C", Offset = "0xD22A7C")]
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
		[Address(RVA = "0x3174B58", Offset = "0x3174B58", VA = "0x3174B58", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x3174F40", Offset = "0x3174F40", VA = "0x3174F40")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x3174FF4", Offset = "0x3174FF4", VA = "0x3174FF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x3175188", Offset = "0x3175188", VA = "0x3175188", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x317531C", Offset = "0x317531C", VA = "0x317531C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x3175378", Offset = "0x3175378", VA = "0x3175378", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x31753E8", Offset = "0x31753E8", VA = "0x31753E8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x3175758", Offset = "0x3175758", VA = "0x3175758", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x3175784", Offset = "0x3175784", VA = "0x3175784")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x317544C", Offset = "0x317544C", VA = "0x317544C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x31757F4", Offset = "0x31757F4", VA = "0x31757F4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x3175980", Offset = "0x3175980", VA = "0x3175980")]
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
		[Address(RVA = "0x3175B44", Offset = "0x3175B44", VA = "0x3175B44")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x3175BF4", Offset = "0x3175BF4", VA = "0x3175BF4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x31760EC", Offset = "0x31760EC", VA = "0x31760EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x31766E4", Offset = "0x31766E4", VA = "0x31766E4")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x3176CC0", Offset = "0x3176CC0", VA = "0x3176CC0")]
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
			[Address(RVA = "0x3177C10", Offset = "0x3177C10", VA = "0x3177C10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x3176CC4", Offset = "0x3176CC4", VA = "0x3176CC4")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x3177288", Offset = "0x3177288", VA = "0x3177288")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x31773C8", Offset = "0x31773C8", VA = "0x31773C8", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x317745C", Offset = "0x317745C", VA = "0x317745C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x3177950", Offset = "0x3177950", VA = "0x3177950", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x3177C18", Offset = "0x3177C18", VA = "0x3177C18")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x3176DA0", Offset = "0x3176DA0", VA = "0x3176DA0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x3177374", Offset = "0x3177374", VA = "0x3177374")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x3177BB4", Offset = "0x3177BB4", VA = "0x3177BB4")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x31770FC", Offset = "0x31770FC", VA = "0x31770FC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x3178268", Offset = "0x3178268", VA = "0x3178268")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x31782DC", Offset = "0x31782DC", VA = "0x31782DC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x31783A4", Offset = "0x31783A4", VA = "0x31783A4")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x3178454", Offset = "0x3178454", VA = "0x3178454")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x3177700", Offset = "0x3177700", VA = "0x3177700")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x3177828", Offset = "0x3177828", VA = "0x3177828")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x3178558", Offset = "0x3178558", VA = "0x3178558")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3177E38", Offset = "0x3177E38", VA = "0x3177E38")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x3177364", Offset = "0x3177364", VA = "0x3177364")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x3178AE8", Offset = "0x3178AE8", VA = "0x3178AE8")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x317869C", Offset = "0x317869C", VA = "0x317869C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x3177C94", Offset = "0x3177C94", VA = "0x3177C94")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x3177D74", Offset = "0x3177D74", VA = "0x3177D74")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x3178BB4", Offset = "0x3178BB4", VA = "0x3178BB4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22A94", Offset = "0xD22A94")]
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
		[Address(RVA = "0x3178C48", Offset = "0x3178C48", VA = "0x3178C48", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x31792D4", Offset = "0x31792D4", VA = "0x31792D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x317936C", Offset = "0x317936C", VA = "0x317936C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x317940C", Offset = "0x317940C", VA = "0x317940C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x3179518", Offset = "0x3179518", VA = "0x3179518")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x31795B4", Offset = "0x31795B4", VA = "0x31795B4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x31799E4", Offset = "0x31799E4", VA = "0x31799E4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x3179BF4", Offset = "0x3179BF4", VA = "0x3179BF4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x3179A90", Offset = "0x3179A90", VA = "0x3179A90")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x31797A0", Offset = "0x31797A0", VA = "0x31797A0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x3179C8C", Offset = "0x3179C8C", VA = "0x3179C8C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22AAC", Offset = "0xD22AAC")]
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
		[Address(RVA = "0x3179D0C", Offset = "0x3179D0C", VA = "0x3179D0C")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x3179DFC", Offset = "0x3179DFC", VA = "0x3179DFC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x3179E58", Offset = "0x3179E58", VA = "0x3179E58")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x316F3D8", Offset = "0x316F3D8", VA = "0x316F3D8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x316E8C0", Offset = "0x316E8C0", VA = "0x316E8C0")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x3179F88", Offset = "0x3179F88", VA = "0x3179F88", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x317A134", Offset = "0x317A134", VA = "0x317A134", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x317A2A4", Offset = "0x317A2A4", VA = "0x317A2A4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x317A4B0", Offset = "0x317A4B0", VA = "0x317A4B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x317A588", Offset = "0x317A588", VA = "0x317A588", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x317A668", Offset = "0x317A668", VA = "0x317A668", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x317A7D8", Offset = "0x317A7D8", VA = "0x317A7D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x317A938", Offset = "0x317A938", VA = "0x317A938", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x317AB78", Offset = "0x317AB78", VA = "0x317AB78", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x317AE44", Offset = "0x317AE44", VA = "0x317AE44", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x317AE88", Offset = "0x317AE88", VA = "0x317AE88", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x317AF6C", Offset = "0x317AF6C", VA = "0x317AF6C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22AC4", Offset = "0xD22AC4")]
		public float spineStiffness;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22ADC", Offset = "0xD22ADC")]
		public float pullBodyVertical;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22AF4", Offset = "0xD22AF4")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD22B0C", Offset = "0xD22B0C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700003F")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x317B0B4", Offset = "0x317B0B4", VA = "0x317B0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x317B1FC", Offset = "0x317B1FC", VA = "0x317B1FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x317B204", Offset = "0x317B204", VA = "0x317B204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x317B20C", Offset = "0x317B20C", VA = "0x317B20C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x317B214", Offset = "0x317B214", VA = "0x317B214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x317B21C", Offset = "0x317B21C", VA = "0x317B21C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x317B224", Offset = "0x317B224", VA = "0x317B224")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x317B22C", Offset = "0x317B22C", VA = "0x317B22C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x317B234", Offset = "0x317B234", VA = "0x317B234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x317B23C", Offset = "0x317B23C", VA = "0x317B23C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x317B274", Offset = "0x317B274", VA = "0x317B274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x317B2AC", Offset = "0x317B2AC", VA = "0x317B2AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x317B2E4", Offset = "0x317B2E4", VA = "0x317B2E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x317B31C", Offset = "0x317B31C", VA = "0x317B31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x317B350", Offset = "0x317B350", VA = "0x317B350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x317B388", Offset = "0x317B388", VA = "0x317B388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x317B3C0", Offset = "0x317B3C0", VA = "0x317B3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x317B3F8", Offset = "0x317B3F8", VA = "0x317B3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x317D528", Offset = "0x317D528", VA = "0x317D528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28ACC", Offset = "0xD28ACC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x317D534", Offset = "0x317D534", VA = "0x317D534")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28ADC", Offset = "0xD28ADC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x317B42C", Offset = "0x317B42C", VA = "0x317B42C")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x317B538", Offset = "0x317B538", VA = "0x317B538")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x317B480", Offset = "0x317B480", VA = "0x317B480")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x317B5C4", Offset = "0x317B5C4", VA = "0x317B5C4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x317B0BC", Offset = "0x317B0BC", VA = "0x317B0BC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x317B694", Offset = "0x317B694", VA = "0x317B694")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x317B74C", Offset = "0x317B74C", VA = "0x317B74C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x317B800", Offset = "0x317B800", VA = "0x317B800")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x317B8B4", Offset = "0x317B8B4", VA = "0x317B8B4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x317B8BC", Offset = "0x317B8BC", VA = "0x317B8BC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x317B8F0", Offset = "0x317B8F0", VA = "0x317B8F0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x317B9B8", Offset = "0x317B9B8", VA = "0x317B9B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x317BB60", Offset = "0x317BB60", VA = "0x317BB60")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x317CFB0", Offset = "0x317CFB0", VA = "0x317CFB0")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x317D3C4", Offset = "0x317D3C4", VA = "0x317D3C4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x317D424", Offset = "0x317D424", VA = "0x317D424")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x317D24C", Offset = "0x317D24C", VA = "0x317D24C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x317D308", Offset = "0x317D308", VA = "0x317D308")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x317D540", Offset = "0x317D540", VA = "0x317D540")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x317D618", Offset = "0x317D618", VA = "0x317D618", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x317D710", Offset = "0x317D710", VA = "0x317D710")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x317D838", Offset = "0x317D838", VA = "0x317D838")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x317D97C", Offset = "0x317D97C", VA = "0x317D97C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x317DAAC", Offset = "0x317DAAC", VA = "0x317DAAC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x317DCE8", Offset = "0x317DCE8", VA = "0x317DCE8", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x317DD6C", Offset = "0x317DD6C", VA = "0x317DD6C")]
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
			[Address(RVA = "0x317E620", Offset = "0x317E620", VA = "0x317E620", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000053")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x317E628", Offset = "0x317E628", VA = "0x317E628", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x317E630", Offset = "0x317E630", VA = "0x317E630", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x317E640", Offset = "0x317E640", VA = "0x317E640", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000056")]
		protected float positionOffset
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x3176690", Offset = "0x3176690", VA = "0x3176690")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x317DD78", Offset = "0x317DD78", VA = "0x317DD78")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x317DF30", Offset = "0x317DF30", VA = "0x317DF30")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x317E090", Offset = "0x317E090", VA = "0x317E090", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x317E0FC", Offset = "0x317E0FC", VA = "0x317E0FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x317E17C", Offset = "0x317E17C", VA = "0x317E17C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x317E528", Offset = "0x317E528", VA = "0x317E528", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x317E530", Offset = "0x317E530", VA = "0x317E530", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x317E638", Offset = "0x317E638", VA = "0x317E638", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x317E63C", Offset = "0x317E63C", VA = "0x317E63C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x3175C74", Offset = "0x3175C74", VA = "0x3175C74")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x3176378", Offset = "0x3176378", VA = "0x3176378")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x317E708", Offset = "0x317E708", VA = "0x317E708")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x3174AD4", Offset = "0x3174AD4", VA = "0x3174AD4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22B1C", Offset = "0xD22B1C")]
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
		[Address(RVA = "0x317E8FC", Offset = "0x317E8FC", VA = "0x317E8FC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x317ECE4", Offset = "0x317ECE4", VA = "0x317ECE4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x317ED98", Offset = "0x317ED98", VA = "0x317ED98", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x317EF2C", Offset = "0x317EF2C", VA = "0x317EF2C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x317F0C0", Offset = "0x317F0C0", VA = "0x317F0C0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x317F11C", Offset = "0x317F11C", VA = "0x317F11C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x317F18C", Offset = "0x317F18C", VA = "0x317F18C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x317F4FC", Offset = "0x317F4FC", VA = "0x317F4FC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x317F528", Offset = "0x317F528", VA = "0x317F528")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x317F1F0", Offset = "0x317F1F0", VA = "0x317F1F0")]
		private void Read()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x317F5C0", Offset = "0x317F5C0", VA = "0x317F5C0")]
		private void Write()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x317F74C", Offset = "0x317F74C", VA = "0x317F74C")]
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
			[Address(RVA = "0x2911560", Offset = "0x2911560", VA = "0x2911560")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22B34", Offset = "0xD22B34")]
		public float maintainRotationWeight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22B4C", Offset = "0xD22B4C")]
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
			[Address(RVA = "0x2E237B0", Offset = "0x2E237B0", VA = "0x2E237B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2E22638", Offset = "0x2E22638", VA = "0x2E22638")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2E22688", Offset = "0x2E22688", VA = "0x2E22688")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2E226D4", Offset = "0x2E226D4", VA = "0x2E226D4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2E22BA8", Offset = "0x2E22BA8", VA = "0x2E22BA8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2E234F0", Offset = "0x2E234F0", VA = "0x2E234F0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2E2359C", Offset = "0x2E2359C", VA = "0x2E2359C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2E23714", Offset = "0x2E23714", VA = "0x2E23714")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2E229D0", Offset = "0x2E229D0", VA = "0x2E229D0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2E22C8C", Offset = "0x2E22C8C", VA = "0x2E22C8C")]
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
				[Address(RVA = "0x29117F4", Offset = "0x29117F4", VA = "0x29117F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x29115C0", Offset = "0x29115C0", VA = "0x29115C0")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x29115C4", Offset = "0x29115C4", VA = "0x29115C4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x29115F4", Offset = "0x29115F4", VA = "0x29115F4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x29116EC", Offset = "0x29116EC", VA = "0x29116EC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22B64", Offset = "0xD22B64")]
		public float bodyWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22B7C", Offset = "0xD22B7C")]
		public float headWeight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22B94", Offset = "0xD22B94")]
		public float eyesWeight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22BAC", Offset = "0xD22BAC")]
		public float clampWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22BC4", Offset = "0xD22BC4")]
		public float clampWeightHead;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22BDC", Offset = "0xD22BDC")]
		public float clampWeightEyes;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22BF4", Offset = "0xD22BF4")]
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
			[Address(RVA = "0x2E23F6C", Offset = "0x2E23F6C", VA = "0x2E23F6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x2E2413C", Offset = "0x2E2413C", VA = "0x2E2413C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x2E2404C", Offset = "0x2E2404C", VA = "0x2E2404C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x2E24160", Offset = "0x2E24160", VA = "0x2E24160")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x2E2405C", Offset = "0x2E2405C", VA = "0x2E2405C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x2E241D8", Offset = "0x2E241D8", VA = "0x2E241D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2E237CC", Offset = "0x2E237CC", VA = "0x2E237CC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2E237FC", Offset = "0x2E237FC", VA = "0x2E237FC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2E23854", Offset = "0x2E23854", VA = "0x2E23854")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2E238D0", Offset = "0x2E238D0", VA = "0x2E238D0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2E23968", Offset = "0x2E23968", VA = "0x2E23968")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2E23A28", Offset = "0x2E23A28", VA = "0x2E23A28")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2E23B24", Offset = "0x2E23B24", VA = "0x2E23B24", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2E23C50", Offset = "0x2E23C50", VA = "0x2E23C50")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2E23C5C", Offset = "0x2E23C5C", VA = "0x2E23C5C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2E23DA0", Offset = "0x2E23DA0", VA = "0x2E23DA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2E241FC", Offset = "0x2E241FC", VA = "0x2E241FC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2E2446C", Offset = "0x2E2446C", VA = "0x2E2446C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2E24608", Offset = "0x2E24608", VA = "0x2E24608")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2E2486C", Offset = "0x2E2486C", VA = "0x2E2486C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2E24B80", Offset = "0x2E24B80", VA = "0x2E24B80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2E24C50", Offset = "0x2E24C50", VA = "0x2E24C50")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2E24DF0", Offset = "0x2E24DF0", VA = "0x2E24DF0")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2E25014", Offset = "0x2E25014", VA = "0x2E25014")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2E253C8", Offset = "0x2E253C8", VA = "0x2E253C8")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2E246C0", Offset = "0x2E246C0", VA = "0x2E246C0")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2E25638", Offset = "0x2E25638", VA = "0x2E25638")]
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
			[Address(RVA = "0x2911830", Offset = "0x2911830", VA = "0x2911830")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x291192C", Offset = "0x291192C", VA = "0x291192C")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x291195C", Offset = "0x291195C", VA = "0x291195C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x2911998", Offset = "0x2911998", VA = "0x2911998")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22C0C", Offset = "0xD22C0C")]
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
		[Address(RVA = "0x2E2589C", Offset = "0x2E2589C", VA = "0x2E2589C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2E259F8", Offset = "0x2E259F8", VA = "0x2E259F8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2E25B3C", Offset = "0x2E25B3C", VA = "0x2E25B3C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2E25B48", Offset = "0x2E25B48", VA = "0x2E25B48")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2E25B78", Offset = "0x2E25B78", VA = "0x2E25B78")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2E25B84", Offset = "0x2E25B84", VA = "0x2E25B84")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2E25B8C", Offset = "0x2E25B8C", VA = "0x2E25B8C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2E25CB0", Offset = "0x2E25CB0", VA = "0x2E25CB0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2E25DCC", Offset = "0x2E25DCC", VA = "0x2E25DCC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x2E25E18", Offset = "0x2E25E18", VA = "0x2E25E18", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x2E25E78", Offset = "0x2E25E78", VA = "0x2E25E78", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2E26270", Offset = "0x2E26270", VA = "0x2E26270")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2E262F0", Offset = "0x2E262F0", VA = "0x2E262F0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2E266AC", Offset = "0x2E266AC", VA = "0x2E266AC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2E26814", Offset = "0x2E26814", VA = "0x2E26814", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2E2697C", Offset = "0x2E2697C", VA = "0x2E2697C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2E268F0", Offset = "0x2E268F0", VA = "0x2E268F0")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2E26A80", Offset = "0x2E26A80", VA = "0x2E26A80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2E27254", Offset = "0x2E27254", VA = "0x2E27254", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2E27258", Offset = "0x2E27258", VA = "0x2E27258", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2E2725C", Offset = "0x2E2725C", VA = "0x2E2725C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2E2706C", Offset = "0x2E2706C", VA = "0x2E2706C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2E23624", Offset = "0x2E23624", VA = "0x2E23624")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22E48", Offset = "0xD22E48")]
			public Transform target;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22E80", Offset = "0xD22E80")]
			public Transform bendGoal;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22EB8", Offset = "0xD22EB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22EB8", Offset = "0xD22EB8")]
			public float positionWeight;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22F0C", Offset = "0xD22F0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22F0C", Offset = "0xD22F0C")]
			public float rotationWeight;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22F60", Offset = "0xD22F60")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22F98", Offset = "0xD22F98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22F98", Offset = "0xD22F98")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22FEC", Offset = "0xD22FEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22FEC", Offset = "0xD22FEC")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23040", Offset = "0xD23040")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23040", Offset = "0xD23040")]
			public float bendGoalWeight;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23094", Offset = "0xD23094")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23094", Offset = "0xD23094")]
			public float swivelOffset;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD230F0", Offset = "0xD230F0")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23128", Offset = "0xD23128")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23160", Offset = "0xD23160")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23160", Offset = "0xD23160")]
			public float armLengthMlp;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD231B8", Offset = "0xD231B8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD23230", Offset = "0xD23230")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD23240", Offset = "0xD23240")]
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
				[Address(RVA = "0x291199C", Offset = "0x291199C", VA = "0x291199C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B0C", Offset = "0xD28B0C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x29119A8", Offset = "0x29119A8", VA = "0x29119A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B1C", Offset = "0xD28B1C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000061")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000422")]
				[Address(RVA = "0x29119B4", Offset = "0x29119B4", VA = "0x29119B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B2C", Offset = "0xD28B2C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x29119C0", Offset = "0x29119C0", VA = "0x29119C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B3C", Offset = "0xD28B3C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000062")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000424")]
				[Address(RVA = "0x29119CC", Offset = "0x29119CC", VA = "0x29119CC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0x2911A00", Offset = "0x2911A00", VA = "0x2911A00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000426")]
				[Address(RVA = "0x2911A40", Offset = "0x2911A40", VA = "0x2911A40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x2911A8C", Offset = "0x2911A8C", VA = "0x2911A8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x2911AD8", Offset = "0x2911AD8", VA = "0x2911AD8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x29123E8", Offset = "0x29123E8", VA = "0x29123E8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x29125A4", Offset = "0x29125A4", VA = "0x29125A4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x29125C8", Offset = "0x29125C8", VA = "0x29125C8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x2912868", Offset = "0x2912868", VA = "0x2912868")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x2913DD8", Offset = "0x2913DD8", VA = "0x2913DD8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x2913E04", Offset = "0x2913E04", VA = "0x2913E04", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x2913814", Offset = "0x2913814", VA = "0x2913814")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x2913890", Offset = "0x2913890", VA = "0x2913890")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x2914024", Offset = "0x2914024", VA = "0x2914024")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x2914148", Offset = "0x2914148", VA = "0x2914148")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD23250", Offset = "0xD23250")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD23260", Offset = "0xD23260")]
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
				[Address(RVA = "0x29142B8", Offset = "0x29142B8", VA = "0x29142B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B4C", Offset = "0xD28B4C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000439")]
				[Address(RVA = "0x29142C0", Offset = "0x29142C0", VA = "0x29142C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B5C", Offset = "0xD28B5C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public float mag
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0x29142C8", Offset = "0x29142C8", VA = "0x29142C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B6C", Offset = "0xD28B6C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043B")]
				[Address(RVA = "0x29142D0", Offset = "0x29142D0", VA = "0x29142D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B7C", Offset = "0xD28B7C")]
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
			[Address(RVA = "0x29142D8", Offset = "0x29142D8", VA = "0x29142D8")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x29142E0", Offset = "0x29142E0", VA = "0x29142E0")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x29143B4", Offset = "0x29143B4", VA = "0x29143B4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x2914448", Offset = "0x2914448", VA = "0x2914448")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x29144F4", Offset = "0x29144F4", VA = "0x29144F4")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2914548", Offset = "0x2914548", VA = "0x2914548")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2913C94", Offset = "0x2913C94", VA = "0x2913C94")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2914684", Offset = "0x2914684", VA = "0x2914684")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x29147C4", Offset = "0x29147C4", VA = "0x29147C4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2914238", Offset = "0x2914238", VA = "0x2914238")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD23280", Offset = "0xD23280")]
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
				[Address(RVA = "0x29147EC", Offset = "0x29147EC", VA = "0x29147EC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000069")]
			public float stepProgress
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x2914800", Offset = "0x2914800", VA = "0x2914800")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B8C", Offset = "0xD28B8C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x2914808", Offset = "0x2914808", VA = "0x2914808")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28B9C", Offset = "0xD28B9C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x2914810", Offset = "0x2914810", VA = "0x2914810")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2914948", Offset = "0x2914948", VA = "0x2914948")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x2914990", Offset = "0x2914990", VA = "0x2914990")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x2914B5C", Offset = "0x2914B5C", VA = "0x2914B5C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2914CD0", Offset = "0x2914CD0", VA = "0x2914CD0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x2914E28", Offset = "0x2914E28", VA = "0x2914E28")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23290", Offset = "0xD23290")]
			public Transform target;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD232C8", Offset = "0xD232C8")]
			public Transform bendGoal;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23300", Offset = "0xD23300")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23300", Offset = "0xD23300")]
			public float positionWeight;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23354", Offset = "0xD23354")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23354", Offset = "0xD23354")]
			public float rotationWeight;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD233A8", Offset = "0xD233A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD233A8", Offset = "0xD233A8")]
			public float bendGoalWeight;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD233FC", Offset = "0xD233FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD233FC", Offset = "0xD233FC")]
			public float swivelOffset;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23458", Offset = "0xD23458")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23458", Offset = "0xD23458")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD234AC", Offset = "0xD234AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD234AC", Offset = "0xD234AC")]
			public float legLengthMlp;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23504", Offset = "0xD23504")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD235AC", Offset = "0xD235AC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD235BC", Offset = "0xD235BC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD235CC", Offset = "0xD235CC")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD235DC", Offset = "0xD235DC")]
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
				[Address(RVA = "0x2914F64", Offset = "0x2914F64", VA = "0x2914F64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28BAC", Offset = "0xD28BAC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x2914F70", Offset = "0x2914F70", VA = "0x2914F70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28BBC", Offset = "0xD28BBC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x2914F7C", Offset = "0x2914F7C", VA = "0x2914F7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28BCC", Offset = "0xD28BCC")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x2914F88", Offset = "0x2914F88", VA = "0x2914F88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28BDC", Offset = "0xD28BDC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public bool hasToes
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x2914F94", Offset = "0x2914F94", VA = "0x2914F94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28BEC", Offset = "0xD28BEC")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x2914F9C", Offset = "0x2914F9C", VA = "0x2914F9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28BFC", Offset = "0xD28BFC")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x2914FA8", Offset = "0x2914FA8", VA = "0x2914FA8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x2914FDC", Offset = "0x2914FDC", VA = "0x2914FDC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x2915014", Offset = "0x2915014", VA = "0x2915014")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x291504C", Offset = "0x291504C", VA = "0x291504C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x2915084", Offset = "0x2915084", VA = "0x2915084")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x29150C4", Offset = "0x29150C4", VA = "0x29150C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C0C", Offset = "0xD28C0C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x29150D0", Offset = "0x29150D0", VA = "0x29150D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C1C", Offset = "0xD28C1C")]
				private set
				{
				}
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x29150DC", Offset = "0x29150DC", VA = "0x29150DC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x2915754", Offset = "0x2915754", VA = "0x2915754", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0x2915D28", Offset = "0x2915D28", VA = "0x2915D28", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0x2915CD8", Offset = "0x2915CD8", VA = "0x2915CD8")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x2915B68", Offset = "0x2915B68", VA = "0x2915B68")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x2916110", Offset = "0x2916110", VA = "0x2916110")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x29165D4", Offset = "0x29165D4", VA = "0x29165D4")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x29162B4", Offset = "0x29162B4", VA = "0x29162B4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x29168CC", Offset = "0x29168CC", VA = "0x29168CC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x2916AE8", Offset = "0x2916AE8", VA = "0x2916AE8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x2916B34", Offset = "0x2916B34", VA = "0x2916B34")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD235EC", Offset = "0xD235EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD235EC", Offset = "0xD235EC")]
			public float weight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23640", Offset = "0xD23640")]
			public float footDistance;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23678", Offset = "0xD23678")]
			public float stepThreshold;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD236B0", Offset = "0xD236B0")]
			public float angleThreshold;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD236E8", Offset = "0xD236E8")]
			public float comAngleMlp;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23720", Offset = "0xD23720")]
			public float maxVelocity;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23758", Offset = "0xD23758")]
			public float velocityFactor;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23790", Offset = "0xD23790")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23790", Offset = "0xD23790")]
			public float maxLegStretch;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD237E8", Offset = "0xD237E8")]
			public float rootSpeed;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23820", Offset = "0xD23820")]
			public float stepSpeed;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23858", Offset = "0xD23858")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23890", Offset = "0xD23890")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD238C8", Offset = "0xD238C8")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23900", Offset = "0xD23900")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23900", Offset = "0xD23900")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23958", Offset = "0xD23958")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23990", Offset = "0xD23990")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD239C8", Offset = "0xD239C8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23A40", Offset = "0xD23A40")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23A78", Offset = "0xD23A78")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD23AB0", Offset = "0xD23AB0")]
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
				[Address(RVA = "0x2916C10", Offset = "0x2916C10", VA = "0x2916C10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C2C", Offset = "0xD28C2C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x2916C1C", Offset = "0x2916C1C", VA = "0x2916C1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C3C", Offset = "0xD28C3C")]
				private set
				{
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x29187E8", Offset = "0x29187E8", VA = "0x29187E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000075")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x2918828", Offset = "0x2918828", VA = "0x2918828")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000076")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x291886C", Offset = "0x291886C", VA = "0x291886C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000077")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x29188AC", Offset = "0x29188AC", VA = "0x29188AC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x2916C28", Offset = "0x2916C28", VA = "0x2916C28")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x2916F04", Offset = "0x2916F04", VA = "0x2916F04")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x29170D4", Offset = "0x29170D4", VA = "0x29170D4")]
			public void Relax()
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x2917138", Offset = "0x2917138", VA = "0x2917138")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x2917380", Offset = "0x2917380", VA = "0x2917380")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x2917444", Offset = "0x2917444", VA = "0x2917444")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x2918560", Offset = "0x2918560", VA = "0x2918560")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x2918698", Offset = "0x2918698", VA = "0x2918698")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x291871C", Offset = "0x291871C", VA = "0x291871C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x29188F0", Offset = "0x29188F0", VA = "0x29188F0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23AC0", Offset = "0xD23AC0")]
			public Transform headTarget;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23AF8", Offset = "0xD23AF8")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23B30", Offset = "0xD23B30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23B30", Offset = "0xD23B30")]
			public float positionWeight;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23B84", Offset = "0xD23B84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23B84", Offset = "0xD23B84")]
			public float rotationWeight;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23BD8", Offset = "0xD23BD8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23BD8", Offset = "0xD23BD8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23C2C", Offset = "0xD23C2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23C2C", Offset = "0xD23C2C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23C80", Offset = "0xD23C80")]
			public Transform chestGoal;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23CB8", Offset = "0xD23CB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23CB8", Offset = "0xD23CB8")]
			public float chestGoalWeight;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23D0C", Offset = "0xD23D0C")]
			public float minHeadHeight;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23D44", Offset = "0xD23D44")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23D44", Offset = "0xD23D44")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23D98", Offset = "0xD23D98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23D98", Offset = "0xD23D98")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23DEC", Offset = "0xD23DEC")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD23DEC", Offset = "0xD23DEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23DEC", Offset = "0xD23DEC")]
			public float neckStiffness;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23E64", Offset = "0xD23E64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23E64", Offset = "0xD23E64")]
			public float rotateChestByHands;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23EB8", Offset = "0xD23EB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23EB8", Offset = "0xD23EB8")]
			public float chestClampWeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23F0C", Offset = "0xD23F0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23F0C", Offset = "0xD23F0C")]
			public float headClampWeight;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23F60", Offset = "0xD23F60")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23F98", Offset = "0xD23F98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23F98", Offset = "0xD23F98")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD23FEC", Offset = "0xD23FEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD23FEC", Offset = "0xD23FEC")]
			public float maxRootAngle;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24044", Offset = "0xD24044")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD24044", Offset = "0xD24044")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24180", Offset = "0xD24180")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24190", Offset = "0xD24190")]
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
				[Address(RVA = "0x31FC628", Offset = "0x31FC628", VA = "0x31FC628")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x31FC668", Offset = "0x31FC668", VA = "0x31FC668")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x31FC6A8", Offset = "0x31FC6A8", VA = "0x31FC6A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone neck
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x31FC6FC", Offset = "0x31FC6FC", VA = "0x31FC6FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone head
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x31FC73C", Offset = "0x31FC73C", VA = "0x31FC73C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x600047C")]
				[Address(RVA = "0x31FC77C", Offset = "0x31FC77C", VA = "0x31FC77C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C4C", Offset = "0xD28C4C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047D")]
				[Address(RVA = "0x31FC790", Offset = "0x31FC790", VA = "0x31FC790")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C5C", Offset = "0xD28C5C")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x600047E")]
				[Address(RVA = "0x31FC7A4", Offset = "0x31FC7A4", VA = "0x31FC7A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C6C", Offset = "0xD28C6C")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600047F")]
				[Address(RVA = "0x31FC7B8", Offset = "0x31FC7B8", VA = "0x31FC7B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C7C", Offset = "0xD28C7C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x31FC7CC", Offset = "0x31FC7CC", VA = "0x31FC7CC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x31FD2B4", Offset = "0x31FD2B4", VA = "0x31FD2B4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x31FD4C0", Offset = "0x31FD4C0", VA = "0x31FD4C0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x31FD90C", Offset = "0x31FD90C", VA = "0x31FD90C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x31FDD48", Offset = "0x31FDD48", VA = "0x31FDD48")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x31FE4BC", Offset = "0x31FE4BC", VA = "0x31FE4BC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x31FEB40", Offset = "0x31FEB40", VA = "0x31FEB40")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x31FF4C8", Offset = "0x31FF4C8", VA = "0x31FF4C8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x31FF6A4", Offset = "0x31FF6A4", VA = "0x31FF6A4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x31FDAA4", Offset = "0x31FDAA4", VA = "0x31FDAA4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x31FE88C", Offset = "0x31FE88C", VA = "0x31FE88C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x31FE160", Offset = "0x31FE160", VA = "0x31FE160")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x31FF73C", Offset = "0x31FF73C", VA = "0x31FF73C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x31FE96C", Offset = "0x31FE96C", VA = "0x31FE96C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x31FE638", Offset = "0x31FE638", VA = "0x31FE638")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x31FFA64", Offset = "0x31FFA64", VA = "0x31FFA64")]
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
			[Address(RVA = "0x31FD218", Offset = "0x31FD218", VA = "0x31FD218")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x31FD294", Offset = "0x31FD294", VA = "0x31FD294")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x31FFBD8", Offset = "0x31FFBD8", VA = "0x31FFBD8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x31FFD5C", Offset = "0x31FFD5C", VA = "0x31FFD5C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x31FF93C", Offset = "0x31FF93C", VA = "0x31FF93C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x31FFF4C", Offset = "0x31FFF4C", VA = "0x31FFF4C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x32000AC", Offset = "0x32000AC", VA = "0x32000AC")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x32001E8", Offset = "0x32001E8", VA = "0x32001E8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x31FF0C4", Offset = "0x31FF0C4", VA = "0x31FF0C4")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x32002A0", Offset = "0x32002A0", VA = "0x32002A0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x31FED34", Offset = "0x31FED34", VA = "0x31FED34")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x3200408", Offset = "0x3200408", VA = "0x3200408")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x3200478", Offset = "0x3200478", VA = "0x3200478")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD22C24", Offset = "0xD22C24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22C24", Offset = "0xD22C24")]
		public int LOD;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22C78", Offset = "0xD22C78")]
		public float scale;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22CB0", Offset = "0xD22CB0")]
		public bool plantFeet;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD22CE8", Offset = "0xD22CE8")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22CF8", Offset = "0xD22CF8")]
		public Spine spine;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22D30", Offset = "0xD22D30")]
		public Arm leftArm;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22D68", Offset = "0xD22D68")]
		public Arm rightArm;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22DA0", Offset = "0xD22DA0")]
		public Leg leftLeg;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22DD8", Offset = "0xD22DD8")]
		public Leg rightLeg;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD22E10", Offset = "0xD22E10")]
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
			[Address(RVA = "0x2E2AB14", Offset = "0x2E2AB14", VA = "0x2E2AB14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28AEC", Offset = "0xD28AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x2E2AB1C", Offset = "0x2E2AB1C", VA = "0x2E2AB1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28AFC", Offset = "0xD28AFC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2E27260", Offset = "0x2E27260", VA = "0x2E27260")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2E2771C", Offset = "0x2E2771C", VA = "0x2E2771C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2E275A8", Offset = "0x2E275A8", VA = "0x2E275A8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2E27A80", Offset = "0x2E27A80", VA = "0x2E27A80")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2E27BC4", Offset = "0x2E27BC4", VA = "0x2E27BC4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2E27BF4", Offset = "0x2E27BF4", VA = "0x2E27BF4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2E27CA4", Offset = "0x2E27CA4", VA = "0x2E27CA4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2E27D8C", Offset = "0x2E27D8C", VA = "0x2E27D8C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2E28548", Offset = "0x2E28548", VA = "0x2E28548", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2E286B8", Offset = "0x2E286B8", VA = "0x2E286B8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2E288BC", Offset = "0x2E288BC", VA = "0x2E288BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2E28938", Offset = "0x2E28938", VA = "0x2E28938", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2E289B4", Offset = "0x2E289B4", VA = "0x2E289B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2E28B98", Offset = "0x2E28B98", VA = "0x2E28B98")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2E27960", Offset = "0x2E27960", VA = "0x2E27960")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2E27E80", Offset = "0x2E27E80", VA = "0x2E27E80")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2E28D58", Offset = "0x2E28D58", VA = "0x2E28D58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2E28DA0", Offset = "0x2E28DA0", VA = "0x2E28DA0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2E2A244", Offset = "0x2E2A244", VA = "0x2E2A244")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2E27FE4", Offset = "0x2E27FE4", VA = "0x2E27FE4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2E29114", Offset = "0x2E29114", VA = "0x2E29114")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2E2A5F4", Offset = "0x2E2A5F4", VA = "0x2E2A5F4")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2E2A63C", Offset = "0x2E2A63C", VA = "0x2E2A63C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2E2A0F4", Offset = "0x2E2A0F4", VA = "0x2E2A0F4")]
		private void Write()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2E2A680", Offset = "0x2E2A680", VA = "0x2E2A680")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2E2AB24", Offset = "0x2E2AB24", VA = "0x2E2AB24")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD241A0", Offset = "0xD241A0")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2CB5D70", Offset = "0x2CB5D70", VA = "0x2CB5D70")]
		public void Start()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2CB6458", Offset = "0x2CB6458", VA = "0x2CB6458")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2CB68E8", Offset = "0x2CB68E8", VA = "0x2CB68E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2CB69AC", Offset = "0x2CB69AC", VA = "0x2CB69AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2CB6AE8", Offset = "0x2CB6AE8", VA = "0x2CB6AE8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD241D8", Offset = "0xD241D8")]
		public Transform transform;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24210", Offset = "0xD24210")]
		public Transform parent;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24248", Offset = "0xD24248")]
		public Transform[] children;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24280", Offset = "0xD24280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD24280", Offset = "0xD24280")]
		public float weight;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD242D4", Offset = "0xD242D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD242D4", Offset = "0xD242D4")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24328", Offset = "0xD24328")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD24328", Offset = "0xD24328")]
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
		[Address(RVA = "0x2CB6B50", Offset = "0x2CB6B50", VA = "0x2CB6B50")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2CB5F70", Offset = "0x2CB5F70", VA = "0x2CB5F70")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2CB651C", Offset = "0x2CB651C", VA = "0x2CB651C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24384", Offset = "0xD24384")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24394", Offset = "0xD24394")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD243A4", Offset = "0xD243A4")]
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
			[Address(RVA = "0x2E2B05C", Offset = "0x2E2B05C", VA = "0x2E2B05C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C8C", Offset = "0xD28C8C")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x2E2B064", Offset = "0x2E2B064", VA = "0x2E2B064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28C9C", Offset = "0xD28C9C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool isPaused
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x2E2B06C", Offset = "0x2E2B06C", VA = "0x2E2B06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28CAC", Offset = "0xD28CAC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x2E2B074", Offset = "0x2E2B074", VA = "0x2E2B074")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28CBC", Offset = "0xD28CBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x2E2B080", Offset = "0x2E2B080", VA = "0x2E2B080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28CCC", Offset = "0xD28CCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x2E2B088", Offset = "0x2E2B088", VA = "0x2E2B088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28CDC", Offset = "0xD28CDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool inInteraction
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x2E2B090", Offset = "0x2E2B090", VA = "0x2E2B090")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public float progress
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x2E2D6F8", Offset = "0x2E2D6F8", VA = "0x2E2D6F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2E2B0FC", Offset = "0x2E2B0FC", VA = "0x2E2B0FC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2E2B194", Offset = "0x2E2B194", VA = "0x2E2B194")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2E2B254", Offset = "0x2E2B254", VA = "0x2E2B254")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2E2B3CC", Offset = "0x2E2B3CC", VA = "0x2E2B3CC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2E2B730", Offset = "0x2E2B730", VA = "0x2E2B730")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2E2B7EC", Offset = "0x2E2B7EC", VA = "0x2E2B7EC")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2E2B844", Offset = "0x2E2B844", VA = "0x2E2B844")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2E2C3C8", Offset = "0x2E2C3C8", VA = "0x2E2C3C8")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2E2CEA4", Offset = "0x2E2CEA4", VA = "0x2E2CEA4")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2E2D0E8", Offset = "0x2E2D0E8", VA = "0x2E2D0E8")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2E2D588", Offset = "0x2E2D588", VA = "0x2E2D588")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2E2D858", Offset = "0x2E2D858", VA = "0x2E2D858")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD243B4", Offset = "0xD243B4")]
		public LookAtIK ik;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD243EC", Offset = "0xD243EC")]
		public float lerpSpeed;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24424", Offset = "0xD24424")]
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
		[Address(RVA = "0x2E2DA7C", Offset = "0x2E2DA7C", VA = "0x2E2DA7C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2E2DBA4", Offset = "0x2E2DBA4", VA = "0x2E2DBA4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2E2DC48", Offset = "0x2E2DC48", VA = "0x2E2DC48")]
		public void Update()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2E2DE50", Offset = "0x2E2DE50", VA = "0x2E2DE50")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2E2DF44", Offset = "0x2E2DF44", VA = "0x2E2DF44")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2E2E00C", Offset = "0x2E2E00C", VA = "0x2E2E00C")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FF48", Offset = "0xD1FF48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FF48", Offset = "0xD1FF48")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24534", Offset = "0xD24534")]
			public float time;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2456C", Offset = "0xD2456C")]
			public bool pause;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD245A4", Offset = "0xD245A4")]
			public bool pickUp;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD245DC", Offset = "0xD245DC")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24614", Offset = "0xD24614")]
			public Message[] messages;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2464C", Offset = "0xD2464C")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x3200C24", Offset = "0x3200C24", VA = "0x3200C24")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x3200DF8", Offset = "0x3200DF8", VA = "0x3200DF8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24684", Offset = "0xD24684")]
			public string function;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD246BC", Offset = "0xD246BC")]
			public GameObject recipient;

			[Token(Token = "0x4000449")]
			private const string empty = "";

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x3200CF4", Offset = "0x3200CF4", VA = "0x3200CF4")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x3200E00", Offset = "0x3200E00", VA = "0x3200E00")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD246F4", Offset = "0xD246F4")]
			public Animator animator;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2472C", Offset = "0xD2472C")]
			public Animation animation;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24764", Offset = "0xD24764")]
			public string animationState;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2479C", Offset = "0xD2479C")]
			public float crossfadeTime;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD247D4", Offset = "0xD247D4")]
			public int layer;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2480C", Offset = "0xD2480C")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000450")]
			private const string empty = "";

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x3200990", Offset = "0x3200990", VA = "0x3200990")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x3200A80", Offset = "0x3200A80", VA = "0x3200A80")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x3200B34", Offset = "0x3200B34", VA = "0x3200B34")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x3200C10", Offset = "0x3200C10", VA = "0x3200C10")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24844", Offset = "0xD24844")]
			public Type type;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2487C", Offset = "0xD2487C")]
			public AnimationCurve curve;

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x3200E44", Offset = "0x3200E44", VA = "0x3200E44")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x3200E70", Offset = "0x3200E70", VA = "0x3200E70")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD248B4", Offset = "0xD248B4")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD248EC", Offset = "0xD248EC")]
			public float multiplier;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24924", Offset = "0xD24924")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x3200E08", Offset = "0x3200E08", VA = "0x3200E08")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x3200E60", Offset = "0x3200E60", VA = "0x3200E60")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2446C", Offset = "0xD2446C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD244A4", Offset = "0xD244A4")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD244DC", Offset = "0xD244DC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24514", Offset = "0xD24514")]
		private float <length>k__BackingField;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24524", Offset = "0xD24524")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000084")]
		public float length
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x2E2E260", Offset = "0x2E2E260", VA = "0x2E2E260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28EAC", Offset = "0xD28EAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x2E2E268", Offset = "0x2E2E268", VA = "0x2E2E268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28EBC", Offset = "0xD28EBC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x2E2E270", Offset = "0x2E2E270", VA = "0x2E2E270")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28ECC", Offset = "0xD28ECC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x2E2E278", Offset = "0x2E2E278", VA = "0x2E2E278")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD28EDC", Offset = "0xD28EDC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x2E2E448", Offset = "0x2E2E448", VA = "0x2E2E448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x2E2D734", Offset = "0x2E2D734", VA = "0x2E2D734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2E2E020", Offset = "0x2E2E020", VA = "0x2E2E020")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28CEC", Offset = "0xD28CEC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2E2E068", Offset = "0x2E2E068", VA = "0x2E2E068")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28D24", Offset = "0xD28D24")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2E2E0B0", Offset = "0x2E2E0B0", VA = "0x2E2E0B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28D5C", Offset = "0xD28D5C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2E2E0F8", Offset = "0x2E2E0F8", VA = "0x2E2E0F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28D94", Offset = "0xD28D94")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2E2E140", Offset = "0x2E2E140", VA = "0x2E2E140")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28DCC", Offset = "0xD28DCC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2E2E188", Offset = "0x2E2E188", VA = "0x2E2E188")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28E04", Offset = "0xD28E04")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2E2E1D0", Offset = "0x2E2E1D0", VA = "0x2E2E1D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28E3C", Offset = "0xD28E3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2E2E218", Offset = "0x2E2E218", VA = "0x2E2E218")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28E74", Offset = "0xD28E74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2E2E280", Offset = "0x2E2E280", VA = "0x2E2E280")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2E2E4D4", Offset = "0x2E2E4D4", VA = "0x2E2E4D4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2E2BDE8", Offset = "0x2E2BDE8", VA = "0x2E2BDE8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2E2E640", Offset = "0x2E2E640", VA = "0x2E2E640")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2E2BC9C", Offset = "0x2E2BC9C", VA = "0x2E2BC9C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2E2BDE0", Offset = "0x2E2BDE0", VA = "0x2E2BDE0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2E2CA48", Offset = "0x2E2CA48", VA = "0x2E2CA48")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2E2D368", Offset = "0x2E2D368", VA = "0x2E2D368")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2E2EC24", Offset = "0x2E2EC24", VA = "0x2E2EC24")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2E2E728", Offset = "0x2E2E728", VA = "0x2E2E728")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2E2E648", Offset = "0x2E2E648", VA = "0x2E2E648")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2E2EBBC", Offset = "0x2E2EBBC", VA = "0x2E2EBBC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2E2EC28", Offset = "0x2E2EC28", VA = "0x2E2EC28")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x2E2EC90", Offset = "0x2E2EC90", VA = "0x2E2EC90")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD1FFA8", Offset = "0xD1FFA8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD1FFA8", Offset = "0xD1FFA8")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2495C", Offset = "0xD2495C")]
		public string targetTag;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24994", Offset = "0xD24994")]
		public float fadeInTime;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD249CC", Offset = "0xD249CC")]
		public float speed;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24A04", Offset = "0xD24A04")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD24A3C", Offset = "0xD24A3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24A3C", Offset = "0xD24A3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD24A3C", Offset = "0xD24A3C")]
		public Collider characterCollider;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xD24AC0", Offset = "0xD24AC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24AC0", Offset = "0xD24AC0")]
		public Transform FPSCamera;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24B20", Offset = "0xD24B20")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24B58", Offset = "0xD24B58")]
		public float camRaycastDistance;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24B90", Offset = "0xD24B90")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24BA0", Offset = "0xD24BA0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD24BA0", Offset = "0xD24BA0")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24C00", Offset = "0xD24C00")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD24C38", Offset = "0xD24C38")]
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
			[Address(RVA = "0x2E2EF38", Offset = "0x2E2EF38", VA = "0x2E2EF38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x2E30C24", Offset = "0x2E30C24", VA = "0x2E30C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x2E30C2C", Offset = "0x2E30C2C", VA = "0x2E30C2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x2E30C34", Offset = "0x2E30C34", VA = "0x2E30C34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD290AC", Offset = "0xD290AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x2E30C3C", Offset = "0x2E30C3C", VA = "0x2E30C3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD290BC", Offset = "0xD290BC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x2E30C44", Offset = "0x2E30C44", VA = "0x2E30C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD290CC", Offset = "0xD290CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x2E30C4C", Offset = "0x2E30C4C", VA = "0x2E30C4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD290DC", Offset = "0xD290DC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2E2ECF8", Offset = "0x2E2ECF8", VA = "0x2E2ECF8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28EEC", Offset = "0xD28EEC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2E2ED40", Offset = "0x2E2ED40", VA = "0x2E2ED40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28F24", Offset = "0xD28F24")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2E2ED88", Offset = "0x2E2ED88", VA = "0x2E2ED88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28F5C", Offset = "0xD28F5C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2E2EDD0", Offset = "0x2E2EDD0", VA = "0x2E2EDD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28F94", Offset = "0xD28F94")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2E2EE18", Offset = "0x2E2EE18", VA = "0x2E2EE18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD28FCC", Offset = "0xD28FCC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2E2EE60", Offset = "0x2E2EE60", VA = "0x2E2EE60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29004", Offset = "0xD29004")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2E2EEA8", Offset = "0x2E2EEA8", VA = "0x2E2EEA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2903C", Offset = "0xD2903C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2E2EEF0", Offset = "0x2E2EEF0", VA = "0x2E2EEF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29074", Offset = "0xD29074")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2E2F0DC", Offset = "0x2E2F0DC", VA = "0x2E2F0DC")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2E2F1A8", Offset = "0x2E2F1A8", VA = "0x2E2F1A8")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2E2F274", Offset = "0x2E2F274", VA = "0x2E2F274")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2E2F320", Offset = "0x2E2F320", VA = "0x2E2F320")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2E2F418", Offset = "0x2E2F418", VA = "0x2E2F418")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2E2F530", Offset = "0x2E2F530", VA = "0x2E2F530")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2E2F5C0", Offset = "0x2E2F5C0", VA = "0x2E2F5C0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2E2F650", Offset = "0x2E2F650", VA = "0x2E2F650")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2E2F6E0", Offset = "0x2E2F6E0", VA = "0x2E2F6E0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2E2F754", Offset = "0x2E2F754", VA = "0x2E2F754")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2E2F7C8", Offset = "0x2E2F7C8", VA = "0x2E2F7C8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2E2F830", Offset = "0x2E2F830", VA = "0x2E2F830")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2E2F8BC", Offset = "0x2E2F8BC", VA = "0x2E2F8BC")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2E2F970", Offset = "0x2E2F970", VA = "0x2E2F970")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2E2FA54", Offset = "0x2E2FA54", VA = "0x2E2FA54")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2E2FD2C", Offset = "0x2E2FD2C", VA = "0x2E2FD2C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2E2FF24", Offset = "0x2E2FF24", VA = "0x2E2FF24")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2E301C8", Offset = "0x2E301C8", VA = "0x2E301C8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2E304A0", Offset = "0x2E304A0", VA = "0x2E304A0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2E304E4", Offset = "0x2E304E4", VA = "0x2E304E4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2E3055C", Offset = "0x2E3055C", VA = "0x2E3055C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2E30690", Offset = "0x2E30690", VA = "0x2E30690")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2E30834", Offset = "0x2E30834", VA = "0x2E30834")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2E30AD8", Offset = "0x2E30AD8", VA = "0x2E30AD8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2E302DC", Offset = "0x2E302DC", VA = "0x2E302DC")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2E30C58", Offset = "0x2E30C58", VA = "0x2E30C58")]
		public void Start()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2E31480", Offset = "0x2E31480", VA = "0x2E31480")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2E314A0", Offset = "0x2E314A0", VA = "0x2E314A0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2E314BC", Offset = "0x2E314BC", VA = "0x2E314BC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2E314D8", Offset = "0x2E314D8", VA = "0x2E314D8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2E31538", Offset = "0x2E31538", VA = "0x2E31538")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2E31674", Offset = "0x2E31674", VA = "0x2E31674")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x2E31784", Offset = "0x2E31784", VA = "0x2E31784")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2E31958", Offset = "0x2E31958", VA = "0x2E31958")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2E31A84", Offset = "0x2E31A84", VA = "0x2E31A84")]
		public void Update()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2E31CE0", Offset = "0x2E31CE0", VA = "0x2E31CE0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x2E311CC", Offset = "0x2E311CC", VA = "0x2E311CC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x2E31E1C", Offset = "0x2E31E1C", VA = "0x2E31E1C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x2E31F44", Offset = "0x2E31F44", VA = "0x2E31F44")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x2E31FD8", Offset = "0x2E31FD8", VA = "0x2E31FD8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x2E320AC", Offset = "0x2E320AC", VA = "0x2E320AC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x2E320C4", Offset = "0x2E320C4", VA = "0x2E320C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2E2EFE4", Offset = "0x2E2EFE4", VA = "0x2E2EFE4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x2E2FBFC", Offset = "0x2E2FBFC", VA = "0x2E2FBFC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2E324C0", Offset = "0x2E324C0", VA = "0x2E324C0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD20008", Offset = "0xD20008")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD20008", Offset = "0xD20008")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24E94", Offset = "0xD24E94")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24ECC", Offset = "0xD24ECC")]
			public float multiplier;

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x32014E4", Offset = "0x32014E4", VA = "0x32014E4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24C48", Offset = "0xD24C48")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24C80", Offset = "0xD24C80")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24CB8", Offset = "0xD24CB8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24CF0", Offset = "0xD24CF0")]
		public Transform pivot;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24D28", Offset = "0xD24D28")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24D60", Offset = "0xD24D60")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24D98", Offset = "0xD24D98")]
		public float twistWeight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24DD0", Offset = "0xD24DD0")]
		public float swingWeight;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24E08", Offset = "0xD24E08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD24E08", Offset = "0xD24E08")]
		public float threeDOFWeight;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24E5C", Offset = "0xD24E5C")]
		public bool rotateOnce;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x2E3290C", Offset = "0x2E3290C", VA = "0x2E3290C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD290EC", Offset = "0xD290EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x2E32954", Offset = "0x2E32954", VA = "0x2E32954")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29124", Offset = "0xD29124")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x2E3299C", Offset = "0x2E3299C", VA = "0x2E3299C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2915C", Offset = "0xD2915C")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x2E329E4", Offset = "0x2E329E4", VA = "0x2E329E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29194", Offset = "0xD29194")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x2E32A2C", Offset = "0x2E32A2C", VA = "0x2E32A2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD291CC", Offset = "0xD291CC")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x2E32A74", Offset = "0x2E32A74", VA = "0x2E32A74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29204", Offset = "0xD29204")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x2E32ABC", Offset = "0x2E32ABC", VA = "0x2E32ABC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2923C", Offset = "0xD2923C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2E32B04", Offset = "0x2E32B04", VA = "0x2E32B04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29274", Offset = "0xD29274")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x2E2E6B8", Offset = "0x2E2E6B8", VA = "0x2E2E6B8")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x2E2D7C0", Offset = "0x2E2D7C0", VA = "0x2E2D7C0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x2E2BE9C", Offset = "0x2E2BE9C", VA = "0x2E2BE9C")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x2E32B4C", Offset = "0x2E32B4C", VA = "0x2E32B4C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD20068", Offset = "0xD20068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD20068", Offset = "0xD20068")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000091")]
		public class CharacterPosition
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24F3C", Offset = "0xD24F3C")]
			public bool use;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24F74", Offset = "0xD24F74")]
			public Vector2 offset;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD24FAC", Offset = "0xD24FAC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24FAC", Offset = "0xD24FAC")]
			public float angleOffset;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25008", Offset = "0xD25008")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25008", Offset = "0xD25008")]
			public float maxAngle;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25060", Offset = "0xD25060")]
			public float radius;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25098", Offset = "0xD25098")]
			public bool orbit;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD250D0", Offset = "0xD250D0")]
			public bool fixYAxis;

			[Token(Token = "0x1700008C")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600053F")]
				[Address(RVA = "0x3201854", Offset = "0x3201854", VA = "0x3201854")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008D")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x3201860", Offset = "0x3201860", VA = "0x3201860")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x32018E8", Offset = "0x32018E8", VA = "0x32018E8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000542")]
			[Address(RVA = "0x3201D2C", Offset = "0x3201D2C", VA = "0x3201D2C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25108", Offset = "0xD25108")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25140", Offset = "0xD25140")]
			public Vector3 direction;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25178", Offset = "0xD25178")]
			public float maxDistance;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD251B0", Offset = "0xD251B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD251B0", Offset = "0xD251B0")]
			public float maxAngle;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25208", Offset = "0xD25208")]
			public bool fixYAxis;

			[Token(Token = "0x6000543")]
			[Address(RVA = "0x32014EC", Offset = "0x32014EC", VA = "0x32014EC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x32015E0", Offset = "0x32015E0", VA = "0x32015E0")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x3201808", Offset = "0x3201808", VA = "0x3201808")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25308", Offset = "0xD25308")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400049F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25340", Offset = "0xD25340")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000548")]
				[Address(RVA = "0x3205498", Offset = "0x3205498", VA = "0x3205498")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25260", Offset = "0xD25260")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25298", Offset = "0xD25298")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD252D0", Offset = "0xD252D0")]
			public Interaction[] interactions;

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x3201D40", Offset = "0x3201D40", VA = "0x3201D40")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x3201DF4", Offset = "0x3201DF4", VA = "0x3201DF4")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD24F04", Offset = "0xD24F04")]
		public Range[] ranges;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x2CAA970", Offset = "0x2CAA970", VA = "0x2CAA970")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD292AC", Offset = "0xD292AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x2CAA9B8", Offset = "0x2CAA9B8", VA = "0x2CAA9B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD292E4", Offset = "0xD292E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2CAAA00", Offset = "0x2CAAA00", VA = "0x2CAAA00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2931C", Offset = "0xD2931C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2CAAA48", Offset = "0x2CAAA48", VA = "0x2CAAA48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29354", Offset = "0xD29354")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x2CAAA90", Offset = "0x2CAAA90", VA = "0x2CAAA90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2938C", Offset = "0xD2938C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x2CAAAD8", Offset = "0x2CAAAD8", VA = "0x2CAAAD8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x2CAACAC", Offset = "0x2CAACAC", VA = "0x2CAACAC")]
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
			[Address(RVA = "0x290C5BC", Offset = "0x290C5BC", VA = "0x290C5BC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000551")]
			[Address(RVA = "0x290C614", Offset = "0x290C614", VA = "0x290C614")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x290C664", Offset = "0x290C664", VA = "0x290C664")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x290C6B0", Offset = "0x290C6B0", VA = "0x290C6B0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x2D40DF0", Offset = "0x2D40DF0", VA = "0x2D40DF0", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD293C4", Offset = "0xD293C4")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x2D41180", Offset = "0x2D41180", VA = "0x2D41180", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x2D41184", Offset = "0x2D41184", VA = "0x2D41184", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x2D4128C", Offset = "0x2D4128C", VA = "0x2D4128C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x2D41114", Offset = "0x2D41114", VA = "0x2D41114")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x2D41074", Offset = "0x2D41074", VA = "0x2D41074")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x2D412F8", Offset = "0x2D412F8", VA = "0x2D412F8")]
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
		[Address(RVA = "0x2D47F2C", Offset = "0x2D47F2C", VA = "0x2D47F2C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x2D48008", Offset = "0x2D48008", VA = "0x2D48008", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x2D481F0", Offset = "0x2D481F0", VA = "0x2D481F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x2D482EC", Offset = "0x2D482EC", VA = "0x2D482EC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x2D4806C", Offset = "0x2D4806C", VA = "0x2D4806C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x2D4864C", Offset = "0x2D4864C", VA = "0x2D4864C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25378", Offset = "0xD25378")]
		public float weight;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25390", Offset = "0xD25390")]
		public float localRotationWeight;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD253A8", Offset = "0xD253A8")]
		public float localPositionWeight;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600055A")]
		public abstract void AutoMapping();

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2CADF7C", Offset = "0x2CADF7C", VA = "0x2CADF7C")]
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
		[Address(RVA = "0x2CADF88", Offset = "0x2CADF88", VA = "0x2CADF88", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2CADFDC", Offset = "0x2CADFDC", VA = "0x2CADFDC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2CAE018", Offset = "0x2CAE018", VA = "0x2CAE018", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2CAE030", Offset = "0x2CAE030", VA = "0x2CAE030")]
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
			[Address(RVA = "0x3202EEC", Offset = "0x3202EEC", VA = "0x3202EEC")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x32030B0", Offset = "0x32030B0", VA = "0x32030B0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x3203190", Offset = "0x3203190", VA = "0x3203190")]
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
			[Address(RVA = "0x3202CE4", Offset = "0x3202CE4", VA = "0x3202CE4")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0x3202D5C", Offset = "0x3202D5C", VA = "0x3202D5C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x3202E9C", Offset = "0x3202E9C", VA = "0x3202E9C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD200C8", Offset = "0xD200C8")]
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
				[Address(RVA = "0x3202C94", Offset = "0x3202C94", VA = "0x3202C94", Slot = "4")]
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
				[Address(RVA = "0x3202CDC", Offset = "0x3202CDC", VA = "0x3202CDC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x3202A58", Offset = "0x3202A58", VA = "0x3202A58")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x3202A84", Offset = "0x3202A84", VA = "0x3202A84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x3202A88", Offset = "0x3202A88", VA = "0x3202A88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x3202C9C", Offset = "0x3202C9C", VA = "0x3202C9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD253C0", Offset = "0xD253C0")]
		public IK ik;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD253F8", Offset = "0xD253F8")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25430", Offset = "0xD25430")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25468", Offset = "0xD25468")]
		public float applyVelocity;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD254A0", Offset = "0xD254A0")]
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
			[Address(RVA = "0x2CAEFE0", Offset = "0x2CAEFE0", VA = "0x2CAEFE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008F")]
		private bool ikUsed
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x2CAFA14", Offset = "0x2CAFA14", VA = "0x2CAFA14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2CAEFA8", Offset = "0x2CAEFA8", VA = "0x2CAEFA8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2CAF058", Offset = "0x2CAF058", VA = "0x2CAF058")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2CAF194", Offset = "0x2CAF194", VA = "0x2CAF194")]
		public void Start()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2CAF11C", Offset = "0x2CAF11C", VA = "0x2CAF11C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD293FC", Offset = "0xD293FC")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2CAF650", Offset = "0x2CAF650", VA = "0x2CAF650")]
		private void Update()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2CAF89C", Offset = "0x2CAF89C", VA = "0x2CAF89C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2CAF958", Offset = "0x2CAF958", VA = "0x2CAF958")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2CAFB94", Offset = "0x2CAFB94", VA = "0x2CAFB94")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2CAF9D8", Offset = "0x2CAF9D8", VA = "0x2CAF9D8")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2CAFB50", Offset = "0x2CAFB50", VA = "0x2CAFB50")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2CAFC34", Offset = "0x2CAFC34", VA = "0x2CAFC34")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2CAFBC8", Offset = "0x2CAFBC8", VA = "0x2CAFBC8")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2CAF0B0", Offset = "0x2CAF0B0", VA = "0x2CAF0B0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2CAF8DC", Offset = "0x2CAF8DC", VA = "0x2CAF8DC")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x2CAFE60", Offset = "0x2CAFE60", VA = "0x2CAFE60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2CAFF9C", Offset = "0x2CAFF9C", VA = "0x2CAFF9C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD254E8", Offset = "0xD254E8")]
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
			[Address(RVA = "0x2CB122C", Offset = "0x2CB122C", VA = "0x2CB122C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000093")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x2CB1238", Offset = "0x2CB1238", VA = "0x2CB1238")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x2CB1254", Offset = "0x2CB1254", VA = "0x2CB1254")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD294AC", Offset = "0xD294AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x2CB125C", Offset = "0x2CB125C", VA = "0x2CB125C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD294BC", Offset = "0xD294BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x2CB0F2C", Offset = "0x2CB0F2C", VA = "0x2CB0F2C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2CB0F74", Offset = "0x2CB0F74", VA = "0x2CB0F74")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2CB0F8C", Offset = "0x2CB0F8C", VA = "0x2CB0F8C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2CB1184", Offset = "0x2CB1184", VA = "0x2CB1184")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x2CB11F4", Offset = "0x2CB11F4", VA = "0x2CB11F4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600058A")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2CB10AC", Offset = "0x2CB10AC", VA = "0x2CB10AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2CB1268", Offset = "0x2CB1268", VA = "0x2CB1268")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2CB126C", Offset = "0x2CB126C", VA = "0x2CB126C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2CB12A0", Offset = "0x2CB12A0", VA = "0x2CB12A0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2CB131C", Offset = "0x2CB131C", VA = "0x2CB131C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2CB14B0", Offset = "0x2CB14B0", VA = "0x2CB14B0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2CB1520", Offset = "0x2CB1520", VA = "0x2CB1520")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD200D8", Offset = "0xD200D8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD200D8", Offset = "0xD200D8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD254F8", Offset = "0xD254F8")]
		public float limit;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25514", Offset = "0xD25514")]
		public float twistLimit;

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2CB1554", Offset = "0x2CB1554", VA = "0x2CB1554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD294CC", Offset = "0xD294CC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x2CB159C", Offset = "0x2CB159C", VA = "0x2CB159C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29504", Offset = "0xD29504")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x2CB15E4", Offset = "0x2CB15E4", VA = "0x2CB15E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2953C", Offset = "0xD2953C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x2CB162C", Offset = "0x2CB162C", VA = "0x2CB162C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29574", Offset = "0xD29574")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2CB1674", Offset = "0x2CB1674", VA = "0x2CB1674", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2CB16B8", Offset = "0x2CB16B8", VA = "0x2CB16B8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x2CB1878", Offset = "0x2CB1878", VA = "0x2CB1878")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD20138", Offset = "0xD20138")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD20138", Offset = "0xD20138")]
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
		[Address(RVA = "0x2CB18B8", Offset = "0x2CB18B8", VA = "0x2CB18B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD295AC", Offset = "0xD295AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2CB1900", Offset = "0x2CB1900", VA = "0x2CB1900")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD295E4", Offset = "0xD295E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x2CB1948", Offset = "0x2CB1948", VA = "0x2CB1948")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2961C", Offset = "0xD2961C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2CB1990", Offset = "0x2CB1990", VA = "0x2CB1990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29654", Offset = "0xD29654")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x2CB19D8", Offset = "0x2CB19D8", VA = "0x2CB19D8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2CB19DC", Offset = "0x2CB19DC", VA = "0x2CB19DC")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x2CB1B60", Offset = "0x2CB1B60", VA = "0x2CB1B60")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD20198", Offset = "0xD20198")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD20198", Offset = "0xD20198")]
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
				[Address(RVA = "0x3203598", Offset = "0x3203598", VA = "0x3203598")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 a
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x32035D0", Offset = "0x32035D0", VA = "0x32035D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 b
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0x320360C", Offset = "0x320360C", VA = "0x320360C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 c
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x3203648", Offset = "0x3203648", VA = "0x3203648")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public bool isValid
			{
				[Token(Token = "0x60005B5")]
				[Address(RVA = "0x32037D4", Offset = "0x32037D4", VA = "0x32037D4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x3203684", Offset = "0x3203684", VA = "0x3203684")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x32037E4", Offset = "0x32037E4", VA = "0x32037E4")]
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
			[Address(RVA = "0x320355C", Offset = "0x320355C", VA = "0x320355C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25540", Offset = "0xD25540")]
		public float twistLimit;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD2555C", Offset = "0xD2555C")]
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
		[Address(RVA = "0x2CB1BA8", Offset = "0x2CB1BA8", VA = "0x2CB1BA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2968C", Offset = "0xD2968C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x2CB1BF0", Offset = "0x2CB1BF0", VA = "0x2CB1BF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD296C4", Offset = "0xD296C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x2CB1C38", Offset = "0x2CB1C38", VA = "0x2CB1C38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD296FC", Offset = "0xD296FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2CB1C80", Offset = "0x2CB1C80", VA = "0x2CB1C80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29734", Offset = "0xD29734")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2CB1CC8", Offset = "0x2CB1CC8", VA = "0x2CB1CC8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2CB21C4", Offset = "0x2CB21C4", VA = "0x2CB21C4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x2CB2258", Offset = "0x2CB2258", VA = "0x2CB2258")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2CB27CC", Offset = "0x2CB27CC", VA = "0x2CB27CC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2CB1D70", Offset = "0x2CB1D70", VA = "0x2CB1D70")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x2CB2B78", Offset = "0x2CB2B78", VA = "0x2CB2B78")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2CB2F84", Offset = "0x2CB2F84", VA = "0x2CB2F84")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2CB2FC8", Offset = "0x2CB2FC8", VA = "0x2CB2FC8")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2CB3028", Offset = "0x2CB3028", VA = "0x2CB3028")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2CB255C", Offset = "0x2CB255C", VA = "0x2CB255C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2CB3094", Offset = "0x2CB3094", VA = "0x2CB3094")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2CB3170", Offset = "0x2CB3170", VA = "0x2CB3170")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD201F8", Offset = "0xD201F8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xD201F8", Offset = "0xD201F8")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD255A4", Offset = "0xD255A4")]
		public float twistLimit;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x2CB31F0", Offset = "0x2CB31F0", VA = "0x2CB31F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD2976C", Offset = "0xD2976C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x2CB3238", Offset = "0x2CB3238", VA = "0x2CB3238")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD297A4", Offset = "0xD297A4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x2CB3280", Offset = "0x2CB3280", VA = "0x2CB3280")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD297DC", Offset = "0xD297DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x2CB32C8", Offset = "0x2CB32C8", VA = "0x2CB32C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xD29814", Offset = "0xD29814")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x2CB3310", Offset = "0x2CB3310", VA = "0x2CB3310")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x2CB332C", Offset = "0x2CB332C", VA = "0x2CB332C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x2CB3370", Offset = "0x2CB3370", VA = "0x2CB3370")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x2CB3594", Offset = "0x2CB3594", VA = "0x2CB3594")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD20258", Offset = "0xD20258")]
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
				[Address(RVA = "0x2908D34", Offset = "0x2908D34", VA = "0x2908D34", Slot = "4")]
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
				[Address(RVA = "0x2908D7C", Offset = "0x2908D7C", VA = "0x2908D7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x2908C38", Offset = "0x2908C38", VA = "0x2908C38")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2908C64", Offset = "0x2908C64", VA = "0x2908C64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2908C68", Offset = "0x2908C68", VA = "0x2908C68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x2908D3C", Offset = "0x2908D3C", VA = "0x2908D3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD255D0", Offset = "0xD255D0")]
		public AimIK ik;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25608", Offset = "0xD25608")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25608", Offset = "0xD25608")]
		public float weight;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2565C", Offset = "0xD2565C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD2565C", Offset = "0xD2565C")]
		public Transform target;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD256BC", Offset = "0xD256BC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD256F4", Offset = "0xD256F4")]
		public float weightSmoothTime;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2572C", Offset = "0xD2572C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD2572C", Offset = "0xD2572C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2578C", Offset = "0xD2578C")]
		public float maxRadiansDelta;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD257C4", Offset = "0xD257C4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD257FC", Offset = "0xD257FC")]
		public float slerpSpeed;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25834", Offset = "0xD25834")]
		public float smoothDampTime;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2586C", Offset = "0xD2586C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD258A4", Offset = "0xD258A4")]
		public float minDistance;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD258DC", Offset = "0xD258DC")]
		public Vector3 offset;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25914", Offset = "0xD25914")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD25914", Offset = "0xD25914")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25914", Offset = "0xD25914")]
		public float maxRootAngle;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25990", Offset = "0xD25990")]
		public bool turnToTarget;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD259C8", Offset = "0xD259C8")]
		public float turnToTargetTime;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25A00", Offset = "0xD25A00")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD25A00", Offset = "0xD25A00")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25A60", Offset = "0xD25A60")]
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
			[Address(RVA = "0x1F49568", Offset = "0x1F49568", VA = "0x1F49568")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1F494DC", Offset = "0x1F494DC", VA = "0x1F494DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1F495F8", Offset = "0x1F495F8", VA = "0x1F495F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1F49D90", Offset = "0x1F49D90", VA = "0x1F49D90")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1F49E7C", Offset = "0x1F49E7C", VA = "0x1F49E7C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1F4A0CC", Offset = "0x1F4A0CC", VA = "0x1F4A0CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD2984C", Offset = "0xD2984C")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1F4A144", Offset = "0x1F4A144", VA = "0x1F4A144")]
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
			[Address(RVA = "0x2908D84", Offset = "0x2908D84", VA = "0x2908D84")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2908F10", Offset = "0x2908F10", VA = "0x2908F10")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2908F18", Offset = "0x2908F18", VA = "0x2908F18")]
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
		[Address(RVA = "0x1F4A3B4", Offset = "0x1F4A3B4", VA = "0x1F4A3B4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1F4A494", Offset = "0x1F4A494", VA = "0x1F4A494")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1F4A500", Offset = "0x1F4A500", VA = "0x1F4A500")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25C20", Offset = "0xD25C20")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400051F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25C58", Offset = "0xD25C58")]
				public float weight;

				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x320507C", Offset = "0x320507C", VA = "0x320507C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25AD0", Offset = "0xD25AD0")]
			public Transform transform;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25B08", Offset = "0xD25B08")]
			public Transform relativeTo;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25B40", Offset = "0xD25B40")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25B78", Offset = "0xD25B78")]
			public float verticalWeight;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25BB0", Offset = "0xD25BB0")]
			public float horizontalWeight;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25BE8", Offset = "0xD25BE8")]
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
			[Address(RVA = "0x2908F34", Offset = "0x2908F34", VA = "0x2908F34")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x2909260", Offset = "0x2909260", VA = "0x2909260")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x2909270", Offset = "0x2909270", VA = "0x2909270")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25A98", Offset = "0xD25A98")]
		public Body[] bodies;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1F4A578", Offset = "0x1F4A578", VA = "0x1F4A578", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1F4A6C4", Offset = "0x1F4A6C4", VA = "0x1F4A6C4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25C90", Offset = "0xD25C90")]
		public float tiltSpeed;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25CC8", Offset = "0xD25CC8")]
		public float tiltSensitivity;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25D00", Offset = "0xD25D00")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25D38", Offset = "0xD25D38")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1F57168", Offset = "0x1F57168", VA = "0x1F57168", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1F571B0", Offset = "0x1F571B0", VA = "0x1F571B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1F57368", Offset = "0x1F57368", VA = "0x1F57368")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD25D70", Offset = "0xD25D70")]
		public float weight;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1F5737C", Offset = "0x1F5737C", VA = "0x1F5737C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1F57454", Offset = "0x1F57454", VA = "0x1F57454")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1F5767C", Offset = "0x1F5767C", VA = "0x1F5767C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1F577AC", Offset = "0x1F577AC", VA = "0x1F577AC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25D88", Offset = "0xD25D88")]
		public Animator animator;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25DC0", Offset = "0xD25DC0")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD25E08", Offset = "0xD25E08")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700009D")]
		public IK ik
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1F61370", Offset = "0x1F61370", VA = "0x1F61370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD298FC", Offset = "0xD298FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1F61378", Offset = "0x1F61378", VA = "0x1F61378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2990C", Offset = "0xD2990C")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1F61380", Offset = "0x1F61380", VA = "0x1F61380")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1F6153C", Offset = "0x1F6153C", VA = "0x1F6153C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1F617C8", Offset = "0x1F617C8", VA = "0x1F617C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1F61920", Offset = "0x1F61920", VA = "0x1F61920")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1F61B10", Offset = "0x1F61B10", VA = "0x1F61B10")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1F61D48", Offset = "0x1F61D48", VA = "0x1F61D48")]
		public void Update()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1F61FF4", Offset = "0x1F61FF4", VA = "0x1F61FF4")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xD20278", Offset = "0xD20278")]
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
			[Address(RVA = "0x1F61634", Offset = "0x1F61634", VA = "0x1F61634")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1F619A0", Offset = "0x1F619A0", VA = "0x1F619A0")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1F61658", Offset = "0x1F61658", VA = "0x1F61658")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1F6205C", Offset = "0x1F6205C", VA = "0x1F6205C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25E88", Offset = "0xD25E88")]
			public string name;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25EC0", Offset = "0xD25EC0")]
			public Collider collider;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25EF8", Offset = "0xD25EF8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD25F44", Offset = "0xD25F44")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD25F54", Offset = "0xD25F54")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD25F64", Offset = "0xD25F64")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD25F74", Offset = "0xD25F74")]
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
				[Address(RVA = "0x290E364", Offset = "0x290E364", VA = "0x290E364")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A1")]
			protected float crossFader
			{
				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x290E378", Offset = "0x290E378", VA = "0x290E378")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2991C", Offset = "0xD2991C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x290E380", Offset = "0x290E380", VA = "0x290E380")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2992C", Offset = "0xD2992C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected float timer
			{
				[Token(Token = "0x60005F4")]
				[Address(RVA = "0x290E388", Offset = "0x290E388", VA = "0x290E388")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2993C", Offset = "0xD2993C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F5")]
				[Address(RVA = "0x290E390", Offset = "0x290E390", VA = "0x290E390")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2994C", Offset = "0xD2994C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 force
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x290E398", Offset = "0x290E398", VA = "0x290E398")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2995C", Offset = "0xD2995C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x290E3A4", Offset = "0x290E3A4", VA = "0x290E3A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2996C", Offset = "0xD2996C")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected Vector3 point
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x290E3B0", Offset = "0x290E3B0", VA = "0x290E3B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2997C", Offset = "0xD2997C")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x290E3BC", Offset = "0x290E3BC", VA = "0x290E3BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2998C", Offset = "0xD2998C")]
				private set
				{
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x290E3C8", Offset = "0x290E3C8", VA = "0x290E3C8")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x290E4FC", Offset = "0x290E4FC", VA = "0x290E4FC")]
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
			[Address(RVA = "0x290E5D0", Offset = "0x290E5D0", VA = "0x290E5D0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2602C", Offset = "0xD2602C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26064", Offset = "0xD26064")]
				public float weight;

				[Token(Token = "0x400053F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000540")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000604")]
				[Address(RVA = "0x32051EC", Offset = "0x32051EC", VA = "0x32051EC")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000605")]
				[Address(RVA = "0x320529C", Offset = "0x320529C", VA = "0x320529C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000606")]
				[Address(RVA = "0x32052B0", Offset = "0x32052B0", VA = "0x32052B0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25F84", Offset = "0xD25F84")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25FBC", Offset = "0xD25FBC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25FF4", Offset = "0xD25FF4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x290E90C", Offset = "0x290E90C", VA = "0x290E90C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x290EA3C", Offset = "0x290EA3C", VA = "0x290EA3C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x290EAA8", Offset = "0x290EAA8", VA = "0x290EAA8", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x290EC10", Offset = "0x290EC10", VA = "0x290EC10")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2610C", Offset = "0xD2610C")]
				public Transform bone;

				[Token(Token = "0x4000545")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26144", Offset = "0xD26144")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD26144", Offset = "0xD26144")]
				public float weight;

				[Token(Token = "0x4000546")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000547")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600060B")]
				[Address(RVA = "0x3205084", Offset = "0x3205084", VA = "0x3205084")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600060C")]
				[Address(RVA = "0x320519C", Offset = "0x320519C", VA = "0x320519C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060D")]
				[Address(RVA = "0x32051A8", Offset = "0x32051A8", VA = "0x32051A8")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2609C", Offset = "0xD2609C")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD260D4", Offset = "0xD260D4")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x290E5E4", Offset = "0x290E5E4", VA = "0x290E5E4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x290E688", Offset = "0x290E688", VA = "0x290E688", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x290E6F4", Offset = "0x290E6F4", VA = "0x290E6F4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x290E8F8", Offset = "0x290E8F8", VA = "0x290E8F8")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25E18", Offset = "0xD25E18")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD25E50", Offset = "0xD25E50")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009F")]
		public bool inProgress
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x2D494F4", Offset = "0x2D494F4", VA = "0x2D494F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2D495C4", Offset = "0x2D495C4", VA = "0x2D495C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2D496A0", Offset = "0x2D496A0", VA = "0x2D496A0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2D498FC", Offset = "0x2D498FC", VA = "0x2D498FC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26208", Offset = "0xD26208")]
			public string name;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26240", Offset = "0xD26240")]
			public Collider collider;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26278", Offset = "0xD26278")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD262C4", Offset = "0xD262C4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD262D4", Offset = "0xD262D4")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD262E4", Offset = "0xD262E4")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD262F4", Offset = "0xD262F4")]
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
				[Address(RVA = "0x290EC24", Offset = "0x290EC24", VA = "0x290EC24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2999C", Offset = "0xD2999C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000612")]
				[Address(RVA = "0x290EC2C", Offset = "0x290EC2C", VA = "0x290EC2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299AC", Offset = "0xD299AC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected float timer
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x290EC34", Offset = "0x290EC34", VA = "0x290EC34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299BC", Offset = "0xD299BC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000614")]
				[Address(RVA = "0x290EC3C", Offset = "0x290EC3C", VA = "0x290EC3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299CC", Offset = "0xD299CC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 force
			{
				[Token(Token = "0x6000615")]
				[Address(RVA = "0x290EC44", Offset = "0x290EC44", VA = "0x290EC44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299DC", Offset = "0xD299DC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000616")]
				[Address(RVA = "0x290EC50", Offset = "0x290EC50", VA = "0x290EC50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299EC", Offset = "0xD299EC")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected Vector3 point
			{
				[Token(Token = "0x6000617")]
				[Address(RVA = "0x290EC5C", Offset = "0x290EC5C", VA = "0x290EC5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD299FC", Offset = "0xD299FC")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000618")]
				[Address(RVA = "0x290EC68", Offset = "0x290EC68", VA = "0x290EC68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD29A0C", Offset = "0xD29A0C")]
				private set
				{
				}
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x290EC74", Offset = "0x290EC74", VA = "0x290EC74")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x290EDBC", Offset = "0x290EDBC", VA = "0x290EDBC")]
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
			[Address(RVA = "0x290EEA4", Offset = "0x290EEA4", VA = "0x290EEA4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD263AC", Offset = "0xD263AC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000559")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD263E4", Offset = "0xD263E4")]
				public float weight;

				[Token(Token = "0x400055A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000623")]
				[Address(RVA = "0x32052B8", Offset = "0x32052B8", VA = "0x32052B8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000624")]
				[Address(RVA = "0x3205348", Offset = "0x3205348", VA = "0x3205348")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000625")]
				[Address(RVA = "0x320535C", Offset = "0x320535C", VA = "0x320535C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26304", Offset = "0xD26304")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2633C", Offset = "0xD2633C")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26374", Offset = "0xD26374")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600061F")]
			[Address(RVA = "0x290EEB8", Offset = "0x290EEB8", VA = "0x290EEB8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x290F068", Offset = "0x290F068", VA = "0x290F068", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0x290F0D4", Offset = "0x290F0D4", VA = "0x290F0D4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x290F274", Offset = "0x290F274", VA = "0x290F274")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2648C", Offset = "0xD2648C")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000560")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD264C4", Offset = "0xD264C4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD264C4", Offset = "0xD264C4")]
				public float weight;

				[Token(Token = "0x4000561")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000562")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600062A")]
				[Address(RVA = "0x3205364", Offset = "0x3205364", VA = "0x3205364")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600062B")]
				[Address(RVA = "0x3205440", Offset = "0x3205440", VA = "0x3205440")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600062C")]
				[Address(RVA = "0x320544C", Offset = "0x320544C", VA = "0x320544C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2641C", Offset = "0xD2641C")]
			public int curveIndex;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26454", Offset = "0xD26454")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000626")]
			[Address(RVA = "0x290F290", Offset = "0x290F290", VA = "0x290F290", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x290F374", Offset = "0x290F374", VA = "0x290F374", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x290F3E0", Offset = "0x290F3E0", VA = "0x290F3E0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x290F69C", Offset = "0x290F69C", VA = "0x290F69C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26198", Offset = "0xD26198")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD261D0", Offset = "0xD261D0")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x2D49904", Offset = "0x2D49904", VA = "0x2D49904", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x2D499D8", Offset = "0x2D499D8", VA = "0x2D499D8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x2D49C3C", Offset = "0x2D49C3C", VA = "0x2D49C3C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD266F4", Offset = "0xD266F4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000571")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2672C", Offset = "0xD2672C")]
				public float weight;

				[Token(Token = "0x6000633")]
				[Address(RVA = "0x3205490", Offset = "0x3205490", VA = "0x3205490")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26588", Offset = "0xD26588")]
			public Transform transform;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD265C0", Offset = "0xD265C0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD265F8", Offset = "0xD265F8")]
			public float speed;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26630", Offset = "0xD26630")]
			public float acceleration;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26668", Offset = "0xD26668")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD26668", Offset = "0xD26668")]
			public float matchVelocity;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD266BC", Offset = "0xD266BC")]
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
			[Address(RVA = "0x3200600", Offset = "0x3200600", VA = "0x3200600")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x32006B8", Offset = "0x32006B8", VA = "0x32006B8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x3200974", Offset = "0x3200974", VA = "0x3200974")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26518", Offset = "0xD26518")]
		public Body[] bodies;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26550", Offset = "0xD26550")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x2E2ADFC", Offset = "0x2E2ADFC", VA = "0x2E2ADFC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x2E2AE78", Offset = "0x2E2AE78", VA = "0x2E2AE78", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x2E2AF38", Offset = "0x2E2AF38", VA = "0x2E2AF38")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD26764", Offset = "0xD26764")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26764", Offset = "0xD26764")]
		public Transform target;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD267C4", Offset = "0xD267C4")]
		public float weight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD267DC", Offset = "0xD267DC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26814", Offset = "0xD26814")]
		public float weightSmoothTime;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2684C", Offset = "0xD2684C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD2684C", Offset = "0xD2684C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD268AC", Offset = "0xD268AC")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD268E4", Offset = "0xD268E4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2691C", Offset = "0xD2691C")]
		public float slerpSpeed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26954", Offset = "0xD26954")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2698C", Offset = "0xD2698C")]
		public float minDistance;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD269C4", Offset = "0xD269C4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xD269C4", Offset = "0xD269C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD269C4", Offset = "0xD269C4")]
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
			[Address(RVA = "0x2CAC2B0", Offset = "0x2CAC2B0", VA = "0x2CAC2B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x2CAC23C", Offset = "0x2CAC23C", VA = "0x2CAC23C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x2CAC340", Offset = "0x2CAC340", VA = "0x2CAC340")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x2CAC884", Offset = "0x2CAC884", VA = "0x2CAC884")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x2CAC970", Offset = "0x2CAC970", VA = "0x2CAC970")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x2CACB68", Offset = "0x2CACB68", VA = "0x2CACB68")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26AB0", Offset = "0xD26AB0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26AE8", Offset = "0xD26AE8")]
			public float spring;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26B20", Offset = "0xD26B20")]
			public bool x;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26B58", Offset = "0xD26B58")]
			public bool y;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26B90", Offset = "0xD26B90")]
			public bool z;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26BC8", Offset = "0xD26BC8")]
			public float minX;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26C00", Offset = "0xD26C00")]
			public float maxX;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26C38", Offset = "0xD26C38")]
			public float minY;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26C70", Offset = "0xD26C70")]
			public float maxY;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26CA8", Offset = "0xD26CA8")]
			public float minZ;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26CE0", Offset = "0xD26CE0")]
			public float maxZ;

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x3201FF4", Offset = "0x3201FF4", VA = "0x3201FF4")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x320214C", Offset = "0x320214C", VA = "0x320214C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x32021C4", Offset = "0x32021C4", VA = "0x32021C4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x320221C", Offset = "0x320221C", VA = "0x320221C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD202E4", Offset = "0xD202E4")]
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
				[Address(RVA = "0x3201FA4", Offset = "0x3201FA4", VA = "0x3201FA4", Slot = "4")]
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
				[Address(RVA = "0x3201FEC", Offset = "0x3201FEC", VA = "0x3201FEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x3201E04", Offset = "0x3201E04", VA = "0x3201E04")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x3201E30", Offset = "0x3201E30", VA = "0x3201E30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x3201E34", Offset = "0x3201E34", VA = "0x3201E34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x3201FAC", Offset = "0x3201FAC", VA = "0x3201FAC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26A40", Offset = "0xD26A40")]
		public float weight;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26A78", Offset = "0xD26A78")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AA")]
		protected float deltaTime
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x2CAD664", Offset = "0x2CAD664", VA = "0x2CAD664")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600063B")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x2CAD690", Offset = "0x2CAD690", VA = "0x2CAD690", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x2CAD6BC", Offset = "0x2CAD6BC", VA = "0x2CAD6BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29A1C", Offset = "0xD29A1C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2CAD734", Offset = "0x2CAD734", VA = "0x2CAD734")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2CAD810", Offset = "0x2CAD810", VA = "0x2CAD810")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2CAD8D0", Offset = "0x2CAD8D0", VA = "0x2CAD8D0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x2CADA00", Offset = "0x2CADA00", VA = "0x2CADA00")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD202F4", Offset = "0xD202F4")]
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
				[Address(RVA = "0x32023C4", Offset = "0x32023C4", VA = "0x32023C4", Slot = "4")]
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
				[Address(RVA = "0x320240C", Offset = "0x320240C", VA = "0x320240C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x3202224", Offset = "0x3202224", VA = "0x3202224")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x3202250", Offset = "0x3202250", VA = "0x3202250", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x3202254", Offset = "0x3202254", VA = "0x3202254", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x32023CC", Offset = "0x32023CC", VA = "0x32023CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26D18", Offset = "0xD26D18")]
		public float weight;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26D50", Offset = "0xD26D50")]
		public VRIK ik;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AD")]
		protected float deltaTime
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x2CADA10", Offset = "0x2CADA10", VA = "0x2CADA10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600064D")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x2CADA3C", Offset = "0x2CADA3C", VA = "0x2CADA3C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x2CADA68", Offset = "0x2CADA68", VA = "0x2CADA68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xD29ACC", Offset = "0xD29ACC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x2CADAE0", Offset = "0x2CADAE0", VA = "0x2CADAE0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x2CADBBC", Offset = "0x2CADBBC", VA = "0x2CADBBC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x2CADCEC", Offset = "0x2CADCEC", VA = "0x2CADCEC")]
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
			[Address(RVA = "0x3202414", Offset = "0x3202414", VA = "0x3202414")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x3202630", Offset = "0x3202630", VA = "0x3202630")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2CADCFC", Offset = "0x2CADCFC", VA = "0x2CADCFC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2CADDC0", Offset = "0x2CADDC0", VA = "0x2CADDC0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2CADE7C", Offset = "0x2CADE7C", VA = "0x2CADE7C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26F64", Offset = "0xD26F64")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005AE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26F9C", Offset = "0xD26F9C")]
				public float weight;

				[Token(Token = "0x6000664")]
				[Address(RVA = "0x32054A0", Offset = "0x32054A0", VA = "0x32054A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26DC0", Offset = "0xD26DC0")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26DF8", Offset = "0xD26DF8")]
			public Transform raycastTo;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD26E30", Offset = "0xD26E30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26E30", Offset = "0xD26E30")]
			public float raycastRadius;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26E84", Offset = "0xD26E84")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26EBC", Offset = "0xD26EBC")]
			public float smoothTimeIn;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26EF4", Offset = "0xD26EF4")]
			public float smoothTimeOut;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26F2C", Offset = "0xD26F2C")]
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
			[Address(RVA = "0x3202638", Offset = "0x3202638", VA = "0x3202638")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x320277C", Offset = "0x320277C", VA = "0x320277C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0x3202874", Offset = "0x3202874", VA = "0x3202874")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0x3202A44", Offset = "0x3202A44", VA = "0x3202A44")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26D88", Offset = "0xD26D88")]
		public Avoider[] avoiders;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2CADEE4", Offset = "0x2CADEE4", VA = "0x2CADEE4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x2CADF6C", Offset = "0x2CADF6C", VA = "0x2CADF6C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27328", Offset = "0xD27328")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27360", Offset = "0xD27360")]
				public float weight;

				[Token(Token = "0x6000674")]
				[Address(RVA = "0x32054A8", Offset = "0x32054A8", VA = "0x32054A8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2722C", Offset = "0xD2722C")]
			public Vector3 offset;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27264", Offset = "0xD27264")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD27264", Offset = "0xD27264")]
			public float additivity;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD272B8", Offset = "0xD272B8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD272F0", Offset = "0xD272F0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x3203334", Offset = "0x3203334", VA = "0x3203334")]
			public void Start()
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x3203384", Offset = "0x3203384", VA = "0x3203384")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x3203548", Offset = "0x3203548", VA = "0x3203548")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD26FD4", Offset = "0xD26FD4")]
		public AimIK aimIK;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2700C", Offset = "0xD2700C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27044", Offset = "0xD27044")]
		public Handedness handedness;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2707C", Offset = "0xD2707C")]
		public bool twoHanded;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD270B4", Offset = "0xD270B4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD270EC", Offset = "0xD270EC")]
		public float magnitudeRandom;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27124", Offset = "0xD27124")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD2715C", Offset = "0xD2715C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27194", Offset = "0xD27194")]
		public float blendTime;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD271CC", Offset = "0xD271CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD271CC", Offset = "0xD271CC")]
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
			[Address(RVA = "0x2CB00C4", Offset = "0x2CB00C4", VA = "0x2CB00C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x2CB0B60", Offset = "0x2CB0B60", VA = "0x2CB0B60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x2CB0BA0", Offset = "0x2CB0BA0", VA = "0x2CB0BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform primaryHand
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x2CB0B20", Offset = "0x2CB0B20", VA = "0x2CB0B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x2CB0B40", Offset = "0x2CB0B40", VA = "0x2CB0B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x2CB00F4", Offset = "0x2CB00F4", VA = "0x2CB00F4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x2CB0120", Offset = "0x2CB0120", VA = "0x2CB0120")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2CB0268", Offset = "0x2CB0268", VA = "0x2CB0268", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2CB0BE0", Offset = "0x2CB0BE0", VA = "0x2CB0BE0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x2CB0C94", Offset = "0x2CB0C94", VA = "0x2CB0C94")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2CB0CD0", Offset = "0x2CB0CD0", VA = "0x2CB0CD0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2CB0EBC", Offset = "0x2CB0EBC", VA = "0x2CB0EBC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27398", Offset = "0xD27398")]
		public float weight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD273D0", Offset = "0xD273D0")]
		public float offset;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x2CB35D0", Offset = "0x2CB35D0", VA = "0x2CB35D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x2CB36D8", Offset = "0x2CB36D8", VA = "0x2CB36D8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x2CB37C0", Offset = "0x2CB37C0", VA = "0x2CB37C0")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x2CB3B14", Offset = "0x2CB3B14", VA = "0x2CB3B14")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x2CB3B4C", Offset = "0x2CB3B4C", VA = "0x2CB3B4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x2CB3C7C", Offset = "0x2CB3C7C", VA = "0x2CB3C7C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27408", Offset = "0xD27408")]
			public float scaleMlp;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27440", Offset = "0xD27440")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27478", Offset = "0xD27478")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD274B0", Offset = "0xD274B0")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD274E8", Offset = "0xD274E8")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27520", Offset = "0xD27520")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27558", Offset = "0xD27558")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xD27590", Offset = "0xD27590")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27590", Offset = "0xD27590")]
			public Vector3 headOffset;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD275E0", Offset = "0xD275E0")]
			public Vector3 handOffset;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27618", Offset = "0xD27618")]
			public float footForwardOffset;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27650", Offset = "0xD27650")]
			public float footInwardOffset;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xD27688", Offset = "0xD27688")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD27688", Offset = "0xD27688")]
			public float footHeadingOffset;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD276E4", Offset = "0xD276E4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xD276FC", Offset = "0xD276FC")]
			public float pelvisRotationWeight;

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x3204C30", Offset = "0x3204C30", VA = "0x3204C30")]
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
				[Address(RVA = "0x32054B0", Offset = "0x32054B0", VA = "0x32054B0")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x600068D")]
				[Address(RVA = "0x3205570", Offset = "0x3205570", VA = "0x3205570")]
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
			[Address(RVA = "0x3204C28", Offset = "0x3204C28", VA = "0x3204C28")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x2CB7EC4", Offset = "0x2CB7EC4", VA = "0x2CB7EC4")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x2CB7EDC", Offset = "0x2CB7EDC", VA = "0x2CB7EDC")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x2CB8014", Offset = "0x2CB8014", VA = "0x2CB8014")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x2CB7F28", Offset = "0x2CB7F28", VA = "0x2CB7F28")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x2CB802C", Offset = "0x2CB802C", VA = "0x2CB802C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x2CB92B0", Offset = "0x2CB92B0", VA = "0x2CB92B0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x2CB9AF4", Offset = "0x2CB9AF4", VA = "0x2CB9AF4")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x2CBA5FC", Offset = "0x2CBA5FC", VA = "0x2CBA5FC")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x2CBAA6C", Offset = "0x2CBAA6C", VA = "0x2CBAA6C")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x2CBACA4", Offset = "0x2CBACA4", VA = "0x2CBACA4")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x2CBB36C", Offset = "0x2CBB36C", VA = "0x2CBB36C")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x2CBB100", Offset = "0x2CBB100", VA = "0x2CBB100")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x2CBB5E8", Offset = "0x2CBB5E8", VA = "0x2CBB5E8")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x2CBB844", Offset = "0x2CBB844", VA = "0x2CBB844")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x2CBB934", Offset = "0x2CBB934", VA = "0x2CBB934")]
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
		[Address(RVA = "0x2CBBC50", Offset = "0x2CBBC50", VA = "0x2CBBC50")]
		private void Start()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x2CBBCAC", Offset = "0x2CBBCAC", VA = "0x2CBBCAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x2CBBCE0", Offset = "0x2CBBCE0", VA = "0x2CBBCE0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x2CBBE1C", Offset = "0x2CBBE1C", VA = "0x2CBBE1C")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27714", Offset = "0xD27714")]
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
			[Address(RVA = "0x2CBBE34", Offset = "0x2CBBE34", VA = "0x2CBBE34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD29B7C", Offset = "0xD29B7C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x2CBBE40", Offset = "0x2CBBE40", VA = "0x2CBBE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD29B8C", Offset = "0xD29B8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x2CBBE4C", Offset = "0x2CBBE4C", VA = "0x2CBBE4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x2CB98C4", Offset = "0x2CB98C4", VA = "0x2CB98C4")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x2CBA8B0", Offset = "0x2CBA8B0", VA = "0x2CBA8B0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x2CBBF5C", Offset = "0x2CBBF5C", VA = "0x2CBBF5C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x2CBC378", Offset = "0x2CBC378", VA = "0x2CBC378")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x2CBC4A8", Offset = "0x2CBC4A8", VA = "0x2CBC4A8")]
		public VRIKRootController()
		{
		}
	}
}
namespace FreakLib.SelectParent
{
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xD20304", Offset = "0xD20304")]
	public class AlwaysSelectMyParent : MonoBehaviour
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1F4A570", Offset = "0x1F4A570", VA = "0x1F4A570")]
		public AlwaysSelectMyParent()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20000D5")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2034C", Offset = "0xD2034C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x2909614", Offset = "0x2909614", VA = "0x2909614")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x290961C", Offset = "0x290961C", VA = "0x290961C")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2035C", Offset = "0xD2035C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x290975C", Offset = "0x290975C", VA = "0x290975C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x2909764", Offset = "0x2909764", VA = "0x2909764")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2036C", Offset = "0xD2036C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x2909780", Offset = "0x2909780", VA = "0x2909780")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x2909788", Offset = "0x2909788", VA = "0x2909788")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2037C", Offset = "0xD2037C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x29097A4", Offset = "0x29097A4", VA = "0x29097A4")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x29097AC", Offset = "0x29097AC", VA = "0x29097AC")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2038C", Offset = "0xD2038C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x29097C8", Offset = "0x29097C8", VA = "0x29097C8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x29097D0", Offset = "0x29097D0", VA = "0x29097D0")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2039C", Offset = "0xD2039C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x29097EC", Offset = "0x29097EC", VA = "0x29097EC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x29097F4", Offset = "0x29097F4", VA = "0x29097F4")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD203AC", Offset = "0xD203AC")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x2909810", Offset = "0x2909810", VA = "0x2909810")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x2909818", Offset = "0x2909818", VA = "0x2909818")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x2909834", Offset = "0x2909834", VA = "0x2909834")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x2909868", Offset = "0x2909868", VA = "0x2909868")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x2909884", Offset = "0x2909884", VA = "0x2909884")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x29098A0", Offset = "0x29098A0", VA = "0x29098A0")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD203BC", Offset = "0xD203BC")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x2909960", Offset = "0x2909960", VA = "0x2909960")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x2909968", Offset = "0x2909968", VA = "0x2909968")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD203CC", Offset = "0xD203CC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x2909984", Offset = "0x2909984", VA = "0x2909984")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x290998C", Offset = "0x290998C", VA = "0x290998C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x29099A8", Offset = "0x29099A8", VA = "0x29099A8")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD203DC", Offset = "0xD203DC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x2909AA8", Offset = "0x2909AA8", VA = "0x2909AA8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x2909AB0", Offset = "0x2909AB0", VA = "0x2909AB0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD203EC", Offset = "0xD203EC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x2909638", Offset = "0x2909638", VA = "0x2909638")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x2909640", Offset = "0x2909640", VA = "0x2909640")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x290965C", Offset = "0x290965C", VA = "0x290965C")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1F58AC8", Offset = "0x1F58AC8", VA = "0x1F58AC8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1F58CA4", Offset = "0x1F58CA4", VA = "0x1F58CA4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1F58E74", Offset = "0x1F58E74", VA = "0x1F58E74")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1F59044", Offset = "0x1F59044", VA = "0x1F59044")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1F59214", Offset = "0x1F59214", VA = "0x1F59214")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1F593EC", Offset = "0x1F593EC", VA = "0x1F593EC")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1F59640", Offset = "0x1F59640", VA = "0x1F59640")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1F59B74", Offset = "0x1F59B74", VA = "0x1F59B74")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1F59DF0", Offset = "0x1F59DF0", VA = "0x1F59DF0")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1F5A08C", Offset = "0x1F5A08C", VA = "0x1F5A08C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1F5A27C", Offset = "0x1F5A27C", VA = "0x1F5A27C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E1")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2040C", Offset = "0xD2040C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x2909ACC", Offset = "0x2909ACC", VA = "0x2909ACC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x2909AD4", Offset = "0x2909AD4", VA = "0x2909AD4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x2909AF0", Offset = "0x2909AF0", VA = "0x2909AF0")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2041C", Offset = "0xD2041C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x2909B0C", Offset = "0x2909B0C", VA = "0x2909B0C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x2909B14", Offset = "0x2909B14", VA = "0x2909B14")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x2909B30", Offset = "0x2909B30", VA = "0x2909B30")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2042C", Offset = "0xD2042C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x2909B4C", Offset = "0x2909B4C", VA = "0x2909B4C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x2909B54", Offset = "0x2909B54", VA = "0x2909B54")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x2909B60", Offset = "0x2909B60", VA = "0x2909B60")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1F5A48C", Offset = "0x1F5A48C", VA = "0x1F5A48C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1F5A65C", Offset = "0x1F5A65C", VA = "0x1F5A65C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1F5A804", Offset = "0x1F5A804", VA = "0x1F5A804")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1F5A9F0", Offset = "0x1F5A9F0", VA = "0x1F5A9F0")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000E5")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20000E6")]
		public static class Utils
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x290AC34", Offset = "0x290AC34", VA = "0x290AC34")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2044C", Offset = "0xD2044C")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x2909C0C", Offset = "0x2909C0C", VA = "0x2909C0C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x2909C14", Offset = "0x2909C14", VA = "0x2909C14")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x2909C30", Offset = "0x2909C30", VA = "0x2909C30")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2045C", Offset = "0xD2045C")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x2909ED4", Offset = "0x2909ED4", VA = "0x2909ED4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x2909EDC", Offset = "0x2909EDC", VA = "0x2909EDC")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x2909F00", Offset = "0x2909F00", VA = "0x2909F00")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2046C", Offset = "0xD2046C")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x290A2E8", Offset = "0x290A2E8", VA = "0x290A2E8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x290A2F0", Offset = "0x290A2F0", VA = "0x290A2F0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x290A314", Offset = "0x290A314", VA = "0x290A314")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2047C", Offset = "0xD2047C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x290A7EC", Offset = "0x290A7EC", VA = "0x290A7EC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x290A7F4", Offset = "0x290A7F4", VA = "0x290A7F4")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x290A818", Offset = "0x290A818", VA = "0x290A818")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2048C", Offset = "0xD2048C")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x290A94C", Offset = "0x290A94C", VA = "0x290A94C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x290A954", Offset = "0x290A954", VA = "0x290A954")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x290A978", Offset = "0x290A978", VA = "0x290A978")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2049C", Offset = "0xD2049C")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x290A99C", Offset = "0x290A99C", VA = "0x290A99C")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x290A9A4", Offset = "0x290A9A4", VA = "0x290A9A4")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x290A9C0", Offset = "0x290A9C0", VA = "0x290A9C0")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD204AC", Offset = "0xD204AC")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x290A9DC", Offset = "0x290A9DC", VA = "0x290A9DC")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x290A9E4", Offset = "0x290A9E4", VA = "0x290A9E4")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x290AA48", Offset = "0x290AA48", VA = "0x290AA48")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD204BC", Offset = "0xD204BC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x290AAA4", Offset = "0x290AAA4", VA = "0x290AAA4")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x290AAAC", Offset = "0x290AAAC", VA = "0x290AAAC")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x290AB10", Offset = "0x290AB10", VA = "0x290AB10")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD204CC", Offset = "0xD204CC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x290AB6C", Offset = "0x290AB6C", VA = "0x290AB6C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x290AB74", Offset = "0x290AB74", VA = "0x290AB74")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x290ABD8", Offset = "0x290ABD8", VA = "0x290ABD8")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD204DC", Offset = "0xD204DC")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x2909C4C", Offset = "0x2909C4C", VA = "0x2909C4C")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x2909C54", Offset = "0x2909C54", VA = "0x2909C54")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x2909C74", Offset = "0x2909C74", VA = "0x2909C74")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD204EC", Offset = "0xD204EC")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x2909C90", Offset = "0x2909C90", VA = "0x2909C90")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x2909C98", Offset = "0x2909C98", VA = "0x2909C98")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x2909CB8", Offset = "0x2909CB8", VA = "0x2909CB8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD204FC", Offset = "0xD204FC")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x2909CD4", Offset = "0x2909CD4", VA = "0x2909CD4")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x2909CDC", Offset = "0x2909CDC", VA = "0x2909CDC")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x2909CF8", Offset = "0x2909CF8", VA = "0x2909CF8")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2050C", Offset = "0xD2050C")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x2909D14", Offset = "0x2909D14", VA = "0x2909D14")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x2909D1C", Offset = "0x2909D1C", VA = "0x2909D1C")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x2909D38", Offset = "0x2909D38", VA = "0x2909D38")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2051C", Offset = "0xD2051C")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x2909D54", Offset = "0x2909D54", VA = "0x2909D54")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x2909D5C", Offset = "0x2909D5C", VA = "0x2909D5C")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x2909D78", Offset = "0x2909D78", VA = "0x2909D78")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2052C", Offset = "0xD2052C")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x2909D94", Offset = "0x2909D94", VA = "0x2909D94")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x2909D9C", Offset = "0x2909D9C", VA = "0x2909D9C")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x2909DB8", Offset = "0x2909DB8", VA = "0x2909DB8")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2053C", Offset = "0xD2053C")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x2909DD4", Offset = "0x2909DD4", VA = "0x2909DD4")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x2909DDC", Offset = "0x2909DDC", VA = "0x2909DDC")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x2909DF8", Offset = "0x2909DF8", VA = "0x2909DF8")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2054C", Offset = "0xD2054C")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2909E14", Offset = "0x2909E14", VA = "0x2909E14")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x2909E1C", Offset = "0x2909E1C", VA = "0x2909E1C")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x2909E38", Offset = "0x2909E38", VA = "0x2909E38")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2055C", Offset = "0xD2055C")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x2909E54", Offset = "0x2909E54", VA = "0x2909E54")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x2909E5C", Offset = "0x2909E5C", VA = "0x2909E5C")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2909E78", Offset = "0x2909E78", VA = "0x2909E78")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2056C", Offset = "0xD2056C")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x2909E94", Offset = "0x2909E94", VA = "0x2909E94")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x2909E9C", Offset = "0x2909E9C", VA = "0x2909E9C")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x2909EB8", Offset = "0x2909EB8", VA = "0x2909EB8")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2057C", Offset = "0xD2057C")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x2909F24", Offset = "0x2909F24", VA = "0x2909F24")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x2909F2C", Offset = "0x2909F2C", VA = "0x2909F2C")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x2909F48", Offset = "0x2909F48", VA = "0x2909F48")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2058C", Offset = "0xD2058C")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x2909F64", Offset = "0x2909F64", VA = "0x2909F64")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x2909F6C", Offset = "0x2909F6C", VA = "0x2909F6C")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x2909F88", Offset = "0x2909F88", VA = "0x2909F88")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2059C", Offset = "0xD2059C")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x2909FA4", Offset = "0x2909FA4", VA = "0x2909FA4")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2909FAC", Offset = "0x2909FAC", VA = "0x2909FAC")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2909FC8", Offset = "0x2909FC8", VA = "0x2909FC8")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD205AC", Offset = "0xD205AC")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x2909FE4", Offset = "0x2909FE4", VA = "0x2909FE4")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x2909FEC", Offset = "0x2909FEC", VA = "0x2909FEC")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x290A008", Offset = "0x290A008", VA = "0x290A008")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD205BC", Offset = "0xD205BC")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x290A024", Offset = "0x290A024", VA = "0x290A024")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x290A02C", Offset = "0x290A02C", VA = "0x290A02C")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x290A048", Offset = "0x290A048", VA = "0x290A048")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD205CC", Offset = "0xD205CC")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x290A064", Offset = "0x290A064", VA = "0x290A064")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x290A06C", Offset = "0x290A06C", VA = "0x290A06C")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x290A088", Offset = "0x290A088", VA = "0x290A088")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD205DC", Offset = "0xD205DC")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x290A0A4", Offset = "0x290A0A4", VA = "0x290A0A4")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x290A0AC", Offset = "0x290A0AC", VA = "0x290A0AC")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x290A0D4", Offset = "0x290A0D4", VA = "0x290A0D4")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD205EC", Offset = "0xD205EC")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x290A0F0", Offset = "0x290A0F0", VA = "0x290A0F0")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x290A0F8", Offset = "0x290A0F8", VA = "0x290A0F8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x290A120", Offset = "0x290A120", VA = "0x290A120")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD205FC", Offset = "0xD205FC")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x290A13C", Offset = "0x290A13C", VA = "0x290A13C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x290A144", Offset = "0x290A144", VA = "0x290A144")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x290A16C", Offset = "0x290A16C", VA = "0x290A16C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2060C", Offset = "0xD2060C")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x290A188", Offset = "0x290A188", VA = "0x290A188")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x290A190", Offset = "0x290A190", VA = "0x290A190")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x290A1AC", Offset = "0x290A1AC", VA = "0x290A1AC")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x290A1C8", Offset = "0x290A1C8", VA = "0x290A1C8")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x290A1FC", Offset = "0x290A1FC", VA = "0x290A1FC")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x290A218", Offset = "0x290A218", VA = "0x290A218")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x290A234", Offset = "0x290A234", VA = "0x290A234")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2061C", Offset = "0xD2061C")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x290A338", Offset = "0x290A338", VA = "0x290A338")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x290A340", Offset = "0x290A340", VA = "0x290A340")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x290A394", Offset = "0x290A394", VA = "0x290A394")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2062C", Offset = "0xD2062C")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x290A3E0", Offset = "0x290A3E0", VA = "0x290A3E0")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x290A3E8", Offset = "0x290A3E8", VA = "0x290A3E8")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x290A404", Offset = "0x290A404", VA = "0x290A404")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2063C", Offset = "0xD2063C")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x290A420", Offset = "0x290A420", VA = "0x290A420")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x290A428", Offset = "0x290A428", VA = "0x290A428")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x290A444", Offset = "0x290A444", VA = "0x290A444")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2064C", Offset = "0xD2064C")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x290A460", Offset = "0x290A460", VA = "0x290A460")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x290A468", Offset = "0x290A468", VA = "0x290A468")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x290A48C", Offset = "0x290A48C", VA = "0x290A48C")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2065C", Offset = "0xD2065C")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x290A4B0", Offset = "0x290A4B0", VA = "0x290A4B0")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x290A4B8", Offset = "0x290A4B8", VA = "0x290A4B8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x290A4DC", Offset = "0x290A4DC", VA = "0x290A4DC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2066C", Offset = "0xD2066C")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x290A500", Offset = "0x290A500", VA = "0x290A500")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x290A508", Offset = "0x290A508", VA = "0x290A508")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x290A510", Offset = "0x290A510", VA = "0x290A510")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2067C", Offset = "0xD2067C")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x290A5AC", Offset = "0x290A5AC", VA = "0x290A5AC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x290A5B4", Offset = "0x290A5B4", VA = "0x290A5B4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x290A5D8", Offset = "0x290A5D8", VA = "0x290A5D8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2068C", Offset = "0xD2068C")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x290A5FC", Offset = "0x290A5FC", VA = "0x290A5FC")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x290A604", Offset = "0x290A604", VA = "0x290A604")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x290A628", Offset = "0x290A628", VA = "0x290A628")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2069C", Offset = "0xD2069C")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x290A64C", Offset = "0x290A64C", VA = "0x290A64C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x290A654", Offset = "0x290A654", VA = "0x290A654")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x290A660", Offset = "0x290A660", VA = "0x290A660")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD206AC", Offset = "0xD206AC")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x290A71C", Offset = "0x290A71C", VA = "0x290A71C")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x290A724", Offset = "0x290A724", VA = "0x290A724")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x290A730", Offset = "0x290A730", VA = "0x290A730")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD206BC", Offset = "0xD206BC")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x290A83C", Offset = "0x290A83C", VA = "0x290A83C")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x290A844", Offset = "0x290A844", VA = "0x290A844")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x290A850", Offset = "0x290A850", VA = "0x290A850")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD206CC", Offset = "0xD206CC")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x290A90C", Offset = "0x290A90C", VA = "0x290A90C")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x290A914", Offset = "0x290A914", VA = "0x290A914")]
			internal Vector2 <DOShapeCircle>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x290A930", Offset = "0x290A930", VA = "0x290A930")]
			internal void <DOShapeCircle>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1F5AC4C", Offset = "0x1F5AC4C", VA = "0x1F5AC4C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1F5ADF4", Offset = "0x1F5ADF4", VA = "0x1F5ADF4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1F5AFC4", Offset = "0x1F5AFC4", VA = "0x1F5AFC4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1F5B16C", Offset = "0x1F5B16C", VA = "0x1F5B16C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1F5B33C", Offset = "0x1F5B33C", VA = "0x1F5B33C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1F5B4E4", Offset = "0x1F5B4E4", VA = "0x1F5B4E4")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1F5B6B0", Offset = "0x1F5B6B0", VA = "0x1F5B6B0")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1F5B8A4", Offset = "0x1F5B8A4", VA = "0x1F5B8A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1F5BA74", Offset = "0x1F5BA74", VA = "0x1F5BA74")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1F5BC44", Offset = "0x1F5BC44", VA = "0x1F5BC44")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1F5BE14", Offset = "0x1F5BE14", VA = "0x1F5BE14")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1F5BFE4", Offset = "0x1F5BFE4", VA = "0x1F5BFE4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1F5C18C", Offset = "0x1F5C18C", VA = "0x1F5C18C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1F5C344", Offset = "0x1F5C344", VA = "0x1F5C344")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1F5C514", Offset = "0x1F5C514", VA = "0x1F5C514")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1F5C6DC", Offset = "0x1F5C6DC", VA = "0x1F5C6DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1F5C8A4", Offset = "0x1F5C8A4", VA = "0x1F5C8A4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1F5CA7C", Offset = "0x1F5CA7C", VA = "0x1F5CA7C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1F5CC48", Offset = "0x1F5CC48", VA = "0x1F5CC48")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1F5CE14", Offset = "0x1F5CE14", VA = "0x1F5CE14")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1F5CFE0", Offset = "0x1F5CFE0", VA = "0x1F5CFE0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1F5D1B0", Offset = "0x1F5D1B0", VA = "0x1F5D1B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1F5D380", Offset = "0x1F5D380", VA = "0x1F5D380")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1F5D538", Offset = "0x1F5D538", VA = "0x1F5D538")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1F5D6F4", Offset = "0x1F5D6F4", VA = "0x1F5D6F4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1F5D8B0", Offset = "0x1F5D8B0", VA = "0x1F5D8B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1F5DA80", Offset = "0x1F5DA80", VA = "0x1F5DA80")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1F5DC58", Offset = "0x1F5DC58", VA = "0x1F5DC58")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1F5DE58", Offset = "0x1F5DE58", VA = "0x1F5DE58")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1F5E060", Offset = "0x1F5E060", VA = "0x1F5E060")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1F5E4B4", Offset = "0x1F5E4B4", VA = "0x1F5E4B4")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1F5E678", Offset = "0x1F5E678", VA = "0x1F5E678")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1F5E82C", Offset = "0x1F5E82C", VA = "0x1F5E82C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1F5E9E0", Offset = "0x1F5E9E0", VA = "0x1F5E9E0")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1F5EBA0", Offset = "0x1F5EBA0", VA = "0x1F5EBA0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1F5ED70", Offset = "0x1F5ED70", VA = "0x1F5ED70")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1F5EF98", Offset = "0x1F5EF98", VA = "0x1F5EF98")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1F5F140", Offset = "0x1F5F140", VA = "0x1F5F140")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1F5F394", Offset = "0x1F5F394", VA = "0x1F5F394")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1F5F5F8", Offset = "0x1F5F5F8", VA = "0x1F5F5F8")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1F5F85C", Offset = "0x1F5F85C", VA = "0x1F5F85C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1F5FAC0", Offset = "0x1F5FAC0", VA = "0x1F5FAC0")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD206EC", Offset = "0xD206EC")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x290AE78", Offset = "0x290AE78", VA = "0x290AE78")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x290AE80", Offset = "0x290AE80", VA = "0x290AE80")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x290AEA4", Offset = "0x290AEA4", VA = "0x290AEA4")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD206FC", Offset = "0xD206FC")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x290AEC8", Offset = "0x290AEC8", VA = "0x290AEC8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x290AED0", Offset = "0x290AED0", VA = "0x290AED0")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x290AEF4", Offset = "0x290AEF4", VA = "0x290AEF4")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2070C", Offset = "0xD2070C")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x290AF18", Offset = "0x290AF18", VA = "0x290AF18", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x290B15C", Offset = "0x290B15C", VA = "0x290B15C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2071C", Offset = "0xD2071C")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x290B86C", Offset = "0x290B86C", VA = "0x290B86C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x290BAD4", Offset = "0x290BAD4", VA = "0x290BAD4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2072C", Offset = "0xD2072C")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x290B3C0", Offset = "0x290B3C0", VA = "0x290B3C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x290B5F0", Offset = "0x290B5F0", VA = "0x290B5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2073C", Offset = "0xD2073C")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x290B168", Offset = "0x290B168", VA = "0x290B168", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x290B3B4", Offset = "0x290B3B4", VA = "0x290B3B4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2074C", Offset = "0xD2074C")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x290B5FC", Offset = "0x290B5FC", VA = "0x290B5FC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x290B860", Offset = "0x290B860", VA = "0x290B860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2075C", Offset = "0xD2075C")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x290BAE0", Offset = "0x290BAE0", VA = "0x290BAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x290BD18", Offset = "0x290BD18", VA = "0x290BD18", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1F5FCD0", Offset = "0x1F5FCD0", VA = "0x1F5FCD0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1F5FEC0", Offset = "0x1F5FEC0", VA = "0x1F5FEC0")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1F600C4", Offset = "0x1F600C4", VA = "0x1F600C4")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1F60184", Offset = "0x1F60184", VA = "0x1F60184")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1F60244", Offset = "0x1F60244", VA = "0x1F60244")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1F60304", Offset = "0x1F60304", VA = "0x1F60304")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1F603D4", Offset = "0x1F603D4", VA = "0x1F603D4")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1F604A4", Offset = "0x1F604A4", VA = "0x1F604A4")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1F60564", Offset = "0x1F60564", VA = "0x1F60564")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1F6078C", Offset = "0x1F6078C", VA = "0x1F6078C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1F609B4", Offset = "0x1F609B4", VA = "0x1F609B4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xD29FCC", Offset = "0xD29FCC")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1F60AD0", Offset = "0x1F60AD0", VA = "0x1F60AD0")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xD2A03C", Offset = "0xD2A03C")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1F60BEC", Offset = "0x1F60BEC", VA = "0x1F60BEC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xD2A0AC", Offset = "0xD2A0AC")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1F60D08", Offset = "0x1F60D08", VA = "0x1F60D08")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xD2A11C", Offset = "0xD2A11C")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x1F60E34", Offset = "0x1F60E34", VA = "0x1F60E34")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xD2A18C", Offset = "0xD2A18C")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1F60F60", Offset = "0x1F60F60", VA = "0x1F60F60")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xD2A1FC", Offset = "0xD2A1FC")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000119")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200011A")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B6")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600079B")]
				[Address(RVA = "0x290931C", Offset = "0x290931C", VA = "0x290931C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x2909350", Offset = "0x2909350", VA = "0x2909350")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x200011B")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B7")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x2909514", Offset = "0x2909514", VA = "0x2909514", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x2909578", Offset = "0x2909578", VA = "0x2909578")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x200011C")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000B8")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600079F")]
				[Address(RVA = "0x2909418", Offset = "0x2909418", VA = "0x2909418", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x2909434", Offset = "0x2909434", VA = "0x2909434")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x200011D")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000B9")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007A1")]
				[Address(RVA = "0x2909384", Offset = "0x2909384", VA = "0x2909384", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x29093D0", Offset = "0x29093D0", VA = "0x29093D0")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200011E")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000BA")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x2909468", Offset = "0x2909468", VA = "0x2909468", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x29094CC", Offset = "0x29094CC", VA = "0x29094CC")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200011F")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000BB")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x29095AC", Offset = "0x29095AC", VA = "0x29095AC", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x29095E0", Offset = "0x29095E0", VA = "0x29095E0")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000120")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000121")]
		public static class Physics
		{
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x290BD24", Offset = "0x290BD24", VA = "0x290BD24")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x290BE28", Offset = "0x290BE28", VA = "0x290BE28")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x290BE30", Offset = "0x290BE30", VA = "0x290BE30")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x290BEC8", Offset = "0x290BEC8", VA = "0x290BEC8")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1F6107C", Offset = "0x1F6107C", VA = "0x1F6107C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1F61140", Offset = "0x1F61140", VA = "0x1F61140")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace CheapBirds
{
	[Token(Token = "0x2000122")]
	public class CameraControl : MonoBehaviour
	{
		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float panSpeed;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotSpeed;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scrollScale;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform yaw;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pitch;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform cam;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastMousePos;

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1F57954", Offset = "0x1F57954", VA = "0x1F57954")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1F57AD4", Offset = "0x1F57AD4", VA = "0x1F57AD4")]
		public CameraControl()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[ExecuteInEditMode]
	public class CheapBirdsSettings : MonoBehaviour
	{
		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float emitterDistance;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float emitterWidth;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float emitterHeight;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float particleLife;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float particleSize;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float particleSpeed;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spritesheetFps;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int numFrames;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float emissionRate;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int maxBirds;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool overrideVelocity;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float horizontalSpread;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float verticalSpread;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool useBidirectionalEmitter;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem ps;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationCurve minCurve;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AnimationCurve maxCurve;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1F57B18", Offset = "0x1F57B18", VA = "0x1F57B18")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1F57EDC", Offset = "0x1F57EDC", VA = "0x1F57EDC")]
		public void SyncVarsFromParticleSystem()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1F580D8", Offset = "0x1F580D8", VA = "0x1F580D8")]
		public void ApplyChanges()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1F584E8", Offset = "0x1F584E8", VA = "0x1F584E8")]
		public CheapBirdsSettings()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[ExecuteInEditMode]
	public class SpritesheetGeneratorCameras : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		public enum NumAngles
		{
			[Token(Token = "0x4000698")]
			Three,
			[Token(Token = "0x4000699")]
			Six
		}

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject animObject;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animation animation;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animator animator;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NumAngles numAngles;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float viewSize;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int tileSize;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD27724", Offset = "0xD27724")]
		private int <sheetSize>k__BackingField;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera[] cams;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useLastFrame;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int frameCounter;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RenderTexture rt;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rect r;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int numFrames;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int hres;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int vres;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float colSizeNorm;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float rowSizeNorm;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string filePath;

		[Token(Token = "0x170000BC")]
		public int sheetSize
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x2CB42D4", Offset = "0x2CB42D4", VA = "0x2CB42D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A30C", Offset = "0xD2A30C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x2CB42DC", Offset = "0x2CB42DC", VA = "0x2CB42DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xD2A31C", Offset = "0xD2A31C")]
			private set
			{
			}
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x2CB42E4", Offset = "0x2CB42E4", VA = "0x2CB42E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x2CB4340", Offset = "0x2CB4340", VA = "0x2CB4340")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x2CB44D8", Offset = "0x2CB44D8", VA = "0x2CB44D8")]
		private static AnimationClip GetClip(GameObject animatedObject)
		{
			return null;
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x2CB4618", Offset = "0x2CB4618", VA = "0x2CB4618")]
		private static AnimationClip GetClip(Animator animator)
		{
			return null;
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x2CB4600", Offset = "0x2CB4600", VA = "0x2CB4600")]
		private static AnimationClip GetClip(Animation a)
		{
			return null;
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x2CB46E8", Offset = "0x2CB46E8", VA = "0x2CB46E8")]
		public static uint CalcNumFrames(AnimationClip clip)
		{
			return default(uint);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x2CB4740", Offset = "0x2CB4740", VA = "0x2CB4740")]
		public static uint CalcNumFrames(Animator animator)
		{
			return default(uint);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x2CB47D4", Offset = "0x2CB47D4", VA = "0x2CB47D4")]
		public static uint CalcNumFrames(Animation a)
		{
			return default(uint);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x2CB47F4", Offset = "0x2CB47F4", VA = "0x2CB47F4")]
		public static uint CalcNumFrames(GameObject animatedObject)
		{
			return default(uint);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x2CB4990", Offset = "0x2CB4990", VA = "0x2CB4990")]
		private static float CalcFrameLength(Animator a)
		{
			return default(float);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2CB49E0", Offset = "0x2CB49E0", VA = "0x2CB49E0")]
		public void ConfigureCamerasForEditMode()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2CB4D78", Offset = "0x2CB4D78", VA = "0x2CB4D78")]
		private void SetAnimationFrame(int frame)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x2CB4EE8", Offset = "0x2CB4EE8", VA = "0x2CB4EE8")]
		public void SetAnimationNormalisedTime(float time)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2CB509C", Offset = "0x2CB509C", VA = "0x2CB509C")]
		public void SetAnimatedObject(GameObject newObject)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2CB524C", Offset = "0x2CB524C", VA = "0x2CB524C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2CB5870", Offset = "0x2CB5870", VA = "0x2CB5870")]
		public void GenerateSpritesheet(string path)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2CB58FC", Offset = "0x2CB58FC", VA = "0x2CB58FC")]
		public SpritesheetGeneratorCameras()
		{
		}
	}
}
namespace CheapBirds.Utils
{
	[Token(Token = "0x2000126")]
	public class Misc
	{
		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string lastUndoEventName;

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x2CACD70", Offset = "0x2CACD70", VA = "0x2CACD70")]
		public Misc()
		{
		}
	}
}
