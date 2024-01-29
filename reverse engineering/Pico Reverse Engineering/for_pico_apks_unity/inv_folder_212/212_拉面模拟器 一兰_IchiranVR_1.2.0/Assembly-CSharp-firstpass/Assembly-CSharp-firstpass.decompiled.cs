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
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928500", Offset = "0x928500")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928500", Offset = "0x928500")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x928FC4", Offset = "0x928FC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x928FC4", Offset = "0x928FC4")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92901C", Offset = "0x92901C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92901C", Offset = "0x92901C")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929074", Offset = "0x929074")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9290AC", Offset = "0x9290AC")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9290E4", Offset = "0x9290E4")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92911C", Offset = "0x92911C")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929154", Offset = "0x929154")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92918C", Offset = "0x92918C")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9291C4", Offset = "0x9291C4")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9291FC", Offset = "0x9291FC")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92920C", Offset = "0x92920C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92923C", Offset = "0x92923C")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1491CFC", Offset = "0x1491CFC", VA = "0x1491CFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93156C", Offset = "0x93156C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1491D04", Offset = "0x1491D04", VA = "0x1491D04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93157C", Offset = "0x93157C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1491D10", Offset = "0x1491D10", VA = "0x1491D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93158C", Offset = "0x93158C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1491D18", Offset = "0x1491D18", VA = "0x1491D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93159C", Offset = "0x93159C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1491D20", Offset = "0x1491D20", VA = "0x1491D20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9315AC", Offset = "0x9315AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1491D28", Offset = "0x1491D28", VA = "0x1491D28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9315BC", Offset = "0x9315BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1491BCC", Offset = "0x1491BCC", VA = "0x1491BCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93148C", Offset = "0x93148C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1491C18", Offset = "0x1491C18", VA = "0x1491C18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9314C4", Offset = "0x9314C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1491C64", Offset = "0x1491C64", VA = "0x1491C64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9314FC", Offset = "0x9314FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1491CB0", Offset = "0x1491CB0", VA = "0x1491CB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931534", Offset = "0x931534")]
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
		[Address(RVA = "0x1491D30", Offset = "0x1491D30", VA = "0x1491D30")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1491D34", Offset = "0x1491D34", VA = "0x1491D34")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1491D38", Offset = "0x1491D38", VA = "0x1491D38")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1491D3C", Offset = "0x1491D3C", VA = "0x1491D3C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92924C", Offset = "0x92924C")]
		public bool markAsLegacy;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929284", Offset = "0x929284")]
		public Transform root;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9292BC", Offset = "0x9292BC")]
		public Transform rootNode;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9292F4", Offset = "0x9292F4")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92932C", Offset = "0x92932C")]
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
		[Address(RVA = "0x145B8A0", Offset = "0x145B8A0", VA = "0x145B8A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x145BC80", Offset = "0x145BC80", VA = "0x145BC80", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x145BC88", Offset = "0x145BC88", VA = "0x145BC88", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x145BD98", Offset = "0x145BD98", VA = "0x145BD98", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x145BE14", Offset = "0x145BE14", VA = "0x145BE14", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x145BE90", Offset = "0x145BE90", VA = "0x145BE90", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x145BAD0", Offset = "0x145BAD0", VA = "0x145BAD0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x145BBA8", Offset = "0x145BBA8", VA = "0x145BBA8")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x145BF0C", Offset = "0x145BF0C", VA = "0x145BF0C")]
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
		[Address(RVA = "0x1460F58", Offset = "0x1460F58", VA = "0x1460F58")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1490B90", Offset = "0x1490B90", VA = "0x1490B90")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1490DB0", Offset = "0x1490DB0", VA = "0x1490DB0")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1490D90", Offset = "0x1490D90", VA = "0x1490D90")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1491448", Offset = "0x1491448", VA = "0x1491448")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x14930EC", Offset = "0x14930EC", VA = "0x14930EC")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1494638", Offset = "0x1494638", VA = "0x1494638")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1492B00", Offset = "0x1492B00", VA = "0x1492B00")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1493134", Offset = "0x1493134", VA = "0x1493134")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1492638", Offset = "0x1492638", VA = "0x1492638")]
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
		[Address(RVA = "0x1491E2C", Offset = "0x1491E2C", VA = "0x1491E2C")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1492124", Offset = "0x1492124", VA = "0x1492124")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1491FA0", Offset = "0x1491FA0", VA = "0x1491FA0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x14922BC", Offset = "0x14922BC", VA = "0x14922BC")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1492894", Offset = "0x1492894", VA = "0x1492894")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1492990", Offset = "0x1492990", VA = "0x1492990")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1492A8C", Offset = "0x1492A8C", VA = "0x1492A8C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1492A04", Offset = "0x1492A04", VA = "0x1492A04")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1492D4C", Offset = "0x1492D4C", VA = "0x1492D4C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1492E00", Offset = "0x1492E00", VA = "0x1492E00")]
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
		[Address(RVA = "0x1493138", Offset = "0x1493138", VA = "0x1493138")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x14931B4", Offset = "0x14931B4", VA = "0x14931B4")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x14938A4", Offset = "0x14938A4", VA = "0x14938A4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1493958", Offset = "0x1493958", VA = "0x1493958")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x149383C", Offset = "0x149383C", VA = "0x149383C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1493A3C", Offset = "0x1493A3C", VA = "0x1493A3C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1493A84", Offset = "0x1493A84", VA = "0x1493A84")]
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
		[Address(RVA = "0x1493A8C", Offset = "0x1493A8C", VA = "0x1493A8C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1493C84", Offset = "0x1493C84", VA = "0x1493C84")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1493C98", Offset = "0x1493C98", VA = "0x1493C98")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1493F28", Offset = "0x1493F28", VA = "0x1493F28")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1493B3C", Offset = "0x1493B3C", VA = "0x1493B3C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1494174", Offset = "0x1494174", VA = "0x1494174")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x14941E8", Offset = "0x14941E8", VA = "0x14941E8")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1494434", Offset = "0x1494434", VA = "0x1494434")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929364", Offset = "0x929364")]
		public bool bakeHandIK;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92939C", Offset = "0x92939C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92939C", Offset = "0x92939C")]
		public float IKKeyReductionError;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9293F4", Offset = "0x9293F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9293F4", Offset = "0x9293F4")]
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
		[Address(RVA = "0x145CE58", Offset = "0x145CE58", VA = "0x145CE58")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x145D33C", Offset = "0x145D33C", VA = "0x145D33C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x145D358", Offset = "0x145D358", VA = "0x145D358", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x145D478", Offset = "0x145D478", VA = "0x145D478", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x145D554", Offset = "0x145D554", VA = "0x145D554", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x145D724", Offset = "0x145D724", VA = "0x145D724", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x145DABC", Offset = "0x145DABC", VA = "0x145DABC")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x145DB98", Offset = "0x145DB98", VA = "0x145DB98")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x929448", Offset = "0x929448")]
		public bool smoothFollow;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x929480", Offset = "0x929480")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9294B8", Offset = "0x9294B8")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9294F0", Offset = "0x9294F0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929528", Offset = "0x929528")]
		public float blockedOffset;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x929540", Offset = "0x929540")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x929550", Offset = "0x929550")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x929560", Offset = "0x929560")]
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
			[Address(RVA = "0x149BD08", Offset = "0x149BD08", VA = "0x149BD08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9315CC", Offset = "0x9315CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x149BD10", Offset = "0x149BD10", VA = "0x149BD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9315DC", Offset = "0x9315DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x149BD18", Offset = "0x149BD18", VA = "0x149BD18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9315EC", Offset = "0x9315EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x149BD20", Offset = "0x149BD20", VA = "0x149BD20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9315FC", Offset = "0x9315FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x149BD28", Offset = "0x149BD28", VA = "0x149BD28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93160C", Offset = "0x93160C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x149BD30", Offset = "0x149BD30", VA = "0x149BD30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93161C", Offset = "0x93161C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x149C86C", Offset = "0x149C86C", VA = "0x149C86C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x149BD38", Offset = "0x149BD38", VA = "0x149BD38")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x149BD74", Offset = "0x149BD74", VA = "0x149BD74")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x149BD7C", Offset = "0x149BD7C", VA = "0x149BD7C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x149BEA4", Offset = "0x149BEA4", VA = "0x149BEA4", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x149BF00", Offset = "0x149BF00", VA = "0x149BF00", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x149BF68", Offset = "0x149BF68", VA = "0x149BF68", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x149BFCC", Offset = "0x149BFCC", VA = "0x149BFCC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x149BED8", Offset = "0x149BED8", VA = "0x149BED8")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x149C14C", Offset = "0x149C14C", VA = "0x149C14C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x149C7BC", Offset = "0x149C7BC", VA = "0x149C7BC")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x149C8E0", Offset = "0x149C8E0", VA = "0x149C8E0")]
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
		[Address(RVA = "0x149C9F8", Offset = "0x149C9F8", VA = "0x149C9F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x149CA30", Offset = "0x149CA30", VA = "0x149CA30")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x149CBE8", Offset = "0x149CBE8", VA = "0x149CBE8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x149CC98", Offset = "0x149CC98", VA = "0x149CC98")]
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
		[Address(RVA = "0x1491450", Offset = "0x1491450", VA = "0x1491450")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1491508", Offset = "0x1491508", VA = "0x1491508")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x14915B4", Offset = "0x14915B4", VA = "0x14915B4")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1491798", Offset = "0x1491798", VA = "0x1491798")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x14916D0", Offset = "0x14916D0", VA = "0x14916D0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x14918B4", Offset = "0x14918B4", VA = "0x14918B4")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x14918FC", Offset = "0x14918FC", VA = "0x14918FC")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1491BC4", Offset = "0x1491BC4", VA = "0x1491BC4")]
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
			[Address(RVA = "0x1494D18", Offset = "0x1494D18", VA = "0x1494D18")]
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
			[Address(RVA = "0x1494AA0", Offset = "0x1494AA0", VA = "0x1494AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1494D90", Offset = "0x1494D90", VA = "0x1494D90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1494A20", Offset = "0x1494A20", VA = "0x1494A20")]
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
		[Address(RVA = "0x1495008", Offset = "0x1495008", VA = "0x1495008")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1495310", Offset = "0x1495310", VA = "0x1495310")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1495568", Offset = "0x1495568", VA = "0x1495568")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x14955EC", Offset = "0x14955EC", VA = "0x14955EC")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1495698", Offset = "0x1495698", VA = "0x1495698")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x14951C0", Offset = "0x14951C0", VA = "0x14951C0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x14954C8", Offset = "0x14954C8", VA = "0x14954C8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1495ED8", Offset = "0x1495ED8", VA = "0x1495ED8")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1495CF0", Offset = "0x1495CF0", VA = "0x1495CF0")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1495DE4", Offset = "0x1495DE4", VA = "0x1495DE4")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x14958B8", Offset = "0x14958B8", VA = "0x14958B8")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x149596C", Offset = "0x149596C", VA = "0x149596C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1495A20", Offset = "0x1495A20", VA = "0x1495A20")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1495AD4", Offset = "0x1495AD4", VA = "0x1495AD4")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1495B88", Offset = "0x1495B88", VA = "0x1495B88")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1495C3C", Offset = "0x1495C3C", VA = "0x1495C3C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x14960EC", Offset = "0x14960EC", VA = "0x14960EC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x14957CC", Offset = "0x14957CC", VA = "0x14957CC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x149605C", Offset = "0x149605C", VA = "0x149605C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x149615C", Offset = "0x149615C", VA = "0x149615C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1496234", Offset = "0x1496234", VA = "0x1496234")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1495FE0", Offset = "0x1495FE0", VA = "0x1495FE0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1495F68", Offset = "0x1495F68", VA = "0x1495F68")]
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
				[Address(RVA = "0x149BD00", Offset = "0x149BD00", VA = "0x149BD00")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0x9D7E04", Offset = "0x9D7E04", VA = "0x9D7E04")]
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
			[Address(RVA = "0x14985CC", Offset = "0x14985CC", VA = "0x14985CC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x14989B8", Offset = "0x14989B8", VA = "0x14989B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x14989C8", Offset = "0x14989C8", VA = "0x14989C8", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1498DF4", Offset = "0x1498DF4", VA = "0x1498DF4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x149922C", Offset = "0x149922C", VA = "0x149922C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1499938", Offset = "0x1499938", VA = "0x1499938")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x14994A8", Offset = "0x14994A8", VA = "0x14994A8")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x149A16C", Offset = "0x149A16C", VA = "0x149A16C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x149A26C", Offset = "0x149A26C", VA = "0x149A26C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x149A820", Offset = "0x149A820", VA = "0x149A820")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x149A610", Offset = "0x149A610", VA = "0x149A610")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x149A488", Offset = "0x149A488", VA = "0x149A488")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x149A30C", Offset = "0x149A30C", VA = "0x149A30C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x149A714", Offset = "0x149A714", VA = "0x149A714")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x149A91C", Offset = "0x149A91C", VA = "0x149A91C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x149B480", Offset = "0x149B480", VA = "0x149B480")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x149AF4C", Offset = "0x149AF4C", VA = "0x149AF4C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x149B7C8", Offset = "0x149B7C8", VA = "0x149B7C8")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x149B298", Offset = "0x149B298", VA = "0x149B298")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x149B7D0", Offset = "0x149B7D0", VA = "0x149B7D0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x149B7D8", Offset = "0x149B7D8", VA = "0x149B7D8")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x149B9A4", Offset = "0x149B9A4", VA = "0x149B9A4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x149BBC8", Offset = "0x149BBC8", VA = "0x149BBC8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1499420", Offset = "0x1499420", VA = "0x1499420")]
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
		[Address(RVA = "0x149CCB4", Offset = "0x149CCB4", VA = "0x149CCB4")]
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
		[Address(RVA = "0x149CCBC", Offset = "0x149CCBC", VA = "0x149CCBC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x149CDFC", Offset = "0x149CDFC", VA = "0x149CDFC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class Hierarchy
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x145BF80", Offset = "0x145BF80", VA = "0x145BF80")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x145C180", Offset = "0x145C180", VA = "0x145C180")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x145C018", Offset = "0x145C018", VA = "0x145C018")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x145C2A4", Offset = "0x145C2A4", VA = "0x145C2A4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x145C3C8", Offset = "0x145C3C8", VA = "0x145C3C8")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x145C678", Offset = "0x145C678", VA = "0x145C678")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x145C794", Offset = "0x145C794", VA = "0x145C794")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x145C91C", Offset = "0x145C91C", VA = "0x145C91C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x145CCB0", Offset = "0x145CCB0", VA = "0x145CCB0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x145CA9C", Offset = "0x145CA9C", VA = "0x145CA9C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x145CE50", Offset = "0x145CE50", VA = "0x145CE50")]
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
		[Address(RVA = "0x145DC58", Offset = "0x145DC58", VA = "0x145DC58")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x145DCE8", Offset = "0x145DCE8", VA = "0x145DCE8")]
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
		[Address(RVA = "0x145DD7C", Offset = "0x145DD7C", VA = "0x145DD7C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x145E7E4", Offset = "0x145E7E4", VA = "0x145E7E4")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x145E8EC", Offset = "0x145E8EC", VA = "0x145E8EC")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x145E0E8", Offset = "0x145E0E8", VA = "0x145E0E8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x145E0F4", Offset = "0x145E0F4", VA = "0x145E0F4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x145E118", Offset = "0x145E118", VA = "0x145E118")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x145E154", Offset = "0x145E154", VA = "0x145E154")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x145E16C", Offset = "0x145E16C", VA = "0x145E16C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x145E180", Offset = "0x145E180", VA = "0x145E180")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x145E194", Offset = "0x145E194", VA = "0x145E194")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x145E1A4", Offset = "0x145E1A4", VA = "0x145E1A4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x145E1EC", Offset = "0x145E1EC", VA = "0x145E1EC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x145E224", Offset = "0x145E224", VA = "0x145E224")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x145E24C", Offset = "0x145E24C", VA = "0x145E24C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x145E9E8", Offset = "0x145E9E8", VA = "0x145E9E8")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x145E280", Offset = "0x145E280", VA = "0x145E280")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x145E2A8", Offset = "0x145E2A8", VA = "0x145E2A8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x145E2D8", Offset = "0x145E2D8", VA = "0x145E2D8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x145E30C", Offset = "0x145E30C", VA = "0x145E30C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x145E350", Offset = "0x145E350", VA = "0x145E350")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x145E3B4", Offset = "0x145E3B4", VA = "0x145E3B4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x145E418", Offset = "0x145E418", VA = "0x145E418")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x145E46C", Offset = "0x145E46C", VA = "0x145E46C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x145E4C0", Offset = "0x145E4C0", VA = "0x145E4C0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x145E558", Offset = "0x145E558", VA = "0x145E558")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x145E5EC", Offset = "0x145E5EC", VA = "0x145E5EC")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x145EA1C", Offset = "0x145EA1C", VA = "0x145EA1C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x145E690", Offset = "0x145E690", VA = "0x145E690")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x145E774", Offset = "0x145E774", VA = "0x145E774")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x145E7A4", Offset = "0x145E7A4", VA = "0x145E7A4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x145EB04", Offset = "0x145EB04", VA = "0x145EB04")]
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
		[Address(RVA = "0x145EB0C", Offset = "0x145EB0C", VA = "0x145EB0C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x145EB9C", Offset = "0x145EB9C", VA = "0x145EB9C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x145EC30", Offset = "0x145EC30", VA = "0x145EC30")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x145EC88", Offset = "0x145EC88", VA = "0x145EC88")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x145ED54", Offset = "0x145ED54", VA = "0x145ED54")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x145ECA0", Offset = "0x145ECA0", VA = "0x145ECA0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x145ED6C", Offset = "0x145ED6C", VA = "0x145ED6C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x145EE10", Offset = "0x145EE10", VA = "0x145EE10")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x145EE3C", Offset = "0x145EE3C", VA = "0x145EE3C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x145EE8C", Offset = "0x145EE8C", VA = "0x145EE8C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x145EEF8", Offset = "0x145EEF8", VA = "0x145EEF8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x145EFEC", Offset = "0x145EFEC", VA = "0x145EFEC")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x145F0C4", Offset = "0x145F0C4", VA = "0x145F0C4")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x145F124", Offset = "0x145F124", VA = "0x145F124")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200001A")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x145F154", Offset = "0x145F154", VA = "0x145F154")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x145F258", Offset = "0x145F258", VA = "0x145F258")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x145F358", Offset = "0x145F358", VA = "0x145F358")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x145F554", Offset = "0x145F554", VA = "0x145F554")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x145F6C8", Offset = "0x145F6C8", VA = "0x145F6C8")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x145F834", Offset = "0x145F834", VA = "0x145F834")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x145FA90", Offset = "0x145FA90", VA = "0x145FA90")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x145FBDC", Offset = "0x145FBDC", VA = "0x145FBDC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x145FD28", Offset = "0x145FD28", VA = "0x145FD28")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x145FE3C", Offset = "0x145FE3C", VA = "0x145FE3C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x145FF50", Offset = "0x145FF50", VA = "0x145FF50")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x14600DC", Offset = "0x14600DC", VA = "0x14600DC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x144EA38", Offset = "0x144EA38", VA = "0x144EA38")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x14601AC", Offset = "0x14601AC", VA = "0x14601AC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1460430", Offset = "0x1460430", VA = "0x1460430")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1460644", Offset = "0x1460644", VA = "0x1460644")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1457DC8", Offset = "0x1457DC8", VA = "0x1457DC8")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x14607C4", Offset = "0x14607C4", VA = "0x14607C4")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x14608D4", Offset = "0x14608D4", VA = "0x14608D4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929580", Offset = "0x929580")]
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
			[Address(RVA = "0x1460A68", Offset = "0x1460A68", VA = "0x1460A68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1460D9C", Offset = "0x1460D9C", VA = "0x1460D9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1460930", Offset = "0x1460930", VA = "0x1460930")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x14609C8", Offset = "0x14609C8", VA = "0x14609C8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x14609CC", Offset = "0x14609CC", VA = "0x14609CC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x14609D0", Offset = "0x14609D0", VA = "0x14609D0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x14609D4", Offset = "0x14609D4", VA = "0x14609D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1460A64", Offset = "0x1460A64", VA = "0x1460A64")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1460A0C", Offset = "0x1460A0C", VA = "0x1460A0C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1460D50", Offset = "0x1460D50", VA = "0x1460D50")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1460B58", Offset = "0x1460B58", VA = "0x1460B58")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1460E58", Offset = "0x1460E58", VA = "0x1460E58")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1460EB4", Offset = "0x1460EB4", VA = "0x1460EB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1460F10", Offset = "0x1460F10", VA = "0x1460F10")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x144CF28", Offset = "0x144CF28", VA = "0x144CF28")]
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
		[Address(RVA = "0x1460FC8", Offset = "0x1460FC8", VA = "0x1460FC8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1461080", Offset = "0x1461080", VA = "0x1461080")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1461138", Offset = "0x1461138", VA = "0x1461138")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x14611F0", Offset = "0x14611F0", VA = "0x14611F0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x14611F8", Offset = "0x14611F8", VA = "0x14611F8")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1461228", Offset = "0x1461228", VA = "0x1461228")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x14612D4", Offset = "0x14612D4", VA = "0x14612D4")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1461380", Offset = "0x1461380", VA = "0x1461380")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1461550", Offset = "0x1461550", VA = "0x1461550")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200001F")]
	public static class V3Tools
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1B44ADC", Offset = "0x1B44ADC", VA = "0x1B44ADC")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1B44B60", Offset = "0x1B44B60", VA = "0x1B44B60")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1B44C00", Offset = "0x1B44C00", VA = "0x1B44C00")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1B44D44", Offset = "0x1B44D44", VA = "0x1B44D44")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1B44E64", Offset = "0x1B44E64", VA = "0x1B44E64")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1B44F7C", Offset = "0x1B44F7C", VA = "0x1B44F7C")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1B45140", Offset = "0x1B45140", VA = "0x1B45140")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1B45238", Offset = "0x1B45238", VA = "0x1B45238")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1B45330", Offset = "0x1B45330", VA = "0x1B45330")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1B45428", Offset = "0x1B45428", VA = "0x1B45428")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1B45528", Offset = "0x1B45528", VA = "0x1B45528")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1B4574C", Offset = "0x1B4574C", VA = "0x1B4574C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1B45988", Offset = "0x1B45988", VA = "0x1B45988")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1B45BD8", Offset = "0x1B45BD8", VA = "0x1B45BD8")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1B45DD8", Offset = "0x1B45DD8", VA = "0x1B45DD8")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1B45FB4", Offset = "0x1B45FB4", VA = "0x1B45FB4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1B460E8", Offset = "0x1B460E8", VA = "0x1B460E8")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1B46240", Offset = "0x1B46240", VA = "0x1B46240")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1B463CC", Offset = "0x1B463CC", VA = "0x1B463CC")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1B4638C", Offset = "0x1B4638C", VA = "0x1B4638C")]
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
		[Address(RVA = "0x1B46508", Offset = "0x1B46508", VA = "0x1B46508")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1B46934", Offset = "0x1B46934", VA = "0x1B46934")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928570", Offset = "0x928570")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928570", Offset = "0x928570")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10A193C", Offset = "0x10A193C", VA = "0x10A193C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93169C", Offset = "0x93169C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x10A1988", Offset = "0x10A1988", VA = "0x10A1988")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9316D4", Offset = "0x9316D4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x10A19D4", Offset = "0x10A19D4", VA = "0x10A19D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93170C", Offset = "0x93170C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x10A1A20", Offset = "0x10A1A20", VA = "0x10A1A20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931744", Offset = "0x931744")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x10A1A6C", Offset = "0x10A1A6C", VA = "0x10A1A6C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10A1B08", Offset = "0x10A1B08", VA = "0x10A1B08")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x10A1B28", Offset = "0x10A1B28", VA = "0x10A1B28")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10A1B58", Offset = "0x10A1B58", VA = "0x10A1B58")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x10A1B88", Offset = "0x10A1B88", VA = "0x10A1B88")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x10A1BC8", Offset = "0x10A1BC8", VA = "0x10A1BC8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10A1C0C", Offset = "0x10A1C0C", VA = "0x10A1C0C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x10A1C30", Offset = "0x10A1C30", VA = "0x10A1C30")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x10A1C54", Offset = "0x10A1C54", VA = "0x10A1C54")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x10A1C7C", Offset = "0x10A1C7C", VA = "0x10A1C7C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x10A1CA8", Offset = "0x10A1CA8", VA = "0x10A1CA8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x10A1CD4", Offset = "0x10A1CD4", VA = "0x10A1CD4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x10A1A8C", Offset = "0x10A1A8C", VA = "0x10A1A8C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10A1CFC", Offset = "0x10A1CFC", VA = "0x10A1CFC")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10A1D08", Offset = "0x10A1D08", VA = "0x10A1D08")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10A1D14", Offset = "0x10A1D14", VA = "0x10A1D14")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10A203C", Offset = "0x10A203C", VA = "0x10A203C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10A20E4", Offset = "0x10A20E4", VA = "0x10A20E4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10A2430", Offset = "0x10A2430", VA = "0x10A2430", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10A2918", Offset = "0x10A2918", VA = "0x10A2918")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x10A294C", Offset = "0x10A294C", VA = "0x10A294C")]
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
			[Address(RVA = "0x10A1EB4", Offset = "0x10A1EB4", VA = "0x10A1EB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x10A2B90", Offset = "0x10A2B90", VA = "0x10A2B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x10A22B4", Offset = "0x10A22B4", VA = "0x10A22B4")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10A29E8", Offset = "0x10A29E8", VA = "0x10A29E8")]
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
			[Address(RVA = "0x10A370C", Offset = "0x10A370C", VA = "0x10A370C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000139")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x10A377C", Offset = "0x10A377C", VA = "0x10A377C")]
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
		[Address(RVA = "0x10A3784", Offset = "0x10A3784", VA = "0x10A3784", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x10A3890", Offset = "0x10A3890", VA = "0x10A3890")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x10A3898", Offset = "0x10A3898", VA = "0x10A3898")]
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
			[Address(RVA = "0x10A3A68", Offset = "0x10A3A68", VA = "0x10A3A68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x10A38CC", Offset = "0x10A38CC", VA = "0x10A38CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10A3B24", Offset = "0x10A3B24", VA = "0x10A3B24")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x10A3B2C", Offset = "0x10A3B2C", VA = "0x10A3B2C")]
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
		[Address(RVA = "0x10A3B60", Offset = "0x10A3B60", VA = "0x10A3B60", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10A3C88", Offset = "0x10A3C88", VA = "0x10A3C88")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x10A3C90", Offset = "0x10A3C90", VA = "0x10A3C90")]
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
			[Address(RVA = "0x10A3E64", Offset = "0x10A3E64", VA = "0x10A3E64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x10A3CC4", Offset = "0x10A3CC4", VA = "0x10A3CC4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10A3F34", Offset = "0x10A3F34", VA = "0x10A3F34")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x10A3F3C", Offset = "0x10A3F3C", VA = "0x10A3F3C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9295B8", Offset = "0x9295B8")]
		public float positionWeight;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9295D0", Offset = "0x9295D0")]
		public float rotationWeight;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10A3F70", Offset = "0x10A3F70", VA = "0x10A3F70")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x10A23D8", Offset = "0x10A23D8", VA = "0x10A23D8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x10A25B8", Offset = "0x10A25B8", VA = "0x10A25B8")]
		public void Update()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10A2DC0", Offset = "0x10A2DC0", VA = "0x10A2DC0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9295E8", Offset = "0x9295E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9295E8", Offset = "0x9295E8")]
		public float weight;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92963C", Offset = "0x92963C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92963C", Offset = "0x92963C")]
		public float rotationWeight;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929690", Offset = "0x929690")]
		public DOF rotationDOF;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9296C8", Offset = "0x9296C8")]
		public bool fixBone1Twist;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929700", Offset = "0x929700")]
		public Transform bone1;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929738", Offset = "0x929738")]
		public Transform bone2;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929770", Offset = "0x929770")]
		public Transform bone3;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9297A8", Offset = "0x9297A8")]
		public Transform tip;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9297E0", Offset = "0x9297E0")]
		public Transform target;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x929818", Offset = "0x929818")]
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
			[Address(RVA = "0x1657EC0", Offset = "0x1657EC0", VA = "0x1657EC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93177C", Offset = "0x93177C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1657EC8", Offset = "0x1657EC8", VA = "0x1657EC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93178C", Offset = "0x93178C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1657ED4", Offset = "0x1657ED4", VA = "0x1657ED4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1657EF4", Offset = "0x1657EF4", VA = "0x1657EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1657F14", Offset = "0x1657F14", VA = "0x1657F14")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x1657F34", Offset = "0x1657F34", VA = "0x1657F34")]
			set
			{
			}
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1657F54", Offset = "0x1657F54", VA = "0x1657F54")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1658060", Offset = "0x1658060", VA = "0x1658060")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1658878", Offset = "0x1658878", VA = "0x1658878")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1658954", Offset = "0x1658954", VA = "0x1658954")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1658A1C", Offset = "0x1658A1C", VA = "0x1658A1C")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x16590A8", Offset = "0x16590A8", VA = "0x16590A8")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929828", Offset = "0x929828")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929828", Offset = "0x929828")]
		public float weight;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92987C", Offset = "0x92987C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000017")]
		public bool initiated
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x16590B8", Offset = "0x16590B8", VA = "0x16590B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93179C", Offset = "0x93179C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x16590C0", Offset = "0x16590C0", VA = "0x16590C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9317AC", Offset = "0x9317AC")]
			private set
			{
			}
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x16590CC", Offset = "0x16590CC", VA = "0x16590CC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1659154", Offset = "0x1659154", VA = "0x1659154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9317BC", Offset = "0x9317BC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x16594CC", Offset = "0x16594CC", VA = "0x16594CC")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1659688", Offset = "0x1659688", VA = "0x1659688")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x16593BC", Offset = "0x16593BC", VA = "0x16593BC")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x165980C", Offset = "0x165980C", VA = "0x165980C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x16598CC", Offset = "0x16598CC", VA = "0x16598CC")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1659944", Offset = "0x1659944", VA = "0x1659944")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x16599B8", Offset = "0x16599B8", VA = "0x16599B8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1659A20", Offset = "0x1659A20", VA = "0x1659A20", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1659A24", Offset = "0x1659A24", VA = "0x1659A24", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1659A38", Offset = "0x1659A38", VA = "0x1659A38")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92988C", Offset = "0x92988C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92988C", Offset = "0x92988C")]
		public float weight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9298E0", Offset = "0x9298E0")]
		public Grounding solver;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x929918", Offset = "0x929918")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x165AB10", Offset = "0x165AB10", VA = "0x165AB10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9317F4", Offset = "0x9317F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x165AB18", Offset = "0x165AB18", VA = "0x165AB18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931804", Offset = "0x931804")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000167")]
		public abstract void ResetPosition();

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x165AB24", Offset = "0x165AB24", VA = "0x165AB24")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x165ADF8", Offset = "0x165ADF8", VA = "0x165ADF8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x165AC68", Offset = "0x165AC68", VA = "0x165AC68")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x165AE2C", Offset = "0x165AE2C", VA = "0x165AE2C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600016F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x165B034", Offset = "0x165B034", VA = "0x165B034")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9285D0", Offset = "0x9285D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9285D0", Offset = "0x9285D0")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929928", Offset = "0x929928")]
		public BipedIK ik;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929960", Offset = "0x929960")]
		public float spineBend;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929998", Offset = "0x929998")]
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
		[Address(RVA = "0x165B3AC", Offset = "0x165B3AC", VA = "0x165B3AC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931814", Offset = "0x931814")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x165B3F8", Offset = "0x165B3F8", VA = "0x165B3F8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93184C", Offset = "0x93184C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x165B444", Offset = "0x165B444", VA = "0x165B444", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x165B548", Offset = "0x165B548", VA = "0x165B548")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x165B5F8", Offset = "0x165B5F8", VA = "0x165B5F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x165B6AC", Offset = "0x165B6AC", VA = "0x165B6AC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x165BC74", Offset = "0x165BC74", VA = "0x165BC74")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x165BCC8", Offset = "0x165BCC8", VA = "0x165BCC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x165C4DC", Offset = "0x165C4DC", VA = "0x165C4DC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x165C63C", Offset = "0x165C63C", VA = "0x165C63C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x165C7CC", Offset = "0x165C7CC", VA = "0x165C7CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x165C970", Offset = "0x165C970", VA = "0x165C970")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928630", Offset = "0x928630")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928630", Offset = "0x928630")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000C9")]
		public class SpineEffector
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DEF4", Offset = "0x92DEF4")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DF2C", Offset = "0x92DF2C")]
			public float horizontalWeight;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DF64", Offset = "0x92DF64")]
			public float verticalWeight;

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x165D88C", Offset = "0x165D88C", VA = "0x165D88C")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x165D89C", Offset = "0x165D89C", VA = "0x165D89C")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9299D0", Offset = "0x9299D0")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929A08", Offset = "0x929A08")]
		public float spineBend;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929A40", Offset = "0x929A40")]
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
		[Address(RVA = "0x165CA08", Offset = "0x165CA08", VA = "0x165CA08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931884", Offset = "0x931884")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x165CA54", Offset = "0x165CA54", VA = "0x165CA54", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9318BC", Offset = "0x9318BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x165CAA0", Offset = "0x165CAA0", VA = "0x165CAA0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9318F4", Offset = "0x9318F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x165CAEC", Offset = "0x165CAEC", VA = "0x165CAEC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x165CB6C", Offset = "0x165CB6C", VA = "0x165CB6C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x165CC04", Offset = "0x165CC04", VA = "0x165CC04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x165CEFC", Offset = "0x165CEFC", VA = "0x165CEFC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x165CF08", Offset = "0x165CF08", VA = "0x165CF08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x165CCC0", Offset = "0x165CCC0", VA = "0x165CCC0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x165CF14", Offset = "0x165CF14", VA = "0x165CF14")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x165D3B4", Offset = "0x165D3B4", VA = "0x165D3B4")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x165D574", Offset = "0x165D574", VA = "0x165D574")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x165D6D0", Offset = "0x165D6D0", VA = "0x165D6D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x165D7F4", Offset = "0x165D7F4", VA = "0x165D7F4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928690", Offset = "0x928690")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928690", Offset = "0x928690")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929A78", Offset = "0x929A78")]
		public Transform pelvis;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929AB0", Offset = "0x929AB0")]
		public Transform characterRoot;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929AE8", Offset = "0x929AE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929AE8", Offset = "0x929AE8")]
		public float rootRotationWeight;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929B3C", Offset = "0x929B3C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929B74", Offset = "0x929B74")]
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
		[Address(RVA = "0x165D8E4", Offset = "0x165D8E4", VA = "0x165D8E4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93192C", Offset = "0x93192C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x165D930", Offset = "0x165D930", VA = "0x165D930", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931964", Offset = "0x931964")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x165D97C", Offset = "0x165D97C", VA = "0x165D97C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x165D994", Offset = "0x165D994", VA = "0x165D994")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x165DB84", Offset = "0x165DB84", VA = "0x165DB84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x165DC84", Offset = "0x165DC84", VA = "0x165DC84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x165E3CC", Offset = "0x165E3CC", VA = "0x165E3CC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x165E80C", Offset = "0x165E80C", VA = "0x165E80C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x165EA7C", Offset = "0x165EA7C", VA = "0x165EA7C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x165ED9C", Offset = "0x165ED9C", VA = "0x165ED9C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x165EF38", Offset = "0x165EF38", VA = "0x165EF38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x165F124", Offset = "0x165F124", VA = "0x165F124")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9286F0", Offset = "0x9286F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9286F0", Offset = "0x9286F0")]
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
			[Address(RVA = "0x9E23E8", Offset = "0x9E23E8", VA = "0x9E23E8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929BAC", Offset = "0x929BAC")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929BE4", Offset = "0x929BE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929BE4", Offset = "0x929BE4")]
		public float rootRotationWeight;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929C38", Offset = "0x929C38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929C38", Offset = "0x929C38")]
		public float minRootRotation;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929C90", Offset = "0x929C90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929C90", Offset = "0x929C90")]
		public float maxRootRotation;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929CE8", Offset = "0x929CE8")]
		public float rootRotationSpeed;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929D20", Offset = "0x929D20")]
		public float maxLegOffset;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929D58", Offset = "0x929D58")]
		public float maxForeLegOffset;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929D90", Offset = "0x929D90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x929D90", Offset = "0x929D90")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929DE4", Offset = "0x929DE4")]
		public Transform characterRoot;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929E1C", Offset = "0x929E1C")]
		public Transform pelvis;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929E54", Offset = "0x929E54")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929E8C", Offset = "0x929E8C")]
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
		[Address(RVA = "0x165F1BC", Offset = "0x165F1BC", VA = "0x165F1BC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93199C", Offset = "0x93199C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x165F208", Offset = "0x165F208", VA = "0x165F208", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9319D4", Offset = "0x9319D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x165F254", Offset = "0x165F254", VA = "0x165F254", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x165F288", Offset = "0x165F288", VA = "0x165F288")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x165F3B8", Offset = "0x165F3B8", VA = "0x165F3B8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x165F578", Offset = "0x165F578", VA = "0x165F578")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x165F5E0", Offset = "0x165F5E0", VA = "0x165F5E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x165F698", Offset = "0x165F698", VA = "0x165F698")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x165F9CC", Offset = "0x165F9CC", VA = "0x165F9CC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x165FDA4", Offset = "0x165FDA4", VA = "0x165FDA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x165FEF0", Offset = "0x165FEF0", VA = "0x165FEF0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1660394", Offset = "0x1660394", VA = "0x1660394")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1660B84", Offset = "0x1660B84", VA = "0x1660B84")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1660E44", Offset = "0x1660E44", VA = "0x1660E44")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1660FA4", Offset = "0x1660FA4", VA = "0x1660FA4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1661280", Offset = "0x1661280", VA = "0x1661280")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x16612B8", Offset = "0x16612B8", VA = "0x16612B8")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x166149C", Offset = "0x166149C", VA = "0x166149C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928750", Offset = "0x928750")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928750", Offset = "0x928750")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929ED4", Offset = "0x929ED4")]
		public VRIK ik;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x16615D0", Offset = "0x16615D0", VA = "0x16615D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931A0C", Offset = "0x931A0C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x166161C", Offset = "0x166161C", VA = "0x166161C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931A44", Offset = "0x931A44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1661668", Offset = "0x1661668", VA = "0x1661668", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931A7C", Offset = "0x931A7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x16616B4", Offset = "0x16616B4", VA = "0x16616B4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x16616CC", Offset = "0x16616CC", VA = "0x16616CC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1661764", Offset = "0x1661764", VA = "0x1661764")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1661818", Offset = "0x1661818", VA = "0x1661818")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1661A64", Offset = "0x1661A64", VA = "0x1661A64")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1661CF8", Offset = "0x1661CF8", VA = "0x1661CF8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1661E00", Offset = "0x1661E00", VA = "0x1661E00")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1662000", Offset = "0x1662000", VA = "0x1662000")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x166215C", Offset = "0x166215C", VA = "0x166215C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x16622F0", Offset = "0x16622F0", VA = "0x16622F0")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DF9C", Offset = "0x92DF9C")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DFAC", Offset = "0x92DFAC")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DFBC", Offset = "0x92DFBC")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DFCC", Offset = "0x92DFCC")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DFDC", Offset = "0x92DFDC")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DFEC", Offset = "0x92DFEC")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DFFC", Offset = "0x92DFFC")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E00C", Offset = "0x92E00C")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E01C", Offset = "0x92E01C")]
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
				[Address(RVA = "0x1663D98", Offset = "0x1663D98", VA = "0x1663D98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933658", Offset = "0x933658")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600062E")]
				[Address(RVA = "0x1663DA0", Offset = "0x1663DA0", VA = "0x1663DA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933668", Offset = "0x933668")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007A")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x1663DAC", Offset = "0x1663DAC", VA = "0x1663DAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933678", Offset = "0x933678")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000630")]
				[Address(RVA = "0x1663DB8", Offset = "0x1663DB8", VA = "0x1663DB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933688", Offset = "0x933688")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public bool initiated
			{
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x1663DC4", Offset = "0x1663DC4", VA = "0x1663DC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933698", Offset = "0x933698")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x1663DCC", Offset = "0x1663DCC", VA = "0x1663DCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9336A8", Offset = "0x9336A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007C")]
			public float heightFromGround
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x1663DD8", Offset = "0x1663DD8", VA = "0x1663DD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9336B8", Offset = "0x9336B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x1663DE0", Offset = "0x1663DE0", VA = "0x1663DE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9336C8", Offset = "0x9336C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007D")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x1663DE8", Offset = "0x1663DE8", VA = "0x1663DE8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9336D8", Offset = "0x9336D8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x1663DF4", Offset = "0x1663DF4", VA = "0x1663DF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9336E8", Offset = "0x9336E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007E")]
			public Transform transform
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x1663E00", Offset = "0x1663E00", VA = "0x1663E00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9336F8", Offset = "0x9336F8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x1663E08", Offset = "0x1663E08", VA = "0x1663E08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933708", Offset = "0x933708")]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public float IKOffset
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0x1663E10", Offset = "0x1663E10", VA = "0x1663E10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933718", Offset = "0x933718")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063A")]
				[Address(RVA = "0x1663E18", Offset = "0x1663E18", VA = "0x1663E18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933728", Offset = "0x933728")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0x1663E20", Offset = "0x1663E20", VA = "0x1663E20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933738", Offset = "0x933738")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600063C")]
				[Address(RVA = "0x1663E38", Offset = "0x1663E38", VA = "0x1663E38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933748", Offset = "0x933748")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0x1663E58", Offset = "0x1663E58", VA = "0x1663E58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933758", Offset = "0x933758")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0x1663E70", Offset = "0x1663E70", VA = "0x1663E70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933768", Offset = "0x933768")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600063F")]
				[Address(RVA = "0x1663E90", Offset = "0x1663E90", VA = "0x1663E90")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000083")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000645")]
				[Address(RVA = "0x1664C54", Offset = "0x1664C54", VA = "0x1664C54")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000084")]
			private float rootYOffset
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x1664F2C", Offset = "0x1664F2C", VA = "0x1664F2C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1663ED8", Offset = "0x1663ED8", VA = "0x1663ED8")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x16629A0", Offset = "0x16629A0", VA = "0x16629A0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1663EEC", Offset = "0x1663EEC", VA = "0x1663EEC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x16638B8", Offset = "0x16638B8", VA = "0x16638B8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1662AE4", Offset = "0x1662AE4", VA = "0x1662AE4")]
			public void Process()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x16646C8", Offset = "0x16646C8", VA = "0x16646C8")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x1663F38", Offset = "0x1663F38", VA = "0x1663F38")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x1664DD4", Offset = "0x1664DD4", VA = "0x1664DD4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000649")]
			[Address(RVA = "0x1664374", Offset = "0x1664374", VA = "0x1664374")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x166447C", Offset = "0x166447C", VA = "0x166447C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x1664ED0", Offset = "0x1664ED0", VA = "0x1664ED0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x1664CE0", Offset = "0x1664CE0", VA = "0x1664CE0")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1665054", Offset = "0x1665054", VA = "0x1665054")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x16628F0", Offset = "0x16628F0", VA = "0x16628F0")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000CD")]
		public class Pelvis
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E02C", Offset = "0x92E02C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E03C", Offset = "0x92E03C")]
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
				[Address(RVA = "0x1665144", Offset = "0x1665144", VA = "0x1665144")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933778", Offset = "0x933778")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x1665150", Offset = "0x1665150", VA = "0x1665150")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933788", Offset = "0x933788")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public float heightOffset
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x166515C", Offset = "0x166515C", VA = "0x166515C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933798", Offset = "0x933798")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x1665164", Offset = "0x1665164", VA = "0x1665164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337A8", Offset = "0x9337A8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1662A9C", Offset = "0x1662A9C", VA = "0x1662A9C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1663808", Offset = "0x1663808", VA = "0x1663808")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x166516C", Offset = "0x166516C", VA = "0x166516C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x166359C", Offset = "0x166359C", VA = "0x166359C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1662998", Offset = "0x1662998", VA = "0x1662998")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929F0C", Offset = "0x929F0C")]
		public LayerMask layers;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929F44", Offset = "0x929F44")]
		public float maxStep;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929F7C", Offset = "0x929F7C")]
		public float heightOffset;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929FB4", Offset = "0x929FB4")]
		public float footSpeed;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x929FEC", Offset = "0x929FEC")]
		public float footRadius;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A024", Offset = "0x92A024")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A070", Offset = "0x92A070")]
		public float prediction;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A0A8", Offset = "0x92A0A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A0A8", Offset = "0x92A0A8")]
		public float footRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A0FC", Offset = "0x92A0FC")]
		public float footRotationSpeed;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A134", Offset = "0x92A134")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A134", Offset = "0x92A134")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A18C", Offset = "0x92A18C")]
		public bool rotateSolver;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A1C4", Offset = "0x92A1C4")]
		public float pelvisSpeed;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A1FC", Offset = "0x92A1FC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A1FC", Offset = "0x92A1FC")]
		public float pelvisDamper;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A250", Offset = "0x92A250")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A288", Offset = "0x92A288")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A2C0", Offset = "0x92A2C0")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A2F8", Offset = "0x92A2F8")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A330", Offset = "0x92A330")]
		public Quality quality;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92A368", Offset = "0x92A368")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92A378", Offset = "0x92A378")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92A388", Offset = "0x92A388")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92A398", Offset = "0x92A398")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92A3A8", Offset = "0x92A3A8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000019")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1662358", Offset = "0x1662358", VA = "0x1662358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931AB4", Offset = "0x931AB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1662360", Offset = "0x1662360", VA = "0x1662360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931AC4", Offset = "0x931AC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1662368", Offset = "0x1662368", VA = "0x1662368")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931AD4", Offset = "0x931AD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1662370", Offset = "0x1662370", VA = "0x1662370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931AE4", Offset = "0x931AE4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public bool isGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1662378", Offset = "0x1662378", VA = "0x1662378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931AF4", Offset = "0x931AF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x1662380", Offset = "0x1662380", VA = "0x1662380")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931B04", Offset = "0x931B04")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform root
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x166238C", Offset = "0x166238C", VA = "0x166238C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931B14", Offset = "0x931B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x1662394", Offset = "0x1662394", VA = "0x1662394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931B24", Offset = "0x931B24")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x166239C", Offset = "0x166239C", VA = "0x166239C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931B34", Offset = "0x931B34")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x16623B4", Offset = "0x16623B4", VA = "0x16623B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x931B44", Offset = "0x931B44")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x16623D4", Offset = "0x16623D4", VA = "0x16623D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 up
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x165C5B0", Offset = "0x165C5B0", VA = "0x165C5B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000020")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x166396C", Offset = "0x166396C", VA = "0x166396C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1662428", Offset = "0x1662428", VA = "0x1662428")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1662808", Offset = "0x1662808", VA = "0x1662808")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x165B9BC", Offset = "0x165B9BC", VA = "0x165B9BC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x165C234", Offset = "0x165C234", VA = "0x165C234")]
		public void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x165E1B4", Offset = "0x165E1B4", VA = "0x165E1B4")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x165B4C4", Offset = "0x165B4C4", VA = "0x165B4C4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1662ACC", Offset = "0x1662ACC", VA = "0x1662ACC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1663A3C", Offset = "0x1663A3C", VA = "0x1663A3C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1663BA4", Offset = "0x1663BA4", VA = "0x1663BA4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1663CA8", Offset = "0x1663CA8", VA = "0x1663CA8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x165B100", Offset = "0x165B100", VA = "0x165B100")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9287B0", Offset = "0x9287B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9287B0", Offset = "0x9287B0")]
	public class AimIK : IK
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10A0C8C", Offset = "0x10A0C8C", VA = "0x10A0C8C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931B54", Offset = "0x931B54")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x10A0CD8", Offset = "0x10A0CD8", VA = "0x10A0CD8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931B8C", Offset = "0x931B8C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10A0D24", Offset = "0x10A0D24", VA = "0x10A0D24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931BC4", Offset = "0x931BC4")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x10A0D70", Offset = "0x10A0D70", VA = "0x10A0D70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931BFC", Offset = "0x931BFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x10A0DBC", Offset = "0x10A0DBC", VA = "0x10A0DBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931C34", Offset = "0x931C34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x10A0E08", Offset = "0x10A0E08", VA = "0x10A0E08", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x10A0E10", Offset = "0x10A0E10", VA = "0x10A0E10")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928810", Offset = "0x928810")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928810", Offset = "0x928810")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x10A1790", Offset = "0x10A1790", VA = "0x10A1790", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931C6C", Offset = "0x931C6C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x10A17DC", Offset = "0x10A17DC", VA = "0x10A17DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931CA4", Offset = "0x931CA4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x10A1828", Offset = "0x10A1828", VA = "0x10A1828")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931CDC", Offset = "0x931CDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x10A1874", Offset = "0x10A1874", VA = "0x10A1874")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931D14", Offset = "0x931D14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x10A18C0", Offset = "0x10A18C0", VA = "0x10A18C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x10A18C8", Offset = "0x10A18C8", VA = "0x10A18C8")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928870", Offset = "0x928870")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928870", Offset = "0x928870")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x10A3560", Offset = "0x10A3560", VA = "0x10A3560", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931D4C", Offset = "0x931D4C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x10A35AC", Offset = "0x10A35AC", VA = "0x10A35AC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931D84", Offset = "0x931D84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x10A35F8", Offset = "0x10A35F8", VA = "0x10A35F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931DBC", Offset = "0x931DBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x10A3644", Offset = "0x10A3644", VA = "0x10A3644")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931DF4", Offset = "0x931DF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x10A3690", Offset = "0x10A3690", VA = "0x10A3690", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x10A3698", Offset = "0x10A3698", VA = "0x10A3698")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9288D0", Offset = "0x9288D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9288D0", Offset = "0x9288D0")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x10A4CFC", Offset = "0x10A4CFC", VA = "0x10A4CFC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931E2C", Offset = "0x931E2C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x10A4D48", Offset = "0x10A4D48", VA = "0x10A4D48", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931E64", Offset = "0x931E64")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x10A4D94", Offset = "0x10A4D94", VA = "0x10A4D94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931E9C", Offset = "0x931E9C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x10A4DE0", Offset = "0x10A4DE0", VA = "0x10A4DE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931ED4", Offset = "0x931ED4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x10A4E2C", Offset = "0x10A4E2C", VA = "0x10A4E2C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x10A4E34", Offset = "0x10A4E34", VA = "0x10A4E34")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928930", Offset = "0x928930")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928930", Offset = "0x928930")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x10A54D8", Offset = "0x10A54D8", VA = "0x10A54D8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931F0C", Offset = "0x931F0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x10A5524", Offset = "0x10A5524", VA = "0x10A5524", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931F44", Offset = "0x931F44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x10A5570", Offset = "0x10A5570", VA = "0x10A5570")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931F7C", Offset = "0x931F7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x10A55BC", Offset = "0x10A55BC", VA = "0x10A55BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931FB4", Offset = "0x931FB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x10A5608", Offset = "0x10A5608", VA = "0x10A5608", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x10A5610", Offset = "0x10A5610", VA = "0x10A5610")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928990", Offset = "0x928990")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928990", Offset = "0x928990")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1659AAC", Offset = "0x1659AAC", VA = "0x1659AAC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x931FEC", Offset = "0x931FEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1659AF8", Offset = "0x1659AF8", VA = "0x1659AF8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932024", Offset = "0x932024")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1659B44", Offset = "0x1659B44", VA = "0x1659B44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93205C", Offset = "0x93205C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1659B90", Offset = "0x1659B90", VA = "0x1659B90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932094", Offset = "0x932094")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1659BDC", Offset = "0x1659BDC", VA = "0x1659BDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9320CC", Offset = "0x9320CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1659C28", Offset = "0x1659C28", VA = "0x1659C28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932104", Offset = "0x932104")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1659C74", Offset = "0x1659C74", VA = "0x1659C74")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1659CB8", Offset = "0x1659CB8", VA = "0x1659CB8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1659CC0", Offset = "0x1659CC0", VA = "0x1659CC0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1659E88", Offset = "0x1659E88", VA = "0x1659E88")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x165A1E8", Offset = "0x165A1E8", VA = "0x165A1E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93213C", Offset = "0x93213C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x165A208", Offset = "0x165A208", VA = "0x165A208")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932174", Offset = "0x932174")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x165A2FC", Offset = "0x165A2FC", VA = "0x165A2FC")]
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
		[Address(RVA = "0x1667D44", Offset = "0x1667D44", VA = "0x1667D44", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1667DC8", Offset = "0x1667DC8", VA = "0x1667DC8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1667E38", Offset = "0x1667E38", VA = "0x1667E38", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001FE")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001FF")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x165A39C", Offset = "0x165A39C", VA = "0x165A39C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A3B8", Offset = "0x92A3B8")]
		public IK[] IKComponents;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A3F0", Offset = "0x92A3F0")]
		public Animator animator;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000021")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x166AEE8", Offset = "0x166AEE8", VA = "0x166AEE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x166AF84", Offset = "0x166AF84", VA = "0x166AF84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x166AFF4", Offset = "0x166AFF4", VA = "0x166AFF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x166B0B0", Offset = "0x166B0B0", VA = "0x166B0B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x166B0EC", Offset = "0x166B0EC", VA = "0x166B0EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x166B028", Offset = "0x166B028", VA = "0x166B028")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x166B178", Offset = "0x166B178", VA = "0x166B178")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9289F0", Offset = "0x9289F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9289F0", Offset = "0x9289F0")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x144A0D0", Offset = "0x144A0D0", VA = "0x144A0D0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9321AC", Offset = "0x9321AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x144A11C", Offset = "0x144A11C", VA = "0x144A11C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9321E4", Offset = "0x9321E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x144A168", Offset = "0x144A168", VA = "0x144A168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93221C", Offset = "0x93221C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x144A1B4", Offset = "0x144A1B4", VA = "0x144A1B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932254", Offset = "0x932254")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x144A200", Offset = "0x144A200", VA = "0x144A200", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x144A208", Offset = "0x144A208", VA = "0x144A208")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928A50", Offset = "0x928A50")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928A50", Offset = "0x928A50")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x144A27C", Offset = "0x144A27C", VA = "0x144A27C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93228C", Offset = "0x93228C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x144A2C8", Offset = "0x144A2C8", VA = "0x144A2C8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9322C4", Offset = "0x9322C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x144A314", Offset = "0x144A314", VA = "0x144A314")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9322FC", Offset = "0x9322FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x144A360", Offset = "0x144A360", VA = "0x144A360")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932334", Offset = "0x932334")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x144A3AC", Offset = "0x144A3AC", VA = "0x144A3AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x144A3B4", Offset = "0x144A3B4", VA = "0x144A3B4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928AB0", Offset = "0x928AB0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928AB0", Offset = "0x928AB0")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x144B298", Offset = "0x144B298", VA = "0x144B298", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93236C", Offset = "0x93236C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x144B2E4", Offset = "0x144B2E4", VA = "0x144B2E4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9323A4", Offset = "0x9323A4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x144B330", Offset = "0x144B330", VA = "0x144B330")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9323DC", Offset = "0x9323DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x144B37C", Offset = "0x144B37C", VA = "0x144B37C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932414", Offset = "0x932414")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x144B3C8", Offset = "0x144B3C8", VA = "0x144B3C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x144B3D0", Offset = "0x144B3D0", VA = "0x144B3D0")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928B10", Offset = "0x928B10")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928B10", Offset = "0x928B10")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1454054", Offset = "0x1454054", VA = "0x1454054", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93244C", Offset = "0x93244C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x14540A0", Offset = "0x14540A0", VA = "0x14540A0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932484", Offset = "0x932484")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x14540EC", Offset = "0x14540EC", VA = "0x14540EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9324BC", Offset = "0x9324BC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1454138", Offset = "0x1454138", VA = "0x1454138")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9324F4", Offset = "0x9324F4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1454184", Offset = "0x1454184", VA = "0x1454184", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x145418C", Offset = "0x145418C", VA = "0x145418C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928B70", Offset = "0x928B70")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E04C", Offset = "0x92E04C")]
			public Transform chest;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E084", Offset = "0x92E084")]
			public Transform neck;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E0BC", Offset = "0x92E0BC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E0F4", Offset = "0x92E0F4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E12C", Offset = "0x92E12C")]
			public Transform leftThigh;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E164", Offset = "0x92E164")]
			public Transform leftCalf;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E19C", Offset = "0x92E19C")]
			public Transform leftFoot;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E1D4", Offset = "0x92E1D4")]
			public Transform leftToes;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E20C", Offset = "0x92E20C")]
			public Transform rightThigh;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E244", Offset = "0x92E244")]
			public Transform rightCalf;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E27C", Offset = "0x92E27C")]
			public Transform rightFoot;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E2B4", Offset = "0x92E2B4")]
			public Transform rightToes;

			[Token(Token = "0x17000087")]
			public bool isFilled
			{
				[Token(Token = "0x600065A")]
				[Address(RVA = "0x1455CB0", Offset = "0x1455CB0", VA = "0x1455CB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000088")]
			public bool isEmpty
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0x1455834", Offset = "0x1455834", VA = "0x1455834")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x145634C", Offset = "0x145634C", VA = "0x145634C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1455310", Offset = "0x1455310", VA = "0x1455310")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1456344", Offset = "0x1456344", VA = "0x1456344")]
			public References()
			{
			}
		}

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x92A428", Offset = "0x92A428")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A428", Offset = "0x92A428")]
		public References references;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A4A4", Offset = "0x92A4A4")]
		public IKSolverVR solver;

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1455204", Offset = "0x1455204", VA = "0x1455204", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93252C", Offset = "0x93252C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1455250", Offset = "0x1455250", VA = "0x1455250", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932564", Offset = "0x932564")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x145529C", Offset = "0x145529C", VA = "0x145529C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93259C", Offset = "0x93259C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x14552E8", Offset = "0x14552E8", VA = "0x14552E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9325D4", Offset = "0x9325D4")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1455790", Offset = "0x1455790", VA = "0x1455790")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93260C", Offset = "0x93260C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x14557B8", Offset = "0x14557B8", VA = "0x14557B8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x14557C0", Offset = "0x14557C0", VA = "0x14557C0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x145612C", Offset = "0x145612C", VA = "0x145612C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x14562A4", Offset = "0x14562A4", VA = "0x14562A4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A4DC", Offset = "0x92A4DC")]
		public float pull;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A4F4", Offset = "0x92A4F4")]
		public float pin;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10A4EA8", Offset = "0x10A4EA8", VA = "0x10A4EA8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10A4F7C", Offset = "0x10A4F7C", VA = "0x10A4F7C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x10A4F9C", Offset = "0x10A4F9C", VA = "0x10A4F9C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x10A536C", Offset = "0x10A536C", VA = "0x10A536C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x10A5070", Offset = "0x10A5070", VA = "0x10A5070")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x10A5464", Offset = "0x10A5464", VA = "0x10A5464")]
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
		[Address(RVA = "0x10A5684", Offset = "0x10A5684", VA = "0x10A5684")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x10A5C00", Offset = "0x10A5C00", VA = "0x10A5C00")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x10A5DC0", Offset = "0x10A5DC0", VA = "0x10A5DC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10A5EDC", Offset = "0x10A5EDC", VA = "0x10A5EDC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E2EC", Offset = "0x92E2EC")]
			public Transform transform;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E324", Offset = "0x92E324")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E324", Offset = "0x92E324")]
			public float weight;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x10A906C", Offset = "0x10A906C", VA = "0x10A906C")]
			public BendBone()
			{
			}

			[Token(Token = "0x600065F")]
			[Address(RVA = "0x10A90EC", Offset = "0x10A90EC", VA = "0x10A90EC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x10A672C", Offset = "0x10A672C", VA = "0x10A672C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000661")]
			[Address(RVA = "0x10A6B30", Offset = "0x10A6B30", VA = "0x10A6B30")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A50C", Offset = "0x92A50C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92A544", Offset = "0x92A544")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A544", Offset = "0x92A544")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A544", Offset = "0x92A544")]
		public float positionWeight;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A5BC", Offset = "0x92A5BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A5BC", Offset = "0x92A5BC")]
		public float bodyWeight;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A610", Offset = "0x92A610")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A610", Offset = "0x92A610")]
		public float thighWeight;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A664", Offset = "0x92A664")]
		public bool handsPullBody;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92A69C", Offset = "0x92A69C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A69C", Offset = "0x92A69C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A69C", Offset = "0x92A69C")]
		public float rotationWeight;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A714", Offset = "0x92A714")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A714", Offset = "0x92A714")]
		public float bodyClampWeight;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A768", Offset = "0x92A768")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A768", Offset = "0x92A768")]
		public float headClampWeight;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A7BC", Offset = "0x92A7BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A7BC", Offset = "0x92A7BC")]
		public float bendWeight;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A810", Offset = "0x92A810")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92A848", Offset = "0x92A848")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A848", Offset = "0x92A848")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A848", Offset = "0x92A848")]
		public float CCDWeight;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A8C0", Offset = "0x92A8C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A8C0", Offset = "0x92A8C0")]
		public float roll;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A914", Offset = "0x92A914")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A914", Offset = "0x92A914")]
		public float damper;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A96C", Offset = "0x92A96C")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92A9A4", Offset = "0x92A9A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92A9A4", Offset = "0x92A9A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92A9A4", Offset = "0x92A9A4")]
		public float postStretchWeight;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AA1C", Offset = "0x92AA1C")]
		public float maxStretch;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AA54", Offset = "0x92AA54")]
		public float stretchDamper;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AA8C", Offset = "0x92AA8C")]
		public bool fixHead;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AAC4", Offset = "0x92AAC4")]
		public Transform[] stretchBones;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92AAFC", Offset = "0x92AAFC")]
		public Vector3 chestDirection;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AB34", Offset = "0x92AB34")]
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
		[Address(RVA = "0x10A5EE4", Offset = "0x10A5EE4", VA = "0x10A5EE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x10A6268", Offset = "0x10A6268", VA = "0x10A6268")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x10A6764", Offset = "0x10A6764", VA = "0x10A6764")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x10A6B58", Offset = "0x10A6B58", VA = "0x10A6B58")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x10A74D0", Offset = "0x10A74D0", VA = "0x10A74D0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x10A781C", Offset = "0x10A781C", VA = "0x10A781C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x10A7BB8", Offset = "0x10A7BB8", VA = "0x10A7BB8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x10A8624", Offset = "0x10A8624", VA = "0x10A8624")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x10A71FC", Offset = "0x10A71FC", VA = "0x10A71FC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x10A8834", Offset = "0x10A8834", VA = "0x10A8834")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x10A84E0", Offset = "0x10A84E0", VA = "0x10A84E0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x10A8344", Offset = "0x10A8344", VA = "0x10A8344")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x10A8BA0", Offset = "0x10A8BA0", VA = "0x10A8BA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x10A8E84", Offset = "0x10A8E84", VA = "0x10A8E84")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E398", Offset = "0x92E398")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E3A8", Offset = "0x92E3A8")]
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
				[Address(RVA = "0x16578D4", Offset = "0x16578D4", VA = "0x16578D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337B8", Offset = "0x9337B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x16578DC", Offset = "0x16578DC", VA = "0x16578DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337C8", Offset = "0x9337C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public bool isRigid
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x16578E4", Offset = "0x16578E4", VA = "0x16578E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337D8", Offset = "0x9337D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x16578EC", Offset = "0x16578EC", VA = "0x16578EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337E8", Offset = "0x9337E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x16578F8", Offset = "0x16578F8", VA = "0x16578F8")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000667")]
			[Address(RVA = "0x1657960", Offset = "0x1657960", VA = "0x1657960")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000668")]
			[Address(RVA = "0x16579B8", Offset = "0x16579B8", VA = "0x16579B8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1657BBC", Offset = "0x1657BBC", VA = "0x1657BBC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AB4C", Offset = "0x92AB4C")]
		public float pin;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AB64", Offset = "0x92AB64")]
		public float pull;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AB7C", Offset = "0x92AB7C")]
		public float push;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AB94", Offset = "0x92AB94")]
		public float pushParent;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ABAC", Offset = "0x92ABAC")]
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
		[Address(RVA = "0x10A919C", Offset = "0x10A919C", VA = "0x10A919C")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x10A9298", Offset = "0x10A9298", VA = "0x10A9298")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x10A93E8", Offset = "0x10A93E8", VA = "0x10A93E8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x10A951C", Offset = "0x10A951C", VA = "0x10A951C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x10A95F8", Offset = "0x10A95F8", VA = "0x10A95F8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x10A9708", Offset = "0x10A9708", VA = "0x10A9708")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x10A9E28", Offset = "0x10A9E28", VA = "0x10A9E28")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x10A98A8", Offset = "0x10A98A8", VA = "0x10A98A8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x10AA314", Offset = "0x10AA314", VA = "0x10AA314")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10AA6B8", Offset = "0x10AA6B8", VA = "0x10AA6B8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x10AAA9C", Offset = "0x10AAA9C", VA = "0x10AAA9C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x10AB020", Offset = "0x10AB020", VA = "0x10AB020")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x10AB5F4", Offset = "0x10AB5F4", VA = "0x10AB5F4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x10AB88C", Offset = "0x10AB88C", VA = "0x10AB88C")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x10AB4EC", Offset = "0x10AB4EC", VA = "0x10AB4EC")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10AAE08", Offset = "0x10AAE08", VA = "0x10AAE08")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10AB470", Offset = "0x10AB470", VA = "0x10AB470")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10AB974", Offset = "0x10AB974", VA = "0x10AB974")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10AB390", Offset = "0x10AB390", VA = "0x10AB390")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x10AB774", Offset = "0x10AB774", VA = "0x10AB774")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ABC4", Offset = "0x92ABC4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92ABDC", Offset = "0x92ABDC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1668060", Offset = "0x1668060", VA = "0x1668060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932644", Offset = "0x932644")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x1668068", Offset = "0x1668068", VA = "0x1668068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932654", Offset = "0x932654")]
			private set
			{
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1667E98", Offset = "0x1667E98", VA = "0x1667E98")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1668074", Offset = "0x1668074", VA = "0x1668074")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x16680F8", Offset = "0x16680F8", VA = "0x16680F8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x16681AC", Offset = "0x16681AC", VA = "0x16681AC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x16681FC", Offset = "0x16681FC", VA = "0x16681FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x16686EC", Offset = "0x16686EC", VA = "0x16686EC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1668924", Offset = "0x1668924", VA = "0x1668924")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1668DC0", Offset = "0x1668DC0", VA = "0x1668DC0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x16684AC", Offset = "0x16684AC", VA = "0x16684AC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x16685CC", Offset = "0x16685CC", VA = "0x16685CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ABEC", Offset = "0x92ABEC")]
		public float positionWeight;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AC04", Offset = "0x92AC04")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92AC1C", Offset = "0x92AC1C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AC2C", Offset = "0x92AC2C")]
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
			[Address(RVA = "0x166942C", Offset = "0x166942C", VA = "0x166942C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932664", Offset = "0x932664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x1669434", Offset = "0x1669434", VA = "0x1669434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932674", Offset = "0x932674")]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x16693C4", Offset = "0x16693C4", VA = "0x16693C4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1669440", Offset = "0x1669440", VA = "0x1669440")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1669514", Offset = "0x1669514", VA = "0x1669514")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1669680", Offset = "0x1669680", VA = "0x1669680")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1669828", Offset = "0x1669828", VA = "0x1669828")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1669B24", Offset = "0x1669B24", VA = "0x1669B24")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1669DFC", Offset = "0x1669DFC", VA = "0x1669DFC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1669F3C", Offset = "0x1669F3C", VA = "0x1669F3C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1669FE8", Offset = "0x1669FE8", VA = "0x1669FE8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x166A63C", Offset = "0x166A63C", VA = "0x166A63C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x166A6AC", Offset = "0x166A6AC", VA = "0x166A6AC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x166A8C4", Offset = "0x166A8C4", VA = "0x166A8C4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x166AC0C", Offset = "0x166AC0C", VA = "0x166AC0C")]
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
				[Address(RVA = "0x166B41C", Offset = "0x166B41C", VA = "0x166B41C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008C")]
			public bool isNodeBone
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x166B588", Offset = "0x166B588", VA = "0x166B588")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008D")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000682")]
				[Address(RVA = "0x166BB98", Offset = "0x166BB98", VA = "0x166BB98")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x166B3CC", Offset = "0x166B3CC", VA = "0x166B3CC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x166B4E8", Offset = "0x166B4E8", VA = "0x166B4E8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x166B538", Offset = "0x166B538", VA = "0x166B538")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x166B598", Offset = "0x166B598", VA = "0x166B598")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x166B680", Offset = "0x166B680", VA = "0x166B680")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x166B688", Offset = "0x166B688", VA = "0x166B688")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x166B818", Offset = "0x166B818", VA = "0x166B818")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x166B924", Offset = "0x166B924", VA = "0x166B924")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000674")]
			[Address(RVA = "0x166B9E8", Offset = "0x166B9E8", VA = "0x166B9E8")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x166BDBC", Offset = "0x166BDBC", VA = "0x166BDBC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x166BDF4", Offset = "0x166BDF4", VA = "0x166BDF4")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x166BE2C", Offset = "0x166BE2C", VA = "0x166BE2C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x166BE54", Offset = "0x166BE54", VA = "0x166BE54")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x166BF80", Offset = "0x166BF80", VA = "0x166BF80")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x166C2C8", Offset = "0x166C2C8", VA = "0x166C2C8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x166C2F8", Offset = "0x166C2F8", VA = "0x166C2F8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x166C490", Offset = "0x166C490", VA = "0x166C490")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600067D")]
			[Address(RVA = "0x166C500", Offset = "0x166C500", VA = "0x166C500")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x166C744", Offset = "0x166C744", VA = "0x166C744")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x166C96C", Offset = "0x166C96C", VA = "0x166C96C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x166CA84", Offset = "0x166CA84", VA = "0x166CA84")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x166C0C4", Offset = "0x166C0C4", VA = "0x166C0C4")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x166CC20", Offset = "0x166CC20", VA = "0x166CC20")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x166B180", Offset = "0x166B180", VA = "0x166B180", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x166B188", Offset = "0x166B188", VA = "0x166B188", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x166B18C", Offset = "0x166B18C", VA = "0x166B18C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x166B2BC", Offset = "0x166B2BC", VA = "0x166B2BC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x166B3C4", Offset = "0x166B3C4", VA = "0x166B3C4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AC44", Offset = "0x92AC44")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x166CC3C", Offset = "0x166CC3C", VA = "0x166CC3C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x166CCE8", Offset = "0x166CCE8", VA = "0x166CCE8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x166CD78", Offset = "0x166CD78", VA = "0x166CD78")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x166CE24", Offset = "0x166CE24", VA = "0x166CE24")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x166CE3C", Offset = "0x166CE3C", VA = "0x166CE3C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x166CE58", Offset = "0x166CE58", VA = "0x166CE58", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x166CF04", Offset = "0x166CF04", VA = "0x166CF04")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x166CF1C", Offset = "0x166CF1C", VA = "0x166CF1C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AC5C", Offset = "0x92AC5C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AC74", Offset = "0x92AC74")]
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
		[Address(RVA = "0x166CF40", Offset = "0x166CF40", VA = "0x166CF40", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x166CFC4", Offset = "0x166CFC4", VA = "0x166CFC4")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x166D098", Offset = "0x166D098", VA = "0x166D098")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x166D3EC", Offset = "0x166D3EC", VA = "0x166D3EC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x166D524", Offset = "0x166D524", VA = "0x166D524")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x166D694", Offset = "0x166D694", VA = "0x166D694")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x166D6F8", Offset = "0x166D6F8", VA = "0x166D6F8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x166D7A0", Offset = "0x166D7A0", VA = "0x166D7A0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x166D858", Offset = "0x166D858", VA = "0x166D858", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x166DB20", Offset = "0x166DB20", VA = "0x166DB20")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x166DBD8", Offset = "0x166DBD8", VA = "0x166DBD8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AC8C", Offset = "0x92AC8C")]
		public int iterations;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ACA4", Offset = "0x92ACA4")]
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
		[Address(RVA = "0x166DD44", Offset = "0x166DD44", VA = "0x166DD44", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x166E03C", Offset = "0x166E03C", VA = "0x166E03C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x166E194", Offset = "0x166E194", VA = "0x166E194")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x166E334", Offset = "0x166E334", VA = "0x166E334")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x166E3B4", Offset = "0x166E3B4", VA = "0x166E3B4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x166E41C", Offset = "0x166E41C", VA = "0x166E41C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x166E49C", Offset = "0x166E49C", VA = "0x166E49C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x166EB74", Offset = "0x166EB74", VA = "0x166EB74")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x166EBAC", Offset = "0x166EBAC", VA = "0x166EBAC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x166EE8C", Offset = "0x166EE8C", VA = "0x166EE8C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x166F240", Offset = "0x166F240", VA = "0x166F240")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x166F32C", Offset = "0x166F32C", VA = "0x166F32C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x166F3F4", Offset = "0x166F3F4", VA = "0x166F3F4")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E3B8", Offset = "0x92E3B8")]
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
			[Address(RVA = "0x163DE18", Offset = "0x163DE18", VA = "0x163DE18")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x163DE68", Offset = "0x163DE68", VA = "0x163DE68")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x163DFF0", Offset = "0x163DFF0", VA = "0x163DFF0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000687")]
			[Address(RVA = "0x163E028", Offset = "0x163E028", VA = "0x163E028")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x163E060", Offset = "0x163E060", VA = "0x163E060")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x163E0B0", Offset = "0x163E0B0", VA = "0x163E0B0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x163D8C0", Offset = "0x163D8C0", VA = "0x163D8C0")]
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
				[Address(RVA = "0x163CE7C", Offset = "0x163CE7C", VA = "0x163CE7C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x163CF78", Offset = "0x163CF78", VA = "0x163CF78")]
				set
				{
				}
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x163D00C", Offset = "0x163D00C", VA = "0x163D00C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x163D2CC", Offset = "0x163D2CC", VA = "0x163D2CC")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x163D5AC", Offset = "0x163D5AC", VA = "0x163D5AC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x163D814", Offset = "0x163D814", VA = "0x163D814")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x163D83C", Offset = "0x163D83C", VA = "0x163D83C")]
			public Bone()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x163D940", Offset = "0x163D940", VA = "0x163D940")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x163D9E0", Offset = "0x163D9E0", VA = "0x163D9E0")]
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
			[Address(RVA = "0x163DDA0", Offset = "0x163DDA0", VA = "0x163DDA0")]
			public Node()
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x163DDA4", Offset = "0x163DDA4", VA = "0x163DDA4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x163DDD4", Offset = "0x163DDD4", VA = "0x163DDD4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92ACDC", Offset = "0x92ACDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ACDC", Offset = "0x92ACDC")]
		public float IKPositionWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92AD30", Offset = "0x92AD30")]
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
			[Address(RVA = "0x166F804", Offset = "0x166F804", VA = "0x166F804")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932684", Offset = "0x932684")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x166F80C", Offset = "0x166F80C", VA = "0x166F80C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932694", Offset = "0x932694")]
			private set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x166F6DC", Offset = "0x166F6DC", VA = "0x166F6DC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1658710", Offset = "0x1658710", VA = "0x1658710")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1659038", Offset = "0x1659038", VA = "0x1659038")]
		public void Update()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x166F758", Offset = "0x166F758", VA = "0x166F758", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x166F764", Offset = "0x166F764", VA = "0x166F764")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x166F770", Offset = "0x166F770", VA = "0x166F770")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x166F778", Offset = "0x166F778", VA = "0x166F778")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x166F7FC", Offset = "0x166F7FC", VA = "0x166F7FC")]
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
		[Address(RVA = "0x166F818", Offset = "0x166F818", VA = "0x166F818")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x166F830", Offset = "0x166F830", VA = "0x166F830")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x166F96C", Offset = "0x166F96C", VA = "0x166F96C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x166FA18", Offset = "0x166FA18", VA = "0x166FA18")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x166FD9C", Offset = "0x166FD9C", VA = "0x166FD9C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AD78", Offset = "0x92AD78")]
		public float poleWeight;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AD90", Offset = "0x92AD90")]
		public float clampWeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ADA8", Offset = "0x92ADA8")]
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
			[Address(RVA = "0x163E458", Offset = "0x163E458", VA = "0x163E458")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x163E524", Offset = "0x163E524", VA = "0x163E524")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000027")]
		protected override int minBones
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x163F2B0", Offset = "0x163F2B0", VA = "0x163F2B0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000028")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x163F854", Offset = "0x163F854", VA = "0x163F854", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x163E358", Offset = "0x163E358", VA = "0x163E358")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x163E5F0", Offset = "0x163E5F0", VA = "0x163E5F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x163E870", Offset = "0x163E870", VA = "0x163E870", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x163F1FC", Offset = "0x163F1FC", VA = "0x163F1FC")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x163EE24", Offset = "0x163EE24", VA = "0x163EE24")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x163F2B8", Offset = "0x163F2B8", VA = "0x163F2B8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x163F8C8", Offset = "0x163F8C8", VA = "0x163F8C8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ADC0", Offset = "0x92ADC0")]
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
		[Address(RVA = "0x163F9D8", Offset = "0x163F9D8", VA = "0x163F9D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x163FD94", Offset = "0x163FD94", VA = "0x163FD94")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x163FE4C", Offset = "0x163FE4C", VA = "0x163FE4C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x163FFE4", Offset = "0x163FFE4", VA = "0x163FFE4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x164017C", Offset = "0x164017C", VA = "0x164017C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x16401C8", Offset = "0x16401C8", VA = "0x16401C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1640228", Offset = "0x1640228", VA = "0x1640228", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1640598", Offset = "0x1640598", VA = "0x1640598", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x16405C4", Offset = "0x16405C4", VA = "0x16405C4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x164028C", Offset = "0x164028C", VA = "0x164028C")]
		private void Read()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1640634", Offset = "0x1640634", VA = "0x1640634")]
		private void Write()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x16407C0", Offset = "0x16407C0", VA = "0x16407C0")]
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
		[Address(RVA = "0x1640964", Offset = "0x1640964", VA = "0x1640964")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x1640A14", Offset = "0x1640A14", VA = "0x1640A14", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1641008", Offset = "0x1641008", VA = "0x1641008", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1641758", Offset = "0x1641758", VA = "0x1641758")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1641EAC", Offset = "0x1641EAC", VA = "0x1641EAC")]
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
			[Address(RVA = "0x16430E0", Offset = "0x16430E0", VA = "0x16430E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1641EB0", Offset = "0x1641EB0", VA = "0x1641EB0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x16425F4", Offset = "0x16425F4", VA = "0x16425F4")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1642728", Offset = "0x1642728", VA = "0x1642728", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x16427C0", Offset = "0x16427C0", VA = "0x16427C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1642D80", Offset = "0x1642D80", VA = "0x1642D80", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x16430E8", Offset = "0x16430E8", VA = "0x16430E8")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1641F80", Offset = "0x1641F80", VA = "0x1641F80")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x16426D4", Offset = "0x16426D4", VA = "0x16426D4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1643084", Offset = "0x1643084", VA = "0x1643084")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x164241C", Offset = "0x164241C", VA = "0x164241C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1643928", Offset = "0x1643928", VA = "0x1643928")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1643A38", Offset = "0x1643A38", VA = "0x1643A38")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1643B64", Offset = "0x1643B64", VA = "0x1643B64")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1643C7C", Offset = "0x1643C7C", VA = "0x1643C7C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1642AE8", Offset = "0x1642AE8", VA = "0x1642AE8")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1642C34", Offset = "0x1642C34", VA = "0x1642C34")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1643E68", Offset = "0x1643E68", VA = "0x1643E68")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x16433A0", Offset = "0x16433A0", VA = "0x16433A0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x16426C4", Offset = "0x16426C4", VA = "0x16426C4")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x16445D0", Offset = "0x16445D0", VA = "0x16445D0")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x164403C", Offset = "0x164403C", VA = "0x164403C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1643200", Offset = "0x1643200", VA = "0x1643200")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x16432DC", Offset = "0x16432DC", VA = "0x16432DC")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x164469C", Offset = "0x164469C", VA = "0x164469C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ADD8", Offset = "0x92ADD8")]
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
		[Address(RVA = "0x1644728", Offset = "0x1644728", VA = "0x1644728", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1645100", Offset = "0x1645100", VA = "0x1645100", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1645198", Offset = "0x1645198", VA = "0x1645198", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1645238", Offset = "0x1645238", VA = "0x1645238", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1645348", Offset = "0x1645348", VA = "0x1645348")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x16453E4", Offset = "0x16453E4", VA = "0x16453E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x164594C", Offset = "0x164594C", VA = "0x164594C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1645B64", Offset = "0x1645B64", VA = "0x1645B64", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x16459FC", Offset = "0x16459FC", VA = "0x16459FC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1645618", Offset = "0x1645618", VA = "0x1645618")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1645BFC", Offset = "0x1645BFC", VA = "0x1645BFC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ADF0", Offset = "0x92ADF0")]
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
		[Address(RVA = "0x1645C70", Offset = "0x1645C70", VA = "0x1645C70")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1645D64", Offset = "0x1645D64", VA = "0x1645D64")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1645DC0", Offset = "0x1645DC0", VA = "0x1645DC0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1645EF4", Offset = "0x1645EF4", VA = "0x1645EF4")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1645F50", Offset = "0x1645F50", VA = "0x1645F50")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1645FD0", Offset = "0x1645FD0", VA = "0x1645FD0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1646180", Offset = "0x1646180", VA = "0x1646180", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x16462F4", Offset = "0x16462F4", VA = "0x16462F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x16464FC", Offset = "0x16464FC", VA = "0x16464FC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x16465D0", Offset = "0x16465D0", VA = "0x16465D0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x16466B8", Offset = "0x16466B8", VA = "0x16466B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x164682C", Offset = "0x164682C", VA = "0x164682C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x16469E8", Offset = "0x16469E8", VA = "0x16469E8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1646C34", Offset = "0x1646C34", VA = "0x1646C34", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1646F04", Offset = "0x1646F04", VA = "0x1646F04", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1646F48", Offset = "0x1646F48", VA = "0x1646F48", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1647038", Offset = "0x1647038", VA = "0x1647038")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AE08", Offset = "0x92AE08")]
		public float spineStiffness;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AE20", Offset = "0x92AE20")]
		public float pullBodyVertical;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AE38", Offset = "0x92AE38")]
		public float pullBodyHorizontal;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92AE50", Offset = "0x92AE50")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700002A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x164714C", Offset = "0x164714C", VA = "0x164714C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1647294", Offset = "0x1647294", VA = "0x1647294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x164729C", Offset = "0x164729C", VA = "0x164729C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x16472A4", Offset = "0x16472A4", VA = "0x16472A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x16472AC", Offset = "0x16472AC", VA = "0x16472AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x16472B4", Offset = "0x16472B4", VA = "0x16472B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x16472BC", Offset = "0x16472BC", VA = "0x16472BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x16472C4", Offset = "0x16472C4", VA = "0x16472C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x16472CC", Offset = "0x16472CC", VA = "0x16472CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x16472D4", Offset = "0x16472D4", VA = "0x16472D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x164730C", Offset = "0x164730C", VA = "0x164730C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1647344", Offset = "0x1647344", VA = "0x1647344")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x164737C", Offset = "0x164737C", VA = "0x164737C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0x16473B4", Offset = "0x16473B4", VA = "0x16473B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x16473E8", Offset = "0x16473E8", VA = "0x16473E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1647420", Offset = "0x1647420", VA = "0x1647420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1647458", Offset = "0x1647458", VA = "0x1647458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1647490", Offset = "0x1647490", VA = "0x1647490")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x164971C", Offset = "0x164971C", VA = "0x164971C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9326A4", Offset = "0x9326A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1649728", Offset = "0x1649728", VA = "0x1649728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9326B4", Offset = "0x9326B4")]
			private set
			{
			}
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x16474C4", Offset = "0x16474C4", VA = "0x16474C4")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x16475D0", Offset = "0x16475D0", VA = "0x16475D0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1647518", Offset = "0x1647518", VA = "0x1647518")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x16476AC", Offset = "0x16476AC", VA = "0x16476AC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1647154", Offset = "0x1647154", VA = "0x1647154")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x164777C", Offset = "0x164777C", VA = "0x164777C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1647834", Offset = "0x1647834", VA = "0x1647834")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x16478E8", Offset = "0x16478E8", VA = "0x16478E8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x164799C", Offset = "0x164799C", VA = "0x164799C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x16479A4", Offset = "0x16479A4", VA = "0x16479A4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x16479D8", Offset = "0x16479D8", VA = "0x16479D8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1647AA0", Offset = "0x1647AA0", VA = "0x1647AA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1647C34", Offset = "0x1647C34", VA = "0x1647C34")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1649034", Offset = "0x1649034", VA = "0x1649034")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x16494C8", Offset = "0x16494C8", VA = "0x16494C8")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1649528", Offset = "0x1649528", VA = "0x1649528")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1649348", Offset = "0x1649348", VA = "0x1649348")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1649408", Offset = "0x1649408", VA = "0x1649408")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1649734", Offset = "0x1649734", VA = "0x1649734")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1649810", Offset = "0x1649810", VA = "0x1649810", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1649958", Offset = "0x1649958", VA = "0x1649958")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1649AE8", Offset = "0x1649AE8", VA = "0x1649AE8")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1649CE8", Offset = "0x1649CE8", VA = "0x1649CE8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1649EE8", Offset = "0x1649EE8", VA = "0x1649EE8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x164A21C", Offset = "0x164A21C", VA = "0x164A21C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x164A31C", Offset = "0x164A31C", VA = "0x164A31C")]
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
			[Address(RVA = "0x164ABB4", Offset = "0x164ABB4", VA = "0x164ABB4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x164ABBC", Offset = "0x164ABBC", VA = "0x164ABBC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x164ABC4", Offset = "0x164ABC4", VA = "0x164ABC4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x164ABD4", Offset = "0x164ABD4", VA = "0x164ABD4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000041")]
		protected float positionOffset
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1641694", Offset = "0x1641694", VA = "0x1641694")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x164A328", Offset = "0x164A328", VA = "0x164A328")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x164A4D8", Offset = "0x164A4D8", VA = "0x164A4D8")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x164A63C", Offset = "0x164A63C", VA = "0x164A63C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x164A6A4", Offset = "0x164A6A4", VA = "0x164A6A4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x164A720", Offset = "0x164A720", VA = "0x164A720", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x164AAB8", Offset = "0x164AAB8", VA = "0x164AAB8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x164AAC0", Offset = "0x164AAC0", VA = "0x164AAC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x164ABCC", Offset = "0x164ABCC", VA = "0x164ABCC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x164ABD0", Offset = "0x164ABD0", VA = "0x164ABD0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1640A94", Offset = "0x1640A94", VA = "0x1640A94")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x16412FC", Offset = "0x16412FC", VA = "0x16412FC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x164AD08", Offset = "0x164AD08", VA = "0x164AD08")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x163F95C", Offset = "0x163F95C", VA = "0x163F95C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AE60", Offset = "0x92AE60")]
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
		[Address(RVA = "0x164AFBC", Offset = "0x164AFBC", VA = "0x164AFBC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x164B378", Offset = "0x164B378", VA = "0x164B378")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x164B430", Offset = "0x164B430", VA = "0x164B430", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x164B5C8", Offset = "0x164B5C8", VA = "0x164B5C8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x164B760", Offset = "0x164B760", VA = "0x164B760", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x164B7AC", Offset = "0x164B7AC", VA = "0x164B7AC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x164B80C", Offset = "0x164B80C", VA = "0x164B80C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x164BB7C", Offset = "0x164BB7C", VA = "0x164BB7C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x164BBA8", Offset = "0x164BBA8", VA = "0x164BBA8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x164B870", Offset = "0x164B870", VA = "0x164B870")]
		private void Read()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x164BCB4", Offset = "0x164BCB4", VA = "0x164BCB4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x164BE40", Offset = "0x164BE40", VA = "0x164BE40")]
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
			[Address(RVA = "0x9E2398", Offset = "0x9E2398", VA = "0x9E2398")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AE78", Offset = "0x92AE78")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AE90", Offset = "0x92AE90")]
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
			[Address(RVA = "0x164D728", Offset = "0x164D728", VA = "0x164D728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x164BFE4", Offset = "0x164BFE4", VA = "0x164BFE4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x164C034", Offset = "0x164C034", VA = "0x164C034")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x164C148", Offset = "0x164C148", VA = "0x164C148", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x164C7B0", Offset = "0x164C7B0", VA = "0x164C7B0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x164D38C", Offset = "0x164D38C", VA = "0x164D38C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x164D4D4", Offset = "0x164D4D4", VA = "0x164D4D4")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x164D688", Offset = "0x164D688", VA = "0x164D688")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x164C4BC", Offset = "0x164C4BC", VA = "0x164C4BC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x164C8DC", Offset = "0x164C8DC", VA = "0x164C8DC")]
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
				[Address(RVA = "0x164F8A8", Offset = "0x164F8A8", VA = "0x164F8A8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1650048", Offset = "0x1650048", VA = "0x1650048")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x164E9FC", Offset = "0x164E9FC", VA = "0x164E9FC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x164ED80", Offset = "0x164ED80", VA = "0x164ED80")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x164FCAC", Offset = "0x164FCAC", VA = "0x164FCAC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AEA8", Offset = "0x92AEA8")]
		public float bodyWeight;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AEC0", Offset = "0x92AEC0")]
		public float headWeight;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AED8", Offset = "0x92AED8")]
		public float eyesWeight;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AEF0", Offset = "0x92AEF0")]
		public float clampWeight;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AF08", Offset = "0x92AF08")]
		public float clampWeightHead;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AF20", Offset = "0x92AF20")]
		public float clampWeightEyes;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AF38", Offset = "0x92AF38")]
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
			[Address(RVA = "0x164E0E8", Offset = "0x164E0E8", VA = "0x164E0E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x164E2C0", Offset = "0x164E2C0", VA = "0x164E2C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x164E1CC", Offset = "0x164E1CC", VA = "0x164E1CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x164E2E4", Offset = "0x164E2E4", VA = "0x164E2E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x164E1DC", Offset = "0x164E1DC", VA = "0x164E1DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x164E360", Offset = "0x164E360", VA = "0x164E360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x164D7A4", Offset = "0x164D7A4", VA = "0x164D7A4")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x164D828", Offset = "0x164D828", VA = "0x164D828")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x164D8D4", Offset = "0x164D8D4", VA = "0x164D8D4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x164D99C", Offset = "0x164D99C", VA = "0x164D99C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x164DA88", Offset = "0x164DA88", VA = "0x164DA88")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x164DB94", Offset = "0x164DB94", VA = "0x164DB94")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x164DCDC", Offset = "0x164DCDC", VA = "0x164DCDC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x164DE00", Offset = "0x164DE00", VA = "0x164DE00")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x164DE0C", Offset = "0x164DE0C", VA = "0x164DE0C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x164DF48", Offset = "0x164DF48", VA = "0x164DF48", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x164E384", Offset = "0x164E384", VA = "0x164E384", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x164E5EC", Offset = "0x164E5EC", VA = "0x164E5EC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x164E78C", Offset = "0x164E78C", VA = "0x164E78C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x164EA2C", Offset = "0x164EA2C", VA = "0x164EA2C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x164EEBC", Offset = "0x164EEBC", VA = "0x164EEBC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x164EFC0", Offset = "0x164EFC0", VA = "0x164EFC0")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x164F1EC", Offset = "0x164F1EC", VA = "0x164F1EC")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x164F448", Offset = "0x164F448", VA = "0x164F448")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x164F974", Offset = "0x164F974", VA = "0x164F974")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x164E850", Offset = "0x164E850", VA = "0x164E850")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x164FE14", Offset = "0x164FE14", VA = "0x164FE14")]
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
			[Address(RVA = "0x1651680", Offset = "0x1651680", VA = "0x1651680")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1652238", Offset = "0x1652238", VA = "0x1652238")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x164C07C", Offset = "0x164C07C", VA = "0x164C07C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1652300", Offset = "0x1652300", VA = "0x1652300")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AF50", Offset = "0x92AF50")]
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
		[Address(RVA = "0x165004C", Offset = "0x165004C", VA = "0x165004C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x165023C", Offset = "0x165023C", VA = "0x165023C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x16503F0", Offset = "0x16503F0", VA = "0x16503F0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x16503FC", Offset = "0x16503FC", VA = "0x16503FC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1650480", Offset = "0x1650480", VA = "0x1650480")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x165048C", Offset = "0x165048C", VA = "0x165048C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1650494", Offset = "0x1650494", VA = "0x1650494", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x16505BC", Offset = "0x16505BC", VA = "0x16505BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x16506DC", Offset = "0x16506DC", VA = "0x16506DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x165071C", Offset = "0x165071C", VA = "0x165071C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1650770", Offset = "0x1650770", VA = "0x1650770", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1650B7C", Offset = "0x1650B7C", VA = "0x1650B7C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1650BFC", Offset = "0x1650BFC", VA = "0x1650BFC")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x16511A4", Offset = "0x16511A4", VA = "0x16511A4")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x16513BC", Offset = "0x16513BC", VA = "0x16513BC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1651578", Offset = "0x1651578", VA = "0x1651578")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x16514F4", Offset = "0x16514F4", VA = "0x16514F4")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1651820", Offset = "0x1651820", VA = "0x1651820", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x16522F4", Offset = "0x16522F4", VA = "0x16522F4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x16522F8", Offset = "0x16522F8", VA = "0x16522F8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x16522FC", Offset = "0x16522FC", VA = "0x16522FC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1651F2C", Offset = "0x1651F2C", VA = "0x1651F2C")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x164D560", Offset = "0x164D560", VA = "0x164D560")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E3D0", Offset = "0x92E3D0")]
			public Transform target;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E408", Offset = "0x92E408")]
			public Transform bendGoal;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E440", Offset = "0x92E440")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E440", Offset = "0x92E440")]
			public float positionWeight;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E494", Offset = "0x92E494")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E494", Offset = "0x92E494")]
			public float rotationWeight;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E4E8", Offset = "0x92E4E8")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E520", Offset = "0x92E520")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E520", Offset = "0x92E520")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E574", Offset = "0x92E574")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E574", Offset = "0x92E574")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E5C8", Offset = "0x92E5C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E5C8", Offset = "0x92E5C8")]
			public float bendGoalWeight;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E61C", Offset = "0x92E61C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E61C", Offset = "0x92E61C")]
			public float swivelOffset;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E678", Offset = "0x92E678")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E6B0", Offset = "0x92E6B0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E6E8", Offset = "0x92E6E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E6E8", Offset = "0x92E6E8")]
			public float armLengthMlp;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E740", Offset = "0x92E740")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E7B8", Offset = "0x92E7B8")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E7C8", Offset = "0x92E7C8")]
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
				[Address(RVA = "0x17673C0", Offset = "0x17673C0", VA = "0x17673C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9337F8", Offset = "0x9337F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006AA")]
				[Address(RVA = "0x17673CC", Offset = "0x17673CC", VA = "0x17673CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933808", Offset = "0x933808")]
				private set
				{
				}
			}

			[Token(Token = "0x17000091")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x17673D8", Offset = "0x17673D8", VA = "0x17673D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933818", Offset = "0x933818")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006AC")]
				[Address(RVA = "0x17673E4", Offset = "0x17673E4", VA = "0x17673E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933828", Offset = "0x933828")]
				private set
				{
				}
			}

			[Token(Token = "0x17000092")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60006AD")]
				[Address(RVA = "0x17673F0", Offset = "0x17673F0", VA = "0x17673F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60006AE")]
				[Address(RVA = "0x1767424", Offset = "0x1767424", VA = "0x1767424")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60006AF")]
				[Address(RVA = "0x1767464", Offset = "0x1767464", VA = "0x1767464")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone hand
			{
				[Token(Token = "0x60006B0")]
				[Address(RVA = "0x17674B0", Offset = "0x17674B0", VA = "0x17674B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x17674FC", Offset = "0x17674FC", VA = "0x17674FC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1767F70", Offset = "0x1767F70", VA = "0x1767F70", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x1768164", Offset = "0x1768164", VA = "0x1768164", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1768210", Offset = "0x1768210", VA = "0x1768210")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1768628", Offset = "0x1768628", VA = "0x1768628")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x176AB9C", Offset = "0x176AB9C", VA = "0x176AB9C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x176AC0C", Offset = "0x176AC0C", VA = "0x176AC0C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1769B8C", Offset = "0x1769B8C", VA = "0x1769B8C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1769E98", Offset = "0x1769E98", VA = "0x1769E98")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x176AE2C", Offset = "0x176AE2C", VA = "0x176AE2C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x176AF54", Offset = "0x176AF54", VA = "0x176AF54")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E7D8", Offset = "0x92E7D8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E7E8", Offset = "0x92E7E8")]
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
				[Address(RVA = "0x176B12C", Offset = "0x176B12C", VA = "0x176B12C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933838", Offset = "0x933838")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C2")]
				[Address(RVA = "0x176B134", Offset = "0x176B134", VA = "0x176B134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933848", Offset = "0x933848")]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public float mag
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x176B13C", Offset = "0x176B13C", VA = "0x176B13C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933858", Offset = "0x933858")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006C4")]
				[Address(RVA = "0x176B144", Offset = "0x176B144", VA = "0x176B144")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933868", Offset = "0x933868")]
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
			[Address(RVA = "0x176B14C", Offset = "0x176B14C", VA = "0x176B14C")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x176B154", Offset = "0x176B154", VA = "0x176B154")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x176B510", Offset = "0x176B510", VA = "0x176B510")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x176B67C", Offset = "0x176B67C", VA = "0x176B67C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x176B90C", Offset = "0x176B90C", VA = "0x176B90C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x176B960", Offset = "0x176B960", VA = "0x176B960")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x176A9FC", Offset = "0x176A9FC", VA = "0x176A9FC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x176BB4C", Offset = "0x176BB4C", VA = "0x176BB4C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x176BC90", Offset = "0x176BC90", VA = "0x176BC90")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x176B088", Offset = "0x176B088", VA = "0x176B088")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92E808", Offset = "0x92E808")]
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
				[Address(RVA = "0x176BCB8", Offset = "0x176BCB8", VA = "0x176BCB8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000099")]
			public float stepProgress
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x176BCCC", Offset = "0x176BCCC", VA = "0x176BCCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933878", Offset = "0x933878")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x176BCD4", Offset = "0x176BCD4", VA = "0x176BCD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933888", Offset = "0x933888")]
				private set
				{
				}
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x176BCDC", Offset = "0x176BCDC", VA = "0x176BCDC")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x176BE6C", Offset = "0x176BE6C", VA = "0x176BE6C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x176BEB4", Offset = "0x176BEB4", VA = "0x176BEB4")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x176C084", Offset = "0x176C084", VA = "0x176C084")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x176C25C", Offset = "0x176C25C", VA = "0x176C25C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x176C448", Offset = "0x176C448", VA = "0x176C448")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E818", Offset = "0x92E818")]
			public Transform target;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E850", Offset = "0x92E850")]
			public Transform bendGoal;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E888", Offset = "0x92E888")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E888", Offset = "0x92E888")]
			public float positionWeight;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E8DC", Offset = "0x92E8DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E8DC", Offset = "0x92E8DC")]
			public float rotationWeight;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E930", Offset = "0x92E930")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E930", Offset = "0x92E930")]
			public float bendGoalWeight;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E984", Offset = "0x92E984")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E984", Offset = "0x92E984")]
			public float swivelOffset;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92E9E0", Offset = "0x92E9E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92E9E0", Offset = "0x92E9E0")]
			public float bendToTargetWeight;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EA34", Offset = "0x92EA34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92EA34", Offset = "0x92EA34")]
			public float legLengthMlp;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EA8C", Offset = "0x92EA8C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92EB34", Offset = "0x92EB34")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92EB44", Offset = "0x92EB44")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92EB54", Offset = "0x92EB54")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92EB64", Offset = "0x92EB64")]
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
				[Address(RVA = "0x176C664", Offset = "0x176C664", VA = "0x176C664")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933898", Offset = "0x933898")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x176C670", Offset = "0x176C670", VA = "0x176C670")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338A8", Offset = "0x9338A8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public Quaternion rotation
			{
				[Token(Token = "0x60006DA")]
				[Address(RVA = "0x176C67C", Offset = "0x176C67C", VA = "0x176C67C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338B8", Offset = "0x9338B8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60006DB")]
				[Address(RVA = "0x176C688", Offset = "0x176C688", VA = "0x176C688")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338C8", Offset = "0x9338C8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public bool hasToes
			{
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x176C694", Offset = "0x176C694", VA = "0x176C694")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338D8", Offset = "0x9338D8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60006DD")]
				[Address(RVA = "0x176C69C", Offset = "0x176C69C", VA = "0x176C69C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338E8", Offset = "0x9338E8")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x176C6A8", Offset = "0x176C6A8", VA = "0x176C6A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private VirtualBone calf
			{
				[Token(Token = "0x60006DF")]
				[Address(RVA = "0x176C6DC", Offset = "0x176C6DC", VA = "0x176C6DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private VirtualBone foot
			{
				[Token(Token = "0x60006E0")]
				[Address(RVA = "0x176C714", Offset = "0x176C714", VA = "0x176C714")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private VirtualBone toes
			{
				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x176C74C", Offset = "0x176C74C", VA = "0x176C74C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x176C784", Offset = "0x176C784", VA = "0x176C784")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x176C7C4", Offset = "0x176C7C4", VA = "0x176C7C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9338F8", Offset = "0x9338F8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x176C7D0", Offset = "0x176C7D0", VA = "0x176C7D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933908", Offset = "0x933908")]
				private set
				{
				}
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x176C7DC", Offset = "0x176C7DC", VA = "0x176C7DC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x176CDE4", Offset = "0x176CDE4", VA = "0x176CDE4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x176D6E4", Offset = "0x176D6E4", VA = "0x176D6E4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x176D5E0", Offset = "0x176D5E0", VA = "0x176D5E0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x176D3A8", Offset = "0x176D3A8", VA = "0x176D3A8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x176DC9C", Offset = "0x176DC9C", VA = "0x176DC9C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x176E3F8", Offset = "0x176E3F8", VA = "0x176E3F8")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x176DECC", Offset = "0x176DECC", VA = "0x176DECC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x176E860", Offset = "0x176E860", VA = "0x176E860", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x176EA7C", Offset = "0x176EA7C", VA = "0x176EA7C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x176EB2C", Offset = "0x176EB2C", VA = "0x176EB2C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EB74", Offset = "0x92EB74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92EB74", Offset = "0x92EB74")]
			public float weight;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EBC8", Offset = "0x92EBC8")]
			public float footDistance;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EC00", Offset = "0x92EC00")]
			public float stepThreshold;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EC38", Offset = "0x92EC38")]
			public float angleThreshold;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EC70", Offset = "0x92EC70")]
			public float comAngleMlp;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92ECA8", Offset = "0x92ECA8")]
			public float maxVelocity;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92ECE0", Offset = "0x92ECE0")]
			public float velocityFactor;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92ED18", Offset = "0x92ED18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92ED18", Offset = "0x92ED18")]
			public float maxLegStretch;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92ED70", Offset = "0x92ED70")]
			public float rootSpeed;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EDA8", Offset = "0x92EDA8")]
			public float stepSpeed;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EDE0", Offset = "0x92EDE0")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EE18", Offset = "0x92EE18")]
			public float maxBodyYOffset;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EE50", Offset = "0x92EE50")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EE88", Offset = "0x92EE88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92EE88", Offset = "0x92EE88")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EEE0", Offset = "0x92EEE0")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EF18", Offset = "0x92EF18")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EF50", Offset = "0x92EF50")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92EFC8", Offset = "0x92EFC8")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F000", Offset = "0x92F000")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92F038", Offset = "0x92F038")]
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
				[Address(RVA = "0x176EC2C", Offset = "0x176EC2C", VA = "0x176EC2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933918", Offset = "0x933918")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006F1")]
				[Address(RVA = "0x176EC38", Offset = "0x176EC38", VA = "0x176EC38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933928", Offset = "0x933928")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x17711D0", Offset = "0x17711D0", VA = "0x17711D0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x1771210", Offset = "0x1771210", VA = "0x1771210")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1771254", Offset = "0x1771254", VA = "0x1771254")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000A7")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x1771294", Offset = "0x1771294", VA = "0x1771294")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x176EC44", Offset = "0x176EC44", VA = "0x176EC44")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x176EF68", Offset = "0x176EF68", VA = "0x176EF68")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x176F1DC", Offset = "0x176F1DC", VA = "0x176F1DC")]
			public void Relax()
			{
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x176F240", Offset = "0x176F240", VA = "0x176F240")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x176F618", Offset = "0x176F618", VA = "0x176F618")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x176F7C8", Offset = "0x176F7C8", VA = "0x176F7C8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1770DDC", Offset = "0x1770DDC", VA = "0x1770DDC")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1770F80", Offset = "0x1770F80", VA = "0x1770F80")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1771004", Offset = "0x1771004", VA = "0x1771004")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x17712D8", Offset = "0x17712D8", VA = "0x17712D8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F048", Offset = "0x92F048")]
			public Transform headTarget;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F080", Offset = "0x92F080")]
			public Transform pelvisTarget;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F0B8", Offset = "0x92F0B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F0B8", Offset = "0x92F0B8")]
			public float positionWeight;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F10C", Offset = "0x92F10C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F10C", Offset = "0x92F10C")]
			public float rotationWeight;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F160", Offset = "0x92F160")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F160", Offset = "0x92F160")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F1B4", Offset = "0x92F1B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F1B4", Offset = "0x92F1B4")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F208", Offset = "0x92F208")]
			public Transform chestGoal;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F240", Offset = "0x92F240")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F240", Offset = "0x92F240")]
			public float chestGoalWeight;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F294", Offset = "0x92F294")]
			public float minHeadHeight;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F2CC", Offset = "0x92F2CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F2CC", Offset = "0x92F2CC")]
			public float bodyPosStiffness;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F320", Offset = "0x92F320")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F320", Offset = "0x92F320")]
			public float bodyRotStiffness;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F374", Offset = "0x92F374")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x92F374", Offset = "0x92F374")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F374", Offset = "0x92F374")]
			public float neckStiffness;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F3EC", Offset = "0x92F3EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F3EC", Offset = "0x92F3EC")]
			public float rotateChestByHands;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F440", Offset = "0x92F440")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F440", Offset = "0x92F440")]
			public float chestClampWeight;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F494", Offset = "0x92F494")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F494", Offset = "0x92F494")]
			public float headClampWeight;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F4E8", Offset = "0x92F4E8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F520", Offset = "0x92F520")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F520", Offset = "0x92F520")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F574", Offset = "0x92F574")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F574", Offset = "0x92F574")]
			public float maxRootAngle;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F5CC", Offset = "0x92F5CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92F5CC", Offset = "0x92F5CC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92F708", Offset = "0x92F708")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92F718", Offset = "0x92F718")]
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
				[Address(RVA = "0x1770D5C", Offset = "0x1770D5C", VA = "0x1770D5C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x17713EC", Offset = "0x17713EC", VA = "0x17713EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x177142C", Offset = "0x177142C", VA = "0x177142C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000703")]
				[Address(RVA = "0x1771480", Offset = "0x1771480", VA = "0x1771480")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone head
			{
				[Token(Token = "0x6000704")]
				[Address(RVA = "0x1770D9C", Offset = "0x1770D9C", VA = "0x1770D9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x17714C0", Offset = "0x17714C0", VA = "0x17714C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933938", Offset = "0x933938")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000706")]
				[Address(RVA = "0x17714D4", Offset = "0x17714D4", VA = "0x17714D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933948", Offset = "0x933948")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0x17714E8", Offset = "0x17714E8", VA = "0x17714E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933958", Offset = "0x933958")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000708")]
				[Address(RVA = "0x17714FC", Offset = "0x17714FC", VA = "0x17714FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933968", Offset = "0x933968")]
				private set
				{
				}
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1771510", Offset = "0x1771510", VA = "0x1771510", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x177201C", Offset = "0x177201C", VA = "0x177201C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x177222C", Offset = "0x177222C", VA = "0x177222C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x17728B4", Offset = "0x17728B4", VA = "0x17728B4")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1772E74", Offset = "0x1772E74", VA = "0x1772E74")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x17738FC", Offset = "0x17738FC", VA = "0x17738FC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1774128", Offset = "0x1774128", VA = "0x1774128")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1774894", Offset = "0x1774894", VA = "0x1774894", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1774A70", Offset = "0x1774A70", VA = "0x1774A70", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1772AE4", Offset = "0x1772AE4", VA = "0x1772AE4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1773D70", Offset = "0x1773D70", VA = "0x1773D70")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x17734A0", Offset = "0x17734A0", VA = "0x17734A0")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1774B6C", Offset = "0x1774B6C", VA = "0x1774B6C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1773EDC", Offset = "0x1773EDC", VA = "0x1773EDC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1773ABC", Offset = "0x1773ABC", VA = "0x1773ABC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1774E94", Offset = "0x1774E94", VA = "0x1774E94")]
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
			[Address(RVA = "0x1767ED4", Offset = "0x1767ED4", VA = "0x1767ED4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x1767F50", Offset = "0x1767F50", VA = "0x1767F50")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1775048", Offset = "0x1775048", VA = "0x1775048")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x176B224", Offset = "0x176B224", VA = "0x176B224")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x176B724", Offset = "0x176B724", VA = "0x176B724")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x17752D8", Offset = "0x17752D8", VA = "0x17752D8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1769C64", Offset = "0x1769C64", VA = "0x1769C64")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1775510", Offset = "0x1775510", VA = "0x1775510")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x176A450", Offset = "0x176A450", VA = "0x176A450")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x17755C8", Offset = "0x17755C8", VA = "0x17755C8")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1774434", Offset = "0x1774434", VA = "0x1774434")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x17757E0", Offset = "0x17757E0", VA = "0x17757E0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x17758E8", Offset = "0x17758E8", VA = "0x17758E8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AF68", Offset = "0x92AF68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92AF68", Offset = "0x92AF68")]
		public int LOD;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AFBC", Offset = "0x92AFBC")]
		public float scale;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92AFF4", Offset = "0x92AFF4")]
		public bool plantFeet;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B02C", Offset = "0x92B02C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B03C", Offset = "0x92B03C")]
		public Spine spine;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B074", Offset = "0x92B074")]
		public Arm leftArm;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B0AC", Offset = "0x92B0AC")]
		public Arm rightArm;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B0E4", Offset = "0x92B0E4")]
		public Leg leftLeg;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B11C", Offset = "0x92B11C")]
		public Leg rightLeg;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B154", Offset = "0x92B154")]
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
			[Address(RVA = "0x1656648", Offset = "0x1656648", VA = "0x1656648")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9326C4", Offset = "0x9326C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1656650", Offset = "0x1656650", VA = "0x1656650")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9326D4", Offset = "0x9326D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1652304", Offset = "0x1652304", VA = "0x1652304")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1652798", Offset = "0x1652798", VA = "0x1652798")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1652620", Offset = "0x1652620", VA = "0x1652620")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1652B6C", Offset = "0x1652B6C", VA = "0x1652B6C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1652E48", Offset = "0x1652E48", VA = "0x1652E48")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1652EEC", Offset = "0x1652EEC", VA = "0x1652EEC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1653080", Offset = "0x1653080", VA = "0x1653080")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x165320C", Offset = "0x165320C", VA = "0x165320C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1653A88", Offset = "0x1653A88", VA = "0x1653A88", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1653BFC", Offset = "0x1653BFC", VA = "0x1653BFC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1653E04", Offset = "0x1653E04", VA = "0x1653E04", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1653E78", Offset = "0x1653E78", VA = "0x1653E78", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1653EEC", Offset = "0x1653EEC", VA = "0x1653EEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x165410C", Offset = "0x165410C", VA = "0x165410C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1652A48", Offset = "0x1652A48", VA = "0x1652A48")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1653384", Offset = "0x1653384", VA = "0x1653384")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x16543EC", Offset = "0x16543EC", VA = "0x16543EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1654434", Offset = "0x1654434", VA = "0x1654434", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1655BD0", Offset = "0x1655BD0", VA = "0x1655BD0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x16534EC", Offset = "0x16534EC", VA = "0x16534EC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x16548FC", Offset = "0x16548FC", VA = "0x16548FC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1655FBC", Offset = "0x1655FBC", VA = "0x1655FBC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1656004", Offset = "0x1656004", VA = "0x1656004")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1655A80", Offset = "0x1655A80", VA = "0x1655A80")]
		private void Write()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1656048", Offset = "0x1656048", VA = "0x1656048")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1656658", Offset = "0x1656658", VA = "0x1656658")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B18C", Offset = "0x92B18C")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1454200", Offset = "0x1454200", VA = "0x1454200")]
		public void Start()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1454958", Offset = "0x1454958", VA = "0x1454958")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1454EDC", Offset = "0x1454EDC", VA = "0x1454EDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1454FA4", Offset = "0x1454FA4", VA = "0x1454FA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x14550CC", Offset = "0x14550CC", VA = "0x14550CC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B1C4", Offset = "0x92B1C4")]
		public Transform transform;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B1FC", Offset = "0x92B1FC")]
		public Transform parent;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B234", Offset = "0x92B234")]
		public Transform[] children;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B26C", Offset = "0x92B26C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92B26C", Offset = "0x92B26C")]
		public float weight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B2C0", Offset = "0x92B2C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92B2C0", Offset = "0x92B2C0")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B314", Offset = "0x92B314")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92B314", Offset = "0x92B314")]
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
		[Address(RVA = "0x1455138", Offset = "0x1455138", VA = "0x1455138")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x14543D4", Offset = "0x14543D4", VA = "0x14543D4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1454A20", Offset = "0x1454A20", VA = "0x1454A20")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B370", Offset = "0x92B370")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B380", Offset = "0x92B380")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B390", Offset = "0x92B390")]
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
			[Address(RVA = "0x1776110", Offset = "0x1776110", VA = "0x1776110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9326E4", Offset = "0x9326E4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x1776118", Offset = "0x1776118", VA = "0x1776118")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9326F4", Offset = "0x9326F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isPaused
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1776120", Offset = "0x1776120", VA = "0x1776120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932704", Offset = "0x932704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1776128", Offset = "0x1776128", VA = "0x1776128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932714", Offset = "0x932714")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1776134", Offset = "0x1776134", VA = "0x1776134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932724", Offset = "0x932724")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x177613C", Offset = "0x177613C", VA = "0x177613C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932734", Offset = "0x932734")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool inInteraction
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1776144", Offset = "0x1776144", VA = "0x1776144")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public float progress
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1778E7C", Offset = "0x1778E7C", VA = "0x1778E7C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x17761B4", Offset = "0x17761B4", VA = "0x17761B4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1776244", Offset = "0x1776244", VA = "0x1776244")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1776308", Offset = "0x1776308", VA = "0x1776308")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1776480", Offset = "0x1776480", VA = "0x1776480")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1776930", Offset = "0x1776930", VA = "0x1776930")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1776CF0", Offset = "0x1776CF0", VA = "0x1776CF0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1776D44", Offset = "0x1776D44", VA = "0x1776D44")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1777A58", Offset = "0x1777A58", VA = "0x1777A58")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1778608", Offset = "0x1778608", VA = "0x1778608")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1778830", Offset = "0x1778830", VA = "0x1778830")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1778D0C", Offset = "0x1778D0C", VA = "0x1778D0C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1779364", Offset = "0x1779364", VA = "0x1779364")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B3A0", Offset = "0x92B3A0")]
		public LookAtIK ik;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B3D8", Offset = "0x92B3D8")]
		public float lerpSpeed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B410", Offset = "0x92B410")]
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
		[Address(RVA = "0x177964C", Offset = "0x177964C", VA = "0x177964C")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x17797D0", Offset = "0x17797D0", VA = "0x17797D0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1779878", Offset = "0x1779878", VA = "0x1779878")]
		public void Update()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1779ACC", Offset = "0x1779ACC", VA = "0x1779ACC")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1779BC4", Offset = "0x1779BC4", VA = "0x1779BC4")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1779C90", Offset = "0x1779C90", VA = "0x1779C90")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928BA8", Offset = "0x928BA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928BA8", Offset = "0x928BA8")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class InteractionEvent
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F728", Offset = "0x92F728")]
			public float time;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F760", Offset = "0x92F760")]
			public bool pause;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F798", Offset = "0x92F798")]
			public bool pickUp;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F7D0", Offset = "0x92F7D0")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F808", Offset = "0x92F808")]
			public Message[] messages;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F840", Offset = "0x92F840")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1778EB8", Offset = "0x1778EB8", VA = "0x1778EB8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x177AFA0", Offset = "0x177AFA0", VA = "0x177AFA0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F878", Offset = "0x92F878")]
			public string function;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F8B0", Offset = "0x92F8B0")]
			public GameObject recipient;

			[Token(Token = "0x4000704")]
			private const string empty = "";

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x177AEB0", Offset = "0x177AEB0", VA = "0x177AEB0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x177AFA8", Offset = "0x177AFA8", VA = "0x177AFA8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F8E8", Offset = "0x92F8E8")]
			public Animator animator;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F920", Offset = "0x92F920")]
			public Animation animation;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F958", Offset = "0x92F958")]
			public string animationState;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F990", Offset = "0x92F990")]
			public float crossfadeTime;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92F9C8", Offset = "0x92F9C8")]
			public int layer;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FA00", Offset = "0x92FA00")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400070B")]
			private const string empty = "";

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x177AC10", Offset = "0x177AC10", VA = "0x177AC10")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x177AD04", Offset = "0x177AD04", VA = "0x177AD04")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x177ADBC", Offset = "0x177ADBC", VA = "0x177ADBC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x177AE9C", Offset = "0x177AE9C", VA = "0x177AE9C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FA38", Offset = "0x92FA38")]
			public Type type;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FA70", Offset = "0x92FA70")]
			public AnimationCurve curve;

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x177A41C", Offset = "0x177A41C", VA = "0x177A41C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x177AFC0", Offset = "0x177AFC0", VA = "0x177AFC0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FAA8", Offset = "0x92FAA8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FAE0", Offset = "0x92FAE0")]
			public float multiplier;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FB18", Offset = "0x92FB18")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x177AAFC", Offset = "0x177AAFC", VA = "0x177AAFC")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x177AFB0", Offset = "0x177AFB0", VA = "0x177AFB0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B458", Offset = "0x92B458")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B490", Offset = "0x92B490")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B4C8", Offset = "0x92B4C8")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B500", Offset = "0x92B500")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B510", Offset = "0x92B510")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700004F")]
		public float length
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1779F04", Offset = "0x1779F04", VA = "0x1779F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932904", Offset = "0x932904")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1779F0C", Offset = "0x1779F0C", VA = "0x1779F0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932914", Offset = "0x932914")]
			private set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1779F14", Offset = "0x1779F14", VA = "0x1779F14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932924", Offset = "0x932924")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1779F1C", Offset = "0x1779F1C", VA = "0x1779F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932934", Offset = "0x932934")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x177A140", Offset = "0x177A140", VA = "0x177A140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1779238", Offset = "0x1779238", VA = "0x1779238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1779CA4", Offset = "0x1779CA4", VA = "0x1779CA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932744", Offset = "0x932744")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1779CF0", Offset = "0x1779CF0", VA = "0x1779CF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93277C", Offset = "0x93277C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1779D3C", Offset = "0x1779D3C", VA = "0x1779D3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9327B4", Offset = "0x9327B4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1779D88", Offset = "0x1779D88", VA = "0x1779D88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9327EC", Offset = "0x9327EC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1779DD4", Offset = "0x1779DD4", VA = "0x1779DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932824", Offset = "0x932824")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1779E20", Offset = "0x1779E20", VA = "0x1779E20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93285C", Offset = "0x93285C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1779E6C", Offset = "0x1779E6C", VA = "0x1779E6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932894", Offset = "0x932894")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1779EB8", Offset = "0x1779EB8", VA = "0x1779EB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9328CC", Offset = "0x9328CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1779F24", Offset = "0x1779F24", VA = "0x1779F24")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x177A1D0", Offset = "0x177A1D0", VA = "0x177A1D0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x17772FC", Offset = "0x17772FC", VA = "0x17772FC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x177A334", Offset = "0x177A334", VA = "0x177A334")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x17771B8", Offset = "0x17771B8", VA = "0x17771B8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x17772F4", Offset = "0x17772F4", VA = "0x17772F4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x17781EC", Offset = "0x17781EC", VA = "0x17781EC")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1778AE4", Offset = "0x1778AE4", VA = "0x1778AE4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x177AB38", Offset = "0x177AB38", VA = "0x177AB38")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x177A438", Offset = "0x177A438", VA = "0x177A438")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x177A33C", Offset = "0x177A33C", VA = "0x177A33C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x177AA94", Offset = "0x177AA94", VA = "0x177AA94")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x177AB3C", Offset = "0x177AB3C", VA = "0x177AB3C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x177ABA4", Offset = "0x177ABA4", VA = "0x177ABA4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928C08", Offset = "0x928C08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928C08", Offset = "0x928C08")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000EB")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000EC")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B520", Offset = "0x92B520")]
		public string targetTag;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B558", Offset = "0x92B558")]
		public float fadeInTime;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B590", Offset = "0x92B590")]
		public float speed;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B5C8", Offset = "0x92B5C8")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92B600", Offset = "0x92B600")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B600", Offset = "0x92B600")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x92B600", Offset = "0x92B600")]
		public Collider characterCollider;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B684", Offset = "0x92B684")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x92B684", Offset = "0x92B684")]
		public Transform FPSCamera;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B6E4", Offset = "0x92B6E4")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B71C", Offset = "0x92B71C")]
		public float camRaycastDistance;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B754", Offset = "0x92B754")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x92B764", Offset = "0x92B764")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B764", Offset = "0x92B764")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B7C4", Offset = "0x92B7C4")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92B7FC", Offset = "0x92B7FC")]
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
			[Address(RVA = "0x177B228", Offset = "0x177B228", VA = "0x177B228")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x177CE80", Offset = "0x177CE80", VA = "0x177CE80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x177CE88", Offset = "0x177CE88", VA = "0x177CE88")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x177CE90", Offset = "0x177CE90", VA = "0x177CE90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932B04", Offset = "0x932B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x177CE98", Offset = "0x177CE98", VA = "0x177CE98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932B14", Offset = "0x932B14")]
			private set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public bool initiated
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x177CEA0", Offset = "0x177CEA0", VA = "0x177CEA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932B24", Offset = "0x932B24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x177CEA8", Offset = "0x177CEA8", VA = "0x177CEA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932B34", Offset = "0x932B34")]
			private set
			{
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x177AFC8", Offset = "0x177AFC8", VA = "0x177AFC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932944", Offset = "0x932944")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x177B014", Offset = "0x177B014", VA = "0x177B014")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x93297C", Offset = "0x93297C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x177B060", Offset = "0x177B060", VA = "0x177B060")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9329B4", Offset = "0x9329B4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x177B0AC", Offset = "0x177B0AC", VA = "0x177B0AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9329EC", Offset = "0x9329EC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x177B0F8", Offset = "0x177B0F8", VA = "0x177B0F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932A24", Offset = "0x932A24")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x177B144", Offset = "0x177B144", VA = "0x177B144")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932A5C", Offset = "0x932A5C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x177B190", Offset = "0x177B190", VA = "0x177B190")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932A94", Offset = "0x932A94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x177B1DC", Offset = "0x177B1DC", VA = "0x177B1DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932ACC", Offset = "0x932ACC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x177B3B8", Offset = "0x177B3B8", VA = "0x177B3B8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x177B484", Offset = "0x177B484", VA = "0x177B484")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x177B550", Offset = "0x177B550", VA = "0x177B550")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x177B5FC", Offset = "0x177B5FC", VA = "0x177B5FC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x177B6F4", Offset = "0x177B6F4", VA = "0x177B6F4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x177B810", Offset = "0x177B810", VA = "0x177B810")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x177B8A0", Offset = "0x177B8A0", VA = "0x177B8A0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x177B930", Offset = "0x177B930", VA = "0x177B930")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x177B9C0", Offset = "0x177B9C0", VA = "0x177B9C0")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x177BA34", Offset = "0x177BA34", VA = "0x177BA34")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x177BAA8", Offset = "0x177BAA8", VA = "0x177BAA8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x177BB10", Offset = "0x177BB10", VA = "0x177BB10")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x177BB9C", Offset = "0x177BB9C", VA = "0x177BB9C")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x177BC50", Offset = "0x177BC50", VA = "0x177BC50")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x177BD34", Offset = "0x177BD34", VA = "0x177BD34")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x177BFD8", Offset = "0x177BFD8", VA = "0x177BFD8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x177C1C8", Offset = "0x177C1C8", VA = "0x177C1C8")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x177C44C", Offset = "0x177C44C", VA = "0x177C44C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x177C740", Offset = "0x177C740", VA = "0x177C740")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x177C784", Offset = "0x177C784", VA = "0x177C784")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x177C7FC", Offset = "0x177C7FC", VA = "0x177C7FC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x177C934", Offset = "0x177C934", VA = "0x177C934")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x177CAAC", Offset = "0x177CAAC", VA = "0x177CAAC")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x177CD54", Offset = "0x177CD54", VA = "0x177CD54")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x177C54C", Offset = "0x177C54C", VA = "0x177C54C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x177CEB4", Offset = "0x177CEB4", VA = "0x177CEB4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x177D668", Offset = "0x177D668", VA = "0x177D668")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x177D688", Offset = "0x177D688", VA = "0x177D688")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x177D6A4", Offset = "0x177D6A4", VA = "0x177D6A4")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x177D6C0", Offset = "0x177D6C0", VA = "0x177D6C0")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x177D720", Offset = "0x177D720", VA = "0x177D720")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x177D83C", Offset = "0x177D83C", VA = "0x177D83C")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x177D938", Offset = "0x177D938", VA = "0x177D938")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x177DAE0", Offset = "0x177DAE0", VA = "0x177DAE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x177DBF8", Offset = "0x177DBF8", VA = "0x177DBF8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x177DE10", Offset = "0x177DE10", VA = "0x177DE10")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x177D3C8", Offset = "0x177D3C8", VA = "0x177D3C8")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x177DF50", Offset = "0x177DF50", VA = "0x177DF50")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x177E07C", Offset = "0x177E07C", VA = "0x177E07C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x177E114", Offset = "0x177E114", VA = "0x177E114")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x177E1EC", Offset = "0x177E1EC", VA = "0x177E1EC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x177E204", Offset = "0x177E204", VA = "0x177E204")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x177B2D4", Offset = "0x177B2D4", VA = "0x177B2D4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x177BED4", Offset = "0x177BED4", VA = "0x177BED4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x177E5C8", Offset = "0x177E5C8", VA = "0x177E5C8")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928C68", Offset = "0x928C68")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928C68", Offset = "0x928C68")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FB50", Offset = "0x92FB50")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FB88", Offset = "0x92FB88")]
			public float multiplier;

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1448F10", Offset = "0x1448F10", VA = "0x1448F10")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B80C", Offset = "0x92B80C")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B844", Offset = "0x92B844")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B87C", Offset = "0x92B87C")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B8B4", Offset = "0x92B8B4")]
		public Transform pivot;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B8EC", Offset = "0x92B8EC")]
		public RotationMode rotationMode;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B924", Offset = "0x92B924")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B95C", Offset = "0x92B95C")]
		public float twistWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B994", Offset = "0x92B994")]
		public float swingWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92B9CC", Offset = "0x92B9CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92B9CC", Offset = "0x92B9CC")]
		public float threeDOFWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BA20", Offset = "0x92BA20")]
		public bool rotateOnce;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x177EB28", Offset = "0x177EB28", VA = "0x177EB28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932B44", Offset = "0x932B44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x177EB74", Offset = "0x177EB74", VA = "0x177EB74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932B7C", Offset = "0x932B7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x177EBC0", Offset = "0x177EBC0", VA = "0x177EBC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932BB4", Offset = "0x932BB4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x177EC0C", Offset = "0x177EC0C", VA = "0x177EC0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932BEC", Offset = "0x932BEC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x177EC58", Offset = "0x177EC58", VA = "0x177EC58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932C24", Offset = "0x932C24")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x177ECA4", Offset = "0x177ECA4", VA = "0x177ECA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932C5C", Offset = "0x932C5C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x177ECF0", Offset = "0x177ECF0", VA = "0x177ECF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932C94", Offset = "0x932C94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x177ED3C", Offset = "0x177ED3C", VA = "0x177ED3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932CCC", Offset = "0x932CCC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x177A3AC", Offset = "0x177A3AC", VA = "0x177A3AC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x17792C8", Offset = "0x17792C8", VA = "0x17792C8")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x17773B0", Offset = "0x17773B0", VA = "0x17773B0")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x177ED88", Offset = "0x177ED88", VA = "0x177ED88")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928CC8", Offset = "0x928CC8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928CC8", Offset = "0x928CC8")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FBC0", Offset = "0x92FBC0")]
			public bool use;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FBF8", Offset = "0x92FBF8")]
			public Vector2 offset;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FC30", Offset = "0x92FC30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92FC30", Offset = "0x92FC30")]
			public float angleOffset;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FC8C", Offset = "0x92FC8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92FC8C", Offset = "0x92FC8C")]
			public float maxAngle;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FCE4", Offset = "0x92FCE4")]
			public float radius;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FD1C", Offset = "0x92FD1C")]
			public bool orbit;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FD54", Offset = "0x92FD54")]
			public bool fixYAxis;

			[Token(Token = "0x170000AF")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600073B")]
				[Address(RVA = "0x14498F4", Offset = "0x14498F4", VA = "0x14498F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B0")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600073C")]
				[Address(RVA = "0x1449930", Offset = "0x1449930", VA = "0x1449930")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1449A28", Offset = "0x1449A28", VA = "0x1449A28")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x144A0A4", Offset = "0x144A0A4", VA = "0x144A0A4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FD8C", Offset = "0x92FD8C")]
			public Collider lookAtTarget;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FDC4", Offset = "0x92FDC4")]
			public Vector3 direction;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FDFC", Offset = "0x92FDFC")]
			public float maxDistance;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FE34", Offset = "0x92FE34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92FE34", Offset = "0x92FE34")]
			public float maxAngle;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FE8C", Offset = "0x92FE8C")]
			public bool fixYAxis;

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x14493E0", Offset = "0x14493E0", VA = "0x14493E0")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x1449588", Offset = "0x1449588", VA = "0x1449588")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1449868", Offset = "0x1449868", VA = "0x1449868")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x931064", Offset = "0x931064")]
				public InteractionObject interactionObject;

				[Token(Token = "0x400083A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93109C", Offset = "0x93109C")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x144A0C8", Offset = "0x144A0C8", VA = "0x144A0C8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FEE4", Offset = "0x92FEE4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FF1C", Offset = "0x92FF1C")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FF54", Offset = "0x92FF54")]
			public Interaction[] interactions;

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1449250", Offset = "0x1449250", VA = "0x1449250")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x144A0B8", Offset = "0x144A0B8", VA = "0x144A0B8")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BA58", Offset = "0x92BA58")]
		public Range[] ranges;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1448F18", Offset = "0x1448F18", VA = "0x1448F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932D04", Offset = "0x932D04")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1448F64", Offset = "0x1448F64", VA = "0x1448F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932D3C", Offset = "0x932D3C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1448FB0", Offset = "0x1448FB0", VA = "0x1448FB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932D74", Offset = "0x932D74")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1448FFC", Offset = "0x1448FFC", VA = "0x1448FFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932DAC", Offset = "0x932DAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1449048", Offset = "0x1449048", VA = "0x1449048")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932DE4", Offset = "0x932DE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1449094", Offset = "0x1449094", VA = "0x1449094")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1449374", Offset = "0x1449374", VA = "0x1449374")]
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
			[Address(RVA = "0x165A698", Offset = "0x165A698", VA = "0x165A698")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x165AAB8", Offset = "0x165AAB8", VA = "0x165AAB8")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x165AA6C", Offset = "0x165AA6C", VA = "0x165AA6C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x165A864", Offset = "0x165A864", VA = "0x165A864")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x165A3A4", Offset = "0x165A3A4", VA = "0x165A3A4", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932E1C", Offset = "0x932E1C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x165A758", Offset = "0x165A758", VA = "0x165A758", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x165A75C", Offset = "0x165A75C", VA = "0x165A75C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x165AA04", Offset = "0x165AA04", VA = "0x165AA04", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x165A6F0", Offset = "0x165A6F0", VA = "0x165A6F0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x165A5F8", Offset = "0x165A5F8", VA = "0x165A5F8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x165AB08", Offset = "0x165AB08", VA = "0x165AB08")]
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
		[Address(RVA = "0x16651CC", Offset = "0x16651CC", VA = "0x16651CC", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1665294", Offset = "0x1665294", VA = "0x1665294", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1665478", Offset = "0x1665478", VA = "0x1665478", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1665574", Offset = "0x1665574", VA = "0x1665574", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x16652FC", Offset = "0x16652FC", VA = "0x16652FC")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x16659B0", Offset = "0x16659B0", VA = "0x16659B0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BA90", Offset = "0x92BA90")]
		public float weight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BAA8", Offset = "0x92BAA8")]
		public float localRotationWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BAC0", Offset = "0x92BAC0")]
		public float localPositionWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600043A")]
		public abstract void AutoMapping();

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x144CE5C", Offset = "0x144CE5C", VA = "0x144CE5C")]
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
		[Address(RVA = "0x144CE68", Offset = "0x144CE68", VA = "0x144CE68", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x144CEBC", Offset = "0x144CEBC", VA = "0x144CEBC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x144CEF8", Offset = "0x144CEF8", VA = "0x144CEF8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x144CF10", Offset = "0x144CF10", VA = "0x144CF10")]
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
			[Address(RVA = "0x144D558", Offset = "0x144D558", VA = "0x144D558")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x144E1D0", Offset = "0x144E1D0", VA = "0x144E1D0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x144DFB4", Offset = "0x144DFB4", VA = "0x144DFB4")]
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
			[Address(RVA = "0x144D708", Offset = "0x144D708", VA = "0x144D708")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x144E368", Offset = "0x144E368", VA = "0x144E368")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x144E318", Offset = "0x144E318", VA = "0x144E318")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F34", Offset = "0x928F34")]
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
				[Address(RVA = "0x144E9C8", Offset = "0x144E9C8", VA = "0x144E9C8", Slot = "4")]
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
				[Address(RVA = "0x144EA30", Offset = "0x144EA30", VA = "0x144EA30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x144D780", Offset = "0x144D780", VA = "0x144D780")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x144E760", Offset = "0x144E760", VA = "0x144E760", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x144E764", Offset = "0x144E764", VA = "0x144E764", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x144E9D0", Offset = "0x144E9D0", VA = "0x144E9D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BAD8", Offset = "0x92BAD8")]
		public IK ik;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BB10", Offset = "0x92BB10")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BB48", Offset = "0x92BB48")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BB80", Offset = "0x92BB80")]
		public float applyVelocity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BBB8", Offset = "0x92BBB8")]
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
			[Address(RVA = "0x144CF70", Offset = "0x144CF70", VA = "0x144CF70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private bool ikUsed
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x144DB6C", Offset = "0x144DB6C", VA = "0x144DB6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x144CF38", Offset = "0x144CF38", VA = "0x144CF38")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x144CFE8", Offset = "0x144CFE8", VA = "0x144CFE8")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x144D124", Offset = "0x144D124", VA = "0x144D124")]
		public void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x144D0A8", Offset = "0x144D0A8", VA = "0x144D0A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x932E54", Offset = "0x932E54")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x144D7AC", Offset = "0x144D7AC", VA = "0x144D7AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x144D9F8", Offset = "0x144D9F8", VA = "0x144D9F8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x144DAB0", Offset = "0x144DAB0", VA = "0x144DAB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x144DCF0", Offset = "0x144DCF0", VA = "0x144DCF0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x144DB30", Offset = "0x144DB30", VA = "0x144DB30")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x144DCAC", Offset = "0x144DCAC", VA = "0x144DCAC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x144DD8C", Offset = "0x144DD8C", VA = "0x144DD8C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x144DD24", Offset = "0x144DD24", VA = "0x144DD24")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x144D040", Offset = "0x144D040", VA = "0x144D040")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x144DA38", Offset = "0x144DA38", VA = "0x144DA38")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x144E530", Offset = "0x144E530", VA = "0x144E530")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x144E658", Offset = "0x144E658", VA = "0x144E658")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92BC00", Offset = "0x92BC00")]
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
			[Address(RVA = "0x1450468", Offset = "0x1450468", VA = "0x1450468")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x14504A4", Offset = "0x14504A4", VA = "0x14504A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700005B")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1450574", Offset = "0x1450574", VA = "0x1450574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932EB8", Offset = "0x932EB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x145057C", Offset = "0x145057C", VA = "0x145057C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x932EC8", Offset = "0x932EC8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x14500CC", Offset = "0x14500CC", VA = "0x14500CC")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1450114", Offset = "0x1450114", VA = "0x1450114")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x145012C", Offset = "0x145012C", VA = "0x145012C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x14503C0", Offset = "0x14503C0", VA = "0x14503C0")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1450430", Offset = "0x1450430", VA = "0x1450430")]
		public void Disable()
		{
		}

		[Token(Token = "0x600045E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x14502D0", Offset = "0x14502D0", VA = "0x14502D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1450588", Offset = "0x1450588", VA = "0x1450588")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x145058C", Offset = "0x145058C", VA = "0x145058C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x14505C0", Offset = "0x14505C0", VA = "0x14505C0")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x14506A4", Offset = "0x14506A4", VA = "0x14506A4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1450920", Offset = "0x1450920", VA = "0x1450920")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x14509DC", Offset = "0x14509DC", VA = "0x14509DC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928D28", Offset = "0x928D28")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928D28", Offset = "0x928D28")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BC10", Offset = "0x92BC10")]
		public float limit;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BC2C", Offset = "0x92BC2C")]
		public float twistLimit;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1450A54", Offset = "0x1450A54", VA = "0x1450A54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932ED8", Offset = "0x932ED8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1450AA0", Offset = "0x1450AA0", VA = "0x1450AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932F10", Offset = "0x932F10")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1450AEC", Offset = "0x1450AEC", VA = "0x1450AEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932F48", Offset = "0x932F48")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1450B38", Offset = "0x1450B38", VA = "0x1450B38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932F80", Offset = "0x932F80")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1450B84", Offset = "0x1450B84", VA = "0x1450B84", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1450C3C", Offset = "0x1450C3C", VA = "0x1450C3C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1450E84", Offset = "0x1450E84", VA = "0x1450E84")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928D88", Offset = "0x928D88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928D88", Offset = "0x928D88")]
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
		[Address(RVA = "0x1450E94", Offset = "0x1450E94", VA = "0x1450E94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932FB8", Offset = "0x932FB8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1450EE0", Offset = "0x1450EE0", VA = "0x1450EE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x932FF0", Offset = "0x932FF0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1450F2C", Offset = "0x1450F2C", VA = "0x1450F2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933028", Offset = "0x933028")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1450F78", Offset = "0x1450F78", VA = "0x1450F78")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933060", Offset = "0x933060")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1450FC4", Offset = "0x1450FC4", VA = "0x1450FC4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1450FC8", Offset = "0x1450FC8", VA = "0x1450FC8")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1451274", Offset = "0x1451274", VA = "0x1451274")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928DE8", Offset = "0x928DE8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928DE8", Offset = "0x928DE8")]
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
				[Address(RVA = "0x145329C", Offset = "0x145329C", VA = "0x145329C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B4")]
			public Vector3 a
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0x14532D4", Offset = "0x14532D4", VA = "0x14532D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B5")]
			public Vector3 b
			{
				[Token(Token = "0x6000756")]
				[Address(RVA = "0x1453310", Offset = "0x1453310", VA = "0x1453310")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 c
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0x145334C", Offset = "0x145334C", VA = "0x145334C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public bool isValid
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0x14523E0", Offset = "0x14523E0", VA = "0x14523E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1452A2C", Offset = "0x1452A2C", VA = "0x1452A2C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1452BA0", Offset = "0x1452BA0", VA = "0x1452BA0")]
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
			[Address(RVA = "0x14523F0", Offset = "0x14523F0", VA = "0x14523F0")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BC58", Offset = "0x92BC58")]
		public float twistLimit;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BC74", Offset = "0x92BC74")]
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
		[Address(RVA = "0x145128C", Offset = "0x145128C", VA = "0x145128C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933098", Offset = "0x933098")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x14512D8", Offset = "0x14512D8", VA = "0x14512D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9330D0", Offset = "0x9330D0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1451324", Offset = "0x1451324", VA = "0x1451324")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933108", Offset = "0x933108")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1451370", Offset = "0x1451370", VA = "0x1451370")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933140", Offset = "0x933140")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x14513BC", Offset = "0x14513BC", VA = "0x14513BC")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1451900", Offset = "0x1451900", VA = "0x1451900", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x14519F8", Offset = "0x14519F8", VA = "0x14519F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1452000", Offset = "0x1452000", VA = "0x1452000")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1451468", Offset = "0x1451468", VA = "0x1451468")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1452474", Offset = "0x1452474", VA = "0x1452474")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1452D60", Offset = "0x1452D60", VA = "0x1452D60")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x1452DA4", Offset = "0x1452DA4", VA = "0x1452DA4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1452EEC", Offset = "0x1452EEC", VA = "0x1452EEC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1451CC4", Offset = "0x1451CC4", VA = "0x1451CC4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x145307C", Offset = "0x145307C", VA = "0x145307C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x145322C", Offset = "0x145322C", VA = "0x145322C")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x928E48", Offset = "0x928E48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x928E48", Offset = "0x928E48")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BCBC", Offset = "0x92BCBC")]
		public float twistLimit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1453388", Offset = "0x1453388", VA = "0x1453388")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933178", Offset = "0x933178")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x14533D4", Offset = "0x14533D4", VA = "0x14533D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9331B0", Offset = "0x9331B0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1453420", Offset = "0x1453420", VA = "0x1453420")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9331E8", Offset = "0x9331E8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x145346C", Offset = "0x145346C", VA = "0x145346C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x933220", Offset = "0x933220")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x14534B8", Offset = "0x14534B8", VA = "0x14534B8")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x14534D4", Offset = "0x14534D4", VA = "0x14534D4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x145358C", Offset = "0x145358C", VA = "0x145358C")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x14538B8", Offset = "0x14538B8", VA = "0x14538B8")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F44", Offset = "0x928F44")]
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
				[Address(RVA = "0x10A0C1C", Offset = "0x10A0C1C", VA = "0x10A0C1C", Slot = "4")]
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
				[Address(RVA = "0x10A0C84", Offset = "0x10A0C84", VA = "0x10A0C84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x10A09EC", Offset = "0x10A09EC", VA = "0x10A09EC")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x10A0AEC", Offset = "0x10A0AEC", VA = "0x10A0AEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x10A0AF0", Offset = "0x10A0AF0", VA = "0x10A0AF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x10A0C24", Offset = "0x10A0C24", VA = "0x10A0C24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BCE8", Offset = "0x92BCE8")]
		public AimIK ik;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BD20", Offset = "0x92BD20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92BD20", Offset = "0x92BD20")]
		public float weight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92BD74", Offset = "0x92BD74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BD74", Offset = "0x92BD74")]
		public Transform target;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BDD4", Offset = "0x92BDD4")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BE0C", Offset = "0x92BE0C")]
		public float weightSmoothTime;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92BE44", Offset = "0x92BE44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BE44", Offset = "0x92BE44")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BEA4", Offset = "0x92BEA4")]
		public float maxRadiansDelta;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BEDC", Offset = "0x92BEDC")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BF14", Offset = "0x92BF14")]
		public float slerpSpeed;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BF4C", Offset = "0x92BF4C")]
		public float smoothDampTime;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BF84", Offset = "0x92BF84")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BFBC", Offset = "0x92BFBC")]
		public float minDistance;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92BFF4", Offset = "0x92BFF4")]
		public Vector3 offset;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92C02C", Offset = "0x92C02C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C02C", Offset = "0x92C02C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92C02C", Offset = "0x92C02C")]
		public float maxRootAngle;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C0A8", Offset = "0x92C0A8")]
		public bool turnToTarget;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C0E0", Offset = "0x92C0E0")]
		public float turnToTargetTime;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92C118", Offset = "0x92C118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C118", Offset = "0x92C118")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C178", Offset = "0x92C178")]
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
			[Address(RVA = "0x109F968", Offset = "0x109F968", VA = "0x109F968")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x109F868", Offset = "0x109F868", VA = "0x109F868")]
		private void Start()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x109FAB4", Offset = "0x109FAB4", VA = "0x109FAB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x10A0464", Offset = "0x10A0464", VA = "0x10A0464")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x10A0600", Offset = "0x10A0600", VA = "0x10A0600")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x10A0970", Offset = "0x10A0970", VA = "0x10A0970")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x933258", Offset = "0x933258")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x10A0A18", Offset = "0x10A0A18", VA = "0x10A0A18")]
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
			[Address(RVA = "0x10A0E84", Offset = "0x10A0E84", VA = "0x10A0E84")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x10A1190", Offset = "0x10A1190", VA = "0x10A1190")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x10A1198", Offset = "0x10A1198", VA = "0x10A1198")]
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
		[Address(RVA = "0x109B048", Offset = "0x109B048", VA = "0x109B048")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x109B124", Offset = "0x109B124", VA = "0x109B124")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x10A111C", Offset = "0x10A111C", VA = "0x10A111C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9310D4", Offset = "0x9310D4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400083C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93110C", Offset = "0x93110C")]
				public float weight;

				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x10A1788", Offset = "0x10A1788", VA = "0x10A1788")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FF8C", Offset = "0x92FF8C")]
			public Transform transform;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FFC4", Offset = "0x92FFC4")]
			public Transform relativeTo;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92FFFC", Offset = "0x92FFFC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930034", Offset = "0x930034")]
			public float verticalWeight;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93006C", Offset = "0x93006C")]
			public float horizontalWeight;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9300A4", Offset = "0x9300A4")]
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
			[Address(RVA = "0x10A12F4", Offset = "0x10A12F4", VA = "0x10A12F4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x10A1760", Offset = "0x10A1760", VA = "0x10A1760")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x10A1770", Offset = "0x10A1770", VA = "0x10A1770")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C1B0", Offset = "0x92C1B0")]
		public Body[] bodies;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x10A11B4", Offset = "0x10A11B4", VA = "0x10A11B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x10A1758", Offset = "0x10A1758", VA = "0x10A1758")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C1E8", Offset = "0x92C1E8")]
		public float tiltSpeed;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C220", Offset = "0x92C220")]
		public float tiltSensitivity;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C258", Offset = "0x92C258")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C290", Offset = "0x92C290")]
		public OffsetPose poseRight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x10A2DC8", Offset = "0x10A2DC8", VA = "0x10A2DC8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x10A2E10", Offset = "0x10A2E10", VA = "0x10A2E10", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x10A3040", Offset = "0x10A3040", VA = "0x10A3040")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92C2C8", Offset = "0x92C2C8")]
		public float weight;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x10A3054", Offset = "0x10A3054", VA = "0x10A3054")]
		private void Start()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x10A3124", Offset = "0x10A3124", VA = "0x10A3124")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x10A3434", Offset = "0x10A3434", VA = "0x10A3434")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x10A3550", Offset = "0x10A3550", VA = "0x10A3550")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C2E0", Offset = "0x92C2E0")]
		public Animator animator;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C318", Offset = "0x92C318")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92C360", Offset = "0x92C360")]
		private IK <ik>k__BackingField;

		[Token(Token = "0x1700005D")]
		public IK ik
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x10A3FE0", Offset = "0x10A3FE0", VA = "0x10A3FE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9332BC", Offset = "0x9332BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x10A3FE8", Offset = "0x10A3FE8", VA = "0x10A3FE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9332CC", Offset = "0x9332CC")]
			private set
			{
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x10A3FF0", Offset = "0x10A3FF0", VA = "0x10A3FF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x10A4180", Offset = "0x10A4180", VA = "0x10A4180")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x10A4408", Offset = "0x10A4408", VA = "0x10A4408")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x10A4558", Offset = "0x10A4558", VA = "0x10A4558")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x10A4744", Offset = "0x10A4744", VA = "0x10A4744")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x10A495C", Offset = "0x10A495C", VA = "0x10A495C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x10A4C00", Offset = "0x10A4C00", VA = "0x10A4C00")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x928EB8", Offset = "0x928EB8")]
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
			[Address(RVA = "0x10A427C", Offset = "0x10A427C", VA = "0x10A427C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x10A45DC", Offset = "0x10A45DC", VA = "0x10A45DC")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x10A42A0", Offset = "0x10A42A0", VA = "0x10A42A0")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x10A4C6C", Offset = "0x10A4C6C", VA = "0x10A4C6C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9300DC", Offset = "0x9300DC")]
			public string name;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930114", Offset = "0x930114")]
			public Collider collider;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93014C", Offset = "0x93014C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x930198", Offset = "0x930198")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9301A8", Offset = "0x9301A8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9301B8", Offset = "0x9301B8")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9301C8", Offset = "0x9301C8")]
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
				[Address(RVA = "0x1665A74", Offset = "0x1665A74", VA = "0x1665A74")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BB")]
			protected float crossFader
			{
				[Token(Token = "0x6000769")]
				[Address(RVA = "0x166601C", Offset = "0x166601C", VA = "0x166601C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A18", Offset = "0x933A18")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600076A")]
				[Address(RVA = "0x1666024", Offset = "0x1666024", VA = "0x1666024")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A28", Offset = "0x933A28")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			protected float timer
			{
				[Token(Token = "0x600076B")]
				[Address(RVA = "0x166602C", Offset = "0x166602C", VA = "0x166602C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A38", Offset = "0x933A38")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600076C")]
				[Address(RVA = "0x1666034", Offset = "0x1666034", VA = "0x1666034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A48", Offset = "0x933A48")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			protected Vector3 force
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0x166603C", Offset = "0x166603C", VA = "0x166603C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A58", Offset = "0x933A58")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x1666048", Offset = "0x1666048", VA = "0x1666048")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A68", Offset = "0x933A68")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			protected Vector3 point
			{
				[Token(Token = "0x600076F")]
				[Address(RVA = "0x1666054", Offset = "0x1666054", VA = "0x1666054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A78", Offset = "0x933A78")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000770")]
				[Address(RVA = "0x1666060", Offset = "0x1666060", VA = "0x1666060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A88", Offset = "0x933A88")]
				private set
				{
				}
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1665EE8", Offset = "0x1665EE8", VA = "0x1665EE8")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1665B5C", Offset = "0x1665B5C", VA = "0x1665B5C")]
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
			[Address(RVA = "0x166606C", Offset = "0x166606C", VA = "0x166606C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x931144", Offset = "0x931144")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400083E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93117C", Offset = "0x93117C")]
				public float weight;

				[Token(Token = "0x400083F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000840")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x16669E8", Offset = "0x16669E8", VA = "0x16669E8")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x16667DC", Offset = "0x16667DC", VA = "0x16667DC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x1666B24", Offset = "0x1666B24", VA = "0x1666B24")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9301D8", Offset = "0x9301D8")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930210", Offset = "0x930210")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930248", Offset = "0x930248")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x16665F8", Offset = "0x16665F8", VA = "0x16665F8", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x1666770", Offset = "0x1666770", VA = "0x1666770", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x16667F0", Offset = "0x16667F0", VA = "0x16667F0", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1666B10", Offset = "0x1666B10", VA = "0x1666B10")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9311B4", Offset = "0x9311B4")]
				public Transform bone;

				[Token(Token = "0x4000842")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9311EC", Offset = "0x9311EC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9311EC", Offset = "0x9311EC")]
				public float weight;

				[Token(Token = "0x4000843")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000844")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x1666400", Offset = "0x1666400", VA = "0x1666400")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x1666188", Offset = "0x1666188", VA = "0x1666188")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007F2")]
				[Address(RVA = "0x1666570", Offset = "0x1666570", VA = "0x1666570")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930280", Offset = "0x930280")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9302B8", Offset = "0x9302B8")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x1666080", Offset = "0x1666080", VA = "0x1666080", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1666124", Offset = "0x1666124", VA = "0x1666124", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1666194", Offset = "0x1666194", VA = "0x1666194", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600077E")]
			[Address(RVA = "0x166655C", Offset = "0x166655C", VA = "0x166655C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C370", Offset = "0x92C370")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C3A8", Offset = "0x92C3A8")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700005F")]
		public bool inProgress
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x16659B8", Offset = "0x16659B8", VA = "0x16659B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1665A88", Offset = "0x1665A88", VA = "0x1665A88", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1665CA8", Offset = "0x1665CA8", VA = "0x1665CA8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1666014", Offset = "0x1666014", VA = "0x1666014")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9302F0", Offset = "0x9302F0")]
			public string name;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930328", Offset = "0x930328")]
			public Collider collider;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930360", Offset = "0x930360")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9303AC", Offset = "0x9303AC")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9303BC", Offset = "0x9303BC")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9303CC", Offset = "0x9303CC")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9303DC", Offset = "0x9303DC")]
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
				[Address(RVA = "0x16670DC", Offset = "0x16670DC", VA = "0x16670DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933A98", Offset = "0x933A98")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000780")]
				[Address(RVA = "0x16670E4", Offset = "0x16670E4", VA = "0x16670E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AA8", Offset = "0x933AA8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected float timer
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x16670EC", Offset = "0x16670EC", VA = "0x16670EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AB8", Offset = "0x933AB8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000782")]
				[Address(RVA = "0x16670F4", Offset = "0x16670F4", VA = "0x16670F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AC8", Offset = "0x933AC8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000783")]
				[Address(RVA = "0x16670FC", Offset = "0x16670FC", VA = "0x16670FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AD8", Offset = "0x933AD8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000784")]
				[Address(RVA = "0x1667108", Offset = "0x1667108", VA = "0x1667108")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AE8", Offset = "0x933AE8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			protected Vector3 point
			{
				[Token(Token = "0x6000785")]
				[Address(RVA = "0x1667114", Offset = "0x1667114", VA = "0x1667114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933AF8", Offset = "0x933AF8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000786")]
				[Address(RVA = "0x1667120", Offset = "0x1667120", VA = "0x1667120")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933B08", Offset = "0x933B08")]
				private set
				{
				}
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1666F94", Offset = "0x1666F94", VA = "0x1666F94")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1666BF8", Offset = "0x1666BF8", VA = "0x1666BF8")]
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
			[Address(RVA = "0x166712C", Offset = "0x166712C", VA = "0x166712C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x931240", Offset = "0x931240")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000846")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x931278", Offset = "0x931278")]
				public float weight;

				[Token(Token = "0x4000847")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000848")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60007F3")]
				[Address(RVA = "0x16675E8", Offset = "0x16675E8", VA = "0x16675E8")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x16673A4", Offset = "0x16673A4", VA = "0x16673A4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x1667704", Offset = "0x1667704", VA = "0x1667704")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9303EC", Offset = "0x9303EC")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930424", Offset = "0x930424")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93045C", Offset = "0x93045C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1667140", Offset = "0x1667140", VA = "0x1667140", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1667338", Offset = "0x1667338", VA = "0x1667338", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x16673B8", Offset = "0x16673B8", VA = "0x16673B8", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x16676E8", Offset = "0x16676E8", VA = "0x16676E8")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9312B0", Offset = "0x9312B0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400084A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9312E8", Offset = "0x9312E8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9312E8", Offset = "0x9312E8")]
				public float weight;

				[Token(Token = "0x400084B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400084C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x1667B80", Offset = "0x1667B80", VA = "0x1667B80")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60007F7")]
				[Address(RVA = "0x1667854", Offset = "0x1667854", VA = "0x1667854")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60007F8")]
				[Address(RVA = "0x1667CBC", Offset = "0x1667CBC", VA = "0x1667CBC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930494", Offset = "0x930494")]
			public int curveIndex;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9304CC", Offset = "0x9304CC")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x166770C", Offset = "0x166770C", VA = "0x166770C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x16677F0", Offset = "0x16677F0", VA = "0x16677F0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1667860", Offset = "0x1667860", VA = "0x1667860", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1667CA8", Offset = "0x1667CA8", VA = "0x1667CA8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C3E0", Offset = "0x92C3E0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C418", Offset = "0x92C418")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1666B2C", Offset = "0x1666B2C", VA = "0x1666B2C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1666D4C", Offset = "0x1666D4C", VA = "0x1666D4C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x16670D4", Offset = "0x16670D4", VA = "0x16670D4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93133C", Offset = "0x93133C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400084E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x931374", Offset = "0x931374")]
				public float weight;

				[Token(Token = "0x60007F9")]
				[Address(RVA = "0x1776108", Offset = "0x1776108", VA = "0x1776108")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930504", Offset = "0x930504")]
			public Transform transform;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93053C", Offset = "0x93053C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930574", Offset = "0x930574")]
			public float speed;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9305AC", Offset = "0x9305AC")]
			public float acceleration;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9305E4", Offset = "0x9305E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9305E4", Offset = "0x9305E4")]
			public float matchVelocity;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930638", Offset = "0x930638")]
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
			[Address(RVA = "0x1775BD4", Offset = "0x1775BD4", VA = "0x1775BD4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1775D6C", Offset = "0x1775D6C", VA = "0x1775D6C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x17760EC", Offset = "0x17760EC", VA = "0x17760EC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C450", Offset = "0x92C450")]
		public Body[] bodies;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C488", Offset = "0x92C488")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1775B5C", Offset = "0x1775B5C", VA = "0x1775B5C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1775CB0", Offset = "0x1775CB0", VA = "0x1775CB0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x17760E4", Offset = "0x17760E4", VA = "0x17760E4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92C4C0", Offset = "0x92C4C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C4C0", Offset = "0x92C4C0")]
		public Transform target;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92C520", Offset = "0x92C520")]
		public float weight;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C538", Offset = "0x92C538")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C570", Offset = "0x92C570")]
		public float weightSmoothTime;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92C5A8", Offset = "0x92C5A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C5A8", Offset = "0x92C5A8")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C608", Offset = "0x92C608")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C640", Offset = "0x92C640")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C678", Offset = "0x92C678")]
		public float slerpSpeed;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C6B0", Offset = "0x92C6B0")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C6E8", Offset = "0x92C6E8")]
		public float minDistance;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92C720", Offset = "0x92C720")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C720", Offset = "0x92C720")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92C720", Offset = "0x92C720")]
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
			[Address(RVA = "0x144A510", Offset = "0x144A510", VA = "0x144A510")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x144A428", Offset = "0x144A428", VA = "0x144A428")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x144A65C", Offset = "0x144A65C", VA = "0x144A65C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x144AD2C", Offset = "0x144AD2C", VA = "0x144AD2C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x144AEC8", Offset = "0x144AEC8", VA = "0x144AEC8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x144B1E4", Offset = "0x144B1E4", VA = "0x144B1E4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930670", Offset = "0x930670")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9306A8", Offset = "0x9306A8")]
			public float spring;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9306E0", Offset = "0x9306E0")]
			public bool x;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930718", Offset = "0x930718")]
			public bool y;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930750", Offset = "0x930750")]
			public bool z;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930788", Offset = "0x930788")]
			public float minX;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9307C0", Offset = "0x9307C0")]
			public float maxX;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9307F8", Offset = "0x9307F8")]
			public float minY;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930830", Offset = "0x930830")]
			public float maxY;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930868", Offset = "0x930868")]
			public float minZ;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9308A0", Offset = "0x9308A0")]
			public float maxZ;

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x144B70C", Offset = "0x144B70C", VA = "0x144B70C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x144BC68", Offset = "0x144BC68", VA = "0x144BC68")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x144BC98", Offset = "0x144BC98", VA = "0x144BC98")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x144BD70", Offset = "0x144BD70", VA = "0x144BD70")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F54", Offset = "0x928F54")]
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
				[Address(RVA = "0x144BBF8", Offset = "0x144BBF8", VA = "0x144BBF8", Slot = "4")]
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
				[Address(RVA = "0x144BC60", Offset = "0x144BC60", VA = "0x144BC60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x144B518", Offset = "0x144B518", VA = "0x144B518")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x144BA98", Offset = "0x144BA98", VA = "0x144BA98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x144BA9C", Offset = "0x144BA9C", VA = "0x144BA9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x144BC00", Offset = "0x144BC00", VA = "0x144BC00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C79C", Offset = "0x92C79C")]
		public float weight;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C7D4", Offset = "0x92C7D4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000061")]
		protected float deltaTime
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x144B444", Offset = "0x144B444", VA = "0x144B444")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004BD")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x144B470", Offset = "0x144B470", VA = "0x144B470", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x144B49C", Offset = "0x144B49C", VA = "0x144B49C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9332DC", Offset = "0x9332DC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x144B544", Offset = "0x144B544", VA = "0x144B544")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x144B650", Offset = "0x144B650", VA = "0x144B650")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x144B96C", Offset = "0x144B96C", VA = "0x144B96C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x144BA88", Offset = "0x144BA88", VA = "0x144BA88")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F64", Offset = "0x928F64")]
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
				[Address(RVA = "0x144C210", Offset = "0x144C210", VA = "0x144C210", Slot = "4")]
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
				[Address(RVA = "0x144C278", Offset = "0x144C278", VA = "0x144C278", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x144BE4C", Offset = "0x144BE4C", VA = "0x144BE4C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x144C0B0", Offset = "0x144C0B0", VA = "0x144C0B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x144C0B4", Offset = "0x144C0B4", VA = "0x144C0B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x144C218", Offset = "0x144C218", VA = "0x144C218", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C80C", Offset = "0x92C80C")]
		public float weight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C844", Offset = "0x92C844")]
		public VRIK ik;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000062")]
		protected float deltaTime
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x144BD78", Offset = "0x144BD78", VA = "0x144BD78")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004C5")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x144BDA4", Offset = "0x144BDA4", VA = "0x144BDA4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x144BDD0", Offset = "0x144BDD0", VA = "0x144BDD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x933340", Offset = "0x933340")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x144BE78", Offset = "0x144BE78", VA = "0x144BE78")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x144BF84", Offset = "0x144BF84", VA = "0x144BF84", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x144C0A0", Offset = "0x144C0A0", VA = "0x144C0A0")]
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
			[Address(RVA = "0x144C340", Offset = "0x144C340", VA = "0x144C340")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x144C79C", Offset = "0x144C79C", VA = "0x144C79C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x144C280", Offset = "0x144C280", VA = "0x144C280")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x144C678", Offset = "0x144C678", VA = "0x144C678")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x144C730", Offset = "0x144C730", VA = "0x144C730")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9313AC", Offset = "0x9313AC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000850")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9313E4", Offset = "0x9313E4")]
				public float weight;

				[Token(Token = "0x60007FA")]
				[Address(RVA = "0x144CE54", Offset = "0x144CE54", VA = "0x144CE54")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9308D8", Offset = "0x9308D8")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930910", Offset = "0x930910")]
			public Transform raycastTo;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930948", Offset = "0x930948")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x930948", Offset = "0x930948")]
			public float raycastRadius;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93099C", Offset = "0x93099C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9309D4", Offset = "0x9309D4")]
			public float smoothTimeIn;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930A0C", Offset = "0x930A0C")]
			public float smoothTimeOut;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930A44", Offset = "0x930A44")]
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
			[Address(RVA = "0x144C828", Offset = "0x144C828", VA = "0x144C828")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x144CA34", Offset = "0x144CA34", VA = "0x144CA34")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x144CBCC", Offset = "0x144CBCC", VA = "0x144CBCC")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x144CE40", Offset = "0x144CE40", VA = "0x144CE40")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C87C", Offset = "0x92C87C")]
		public Avoider[] avoiders;

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x144C7A4", Offset = "0x144C7A4", VA = "0x144C7A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x144CA24", Offset = "0x144CA24", VA = "0x144CA24")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93141C", Offset = "0x93141C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000852")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x931454", Offset = "0x931454")]
				public float weight;

				[Token(Token = "0x60007FB")]
				[Address(RVA = "0x14500C4", Offset = "0x14500C4", VA = "0x14500C4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930A7C", Offset = "0x930A7C")]
			public Vector3 offset;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930AB4", Offset = "0x930AB4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x930AB4", Offset = "0x930AB4")]
			public float additivity;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930B08", Offset = "0x930B08")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930B40", Offset = "0x930B40")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x144EDB4", Offset = "0x144EDB4", VA = "0x144EDB4")]
			public void Start()
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x144F968", Offset = "0x144F968", VA = "0x144F968")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x14500B0", Offset = "0x14500B0", VA = "0x14500B0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C8B4", Offset = "0x92C8B4")]
		public AimIK aimIK;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C8EC", Offset = "0x92C8EC")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C924", Offset = "0x92C924")]
		public Handedness handedness;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C95C", Offset = "0x92C95C")]
		public bool twoHanded;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C994", Offset = "0x92C994")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92C9CC", Offset = "0x92C9CC")]
		public float magnitudeRandom;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CA04", Offset = "0x92CA04")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CA3C", Offset = "0x92CA3C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CA74", Offset = "0x92CA74")]
		public float blendTime;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x92CAAC", Offset = "0x92CAAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CAAC", Offset = "0x92CAAC")]
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
			[Address(RVA = "0x144EB8C", Offset = "0x144EB8C", VA = "0x144EB8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x144FC1C", Offset = "0x144FC1C", VA = "0x144FC1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x144FC5C", Offset = "0x144FC5C", VA = "0x144FC5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private Transform primaryHand
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x144FBDC", Offset = "0x144FBDC", VA = "0x144FBDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x144FBFC", Offset = "0x144FBFC", VA = "0x144FBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x144EBBC", Offset = "0x144EBBC", VA = "0x144EBBC")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x144EBE8", Offset = "0x144EBE8", VA = "0x144EBE8")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x144EE64", Offset = "0x144EE64", VA = "0x144EE64", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x144FC9C", Offset = "0x144FC9C", VA = "0x144FC9C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x144FDF4", Offset = "0x144FDF4", VA = "0x144FDF4")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x144FE30", Offset = "0x144FE30", VA = "0x144FE30", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x144FFFC", Offset = "0x144FFFC", VA = "0x144FFFC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CB0C", Offset = "0x92CB0C")]
		public float weight;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CB44", Offset = "0x92CB44")]
		public float offset;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x14538C4", Offset = "0x14538C4", VA = "0x14538C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x14539B8", Offset = "0x14539B8", VA = "0x14539B8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1453AA4", Offset = "0x1453AA4", VA = "0x1453AA4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1453EEC", Offset = "0x1453EEC", VA = "0x1453EEC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1453F24", Offset = "0x1453F24", VA = "0x1453F24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1454040", Offset = "0x1454040", VA = "0x1454040")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930B78", Offset = "0x930B78")]
			public float scaleMlp;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930BB0", Offset = "0x930BB0")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930BE8", Offset = "0x930BE8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930C20", Offset = "0x930C20")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930C58", Offset = "0x930C58")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930C90", Offset = "0x930C90")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930CC8", Offset = "0x930CC8")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x930D00", Offset = "0x930D00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930D00", Offset = "0x930D00")]
			public Vector3 headOffset;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930D50", Offset = "0x930D50")]
			public Vector3 handOffset;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930D88", Offset = "0x930D88")]
			public float footForwardOffset;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930DC0", Offset = "0x930DC0")]
			public float footInwardOffset;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930DF8", Offset = "0x930DF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x930DF8", Offset = "0x930DF8")]
			public float footHeadingOffset;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x930E54", Offset = "0x930E54")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x930E6C", Offset = "0x930E6C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x145AEB8", Offset = "0x145AEB8", VA = "0x145AEB8")]
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
				[Address(RVA = "0x145897C", Offset = "0x145897C", VA = "0x145897C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60007FD")]
				[Address(RVA = "0x14594F8", Offset = "0x14594F8", VA = "0x14594F8")]
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
			[Address(RVA = "0x1457DC0", Offset = "0x1457DC0", VA = "0x1457DC0")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x14568A0", Offset = "0x14568A0", VA = "0x14568A0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x14568B8", Offset = "0x14568B8", VA = "0x14568B8")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1456A50", Offset = "0x1456A50", VA = "0x1456A50")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1456904", Offset = "0x1456904", VA = "0x1456904")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1456A68", Offset = "0x1456A68", VA = "0x1456A68")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1457F38", Offset = "0x1457F38", VA = "0x1457F38")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1458A40", Offset = "0x1458A40", VA = "0x1458A40")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1459558", Offset = "0x1459558", VA = "0x1459558")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1459974", Offset = "0x1459974", VA = "0x1459974")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1459B98", Offset = "0x1459B98", VA = "0x1459B98")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x145A2B8", Offset = "0x145A2B8", VA = "0x145A2B8")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x145A06C", Offset = "0x145A06C", VA = "0x145A06C")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x145A594", Offset = "0x145A594", VA = "0x145A594")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x145A890", Offset = "0x145A890", VA = "0x145A890")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x145AA68", Offset = "0x145AA68", VA = "0x145AA68")]
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
		[Address(RVA = "0x145AF90", Offset = "0x145AF90", VA = "0x145AF90")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x145AFF0", Offset = "0x145AFF0", VA = "0x145AFF0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x145B024", Offset = "0x145B024", VA = "0x145B024")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x145B1AC", Offset = "0x145B1AC", VA = "0x145B1AC")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CB7C", Offset = "0x92CB7C")]
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
			[Address(RVA = "0x145B1C4", Offset = "0x145B1C4", VA = "0x145B1C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9333A4", Offset = "0x9333A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x145B1D0", Offset = "0x145B1D0", VA = "0x145B1D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9333B4", Offset = "0x9333B4")]
			private set
			{
			}
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x145B1DC", Offset = "0x145B1DC", VA = "0x145B1DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1458720", Offset = "0x1458720", VA = "0x1458720")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x14597CC", Offset = "0x14597CC", VA = "0x14597CC")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x145B2D8", Offset = "0x145B2D8", VA = "0x145B2D8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x145B77C", Offset = "0x145B77C", VA = "0x145B77C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x145B898", Offset = "0x145B898", VA = "0x145B898")]
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
			[Address(RVA = "0x14A595C", Offset = "0x14A595C", VA = "0x14A595C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x14A5C08", Offset = "0x14A5C08", VA = "0x14A5C08")]
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
		[Address(RVA = "0x14A5884", Offset = "0x14A5884", VA = "0x14A5884")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x14A58E4", Offset = "0x14A58E4", VA = "0x14A58E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x14A5B18", Offset = "0x14A5B18", VA = "0x14A5B18")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x14A5C00", Offset = "0x14A5C00", VA = "0x14A5C00")]
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
		[Address(RVA = "0x149CE30", Offset = "0x149CE30", VA = "0x149CE30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x149CEB4", Offset = "0x149CEB4", VA = "0x149CEB4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CB8C", Offset = "0x92CB8C")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x149CEBC", Offset = "0x149CEBC", VA = "0x149CEBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x149CFC4", Offset = "0x149CFC4", VA = "0x149CFC4")]
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
		[Address(RVA = "0x109A7F4", Offset = "0x109A7F4", VA = "0x109A7F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x109A838", Offset = "0x109A838", VA = "0x109A838")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x109AA98", Offset = "0x109AA98", VA = "0x109AA98")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CBC4", Offset = "0x92CBC4")]
		public AimPoser aimPoser;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CBFC", Offset = "0x92CBFC")]
		public AimIK aim;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CC34", Offset = "0x92CC34")]
		public LookAtIK lookAt;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CC6C", Offset = "0x92CC6C")]
		public Animator animator;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CCA4", Offset = "0x92CCA4")]
		public float crossfadeTime;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CCDC", Offset = "0x92CCDC")]
		public float minAimDistance;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x109AAA0", Offset = "0x109AAA0", VA = "0x109AAA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x109AAE4", Offset = "0x109AAE4", VA = "0x109AAE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x109AC38", Offset = "0x109AC38", VA = "0x109AC38")]
		private void Pose()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x109AE50", Offset = "0x109AE50", VA = "0x109AE50")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x109B190", Offset = "0x109B190", VA = "0x109B190")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x109B268", Offset = "0x109B268", VA = "0x109B268")]
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
		[Address(RVA = "0x109C034", Offset = "0x109C034", VA = "0x109C034")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x109C298", Offset = "0x109C298", VA = "0x109C298")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x109C4E8", Offset = "0x109C4E8", VA = "0x109C4E8")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92CD14", Offset = "0x92CD14")]
		public Animator animator;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92CD4C", Offset = "0x92CD4C")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CD84", Offset = "0x92CD84")]
		public float lookAtWeight;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CD9C", Offset = "0x92CD9C")]
		public float lookAtBodyWeight;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CDB4", Offset = "0x92CDB4")]
		public float lookAtHeadWeight;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CDCC", Offset = "0x92CDCC")]
		public float lookAtEyesWeight;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CDE4", Offset = "0x92CDE4")]
		public float lookAtClampWeight;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CDFC", Offset = "0x92CDFC")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CE14", Offset = "0x92CE14")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92CE2C", Offset = "0x92CE2C")]
		public Transform footTargetBiped;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CE64", Offset = "0x92CE64")]
		public float footPositionWeight;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CE7C", Offset = "0x92CE7C")]
		public float footRotationWeight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x92CE94", Offset = "0x92CE94")]
		public Transform handTargetBiped;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CECC", Offset = "0x92CECC")]
		public float handPositionWeight;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CEE4", Offset = "0x92CEE4")]
		public float handRotationWeight;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x149EBA8", Offset = "0x149EBA8", VA = "0x149EBA8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x149F054", Offset = "0x149F054", VA = "0x149F054")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92CEFC", Offset = "0x92CEFC")]
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
			[Address(RVA = "0x1093920", Offset = "0x1093920", VA = "0x1093920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9333C4", Offset = "0x9333C4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x109392C", Offset = "0x109392C", VA = "0x109392C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9333D4", Offset = "0x9333D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1093938", Offset = "0x1093938", VA = "0x1093938")]
		private void Start()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1093974", Offset = "0x1093974", VA = "0x1093974")]
		private void Update()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x109442C", Offset = "0x109442C", VA = "0x109442C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1094114", Offset = "0x1094114", VA = "0x1094114")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x10945D4", Offset = "0x10945D4", VA = "0x10945D4")]
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
			[Address(RVA = "0x1094600", Offset = "0x1094600", VA = "0x1094600")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x10946A0", Offset = "0x10946A0", VA = "0x10946A0")]
		private void Update()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1094938", Offset = "0x1094938", VA = "0x1094938")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F74", Offset = "0x928F74")]
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
				[Address(RVA = "0x1095D48", Offset = "0x1095D48", VA = "0x1095D48", Slot = "4")]
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
				[Address(RVA = "0x1095DB0", Offset = "0x1095DB0", VA = "0x1095DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1095934", Offset = "0x1095934", VA = "0x1095934")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x1095A08", Offset = "0x1095A08", VA = "0x1095A08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x1095A0C", Offset = "0x1095A0C", VA = "0x1095A0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1095D50", Offset = "0x1095D50", VA = "0x1095D50", Slot = "8")]
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
			[Address(RVA = "0x109494C", Offset = "0x109494C", VA = "0x109494C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 position
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x10945A0", Offset = "0x10945A0", VA = "0x10945A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x1094960", Offset = "0x1094960", VA = "0x1094960")]
			set
			{
			}
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x10949B0", Offset = "0x10949B0", VA = "0x10949B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1094C34", Offset = "0x1094C34", VA = "0x1094C34")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1094E50", Offset = "0x1094E50", VA = "0x1094E50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1095108", Offset = "0x1095108", VA = "0x1095108")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x10954A0", Offset = "0x10954A0", VA = "0x10954A0")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x10956FC", Offset = "0x10956FC", VA = "0x10956FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1095050", Offset = "0x1095050", VA = "0x1095050")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9333E4", Offset = "0x9333E4")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1095960", Offset = "0x1095960", VA = "0x1095960")]
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
		[Address(RVA = "0x1095DB8", Offset = "0x1095DB8", VA = "0x1095DB8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1095E74", Offset = "0x1095E74", VA = "0x1095E74")]
		private void Update()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1096108", Offset = "0x1096108", VA = "0x1096108")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930E94", Offset = "0x930E94")]
			public int animationLayer;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930ECC", Offset = "0x930ECC")]
			public string animationState;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930F04", Offset = "0x930F04")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930F3C", Offset = "0x930F3C")]
			public Transform warpFrom;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930F74", Offset = "0x930F74")]
			public Transform warpTo;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930FAC", Offset = "0x930FAC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CF0C", Offset = "0x92CF0C")]
		public Animator animator;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CF44", Offset = "0x92CF44")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x92CF7C", Offset = "0x92CF7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CF7C", Offset = "0x92CF7C")]
		public Warp[] warps;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x149D03C", Offset = "0x149D03C", VA = "0x149D03C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x149D068", Offset = "0x149D068", VA = "0x149D068")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x149D270", Offset = "0x149D270", VA = "0x149D270", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x149D624", Offset = "0x149D624", VA = "0x149D624")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x149D6C4", Offset = "0x149D6C4", VA = "0x149D6C4")]
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
		[Address(RVA = "0x149D6CC", Offset = "0x149D6CC", VA = "0x149D6CC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x149D72C", Offset = "0x149D72C", VA = "0x149D72C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x149D964", Offset = "0x149D964", VA = "0x149D964", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x149DBC8", Offset = "0x149DBC8", VA = "0x149DBC8")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CFCC", Offset = "0x92CFCC")]
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
		[Address(RVA = "0x149DBDC", Offset = "0x149DBDC", VA = "0x149DBDC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x149DD88", Offset = "0x149DD88", VA = "0x149DD88", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x149DE04", Offset = "0x149DE04", VA = "0x149DE04")]
		private void Read()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x149DF5C", Offset = "0x149DF5C", VA = "0x149DF5C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x149DFA4", Offset = "0x149DFA4", VA = "0x149DFA4")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x149E59C", Offset = "0x149E59C", VA = "0x149E59C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x149E360", Offset = "0x149E360", VA = "0x149E360")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x149E8F4", Offset = "0x149E8F4", VA = "0x149E8F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x149EA10", Offset = "0x149EA10", VA = "0x149EA10")]
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
		[Address(RVA = "0x14A0024", Offset = "0x14A0024", VA = "0x14A0024", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x14A008C", Offset = "0x14A008C", VA = "0x14A008C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x14A0350", Offset = "0x14A0350", VA = "0x14A0350")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x14A0508", Offset = "0x14A0508", VA = "0x14A0508")]
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
			[Address(RVA = "0x14A1374", Offset = "0x14A1374", VA = "0x14A1374")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x14A1414", Offset = "0x14A1414", VA = "0x14A1414")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x14A10B8", Offset = "0x14A10B8", VA = "0x14A10B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x14A1130", Offset = "0x14A1130", VA = "0x14A1130")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x14A14B4", Offset = "0x14A14B4", VA = "0x14A14B4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92CFE4", Offset = "0x92CFE4")]
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
		[Address(RVA = "0x14A3EB0", Offset = "0x14A3EB0", VA = "0x14A3EB0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x14A4494", Offset = "0x14A4494", VA = "0x14A4494")]
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
		[Address(RVA = "0x14A449C", Offset = "0x14A449C", VA = "0x14A449C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x14A4550", Offset = "0x14A4550", VA = "0x14A4550")]
		private void Update()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x14A49CC", Offset = "0x14A49CC", VA = "0x14A49CC")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x14A4A78", Offset = "0x14A4A78", VA = "0x14A4A78")]
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
			[Address(RVA = "0x14A4C4C", Offset = "0x14A4C4C", VA = "0x14A4C4C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x14A4D80", Offset = "0x14A4D80", VA = "0x14A4D80")]
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
		[Address(RVA = "0x14A4B00", Offset = "0x14A4B00", VA = "0x14A4B00")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x14A4CD0", Offset = "0x14A4CD0", VA = "0x14A4CD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x14A4D6C", Offset = "0x14A4D6C", VA = "0x14A4D6C")]
		private void Update()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x14A4D70", Offset = "0x14A4D70", VA = "0x14A4D70")]
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
		[Address(RVA = "0x14A4D90", Offset = "0x14A4D90", VA = "0x14A4D90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x14A4DFC", Offset = "0x14A4DFC", VA = "0x14A4DFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x14A4EE0", Offset = "0x14A4EE0", VA = "0x14A4EE0")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92CFFC", Offset = "0x92CFFC")]
		public Transform target;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D034", Offset = "0x92D034")]
		public Transform pin;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D06C", Offset = "0x92D06C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D0A4", Offset = "0x92D0A4")]
		public AimIK aim;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D0DC", Offset = "0x92D0DC")]
		public float weight;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D114", Offset = "0x92D114")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D14C", Offset = "0x92D14C")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x14A4EE8", Offset = "0x14A4EE8", VA = "0x14A4EE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x14A4F48", Offset = "0x14A4F48", VA = "0x14A4F48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x14A50E4", Offset = "0x14A50E4", VA = "0x14A50E4")]
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
		[Address(RVA = "0x14A50EC", Offset = "0x14A50EC", VA = "0x14A50EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x14A51BC", Offset = "0x14A51BC", VA = "0x14A51BC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x14A524C", Offset = "0x14A524C", VA = "0x14A524C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x14A5760", Offset = "0x14A5760", VA = "0x14A5760")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x14A587C", Offset = "0x14A587C", VA = "0x14A587C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D184", Offset = "0x92D184")]
		public float aimWeight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D19C", Offset = "0x92D19C")]
		public float sightWeight;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D1B4", Offset = "0x92D1B4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D1D0", Offset = "0x92D1D0")]
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
		[Address(RVA = "0x14A5C10", Offset = "0x14A5C10", VA = "0x14A5C10")]
		private void Start()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x14A5DC0", Offset = "0x14A5DC0", VA = "0x14A5DC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x14A5DCC", Offset = "0x14A5DCC", VA = "0x14A5DCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x14A610C", Offset = "0x14A610C", VA = "0x14A610C")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x14A6484", Offset = "0x14A6484", VA = "0x14A6484")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x14A5E90", Offset = "0x14A5E90", VA = "0x14A5E90")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x14A6EA4", Offset = "0x14A6EA4", VA = "0x14A6EA4")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D1E8", Offset = "0x92D1E8")]
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
		[Address(RVA = "0x14A6EC4", Offset = "0x14A6EC4", VA = "0x14A6EC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x14A6F48", Offset = "0x14A6F48", VA = "0x14A6F48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x14A706C", Offset = "0x14A706C", VA = "0x14A706C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x14A711C", Offset = "0x14A711C", VA = "0x14A711C")]
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
		[Address(RVA = "0x14A74B0", Offset = "0x14A74B0", VA = "0x14A74B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x14A767C", Offset = "0x14A767C", VA = "0x14A767C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x14A7840", Offset = "0x14A7840", VA = "0x14A7840")]
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
		[Address(RVA = "0x14A7BF0", Offset = "0x14A7BF0", VA = "0x14A7BF0")]
		private void Start()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x14A7D9C", Offset = "0x14A7D9C", VA = "0x14A7D9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x14A8158", Offset = "0x14A8158", VA = "0x14A8158")]
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
		[Address(RVA = "0x14A8168", Offset = "0x14A8168", VA = "0x14A8168")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x14A829C", Offset = "0x14A829C", VA = "0x14A829C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x14A83EC", Offset = "0x14A83EC", VA = "0x14A83EC")]
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
		[Address(RVA = "0x14A83F4", Offset = "0x14A83F4", VA = "0x14A83F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x14A8AC4", Offset = "0x14A8AC4", VA = "0x14A8AC4")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D200", Offset = "0x92D200")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D238", Offset = "0x92D238")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x14A8ACC", Offset = "0x14A8ACC", VA = "0x14A8ACC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x14A8B2C", Offset = "0x14A8B2C", VA = "0x14A8B2C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x14A8E38", Offset = "0x14A8E38", VA = "0x14A8E38")]
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
				[Address(RVA = "0x14A973C", Offset = "0x14A973C", VA = "0x14A973C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x14A8E74", Offset = "0x14A8E74", VA = "0x14A8E74")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x14A8EF4", Offset = "0x14A8EF4", VA = "0x14A8EF4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x14A9560", Offset = "0x14A9560", VA = "0x14A9560")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x14A9794", Offset = "0x14A9794", VA = "0x14A9794")]
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
		[Address(RVA = "0x14A8E40", Offset = "0x14A8E40", VA = "0x14A8E40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x14A8E94", Offset = "0x14A8E94", VA = "0x14A8E94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x14A9550", Offset = "0x14A9550", VA = "0x14A9550")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x930FE4", Offset = "0x930FE4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x93101C", Offset = "0x93101C")]
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
			[Address(RVA = "0x1096284", Offset = "0x1096284", VA = "0x1096284")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1096478", Offset = "0x1096478", VA = "0x1096478")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x10964B4", Offset = "0x10964B4", VA = "0x10964B4")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1096664", Offset = "0x1096664", VA = "0x1096664")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x10968AC", Offset = "0x10968AC", VA = "0x10968AC")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D270", Offset = "0x92D270")]
		public Mode mode;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D2A8", Offset = "0x92D2A8")]
		public Absorber[] absorbers;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D2E0", Offset = "0x92D2E0")]
		public AnimationCurve falloff;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D318", Offset = "0x92D318")]
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
		[Address(RVA = "0x1096110", Offset = "0x1096110", VA = "0x1096110", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x10961F8", Offset = "0x10961F8", VA = "0x10961F8")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x109636C", Offset = "0x109636C", VA = "0x109636C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x10965DC", Offset = "0x10965DC", VA = "0x10965DC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1096774", Offset = "0x1096774", VA = "0x1096774", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x109689C", Offset = "0x109689C", VA = "0x109689C")]
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
		[Address(RVA = "0x109692C", Offset = "0x109692C", VA = "0x109692C")]
		private void Start()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x10969AC", Offset = "0x10969AC", VA = "0x10969AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1096A60", Offset = "0x1096A60", VA = "0x1096A60")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1096BC0", Offset = "0x1096BC0", VA = "0x1096BC0")]
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
			[Address(RVA = "0x1097960", Offset = "0x1097960", VA = "0x1097960")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x109762C", Offset = "0x109762C", VA = "0x109762C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x109772C", Offset = "0x109772C", VA = "0x109772C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1097958", Offset = "0x1097958", VA = "0x1097958")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D350", Offset = "0x92D350")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D350", Offset = "0x92D350")]
		public float weight;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D3A4", Offset = "0x92D3A4")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D3DC", Offset = "0x92D3DC")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D428", Offset = "0x92D428")]
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
		[Address(RVA = "0x1097970", Offset = "0x1097970", VA = "0x1097970")]
		private void Start()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1097CC0", Offset = "0x1097CC0", VA = "0x1097CC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1098410", Offset = "0x1098410", VA = "0x1098410")]
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
			[Address(RVA = "0x1098980", Offset = "0x1098980", VA = "0x1098980")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool holdingLeft
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1098A70", Offset = "0x1098A70", VA = "0x1098A70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		private bool holdingRight
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x10989B8", Offset = "0x10989B8", VA = "0x10989B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1098494", Offset = "0x1098494", VA = "0x1098494")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000588")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1098B28", Offset = "0x1098B28", VA = "0x1098B28")]
		private void Start()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1098CC0", Offset = "0x1098CC0", VA = "0x1098CC0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1098E3C", Offset = "0x1098E3C", VA = "0x1098E3C")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1098F1C", Offset = "0x1098F1C", VA = "0x1098F1C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1099054", Offset = "0x1099054", VA = "0x1099054")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1099270", Offset = "0x1099270", VA = "0x1099270")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1099454", Offset = "0x1099454", VA = "0x1099454")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1099468", Offset = "0x1099468", VA = "0x1099468", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x109965C", Offset = "0x109965C", VA = "0x109965C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1099670", Offset = "0x1099670", VA = "0x1099670", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x109981C", Offset = "0x109981C", VA = "0x109981C")]
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
		[Address(RVA = "0x1099FBC", Offset = "0x1099FBC", VA = "0x1099FBC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x109A094", Offset = "0x109A094", VA = "0x109A094")]
		private void Update()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x109A23C", Offset = "0x109A23C", VA = "0x109A23C")]
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
		[Address(RVA = "0x109A244", Offset = "0x109A244", VA = "0x109A244")]
		private void Start()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x109A2A4", Offset = "0x109A2A4", VA = "0x109A2A4")]
		private void Update()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x109A300", Offset = "0x109A300", VA = "0x109A300")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x109A3D8", Offset = "0x109A3D8", VA = "0x109A3D8")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F84", Offset = "0x928F84")]
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
				[Address(RVA = "0x109A784", Offset = "0x109A784", VA = "0x109A784", Slot = "4")]
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
				[Address(RVA = "0x109A7EC", Offset = "0x109A7EC", VA = "0x109A7EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x109A588", Offset = "0x109A588", VA = "0x109A588")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x109A5C4", Offset = "0x109A5C4", VA = "0x109A5C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x109A5C8", Offset = "0x109A5C8", VA = "0x109A5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x109A78C", Offset = "0x109A78C", VA = "0x109A78C", Slot = "8")]
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
		[Address(RVA = "0x109A3E8", Offset = "0x109A3E8", VA = "0x109A3E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x109A4B4", Offset = "0x109A4B4", VA = "0x109A4B4")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x109A4FC", Offset = "0x109A4FC", VA = "0x109A4FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x933448", Offset = "0x933448")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x109A5B4", Offset = "0x109A5B4", VA = "0x109A5B4")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928F94", Offset = "0x928F94")]
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
				[Address(RVA = "0x109BFC4", Offset = "0x109BFC4", VA = "0x109BFC4", Slot = "4")]
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
				[Address(RVA = "0x109C02C", Offset = "0x109C02C", VA = "0x109C02C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x109BE54", Offset = "0x109BE54", VA = "0x109BE54")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x109BE88", Offset = "0x109BE88", VA = "0x109BE88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x109BE8C", Offset = "0x109BE8C", VA = "0x109BE8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x109BFCC", Offset = "0x109BFCC", VA = "0x109BFCC", Slot = "8")]
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
		[Address(RVA = "0x109BD1C", Offset = "0x109BD1C", VA = "0x109BD1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x109BDD8", Offset = "0x109BDD8", VA = "0x109BDD8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9334AC", Offset = "0x9334AC")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x109BE80", Offset = "0x109BE80", VA = "0x109BE80")]
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
			[Address(RVA = "0x109C5D4", Offset = "0x109C5D4", VA = "0x109C5D4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x109D2E4", Offset = "0x109D2E4", VA = "0x109D2E4")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x109C950", Offset = "0x109C950", VA = "0x109C950")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x109D3D0", Offset = "0x109D3D0", VA = "0x109D3D0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x109D56C", Offset = "0x109D56C", VA = "0x109D56C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x109D608", Offset = "0x109D608", VA = "0x109D608")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x109D6A0", Offset = "0x109D6A0", VA = "0x109D6A0")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x109D130", Offset = "0x109D130", VA = "0x109D130")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x109D738", Offset = "0x109D738", VA = "0x109D738")]
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
		[Address(RVA = "0x109C55C", Offset = "0x109C55C", VA = "0x109C55C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x109C8E4", Offset = "0x109C8E4", VA = "0x109C8E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x109D068", Offset = "0x109D068", VA = "0x109D068")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x109D2DC", Offset = "0x109D2DC", VA = "0x109D2DC")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D474", Offset = "0x92D474")]
		public Transform to;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D4AC", Offset = "0x92D4AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D4AC", Offset = "0x92D4AC")]
		public float transferMotion;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x109D774", Offset = "0x109D774", VA = "0x109D774")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x109D7B0", Offset = "0x109D7B0", VA = "0x109D7B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x109D908", Offset = "0x109D908", VA = "0x109D908")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D500", Offset = "0x92D500")]
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
		[Address(RVA = "0x109DADC", Offset = "0x109DADC", VA = "0x109DADC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x109DCBC", Offset = "0x109DCBC", VA = "0x109DCBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x109DF58", Offset = "0x109DF58", VA = "0x109DF58")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x109E024", Offset = "0x109E024", VA = "0x109E024")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x109E140", Offset = "0x109E140", VA = "0x109E140")]
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
		[Address(RVA = "0x109E4AC", Offset = "0x109E4AC", VA = "0x109E4AC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x109E924", Offset = "0x109E924", VA = "0x109E924")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x109EB7C", Offset = "0x109EB7C", VA = "0x109EB7C")]
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
		[Address(RVA = "0x14A712C", Offset = "0x14A712C", VA = "0x14A712C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x14A7428", Offset = "0x14A7428", VA = "0x14A7428")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x14A74A8", Offset = "0x14A74A8", VA = "0x14A74A8")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928FA4", Offset = "0x928FA4")]
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
				[Address(RVA = "0x1099F4C", Offset = "0x1099F4C", VA = "0x1099F4C", Slot = "4")]
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
				[Address(RVA = "0x1099FB4", Offset = "0x1099FB4", VA = "0x1099FB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1099BFC", Offset = "0x1099BFC", VA = "0x1099BFC")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1099E08", Offset = "0x1099E08", VA = "0x1099E08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1099E0C", Offset = "0x1099E0C", VA = "0x1099E0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x1099F54", Offset = "0x1099F54", VA = "0x1099F54", Slot = "8")]
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
		[Address(RVA = "0x1099830", Offset = "0x1099830", VA = "0x1099830")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x10999D4", Offset = "0x10999D4", VA = "0x10999D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1099958", Offset = "0x1099958", VA = "0x1099958")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x933510", Offset = "0x933510")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1099C28", Offset = "0x1099C28", VA = "0x1099C28")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1099D0C", Offset = "0x1099D0C", VA = "0x1099D0C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1099DEC", Offset = "0x1099DEC", VA = "0x1099DEC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92D538", Offset = "0x92D538")]
		public float weight;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x149EA70", Offset = "0x149EA70", VA = "0x149EA70")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x149EADC", Offset = "0x149EADC", VA = "0x149EADC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x149EB98", Offset = "0x149EB98", VA = "0x149EB98")]
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
			[Address(RVA = "0x109D994", Offset = "0x109D994", VA = "0x109D994")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x109DAD4", Offset = "0x109DAD4", VA = "0x109DAD4")]
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
		[Address(RVA = "0x109D91C", Offset = "0x109D91C", VA = "0x109D91C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x109DACC", Offset = "0x109DACC", VA = "0x109DACC")]
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
		[Address(RVA = "0x14A7850", Offset = "0x14A7850", VA = "0x14A7850")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x14A7A1C", Offset = "0x14A7A1C", VA = "0x14A7A1C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x14A7BE0", Offset = "0x14A7BE0", VA = "0x14A7BE0")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D550", Offset = "0x92D550")]
		public VRIK ik;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92D588", Offset = "0x92D588")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D588", Offset = "0x92D588")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D5E8", Offset = "0x92D5E8")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D620", Offset = "0x92D620")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92D658", Offset = "0x92D658")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D658", Offset = "0x92D658")]
		public Transform leftHandAnchor;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D6B8", Offset = "0x92D6B8")]
		public Transform rightHandAnchor;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D6F0", Offset = "0x92D6F0")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D728", Offset = "0x92D728")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92D760", Offset = "0x92D760")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D760", Offset = "0x92D760")]
		public float scaleMlp;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92D7C0", Offset = "0x92D7C0")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x109EBA0", Offset = "0x109EBA0", VA = "0x109EBA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x109ED3C", Offset = "0x109ED3C", VA = "0x109ED3C")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D7F8", Offset = "0x92D7F8")]
		public VRIK ik;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D830", Offset = "0x92D830")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D868", Offset = "0x92D868")]
		public Transform headTracker;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D8A0", Offset = "0x92D8A0")]
		public Transform bodyTracker;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D8D8", Offset = "0x92D8D8")]
		public Transform leftHandTracker;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D910", Offset = "0x92D910")]
		public Transform rightHandTracker;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D948", Offset = "0x92D948")]
		public Transform leftFootTracker;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92D980", Offset = "0x92D980")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92D9B8", Offset = "0x92D9B8")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x109EDB8", Offset = "0x109EDB8", VA = "0x109EDB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x109EF24", Offset = "0x109EF24", VA = "0x109EF24")]
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
		[Address(RVA = "0x109EF98", Offset = "0x109EF98", VA = "0x109EF98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x109EFF4", Offset = "0x109EFF4", VA = "0x109EFF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x109F208", Offset = "0x109F208", VA = "0x109F208")]
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
		[Address(RVA = "0x109F280", Offset = "0x109F280", VA = "0x109F280")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x109F7E8", Offset = "0x109F7E8", VA = "0x109F7E8")]
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
			[Address(RVA = "0x149F098", Offset = "0x149F098", VA = "0x149F098", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x149F074", Offset = "0x149F074", VA = "0x149F074", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x149F0A0", Offset = "0x149F0A0", VA = "0x149F0A0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x149F164", Offset = "0x149F164", VA = "0x149F164", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x149F2DC", Offset = "0x149F2DC", VA = "0x149F2DC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x149F590", Offset = "0x149F590", VA = "0x149F590", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x149F2EC", Offset = "0x149F2EC", VA = "0x149F2EC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x149F5A0", Offset = "0x149F5A0", VA = "0x149F5A0")]
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
		[Address(RVA = "0x149F5B8", Offset = "0x149F5B8", VA = "0x149F5B8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x149F620", Offset = "0x149F620", VA = "0x149F620", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x149F74C", Offset = "0x149F74C", VA = "0x149F74C")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x149F8C8", Offset = "0x149F8C8", VA = "0x149F8C8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x92DA20", Offset = "0x92DA20")]
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
			[Address(RVA = "0x149F98C", Offset = "0x149F98C", VA = "0x149F98C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x149F8E0", Offset = "0x149F8E0", VA = "0x149F8E0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x149F970", Offset = "0x149F970", VA = "0x149F970", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x149FA7C", Offset = "0x149FA7C", VA = "0x149FA7C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x149FE4C", Offset = "0x149FE4C", VA = "0x149FE4C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x14A0000", Offset = "0x14A0000", VA = "0x14A0000")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DA64", Offset = "0x92DA64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DA64", Offset = "0x92DA64")]
		public Transform gravityTarget;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DAC4", Offset = "0x92DAC4")]
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
		[Address(RVA = "0x14A052C", Offset = "0x14A052C", VA = "0x14A052C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x14A06B0", Offset = "0x14A06B0", VA = "0x14A06B0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x14A0878", Offset = "0x14A0878", VA = "0x14A0878", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x14A0AF0", Offset = "0x14A0AF0", VA = "0x14A0AF0")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x14A0BB4", Offset = "0x14A0BB4", VA = "0x14A0BB4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x14A0D9C", Offset = "0x14A0D9C", VA = "0x14A0D9C")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x14A0F4C", Offset = "0x14A0F4C", VA = "0x14A0F4C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x14A0F70", Offset = "0x14A0F70", VA = "0x14A0F70")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x14A0F94", Offset = "0x14A0F94", VA = "0x14A0F94")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x14A1098", Offset = "0x14A1098", VA = "0x14A1098")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x928FB4", Offset = "0x928FB4")]
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
				[Address(RVA = "0x14A3E40", Offset = "0x14A3E40", VA = "0x14A3E40", Slot = "4")]
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
				[Address(RVA = "0x14A3EA8", Offset = "0x14A3EA8", VA = "0x14A3EA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x14A3B94", Offset = "0x14A3B94", VA = "0x14A3B94")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x14A3CF4", Offset = "0x14A3CF4", VA = "0x14A3CF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x14A3CF8", Offset = "0x14A3CF8", VA = "0x14A3CF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x14A3E48", Offset = "0x14A3E48", VA = "0x14A3E48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DAFC", Offset = "0x92DAFC")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DB34", Offset = "0x92DB34")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DB6C", Offset = "0x92DB6C")]
		public bool lookInCameraDirection;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DBA4", Offset = "0x92DBA4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DBDC", Offset = "0x92DBDC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x92DC14", Offset = "0x92DC14")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DC4C", Offset = "0x92DC4C")]
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
			[Address(RVA = "0x14A14BC", Offset = "0x14A14BC", VA = "0x14A14BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933574", Offset = "0x933574")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x14A14C4", Offset = "0x14A14C4", VA = "0x14A14C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933584", Offset = "0x933584")]
			private set
			{
			}
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x14A14D0", Offset = "0x14A14D0", VA = "0x14A14D0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x14A167C", Offset = "0x14A167C", VA = "0x14A167C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x14A170C", Offset = "0x14A170C", VA = "0x14A170C", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x14A185C", Offset = "0x14A185C", VA = "0x14A185C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x14A27D8", Offset = "0x14A27D8", VA = "0x14A27D8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x14A2B70", Offset = "0x14A2B70", VA = "0x14A2B70", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x14A1E6C", Offset = "0x14A1E6C", VA = "0x14A1E6C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x14A2C50", Offset = "0x14A2C50", VA = "0x14A2C50")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x14A3240", Offset = "0x14A3240", VA = "0x14A3240")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x14A28B4", Offset = "0x14A28B4", VA = "0x14A28B4")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x14A32E0", Offset = "0x14A32E0", VA = "0x14A32E0", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x14A3750", Offset = "0x14A3750", VA = "0x14A3750")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x14A38DC", Offset = "0x14A38DC", VA = "0x14A38DC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x14A3AF4", Offset = "0x14A3AF4", VA = "0x14A3AF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x933594", Offset = "0x933594")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x14A23B8", Offset = "0x14A23B8", VA = "0x14A23B8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x14A3BC0", Offset = "0x14A3BC0", VA = "0x14A3BC0")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DC5C", Offset = "0x92DC5C")]
		public CameraController cameraController;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DC94", Offset = "0x92DC94")]
		public float accelerationTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DCCC", Offset = "0x92DCCC")]
		public float turnTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DD04", Offset = "0x92DD04")]
		public bool walkByDefault;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DD3C", Offset = "0x92DD3C")]
		public RotationMode rotationMode;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DD74", Offset = "0x92DD74")]
		public float moveSpeed;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DDAC", Offset = "0x92DDAC")]
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
			[Address(RVA = "0x109B27C", Offset = "0x109B27C", VA = "0x109B27C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9335F8", Offset = "0x9335F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x109B284", Offset = "0x109B284", VA = "0x109B284")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933608", Offset = "0x933608")]
			private set
			{
			}
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x109B290", Offset = "0x109B290", VA = "0x109B290")]
		private void Start()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x109B32C", Offset = "0x109B32C", VA = "0x109B32C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x109BA28", Offset = "0x109BA28", VA = "0x109BA28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x109B380", Offset = "0x109B380", VA = "0x109B380")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x109B780", Offset = "0x109B780", VA = "0x109B780")]
		private void Move()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x109BA64", Offset = "0x109BA64", VA = "0x109BA64")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x109BB5C", Offset = "0x109BB5C", VA = "0x109BB5C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x109BBFC", Offset = "0x109BBFC", VA = "0x109BBFC")]
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
		[Address(RVA = "0x109E148", Offset = "0x109E148", VA = "0x109E148", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x109E1C8", Offset = "0x109E1C8", VA = "0x109E1C8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x109E45C", Offset = "0x109E45C", VA = "0x109E45C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x109E480", Offset = "0x109E480", VA = "0x109E480")]
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
		[Address(RVA = "0x109E188", Offset = "0x109E188", VA = "0x109E188", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x109E5C0", Offset = "0x109E5C0", VA = "0x109E5C0", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x109E49C", Offset = "0x109E49C", VA = "0x109E49C")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x149EA2C", Offset = "0x149EA2C", VA = "0x149EA2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x149EA68", Offset = "0x149EA68", VA = "0x149EA68")]
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
		[Address(RVA = "0x109BC24", Offset = "0x109BC24", VA = "0x109BC24")]
		private void Update()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x109BC58", Offset = "0x109BC58", VA = "0x109BC58")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x109BD08", Offset = "0x109BD08", VA = "0x109BD08")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DDBC", Offset = "0x92DDBC")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DDF4", Offset = "0x92DDF4")]
		public float cornerRadius;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DE2C", Offset = "0x92DE2C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DE64", Offset = "0x92DE64")]
		public float maxSampleDistance;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x92DE9C", Offset = "0x92DE9C")]
		public float nextPathInterval;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DED4", Offset = "0x92DED4")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92DEE4", Offset = "0x92DEE4")]
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
			[Address(RVA = "0x1096BD4", Offset = "0x1096BD4", VA = "0x1096BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933618", Offset = "0x933618")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x1096BE0", Offset = "0x1096BE0", VA = "0x1096BE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933628", Offset = "0x933628")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public State state
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1096BEC", Offset = "0x1096BEC", VA = "0x1096BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933638", Offset = "0x933638")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1096BF4", Offset = "0x1096BF4", VA = "0x1096BF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x933648", Offset = "0x933648")]
			private set
			{
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1096BFC", Offset = "0x1096BFC", VA = "0x1096BFC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1096CF4", Offset = "0x1096CF4", VA = "0x1096CF4")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x109724C", Offset = "0x109724C", VA = "0x109724C")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x10972BC", Offset = "0x10972BC", VA = "0x10972BC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1097114", Offset = "0x1097114", VA = "0x1097114")]
		private void Stop()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1097188", Offset = "0x1097188", VA = "0x1097188")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1097404", Offset = "0x1097404", VA = "0x1097404")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x10975B4", Offset = "0x10975B4", VA = "0x10975B4")]
		public Navigator()
		{
		}
	}
}
