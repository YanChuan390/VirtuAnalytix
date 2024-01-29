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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFB7C", Offset = "0x6CFB7C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFB7C", Offset = "0x6CFB7C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1108", Offset = "0x6D1108")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1108", Offset = "0x6D1108")]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1160", Offset = "0x6D1160")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1160", Offset = "0x6D1160")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D11B8", Offset = "0x6D11B8")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D11F0", Offset = "0x6D11F0")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1228", Offset = "0x6D1228")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1260", Offset = "0x6D1260")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1298", Offset = "0x6D1298")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D12D0", Offset = "0x6D12D0")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1308", Offset = "0x6D1308")]
		public string saveName;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1340", Offset = "0x6D1340")]
		private bool <isBaking>k__BackingField;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1350", Offset = "0x6D1350")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D13D0", Offset = "0x6D13D0")]
		private float <clipLength>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x16693E4", Offset = "0x16693E4", VA = "0x16693E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D936C", Offset = "0x6D936C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x16693EC", Offset = "0x16693EC", VA = "0x16693EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D937C", Offset = "0x6D937C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x16693F8", Offset = "0x16693F8", VA = "0x16693F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D938C", Offset = "0x6D938C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1669400", Offset = "0x1669400", VA = "0x1669400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D939C", Offset = "0x6D939C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1669408", Offset = "0x1669408", VA = "0x1669408")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D93AC", Offset = "0x6D93AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1669410", Offset = "0x1669410", VA = "0x1669410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D93BC", Offset = "0x6D93BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x16692C4", Offset = "0x16692C4", VA = "0x16692C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D928C", Offset = "0x6D928C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x166930C", Offset = "0x166930C", VA = "0x166930C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D92C4", Offset = "0x6D92C4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1669354", Offset = "0x1669354", VA = "0x1669354")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D92FC", Offset = "0x6D92FC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x166939C", Offset = "0x166939C", VA = "0x166939C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9334", Offset = "0x6D9334")]
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
		[Address(RVA = "0x1669418", Offset = "0x1669418", VA = "0x1669418")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x166941C", Offset = "0x166941C", VA = "0x166941C")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1669420", Offset = "0x1669420", VA = "0x1669420")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1669424", Offset = "0x1669424", VA = "0x1669424")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D13E0", Offset = "0x6D13E0")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1418", Offset = "0x6D1418")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1450", Offset = "0x6D1450")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1488", Offset = "0x6D1488")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D14C0", Offset = "0x6D14C0")]
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
		[Address(RVA = "0x167BC70", Offset = "0x167BC70", VA = "0x167BC70")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x167C060", Offset = "0x167C060", VA = "0x167C060", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x167C068", Offset = "0x167C068", VA = "0x167C068", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x167C178", Offset = "0x167C178", VA = "0x167C178", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x167C1F4", Offset = "0x167C1F4", VA = "0x167C1F4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x167C270", Offset = "0x167C270", VA = "0x167C270", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x167BEB8", Offset = "0x167BEB8", VA = "0x167BEB8")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x167BF8C", Offset = "0x167BF8C", VA = "0x167BF8C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x167C2EC", Offset = "0x167C2EC", VA = "0x167C2EC")]
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
		[Address(RVA = "0x15227E4", Offset = "0x15227E4", VA = "0x15227E4")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x16686BC", Offset = "0x16686BC", VA = "0x16686BC")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1668918", Offset = "0x1668918", VA = "0x1668918")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x16688F8", Offset = "0x16688F8", VA = "0x16688F8")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1668EC4", Offset = "0x1668EC4", VA = "0x1668EC4")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x166A5BC", Offset = "0x166A5BC", VA = "0x166A5BC")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x166BE74", Offset = "0x166BE74", VA = "0x166BE74")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x166A010", Offset = "0x166A010", VA = "0x166A010")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x166A604", Offset = "0x166A604", VA = "0x166A604")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1669B40", Offset = "0x1669B40", VA = "0x1669B40")]
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
		[Address(RVA = "0x1669510", Offset = "0x1669510", VA = "0x1669510")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x166977C", Offset = "0x166977C", VA = "0x166977C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1669674", Offset = "0x1669674", VA = "0x1669674")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x16698F8", Offset = "0x16698F8", VA = "0x16698F8")]
		public void SetIKKeyframes(float time, Avatar avatar, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1669DA4", Offset = "0x1669DA4", VA = "0x1669DA4")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1669EA0", Offset = "0x1669EA0", VA = "0x1669EA0")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1669F9C", Offset = "0x1669F9C", VA = "0x1669F9C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1669F14", Offset = "0x1669F14", VA = "0x1669F14")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x166A208", Offset = "0x166A208", VA = "0x166A208")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x166A2BC", Offset = "0x166A2BC", VA = "0x166A2BC")]
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
		[Address(RVA = "0x166A608", Offset = "0x166A608", VA = "0x166A608")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x166A678", Offset = "0x166A678", VA = "0x166A678")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x166B10C", Offset = "0x166B10C", VA = "0x166B10C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x166B1C0", Offset = "0x166B1C0", VA = "0x166B1C0")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x166B0B0", Offset = "0x166B0B0", VA = "0x166B0B0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x166B2B8", Offset = "0x166B2B8", VA = "0x166B2B8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x166B300", Offset = "0x166B300", VA = "0x166B300")]
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
		[Address(RVA = "0x166B308", Offset = "0x166B308", VA = "0x166B308")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x166B494", Offset = "0x166B494", VA = "0x166B494")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x166B4A8", Offset = "0x166B4A8", VA = "0x166B4A8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x166B794", Offset = "0x166B794", VA = "0x166B794")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x166B3A0", Offset = "0x166B3A0", VA = "0x166B3A0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x166BA48", Offset = "0x166BA48", VA = "0x166BA48")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x166BABC", Offset = "0x166BABC", VA = "0x166BABC")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x166BC70", Offset = "0x166BC70", VA = "0x166BC70")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D14F8", Offset = "0x6D14F8")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1530", Offset = "0x6D1530")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1530", Offset = "0x6D1530")]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1588", Offset = "0x6D1588")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1588", Offset = "0x6D1588")]
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
		[Address(RVA = "0x1685C24", Offset = "0x1685C24", VA = "0x1685C24")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1686100", Offset = "0x1686100", VA = "0x1686100", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x168611C", Offset = "0x168611C", VA = "0x168611C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x16861F8", Offset = "0x16861F8", VA = "0x16861F8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x16862D4", Offset = "0x16862D4", VA = "0x16862D4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x16864A4", Offset = "0x16864A4", VA = "0x16864A4", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x168676C", Offset = "0x168676C", VA = "0x168676C")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1686848", Offset = "0x1686848", VA = "0x1686848")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D15DC", Offset = "0x6D15DC")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D1614", Offset = "0x6D1614")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D164C", Offset = "0x6D164C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D1684", Offset = "0x6D1684")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D16BC", Offset = "0x6D16BC")]
		public float blockedOffset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D16D4", Offset = "0x6D16D4")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D16E4", Offset = "0x6D16E4")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D16F4", Offset = "0x6D16F4")]
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
			[Address(RVA = "0x1674660", Offset = "0x1674660", VA = "0x1674660")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D93CC", Offset = "0x6D93CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1674668", Offset = "0x1674668", VA = "0x1674668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D93DC", Offset = "0x6D93DC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1674670", Offset = "0x1674670", VA = "0x1674670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D93EC", Offset = "0x6D93EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1674678", Offset = "0x1674678", VA = "0x1674678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D93FC", Offset = "0x6D93FC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1674680", Offset = "0x1674680", VA = "0x1674680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D940C", Offset = "0x6D940C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1674688", Offset = "0x1674688", VA = "0x1674688")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D941C", Offset = "0x6D941C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1674F10", Offset = "0x1674F10", VA = "0x1674F10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1674690", Offset = "0x1674690", VA = "0x1674690")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x16746CC", Offset = "0x16746CC", VA = "0x16746CC")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x16746D4", Offset = "0x16746D4", VA = "0x16746D4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x16747D8", Offset = "0x16747D8", VA = "0x16747D8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1674834", Offset = "0x1674834", VA = "0x1674834", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x167489C", Offset = "0x167489C", VA = "0x167489C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1674900", Offset = "0x1674900", VA = "0x1674900")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x167480C", Offset = "0x167480C", VA = "0x167480C")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1674A80", Offset = "0x1674A80", VA = "0x1674A80")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1674EE0", Offset = "0x1674EE0", VA = "0x1674EE0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1674F80", Offset = "0x1674F80", VA = "0x1674F80")]
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
		[Address(RVA = "0x1675024", Offset = "0x1675024", VA = "0x1675024")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x167505C", Offset = "0x167505C", VA = "0x167505C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1675204", Offset = "0x1675204", VA = "0x1675204")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1675234", Offset = "0x1675234", VA = "0x1675234")]
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
		[Address(RVA = "0x1668ECC", Offset = "0x1668ECC", VA = "0x1668ECC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1668EF0", Offset = "0x1668EF0", VA = "0x1668EF0")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1668F28", Offset = "0x1668F28", VA = "0x1668F28")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1669018", Offset = "0x1669018", VA = "0x1669018")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1668FC0", Offset = "0x1668FC0", VA = "0x1668FC0")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x16690B0", Offset = "0x16690B0", VA = "0x16690B0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x16690F8", Offset = "0x16690F8", VA = "0x16690F8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x16692BC", Offset = "0x16692BC", VA = "0x16692BC")]
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
			[Address(RVA = "0x1358D68", Offset = "0x1358D68", VA = "0x1358D68")]
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
			[Address(RVA = "0x166D918", Offset = "0x166D918", VA = "0x166D918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x166DB84", Offset = "0x166DB84", VA = "0x166DB84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x166D8CC", Offset = "0x166D8CC", VA = "0x166D8CC")]
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
		[Address(RVA = "0x166DDF0", Offset = "0x166DDF0", VA = "0x166DDF0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x166E10C", Offset = "0x166E10C", VA = "0x166E10C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x166E378", Offset = "0x166E378", VA = "0x166E378")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x166E3F8", Offset = "0x166E3F8", VA = "0x166E3F8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x166E4A0", Offset = "0x166E4A0", VA = "0x166E4A0")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x166DFC0", Offset = "0x166DFC0", VA = "0x166DFC0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x166E2DC", Offset = "0x166E2DC", VA = "0x166E2DC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x166ECD0", Offset = "0x166ECD0", VA = "0x166ECD0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x166EAD8", Offset = "0x166EAD8", VA = "0x166EAD8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x166EBD4", Offset = "0x166EBD4", VA = "0x166EBD4")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x166E6B8", Offset = "0x166E6B8", VA = "0x166E6B8")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x166E768", Offset = "0x166E768", VA = "0x166E768")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x166E818", Offset = "0x166E818", VA = "0x166E818")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x166E8C8", Offset = "0x166E8C8", VA = "0x166E8C8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x166E978", Offset = "0x166E978", VA = "0x166E978")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x166EA28", Offset = "0x166EA28", VA = "0x166EA28")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x166EED8", Offset = "0x166EED8", VA = "0x166EED8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x166E5D0", Offset = "0x166E5D0", VA = "0x166E5D0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x166EE48", Offset = "0x166EE48", VA = "0x166EE48")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x166EF44", Offset = "0x166EF44", VA = "0x166EF44")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x166F018", Offset = "0x166F018", VA = "0x166F018")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x166EDD0", Offset = "0x166EDD0", VA = "0x166EDD0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x166ED5C", Offset = "0x166ED5C", VA = "0x166ED5C")]
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
				[Address(RVA = "0x1358DF4", Offset = "0x1358DF4", VA = "0x1358DF4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1358DE0", Offset = "0x1358DE0", VA = "0x1358DE0")]
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
			[Address(RVA = "0x167105C", Offset = "0x167105C", VA = "0x167105C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1671444", Offset = "0x1671444", VA = "0x1671444")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1671454", Offset = "0x1671454", VA = "0x1671454", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x167187C", Offset = "0x167187C", VA = "0x167187C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1671CB0", Offset = "0x1671CB0", VA = "0x1671CB0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x167229C", Offset = "0x167229C", VA = "0x167229C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1671EC4", Offset = "0x1671EC4", VA = "0x1671EC4")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x166CCA0", Offset = "0x166CCA0", VA = "0x166CCA0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1672A9C", Offset = "0x1672A9C", VA = "0x1672A9C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1672FFC", Offset = "0x1672FFC", VA = "0x1672FFC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1672DF0", Offset = "0x1672DF0", VA = "0x1672DF0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1672C6C", Offset = "0x1672C6C", VA = "0x1672C6C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1672B3C", Offset = "0x1672B3C", VA = "0x1672B3C")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1672EFC", Offset = "0x1672EFC", VA = "0x1672EFC")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x16730F4", Offset = "0x16730F4", VA = "0x16730F4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1673C18", Offset = "0x1673C18", VA = "0x1673C18")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x16736A0", Offset = "0x16736A0", VA = "0x16736A0")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1673EC0", Offset = "0x1673EC0", VA = "0x1673EC0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1673A0C", Offset = "0x1673A0C", VA = "0x1673A0C")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1673EC8", Offset = "0x1673EC8", VA = "0x1673EC8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1673ED0", Offset = "0x1673ED0", VA = "0x1673ED0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1674098", Offset = "0x1674098", VA = "0x1674098")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1674254", Offset = "0x1674254", VA = "0x1674254")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x166D0FC", Offset = "0x166D0FC", VA = "0x166D0FC")]
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
		[Address(RVA = "0xFAFAE4", Offset = "0xFAFAE4", VA = "0xFAFAE4")]
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
		[Address(RVA = "0xFBD08C", Offset = "0xFBD08C", VA = "0xFBD08C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFBD1D4", Offset = "0xFBD1D4", VA = "0xFBD1D4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1683B10", Offset = "0x1683B10", VA = "0x1683B10")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1683CFC", Offset = "0x1683CFC", VA = "0x1683CFC")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1683BA8", Offset = "0x1683BA8", VA = "0x1683BA8")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1683E1C", Offset = "0x1683E1C", VA = "0x1683E1C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1683F48", Offset = "0x1683F48", VA = "0x1683F48")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1684194", Offset = "0x1684194", VA = "0x1684194")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x168429C", Offset = "0x168429C", VA = "0x168429C")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1684410", Offset = "0x1684410", VA = "0x1684410")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x16847EC", Offset = "0x16847EC", VA = "0x16847EC")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x16845B0", Offset = "0x16845B0", VA = "0x16845B0")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x16849A0", Offset = "0x16849A0", VA = "0x16849A0")]
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
		[Address(RVA = "0x16AD4FC", Offset = "0x16AD4FC", VA = "0x16AD4FC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x16AD568", Offset = "0x16AD568", VA = "0x16AD568")]
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
		[Address(RVA = "0x16B0C88", Offset = "0x16B0C88", VA = "0x16B0C88")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x16B6634", Offset = "0x16B6634", VA = "0x16B6634")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x16B66A8", Offset = "0x16B66A8", VA = "0x16B66A8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x16B609C", Offset = "0x16B609C", VA = "0x16B609C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x16B60A8", Offset = "0x16B60A8", VA = "0x16B60A8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x16B60CC", Offset = "0x16B60CC", VA = "0x16B60CC")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x16B6108", Offset = "0x16B6108", VA = "0x16B6108")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x16B6120", Offset = "0x16B6120", VA = "0x16B6120")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x16B6134", Offset = "0x16B6134", VA = "0x16B6134")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x16B6148", Offset = "0x16B6148", VA = "0x16B6148")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x16B6158", Offset = "0x16B6158", VA = "0x16B6158")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x16B61A0", Offset = "0x16B61A0", VA = "0x16B61A0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x16B61D8", Offset = "0x16B61D8", VA = "0x16B61D8")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x16B6200", Offset = "0x16B6200", VA = "0x16B6200")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x16B6734", Offset = "0x16B6734", VA = "0x16B6734")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x16B6234", Offset = "0x16B6234", VA = "0x16B6234")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x16B625C", Offset = "0x16B625C", VA = "0x16B625C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x16B628C", Offset = "0x16B628C", VA = "0x16B628C")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x16B62C0", Offset = "0x16B62C0", VA = "0x16B62C0")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x16B6304", Offset = "0x16B6304", VA = "0x16B6304")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x16B6368", Offset = "0x16B6368", VA = "0x16B6368")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16B63CC", Offset = "0x16B63CC", VA = "0x16B63CC")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x16B6420", Offset = "0x16B6420", VA = "0x16B6420")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x16B6474", Offset = "0x16B6474", VA = "0x16B6474")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x16B64B0", Offset = "0x16B64B0", VA = "0x16B64B0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x16B64E8", Offset = "0x16B64E8", VA = "0x16B64E8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x16B6768", Offset = "0x16B6768", VA = "0x16B6768")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x16B6530", Offset = "0x16B6530", VA = "0x16B6530")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x16B65C4", Offset = "0x16B65C4", VA = "0x16B65C4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x16B65F4", Offset = "0x16B65F4", VA = "0x16B65F4")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x16B67FC", Offset = "0x16B67FC", VA = "0x16B67FC")]
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
		[Address(RVA = "0x16B68B8", Offset = "0x16B68B8", VA = "0x16B68B8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x16B6924", Offset = "0x16B6924", VA = "0x16B6924")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x16B6990", Offset = "0x16B6990", VA = "0x16B6990")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x16B69E8", Offset = "0x16B69E8", VA = "0x16B69E8")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x16B6AB4", Offset = "0x16B6AB4", VA = "0x16B6AB4")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x16B6A00", Offset = "0x16B6A00", VA = "0x16B6A00")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x16B6ACC", Offset = "0x16B6ACC", VA = "0x16B6ACC")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x16B6B70", Offset = "0x16B6B70", VA = "0x16B6B70")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x16B6B9C", Offset = "0x16B6B9C", VA = "0x16B6B9C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x16B6BEC", Offset = "0x16B6BEC", VA = "0x16B6BEC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x16B6C58", Offset = "0x16B6C58", VA = "0x16B6C58")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x16B6D6C", Offset = "0x16B6D6C", VA = "0x16B6D6C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x16B6E64", Offset = "0x16B6E64", VA = "0x16B6E64")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x16B6EC0", Offset = "0x16B6EC0", VA = "0x16B6EC0")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x151B8D8", Offset = "0x151B8D8", VA = "0x151B8D8")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x151B928", Offset = "0x151B928", VA = "0x151B928")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x151B978", Offset = "0x151B978", VA = "0x151B978")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x151BA20", Offset = "0x151BA20", VA = "0x151BA20")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x151BAC8", Offset = "0x151BAC8", VA = "0x151BAC8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x151BBA8", Offset = "0x151BBA8", VA = "0x151BBA8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x151BBFC", Offset = "0x151BBFC", VA = "0x151BBFC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x151B0F0", Offset = "0x151B0F0", VA = "0x151B0F0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x151BCD0", Offset = "0x151BCD0", VA = "0x151BCD0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x151BE60", Offset = "0x151BE60", VA = "0x151BE60")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x151BF54", Offset = "0x151BF54", VA = "0x151BF54")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x151C060", Offset = "0x151C060", VA = "0x151C060")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x151C14C", Offset = "0x151C14C", VA = "0x151C14C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1714", Offset = "0x6D1714")]
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
			[Address(RVA = "0x1522320", Offset = "0x1522320", VA = "0x1522320")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x152262C", Offset = "0x152262C", VA = "0x152262C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x15221E0", Offset = "0x15221E0", VA = "0x15221E0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1522280", Offset = "0x1522280", VA = "0x1522280", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1522284", Offset = "0x1522284", VA = "0x1522284", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1522288", Offset = "0x1522288", VA = "0x1522288", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x152228C", Offset = "0x152228C", VA = "0x152228C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x152231C", Offset = "0x152231C", VA = "0x152231C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x15222C4", Offset = "0x15222C4", VA = "0x15222C4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x15225E0", Offset = "0x15225E0", VA = "0x15225E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x152240C", Offset = "0x152240C", VA = "0x152240C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x15226E4", Offset = "0x15226E4", VA = "0x15226E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1522740", Offset = "0x1522740", VA = "0x1522740")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x152279C", Offset = "0x152279C", VA = "0x152279C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x151B8C8", Offset = "0x151B8C8", VA = "0x151B8C8")]
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
		[Address(RVA = "0x1522E48", Offset = "0x1522E48", VA = "0x1522E48")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1522F08", Offset = "0x1522F08", VA = "0x1522F08")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1522FC8", Offset = "0x1522FC8", VA = "0x1522FC8")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1523088", Offset = "0x1523088", VA = "0x1523088")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V3Tools
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1524A50", Offset = "0x1524A50", VA = "0x1524A50")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1524AF0", Offset = "0x1524AF0", VA = "0x1524AF0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1524B2C", Offset = "0x1524B2C", VA = "0x1524B2C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1524B70", Offset = "0x1524B70", VA = "0x1524B70")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1524C0C", Offset = "0x1524C0C", VA = "0x1524C0C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1524D68", Offset = "0x1524D68", VA = "0x1524D68")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1524EE4", Offset = "0x1524EE4", VA = "0x1524EE4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1525068", Offset = "0x1525068", VA = "0x1525068")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1525124", Offset = "0x1525124", VA = "0x1525124")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1525224", Offset = "0x1525224", VA = "0x1525224")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x15252AC", Offset = "0x15252AC", VA = "0x15252AC")]
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
		[Address(RVA = "0x13585CC", Offset = "0x13585CC", VA = "0x13585CC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1358664", Offset = "0x1358664", VA = "0x1358664")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFBEC", Offset = "0x6CFBEC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFBEC", Offset = "0x6CFBEC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x166C380", Offset = "0x166C380", VA = "0x166C380")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D949C", Offset = "0x6D949C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x166C3C8", Offset = "0x166C3C8", VA = "0x166C3C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D94D4", Offset = "0x6D94D4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x166C410", Offset = "0x166C410", VA = "0x166C410")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D950C", Offset = "0x6D950C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x166C458", Offset = "0x166C458", VA = "0x166C458")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9544", Offset = "0x6D9544")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x166C4A0", Offset = "0x166C4A0", VA = "0x166C4A0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x166C53C", Offset = "0x166C53C", VA = "0x166C53C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x166C55C", Offset = "0x166C55C", VA = "0x166C55C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x166C58C", Offset = "0x166C58C", VA = "0x166C58C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x166C5BC", Offset = "0x166C5BC", VA = "0x166C5BC")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x166C5FC", Offset = "0x166C5FC", VA = "0x166C5FC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x166C640", Offset = "0x166C640", VA = "0x166C640")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x166C664", Offset = "0x166C664", VA = "0x166C664")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x166C688", Offset = "0x166C688", VA = "0x166C688")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x166C6B0", Offset = "0x166C6B0", VA = "0x166C6B0")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x166C6DC", Offset = "0x166C6DC", VA = "0x166C6DC")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x166C708", Offset = "0x166C708", VA = "0x166C708")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x166C4C0", Offset = "0x166C4C0", VA = "0x166C4C0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x166C730", Offset = "0x166C730", VA = "0x166C730")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x166C73C", Offset = "0x166C73C", VA = "0x166C73C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x166C748", Offset = "0x166C748", VA = "0x166C748")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x166CA2C", Offset = "0x166CA2C", VA = "0x166CA2C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x166CAD4", Offset = "0x166CAD4", VA = "0x166CAD4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x166CEB4", Offset = "0x166CEB4", VA = "0x166CEB4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x166D040", Offset = "0x166D040", VA = "0x166D040")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x166D074", Offset = "0x166D074", VA = "0x166D074")]
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
			[Address(RVA = "0x166C8E8", Offset = "0x166C8E8", VA = "0x166C8E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x166D2DC", Offset = "0x166D2DC", VA = "0x166D2DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x166CD90", Offset = "0x166CD90", VA = "0x166CD90")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x166D168", Offset = "0x166D168", VA = "0x166D168")]
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
			[Address(RVA = "0xFAFAEC", Offset = "0xFAFAEC", VA = "0xFAFAEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012C")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFAFB58", Offset = "0xFAFB58", VA = "0xFAFB58")]
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
		[Address(RVA = "0xFAFB60", Offset = "0xFAFB60", VA = "0xFAFB60", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFAFC20", Offset = "0xFAFC20", VA = "0xFAFC20")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFAFC28", Offset = "0xFAFC28", VA = "0xFAFC28")]
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
			[Address(RVA = "0xFAFD5C", Offset = "0xFAFD5C", VA = "0xFAFD5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFAFC54", Offset = "0xFAFC54", VA = "0xFAFC54", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xFAFD98", Offset = "0xFAFD98", VA = "0xFAFD98")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xFAFDA0", Offset = "0xFAFDA0", VA = "0xFAFDA0")]
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
		[Address(RVA = "0xFAFDCC", Offset = "0xFAFDCC", VA = "0xFAFDCC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xFAFE4C", Offset = "0xFAFE4C", VA = "0xFAFE4C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xFAFE54", Offset = "0xFAFE54", VA = "0xFAFE54")]
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
			[Address(RVA = "0xFAFF88", Offset = "0xFAFF88", VA = "0xFAFF88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xFAFE80", Offset = "0xFAFE80", VA = "0xFAFE80", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xFAFFC4", Offset = "0xFAFFC4", VA = "0xFAFFC4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xFAFFCC", Offset = "0xFAFFCC", VA = "0xFAFFCC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D174C", Offset = "0x6D174C")]
		public float positionWeight;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1764", Offset = "0x6D1764")]
		public float rotationWeight;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xFAFFF8", Offset = "0xFAFFF8", VA = "0xFAFFF8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xFB0064", Offset = "0xFB0064", VA = "0xFB0064")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xFB00B8", Offset = "0xFB00B8", VA = "0xFB00B8")]
		public void Update()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xFB0368", Offset = "0xFB0368", VA = "0xFB0368")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D177C", Offset = "0x6D177C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D177C", Offset = "0x6D177C")]
		public float weight;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D17D0", Offset = "0x6D17D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D17D0", Offset = "0x6D17D0")]
		public float rotationWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1824", Offset = "0x6D1824")]
		public DOF rotationDOF;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D185C", Offset = "0x6D185C")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1894", Offset = "0x6D1894")]
		public Transform bone1;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D18CC", Offset = "0x6D18CC")]
		public Transform bone2;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1904", Offset = "0x6D1904")]
		public Transform bone3;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D193C", Offset = "0x6D193C")]
		public Transform tip;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1974", Offset = "0x6D1974")]
		public Transform target;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D19AC", Offset = "0x6D19AC")]
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
			[Address(RVA = "0x1679E14", Offset = "0x1679E14", VA = "0x1679E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D957C", Offset = "0x6D957C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1679E1C", Offset = "0x1679E1C", VA = "0x1679E1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D958C", Offset = "0x6D958C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1679E28", Offset = "0x1679E28", VA = "0x1679E28")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1679E48", Offset = "0x1679E48", VA = "0x1679E48")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1679E68", Offset = "0x1679E68", VA = "0x1679E68")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1679E88", Offset = "0x1679E88", VA = "0x1679E88")]
			set
			{
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1679EA8", Offset = "0x1679EA8", VA = "0x1679EA8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1679FB0", Offset = "0x1679FB0", VA = "0x1679FB0")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x167A454", Offset = "0x167A454", VA = "0x167A454")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x167A52C", Offset = "0x167A52C", VA = "0x167A52C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x167A5F0", Offset = "0x167A5F0", VA = "0x167A5F0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x167AB38", Offset = "0x167AB38", VA = "0x167AB38")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D19BC", Offset = "0x6D19BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D19BC", Offset = "0x6D19BC")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1A10", Offset = "0x6D1A10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x167AB48", Offset = "0x167AB48", VA = "0x167AB48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D959C", Offset = "0x6D959C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x167AB50", Offset = "0x167AB50", VA = "0x167AB50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D95AC", Offset = "0x6D95AC")]
			private set
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x167AB5C", Offset = "0x167AB5C", VA = "0x167AB5C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x167ABE4", Offset = "0x167ABE4", VA = "0x167ABE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D95BC", Offset = "0x6D95BC")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x167AF1C", Offset = "0x167AF1C", VA = "0x167AF1C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x167B094", Offset = "0x167B094", VA = "0x167B094")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x167AE20", Offset = "0x167AE20", VA = "0x167AE20")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x167B204", Offset = "0x167B204", VA = "0x167B204", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x167B2C4", Offset = "0x167B2C4", VA = "0x167B2C4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x167B33C", Offset = "0x167B33C", VA = "0x167B33C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x167B3B0", Offset = "0x167B3B0", VA = "0x167B3B0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x167B418", Offset = "0x167B418", VA = "0x167B418", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x167B41C", Offset = "0x167B41C", VA = "0x167B41C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x167B430", Offset = "0x167B430", VA = "0x167B430")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1A20", Offset = "0x6D1A20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1A20", Offset = "0x6D1A20")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1A74", Offset = "0x6D1A74")]
		public Grounding solver;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1AAC", Offset = "0x6D1AAC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x167C84C", Offset = "0x167C84C", VA = "0x167C84C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D95F4", Offset = "0x6D95F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x167C854", Offset = "0x167C854", VA = "0x167C854")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9604", Offset = "0x6D9604")]
			protected set
			{
			}
		}

		[Token(Token = "0x600015A")]
		public abstract void ResetPosition();

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x167C860", Offset = "0x167C860", VA = "0x167C860")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x167CA0C", Offset = "0x167CA0C", VA = "0x167CA0C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x167C90C", Offset = "0x167C90C", VA = "0x167C90C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x167CA40", Offset = "0x167CA40", VA = "0x167CA40")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000162")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x167CB7C", Offset = "0x167CB7C", VA = "0x167CB7C")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFC4C", Offset = "0x6CFC4C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFC4C", Offset = "0x6CFC4C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1ABC", Offset = "0x6D1ABC")]
		public BipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1AF4", Offset = "0x6D1AF4")]
		public float spineBend;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1B2C", Offset = "0x6D1B2C")]
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
		[Address(RVA = "0x167CC8C", Offset = "0x167CC8C", VA = "0x167CC8C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9614", Offset = "0x6D9614")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x167CCD4", Offset = "0x167CCD4", VA = "0x167CCD4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D964C", Offset = "0x6D964C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x167CD1C", Offset = "0x167CD1C", VA = "0x167CD1C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x167CDE4", Offset = "0x167CDE4", VA = "0x167CDE4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x167CE90", Offset = "0x167CE90", VA = "0x167CE90")]
		private void Update()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x167CEF0", Offset = "0x167CEF0", VA = "0x167CEF0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x167D438", Offset = "0x167D438", VA = "0x167D438")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x167D48C", Offset = "0x167D48C", VA = "0x167D48C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x167DAC8", Offset = "0x167DAC8", VA = "0x167DAC8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x167DBE0", Offset = "0x167DBE0", VA = "0x167DBE0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x167DD20", Offset = "0x167DD20", VA = "0x167DD20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x167DEB0", Offset = "0x167DEB0", VA = "0x167DEB0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFCAC", Offset = "0x6CFCAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFCAC", Offset = "0x6CFCAC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000036")]
		public class SpineEffector
		{
			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1C0C", Offset = "0x6D1C0C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1C44", Offset = "0x6D1C44")]
			public float horizontalWeight;

			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1C7C", Offset = "0x6D1C7C")]
			public float verticalWeight;

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x135CD04", Offset = "0x135CD04", VA = "0x135CD04")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x135CD14", Offset = "0x135CD14", VA = "0x135CD14")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1B64", Offset = "0x6D1B64")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1B9C", Offset = "0x6D1B9C")]
		public float spineBend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1BD4", Offset = "0x6D1BD4")]
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
		[Address(RVA = "0x167E2E8", Offset = "0x167E2E8", VA = "0x167E2E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9684", Offset = "0x6D9684")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x167E330", Offset = "0x167E330", VA = "0x167E330", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D96BC", Offset = "0x6D96BC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x167E378", Offset = "0x167E378", VA = "0x167E378", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D96F4", Offset = "0x6D96F4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x167E3C0", Offset = "0x167E3C0", VA = "0x167E3C0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x167E3FC", Offset = "0x167E3FC", VA = "0x167E3FC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x167E490", Offset = "0x167E490", VA = "0x167E490")]
		private void Update()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x167E70C", Offset = "0x167E70C", VA = "0x167E70C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x167E718", Offset = "0x167E718", VA = "0x167E718")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x167E4F8", Offset = "0x167E4F8", VA = "0x167E4F8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x167E724", Offset = "0x167E724", VA = "0x167E724")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x167EA40", Offset = "0x167EA40", VA = "0x167EA40")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x167EB50", Offset = "0x167EB50", VA = "0x167EB50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x167ECA8", Offset = "0x167ECA8", VA = "0x167ECA8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x167EDBC", Offset = "0x167EDBC", VA = "0x167EDBC")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFD0C", Offset = "0x6CFD0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFD0C", Offset = "0x6CFD0C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1CB4", Offset = "0x6D1CB4")]
		public Transform pelvis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1CEC", Offset = "0x6D1CEC")]
		public Transform characterRoot;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1D24", Offset = "0x6D1D24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1D24", Offset = "0x6D1D24")]
		public float rootRotationWeight;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1D78", Offset = "0x6D1D78")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1DB0", Offset = "0x6D1DB0")]
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
		[Address(RVA = "0x167EE44", Offset = "0x167EE44", VA = "0x167EE44", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D972C", Offset = "0x6D972C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x167EE8C", Offset = "0x167EE8C", VA = "0x167EE8C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9764", Offset = "0x6D9764")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x167EED4", Offset = "0x167EED4", VA = "0x167EED4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x167EEEC", Offset = "0x167EEEC", VA = "0x167EEEC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x167F120", Offset = "0x167F120", VA = "0x167F120")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x167F21C", Offset = "0x167F21C", VA = "0x167F21C")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x167F7C4", Offset = "0x167F7C4", VA = "0x167F7C4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x167FBCC", Offset = "0x167FBCC", VA = "0x167FBCC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x167FD58", Offset = "0x167FD58", VA = "0x167FD58")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x168005C", Offset = "0x168005C", VA = "0x168005C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x16801A8", Offset = "0x16801A8", VA = "0x16801A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1680390", Offset = "0x1680390", VA = "0x1680390")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFD6C", Offset = "0x6CFD6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFD6C", Offset = "0x6CFD6C")]
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
			[Address(RVA = "0x135CD5C", Offset = "0x135CD5C", VA = "0x135CD5C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1DE8", Offset = "0x6D1DE8")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1E20", Offset = "0x6D1E20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1E20", Offset = "0x6D1E20")]
		public float rootRotationWeight;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1E74", Offset = "0x6D1E74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1E74", Offset = "0x6D1E74")]
		public float minRootRotation;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1ECC", Offset = "0x6D1ECC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1ECC", Offset = "0x6D1ECC")]
		public float maxRootRotation;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1F24", Offset = "0x6D1F24")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1F5C", Offset = "0x6D1F5C")]
		public float maxLegOffset;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1F94", Offset = "0x6D1F94")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D1FCC", Offset = "0x6D1FCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D1FCC", Offset = "0x6D1FCC")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2020", Offset = "0x6D2020")]
		public Transform characterRoot;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2058", Offset = "0x6D2058")]
		public Transform pelvis;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2090", Offset = "0x6D2090")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D20C8", Offset = "0x6D20C8")]
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
		[Address(RVA = "0x1680418", Offset = "0x1680418", VA = "0x1680418", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D979C", Offset = "0x6D979C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1680460", Offset = "0x1680460", VA = "0x1680460", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D97D4", Offset = "0x6D97D4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x16804A8", Offset = "0x16804A8", VA = "0x16804A8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x16804DC", Offset = "0x16804DC", VA = "0x16804DC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1680608", Offset = "0x1680608", VA = "0x1680608")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x168080C", Offset = "0x168080C", VA = "0x168080C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1680874", Offset = "0x1680874", VA = "0x1680874")]
		private void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16808D8", Offset = "0x16808D8", VA = "0x16808D8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1680C04", Offset = "0x1680C04", VA = "0x1680C04")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1680F48", Offset = "0x1680F48", VA = "0x1680F48")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1681040", Offset = "0x1681040", VA = "0x1681040")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x168140C", Offset = "0x168140C", VA = "0x168140C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1681A28", Offset = "0x1681A28", VA = "0x1681A28")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1681BF8", Offset = "0x1681BF8", VA = "0x1681BF8")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1681CD4", Offset = "0x1681CD4", VA = "0x1681CD4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1681F1C", Offset = "0x1681F1C", VA = "0x1681F1C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1681F54", Offset = "0x1681F54", VA = "0x1681F54")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1682134", Offset = "0x1682134", VA = "0x1682134")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFDCC", Offset = "0x6CFDCC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFDCC", Offset = "0x6CFDCC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2110", Offset = "0x6D2110")]
		public VRIK ik;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1682234", Offset = "0x1682234", VA = "0x1682234")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D980C", Offset = "0x6D980C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x168227C", Offset = "0x168227C", VA = "0x168227C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9844", Offset = "0x6D9844")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x16822C4", Offset = "0x16822C4", VA = "0x16822C4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D987C", Offset = "0x6D987C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x168230C", Offset = "0x168230C", VA = "0x168230C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1682324", Offset = "0x1682324", VA = "0x1682324")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x16823B8", Offset = "0x16823B8", VA = "0x16823B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1682418", Offset = "0x1682418", VA = "0x1682418")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1682638", Offset = "0x1682638", VA = "0x1682638")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1682828", Offset = "0x1682828", VA = "0x1682828")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x16828B8", Offset = "0x16828B8", VA = "0x16828B8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1682A74", Offset = "0x1682A74", VA = "0x1682A74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1682BCC", Offset = "0x1682BCC", VA = "0x1682BCC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1682D4C", Offset = "0x1682D4C", VA = "0x1682D4C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D25F4", Offset = "0x6D25F4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2604", Offset = "0x6D2604")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2614", Offset = "0x6D2614")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2624", Offset = "0x6D2624")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2634", Offset = "0x6D2634")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2644", Offset = "0x6D2644")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2654", Offset = "0x6D2654")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2664", Offset = "0x6D2664")]
			private RaycastHit <heelHit>k__BackingField;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2674", Offset = "0x6D2674")]
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
				[Address(RVA = "0x135CD9C", Offset = "0x135CD9C", VA = "0x135CD9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9954", Offset = "0x6D9954")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x135CDA4", Offset = "0x135CDA4", VA = "0x135CDA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9964", Offset = "0x6D9964")]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x135CDB0", Offset = "0x135CDB0", VA = "0x135CDB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9974", Offset = "0x6D9974")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0x135CDBC", Offset = "0x135CDBC", VA = "0x135CDBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9984", Offset = "0x6D9984")]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x135CDC8", Offset = "0x135CDC8", VA = "0x135CDC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9994", Offset = "0x6D9994")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x135CDD0", Offset = "0x135CDD0", VA = "0x135CDD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99A4", Offset = "0x6D99A4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x135CDDC", Offset = "0x135CDDC", VA = "0x135CDDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99B4", Offset = "0x6D99B4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x135CDE4", Offset = "0x135CDE4", VA = "0x135CDE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99C4", Offset = "0x6D99C4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x135CDEC", Offset = "0x135CDEC", VA = "0x135CDEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99D4", Offset = "0x6D99D4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x135CDF8", Offset = "0x135CDF8", VA = "0x135CDF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99E4", Offset = "0x6D99E4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x135CE04", Offset = "0x135CE04", VA = "0x135CE04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D99F4", Offset = "0x6D99F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x135CE0C", Offset = "0x135CE0C", VA = "0x135CE0C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A04", Offset = "0x6D9A04")]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x135CE14", Offset = "0x135CE14", VA = "0x135CE14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A14", Offset = "0x6D9A14")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x135CE1C", Offset = "0x135CE1C", VA = "0x135CE1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A24", Offset = "0x6D9A24")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x135CE24", Offset = "0x135CE24", VA = "0x135CE24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A34", Offset = "0x6D9A34")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x135CE3C", Offset = "0x135CE3C", VA = "0x135CE3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A44", Offset = "0x6D9A44")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x135CE5C", Offset = "0x135CE5C", VA = "0x135CE5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A54", Offset = "0x6D9A54")]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x135CE74", Offset = "0x135CE74", VA = "0x135CE74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A64", Offset = "0x6D9A64")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x135CE94", Offset = "0x135CE94", VA = "0x135CE94")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x135DE90", Offset = "0x135DE90", VA = "0x135DE90")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x135DFF4", Offset = "0x135DFF4", VA = "0x135DFF4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x135CEDC", Offset = "0x135CEDC", VA = "0x135CEDC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x135CEF0", Offset = "0x135CEF0", VA = "0x135CEF0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x135CF64", Offset = "0x135CF64", VA = "0x135CF64")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x135CFB0", Offset = "0x135CFB0", VA = "0x135CFB0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x135D020", Offset = "0x135D020", VA = "0x135D020")]
			public void Process()
			{
			}

			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x135DB08", Offset = "0x135DB08", VA = "0x135DB08")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x135D6A8", Offset = "0x135D6A8", VA = "0x135D6A8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x135DF24", Offset = "0x135DF24", VA = "0x135DF24")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x135D944", Offset = "0x135D944", VA = "0x135D944")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x135D9D0", Offset = "0x135D9D0", VA = "0x135D9D0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x135DF94", Offset = "0x135DF94", VA = "0x135DF94")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x135DEB8", Offset = "0x135DEB8", VA = "0x135DEB8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x135E088", Offset = "0x135E088", VA = "0x135E088")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x135E114", Offset = "0x135E114", VA = "0x135E114")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003E")]
		public class Pelvis
		{
			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2684", Offset = "0x6D2684")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D2694", Offset = "0x6D2694")]
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
				[Address(RVA = "0x135E158", Offset = "0x135E158", VA = "0x135E158")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A74", Offset = "0x6D9A74")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x135E164", Offset = "0x135E164", VA = "0x135E164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A84", Offset = "0x6D9A84")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x135E170", Offset = "0x135E170", VA = "0x135E170")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9A94", Offset = "0x6D9A94")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x135E178", Offset = "0x135E178", VA = "0x135E178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9AA4", Offset = "0x6D9AA4")]
				private set
				{
				}
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x135E180", Offset = "0x135E180", VA = "0x135E180")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x135E1F0", Offset = "0x135E1F0", VA = "0x135E1F0")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x135E190", Offset = "0x135E190", VA = "0x135E190")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x135E25C", Offset = "0x135E25C", VA = "0x135E25C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x135E3FC", Offset = "0x135E3FC", VA = "0x135E3FC")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2148", Offset = "0x6D2148")]
		public LayerMask layers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2180", Offset = "0x6D2180")]
		public float maxStep;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D21B8", Offset = "0x6D21B8")]
		public float heightOffset;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D21F0", Offset = "0x6D21F0")]
		public float footSpeed;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2228", Offset = "0x6D2228")]
		public float footRadius;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2260", Offset = "0x6D2260")]
		public float footCenterOffset;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D22AC", Offset = "0x6D22AC")]
		public float prediction;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D22E4", Offset = "0x6D22E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D22E4", Offset = "0x6D22E4")]
		public float footRotationWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2338", Offset = "0x6D2338")]
		public float footRotationSpeed;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2370", Offset = "0x6D2370")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2370", Offset = "0x6D2370")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D23C8", Offset = "0x6D23C8")]
		public bool rotateSolver;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2400", Offset = "0x6D2400")]
		public float pelvisSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2438", Offset = "0x6D2438")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2438", Offset = "0x6D2438")]
		public float pelvisDamper;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D248C", Offset = "0x6D248C")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D24C4", Offset = "0x6D24C4")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D24FC", Offset = "0x6D24FC")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2534", Offset = "0x6D2534")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D256C", Offset = "0x6D256C")]
		public Quality quality;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D25A4", Offset = "0x6D25A4")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D25B4", Offset = "0x6D25B4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D25C4", Offset = "0x6D25C4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D25D4", Offset = "0x6D25D4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D25E4", Offset = "0x6D25E4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1682DA4", Offset = "0x1682DA4", VA = "0x1682DA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98B4", Offset = "0x6D98B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x1682DAC", Offset = "0x1682DAC", VA = "0x1682DAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98C4", Offset = "0x6D98C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x1682DB4", Offset = "0x1682DB4", VA = "0x1682DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98D4", Offset = "0x6D98D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x1682DBC", Offset = "0x1682DBC", VA = "0x1682DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98E4", Offset = "0x6D98E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x1682DC4", Offset = "0x1682DC4", VA = "0x1682DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D98F4", Offset = "0x6D98F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x1682DCC", Offset = "0x1682DCC", VA = "0x1682DCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9904", Offset = "0x6D9904")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x1682DD8", Offset = "0x1682DD8", VA = "0x1682DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9914", Offset = "0x6D9914")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x1682DE0", Offset = "0x1682DE0", VA = "0x1682DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9924", Offset = "0x6D9924")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1682DE8", Offset = "0x1682DE8", VA = "0x1682DE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9934", Offset = "0x6D9934")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1682E00", Offset = "0x1682E00", VA = "0x1682E00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9944", Offset = "0x6D9944")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1682E20", Offset = "0x1682E20", VA = "0x1682E20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x167DB9C", Offset = "0x167DB9C", VA = "0x167DB9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x16831E0", Offset = "0x16831E0", VA = "0x16831E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1682E74", Offset = "0x1682E74", VA = "0x1682E74")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x16830C0", Offset = "0x16830C0", VA = "0x16830C0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x167D1B0", Offset = "0x167D1B0", VA = "0x167D1B0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x167D880", Offset = "0x167D880", VA = "0x167D880")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x167F664", Offset = "0x167F664", VA = "0x167F664")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x167CD58", Offset = "0x167CD58", VA = "0x167CD58")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x16831C8", Offset = "0x16831C8", VA = "0x16831C8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1683260", Offset = "0x1683260", VA = "0x1683260")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x16832F0", Offset = "0x16832F0", VA = "0x16832F0")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x16833AC", Offset = "0x16833AC", VA = "0x16833AC")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x167CC38", Offset = "0x167CC38", VA = "0x167CC38")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFE2C", Offset = "0x6CFE2C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFE2C", Offset = "0x6CFE2C")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1666AD0", Offset = "0x1666AD0", VA = "0x1666AD0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9AB4", Offset = "0x6D9AB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1666B18", Offset = "0x1666B18", VA = "0x1666B18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9AEC", Offset = "0x6D9AEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1666B60", Offset = "0x1666B60", VA = "0x1666B60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9B24", Offset = "0x6D9B24")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1666BA8", Offset = "0x1666BA8", VA = "0x1666BA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9B5C", Offset = "0x6D9B5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1666BF0", Offset = "0x1666BF0", VA = "0x1666BF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9B94", Offset = "0x6D9B94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1666C38", Offset = "0x1666C38", VA = "0x1666C38", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1666C40", Offset = "0x1666C40", VA = "0x1666C40")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFE8C", Offset = "0x6CFE8C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFE8C", Offset = "0x6CFE8C")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1668530", Offset = "0x1668530", VA = "0x1668530", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9BCC", Offset = "0x6D9BCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1668578", Offset = "0x1668578", VA = "0x1668578", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9C04", Offset = "0x6D9C04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x16685C0", Offset = "0x16685C0", VA = "0x16685C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9C3C", Offset = "0x6D9C3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1668608", Offset = "0x1668608", VA = "0x1668608")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9C74", Offset = "0x6D9C74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1668650", Offset = "0x1668650", VA = "0x1668650", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1668658", Offset = "0x1668658", VA = "0x1668658")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFEEC", Offset = "0x6CFEEC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFEEC", Offset = "0x6CFEEC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x16744D4", Offset = "0x16744D4", VA = "0x16744D4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9CAC", Offset = "0x6D9CAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x167451C", Offset = "0x167451C", VA = "0x167451C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9CE4", Offset = "0x6D9CE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1674564", Offset = "0x1674564", VA = "0x1674564")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9D1C", Offset = "0x6D9D1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x16745AC", Offset = "0x16745AC", VA = "0x16745AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9D54", Offset = "0x6D9D54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x16745F4", Offset = "0x16745F4", VA = "0x16745F4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x16745FC", Offset = "0x16745FC", VA = "0x16745FC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFF4C", Offset = "0x6CFF4C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFF4C", Offset = "0x6CFF4C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xFBDCF0", Offset = "0xFBDCF0", VA = "0xFBDCF0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9D8C", Offset = "0x6D9D8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xFBDD38", Offset = "0xFBDD38", VA = "0xFBDD38", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9DC4", Offset = "0x6D9DC4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xFBDD80", Offset = "0xFBDD80", VA = "0xFBDD80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9DFC", Offset = "0x6D9DFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xFBDDC8", Offset = "0xFBDDC8", VA = "0xFBDDC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9E34", Offset = "0x6D9E34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xFBDE10", Offset = "0xFBDE10", VA = "0xFBDE10", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xFBDE18", Offset = "0xFBDE18", VA = "0xFBDE18")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6CFFAC", Offset = "0x6CFFAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6CFFAC", Offset = "0x6CFFAC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xFBE33C", Offset = "0xFBE33C", VA = "0xFBE33C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9E6C", Offset = "0x6D9E6C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xFBE384", Offset = "0xFBE384", VA = "0xFBE384", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9EA4", Offset = "0x6D9EA4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xFBE3CC", Offset = "0xFBE3CC", VA = "0xFBE3CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9EDC", Offset = "0x6D9EDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xFBE414", Offset = "0xFBE414", VA = "0xFBE414")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9F14", Offset = "0x6D9F14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xFBE45C", Offset = "0xFBE45C", VA = "0xFBE45C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xFBE464", Offset = "0xFBE464", VA = "0xFBE464")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D000C", Offset = "0x6D000C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D000C", Offset = "0x6D000C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x167B494", Offset = "0x167B494", VA = "0x167B494", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9F4C", Offset = "0x6D9F4C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x167B4DC", Offset = "0x167B4DC", VA = "0x167B4DC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9F84", Offset = "0x6D9F84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x167B524", Offset = "0x167B524", VA = "0x167B524")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9FBC", Offset = "0x6D9FBC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x167B56C", Offset = "0x167B56C", VA = "0x167B56C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6D9FF4", Offset = "0x6D9FF4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x167B5B4", Offset = "0x167B5B4", VA = "0x167B5B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA02C", Offset = "0x6DA02C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x167B5FC", Offset = "0x167B5FC", VA = "0x167B5FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA064", Offset = "0x6DA064")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x167B644", Offset = "0x167B644", VA = "0x167B644")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x167B668", Offset = "0x167B668", VA = "0x167B668", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x167B670", Offset = "0x167B670", VA = "0x167B670")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x167B84C", Offset = "0x167B84C", VA = "0x167B84C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x167BAE0", Offset = "0x167BAE0", VA = "0x167BAE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA09C", Offset = "0x6DA09C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x167BB00", Offset = "0x167BB00", VA = "0x167BB00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA0D4", Offset = "0x6DA0D4")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x167BBD8", Offset = "0x167BBD8", VA = "0x167BBD8")]
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
		[Address(RVA = "0x16868D8", Offset = "0x16868D8", VA = "0x16868D8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1686960", Offset = "0x1686960", VA = "0x1686960", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x16869D4", Offset = "0x16869D4", VA = "0x16869D4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000224")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000225")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x167BC68", Offset = "0x167BC68", VA = "0x167BC68")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D26A4", Offset = "0x6D26A4")]
		public IK[] IKComponents;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D26DC", Offset = "0x6D26DC")]
		public Animator animator;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1688F50", Offset = "0x1688F50", VA = "0x1688F50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1688FE8", Offset = "0x1688FE8", VA = "0x1688FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1689058", Offset = "0x1689058", VA = "0x1689058")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1689114", Offset = "0x1689114", VA = "0x1689114")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1689150", Offset = "0x1689150", VA = "0x1689150")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x168908C", Offset = "0x168908C", VA = "0x168908C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x16891E0", Offset = "0x16891E0", VA = "0x16891E0")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D006C", Offset = "0x6D006C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D006C", Offset = "0x6D006C")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x16B6EF0", Offset = "0x16B6EF0", VA = "0x16B6EF0", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA10C", Offset = "0x6DA10C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x16B6F38", Offset = "0x16B6F38", VA = "0x16B6F38", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA144", Offset = "0x6DA144")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x16B6F80", Offset = "0x16B6F80", VA = "0x16B6F80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA17C", Offset = "0x6DA17C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x16B6FC8", Offset = "0x16B6FC8", VA = "0x16B6FC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA1B4", Offset = "0x6DA1B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x16B7010", Offset = "0x16B7010", VA = "0x16B7010", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x16B7018", Offset = "0x16B7018", VA = "0x16B7018")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D00CC", Offset = "0x6D00CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D00CC", Offset = "0x6D00CC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x16B707C", Offset = "0x16B707C", VA = "0x16B707C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA1EC", Offset = "0x6DA1EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x16B70C4", Offset = "0x16B70C4", VA = "0x16B70C4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA224", Offset = "0x6DA224")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x16B710C", Offset = "0x16B710C", VA = "0x16B710C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA25C", Offset = "0x6DA25C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x16B7154", Offset = "0x16B7154", VA = "0x16B7154")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA294", Offset = "0x6DA294")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x16B719C", Offset = "0x16B719C", VA = "0x16B719C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x16B71A4", Offset = "0x16B71A4", VA = "0x16B71A4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D012C", Offset = "0x6D012C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D012C", Offset = "0x6D012C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x16B7B7C", Offset = "0x16B7B7C", VA = "0x16B7B7C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA2CC", Offset = "0x6DA2CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x16B7BC4", Offset = "0x16B7BC4", VA = "0x16B7BC4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA304", Offset = "0x6DA304")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x16B7C0C", Offset = "0x16B7C0C", VA = "0x16B7C0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA33C", Offset = "0x6DA33C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x16B7C54", Offset = "0x16B7C54", VA = "0x16B7C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA374", Offset = "0x6DA374")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x16B7C9C", Offset = "0x16B7C9C", VA = "0x16B7C9C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x16B7CA4", Offset = "0x16B7CA4", VA = "0x16B7CA4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D018C", Offset = "0x6D018C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D018C", Offset = "0x6D018C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1523090", Offset = "0x1523090", VA = "0x1523090", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA3AC", Offset = "0x6DA3AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x15230D8", Offset = "0x15230D8", VA = "0x15230D8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA3E4", Offset = "0x6DA3E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x1523120", Offset = "0x1523120", VA = "0x1523120")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA41C", Offset = "0x6DA41C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1523168", Offset = "0x1523168", VA = "0x1523168")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA454", Offset = "0x6DA454")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x15231B0", Offset = "0x15231B0", VA = "0x15231B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x15231B8", Offset = "0x15231B8", VA = "0x15231B8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D01EC", Offset = "0x6D01EC")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D27C0", Offset = "0x6D27C0")]
			public Transform chest;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D27F8", Offset = "0x6D27F8")]
			public Transform neck;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2830", Offset = "0x6D2830")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2868", Offset = "0x6D2868")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D28A0", Offset = "0x6D28A0")]
			public Transform leftThigh;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D28D8", Offset = "0x6D28D8")]
			public Transform leftCalf;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2910", Offset = "0x6D2910")]
			public Transform leftFoot;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2948", Offset = "0x6D2948")]
			public Transform leftToes;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2980", Offset = "0x6D2980")]
			public Transform rightThigh;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D29B8", Offset = "0x6D29B8")]
			public Transform rightCalf;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D29F0", Offset = "0x6D29F0")]
			public Transform rightFoot;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2A28", Offset = "0x6D2A28")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000250")]
				[Address(RVA = "0x188FA58", Offset = "0x188FA58", VA = "0x188FA58")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000251")]
				[Address(RVA = "0x188FED0", Offset = "0x188FED0", VA = "0x188FED0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600024F")]
			[Address(RVA = "0x188F610", Offset = "0x188F610", VA = "0x188F610")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000252")]
			[Address(RVA = "0x1890348", Offset = "0x1890348", VA = "0x1890348")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000253")]
			[Address(RVA = "0x18906E4", Offset = "0x18906E4", VA = "0x18906E4")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2714", Offset = "0x6D2714")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x6D2714", Offset = "0x6D2714")]
		public References references;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2788", Offset = "0x6D2788")]
		public IKSolverVR solver;

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1525348", Offset = "0x1525348", VA = "0x1525348", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA48C", Offset = "0x6DA48C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1525390", Offset = "0x1525390", VA = "0x1525390", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA4C4", Offset = "0x6DA4C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x15253D8", Offset = "0x15253D8", VA = "0x15253D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA4FC", Offset = "0x6DA4FC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1525420", Offset = "0x1525420", VA = "0x1525420")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA534", Offset = "0x6DA534")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x152544C", Offset = "0x152544C", VA = "0x152544C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA56C", Offset = "0x6DA56C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1525474", Offset = "0x1525474", VA = "0x1525474", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x152547C", Offset = "0x152547C", VA = "0x152547C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x15254FC", Offset = "0x15254FC", VA = "0x15254FC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1525668", Offset = "0x1525668", VA = "0x1525668")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2A60", Offset = "0x6D2A60")]
		public float pull;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2A78", Offset = "0x6D2A78")]
		public float pin;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xFBDE7C", Offset = "0xFBDE7C", VA = "0xFBDE7C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xFBDF4C", Offset = "0xFBDF4C", VA = "0xFBDF4C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xFBDF6C", Offset = "0xFBDF6C", VA = "0xFBDF6C")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xFBE1E0", Offset = "0xFBE1E0", VA = "0xFBE1E0")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xFBE040", Offset = "0xFBE040", VA = "0xFBE040")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xFBE2D8", Offset = "0xFBE2D8", VA = "0xFBE2D8")]
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
		[Address(RVA = "0xFBE4C8", Offset = "0xFBE4C8", VA = "0xFBE4C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xFBE92C", Offset = "0xFBE92C", VA = "0xFBE92C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xFBEAE8", Offset = "0xFBEAE8", VA = "0xFBEAE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xFBEBF4", Offset = "0xFBEBF4", VA = "0xFBEBF4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D30D0", Offset = "0x6D30D0")]
			public Transform transform;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3108", Offset = "0x6D3108")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3108", Offset = "0x6D3108")]
			public float weight;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600026C")]
			[Address(RVA = "0x135C134", Offset = "0x135C134", VA = "0x135C134")]
			public BendBone()
			{
			}

			[Token(Token = "0x600026D")]
			[Address(RVA = "0x135C170", Offset = "0x135C170", VA = "0x135C170")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0x135C1C8", Offset = "0x135C1C8", VA = "0x135C1C8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600026F")]
			[Address(RVA = "0x135C200", Offset = "0x135C200", VA = "0x135C200")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2A90", Offset = "0x6D2A90")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D2AC8", Offset = "0x6D2AC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2AC8", Offset = "0x6D2AC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2AC8", Offset = "0x6D2AC8")]
		public float positionWeight;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2B40", Offset = "0x6D2B40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2B40", Offset = "0x6D2B40")]
		public float bodyWeight;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2B94", Offset = "0x6D2B94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2B94", Offset = "0x6D2B94")]
		public float thighWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2BE8", Offset = "0x6D2BE8")]
		public bool handsPullBody;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D2C20", Offset = "0x6D2C20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2C20", Offset = "0x6D2C20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2C20", Offset = "0x6D2C20")]
		public float rotationWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2C98", Offset = "0x6D2C98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2C98", Offset = "0x6D2C98")]
		public float bodyClampWeight;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2CEC", Offset = "0x6D2CEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2CEC", Offset = "0x6D2CEC")]
		public float headClampWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2D40", Offset = "0x6D2D40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2D40", Offset = "0x6D2D40")]
		public float bendWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2D94", Offset = "0x6D2D94")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2DCC", Offset = "0x6D2DCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2DCC", Offset = "0x6D2DCC")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D2DCC", Offset = "0x6D2DCC")]
		public float CCDWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2E44", Offset = "0x6D2E44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2E44", Offset = "0x6D2E44")]
		public float roll;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2E98", Offset = "0x6D2E98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2E98", Offset = "0x6D2E98")]
		public float damper;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2EF0", Offset = "0x6D2EF0")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D2F28", Offset = "0x6D2F28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2F28", Offset = "0x6D2F28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D2F28", Offset = "0x6D2F28")]
		public float postStretchWeight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2FA0", Offset = "0x6D2FA0")]
		public float maxStretch;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D2FD8", Offset = "0x6D2FD8")]
		public float stretchDamper;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3010", Offset = "0x6D3010")]
		public bool fixHead;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3048", Offset = "0x6D3048")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D3080", Offset = "0x6D3080")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D30B8", Offset = "0x6D30B8")]
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
		[Address(RVA = "0xFBEBFC", Offset = "0xFBEBFC", VA = "0xFBEBFC")]
		private void Start()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xFBEF30", Offset = "0xFBEF30", VA = "0xFBEF30")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xFBF3D0", Offset = "0xFBF3D0", VA = "0xFBF3D0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xFBF79C", Offset = "0xFBF79C", VA = "0xFBF79C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xFBFF28", Offset = "0xFBFF28", VA = "0xFBFF28")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xFC0208", Offset = "0xFC0208", VA = "0xFC0208")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xFC050C", Offset = "0xFC050C", VA = "0xFC050C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xFC0CE0", Offset = "0xFC0CE0", VA = "0xFC0CE0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xFBFD0C", Offset = "0xFBFD0C", VA = "0xFBFD0C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xFC0EA8", Offset = "0xFC0EA8", VA = "0xFC0EA8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xFC0BF8", Offset = "0xFC0BF8", VA = "0xFC0BF8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xFC0B2C", Offset = "0xFC0B2C", VA = "0xFC0B2C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xFC112C", Offset = "0xFC112C", VA = "0xFC112C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xFC13FC", Offset = "0xFC13FC", VA = "0xFC13FC")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D31F4", Offset = "0x6D31F4")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3204", Offset = "0x6D3204")]
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
				[Address(RVA = "0x135C2BC", Offset = "0x135C2BC", VA = "0x135C2BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA5A4", Offset = "0x6DA5A4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x135C2C4", Offset = "0x135C2C4", VA = "0x135C2C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA5B4", Offset = "0x6DA5B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000286")]
				[Address(RVA = "0x135C2CC", Offset = "0x135C2CC", VA = "0x135C2CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA5C4", Offset = "0x6DA5C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000287")]
				[Address(RVA = "0x135C2D4", Offset = "0x135C2D4", VA = "0x135C2D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA5D4", Offset = "0x6DA5D4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x135C2E0", Offset = "0x135C2E0", VA = "0x135C2E0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x135C32C", Offset = "0x135C32C", VA = "0x135C32C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x135C384", Offset = "0x135C384", VA = "0x135C384")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x135C528", Offset = "0x135C528", VA = "0x135C528")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D315C", Offset = "0x6D315C")]
		public float pin;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3174", Offset = "0x6D3174")]
		public float pull;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D318C", Offset = "0x6D318C")]
		public float push;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D31A4", Offset = "0x6D31A4")]
		public float pushParent;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D31BC", Offset = "0x6D31BC")]
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
		[Address(RVA = "0xFC1AD8", Offset = "0xFC1AD8", VA = "0xFC1AD8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xFC1BC4", Offset = "0xFC1BC4", VA = "0xFC1BC4")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xFC1CF0", Offset = "0xFC1CF0", VA = "0xFC1CF0")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xFC1E1C", Offset = "0xFC1E1C", VA = "0xFC1E1C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xFC1EF4", Offset = "0xFC1EF4", VA = "0xFC1EF4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xFC200C", Offset = "0xFC200C", VA = "0xFC200C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xFC2688", Offset = "0xFC2688", VA = "0xFC2688")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xFC219C", Offset = "0xFC219C", VA = "0xFC219C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xFC2A78", Offset = "0xFC2A78", VA = "0xFC2A78")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xFC2CD8", Offset = "0xFC2CD8", VA = "0xFC2CD8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xFC2F44", Offset = "0xFC2F44", VA = "0xFC2F44")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xFC32E8", Offset = "0xFC32E8", VA = "0xFC32E8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xFC377C", Offset = "0xFC377C", VA = "0xFC377C")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xFC39A0", Offset = "0xFC39A0", VA = "0xFC39A0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xFC370C", Offset = "0xFC370C", VA = "0xFC370C")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xFC3174", Offset = "0xFC3174", VA = "0xFC3174")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xFC3690", Offset = "0xFC3690", VA = "0xFC3690")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xFC3A88", Offset = "0xFC3A88", VA = "0xFC3A88")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xFC35B0", Offset = "0xFC35B0", VA = "0xFC35B0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xFC3888", Offset = "0xFC3888", VA = "0xFC3888")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3214", Offset = "0x6D3214")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D322C", Offset = "0x6D322C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1686C1C", Offset = "0x1686C1C", VA = "0x1686C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA5E4", Offset = "0x6DA5E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1686C24", Offset = "0x1686C24", VA = "0x1686C24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA5F4", Offset = "0x6DA5F4")]
			private set
			{
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1686A34", Offset = "0x1686A34", VA = "0x1686A34")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1686C30", Offset = "0x1686C30", VA = "0x1686C30")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1686C70", Offset = "0x1686C70", VA = "0x1686C70")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1686CD0", Offset = "0x1686CD0", VA = "0x1686CD0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1686CDC", Offset = "0x1686CDC", VA = "0x1686CDC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1686FF0", Offset = "0x1686FF0", VA = "0x1686FF0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x16871E0", Offset = "0x16871E0", VA = "0x16871E0")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x168752C", Offset = "0x168752C", VA = "0x168752C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x1686EA0", Offset = "0x1686EA0", VA = "0x1686EA0")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1686F48", Offset = "0x1686F48", VA = "0x1686F48")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D323C", Offset = "0x6D323C")]
		public float positionWeight;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3254", Offset = "0x6D3254")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D326C", Offset = "0x6D326C")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D327C", Offset = "0x6D327C")]
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
			[Address(RVA = "0x16879C8", Offset = "0x16879C8", VA = "0x16879C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA604", Offset = "0x6DA604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x16879D0", Offset = "0x16879D0", VA = "0x16879D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA614", Offset = "0x6DA614")]
			private set
			{
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1687960", Offset = "0x1687960", VA = "0x1687960")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x16879DC", Offset = "0x16879DC", VA = "0x16879DC")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1687A6C", Offset = "0x1687A6C", VA = "0x1687A6C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x1687B80", Offset = "0x1687B80", VA = "0x1687B80")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1687CB0", Offset = "0x1687CB0", VA = "0x1687CB0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1687FCC", Offset = "0x1687FCC", VA = "0x1687FCC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1688260", Offset = "0x1688260", VA = "0x1688260")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1688334", Offset = "0x1688334", VA = "0x1688334")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x16883DC", Offset = "0x16883DC", VA = "0x16883DC")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1688918", Offset = "0x1688918", VA = "0x1688918")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1688944", Offset = "0x1688944", VA = "0x1688944")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1688AA4", Offset = "0x1688AA4", VA = "0x1688AA4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1688D30", Offset = "0x1688D30", VA = "0x1688D30")]
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
				[Address(RVA = "0x135F764", Offset = "0x135F764", VA = "0x135F764")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0x135F840", Offset = "0x135F840", VA = "0x135F840")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x135FBE4", Offset = "0x135FBE4", VA = "0x135FBE4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x135F738", Offset = "0x135F738", VA = "0x135F738")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x135F7A0", Offset = "0x135F7A0", VA = "0x135F7A0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x135F7F0", Offset = "0x135F7F0", VA = "0x135F7F0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x135F850", Offset = "0x135F850", VA = "0x135F850")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x135F8D8", Offset = "0x135F8D8", VA = "0x135F8D8")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x135F8E0", Offset = "0x135F8E0", VA = "0x135F8E0")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x135F9B8", Offset = "0x135F9B8", VA = "0x135F9B8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x135FA30", Offset = "0x135FA30", VA = "0x135FA30")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x135FAC8", Offset = "0x135FAC8", VA = "0x135FAC8")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x135FD24", Offset = "0x135FD24", VA = "0x135FD24")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x135FD5C", Offset = "0x135FD5C", VA = "0x135FD5C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x135FD94", Offset = "0x135FD94", VA = "0x135FD94")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x135FDBC", Offset = "0x135FDBC", VA = "0x135FDBC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x135FEA8", Offset = "0x135FEA8", VA = "0x135FEA8")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1360034", Offset = "0x1360034", VA = "0x1360034")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x1360064", Offset = "0x1360064", VA = "0x1360064")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x136012C", Offset = "0x136012C", VA = "0x136012C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x136019C", Offset = "0x136019C", VA = "0x136019C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x13602EC", Offset = "0x13602EC", VA = "0x13602EC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x136043C", Offset = "0x136043C", VA = "0x136043C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x13604BC", Offset = "0x13604BC", VA = "0x13604BC")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x135FF24", Offset = "0x135FF24", VA = "0x135FF24")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x13605F4", Offset = "0x13605F4", VA = "0x13605F4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x16891E8", Offset = "0x16891E8", VA = "0x16891E8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x16891F0", Offset = "0x16891F0", VA = "0x16891F0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x16891F4", Offset = "0x16891F4", VA = "0x16891F4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1689338", Offset = "0x1689338", VA = "0x1689338")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x16893A8", Offset = "0x16893A8", VA = "0x16893A8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3294", Offset = "0x6D3294")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x16893B0", Offset = "0x16893B0", VA = "0x16893B0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1689458", Offset = "0x1689458", VA = "0x1689458")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x16894C4", Offset = "0x16894C4", VA = "0x16894C4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1689544", Offset = "0x1689544", VA = "0x1689544")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1689560", Offset = "0x1689560", VA = "0x1689560")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1689580", Offset = "0x1689580", VA = "0x1689580", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1689608", Offset = "0x1689608", VA = "0x1689608")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1689624", Offset = "0x1689624", VA = "0x1689624")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D32AC", Offset = "0x6D32AC")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D32C4", Offset = "0x6D32C4")]
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
		[Address(RVA = "0x168964C", Offset = "0x168964C", VA = "0x168964C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x16896D0", Offset = "0x16896D0", VA = "0x16896D0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x16897AC", Offset = "0x16897AC", VA = "0x16897AC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x16899D0", Offset = "0x16899D0", VA = "0x16899D0")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1689A94", Offset = "0x1689A94", VA = "0x1689A94")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1689B84", Offset = "0x1689B84", VA = "0x1689B84")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1689B90", Offset = "0x1689B90", VA = "0x1689B90")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1689C44", Offset = "0x1689C44", VA = "0x1689C44")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1689D08", Offset = "0x1689D08", VA = "0x1689D08", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1689F48", Offset = "0x1689F48", VA = "0x1689F48")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1689FBC", Offset = "0x1689FBC", VA = "0x1689FBC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D32DC", Offset = "0x6D32DC")]
		public int iterations;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D32F4", Offset = "0x6D32F4")]
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
		[Address(RVA = "0x168A13C", Offset = "0x168A13C", VA = "0x168A13C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x168A4A0", Offset = "0x168A4A0", VA = "0x168A4A0")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x168A584", Offset = "0x168A584", VA = "0x168A584")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x168A69C", Offset = "0x168A69C", VA = "0x168A69C")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x168A6AC", Offset = "0x168A6AC", VA = "0x168A6AC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x168A718", Offset = "0x168A718", VA = "0x168A718")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x168A79C", Offset = "0x168A79C", VA = "0x168A79C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x168AD74", Offset = "0x168AD74", VA = "0x168AD74")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x168ADAC", Offset = "0x168ADAC", VA = "0x168ADAC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x168B030", Offset = "0x168B030", VA = "0x168B030")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x168B338", Offset = "0x168B338", VA = "0x168B338")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x168B424", Offset = "0x168B424", VA = "0x168B424")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x168B4EC", Offset = "0x168B4EC", VA = "0x168B4EC")]
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
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D33B8", Offset = "0x6D33B8")]
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
			[Address(RVA = "0x1361100", Offset = "0x1361100", VA = "0x1361100")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1361150", Offset = "0x1361150", VA = "0x1361150")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x13611F0", Offset = "0x13611F0", VA = "0x13611F0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x1361228", Offset = "0x1361228", VA = "0x1361228")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x1361260", Offset = "0x1361260", VA = "0x1361260")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0x13612B0", Offset = "0x13612B0", VA = "0x13612B0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1360CE0", Offset = "0x1360CE0", VA = "0x1360CE0")]
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
				[Address(RVA = "0x1360610", Offset = "0x1360610", VA = "0x1360610")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000304")]
				[Address(RVA = "0x136070C", Offset = "0x136070C", VA = "0x136070C")]
				set
				{
				}
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x1360790", Offset = "0x1360790", VA = "0x1360790")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x1360940", Offset = "0x1360940", VA = "0x1360940")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0x1360B14", Offset = "0x1360B14", VA = "0x1360B14")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x1360C74", Offset = "0x1360C74", VA = "0x1360C74")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x1360C9C", Offset = "0x1360C9C", VA = "0x1360C9C")]
			public Bone()
			{
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1360D1C", Offset = "0x1360D1C", VA = "0x1360D1C")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1360D6C", Offset = "0x1360D6C", VA = "0x1360D6C")]
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
			[Address(RVA = "0x136109C", Offset = "0x136109C", VA = "0x136109C")]
			public Node()
			{
			}

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x13610A0", Offset = "0x13610A0", VA = "0x13610A0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x13610C8", Offset = "0x13610C8", VA = "0x13610C8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D331C", Offset = "0x6D331C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D331C", Offset = "0x6D331C")]
		public float IKPositionWeight;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3370", Offset = "0x6D3370")]
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
			[Address(RVA = "0x18733A0", Offset = "0x18733A0", VA = "0x18733A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA624", Offset = "0x6DA624")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x18733A8", Offset = "0x18733A8", VA = "0x18733A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA634", Offset = "0x6DA634")]
			private set
			{
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x18730EC", Offset = "0x18730EC", VA = "0x18730EC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E7")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1873164", Offset = "0x1873164", VA = "0x1873164")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x18732D8", Offset = "0x18732D8", VA = "0x18732D8")]
		public void Update()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1873348", Offset = "0x1873348", VA = "0x1873348", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1873354", Offset = "0x1873354", VA = "0x1873354")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1873360", Offset = "0x1873360", VA = "0x1873360")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1873368", Offset = "0x1873368", VA = "0x1873368")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1873398", Offset = "0x1873398", VA = "0x1873398")]
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
		[Address(RVA = "0x18733B4", Offset = "0x18733B4", VA = "0x18733B4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x18733CC", Offset = "0x18733CC", VA = "0x18733CC")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1873504", Offset = "0x1873504", VA = "0x1873504")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x18735B0", Offset = "0x18735B0", VA = "0x18735B0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1873838", Offset = "0x1873838", VA = "0x1873838")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D33D0", Offset = "0x6D33D0")]
		public float poleWeight;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D33E8", Offset = "0x6D33E8")]
		public float clampWeight;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3400", Offset = "0x6D3400")]
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
			[Address(RVA = "0x18738CC", Offset = "0x18738CC", VA = "0x18738CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1873908", Offset = "0x1873908", VA = "0x1873908")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1874398", Offset = "0x1874398", VA = "0x1874398", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x187477C", Offset = "0x187477C", VA = "0x187477C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1873850", Offset = "0x1873850", VA = "0x1873850")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1873944", Offset = "0x1873944", VA = "0x1873944", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1873B64", Offset = "0x1873B64", VA = "0x1873B64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x18742E4", Offset = "0x18742E4", VA = "0x18742E4")]
		private void Solve()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1874074", Offset = "0x1874074", VA = "0x1874074")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x18743A0", Offset = "0x18743A0", VA = "0x18743A0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x18747F0", Offset = "0x18747F0", VA = "0x18747F0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3418", Offset = "0x6D3418")]
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
		[Address(RVA = "0x18748B8", Offset = "0x18748B8", VA = "0x18748B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1874C58", Offset = "0x1874C58", VA = "0x1874C58")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1874CC4", Offset = "0x1874CC4", VA = "0x1874CC4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1874E1C", Offset = "0x1874E1C", VA = "0x1874E1C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1874FB0", Offset = "0x1874FB0", VA = "0x1874FB0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x187500C", Offset = "0x187500C", VA = "0x187500C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x187507C", Offset = "0x187507C", VA = "0x187507C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x18753EC", Offset = "0x18753EC", VA = "0x18753EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1875418", Offset = "0x1875418", VA = "0x1875418")]
		private void Solve()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x18750E0", Offset = "0x18750E0", VA = "0x18750E0")]
		private void Read()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1875484", Offset = "0x1875484", VA = "0x1875484")]
		private void Write()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1875610", Offset = "0x1875610", VA = "0x1875610")]
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
		[Address(RVA = "0x1875774", Offset = "0x1875774", VA = "0x1875774")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1875824", Offset = "0x1875824", VA = "0x1875824", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1875D1C", Offset = "0x1875D1C", VA = "0x1875D1C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1876314", Offset = "0x1876314", VA = "0x1876314")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x18768F0", Offset = "0x18768F0", VA = "0x18768F0")]
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
			[Address(RVA = "0x1877824", Offset = "0x1877824", VA = "0x1877824", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x18768F4", Offset = "0x18768F4", VA = "0x18768F4")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1876EB8", Offset = "0x1876EB8", VA = "0x1876EB8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1876FF8", Offset = "0x1876FF8", VA = "0x1876FF8", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x187708C", Offset = "0x187708C", VA = "0x187708C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1877564", Offset = "0x1877564", VA = "0x1877564", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x187782C", Offset = "0x187782C", VA = "0x187782C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x18769D0", Offset = "0x18769D0", VA = "0x18769D0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1876FA4", Offset = "0x1876FA4", VA = "0x1876FA4")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x18777C8", Offset = "0x18777C8", VA = "0x18777C8")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1876D2C", Offset = "0x1876D2C", VA = "0x1876D2C")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1877E7C", Offset = "0x1877E7C", VA = "0x1877E7C")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1877EF0", Offset = "0x1877EF0", VA = "0x1877EF0")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1877FB8", Offset = "0x1877FB8", VA = "0x1877FB8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1878068", Offset = "0x1878068", VA = "0x1878068")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1877314", Offset = "0x1877314", VA = "0x1877314")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x187743C", Offset = "0x187743C", VA = "0x187743C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x187816C", Offset = "0x187816C", VA = "0x187816C")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1877A4C", Offset = "0x1877A4C", VA = "0x1877A4C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1876F94", Offset = "0x1876F94", VA = "0x1876F94")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x18786FC", Offset = "0x18786FC", VA = "0x18786FC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x18782B0", Offset = "0x18782B0", VA = "0x18782B0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x18778A8", Offset = "0x18778A8", VA = "0x18778A8")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1877988", Offset = "0x1877988", VA = "0x1877988")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x18787C8", Offset = "0x18787C8", VA = "0x18787C8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3430", Offset = "0x6D3430")]
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
		[Address(RVA = "0x1878844", Offset = "0x1878844", VA = "0x1878844", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1878E84", Offset = "0x1878E84", VA = "0x1878E84", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1878F1C", Offset = "0x1878F1C", VA = "0x1878F1C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1878FBC", Offset = "0x1878FBC", VA = "0x1878FBC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x18790B8", Offset = "0x18790B8", VA = "0x18790B8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1879154", Offset = "0x1879154", VA = "0x1879154", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1879584", Offset = "0x1879584", VA = "0x1879584", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x187977C", Offset = "0x187977C", VA = "0x187977C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1879630", Offset = "0x1879630", VA = "0x1879630")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1879340", Offset = "0x1879340", VA = "0x1879340")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1879814", Offset = "0x1879814", VA = "0x1879814")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3448", Offset = "0x6D3448")]
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
		[Address(RVA = "0x1879888", Offset = "0x1879888", VA = "0x1879888")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1879978", Offset = "0x1879978", VA = "0x1879978")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x18799D4", Offset = "0x18799D4", VA = "0x18799D4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1879B04", Offset = "0x1879B04", VA = "0x1879B04")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1879B60", Offset = "0x1879B60", VA = "0x1879B60")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1879BE0", Offset = "0x1879BE0", VA = "0x1879BE0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1879D84", Offset = "0x1879D84", VA = "0x1879D84", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1879EF4", Offset = "0x1879EF4", VA = "0x1879EF4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x187A100", Offset = "0x187A100", VA = "0x187A100", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x187A1D8", Offset = "0x187A1D8", VA = "0x187A1D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x187A2C4", Offset = "0x187A2C4", VA = "0x187A2C4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x187A438", Offset = "0x187A438", VA = "0x187A438", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x187A590", Offset = "0x187A590", VA = "0x187A590", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x187A7DC", Offset = "0x187A7DC", VA = "0x187A7DC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x187AAB8", Offset = "0x187AAB8", VA = "0x187AAB8", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x187AAFC", Offset = "0x187AAFC", VA = "0x187AAFC", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x187ABEC", Offset = "0x187ABEC", VA = "0x187ABEC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3460", Offset = "0x6D3460")]
		public float spineStiffness;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3478", Offset = "0x6D3478")]
		public float pullBodyVertical;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3490", Offset = "0x6D3490")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D34A8", Offset = "0x6D34A8")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x187ACFC", Offset = "0x187ACFC", VA = "0x187ACFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x187AE44", Offset = "0x187AE44", VA = "0x187AE44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x187AE4C", Offset = "0x187AE4C", VA = "0x187AE4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x187AE54", Offset = "0x187AE54", VA = "0x187AE54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x187AE5C", Offset = "0x187AE5C", VA = "0x187AE5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x187AE64", Offset = "0x187AE64", VA = "0x187AE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x187AE6C", Offset = "0x187AE6C", VA = "0x187AE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x187AE74", Offset = "0x187AE74", VA = "0x187AE74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x187AE7C", Offset = "0x187AE7C", VA = "0x187AE7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x187AE84", Offset = "0x187AE84", VA = "0x187AE84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x187AEBC", Offset = "0x187AEBC", VA = "0x187AEBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x187AEF4", Offset = "0x187AEF4", VA = "0x187AEF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x187AF2C", Offset = "0x187AF2C", VA = "0x187AF2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x187AF64", Offset = "0x187AF64", VA = "0x187AF64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x187AF98", Offset = "0x187AF98", VA = "0x187AF98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x187AFD0", Offset = "0x187AFD0", VA = "0x187AFD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x187B008", Offset = "0x187B008", VA = "0x187B008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x187B040", Offset = "0x187B040", VA = "0x187B040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x187CF04", Offset = "0x187CF04", VA = "0x187CF04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA644", Offset = "0x6DA644")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x187CF10", Offset = "0x187CF10", VA = "0x187CF10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA654", Offset = "0x6DA654")]
			private set
			{
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x187B074", Offset = "0x187B074", VA = "0x187B074")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x187B180", Offset = "0x187B180", VA = "0x187B180")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x187B0C8", Offset = "0x187B0C8", VA = "0x187B0C8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x187B20C", Offset = "0x187B20C", VA = "0x187B20C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x187AD04", Offset = "0x187AD04", VA = "0x187AD04")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x187B2DC", Offset = "0x187B2DC", VA = "0x187B2DC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x187B394", Offset = "0x187B394", VA = "0x187B394")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x187B448", Offset = "0x187B448", VA = "0x187B448")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x187B4FC", Offset = "0x187B4FC", VA = "0x187B4FC")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x187B504", Offset = "0x187B504", VA = "0x187B504")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x187B538", Offset = "0x187B538", VA = "0x187B538")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x187B600", Offset = "0x187B600", VA = "0x187B600", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x187B7A4", Offset = "0x187B7A4", VA = "0x187B7A4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x187C980", Offset = "0x187C980", VA = "0x187C980")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x187CD94", Offset = "0x187CD94", VA = "0x187CD94")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x187CDF4", Offset = "0x187CDF4", VA = "0x187CDF4")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x187CC1C", Offset = "0x187CC1C", VA = "0x187CC1C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x187CCD8", Offset = "0x187CCD8", VA = "0x187CCD8")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x187CF1C", Offset = "0x187CF1C", VA = "0x187CF1C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x187CFF4", Offset = "0x187CFF4", VA = "0x187CFF4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x187D0F0", Offset = "0x187D0F0", VA = "0x187D0F0")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x187D218", Offset = "0x187D218", VA = "0x187D218")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x187D35C", Offset = "0x187D35C", VA = "0x187D35C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x187D48C", Offset = "0x187D48C", VA = "0x187D48C", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x187D6CC", Offset = "0x187D6CC", VA = "0x187D6CC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x187D750", Offset = "0x187D750", VA = "0x187D750")]
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
			[Address(RVA = "0x187DFB0", Offset = "0x187DFB0", VA = "0x187DFB0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x187DFB8", Offset = "0x187DFB8", VA = "0x187DFB8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x187DFC0", Offset = "0x187DFC0", VA = "0x187DFC0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x187DFD0", Offset = "0x187DFD0", VA = "0x187DFD0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x18762C0", Offset = "0x18762C0", VA = "0x18762C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x187D75C", Offset = "0x187D75C", VA = "0x187D75C")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x187D8F4", Offset = "0x187D8F4", VA = "0x187D8F4")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x187DA2C", Offset = "0x187DA2C", VA = "0x187DA2C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x187DA98", Offset = "0x187DA98", VA = "0x187DA98", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x187DB18", Offset = "0x187DB18", VA = "0x187DB18", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x187DEB8", Offset = "0x187DEB8", VA = "0x187DEB8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x187DEC0", Offset = "0x187DEC0", VA = "0x187DEC0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x187DFC8", Offset = "0x187DFC8", VA = "0x187DFC8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x187DFCC", Offset = "0x187DFCC", VA = "0x187DFCC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x18758A4", Offset = "0x18758A4", VA = "0x18758A4")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1875FA8", Offset = "0x1875FA8", VA = "0x1875FA8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x187E098", Offset = "0x187E098", VA = "0x187E098")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1874840", Offset = "0x1874840", VA = "0x1874840")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D34B8", Offset = "0x6D34B8")]
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
		[Address(RVA = "0x187E28C", Offset = "0x187E28C", VA = "0x187E28C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x187E62C", Offset = "0x187E62C", VA = "0x187E62C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x187E698", Offset = "0x187E698", VA = "0x187E698", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x187E7F0", Offset = "0x187E7F0", VA = "0x187E7F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x187E984", Offset = "0x187E984", VA = "0x187E984", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x187E9E0", Offset = "0x187E9E0", VA = "0x187E9E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x187EA50", Offset = "0x187EA50", VA = "0x187EA50", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x187EDC0", Offset = "0x187EDC0", VA = "0x187EDC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x187EDEC", Offset = "0x187EDEC", VA = "0x187EDEC")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x187EAB4", Offset = "0x187EAB4", VA = "0x187EAB4")]
		private void Read()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x187EE80", Offset = "0x187EE80", VA = "0x187EE80")]
		private void Write()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x187F00C", Offset = "0x187F00C", VA = "0x187F00C")]
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
			[Address(RVA = "0x1361554", Offset = "0x1361554", VA = "0x1361554")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D34D0", Offset = "0x6D34D0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D34E8", Offset = "0x6D34E8")]
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
			[Address(RVA = "0x18802A0", Offset = "0x18802A0", VA = "0x18802A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x187F170", Offset = "0x187F170", VA = "0x187F170")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x187F1C0", Offset = "0x187F1C0", VA = "0x187F1C0")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x187F20C", Offset = "0x187F20C", VA = "0x187F20C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x187F6E0", Offset = "0x187F6E0", VA = "0x187F6E0", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x188002C", Offset = "0x188002C", VA = "0x188002C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x18800D8", Offset = "0x18800D8", VA = "0x18800D8")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x188021C", Offset = "0x188021C", VA = "0x188021C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x187F508", Offset = "0x187F508", VA = "0x187F508")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x187F7C4", Offset = "0x187F7C4", VA = "0x187F7C4")]
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
				[Address(RVA = "0x13617E0", Offset = "0x13617E0", VA = "0x13617E0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x13615B4", Offset = "0x13615B4", VA = "0x13615B4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x13615B8", Offset = "0x13615B8", VA = "0x13615B8")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x13615E0", Offset = "0x13615E0", VA = "0x13615E0")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x13616D8", Offset = "0x13616D8", VA = "0x13616D8")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3500", Offset = "0x6D3500")]
		public float bodyWeight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3518", Offset = "0x6D3518")]
		public float headWeight;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3530", Offset = "0x6D3530")]
		public float eyesWeight;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3548", Offset = "0x6D3548")]
		public float clampWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3560", Offset = "0x6D3560")]
		public float clampWeightHead;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3578", Offset = "0x6D3578")]
		public float clampWeightEyes;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3590", Offset = "0x6D3590")]
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
			[Address(RVA = "0x1880A38", Offset = "0x1880A38", VA = "0x1880A38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1880C08", Offset = "0x1880C08", VA = "0x1880C08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1880B18", Offset = "0x1880B18", VA = "0x1880B18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1880C2C", Offset = "0x1880C2C", VA = "0x1880C2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1880B28", Offset = "0x1880B28", VA = "0x1880B28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1880CA4", Offset = "0x1880CA4", VA = "0x1880CA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x18802BC", Offset = "0x18802BC", VA = "0x18802BC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x18802EC", Offset = "0x18802EC", VA = "0x18802EC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1880344", Offset = "0x1880344", VA = "0x1880344")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x18803C0", Offset = "0x18803C0", VA = "0x18803C0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1880458", Offset = "0x1880458", VA = "0x1880458")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1880518", Offset = "0x1880518", VA = "0x1880518")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1880614", Offset = "0x1880614", VA = "0x1880614", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1880740", Offset = "0x1880740", VA = "0x1880740", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1880880", Offset = "0x1880880", VA = "0x1880880", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1880CC8", Offset = "0x1880CC8", VA = "0x1880CC8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1880F08", Offset = "0x1880F08", VA = "0x1880F08", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x18810A4", Offset = "0x18810A4", VA = "0x18810A4")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x18812D0", Offset = "0x18812D0", VA = "0x18812D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x18815A4", Offset = "0x18815A4", VA = "0x18815A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1881674", Offset = "0x1881674", VA = "0x1881674")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1881814", Offset = "0x1881814", VA = "0x1881814")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x1881A38", Offset = "0x1881A38", VA = "0x1881A38")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1881DEC", Offset = "0x1881DEC", VA = "0x1881DEC")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x188114C", Offset = "0x188114C", VA = "0x188114C")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x188205C", Offset = "0x188205C", VA = "0x188205C")]
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
			[Address(RVA = "0x136181C", Offset = "0x136181C", VA = "0x136181C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1361918", Offset = "0x1361918", VA = "0x1361918")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1361948", Offset = "0x1361948", VA = "0x1361948")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1361984", Offset = "0x1361984", VA = "0x1361984")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D35A8", Offset = "0x6D35A8")]
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
		[Address(RVA = "0x1882278", Offset = "0x1882278", VA = "0x1882278")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x18823D4", Offset = "0x18823D4", VA = "0x18823D4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1882518", Offset = "0x1882518", VA = "0x1882518")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1882524", Offset = "0x1882524", VA = "0x1882524")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1882554", Offset = "0x1882554", VA = "0x1882554")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1882560", Offset = "0x1882560", VA = "0x1882560")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1882568", Offset = "0x1882568", VA = "0x1882568", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1882668", Offset = "0x1882668", VA = "0x1882668", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1882784", Offset = "0x1882784", VA = "0x1882784", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x18827D0", Offset = "0x18827D0", VA = "0x18827D0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1882830", Offset = "0x1882830", VA = "0x1882830", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1882BF8", Offset = "0x1882BF8", VA = "0x1882BF8")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1882C4C", Offset = "0x1882C4C", VA = "0x1882C4C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1883008", Offset = "0x1883008", VA = "0x1883008")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1883170", Offset = "0x1883170", VA = "0x1883170", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x18832D8", Offset = "0x18832D8", VA = "0x18832D8")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x188324C", Offset = "0x188324C", VA = "0x188324C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x18833DC", Offset = "0x18833DC", VA = "0x18833DC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1883BB4", Offset = "0x1883BB4", VA = "0x1883BB4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1883BB8", Offset = "0x1883BB8", VA = "0x1883BB8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1883BBC", Offset = "0x1883BBC", VA = "0x1883BBC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x18839CC", Offset = "0x18839CC", VA = "0x18839CC")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1880148", Offset = "0x1880148", VA = "0x1880148")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D37AC", Offset = "0x6D37AC")]
			public Transform target;

			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D37E4", Offset = "0x6D37E4")]
			public Transform bendGoal;

			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D381C", Offset = "0x6D381C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D381C", Offset = "0x6D381C")]
			public float positionWeight;

			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3870", Offset = "0x6D3870")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3870", Offset = "0x6D3870")]
			public float rotationWeight;

			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D38C4", Offset = "0x6D38C4")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D38FC", Offset = "0x6D38FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D38FC", Offset = "0x6D38FC")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3950", Offset = "0x6D3950")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3950", Offset = "0x6D3950")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D39A4", Offset = "0x6D39A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D39A4", Offset = "0x6D39A4")]
			public float bendGoalWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D39F8", Offset = "0x6D39F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D39F8", Offset = "0x6D39F8")]
			public float swivelOffset;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3A54", Offset = "0x6D3A54")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3A8C", Offset = "0x6D3A8C")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3AC4", Offset = "0x6D3AC4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3AC4", Offset = "0x6D3AC4")]
			public float armLengthMlp;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3B1C", Offset = "0x6D3B1C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3B94", Offset = "0x6D3B94")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3BA4", Offset = "0x6D3BA4")]
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
				[Address(RVA = "0x1361988", Offset = "0x1361988", VA = "0x1361988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA684", Offset = "0x6DA684")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x1361994", Offset = "0x1361994", VA = "0x1361994")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA694", Offset = "0x6DA694")]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0x13619A0", Offset = "0x13619A0", VA = "0x13619A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA6A4", Offset = "0x6DA6A4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600041A")]
				[Address(RVA = "0x13619AC", Offset = "0x13619AC", VA = "0x13619AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA6B4", Offset = "0x6DA6B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600041B")]
				[Address(RVA = "0x13619B8", Offset = "0x13619B8", VA = "0x13619B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600041C")]
				[Address(RVA = "0x13619EC", Offset = "0x13619EC", VA = "0x13619EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600041D")]
				[Address(RVA = "0x1361A2C", Offset = "0x1361A2C", VA = "0x1361A2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x600041E")]
				[Address(RVA = "0x1361A78", Offset = "0x1361A78", VA = "0x1361A78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1361AC4", Offset = "0x1361AC4", VA = "0x1361AC4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x13622EC", Offset = "0x13622EC", VA = "0x13622EC", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x13624A8", Offset = "0x13624A8", VA = "0x13624A8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x13624CC", Offset = "0x13624CC", VA = "0x13624CC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x136276C", Offset = "0x136276C", VA = "0x136276C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1363CC8", Offset = "0x1363CC8", VA = "0x1363CC8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1363CF4", Offset = "0x1363CF4", VA = "0x1363CF4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1363704", Offset = "0x1363704", VA = "0x1363704")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1363780", Offset = "0x1363780", VA = "0x1363780")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1363F14", Offset = "0x1363F14", VA = "0x1363F14")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x1364038", Offset = "0x1364038", VA = "0x1364038")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3BB4", Offset = "0x6D3BB4")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3BC4", Offset = "0x6D3BC4")]
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
				[Address(RVA = "0x1364190", Offset = "0x1364190", VA = "0x1364190")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA6C4", Offset = "0x6DA6C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x1364198", Offset = "0x1364198", VA = "0x1364198")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA6D4", Offset = "0x6DA6D4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000431")]
				[Address(RVA = "0x13641A0", Offset = "0x13641A0", VA = "0x13641A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA6E4", Offset = "0x6DA6E4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000432")]
				[Address(RVA = "0x13641A8", Offset = "0x13641A8", VA = "0x13641A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA6F4", Offset = "0x6DA6F4")]
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
			[Address(RVA = "0x13641B0", Offset = "0x13641B0", VA = "0x13641B0")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x13641B8", Offset = "0x13641B8", VA = "0x13641B8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x136428C", Offset = "0x136428C", VA = "0x136428C")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x1364320", Offset = "0x1364320", VA = "0x1364320")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x13643CC", Offset = "0x13643CC", VA = "0x13643CC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1364420", Offset = "0x1364420", VA = "0x1364420")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1363B84", Offset = "0x1363B84", VA = "0x1363B84")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x136455C", Offset = "0x136455C", VA = "0x136455C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x136469C", Offset = "0x136469C", VA = "0x136469C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x136411C", Offset = "0x136411C", VA = "0x136411C")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3BE4", Offset = "0x6D3BE4")]
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
				[Address(RVA = "0x13646C4", Offset = "0x13646C4", VA = "0x13646C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x600043E")]
				[Address(RVA = "0x13646D8", Offset = "0x13646D8", VA = "0x13646D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA704", Offset = "0x6DA704")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x13646E0", Offset = "0x13646E0", VA = "0x13646E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA714", Offset = "0x6DA714")]
				private set
				{
				}
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x13646E8", Offset = "0x13646E8", VA = "0x13646E8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x1364820", Offset = "0x1364820", VA = "0x1364820")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x1364868", Offset = "0x1364868", VA = "0x1364868")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1364A2C", Offset = "0x1364A2C", VA = "0x1364A2C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x1364BA0", Offset = "0x1364BA0", VA = "0x1364BA0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x1364CF8", Offset = "0x1364CF8", VA = "0x1364CF8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3BF4", Offset = "0x6D3BF4")]
			public Transform target;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3C2C", Offset = "0x6D3C2C")]
			public Transform bendGoal;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3C64", Offset = "0x6D3C64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3C64", Offset = "0x6D3C64")]
			public float positionWeight;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3CB8", Offset = "0x6D3CB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3CB8", Offset = "0x6D3CB8")]
			public float rotationWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3D0C", Offset = "0x6D3D0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3D0C", Offset = "0x6D3D0C")]
			public float bendGoalWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3D60", Offset = "0x6D3D60")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3D60", Offset = "0x6D3D60")]
			public float swivelOffset;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3DBC", Offset = "0x6D3DBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3DBC", Offset = "0x6D3DBC")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3E10", Offset = "0x6D3E10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3E10", Offset = "0x6D3E10")]
			public float legLengthMlp;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3E68", Offset = "0x6D3E68")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3F10", Offset = "0x6D3F10")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3F20", Offset = "0x6D3F20")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3F30", Offset = "0x6D3F30")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D3F40", Offset = "0x6D3F40")]
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
				[Address(RVA = "0x1364E34", Offset = "0x1364E34", VA = "0x1364E34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA724", Offset = "0x6DA724")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x1364E40", Offset = "0x1364E40", VA = "0x1364E40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA734", Offset = "0x6DA734")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000448")]
				[Address(RVA = "0x1364E4C", Offset = "0x1364E4C", VA = "0x1364E4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA744", Offset = "0x6DA744")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x1364E58", Offset = "0x1364E58", VA = "0x1364E58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA754", Offset = "0x6DA754")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600044A")]
				[Address(RVA = "0x1364E64", Offset = "0x1364E64", VA = "0x1364E64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA764", Offset = "0x6DA764")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x1364E6C", Offset = "0x1364E6C", VA = "0x1364E6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA774", Offset = "0x6DA774")]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x1364E78", Offset = "0x1364E78", VA = "0x1364E78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x1364EAC", Offset = "0x1364EAC", VA = "0x1364EAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x600044E")]
				[Address(RVA = "0x1364EE4", Offset = "0x1364EE4", VA = "0x1364EE4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x1364F1C", Offset = "0x1364F1C", VA = "0x1364F1C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x1364F54", Offset = "0x1364F54", VA = "0x1364F54")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x1364F94", Offset = "0x1364F94", VA = "0x1364F94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA784", Offset = "0x6DA784")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x1364FA0", Offset = "0x1364FA0", VA = "0x1364FA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA794", Offset = "0x6DA794")]
				private set
				{
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1364FAC", Offset = "0x1364FAC", VA = "0x1364FAC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x13655E0", Offset = "0x13655E0", VA = "0x13655E0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1365B9C", Offset = "0x1365B9C", VA = "0x1365B9C", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1365B4C", Offset = "0x1365B4C", VA = "0x1365B4C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x13659DC", Offset = "0x13659DC", VA = "0x13659DC")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1365F84", Offset = "0x1365F84", VA = "0x1365F84")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x1366434", Offset = "0x1366434", VA = "0x1366434")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1366114", Offset = "0x1366114", VA = "0x1366114")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x136672C", Offset = "0x136672C", VA = "0x136672C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1366948", Offset = "0x1366948", VA = "0x1366948", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1366994", Offset = "0x1366994", VA = "0x1366994")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3F50", Offset = "0x6D3F50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D3F50", Offset = "0x6D3F50")]
			public float weight;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3FA4", Offset = "0x6D3FA4")]
			public float footDistance;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3FDC", Offset = "0x6D3FDC")]
			public float stepThreshold;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4014", Offset = "0x6D4014")]
			public float angleThreshold;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D404C", Offset = "0x6D404C")]
			public float comAngleMlp;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4084", Offset = "0x6D4084")]
			public float maxVelocity;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D40BC", Offset = "0x6D40BC")]
			public float velocityFactor;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D40F4", Offset = "0x6D40F4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D40F4", Offset = "0x6D40F4")]
			public float maxLegStretch;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D414C", Offset = "0x6D414C")]
			public float rootSpeed;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4184", Offset = "0x6D4184")]
			public float stepSpeed;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D41BC", Offset = "0x6D41BC")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D41F4", Offset = "0x6D41F4")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D422C", Offset = "0x6D422C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D422C", Offset = "0x6D422C")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4284", Offset = "0x6D4284")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D42BC", Offset = "0x6D42BC")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D42F4", Offset = "0x6D42F4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D436C", Offset = "0x6D436C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D43A4", Offset = "0x6D43A4")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D43DC", Offset = "0x6D43DC")]
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
				[Address(RVA = "0x1366A64", Offset = "0x1366A64", VA = "0x1366A64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA7A4", Offset = "0x6DA7A4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x1366A70", Offset = "0x1366A70", VA = "0x1366A70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA7B4", Offset = "0x6DA7B4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0x13684F8", Offset = "0x13684F8", VA = "0x13684F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1368538", Offset = "0x1368538", VA = "0x1368538")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0x136857C", Offset = "0x136857C", VA = "0x136857C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x13685BC", Offset = "0x13685BC", VA = "0x13685BC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1366A7C", Offset = "0x1366A7C", VA = "0x1366A7C")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1366D1C", Offset = "0x1366D1C", VA = "0x1366D1C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1366EEC", Offset = "0x1366EEC", VA = "0x1366EEC")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1367134", Offset = "0x1367134", VA = "0x1367134")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x13671F8", Offset = "0x13671F8", VA = "0x13671F8")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1368270", Offset = "0x1368270", VA = "0x1368270")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x13683A8", Offset = "0x13683A8", VA = "0x13683A8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x136842C", Offset = "0x136842C", VA = "0x136842C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1368600", Offset = "0x1368600", VA = "0x1368600")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D43EC", Offset = "0x6D43EC")]
			public Transform headTarget;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4424", Offset = "0x6D4424")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D445C", Offset = "0x6D445C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D445C", Offset = "0x6D445C")]
			public float positionWeight;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D44B0", Offset = "0x6D44B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D44B0", Offset = "0x6D44B0")]
			public float rotationWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4504", Offset = "0x6D4504")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4504", Offset = "0x6D4504")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4558", Offset = "0x6D4558")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4558", Offset = "0x6D4558")]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D45AC", Offset = "0x6D45AC")]
			public Transform chestGoal;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D45E4", Offset = "0x6D45E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D45E4", Offset = "0x6D45E4")]
			public float chestGoalWeight;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4638", Offset = "0x6D4638")]
			public float minHeadHeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4670", Offset = "0x6D4670")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4670", Offset = "0x6D4670")]
			public float bodyPosStiffness;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D46C4", Offset = "0x6D46C4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D46C4", Offset = "0x6D46C4")]
			public float bodyRotStiffness;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4718", Offset = "0x6D4718")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4718", Offset = "0x6D4718")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6D4718", Offset = "0x6D4718")]
			public float neckStiffness;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4790", Offset = "0x6D4790")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4790", Offset = "0x6D4790")]
			public float rotateChestByHands;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D47E4", Offset = "0x6D47E4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D47E4", Offset = "0x6D47E4")]
			public float chestClampWeight;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4838", Offset = "0x6D4838")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4838", Offset = "0x6D4838")]
			public float headClampWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D488C", Offset = "0x6D488C")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D48C4", Offset = "0x6D48C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D48C4", Offset = "0x6D48C4")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4918", Offset = "0x6D4918")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4918", Offset = "0x6D4918")]
			public float maxRootAngle;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4970", Offset = "0x6D4970")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4970", Offset = "0x6D4970")]
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
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4AAC", Offset = "0x6D4AAC")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4ABC", Offset = "0x6D4ABC")]
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
				[Address(RVA = "0x1886374", Offset = "0x1886374", VA = "0x1886374")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x600046E")]
				[Address(RVA = "0x18863B4", Offset = "0x18863B4", VA = "0x18863B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x18863F4", Offset = "0x18863F4", VA = "0x18863F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x1886448", Offset = "0x1886448", VA = "0x1886448")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x1886488", Offset = "0x1886488", VA = "0x1886488")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x18864C8", Offset = "0x18864C8", VA = "0x18864C8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA7C4", Offset = "0x6DA7C4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000473")]
				[Address(RVA = "0x18864DC", Offset = "0x18864DC", VA = "0x18864DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA7D4", Offset = "0x6DA7D4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000474")]
				[Address(RVA = "0x18864F0", Offset = "0x18864F0", VA = "0x18864F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA7E4", Offset = "0x6DA7E4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x1886504", Offset = "0x1886504", VA = "0x1886504")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA7F4", Offset = "0x6DA7F4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x1886518", Offset = "0x1886518", VA = "0x1886518", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1886FC0", Offset = "0x1886FC0", VA = "0x1886FC0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0x18871CC", Offset = "0x18871CC", VA = "0x18871CC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000479")]
			[Address(RVA = "0x1887610", Offset = "0x1887610", VA = "0x1887610")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1887A4C", Offset = "0x1887A4C", VA = "0x1887A4C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600047B")]
			[Address(RVA = "0x18881A4", Offset = "0x18881A4", VA = "0x18881A4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1888828", Offset = "0x1888828", VA = "0x1888828")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x188922C", Offset = "0x188922C", VA = "0x188922C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1889408", Offset = "0x1889408", VA = "0x1889408", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x18877A8", Offset = "0x18877A8", VA = "0x18877A8")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x1888574", Offset = "0x1888574", VA = "0x1888574")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1887E5C", Offset = "0x1887E5C", VA = "0x1887E5C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x18894A0", Offset = "0x18894A0", VA = "0x18894A0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x1888654", Offset = "0x1888654", VA = "0x1888654")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x1888320", Offset = "0x1888320", VA = "0x1888320")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0x18897C8", Offset = "0x18897C8", VA = "0x18897C8")]
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
			[Address(RVA = "0x1886F24", Offset = "0x1886F24", VA = "0x1886F24")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000487")]
			[Address(RVA = "0x1886FA0", Offset = "0x1886FA0", VA = "0x1886FA0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000488")]
			[Address(RVA = "0x188993C", Offset = "0x188993C", VA = "0x188993C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1889AC0", Offset = "0x1889AC0", VA = "0x1889AC0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x18896A0", Offset = "0x18896A0", VA = "0x18896A0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1889CB0", Offset = "0x1889CB0", VA = "0x1889CB0")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1889E10", Offset = "0x1889E10", VA = "0x1889E10")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x1889F4C", Offset = "0x1889F4C", VA = "0x1889F4C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1888E28", Offset = "0x1888E28", VA = "0x1888E28")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x188A004", Offset = "0x188A004", VA = "0x188A004")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1888A98", Offset = "0x1888A98", VA = "0x1888A98")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x188A16C", Offset = "0x188A16C", VA = "0x188A16C")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x188A1DC", Offset = "0x188A1DC", VA = "0x188A1DC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D35C0", Offset = "0x6D35C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D35C0", Offset = "0x6D35C0")]
		public int LOD;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3614", Offset = "0x6D3614")]
		public bool plantFeet;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D364C", Offset = "0x6D364C")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D365C", Offset = "0x6D365C")]
		public Spine spine;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3694", Offset = "0x6D3694")]
		public Arm leftArm;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D36CC", Offset = "0x6D36CC")]
		public Arm rightArm;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3704", Offset = "0x6D3704")]
		public Leg leftLeg;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D373C", Offset = "0x6D373C")]
		public Leg rightLeg;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D3774", Offset = "0x6D3774")]
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
			[Address(RVA = "0x16AD18C", Offset = "0x16AD18C", VA = "0x16AD18C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA664", Offset = "0x6DA664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x16AD194", Offset = "0x16AD194", VA = "0x16AD194")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA674", Offset = "0x6DA674")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x16A9624", Offset = "0x16A9624", VA = "0x16A9624")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x16A9A88", Offset = "0x16A9A88", VA = "0x16A9A88")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x16A9934", Offset = "0x16A9934", VA = "0x16A9934")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x16AA1E8", Offset = "0x16AA1E8", VA = "0x16AA1E8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x16AA32C", Offset = "0x16AA32C", VA = "0x16AA32C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x16AA35C", Offset = "0x16AA35C", VA = "0x16AA35C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x16AA40C", Offset = "0x16AA40C", VA = "0x16AA40C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x16AA4F4", Offset = "0x16AA4F4", VA = "0x16AA4F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x16AAC58", Offset = "0x16AAC58", VA = "0x16AAC58", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x16AADC8", Offset = "0x16AADC8", VA = "0x16AADC8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x16AAFCC", Offset = "0x16AAFCC", VA = "0x16AAFCC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x16AB048", Offset = "0x16AB048", VA = "0x16AB048", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x16AB0C4", Offset = "0x16AB0C4", VA = "0x16AB0C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x16AB29C", Offset = "0x16AB29C", VA = "0x16AB29C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x16A9CBC", Offset = "0x16A9CBC", VA = "0x16A9CBC")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x16A9DAC", Offset = "0x16A9DAC", VA = "0x16A9DAC")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x16AA0C8", Offset = "0x16AA0C8", VA = "0x16AA0C8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x16AA5E8", Offset = "0x16AA5E8", VA = "0x16AA5E8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x16AB45C", Offset = "0x16AB45C", VA = "0x16AB45C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x16AB4A4", Offset = "0x16AB4A4", VA = "0x16AB4A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x16AC8BC", Offset = "0x16AC8BC", VA = "0x16AC8BC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x16AA74C", Offset = "0x16AA74C", VA = "0x16AA74C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x16AB818", Offset = "0x16AB818", VA = "0x16AB818")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x16ACC6C", Offset = "0x16ACC6C", VA = "0x16ACC6C")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x16ACCB4", Offset = "0x16ACCB4", VA = "0x16ACCB4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x16AC76C", Offset = "0x16AC76C", VA = "0x16AC76C")]
		private void Write()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x16ACCF8", Offset = "0x16ACCF8", VA = "0x16ACCF8")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x16AD19C", Offset = "0x16AD19C", VA = "0x16AD19C")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4ACC", Offset = "0x6D4ACC")]
		public Transform parent;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4B04", Offset = "0x6D4B04")]
		public Transform child;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4B3C", Offset = "0x6D4B3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4B3C", Offset = "0x6D4B3C")]
		public float weight;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4B90", Offset = "0x6D4B90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4B90", Offset = "0x6D4B90")]
		public float parentChildCrossfade;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4BE4", Offset = "0x6D4BE4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D4BE4", Offset = "0x6D4BE4")]
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
		[Address(RVA = "0x15232A0", Offset = "0x15232A0", VA = "0x15232A0")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x15235BC", Offset = "0x15235BC", VA = "0x15235BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x152397C", Offset = "0x152397C", VA = "0x152397C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1523A00", Offset = "0x1523A00", VA = "0x1523A00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1523A84", Offset = "0x1523A84", VA = "0x1523A84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1523B9C", Offset = "0x1523B9C", VA = "0x1523B9C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4C40", Offset = "0x6D4C40")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4C50", Offset = "0x6D4C50")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4C60", Offset = "0x6D4C60")]
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
			[Address(RVA = "0x16AE150", Offset = "0x16AE150", VA = "0x16AE150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA804", Offset = "0x6DA804")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x16AE158", Offset = "0x16AE158", VA = "0x16AE158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA814", Offset = "0x6DA814")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x16AE160", Offset = "0x16AE160", VA = "0x16AE160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA824", Offset = "0x6DA824")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x16AE168", Offset = "0x16AE168", VA = "0x16AE168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA834", Offset = "0x6DA834")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x16AE174", Offset = "0x16AE174", VA = "0x16AE174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA844", Offset = "0x6DA844")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x16AE17C", Offset = "0x16AE17C", VA = "0x16AE17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA854", Offset = "0x6DA854")]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x16AE184", Offset = "0x16AE184", VA = "0x16AE184")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x16B0554", Offset = "0x16B0554", VA = "0x16B0554")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x16AE1F0", Offset = "0x16AE1F0", VA = "0x16AE1F0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x16AE27C", Offset = "0x16AE27C", VA = "0x16AE27C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x16AE31C", Offset = "0x16AE31C", VA = "0x16AE31C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x16AE494", Offset = "0x16AE494", VA = "0x16AE494")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x16AE7F8", Offset = "0x16AE7F8", VA = "0x16AE7F8")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x16AE8B4", Offset = "0x16AE8B4", VA = "0x16AE8B4")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x16AE90C", Offset = "0x16AE90C", VA = "0x16AE90C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x16AF2FC", Offset = "0x16AF2FC", VA = "0x16AF2FC")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x16AFD64", Offset = "0x16AFD64", VA = "0x16AFD64")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x16AFFA8", Offset = "0x16AFFA8", VA = "0x16AFFA8")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x16B0400", Offset = "0x16B0400", VA = "0x16B0400")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x16B06B4", Offset = "0x16B06B4", VA = "0x16B06B4")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4C70", Offset = "0x6D4C70")]
		public LookAtIK ik;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4CA8", Offset = "0x6D4CA8")]
		public float lerpSpeed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4CE0", Offset = "0x6D4CE0")]
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
		[Address(RVA = "0x16B08A4", Offset = "0x16B08A4", VA = "0x16B08A4")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x16B09C0", Offset = "0x16B09C0", VA = "0x16B09C0")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x16B0A64", Offset = "0x16B0A64", VA = "0x16B0A64")]
		public void Update()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x16B109C", Offset = "0x16B109C", VA = "0x16B109C")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x16B1190", Offset = "0x16B1190", VA = "0x16B1190")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x16B1258", Offset = "0x16B1258", VA = "0x16B1258")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D0224", Offset = "0x6D0224")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D0224", Offset = "0x6D0224")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000083")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4DF0", Offset = "0x6D4DF0")]
			public float time;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4E28", Offset = "0x6D4E28")]
			public bool pause;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4E60", Offset = "0x6D4E60")]
			public bool pickUp;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4E98", Offset = "0x6D4E98")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4ED0", Offset = "0x6D4ED0")]
			public Message[] messages;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4F08", Offset = "0x6D4F08")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x188A988", Offset = "0x188A988", VA = "0x188A988")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x188AB5C", Offset = "0x188AB5C", VA = "0x188AB5C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4F40", Offset = "0x6D4F40")]
			public string function;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4F78", Offset = "0x6D4F78")]
			public GameObject recipient;

			[Token(Token = "0x400045C")]
			private const string empty = "";

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x188AA58", Offset = "0x188AA58", VA = "0x188AA58")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x188AB64", Offset = "0x188AB64", VA = "0x188AB64")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4FB0", Offset = "0x6D4FB0")]
			public Animator animator;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4FE8", Offset = "0x6D4FE8")]
			public Animation animation;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5020", Offset = "0x6D5020")]
			public string animationState;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5058", Offset = "0x6D5058")]
			public float crossfadeTime;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5090", Offset = "0x6D5090")]
			public int layer;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D50C8", Offset = "0x6D50C8")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000463")]
			private const string empty = "";

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x188A6F4", Offset = "0x188A6F4", VA = "0x188A6F4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x188A7E4", Offset = "0x188A7E4", VA = "0x188A7E4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x188A898", Offset = "0x188A898", VA = "0x188A898")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x188A974", Offset = "0x188A974", VA = "0x188A974")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5100", Offset = "0x6D5100")]
			public Type type;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5138", Offset = "0x6D5138")]
			public AnimationCurve curve;

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x188ABA8", Offset = "0x188ABA8", VA = "0x188ABA8")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x188ABD4", Offset = "0x188ABD4", VA = "0x188ABD4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5170", Offset = "0x6D5170")]
			public WeightCurve.Type curve;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D51A8", Offset = "0x6D51A8")]
			public float multiplier;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D51E0", Offset = "0x6D51E0")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x188AB6C", Offset = "0x188AB6C", VA = "0x188AB6C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x188ABC4", Offset = "0x188ABC4", VA = "0x188ABC4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4D28", Offset = "0x6D4D28")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4D60", Offset = "0x6D4D60")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D4D98", Offset = "0x6D4D98")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4DD0", Offset = "0x6D4DD0")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D4DE0", Offset = "0x6D4DE0")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x16B14AC", Offset = "0x16B14AC", VA = "0x16B14AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAA24", Offset = "0x6DAA24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x16B14B4", Offset = "0x16B14B4", VA = "0x16B14B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAA34", Offset = "0x6DAA34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x16B14BC", Offset = "0x16B14BC", VA = "0x16B14BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAA44", Offset = "0x6DAA44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x16B14C4", Offset = "0x16B14C4", VA = "0x16B14C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAA54", Offset = "0x6DAA54")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x16B168C", Offset = "0x16B168C", VA = "0x16B168C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x16B0590", Offset = "0x16B0590", VA = "0x16B0590")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x16B126C", Offset = "0x16B126C", VA = "0x16B126C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA864", Offset = "0x6DA864")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x16B12B4", Offset = "0x16B12B4", VA = "0x16B12B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA89C", Offset = "0x6DA89C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x16B12FC", Offset = "0x16B12FC", VA = "0x16B12FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA8D4", Offset = "0x6DA8D4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x16B1344", Offset = "0x16B1344", VA = "0x16B1344")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA90C", Offset = "0x6DA90C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x16B138C", Offset = "0x16B138C", VA = "0x16B138C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA944", Offset = "0x6DA944")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x16B13D4", Offset = "0x16B13D4", VA = "0x16B13D4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA97C", Offset = "0x6DA97C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x16B141C", Offset = "0x16B141C", VA = "0x16B141C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA9B4", Offset = "0x6DA9B4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x16B1464", Offset = "0x16B1464", VA = "0x16B1464")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DA9EC", Offset = "0x6DA9EC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x16B14CC", Offset = "0x16B14CC", VA = "0x16B14CC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x16B1718", Offset = "0x16B1718", VA = "0x16B1718")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x16AEE74", Offset = "0x16AEE74", VA = "0x16AEE74")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x16B18A4", Offset = "0x16B18A4", VA = "0x16B18A4")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x16AED20", Offset = "0x16AED20", VA = "0x16AED20")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x16AEE6C", Offset = "0x16AEE6C", VA = "0x16AEE6C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x16AF908", Offset = "0x16AF908", VA = "0x16AF908")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x16B01E0", Offset = "0x16B01E0", VA = "0x16B01E0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x16B1E88", Offset = "0x16B1E88", VA = "0x16B1E88")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x16B198C", Offset = "0x16B198C", VA = "0x16B198C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x16B18AC", Offset = "0x16B18AC", VA = "0x16B18AC")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x16B1E20", Offset = "0x16B1E20", VA = "0x16B1E20")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x16B1E8C", Offset = "0x16B1E8C", VA = "0x16B1E8C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x16B1EF4", Offset = "0x16B1EF4", VA = "0x16B1EF4")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D0284", Offset = "0x6D0284")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D0284", Offset = "0x6D0284")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008A")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008B")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5218", Offset = "0x6D5218")]
		public string targetTag;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5250", Offset = "0x6D5250")]
		public float fadeInTime;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5288", Offset = "0x6D5288")]
		public float speed;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D52C0", Offset = "0x6D52C0")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D52F8", Offset = "0x6D52F8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6D52F8", Offset = "0x6D52F8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D52F8", Offset = "0x6D52F8")]
		public Collider characterCollider;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D537C", Offset = "0x6D537C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x6D537C", Offset = "0x6D537C")]
		public Transform FPSCamera;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D53DC", Offset = "0x6D53DC")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5414", Offset = "0x6D5414")]
		public float camRaycastDistance;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D544C", Offset = "0x6D544C")]
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
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6D545C", Offset = "0x6D545C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D545C", Offset = "0x6D545C")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D54BC", Offset = "0x6D54BC")]
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
			[Address(RVA = "0x16AE028", Offset = "0x16AE028", VA = "0x16AE028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x16B3C04", Offset = "0x16B3C04", VA = "0x16B3C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x16B3C0C", Offset = "0x16B3C0C", VA = "0x16B3C0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x16B3C14", Offset = "0x16B3C14", VA = "0x16B3C14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAC24", Offset = "0x6DAC24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x16B3C1C", Offset = "0x16B3C1C", VA = "0x16B3C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAC34", Offset = "0x6DAC34")]
			private set
			{
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x16B1F50", Offset = "0x16B1F50", VA = "0x16B1F50")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAA64", Offset = "0x6DAA64")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x16B1F98", Offset = "0x16B1F98", VA = "0x16B1F98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAA9C", Offset = "0x6DAA9C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x16B1FE0", Offset = "0x16B1FE0", VA = "0x16B1FE0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAAD4", Offset = "0x6DAAD4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x16B2028", Offset = "0x16B2028", VA = "0x16B2028")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAB0C", Offset = "0x6DAB0C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x16B2070", Offset = "0x16B2070", VA = "0x16B2070")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAB44", Offset = "0x6DAB44")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x16B20B8", Offset = "0x16B20B8", VA = "0x16B20B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAB7C", Offset = "0x6DAB7C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x16B2100", Offset = "0x16B2100", VA = "0x16B2100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DABB4", Offset = "0x6DABB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x16B2148", Offset = "0x16B2148", VA = "0x16B2148")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DABEC", Offset = "0x6DABEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x16B2288", Offset = "0x16B2288", VA = "0x16B2288")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x16B2354", Offset = "0x16B2354", VA = "0x16B2354")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x16B2420", Offset = "0x16B2420", VA = "0x16B2420")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x16B24CC", Offset = "0x16B24CC", VA = "0x16B24CC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x16AD708", Offset = "0x16AD708", VA = "0x16AD708")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x16B25C4", Offset = "0x16B25C4", VA = "0x16B25C4")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x16B2654", Offset = "0x16B2654", VA = "0x16B2654")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x16B26E4", Offset = "0x16B26E4", VA = "0x16B26E4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x16B2774", Offset = "0x16B2774", VA = "0x16B2774")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x16AE0D4", Offset = "0x16AE0D4", VA = "0x16AE0D4")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x16B27E8", Offset = "0x16B27E8", VA = "0x16B27E8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x16B2850", Offset = "0x16B2850", VA = "0x16B2850")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x16B28DC", Offset = "0x16B28DC", VA = "0x16B28DC")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x16B2990", Offset = "0x16B2990", VA = "0x16B2990")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x16B2A74", Offset = "0x16B2A74", VA = "0x16B2A74")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x16B2D4C", Offset = "0x16B2D4C", VA = "0x16B2D4C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x16B2F2C", Offset = "0x16B2F2C", VA = "0x16B2F2C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x16B31C0", Offset = "0x16B31C0", VA = "0x16B31C0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x16B3498", Offset = "0x16B3498", VA = "0x16B3498")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x16B34DC", Offset = "0x16B34DC", VA = "0x16B34DC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x16B3554", Offset = "0x16B3554", VA = "0x16B3554")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x16B3670", Offset = "0x16B3670", VA = "0x16B3670")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x16B3814", Offset = "0x16B3814", VA = "0x16B3814")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x16B3AB8", Offset = "0x16B3AB8", VA = "0x16B3AB8")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x16B32D4", Offset = "0x16B32D4", VA = "0x16B32D4")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x16B3C24", Offset = "0x16B3C24", VA = "0x16B3C24")]
		public void Start()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x16B4390", Offset = "0x16B4390", VA = "0x16B4390")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x16B43B0", Offset = "0x16B43B0", VA = "0x16B43B0")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x16B43CC", Offset = "0x16B43CC", VA = "0x16B43CC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x16B43E8", Offset = "0x16B43E8", VA = "0x16B43E8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x16B4448", Offset = "0x16B4448", VA = "0x16B4448")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x16B4584", Offset = "0x16B4584", VA = "0x16B4584")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x16B4694", Offset = "0x16B4694", VA = "0x16B4694")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x16B4A38", Offset = "0x16B4A38", VA = "0x16B4A38")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x16B4B38", Offset = "0x16B4B38", VA = "0x16B4B38")]
		public void Update()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x16B4DC8", Offset = "0x16B4DC8", VA = "0x16B4DC8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x16B40F4", Offset = "0x16B40F4", VA = "0x16B40F4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x16B4F04", Offset = "0x16B4F04", VA = "0x16B4F04")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x16B502C", Offset = "0x16B502C", VA = "0x16B502C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x16B50C0", Offset = "0x16B50C0", VA = "0x16B50C0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x16B5194", Offset = "0x16B5194", VA = "0x16B5194")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x16B51AC", Offset = "0x16B51AC", VA = "0x16B51AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x16B2190", Offset = "0x16B2190", VA = "0x16B2190")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x16B2C1C", Offset = "0x16B2C1C", VA = "0x16B2C1C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x16B5514", Offset = "0x16B5514", VA = "0x16B5514")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D02E4", Offset = "0x6D02E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D02E4", Offset = "0x6D02E4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008D")]
		public class Multiplier
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D56B4", Offset = "0x6D56B4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D56EC", Offset = "0x6D56EC")]
			public float multiplier;

			[Token(Token = "0x6000529")]
			[Address(RVA = "0x188B240", Offset = "0x188B240", VA = "0x188B240")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D54F4", Offset = "0x6D54F4")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D552C", Offset = "0x6D552C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5564", Offset = "0x6D5564")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D559C", Offset = "0x6D559C")]
		public Transform pivot;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D55D4", Offset = "0x6D55D4")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D560C", Offset = "0x6D560C")]
		public float twistWeight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5644", Offset = "0x6D5644")]
		public float swingWeight;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D567C", Offset = "0x6D567C")]
		public bool rotateOnce;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x16B5C4C", Offset = "0x16B5C4C", VA = "0x16B5C4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAC44", Offset = "0x6DAC44")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x16B5C94", Offset = "0x16B5C94", VA = "0x16B5C94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAC7C", Offset = "0x6DAC7C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x16B5CDC", Offset = "0x16B5CDC", VA = "0x16B5CDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DACB4", Offset = "0x6DACB4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x16B5D24", Offset = "0x16B5D24", VA = "0x16B5D24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DACEC", Offset = "0x6DACEC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x16B5D6C", Offset = "0x16B5D6C", VA = "0x16B5D6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAD24", Offset = "0x6DAD24")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x16B5DB4", Offset = "0x16B5DB4", VA = "0x16B5DB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAD5C", Offset = "0x6DAD5C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x16B5DFC", Offset = "0x16B5DFC", VA = "0x16B5DFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAD94", Offset = "0x6DAD94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x16B5E44", Offset = "0x16B5E44", VA = "0x16B5E44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DADCC", Offset = "0x6DADCC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x16B191C", Offset = "0x16B191C", VA = "0x16B191C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x16B061C", Offset = "0x16B061C", VA = "0x16B061C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x16AEF28", Offset = "0x16AEF28", VA = "0x16AEF28")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x16B5E8C", Offset = "0x16B5E8C", VA = "0x16B5E8C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D0344", Offset = "0x6D0344")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D0344", Offset = "0x6D0344")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public class CharacterPosition
		{
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D575C", Offset = "0x6D575C")]
			public bool use;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5794", Offset = "0x6D5794")]
			public Vector2 offset;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D57CC", Offset = "0x6D57CC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D57CC", Offset = "0x6D57CC")]
			public float angleOffset;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5828", Offset = "0x6D5828")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5828", Offset = "0x6D5828")]
			public float maxAngle;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5880", Offset = "0x6D5880")]
			public float radius;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D58B8", Offset = "0x6D58B8")]
			public bool orbit;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D58F0", Offset = "0x6D58F0")]
			public bool fixYAxis;

			[Token(Token = "0x1700008D")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000532")]
				[Address(RVA = "0x188B5B0", Offset = "0x188B5B0", VA = "0x188B5B0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008E")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x188B5BC", Offset = "0x188B5BC", VA = "0x188B5BC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x188B644", Offset = "0x188B644", VA = "0x188B644")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x188BA88", Offset = "0x188BA88", VA = "0x188BA88")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5928", Offset = "0x6D5928")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5960", Offset = "0x6D5960")]
			public Vector3 direction;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5998", Offset = "0x6D5998")]
			public float maxDistance;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D59D0", Offset = "0x6D59D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D59D0", Offset = "0x6D59D0")]
			public float maxAngle;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5A28", Offset = "0x6D5A28")]
			public bool fixYAxis;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x188B248", Offset = "0x188B248", VA = "0x188B248")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x188B33C", Offset = "0x188B33C", VA = "0x188B33C")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x188B564", Offset = "0x188B564", VA = "0x188B564")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5B78", Offset = "0x6D5B78")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004AD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5BB0", Offset = "0x6D5BB0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600053B")]
				[Address(RVA = "0x1890F78", Offset = "0x1890F78", VA = "0x1890F78")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5AD0", Offset = "0x6D5AD0")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5B08", Offset = "0x6D5B08")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5B40", Offset = "0x6D5B40")]
			public Interaction[] interactions;

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x188BA9C", Offset = "0x188BA9C", VA = "0x188BA9C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x188BB50", Offset = "0x188BB50", VA = "0x188BB50")]
			public Range()
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5724", Offset = "0x6D5724")]
		public Range[] ranges;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x16B5ED4", Offset = "0x16B5ED4", VA = "0x16B5ED4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAE04", Offset = "0x6DAE04")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x16B5F1C", Offset = "0x16B5F1C", VA = "0x16B5F1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAE3C", Offset = "0x6DAE3C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x16B5F64", Offset = "0x16B5F64", VA = "0x16B5F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAE74", Offset = "0x6DAE74")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x16B5FAC", Offset = "0x16B5FAC", VA = "0x16B5FAC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAEAC", Offset = "0x6DAEAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x16B5FF4", Offset = "0x16B5FF4", VA = "0x16B5FF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAEE4", Offset = "0x6DAEE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x16B603C", Offset = "0x16B603C", VA = "0x16B603C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x16B4864", Offset = "0x16B4864", VA = "0x16B4864")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x16B6040", Offset = "0x16B6040", VA = "0x16B6040")]
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
			[Address(RVA = "0x135C8A8", Offset = "0x135C8A8", VA = "0x135C8A8")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000544")]
			[Address(RVA = "0x135C8E4", Offset = "0x135C8E4", VA = "0x135C8E4")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x135C934", Offset = "0x135C934", VA = "0x135C934")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x135C980", Offset = "0x135C980", VA = "0x135C980")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x167C350", Offset = "0x167C350", VA = "0x167C350", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DAF1C", Offset = "0x6DAF1C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x167C6CC", Offset = "0x167C6CC", VA = "0x167C6CC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x167C6D0", Offset = "0x167C6D0", VA = "0x167C6D0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x167C7D8", Offset = "0x167C7D8", VA = "0x167C7D8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x167C660", Offset = "0x167C660", VA = "0x167C660")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x167C5C0", Offset = "0x167C5C0", VA = "0x167C5C0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x167C844", Offset = "0x167C844", VA = "0x167C844")]
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
		[Address(RVA = "0x1683428", Offset = "0x1683428", VA = "0x1683428", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x16834F0", Offset = "0x16834F0", VA = "0x16834F0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x16836AC", Offset = "0x16836AC", VA = "0x16836AC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x16837A8", Offset = "0x16837A8", VA = "0x16837A8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1683548", Offset = "0x1683548", VA = "0x1683548")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1683B08", Offset = "0x1683B08", VA = "0x1683B08")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5BE8", Offset = "0x6D5BE8")]
		public float weight;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5C00", Offset = "0x6D5C00")]
		public float localRotationWeight;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5C18", Offset = "0x6D5C18")]
		public float localPositionWeight;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600054D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x151B7FC", Offset = "0x151B7FC", VA = "0x151B7FC")]
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
		[Address(RVA = "0x151B808", Offset = "0x151B808", VA = "0x151B808", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x151B85C", Offset = "0x151B85C", VA = "0x151B85C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x151B898", Offset = "0x151B898", VA = "0x151B898", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x151B8B0", Offset = "0x151B8B0", VA = "0x151B8B0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D03A4", Offset = "0x6D03A4")]
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
			[Address(RVA = "0x188DAC0", Offset = "0x188DAC0", VA = "0x188DAC0")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x188DC30", Offset = "0x188DC30", VA = "0x188DC30")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x188DD10", Offset = "0x188DD10", VA = "0x188DD10")]
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
			[Address(RVA = "0x188D8D0", Offset = "0x188D8D0", VA = "0x188D8D0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x188D930", Offset = "0x188D930", VA = "0x188D930")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x188DA70", Offset = "0x188DA70", VA = "0x188DA70")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0404", Offset = "0x6D0404")]
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
				[Address(RVA = "0x188D880", Offset = "0x188D880", VA = "0x188D880", Slot = "4")]
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
				[Address(RVA = "0x188D8C8", Offset = "0x188D8C8", VA = "0x188D8C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x188D664", Offset = "0x188D664", VA = "0x188D664")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x188D690", Offset = "0x188D690", VA = "0x188D690", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000570")]
			[Address(RVA = "0x188D694", Offset = "0x188D694", VA = "0x188D694", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x188D888", Offset = "0x188D888", VA = "0x188D888", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5C30", Offset = "0x6D5C30")]
		public IK ik;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5C68", Offset = "0x6D5C68")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5CA0", Offset = "0x6D5CA0")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5CD8", Offset = "0x6D5CD8")]
		public float applyVelocity;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5D10", Offset = "0x6D5D10")]
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
			[Address(RVA = "0x151C1E0", Offset = "0x151C1E0", VA = "0x151C1E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000090")]
		private bool ikUsed
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x151CB68", Offset = "0x151CB68", VA = "0x151CB68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x151C1A8", Offset = "0x151C1A8", VA = "0x151C1A8")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x151C258", Offset = "0x151C258", VA = "0x151C258")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x151C388", Offset = "0x151C388", VA = "0x151C388")]
		public void Start()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x151C31C", Offset = "0x151C31C", VA = "0x151C31C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DAF54", Offset = "0x6DAF54")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x151C7A4", Offset = "0x151C7A4", VA = "0x151C7A4")]
		private void Update()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x151C9F0", Offset = "0x151C9F0", VA = "0x151C9F0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x151CAAC", Offset = "0x151CAAC", VA = "0x151CAAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x151CCE8", Offset = "0x151CCE8", VA = "0x151CCE8")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x151CB2C", Offset = "0x151CB2C", VA = "0x151CB2C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x151CCA4", Offset = "0x151CCA4", VA = "0x151CCA4")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x151CD88", Offset = "0x151CD88", VA = "0x151CD88")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x151CD1C", Offset = "0x151CD1C", VA = "0x151CD1C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x151C2B0", Offset = "0x151C2B0", VA = "0x151C2B0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x151CA30", Offset = "0x151CA30", VA = "0x151CA30")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x151CFB4", Offset = "0x151CFB4", VA = "0x151CFB4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x151D0CC", Offset = "0x151D0CC", VA = "0x151D0CC")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D5D58", Offset = "0x6D5D58")]
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
			[Address(RVA = "0x151E7E8", Offset = "0x151E7E8", VA = "0x151E7E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x151E7F4", Offset = "0x151E7F4", VA = "0x151E7F4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x151E810", Offset = "0x151E810", VA = "0x151E810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB004", Offset = "0x6DB004")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x151E818", Offset = "0x151E818", VA = "0x151E818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB014", Offset = "0x6DB014")]
			private set
			{
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x151E4E8", Offset = "0x151E4E8", VA = "0x151E4E8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x151E530", Offset = "0x151E530", VA = "0x151E530")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x151E548", Offset = "0x151E548", VA = "0x151E548")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x151E740", Offset = "0x151E740", VA = "0x151E740")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x151E7B0", Offset = "0x151E7B0", VA = "0x151E7B0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600057D")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x151E668", Offset = "0x151E668", VA = "0x151E668")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x151E824", Offset = "0x151E824", VA = "0x151E824")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x151E828", Offset = "0x151E828", VA = "0x151E828")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x151E85C", Offset = "0x151E85C", VA = "0x151E85C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x151E8D8", Offset = "0x151E8D8", VA = "0x151E8D8")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x151EA6C", Offset = "0x151EA6C", VA = "0x151EA6C")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x151EADC", Offset = "0x151EADC", VA = "0x151EADC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D0414", Offset = "0x6D0414")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D0414", Offset = "0x6D0414")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5D68", Offset = "0x6D5D68")]
		public float limit;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5D84", Offset = "0x6D5D84")]
		public float twistLimit;

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x151EB10", Offset = "0x151EB10", VA = "0x151EB10")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB024", Offset = "0x6DB024")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x151EB58", Offset = "0x151EB58", VA = "0x151EB58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB05C", Offset = "0x6DB05C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x151EBA0", Offset = "0x151EBA0", VA = "0x151EBA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB094", Offset = "0x6DB094")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x151EBE8", Offset = "0x151EBE8", VA = "0x151EBE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB0CC", Offset = "0x6DB0CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x151EC30", Offset = "0x151EC30", VA = "0x151EC30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x151EC74", Offset = "0x151EC74", VA = "0x151EC74")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x151EE34", Offset = "0x151EE34", VA = "0x151EE34")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D0474", Offset = "0x6D0474")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D0474", Offset = "0x6D0474")]
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
		[Address(RVA = "0x151EE74", Offset = "0x151EE74", VA = "0x151EE74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB104", Offset = "0x6DB104")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x151EEBC", Offset = "0x151EEBC", VA = "0x151EEBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB13C", Offset = "0x6DB13C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x151EF04", Offset = "0x151EF04", VA = "0x151EF04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB174", Offset = "0x6DB174")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x151EF4C", Offset = "0x151EF4C", VA = "0x151EF4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB1AC", Offset = "0x6DB1AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x151EF94", Offset = "0x151EF94", VA = "0x151EF94", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x151EFBC", Offset = "0x151EFBC", VA = "0x151EFBC")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x151F1B8", Offset = "0x151F1B8", VA = "0x151F1B8")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D04D4", Offset = "0x6D04D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D04D4", Offset = "0x6D04D4")]
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
				[Address(RVA = "0x188E344", Offset = "0x188E344", VA = "0x188E344")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000097")]
			public Vector3 a
			{
				[Token(Token = "0x60005A4")]
				[Address(RVA = "0x188E37C", Offset = "0x188E37C", VA = "0x188E37C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 b
			{
				[Token(Token = "0x60005A5")]
				[Address(RVA = "0x188E3B8", Offset = "0x188E3B8", VA = "0x188E3B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 c
			{
				[Token(Token = "0x60005A6")]
				[Address(RVA = "0x188E3F4", Offset = "0x188E3F4", VA = "0x188E3F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public bool isValid
			{
				[Token(Token = "0x60005A8")]
				[Address(RVA = "0x188E56C", Offset = "0x188E56C", VA = "0x188E56C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x188E430", Offset = "0x188E430", VA = "0x188E430")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x188E57C", Offset = "0x188E57C", VA = "0x188E57C")]
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
			[Address(RVA = "0x188E308", Offset = "0x188E308", VA = "0x188E308")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5DB0", Offset = "0x6D5DB0")]
		public float twistLimit;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5DCC", Offset = "0x6D5DCC")]
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
		[Address(RVA = "0x151F210", Offset = "0x151F210", VA = "0x151F210")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB1E4", Offset = "0x6DB1E4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x151F258", Offset = "0x151F258", VA = "0x151F258")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB21C", Offset = "0x6DB21C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x151F2A0", Offset = "0x151F2A0", VA = "0x151F2A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB254", Offset = "0x6DB254")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x151F2E8", Offset = "0x151F2E8", VA = "0x151F2E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB28C", Offset = "0x6DB28C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x151F330", Offset = "0x151F330", VA = "0x151F330")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x151F7D0", Offset = "0x151F7D0", VA = "0x151F7D0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x151F864", Offset = "0x151F864", VA = "0x151F864")]
		private void Start()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x151FD90", Offset = "0x151FD90", VA = "0x151FD90")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x151F3CC", Offset = "0x151F3CC", VA = "0x151F3CC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1520110", Offset = "0x1520110", VA = "0x1520110")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x152051C", Offset = "0x152051C", VA = "0x152051C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1520560", Offset = "0x1520560", VA = "0x1520560")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x15205C0", Offset = "0x15205C0", VA = "0x15205C0")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x151FB20", Offset = "0x151FB20", VA = "0x151FB20")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x152062C", Offset = "0x152062C", VA = "0x152062C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1520708", Offset = "0x1520708", VA = "0x1520708")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D0534", Offset = "0x6D0534")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x6D0534", Offset = "0x6D0534")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5E8C", Offset = "0x6D5E8C")]
		public float twistLimit;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x152077C", Offset = "0x152077C", VA = "0x152077C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB2C4", Offset = "0x6DB2C4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x15207C4", Offset = "0x15207C4", VA = "0x15207C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB2FC", Offset = "0x6DB2FC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x152080C", Offset = "0x152080C", VA = "0x152080C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB334", Offset = "0x6DB334")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1520854", Offset = "0x1520854", VA = "0x1520854")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x6DB36C", Offset = "0x6DB36C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x152089C", Offset = "0x152089C", VA = "0x152089C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x15208B8", Offset = "0x15208B8", VA = "0x15208B8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x15208FC", Offset = "0x15208FC", VA = "0x15208FC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1520B20", Offset = "0x1520B20", VA = "0x1520B20")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0594", Offset = "0x6D0594")]
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
				[Address(RVA = "0x1358814", Offset = "0x1358814", VA = "0x1358814", Slot = "4")]
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
				[Address(RVA = "0x135885C", Offset = "0x135885C", VA = "0x135885C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x1358724", Offset = "0x1358724", VA = "0x1358724")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x1358750", Offset = "0x1358750", VA = "0x1358750", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x1358754", Offset = "0x1358754", VA = "0x1358754", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x135881C", Offset = "0x135881C", VA = "0x135881C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5EE0", Offset = "0x6D5EE0")]
		public AimIK ik;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5F18", Offset = "0x6D5F18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D5F18", Offset = "0x6D5F18")]
		public float weight;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D5F6C", Offset = "0x6D5F6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5F6C", Offset = "0x6D5F6C")]
		public Transform target;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D5FCC", Offset = "0x6D5FCC")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6004", Offset = "0x6D6004")]
		public float weightSmoothTime;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D603C", Offset = "0x6D603C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D603C", Offset = "0x6D603C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D609C", Offset = "0x6D609C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D60D4", Offset = "0x6D60D4")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D610C", Offset = "0x6D610C")]
		public float slerpSpeed;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6144", Offset = "0x6D6144")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D617C", Offset = "0x6D617C")]
		public float minDistance;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D61B4", Offset = "0x6D61B4")]
		public Vector3 offset;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D61EC", Offset = "0x6D61EC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D61EC", Offset = "0x6D61EC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D61EC", Offset = "0x6D61EC")]
		public float maxRootAngle;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6268", Offset = "0x6D6268")]
		public bool turnToTarget;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D62A0", Offset = "0x6D62A0")]
		public float turnToTargetTime;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D62D8", Offset = "0x6D62D8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D62D8", Offset = "0x6D62D8")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6338", Offset = "0x6D6338")]
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
			[Address(RVA = "0x16660B0", Offset = "0x16660B0", VA = "0x16660B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1666028", Offset = "0x1666028", VA = "0x1666028")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1666140", Offset = "0x1666140", VA = "0x1666140")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1666698", Offset = "0x1666698", VA = "0x1666698")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1666784", Offset = "0x1666784", VA = "0x1666784")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x16669D4", Offset = "0x16669D4", VA = "0x16669D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB3A4", Offset = "0x6DB3A4")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1666A40", Offset = "0x1666A40", VA = "0x1666A40")]
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
			[Address(RVA = "0x1358864", Offset = "0x1358864", VA = "0x1358864")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x13589F0", Offset = "0x13589F0", VA = "0x13589F0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x13589F8", Offset = "0x13589F8", VA = "0x13589F8")]
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
		[Address(RVA = "0x1666CA4", Offset = "0x1666CA4", VA = "0x1666CA4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1666D84", Offset = "0x1666D84", VA = "0x1666D84")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1666DF0", Offset = "0x1666DF0", VA = "0x1666DF0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D64F8", Offset = "0x6D64F8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400052A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6530", Offset = "0x6D6530")]
				public float weight;

				[Token(Token = "0x60005CB")]
				[Address(RVA = "0x1890B5C", Offset = "0x1890B5C", VA = "0x1890B5C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D63A8", Offset = "0x6D63A8")]
			public Transform transform;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D63E0", Offset = "0x6D63E0")]
			public Transform relativeTo;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6418", Offset = "0x6D6418")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6450", Offset = "0x6D6450")]
			public float verticalWeight;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6488", Offset = "0x6D6488")]
			public float horizontalWeight;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D64C0", Offset = "0x6D64C0")]
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
			[Address(RVA = "0x1358A14", Offset = "0x1358A14", VA = "0x1358A14")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1358D40", Offset = "0x1358D40", VA = "0x1358D40")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1358D50", Offset = "0x1358D50", VA = "0x1358D50")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6370", Offset = "0x6D6370")]
		public Body[] bodies;

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1666F00", Offset = "0x1666F00", VA = "0x1666F00", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x166704C", Offset = "0x166704C", VA = "0x166704C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6568", Offset = "0x6D6568")]
		public float tiltSpeed;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D65A0", Offset = "0x6D65A0")]
		public float tiltSensitivity;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D65D8", Offset = "0x6D65D8")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6610", Offset = "0x6D6610")]
		public OffsetPose poseRight;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x16742C0", Offset = "0x16742C0", VA = "0x16742C0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1674308", Offset = "0x1674308", VA = "0x1674308", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x16744C0", Offset = "0x16744C0", VA = "0x16744C0")]
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
		[Address(RVA = "0xFBD208", Offset = "0xFBD208", VA = "0xFBD208")]
		private void Start()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xFBD298", Offset = "0xFBD298", VA = "0xFBD298")]
		private void Update()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xFBD364", Offset = "0xFBD364", VA = "0xFBD364")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D66B8", Offset = "0x6D66B8")]
			public string name;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D66F0", Offset = "0x6D66F0")]
			public Collider collider;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6728", Offset = "0x6D6728")]
			private float crossFadeTime;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6774", Offset = "0x6D6774")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6784", Offset = "0x6D6784")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6794", Offset = "0x6D6794")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D67A4", Offset = "0x6D67A4")]
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
				[Address(RVA = "0x135E404", Offset = "0x135E404", VA = "0x135E404")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A0")]
			protected float crossFader
			{
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0x135E418", Offset = "0x135E418", VA = "0x135E418")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB454", Offset = "0x6DB454")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x135E420", Offset = "0x135E420", VA = "0x135E420")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB464", Offset = "0x6DB464")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A1")]
			protected float timer
			{
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x135E428", Offset = "0x135E428", VA = "0x135E428")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB474", Offset = "0x6DB474")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x135E430", Offset = "0x135E430", VA = "0x135E430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB484", Offset = "0x6DB484")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			protected Vector3 force
			{
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x135E438", Offset = "0x135E438", VA = "0x135E438")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB494", Offset = "0x6DB494")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DC")]
				[Address(RVA = "0x135E444", Offset = "0x135E444", VA = "0x135E444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB4A4", Offset = "0x6DB4A4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A3")]
			protected Vector3 point
			{
				[Token(Token = "0x60005DD")]
				[Address(RVA = "0x135E450", Offset = "0x135E450", VA = "0x135E450")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB4B4", Offset = "0x6DB4B4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0x135E45C", Offset = "0x135E45C", VA = "0x135E45C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB4C4", Offset = "0x6DB4C4")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x135E468", Offset = "0x135E468", VA = "0x135E468")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x135E59C", Offset = "0x135E59C", VA = "0x135E59C")]
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
			[Address(RVA = "0x135E670", Offset = "0x135E670", VA = "0x135E670")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D685C", Offset = "0x6D685C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000542")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6894", Offset = "0x6D6894")]
				public float weight;

				[Token(Token = "0x4000543")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000544")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60005E9")]
				[Address(RVA = "0x1890CCC", Offset = "0x1890CCC", VA = "0x1890CCC")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x1890D7C", Offset = "0x1890D7C", VA = "0x1890D7C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x1890D90", Offset = "0x1890D90", VA = "0x1890D90")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D67B4", Offset = "0x6D67B4")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D67EC", Offset = "0x6D67EC")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6824", Offset = "0x6D6824")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x135E99C", Offset = "0x135E99C", VA = "0x135E99C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x135EACC", Offset = "0x135EACC", VA = "0x135EACC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x135EB38", Offset = "0x135EB38", VA = "0x135EB38", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x135ECA0", Offset = "0x135ECA0", VA = "0x135ECA0")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D693C", Offset = "0x6D693C")]
				public Transform bone;

				[Token(Token = "0x4000549")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D6974", Offset = "0x6D6974")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6974", Offset = "0x6D6974")]
				public float weight;

				[Token(Token = "0x400054A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400054B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60005F0")]
				[Address(RVA = "0x1890B64", Offset = "0x1890B64", VA = "0x1890B64")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60005F1")]
				[Address(RVA = "0x1890C7C", Offset = "0x1890C7C", VA = "0x1890C7C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60005F2")]
				[Address(RVA = "0x1890C88", Offset = "0x1890C88", VA = "0x1890C88")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D68CC", Offset = "0x6D68CC")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6904", Offset = "0x6D6904")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x135E684", Offset = "0x135E684", VA = "0x135E684", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x135E728", Offset = "0x135E728", VA = "0x135E728", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x135E794", Offset = "0x135E794", VA = "0x135E794", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x135E988", Offset = "0x135E988", VA = "0x135E988")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6648", Offset = "0x6D6648")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6680", Offset = "0x6D6680")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700009E")]
		public bool inProgress
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x16849A8", Offset = "0x16849A8", VA = "0x16849A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1684A78", Offset = "0x1684A78", VA = "0x1684A78", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1684B54", Offset = "0x1684B54", VA = "0x1684B54")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1684DB0", Offset = "0x1684DB0", VA = "0x1684DB0")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6A38", Offset = "0x6D6A38")]
			public string name;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6A70", Offset = "0x6D6A70")]
			public Collider collider;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6AA8", Offset = "0x6D6AA8")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6AF4", Offset = "0x6D6AF4")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6B04", Offset = "0x6D6B04")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6B14", Offset = "0x6D6B14")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D6B24", Offset = "0x6D6B24")]
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
				[Address(RVA = "0x135ECB4", Offset = "0x135ECB4", VA = "0x135ECB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB4D4", Offset = "0x6DB4D4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0x135ECBC", Offset = "0x135ECBC", VA = "0x135ECBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB4E4", Offset = "0x6DB4E4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected float timer
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x135ECC4", Offset = "0x135ECC4", VA = "0x135ECC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB4F4", Offset = "0x6DB4F4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0x135ECCC", Offset = "0x135ECCC", VA = "0x135ECCC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB504", Offset = "0x6DB504")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 force
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x135ECD4", Offset = "0x135ECD4", VA = "0x135ECD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB514", Offset = "0x6DB514")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x135ECE0", Offset = "0x135ECE0", VA = "0x135ECE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB524", Offset = "0x6DB524")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			protected Vector3 point
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x135ECEC", Offset = "0x135ECEC", VA = "0x135ECEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB534", Offset = "0x6DB534")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x135ECF8", Offset = "0x135ECF8", VA = "0x135ECF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB544", Offset = "0x6DB544")]
				private set
				{
				}
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x135ED04", Offset = "0x135ED04", VA = "0x135ED04")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x135EE4C", Offset = "0x135EE4C", VA = "0x135EE4C")]
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
			[Address(RVA = "0x135EF34", Offset = "0x135EF34", VA = "0x135EF34")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6BDC", Offset = "0x6D6BDC")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6C14", Offset = "0x6D6C14")]
				public float weight;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000608")]
				[Address(RVA = "0x1890D98", Offset = "0x1890D98", VA = "0x1890D98")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000609")]
				[Address(RVA = "0x1890E28", Offset = "0x1890E28", VA = "0x1890E28")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060A")]
				[Address(RVA = "0x1890E3C", Offset = "0x1890E3C", VA = "0x1890E3C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6B34", Offset = "0x6D6B34")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6B6C", Offset = "0x6D6B6C")]
			public int upDirCurveIndex;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6BA4", Offset = "0x6D6BA4")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x135EF48", Offset = "0x135EF48", VA = "0x135EF48", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x135F0F8", Offset = "0x135F0F8", VA = "0x135F0F8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x135F164", Offset = "0x135F164", VA = "0x135F164", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x135F304", Offset = "0x135F304", VA = "0x135F304")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6CBC", Offset = "0x6D6CBC")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6CF4", Offset = "0x6D6CF4")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D6CF4", Offset = "0x6D6CF4")]
				public float weight;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000566")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x1890E44", Offset = "0x1890E44", VA = "0x1890E44")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000610")]
				[Address(RVA = "0x1890F20", Offset = "0x1890F20", VA = "0x1890F20")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000611")]
				[Address(RVA = "0x1890F2C", Offset = "0x1890F2C", VA = "0x1890F2C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6C4C", Offset = "0x6D6C4C")]
			public int curveIndex;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6C84", Offset = "0x6D6C84")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x135F320", Offset = "0x135F320", VA = "0x135F320", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x135F404", Offset = "0x135F404", VA = "0x135F404", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x135F470", Offset = "0x135F470", VA = "0x135F470", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x135F724", Offset = "0x135F724", VA = "0x135F724")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D69C8", Offset = "0x6D69C8")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6A00", Offset = "0x6D6A00")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1685104", Offset = "0x1685104", VA = "0x1685104", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x16851D8", Offset = "0x16851D8", VA = "0x16851D8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x168543C", Offset = "0x168543C", VA = "0x168543C")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6F24", Offset = "0x6D6F24")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000575")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6F5C", Offset = "0x6D6F5C")]
				public float weight;

				[Token(Token = "0x6000618")]
				[Address(RVA = "0x1890F70", Offset = "0x1890F70", VA = "0x1890F70")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6DB8", Offset = "0x6D6DB8")]
			public Transform transform;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6DF0", Offset = "0x6D6DF0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6E28", Offset = "0x6D6E28")]
			public float speed;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6E60", Offset = "0x6D6E60")]
			public float acceleration;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D6E98", Offset = "0x6D6E98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6E98", Offset = "0x6D6E98")]
			public float matchVelocity;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6EEC", Offset = "0x6D6EEC")]
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
			[Address(RVA = "0x188A364", Offset = "0x188A364", VA = "0x188A364")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x188A41C", Offset = "0x188A41C", VA = "0x188A41C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x188A6D8", Offset = "0x188A6D8", VA = "0x188A6D8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6D48", Offset = "0x6D6D48")]
		public Body[] bodies;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6D80", Offset = "0x6D6D80")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x16AD3B8", Offset = "0x16AD3B8", VA = "0x16AD3B8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x16AD434", Offset = "0x16AD434", VA = "0x16AD434", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x16AD4F4", Offset = "0x16AD4F4", VA = "0x16AD4F4")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D6F94", Offset = "0x6D6F94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D6F94", Offset = "0x6D6F94")]
		public Transform target;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D6FF4", Offset = "0x6D6FF4")]
		public float weight;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D700C", Offset = "0x6D700C")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7044", Offset = "0x6D7044")]
		public float weightSmoothTime;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D707C", Offset = "0x6D707C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D707C", Offset = "0x6D707C")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D70DC", Offset = "0x6D70DC")]
		public float maxRadiansDelta;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7114", Offset = "0x6D7114")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D714C", Offset = "0x6D714C")]
		public float slerpSpeed;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7184", Offset = "0x6D7184")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D71BC", Offset = "0x6D71BC")]
		public float minDistance;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D71F4", Offset = "0x6D71F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D71F4", Offset = "0x6D71F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D71F4", Offset = "0x6D71F4")]
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
			[Address(RVA = "0x16B727C", Offset = "0x16B727C", VA = "0x16B727C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x16B7208", Offset = "0x16B7208", VA = "0x16B7208")]
		private void Start()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x16B730C", Offset = "0x16B730C", VA = "0x16B730C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x16B7828", Offset = "0x16B7828", VA = "0x16B7828")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x16B7914", Offset = "0x16B7914", VA = "0x16B7914")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x16B7B0C", Offset = "0x16B7B0C", VA = "0x16B7B0C")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D72E0", Offset = "0x6D72E0")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7318", Offset = "0x6D7318")]
			public float spring;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7350", Offset = "0x6D7350")]
			public bool x;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7388", Offset = "0x6D7388")]
			public bool y;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D73C0", Offset = "0x6D73C0")]
			public bool z;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D73F8", Offset = "0x6D73F8")]
			public float minX;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7430", Offset = "0x6D7430")]
			public float maxX;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7468", Offset = "0x6D7468")]
			public float minY;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D74A0", Offset = "0x6D74A0")]
			public float maxY;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D74D8", Offset = "0x6D74D8")]
			public float minZ;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7510", Offset = "0x6D7510")]
			public float maxZ;

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x188CA90", Offset = "0x188CA90", VA = "0x188CA90")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x188CBE8", Offset = "0x188CBE8", VA = "0x188CBE8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x188CC60", Offset = "0x188CC60", VA = "0x188CC60")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x188CCB8", Offset = "0x188CCB8", VA = "0x188CCB8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05B4", Offset = "0x6D05B4")]
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
				[Address(RVA = "0x188CA40", Offset = "0x188CA40", VA = "0x188CA40", Slot = "4")]
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
				[Address(RVA = "0x188CA88", Offset = "0x188CA88", VA = "0x188CA88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x188C8C0", Offset = "0x188C8C0", VA = "0x188C8C0")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600062C")]
			[Address(RVA = "0x188C8EC", Offset = "0x188C8EC", VA = "0x188C8EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x188C8F0", Offset = "0x188C8F0", VA = "0x188C8F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x188CA48", Offset = "0x188CA48", VA = "0x188CA48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7270", Offset = "0x6D7270")]
		public float weight;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D72A8", Offset = "0x6D72A8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000A9")]
		protected float deltaTime
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x1519398", Offset = "0x1519398", VA = "0x1519398")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000620")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1518188", Offset = "0x1518188", VA = "0x1518188", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x15193C4", Offset = "0x15193C4", VA = "0x15193C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB554", Offset = "0x6DB554")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1519430", Offset = "0x1519430", VA = "0x1519430")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x151950C", Offset = "0x151950C", VA = "0x151950C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x15184F8", Offset = "0x15184F8", VA = "0x15184F8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1518618", Offset = "0x1518618", VA = "0x1518618")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05C4", Offset = "0x6D05C4")]
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
				[Address(RVA = "0x188CE40", Offset = "0x188CE40", VA = "0x188CE40", Slot = "4")]
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
				[Address(RVA = "0x188CE88", Offset = "0x188CE88", VA = "0x188CE88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000638")]
			[Address(RVA = "0x188CCC0", Offset = "0x188CCC0", VA = "0x188CCC0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x188CCEC", Offset = "0x188CCEC", VA = "0x188CCEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x188CCF0", Offset = "0x188CCF0", VA = "0x188CCF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x188CE48", Offset = "0x188CE48", VA = "0x188CE48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7548", Offset = "0x6D7548")]
		public float weight;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7580", Offset = "0x6D7580")]
		public VRIK ik;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x15195CC", Offset = "0x15195CC", VA = "0x15195CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000632")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x15195F8", Offset = "0x15195F8", VA = "0x15195F8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1519624", Offset = "0x1519624", VA = "0x1519624")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB604", Offset = "0x6DB604")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1519690", Offset = "0x1519690", VA = "0x1519690")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x151976C", Offset = "0x151976C", VA = "0x151976C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1519878", Offset = "0x1519878", VA = "0x1519878")]
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
			[Address(RVA = "0x188CE90", Offset = "0x188CE90", VA = "0x188CE90")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x188D0AC", Offset = "0x188D0AC", VA = "0x188D0AC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1519888", Offset = "0x1519888", VA = "0x1519888")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x151994C", Offset = "0x151994C", VA = "0x151994C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1519A08", Offset = "0x1519A08", VA = "0x1519A08")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7794", Offset = "0x6D7794")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D77CC", Offset = "0x6D77CC")]
				public float weight;

				[Token(Token = "0x6000649")]
				[Address(RVA = "0x1890F80", Offset = "0x1890F80", VA = "0x1890F80")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D75F0", Offset = "0x6D75F0")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7628", Offset = "0x6D7628")]
			public Transform raycastTo;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7660", Offset = "0x6D7660")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D7660", Offset = "0x6D7660")]
			public float raycastRadius;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D76B4", Offset = "0x6D76B4")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D76EC", Offset = "0x6D76EC")]
			public float smoothTimeIn;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7724", Offset = "0x6D7724")]
			public float smoothTimeOut;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D775C", Offset = "0x6D775C")]
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
			[Address(RVA = "0x188D0B4", Offset = "0x188D0B4", VA = "0x188D0B4")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x188D1F8", Offset = "0x188D1F8", VA = "0x188D1F8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0x188D2F0", Offset = "0x188D2F0", VA = "0x188D2F0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x188D4C0", Offset = "0x188D4C0", VA = "0x188D4C0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D75B8", Offset = "0x6D75B8")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x151A3B0", Offset = "0x151A3B0", VA = "0x151A3B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x151A438", Offset = "0x151A438", VA = "0x151A438")]
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
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7B58", Offset = "0x6D7B58")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7B90", Offset = "0x6D7B90")]
				public float weight;

				[Token(Token = "0x6000659")]
				[Address(RVA = "0x1890F88", Offset = "0x1890F88", VA = "0x1890F88")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7A5C", Offset = "0x6D7A5C")]
			public Vector3 offset;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7A94", Offset = "0x6D7A94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D7A94", Offset = "0x6D7A94")]
			public float additivity;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7AE8", Offset = "0x6D7AE8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7B20", Offset = "0x6D7B20")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x188DEB4", Offset = "0x188DEB4", VA = "0x188DEB4")]
			public void Start()
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x188DF04", Offset = "0x188DF04", VA = "0x188DF04")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x188E0C8", Offset = "0x188E0C8", VA = "0x188E0C8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7804", Offset = "0x6D7804")]
		public AimIK aimIK;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D783C", Offset = "0x6D783C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7874", Offset = "0x6D7874")]
		public Handedness handedness;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D78AC", Offset = "0x6D78AC")]
		public bool twoHanded;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D78E4", Offset = "0x6D78E4")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D791C", Offset = "0x6D791C")]
		public float magnitudeRandom;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7954", Offset = "0x6D7954")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D798C", Offset = "0x6D798C")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D79C4", Offset = "0x6D79C4")]
		public float blendTime;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6D79FC", Offset = "0x6D79FC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D79FC", Offset = "0x6D79FC")]
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
			[Address(RVA = "0x151D3B4", Offset = "0x151D3B4", VA = "0x151D3B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x151DE2C", Offset = "0x151DE2C", VA = "0x151DE2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x151DE6C", Offset = "0x151DE6C", VA = "0x151DE6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x151DDEC", Offset = "0x151DDEC", VA = "0x151DDEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x151DE0C", Offset = "0x151DE0C", VA = "0x151DE0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x151D3E4", Offset = "0x151D3E4", VA = "0x151D3E4")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x151D410", Offset = "0x151D410", VA = "0x151D410")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x151D558", Offset = "0x151D558", VA = "0x151D558", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x151DEAC", Offset = "0x151DEAC", VA = "0x151DEAC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x151DF60", Offset = "0x151DF60", VA = "0x151DF60")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x151DF9C", Offset = "0x151DF9C", VA = "0x151DF9C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x151E154", Offset = "0x151E154", VA = "0x151E154")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7BC8", Offset = "0x6D7BC8")]
		public float weight;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7C00", Offset = "0x6D7C00")]
		public float offset;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1520D5C", Offset = "0x1520D5C", VA = "0x1520D5C")]
		private void Start()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1520E44", Offset = "0x1520E44", VA = "0x1520E44")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1520F2C", Offset = "0x1520F2C", VA = "0x1520F2C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1521280", Offset = "0x1521280", VA = "0x1521280")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x15212B8", Offset = "0x15212B8", VA = "0x15212B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x15213C4", Offset = "0x15213C4", VA = "0x15213C4")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7C38", Offset = "0x6D7C38")]
			public float scaleMlp;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7C70", Offset = "0x6D7C70")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7CA8", Offset = "0x6D7CA8")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7CE0", Offset = "0x6D7CE0")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7D18", Offset = "0x6D7D18")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7D50", Offset = "0x6D7D50")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7D88", Offset = "0x6D7D88")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7DC0", Offset = "0x6D7DC0")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7DF8", Offset = "0x6D7DF8")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7E30", Offset = "0x6D7E30")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6D7E30", Offset = "0x6D7E30")]
			public Vector3 headOffset;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7E80", Offset = "0x6D7E80")]
			public Vector3 handOffset;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7EB8", Offset = "0x6D7EB8")]
			public float footForwardOffset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7EF0", Offset = "0x6D7EF0")]
			public float footInwardOffset;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7F28", Offset = "0x6D7F28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D7F28", Offset = "0x6D7F28")]
			public float footHeadingOffset;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D7F84", Offset = "0x6D7F84")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D7F9C", Offset = "0x6D7F9C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x18906F4", Offset = "0x18906F4", VA = "0x18906F4")]
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
				[Address(RVA = "0x1890F90", Offset = "0x1890F90", VA = "0x1890F90")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0x1891050", Offset = "0x1891050", VA = "0x1891050")]
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
			[Address(RVA = "0x18906EC", Offset = "0x18906EC", VA = "0x18906EC")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1527540", Offset = "0x1527540", VA = "0x1527540")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x152585C", Offset = "0x152585C", VA = "0x152585C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x152769C", Offset = "0x152769C", VA = "0x152769C")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1526A60", Offset = "0x1526A60", VA = "0x1526A60")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1527E88", Offset = "0x1527E88", VA = "0x1527E88")]
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
		[Address(RVA = "0x152827C", Offset = "0x152827C", VA = "0x152827C")]
		private void Start()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x15282D0", Offset = "0x15282D0", VA = "0x15282D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1528304", Offset = "0x1528304", VA = "0x1528304")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1528440", Offset = "0x1528440", VA = "0x1528440")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D7FB4", Offset = "0x6D7FB4")]
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
			[Address(RVA = "0x1528B30", Offset = "0x1528B30", VA = "0x1528B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB6B4", Offset = "0x6DB6B4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1528B3C", Offset = "0x1528B3C", VA = "0x1528B3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB6C4", Offset = "0x6DB6C4")]
			private set
			{
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1528B48", Offset = "0x1528B48", VA = "0x1528B48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1527C90", Offset = "0x1527C90", VA = "0x1527C90")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x15280F8", Offset = "0x15280F8", VA = "0x15280F8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1528C34", Offset = "0x1528C34", VA = "0x1528C34")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1529050", Offset = "0x1529050", VA = "0x1529050")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x152915C", Offset = "0x152915C", VA = "0x152915C")]
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
			[Address(RVA = "0x135C740", Offset = "0x135C740", VA = "0x135C740")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x135C8A0", Offset = "0x135C8A0", VA = "0x135C8A0")]
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
		[Address(RVA = "0xFC41B8", Offset = "0xFC41B8", VA = "0xFC41B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xFC420C", Offset = "0xFC420C", VA = "0xFC420C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xFC4288", Offset = "0xFC4288", VA = "0xFC4288")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xFC4360", Offset = "0xFC4360", VA = "0xFC4360")]
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
		[Address(RVA = "0x1665F9C", Offset = "0x1665F9C", VA = "0x1665F9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1666020", Offset = "0x1666020", VA = "0x1666020")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D7FFC", Offset = "0x6D7FFC")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1666E54", Offset = "0x1666E54", VA = "0x1666E54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1666ECC", Offset = "0x1666ECC", VA = "0x1666ECC")]
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
		[Address(RVA = "0x1520B5C", Offset = "0x1520B5C", VA = "0x1520B5C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1520BA0", Offset = "0x1520BA0", VA = "0x1520BA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1520D54", Offset = "0x1520D54", VA = "0x1520D54")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8034", Offset = "0x6D8034")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D806C", Offset = "0x6D806C")]
		public AimIK aim;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D80A4", Offset = "0x6D80A4")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D80DC", Offset = "0x6D80DC")]
		public Animator animator;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8114", Offset = "0x6D8114")]
		public float crossfadeTime;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D814C", Offset = "0x6D814C")]
		public float minAimDistance;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x15213D8", Offset = "0x15213D8", VA = "0x15213D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x152141C", Offset = "0x152141C", VA = "0x152141C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1521584", Offset = "0x1521584", VA = "0x1521584")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1521714", Offset = "0x1521714", VA = "0x1521714")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1521850", Offset = "0x1521850", VA = "0x1521850")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x15218CC", Offset = "0x15218CC", VA = "0x15218CC")]
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
		[Address(RVA = "0x1522854", Offset = "0x1522854", VA = "0x1522854")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x15229C4", Offset = "0x15229C4", VA = "0x15229C4")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1522B58", Offset = "0x1522B58", VA = "0x1522B58")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D8184", Offset = "0x6D8184")]
		public Animator animator;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D81BC", Offset = "0x6D81BC")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D81F4", Offset = "0x6D81F4")]
		public float lookAtWeight;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D820C", Offset = "0x6D820C")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8224", Offset = "0x6D8224")]
		public float lookAtHeadWeight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D823C", Offset = "0x6D823C")]
		public float lookAtEyesWeight;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8254", Offset = "0x6D8254")]
		public float lookAtClampWeight;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D826C", Offset = "0x6D826C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8284", Offset = "0x6D8284")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D829C", Offset = "0x6D829C")]
		public Transform footTargetBiped;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D82D4", Offset = "0x6D82D4")]
		public float footPositionWeight;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D82EC", Offset = "0x6D82EC")]
		public float footRotationWeight;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x6D8304", Offset = "0x6D8304")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D833C", Offset = "0x6D833C")]
		public float handPositionWeight;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8354", Offset = "0x6D8354")]
		public float handRotationWeight;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x166D4A4", Offset = "0x166D4A4", VA = "0x166D4A4")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x166D8AC", Offset = "0x166D8AC", VA = "0x166D8AC")]
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
		[Address(RVA = "0x16B7D08", Offset = "0x16B7D08", VA = "0x16B7D08")]
		private void Update()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x16B8514", Offset = "0x16B8514", VA = "0x16B8514")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x16B82C4", Offset = "0x16B82C4", VA = "0x16B82C4")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x16B8610", Offset = "0x16B8610", VA = "0x16B8610")]
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
			[Address(RVA = "0x16B863C", Offset = "0x16B863C", VA = "0x16B863C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x16B86C0", Offset = "0x16B86C0", VA = "0x16B86C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x16B88E4", Offset = "0x16B88E4", VA = "0x16B88E4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D05D4", Offset = "0x6D05D4")]
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
				[Address(RVA = "0x188C608", Offset = "0x188C608", VA = "0x188C608", Slot = "4")]
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
				[Address(RVA = "0x188C650", Offset = "0x188C650", VA = "0x188C650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x188C318", Offset = "0x188C318", VA = "0x188C318")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x188C344", Offset = "0x188C344", VA = "0x188C344", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x188C348", Offset = "0x188C348", VA = "0x188C348", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x188C610", Offset = "0x188C610", VA = "0x188C610", Slot = "8")]
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
			[Address(RVA = "0x16B88F8", Offset = "0x16B88F8", VA = "0x16B88F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B7")]
		public Vector3 position
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x16B85DC", Offset = "0x16B85DC", VA = "0x16B85DC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x16B890C", Offset = "0x16B890C", VA = "0x16B890C")]
			set
			{
			}
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x16B895C", Offset = "0x16B895C", VA = "0x16B895C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x16B8B50", Offset = "0x16B8B50", VA = "0x16B8B50")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x16B8CEC", Offset = "0x16B8CEC", VA = "0x16B8CEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x16B8F14", Offset = "0x16B8F14", VA = "0x16B8F14")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x16B91B8", Offset = "0x16B91B8", VA = "0x16B91B8")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x16B9330", Offset = "0x16B9330", VA = "0x16B9330")]
		private void Update()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x16B8E6C", Offset = "0x16B8E6C", VA = "0x16B8E6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB6D4", Offset = "0x6DB6D4")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x16B952C", Offset = "0x16B952C", VA = "0x16B952C")]
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
		[Address(RVA = "0x1517D80", Offset = "0x1517D80", VA = "0x1517D80")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1517E40", Offset = "0x1517E40", VA = "0x1517E40")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1518098", Offset = "0x1518098", VA = "0x1518098")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D842C", Offset = "0x6D842C")]
			public int animationLayer;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8464", Offset = "0x6D8464")]
			public string animationState;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D849C", Offset = "0x6D849C")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D84D4", Offset = "0x6D84D4")]
			public Transform warpFrom;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D850C", Offset = "0x6D850C")]
			public Transform warpTo;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8544", Offset = "0x6D8544")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D836C", Offset = "0x6D836C")]
		public Animator animator;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D83A4", Offset = "0x6D83A4")]
		public EffectorMode effectorMode;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D83DC", Offset = "0x6D83DC")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x6D83DC", Offset = "0x6D83DC")]
		public Warp[] warps;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1667054", Offset = "0x1667054", VA = "0x1667054", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1667080", Offset = "0x1667080", VA = "0x1667080")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x16672C0", Offset = "0x16672C0", VA = "0x16672C0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1667584", Offset = "0x1667584", VA = "0x1667584")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1667624", Offset = "0x1667624", VA = "0x1667624")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D05E4", Offset = "0x6D05E4")]
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
		[Address(RVA = "0x166762C", Offset = "0x166762C", VA = "0x166762C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1667680", Offset = "0x1667680", VA = "0x1667680")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x166781C", Offset = "0x166781C", VA = "0x166781C", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1667A24", Offset = "0x1667A24", VA = "0x1667A24")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0644", Offset = "0x6D0644")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0644", Offset = "0x6D0644")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D857C", Offset = "0x6D857C")]
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
		[Address(RVA = "0x1667A38", Offset = "0x1667A38", VA = "0x1667A38", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1667BC4", Offset = "0x1667BC4", VA = "0x1667BC4", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1667C40", Offset = "0x1667C40", VA = "0x1667C40")]
		private void Read()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1667D34", Offset = "0x1667D34", VA = "0x1667D34")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1667D7C", Offset = "0x1667D7C", VA = "0x1667D7C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1668168", Offset = "0x1668168", VA = "0x1668168")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1667FF0", Offset = "0x1667FF0", VA = "0x1667FF0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x16683C4", Offset = "0x16683C4", VA = "0x16683C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x16684D0", Offset = "0x16684D0", VA = "0x16684D0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D06D8", Offset = "0x6D06D8")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1675F74", Offset = "0x1675F74", VA = "0x1675F74", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1675FD0", Offset = "0x1675FD0", VA = "0x1675FD0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x167620C", Offset = "0x167620C", VA = "0x167620C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x1676300", Offset = "0x1676300", VA = "0x1676300")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0738", Offset = "0x6D0738")]
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
			[Address(RVA = "0x1676D24", Offset = "0x1676D24", VA = "0x1676D24")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BB")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1676DA8", Offset = "0x1676DA8", VA = "0x1676DA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1676B2C", Offset = "0x1676B2C", VA = "0x1676B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1676B98", Offset = "0x1676B98", VA = "0x1676B98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1676E2C", Offset = "0x1676E2C", VA = "0x1676E2C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8594", Offset = "0x6D8594")]
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
		[Address(RVA = "0xFBD36C", Offset = "0xFBD36C", VA = "0xFBD36C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xFBD7CC", Offset = "0xFBD7CC", VA = "0xFBD7CC")]
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
		[Address(RVA = "0xFBD7D4", Offset = "0xFBD7D4", VA = "0xFBD7D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xFBD87C", Offset = "0xFBD87C", VA = "0xFBD87C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xFBDC00", Offset = "0xFBDC00", VA = "0xFBDC00")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xFBDCAC", Offset = "0xFBDCAC", VA = "0xFBDCAC")]
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
			[Address(RVA = "0x135C228", Offset = "0x135C228", VA = "0x135C228")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x135C2AC", Offset = "0x135C2AC", VA = "0x135C2AC")]
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
		[Address(RVA = "0xFC1578", Offset = "0xFC1578", VA = "0xFC1578")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xFC16D0", Offset = "0xFC16D0", VA = "0xFC16D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xFC1774", Offset = "0xFC1774", VA = "0xFC1774")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xFC1778", Offset = "0xFC1778", VA = "0xFC1778")]
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
		[Address(RVA = "0xFC1788", Offset = "0xFC1788", VA = "0xFC1788")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xFC17FC", Offset = "0xFC17FC", VA = "0xFC17FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xFC18D0", Offset = "0xFC18D0", VA = "0xFC18D0")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D85AC", Offset = "0x6D85AC")]
		public Transform target;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D85E4", Offset = "0x6D85E4")]
		public Transform pin;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D861C", Offset = "0x6D861C")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8654", Offset = "0x6D8654")]
		public AimIK aim;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D868C", Offset = "0x6D868C")]
		public float weight;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D86C4", Offset = "0x6D86C4")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D86FC", Offset = "0x6D86FC")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xFC18D8", Offset = "0xFC18D8", VA = "0xFC18D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFC192C", Offset = "0xFC192C", VA = "0xFC192C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xFC1AD0", Offset = "0xFC1AD0", VA = "0xFC1AD0")]
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
		[Address(RVA = "0xFC3B74", Offset = "0xFC3B74", VA = "0xFC3B74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xFC3C3C", Offset = "0xFC3C3C", VA = "0xFC3C3C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFC3CCC", Offset = "0xFC3CCC", VA = "0xFC3CCC")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFC40A4", Offset = "0xFC40A4", VA = "0xFC40A4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFC41B0", Offset = "0xFC41B0", VA = "0xFC41B0")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8734", Offset = "0x6D8734")]
		public float aimWeight;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D874C", Offset = "0x6D874C")]
		public float sightWeight;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8764", Offset = "0x6D8764")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8780", Offset = "0x6D8780")]
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
		[Address(RVA = "0xFC4368", Offset = "0xFC4368", VA = "0xFC4368")]
		private void Start()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xFC44DC", Offset = "0xFC44DC", VA = "0xFC44DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xFC44E8", Offset = "0xFC44E8", VA = "0xFC44E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFC4768", Offset = "0xFC4768", VA = "0xFC4768")]
		private void Aiming()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xFC4914", Offset = "0xFC4914", VA = "0xFC4914")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xFC45B0", Offset = "0xFC45B0", VA = "0xFC45B0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xFC5208", Offset = "0xFC5208", VA = "0xFC5208")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0798", Offset = "0x6D0798")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0798", Offset = "0x6D0798")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8798", Offset = "0x6D8798")]
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
		[Address(RVA = "0x1679BE8", Offset = "0x1679BE8", VA = "0x1679BE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1679C60", Offset = "0x1679C60", VA = "0x1679C60")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1679D4C", Offset = "0x1679D4C", VA = "0x1679D4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1679E04", Offset = "0x1679E04", VA = "0x1679E04")]
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
		[Address(RVA = "0x1684DB8", Offset = "0x1684DB8", VA = "0x1684DB8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1684F10", Offset = "0x1684F10", VA = "0x1684F10")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x16850F4", Offset = "0x16850F4", VA = "0x16850F4")]
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
		[Address(RVA = "0x1685790", Offset = "0x1685790", VA = "0x1685790")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x16858D8", Offset = "0x16858D8", VA = "0x16858D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1685C14", Offset = "0x1685C14", VA = "0x1685C14")]
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
		[Address(RVA = "0x16AD5D4", Offset = "0x16AD5D4", VA = "0x16AD5D4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x16AD820", Offset = "0x16AD820", VA = "0x16AD820")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x16AD92C", Offset = "0x16AD92C", VA = "0x16AD92C")]
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
		[Address(RVA = "0x16AD934", Offset = "0x16AD934", VA = "0x16AD934")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x16AE148", Offset = "0x16AE148", VA = "0x16AE148")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D082C", Offset = "0x6D082C")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D87B0", Offset = "0x6D87B0")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D87E8", Offset = "0x6D87E8")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x16B58B8", Offset = "0x16B58B8", VA = "0x16B58B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x16B590C", Offset = "0x16B590C", VA = "0x16B590C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x16B5C44", Offset = "0x16B5C44", VA = "0x16B5C44")]
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
				[Address(RVA = "0x188C2AC", Offset = "0x188C2AC", VA = "0x188C2AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x188BB60", Offset = "0x188BB60", VA = "0x188BB60")]
			public void Initiate()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x188BB80", Offset = "0x188BB80", VA = "0x188BB80")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x188C118", Offset = "0x188C118", VA = "0x188C118")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x188C304", Offset = "0x188C304", VA = "0x188C304")]
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
		[Address(RVA = "0x16B6804", Offset = "0x16B6804", VA = "0x16B6804")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x16B6840", Offset = "0x16B6840", VA = "0x16B6840")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x16B68A8", Offset = "0x16B68A8", VA = "0x16B68A8")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8900", Offset = "0x6D8900")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8938", Offset = "0x6D8938")]
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
			[Address(RVA = "0x188C658", Offset = "0x188C658", VA = "0x188C658")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x188C72C", Offset = "0x188C72C", VA = "0x188C72C")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x188C768", Offset = "0x188C768", VA = "0x188C768")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x188C800", Offset = "0x188C800", VA = "0x188C800")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x188C874", Offset = "0x188C874", VA = "0x188C874")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8820", Offset = "0x6D8820")]
		public Mode mode;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8858", Offset = "0x6D8858")]
		public Absorber[] absorbers;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8890", Offset = "0x6D8890")]
		public AnimationCurve falloff;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D88C8", Offset = "0x6D88C8")]
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
		[Address(RVA = "0x15180A0", Offset = "0x15180A0", VA = "0x15180A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x15181B4", Offset = "0x15181B4", VA = "0x15181B4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1518244", Offset = "0x1518244", VA = "0x1518244", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1518358", Offset = "0x1518358", VA = "0x1518358")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x15183E4", Offset = "0x15183E4", VA = "0x15183E4", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1518604", Offset = "0x1518604", VA = "0x1518604")]
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
		[Address(RVA = "0x1518628", Offset = "0x1518628", VA = "0x1518628")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x151869C", Offset = "0x151869C", VA = "0x151869C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1518778", Offset = "0x1518778", VA = "0x1518778")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1518838", Offset = "0x1518838", VA = "0x1518838")]
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
			[Address(RVA = "0x188C8B0", Offset = "0x188C8B0", VA = "0x188C8B0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x15190F0", Offset = "0x15190F0", VA = "0x15190F0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x15191FC", Offset = "0x15191FC", VA = "0x15191FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1519388", Offset = "0x1519388", VA = "0x1519388")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D088C", Offset = "0x6D088C")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8980", Offset = "0x6D8980")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8980", Offset = "0x6D8980")]
		public float weight;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D89D4", Offset = "0x6D89D4")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8A0C", Offset = "0x6D8A0C")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8A58", Offset = "0x6D8A58")]
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
		[Address(RVA = "0x1519A64", Offset = "0x1519A64", VA = "0x1519A64")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1519D28", Offset = "0x1519D28", VA = "0x1519D28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x151A370", Offset = "0x151A370", VA = "0x151A370")]
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
			[Address(RVA = "0x151A71C", Offset = "0x151A71C", VA = "0x151A71C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x151A448", Offset = "0x151A448", VA = "0x151A448")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000712")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x151A73C", Offset = "0x151A73C", VA = "0x151A73C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x151A8C4", Offset = "0x151A8C4", VA = "0x151A8C4")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x151AA48", Offset = "0x151AA48", VA = "0x151AA48")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x151AB24", Offset = "0x151AB24", VA = "0x151AB24")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x151AC58", Offset = "0x151AC58", VA = "0x151AC58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x151ADBC", Offset = "0x151ADBC", VA = "0x151ADBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x151AF88", Offset = "0x151AF88", VA = "0x151AF88")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x151AF9C", Offset = "0x151AF9C", VA = "0x151AF9C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x151B200", Offset = "0x151B200", VA = "0x151B200")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x151B214", Offset = "0x151B214", VA = "0x151B214", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x151B348", Offset = "0x151B348", VA = "0x151B348")]
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
		[Address(RVA = "0x151D1B8", Offset = "0x151D1B8", VA = "0x151D1B8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x151D298", Offset = "0x151D298", VA = "0x151D298")]
		private void Update()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x151D3AC", Offset = "0x151D3AC", VA = "0x151D3AC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D08EC", Offset = "0x6D08EC")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x151E1C4", Offset = "0x151E1C4", VA = "0x151E1C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x151E218", Offset = "0x151E218", VA = "0x151E218")]
		private void Update()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x151E270", Offset = "0x151E270", VA = "0x151E270")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x151E350", Offset = "0x151E350", VA = "0x151E350")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D094C", Offset = "0x6D094C")]
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
				[Address(RVA = "0x188E2B8", Offset = "0x188E2B8", VA = "0x188E2B8", Slot = "4")]
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
				[Address(RVA = "0x188E300", Offset = "0x188E300", VA = "0x188E300", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x188E0DC", Offset = "0x188E0DC", VA = "0x188E0DC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x188E108", Offset = "0x188E108", VA = "0x188E108", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x188E10C", Offset = "0x188E10C", VA = "0x188E10C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x188E2C0", Offset = "0x188E2C0", VA = "0x188E2C0", Slot = "8")]
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
		[Address(RVA = "0x151E360", Offset = "0x151E360", VA = "0x151E360")]
		private void Start()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x151E414", Offset = "0x151E414", VA = "0x151E414")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x151E45C", Offset = "0x151E45C", VA = "0x151E45C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB784", Offset = "0x6DB784")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x151E4D8", Offset = "0x151E4D8", VA = "0x151E4D8")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000102")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D095C", Offset = "0x6D095C")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09BC", Offset = "0x6D09BC")]
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
				[Address(RVA = "0x188E824", Offset = "0x188E824", VA = "0x188E824", Slot = "4")]
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
				[Address(RVA = "0x188E86C", Offset = "0x188E86C", VA = "0x188E86C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x188E6CC", Offset = "0x188E6CC", VA = "0x188E6CC")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x188E6F8", Offset = "0x188E6F8", VA = "0x188E6F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x188E6FC", Offset = "0x188E6FC", VA = "0x188E6FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000737")]
			[Address(RVA = "0x188E82C", Offset = "0x188E82C", VA = "0x188E82C", Slot = "8")]
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
		[Address(RVA = "0x15220C0", Offset = "0x15220C0", VA = "0x15220C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x152216C", Offset = "0x152216C", VA = "0x152216C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB834", Offset = "0x6DB834")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x15221D8", Offset = "0x15221D8", VA = "0x15221D8")]
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
			[Address(RVA = "0x188E874", Offset = "0x188E874", VA = "0x188E874")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x188EB0C", Offset = "0x188EB0C", VA = "0x188EB0C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x188EBF4", Offset = "0x188EBF4", VA = "0x188EBF4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x188F088", Offset = "0x188F088", VA = "0x188F088")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x188F17C", Offset = "0x188F17C", VA = "0x188F17C")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x188F214", Offset = "0x188F214", VA = "0x188F214")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x188F2A8", Offset = "0x188F2A8", VA = "0x188F2A8")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x188F33C", Offset = "0x188F33C", VA = "0x188F33C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x188F4A8", Offset = "0x188F4A8", VA = "0x188F4A8")]
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
		[Address(RVA = "0x1522B88", Offset = "0x1522B88", VA = "0x1522B88")]
		private void Start()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1522C04", Offset = "0x1522C04", VA = "0x1522C04")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1522C74", Offset = "0x1522C74", VA = "0x1522C74")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1522D3C", Offset = "0x1522D3C", VA = "0x1522D3C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8AA4", Offset = "0x6D8AA4")]
		public Transform to;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8ADC", Offset = "0x6D8ADC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8ADC", Offset = "0x6D8ADC")]
		public float transferMotion;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1522D44", Offset = "0x1522D44", VA = "0x1522D44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1522D80", Offset = "0x1522D80", VA = "0x1522D80")]
		private void Update()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1522E34", Offset = "0x1522E34", VA = "0x1522E34")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8B30", Offset = "0x6D8B30")]
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
		[Address(RVA = "0x1523BEC", Offset = "0x1523BEC", VA = "0x1523BEC")]
		private void Start()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1523DDC", Offset = "0x1523DDC", VA = "0x1523DDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1523FCC", Offset = "0x1523FCC", VA = "0x1523FCC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1524098", Offset = "0x1524098", VA = "0x1524098")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x15241A4", Offset = "0x15241A4", VA = "0x15241A4")]
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
		[Address(RVA = "0x1524434", Offset = "0x1524434", VA = "0x1524434", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x15247C0", Offset = "0x15247C0", VA = "0x15247C0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1524A2C", Offset = "0x1524A2C", VA = "0x1524A2C")]
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
		[Address(RVA = "0x167DF38", Offset = "0x167DF38", VA = "0x167DF38")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x167E260", Offset = "0x167E260", VA = "0x167E260")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x167E2E0", Offset = "0x167E2E0", VA = "0x167E2E0")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D09CC", Offset = "0x6D09CC")]
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
				[Address(RVA = "0x188D614", Offset = "0x188D614", VA = "0x188D614", Slot = "4")]
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
				[Address(RVA = "0x188D65C", Offset = "0x188D65C", VA = "0x188D65C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x188D4D4", Offset = "0x188D4D4", VA = "0x188D4D4")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x188D500", Offset = "0x188D500", VA = "0x188D500", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x188D504", Offset = "0x188D504", VA = "0x188D504", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x188D61C", Offset = "0x188D61C", VA = "0x188D61C", Slot = "8")]
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
		[Address(RVA = "0x151B35C", Offset = "0x151B35C", VA = "0x151B35C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x151B488", Offset = "0x151B488", VA = "0x151B488")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x151B41C", Offset = "0x151B41C", VA = "0x151B41C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB8E4", Offset = "0x6DB8E4")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x151B60C", Offset = "0x151B60C", VA = "0x151B60C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x151B6F8", Offset = "0x151B6F8", VA = "0x151B6F8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x151B7E0", Offset = "0x151B7E0", VA = "0x151B7E0")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8B68", Offset = "0x6D8B68")]
		public float weight;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x166C244", Offset = "0x166C244", VA = "0x166C244")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x166C2B8", Offset = "0x166C2B8", VA = "0x166C2B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x166C370", Offset = "0x166C370", VA = "0x166C370")]
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
			[Address(RVA = "0x188F4DC", Offset = "0x188F4DC", VA = "0x188F4DC")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x188F608", Offset = "0x188F608", VA = "0x188F608")]
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
		[Address(RVA = "0x152321C", Offset = "0x152321C", VA = "0x152321C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x1523298", Offset = "0x1523298", VA = "0x1523298")]
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
		[Address(RVA = "0x1685444", Offset = "0x1685444", VA = "0x1685444")]
		private void Update()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x168559C", Offset = "0x168559C", VA = "0x168559C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1685780", Offset = "0x1685780", VA = "0x1685780")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8B80", Offset = "0x6D8B80")]
		public VRIK ik;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8BB8", Offset = "0x6D8BB8")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8BF0", Offset = "0x6D8BF0")]
		public Transform headTracker;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8C28", Offset = "0x6D8C28")]
		public Transform bodyTracker;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8C60", Offset = "0x6D8C60")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8C98", Offset = "0x6D8C98")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8CD0", Offset = "0x6D8CD0")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8D08", Offset = "0x6D8D08")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8D40", Offset = "0x6D8D40")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x15256F8", Offset = "0x15256F8", VA = "0x15256F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1527638", Offset = "0x1527638", VA = "0x1527638")]
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
		[Address(RVA = "0x1528458", Offset = "0x1528458", VA = "0x1528458")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x15284B4", Offset = "0x15284B4", VA = "0x15284B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x152863C", Offset = "0x152863C", VA = "0x152863C")]
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
		[Address(RVA = "0x1528670", Offset = "0x1528670", VA = "0x1528670")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x1528AF4", Offset = "0x1528AF4", VA = "0x1528AF4")]
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
			[Address(RVA = "0x1675274", Offset = "0x1675274", VA = "0x1675274", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1675250", Offset = "0x1675250", VA = "0x1675250", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x167527C", Offset = "0x167527C", VA = "0x167527C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x16752E0", Offset = "0x16752E0", VA = "0x16752E0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1675478", Offset = "0x1675478", VA = "0x1675478", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x167569C", Offset = "0x167569C", VA = "0x167569C", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1675488", Offset = "0x1675488", VA = "0x1675488")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x16756AC", Offset = "0x16756AC", VA = "0x16756AC")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D09DC", Offset = "0x6D09DC")]
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
		[Address(RVA = "0x16756C4", Offset = "0x16756C4", VA = "0x16756C4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1675720", Offset = "0x1675720", VA = "0x1675720", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x16757BC", Offset = "0x16757BC", VA = "0x16757BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x16758D4", Offset = "0x16758D4", VA = "0x16758D4")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000115")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0A3C", Offset = "0x6D0A3C")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6D8DA8", Offset = "0x6D8DA8")]
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
			[Address(RVA = "0x1675988", Offset = "0x1675988", VA = "0x1675988", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x16758EC", Offset = "0x16758EC", VA = "0x16758EC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x167596C", Offset = "0x167596C", VA = "0x167596C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1675A80", Offset = "0x1675A80", VA = "0x1675A80", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1675E48", Offset = "0x1675E48", VA = "0x1675E48")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1675F50", Offset = "0x1675F50", VA = "0x1675F50")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0A9C", Offset = "0x6D0A9C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0A9C", Offset = "0x6D0A9C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8DEC", Offset = "0x6D8DEC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8DEC", Offset = "0x6D8DEC")]
		public Transform gravityTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8E4C", Offset = "0x6D8E4C")]
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
		[Address(RVA = "0x1676324", Offset = "0x1676324", VA = "0x1676324")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1676454", Offset = "0x1676454", VA = "0x1676454", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x167660C", Offset = "0x167660C", VA = "0x167660C", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x16767BC", Offset = "0x16767BC", VA = "0x16767BC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x1676820", Offset = "0x1676820", VA = "0x1676820")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1676940", Offset = "0x1676940", VA = "0x1676940")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1676A64", Offset = "0x1676A64", VA = "0x1676A64")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1676A88", Offset = "0x1676A88", VA = "0x1676A88")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1676AAC", Offset = "0x1676AAC", VA = "0x1676AAC")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1676B0C", Offset = "0x1676B0C", VA = "0x1676B0C")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0B30", Offset = "0x6D0B30")]
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
				[Address(RVA = "0x1358F20", Offset = "0x1358F20", VA = "0x1358F20", Slot = "4")]
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
				[Address(RVA = "0x1358F68", Offset = "0x1358F68", VA = "0x1358F68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1358DFC", Offset = "0x1358DFC", VA = "0x1358DFC")]
			[DebuggerHidden]
			public <JumpSmooth>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1358E28", Offset = "0x1358E28", VA = "0x1358E28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1358E2C", Offset = "0x1358E2C", VA = "0x1358E2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1358F28", Offset = "0x1358F28", VA = "0x1358F28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8E84", Offset = "0x6D8E84")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8EBC", Offset = "0x6D8EBC")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8EF4", Offset = "0x6D8EF4")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8F2C", Offset = "0x6D8F2C")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8F64", Offset = "0x6D8F64")]
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
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x6D8F9C", Offset = "0x6D8F9C")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D8FD4", Offset = "0x6D8FD4")]
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
			[Address(RVA = "0x1676E34", Offset = "0x1676E34", VA = "0x1676E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB994", Offset = "0x6DB994")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1676E3C", Offset = "0x1676E3C", VA = "0x1676E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DB9A4", Offset = "0x6DB9A4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1676E48", Offset = "0x1676E48", VA = "0x1676E48", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1676F88", Offset = "0x1676F88", VA = "0x1676F88")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1677018", Offset = "0x1677018", VA = "0x1677018", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1677094", Offset = "0x1677094", VA = "0x1677094")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1677C80", Offset = "0x1677C80", VA = "0x1677C80", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1677ED8", Offset = "0x1677ED8", VA = "0x1677ED8", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1677588", Offset = "0x1677588", VA = "0x1677588")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1677FB4", Offset = "0x1677FB4", VA = "0x1677FB4")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x167845C", Offset = "0x167845C", VA = "0x167845C")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1677D08", Offset = "0x1677D08", VA = "0x1677D08")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x16784FC", Offset = "0x16784FC", VA = "0x16784FC", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1678838", Offset = "0x1678838", VA = "0x1678838")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1678928", Offset = "0x1678928", VA = "0x1678928", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1678A88", Offset = "0x1678A88", VA = "0x1678A88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6DB9B4", Offset = "0x6DB9B4")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x16778D8", Offset = "0x16778D8", VA = "0x16778D8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1678B18", Offset = "0x1678B18", VA = "0x1678B18")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x6D0B40", Offset = "0x6D0B40")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D8FE4", Offset = "0x6D8FE4")]
		public CameraController cameraController;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D901C", Offset = "0x6D901C")]
		public float accelerationTime;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D9054", Offset = "0x6D9054")]
		public float turnTime;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D908C", Offset = "0x6D908C")]
		public bool walkByDefault;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D90C4", Offset = "0x6D90C4")]
		public RotationMode rotationMode;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D90FC", Offset = "0x6D90FC")]
		public float moveSpeed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D9134", Offset = "0x6D9134")]
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
			[Address(RVA = "0x15218E0", Offset = "0x15218E0", VA = "0x15218E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBA64", Offset = "0x6DBA64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x15218E8", Offset = "0x15218E8", VA = "0x15218E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBA74", Offset = "0x6DBA74")]
			private set
			{
			}
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x15218F4", Offset = "0x15218F4", VA = "0x15218F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1521984", Offset = "0x1521984", VA = "0x1521984")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1521E44", Offset = "0x1521E44", VA = "0x1521E44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x15219D8", Offset = "0x15219D8", VA = "0x15219D8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1521C58", Offset = "0x1521C58", VA = "0x1521C58")]
		private void Move()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1521E80", Offset = "0x1521E80", VA = "0x1521E80")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1521F1C", Offset = "0x1521F1C", VA = "0x1521F1C")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1521FA0", Offset = "0x1521FA0", VA = "0x1521FA0")]
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
		[Address(RVA = "0x15241AC", Offset = "0x15241AC", VA = "0x15241AC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1524224", Offset = "0x1524224", VA = "0x1524224", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x15243E4", Offset = "0x15243E4", VA = "0x15243E4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1524408", Offset = "0x1524408", VA = "0x1524408")]
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
		[Address(RVA = "0x15241EC", Offset = "0x15241EC", VA = "0x15241EC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1524524", Offset = "0x1524524", VA = "0x1524524", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1524424", Offset = "0x1524424", VA = "0x1524424")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x16684EC", Offset = "0x16684EC", VA = "0x16684EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1668528", Offset = "0x1668528", VA = "0x1668528")]
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
		[Address(RVA = "0x1521FC8", Offset = "0x1521FC8", VA = "0x1521FC8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1521FFC", Offset = "0x1521FFC", VA = "0x1521FFC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x15220AC", Offset = "0x15220AC", VA = "0x15220AC")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D9144", Offset = "0x6D9144")]
		public bool activeTargetSeeking;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D917C", Offset = "0x6D917C")]
		public float cornerRadius;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D91B4", Offset = "0x6D91B4")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D91EC", Offset = "0x6D91EC")]
		public float maxSampleDistance;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6D9224", Offset = "0x6D9224")]
		public float nextPathInterval;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D925C", Offset = "0x6D925C")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D926C", Offset = "0x6D926C")]
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
			[Address(RVA = "0x151884C", Offset = "0x151884C", VA = "0x151884C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBA84", Offset = "0x6DBA84")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x1518858", Offset = "0x1518858", VA = "0x1518858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBA94", Offset = "0x6DBA94")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public State state
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x1518864", Offset = "0x1518864", VA = "0x1518864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBAA4", Offset = "0x6DBAA4")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x151886C", Offset = "0x151886C", VA = "0x151886C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBAB4", Offset = "0x6DBAB4")]
			private set
			{
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1518874", Offset = "0x1518874", VA = "0x1518874")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1518924", Offset = "0x1518924", VA = "0x1518924")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1518D10", Offset = "0x1518D10", VA = "0x1518D10")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1518D8C", Offset = "0x1518D8C", VA = "0x1518D8C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1518CCC", Offset = "0x1518CCC", VA = "0x1518CCC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1518CFC", Offset = "0x1518CFC", VA = "0x1518CFC")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1518ED8", Offset = "0x1518ED8", VA = "0x1518ED8")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1519088", Offset = "0x1519088", VA = "0x1519088")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BB0", Offset = "0x6D0BB0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1359230", Offset = "0x1359230", VA = "0x1359230")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1359238", Offset = "0x1359238", VA = "0x1359238")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1359254", Offset = "0x1359254", VA = "0x1359254")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BC0", Offset = "0x6D0BC0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1359270", Offset = "0x1359270", VA = "0x1359270")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1359278", Offset = "0x1359278", VA = "0x1359278")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1359294", Offset = "0x1359294", VA = "0x1359294")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BD0", Offset = "0x6D0BD0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x13592B0", Offset = "0x13592B0", VA = "0x13592B0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x13592B8", Offset = "0x13592B8", VA = "0x13592B8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x13592F8", Offset = "0x13592F8", VA = "0x13592F8")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xFB4B28", Offset = "0xFB4B28", VA = "0xFB4B28")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xFB4CE8", Offset = "0xFB4CE8", VA = "0xFB4CE8")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xFB4E80", Offset = "0xFB4E80", VA = "0xFB4E80")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xFB501C", Offset = "0xFB501C", VA = "0xFB501C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xFB5090", Offset = "0xFB5090", VA = "0xFB5090")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xFB5104", Offset = "0xFB5104", VA = "0xFB5104")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xFB5168", Offset = "0xFB5168", VA = "0xFB5168")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xFB51EC", Offset = "0xFB51EC", VA = "0xFB51EC")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xFB5250", Offset = "0xFB5250", VA = "0xFB5250")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xFB52B4", Offset = "0xFB52B4", VA = "0xFB52B4")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xFB5318", Offset = "0xFB5318", VA = "0xFB5318")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xFB537C", Offset = "0xFB537C", VA = "0xFB537C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xFB53E8", Offset = "0xFB53E8", VA = "0xFB53E8")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xFB5450", Offset = "0xFB5450", VA = "0xFB5450")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xFB54B4", Offset = "0xFB54B4", VA = "0xFB54B4")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000128")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0BF0", Offset = "0x6D0BF0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x135931C", Offset = "0x135931C", VA = "0x135931C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x1359324", Offset = "0x1359324", VA = "0x1359324")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C00", Offset = "0x6D0C00")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x1359464", Offset = "0x1359464", VA = "0x1359464")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x135946C", Offset = "0x135946C", VA = "0x135946C")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C10", Offset = "0x6D0C10")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x1359488", Offset = "0x1359488", VA = "0x1359488")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x1359490", Offset = "0x1359490", VA = "0x1359490")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C20", Offset = "0x6D0C20")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x13594AC", Offset = "0x13594AC", VA = "0x13594AC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x13594B4", Offset = "0x13594B4", VA = "0x13594B4")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C30", Offset = "0x6D0C30")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x13594D0", Offset = "0x13594D0", VA = "0x13594D0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x13594D8", Offset = "0x13594D8", VA = "0x13594D8")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C40", Offset = "0x6D0C40")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x13594F4", Offset = "0x13594F4", VA = "0x13594F4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x13594FC", Offset = "0x13594FC", VA = "0x13594FC")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C50", Offset = "0x6D0C50")]
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
			[Address(RVA = "0x1359518", Offset = "0x1359518", VA = "0x1359518")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1359520", Offset = "0x1359520", VA = "0x1359520")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x135953C", Offset = "0x135953C", VA = "0x135953C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x1359570", Offset = "0x1359570", VA = "0x1359570")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x135958C", Offset = "0x135958C", VA = "0x135958C")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x13595A8", Offset = "0x13595A8", VA = "0x13595A8")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C60", Offset = "0x6D0C60")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1359668", Offset = "0x1359668", VA = "0x1359668")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1359670", Offset = "0x1359670", VA = "0x1359670")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C70", Offset = "0x6D0C70")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x135968C", Offset = "0x135968C", VA = "0x135968C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1359694", Offset = "0x1359694", VA = "0x1359694")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x13596B0", Offset = "0x13596B0", VA = "0x13596B0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C80", Offset = "0x6D0C80")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x13597B0", Offset = "0x13597B0", VA = "0x13597B0")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x13597B8", Offset = "0x13597B8", VA = "0x13597B8")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0C90", Offset = "0x6D0C90")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1359340", Offset = "0x1359340", VA = "0x1359340")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x1359348", Offset = "0x1359348", VA = "0x1359348")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1359364", Offset = "0x1359364", VA = "0x1359364")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFB1F34", Offset = "0xFB1F34", VA = "0xFB1F34")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFB5518", Offset = "0xFB5518", VA = "0xFB5518")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xFB56D8", Offset = "0xFB56D8", VA = "0xFB56D8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xFB5898", Offset = "0xFB5898", VA = "0xFB5898")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xFB22C4", Offset = "0xFB22C4", VA = "0xFB22C4")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xFB5A58", Offset = "0xFB5A58", VA = "0xFB5A58")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFB5C9C", Offset = "0xFB5C9C", VA = "0xFB5C9C")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xFB6194", Offset = "0xFB6194", VA = "0xFB6194")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xFB6400", Offset = "0xFB6400", VA = "0xFB6400")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xFB6680", Offset = "0xFB6680", VA = "0xFB6680")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xFB6860", Offset = "0xFB6860", VA = "0xFB6860")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000134")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CB0", Offset = "0x6D0CB0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x13597D4", Offset = "0x13597D4", VA = "0x13597D4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x13597DC", Offset = "0x13597DC", VA = "0x13597DC")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CC0", Offset = "0x6D0CC0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x13597F8", Offset = "0x13597F8", VA = "0x13597F8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1359800", Offset = "0x1359800", VA = "0x1359800")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CD0", Offset = "0x6D0CD0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x135981C", Offset = "0x135981C", VA = "0x135981C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1359824", Offset = "0x1359824", VA = "0x1359824")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CE0", Offset = "0x6D0CE0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1359840", Offset = "0x1359840", VA = "0x1359840")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x1359848", Offset = "0x1359848", VA = "0x1359848")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000139")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0CF0", Offset = "0x6D0CF0")]
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
			[Address(RVA = "0x1359864", Offset = "0x1359864", VA = "0x1359864")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x135986C", Offset = "0x135986C", VA = "0x135986C")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1359888", Offset = "0x1359888", VA = "0x1359888")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x13598A4", Offset = "0x13598A4", VA = "0x13598A4")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x13598D8", Offset = "0x13598D8", VA = "0x13598D8")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x13598F4", Offset = "0x13598F4", VA = "0x13598F4")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x1359910", Offset = "0x1359910", VA = "0x1359910")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D00", Offset = "0x6D0D00")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x13599C8", Offset = "0x13599C8", VA = "0x13599C8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x13599D0", Offset = "0x13599D0", VA = "0x13599D0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x13599F8", Offset = "0x13599F8", VA = "0x13599F8")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D10", Offset = "0x6D0D10")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1359A14", Offset = "0x1359A14", VA = "0x1359A14")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x1359A1C", Offset = "0x1359A1C", VA = "0x1359A1C")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x1359A38", Offset = "0x1359A38", VA = "0x1359A38")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xFB2100", Offset = "0xFB2100", VA = "0xFB2100")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xFB6A4C", Offset = "0xFB6A4C", VA = "0xFB6A4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xFB6C08", Offset = "0xFB6C08", VA = "0xFB6C08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xFB248C", Offset = "0xFB248C", VA = "0xFB248C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xFB6DC4", Offset = "0xFB6DC4", VA = "0xFB6DC4")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xFB71EC", Offset = "0xFB71EC", VA = "0xFB71EC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xFB74DC", Offset = "0xFB74DC", VA = "0xFB74DC")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}
	}
	[Token(Token = "0x200013C")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D30", Offset = "0x6D0D30")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1359B30", Offset = "0x1359B30", VA = "0x1359B30")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1359B38", Offset = "0x1359B38", VA = "0x1359B38")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1359B54", Offset = "0x1359B54", VA = "0x1359B54")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D40", Offset = "0x6D0D40")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x1359B70", Offset = "0x1359B70", VA = "0x1359B70")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x1359B78", Offset = "0x1359B78", VA = "0x1359B78")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x1359B94", Offset = "0x1359B94", VA = "0x1359B94")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D50", Offset = "0x6D0D50")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x1359BB0", Offset = "0x1359BB0", VA = "0x1359BB0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x1359BB8", Offset = "0x1359BB8", VA = "0x1359BB8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x1359BC4", Offset = "0x1359BC4", VA = "0x1359BC4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xFB27E0", Offset = "0xFB27E0", VA = "0xFB27E0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xFB2D20", Offset = "0xFB2D20", VA = "0xFB2D20")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xFB77E4", Offset = "0xFB77E4", VA = "0xFB77E4")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xFB79D0", Offset = "0xFB79D0", VA = "0xFB79D0")]
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
			[Address(RVA = "0x135AC58", Offset = "0x135AC58", VA = "0x135AC58")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D70", Offset = "0x6D0D70")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x1359C70", Offset = "0x1359C70", VA = "0x1359C70")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1359C78", Offset = "0x1359C78", VA = "0x1359C78")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x1359C94", Offset = "0x1359C94", VA = "0x1359C94")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D80", Offset = "0x6D0D80")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1359F38", Offset = "0x1359F38", VA = "0x1359F38")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x1359F40", Offset = "0x1359F40", VA = "0x1359F40")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1359F64", Offset = "0x1359F64", VA = "0x1359F64")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0D90", Offset = "0x6D0D90")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x135A34C", Offset = "0x135A34C", VA = "0x135A34C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x135A354", Offset = "0x135A354", VA = "0x135A354")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x135A378", Offset = "0x135A378", VA = "0x135A378")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DA0", Offset = "0x6D0DA0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x135A850", Offset = "0x135A850", VA = "0x135A850")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x135A858", Offset = "0x135A858", VA = "0x135A858")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x135A87C", Offset = "0x135A87C", VA = "0x135A87C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DB0", Offset = "0x6D0DB0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x135A970", Offset = "0x135A970", VA = "0x135A970")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x135A978", Offset = "0x135A978", VA = "0x135A978")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x135A99C", Offset = "0x135A99C", VA = "0x135A99C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DC0", Offset = "0x6D0DC0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x135A9C0", Offset = "0x135A9C0", VA = "0x135A9C0")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x135A9C8", Offset = "0x135A9C8", VA = "0x135A9C8")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x135A9E4", Offset = "0x135A9E4", VA = "0x135A9E4")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DD0", Offset = "0x6D0DD0")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400085C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x135AA00", Offset = "0x135AA00", VA = "0x135AA00")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x135AA08", Offset = "0x135AA08", VA = "0x135AA08")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x135AA6C", Offset = "0x135AA6C", VA = "0x135AA6C")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DE0", Offset = "0x6D0DE0")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400085D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x135AAC8", Offset = "0x135AAC8", VA = "0x135AAC8")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x135AAD0", Offset = "0x135AAD0", VA = "0x135AAD0")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x135AB34", Offset = "0x135AB34", VA = "0x135AB34")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0DF0", Offset = "0x6D0DF0")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400085E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x135AB90", Offset = "0x135AB90", VA = "0x135AB90")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x135AB98", Offset = "0x135AB98", VA = "0x135AB98")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x135ABFC", Offset = "0x135ABFC", VA = "0x135ABFC")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E00", Offset = "0x6D0E00")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400085F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x1359CB0", Offset = "0x1359CB0", VA = "0x1359CB0")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x1359CB8", Offset = "0x1359CB8", VA = "0x1359CB8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x1359CD8", Offset = "0x1359CD8", VA = "0x1359CD8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E10", Offset = "0x6D0E10")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000860")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x1359CF4", Offset = "0x1359CF4", VA = "0x1359CF4")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x1359CFC", Offset = "0x1359CFC", VA = "0x1359CFC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x1359D1C", Offset = "0x1359D1C", VA = "0x1359D1C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E20", Offset = "0x6D0E20")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x1359D38", Offset = "0x1359D38", VA = "0x1359D38")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x1359D40", Offset = "0x1359D40", VA = "0x1359D40")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x1359D5C", Offset = "0x1359D5C", VA = "0x1359D5C")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E30", Offset = "0x6D0E30")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x1359D78", Offset = "0x1359D78", VA = "0x1359D78")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x1359D80", Offset = "0x1359D80", VA = "0x1359D80")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x1359D9C", Offset = "0x1359D9C", VA = "0x1359D9C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E40", Offset = "0x6D0E40")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x1359DB8", Offset = "0x1359DB8", VA = "0x1359DB8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1359DC0", Offset = "0x1359DC0", VA = "0x1359DC0")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x1359DDC", Offset = "0x1359DDC", VA = "0x1359DDC")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E50", Offset = "0x6D0E50")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1359DF8", Offset = "0x1359DF8", VA = "0x1359DF8")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1359E00", Offset = "0x1359E00", VA = "0x1359E00")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1359E1C", Offset = "0x1359E1C", VA = "0x1359E1C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E60", Offset = "0x6D0E60")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1359E38", Offset = "0x1359E38", VA = "0x1359E38")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1359E40", Offset = "0x1359E40", VA = "0x1359E40")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1359E5C", Offset = "0x1359E5C", VA = "0x1359E5C")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E70", Offset = "0x6D0E70")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x1359E78", Offset = "0x1359E78", VA = "0x1359E78")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x1359E80", Offset = "0x1359E80", VA = "0x1359E80")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1359E9C", Offset = "0x1359E9C", VA = "0x1359E9C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E80", Offset = "0x6D0E80")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1359EB8", Offset = "0x1359EB8", VA = "0x1359EB8")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1359EC0", Offset = "0x1359EC0", VA = "0x1359EC0")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1359EDC", Offset = "0x1359EDC", VA = "0x1359EDC")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0E90", Offset = "0x6D0E90")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1359EF8", Offset = "0x1359EF8", VA = "0x1359EF8")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1359F00", Offset = "0x1359F00", VA = "0x1359F00")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x1359F1C", Offset = "0x1359F1C", VA = "0x1359F1C")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EA0", Offset = "0x6D0EA0")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x1359F88", Offset = "0x1359F88", VA = "0x1359F88")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1359F90", Offset = "0x1359F90", VA = "0x1359F90")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1359FAC", Offset = "0x1359FAC", VA = "0x1359FAC")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EB0", Offset = "0x6D0EB0")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1359FC8", Offset = "0x1359FC8", VA = "0x1359FC8")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1359FD0", Offset = "0x1359FD0", VA = "0x1359FD0")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1359FEC", Offset = "0x1359FEC", VA = "0x1359FEC")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EC0", Offset = "0x6D0EC0")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x135A008", Offset = "0x135A008", VA = "0x135A008")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x135A010", Offset = "0x135A010", VA = "0x135A010")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x135A02C", Offset = "0x135A02C", VA = "0x135A02C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0ED0", Offset = "0x6D0ED0")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x135A048", Offset = "0x135A048", VA = "0x135A048")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x135A050", Offset = "0x135A050", VA = "0x135A050")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x135A06C", Offset = "0x135A06C", VA = "0x135A06C")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EE0", Offset = "0x6D0EE0")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x135A088", Offset = "0x135A088", VA = "0x135A088")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x135A090", Offset = "0x135A090", VA = "0x135A090")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x135A0AC", Offset = "0x135A0AC", VA = "0x135A0AC")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0EF0", Offset = "0x6D0EF0")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x135A0C8", Offset = "0x135A0C8", VA = "0x135A0C8")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x135A0D0", Offset = "0x135A0D0", VA = "0x135A0D0")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x135A0EC", Offset = "0x135A0EC", VA = "0x135A0EC")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F00", Offset = "0x6D0F00")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x135A108", Offset = "0x135A108", VA = "0x135A108")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x135A110", Offset = "0x135A110", VA = "0x135A110")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x135A138", Offset = "0x135A138", VA = "0x135A138")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F10", Offset = "0x6D0F10")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x135A154", Offset = "0x135A154", VA = "0x135A154")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x135A15C", Offset = "0x135A15C", VA = "0x135A15C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x135A184", Offset = "0x135A184", VA = "0x135A184")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F20", Offset = "0x6D0F20")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x135A1A0", Offset = "0x135A1A0", VA = "0x135A1A0")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x135A1A8", Offset = "0x135A1A8", VA = "0x135A1A8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x135A1D0", Offset = "0x135A1D0", VA = "0x135A1D0")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F30", Offset = "0x6D0F30")]
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
			[Address(RVA = "0x135A1EC", Offset = "0x135A1EC", VA = "0x135A1EC")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x135A1F4", Offset = "0x135A1F4", VA = "0x135A1F4")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x135A210", Offset = "0x135A210", VA = "0x135A210")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x135A22C", Offset = "0x135A22C", VA = "0x135A22C")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x135A260", Offset = "0x135A260", VA = "0x135A260")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x135A27C", Offset = "0x135A27C", VA = "0x135A27C")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x135A298", Offset = "0x135A298", VA = "0x135A298")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F40", Offset = "0x6D0F40")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x135A39C", Offset = "0x135A39C", VA = "0x135A39C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x135A3A4", Offset = "0x135A3A4", VA = "0x135A3A4")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x135A3F8", Offset = "0x135A3F8", VA = "0x135A3F8")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F50", Offset = "0x6D0F50")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x135A444", Offset = "0x135A444", VA = "0x135A444")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x135A44C", Offset = "0x135A44C", VA = "0x135A44C")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x135A468", Offset = "0x135A468", VA = "0x135A468")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F60", Offset = "0x6D0F60")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x135A484", Offset = "0x135A484", VA = "0x135A484")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x135A48C", Offset = "0x135A48C", VA = "0x135A48C")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x135A4A8", Offset = "0x135A4A8", VA = "0x135A4A8")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F70", Offset = "0x6D0F70")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x135A4C4", Offset = "0x135A4C4", VA = "0x135A4C4")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x135A4CC", Offset = "0x135A4CC", VA = "0x135A4CC")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x135A4F0", Offset = "0x135A4F0", VA = "0x135A4F0")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F80", Offset = "0x6D0F80")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x135A514", Offset = "0x135A514", VA = "0x135A514")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x135A51C", Offset = "0x135A51C", VA = "0x135A51C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x135A540", Offset = "0x135A540", VA = "0x135A540")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0F90", Offset = "0x6D0F90")]
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
			[Address(RVA = "0x135A564", Offset = "0x135A564", VA = "0x135A564")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x135A56C", Offset = "0x135A56C", VA = "0x135A56C")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x135A574", Offset = "0x135A574", VA = "0x135A574")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FA0", Offset = "0x6D0FA0")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x135A610", Offset = "0x135A610", VA = "0x135A610")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x135A618", Offset = "0x135A618", VA = "0x135A618")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x135A63C", Offset = "0x135A63C", VA = "0x135A63C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FB0", Offset = "0x6D0FB0")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x135A660", Offset = "0x135A660", VA = "0x135A660")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x135A668", Offset = "0x135A668", VA = "0x135A668")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x135A68C", Offset = "0x135A68C", VA = "0x135A68C")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FC0", Offset = "0x6D0FC0")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x135A6B0", Offset = "0x135A6B0", VA = "0x135A6B0")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x135A6B8", Offset = "0x135A6B8", VA = "0x135A6B8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x135A6C4", Offset = "0x135A6C4", VA = "0x135A6C4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FD0", Offset = "0x6D0FD0")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x135A780", Offset = "0x135A780", VA = "0x135A780")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x135A788", Offset = "0x135A788", VA = "0x135A788")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x135A794", Offset = "0x135A794", VA = "0x135A794")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D0FE0", Offset = "0x6D0FE0")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x135A8A0", Offset = "0x135A8A0", VA = "0x135A8A0")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x135A8A8", Offset = "0x135A8A8", VA = "0x135A8A8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x135A8B4", Offset = "0x135A8B4", VA = "0x135A8B4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFB31E8", Offset = "0xFB31E8", VA = "0xFB31E8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFB29A0", Offset = "0xFB29A0", VA = "0xFB29A0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xFB2EB8", Offset = "0xFB2EB8", VA = "0xFB2EB8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xFB7C1C", Offset = "0xFB7C1C", VA = "0xFB7C1C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xFB7DDC", Offset = "0xFB7DDC", VA = "0xFB7DDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xFB7F74", Offset = "0xFB7F74", VA = "0xFB7F74")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xFB8130", Offset = "0xFB8130", VA = "0xFB8130")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xFB8324", Offset = "0xFB8324", VA = "0xFB8324")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xFB84DC", Offset = "0xFB84DC", VA = "0xFB84DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xFB8694", Offset = "0xFB8694", VA = "0xFB8694")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFB884C", Offset = "0xFB884C", VA = "0xFB884C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFB8A0C", Offset = "0xFB8A0C", VA = "0xFB8A0C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xFB8BA4", Offset = "0xFB8BA4", VA = "0xFB8BA4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xFB8D4C", Offset = "0xFB8D4C", VA = "0xFB8D4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xFB8F04", Offset = "0xFB8F04", VA = "0xFB8F04")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xFB90B4", Offset = "0xFB90B4", VA = "0xFB90B4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xFB1D74", Offset = "0xFB1D74", VA = "0xFB1D74")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFB9264", Offset = "0xFB9264", VA = "0xFB9264")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFB9418", Offset = "0xFB9418", VA = "0xFB9418")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFB95CC", Offset = "0xFB95CC", VA = "0xFB95CC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFB9780", Offset = "0xFB9780", VA = "0xFB9780")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xFB9938", Offset = "0xFB9938", VA = "0xFB9938")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xFB9AF0", Offset = "0xFB9AF0", VA = "0xFB9AF0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xFB9C98", Offset = "0xFB9C98", VA = "0xFB9C98")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xFB9E44", Offset = "0xFB9E44", VA = "0xFB9E44")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xFB2628", Offset = "0xFB2628", VA = "0xFB2628")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xFB35C4", Offset = "0xFB35C4", VA = "0xFB35C4")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xFB9FF0", Offset = "0xFB9FF0", VA = "0xFB9FF0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xFB378C", Offset = "0xFB378C", VA = "0xFB378C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xFBA1D8", Offset = "0xFBA1D8", VA = "0xFBA1D8")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xFBA604", Offset = "0xFBA604", VA = "0xFBA604")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xFBA7B0", Offset = "0xFBA7B0", VA = "0xFBA7B0")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xFBA94C", Offset = "0xFBA94C", VA = "0xFBA94C")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xFBAAE8", Offset = "0xFBAAE8", VA = "0xFBAAE8")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xFB2B60", Offset = "0xFB2B60", VA = "0xFB2B60")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xFBAC90", Offset = "0xFBAC90", VA = "0xFBAC90")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xFB3050", Offset = "0xFB3050", VA = "0xFB3050")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xFB3380", Offset = "0xFB3380", VA = "0xFB3380")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xFBAE94", Offset = "0xFBAE94", VA = "0xFBAE94")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xFBB0E8", Offset = "0xFBB0E8", VA = "0xFBB0E8")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xFBB33C", Offset = "0xFBB33C", VA = "0xFBB33C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200016A")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1000", Offset = "0x6D1000")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x135AE9C", Offset = "0x135AE9C", VA = "0x135AE9C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x135AEA4", Offset = "0x135AEA4", VA = "0x135AEA4")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x135AEC8", Offset = "0x135AEC8", VA = "0x135AEC8")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1010", Offset = "0x6D1010")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x135AEEC", Offset = "0x135AEEC", VA = "0x135AEEC")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x135AEF4", Offset = "0x135AEF4", VA = "0x135AEF4")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x135AF18", Offset = "0x135AF18", VA = "0x135AF18")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1020", Offset = "0x6D1020")]
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
			[Address(RVA = "0x135AF3C", Offset = "0x135AF3C", VA = "0x135AF3C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x135B180", Offset = "0x135B180", VA = "0x135B180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1030", Offset = "0x6D1030")]
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
			[Address(RVA = "0x135B890", Offset = "0x135B890", VA = "0x135B890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x135BAF8", Offset = "0x135BAF8", VA = "0x135BAF8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1040", Offset = "0x6D1040")]
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
			[Address(RVA = "0x135B3E4", Offset = "0x135B3E4", VA = "0x135B3E4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x135B614", Offset = "0x135B614", VA = "0x135B614", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1050", Offset = "0x6D1050")]
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
			[Address(RVA = "0x135B18C", Offset = "0x135B18C", VA = "0x135B18C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x135B3D8", Offset = "0x135B3D8", VA = "0x135B3D8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1060", Offset = "0x6D1060")]
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
			[Address(RVA = "0x135B620", Offset = "0x135B620", VA = "0x135B620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x135B884", Offset = "0x135B884", VA = "0x135B884", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D1070", Offset = "0x6D1070")]
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
			[Address(RVA = "0x135BB04", Offset = "0x135BB04", VA = "0x135BB04", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x135BD3C", Offset = "0x135BD3C", VA = "0x135BD3C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFBB590", Offset = "0xFBB590", VA = "0xFBB590")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFBB780", Offset = "0xFBB780", VA = "0xFBB780")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFBB984", Offset = "0xFBB984", VA = "0xFBB984")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xFBBA44", Offset = "0xFBBA44", VA = "0xFBBA44")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xFBBB04", Offset = "0xFBBB04", VA = "0xFBBB04")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xFBBBC4", Offset = "0xFBBBC4", VA = "0xFBBBC4")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xFBBC94", Offset = "0xFBBC94", VA = "0xFBBC94")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xFBBD64", Offset = "0xFBBD64", VA = "0xFBBD64")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xFBBE24", Offset = "0xFBBE24", VA = "0xFBBE24")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xFBC03C", Offset = "0xFBC03C", VA = "0xFBC03C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xFBC254", Offset = "0xFBC254", VA = "0xFBC254")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6DC044", Offset = "0x6DC044")]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xFBC358", Offset = "0xFBC358", VA = "0xFBC358")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6DC0B4", Offset = "0x6DC0B4")]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xFBC45C", Offset = "0xFBC45C", VA = "0xFBC45C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6DC124", Offset = "0x6DC124")]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xFBC560", Offset = "0xFBC560", VA = "0xFBC560")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6DC194", Offset = "0x6DC194")]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xFBC674", Offset = "0xFBC674", VA = "0xFBC674")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6DC204", Offset = "0x6DC204")]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xFBC788", Offset = "0xFBC788", VA = "0xFBC788")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6DC274", Offset = "0x6DC274")]
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
				[Address(RVA = "0x1358F70", Offset = "0x1358F70", VA = "0x1358F70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1358FA4", Offset = "0x1358FA4", VA = "0x1358FA4")]
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
				[Address(RVA = "0x1359140", Offset = "0x1359140", VA = "0x1359140", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x13591A4", Offset = "0x13591A4", VA = "0x13591A4")]
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
				[Address(RVA = "0x1359058", Offset = "0x1359058", VA = "0x1359058", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1359074", Offset = "0x1359074", VA = "0x1359074")]
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
				[Address(RVA = "0x1358FD0", Offset = "0x1358FD0", VA = "0x1358FD0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x135901C", Offset = "0x135901C", VA = "0x135901C")]
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
				[Address(RVA = "0x13590A0", Offset = "0x13590A0", VA = "0x13590A0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x1359104", Offset = "0x1359104", VA = "0x1359104")]
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
				[Address(RVA = "0x13591D0", Offset = "0x13591D0", VA = "0x13591D0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1359204", Offset = "0x1359204", VA = "0x1359204")]
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
			[Address(RVA = "0x135BD48", Offset = "0x135BD48", VA = "0x135BD48")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x135BE4C", Offset = "0x135BE4C", VA = "0x135BE4C")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x135BEE4", Offset = "0x135BEE4", VA = "0x135BEE4")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x135BF7C", Offset = "0x135BF7C", VA = "0x135BF7C")]
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
		[Address(RVA = "0xFBC88C", Offset = "0xFBC88C", VA = "0xFBC88C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xFBC950", Offset = "0xFBC950", VA = "0xFBC950")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6D1080", Offset = "0x6D1080")]
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
			[Address(RVA = "0xFB0370", Offset = "0xFB0370", VA = "0xFB0370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC384", Offset = "0x6DC384")]
			add
			{
			}
			[Token(Token = "0x600090B")]
			[Address(RVA = "0xFB042C", Offset = "0xFB042C", VA = "0xFB042C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC394", Offset = "0x6DC394")]
			remove
			{
			}
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xFB04E8", Offset = "0xFB04E8", VA = "0xFB04E8")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xFB0564", Offset = "0xFB0564", VA = "0xFB0564")]
		private void Awake()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xFB1AAC", Offset = "0xFB1AAC", VA = "0xFB1AAC")]
		private void Start()
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xFB1AF0", Offset = "0xFB1AF0", VA = "0xFB1AF0")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xFB1AF4", Offset = "0xFB1AF4", VA = "0xFB1AF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xFB05B4", Offset = "0xFB05B4", VA = "0xFB05B4")]
		public void CreateTween()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xFB397C", Offset = "0xFB397C", VA = "0xFB397C", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xFB39F4", Offset = "0xFB39F4", VA = "0xFB39F4", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xFB3A6C", Offset = "0xFB3A6C", VA = "0xFB3A6C", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xFB3AE4", Offset = "0xFB3AE4", VA = "0xFB3AE4", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xFB3B5C", Offset = "0xFB3B5C", VA = "0xFB3B5C", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xFB3BD4", Offset = "0xFB3BD4", VA = "0xFB3BD4", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xFB3CCC", Offset = "0xFB3CCC", VA = "0xFB3CCC", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xFB3CDC", Offset = "0xFB3CDC", VA = "0xFB3CDC", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xFB4058", Offset = "0xFB4058", VA = "0xFB4058", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xFB40D4", Offset = "0xFB40D4", VA = "0xFB40D4", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xFB4158", Offset = "0xFB4158", VA = "0xFB4158")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xFB41E0", Offset = "0xFB41E0", VA = "0xFB41E0")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xFB4244", Offset = "0xFB4244", VA = "0xFB4244")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xFB42A8", Offset = "0xFB42A8", VA = "0xFB42A8")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xFB4330", Offset = "0xFB4330", VA = "0xFB4330")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xFB4394", Offset = "0xFB4394", VA = "0xFB4394")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xFB441C", Offset = "0xFB441C", VA = "0xFB441C")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xFB4480", Offset = "0xFB4480", VA = "0xFB4480")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xFB45C8", Offset = "0xFB45C8", VA = "0xFB45C8")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xFB4654", Offset = "0xFB4654", VA = "0xFB4654")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xFB46D0", Offset = "0xFB46D0", VA = "0xFB46D0")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xFB4768", Offset = "0xFB4768", VA = "0xFB4768")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xFB47E8", Offset = "0xFB47E8", VA = "0xFB47E8")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xFB1B50", Offset = "0xFB1B50", VA = "0xFB1B50")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xFB48F4", Offset = "0xFB48F4", VA = "0xFB48F4")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xFB1B38", Offset = "0xFB1B38", VA = "0xFB1B38")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xFB3DF0", Offset = "0xFB3DF0", VA = "0xFB3DF0")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xFB4930", Offset = "0xFB4930", VA = "0xFB4930")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xFB4B20", Offset = "0xFB4B20", VA = "0xFB4B20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DC3A4", Offset = "0x6DC3A4")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D10D8", Offset = "0x6D10D8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform target;

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x135C0D0", Offset = "0x135C0D0", VA = "0x135C0D0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x135C0D8", Offset = "0x135C0D8", VA = "0x135C0D8")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x135C0F4", Offset = "0x135C0F4", VA = "0x135C0F4")]
			internal void <DOSpiral>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D10E8", Offset = "0x6D10E8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x135C110", Offset = "0x135C110", VA = "0x135C110")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x135C118", Offset = "0x135C118", VA = "0x135C118")]
			internal Vector3 <DOSpiral>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xFBCA04", Offset = "0xFBCA04", VA = "0xFBCA04")]
		static DOTweenProShortcuts()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xFBCA50", Offset = "0xFBCA50", VA = "0xFBCA50")]
		public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xFBCD68", Offset = "0xFBCD68", VA = "0xFBCD68")]
		public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
		{
			return null;
		}
	}
}
