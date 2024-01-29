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
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681970", Offset = "0x681970")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681970", Offset = "0x681970")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x682EFC", Offset = "0x682EFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x682EFC", Offset = "0x682EFC")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x682F54", Offset = "0x682F54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x682F54", Offset = "0x682F54")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x682FAC", Offset = "0x682FAC")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x682FE4", Offset = "0x682FE4")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68301C", Offset = "0x68301C")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683054", Offset = "0x683054")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68308C", Offset = "0x68308C")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6830C4", Offset = "0x6830C4")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6830FC", Offset = "0x6830FC")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683134", Offset = "0x683134")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683144", Offset = "0x683144")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6831C4", Offset = "0x6831C4")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1573524", Offset = "0x1573524", VA = "0x1573524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B160", Offset = "0x68B160")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x157352C", Offset = "0x157352C", VA = "0x157352C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B170", Offset = "0x68B170")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1573538", Offset = "0x1573538", VA = "0x1573538")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B180", Offset = "0x68B180")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1573540", Offset = "0x1573540", VA = "0x1573540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B190", Offset = "0x68B190")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1573548", Offset = "0x1573548", VA = "0x1573548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B1A0", Offset = "0x68B1A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1573550", Offset = "0x1573550", VA = "0x1573550")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B1B0", Offset = "0x68B1B0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1573404", Offset = "0x1573404", VA = "0x1573404")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B080", Offset = "0x68B080")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x157344C", Offset = "0x157344C", VA = "0x157344C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B0B8", Offset = "0x68B0B8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1573494", Offset = "0x1573494", VA = "0x1573494")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B0F0", Offset = "0x68B0F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x15734DC", Offset = "0x15734DC", VA = "0x15734DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B128", Offset = "0x68B128")]
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
		[Address(RVA = "0x1573558", Offset = "0x1573558", VA = "0x1573558")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x157355C", Offset = "0x157355C", VA = "0x157355C")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1573560", Offset = "0x1573560", VA = "0x1573560")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1573564", Offset = "0x1573564", VA = "0x1573564")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6831D4", Offset = "0x6831D4")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68320C", Offset = "0x68320C")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683244", Offset = "0x683244")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68327C", Offset = "0x68327C")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6832B4", Offset = "0x6832B4")]
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
		[Address(RVA = "0x15A4E80", Offset = "0x15A4E80", VA = "0x15A4E80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x15A5284", Offset = "0x15A5284", VA = "0x15A5284", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x15A528C", Offset = "0x15A528C", VA = "0x15A528C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x15A539C", Offset = "0x15A539C", VA = "0x15A539C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x15A5418", Offset = "0x15A5418", VA = "0x15A5418", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x15A5494", Offset = "0x15A5494", VA = "0x15A5494", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x15A50DC", Offset = "0x15A50DC", VA = "0x15A50DC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x15A51B0", Offset = "0x15A51B0", VA = "0x15A51B0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x15A5510", Offset = "0x15A5510", VA = "0x15A5510")]
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
		[Address(RVA = "0x1449D94", Offset = "0x1449D94", VA = "0x1449D94")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x15727D8", Offset = "0x15727D8", VA = "0x15727D8")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1572A40", Offset = "0x1572A40", VA = "0x1572A40")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1572A20", Offset = "0x1572A20", VA = "0x1572A20")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1573004", Offset = "0x1573004", VA = "0x1573004")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1574834", Offset = "0x1574834", VA = "0x1574834")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1576164", Offset = "0x1576164", VA = "0x1576164")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1574288", Offset = "0x1574288", VA = "0x1574288")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x157487C", Offset = "0x157487C", VA = "0x157487C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1573DB8", Offset = "0x1573DB8", VA = "0x1573DB8")]
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
		[Address(RVA = "0x1573680", Offset = "0x1573680", VA = "0x1573680")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1573994", Offset = "0x1573994", VA = "0x1573994")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1573838", Offset = "0x1573838", VA = "0x1573838")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1573B70", Offset = "0x1573B70", VA = "0x1573B70")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x157401C", Offset = "0x157401C", VA = "0x157401C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1574118", Offset = "0x1574118", VA = "0x1574118")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1574214", Offset = "0x1574214", VA = "0x1574214")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x157418C", Offset = "0x157418C", VA = "0x157418C")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1574480", Offset = "0x1574480", VA = "0x1574480")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1574534", Offset = "0x1574534", VA = "0x1574534")]
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
		[Address(RVA = "0x1574880", Offset = "0x1574880", VA = "0x1574880")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x15748FC", Offset = "0x15748FC", VA = "0x15748FC")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1575398", Offset = "0x1575398", VA = "0x1575398")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x157544C", Offset = "0x157544C", VA = "0x157544C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1575334", Offset = "0x1575334", VA = "0x1575334")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1575544", Offset = "0x1575544", VA = "0x1575544")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x157558C", Offset = "0x157558C", VA = "0x157558C")]
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
		[Address(RVA = "0x1575594", Offset = "0x1575594", VA = "0x1575594")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1575784", Offset = "0x1575784", VA = "0x1575784")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1575798", Offset = "0x1575798", VA = "0x1575798")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1575A84", Offset = "0x1575A84", VA = "0x1575A84")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1575640", Offset = "0x1575640", VA = "0x1575640")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1575D38", Offset = "0x1575D38", VA = "0x1575D38")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1575DAC", Offset = "0x1575DAC", VA = "0x1575DAC")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1575F60", Offset = "0x1575F60", VA = "0x1575F60")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6832EC", Offset = "0x6832EC")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683324", Offset = "0x683324")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683324", Offset = "0x683324")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68337C", Offset = "0x68337C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68337C", Offset = "0x68337C")]
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
		[Address(RVA = "0x15AF278", Offset = "0x15AF278", VA = "0x15AF278")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x15AF80C", Offset = "0x15AF80C", VA = "0x15AF80C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15AF828", Offset = "0x15AF828", VA = "0x15AF828", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x15AF904", Offset = "0x15AF904", VA = "0x15AF904", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x15AF9E0", Offset = "0x15AF9E0", VA = "0x15AF9E0", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x15AFBB0", Offset = "0x15AFBB0", VA = "0x15AFBB0", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x15AFE78", Offset = "0x15AFE78", VA = "0x15AFE78")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x15AFF54", Offset = "0x15AFF54", VA = "0x15AFF54")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6833D0", Offset = "0x6833D0")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x683408", Offset = "0x683408")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x683440", Offset = "0x683440")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x683478", Offset = "0x683478")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6834B0", Offset = "0x6834B0")]
		public float blockedOffset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6834C8", Offset = "0x6834C8")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6834D8", Offset = "0x6834D8")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6834E8", Offset = "0x6834E8")]
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
			[Address(RVA = "0x157F600", Offset = "0x157F600", VA = "0x157F600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B1C0", Offset = "0x68B1C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x157F608", Offset = "0x157F608", VA = "0x157F608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B1D0", Offset = "0x68B1D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x157F610", Offset = "0x157F610", VA = "0x157F610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B1E0", Offset = "0x68B1E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x157F618", Offset = "0x157F618", VA = "0x157F618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B1F0", Offset = "0x68B1F0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x157F620", Offset = "0x157F620", VA = "0x157F620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B200", Offset = "0x68B200")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x157F628", Offset = "0x157F628", VA = "0x157F628")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B210", Offset = "0x68B210")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x157FEBC", Offset = "0x157FEBC", VA = "0x157FEBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x157F630", Offset = "0x157F630", VA = "0x157F630")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x157F66C", Offset = "0x157F66C", VA = "0x157F66C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x157F674", Offset = "0x157F674", VA = "0x157F674", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x157F784", Offset = "0x157F784", VA = "0x157F784", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x157F7E0", Offset = "0x157F7E0", VA = "0x157F7E0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x157F848", Offset = "0x157F848", VA = "0x157F848", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x157F8AC", Offset = "0x157F8AC", VA = "0x157F8AC")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x157F7B8", Offset = "0x157F7B8", VA = "0x157F7B8")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x157FA2C", Offset = "0x157FA2C", VA = "0x157FA2C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x157FE8C", Offset = "0x157FE8C", VA = "0x157FE8C")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x157FF2C", Offset = "0x157FF2C", VA = "0x157FF2C")]
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
		[Address(RVA = "0x157FFD0", Offset = "0x157FFD0", VA = "0x157FFD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1580008", Offset = "0x1580008", VA = "0x1580008")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15801B0", Offset = "0x15801B0", VA = "0x15801B0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x15801E0", Offset = "0x15801E0", VA = "0x15801E0")]
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
		[Address(RVA = "0x157300C", Offset = "0x157300C", VA = "0x157300C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1573030", Offset = "0x1573030", VA = "0x1573030")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1573068", Offset = "0x1573068", VA = "0x1573068")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1573158", Offset = "0x1573158", VA = "0x1573158")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1573100", Offset = "0x1573100", VA = "0x1573100")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15731F0", Offset = "0x15731F0", VA = "0x15731F0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1573238", Offset = "0x1573238", VA = "0x1573238")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15733FC", Offset = "0x15733FC", VA = "0x15733FC")]
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
			[Address(RVA = "0x1289C14", Offset = "0x1289C14", VA = "0x1289C14")]
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
			[Address(RVA = "0x1577D7C", Offset = "0x1577D7C", VA = "0x1577D7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1577FEC", Offset = "0x1577FEC", VA = "0x1577FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1577CFC", Offset = "0x1577CFC", VA = "0x1577CFC")]
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
		[Address(RVA = "0x157825C", Offset = "0x157825C", VA = "0x157825C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1578580", Offset = "0x1578580", VA = "0x1578580")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15787F4", Offset = "0x15787F4", VA = "0x15787F4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1578874", Offset = "0x1578874", VA = "0x1578874")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x157891C", Offset = "0x157891C", VA = "0x157891C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1578434", Offset = "0x1578434", VA = "0x1578434")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1578758", Offset = "0x1578758", VA = "0x1578758")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x157914C", Offset = "0x157914C", VA = "0x157914C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1578F54", Offset = "0x1578F54", VA = "0x1578F54")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1579050", Offset = "0x1579050", VA = "0x1579050")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1578B34", Offset = "0x1578B34", VA = "0x1578B34")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1578BE4", Offset = "0x1578BE4", VA = "0x1578BE4")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1578C94", Offset = "0x1578C94", VA = "0x1578C94")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1578D44", Offset = "0x1578D44", VA = "0x1578D44")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1578DF4", Offset = "0x1578DF4", VA = "0x1578DF4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1578EA4", Offset = "0x1578EA4", VA = "0x1578EA4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1579354", Offset = "0x1579354", VA = "0x1579354")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1578A4C", Offset = "0x1578A4C", VA = "0x1578A4C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x15792C4", Offset = "0x15792C4", VA = "0x15792C4")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x15793C0", Offset = "0x15793C0", VA = "0x15793C0")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1579494", Offset = "0x1579494", VA = "0x1579494")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x157924C", Offset = "0x157924C", VA = "0x157924C")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x15791D8", Offset = "0x15791D8", VA = "0x15791D8")]
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
				[Address(RVA = "0x1289CA0", Offset = "0x1289CA0", VA = "0x1289CA0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1289C8C", Offset = "0x1289C8C", VA = "0x1289C8C")]
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
			[Address(RVA = "0x157BCFC", Offset = "0x157BCFC", VA = "0x157BCFC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x157C0E4", Offset = "0x157C0E4", VA = "0x157C0E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x157C0F4", Offset = "0x157C0F4", VA = "0x157C0F4", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x157C51C", Offset = "0x157C51C", VA = "0x157C51C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x157C950", Offset = "0x157C950", VA = "0x157C950")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x157D020", Offset = "0x157D020", VA = "0x157D020")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x157CB7C", Offset = "0x157CB7C", VA = "0x157CB7C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1576FD0", Offset = "0x1576FD0", VA = "0x1576FD0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x157D8A4", Offset = "0x157D8A4", VA = "0x157D8A4")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x157DE60", Offset = "0x157DE60", VA = "0x157DE60")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x157DC40", Offset = "0x157DC40", VA = "0x157DC40")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x157DABC", Offset = "0x157DABC", VA = "0x157DABC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x157D944", Offset = "0x157D944", VA = "0x157D944")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x157DD4C", Offset = "0x157DD4C", VA = "0x157DD4C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x157DF58", Offset = "0x157DF58", VA = "0x157DF58")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x157EB40", Offset = "0x157EB40", VA = "0x157EB40")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x157E5B0", Offset = "0x157E5B0", VA = "0x157E5B0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x157EE3C", Offset = "0x157EE3C", VA = "0x157EE3C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x157E928", Offset = "0x157E928", VA = "0x157E928")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x157EE44", Offset = "0x157EE44", VA = "0x157EE44")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x157EE4C", Offset = "0x157EE4C", VA = "0x157EE4C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x157F020", Offset = "0x157F020", VA = "0x157F020")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x157F1E8", Offset = "0x157F1E8", VA = "0x157F1E8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1577450", Offset = "0x1577450", VA = "0x1577450")]
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
		[Address(RVA = "0xE8D564", Offset = "0xE8D564", VA = "0xE8D564")]
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
		[Address(RVA = "0xE9B1E8", Offset = "0xE9B1E8", VA = "0xE9B1E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xE9B330", Offset = "0xE9B330", VA = "0xE9B330")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x15AD144", Offset = "0x15AD144", VA = "0x15AD144")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x15AD330", Offset = "0x15AD330", VA = "0x15AD330")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x15AD1DC", Offset = "0x15AD1DC", VA = "0x15AD1DC")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x15AD450", Offset = "0x15AD450", VA = "0x15AD450")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x15AD57C", Offset = "0x15AD57C", VA = "0x15AD57C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x15AD7D0", Offset = "0x15AD7D0", VA = "0x15AD7D0")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x15AD8D8", Offset = "0x15AD8D8", VA = "0x15AD8D8")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x15ADA4C", Offset = "0x15ADA4C", VA = "0x15ADA4C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x15ADE28", Offset = "0x15ADE28", VA = "0x15ADE28")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x15ADBEC", Offset = "0x15ADBEC", VA = "0x15ADBEC")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x15ADFDC", Offset = "0x15ADFDC", VA = "0x15ADFDC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1609F94", Offset = "0x1609F94", VA = "0x1609F94")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x160A020", Offset = "0x160A020", VA = "0x160A020")]
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
		[Address(RVA = "0x160D878", Offset = "0x160D878", VA = "0x160D878")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x16134B0", Offset = "0x16134B0", VA = "0x16134B0")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1613524", Offset = "0x1613524", VA = "0x1613524")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1612F18", Offset = "0x1612F18", VA = "0x1612F18")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1612F24", Offset = "0x1612F24", VA = "0x1612F24")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1612F48", Offset = "0x1612F48", VA = "0x1612F48")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1612F84", Offset = "0x1612F84", VA = "0x1612F84")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1612F9C", Offset = "0x1612F9C", VA = "0x1612F9C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1612FB0", Offset = "0x1612FB0", VA = "0x1612FB0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1612FC4", Offset = "0x1612FC4", VA = "0x1612FC4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1612FD4", Offset = "0x1612FD4", VA = "0x1612FD4")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x161301C", Offset = "0x161301C", VA = "0x161301C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1613054", Offset = "0x1613054", VA = "0x1613054")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x161307C", Offset = "0x161307C", VA = "0x161307C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x16135B0", Offset = "0x16135B0", VA = "0x16135B0")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x16130B0", Offset = "0x16130B0", VA = "0x16130B0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x16130D8", Offset = "0x16130D8", VA = "0x16130D8")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1613108", Offset = "0x1613108", VA = "0x1613108")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x161313C", Offset = "0x161313C", VA = "0x161313C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1613180", Offset = "0x1613180", VA = "0x1613180")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x16131E4", Offset = "0x16131E4", VA = "0x16131E4")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1613248", Offset = "0x1613248", VA = "0x1613248")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x161329C", Offset = "0x161329C", VA = "0x161329C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x16132F0", Offset = "0x16132F0", VA = "0x16132F0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x161332C", Offset = "0x161332C", VA = "0x161332C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1613364", Offset = "0x1613364", VA = "0x1613364")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x16135E4", Offset = "0x16135E4", VA = "0x16135E4")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x16133AC", Offset = "0x16133AC", VA = "0x16133AC")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1613440", Offset = "0x1613440", VA = "0x1613440")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1613470", Offset = "0x1613470", VA = "0x1613470")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1613678", Offset = "0x1613678", VA = "0x1613678")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1613734", Offset = "0x1613734", VA = "0x1613734")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x16137C0", Offset = "0x16137C0", VA = "0x16137C0")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1613850", Offset = "0x1613850", VA = "0x1613850")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x16138A8", Offset = "0x16138A8", VA = "0x16138A8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1613974", Offset = "0x1613974", VA = "0x1613974")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x16138C0", Offset = "0x16138C0", VA = "0x16138C0")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x161398C", Offset = "0x161398C", VA = "0x161398C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1613A30", Offset = "0x1613A30", VA = "0x1613A30")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1613A5C", Offset = "0x1613A5C", VA = "0x1613A5C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1613AAC", Offset = "0x1613AAC", VA = "0x1613AAC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1613B18", Offset = "0x1613B18", VA = "0x1613B18")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1613C2C", Offset = "0x1613C2C", VA = "0x1613C2C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1613D24", Offset = "0x1613D24", VA = "0x1613D24")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1613D80", Offset = "0x1613D80", VA = "0x1613D80")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1442B54", Offset = "0x1442B54", VA = "0x1442B54")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1442BA4", Offset = "0x1442BA4", VA = "0x1442BA4")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1442BF4", Offset = "0x1442BF4", VA = "0x1442BF4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1442C9C", Offset = "0x1442C9C", VA = "0x1442C9C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1442D44", Offset = "0x1442D44", VA = "0x1442D44")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1442E24", Offset = "0x1442E24", VA = "0x1442E24")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1442E78", Offset = "0x1442E78", VA = "0x1442E78")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1442354", Offset = "0x1442354", VA = "0x1442354")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1442F4C", Offset = "0x1442F4C", VA = "0x1442F4C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x14430DC", Offset = "0x14430DC", VA = "0x14430DC")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x14431D0", Offset = "0x14431D0", VA = "0x14431D0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x14432DC", Offset = "0x14432DC", VA = "0x14432DC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x14433C8", Offset = "0x14433C8", VA = "0x14433C8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683508", Offset = "0x683508")]
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
			[Address(RVA = "0x1449890", Offset = "0x1449890", VA = "0x1449890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1449BDC", Offset = "0x1449BDC", VA = "0x1449BDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1449750", Offset = "0x1449750", VA = "0x1449750")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x14497F0", Offset = "0x14497F0", VA = "0x14497F0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x14497F4", Offset = "0x14497F4", VA = "0x14497F4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x14497F8", Offset = "0x14497F8", VA = "0x14497F8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x14497FC", Offset = "0x14497FC", VA = "0x14497FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x144988C", Offset = "0x144988C", VA = "0x144988C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1449834", Offset = "0x1449834", VA = "0x1449834")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1449B90", Offset = "0x1449B90", VA = "0x1449B90")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x144997C", Offset = "0x144997C", VA = "0x144997C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1449C94", Offset = "0x1449C94", VA = "0x1449C94")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1449CF0", Offset = "0x1449CF0", VA = "0x1449CF0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1449D4C", Offset = "0x1449D4C", VA = "0x1449D4C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1442B44", Offset = "0x1442B44", VA = "0x1442B44")]
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
		[Address(RVA = "0x144A3F8", Offset = "0x144A3F8", VA = "0x144A3F8")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x144A4B8", Offset = "0x144A4B8", VA = "0x144A4B8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x144A578", Offset = "0x144A578", VA = "0x144A578")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x144A638", Offset = "0x144A638", VA = "0x144A638")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V3Tools
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x144C0D8", Offset = "0x144C0D8", VA = "0x144C0D8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x144C178", Offset = "0x144C178", VA = "0x144C178")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x144C1B4", Offset = "0x144C1B4", VA = "0x144C1B4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x144C1F8", Offset = "0x144C1F8", VA = "0x144C1F8")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x144C294", Offset = "0x144C294", VA = "0x144C294")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x144C3F0", Offset = "0x144C3F0", VA = "0x144C3F0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x144C56C", Offset = "0x144C56C", VA = "0x144C56C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x144C6F0", Offset = "0x144C6F0", VA = "0x144C6F0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x144C7AC", Offset = "0x144C7AC", VA = "0x144C7AC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x144C8AC", Offset = "0x144C8AC", VA = "0x144C8AC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x144C934", Offset = "0x144C934", VA = "0x144C934")]
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
		[Address(RVA = "0x128946C", Offset = "0x128946C", VA = "0x128946C")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1289504", Offset = "0x1289504", VA = "0x1289504")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6819E0", Offset = "0x6819E0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6819E0", Offset = "0x6819E0")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1576670", Offset = "0x1576670", VA = "0x1576670")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B290", Offset = "0x68B290")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x15766B8", Offset = "0x15766B8", VA = "0x15766B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B2C8", Offset = "0x68B2C8")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1576700", Offset = "0x1576700", VA = "0x1576700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B300", Offset = "0x68B300")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1576748", Offset = "0x1576748", VA = "0x1576748")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B338", Offset = "0x68B338")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1576790", Offset = "0x1576790", VA = "0x1576790")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x157682C", Offset = "0x157682C", VA = "0x157682C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x157684C", Offset = "0x157684C", VA = "0x157684C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x157687C", Offset = "0x157687C", VA = "0x157687C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x15768AC", Offset = "0x15768AC", VA = "0x15768AC")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x15768EC", Offset = "0x15768EC", VA = "0x15768EC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1576930", Offset = "0x1576930", VA = "0x1576930")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1576954", Offset = "0x1576954", VA = "0x1576954")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1576978", Offset = "0x1576978", VA = "0x1576978")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x15769A0", Offset = "0x15769A0", VA = "0x15769A0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x15769CC", Offset = "0x15769CC", VA = "0x15769CC")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x15769F8", Offset = "0x15769F8", VA = "0x15769F8")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x15767B0", Offset = "0x15767B0", VA = "0x15767B0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1576A20", Offset = "0x1576A20", VA = "0x1576A20")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1576A2C", Offset = "0x1576A2C", VA = "0x1576A2C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1576A38", Offset = "0x1576A38", VA = "0x1576A38")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1576D5C", Offset = "0x1576D5C", VA = "0x1576D5C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1576E04", Offset = "0x1576E04", VA = "0x1576E04", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15771F0", Offset = "0x15771F0", VA = "0x15771F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x157737C", Offset = "0x157737C", VA = "0x157737C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x15773B0", Offset = "0x15773B0", VA = "0x15773B0")]
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
			[Address(RVA = "0x1576BD8", Offset = "0x1576BD8", VA = "0x1576BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x15776A8", Offset = "0x15776A8", VA = "0x15776A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15770CC", Offset = "0x15770CC", VA = "0x15770CC")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15774D4", Offset = "0x15774D4", VA = "0x15774D4")]
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
			[Address(RVA = "0xE8D56C", Offset = "0xE8D56C", VA = "0xE8D56C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE8D5D8", Offset = "0xE8D5D8", VA = "0xE8D5D8")]
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
		[Address(RVA = "0xE8D5E0", Offset = "0xE8D5E0", VA = "0xE8D5E0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE8D6A0", Offset = "0xE8D6A0", VA = "0xE8D6A0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE8D6A8", Offset = "0xE8D6A8", VA = "0xE8D6A8")]
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
			[Address(RVA = "0xE8D7E4", Offset = "0xE8D7E4", VA = "0xE8D7E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE8D6DC", Offset = "0xE8D6DC", VA = "0xE8D6DC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE8D820", Offset = "0xE8D820", VA = "0xE8D820")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE8D828", Offset = "0xE8D828", VA = "0xE8D828")]
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
		[Address(RVA = "0xE8D85C", Offset = "0xE8D85C", VA = "0xE8D85C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE8D8DC", Offset = "0xE8D8DC", VA = "0xE8D8DC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE8D8E4", Offset = "0xE8D8E4", VA = "0xE8D8E4")]
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
			[Address(RVA = "0xE8DA20", Offset = "0xE8DA20", VA = "0xE8DA20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE8D918", Offset = "0xE8D918", VA = "0xE8D918", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE8DA5C", Offset = "0xE8DA5C", VA = "0xE8DA5C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE8DA64", Offset = "0xE8DA64", VA = "0xE8DA64")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683540", Offset = "0x683540")]
		public float positionWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683558", Offset = "0x683558")]
		public float rotationWeight;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE8DA98", Offset = "0xE8DA98", VA = "0xE8DA98")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE8DB04", Offset = "0xE8DB04", VA = "0xE8DB04")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE8DB5C", Offset = "0xE8DB5C", VA = "0xE8DB5C")]
		public void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE8DE0C", Offset = "0xE8DE0C", VA = "0xE8DE0C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683570", Offset = "0x683570")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683570", Offset = "0x683570")]
		public float weight;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6835C4", Offset = "0x6835C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6835C4", Offset = "0x6835C4")]
		public float rotationWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683618", Offset = "0x683618")]
		public DOF rotationDOF;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683650", Offset = "0x683650")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683688", Offset = "0x683688")]
		public Transform bone1;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6836C0", Offset = "0x6836C0")]
		public Transform bone2;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6836F8", Offset = "0x6836F8")]
		public Transform bone3;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683730", Offset = "0x683730")]
		public Transform tip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683768", Offset = "0x683768")]
		public Transform target;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6837A0", Offset = "0x6837A0")]
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
			[Address(RVA = "0x15A2ECC", Offset = "0x15A2ECC", VA = "0x15A2ECC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B370", Offset = "0x68B370")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x15A2ED4", Offset = "0x15A2ED4", VA = "0x15A2ED4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B380", Offset = "0x68B380")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x15A2EE0", Offset = "0x15A2EE0", VA = "0x15A2EE0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x15A2F00", Offset = "0x15A2F00", VA = "0x15A2F00")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x15A2F20", Offset = "0x15A2F20", VA = "0x15A2F20")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x15A2F40", Offset = "0x15A2F40", VA = "0x15A2F40")]
			set
			{
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x15A2F60", Offset = "0x15A2F60", VA = "0x15A2F60")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x15A3074", Offset = "0x15A3074", VA = "0x15A3074")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x15A3530", Offset = "0x15A3530", VA = "0x15A3530")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x15A3608", Offset = "0x15A3608", VA = "0x15A3608")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x15A36CC", Offset = "0x15A36CC", VA = "0x15A36CC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x15A3C18", Offset = "0x15A3C18", VA = "0x15A3C18")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6837B0", Offset = "0x6837B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6837B0", Offset = "0x6837B0")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683804", Offset = "0x683804")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x15A3C28", Offset = "0x15A3C28", VA = "0x15A3C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B390", Offset = "0x68B390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x15A3C30", Offset = "0x15A3C30", VA = "0x15A3C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B3A0", Offset = "0x68B3A0")]
			private set
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x15A3C3C", Offset = "0x15A3C3C", VA = "0x15A3C3C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x15A3CC4", Offset = "0x15A3CC4", VA = "0x15A3CC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B3B0", Offset = "0x68B3B0")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x15A4050", Offset = "0x15A4050", VA = "0x15A4050")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x15A4214", Offset = "0x15A4214", VA = "0x15A4214")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x15A3F4C", Offset = "0x15A3F4C", VA = "0x15A3F4C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x15A43A0", Offset = "0x15A43A0", VA = "0x15A43A0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x15A4460", Offset = "0x15A4460", VA = "0x15A4460")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x15A44D8", Offset = "0x15A44D8", VA = "0x15A44D8")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x15A454C", Offset = "0x15A454C", VA = "0x15A454C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x15A45B4", Offset = "0x15A45B4", VA = "0x15A45B4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x15A45B8", Offset = "0x15A45B8", VA = "0x15A45B8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x15A45CC", Offset = "0x15A45CC", VA = "0x15A45CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683814", Offset = "0x683814")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683814", Offset = "0x683814")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683868", Offset = "0x683868")]
		public Grounding solver;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6838A0", Offset = "0x6838A0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x15A5A90", Offset = "0x15A5A90", VA = "0x15A5A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B3E8", Offset = "0x68B3E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x15A5A98", Offset = "0x15A5A98", VA = "0x15A5A98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B3F8", Offset = "0x68B3F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x600015A")]
		public abstract void ResetPosition();

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x15A5AA4", Offset = "0x15A5AA4", VA = "0x15A5AA4")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x15A5C50", Offset = "0x15A5C50", VA = "0x15A5C50")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x15A5B50", Offset = "0x15A5B50", VA = "0x15A5B50")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x15A5C84", Offset = "0x15A5C84", VA = "0x15A5C84")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000162")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15A5DC0", Offset = "0x15A5DC0", VA = "0x15A5DC0")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681A40", Offset = "0x681A40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681A40", Offset = "0x681A40")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6838B0", Offset = "0x6838B0")]
		public BipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6838E8", Offset = "0x6838E8")]
		public float spineBend;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683920", Offset = "0x683920")]
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
		[Address(RVA = "0x15A5EDC", Offset = "0x15A5EDC", VA = "0x15A5EDC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B408", Offset = "0x68B408")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x15A5F24", Offset = "0x15A5F24", VA = "0x15A5F24", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B440", Offset = "0x68B440")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x15A5F6C", Offset = "0x15A5F6C", VA = "0x15A5F6C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x15A6034", Offset = "0x15A6034", VA = "0x15A6034")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x15A60E0", Offset = "0x15A60E0", VA = "0x15A60E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x15A6140", Offset = "0x15A6140", VA = "0x15A6140")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x15A672C", Offset = "0x15A672C", VA = "0x15A672C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x15A6780", Offset = "0x15A6780", VA = "0x15A6780")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x15A6DBC", Offset = "0x15A6DBC", VA = "0x15A6DBC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x15A6ED4", Offset = "0x15A6ED4", VA = "0x15A6ED4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x15A7014", Offset = "0x15A7014", VA = "0x15A7014")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x15A71D8", Offset = "0x15A71D8", VA = "0x15A71D8")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681AA0", Offset = "0x681AA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681AA0", Offset = "0x681AA0")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683A00", Offset = "0x683A00")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683A38", Offset = "0x683A38")]
			public float horizontalWeight;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683A70", Offset = "0x683A70")]
			public float verticalWeight;

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x128DC50", Offset = "0x128DC50", VA = "0x128DC50")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x128DC60", Offset = "0x128DC60", VA = "0x128DC60")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683958", Offset = "0x683958")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683990", Offset = "0x683990")]
		public float spineBend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6839C8", Offset = "0x6839C8")]
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
		[Address(RVA = "0x15A7628", Offset = "0x15A7628", VA = "0x15A7628")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B478", Offset = "0x68B478")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x15A7670", Offset = "0x15A7670", VA = "0x15A7670", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B4B0", Offset = "0x68B4B0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x15A76B8", Offset = "0x15A76B8", VA = "0x15A76B8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B4E8", Offset = "0x68B4E8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x15A7700", Offset = "0x15A7700", VA = "0x15A7700", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x15A773C", Offset = "0x15A773C", VA = "0x15A773C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x15A77D0", Offset = "0x15A77D0", VA = "0x15A77D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x15A7A88", Offset = "0x15A7A88", VA = "0x15A7A88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x15A7A94", Offset = "0x15A7A94", VA = "0x15A7A94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x15A7838", Offset = "0x15A7838", VA = "0x15A7838")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x15A7AA0", Offset = "0x15A7AA0", VA = "0x15A7AA0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x15A7DBC", Offset = "0x15A7DBC", VA = "0x15A7DBC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x15A7ECC", Offset = "0x15A7ECC", VA = "0x15A7ECC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x15A8048", Offset = "0x15A8048", VA = "0x15A8048")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x15A8180", Offset = "0x15A8180", VA = "0x15A8180")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681B00", Offset = "0x681B00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681B00", Offset = "0x681B00")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683AA8", Offset = "0x683AA8")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683AE0", Offset = "0x683AE0")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683B18", Offset = "0x683B18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683B18", Offset = "0x683B18")]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683B6C", Offset = "0x683B6C")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683BA4", Offset = "0x683BA4")]
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
		[Address(RVA = "0x15A8220", Offset = "0x15A8220", VA = "0x15A8220", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B520", Offset = "0x68B520")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x15A8268", Offset = "0x15A8268", VA = "0x15A8268", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B558", Offset = "0x68B558")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x15A82B0", Offset = "0x15A82B0", VA = "0x15A82B0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x15A82C8", Offset = "0x15A82C8", VA = "0x15A82C8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x15A84FC", Offset = "0x15A84FC", VA = "0x15A84FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x15A85F8", Offset = "0x15A85F8", VA = "0x15A85F8")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x15A8BA0", Offset = "0x15A8BA0", VA = "0x15A8BA0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x15A9004", Offset = "0x15A9004", VA = "0x15A9004")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x15A9190", Offset = "0x15A9190", VA = "0x15A9190")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x15A9494", Offset = "0x15A9494", VA = "0x15A9494")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x15A95E0", Offset = "0x15A95E0", VA = "0x15A95E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x15A97EC", Offset = "0x15A97EC", VA = "0x15A97EC")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681B60", Offset = "0x681B60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681B60", Offset = "0x681B60")]
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
			[Address(RVA = "0x128DCA8", Offset = "0x128DCA8", VA = "0x128DCA8")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683BDC", Offset = "0x683BDC")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683C14", Offset = "0x683C14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683C14", Offset = "0x683C14")]
		public float rootRotationWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683C68", Offset = "0x683C68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683C68", Offset = "0x683C68")]
		public float minRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683CC0", Offset = "0x683CC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683CC0", Offset = "0x683CC0")]
		public float maxRootRotation;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683D18", Offset = "0x683D18")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683D50", Offset = "0x683D50")]
		public float maxLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683D88", Offset = "0x683D88")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683DC0", Offset = "0x683DC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x683DC0", Offset = "0x683DC0")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683E14", Offset = "0x683E14")]
		public Transform characterRoot;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683E4C", Offset = "0x683E4C")]
		public Transform pelvis;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683E84", Offset = "0x683E84")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683EBC", Offset = "0x683EBC")]
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
		[Address(RVA = "0x15A988C", Offset = "0x15A988C", VA = "0x15A988C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B590", Offset = "0x68B590")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x15A98D4", Offset = "0x15A98D4", VA = "0x15A98D4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B5C8", Offset = "0x68B5C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x15A991C", Offset = "0x15A991C", VA = "0x15A991C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x15A9950", Offset = "0x15A9950", VA = "0x15A9950")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x15A9A7C", Offset = "0x15A9A7C", VA = "0x15A9A7C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x15A9C80", Offset = "0x15A9C80", VA = "0x15A9C80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x15A9CE8", Offset = "0x15A9CE8", VA = "0x15A9CE8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x15A9D4C", Offset = "0x15A9D4C", VA = "0x15A9D4C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x15AA0AC", Offset = "0x15AA0AC", VA = "0x15AA0AC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x15AA444", Offset = "0x15AA444", VA = "0x15AA444")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x15AA53C", Offset = "0x15AA53C", VA = "0x15AA53C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x15AA908", Offset = "0x15AA908", VA = "0x15AA908")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x15AAF24", Offset = "0x15AAF24", VA = "0x15AAF24")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x15AB0F4", Offset = "0x15AB0F4", VA = "0x15AB0F4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x15AB1D0", Offset = "0x15AB1D0", VA = "0x15AB1D0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x15AB418", Offset = "0x15AB418", VA = "0x15AB418")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x15AB450", Offset = "0x15AB450", VA = "0x15AB450")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x15AB654", Offset = "0x15AB654", VA = "0x15AB654")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681BC0", Offset = "0x681BC0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681BC0", Offset = "0x681BC0")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683F04", Offset = "0x683F04")]
		public VRIK ik;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x15AB76C", Offset = "0x15AB76C", VA = "0x15AB76C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B600", Offset = "0x68B600")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x15AB7B4", Offset = "0x15AB7B4", VA = "0x15AB7B4", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B638", Offset = "0x68B638")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x15AB7FC", Offset = "0x15AB7FC", VA = "0x15AB7FC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B670", Offset = "0x68B670")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x15AB844", Offset = "0x15AB844", VA = "0x15AB844", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x15AB85C", Offset = "0x15AB85C", VA = "0x15AB85C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x15AB8F0", Offset = "0x15AB8F0", VA = "0x15AB8F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x15AB950", Offset = "0x15AB950", VA = "0x15AB950")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x15ABBBC", Offset = "0x15ABBBC", VA = "0x15ABBBC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x15ABDAC", Offset = "0x15ABDAC", VA = "0x15ABDAC")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x15ABE3C", Offset = "0x15ABE3C", VA = "0x15ABE3C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x15ABFF8", Offset = "0x15ABFF8", VA = "0x15ABFF8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x15AC174", Offset = "0x15AC174", VA = "0x15AC174")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x15AC328", Offset = "0x15AC328", VA = "0x15AC328")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6843E8", Offset = "0x6843E8")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6843F8", Offset = "0x6843F8")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684408", Offset = "0x684408")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684418", Offset = "0x684418")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684428", Offset = "0x684428")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684438", Offset = "0x684438")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684448", Offset = "0x684448")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684458", Offset = "0x684458")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684468", Offset = "0x684468")]
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
				[Address(RVA = "0x128DD0C", Offset = "0x128DD0C", VA = "0x128DD0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B748", Offset = "0x68B748")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x128DD14", Offset = "0x128DD14", VA = "0x128DD14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B758", Offset = "0x68B758")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x128DD20", Offset = "0x128DD20", VA = "0x128DD20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B768", Offset = "0x68B768")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x128DD2C", Offset = "0x128DD2C", VA = "0x128DD2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B778", Offset = "0x68B778")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x128DD38", Offset = "0x128DD38", VA = "0x128DD38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B788", Offset = "0x68B788")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x128DD40", Offset = "0x128DD40", VA = "0x128DD40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B798", Offset = "0x68B798")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x128DD4C", Offset = "0x128DD4C", VA = "0x128DD4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B7A8", Offset = "0x68B7A8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x128DD54", Offset = "0x128DD54", VA = "0x128DD54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B7B8", Offset = "0x68B7B8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x128DD5C", Offset = "0x128DD5C", VA = "0x128DD5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B7C8", Offset = "0x68B7C8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x128DD68", Offset = "0x128DD68", VA = "0x128DD68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B7D8", Offset = "0x68B7D8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x128DD74", Offset = "0x128DD74", VA = "0x128DD74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B7E8", Offset = "0x68B7E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x128DD7C", Offset = "0x128DD7C", VA = "0x128DD7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B7F8", Offset = "0x68B7F8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x128DD84", Offset = "0x128DD84", VA = "0x128DD84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B808", Offset = "0x68B808")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x128DD8C", Offset = "0x128DD8C", VA = "0x128DD8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B818", Offset = "0x68B818")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x128DD94", Offset = "0x128DD94", VA = "0x128DD94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B828", Offset = "0x68B828")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x128DDAC", Offset = "0x128DDAC", VA = "0x128DDAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B838", Offset = "0x68B838")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x128DDCC", Offset = "0x128DDCC", VA = "0x128DDCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B848", Offset = "0x68B848")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x128DDE4", Offset = "0x128DDE4", VA = "0x128DDE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B858", Offset = "0x68B858")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x128DE04", Offset = "0x128DE04", VA = "0x128DE04")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x128EE1C", Offset = "0x128EE1C", VA = "0x128EE1C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x128EF80", Offset = "0x128EF80", VA = "0x128EF80")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x128DE4C", Offset = "0x128DE4C", VA = "0x128DE4C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x128DE60", Offset = "0x128DE60", VA = "0x128DE60")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x128DEF0", Offset = "0x128DEF0", VA = "0x128DEF0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x128DF3C", Offset = "0x128DF3C", VA = "0x128DF3C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x128DFAC", Offset = "0x128DFAC", VA = "0x128DFAC")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x128EA94", Offset = "0x128EA94", VA = "0x128EA94")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x128E634", Offset = "0x128E634", VA = "0x128E634")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x128EEB0", Offset = "0x128EEB0", VA = "0x128EEB0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x128E8D0", Offset = "0x128E8D0", VA = "0x128E8D0")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x128E95C", Offset = "0x128E95C", VA = "0x128E95C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x128EF20", Offset = "0x128EF20", VA = "0x128EF20")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x128EE44", Offset = "0x128EE44", VA = "0x128EE44")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x128F014", Offset = "0x128F014", VA = "0x128F014")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x128F0A0", Offset = "0x128F0A0", VA = "0x128F0A0")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684478", Offset = "0x684478")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684488", Offset = "0x684488")]
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
				[Address(RVA = "0x128F0E4", Offset = "0x128F0E4", VA = "0x128F0E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B868", Offset = "0x68B868")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x128F0F0", Offset = "0x128F0F0", VA = "0x128F0F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B878", Offset = "0x68B878")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x128F0FC", Offset = "0x128F0FC", VA = "0x128F0FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B888", Offset = "0x68B888")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x128F104", Offset = "0x128F104", VA = "0x128F104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B898", Offset = "0x68B898")]
				private set
				{
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x128F10C", Offset = "0x128F10C", VA = "0x128F10C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x128F19C", Offset = "0x128F19C", VA = "0x128F19C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x128F13C", Offset = "0x128F13C", VA = "0x128F13C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x128F208", Offset = "0x128F208", VA = "0x128F208")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x128F3A8", Offset = "0x128F3A8", VA = "0x128F3A8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683F3C", Offset = "0x683F3C")]
		public LayerMask layers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683F74", Offset = "0x683F74")]
		public float maxStep;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683FAC", Offset = "0x683FAC")]
		public float heightOffset;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x683FE4", Offset = "0x683FE4")]
		public float footSpeed;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68401C", Offset = "0x68401C")]
		public float footRadius;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684054", Offset = "0x684054")]
		public float footCenterOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6840A0", Offset = "0x6840A0")]
		public float prediction;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6840D8", Offset = "0x6840D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6840D8", Offset = "0x6840D8")]
		public float footRotationWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68412C", Offset = "0x68412C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684164", Offset = "0x684164")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684164", Offset = "0x684164")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6841BC", Offset = "0x6841BC")]
		public bool rotateSolver;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6841F4", Offset = "0x6841F4")]
		public float pelvisSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68422C", Offset = "0x68422C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68422C", Offset = "0x68422C")]
		public float pelvisDamper;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684280", Offset = "0x684280")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6842B8", Offset = "0x6842B8")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6842F0", Offset = "0x6842F0")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684328", Offset = "0x684328")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684360", Offset = "0x684360")]
		public Quality quality;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684398", Offset = "0x684398")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6843A8", Offset = "0x6843A8")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6843B8", Offset = "0x6843B8")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6843C8", Offset = "0x6843C8")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6843D8", Offset = "0x6843D8")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x15AC38C", Offset = "0x15AC38C", VA = "0x15AC38C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B6A8", Offset = "0x68B6A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x15AC394", Offset = "0x15AC394", VA = "0x15AC394")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B6B8", Offset = "0x68B6B8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x15AC39C", Offset = "0x15AC39C", VA = "0x15AC39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B6C8", Offset = "0x68B6C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x15AC3A4", Offset = "0x15AC3A4", VA = "0x15AC3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B6D8", Offset = "0x68B6D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x15AC3AC", Offset = "0x15AC3AC", VA = "0x15AC3AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B6E8", Offset = "0x68B6E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x15AC3B4", Offset = "0x15AC3B4", VA = "0x15AC3B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B6F8", Offset = "0x68B6F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x15AC3C0", Offset = "0x15AC3C0", VA = "0x15AC3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B708", Offset = "0x68B708")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x15AC3C8", Offset = "0x15AC3C8", VA = "0x15AC3C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B718", Offset = "0x68B718")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x15AC3D0", Offset = "0x15AC3D0", VA = "0x15AC3D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B728", Offset = "0x68B728")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x15AC3E8", Offset = "0x15AC3E8", VA = "0x15AC3E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B738", Offset = "0x68B738")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x15AC408", Offset = "0x15AC408", VA = "0x15AC408")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x15A6E90", Offset = "0x15A6E90", VA = "0x15A6E90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x15AC7D4", Offset = "0x15AC7D4", VA = "0x15AC7D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x15AC45C", Offset = "0x15AC45C", VA = "0x15AC45C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x15AC6A8", Offset = "0x15AC6A8", VA = "0x15AC6A8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x15A645C", Offset = "0x15A645C", VA = "0x15A645C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x15A6B74", Offset = "0x15A6B74", VA = "0x15A6B74")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x15A8A40", Offset = "0x15A8A40", VA = "0x15A8A40")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x15A5FA8", Offset = "0x15A5FA8", VA = "0x15A5FA8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x15AC7BC", Offset = "0x15AC7BC", VA = "0x15AC7BC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x15AC854", Offset = "0x15AC854", VA = "0x15AC854")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x15AC8E4", Offset = "0x15AC8E4", VA = "0x15AC8E4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x15AC9A0", Offset = "0x15AC9A0", VA = "0x15AC9A0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x15A5E88", Offset = "0x15A5E88", VA = "0x15A5E88")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681C20", Offset = "0x681C20")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681C20", Offset = "0x681C20")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1570B5C", Offset = "0x1570B5C", VA = "0x1570B5C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B8A8", Offset = "0x68B8A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1570BA4", Offset = "0x1570BA4", VA = "0x1570BA4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B8E0", Offset = "0x68B8E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1570BEC", Offset = "0x1570BEC", VA = "0x1570BEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B918", Offset = "0x68B918")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1570C34", Offset = "0x1570C34", VA = "0x1570C34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B950", Offset = "0x68B950")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1570C7C", Offset = "0x1570C7C", VA = "0x1570C7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B988", Offset = "0x68B988")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1570CC4", Offset = "0x1570CC4", VA = "0x1570CC4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1570CCC", Offset = "0x1570CCC", VA = "0x1570CCC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681C80", Offset = "0x681C80")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681C80", Offset = "0x681C80")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1572640", Offset = "0x1572640", VA = "0x1572640", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B9C0", Offset = "0x68B9C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1572688", Offset = "0x1572688", VA = "0x1572688", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68B9F8", Offset = "0x68B9F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x15726D0", Offset = "0x15726D0", VA = "0x15726D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BA30", Offset = "0x68BA30")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1572718", Offset = "0x1572718", VA = "0x1572718")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BA68", Offset = "0x68BA68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1572760", Offset = "0x1572760", VA = "0x1572760", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1572768", Offset = "0x1572768", VA = "0x1572768")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681CE0", Offset = "0x681CE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681CE0", Offset = "0x681CE0")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x157F468", Offset = "0x157F468", VA = "0x157F468", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BAA0", Offset = "0x68BAA0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x157F4B0", Offset = "0x157F4B0", VA = "0x157F4B0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BAD8", Offset = "0x68BAD8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x157F4F8", Offset = "0x157F4F8", VA = "0x157F4F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BB10", Offset = "0x68BB10")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x157F540", Offset = "0x157F540", VA = "0x157F540")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BB48", Offset = "0x68BB48")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x157F588", Offset = "0x157F588", VA = "0x157F588", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x157F590", Offset = "0x157F590", VA = "0x157F590")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681D40", Offset = "0x681D40")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681D40", Offset = "0x681D40")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE9BE74", Offset = "0xE9BE74", VA = "0xE9BE74", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BB80", Offset = "0x68BB80")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE9BEBC", Offset = "0xE9BEBC", VA = "0xE9BEBC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BBB8", Offset = "0x68BBB8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE9BF04", Offset = "0xE9BF04", VA = "0xE9BF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BBF0", Offset = "0x68BBF0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE9BF4C", Offset = "0xE9BF4C", VA = "0xE9BF4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BC28", Offset = "0x68BC28")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE9BF94", Offset = "0xE9BF94", VA = "0xE9BF94", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE9BF9C", Offset = "0xE9BF9C", VA = "0xE9BF9C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681DA0", Offset = "0x681DA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681DA0", Offset = "0x681DA0")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE9C4E4", Offset = "0xE9C4E4", VA = "0xE9C4E4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BC60", Offset = "0x68BC60")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE9C52C", Offset = "0xE9C52C", VA = "0xE9C52C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BC98", Offset = "0x68BC98")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE9C574", Offset = "0xE9C574", VA = "0xE9C574")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BCD0", Offset = "0x68BCD0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE9C5BC", Offset = "0xE9C5BC", VA = "0xE9C5BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BD08", Offset = "0x68BD08")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE9C604", Offset = "0xE9C604", VA = "0xE9C604", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE9C60C", Offset = "0xE9C60C", VA = "0xE9C60C")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681E00", Offset = "0x681E00")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681E00", Offset = "0x681E00")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x15A463C", Offset = "0x15A463C", VA = "0x15A463C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BD40", Offset = "0x68BD40")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x15A4684", Offset = "0x15A4684", VA = "0x15A4684", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BD78", Offset = "0x68BD78")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x15A46CC", Offset = "0x15A46CC", VA = "0x15A46CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BDB0", Offset = "0x68BDB0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x15A4714", Offset = "0x15A4714", VA = "0x15A4714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BDE8", Offset = "0x68BDE8")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x15A475C", Offset = "0x15A475C", VA = "0x15A475C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BE20", Offset = "0x68BE20")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x15A47A4", Offset = "0x15A47A4", VA = "0x15A47A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BE58", Offset = "0x68BE58")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x15A47EC", Offset = "0x15A47EC", VA = "0x15A47EC")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x15A4830", Offset = "0x15A4830", VA = "0x15A4830", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x15A4838", Offset = "0x15A4838", VA = "0x15A4838")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x15A4A20", Offset = "0x15A4A20", VA = "0x15A4A20")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x15A4CC0", Offset = "0x15A4CC0", VA = "0x15A4CC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BE90", Offset = "0x68BE90")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x15A4CE0", Offset = "0x15A4CE0", VA = "0x15A4CE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BEC8", Offset = "0x68BEC8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x15A4DD0", Offset = "0x15A4DD0", VA = "0x15A4DD0")]
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
		[Address(RVA = "0x15AFFF0", Offset = "0x15AFFF0", VA = "0x15AFFF0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x15B0078", Offset = "0x15B0078", VA = "0x15B0078", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x15B00EC", Offset = "0x15B00EC", VA = "0x15B00EC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000225")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x15A4E78", Offset = "0x15A4E78", VA = "0x15A4E78")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684498", Offset = "0x684498")]
		public IK[] IKComponents;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6844D0", Offset = "0x6844D0")]
		public Animator animator;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x15B2778", Offset = "0x15B2778", VA = "0x15B2778")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x15B2810", Offset = "0x15B2810", VA = "0x15B2810")]
		private void Start()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x15B2880", Offset = "0x15B2880", VA = "0x15B2880")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x15B293C", Offset = "0x15B293C", VA = "0x15B293C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x15B2978", Offset = "0x15B2978", VA = "0x15B2978")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x15B28B4", Offset = "0x15B28B4", VA = "0x15B28B4")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x15B2A08", Offset = "0x15B2A08", VA = "0x15B2A08")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681E60", Offset = "0x681E60")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681E60", Offset = "0x681E60")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1613DB0", Offset = "0x1613DB0", VA = "0x1613DB0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BF00", Offset = "0x68BF00")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1613DF8", Offset = "0x1613DF8", VA = "0x1613DF8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BF38", Offset = "0x68BF38")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1613E40", Offset = "0x1613E40", VA = "0x1613E40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BF70", Offset = "0x68BF70")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1613E88", Offset = "0x1613E88", VA = "0x1613E88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BFA8", Offset = "0x68BFA8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1613ED0", Offset = "0x1613ED0", VA = "0x1613ED0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1613ED8", Offset = "0x1613ED8", VA = "0x1613ED8")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681EC0", Offset = "0x681EC0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681EC0", Offset = "0x681EC0")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1613F48", Offset = "0x1613F48", VA = "0x1613F48", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68BFE0", Offset = "0x68BFE0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1613F90", Offset = "0x1613F90", VA = "0x1613F90", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C018", Offset = "0x68C018")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1613FD8", Offset = "0x1613FD8", VA = "0x1613FD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C050", Offset = "0x68C050")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1614020", Offset = "0x1614020", VA = "0x1614020")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C088", Offset = "0x68C088")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1614068", Offset = "0x1614068", VA = "0x1614068", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1614070", Offset = "0x1614070", VA = "0x1614070")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681F20", Offset = "0x681F20")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681F20", Offset = "0x681F20")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1614A6C", Offset = "0x1614A6C", VA = "0x1614A6C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C0C0", Offset = "0x68C0C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1614AB4", Offset = "0x1614AB4", VA = "0x1614AB4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C0F8", Offset = "0x68C0F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x1614AFC", Offset = "0x1614AFC", VA = "0x1614AFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C130", Offset = "0x68C130")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1614B44", Offset = "0x1614B44", VA = "0x1614B44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C168", Offset = "0x68C168")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1614B8C", Offset = "0x1614B8C", VA = "0x1614B8C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1614B94", Offset = "0x1614B94", VA = "0x1614B94")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681F80", Offset = "0x681F80")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x681F80", Offset = "0x681F80")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x144A640", Offset = "0x144A640", VA = "0x144A640", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C1A0", Offset = "0x68C1A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x144A688", Offset = "0x144A688", VA = "0x144A688", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C1D8", Offset = "0x68C1D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x144A6D0", Offset = "0x144A6D0", VA = "0x144A6D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C210", Offset = "0x68C210")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x144A718", Offset = "0x144A718", VA = "0x144A718")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C248", Offset = "0x68C248")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x144A760", Offset = "0x144A760", VA = "0x144A760", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x144A768", Offset = "0x144A768", VA = "0x144A768")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x681FE0", Offset = "0x681FE0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6845B4", Offset = "0x6845B4")]
			public Transform chest;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6845EC", Offset = "0x6845EC")]
			public Transform neck;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684624", Offset = "0x684624")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68465C", Offset = "0x68465C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684694", Offset = "0x684694")]
			public Transform leftThigh;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6846CC", Offset = "0x6846CC")]
			public Transform leftCalf;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684704", Offset = "0x684704")]
			public Transform leftFoot;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68473C", Offset = "0x68473C")]
			public Transform leftToes;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684774", Offset = "0x684774")]
			public Transform rightThigh;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6847AC", Offset = "0x6847AC")]
			public Transform rightCalf;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6847E4", Offset = "0x6847E4")]
			public Transform rightFoot;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68481C", Offset = "0x68481C")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x17ED028", Offset = "0x17ED028", VA = "0x17ED028")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x17ED4A0", Offset = "0x17ED4A0", VA = "0x17ED4A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x17ECAD8", Offset = "0x17ECAD8", VA = "0x17ECAD8")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x17ED918", Offset = "0x17ED918", VA = "0x17ED918")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x17EDDC4", Offset = "0x17EDDC4", VA = "0x17EDDC4")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684508", Offset = "0x684508")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x684508", Offset = "0x684508")]
		public References references;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68457C", Offset = "0x68457C")]
		public IKSolverVR solver;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x144C9D0", Offset = "0x144C9D0", VA = "0x144C9D0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C280", Offset = "0x68C280")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x144CA18", Offset = "0x144CA18", VA = "0x144CA18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C2B8", Offset = "0x68C2B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x144CA60", Offset = "0x144CA60", VA = "0x144CA60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C2F0", Offset = "0x68C2F0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x144CAA8", Offset = "0x144CAA8", VA = "0x144CAA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C328", Offset = "0x68C328")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x144CAD4", Offset = "0x144CAD4", VA = "0x144CAD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C360", Offset = "0x68C360")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x144CAFC", Offset = "0x144CAFC", VA = "0x144CAFC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x144CB04", Offset = "0x144CB04", VA = "0x144CB04", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x144CB84", Offset = "0x144CB84", VA = "0x144CB84", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x144CCF0", Offset = "0x144CCF0", VA = "0x144CCF0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684854", Offset = "0x684854")]
		public float pull;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68486C", Offset = "0x68486C")]
		public float pin;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE9C00C", Offset = "0xE9C00C", VA = "0xE9C00C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE9C0E8", Offset = "0xE9C0E8", VA = "0xE9C0E8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE9C108", Offset = "0xE9C108", VA = "0xE9C108")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE9C37C", Offset = "0xE9C37C", VA = "0xE9C37C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE9C1DC", Offset = "0xE9C1DC", VA = "0xE9C1DC")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE9C474", Offset = "0xE9C474", VA = "0xE9C474")]
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
		[Address(RVA = "0xE9C67C", Offset = "0xE9C67C", VA = "0xE9C67C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE9CAF4", Offset = "0xE9CAF4", VA = "0xE9CAF4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE9CCB0", Offset = "0xE9CCB0", VA = "0xE9CCB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE9CDE0", Offset = "0xE9CDE0", VA = "0xE9CDE0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684EC4", Offset = "0x684EC4")]
			public Transform transform;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684EFC", Offset = "0x684EFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684EFC", Offset = "0x684EFC")]
			public float weight;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x128D024", Offset = "0x128D024", VA = "0x128D024")]
			public BendBone()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x128D060", Offset = "0x128D060", VA = "0x128D060")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x128D0C4", Offset = "0x128D0C4", VA = "0x128D0C4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x128D0FC", Offset = "0x128D0FC", VA = "0x128D0FC")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684884", Offset = "0x684884")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6848BC", Offset = "0x6848BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6848BC", Offset = "0x6848BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6848BC", Offset = "0x6848BC")]
		public float positionWeight;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684934", Offset = "0x684934")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684934", Offset = "0x684934")]
		public float bodyWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684988", Offset = "0x684988")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684988", Offset = "0x684988")]
		public float thighWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6849DC", Offset = "0x6849DC")]
		public bool handsPullBody;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x684A14", Offset = "0x684A14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684A14", Offset = "0x684A14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684A14", Offset = "0x684A14")]
		public float rotationWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684A8C", Offset = "0x684A8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684A8C", Offset = "0x684A8C")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684AE0", Offset = "0x684AE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684AE0", Offset = "0x684AE0")]
		public float headClampWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684B34", Offset = "0x684B34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684B34", Offset = "0x684B34")]
		public float bendWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684B88", Offset = "0x684B88")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684BC0", Offset = "0x684BC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684BC0", Offset = "0x684BC0")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x684BC0", Offset = "0x684BC0")]
		public float CCDWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684C38", Offset = "0x684C38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684C38", Offset = "0x684C38")]
		public float roll;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684C8C", Offset = "0x684C8C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684C8C", Offset = "0x684C8C")]
		public float damper;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684CE4", Offset = "0x684CE4")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684D1C", Offset = "0x684D1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684D1C", Offset = "0x684D1C")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x684D1C", Offset = "0x684D1C")]
		public float postStretchWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684D94", Offset = "0x684D94")]
		public float maxStretch;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684DCC", Offset = "0x684DCC")]
		public float stretchDamper;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684E04", Offset = "0x684E04")]
		public bool fixHead;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x684E3C", Offset = "0x684E3C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x684E74", Offset = "0x684E74")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684EAC", Offset = "0x684EAC")]
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
		[Address(RVA = "0xE9CDE8", Offset = "0xE9CDE8", VA = "0xE9CDE8")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE9D170", Offset = "0xE9D170", VA = "0xE9D170")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE9D64C", Offset = "0xE9D64C", VA = "0xE9D64C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE9DA18", Offset = "0xE9DA18", VA = "0xE9DA18")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE9E1A4", Offset = "0xE9E1A4", VA = "0xE9E1A4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE9E484", Offset = "0xE9E484", VA = "0xE9E484")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE9E788", Offset = "0xE9E788", VA = "0xE9E788")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE9EF5C", Offset = "0xE9EF5C", VA = "0xE9EF5C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE9DF88", Offset = "0xE9DF88", VA = "0xE9DF88")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE9F124", Offset = "0xE9F124", VA = "0xE9F124")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE9EE74", Offset = "0xE9EE74", VA = "0xE9EE74")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE9EDA8", Offset = "0xE9EDA8", VA = "0xE9EDA8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE9F3A8", Offset = "0xE9F3A8", VA = "0xE9F3A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE9F6DC", Offset = "0xE9F6DC", VA = "0xE9F6DC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684FE8", Offset = "0x684FE8")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x684FF8", Offset = "0x684FF8")]
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
				[Address(RVA = "0x128D1B8", Offset = "0x128D1B8", VA = "0x128D1B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C398", Offset = "0x68C398")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x128D1C0", Offset = "0x128D1C0", VA = "0x128D1C0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C3A8", Offset = "0x68C3A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x128D1C8", Offset = "0x128D1C8", VA = "0x128D1C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C3B8", Offset = "0x68C3B8")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x128D1D0", Offset = "0x128D1D0", VA = "0x128D1D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C3C8", Offset = "0x68C3C8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x128D1DC", Offset = "0x128D1DC", VA = "0x128D1DC")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x128D244", Offset = "0x128D244", VA = "0x128D244")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x128D29C", Offset = "0x128D29C", VA = "0x128D29C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x128D440", Offset = "0x128D440", VA = "0x128D440")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684F50", Offset = "0x684F50")]
		public float pin;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684F68", Offset = "0x684F68")]
		public float pull;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684F80", Offset = "0x684F80")]
		public float push;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684F98", Offset = "0x684F98")]
		public float pushParent;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x684FB0", Offset = "0x684FB0")]
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
		[Address(RVA = "0xE9FE38", Offset = "0xE9FE38", VA = "0xE9FE38")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE9FF54", Offset = "0xE9FF54", VA = "0xE9FF54")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xEA00C4", Offset = "0xEA00C4", VA = "0xEA00C4")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xEA0200", Offset = "0xEA0200", VA = "0xEA0200")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xEA02D8", Offset = "0xEA02D8", VA = "0xEA02D8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xEA03FC", Offset = "0xEA03FC", VA = "0xEA03FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xEA0ACC", Offset = "0xEA0ACC", VA = "0xEA0ACC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xEA0598", Offset = "0xEA0598", VA = "0xEA0598")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xEA0EBC", Offset = "0xEA0EBC", VA = "0xEA0EBC")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xEA111C", Offset = "0xEA111C", VA = "0xEA111C")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xEA1388", Offset = "0xEA1388", VA = "0xEA1388")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xEA172C", Offset = "0xEA172C", VA = "0xEA172C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xEA1BC0", Offset = "0xEA1BC0", VA = "0xEA1BC0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xEA1DE4", Offset = "0xEA1DE4", VA = "0xEA1DE4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xEA1B50", Offset = "0xEA1B50", VA = "0xEA1B50")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xEA15B8", Offset = "0xEA15B8", VA = "0xEA15B8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xEA1AD4", Offset = "0xEA1AD4", VA = "0xEA1AD4")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xEA1ECC", Offset = "0xEA1ECC", VA = "0xEA1ECC")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xEA19F4", Offset = "0xEA19F4", VA = "0xEA19F4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xEA1CCC", Offset = "0xEA1CCC", VA = "0xEA1CCC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685008", Offset = "0x685008")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685020", Offset = "0x685020")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x15B0334", Offset = "0x15B0334", VA = "0x15B0334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C3D8", Offset = "0x68C3D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x15B033C", Offset = "0x15B033C", VA = "0x15B033C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C3E8", Offset = "0x68C3E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x15B014C", Offset = "0x15B014C", VA = "0x15B014C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x15B0348", Offset = "0x15B0348", VA = "0x15B0348")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x15B0388", Offset = "0x15B0388", VA = "0x15B0388")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x15B03F0", Offset = "0x15B03F0", VA = "0x15B03F0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x15B0440", Offset = "0x15B0440", VA = "0x15B0440")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x15B0754", Offset = "0x15B0754", VA = "0x15B0754")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x15B0944", Offset = "0x15B0944", VA = "0x15B0944")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x15B0C90", Offset = "0x15B0C90", VA = "0x15B0C90")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x15B0604", Offset = "0x15B0604", VA = "0x15B0604")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x15B06AC", Offset = "0x15B06AC", VA = "0x15B06AC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685030", Offset = "0x685030")]
		public float positionWeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685048", Offset = "0x685048")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685060", Offset = "0x685060")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685070", Offset = "0x685070")]
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
			[Address(RVA = "0x15B112C", Offset = "0x15B112C", VA = "0x15B112C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C3F8", Offset = "0x68C3F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x15B1134", Offset = "0x15B1134", VA = "0x15B1134")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C408", Offset = "0x68C408")]
			private set
			{
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x15B10C4", Offset = "0x15B10C4", VA = "0x15B10C4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x15B1140", Offset = "0x15B1140", VA = "0x15B1140")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x15B11D0", Offset = "0x15B11D0", VA = "0x15B11D0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x15B1314", Offset = "0x15B1314", VA = "0x15B1314")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x15B1494", Offset = "0x15B1494", VA = "0x15B1494")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x15B17BC", Offset = "0x15B17BC", VA = "0x15B17BC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x15B1A88", Offset = "0x15B1A88", VA = "0x15B1A88")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x15B1B5C", Offset = "0x15B1B5C", VA = "0x15B1B5C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x15B1C04", Offset = "0x15B1C04", VA = "0x15B1C04")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x15B2140", Offset = "0x15B2140", VA = "0x15B2140")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x15B216C", Offset = "0x15B216C", VA = "0x15B216C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x15B22CC", Offset = "0x15B22CC", VA = "0x15B22CC")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x15B2558", Offset = "0x15B2558", VA = "0x15B2558")]
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
				[Address(RVA = "0x129074C", Offset = "0x129074C", VA = "0x129074C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x1290828", Offset = "0x1290828", VA = "0x1290828")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x1290BF8", Offset = "0x1290BF8", VA = "0x1290BF8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x12906FC", Offset = "0x12906FC", VA = "0x12906FC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x1290788", Offset = "0x1290788", VA = "0x1290788")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x12907D8", Offset = "0x12907D8", VA = "0x12907D8")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1290838", Offset = "0x1290838", VA = "0x1290838")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x12908C0", Offset = "0x12908C0", VA = "0x12908C0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x12908C8", Offset = "0x12908C8", VA = "0x12908C8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x12909A0", Offset = "0x12909A0", VA = "0x12909A0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1290A18", Offset = "0x1290A18", VA = "0x1290A18")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1290ADC", Offset = "0x1290ADC", VA = "0x1290ADC")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x1290D38", Offset = "0x1290D38", VA = "0x1290D38")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x1290D70", Offset = "0x1290D70", VA = "0x1290D70")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x1290DA8", Offset = "0x1290DA8", VA = "0x1290DA8")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1290DD0", Offset = "0x1290DD0", VA = "0x1290DD0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x1290EBC", Offset = "0x1290EBC", VA = "0x1290EBC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1291048", Offset = "0x1291048", VA = "0x1291048")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1291078", Offset = "0x1291078", VA = "0x1291078")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1291140", Offset = "0x1291140", VA = "0x1291140")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x12911B0", Offset = "0x12911B0", VA = "0x12911B0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1291300", Offset = "0x1291300", VA = "0x1291300")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1291450", Offset = "0x1291450", VA = "0x1291450")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x12914D0", Offset = "0x12914D0", VA = "0x12914D0")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1290F38", Offset = "0x1290F38", VA = "0x1290F38")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1291608", Offset = "0x1291608", VA = "0x1291608")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x15B2A10", Offset = "0x15B2A10", VA = "0x15B2A10", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x15B2A18", Offset = "0x15B2A18", VA = "0x15B2A18", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x15B2A1C", Offset = "0x15B2A1C", VA = "0x15B2A1C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x15B2B6C", Offset = "0x15B2B6C", VA = "0x15B2B6C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x15B2BDC", Offset = "0x15B2BDC", VA = "0x15B2BDC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685088", Offset = "0x685088")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x15B2BE4", Offset = "0x15B2BE4", VA = "0x15B2BE4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x15B2C98", Offset = "0x15B2C98", VA = "0x15B2C98")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x15B2D10", Offset = "0x15B2D10", VA = "0x15B2D10")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x15B2DA4", Offset = "0x15B2DA4", VA = "0x15B2DA4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x15B2DC0", Offset = "0x15B2DC0", VA = "0x15B2DC0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x15B2DE0", Offset = "0x15B2DE0", VA = "0x15B2DE0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x15B2E78", Offset = "0x15B2E78", VA = "0x15B2E78")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x15B2E94", Offset = "0x15B2E94", VA = "0x15B2E94")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6850A0", Offset = "0x6850A0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6850B8", Offset = "0x6850B8")]
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
		[Address(RVA = "0x15B2EBC", Offset = "0x15B2EBC", VA = "0x15B2EBC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x15B2F40", Offset = "0x15B2F40", VA = "0x15B2F40")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x15B301C", Offset = "0x15B301C", VA = "0x15B301C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x15B3240", Offset = "0x15B3240", VA = "0x15B3240")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x15B3334", Offset = "0x15B3334", VA = "0x15B3334")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x15B3460", Offset = "0x15B3460", VA = "0x15B3460")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x15B34C4", Offset = "0x15B34C4", VA = "0x15B34C4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x15B3578", Offset = "0x15B3578", VA = "0x15B3578")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x15B363C", Offset = "0x15B363C", VA = "0x15B363C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x15B38D4", Offset = "0x15B38D4", VA = "0x15B38D4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x15B3948", Offset = "0x15B3948", VA = "0x15B3948")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6850D0", Offset = "0x6850D0")]
		public int iterations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6850E8", Offset = "0x6850E8")]
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
		[Address(RVA = "0x15B3AC8", Offset = "0x15B3AC8", VA = "0x15B3AC8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x15B3E34", Offset = "0x15B3E34", VA = "0x15B3E34")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x15B3F54", Offset = "0x15B3F54", VA = "0x15B3F54")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x15B40B4", Offset = "0x15B40B4", VA = "0x15B40B4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x15B4134", Offset = "0x15B4134", VA = "0x15B4134")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x15B41A0", Offset = "0x15B41A0", VA = "0x15B41A0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x15B4224", Offset = "0x15B4224", VA = "0x15B4224", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x15B4868", Offset = "0x15B4868", VA = "0x15B4868")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x15B48A0", Offset = "0x15B48A0", VA = "0x15B48A0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x15B4B24", Offset = "0x15B4B24", VA = "0x15B4B24")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x15B4E2C", Offset = "0x15B4E2C", VA = "0x15B4E2C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x15B4F18", Offset = "0x15B4F18", VA = "0x15B4F18")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x15B4FE0", Offset = "0x15B4FE0", VA = "0x15B4FE0")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6851AC", Offset = "0x6851AC")]
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
			[Address(RVA = "0x1292154", Offset = "0x1292154", VA = "0x1292154")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x12921A4", Offset = "0x12921A4", VA = "0x12921A4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x1292244", Offset = "0x1292244", VA = "0x1292244")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x129227C", Offset = "0x129227C", VA = "0x129227C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x12922B4", Offset = "0x12922B4", VA = "0x12922B4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x1292304", Offset = "0x1292304", VA = "0x1292304")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1291D08", Offset = "0x1291D08", VA = "0x1291D08")]
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
				[Address(RVA = "0x1291624", Offset = "0x1291624", VA = "0x1291624")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x1291728", Offset = "0x1291728", VA = "0x1291728")]
				set
				{
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x12917B8", Offset = "0x12917B8", VA = "0x12917B8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1291968", Offset = "0x1291968", VA = "0x1291968")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1291B3C", Offset = "0x1291B3C", VA = "0x1291B3C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1291C9C", Offset = "0x1291C9C", VA = "0x1291C9C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1291CC4", Offset = "0x1291CC4", VA = "0x1291CC4")]
			public Bone()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1291D44", Offset = "0x1291D44", VA = "0x1291D44")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1291D9C", Offset = "0x1291D9C", VA = "0x1291D9C")]
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
			[Address(RVA = "0x12920DC", Offset = "0x12920DC", VA = "0x12920DC")]
			public Node()
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x12920E0", Offset = "0x12920E0", VA = "0x12920E0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1292110", Offset = "0x1292110", VA = "0x1292110")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685110", Offset = "0x685110")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685110", Offset = "0x685110")]
		public float IKPositionWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685164", Offset = "0x685164")]
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
			[Address(RVA = "0x17C002C", Offset = "0x17C002C", VA = "0x17C002C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C418", Offset = "0x68C418")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x17C0034", Offset = "0x17C0034", VA = "0x17C0034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C428", Offset = "0x68C428")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x17BFD6C", Offset = "0x17BFD6C", VA = "0x17BFD6C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x17BFDE4", Offset = "0x17BFDE4", VA = "0x17BFDE4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x17BFF64", Offset = "0x17BFF64", VA = "0x17BFF64")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x17BFFD4", Offset = "0x17BFFD4", VA = "0x17BFFD4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x17BFFE0", Offset = "0x17BFFE0", VA = "0x17BFFE0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x17BFFEC", Offset = "0x17BFFEC", VA = "0x17BFFEC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17BFFF4", Offset = "0x17BFFF4", VA = "0x17BFFF4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17C0024", Offset = "0x17C0024", VA = "0x17C0024")]
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
		[Address(RVA = "0x17C0040", Offset = "0x17C0040", VA = "0x17C0040")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x17C0058", Offset = "0x17C0058", VA = "0x17C0058")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x17C0190", Offset = "0x17C0190", VA = "0x17C0190")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x17C023C", Offset = "0x17C023C", VA = "0x17C023C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x17C04C4", Offset = "0x17C04C4", VA = "0x17C04C4")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6851C4", Offset = "0x6851C4")]
		public float poleWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6851DC", Offset = "0x6851DC")]
		public float clampWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6851F4", Offset = "0x6851F4")]
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
			[Address(RVA = "0x17C0558", Offset = "0x17C0558", VA = "0x17C0558")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x17C0594", Offset = "0x17C0594", VA = "0x17C0594")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x17C1044", Offset = "0x17C1044", VA = "0x17C1044", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x17C1428", Offset = "0x17C1428", VA = "0x17C1428", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x17C04DC", Offset = "0x17C04DC", VA = "0x17C04DC")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x17C05D0", Offset = "0x17C05D0", VA = "0x17C05D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x17C07F0", Offset = "0x17C07F0", VA = "0x17C07F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x17C0F90", Offset = "0x17C0F90", VA = "0x17C0F90")]
		private void Solve()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x17C0D20", Offset = "0x17C0D20", VA = "0x17C0D20")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x17C104C", Offset = "0x17C104C", VA = "0x17C104C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x17C149C", Offset = "0x17C149C", VA = "0x17C149C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68520C", Offset = "0x68520C")]
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
		[Address(RVA = "0x17C1570", Offset = "0x17C1570", VA = "0x17C1570", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x17C1958", Offset = "0x17C1958", VA = "0x17C1958")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x17C1A0C", Offset = "0x17C1A0C", VA = "0x17C1A0C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x17C1BA0", Offset = "0x17C1BA0", VA = "0x17C1BA0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x17C1D34", Offset = "0x17C1D34", VA = "0x17C1D34", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x17C1D90", Offset = "0x17C1D90", VA = "0x17C1D90", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x17C1E00", Offset = "0x17C1E00", VA = "0x17C1E00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x17C2170", Offset = "0x17C2170", VA = "0x17C2170", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x17C219C", Offset = "0x17C219C", VA = "0x17C219C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x17C1E64", Offset = "0x17C1E64", VA = "0x17C1E64")]
		private void Read()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x17C2208", Offset = "0x17C2208", VA = "0x17C2208")]
		private void Write()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x17C2394", Offset = "0x17C2394", VA = "0x17C2394")]
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
		[Address(RVA = "0x17C2558", Offset = "0x17C2558", VA = "0x17C2558")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x17C2608", Offset = "0x17C2608", VA = "0x17C2608", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x17C2B00", Offset = "0x17C2B00", VA = "0x17C2B00", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x17C30F8", Offset = "0x17C30F8", VA = "0x17C30F8")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x17C36D4", Offset = "0x17C36D4", VA = "0x17C36D4")]
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
			[Address(RVA = "0x17C4624", Offset = "0x17C4624", VA = "0x17C4624", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x17C36D8", Offset = "0x17C36D8", VA = "0x17C36D8")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x17C3C9C", Offset = "0x17C3C9C", VA = "0x17C3C9C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x17C3DDC", Offset = "0x17C3DDC", VA = "0x17C3DDC", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x17C3E70", Offset = "0x17C3E70", VA = "0x17C3E70", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17C4364", Offset = "0x17C4364", VA = "0x17C4364", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x17C462C", Offset = "0x17C462C", VA = "0x17C462C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x17C37B4", Offset = "0x17C37B4", VA = "0x17C37B4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x17C3D88", Offset = "0x17C3D88", VA = "0x17C3D88")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x17C45C8", Offset = "0x17C45C8", VA = "0x17C45C8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x17C3B10", Offset = "0x17C3B10", VA = "0x17C3B10")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x17C4C7C", Offset = "0x17C4C7C", VA = "0x17C4C7C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x17C4CF0", Offset = "0x17C4CF0", VA = "0x17C4CF0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x17C4DB8", Offset = "0x17C4DB8", VA = "0x17C4DB8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x17C4E68", Offset = "0x17C4E68", VA = "0x17C4E68")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x17C4114", Offset = "0x17C4114", VA = "0x17C4114")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x17C423C", Offset = "0x17C423C", VA = "0x17C423C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x17C4F6C", Offset = "0x17C4F6C", VA = "0x17C4F6C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x17C484C", Offset = "0x17C484C", VA = "0x17C484C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x17C3D78", Offset = "0x17C3D78", VA = "0x17C3D78")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x17C54FC", Offset = "0x17C54FC", VA = "0x17C54FC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x17C50B0", Offset = "0x17C50B0", VA = "0x17C50B0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x17C46A8", Offset = "0x17C46A8", VA = "0x17C46A8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x17C4788", Offset = "0x17C4788", VA = "0x17C4788")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x17C55C8", Offset = "0x17C55C8", VA = "0x17C55C8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685224", Offset = "0x685224")]
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
		[Address(RVA = "0x17C565C", Offset = "0x17C565C", VA = "0x17C565C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x17C5CE8", Offset = "0x17C5CE8", VA = "0x17C5CE8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x17C5D80", Offset = "0x17C5D80", VA = "0x17C5D80", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x17C5E20", Offset = "0x17C5E20", VA = "0x17C5E20", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17C5F2C", Offset = "0x17C5F2C", VA = "0x17C5F2C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x17C5FC8", Offset = "0x17C5FC8", VA = "0x17C5FC8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x17C63F8", Offset = "0x17C63F8", VA = "0x17C63F8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x17C6608", Offset = "0x17C6608", VA = "0x17C6608", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x17C64A4", Offset = "0x17C64A4", VA = "0x17C64A4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x17C61B4", Offset = "0x17C61B4", VA = "0x17C61B4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x17C66A0", Offset = "0x17C66A0", VA = "0x17C66A0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68523C", Offset = "0x68523C")]
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
		[Address(RVA = "0x17C6720", Offset = "0x17C6720", VA = "0x17C6720")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x17C6810", Offset = "0x17C6810", VA = "0x17C6810")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x17C686C", Offset = "0x17C686C", VA = "0x17C686C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x17C699C", Offset = "0x17C699C", VA = "0x17C699C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x17C69F8", Offset = "0x17C69F8", VA = "0x17C69F8")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x17C6A78", Offset = "0x17C6A78", VA = "0x17C6A78", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x17C6C24", Offset = "0x17C6C24", VA = "0x17C6C24", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x17C6D94", Offset = "0x17C6D94", VA = "0x17C6D94", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x17C6FA4", Offset = "0x17C6FA4", VA = "0x17C6FA4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x17C707C", Offset = "0x17C707C", VA = "0x17C707C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x17C7168", Offset = "0x17C7168", VA = "0x17C7168", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x17C72DC", Offset = "0x17C72DC", VA = "0x17C72DC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x17C7434", Offset = "0x17C7434", VA = "0x17C7434", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x17C7680", Offset = "0x17C7680", VA = "0x17C7680", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x17C795C", Offset = "0x17C795C", VA = "0x17C795C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x17C79A0", Offset = "0x17C79A0", VA = "0x17C79A0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x17C7A90", Offset = "0x17C7A90", VA = "0x17C7A90")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685254", Offset = "0x685254")]
		public float spineStiffness;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68526C", Offset = "0x68526C")]
		public float pullBodyVertical;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685284", Offset = "0x685284")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68529C", Offset = "0x68529C")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x17C7BDC", Offset = "0x17C7BDC", VA = "0x17C7BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x17C7D24", Offset = "0x17C7D24", VA = "0x17C7D24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x17C7D2C", Offset = "0x17C7D2C", VA = "0x17C7D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x17C7D34", Offset = "0x17C7D34", VA = "0x17C7D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x17C7D3C", Offset = "0x17C7D3C", VA = "0x17C7D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x17C7D44", Offset = "0x17C7D44", VA = "0x17C7D44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x17C7D4C", Offset = "0x17C7D4C", VA = "0x17C7D4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x17C7D54", Offset = "0x17C7D54", VA = "0x17C7D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x17C7D5C", Offset = "0x17C7D5C", VA = "0x17C7D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x17C7D64", Offset = "0x17C7D64", VA = "0x17C7D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x17C7D9C", Offset = "0x17C7D9C", VA = "0x17C7D9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x17C7DD4", Offset = "0x17C7DD4", VA = "0x17C7DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x17C7E0C", Offset = "0x17C7E0C", VA = "0x17C7E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x17C7E44", Offset = "0x17C7E44", VA = "0x17C7E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x17C7E78", Offset = "0x17C7E78", VA = "0x17C7E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x17C7EB0", Offset = "0x17C7EB0", VA = "0x17C7EB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x17C7EE8", Offset = "0x17C7EE8", VA = "0x17C7EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x17C7F20", Offset = "0x17C7F20", VA = "0x17C7F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x17CA0AC", Offset = "0x17CA0AC", VA = "0x17CA0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C438", Offset = "0x68C438")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x17CA0B8", Offset = "0x17CA0B8", VA = "0x17CA0B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C448", Offset = "0x68C448")]
			private set
			{
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x17C7F54", Offset = "0x17C7F54", VA = "0x17C7F54")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x17C8060", Offset = "0x17C8060", VA = "0x17C8060")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x17C7FA8", Offset = "0x17C7FA8", VA = "0x17C7FA8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x17C80EC", Offset = "0x17C80EC", VA = "0x17C80EC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x17C7BE4", Offset = "0x17C7BE4", VA = "0x17C7BE4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x17C81BC", Offset = "0x17C81BC", VA = "0x17C81BC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x17C8274", Offset = "0x17C8274", VA = "0x17C8274")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x17C8328", Offset = "0x17C8328", VA = "0x17C8328")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x17C83DC", Offset = "0x17C83DC", VA = "0x17C83DC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x17C83E4", Offset = "0x17C83E4", VA = "0x17C83E4")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x17C8418", Offset = "0x17C8418", VA = "0x17C8418")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x17C84E0", Offset = "0x17C84E0", VA = "0x17C84E0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x17C8688", Offset = "0x17C8688", VA = "0x17C8688")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x17C9B28", Offset = "0x17C9B28", VA = "0x17C9B28")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x17C9F3C", Offset = "0x17C9F3C", VA = "0x17C9F3C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x17C9F9C", Offset = "0x17C9F9C", VA = "0x17C9F9C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x17C9DC4", Offset = "0x17C9DC4", VA = "0x17C9DC4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x17C9E80", Offset = "0x17C9E80", VA = "0x17C9E80")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x17CA0C4", Offset = "0x17CA0C4", VA = "0x17CA0C4")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x17CA19C", Offset = "0x17CA19C", VA = "0x17CA19C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x17CA298", Offset = "0x17CA298", VA = "0x17CA298")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x17CA3C0", Offset = "0x17CA3C0", VA = "0x17CA3C0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x17CA504", Offset = "0x17CA504", VA = "0x17CA504")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x17CA634", Offset = "0x17CA634", VA = "0x17CA634", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x17CA874", Offset = "0x17CA874", VA = "0x17CA874", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x17CA8F8", Offset = "0x17CA8F8", VA = "0x17CA8F8")]
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
			[Address(RVA = "0x17CB1AC", Offset = "0x17CB1AC", VA = "0x17CB1AC", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x17CB1B4", Offset = "0x17CB1B4", VA = "0x17CB1B4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x17CB1BC", Offset = "0x17CB1BC", VA = "0x17CB1BC", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x17CB1CC", Offset = "0x17CB1CC", VA = "0x17CB1CC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x17C30A4", Offset = "0x17C30A4", VA = "0x17C30A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x17CA904", Offset = "0x17CA904", VA = "0x17CA904")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x17CAABC", Offset = "0x17CAABC", VA = "0x17CAABC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x17CAC1C", Offset = "0x17CAC1C", VA = "0x17CAC1C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x17CAC88", Offset = "0x17CAC88", VA = "0x17CAC88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x17CAD08", Offset = "0x17CAD08", VA = "0x17CAD08", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x17CB0B4", Offset = "0x17CB0B4", VA = "0x17CB0B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x17CB0BC", Offset = "0x17CB0BC", VA = "0x17CB0BC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x17CB1C4", Offset = "0x17CB1C4", VA = "0x17CB1C4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x17CB1C8", Offset = "0x17CB1C8", VA = "0x17CB1C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x17C2688", Offset = "0x17C2688", VA = "0x17C2688")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x17C2D8C", Offset = "0x17C2D8C", VA = "0x17C2D8C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x17CB294", Offset = "0x17CB294", VA = "0x17CB294")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17C14EC", Offset = "0x17C14EC", VA = "0x17C14EC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6852AC", Offset = "0x6852AC")]
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
		[Address(RVA = "0x17CB488", Offset = "0x17CB488", VA = "0x17CB488", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x17CB870", Offset = "0x17CB870", VA = "0x17CB870")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x17CB924", Offset = "0x17CB924", VA = "0x17CB924", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x17CBAB8", Offset = "0x17CBAB8", VA = "0x17CBAB8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x17CBC4C", Offset = "0x17CBC4C", VA = "0x17CBC4C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x17CBCA8", Offset = "0x17CBCA8", VA = "0x17CBCA8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x17CBD18", Offset = "0x17CBD18", VA = "0x17CBD18", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x17CC088", Offset = "0x17CC088", VA = "0x17CC088", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x17CC0B4", Offset = "0x17CC0B4", VA = "0x17CC0B4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x17CBD7C", Offset = "0x17CBD7C", VA = "0x17CBD7C")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x17CC148", Offset = "0x17CC148", VA = "0x17CC148")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x17CC2D4", Offset = "0x17CC2D4", VA = "0x17CC2D4")]
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
			[Address(RVA = "0x12925AC", Offset = "0x12925AC", VA = "0x12925AC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6852C4", Offset = "0x6852C4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6852DC", Offset = "0x6852DC")]
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
			[Address(RVA = "0x17CD61C", Offset = "0x17CD61C", VA = "0x17CD61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x17CC498", Offset = "0x17CC498", VA = "0x17CC498")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x17CC4E8", Offset = "0x17CC4E8", VA = "0x17CC4E8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x17CC534", Offset = "0x17CC534", VA = "0x17CC534", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x17CCA08", Offset = "0x17CCA08", VA = "0x17CCA08", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x17CD354", Offset = "0x17CD354", VA = "0x17CD354", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x17CD400", Offset = "0x17CD400", VA = "0x17CD400")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x17CD580", Offset = "0x17CD580", VA = "0x17CD580")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x17CC830", Offset = "0x17CC830", VA = "0x17CC830")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x17CCAEC", Offset = "0x17CCAEC", VA = "0x17CCAEC")]
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
				[Address(RVA = "0x1292840", Offset = "0x1292840", VA = "0x1292840")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x129260C", Offset = "0x129260C", VA = "0x129260C")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1292610", Offset = "0x1292610", VA = "0x1292610")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1292640", Offset = "0x1292640", VA = "0x1292640")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1292738", Offset = "0x1292738", VA = "0x1292738")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6852F4", Offset = "0x6852F4")]
		public float bodyWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68530C", Offset = "0x68530C")]
		public float headWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685324", Offset = "0x685324")]
		public float eyesWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68533C", Offset = "0x68533C")]
		public float clampWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685354", Offset = "0x685354")]
		public float clampWeightHead;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68536C", Offset = "0x68536C")]
		public float clampWeightEyes;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685384", Offset = "0x685384")]
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
			[Address(RVA = "0x17CDDC0", Offset = "0x17CDDC0", VA = "0x17CDDC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x17CDF90", Offset = "0x17CDF90", VA = "0x17CDF90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x17CDEA0", Offset = "0x17CDEA0", VA = "0x17CDEA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x17CDFB4", Offset = "0x17CDFB4", VA = "0x17CDFB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x17CDEB0", Offset = "0x17CDEB0", VA = "0x17CDEB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x17CE02C", Offset = "0x17CE02C", VA = "0x17CE02C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x17CD638", Offset = "0x17CD638", VA = "0x17CD638")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x17CD668", Offset = "0x17CD668", VA = "0x17CD668")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x17CD6C0", Offset = "0x17CD6C0", VA = "0x17CD6C0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x17CD73C", Offset = "0x17CD73C", VA = "0x17CD73C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x17CD7D4", Offset = "0x17CD7D4", VA = "0x17CD7D4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x17CD894", Offset = "0x17CD894", VA = "0x17CD894")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x17CD990", Offset = "0x17CD990", VA = "0x17CD990", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x17CDABC", Offset = "0x17CDABC", VA = "0x17CDABC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x17CDBFC", Offset = "0x17CDBFC", VA = "0x17CDBFC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x17CE050", Offset = "0x17CE050", VA = "0x17CE050", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x17CE2C0", Offset = "0x17CE2C0", VA = "0x17CE2C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x17CE45C", Offset = "0x17CE45C", VA = "0x17CE45C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x17CE6BC", Offset = "0x17CE6BC", VA = "0x17CE6BC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x17CE9D0", Offset = "0x17CE9D0", VA = "0x17CE9D0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x17CEAA0", Offset = "0x17CEAA0", VA = "0x17CEAA0")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x17CEC40", Offset = "0x17CEC40", VA = "0x17CEC40")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x17CEE64", Offset = "0x17CEE64", VA = "0x17CEE64")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x17CF218", Offset = "0x17CF218", VA = "0x17CF218")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x17CE510", Offset = "0x17CE510", VA = "0x17CE510")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x17CF488", Offset = "0x17CF488", VA = "0x17CF488")]
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
			[Address(RVA = "0x129287C", Offset = "0x129287C", VA = "0x129287C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1292978", Offset = "0x1292978", VA = "0x1292978")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x12929A8", Offset = "0x12929A8", VA = "0x12929A8")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x12929E4", Offset = "0x12929E4", VA = "0x12929E4")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68539C", Offset = "0x68539C")]
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
		[Address(RVA = "0x17CF6FC", Offset = "0x17CF6FC", VA = "0x17CF6FC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x17CF858", Offset = "0x17CF858", VA = "0x17CF858")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x17CF99C", Offset = "0x17CF99C", VA = "0x17CF99C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x17CF9A8", Offset = "0x17CF9A8", VA = "0x17CF9A8")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x17CF9D8", Offset = "0x17CF9D8", VA = "0x17CF9D8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x17CF9E4", Offset = "0x17CF9E4", VA = "0x17CF9E4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x17CF9EC", Offset = "0x17CF9EC", VA = "0x17CF9EC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x17CFB10", Offset = "0x17CFB10", VA = "0x17CFB10", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x17CFC2C", Offset = "0x17CFC2C", VA = "0x17CFC2C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x17CFC78", Offset = "0x17CFC78", VA = "0x17CFC78", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x17CFCD8", Offset = "0x17CFCD8", VA = "0x17CFCD8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x17D00D0", Offset = "0x17D00D0", VA = "0x17D00D0")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x17D014C", Offset = "0x17D014C", VA = "0x17D014C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x17D0508", Offset = "0x17D0508", VA = "0x17D0508")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x17D0670", Offset = "0x17D0670", VA = "0x17D0670", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x17D07D8", Offset = "0x17D07D8", VA = "0x17D07D8")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x17D074C", Offset = "0x17D074C", VA = "0x17D074C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x17D08DC", Offset = "0x17D08DC", VA = "0x17D08DC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x17D10B4", Offset = "0x17D10B4", VA = "0x17D10B4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x17D10B8", Offset = "0x17D10B8", VA = "0x17D10B8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x17D10BC", Offset = "0x17D10BC", VA = "0x17D10BC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x17D0ECC", Offset = "0x17D0ECC", VA = "0x17D0ECC")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17CD488", Offset = "0x17CD488", VA = "0x17CD488")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6855A0", Offset = "0x6855A0")]
			public Transform target;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6855D8", Offset = "0x6855D8")]
			public Transform bendGoal;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685610", Offset = "0x685610")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685610", Offset = "0x685610")]
			public float positionWeight;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685664", Offset = "0x685664")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685664", Offset = "0x685664")]
			public float rotationWeight;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6856B8", Offset = "0x6856B8")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6856F0", Offset = "0x6856F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6856F0", Offset = "0x6856F0")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685744", Offset = "0x685744")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685744", Offset = "0x685744")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685798", Offset = "0x685798")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685798", Offset = "0x685798")]
			public float bendGoalWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6857EC", Offset = "0x6857EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6857EC", Offset = "0x6857EC")]
			public float swivelOffset;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685848", Offset = "0x685848")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685880", Offset = "0x685880")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6858B8", Offset = "0x6858B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6858B8", Offset = "0x6858B8")]
			public float armLengthMlp;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685910", Offset = "0x685910")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685988", Offset = "0x685988")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685998", Offset = "0x685998")]
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
				[Address(RVA = "0x12929E8", Offset = "0x12929E8", VA = "0x12929E8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C478", Offset = "0x68C478")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x12929F4", Offset = "0x12929F4", VA = "0x12929F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C488", Offset = "0x68C488")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x1292A00", Offset = "0x1292A00", VA = "0x1292A00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C498", Offset = "0x68C498")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x1292A0C", Offset = "0x1292A0C", VA = "0x1292A0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C4A8", Offset = "0x68C4A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x1292A18", Offset = "0x1292A18", VA = "0x1292A18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x1292A4C", Offset = "0x1292A4C", VA = "0x1292A4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x1292A8C", Offset = "0x1292A8C", VA = "0x1292A8C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x1292AD8", Offset = "0x1292AD8", VA = "0x1292AD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1292B24", Offset = "0x1292B24", VA = "0x1292B24", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x129339C", Offset = "0x129339C", VA = "0x129339C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1293558", Offset = "0x1293558", VA = "0x1293558", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x129357C", Offset = "0x129357C", VA = "0x129357C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x129381C", Offset = "0x129381C", VA = "0x129381C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1294D78", Offset = "0x1294D78", VA = "0x1294D78", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1294DA4", Offset = "0x1294DA4", VA = "0x1294DA4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x12947B4", Offset = "0x12947B4", VA = "0x12947B4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1294830", Offset = "0x1294830", VA = "0x1294830")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1294FC4", Offset = "0x1294FC4", VA = "0x1294FC4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x12950E8", Offset = "0x12950E8", VA = "0x12950E8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6859A8", Offset = "0x6859A8")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6859B8", Offset = "0x6859B8")]
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
				[Address(RVA = "0x1295258", Offset = "0x1295258", VA = "0x1295258")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C4B8", Offset = "0x68C4B8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x1295260", Offset = "0x1295260", VA = "0x1295260")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C4C8", Offset = "0x68C4C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x1295268", Offset = "0x1295268", VA = "0x1295268")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C4D8", Offset = "0x68C4D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000432")]
				[Address(RVA = "0x1295270", Offset = "0x1295270", VA = "0x1295270")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C4E8", Offset = "0x68C4E8")]
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
			[Address(RVA = "0x1295278", Offset = "0x1295278", VA = "0x1295278")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x1295280", Offset = "0x1295280", VA = "0x1295280")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x1295354", Offset = "0x1295354", VA = "0x1295354")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x12953E8", Offset = "0x12953E8", VA = "0x12953E8")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x1295494", Offset = "0x1295494", VA = "0x1295494")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x12954E8", Offset = "0x12954E8", VA = "0x12954E8")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1294C34", Offset = "0x1294C34", VA = "0x1294C34")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1295624", Offset = "0x1295624", VA = "0x1295624")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1295764", Offset = "0x1295764", VA = "0x1295764")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x12951D8", Offset = "0x12951D8", VA = "0x12951D8")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6859D8", Offset = "0x6859D8")]
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
				[Address(RVA = "0x129578C", Offset = "0x129578C", VA = "0x129578C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x12957A0", Offset = "0x12957A0", VA = "0x12957A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C4F8", Offset = "0x68C4F8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x12957A8", Offset = "0x12957A8", VA = "0x12957A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C508", Offset = "0x68C508")]
				private set
				{
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x12957B0", Offset = "0x12957B0", VA = "0x12957B0")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x12958E8", Offset = "0x12958E8", VA = "0x12958E8")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1295930", Offset = "0x1295930", VA = "0x1295930")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1295AF4", Offset = "0x1295AF4", VA = "0x1295AF4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1295C68", Offset = "0x1295C68", VA = "0x1295C68")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1295DC0", Offset = "0x1295DC0", VA = "0x1295DC0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6859E8", Offset = "0x6859E8")]
			public Transform target;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685A20", Offset = "0x685A20")]
			public Transform bendGoal;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685A58", Offset = "0x685A58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685A58", Offset = "0x685A58")]
			public float positionWeight;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685AAC", Offset = "0x685AAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685AAC", Offset = "0x685AAC")]
			public float rotationWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685B00", Offset = "0x685B00")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685B00", Offset = "0x685B00")]
			public float bendGoalWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685B54", Offset = "0x685B54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685B54", Offset = "0x685B54")]
			public float swivelOffset;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685BB0", Offset = "0x685BB0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685BB0", Offset = "0x685BB0")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685C04", Offset = "0x685C04")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685C04", Offset = "0x685C04")]
			public float legLengthMlp;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685C5C", Offset = "0x685C5C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685D04", Offset = "0x685D04")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685D14", Offset = "0x685D14")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685D24", Offset = "0x685D24")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685D34", Offset = "0x685D34")]
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
				[Address(RVA = "0x1295EFC", Offset = "0x1295EFC", VA = "0x1295EFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C518", Offset = "0x68C518")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x1295F08", Offset = "0x1295F08", VA = "0x1295F08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C528", Offset = "0x68C528")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x1295F14", Offset = "0x1295F14", VA = "0x1295F14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C538", Offset = "0x68C538")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x1295F20", Offset = "0x1295F20", VA = "0x1295F20")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C548", Offset = "0x68C548")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x1295F2C", Offset = "0x1295F2C", VA = "0x1295F2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C558", Offset = "0x68C558")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x1295F34", Offset = "0x1295F34", VA = "0x1295F34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C568", Offset = "0x68C568")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x1295F40", Offset = "0x1295F40", VA = "0x1295F40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x1295F74", Offset = "0x1295F74", VA = "0x1295F74")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x1295FAC", Offset = "0x1295FAC", VA = "0x1295FAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x1295FE4", Offset = "0x1295FE4", VA = "0x1295FE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x129601C", Offset = "0x129601C", VA = "0x129601C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x129605C", Offset = "0x129605C", VA = "0x129605C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C578", Offset = "0x68C578")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1296068", Offset = "0x1296068", VA = "0x1296068")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C588", Offset = "0x68C588")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1296074", Offset = "0x1296074", VA = "0x1296074", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x12966EC", Offset = "0x12966EC", VA = "0x12966EC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1296CA8", Offset = "0x1296CA8", VA = "0x1296CA8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1296C58", Offset = "0x1296C58", VA = "0x1296C58")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x1296AE8", Offset = "0x1296AE8", VA = "0x1296AE8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1297090", Offset = "0x1297090", VA = "0x1297090")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1297540", Offset = "0x1297540", VA = "0x1297540")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1297220", Offset = "0x1297220", VA = "0x1297220")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1297838", Offset = "0x1297838", VA = "0x1297838", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1297A54", Offset = "0x1297A54", VA = "0x1297A54", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1297AA0", Offset = "0x1297AA0", VA = "0x1297AA0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685D44", Offset = "0x685D44")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685D44", Offset = "0x685D44")]
			public float weight;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685D98", Offset = "0x685D98")]
			public float footDistance;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685DD0", Offset = "0x685DD0")]
			public float stepThreshold;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685E08", Offset = "0x685E08")]
			public float angleThreshold;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685E40", Offset = "0x685E40")]
			public float comAngleMlp;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685E78", Offset = "0x685E78")]
			public float maxVelocity;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685EB0", Offset = "0x685EB0")]
			public float velocityFactor;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685EE8", Offset = "0x685EE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x685EE8", Offset = "0x685EE8")]
			public float maxLegStretch;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685F40", Offset = "0x685F40")]
			public float rootSpeed;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685F78", Offset = "0x685F78")]
			public float stepSpeed;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685FB0", Offset = "0x685FB0")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685FE8", Offset = "0x685FE8")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686020", Offset = "0x686020")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686020", Offset = "0x686020")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686078", Offset = "0x686078")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6860B0", Offset = "0x6860B0")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6860E8", Offset = "0x6860E8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686160", Offset = "0x686160")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686198", Offset = "0x686198")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6861D0", Offset = "0x6861D0")]
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
				[Address(RVA = "0x1297B7C", Offset = "0x1297B7C", VA = "0x1297B7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C598", Offset = "0x68C598")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1297B88", Offset = "0x1297B88", VA = "0x1297B88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C5A8", Offset = "0x68C5A8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x1299630", Offset = "0x1299630", VA = "0x1299630")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1299670", Offset = "0x1299670", VA = "0x1299670")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x12996B4", Offset = "0x12996B4", VA = "0x12996B4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x12996F4", Offset = "0x12996F4", VA = "0x12996F4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1297B94", Offset = "0x1297B94", VA = "0x1297B94")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1297E54", Offset = "0x1297E54", VA = "0x1297E54")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1298024", Offset = "0x1298024", VA = "0x1298024")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x129826C", Offset = "0x129826C", VA = "0x129826C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x1298330", Offset = "0x1298330", VA = "0x1298330")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x12993A8", Offset = "0x12993A8", VA = "0x12993A8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x12994E0", Offset = "0x12994E0", VA = "0x12994E0")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x1299564", Offset = "0x1299564", VA = "0x1299564")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1299738", Offset = "0x1299738", VA = "0x1299738")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6861E0", Offset = "0x6861E0")]
			public Transform headTarget;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686218", Offset = "0x686218")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686250", Offset = "0x686250")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686250", Offset = "0x686250")]
			public float positionWeight;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6862A4", Offset = "0x6862A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6862A4", Offset = "0x6862A4")]
			public float rotationWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6862F8", Offset = "0x6862F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6862F8", Offset = "0x6862F8")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68634C", Offset = "0x68634C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68634C", Offset = "0x68634C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6863A0", Offset = "0x6863A0")]
			public Transform chestGoal;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6863D8", Offset = "0x6863D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6863D8", Offset = "0x6863D8")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68642C", Offset = "0x68642C")]
			public float minHeadHeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686464", Offset = "0x686464")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686464", Offset = "0x686464")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6864B8", Offset = "0x6864B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6864B8", Offset = "0x6864B8")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68650C", Offset = "0x68650C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68650C", Offset = "0x68650C")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x68650C", Offset = "0x68650C")]
			public float neckStiffness;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686584", Offset = "0x686584")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686584", Offset = "0x686584")]
			public float rotateChestByHands;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6865D8", Offset = "0x6865D8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6865D8", Offset = "0x6865D8")]
			public float chestClampWeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68662C", Offset = "0x68662C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68662C", Offset = "0x68662C")]
			public float headClampWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686680", Offset = "0x686680")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6866B8", Offset = "0x6866B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6866B8", Offset = "0x6866B8")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68670C", Offset = "0x68670C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68670C", Offset = "0x68670C")]
			public float maxRootAngle;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686764", Offset = "0x686764")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686764", Offset = "0x686764")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6868A0", Offset = "0x6868A0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6868B0", Offset = "0x6868B0")]
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
				[Address(RVA = "0x17E35AC", Offset = "0x17E35AC", VA = "0x17E35AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x17E35EC", Offset = "0x17E35EC", VA = "0x17E35EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x17E362C", Offset = "0x17E362C", VA = "0x17E362C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x17E3680", Offset = "0x17E3680", VA = "0x17E3680")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x17E36C0", Offset = "0x17E36C0", VA = "0x17E36C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x17E3700", Offset = "0x17E3700", VA = "0x17E3700")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C5B8", Offset = "0x68C5B8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x17E3714", Offset = "0x17E3714", VA = "0x17E3714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C5C8", Offset = "0x68C5C8")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x17E3728", Offset = "0x17E3728", VA = "0x17E3728")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C5D8", Offset = "0x68C5D8")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x17E373C", Offset = "0x17E373C", VA = "0x17E373C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C5E8", Offset = "0x68C5E8")]
				private set
				{
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x17E3750", Offset = "0x17E3750", VA = "0x17E3750", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x17E4238", Offset = "0x17E4238", VA = "0x17E4238", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x17E4444", Offset = "0x17E4444", VA = "0x17E4444", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x17E4888", Offset = "0x17E4888", VA = "0x17E4888")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x17E4CC4", Offset = "0x17E4CC4", VA = "0x17E4CC4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x17E541C", Offset = "0x17E541C", VA = "0x17E541C")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x17E5AA0", Offset = "0x17E5AA0", VA = "0x17E5AA0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x17E64A4", Offset = "0x17E64A4", VA = "0x17E64A4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x17E6680", Offset = "0x17E6680", VA = "0x17E6680", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x17E4A20", Offset = "0x17E4A20", VA = "0x17E4A20")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x17E57EC", Offset = "0x17E57EC", VA = "0x17E57EC")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x17E50D4", Offset = "0x17E50D4", VA = "0x17E50D4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x17E6718", Offset = "0x17E6718", VA = "0x17E6718")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x17E58CC", Offset = "0x17E58CC", VA = "0x17E58CC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x17E5598", Offset = "0x17E5598", VA = "0x17E5598")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x17E6A40", Offset = "0x17E6A40", VA = "0x17E6A40")]
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
			[Address(RVA = "0x17E419C", Offset = "0x17E419C", VA = "0x17E419C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x17E4218", Offset = "0x17E4218", VA = "0x17E4218")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x17E6BB4", Offset = "0x17E6BB4", VA = "0x17E6BB4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x17E6D38", Offset = "0x17E6D38", VA = "0x17E6D38")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x17E6918", Offset = "0x17E6918", VA = "0x17E6918")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x17E6F28", Offset = "0x17E6F28", VA = "0x17E6F28")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x17E7088", Offset = "0x17E7088", VA = "0x17E7088")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x17E71C4", Offset = "0x17E71C4", VA = "0x17E71C4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x17E60A0", Offset = "0x17E60A0", VA = "0x17E60A0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x17E727C", Offset = "0x17E727C", VA = "0x17E727C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x17E5D10", Offset = "0x17E5D10", VA = "0x17E5D10")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x17E73E4", Offset = "0x17E73E4", VA = "0x17E73E4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x17E7454", Offset = "0x17E7454", VA = "0x17E7454")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6853B4", Offset = "0x6853B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6853B4", Offset = "0x6853B4")]
		public int LOD;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685408", Offset = "0x685408")]
		public bool plantFeet;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x685440", Offset = "0x685440")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685450", Offset = "0x685450")]
		public Spine spine;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685488", Offset = "0x685488")]
		public Arm leftArm;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6854C0", Offset = "0x6854C0")]
		public Arm rightArm;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6854F8", Offset = "0x6854F8")]
		public Leg leftLeg;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685530", Offset = "0x685530")]
		public Leg rightLeg;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x685568", Offset = "0x685568")]
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
			[Address(RVA = "0x1609B70", Offset = "0x1609B70", VA = "0x1609B70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C458", Offset = "0x68C458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1609B78", Offset = "0x1609B78", VA = "0x1609B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C468", Offset = "0x68C468")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1605F50", Offset = "0x1605F50", VA = "0x1605F50")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x160640C", Offset = "0x160640C", VA = "0x160640C")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1606298", Offset = "0x1606298", VA = "0x1606298")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1606B6C", Offset = "0x1606B6C", VA = "0x1606B6C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1606CB0", Offset = "0x1606CB0", VA = "0x1606CB0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1606CE0", Offset = "0x1606CE0", VA = "0x1606CE0")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1606D90", Offset = "0x1606D90", VA = "0x1606D90")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1606E78", Offset = "0x1606E78", VA = "0x1606E78")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1607630", Offset = "0x1607630", VA = "0x1607630", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x16077A0", Offset = "0x16077A0", VA = "0x16077A0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x16079A4", Offset = "0x16079A4", VA = "0x16079A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1607A20", Offset = "0x1607A20", VA = "0x1607A20", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1607A9C", Offset = "0x1607A9C", VA = "0x1607A9C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1607C80", Offset = "0x1607C80", VA = "0x1607C80")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1606640", Offset = "0x1606640", VA = "0x1606640")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1606730", Offset = "0x1606730", VA = "0x1606730")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1606A4C", Offset = "0x1606A4C", VA = "0x1606A4C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1606F6C", Offset = "0x1606F6C", VA = "0x1606F6C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1607E40", Offset = "0x1607E40", VA = "0x1607E40", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1607E88", Offset = "0x1607E88", VA = "0x1607E88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x16092A0", Offset = "0x16092A0", VA = "0x16092A0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x16070D0", Offset = "0x16070D0", VA = "0x16070D0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x16081FC", Offset = "0x16081FC", VA = "0x16081FC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1609650", Offset = "0x1609650", VA = "0x1609650")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1609698", Offset = "0x1609698", VA = "0x1609698")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1609150", Offset = "0x1609150", VA = "0x1609150")]
		private void Write()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x16096DC", Offset = "0x16096DC", VA = "0x16096DC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1609B80", Offset = "0x1609B80", VA = "0x1609B80")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6868C0", Offset = "0x6868C0")]
		public Transform parent;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6868F8", Offset = "0x6868F8")]
		public Transform child;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686930", Offset = "0x686930")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686930", Offset = "0x686930")]
		public float weight;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x686984", Offset = "0x686984")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686984", Offset = "0x686984")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6869D8", Offset = "0x6869D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6869D8", Offset = "0x6869D8")]
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
		[Address(RVA = "0x144A85C", Offset = "0x144A85C", VA = "0x144A85C")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x144AB78", Offset = "0x144AB78", VA = "0x144AB78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x144AF8C", Offset = "0x144AF8C", VA = "0x144AF8C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x144B010", Offset = "0x144B010", VA = "0x144B010")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x144B094", Offset = "0x144B094", VA = "0x144B094")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x144B1D0", Offset = "0x144B1D0", VA = "0x144B1D0")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686A34", Offset = "0x686A34")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686A44", Offset = "0x686A44")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686A54", Offset = "0x686A54")]
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
			[Address(RVA = "0x160AC2C", Offset = "0x160AC2C", VA = "0x160AC2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C5F8", Offset = "0x68C5F8")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x160AC34", Offset = "0x160AC34", VA = "0x160AC34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C608", Offset = "0x68C608")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x160AC3C", Offset = "0x160AC3C", VA = "0x160AC3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C618", Offset = "0x68C618")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x160AC44", Offset = "0x160AC44", VA = "0x160AC44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C628", Offset = "0x68C628")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x160AC50", Offset = "0x160AC50", VA = "0x160AC50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C638", Offset = "0x68C638")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x160AC58", Offset = "0x160AC58", VA = "0x160AC58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C648", Offset = "0x68C648")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x160AC60", Offset = "0x160AC60", VA = "0x160AC60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x160D128", Offset = "0x160D128", VA = "0x160D128")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x160ACCC", Offset = "0x160ACCC", VA = "0x160ACCC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x160AD64", Offset = "0x160AD64", VA = "0x160AD64")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x160AE30", Offset = "0x160AE30", VA = "0x160AE30")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x160AFA8", Offset = "0x160AFA8", VA = "0x160AFA8")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x160B30C", Offset = "0x160B30C", VA = "0x160B30C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x160B3C8", Offset = "0x160B3C8", VA = "0x160B3C8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x160B420", Offset = "0x160B420", VA = "0x160B420")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x160BE6C", Offset = "0x160BE6C", VA = "0x160BE6C")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x160C91C", Offset = "0x160C91C", VA = "0x160C91C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x160CB60", Offset = "0x160CB60", VA = "0x160CB60")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x160CFB8", Offset = "0x160CFB8", VA = "0x160CFB8")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x160D288", Offset = "0x160D288", VA = "0x160D288")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686A64", Offset = "0x686A64")]
		public LookAtIK ik;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686A9C", Offset = "0x686A9C")]
		public float lerpSpeed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686AD4", Offset = "0x686AD4")]
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
		[Address(RVA = "0x160D478", Offset = "0x160D478", VA = "0x160D478")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x160D5A0", Offset = "0x160D5A0", VA = "0x160D5A0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x160D644", Offset = "0x160D644", VA = "0x160D644")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x160DC8C", Offset = "0x160DC8C", VA = "0x160DC8C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x160DD80", Offset = "0x160DD80", VA = "0x160DD80")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x160DE48", Offset = "0x160DE48", VA = "0x160DE48")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x682018", Offset = "0x682018")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682018", Offset = "0x682018")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686BE4", Offset = "0x686BE4")]
			public float time;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686C1C", Offset = "0x686C1C")]
			public bool pause;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686C54", Offset = "0x686C54")]
			public bool pickUp;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686C8C", Offset = "0x686C8C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686CC4", Offset = "0x686CC4")]
			public Message[] messages;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686CFC", Offset = "0x686CFC")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x17E7C00", Offset = "0x17E7C00", VA = "0x17E7C00")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x17E7DD4", Offset = "0x17E7DD4", VA = "0x17E7DD4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686D34", Offset = "0x686D34")]
			public string function;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686D6C", Offset = "0x686D6C")]
			public GameObject recipient;

			[Token(Token = "0x400045C")]
			private const string empty = "";

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x17E7CD0", Offset = "0x17E7CD0", VA = "0x17E7CD0")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x17E7DDC", Offset = "0x17E7DDC", VA = "0x17E7DDC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686DA4", Offset = "0x686DA4")]
			public Animator animator;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686DDC", Offset = "0x686DDC")]
			public Animation animation;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686E14", Offset = "0x686E14")]
			public string animationState;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686E4C", Offset = "0x686E4C")]
			public float crossfadeTime;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686E84", Offset = "0x686E84")]
			public int layer;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686EBC", Offset = "0x686EBC")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000463")]
			private const string empty = "";

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x17E796C", Offset = "0x17E796C", VA = "0x17E796C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x17E7A5C", Offset = "0x17E7A5C", VA = "0x17E7A5C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x17E7B10", Offset = "0x17E7B10", VA = "0x17E7B10")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x17E7BEC", Offset = "0x17E7BEC", VA = "0x17E7BEC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686EF4", Offset = "0x686EF4")]
			public Type type;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686F2C", Offset = "0x686F2C")]
			public AnimationCurve curve;

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x17E7E20", Offset = "0x17E7E20", VA = "0x17E7E20")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x17E7E4C", Offset = "0x17E7E4C", VA = "0x17E7E4C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686F64", Offset = "0x686F64")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686F9C", Offset = "0x686F9C")]
			public float multiplier;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686FD4", Offset = "0x686FD4")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x17E7DE4", Offset = "0x17E7DE4", VA = "0x17E7DE4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x17E7E3C", Offset = "0x17E7E3C", VA = "0x17E7E3C")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686B1C", Offset = "0x686B1C")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686B54", Offset = "0x686B54")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x686B8C", Offset = "0x686B8C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686BC4", Offset = "0x686BC4")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x686BD4", Offset = "0x686BD4")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x160E09C", Offset = "0x160E09C", VA = "0x160E09C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C818", Offset = "0x68C818")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x160E0A4", Offset = "0x160E0A4", VA = "0x160E0A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C828", Offset = "0x68C828")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x160E0AC", Offset = "0x160E0AC", VA = "0x160E0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C838", Offset = "0x68C838")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x160E0B4", Offset = "0x160E0B4", VA = "0x160E0B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68C848", Offset = "0x68C848")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x160E284", Offset = "0x160E284", VA = "0x160E284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x160D164", Offset = "0x160D164", VA = "0x160D164")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x160DE5C", Offset = "0x160DE5C", VA = "0x160DE5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C658", Offset = "0x68C658")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x160DEA4", Offset = "0x160DEA4", VA = "0x160DEA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C690", Offset = "0x68C690")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x160DEEC", Offset = "0x160DEEC", VA = "0x160DEEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C6C8", Offset = "0x68C6C8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x160DF34", Offset = "0x160DF34", VA = "0x160DF34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C700", Offset = "0x68C700")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x160DF7C", Offset = "0x160DF7C", VA = "0x160DF7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C738", Offset = "0x68C738")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x160DFC4", Offset = "0x160DFC4", VA = "0x160DFC4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C770", Offset = "0x68C770")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x160E00C", Offset = "0x160E00C", VA = "0x160E00C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C7A8", Offset = "0x68C7A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x160E054", Offset = "0x160E054", VA = "0x160E054")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C7E0", Offset = "0x68C7E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x160E0BC", Offset = "0x160E0BC", VA = "0x160E0BC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x160E310", Offset = "0x160E310", VA = "0x160E310")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x160B9DC", Offset = "0x160B9DC", VA = "0x160B9DC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x160E49C", Offset = "0x160E49C", VA = "0x160E49C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x160B888", Offset = "0x160B888", VA = "0x160B888")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x160B9D4", Offset = "0x160B9D4", VA = "0x160B9D4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x160C4C0", Offset = "0x160C4C0", VA = "0x160C4C0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x160CD98", Offset = "0x160CD98", VA = "0x160CD98")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x160EA80", Offset = "0x160EA80", VA = "0x160EA80")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x160E584", Offset = "0x160E584", VA = "0x160E584")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x160E4A4", Offset = "0x160E4A4", VA = "0x160E4A4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x160EA18", Offset = "0x160EA18", VA = "0x160EA18")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x160EA84", Offset = "0x160EA84", VA = "0x160EA84")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x160EAEC", Offset = "0x160EAEC", VA = "0x160EAEC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x682078", Offset = "0x682078")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682078", Offset = "0x682078")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68700C", Offset = "0x68700C")]
		public string targetTag;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687044", Offset = "0x687044")]
		public float fadeInTime;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68707C", Offset = "0x68707C")]
		public float speed;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6870B4", Offset = "0x6870B4")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6870EC", Offset = "0x6870EC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6870EC", Offset = "0x6870EC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6870EC", Offset = "0x6870EC")]
		public Collider characterCollider;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687170", Offset = "0x687170")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x687170", Offset = "0x687170")]
		public Transform FPSCamera;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6871D0", Offset = "0x6871D0")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687208", Offset = "0x687208")]
		public float camRaycastDistance;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x687240", Offset = "0x687240")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x687250", Offset = "0x687250")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687250", Offset = "0x687250")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6872B0", Offset = "0x6872B0")]
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
			[Address(RVA = "0x160AB04", Offset = "0x160AB04", VA = "0x160AB04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1610848", Offset = "0x1610848", VA = "0x1610848")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x1610850", Offset = "0x1610850", VA = "0x1610850")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1610858", Offset = "0x1610858", VA = "0x1610858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CA18", Offset = "0x68CA18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x1610860", Offset = "0x1610860", VA = "0x1610860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CA28", Offset = "0x68CA28")]
			private set
			{
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x160EB54", Offset = "0x160EB54", VA = "0x160EB54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C858", Offset = "0x68C858")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x160EB9C", Offset = "0x160EB9C", VA = "0x160EB9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C890", Offset = "0x68C890")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x160EBE4", Offset = "0x160EBE4", VA = "0x160EBE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C8C8", Offset = "0x68C8C8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x160EC2C", Offset = "0x160EC2C", VA = "0x160EC2C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C900", Offset = "0x68C900")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x160EC74", Offset = "0x160EC74", VA = "0x160EC74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C938", Offset = "0x68C938")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x160ECBC", Offset = "0x160ECBC", VA = "0x160ECBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C970", Offset = "0x68C970")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x160ED04", Offset = "0x160ED04", VA = "0x160ED04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C9A8", Offset = "0x68C9A8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x160ED4C", Offset = "0x160ED4C", VA = "0x160ED4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68C9E0", Offset = "0x68C9E0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x160EE8C", Offset = "0x160EE8C", VA = "0x160EE8C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x160EF58", Offset = "0x160EF58", VA = "0x160EF58")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x160F024", Offset = "0x160F024", VA = "0x160F024")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x160F0D0", Offset = "0x160F0D0", VA = "0x160F0D0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x160A1E4", Offset = "0x160A1E4", VA = "0x160A1E4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x160F1C8", Offset = "0x160F1C8", VA = "0x160F1C8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x160F258", Offset = "0x160F258", VA = "0x160F258")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x160F2E8", Offset = "0x160F2E8", VA = "0x160F2E8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x160F378", Offset = "0x160F378", VA = "0x160F378")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x160ABB0", Offset = "0x160ABB0", VA = "0x160ABB0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x160F3EC", Offset = "0x160F3EC", VA = "0x160F3EC")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x160F454", Offset = "0x160F454", VA = "0x160F454")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x160F4E0", Offset = "0x160F4E0", VA = "0x160F4E0")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x160F594", Offset = "0x160F594", VA = "0x160F594")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x160F678", Offset = "0x160F678", VA = "0x160F678")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x160F950", Offset = "0x160F950", VA = "0x160F950")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x160FB48", Offset = "0x160FB48", VA = "0x160FB48")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x160FDEC", Offset = "0x160FDEC", VA = "0x160FDEC")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x16100C4", Offset = "0x16100C4", VA = "0x16100C4")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1610108", Offset = "0x1610108", VA = "0x1610108")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1610180", Offset = "0x1610180", VA = "0x1610180")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x16102B4", Offset = "0x16102B4", VA = "0x16102B4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1610458", Offset = "0x1610458", VA = "0x1610458")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x16106FC", Offset = "0x16106FC", VA = "0x16106FC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x160FF00", Offset = "0x160FF00", VA = "0x160FF00")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1610868", Offset = "0x1610868", VA = "0x1610868")]
		public void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1611090", Offset = "0x1611090", VA = "0x1611090")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x16110B0", Offset = "0x16110B0", VA = "0x16110B0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x16110CC", Offset = "0x16110CC", VA = "0x16110CC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x16110E8", Offset = "0x16110E8", VA = "0x16110E8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1611148", Offset = "0x1611148", VA = "0x1611148")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1611284", Offset = "0x1611284", VA = "0x1611284")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1611394", Offset = "0x1611394", VA = "0x1611394")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1611738", Offset = "0x1611738", VA = "0x1611738")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1611864", Offset = "0x1611864", VA = "0x1611864")]
		public void Update()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1611AF4", Offset = "0x1611AF4", VA = "0x1611AF4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1610DDC", Offset = "0x1610DDC", VA = "0x1610DDC")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1611C30", Offset = "0x1611C30", VA = "0x1611C30")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1611D58", Offset = "0x1611D58", VA = "0x1611D58")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1611DEC", Offset = "0x1611DEC", VA = "0x1611DEC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1611EC0", Offset = "0x1611EC0", VA = "0x1611EC0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1611ED8", Offset = "0x1611ED8", VA = "0x1611ED8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x160ED94", Offset = "0x160ED94", VA = "0x160ED94")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x160F820", Offset = "0x160F820", VA = "0x160F820")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x16122D4", Offset = "0x16122D4", VA = "0x16122D4")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6820D8", Offset = "0x6820D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6820D8", Offset = "0x6820D8")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Multiplier
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6874A8", Offset = "0x6874A8")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6874E0", Offset = "0x6874E0")]
			public float multiplier;

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x17E84C0", Offset = "0x17E84C0", VA = "0x17E84C0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6872E8", Offset = "0x6872E8")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687320", Offset = "0x687320")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687358", Offset = "0x687358")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687390", Offset = "0x687390")]
		public Transform pivot;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6873C8", Offset = "0x6873C8")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687400", Offset = "0x687400")]
		public float twistWeight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687438", Offset = "0x687438")]
		public float swingWeight;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687470", Offset = "0x687470")]
		public bool rotateOnce;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1612ABC", Offset = "0x1612ABC", VA = "0x1612ABC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CA38", Offset = "0x68CA38")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1612B04", Offset = "0x1612B04", VA = "0x1612B04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CA70", Offset = "0x68CA70")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1612B4C", Offset = "0x1612B4C", VA = "0x1612B4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CAA8", Offset = "0x68CAA8")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1612B94", Offset = "0x1612B94", VA = "0x1612B94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CAE0", Offset = "0x68CAE0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1612BDC", Offset = "0x1612BDC", VA = "0x1612BDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CB18", Offset = "0x68CB18")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1612C24", Offset = "0x1612C24", VA = "0x1612C24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CB50", Offset = "0x68CB50")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1612C6C", Offset = "0x1612C6C", VA = "0x1612C6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CB88", Offset = "0x68CB88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1612CB4", Offset = "0x1612CB4", VA = "0x1612CB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CBC0", Offset = "0x68CBC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x160E514", Offset = "0x160E514", VA = "0x160E514")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x160D1F0", Offset = "0x160D1F0", VA = "0x160D1F0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x160BA90", Offset = "0x160BA90", VA = "0x160BA90")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1612CFC", Offset = "0x1612CFC", VA = "0x1612CFC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x682138", Offset = "0x682138")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682138", Offset = "0x682138")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class CharacterPosition
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687550", Offset = "0x687550")]
			public bool use;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687588", Offset = "0x687588")]
			public Vector2 offset;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6875C0", Offset = "0x6875C0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6875C0", Offset = "0x6875C0")]
			public float angleOffset;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68761C", Offset = "0x68761C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68761C", Offset = "0x68761C")]
			public float maxAngle;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687674", Offset = "0x687674")]
			public float radius;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6876AC", Offset = "0x6876AC")]
			public bool orbit;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6876E4", Offset = "0x6876E4")]
			public bool fixYAxis;

			[Token(Token = "0x1700008D")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x17E8830", Offset = "0x17E8830", VA = "0x17E8830")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x17E883C", Offset = "0x17E883C", VA = "0x17E883C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x17E88C4", Offset = "0x17E88C4", VA = "0x17E88C4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x17E8D08", Offset = "0x17E8D08", VA = "0x17E8D08")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68771C", Offset = "0x68771C")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687754", Offset = "0x687754")]
			public Vector3 direction;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68778C", Offset = "0x68778C")]
			public float maxDistance;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6877C4", Offset = "0x6877C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6877C4", Offset = "0x6877C4")]
			public float maxAngle;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68781C", Offset = "0x68781C")]
			public bool fixYAxis;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x17E84C8", Offset = "0x17E84C8", VA = "0x17E84C8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x17E85BC", Offset = "0x17E85BC", VA = "0x17E85BC")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x17E87E4", Offset = "0x17E87E4", VA = "0x17E87E4")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68796C", Offset = "0x68796C")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6879A4", Offset = "0x6879A4")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600053B")]
				[Address(RVA = "0x17EE65C", Offset = "0x17EE65C", VA = "0x17EE65C")]
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
			[SerializeField]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6878C4", Offset = "0x6878C4")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6878FC", Offset = "0x6878FC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687934", Offset = "0x687934")]
			public Interaction[] interactions;

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x17E8D1C", Offset = "0x17E8D1C", VA = "0x17E8D1C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x17E8DD0", Offset = "0x17E8DD0", VA = "0x17E8DD0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687518", Offset = "0x687518")]
		public Range[] ranges;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1612D44", Offset = "0x1612D44", VA = "0x1612D44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CBF8", Offset = "0x68CBF8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1612D8C", Offset = "0x1612D8C", VA = "0x1612D8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CC30", Offset = "0x68CC30")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1612DD4", Offset = "0x1612DD4", VA = "0x1612DD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CC68", Offset = "0x68CC68")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1612E1C", Offset = "0x1612E1C", VA = "0x1612E1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CCA0", Offset = "0x68CCA0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1612E64", Offset = "0x1612E64", VA = "0x1612E64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CCD8", Offset = "0x68CCD8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1612EAC", Offset = "0x1612EAC", VA = "0x1612EAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1611564", Offset = "0x1611564", VA = "0x1611564")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1612EB0", Offset = "0x1612EB0", VA = "0x1612EB0")]
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
			[Address(RVA = "0x128D7D4", Offset = "0x128D7D4", VA = "0x128D7D4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x128D82C", Offset = "0x128D82C", VA = "0x128D82C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x128D87C", Offset = "0x128D87C", VA = "0x128D87C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x128D8C8", Offset = "0x128D8C8", VA = "0x128D8C8")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x15A5580", Offset = "0x15A5580", VA = "0x15A5580", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CD10", Offset = "0x68CD10")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x15A5910", Offset = "0x15A5910", VA = "0x15A5910", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x15A5914", Offset = "0x15A5914", VA = "0x15A5914", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x15A5A1C", Offset = "0x15A5A1C", VA = "0x15A5A1C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x15A58A4", Offset = "0x15A58A4", VA = "0x15A58A4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x15A5804", Offset = "0x15A5804", VA = "0x15A5804")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x15A5A88", Offset = "0x15A5A88", VA = "0x15A5A88")]
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
		[Address(RVA = "0x15ACA1C", Offset = "0x15ACA1C", VA = "0x15ACA1C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x15ACAF8", Offset = "0x15ACAF8", VA = "0x15ACAF8", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x15ACCE0", Offset = "0x15ACCE0", VA = "0x15ACCE0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x15ACDDC", Offset = "0x15ACDDC", VA = "0x15ACDDC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x15ACB5C", Offset = "0x15ACB5C", VA = "0x15ACB5C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x15AD13C", Offset = "0x15AD13C", VA = "0x15AD13C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6879DC", Offset = "0x6879DC")]
		public float weight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6879F4", Offset = "0x6879F4")]
		public float localRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687A0C", Offset = "0x687A0C")]
		public float localPositionWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600054D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1442A78", Offset = "0x1442A78", VA = "0x1442A78")]
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
		[Address(RVA = "0x1442A84", Offset = "0x1442A84", VA = "0x1442A84", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1442AD8", Offset = "0x1442AD8", VA = "0x1442AD8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1442B14", Offset = "0x1442B14", VA = "0x1442B14", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1442B2C", Offset = "0x1442B2C", VA = "0x1442B2C")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682198", Offset = "0x682198")]
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
			[Address(RVA = "0x17EADE4", Offset = "0x17EADE4", VA = "0x17EADE4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x17EAFA8", Offset = "0x17EAFA8", VA = "0x17EAFA8")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x17EB088", Offset = "0x17EB088", VA = "0x17EB088")]
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
			[Address(RVA = "0x17EABDC", Offset = "0x17EABDC", VA = "0x17EABDC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x17EAC54", Offset = "0x17EAC54", VA = "0x17EAC54")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x17EAD94", Offset = "0x17EAD94", VA = "0x17EAD94")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6821F8", Offset = "0x6821F8")]
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
				[Address(RVA = "0x17EAB8C", Offset = "0x17EAB8C", VA = "0x17EAB8C", Slot = "4")]
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
				[Address(RVA = "0x17EABD4", Offset = "0x17EABD4", VA = "0x17EABD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x17EA950", Offset = "0x17EA950", VA = "0x17EA950")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x17EA97C", Offset = "0x17EA97C", VA = "0x17EA97C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x17EA980", Offset = "0x17EA980", VA = "0x17EA980", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x17EAB94", Offset = "0x17EAB94", VA = "0x17EAB94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687A24", Offset = "0x687A24")]
		public IK ik;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687A5C", Offset = "0x687A5C")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687A94", Offset = "0x687A94")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687ACC", Offset = "0x687ACC")]
		public float applyVelocity;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687B04", Offset = "0x687B04")]
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
			[Address(RVA = "0x144345C", Offset = "0x144345C", VA = "0x144345C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1443E90", Offset = "0x1443E90", VA = "0x1443E90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1443424", Offset = "0x1443424", VA = "0x1443424")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x14434D4", Offset = "0x14434D4", VA = "0x14434D4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1443610", Offset = "0x1443610", VA = "0x1443610")]
		public void Start()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1443598", Offset = "0x1443598", VA = "0x1443598")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68CD48", Offset = "0x68CD48")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1443ACC", Offset = "0x1443ACC", VA = "0x1443ACC")]
		private void Update()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1443D18", Offset = "0x1443D18", VA = "0x1443D18")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1443DD4", Offset = "0x1443DD4", VA = "0x1443DD4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1444010", Offset = "0x1444010", VA = "0x1444010")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1443E54", Offset = "0x1443E54", VA = "0x1443E54")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1443FCC", Offset = "0x1443FCC", VA = "0x1443FCC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x14440B0", Offset = "0x14440B0", VA = "0x14440B0")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1444044", Offset = "0x1444044", VA = "0x1444044")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x144352C", Offset = "0x144352C", VA = "0x144352C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1443D58", Offset = "0x1443D58", VA = "0x1443D58")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x14442DC", Offset = "0x14442DC", VA = "0x14442DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1444418", Offset = "0x1444418", VA = "0x1444418")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x687B4C", Offset = "0x687B4C")]
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
			[Address(RVA = "0x1445BF0", Offset = "0x1445BF0", VA = "0x1445BF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1445BFC", Offset = "0x1445BFC", VA = "0x1445BFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1445C18", Offset = "0x1445C18", VA = "0x1445C18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CDF8", Offset = "0x68CDF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x1445C20", Offset = "0x1445C20", VA = "0x1445C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CE08", Offset = "0x68CE08")]
			private set
			{
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x14458F0", Offset = "0x14458F0", VA = "0x14458F0")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1445938", Offset = "0x1445938", VA = "0x1445938")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1445950", Offset = "0x1445950", VA = "0x1445950")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1445B48", Offset = "0x1445B48", VA = "0x1445B48")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1445BB8", Offset = "0x1445BB8", VA = "0x1445BB8")]
		public void Disable()
		{
		}

		[Token(Token = "0x600057D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1445A70", Offset = "0x1445A70", VA = "0x1445A70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1445C2C", Offset = "0x1445C2C", VA = "0x1445C2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1445C30", Offset = "0x1445C30", VA = "0x1445C30")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1445C64", Offset = "0x1445C64", VA = "0x1445C64")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1445CE0", Offset = "0x1445CE0", VA = "0x1445CE0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1445E74", Offset = "0x1445E74", VA = "0x1445E74")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1445EE4", Offset = "0x1445EE4", VA = "0x1445EE4")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x682208", Offset = "0x682208")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682208", Offset = "0x682208")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687B5C", Offset = "0x687B5C")]
		public float limit;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687B78", Offset = "0x687B78")]
		public float twistLimit;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1445F18", Offset = "0x1445F18", VA = "0x1445F18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CE18", Offset = "0x68CE18")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1445F60", Offset = "0x1445F60", VA = "0x1445F60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CE50", Offset = "0x68CE50")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1445FA8", Offset = "0x1445FA8", VA = "0x1445FA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CE88", Offset = "0x68CE88")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1445FF0", Offset = "0x1445FF0", VA = "0x1445FF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CEC0", Offset = "0x68CEC0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1446038", Offset = "0x1446038", VA = "0x1446038", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x144607C", Offset = "0x144607C", VA = "0x144607C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x144623C", Offset = "0x144623C", VA = "0x144623C")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682268", Offset = "0x682268")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x682268", Offset = "0x682268")]
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
		[Address(RVA = "0x144627C", Offset = "0x144627C", VA = "0x144627C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CEF8", Offset = "0x68CEF8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x14462C4", Offset = "0x14462C4", VA = "0x14462C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CF30", Offset = "0x68CF30")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x144630C", Offset = "0x144630C", VA = "0x144630C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CF68", Offset = "0x68CF68")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1446354", Offset = "0x1446354", VA = "0x1446354")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CFA0", Offset = "0x68CFA0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x144639C", Offset = "0x144639C", VA = "0x144639C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x14463C4", Offset = "0x14463C4", VA = "0x14463C4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x14465C0", Offset = "0x14465C0", VA = "0x14465C0")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6822C8", Offset = "0x6822C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6822C8", Offset = "0x6822C8")]
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
				[Address(RVA = "0x17EB6D4", Offset = "0x17EB6D4", VA = "0x17EB6D4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x17EB70C", Offset = "0x17EB70C", VA = "0x17EB70C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x17EB748", Offset = "0x17EB748", VA = "0x17EB748")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x17EB784", Offset = "0x17EB784", VA = "0x17EB784")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x17EB910", Offset = "0x17EB910", VA = "0x17EB910")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x17EB7C0", Offset = "0x17EB7C0", VA = "0x17EB7C0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x17EB920", Offset = "0x17EB920", VA = "0x17EB920")]
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
			[Address(RVA = "0x17EB698", Offset = "0x17EB698", VA = "0x17EB698")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687BA4", Offset = "0x687BA4")]
		public float twistLimit;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687BC0", Offset = "0x687BC0")]
		public int smoothIterations;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
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
		[Address(RVA = "0x1446618", Offset = "0x1446618", VA = "0x1446618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68CFD8", Offset = "0x68CFD8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1446660", Offset = "0x1446660", VA = "0x1446660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D010", Offset = "0x68D010")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x14466A8", Offset = "0x14466A8", VA = "0x14466A8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D048", Offset = "0x68D048")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x14466F0", Offset = "0x14466F0", VA = "0x14466F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D080", Offset = "0x68D080")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1446738", Offset = "0x1446738", VA = "0x1446738")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1446C34", Offset = "0x1446C34", VA = "0x1446C34", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1446CC8", Offset = "0x1446CC8", VA = "0x1446CC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x144723C", Offset = "0x144723C", VA = "0x144723C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x14467E0", Offset = "0x14467E0", VA = "0x14467E0")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x14475E8", Offset = "0x14475E8", VA = "0x14475E8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x14479F4", Offset = "0x14479F4", VA = "0x14479F4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1447A38", Offset = "0x1447A38", VA = "0x1447A38")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1447A98", Offset = "0x1447A98", VA = "0x1447A98")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1446FCC", Offset = "0x1446FCC", VA = "0x1446FCC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1447B04", Offset = "0x1447B04", VA = "0x1447B04")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1447BE0", Offset = "0x1447BE0", VA = "0x1447BE0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682328", Offset = "0x682328")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x682328", Offset = "0x682328")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687C80", Offset = "0x687C80")]
		public float twistLimit;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1447C60", Offset = "0x1447C60", VA = "0x1447C60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D0B8", Offset = "0x68D0B8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1447CA8", Offset = "0x1447CA8", VA = "0x1447CA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D0F0", Offset = "0x68D0F0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1447CF0", Offset = "0x1447CF0", VA = "0x1447CF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D128", Offset = "0x68D128")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1447D38", Offset = "0x1447D38", VA = "0x1447D38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x68D160", Offset = "0x68D160")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1447D80", Offset = "0x1447D80", VA = "0x1447D80")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1447D9C", Offset = "0x1447D9C", VA = "0x1447D9C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1447DE0", Offset = "0x1447DE0", VA = "0x1447DE0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1448004", Offset = "0x1448004", VA = "0x1448004")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682388", Offset = "0x682388")]
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
				[Address(RVA = "0x12896C0", Offset = "0x12896C0", VA = "0x12896C0", Slot = "4")]
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
				[Address(RVA = "0x1289708", Offset = "0x1289708", VA = "0x1289708", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x12895C4", Offset = "0x12895C4", VA = "0x12895C4")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x12895F0", Offset = "0x12895F0", VA = "0x12895F0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x12895F4", Offset = "0x12895F4", VA = "0x12895F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x12896C8", Offset = "0x12896C8", VA = "0x12896C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687CD4", Offset = "0x687CD4")]
		public AimIK ik;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687D0C", Offset = "0x687D0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687D0C", Offset = "0x687D0C")]
		public float weight;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x687D60", Offset = "0x687D60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687D60", Offset = "0x687D60")]
		public Transform target;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687DC0", Offset = "0x687DC0")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687DF8", Offset = "0x687DF8")]
		public float weightSmoothTime;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x687E30", Offset = "0x687E30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687E30", Offset = "0x687E30")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687E90", Offset = "0x687E90")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687EC8", Offset = "0x687EC8")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687F00", Offset = "0x687F00")]
		public float slerpSpeed;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687F38", Offset = "0x687F38")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687F70", Offset = "0x687F70")]
		public float minDistance;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687FA8", Offset = "0x687FA8")]
		public Vector3 offset;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x687FE0", Offset = "0x687FE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x687FE0", Offset = "0x687FE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x687FE0", Offset = "0x687FE0")]
		public float maxRootAngle;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68805C", Offset = "0x68805C")]
		public bool turnToTarget;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688094", Offset = "0x688094")]
		public float turnToTargetTime;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6880CC", Offset = "0x6880CC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6880CC", Offset = "0x6880CC")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68812C", Offset = "0x68812C")]
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
			[Address(RVA = "0x157011C", Offset = "0x157011C", VA = "0x157011C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1570090", Offset = "0x1570090", VA = "0x1570090")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x15701AC", Offset = "0x15701AC", VA = "0x15701AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1570718", Offset = "0x1570718", VA = "0x1570718")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1570804", Offset = "0x1570804", VA = "0x1570804")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1570A54", Offset = "0x1570A54", VA = "0x1570A54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D198", Offset = "0x68D198")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1570ACC", Offset = "0x1570ACC", VA = "0x1570ACC")]
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
			[Address(RVA = "0x1289710", Offset = "0x1289710", VA = "0x1289710")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x128989C", Offset = "0x128989C", VA = "0x128989C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x12898A4", Offset = "0x12898A4", VA = "0x12898A4")]
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
		[Address(RVA = "0x1570D3C", Offset = "0x1570D3C", VA = "0x1570D3C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1570E1C", Offset = "0x1570E1C", VA = "0x1570E1C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1570E88", Offset = "0x1570E88", VA = "0x1570E88")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6882EC", Offset = "0x6882EC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688324", Offset = "0x688324")]
				public float weight;

				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x17EE240", Offset = "0x17EE240", VA = "0x17EE240")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68819C", Offset = "0x68819C")]
			public Transform transform;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6881D4", Offset = "0x6881D4")]
			public Transform relativeTo;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68820C", Offset = "0x68820C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688244", Offset = "0x688244")]
			public float verticalWeight;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68827C", Offset = "0x68827C")]
			public float horizontalWeight;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6882B4", Offset = "0x6882B4")]
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
			[Address(RVA = "0x12898C0", Offset = "0x12898C0", VA = "0x12898C0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1289BEC", Offset = "0x1289BEC", VA = "0x1289BEC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1289BFC", Offset = "0x1289BFC", VA = "0x1289BFC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688164", Offset = "0x688164")]
		public Body[] bodies;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1570FA4", Offset = "0x1570FA4", VA = "0x1570FA4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x15710F0", Offset = "0x15710F0", VA = "0x15710F0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68835C", Offset = "0x68835C")]
		public float tiltSpeed;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688394", Offset = "0x688394")]
		public float tiltSensitivity;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6883CC", Offset = "0x6883CC")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688404", Offset = "0x688404")]
		public OffsetPose poseRight;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x157F254", Offset = "0x157F254", VA = "0x157F254", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x157F29C", Offset = "0x157F29C", VA = "0x157F29C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x157F454", Offset = "0x157F454", VA = "0x157F454")]
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
		[Address(RVA = "0xE9B364", Offset = "0xE9B364", VA = "0xE9B364")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xE9B408", Offset = "0xE9B408", VA = "0xE9B408")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xE9B4D4", Offset = "0xE9B4D4", VA = "0xE9B4D4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6884AC", Offset = "0x6884AC")]
			public string name;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6884E4", Offset = "0x6884E4")]
			public Collider collider;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68851C", Offset = "0x68851C")]
			private float crossFadeTime;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x688568", Offset = "0x688568")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x688578", Offset = "0x688578")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x688588", Offset = "0x688588")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x688598", Offset = "0x688598")]
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
				[Address(RVA = "0x128F3B0", Offset = "0x128F3B0", VA = "0x128F3B0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x128F3C4", Offset = "0x128F3C4", VA = "0x128F3C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D248", Offset = "0x68D248")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x128F3CC", Offset = "0x128F3CC", VA = "0x128F3CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D258", Offset = "0x68D258")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x128F3D4", Offset = "0x128F3D4", VA = "0x128F3D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D268", Offset = "0x68D268")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x128F3DC", Offset = "0x128F3DC", VA = "0x128F3DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D278", Offset = "0x68D278")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x128F3E4", Offset = "0x128F3E4", VA = "0x128F3E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D288", Offset = "0x68D288")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x128F3F0", Offset = "0x128F3F0", VA = "0x128F3F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D298", Offset = "0x68D298")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x128F3FC", Offset = "0x128F3FC", VA = "0x128F3FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D2A8", Offset = "0x68D2A8")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x128F408", Offset = "0x128F408", VA = "0x128F408")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D2B8", Offset = "0x68D2B8")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x128F414", Offset = "0x128F414", VA = "0x128F414")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x128F548", Offset = "0x128F548", VA = "0x128F548")]
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
			[Address(RVA = "0x128F61C", Offset = "0x128F61C", VA = "0x128F61C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688650", Offset = "0x688650")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000542")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688688", Offset = "0x688688")]
				public float weight;

				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x17EE3B0", Offset = "0x17EE3B0", VA = "0x17EE3B0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x17EE460", Offset = "0x17EE460", VA = "0x17EE460")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x17EE474", Offset = "0x17EE474", VA = "0x17EE474")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6885A8", Offset = "0x6885A8")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6885E0", Offset = "0x6885E0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688618", Offset = "0x688618")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x128F958", Offset = "0x128F958", VA = "0x128F958", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x128FA88", Offset = "0x128FA88", VA = "0x128FA88", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x128FAF4", Offset = "0x128FAF4", VA = "0x128FAF4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x128FC5C", Offset = "0x128FC5C", VA = "0x128FC5C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688730", Offset = "0x688730")]
				public Transform bone;

				[Token(Token = "0x4000549")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x688768", Offset = "0x688768")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688768", Offset = "0x688768")]
				public float weight;

				[Token(Token = "0x400054A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x17EE248", Offset = "0x17EE248", VA = "0x17EE248")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x17EE360", Offset = "0x17EE360", VA = "0x17EE360")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x17EE36C", Offset = "0x17EE36C", VA = "0x17EE36C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6886C0", Offset = "0x6886C0")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6886F8", Offset = "0x6886F8")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x128F630", Offset = "0x128F630", VA = "0x128F630", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x128F6D4", Offset = "0x128F6D4", VA = "0x128F6D4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x128F740", Offset = "0x128F740", VA = "0x128F740", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x128F944", Offset = "0x128F944", VA = "0x128F944")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68843C", Offset = "0x68843C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688474", Offset = "0x688474")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x15ADFE4", Offset = "0x15ADFE4", VA = "0x15ADFE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x15AE0B4", Offset = "0x15AE0B4", VA = "0x15AE0B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x15AE190", Offset = "0x15AE190", VA = "0x15AE190")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15AE3EC", Offset = "0x15AE3EC", VA = "0x15AE3EC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68882C", Offset = "0x68882C")]
			public string name;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688864", Offset = "0x688864")]
			public Collider collider;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68889C", Offset = "0x68889C")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6888E8", Offset = "0x6888E8")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6888F8", Offset = "0x6888F8")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x688908", Offset = "0x688908")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x688918", Offset = "0x688918")]
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
				[Address(RVA = "0x128FC70", Offset = "0x128FC70", VA = "0x128FC70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D2C8", Offset = "0x68D2C8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x128FC78", Offset = "0x128FC78", VA = "0x128FC78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D2D8", Offset = "0x68D2D8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x128FC80", Offset = "0x128FC80", VA = "0x128FC80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D2E8", Offset = "0x68D2E8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x128FC88", Offset = "0x128FC88", VA = "0x128FC88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D2F8", Offset = "0x68D2F8")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x128FC90", Offset = "0x128FC90", VA = "0x128FC90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D308", Offset = "0x68D308")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x128FC9C", Offset = "0x128FC9C", VA = "0x128FC9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D318", Offset = "0x68D318")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x128FCA8", Offset = "0x128FCA8", VA = "0x128FCA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D328", Offset = "0x68D328")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x128FCB4", Offset = "0x128FCB4", VA = "0x128FCB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D338", Offset = "0x68D338")]
				private set
				{
				}
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x128FCC0", Offset = "0x128FCC0", VA = "0x128FCC0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x128FE08", Offset = "0x128FE08", VA = "0x128FE08")]
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
			[Address(RVA = "0x128FEF0", Offset = "0x128FEF0", VA = "0x128FEF0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6889D0", Offset = "0x6889D0")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688A08", Offset = "0x688A08")]
				public float weight;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x17EE47C", Offset = "0x17EE47C", VA = "0x17EE47C")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x17EE50C", Offset = "0x17EE50C", VA = "0x17EE50C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060A")]
				[Address(RVA = "0x17EE520", Offset = "0x17EE520", VA = "0x17EE520")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688928", Offset = "0x688928")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688960", Offset = "0x688960")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688998", Offset = "0x688998")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x128FF04", Offset = "0x128FF04", VA = "0x128FF04", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x12900B4", Offset = "0x12900B4", VA = "0x12900B4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1290120", Offset = "0x1290120", VA = "0x1290120", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x12902C0", Offset = "0x12902C0", VA = "0x12902C0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688AB0", Offset = "0x688AB0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688AE8", Offset = "0x688AE8")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x688AE8", Offset = "0x688AE8")]
				public float weight;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x17EE528", Offset = "0x17EE528", VA = "0x17EE528")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x17EE604", Offset = "0x17EE604", VA = "0x17EE604")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x17EE610", Offset = "0x17EE610", VA = "0x17EE610")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688A40", Offset = "0x688A40")]
			public int curveIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688A78", Offset = "0x688A78")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x12902DC", Offset = "0x12902DC", VA = "0x12902DC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x12903C0", Offset = "0x12903C0", VA = "0x12903C0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x129042C", Offset = "0x129042C", VA = "0x129042C", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x12906E8", Offset = "0x12906E8", VA = "0x12906E8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6887BC", Offset = "0x6887BC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6887F4", Offset = "0x6887F4")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x15AE74C", Offset = "0x15AE74C", VA = "0x15AE74C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x15AE820", Offset = "0x15AE820", VA = "0x15AE820")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x15AEA84", Offset = "0x15AEA84", VA = "0x15AEA84")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688D18", Offset = "0x688D18")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688D50", Offset = "0x688D50")]
				public float weight;

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x17EE654", Offset = "0x17EE654", VA = "0x17EE654")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688BAC", Offset = "0x688BAC")]
			public Transform transform;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688BE4", Offset = "0x688BE4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688C1C", Offset = "0x688C1C")]
			public float speed;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688C54", Offset = "0x688C54")]
			public float acceleration;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x688C8C", Offset = "0x688C8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688C8C", Offset = "0x688C8C")]
			public float matchVelocity;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688CE0", Offset = "0x688CE0")]
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
			[Address(RVA = "0x17E75DC", Offset = "0x17E75DC", VA = "0x17E75DC")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x17E7694", Offset = "0x17E7694", VA = "0x17E7694")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x17E7950", Offset = "0x17E7950", VA = "0x17E7950")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688B3C", Offset = "0x688B3C")]
		public Body[] bodies;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688B74", Offset = "0x688B74")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1609E50", Offset = "0x1609E50", VA = "0x1609E50")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1609ECC", Offset = "0x1609ECC", VA = "0x1609ECC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1609F8C", Offset = "0x1609F8C", VA = "0x1609F8C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x688D88", Offset = "0x688D88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688D88", Offset = "0x688D88")]
		public Transform target;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x688DE8", Offset = "0x688DE8")]
		public float weight;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688E00", Offset = "0x688E00")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688E38", Offset = "0x688E38")]
		public float weightSmoothTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x688E70", Offset = "0x688E70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688E70", Offset = "0x688E70")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688ED0", Offset = "0x688ED0")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688F08", Offset = "0x688F08")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688F40", Offset = "0x688F40")]
		public float slerpSpeed;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688F78", Offset = "0x688F78")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688FB0", Offset = "0x688FB0")]
		public float minDistance;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x688FE8", Offset = "0x688FE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x688FE8", Offset = "0x688FE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x688FE8", Offset = "0x688FE8")]
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
			[Address(RVA = "0x1614154", Offset = "0x1614154", VA = "0x1614154")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x16140E0", Offset = "0x16140E0", VA = "0x16140E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x16141E4", Offset = "0x16141E4", VA = "0x16141E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1614718", Offset = "0x1614718", VA = "0x1614718")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1614804", Offset = "0x1614804", VA = "0x1614804")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x16149FC", Offset = "0x16149FC", VA = "0x16149FC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6890D4", Offset = "0x6890D4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68910C", Offset = "0x68910C")]
			public float spring;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689144", Offset = "0x689144")]
			public bool x;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68917C", Offset = "0x68917C")]
			public bool y;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6891B4", Offset = "0x6891B4")]
			public bool z;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6891EC", Offset = "0x6891EC")]
			public float minX;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689224", Offset = "0x689224")]
			public float maxX;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68925C", Offset = "0x68925C")]
			public float minY;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689294", Offset = "0x689294")]
			public float maxY;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6892CC", Offset = "0x6892CC")]
			public float minZ;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689304", Offset = "0x689304")]
			public float maxZ;

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x17E9D50", Offset = "0x17E9D50", VA = "0x17E9D50")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x17E9EA8", Offset = "0x17E9EA8", VA = "0x17E9EA8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x17E9F20", Offset = "0x17E9F20", VA = "0x17E9F20")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x17E9F78", Offset = "0x17E9F78", VA = "0x17E9F78")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6823A8", Offset = "0x6823A8")]
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
				[Address(RVA = "0x17E9D00", Offset = "0x17E9D00", VA = "0x17E9D00", Slot = "4")]
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
				[Address(RVA = "0x17E9D48", Offset = "0x17E9D48", VA = "0x17E9D48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x17E9B60", Offset = "0x17E9B60", VA = "0x17E9B60")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x17E9B8C", Offset = "0x17E9B8C", VA = "0x17E9B8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x17E9B90", Offset = "0x17E9B90", VA = "0x17E9B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x17E9D08", Offset = "0x17E9D08", VA = "0x17E9D08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689064", Offset = "0x689064")]
		public float weight;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68909C", Offset = "0x68909C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A9")]
		protected float deltaTime
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1440534", Offset = "0x1440534", VA = "0x1440534")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000620")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x143F290", Offset = "0x143F290", VA = "0x143F290", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x1440560", Offset = "0x1440560", VA = "0x1440560")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D348", Offset = "0x68D348")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x14405D8", Offset = "0x14405D8", VA = "0x14405D8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x14406B4", Offset = "0x14406B4", VA = "0x14406B4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x143F624", Offset = "0x143F624", VA = "0x143F624", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x143F768", Offset = "0x143F768", VA = "0x143F768")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6823B8", Offset = "0x6823B8")]
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
				[Address(RVA = "0x17EA120", Offset = "0x17EA120", VA = "0x17EA120", Slot = "4")]
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
				[Address(RVA = "0x17EA168", Offset = "0x17EA168", VA = "0x17EA168", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x17E9F80", Offset = "0x17E9F80", VA = "0x17E9F80")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x17E9FAC", Offset = "0x17E9FAC", VA = "0x17E9FAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x17E9FB0", Offset = "0x17E9FB0", VA = "0x17E9FB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x17EA128", Offset = "0x17EA128", VA = "0x17EA128", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68933C", Offset = "0x68933C")]
		public float weight;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689374", Offset = "0x689374")]
		public VRIK ik;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1440774", Offset = "0x1440774", VA = "0x1440774")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x14407A0", Offset = "0x14407A0", VA = "0x14407A0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x14407CC", Offset = "0x14407CC", VA = "0x14407CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D3F8", Offset = "0x68D3F8")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1440844", Offset = "0x1440844", VA = "0x1440844")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1440920", Offset = "0x1440920", VA = "0x1440920", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1440A50", Offset = "0x1440A50", VA = "0x1440A50")]
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
			[Address(RVA = "0x17EA170", Offset = "0x17EA170", VA = "0x17EA170")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x17EA38C", Offset = "0x17EA38C", VA = "0x17EA38C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1440A60", Offset = "0x1440A60", VA = "0x1440A60")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1440B24", Offset = "0x1440B24", VA = "0x1440B24")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1440BE0", Offset = "0x1440BE0", VA = "0x1440BE0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689588", Offset = "0x689588")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6895C0", Offset = "0x6895C0")]
				public float weight;

				[Token(Token = "0x6000649")]
				[Address(RVA = "0x17EE664", Offset = "0x17EE664", VA = "0x17EE664")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6893E4", Offset = "0x6893E4")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68941C", Offset = "0x68941C")]
			public Transform raycastTo;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689454", Offset = "0x689454")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x689454", Offset = "0x689454")]
			public float raycastRadius;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6894A8", Offset = "0x6894A8")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6894E0", Offset = "0x6894E0")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689518", Offset = "0x689518")]
			public float smoothTimeOut;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689550", Offset = "0x689550")]
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
			[Address(RVA = "0x17EA394", Offset = "0x17EA394", VA = "0x17EA394")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x17EA4D8", Offset = "0x17EA4D8", VA = "0x17EA4D8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x17EA5D0", Offset = "0x17EA5D0", VA = "0x17EA5D0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x17EA7A0", Offset = "0x17EA7A0", VA = "0x17EA7A0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6893AC", Offset = "0x6893AC")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x14415A0", Offset = "0x14415A0", VA = "0x14415A0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1441628", Offset = "0x1441628", VA = "0x1441628")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68994C", Offset = "0x68994C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689984", Offset = "0x689984")]
				public float weight;

				[Token(Token = "0x6000659")]
				[Address(RVA = "0x17EE66C", Offset = "0x17EE66C", VA = "0x17EE66C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689850", Offset = "0x689850")]
			public Vector3 offset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689888", Offset = "0x689888")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x689888", Offset = "0x689888")]
			public float additivity;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6898DC", Offset = "0x6898DC")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689914", Offset = "0x689914")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x17EB22C", Offset = "0x17EB22C", VA = "0x17EB22C")]
			public void Start()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x17EB27C", Offset = "0x17EB27C", VA = "0x17EB27C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x17EB440", Offset = "0x17EB440", VA = "0x17EB440")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6895F8", Offset = "0x6895F8")]
		public AimIK aimIK;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689630", Offset = "0x689630")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689668", Offset = "0x689668")]
		public Handedness handedness;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6896A0", Offset = "0x6896A0")]
		public bool twoHanded;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6896D8", Offset = "0x6896D8")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689710", Offset = "0x689710")]
		public float magnitudeRandom;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689748", Offset = "0x689748")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689780", Offset = "0x689780")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6897B8", Offset = "0x6897B8")]
		public float blendTime;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6897F0", Offset = "0x6897F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6897F0", Offset = "0x6897F0")]
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
			[Address(RVA = "0x144473C", Offset = "0x144473C", VA = "0x144473C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x14451D8", Offset = "0x14451D8", VA = "0x14451D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1445218", Offset = "0x1445218", VA = "0x1445218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1445198", Offset = "0x1445198", VA = "0x1445198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x14451B8", Offset = "0x14451B8", VA = "0x14451B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x144476C", Offset = "0x144476C", VA = "0x144476C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1444798", Offset = "0x1444798", VA = "0x1444798")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x14448E0", Offset = "0x14448E0", VA = "0x14448E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1445258", Offset = "0x1445258", VA = "0x1445258")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x144530C", Offset = "0x144530C", VA = "0x144530C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1445348", Offset = "0x1445348", VA = "0x1445348", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1445534", Offset = "0x1445534", VA = "0x1445534")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6899BC", Offset = "0x6899BC")]
		public float weight;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6899F4", Offset = "0x6899F4")]
		public float offset;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1448240", Offset = "0x1448240", VA = "0x1448240")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1448348", Offset = "0x1448348", VA = "0x1448348")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1448430", Offset = "0x1448430", VA = "0x1448430")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1448784", Offset = "0x1448784", VA = "0x1448784")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x14487BC", Offset = "0x14487BC", VA = "0x14487BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x14488EC", Offset = "0x14488EC", VA = "0x14488EC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689A2C", Offset = "0x689A2C")]
			public float scaleMlp;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689A64", Offset = "0x689A64")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689A9C", Offset = "0x689A9C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689AD4", Offset = "0x689AD4")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689B0C", Offset = "0x689B0C")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689B44", Offset = "0x689B44")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689B7C", Offset = "0x689B7C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689BB4", Offset = "0x689BB4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689BEC", Offset = "0x689BEC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689C24", Offset = "0x689C24")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x689C24", Offset = "0x689C24")]
			public Vector3 headOffset;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689C74", Offset = "0x689C74")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689CAC", Offset = "0x689CAC")]
			public float footForwardOffset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689CE4", Offset = "0x689CE4")]
			public float footInwardOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689D1C", Offset = "0x689D1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x689D1C", Offset = "0x689D1C")]
			public float footHeadingOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x689D78", Offset = "0x689D78")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x689D90", Offset = "0x689D90")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x17EDDD4", Offset = "0x17EDDD4", VA = "0x17EDDD4")]
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
				[Address(RVA = "0x17EE674", Offset = "0x17EE674", VA = "0x17EE674")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0x17EE734", Offset = "0x17EE734", VA = "0x17EE734")]
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
			[Address(RVA = "0x17EDDCC", Offset = "0x17EDDCC", VA = "0x17EDDCC")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x144EC8C", Offset = "0x144EC8C", VA = "0x144EC8C")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x144CF08", Offset = "0x144CF08", VA = "0x144CF08")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x144EDF4", Offset = "0x144EDF4", VA = "0x144EDF4")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x144E18C", Offset = "0x144E18C", VA = "0x144E18C")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x144F638", Offset = "0x144F638", VA = "0x144F638")]
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
		[Address(RVA = "0x144FA8C", Offset = "0x144FA8C", VA = "0x144FA8C")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x144FAE8", Offset = "0x144FAE8", VA = "0x144FAE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x144FB1C", Offset = "0x144FB1C", VA = "0x144FB1C")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x144FC58", Offset = "0x144FC58", VA = "0x144FC58")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x689DA8", Offset = "0x689DA8")]
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
			[Address(RVA = "0x1450360", Offset = "0x1450360", VA = "0x1450360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D4A8", Offset = "0x68D4A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x145036C", Offset = "0x145036C", VA = "0x145036C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D4B8", Offset = "0x68D4B8")]
			private set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1450378", Offset = "0x1450378", VA = "0x1450378")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x144F408", Offset = "0x144F408", VA = "0x144F408")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x144F8D0", Offset = "0x144F8D0", VA = "0x144F8D0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1450488", Offset = "0x1450488", VA = "0x1450488")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x14508A4", Offset = "0x14508A4", VA = "0x14508A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x14509D4", Offset = "0x14509D4", VA = "0x14509D4")]
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
			[HideInInspector]
			[SerializeField]
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
			[Address(RVA = "0x128D658", Offset = "0x128D658", VA = "0x128D658")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x128D7CC", Offset = "0x128D7CC", VA = "0x128D7CC")]
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
		[Address(RVA = "0xEA2630", Offset = "0xEA2630", VA = "0xEA2630")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xEA268C", Offset = "0xEA268C", VA = "0xEA268C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xEA2708", Offset = "0xEA2708", VA = "0xEA2708")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xEA27EC", Offset = "0xEA27EC", VA = "0xEA27EC")]
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
		[Address(RVA = "0x1570004", Offset = "0x1570004", VA = "0x1570004")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1570088", Offset = "0x1570088", VA = "0x1570088")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689DF0", Offset = "0x689DF0")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1570EF8", Offset = "0x1570EF8", VA = "0x1570EF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1570F70", Offset = "0x1570F70", VA = "0x1570F70")]
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
		[Address(RVA = "0x1448040", Offset = "0x1448040", VA = "0x1448040")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1448084", Offset = "0x1448084", VA = "0x1448084")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1448238", Offset = "0x1448238", VA = "0x1448238")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689E28", Offset = "0x689E28")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689E60", Offset = "0x689E60")]
		public AimIK aim;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689E98", Offset = "0x689E98")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689ED0", Offset = "0x689ED0")]
		public Animator animator;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689F08", Offset = "0x689F08")]
		public float crossfadeTime;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x689F40", Offset = "0x689F40")]
		public float minAimDistance;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1448900", Offset = "0x1448900", VA = "0x1448900")]
		private void Start()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1448944", Offset = "0x1448944", VA = "0x1448944")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1448AAC", Offset = "0x1448AAC", VA = "0x1448AAC")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1448C58", Offset = "0x1448C58", VA = "0x1448C58")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1448D94", Offset = "0x1448D94", VA = "0x1448D94")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1448E10", Offset = "0x1448E10", VA = "0x1448E10")]
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
		[Address(RVA = "0x1449E04", Offset = "0x1449E04", VA = "0x1449E04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1449F74", Offset = "0x1449F74", VA = "0x1449F74")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x144A108", Offset = "0x144A108", VA = "0x144A108")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x689F78", Offset = "0x689F78")]
		public Animator animator;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x689FB0", Offset = "0x689FB0")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x689FE8", Offset = "0x689FE8")]
		public float lookAtWeight;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A000", Offset = "0x68A000")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A018", Offset = "0x68A018")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A030", Offset = "0x68A030")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A048", Offset = "0x68A048")]
		public float lookAtClampWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A060", Offset = "0x68A060")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A078", Offset = "0x68A078")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x68A090", Offset = "0x68A090")]
		public Transform footTargetBiped;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A0C8", Offset = "0x68A0C8")]
		public float footPositionWeight;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A0E0", Offset = "0x68A0E0")]
		public float footRotationWeight;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x68A0F8", Offset = "0x68A0F8")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A130", Offset = "0x68A130")]
		public float handPositionWeight;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A148", Offset = "0x68A148")]
		public float handRotationWeight;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x15778D4", Offset = "0x15778D4", VA = "0x15778D4")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1577CDC", Offset = "0x1577CDC", VA = "0x1577CDC")]
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
		[Address(RVA = "0x1614C04", Offset = "0x1614C04", VA = "0x1614C04")]
		private void Update()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1615410", Offset = "0x1615410", VA = "0x1615410")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x16151C0", Offset = "0x16151C0", VA = "0x16151C0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x161550C", Offset = "0x161550C", VA = "0x161550C")]
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
			[Address(RVA = "0x1615538", Offset = "0x1615538", VA = "0x1615538")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x16155BC", Offset = "0x16155BC", VA = "0x16155BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x16157E0", Offset = "0x16157E0", VA = "0x16157E0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6823C8", Offset = "0x6823C8")]
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
				[Address(RVA = "0x17E9894", Offset = "0x17E9894", VA = "0x17E9894", Slot = "4")]
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
				[Address(RVA = "0x17E98DC", Offset = "0x17E98DC", VA = "0x17E98DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x17E9598", Offset = "0x17E9598", VA = "0x17E9598")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x17E95C4", Offset = "0x17E95C4", VA = "0x17E95C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x17E95C8", Offset = "0x17E95C8", VA = "0x17E95C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x17E989C", Offset = "0x17E989C", VA = "0x17E989C", Slot = "8")]
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
			[Address(RVA = "0x16157F4", Offset = "0x16157F4", VA = "0x16157F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x16154D8", Offset = "0x16154D8", VA = "0x16154D8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1615808", Offset = "0x1615808", VA = "0x1615808")]
			set
			{
			}
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1615858", Offset = "0x1615858", VA = "0x1615858")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1615A84", Offset = "0x1615A84", VA = "0x1615A84")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1615C20", Offset = "0x1615C20", VA = "0x1615C20")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1615E54", Offset = "0x1615E54", VA = "0x1615E54")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x16160F8", Offset = "0x16160F8", VA = "0x16160F8")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1616270", Offset = "0x1616270", VA = "0x1616270")]
		private void Update()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1615DA0", Offset = "0x1615DA0", VA = "0x1615DA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D4C8", Offset = "0x68D4C8")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x161646C", Offset = "0x161646C", VA = "0x161646C")]
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
		[Address(RVA = "0x143EE64", Offset = "0x143EE64", VA = "0x143EE64")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x143EF34", Offset = "0x143EF34", VA = "0x143EF34")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x143F18C", Offset = "0x143F18C", VA = "0x143F18C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A220", Offset = "0x68A220")]
			public int animationLayer;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A258", Offset = "0x68A258")]
			public string animationState;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A290", Offset = "0x68A290")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A2C8", Offset = "0x68A2C8")]
			public Transform warpFrom;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A300", Offset = "0x68A300")]
			public Transform warpTo;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A338", Offset = "0x68A338")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A160", Offset = "0x68A160")]
		public Animator animator;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A198", Offset = "0x68A198")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A1D0", Offset = "0x68A1D0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x68A1D0", Offset = "0x68A1D0")]
		public Warp[] warps;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x15710F8", Offset = "0x15710F8", VA = "0x15710F8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1571124", Offset = "0x1571124", VA = "0x1571124")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1571364", Offset = "0x1571364", VA = "0x1571364", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1571628", Offset = "0x1571628", VA = "0x1571628")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x15716C8", Offset = "0x15716C8", VA = "0x15716C8")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6823D8", Offset = "0x6823D8")]
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
		[Address(RVA = "0x15716D0", Offset = "0x15716D0", VA = "0x15716D0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x157172C", Offset = "0x157172C", VA = "0x157172C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x15718C8", Offset = "0x15718C8", VA = "0x15718C8", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1571AD0", Offset = "0x1571AD0", VA = "0x1571AD0")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682438", Offset = "0x682438")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682438", Offset = "0x682438")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A370", Offset = "0x68A370")]
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
		[Address(RVA = "0x1571AE4", Offset = "0x1571AE4", VA = "0x1571AE4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1571CB0", Offset = "0x1571CB0", VA = "0x1571CB0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1571D2C", Offset = "0x1571D2C", VA = "0x1571D2C")]
		private void Read()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1571E20", Offset = "0x1571E20", VA = "0x1571E20")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1571E68", Offset = "0x1571E68", VA = "0x1571E68")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1572254", Offset = "0x1572254", VA = "0x1572254")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x15720DC", Offset = "0x15720DC", VA = "0x15720DC")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x15724B0", Offset = "0x15724B0", VA = "0x15724B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x15725E0", Offset = "0x15725E0", VA = "0x15725E0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6824CC", Offset = "0x6824CC")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1580F34", Offset = "0x1580F34", VA = "0x1580F34", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1580F98", Offset = "0x1580F98", VA = "0x1580F98", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x15811D4", Offset = "0x15811D4", VA = "0x15811D4")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x15812C8", Offset = "0x15812C8", VA = "0x15812C8")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x68252C", Offset = "0x68252C")]
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
			[Address(RVA = "0x1581D24", Offset = "0x1581D24", VA = "0x1581D24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1581DA8", Offset = "0x1581DA8", VA = "0x1581DA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1581B24", Offset = "0x1581B24", VA = "0x1581B24")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1581B98", Offset = "0x1581B98", VA = "0x1581B98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1581E2C", Offset = "0x1581E2C", VA = "0x1581E2C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A388", Offset = "0x68A388")]
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
		[Address(RVA = "0xE9B4DC", Offset = "0xE9B4DC", VA = "0xE9B4DC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xE9B93C", Offset = "0xE9B93C", VA = "0xE9B93C")]
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
		[Address(RVA = "0xE9B944", Offset = "0xE9B944", VA = "0xE9B944")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xE9BA00", Offset = "0xE9BA00", VA = "0xE9BA00")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xE9BD84", Offset = "0xE9BD84", VA = "0xE9BD84")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xE9BE30", Offset = "0xE9BE30", VA = "0xE9BE30")]
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
			[Address(RVA = "0x128D124", Offset = "0x128D124", VA = "0x128D124")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x128D1A8", Offset = "0x128D1A8", VA = "0x128D1A8")]
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
		[Address(RVA = "0xE9F8C4", Offset = "0xE9F8C4", VA = "0xE9F8C4")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xE9FA1C", Offset = "0xE9FA1C", VA = "0xE9FA1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xE9FAC0", Offset = "0xE9FAC0", VA = "0xE9FAC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xE9FAC4", Offset = "0xE9FAC4", VA = "0xE9FAC4")]
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
		[Address(RVA = "0xE9FAD4", Offset = "0xE9FAD4", VA = "0xE9FAD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xE9FB48", Offset = "0xE9FB48", VA = "0xE9FB48")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xE9FC28", Offset = "0xE9FC28", VA = "0xE9FC28")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A3A0", Offset = "0x68A3A0")]
		public Transform target;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A3D8", Offset = "0x68A3D8")]
		public Transform pin;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A410", Offset = "0x68A410")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A448", Offset = "0x68A448")]
		public AimIK aim;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A480", Offset = "0x68A480")]
		public float weight;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A4B8", Offset = "0x68A4B8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A4F0", Offset = "0x68A4F0")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xE9FC30", Offset = "0xE9FC30", VA = "0xE9FC30")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xE9FC8C", Offset = "0xE9FC8C", VA = "0xE9FC8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xE9FE30", Offset = "0xE9FE30", VA = "0xE9FE30")]
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
		[Address(RVA = "0xEA1FB8", Offset = "0xEA1FB8", VA = "0xEA1FB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xEA2090", Offset = "0xEA2090", VA = "0xEA2090")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xEA2120", Offset = "0xEA2120", VA = "0xEA2120")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xEA24F8", Offset = "0xEA24F8", VA = "0xEA24F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xEA2628", Offset = "0xEA2628", VA = "0xEA2628")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A528", Offset = "0x68A528")]
		public float aimWeight;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A540", Offset = "0x68A540")]
		public float sightWeight;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A558", Offset = "0x68A558")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A574", Offset = "0x68A574")]
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
		[Address(RVA = "0xEA27F4", Offset = "0xEA27F4", VA = "0xEA27F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xEA2968", Offset = "0xEA2968", VA = "0xEA2968")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xEA2974", Offset = "0xEA2974", VA = "0xEA2974")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xEA2BF4", Offset = "0xEA2BF4", VA = "0xEA2BF4")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xEA2DA0", Offset = "0xEA2DA0", VA = "0xEA2DA0")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xEA2A3C", Offset = "0xEA2A3C", VA = "0xEA2A3C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xEA3694", Offset = "0xEA3694", VA = "0xEA3694")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x68258C", Offset = "0x68258C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x68258C", Offset = "0x68258C")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A58C", Offset = "0x68A58C")]
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
		[Address(RVA = "0x15A2C8C", Offset = "0x15A2C8C", VA = "0x15A2C8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x15A2D18", Offset = "0x15A2D18", VA = "0x15A2D18")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x15A2E04", Offset = "0x15A2E04", VA = "0x15A2E04")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x15A2EBC", Offset = "0x15A2EBC", VA = "0x15A2EBC")]
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
		[Address(RVA = "0x15AE3F4", Offset = "0x15AE3F4", VA = "0x15AE3F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x15AE558", Offset = "0x15AE558", VA = "0x15AE558")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x15AE73C", Offset = "0x15AE73C", VA = "0x15AE73C")]
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
		[Address(RVA = "0x15AEDE4", Offset = "0x15AEDE4", VA = "0x15AEDE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x15AEF2C", Offset = "0x15AEF2C", VA = "0x15AEF2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x15AF268", Offset = "0x15AF268", VA = "0x15AF268")]
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
		[Address(RVA = "0x160A0B0", Offset = "0x160A0B0", VA = "0x160A0B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x160A2FC", Offset = "0x160A2FC", VA = "0x160A2FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x160A408", Offset = "0x160A408", VA = "0x160A408")]
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
		[Address(RVA = "0x160A410", Offset = "0x160A410", VA = "0x160A410")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x160AC24", Offset = "0x160AC24", VA = "0x160AC24")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682620", Offset = "0x682620")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A5A4", Offset = "0x68A5A4")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A5DC", Offset = "0x68A5DC")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1612720", Offset = "0x1612720", VA = "0x1612720")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x161277C", Offset = "0x161277C", VA = "0x161277C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1612AB4", Offset = "0x1612AB4", VA = "0x1612AB4")]
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
				[Address(RVA = "0x17E952C", Offset = "0x17E952C", VA = "0x17E952C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x17E8DE0", Offset = "0x17E8DE0", VA = "0x17E8DE0")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x17E8E00", Offset = "0x17E8E00", VA = "0x17E8E00")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x17E9398", Offset = "0x17E9398", VA = "0x17E9398")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x17E9584", Offset = "0x17E9584", VA = "0x17E9584")]
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
		[Address(RVA = "0x1613680", Offset = "0x1613680", VA = "0x1613680")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x16136BC", Offset = "0x16136BC", VA = "0x16136BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1613724", Offset = "0x1613724", VA = "0x1613724")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A6F4", Offset = "0x68A6F4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A72C", Offset = "0x68A72C")]
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
			[Address(RVA = "0x17E98E4", Offset = "0x17E98E4", VA = "0x17E98E4")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x17E99CC", Offset = "0x17E99CC", VA = "0x17E99CC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x17E9A08", Offset = "0x17E9A08", VA = "0x17E9A08")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x17E9AA0", Offset = "0x17E9AA0", VA = "0x17E9AA0")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x17E9B14", Offset = "0x17E9B14", VA = "0x17E9B14")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A614", Offset = "0x68A614")]
		public Mode mode;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A64C", Offset = "0x68A64C")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A684", Offset = "0x68A684")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A6BC", Offset = "0x68A6BC")]
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
		[Address(RVA = "0x143F194", Offset = "0x143F194", VA = "0x143F194", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x143F2BC", Offset = "0x143F2BC", VA = "0x143F2BC")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x143F34C", Offset = "0x143F34C", VA = "0x143F34C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x143F460", Offset = "0x143F460", VA = "0x143F460")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x143F4EC", Offset = "0x143F4EC", VA = "0x143F4EC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x143F754", Offset = "0x143F754", VA = "0x143F754")]
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
		[Address(RVA = "0x143F778", Offset = "0x143F778", VA = "0x143F778")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x143F7F4", Offset = "0x143F7F4", VA = "0x143F7F4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x143F8D0", Offset = "0x143F8D0", VA = "0x143F8D0")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x143F990", Offset = "0x143F990", VA = "0x143F990")]
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
			[Address(RVA = "0x17E9B50", Offset = "0x17E9B50", VA = "0x17E9B50")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x144028C", Offset = "0x144028C", VA = "0x144028C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1440398", Offset = "0x1440398", VA = "0x1440398", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1440524", Offset = "0x1440524", VA = "0x1440524")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682680", Offset = "0x682680")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A774", Offset = "0x68A774")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A774", Offset = "0x68A774")]
		public float weight;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A7C8", Offset = "0x68A7C8")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A800", Offset = "0x68A800")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A84C", Offset = "0x68A84C")]
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
		[Address(RVA = "0x1440C48", Offset = "0x1440C48", VA = "0x1440C48")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1440F18", Offset = "0x1440F18", VA = "0x1440F18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1441560", Offset = "0x1441560", VA = "0x1441560")]
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
			[Address(RVA = "0x144190C", Offset = "0x144190C", VA = "0x144190C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1441638", Offset = "0x1441638", VA = "0x1441638")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000712")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x144192C", Offset = "0x144192C", VA = "0x144192C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1441AE4", Offset = "0x1441AE4", VA = "0x1441AE4")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1441C68", Offset = "0x1441C68", VA = "0x1441C68")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1441D44", Offset = "0x1441D44", VA = "0x1441D44")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1441E78", Offset = "0x1441E78", VA = "0x1441E78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1441FDC", Offset = "0x1441FDC", VA = "0x1441FDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x14421EC", Offset = "0x14421EC", VA = "0x14421EC")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1442200", Offset = "0x1442200", VA = "0x1442200", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1442464", Offset = "0x1442464", VA = "0x1442464")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1442478", Offset = "0x1442478", VA = "0x1442478", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x14425AC", Offset = "0x14425AC", VA = "0x14425AC")]
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
		[Address(RVA = "0x1444540", Offset = "0x1444540", VA = "0x1444540")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1444620", Offset = "0x1444620", VA = "0x1444620")]
		private void Update()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1444734", Offset = "0x1444734", VA = "0x1444734")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6826E0", Offset = "0x6826E0")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x14455A4", Offset = "0x14455A4", VA = "0x14455A4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1445600", Offset = "0x1445600", VA = "0x1445600")]
		private void Update()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1445658", Offset = "0x1445658", VA = "0x1445658")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1445738", Offset = "0x1445738", VA = "0x1445738")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682740", Offset = "0x682740")]
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
				[Address(RVA = "0x17EB648", Offset = "0x17EB648", VA = "0x17EB648", Slot = "4")]
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
				[Address(RVA = "0x17EB690", Offset = "0x17EB690", VA = "0x17EB690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x17EB454", Offset = "0x17EB454", VA = "0x17EB454")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x17EB480", Offset = "0x17EB480", VA = "0x17EB480", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x17EB484", Offset = "0x17EB484", VA = "0x17EB484", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x17EB650", Offset = "0x17EB650", VA = "0x17EB650", Slot = "8")]
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
		[Address(RVA = "0x1445748", Offset = "0x1445748", VA = "0x1445748")]
		private void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1445810", Offset = "0x1445810", VA = "0x1445810")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1445858", Offset = "0x1445858", VA = "0x1445858")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D578", Offset = "0x68D578")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x14458E0", Offset = "0x14458E0", VA = "0x14458E0")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682750", Offset = "0x682750")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6827B0", Offset = "0x6827B0")]
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
				[Address(RVA = "0x17EBBE0", Offset = "0x17EBBE0", VA = "0x17EBBE0", Slot = "4")]
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
				[Address(RVA = "0x17EBC28", Offset = "0x17EBC28", VA = "0x17EBC28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x17EBA70", Offset = "0x17EBA70", VA = "0x17EBA70")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x17EBA9C", Offset = "0x17EBA9C", VA = "0x17EBA9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x17EBAA0", Offset = "0x17EBAA0", VA = "0x17EBAA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x17EBBE8", Offset = "0x17EBBE8", VA = "0x17EBBE8", Slot = "8")]
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
		[Address(RVA = "0x1449618", Offset = "0x1449618", VA = "0x1449618")]
		private void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x14496D0", Offset = "0x14496D0", VA = "0x14496D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D628", Offset = "0x68D628")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x1449748", Offset = "0x1449748", VA = "0x1449748")]
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
			[Address(RVA = "0x17EBC30", Offset = "0x17EBC30", VA = "0x17EBC30")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x17EBF3C", Offset = "0x17EBF3C", VA = "0x17EBF3C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x17EC024", Offset = "0x17EC024", VA = "0x17EC024")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x17EC4B8", Offset = "0x17EC4B8", VA = "0x17EC4B8")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x17EC5AC", Offset = "0x17EC5AC", VA = "0x17EC5AC")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x17EC644", Offset = "0x17EC644", VA = "0x17EC644")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x17EC6D8", Offset = "0x17EC6D8", VA = "0x17EC6D8")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x17EC76C", Offset = "0x17EC76C", VA = "0x17EC76C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x17EC95C", Offset = "0x17EC95C", VA = "0x17EC95C")]
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
		[Address(RVA = "0x144A138", Offset = "0x144A138", VA = "0x144A138")]
		private void Start()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x144A1B4", Offset = "0x144A1B4", VA = "0x144A1B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x144A224", Offset = "0x144A224", VA = "0x144A224")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x144A2EC", Offset = "0x144A2EC", VA = "0x144A2EC")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A898", Offset = "0x68A898")]
		public Transform to;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A8D0", Offset = "0x68A8D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A8D0", Offset = "0x68A8D0")]
		public float transferMotion;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x144A2F4", Offset = "0x144A2F4", VA = "0x144A2F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x144A330", Offset = "0x144A330", VA = "0x144A330")]
		private void Update()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x144A3E4", Offset = "0x144A3E4", VA = "0x144A3E4")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A924", Offset = "0x68A924")]
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
		[Address(RVA = "0x144B220", Offset = "0x144B220", VA = "0x144B220")]
		private void Start()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x144B438", Offset = "0x144B438", VA = "0x144B438")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x144B628", Offset = "0x144B628", VA = "0x144B628")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x144B6F4", Offset = "0x144B6F4", VA = "0x144B6F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x144B824", Offset = "0x144B824", VA = "0x144B824")]
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
		[Address(RVA = "0x144BABC", Offset = "0x144BABC", VA = "0x144BABC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x144BE48", Offset = "0x144BE48", VA = "0x144BE48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x144C0B4", Offset = "0x144C0B4", VA = "0x144C0B4")]
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
		[Address(RVA = "0x15A7278", Offset = "0x15A7278", VA = "0x15A7278")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x15A75A0", Offset = "0x15A75A0", VA = "0x15A75A0")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x15A7620", Offset = "0x15A7620", VA = "0x15A7620")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6827C0", Offset = "0x6827C0")]
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
				[Address(RVA = "0x17EA900", Offset = "0x17EA900", VA = "0x17EA900", Slot = "4")]
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
				[Address(RVA = "0x17EA948", Offset = "0x17EA948", VA = "0x17EA948", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x17EA7B4", Offset = "0x17EA7B4", VA = "0x17EA7B4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x17EA7E0", Offset = "0x17EA7E0", VA = "0x17EA7E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x17EA7E4", Offset = "0x17EA7E4", VA = "0x17EA7E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x17EA908", Offset = "0x17EA908", VA = "0x17EA908", Slot = "8")]
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
		[Address(RVA = "0x14425C0", Offset = "0x14425C0", VA = "0x14425C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1442704", Offset = "0x1442704", VA = "0x1442704")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x144268C", Offset = "0x144268C", VA = "0x144268C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D6D8", Offset = "0x68D6D8")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1442888", Offset = "0x1442888", VA = "0x1442888")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1442974", Offset = "0x1442974", VA = "0x1442974")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1442A5C", Offset = "0x1442A5C", VA = "0x1442A5C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68A95C", Offset = "0x68A95C")]
		public float weight;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1576534", Offset = "0x1576534", VA = "0x1576534")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x15765A8", Offset = "0x15765A8", VA = "0x15765A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1576660", Offset = "0x1576660", VA = "0x1576660")]
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
			[Address(RVA = "0x17EC990", Offset = "0x17EC990", VA = "0x17EC990")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x17ECAD0", Offset = "0x17ECAD0", VA = "0x17ECAD0")]
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
		[Address(RVA = "0x144A7D8", Offset = "0x144A7D8", VA = "0x144A7D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x144A854", Offset = "0x144A854", VA = "0x144A854")]
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
		[Address(RVA = "0x15AEA8C", Offset = "0x15AEA8C", VA = "0x15AEA8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x15AEBF0", Offset = "0x15AEBF0", VA = "0x15AEBF0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x15AEDD4", Offset = "0x15AEDD4", VA = "0x15AEDD4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A974", Offset = "0x68A974")]
		public VRIK ik;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A9AC", Offset = "0x68A9AC")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68A9E4", Offset = "0x68A9E4")]
		public Transform headTracker;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AA1C", Offset = "0x68AA1C")]
		public Transform bodyTracker;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AA54", Offset = "0x68AA54")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AA8C", Offset = "0x68AA8C")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AAC4", Offset = "0x68AAC4")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AAFC", Offset = "0x68AAFC")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68AB34", Offset = "0x68AB34")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x144CD98", Offset = "0x144CD98", VA = "0x144CD98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x144ED84", Offset = "0x144ED84", VA = "0x144ED84")]
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
		[Address(RVA = "0x144FC70", Offset = "0x144FC70", VA = "0x144FC70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x144FCCC", Offset = "0x144FCCC", VA = "0x144FCCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x144FE54", Offset = "0x144FE54", VA = "0x144FE54")]
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
		[Address(RVA = "0x144FE88", Offset = "0x144FE88", VA = "0x144FE88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1450324", Offset = "0x1450324", VA = "0x1450324")]
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
			[Address(RVA = "0x1580220", Offset = "0x1580220", VA = "0x1580220", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x15801FC", Offset = "0x15801FC", VA = "0x15801FC", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1580228", Offset = "0x1580228", VA = "0x1580228")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x158028C", Offset = "0x158028C", VA = "0x158028C", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1580424", Offset = "0x1580424", VA = "0x1580424", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1580648", Offset = "0x1580648", VA = "0x1580648", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1580434", Offset = "0x1580434", VA = "0x1580434")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1580658", Offset = "0x1580658", VA = "0x1580658")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6827D0", Offset = "0x6827D0")]
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
		[Address(RVA = "0x1580670", Offset = "0x1580670", VA = "0x1580670", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x15806D4", Offset = "0x15806D4", VA = "0x15806D4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1580770", Offset = "0x1580770", VA = "0x1580770")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x1580888", Offset = "0x1580888", VA = "0x1580888")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682830", Offset = "0x682830")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x68AB9C", Offset = "0x68AB9C")]
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
			[Address(RVA = "0x1580948", Offset = "0x1580948", VA = "0x1580948", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x15808A0", Offset = "0x15808A0", VA = "0x15808A0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x158092C", Offset = "0x158092C", VA = "0x158092C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1580A40", Offset = "0x1580A40", VA = "0x1580A40", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1580E08", Offset = "0x1580E08", VA = "0x1580E08")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1580F10", Offset = "0x1580F10", VA = "0x1580F10")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682890", Offset = "0x682890")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682890", Offset = "0x682890")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68ABE0", Offset = "0x68ABE0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68ABE0", Offset = "0x68ABE0")]
		public Transform gravityTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AC40", Offset = "0x68AC40")]
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
		[Address(RVA = "0x15812EC", Offset = "0x15812EC", VA = "0x15812EC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x158141C", Offset = "0x158141C", VA = "0x158141C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1581604", Offset = "0x1581604", VA = "0x1581604", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x15817B4", Offset = "0x15817B4", VA = "0x15817B4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1581818", Offset = "0x1581818", VA = "0x1581818")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1581938", Offset = "0x1581938", VA = "0x1581938")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1581A5C", Offset = "0x1581A5C", VA = "0x1581A5C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1581A80", Offset = "0x1581A80", VA = "0x1581A80")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1581AA4", Offset = "0x1581AA4", VA = "0x1581AA4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1581B04", Offset = "0x1581B04", VA = "0x1581B04")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682924", Offset = "0x682924")]
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
				[Address(RVA = "0x1289DD8", Offset = "0x1289DD8", VA = "0x1289DD8", Slot = "4")]
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
				[Address(RVA = "0x1289E20", Offset = "0x1289E20", VA = "0x1289E20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1289CA8", Offset = "0x1289CA8", VA = "0x1289CA8")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1289CD4", Offset = "0x1289CD4", VA = "0x1289CD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1289CD8", Offset = "0x1289CD8", VA = "0x1289CD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1289DE0", Offset = "0x1289DE0", VA = "0x1289DE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68AC78", Offset = "0x68AC78")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68ACB0", Offset = "0x68ACB0")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68ACE8", Offset = "0x68ACE8")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68AD20", Offset = "0x68AD20")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68AD58", Offset = "0x68AD58")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x68AD90", Offset = "0x68AD90")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68ADC8", Offset = "0x68ADC8")]
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
			[Address(RVA = "0x1581E34", Offset = "0x1581E34", VA = "0x1581E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D788", Offset = "0x68D788")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1581E3C", Offset = "0x1581E3C", VA = "0x1581E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D798", Offset = "0x68D798")]
			private set
			{
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1581E48", Offset = "0x1581E48", VA = "0x1581E48", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1581FB0", Offset = "0x1581FB0", VA = "0x1581FB0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1582040", Offset = "0x1582040", VA = "0x1582040", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x15820BC", Offset = "0x15820BC", VA = "0x15820BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1582CA8", Offset = "0x1582CA8", VA = "0x1582CA8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1582F00", Offset = "0x1582F00", VA = "0x1582F00", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x15825B0", Offset = "0x15825B0", VA = "0x15825B0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1582FDC", Offset = "0x1582FDC", VA = "0x1582FDC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1583484", Offset = "0x1583484", VA = "0x1583484")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1582D30", Offset = "0x1582D30", VA = "0x1582D30")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1583524", Offset = "0x1583524", VA = "0x1583524", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1583860", Offset = "0x1583860", VA = "0x1583860")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1583950", Offset = "0x1583950", VA = "0x1583950", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1583AB0", Offset = "0x1583AB0", VA = "0x1583AB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x68D7A8", Offset = "0x68D7A8")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1582900", Offset = "0x1582900", VA = "0x1582900")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1583B4C", Offset = "0x1583B4C", VA = "0x1583B4C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x682934", Offset = "0x682934")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68ADD8", Offset = "0x68ADD8")]
		public CameraController cameraController;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AE10", Offset = "0x68AE10")]
		public float accelerationTime;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AE48", Offset = "0x68AE48")]
		public float turnTime;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AE80", Offset = "0x68AE80")]
		public bool walkByDefault;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AEB8", Offset = "0x68AEB8")]
		public RotationMode rotationMode;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AEF0", Offset = "0x68AEF0")]
		public float moveSpeed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AF28", Offset = "0x68AF28")]
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
			[Address(RVA = "0x1448E24", Offset = "0x1448E24", VA = "0x1448E24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D858", Offset = "0x68D858")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1448E2C", Offset = "0x1448E2C", VA = "0x1448E2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D868", Offset = "0x68D868")]
			private set
			{
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1448E38", Offset = "0x1448E38", VA = "0x1448E38")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1448EDC", Offset = "0x1448EDC", VA = "0x1448EDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x144939C", Offset = "0x144939C", VA = "0x144939C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1448F30", Offset = "0x1448F30", VA = "0x1448F30")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x14491B0", Offset = "0x14491B0", VA = "0x14491B0")]
		private void Move()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x14493D8", Offset = "0x14493D8", VA = "0x14493D8")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1449474", Offset = "0x1449474", VA = "0x1449474")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x14494F8", Offset = "0x14494F8", VA = "0x14494F8")]
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
		[Address(RVA = "0x144B82C", Offset = "0x144B82C", VA = "0x144B82C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x144B8AC", Offset = "0x144B8AC", VA = "0x144B8AC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x144BA6C", Offset = "0x144BA6C", VA = "0x144BA6C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x144BA90", Offset = "0x144BA90", VA = "0x144BA90")]
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
		[Address(RVA = "0x144B86C", Offset = "0x144B86C", VA = "0x144B86C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x144BBAC", Offset = "0x144BBAC", VA = "0x144BBAC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x144BAAC", Offset = "0x144BAAC", VA = "0x144BAAC")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x15725FC", Offset = "0x15725FC", VA = "0x15725FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1572638", Offset = "0x1572638", VA = "0x1572638")]
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
		[Address(RVA = "0x1449520", Offset = "0x1449520", VA = "0x1449520")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1449554", Offset = "0x1449554", VA = "0x1449554")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1449604", Offset = "0x1449604", VA = "0x1449604")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AF38", Offset = "0x68AF38")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AF70", Offset = "0x68AF70")]
		public float cornerRadius;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AFA8", Offset = "0x68AFA8")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68AFE0", Offset = "0x68AFE0")]
		public float maxSampleDistance;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x68B018", Offset = "0x68B018")]
		public float nextPathInterval;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B050", Offset = "0x68B050")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B060", Offset = "0x68B060")]
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
			[Address(RVA = "0x143F9A4", Offset = "0x143F9A4", VA = "0x143F9A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D878", Offset = "0x68D878")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x143F9B0", Offset = "0x143F9B0", VA = "0x143F9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D888", Offset = "0x68D888")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public State state
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x143F9BC", Offset = "0x143F9BC", VA = "0x143F9BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D898", Offset = "0x68D898")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x143F9C4", Offset = "0x143F9C4", VA = "0x143F9C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68D8A8", Offset = "0x68D8A8")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x143F9CC", Offset = "0x143F9CC", VA = "0x143F9CC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x143FAA0", Offset = "0x143FAA0", VA = "0x143FAA0")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x143FEA0", Offset = "0x143FEA0", VA = "0x143FEA0")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x143FF1C", Offset = "0x143FF1C", VA = "0x143FF1C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x143FE5C", Offset = "0x143FE5C", VA = "0x143FE5C")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x143FE8C", Offset = "0x143FE8C", VA = "0x143FE8C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1440068", Offset = "0x1440068", VA = "0x1440068")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1440218", Offset = "0x1440218", VA = "0x1440218")]
		public Navigator()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000124")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6829A4", Offset = "0x6829A4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x128A120", Offset = "0x128A120", VA = "0x128A120")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x128A128", Offset = "0x128A128", VA = "0x128A128")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x128A144", Offset = "0x128A144", VA = "0x128A144")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6829B4", Offset = "0x6829B4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x128A160", Offset = "0x128A160", VA = "0x128A160")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x128A168", Offset = "0x128A168", VA = "0x128A168")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x128A184", Offset = "0x128A184", VA = "0x128A184")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6829C4", Offset = "0x6829C4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x128A1A0", Offset = "0x128A1A0", VA = "0x128A1A0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x128A1A8", Offset = "0x128A1A8", VA = "0x128A1A8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x128A1E8", Offset = "0x128A1E8", VA = "0x128A1E8")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xE92774", Offset = "0xE92774", VA = "0xE92774")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xE92944", Offset = "0xE92944", VA = "0xE92944")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xE92AEC", Offset = "0xE92AEC", VA = "0xE92AEC")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xE92CA8", Offset = "0xE92CA8", VA = "0xE92CA8")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xE92D1C", Offset = "0xE92D1C", VA = "0xE92D1C")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xE92D90", Offset = "0xE92D90", VA = "0xE92D90")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xE92DF4", Offset = "0xE92DF4", VA = "0xE92DF4")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xE92E78", Offset = "0xE92E78", VA = "0xE92E78")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xE92EDC", Offset = "0xE92EDC", VA = "0xE92EDC")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xE92F40", Offset = "0xE92F40", VA = "0xE92F40")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xE92FA4", Offset = "0xE92FA4", VA = "0xE92FA4")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xE93008", Offset = "0xE93008", VA = "0xE93008")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xE93074", Offset = "0xE93074", VA = "0xE93074")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xE930DC", Offset = "0xE930DC", VA = "0xE930DC")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xE93140", Offset = "0xE93140", VA = "0xE93140")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000128")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6829E4", Offset = "0x6829E4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x128A20C", Offset = "0x128A20C", VA = "0x128A20C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x128A214", Offset = "0x128A214", VA = "0x128A214")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6829F4", Offset = "0x6829F4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x128A354", Offset = "0x128A354", VA = "0x128A354")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x128A35C", Offset = "0x128A35C", VA = "0x128A35C")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A04", Offset = "0x682A04")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x128A378", Offset = "0x128A378", VA = "0x128A378")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x128A380", Offset = "0x128A380", VA = "0x128A380")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A14", Offset = "0x682A14")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x128A39C", Offset = "0x128A39C", VA = "0x128A39C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x128A3A4", Offset = "0x128A3A4", VA = "0x128A3A4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A24", Offset = "0x682A24")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x128A3C0", Offset = "0x128A3C0", VA = "0x128A3C0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x128A3C8", Offset = "0x128A3C8", VA = "0x128A3C8")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A34", Offset = "0x682A34")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x128A3E4", Offset = "0x128A3E4", VA = "0x128A3E4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x128A3EC", Offset = "0x128A3EC", VA = "0x128A3EC")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A44", Offset = "0x682A44")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x128A408", Offset = "0x128A408", VA = "0x128A408")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x128A410", Offset = "0x128A410", VA = "0x128A410")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x128A42C", Offset = "0x128A42C", VA = "0x128A42C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x128A460", Offset = "0x128A460", VA = "0x128A460")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x128A47C", Offset = "0x128A47C", VA = "0x128A47C")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x128A498", Offset = "0x128A498", VA = "0x128A498")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A54", Offset = "0x682A54")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x128A558", Offset = "0x128A558", VA = "0x128A558")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x128A560", Offset = "0x128A560", VA = "0x128A560")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A64", Offset = "0x682A64")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x128A57C", Offset = "0x128A57C", VA = "0x128A57C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x128A584", Offset = "0x128A584", VA = "0x128A584")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x128A5A0", Offset = "0x128A5A0", VA = "0x128A5A0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A74", Offset = "0x682A74")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x128A6A0", Offset = "0x128A6A0", VA = "0x128A6A0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x128A6A8", Offset = "0x128A6A8", VA = "0x128A6A8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682A84", Offset = "0x682A84")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x128A230", Offset = "0x128A230", VA = "0x128A230")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x128A238", Offset = "0x128A238", VA = "0x128A238")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x128A254", Offset = "0x128A254", VA = "0x128A254")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xE8FA58", Offset = "0xE8FA58", VA = "0xE8FA58")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xE931A4", Offset = "0xE931A4", VA = "0xE931A4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xE93374", Offset = "0xE93374", VA = "0xE93374")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xE93544", Offset = "0xE93544", VA = "0xE93544")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xE8FE08", Offset = "0xE8FE08", VA = "0xE8FE08")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xE93714", Offset = "0xE93714", VA = "0xE93714")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xE93968", Offset = "0xE93968", VA = "0xE93968")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xE93E9C", Offset = "0xE93E9C", VA = "0xE93E9C")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xE94118", Offset = "0xE94118", VA = "0xE94118")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xE943B4", Offset = "0xE943B4", VA = "0xE943B4")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xE945A4", Offset = "0xE945A4", VA = "0xE945A4")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000134")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682AA4", Offset = "0x682AA4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x128A6C4", Offset = "0x128A6C4", VA = "0x128A6C4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x128A6CC", Offset = "0x128A6CC", VA = "0x128A6CC")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682AB4", Offset = "0x682AB4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x128A6E8", Offset = "0x128A6E8", VA = "0x128A6E8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x128A6F0", Offset = "0x128A6F0", VA = "0x128A6F0")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682AC4", Offset = "0x682AC4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x128A70C", Offset = "0x128A70C", VA = "0x128A70C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x128A714", Offset = "0x128A714", VA = "0x128A714")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682AD4", Offset = "0x682AD4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x128A730", Offset = "0x128A730", VA = "0x128A730")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x128A738", Offset = "0x128A738", VA = "0x128A738")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682AE4", Offset = "0x682AE4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x128A754", Offset = "0x128A754", VA = "0x128A754")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x128A75C", Offset = "0x128A75C", VA = "0x128A75C")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x128A778", Offset = "0x128A778", VA = "0x128A778")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x128A794", Offset = "0x128A794", VA = "0x128A794")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x128A7C8", Offset = "0x128A7C8", VA = "0x128A7C8")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x128A7E4", Offset = "0x128A7E4", VA = "0x128A7E4")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x128A800", Offset = "0x128A800", VA = "0x128A800")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682AF4", Offset = "0x682AF4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x128A8B8", Offset = "0x128A8B8", VA = "0x128A8B8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x128A8C0", Offset = "0x128A8C0", VA = "0x128A8C0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x128A8E8", Offset = "0x128A8E8", VA = "0x128A8E8")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B04", Offset = "0x682B04")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x128A904", Offset = "0x128A904", VA = "0x128A904")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x128A90C", Offset = "0x128A90C", VA = "0x128A90C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x128A928", Offset = "0x128A928", VA = "0x128A928")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xE8FC34", Offset = "0xE8FC34", VA = "0xE8FC34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xE947B4", Offset = "0xE947B4", VA = "0xE947B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xE94980", Offset = "0xE94980", VA = "0xE94980")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xE8FFE0", Offset = "0xE8FFE0", VA = "0xE8FFE0")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xE94B4C", Offset = "0xE94B4C", VA = "0xE94B4C")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xE94FA8", Offset = "0xE94FA8", VA = "0xE94FA8")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xE952A8", Offset = "0xE952A8", VA = "0xE952A8")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x200013C")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B24", Offset = "0x682B24")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x128AA20", Offset = "0x128AA20", VA = "0x128AA20")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x128AA28", Offset = "0x128AA28", VA = "0x128AA28")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x128AA44", Offset = "0x128AA44", VA = "0x128AA44")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B34", Offset = "0x682B34")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x128AA60", Offset = "0x128AA60", VA = "0x128AA60")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x128AA68", Offset = "0x128AA68", VA = "0x128AA68")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x128AA84", Offset = "0x128AA84", VA = "0x128AA84")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B44", Offset = "0x682B44")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x128AAA0", Offset = "0x128AAA0", VA = "0x128AAA0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x128AAA8", Offset = "0x128AAA8", VA = "0x128AAA8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x128AAB4", Offset = "0x128AAB4", VA = "0x128AAB4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xE9035C", Offset = "0xE9035C", VA = "0xE9035C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xE908CC", Offset = "0xE908CC", VA = "0xE908CC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xE955CC", Offset = "0xE955CC", VA = "0xE955CC")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xE957B8", Offset = "0xE957B8", VA = "0xE957B8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000140")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000141")]
		public static class Utils
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x128BB48", Offset = "0x128BB48", VA = "0x128BB48")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B64", Offset = "0x682B64")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x128AB60", Offset = "0x128AB60", VA = "0x128AB60")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x128AB68", Offset = "0x128AB68", VA = "0x128AB68")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x128AB84", Offset = "0x128AB84", VA = "0x128AB84")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B74", Offset = "0x682B74")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x128AE28", Offset = "0x128AE28", VA = "0x128AE28")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x128AE30", Offset = "0x128AE30", VA = "0x128AE30")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x128AE54", Offset = "0x128AE54", VA = "0x128AE54")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B84", Offset = "0x682B84")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x128B23C", Offset = "0x128B23C", VA = "0x128B23C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x128B244", Offset = "0x128B244", VA = "0x128B244")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x128B268", Offset = "0x128B268", VA = "0x128B268")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B94", Offset = "0x682B94")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x128B740", Offset = "0x128B740", VA = "0x128B740")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x128B748", Offset = "0x128B748", VA = "0x128B748")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x128B76C", Offset = "0x128B76C", VA = "0x128B76C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682BA4", Offset = "0x682BA4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x128B860", Offset = "0x128B860", VA = "0x128B860")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x128B868", Offset = "0x128B868", VA = "0x128B868")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x128B88C", Offset = "0x128B88C", VA = "0x128B88C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682BB4", Offset = "0x682BB4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x128B8B0", Offset = "0x128B8B0", VA = "0x128B8B0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x128B8B8", Offset = "0x128B8B8", VA = "0x128B8B8")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x128B8D4", Offset = "0x128B8D4", VA = "0x128B8D4")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682BC4", Offset = "0x682BC4")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x128B8F0", Offset = "0x128B8F0", VA = "0x128B8F0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x128B8F8", Offset = "0x128B8F8", VA = "0x128B8F8")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x128B95C", Offset = "0x128B95C", VA = "0x128B95C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682BD4", Offset = "0x682BD4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x128B9B8", Offset = "0x128B9B8", VA = "0x128B9B8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x128B9C0", Offset = "0x128B9C0", VA = "0x128B9C0")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x128BA24", Offset = "0x128BA24", VA = "0x128BA24")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682BE4", Offset = "0x682BE4")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x128BA80", Offset = "0x128BA80", VA = "0x128BA80")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x128BA88", Offset = "0x128BA88", VA = "0x128BA88")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x128BAEC", Offset = "0x128BAEC", VA = "0x128BAEC")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682BF4", Offset = "0x682BF4")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x128ABA0", Offset = "0x128ABA0", VA = "0x128ABA0")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x128ABA8", Offset = "0x128ABA8", VA = "0x128ABA8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x128ABC8", Offset = "0x128ABC8", VA = "0x128ABC8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C04", Offset = "0x682C04")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x128ABE4", Offset = "0x128ABE4", VA = "0x128ABE4")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x128ABEC", Offset = "0x128ABEC", VA = "0x128ABEC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x128AC0C", Offset = "0x128AC0C", VA = "0x128AC0C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C14", Offset = "0x682C14")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x128AC28", Offset = "0x128AC28", VA = "0x128AC28")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x128AC30", Offset = "0x128AC30", VA = "0x128AC30")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x128AC4C", Offset = "0x128AC4C", VA = "0x128AC4C")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C24", Offset = "0x682C24")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x128AC68", Offset = "0x128AC68", VA = "0x128AC68")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x128AC70", Offset = "0x128AC70", VA = "0x128AC70")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x128AC8C", Offset = "0x128AC8C", VA = "0x128AC8C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C34", Offset = "0x682C34")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x128ACA8", Offset = "0x128ACA8", VA = "0x128ACA8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x128ACB0", Offset = "0x128ACB0", VA = "0x128ACB0")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x128ACCC", Offset = "0x128ACCC", VA = "0x128ACCC")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C44", Offset = "0x682C44")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x128ACE8", Offset = "0x128ACE8", VA = "0x128ACE8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x128ACF0", Offset = "0x128ACF0", VA = "0x128ACF0")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x128AD0C", Offset = "0x128AD0C", VA = "0x128AD0C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C54", Offset = "0x682C54")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x128AD28", Offset = "0x128AD28", VA = "0x128AD28")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x128AD30", Offset = "0x128AD30", VA = "0x128AD30")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x128AD4C", Offset = "0x128AD4C", VA = "0x128AD4C")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C64", Offset = "0x682C64")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x128AD68", Offset = "0x128AD68", VA = "0x128AD68")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x128AD70", Offset = "0x128AD70", VA = "0x128AD70")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x128AD8C", Offset = "0x128AD8C", VA = "0x128AD8C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C74", Offset = "0x682C74")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x128ADA8", Offset = "0x128ADA8", VA = "0x128ADA8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x128ADB0", Offset = "0x128ADB0", VA = "0x128ADB0")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x128ADCC", Offset = "0x128ADCC", VA = "0x128ADCC")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C84", Offset = "0x682C84")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x128ADE8", Offset = "0x128ADE8", VA = "0x128ADE8")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x128ADF0", Offset = "0x128ADF0", VA = "0x128ADF0")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x128AE0C", Offset = "0x128AE0C", VA = "0x128AE0C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C94", Offset = "0x682C94")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x128AE78", Offset = "0x128AE78", VA = "0x128AE78")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x128AE80", Offset = "0x128AE80", VA = "0x128AE80")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x128AE9C", Offset = "0x128AE9C", VA = "0x128AE9C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CA4", Offset = "0x682CA4")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x128AEB8", Offset = "0x128AEB8", VA = "0x128AEB8")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x128AEC0", Offset = "0x128AEC0", VA = "0x128AEC0")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x128AEDC", Offset = "0x128AEDC", VA = "0x128AEDC")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CB4", Offset = "0x682CB4")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x128AEF8", Offset = "0x128AEF8", VA = "0x128AEF8")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x128AF00", Offset = "0x128AF00", VA = "0x128AF00")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x128AF1C", Offset = "0x128AF1C", VA = "0x128AF1C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CC4", Offset = "0x682CC4")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x128AF38", Offset = "0x128AF38", VA = "0x128AF38")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x128AF40", Offset = "0x128AF40", VA = "0x128AF40")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x128AF5C", Offset = "0x128AF5C", VA = "0x128AF5C")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CD4", Offset = "0x682CD4")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x128AF78", Offset = "0x128AF78", VA = "0x128AF78")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x128AF80", Offset = "0x128AF80", VA = "0x128AF80")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x128AF9C", Offset = "0x128AF9C", VA = "0x128AF9C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CE4", Offset = "0x682CE4")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x128AFB8", Offset = "0x128AFB8", VA = "0x128AFB8")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x128AFC0", Offset = "0x128AFC0", VA = "0x128AFC0")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x128AFDC", Offset = "0x128AFDC", VA = "0x128AFDC")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682CF4", Offset = "0x682CF4")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x128AFF8", Offset = "0x128AFF8", VA = "0x128AFF8")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x128B000", Offset = "0x128B000", VA = "0x128B000")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x128B028", Offset = "0x128B028", VA = "0x128B028")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D04", Offset = "0x682D04")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x128B044", Offset = "0x128B044", VA = "0x128B044")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x128B04C", Offset = "0x128B04C", VA = "0x128B04C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x128B074", Offset = "0x128B074", VA = "0x128B074")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D14", Offset = "0x682D14")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x128B090", Offset = "0x128B090", VA = "0x128B090")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x128B098", Offset = "0x128B098", VA = "0x128B098")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x128B0C0", Offset = "0x128B0C0", VA = "0x128B0C0")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D24", Offset = "0x682D24")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x128B0DC", Offset = "0x128B0DC", VA = "0x128B0DC")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x128B0E4", Offset = "0x128B0E4", VA = "0x128B0E4")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x128B100", Offset = "0x128B100", VA = "0x128B100")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x128B11C", Offset = "0x128B11C", VA = "0x128B11C")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x128B150", Offset = "0x128B150", VA = "0x128B150")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x128B16C", Offset = "0x128B16C", VA = "0x128B16C")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x128B188", Offset = "0x128B188", VA = "0x128B188")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D34", Offset = "0x682D34")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x128B28C", Offset = "0x128B28C", VA = "0x128B28C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x128B294", Offset = "0x128B294", VA = "0x128B294")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x128B2E8", Offset = "0x128B2E8", VA = "0x128B2E8")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D44", Offset = "0x682D44")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x128B334", Offset = "0x128B334", VA = "0x128B334")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x128B33C", Offset = "0x128B33C", VA = "0x128B33C")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x128B358", Offset = "0x128B358", VA = "0x128B358")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D54", Offset = "0x682D54")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x128B374", Offset = "0x128B374", VA = "0x128B374")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x128B37C", Offset = "0x128B37C", VA = "0x128B37C")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x128B398", Offset = "0x128B398", VA = "0x128B398")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D64", Offset = "0x682D64")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x128B3B4", Offset = "0x128B3B4", VA = "0x128B3B4")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x128B3BC", Offset = "0x128B3BC", VA = "0x128B3BC")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x128B3E0", Offset = "0x128B3E0", VA = "0x128B3E0")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D74", Offset = "0x682D74")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x128B404", Offset = "0x128B404", VA = "0x128B404")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x128B40C", Offset = "0x128B40C", VA = "0x128B40C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x128B430", Offset = "0x128B430", VA = "0x128B430")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D84", Offset = "0x682D84")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x128B454", Offset = "0x128B454", VA = "0x128B454")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x128B45C", Offset = "0x128B45C", VA = "0x128B45C")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x128B464", Offset = "0x128B464", VA = "0x128B464")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682D94", Offset = "0x682D94")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x128B500", Offset = "0x128B500", VA = "0x128B500")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x128B508", Offset = "0x128B508", VA = "0x128B508")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x128B52C", Offset = "0x128B52C", VA = "0x128B52C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682DA4", Offset = "0x682DA4")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x128B550", Offset = "0x128B550", VA = "0x128B550")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x128B558", Offset = "0x128B558", VA = "0x128B558")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x128B57C", Offset = "0x128B57C", VA = "0x128B57C")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682DB4", Offset = "0x682DB4")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x128B5A0", Offset = "0x128B5A0", VA = "0x128B5A0")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x128B5A8", Offset = "0x128B5A8", VA = "0x128B5A8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x128B5B4", Offset = "0x128B5B4", VA = "0x128B5B4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682DC4", Offset = "0x682DC4")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x128B670", Offset = "0x128B670", VA = "0x128B670")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x128B678", Offset = "0x128B678", VA = "0x128B678")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x128B684", Offset = "0x128B684", VA = "0x128B684")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682DD4", Offset = "0x682DD4")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x128B790", Offset = "0x128B790", VA = "0x128B790")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x128B798", Offset = "0x128B798", VA = "0x128B798")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x128B7A4", Offset = "0x128B7A4", VA = "0x128B7A4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xE90DC4", Offset = "0xE90DC4", VA = "0xE90DC4")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xE9052C", Offset = "0xE9052C", VA = "0xE9052C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xE90A74", Offset = "0xE90A74", VA = "0xE90A74")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xE95A14", Offset = "0xE95A14", VA = "0xE95A14")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xE95BE4", Offset = "0xE95BE4", VA = "0xE95BE4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xE95D8C", Offset = "0xE95D8C", VA = "0xE95D8C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xE95F58", Offset = "0xE95F58", VA = "0xE95F58")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xE9614C", Offset = "0xE9614C", VA = "0xE9614C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xE9631C", Offset = "0xE9631C", VA = "0xE9631C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xE964EC", Offset = "0xE964EC", VA = "0xE964EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xE966BC", Offset = "0xE966BC", VA = "0xE966BC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xE9688C", Offset = "0xE9688C", VA = "0xE9688C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xE96A34", Offset = "0xE96A34", VA = "0xE96A34")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xE96BEC", Offset = "0xE96BEC", VA = "0xE96BEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xE96DBC", Offset = "0xE96DBC", VA = "0xE96DBC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xE96F84", Offset = "0xE96F84", VA = "0xE96F84")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xE8F880", Offset = "0xE8F880", VA = "0xE8F880")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xE9714C", Offset = "0xE9714C", VA = "0xE9714C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xE97318", Offset = "0xE97318", VA = "0xE97318")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xE974E4", Offset = "0xE974E4", VA = "0xE974E4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xE976B0", Offset = "0xE976B0", VA = "0xE976B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xE97880", Offset = "0xE97880", VA = "0xE97880")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xE97A50", Offset = "0xE97A50", VA = "0xE97A50")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xE97C08", Offset = "0xE97C08", VA = "0xE97C08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xE97DC4", Offset = "0xE97DC4", VA = "0xE97DC4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xE9018C", Offset = "0xE9018C", VA = "0xE9018C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xE911C0", Offset = "0xE911C0", VA = "0xE911C0")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xE97F80", Offset = "0xE97F80", VA = "0xE97F80")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xE91398", Offset = "0xE91398", VA = "0xE91398")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xE98180", Offset = "0xE98180", VA = "0xE98180")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xE985D4", Offset = "0xE985D4", VA = "0xE985D4")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xE98798", Offset = "0xE98798", VA = "0xE98798")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xE9894C", Offset = "0xE9894C", VA = "0xE9894C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xE98B00", Offset = "0xE98B00", VA = "0xE98B00")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xE906FC", Offset = "0xE906FC", VA = "0xE906FC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xE98CC0", Offset = "0xE98CC0", VA = "0xE98CC0")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xE90C1C", Offset = "0xE90C1C", VA = "0xE90C1C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xE90F6C", Offset = "0xE90F6C", VA = "0xE90F6C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xE98EE8", Offset = "0xE98EE8", VA = "0xE98EE8")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xE9914C", Offset = "0xE9914C", VA = "0xE9914C")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xE993B0", Offset = "0xE993B0", VA = "0xE993B0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200016A")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682DF4", Offset = "0x682DF4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x128BD8C", Offset = "0x128BD8C", VA = "0x128BD8C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x128BD94", Offset = "0x128BD94", VA = "0x128BD94")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x128BDB8", Offset = "0x128BDB8", VA = "0x128BDB8")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E04", Offset = "0x682E04")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x128BDDC", Offset = "0x128BDDC", VA = "0x128BDDC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x128BDE4", Offset = "0x128BDE4", VA = "0x128BDE4")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x128BE08", Offset = "0x128BE08", VA = "0x128BE08")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E14", Offset = "0x682E14")]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x128BE2C", Offset = "0x128BE2C", VA = "0x128BE2C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x128C070", Offset = "0x128C070", VA = "0x128C070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E24", Offset = "0x682E24")]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x128C780", Offset = "0x128C780", VA = "0x128C780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x128C9E8", Offset = "0x128C9E8", VA = "0x128C9E8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E34", Offset = "0x682E34")]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x128C2D4", Offset = "0x128C2D4", VA = "0x128C2D4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x128C504", Offset = "0x128C504", VA = "0x128C504", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E44", Offset = "0x682E44")]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x128C07C", Offset = "0x128C07C", VA = "0x128C07C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x128C2C8", Offset = "0x128C2C8", VA = "0x128C2C8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E54", Offset = "0x682E54")]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x128C510", Offset = "0x128C510", VA = "0x128C510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x128C774", Offset = "0x128C774", VA = "0x128C774", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682E64", Offset = "0x682E64")]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x128C9F4", Offset = "0x128C9F4", VA = "0x128C9F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x128CC2C", Offset = "0x128CC2C", VA = "0x128CC2C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xE99614", Offset = "0xE99614", VA = "0xE99614")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xE99804", Offset = "0xE99804", VA = "0xE99804")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xE99A08", Offset = "0xE99A08", VA = "0xE99A08")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xE99AC8", Offset = "0xE99AC8", VA = "0xE99AC8")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xE99B88", Offset = "0xE99B88", VA = "0xE99B88")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xE99C48", Offset = "0xE99C48", VA = "0xE99C48")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xE99D18", Offset = "0xE99D18", VA = "0xE99D18")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xE99DE8", Offset = "0xE99DE8", VA = "0xE99DE8")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xE99EA8", Offset = "0xE99EA8", VA = "0xE99EA8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xE9A0D0", Offset = "0xE9A0D0", VA = "0xE9A0D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xE9A2F8", Offset = "0xE9A2F8", VA = "0xE9A2F8")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x68DE38", Offset = "0x68DE38")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xE9A414", Offset = "0xE9A414", VA = "0xE9A414")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x68DEA8", Offset = "0x68DEA8")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xE9A530", Offset = "0xE9A530", VA = "0xE9A530")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x68DF18", Offset = "0x68DF18")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xE9A64C", Offset = "0xE9A64C", VA = "0xE9A64C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x68DF88", Offset = "0x68DF88")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xE9A778", Offset = "0xE9A778", VA = "0xE9A778")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x68DFF8", Offset = "0x68DFF8")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xE9A8A4", Offset = "0xE9A8A4", VA = "0xE9A8A4")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x68E068", Offset = "0x68E068")]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000173")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000174")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000CC")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60008F8")]
				[Address(RVA = "0x1289E28", Offset = "0x1289E28", VA = "0x1289E28", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1289E5C", Offset = "0x1289E5C", VA = "0x1289E5C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000175")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000CD")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60008FA")]
				[Address(RVA = "0x128A020", Offset = "0x128A020", VA = "0x128A020", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x128A084", Offset = "0x128A084", VA = "0x128A084")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000176")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000CE")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60008FC")]
				[Address(RVA = "0x1289F24", Offset = "0x1289F24", VA = "0x1289F24", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1289F40", Offset = "0x1289F40", VA = "0x1289F40")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000177")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000CF")]
			public override bool keepWaiting
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0x1289E90", Offset = "0x1289E90", VA = "0x1289E90", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x1289EDC", Offset = "0x1289EDC", VA = "0x1289EDC")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000178")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000D0")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000900")]
				[Address(RVA = "0x1289F74", Offset = "0x1289F74", VA = "0x1289F74", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1289FD8", Offset = "0x1289FD8", VA = "0x1289FD8")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000179")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000D1")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000902")]
				[Address(RVA = "0x128A0B8", Offset = "0x128A0B8", VA = "0x128A0B8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x128A0EC", Offset = "0x128A0EC", VA = "0x128A0EC")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200017A")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200017B")]
		public static class Physics
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x128CC38", Offset = "0x128CC38", VA = "0x128CC38")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x128CD3C", Offset = "0x128CD3C", VA = "0x128CD3C")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x128CDD4", Offset = "0x128CDD4", VA = "0x128CDD4")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x128CE6C", Offset = "0x128CE6C", VA = "0x128CE6C")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xE9A9C0", Offset = "0xE9A9C0", VA = "0xE9A9C0")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xE9AA84", Offset = "0xE9AA84", VA = "0xE9AA84")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x682E74", Offset = "0x682E74")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x200017D")]
		public enum AnimationType
		{
			[Token(Token = "0x40008D7")]
			None,
			[Token(Token = "0x40008D8")]
			Move,
			[Token(Token = "0x40008D9")]
			LocalMove,
			[Token(Token = "0x40008DA")]
			Rotate,
			[Token(Token = "0x40008DB")]
			LocalRotate,
			[Token(Token = "0x40008DC")]
			Scale,
			[Token(Token = "0x40008DD")]
			Color,
			[Token(Token = "0x40008DE")]
			Fade,
			[Token(Token = "0x40008DF")]
			Text,
			[Token(Token = "0x40008E0")]
			PunchPosition,
			[Token(Token = "0x40008E1")]
			PunchRotation,
			[Token(Token = "0x40008E2")]
			PunchScale,
			[Token(Token = "0x40008E3")]
			ShakePosition,
			[Token(Token = "0x40008E4")]
			ShakeRotation,
			[Token(Token = "0x40008E5")]
			ShakeScale,
			[Token(Token = "0x40008E6")]
			CameraAspect,
			[Token(Token = "0x40008E7")]
			CameraBackgroundColor,
			[Token(Token = "0x40008E8")]
			CameraFieldOfView,
			[Token(Token = "0x40008E9")]
			CameraOrthoSize,
			[Token(Token = "0x40008EA")]
			CameraPixelRect,
			[Token(Token = "0x40008EB")]
			CameraRect,
			[Token(Token = "0x40008EC")]
			UIWidthHeight
		}

		[Token(Token = "0x200017E")]
		public enum TargetType
		{
			[Token(Token = "0x40008EE")]
			Unset,
			[Token(Token = "0x40008EF")]
			Camera,
			[Token(Token = "0x40008F0")]
			CanvasGroup,
			[Token(Token = "0x40008F1")]
			Image,
			[Token(Token = "0x40008F2")]
			Light,
			[Token(Token = "0x40008F3")]
			RectTransform,
			[Token(Token = "0x40008F4")]
			Renderer,
			[Token(Token = "0x40008F5")]
			SpriteRenderer,
			[Token(Token = "0x40008F6")]
			Rigidbody,
			[Token(Token = "0x40008F7")]
			Rigidbody2D,
			[Token(Token = "0x40008F8")]
			Text,
			[Token(Token = "0x40008F9")]
			Transform,
			[Token(Token = "0x40008FA")]
			tk2dBaseSprite,
			[Token(Token = "0x40008FB")]
			tk2dTextMesh,
			[Token(Token = "0x40008FC")]
			TextMeshPro,
			[Token(Token = "0x40008FD")]
			TextMeshProUGUI
		}

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool isActive;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isValid;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenCreated;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x600090A")]
			[Address(RVA = "0xE8DE14", Offset = "0xE8DE14", VA = "0xE8DE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68E178", Offset = "0x68E178")]
			add
			{
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0xE8DED0", Offset = "0xE8DED0", VA = "0xE8DED0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68E188", Offset = "0x68E188")]
			remove
			{
			}
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xE8DF8C", Offset = "0xE8DF8C", VA = "0xE8DF8C")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xE8E008", Offset = "0xE8E008", VA = "0xE8E008")]
		private void Awake()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xE8F5B0", Offset = "0xE8F5B0", VA = "0xE8F5B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xE8F5F4", Offset = "0xE8F5F4", VA = "0xE8F5F4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xE8F5F8", Offset = "0xE8F5F8", VA = "0xE8F5F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xE8E058", Offset = "0xE8E058", VA = "0xE8E058")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xE915A0", Offset = "0xE915A0", VA = "0xE915A0", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xE91618", Offset = "0xE91618", VA = "0xE91618", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xE91690", Offset = "0xE91690", VA = "0xE91690", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xE91708", Offset = "0xE91708", VA = "0xE91708", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xE91780", Offset = "0xE91780", VA = "0xE91780", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xE917F8", Offset = "0xE917F8", VA = "0xE917F8", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xE918F0", Offset = "0xE918F0", VA = "0xE918F0", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xE91900", Offset = "0xE91900", VA = "0xE91900", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xE91C7C", Offset = "0xE91C7C", VA = "0xE91C7C", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xE91CF8", Offset = "0xE91CF8", VA = "0xE91CF8", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xE91D84", Offset = "0xE91D84", VA = "0xE91D84")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xE91E0C", Offset = "0xE91E0C", VA = "0xE91E0C")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xE91E70", Offset = "0xE91E70", VA = "0xE91E70")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xE91ED4", Offset = "0xE91ED4", VA = "0xE91ED4")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xE91F5C", Offset = "0xE91F5C", VA = "0xE91F5C")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xE91FC0", Offset = "0xE91FC0", VA = "0xE91FC0")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xE92048", Offset = "0xE92048", VA = "0xE92048")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xE920AC", Offset = "0xE920AC", VA = "0xE920AC")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xE921F4", Offset = "0xE921F4", VA = "0xE921F4")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xE92280", Offset = "0xE92280", VA = "0xE92280")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xE922FC", Offset = "0xE922FC", VA = "0xE922FC")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xE92394", Offset = "0xE92394", VA = "0xE92394")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xE92414", Offset = "0xE92414", VA = "0xE92414")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xE8F65C", Offset = "0xE8F65C", VA = "0xE8F65C")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xE92520", Offset = "0xE92520", VA = "0xE92520")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xE8F644", Offset = "0xE8F644", VA = "0xE8F644")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xE91A14", Offset = "0xE91A14", VA = "0xE91A14")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xE9255C", Offset = "0xE9255C", VA = "0xE9255C")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xE92768", Offset = "0xE92768", VA = "0xE92768")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68E198", Offset = "0x68E198")]
		private void <CreateTween>b__47_0()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public static class DOTweenAnimationExtensions
	{
		[Token(Token = "0x600092F")]
		public static bool IsSameOrSubclassOf<T>(this Component t)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000180")]
	public static class DOTweenProShortcuts
	{
		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682ECC", Offset = "0x682ECC")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x128CFC0", Offset = "0x128CFC0", VA = "0x128CFC0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x128CFC8", Offset = "0x128CFC8", VA = "0x128CFC8")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x128CFE4", Offset = "0x128CFE4", VA = "0x128CFE4")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682EDC", Offset = "0x682EDC")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x128D000", Offset = "0x128D000", VA = "0x128D000")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x128D008", Offset = "0x128D008", VA = "0x128D008")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xE9AB38", Offset = "0xE9AB38", VA = "0xE9AB38")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xE9AB84", Offset = "0xE9AB84", VA = "0xE9AB84")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xE9AEB4", Offset = "0xE9AEB4", VA = "0xE9AEB4")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
