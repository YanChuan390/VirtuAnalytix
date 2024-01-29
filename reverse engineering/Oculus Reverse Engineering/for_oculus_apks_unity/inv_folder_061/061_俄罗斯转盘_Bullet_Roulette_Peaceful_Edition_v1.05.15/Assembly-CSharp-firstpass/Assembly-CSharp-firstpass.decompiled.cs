using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RootMotion
{
	[Token(Token = "0x2000002")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		public enum Mode
		{
			[Token(Token = "0x4000014")]
			AnimationClips,
			[Token(Token = "0x4000015")]
			AnimationStates,
			[Token(Token = "0x4000016")]
			PlayableDirector,
			[Token(Token = "0x4000017")]
			Realtime
		}

		[Token(Token = "0x2000004")]
		public delegate void BakerDelegate(AnimationClip clip, float time);

		[Serializable]
		[Token(Token = "0x2000005")]
		public class ClipSettings
		{
			[Serializable]
			[Token(Token = "0x2000006")]
			public enum BasedUponRotation
			{
				[Token(Token = "0x4000025")]
				Original,
				[Token(Token = "0x4000026")]
				BodyOrientation
			}

			[Serializable]
			[Token(Token = "0x2000007")]
			public enum BasedUponY
			{
				[Token(Token = "0x4000028")]
				Original,
				[Token(Token = "0x4000029")]
				CenterOfMass,
				[Token(Token = "0x400002A")]
				Feet
			}

			[Serializable]
			[Token(Token = "0x2000008")]
			public enum BasedUponXZ
			{
				[Token(Token = "0x400002C")]
				Original,
				[Token(Token = "0x400002D")]
				CenterOfMass
			}

			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool loopTime;

			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool loopBlend;

			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cycleOffset;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool loopBlendOrientation;

			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasedUponRotation basedUponRotation;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float orientationOffsetY;

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool loopBlendPositionY;

			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BasedUponY basedUponY;

			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float level;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool loopBlendPositionXZ;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public BasedUponXZ basedUponXZ;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool mirror;

			[Token(Token = "0x6000018")]
			[Address(RVA = "0xA53358", Offset = "0xA53358", VA = "0xA53358")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BakerDelegate OnStartClip;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BakerDelegate OnUpdateClip;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("If enabled, baked clips will have the same AnimationClipSettings as the clips used for baking. If disabled, clip settings from below will be applied to all the baked clips.")]
		public bool inheritClipSettings;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("AnimationClipSettings applied to the baked animation clip.")]
		public ClipSettings clipSettings;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0xA5305C", Offset = "0xA5305C", VA = "0xA5305C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xA53064", Offset = "0xA53064", VA = "0xA53064")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xA53070", Offset = "0xA53070", VA = "0xA53070")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xA53078", Offset = "0xA53078", VA = "0xA53078")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xA53080", Offset = "0xA53080", VA = "0xA53080")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xA53088", Offset = "0xA53088", VA = "0xA53088")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xA52F4C", Offset = "0xA52F4C", VA = "0xA52F4C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xA52F90", Offset = "0xA52F90", VA = "0xA52F90")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xA52FD4", Offset = "0xA52FD4", VA = "0xA52FD4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA53018", Offset = "0xA53018", VA = "0xA53018")]
		[ContextMenu("Asset Store Thread")]
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
		[Address(RVA = "0xA53090", Offset = "0xA53090", VA = "0xA53090")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xA53094", Offset = "0xA53094", VA = "0xA53094")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xA53098", Offset = "0xA53098", VA = "0xA53098")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xA5309C", Offset = "0xA5309C", VA = "0xA5309C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerTransform[] children;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int rootChildIndex;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xA53360", Offset = "0xA53360", VA = "0xA53360")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xA537A4", Offset = "0xA537A4", VA = "0xA537A4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xA537AC", Offset = "0xA537AC", VA = "0xA537AC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xA539E8", Offset = "0xA539E8", VA = "0xA539E8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xA53C4C", Offset = "0xA53C4C", VA = "0xA53C4C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xA53F64", Offset = "0xA53F64", VA = "0xA53F64", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xA5358C", Offset = "0xA5358C", VA = "0xA5358C")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xA53644", Offset = "0xA53644", VA = "0xA53644")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xA541C4", Offset = "0xA541C4", VA = "0xA541C4")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class TQ
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xA5422C", Offset = "0xA5422C", VA = "0xA5422C")]
		public TQ()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA54234", Offset = "0xA54234", VA = "0xA54234")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA54298", Offset = "0xA54298", VA = "0xA54298")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA544F4", Offset = "0xA544F4", VA = "0xA544F4")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA54B64", Offset = "0xA54B64", VA = "0xA54B64")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA5502C", Offset = "0xA5502C", VA = "0xA5502C")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA544D4", Offset = "0xA544D4", VA = "0xA544D4")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA55218", Offset = "0xA55218", VA = "0xA55218")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA55220", Offset = "0xA55220", VA = "0xA55220")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xA55258", Offset = "0xA55258", VA = "0xA55258")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA5561C", Offset = "0xA5561C", VA = "0xA5561C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA557FC", Offset = "0xA557FC", VA = "0xA557FC")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA55800", Offset = "0xA55800", VA = "0xA55800")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA55994", Offset = "0xA55994", VA = "0xA55994")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xA55CF8", Offset = "0xA55CF8", VA = "0xA55CF8")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA55EE0", Offset = "0xA55EE0", VA = "0xA55EE0")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA55F70", Offset = "0xA55F70", VA = "0xA55F70")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA55150", Offset = "0xA55150", VA = "0xA55150")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA55FE4", Offset = "0xA55FE4", VA = "0xA55FE4")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA55B60", Offset = "0xA55B60", VA = "0xA55B60")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA55FE8", Offset = "0xA55FE8", VA = "0xA55FE8")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xA56378", Offset = "0xA56378", VA = "0xA56378")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xA56468", Offset = "0xA56468", VA = "0xA56468")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xA5654C", Offset = "0xA5654C", VA = "0xA5654C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xA565B4", Offset = "0xA565B4", VA = "0xA565B4")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xA564D0", Offset = "0xA564D0", VA = "0xA564D0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xA565B8", Offset = "0xA565B8", VA = "0xA565B8")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xA56660", Offset = "0xA56660", VA = "0xA56660")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class BakerMuscle
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xA5694C", Offset = "0xA5694C", VA = "0xA5694C")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xA569BC", Offset = "0xA569BC", VA = "0xA569BC")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xA57458", Offset = "0xA57458", VA = "0xA57458")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xA57500", Offset = "0xA57500", VA = "0xA57500")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xA573F0", Offset = "0xA573F0", VA = "0xA573F0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA575F4", Offset = "0xA575F4", VA = "0xA575F4")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA57630", Offset = "0xA57630", VA = "0xA57630")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class BakerTransform
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xA536FC", Offset = "0xA536FC", VA = "0xA536FC")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA539D4", Offset = "0xA539D4", VA = "0xA539D4")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA53CB0", Offset = "0xA53CB0", VA = "0xA53CB0")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA57638", Offset = "0xA57638", VA = "0xA57638")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA5387C", Offset = "0xA5387C", VA = "0xA5387C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA578C0", Offset = "0xA578C0", VA = "0xA578C0")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA53FD0", Offset = "0xA53FD0", VA = "0xA53FD0")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA53A54", Offset = "0xA53A54", VA = "0xA53A54")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 0.1f)]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public float IKKeyReductionError;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] muscles;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HumanPose pose;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mN;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xA57928", Offset = "0xA57928", VA = "0xA57928")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA57E88", Offset = "0xA57E88", VA = "0xA57E88", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA57EA4", Offset = "0xA57EA4", VA = "0xA57EA4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA57F7C", Offset = "0xA57F7C", VA = "0xA57F7C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA58038", Offset = "0xA58038", VA = "0xA58038", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA581D8", Offset = "0xA581D8", VA = "0xA581D8", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA584FC", Offset = "0xA584FC", VA = "0xA584FC")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA585DC", Offset = "0xA585DC", VA = "0xA585DC")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000012")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000091")]
			Update,
			[Token(Token = "0x4000092")]
			FixedUpdate,
			[Token(Token = "0x4000093")]
			LateUpdate,
			[Token(Token = "0x4000094")]
			FixedLateUpdate
		}

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0xA5868C", Offset = "0xA5868C", VA = "0xA5868C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA58694", Offset = "0xA58694", VA = "0xA58694")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xA5869C", Offset = "0xA5869C", VA = "0xA5869C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xA586A4", Offset = "0xA586A4", VA = "0xA586A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xA586AC", Offset = "0xA586AC", VA = "0xA586AC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xA586B4", Offset = "0xA586B4", VA = "0xA586B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xA5911C", Offset = "0xA5911C", VA = "0xA5911C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xA586BC", Offset = "0xA586BC", VA = "0xA586BC")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xA586F4", Offset = "0xA586F4", VA = "0xA586F4")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA586FC", Offset = "0xA586FC", VA = "0xA586FC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA58834", Offset = "0xA58834", VA = "0xA58834", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA5887C", Offset = "0xA5887C", VA = "0xA5887C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA588D4", Offset = "0xA588D4", VA = "0xA588D4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA5892C", Offset = "0xA5892C", VA = "0xA5892C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA58860", Offset = "0xA58860", VA = "0xA58860")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA58AB8", Offset = "0xA58AB8", VA = "0xA58AB8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA590E0", Offset = "0xA590E0", VA = "0xA590E0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA59188", Offset = "0xA59188", VA = "0xA59188")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xA59250", Offset = "0xA59250", VA = "0xA59250")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA5927C", Offset = "0xA5927C", VA = "0xA5927C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA594A0", Offset = "0xA594A0", VA = "0xA594A0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA594DC", Offset = "0xA594DC", VA = "0xA594DC")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public enum Axis
	{
		[Token(Token = "0x400009B")]
		X,
		[Token(Token = "0x400009C")]
		Y,
		[Token(Token = "0x400009D")]
		Z
	}
	[Token(Token = "0x2000015")]
	public class AxisTools
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xA594F8", Offset = "0xA594F8", VA = "0xA594F8")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA595D8", Offset = "0xA595D8", VA = "0xA595D8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xA59610", Offset = "0xA59610", VA = "0xA59610")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA59758", Offset = "0xA59758", VA = "0xA59758")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA5970C", Offset = "0xA5970C", VA = "0xA5970C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA59854", Offset = "0xA59854", VA = "0xA59854")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA59898", Offset = "0xA59898", VA = "0xA59898")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xA59B58", Offset = "0xA59B58", VA = "0xA59B58")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000017")]
		public class LimbOrientation
		{
			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000076")]
			[Address(RVA = "0xA59E8C", Offset = "0xA59E8C", VA = "0xA59E8C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xA59BD4", Offset = "0xA59BD4", VA = "0xA59BD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xA59F00", Offset = "0xA59F00", VA = "0xA59F00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA59B60", Offset = "0xA59B60", VA = "0xA59B60")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000018")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000019")]
		public enum BoneType
		{
			[Token(Token = "0x40000B8")]
			Unassigned,
			[Token(Token = "0x40000B9")]
			Spine,
			[Token(Token = "0x40000BA")]
			Head,
			[Token(Token = "0x40000BB")]
			Arm,
			[Token(Token = "0x40000BC")]
			Leg,
			[Token(Token = "0x40000BD")]
			Tail,
			[Token(Token = "0x40000BE")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200001A")]
		public enum BoneSide
		{
			[Token(Token = "0x40000C0")]
			Center,
			[Token(Token = "0x40000C1")]
			Left,
			[Token(Token = "0x40000C2")]
			Right
		}

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA5A1B8", Offset = "0xA5A1B8", VA = "0xA5A1B8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA5A484", Offset = "0xA5A484", VA = "0xA5A484")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA5A6C0", Offset = "0xA5A6C0", VA = "0xA5A6C0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA5A734", Offset = "0xA5A734", VA = "0xA5A734")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA5A7C8", Offset = "0xA5A7C8", VA = "0xA5A7C8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA5A36C", Offset = "0xA5A36C", VA = "0xA5A36C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xA5A638", Offset = "0xA5A638", VA = "0xA5A638")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA5AF00", Offset = "0xA5AF00", VA = "0xA5AF00")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xA5AD58", Offset = "0xA5AD58", VA = "0xA5AD58")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA5AE2C", Offset = "0xA5AE2C", VA = "0xA5AE2C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xA5A9B0", Offset = "0xA5A9B0", VA = "0xA5A9B0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xA5AA4C", Offset = "0xA5AA4C", VA = "0xA5AA4C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA5AAE8", Offset = "0xA5AAE8", VA = "0xA5AAE8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xA5AB84", Offset = "0xA5AB84", VA = "0xA5AB84")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xA5AC20", Offset = "0xA5AC20", VA = "0xA5AC20")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xA5ACBC", Offset = "0xA5ACBC", VA = "0xA5ACBC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA5B0E8", Offset = "0xA5B0E8", VA = "0xA5B0E8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xA5A8DC", Offset = "0xA5A8DC", VA = "0xA5A8DC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xA5B064", Offset = "0xA5B064", VA = "0xA5B064")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xA5B148", Offset = "0xA5B148", VA = "0xA5B148")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA5B208", Offset = "0xA5B208", VA = "0xA5B208")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA5AFF0", Offset = "0xA5AFF0", VA = "0xA5AFF0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA5AF80", Offset = "0xA5AF80", VA = "0xA5AF80")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class BipedReferences
	{
		[Token(Token = "0x200001C")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000A8")]
				[Address(RVA = "0xA61CC0", Offset = "0xA61CC0", VA = "0xA61CC0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xA61CAC", Offset = "0xA61CAC", VA = "0xA61CAC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xA5DFF8", Offset = "0xA5DFF8", VA = "0xA5DFF8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xA5E354", Offset = "0xA5E354", VA = "0xA5E354")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA5E364", Offset = "0xA5E364", VA = "0xA5E364", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA5E6F0", Offset = "0xA5E6F0", VA = "0xA5E6F0", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA5EA80", Offset = "0xA5EA80", VA = "0xA5EA80")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xA5F1A4", Offset = "0xA5F1A4", VA = "0xA5F1A4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xA5ED14", Offset = "0xA5ED14", VA = "0xA5ED14")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xA5FA24", Offset = "0xA5FA24", VA = "0xA5FA24")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xA5FB10", Offset = "0xA5FB10", VA = "0xA5FB10")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xA6062C", Offset = "0xA6062C", VA = "0xA6062C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xA60438", Offset = "0xA60438", VA = "0xA60438")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xA601D8", Offset = "0xA601D8", VA = "0xA601D8")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xA5FBAC", Offset = "0xA5FBAC", VA = "0xA5FBAC")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA6052C", Offset = "0xA6052C", VA = "0xA6052C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA6070C", Offset = "0xA6070C", VA = "0xA6070C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA612B4", Offset = "0xA612B4", VA = "0xA612B4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA60D5C", Offset = "0xA60D5C", VA = "0xA60D5C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA61600", Offset = "0xA61600", VA = "0xA61600")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA610BC", Offset = "0xA610BC", VA = "0xA610BC")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA61608", Offset = "0xA61608", VA = "0xA61608")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA61610", Offset = "0xA61610", VA = "0xA61610")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA617D0", Offset = "0xA617D0", VA = "0xA617D0")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA61C44", Offset = "0xA61C44", VA = "0xA61C44")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA5EC94", Offset = "0xA5EC94", VA = "0xA5EC94")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xA61CC8", Offset = "0xA61CC8", VA = "0xA61CC8")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA61CD0", Offset = "0xA61CD0", VA = "0xA61CD0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA61DC8", Offset = "0xA61DC8", VA = "0xA61DC8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Hierarchy
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA61BC0", Offset = "0xA61BC0", VA = "0xA61BC0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA61AB4", Offset = "0xA61AB4", VA = "0xA61AB4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5FD10", VA = "0xA5FD10")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA60328", Offset = "0xA60328", VA = "0xA60328")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA5FF90", Offset = "0xA5FF90", VA = "0xA5FF90")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA61DD8", Offset = "0xA61DD8", VA = "0xA61DD8")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA5FE40", Offset = "0xA5FE40", VA = "0xA5FE40")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xA61ECC", Offset = "0xA61ECC", VA = "0xA61ECC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xA62238", Offset = "0xA62238", VA = "0xA62238")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA62030", Offset = "0xA62030", VA = "0xA62030")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA623C0", Offset = "0xA623C0", VA = "0xA623C0")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xA623C8", Offset = "0xA623C8", VA = "0xA623C8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xA62450", Offset = "0xA62450", VA = "0xA62450")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000DC")]
		None,
		[Token(Token = "0x40000DD")]
		InOutCubic,
		[Token(Token = "0x40000DE")]
		InOutQuintic,
		[Token(Token = "0x40000DF")]
		InOutSine,
		[Token(Token = "0x40000E0")]
		InQuintic,
		[Token(Token = "0x40000E1")]
		InQuartic,
		[Token(Token = "0x40000E2")]
		InCubic,
		[Token(Token = "0x40000E3")]
		InQuadratic,
		[Token(Token = "0x40000E4")]
		InElastic,
		[Token(Token = "0x40000E5")]
		InElasticSmall,
		[Token(Token = "0x40000E6")]
		InElasticBig,
		[Token(Token = "0x40000E7")]
		InSine,
		[Token(Token = "0x40000E8")]
		InBack,
		[Token(Token = "0x40000E9")]
		OutQuintic,
		[Token(Token = "0x40000EA")]
		OutQuartic,
		[Token(Token = "0x40000EB")]
		OutCubic,
		[Token(Token = "0x40000EC")]
		OutInCubic,
		[Token(Token = "0x40000ED")]
		OutInQuartic,
		[Token(Token = "0x40000EE")]
		OutElastic,
		[Token(Token = "0x40000EF")]
		OutElasticSmall,
		[Token(Token = "0x40000F0")]
		OutElasticBig,
		[Token(Token = "0x40000F1")]
		OutSine,
		[Token(Token = "0x40000F2")]
		OutBack,
		[Token(Token = "0x40000F3")]
		OutBackCubic,
		[Token(Token = "0x40000F4")]
		OutBackQuartic,
		[Token(Token = "0x40000F5")]
		BackInCubic,
		[Token(Token = "0x40000F6")]
		BackInQuartic
	}
	[Token(Token = "0x2000022")]
	public class Interp
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xA624DC", Offset = "0xA624DC", VA = "0xA624DC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xA62E64", Offset = "0xA62E64", VA = "0xA62E64")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xA62ED4", Offset = "0xA62ED4", VA = "0xA62ED4")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xA628DC", Offset = "0xA628DC", VA = "0xA628DC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xA628E8", Offset = "0xA628E8", VA = "0xA628E8")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xA6290C", Offset = "0xA6290C", VA = "0xA6290C")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA62948", Offset = "0xA62948", VA = "0xA62948")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA62960", Offset = "0xA62960", VA = "0xA62960")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA62974", Offset = "0xA62974", VA = "0xA62974")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA62988", Offset = "0xA62988", VA = "0xA62988")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xA62998", Offset = "0xA62998", VA = "0xA62998")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA629E0", Offset = "0xA629E0", VA = "0xA629E0")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xA62A18", Offset = "0xA62A18", VA = "0xA62A18")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xA62A40", Offset = "0xA62A40", VA = "0xA62A40")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA62F44", Offset = "0xA62F44", VA = "0xA62F44")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA62A74", Offset = "0xA62A74", VA = "0xA62A74")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA62A9C", Offset = "0xA62A9C", VA = "0xA62A9C")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA62ACC", Offset = "0xA62ACC", VA = "0xA62ACC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA62B00", Offset = "0xA62B00", VA = "0xA62B00")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA62B44", Offset = "0xA62B44", VA = "0xA62B44")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA62BA8", Offset = "0xA62BA8", VA = "0xA62BA8")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA62C0C", Offset = "0xA62C0C", VA = "0xA62C0C")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA62C60", Offset = "0xA62C60", VA = "0xA62C60")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA62CB4", Offset = "0xA62CB4", VA = "0xA62CB4")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA62CEC", Offset = "0xA62CEC", VA = "0xA62CEC")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA62D20", Offset = "0xA62D20", VA = "0xA62D20")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA62F78", Offset = "0xA62F78", VA = "0xA62F78")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA62D64", Offset = "0xA62D64", VA = "0xA62D64")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA62DF4", Offset = "0xA62DF4", VA = "0xA62DF4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA62E24", Offset = "0xA62E24", VA = "0xA62E24")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA63008", Offset = "0xA63008", VA = "0xA63008")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA63010", Offset = "0xA63010", VA = "0xA63010")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA6305C", Offset = "0xA6305C", VA = "0xA6305C")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA63118", Offset = "0xA63118", VA = "0xA63118")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA63070", Offset = "0xA63070", VA = "0xA63070")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA6312C", Offset = "0xA6312C", VA = "0xA6312C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA631BC", Offset = "0xA631BC", VA = "0xA631BC")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA631E4", Offset = "0xA631E4", VA = "0xA631E4")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA63230", Offset = "0xA63230", VA = "0xA63230")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA63298", Offset = "0xA63298", VA = "0xA63298")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA633F4", Offset = "0xA633F4", VA = "0xA633F4")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA6352C", Offset = "0xA6352C", VA = "0xA6352C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA63584", Offset = "0xA63584", VA = "0xA63584")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static bool hasInstance
		{
			[Token(Token = "0x60000E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public static T instance
		{
			[Token(Token = "0x60000E5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000E7")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public enum ShowIfMode
	{
		[Token(Token = "0x40000F9")]
		Disabled,
		[Token(Token = "0x40000FA")]
		Hidden
	}
	[Token(Token = "0x2000026")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x1700000F")]
		public string propName
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xA635A8", Offset = "0xA635A8", VA = "0xA635A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xA635B0", Offset = "0xA635B0", VA = "0xA635B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public object propValue
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xA635B8", Offset = "0xA635B8", VA = "0xA635B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xA635C0", Offset = "0xA635C0", VA = "0xA635C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public object otherPropValue
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xA635C8", Offset = "0xA635C8", VA = "0xA635C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xA635D0", Offset = "0xA635D0", VA = "0xA635D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool indent
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xA635D8", Offset = "0xA635D8", VA = "0xA635D8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xA635E0", Offset = "0xA635E0", VA = "0xA635E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xA635EC", Offset = "0xA635EC", VA = "0xA635EC")]
			[CompilerGenerated]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xA635F4", Offset = "0xA635F4", VA = "0xA635F4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA635FC", Offset = "0xA635FC", VA = "0xA635FC")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000027")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x17000014")]
		public float min
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xA6367C", Offset = "0xA6367C", VA = "0xA6367C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xA63684", Offset = "0xA63684", VA = "0xA63684")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float max
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xA6368C", Offset = "0xA6368C", VA = "0xA6368C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xA63694", Offset = "0xA63694", VA = "0xA63694")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA6369C", Offset = "0xA6369C", VA = "0xA6369C")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string color;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xA636C8", Offset = "0xA636C8", VA = "0xA636C8")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA63784", Offset = "0xA63784", VA = "0xA63784")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xA6384C", Offset = "0xA6384C", VA = "0xA6384C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA638D4", Offset = "0xA638D4", VA = "0xA638D4")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA63960", Offset = "0xA63960", VA = "0xA63960")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA639B8", Offset = "0xA639B8", VA = "0xA639B8")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA63AE8", Offset = "0xA63AE8", VA = "0xA63AE8")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA63C68", Offset = "0xA63C68", VA = "0xA63C68")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA63D44", Offset = "0xA63D44", VA = "0xA63D44")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA63E20", Offset = "0xA63E20", VA = "0xA63E20")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA64038", Offset = "0xA64038", VA = "0xA64038")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xA64084", Offset = "0xA64084", VA = "0xA64084")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xA640D0", Offset = "0xA640D0", VA = "0xA640D0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA641D4", Offset = "0xA641D4", VA = "0xA641D4")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA642D8", Offset = "0xA642D8", VA = "0xA642D8")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA643EC", Offset = "0xA643EC", VA = "0xA643EC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA64494", Offset = "0xA64494", VA = "0xA64494")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA645A0", Offset = "0xA645A0", VA = "0xA645A0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA64708", Offset = "0xA64708", VA = "0xA64708")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA648EC", Offset = "0xA648EC", VA = "0xA648EC")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA649BC", Offset = "0xA649BC", VA = "0xA649BC")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA64B40", Offset = "0xA64B40", VA = "0xA64B40")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA64C4C", Offset = "0xA64C4C", VA = "0xA64C4C")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA64CA4", Offset = "0xA64CA4", VA = "0xA64CA4")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA64EC8", Offset = "0xA64EC8", VA = "0xA64EC8")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200002B")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000016")]
		public static T instance
		{
			[Token(Token = "0x6000111")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000113")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000114")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000017")]
		private bool animatePhysics
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xA650EC", Offset = "0xA650EC", VA = "0xA650EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private bool isAnimated
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xA653E8", Offset = "0xA653E8", VA = "0xA653E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA64FD0", Offset = "0xA64FD0", VA = "0xA64FD0")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA65064", Offset = "0xA65064", VA = "0xA65064", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA65068", Offset = "0xA65068", VA = "0xA65068", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA6506C", Offset = "0xA6506C", VA = "0xA6506C", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA65070", Offset = "0xA65070", VA = "0xA65070")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA650E8", Offset = "0xA650E8", VA = "0xA650E8")]
		private void Start()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA65098", Offset = "0xA65098", VA = "0xA65098")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA653AC", Offset = "0xA653AC", VA = "0xA653AC")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA651B8", Offset = "0xA651B8", VA = "0xA651B8")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA65480", Offset = "0xA65480", VA = "0xA65480")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA654CC", Offset = "0xA654CC", VA = "0xA654CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA65518", Offset = "0xA65518", VA = "0xA65518")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA65550", Offset = "0xA65550", VA = "0xA65550")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xA65560", Offset = "0xA65560", VA = "0xA65560")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xA65614", Offset = "0xA65614", VA = "0xA65614")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xA656C8", Offset = "0xA656C8", VA = "0xA656C8")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA6577C", Offset = "0xA6577C", VA = "0xA6577C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA65784", Offset = "0xA65784", VA = "0xA65784")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA6578C", Offset = "0xA6578C", VA = "0xA6578C")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA6581C", Offset = "0xA6581C", VA = "0xA6581C")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA658B0", Offset = "0xA658B0", VA = "0xA658B0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA65960", Offset = "0xA65960", VA = "0xA65960")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002F")]
	public static class V3Tools
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA659BC", Offset = "0xA659BC", VA = "0xA659BC")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA659DC", Offset = "0xA659DC", VA = "0xA659DC")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA65AB0", Offset = "0xA65AB0", VA = "0xA65AB0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA65B68", Offset = "0xA65B68", VA = "0xA65B68")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA65BC4", Offset = "0xA65BC4", VA = "0xA65BC4")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA65C20", Offset = "0xA65C20", VA = "0xA65C20")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA65D38", Offset = "0xA65D38", VA = "0xA65D38")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA65D94", Offset = "0xA65D94", VA = "0xA65D94")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA65DCC", Offset = "0xA65DCC", VA = "0xA65DCC")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA65F9C", Offset = "0xA65F9C", VA = "0xA65F9C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA661A0", Offset = "0xA661A0", VA = "0xA661A0")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA66318", Offset = "0xA66318", VA = "0xA66318")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA66548", Offset = "0xA66548", VA = "0xA66548")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA66798", Offset = "0xA66798", VA = "0xA66798")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA669F0", Offset = "0xA669F0", VA = "0xA669F0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA66B9C", Offset = "0xA66B9C", VA = "0xA66B9C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA66D94", Offset = "0xA66D94", VA = "0xA66D94")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA66E10", Offset = "0xA66E10", VA = "0xA66E10")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA66EA0", Offset = "0xA66EA0", VA = "0xA66EA0")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA66F38", Offset = "0xA66F38", VA = "0xA66F38")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xA66F28", Offset = "0xA66F28", VA = "0xA66F28")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000030")]
	public static class Warning
	{
		[Token(Token = "0x2000031")]
		public delegate void Logger(string message);

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xA66FB4", Offset = "0xA66FB4", VA = "0xA66FB4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA5F970", Offset = "0xA5F970", VA = "0xA5F970")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000032")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xA67170", Offset = "0xA67170", VA = "0xA67170")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA671B4", Offset = "0xA671B4", VA = "0xA671B4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA671F8", Offset = "0xA671F8", VA = "0xA671F8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA6723C", Offset = "0xA6723C", VA = "0xA6723C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA67280", Offset = "0xA67280", VA = "0xA67280")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA67318", Offset = "0xA67318", VA = "0xA67318")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA67334", Offset = "0xA67334", VA = "0xA67334")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA67360", Offset = "0xA67360", VA = "0xA67360")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA6738C", Offset = "0xA6738C", VA = "0xA6738C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA673C8", Offset = "0xA673C8", VA = "0xA673C8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA67408", Offset = "0xA67408", VA = "0xA67408")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA67428", Offset = "0xA67428", VA = "0xA67428")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA67448", Offset = "0xA67448", VA = "0xA67448")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA6746C", Offset = "0xA6746C", VA = "0xA6746C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA67494", Offset = "0xA67494", VA = "0xA67494")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA674BC", Offset = "0xA674BC", VA = "0xA674BC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA6729C", Offset = "0xA6729C", VA = "0xA6729C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA674E0", Offset = "0xA674E0", VA = "0xA674E0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA674EC", Offset = "0xA674EC", VA = "0xA674EC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA674F8", Offset = "0xA674F8", VA = "0xA674F8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA677AC", Offset = "0xA677AC", VA = "0xA677AC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA67848", Offset = "0xA67848", VA = "0xA67848", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA67B6C", Offset = "0xA67B6C", VA = "0xA67B6C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA67FD8", Offset = "0xA67FD8", VA = "0xA67FD8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA67FFC", Offset = "0xA67FFC", VA = "0xA67FFC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000019")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xA67634", Offset = "0xA67634", VA = "0xA67634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xA68298", Offset = "0xA68298", VA = "0xA68298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA679F8", Offset = "0xA679F8", VA = "0xA679F8")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA680AC", Offset = "0xA680AC", VA = "0xA680AC")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public abstract class Constraint
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700001B")]
		public bool isValid
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xA684C0", Offset = "0xA684C0", VA = "0xA684C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000166")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA68520", Offset = "0xA68520", VA = "0xA68520")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xA68528", Offset = "0xA68528", VA = "0xA68528", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA685C0", Offset = "0xA685C0", VA = "0xA685C0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA685C8", Offset = "0xA685C8", VA = "0xA685C8")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		private bool positionChanged
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xA686FC", Offset = "0xA686FC", VA = "0xA686FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA685F8", Offset = "0xA685F8", VA = "0xA685F8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA68758", Offset = "0xA68758", VA = "0xA68758")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA68760", Offset = "0xA68760", VA = "0xA68760")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xA68790", Offset = "0xA68790", VA = "0xA68790", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA6880C", Offset = "0xA6880C", VA = "0xA6880C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA68814", Offset = "0xA68814", VA = "0xA68814")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700001D")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xA68948", Offset = "0xA68948", VA = "0xA68948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA68844", Offset = "0xA68844", VA = "0xA68844", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA689A0", Offset = "0xA689A0", VA = "0xA689A0")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA689A8", Offset = "0xA689A8", VA = "0xA689A8")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class Constraints
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xA689D8", Offset = "0xA689D8", VA = "0xA689D8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA67B18", Offset = "0xA67B18", VA = "0xA67B18")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA67CE0", Offset = "0xA67CE0", VA = "0xA67CE0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA684B8", Offset = "0xA684B8", VA = "0xA684B8")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200003B")]
		public enum DOF
		{
			[Token(Token = "0x4000144")]
			One,
			[Token(Token = "0x4000145")]
			Three
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x1700001E")]
		public bool initiated
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xA68A38", Offset = "0xA68A38", VA = "0xA68A38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xA68A40", Offset = "0xA68A40", VA = "0xA68A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xA68A4C", Offset = "0xA68A4C", VA = "0xA68A4C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xA68A6C", Offset = "0xA68A6C", VA = "0xA68A6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xA68A8C", Offset = "0xA68A8C", VA = "0xA68A8C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xA68AAC", Offset = "0xA68AAC", VA = "0xA68AAC")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA68ACC", Offset = "0xA68ACC", VA = "0xA68ACC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA68BC4", Offset = "0xA68BC4", VA = "0xA68BC4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA69248", Offset = "0xA69248", VA = "0xA69248")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA69314", Offset = "0xA69314", VA = "0xA69314")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA693CC", Offset = "0xA693CC", VA = "0xA693CC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA6996C", Offset = "0xA6996C", VA = "0xA6996C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000021")]
		public bool initiated
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xA6A97C", Offset = "0xA6A97C", VA = "0xA6A97C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xA6A984", Offset = "0xA6A984", VA = "0xA6A984")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA6A990", Offset = "0xA6A990", VA = "0xA6A990")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA6AA08", Offset = "0xA6AA08", VA = "0xA6AA08")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA6AD68", Offset = "0xA6AD68", VA = "0xA6AD68")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA6AF24", Offset = "0xA6AF24", VA = "0xA6AF24")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA6AC78", Offset = "0xA6AC78", VA = "0xA6AC78")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA6B0A4", Offset = "0xA6B0A4", VA = "0xA6B0A4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA6B154", Offset = "0xA6B154", VA = "0xA6B154")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA6B1BC", Offset = "0xA6B1BC", VA = "0xA6B1BC")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA6B228", Offset = "0xA6B228", VA = "0xA6B228")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA6B288", Offset = "0xA6B288", VA = "0xA6B288", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA6B28C", Offset = "0xA6B28C", VA = "0xA6B28C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA6B2A0", Offset = "0xA6B2A0", VA = "0xA6B2A0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderDelegate OnPostIK;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xA6B30C", Offset = "0xA6B30C", VA = "0xA6B30C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xA6B314", Offset = "0xA6B314", VA = "0xA6B314")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000194")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA6B320", Offset = "0xA6B320", VA = "0xA6B320")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA6B5D0", Offset = "0xA6B5D0", VA = "0xA6B5D0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA6B3E4", Offset = "0xA6B3E4", VA = "0xA6B3E4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA6B5F8", Offset = "0xA6B5F8", VA = "0xA6B5F8")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600019C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA6B76C", Offset = "0xA6B76C", VA = "0xA6B76C")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float lastWeight;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xA6BA70", Offset = "0xA6BA70", VA = "0xA6BA70", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xA6BAB4", Offset = "0xA6BAB4", VA = "0xA6BAB4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA6BAF8", Offset = "0xA6BAF8", VA = "0xA6BAF8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA6BBD8", Offset = "0xA6BBD8", VA = "0xA6BBD8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA6BC78", Offset = "0xA6BC78", VA = "0xA6BC78")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA6BCCC", Offset = "0xA6BCCC", VA = "0xA6BCCC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA6C2EC", Offset = "0xA6C2EC", VA = "0xA6C2EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA6C32C", Offset = "0xA6C32C", VA = "0xA6C32C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA6C9A4", Offset = "0xA6C9A4", VA = "0xA6C9A4")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA6CACC", Offset = "0xA6CACC", VA = "0xA6CACC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA6CCC8", Offset = "0xA6CCC8", VA = "0xA6CCC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA6CEA0", Offset = "0xA6CEA0", VA = "0xA6CEA0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000041")]
		public class SpineEffector
		{
			[Token(Token = "0x400015F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0xA6DD34", Offset = "0xA6DD34", VA = "0xA6DD34")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xA6DD44", Offset = "0xA6DD44", VA = "0xA6DD44")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SpineEffector[] spine;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] feet;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 spineOffset;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool firstSolve;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xA6CF44", Offset = "0xA6CF44", VA = "0xA6CF44")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA6CF88", Offset = "0xA6CF88", VA = "0xA6CF88", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA6CFCC", Offset = "0xA6CFCC", VA = "0xA6CFCC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA6D010", Offset = "0xA6D010", VA = "0xA6D010", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA6D078", Offset = "0xA6D078", VA = "0xA6D078")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA6D100", Offset = "0xA6D100", VA = "0xA6D100")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA6D440", Offset = "0xA6D440", VA = "0xA6D440")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA6D44C", Offset = "0xA6D44C", VA = "0xA6D44C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA6D15C", Offset = "0xA6D15C", VA = "0xA6D15C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA6D458", Offset = "0xA6D458", VA = "0xA6D458")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA6D7C8", Offset = "0xA6D7C8", VA = "0xA6D7C8")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA6D94C", Offset = "0xA6D94C", VA = "0xA6D94C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA6DAAC", Offset = "0xA6DAAC", VA = "0xA6DAAC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA6DAC8", Offset = "0xA6DAC8", VA = "0xA6DAC8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA6DC90", Offset = "0xA6DC90", VA = "0xA6DC90")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IK[] legs;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] feet;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int solvedFeet;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool solved;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastWeight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xA6DD88", Offset = "0xA6DD88", VA = "0xA6DD88", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA6DDCC", Offset = "0xA6DDCC", VA = "0xA6DDCC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA6DE10", Offset = "0xA6DE10", VA = "0xA6DE10", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA6E000", Offset = "0xA6E000", VA = "0xA6E000")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA6E220", Offset = "0xA6E220", VA = "0xA6E220")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA6E300", Offset = "0xA6E300", VA = "0xA6E300")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA6E9EC", Offset = "0xA6E9EC", VA = "0xA6E9EC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA6EEA4", Offset = "0xA6EEA4", VA = "0xA6EEA4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA6F050", Offset = "0xA6F050", VA = "0xA6F050")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA6F3D8", Offset = "0xA6F3D8", VA = "0xA6F3D8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA6F5DC", Offset = "0xA6F5DC", VA = "0xA6F5DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA6F804", Offset = "0xA6F804", VA = "0xA6F804")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000044")]
		public struct Foot
		{
			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xA7054C", Offset = "0xA7054C", VA = "0xA7054C")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("The head (optional, if you intend to maintain its rotation).")]
		public Transform head;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] legs;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IK[] forelegs;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Foot[] feet;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int solvedFeet;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool solved;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float angle;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform forefeetRoot;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Quaternion headRotation;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastWeight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xA6F8A8", Offset = "0xA6F8A8", VA = "0xA6F8A8", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA6F8EC", Offset = "0xA6F8EC", VA = "0xA6F8EC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA6F930", Offset = "0xA6F930", VA = "0xA6F930", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA6FAAC", Offset = "0xA6FAAC", VA = "0xA6FAAC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA6FBB0", Offset = "0xA6FBB0", VA = "0xA6FBB0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA6FDA8", Offset = "0xA6FDA8", VA = "0xA6FDA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA6FE0C", Offset = "0xA6FE0C", VA = "0xA6FE0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA6FE64", Offset = "0xA6FE64", VA = "0xA6FE64")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA701B0", Offset = "0xA701B0", VA = "0xA701B0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA705AC", Offset = "0xA705AC", VA = "0xA705AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA7063C", Offset = "0xA7063C", VA = "0xA7063C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA70A8C", Offset = "0xA70A8C", VA = "0xA70A8C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA71150", Offset = "0xA71150", VA = "0xA71150")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA71408", Offset = "0xA71408", VA = "0xA71408")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA7153C", Offset = "0xA7153C", VA = "0xA7153C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA71834", Offset = "0xA71834", VA = "0xA71834")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA71864", Offset = "0xA71864", VA = "0xA71864")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA71A84", Offset = "0xA71A84", VA = "0xA71A84")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000046")]
		public enum Quality
		{
			[Token(Token = "0x40001AD")]
			Fastest,
			[Token(Token = "0x40001AE")]
			Simple,
			[Token(Token = "0x40001AF")]
			Best
		}

		[Token(Token = "0x2000047")]
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x2000048")]
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x2000049")]
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x200004A")]
		public class Leg
		{
			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700002B")]
			public bool isGrounded
			{
				[Token(Token = "0x6000202")]
				[Address(RVA = "0xA73900", Offset = "0xA73900", VA = "0xA73900")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000203")]
				[Address(RVA = "0xA73908", Offset = "0xA73908", VA = "0xA73908")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0xA73914", Offset = "0xA73914", VA = "0xA73914")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000205")]
				[Address(RVA = "0xA73920", Offset = "0xA73920", VA = "0xA73920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool initiated
			{
				[Token(Token = "0x6000206")]
				[Address(RVA = "0xA7392C", Offset = "0xA7392C", VA = "0xA7392C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000207")]
				[Address(RVA = "0xA73934", Offset = "0xA73934", VA = "0xA73934")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0xA73940", Offset = "0xA73940", VA = "0xA73940")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000209")]
				[Address(RVA = "0xA73948", Offset = "0xA73948", VA = "0xA73948")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public Vector3 velocity
			{
				[Token(Token = "0x600020A")]
				[Address(RVA = "0xA73950", Offset = "0xA73950", VA = "0xA73950")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600020B")]
				[Address(RVA = "0xA7395C", Offset = "0xA7395C", VA = "0xA7395C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public Transform transform
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0xA73968", Offset = "0xA73968", VA = "0xA73968")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600020D")]
				[Address(RVA = "0xA73970", Offset = "0xA73970", VA = "0xA73970")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public float IKOffset
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0xA73978", Offset = "0xA73978", VA = "0xA73978")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600020F")]
				[Address(RVA = "0xA73980", Offset = "0xA73980", VA = "0xA73980")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0xA73988", Offset = "0xA73988", VA = "0xA73988")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000211")]
				[Address(RVA = "0xA739A0", Offset = "0xA739A0", VA = "0xA739A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0xA739C0", Offset = "0xA739C0", VA = "0xA739C0")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000213")]
				[Address(RVA = "0xA739D8", Offset = "0xA739D8", VA = "0xA739D8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0xA739F8", Offset = "0xA739F8", VA = "0xA739F8")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000035")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0xA742B4", Offset = "0xA742B4", VA = "0xA742B4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000036")]
			private float rootYOffset
			{
				[Token(Token = "0x6000223")]
				[Address(RVA = "0xA74404", Offset = "0xA74404", VA = "0xA74404")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0xA73A40", Offset = "0xA73A40", VA = "0xA73A40")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0xA7207C", Offset = "0xA7207C", VA = "0xA7207C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0xA73A54", Offset = "0xA73A54", VA = "0xA73A54")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0xA72D90", Offset = "0xA72D90", VA = "0xA72D90")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xA72190", Offset = "0xA72190", VA = "0xA72190")]
			public void Process()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xA73EE0", Offset = "0xA73EE0", VA = "0xA73EE0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0xA73A94", Offset = "0xA73A94", VA = "0xA73A94")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xA74348", Offset = "0xA74348", VA = "0xA74348")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0xA73D48", Offset = "0xA73D48", VA = "0xA73D48")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0xA73DC8", Offset = "0xA73DC8", VA = "0xA73DC8")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xA743B4", Offset = "0xA743B4", VA = "0xA743B4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0xA742E8", Offset = "0xA742E8", VA = "0xA742E8")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0xA74490", Offset = "0xA74490", VA = "0xA74490")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0xA71FDC", Offset = "0xA71FDC", VA = "0xA71FDC")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200004B")]
		public class Pelvis
		{
			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000037")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000225")]
				[Address(RVA = "0xA74640", Offset = "0xA74640", VA = "0xA74640")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000226")]
				[Address(RVA = "0xA7464C", Offset = "0xA7464C", VA = "0xA7464C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000038")]
			public float heightOffset
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0xA74658", Offset = "0xA74658", VA = "0xA74658")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000228")]
				[Address(RVA = "0xA74660", Offset = "0xA74660", VA = "0xA74660")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0xA72154", Offset = "0xA72154", VA = "0xA72154")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0xA72CFC", Offset = "0xA72CFC", VA = "0xA72CFC")]
			public void Reset()
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0xA74668", Offset = "0xA74668", VA = "0xA74668")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0xA72B10", Offset = "0xA72B10", VA = "0xA72B10")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0xA72074", Offset = "0xA72074", VA = "0xA72074")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public OnRaycastDelegate Raycast;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OnCapsuleCastDelegate CapsuleCast;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public OnSphereCastDelegate SphereCast;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool initiated;

		[Token(Token = "0x17000023")]
		public Leg[] legs
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0xA71B88", Offset = "0xA71B88", VA = "0xA71B88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xA71B90", Offset = "0xA71B90", VA = "0xA71B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xA71B98", Offset = "0xA71B98", VA = "0xA71B98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xA71BA0", Offset = "0xA71BA0", VA = "0xA71BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool isGrounded
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xA71BA8", Offset = "0xA71BA8", VA = "0xA71BA8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xA71BB0", Offset = "0xA71BB0", VA = "0xA71BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform root
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xA71BBC", Offset = "0xA71BBC", VA = "0xA71BBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xA71BC4", Offset = "0xA71BC4", VA = "0xA71BC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xA71BCC", Offset = "0xA71BCC", VA = "0xA71BCC")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xA71BE4", Offset = "0xA71BE4", VA = "0xA71BE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xA71C04", Offset = "0xA71C04", VA = "0xA71C04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3 up
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xA6CA64", Offset = "0xA6CA64", VA = "0xA6CA64")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002A")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xA72E24", Offset = "0xA72E24", VA = "0xA72E24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA71C4C", Offset = "0xA71C4C", VA = "0xA71C4C")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA71ED4", Offset = "0xA71ED4", VA = "0xA71ED4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA6C028", Offset = "0xA6C028", VA = "0xA6C028")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA6C7A4", Offset = "0xA6C7A4", VA = "0xA6C7A4")]
		public void Update()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA6E874", Offset = "0xA6E874", VA = "0xA6E874")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA6BB60", Offset = "0xA6BB60", VA = "0xA6BB60")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA72178", Offset = "0xA72178", VA = "0xA72178")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA72ED8", Offset = "0xA72ED8", VA = "0xA72ED8")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA72F5C", Offset = "0xA72F5C", VA = "0xA72F5C")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA730B0", Offset = "0xA730B0", VA = "0xA730B0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA6B7E4", Offset = "0xA6B7E4", VA = "0xA6B7E4")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xA746BC", Offset = "0xA746BC", VA = "0xA746BC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA74700", Offset = "0xA74700", VA = "0xA74700", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA74744", Offset = "0xA74744", VA = "0xA74744")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA74788", Offset = "0xA74788", VA = "0xA74788")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA747CC", Offset = "0xA747CC", VA = "0xA747CC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA74810", Offset = "0xA74810", VA = "0xA74810", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA74818", Offset = "0xA74818", VA = "0xA74818")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xA74894", Offset = "0xA74894", VA = "0xA74894", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA748D8", Offset = "0xA748D8", VA = "0xA748D8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA7491C", Offset = "0xA7491C", VA = "0xA7491C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA74960", Offset = "0xA74960", VA = "0xA74960")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA749A4", Offset = "0xA749A4", VA = "0xA749A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA749AC", Offset = "0xA749AC", VA = "0xA749AC")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xA74A20", Offset = "0xA74A20", VA = "0xA74A20", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA74A64", Offset = "0xA74A64", VA = "0xA74A64", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA74AA8", Offset = "0xA74AA8", VA = "0xA74AA8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA74AEC", Offset = "0xA74AEC", VA = "0xA74AEC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA74B30", Offset = "0xA74B30", VA = "0xA74B30", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA74B38", Offset = "0xA74B38", VA = "0xA74B38")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA74BAC", Offset = "0xA74BAC", VA = "0xA74BAC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA74BF0", Offset = "0xA74BF0", VA = "0xA74BF0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA74C34", Offset = "0xA74C34", VA = "0xA74C34")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA74C78", Offset = "0xA74C78", VA = "0xA74C78")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA74CBC", Offset = "0xA74CBC", VA = "0xA74CBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA74CC4", Offset = "0xA74CC4", VA = "0xA74CC4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xA74D38", Offset = "0xA74D38", VA = "0xA74D38", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA74D7C", Offset = "0xA74D7C", VA = "0xA74D7C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA74DC0", Offset = "0xA74DC0", VA = "0xA74DC0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA74E04", Offset = "0xA74E04", VA = "0xA74E04")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA74E48", Offset = "0xA74E48", VA = "0xA74E48", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA74E50", Offset = "0xA74E50", VA = "0xA74E50")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xA74EC4", Offset = "0xA74EC4", VA = "0xA74EC4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA74F08", Offset = "0xA74F08", VA = "0xA74F08", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA74F4C", Offset = "0xA74F4C", VA = "0xA74F4C")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA74F90", Offset = "0xA74F90", VA = "0xA74F90")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA74FD4", Offset = "0xA74FD4", VA = "0xA74FD4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA75018", Offset = "0xA75018", VA = "0xA75018")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA7505C", Offset = "0xA7505C", VA = "0xA7505C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA7509C", Offset = "0xA7509C", VA = "0xA7509C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA750A4", Offset = "0xA750A4", VA = "0xA750A4")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA75274", Offset = "0xA75274", VA = "0xA75274")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA75730", Offset = "0xA75730", VA = "0xA75730")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA75750", Offset = "0xA75750", VA = "0xA75750")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA75840", Offset = "0xA75840", VA = "0xA75840")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x600025A")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA758F0", Offset = "0xA758F0", VA = "0xA758F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA75968", Offset = "0xA75968", VA = "0xA75968", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA759D8", Offset = "0xA759D8", VA = "0xA759D8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600025E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600025F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA7488C", Offset = "0xA7488C", VA = "0xA7488C")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000039")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0xA75A28", Offset = "0xA75A28", VA = "0xA75A28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA75AB4", Offset = "0xA75AB4", VA = "0xA75AB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA75B18", Offset = "0xA75B18", VA = "0xA75B18")]
		private void Update()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA75BB8", Offset = "0xA75BB8", VA = "0xA75BB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA75BE4", Offset = "0xA75BE4", VA = "0xA75BE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA75B3C", Offset = "0xA75B3C", VA = "0xA75B3C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA75C68", Offset = "0xA75C68", VA = "0xA75C68")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xA75C70", Offset = "0xA75C70", VA = "0xA75C70", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA75CB4", Offset = "0xA75CB4", VA = "0xA75CB4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA75CF8", Offset = "0xA75CF8", VA = "0xA75CF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA75D3C", Offset = "0xA75D3C", VA = "0xA75D3C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA75D80", Offset = "0xA75D80", VA = "0xA75D80", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xA75D88", Offset = "0xA75D88", VA = "0xA75D88")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xA75DFC", Offset = "0xA75DFC", VA = "0xA75DFC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xA75E40", Offset = "0xA75E40", VA = "0xA75E40", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xA75E84", Offset = "0xA75E84", VA = "0xA75E84")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA75EC8", Offset = "0xA75EC8", VA = "0xA75EC8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xA75F0C", Offset = "0xA75F0C", VA = "0xA75F0C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA75F14", Offset = "0xA75F14", VA = "0xA75F14")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA75F88", Offset = "0xA75F88", VA = "0xA75F88", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA75FCC", Offset = "0xA75FCC", VA = "0xA75FCC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA76010", Offset = "0xA76010", VA = "0xA76010")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA76054", Offset = "0xA76054", VA = "0xA76054")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA76098", Offset = "0xA76098", VA = "0xA76098", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA760A0", Offset = "0xA760A0", VA = "0xA760A0")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA76114", Offset = "0xA76114", VA = "0xA76114", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA76158", Offset = "0xA76158", VA = "0xA76158", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA7619C", Offset = "0xA7619C", VA = "0xA7619C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA761E0", Offset = "0xA761E0", VA = "0xA761E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA76224", Offset = "0xA76224", VA = "0xA76224", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA7622C", Offset = "0xA7622C", VA = "0xA7622C")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000059")]
		public class References
		{
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[LargeHeader("Spine")]
			public Transform pelvis;

			[Token(Token = "0x40001DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			[LargeHeader("Left Arm")]
			public Transform leftShoulder;

			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftForearm;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftHand;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			[LargeHeader("Right Arm")]
			public Transform rightShoulder;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightForearm;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightHand;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[LargeHeader("Left Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[LargeHeader("Right Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x1700003A")]
			public bool isFilled
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0xA76C7C", Offset = "0xA76C7C", VA = "0xA76C7C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003B")]
			public bool isEmpty
			{
				[Token(Token = "0x600028D")]
				[Address(RVA = "0xA768C0", Offset = "0xA768C0", VA = "0xA768C0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA773B8", Offset = "0xA773B8", VA = "0xA773B8")]
			public References()
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA773C0", Offset = "0xA773C0", VA = "0xA773C0")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0xA775B0", Offset = "0xA775B0", VA = "0xA775B0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0xA76388", Offset = "0xA76388", VA = "0xA76388")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA762A0", Offset = "0xA762A0", VA = "0xA762A0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA762E4", Offset = "0xA762E4", VA = "0xA762E4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA76328", Offset = "0xA76328", VA = "0xA76328")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA7636C", Offset = "0xA7636C", VA = "0xA7636C")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA76824", Offset = "0xA76824", VA = "0xA76824")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA7684C", Offset = "0xA7684C", VA = "0xA7684C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA76854", Offset = "0xA76854", VA = "0xA76854", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xA77178", Offset = "0xA77178", VA = "0xA77178", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA77308", Offset = "0xA77308", VA = "0xA77308")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xA77AF4", Offset = "0xA77AF4", VA = "0xA77AF4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA77BC4", Offset = "0xA77BC4", VA = "0xA77BC4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA77BE4", Offset = "0xA77BE4", VA = "0xA77BE4")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA77E38", Offset = "0xA77E38", VA = "0xA77E38")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xA77CA4", Offset = "0xA77CA4", VA = "0xA77CA4")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA77F1C", Offset = "0xA77F1C", VA = "0xA77F1C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xA77F88", Offset = "0xA77F88", VA = "0xA77F88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA78438", Offset = "0xA78438", VA = "0xA78438")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA785CC", Offset = "0xA785CC", VA = "0xA785CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA786F8", Offset = "0xA786F8", VA = "0xA786F8")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005D")]
		public class BendBone
		{
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xA7B95C", Offset = "0xA7B95C", VA = "0xA7B95C")]
			public BendBone()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xA7B9BC", Offset = "0xA7B9BC", VA = "0xA7B9BC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xA78FF0", Offset = "0xA78FF0", VA = "0xA78FF0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA793C0", Offset = "0xA793C0", VA = "0xA793C0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		public float CCDWeight;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[LargeHeader("Stretching")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xA78700", Offset = "0xA78700", VA = "0xA78700")]
		private void Start()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA78B40", Offset = "0xA78B40", VA = "0xA78B40")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA7901C", Offset = "0xA7901C", VA = "0xA7901C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA793E8", Offset = "0xA793E8", VA = "0xA793E8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA79CE4", Offset = "0xA79CE4", VA = "0xA79CE4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xA7A0DC", Offset = "0xA7A0DC", VA = "0xA7A0DC")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA7A4EC", Offset = "0xA7A4EC", VA = "0xA7A4EC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA7AE6C", Offset = "0xA7AE6C", VA = "0xA7AE6C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA79A28", Offset = "0xA79A28", VA = "0xA79A28")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA7B0A8", Offset = "0xA7B0A8", VA = "0xA7B0A8")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA7AD84", Offset = "0xA7AD84", VA = "0xA7AD84")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA7AC84", Offset = "0xA7AC84", VA = "0xA7AC84")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA7B3AC", Offset = "0xA7B3AC", VA = "0xA7B3AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA7B748", Offset = "0xA7B748", VA = "0xA7B748")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200005F")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700003C")]
			public float nominalDistance
			{
				[Token(Token = "0x60002BF")]
				[Address(RVA = "0xA7DD28", Offset = "0xA7DD28", VA = "0xA7DD28")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002C0")]
				[Address(RVA = "0xA7DD30", Offset = "0xA7DD30", VA = "0xA7DD30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public bool isRigid
			{
				[Token(Token = "0x60002C1")]
				[Address(RVA = "0xA7DD38", Offset = "0xA7DD38", VA = "0xA7DD38")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0xA7DD40", Offset = "0xA7DD40", VA = "0xA7DD40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA7DD4C", Offset = "0xA7DD4C", VA = "0xA7DD4C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xA7DDA8", Offset = "0xA7DDA8", VA = "0xA7DDA8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xA7DF08", Offset = "0xA7DF08", VA = "0xA7DF08")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xA7E0EC", Offset = "0xA7E0EC", VA = "0xA7E0EC")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public enum Smoothing
		{
			[Token(Token = "0x4000251")]
			None,
			[Token(Token = "0x4000252")]
			Exponential,
			[Token(Token = "0x4000253")]
			Cubic
		}

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000245")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xA7BA44", Offset = "0xA7BA44", VA = "0xA7BA44")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA7BB74", Offset = "0xA7BB74", VA = "0xA7BB74")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA7BCE8", Offset = "0xA7BCE8", VA = "0xA7BCE8")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA7BE18", Offset = "0xA7BE18", VA = "0xA7BE18")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA7BED4", Offset = "0xA7BED4", VA = "0xA7BED4")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA7BFF0", Offset = "0xA7BFF0", VA = "0xA7BFF0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA7C740", Offset = "0xA7C740", VA = "0xA7C740")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA7C178", Offset = "0xA7C178", VA = "0xA7C178")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA7CB28", Offset = "0xA7CB28", VA = "0xA7CB28")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA7CDBC", Offset = "0xA7CDBC", VA = "0xA7CDBC")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA7D08C", Offset = "0xA7D08C", VA = "0xA7D08C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA7D428", Offset = "0xA7D428", VA = "0xA7D428")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA7D924", Offset = "0xA7D924", VA = "0xA7D924")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA7DB24", Offset = "0xA7DB24", VA = "0xA7DB24")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA7D810", Offset = "0xA7D810", VA = "0xA7D810")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA7D2C8", Offset = "0xA7D2C8", VA = "0xA7D2C8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA7D7A8", Offset = "0xA7D7A8", VA = "0xA7D7A8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA7DC00", Offset = "0xA7DC00", VA = "0xA7DC00")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA7D6D4", Offset = "0xA7D6D4", VA = "0xA7D6D4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA7DA28", Offset = "0xA7DA28", VA = "0xA7DA28")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700003E")]
		public bool initiated
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0xA7E500", Offset = "0xA7E500", VA = "0xA7E500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xA7E508", Offset = "0xA7E508", VA = "0xA7E508")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA7E328", Offset = "0xA7E328", VA = "0xA7E328")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA7E514", Offset = "0xA7E514", VA = "0xA7E514")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA7E580", Offset = "0xA7E580", VA = "0xA7E580")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA7E614", Offset = "0xA7E614", VA = "0xA7E614")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA7E658", Offset = "0xA7E658", VA = "0xA7E658")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA7EA60", Offset = "0xA7EA60", VA = "0xA7EA60")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA7EDB4", Offset = "0xA7EDB4", VA = "0xA7EDB4")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA7F17C", Offset = "0xA7F17C", VA = "0xA7F17C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA7E928", Offset = "0xA7E928", VA = "0xA7E928")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA7E9C4", Offset = "0xA7E9C4", VA = "0xA7E9C4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class IKEffector
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700003F")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xA7F840", Offset = "0xA7F840", VA = "0xA7F840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xA7F848", Offset = "0xA7F848", VA = "0xA7F848")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA7F7E4", Offset = "0xA7F7E4", VA = "0xA7F7E4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xA7F854", Offset = "0xA7F854", VA = "0xA7F854")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA7F8D8", Offset = "0xA7F8D8", VA = "0xA7F8D8")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA7FAA8", Offset = "0xA7FAA8", VA = "0xA7FAA8")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA7FCB4", Offset = "0xA7FCB4", VA = "0xA7FCB4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA7FFBC", Offset = "0xA7FFBC", VA = "0xA7FFBC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA80280", Offset = "0xA80280", VA = "0xA80280")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA80398", Offset = "0xA80398", VA = "0xA80398")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA80434", Offset = "0xA80434", VA = "0xA80434")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA80AD4", Offset = "0xA80AD4", VA = "0xA80AD4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA80B2C", Offset = "0xA80B2C", VA = "0xA80B2C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA80CF4", Offset = "0xA80CF4", VA = "0xA80CF4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA80F3C", Offset = "0xA80F3C", VA = "0xA80F3C")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000064")]
		public class BoneMap
		{
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000040")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002E8")]
				[Address(RVA = "0xA8149C", Offset = "0xA8149C", VA = "0xA8149C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000041")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002EB")]
				[Address(RVA = "0xA81554", Offset = "0xA81554", VA = "0xA81554")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000042")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0xA81934", Offset = "0xA81934", VA = "0xA81934")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA8145C", Offset = "0xA8145C", VA = "0xA8145C")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xA814CC", Offset = "0xA814CC", VA = "0xA814CC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xA81510", Offset = "0xA81510", VA = "0xA81510")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xA81564", Offset = "0xA81564", VA = "0xA81564")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xA81638", Offset = "0xA81638", VA = "0xA81638")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xA81640", Offset = "0xA81640", VA = "0xA81640")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA8170C", Offset = "0xA8170C", VA = "0xA8170C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA81778", Offset = "0xA81778", VA = "0xA81778")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xA81824", Offset = "0xA81824", VA = "0xA81824")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xA81A9C", Offset = "0xA81A9C", VA = "0xA81A9C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xA81AC8", Offset = "0xA81AC8", VA = "0xA81AC8")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xA81AF4", Offset = "0xA81AF4", VA = "0xA81AF4")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xA81B1C", Offset = "0xA81B1C", VA = "0xA81B1C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xA81BDC", Offset = "0xA81BDC", VA = "0xA81BDC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xA81D60", Offset = "0xA81D60", VA = "0xA81D60")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xA81D84", Offset = "0xA81D84", VA = "0xA81D84")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xA81EA4", Offset = "0xA81EA4", VA = "0xA81EA4")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xA81F08", Offset = "0xA81F08", VA = "0xA81F08")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xA82088", Offset = "0xA82088", VA = "0xA82088")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xA82208", Offset = "0xA82208", VA = "0xA82208")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xA82284", Offset = "0xA82284", VA = "0xA82284")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xA81C50", Offset = "0xA81C50", VA = "0xA81C50")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0xA823A0", Offset = "0xA823A0", VA = "0xA823A0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA811EC", Offset = "0xA811EC", VA = "0xA811EC", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA811F4", Offset = "0xA811F4", VA = "0xA811F4", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA811F8", Offset = "0xA811F8", VA = "0xA811F8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA81340", Offset = "0xA81340", VA = "0xA81340")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA81454", Offset = "0xA81454", VA = "0xA81454")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xA823BC", Offset = "0xA823BC", VA = "0xA823BC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA82464", Offset = "0xA82464", VA = "0xA82464")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA824F4", Offset = "0xA824F4", VA = "0xA824F4")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA825A0", Offset = "0xA825A0", VA = "0xA825A0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA825B8", Offset = "0xA825B8", VA = "0xA825B8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA825D4", Offset = "0xA825D4", VA = "0xA825D4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA8267C", Offset = "0xA8267C", VA = "0xA8267C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA82694", Offset = "0xA82694", VA = "0xA82694")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000067")]
		public enum BoneMapType
		{
			[Token(Token = "0x40002AB")]
			Parent,
			[Token(Token = "0x40002AC")]
			Bone1,
			[Token(Token = "0x40002AD")]
			Bone2,
			[Token(Token = "0x40002AE")]
			Bone3
		}

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xA826B8", Offset = "0xA826B8", VA = "0xA826B8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA8272C", Offset = "0xA8272C", VA = "0xA8272C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA827F4", Offset = "0xA827F4", VA = "0xA827F4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA82AAC", Offset = "0xA82AAC", VA = "0xA82AAC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA82BF8", Offset = "0xA82BF8", VA = "0xA82BF8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA82D7C", Offset = "0xA82D7C", VA = "0xA82D7C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA82DDC", Offset = "0xA82DDC", VA = "0xA82DDC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA82E74", Offset = "0xA82E74", VA = "0xA82E74")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xA82F1C", Offset = "0xA82F1C", VA = "0xA82F1C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xA831D0", Offset = "0xA831D0", VA = "0xA831D0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xA83230", Offset = "0xA83230", VA = "0xA83230")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xA83374", Offset = "0xA83374", VA = "0xA83374", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA836A0", Offset = "0xA836A0", VA = "0xA836A0")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xA83818", Offset = "0xA83818", VA = "0xA83818")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xA839D0", Offset = "0xA839D0", VA = "0xA839D0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xA83A44", Offset = "0xA83A44", VA = "0xA83A44")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA83AA0", Offset = "0xA83AA0", VA = "0xA83AA0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA83B18", Offset = "0xA83B18", VA = "0xA83B18", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA84190", Offset = "0xA84190", VA = "0xA84190")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA841C8", Offset = "0xA841C8", VA = "0xA841C8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA8442C", Offset = "0xA8442C", VA = "0xA8442C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA8474C", Offset = "0xA8474C", VA = "0xA8474C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xA8482C", Offset = "0xA8482C", VA = "0xA8482C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA848E0", Offset = "0xA848E0", VA = "0xA848E0")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200006A")]
		public class Point
		{
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000337")]
			[Address(RVA = "0xA851BC", Offset = "0xA851BC", VA = "0xA851BC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0xA85200", Offset = "0xA85200", VA = "0xA85200")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0xA852E0", Offset = "0xA852E0", VA = "0xA852E0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0xA8530C", Offset = "0xA8530C", VA = "0xA8530C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0xA85338", Offset = "0xA85338", VA = "0xA85338")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xA8537C", Offset = "0xA8537C", VA = "0xA8537C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0xA853C0", Offset = "0xA853C0", VA = "0xA853C0")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006B")]
		public class Bone : Point
		{
			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000044")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600033E")]
				[Address(RVA = "0xA85420", Offset = "0xA85420", VA = "0xA85420")]
				get
				{
					return null;
				}
				[Token(Token = "0x600033F")]
				[Address(RVA = "0xA85510", Offset = "0xA85510", VA = "0xA85510")]
				set
				{
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0xA85594", Offset = "0xA85594", VA = "0xA85594")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0xA85800", Offset = "0xA85800", VA = "0xA85800")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xA85ABC", Offset = "0xA85ABC", VA = "0xA85ABC")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0xA85CB0", Offset = "0xA85CB0", VA = "0xA85CB0")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0xA85CD8", Offset = "0xA85CD8", VA = "0xA85CD8")]
			public Bone()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0xA85D44", Offset = "0xA85D44", VA = "0xA85D44")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0xA85DC4", Offset = "0xA85DC4", VA = "0xA85DC4")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006C")]
		public class Node : Point
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000347")]
			[Address(RVA = "0xA85E58", Offset = "0xA85E58", VA = "0xA85E58")]
			public Node()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0xA85E5C", Offset = "0xA85E5C", VA = "0xA85E5C")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0xA85E88", Offset = "0xA85E88", VA = "0xA85E88")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200006D")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200006E")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The positional or the master weight of the solver.")]
		public float IKPositionWeight;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000043")]
		public bool initiated
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0xA84DC8", Offset = "0xA84DC8", VA = "0xA84DC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0xA84DD0", Offset = "0xA84DD0", VA = "0xA84DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA84B1C", Offset = "0xA84B1C", VA = "0xA84B1C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA84B90", Offset = "0xA84B90", VA = "0xA84B90")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA84D14", Offset = "0xA84D14", VA = "0xA84D14")]
		public void Update()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA84D84", Offset = "0xA84D84", VA = "0xA84D84", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA84D90", Offset = "0xA84D90", VA = "0xA84D90")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA84D9C", Offset = "0xA84D9C", VA = "0xA84D9C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA84DA4", Offset = "0xA84DA4", VA = "0xA84DA4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA84DC0", Offset = "0xA84DC0", VA = "0xA84DC0")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600032D")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600032E")]
		public abstract void FixTransforms();

		[Token(Token = "0x600032F")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000330")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000331")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xA84DDC", Offset = "0xA84DDC", VA = "0xA84DDC")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA84DF4", Offset = "0xA84DF4", VA = "0xA84DF4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA84F18", Offset = "0xA84F18", VA = "0xA84F18")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA84FB0", Offset = "0xA84FB0", VA = "0xA84FB0")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA851A4", Offset = "0xA851A4", VA = "0xA851A4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000045")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0xA86284", Offset = "0xA86284", VA = "0xA86284")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xA862B4", Offset = "0xA862B4", VA = "0xA862B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		protected override int minBones
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xA86F04", Offset = "0xA86F04", VA = "0xA86F04", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xA87444", Offset = "0xA87444", VA = "0xA87444", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xA8614C", Offset = "0xA8614C", VA = "0xA8614C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA862E4", Offset = "0xA862E4", VA = "0xA862E4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA86570", Offset = "0xA86570", VA = "0xA86570", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA86E5C", Offset = "0xA86E5C", VA = "0xA86E5C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA86AF8", Offset = "0xA86AF8", VA = "0xA86AF8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA86F0C", Offset = "0xA86F0C", VA = "0xA86F0C")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA874A4", Offset = "0xA874A4", VA = "0xA874A4")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xA87548", Offset = "0xA87548", VA = "0xA87548", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA878EC", Offset = "0xA878EC", VA = "0xA878EC")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA8799C", Offset = "0xA8799C", VA = "0xA8799C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA87B1C", Offset = "0xA87B1C", VA = "0xA87B1C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA87C7C", Offset = "0xA87C7C", VA = "0xA87C7C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA87CBC", Offset = "0xA87CBC", VA = "0xA87CBC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA87D0C", Offset = "0xA87D0C", VA = "0xA87D0C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA8806C", Offset = "0xA8806C", VA = "0xA8806C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA8808C", Offset = "0xA8808C", VA = "0xA8808C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA87D64", Offset = "0xA87D64", VA = "0xA87D64")]
		private void Read()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA880F4", Offset = "0xA880F4", VA = "0xA880F4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA8826C", Offset = "0xA8826C", VA = "0xA8826C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xA88460", Offset = "0xA88460", VA = "0xA88460")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA884D0", Offset = "0xA884D0", VA = "0xA884D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA88540", Offset = "0xA88540", VA = "0xA88540", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA887F4", Offset = "0xA887F4", VA = "0xA887F4")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA88E84", Offset = "0xA88E84", VA = "0xA88E84")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000049")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0xA89E48", Offset = "0xA89E48", VA = "0xA89E48", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA88E8C", Offset = "0xA88E8C", VA = "0xA88E8C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA8946C", Offset = "0xA8946C", VA = "0xA8946C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA8959C", Offset = "0xA8959C", VA = "0xA8959C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA89624", Offset = "0xA89624", VA = "0xA89624", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA89B3C", Offset = "0xA89B3C", VA = "0xA89B3C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA89E50", Offset = "0xA89E50", VA = "0xA89E50")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA88F64", Offset = "0xA88F64", VA = "0xA88F64")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA89554", Offset = "0xA89554", VA = "0xA89554")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA89E00", Offset = "0xA89E00", VA = "0xA89E00")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA89300", Offset = "0xA89300", VA = "0xA89300")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA8A4FC", Offset = "0xA8A4FC", VA = "0xA8A4FC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA8A564", Offset = "0xA8A564", VA = "0xA8A564")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA8A634", Offset = "0xA8A634", VA = "0xA8A634")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA8A6FC", Offset = "0xA8A6FC", VA = "0xA8A6FC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA898B4", Offset = "0xA898B4", VA = "0xA898B4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA899F8", Offset = "0xA899F8", VA = "0xA899F8")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA8A7EC", Offset = "0xA8A7EC", VA = "0xA8A7EC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA8A0EC", Offset = "0xA8A0EC", VA = "0xA8A0EC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA89544", Offset = "0xA89544", VA = "0xA89544")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA8AE5C", Offset = "0xA8AE5C", VA = "0xA8AE5C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA8A9AC", Offset = "0xA8A9AC", VA = "0xA8A9AC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA89F6C", Offset = "0xA89F6C", VA = "0xA89F6C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA8A03C", Offset = "0xA8A03C", VA = "0xA8A03C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA8AF14", Offset = "0xA8AF14", VA = "0xA8AF14")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xA8AFB0", Offset = "0xA8AFB0", VA = "0xA8AFB0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA8B674", Offset = "0xA8B674", VA = "0xA8B674", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA8B700", Offset = "0xA8B700", VA = "0xA8B700", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA8B794", Offset = "0xA8B794", VA = "0xA8B794", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xA8B88C", Offset = "0xA8B88C", VA = "0xA8B88C")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA8B91C", Offset = "0xA8B91C", VA = "0xA8B91C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA8BD1C", Offset = "0xA8BD1C", VA = "0xA8BD1C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA8BF14", Offset = "0xA8BF14", VA = "0xA8BF14", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA8BDBC", Offset = "0xA8BDBC", VA = "0xA8BDBC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA8BAF4", Offset = "0xA8BAF4", VA = "0xA8BAF4")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA8BF98", Offset = "0xA8BF98", VA = "0xA8BF98")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xA8C014", Offset = "0xA8C014", VA = "0xA8C014")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA8C0F0", Offset = "0xA8C0F0", VA = "0xA8C0F0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xA7DDF4", Offset = "0xA7DDF4", VA = "0xA7DDF4")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA7F794", Offset = "0xA7F794", VA = "0xA7F794")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA7E8B4", Offset = "0xA7E8B4", VA = "0xA7E8B4")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA8C138", Offset = "0xA8C138", VA = "0xA8C138", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA8C2D8", Offset = "0xA8C2D8", VA = "0xA8C2D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xA8C434", Offset = "0xA8C434", VA = "0xA8C434", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xA8C634", Offset = "0xA8C634", VA = "0xA8C634", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xA8C704", Offset = "0xA8C704", VA = "0xA8C704", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xA8C7E0", Offset = "0xA8C7E0", VA = "0xA8C7E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xA8C93C", Offset = "0xA8C93C", VA = "0xA8C93C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xA8CAD4", Offset = "0xA8CAD4", VA = "0xA8CAD4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xA8CCFC", Offset = "0xA8CCFC", VA = "0xA8CCFC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA8CFCC", Offset = "0xA8CFCC", VA = "0xA8CFCC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA8D004", Offset = "0xA8D004", VA = "0xA8D004", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA8D0DC", Offset = "0xA8D0DC", VA = "0xA8D0DC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000308")]
		Body,
		[Token(Token = "0x4000309")]
		LeftShoulder,
		[Token(Token = "0x400030A")]
		RightShoulder,
		[Token(Token = "0x400030B")]
		LeftThigh,
		[Token(Token = "0x400030C")]
		RightThigh,
		[Token(Token = "0x400030D")]
		LeftHand,
		[Token(Token = "0x400030E")]
		RightHand,
		[Token(Token = "0x400030F")]
		LeftFoot,
		[Token(Token = "0x4000310")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000312")]
		LeftArm,
		[Token(Token = "0x4000313")]
		RightArm,
		[Token(Token = "0x4000314")]
		LeftLeg,
		[Token(Token = "0x4000315")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xA8D230", Offset = "0xA8D230", VA = "0xA8D230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xA8D370", Offset = "0xA8D370", VA = "0xA8D370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xA8D378", Offset = "0xA8D378", VA = "0xA8D378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xA8D380", Offset = "0xA8D380", VA = "0xA8D380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xA8D388", Offset = "0xA8D388", VA = "0xA8D388")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xA8D390", Offset = "0xA8D390", VA = "0xA8D390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xA8D398", Offset = "0xA8D398", VA = "0xA8D398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xA8D3A0", Offset = "0xA8D3A0", VA = "0xA8D3A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xA8D3A8", Offset = "0xA8D3A8", VA = "0xA8D3A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xA8D3B0", Offset = "0xA8D3B0", VA = "0xA8D3B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xA8D3DC", Offset = "0xA8D3DC", VA = "0xA8D3DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xA8D408", Offset = "0xA8D408", VA = "0xA8D408")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xA8D434", Offset = "0xA8D434", VA = "0xA8D434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xA8D460", Offset = "0xA8D460", VA = "0xA8D460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xA8D488", Offset = "0xA8D488", VA = "0xA8D488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xA8D4B4", Offset = "0xA8D4B4", VA = "0xA8D4B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xA8D4E0", Offset = "0xA8D4E0", VA = "0xA8D4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xA8D50C", Offset = "0xA8D50C", VA = "0xA8D50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xA8F6D8", Offset = "0xA8F6D8", VA = "0xA8F6D8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xA8F6E4", Offset = "0xA8F6E4", VA = "0xA8F6E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xA8D534", Offset = "0xA8D534", VA = "0xA8D534")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA8D634", Offset = "0xA8D634", VA = "0xA8D634")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA8D584", Offset = "0xA8D584", VA = "0xA8D584")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xA8D6AC", Offset = "0xA8D6AC", VA = "0xA8D6AC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA8D238", Offset = "0xA8D238", VA = "0xA8D238")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xA8D774", Offset = "0xA8D774", VA = "0xA8D774")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xA8D824", Offset = "0xA8D824", VA = "0xA8D824")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xA8D8D0", Offset = "0xA8D8D0", VA = "0xA8D8D0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xA8D97C", Offset = "0xA8D97C", VA = "0xA8D97C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA8D984", Offset = "0xA8D984", VA = "0xA8D984")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA8D9AC", Offset = "0xA8D9AC", VA = "0xA8D9AC")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA8DA6C", Offset = "0xA8DA6C", VA = "0xA8DA6C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA8DC00", Offset = "0xA8DC00", VA = "0xA8DC00")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA8EFDC", Offset = "0xA8EFDC", VA = "0xA8EFDC")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA8F58C", Offset = "0xA8F58C", VA = "0xA8F58C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xA8F5E8", Offset = "0xA8F5E8", VA = "0xA8F5E8")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA8F42C", Offset = "0xA8F42C", VA = "0xA8F42C")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA8F4DC", Offset = "0xA8F4DC", VA = "0xA8F4DC")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA8F6F0", Offset = "0xA8F6F0", VA = "0xA8F6F0")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA8F7B4", Offset = "0xA8F7B4", VA = "0xA8F7B4", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA8F880", Offset = "0xA8F880", VA = "0xA8F880")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA8F99C", Offset = "0xA8F99C", VA = "0xA8F99C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA8FB2C", Offset = "0xA8FB2C", VA = "0xA8FB2C")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA8FCA4", Offset = "0xA8FCA4", VA = "0xA8FCA4", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA8FF00", Offset = "0xA8FF00", VA = "0xA8FF00", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA8FF78", Offset = "0xA8FF78", VA = "0xA8FF78")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700005D")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xA90818", Offset = "0xA90818", VA = "0xA90818", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xA90820", Offset = "0xA90820", VA = "0xA90820", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xA90828", Offset = "0xA90828", VA = "0xA90828", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xA90CCC", Offset = "0xA90CCC", VA = "0xA90CCC", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		protected float positionOffset
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xA90D88", Offset = "0xA90D88", VA = "0xA90D88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA8FF84", Offset = "0xA8FF84", VA = "0xA8FF84")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA90134", Offset = "0xA90134", VA = "0xA90134")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA90280", Offset = "0xA90280", VA = "0xA90280", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA902E0", Offset = "0xA902E0", VA = "0xA902E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA90354", Offset = "0xA90354", VA = "0xA90354", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA90734", Offset = "0xA90734", VA = "0xA90734", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA9073C", Offset = "0xA9073C", VA = "0xA9073C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xA90830", Offset = "0xA90830", VA = "0xA90830", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xA90834", Offset = "0xA90834", VA = "0xA90834", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xA90838", Offset = "0xA90838", VA = "0xA90838")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA90DD0", Offset = "0xA90DD0", VA = "0xA90DD0")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA91188", Offset = "0xA91188", VA = "0xA91188")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA9141C", Offset = "0xA9141C", VA = "0xA9141C")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xA91490", Offset = "0xA91490", VA = "0xA91490", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA91834", Offset = "0xA91834", VA = "0xA91834")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA918E8", Offset = "0xA918E8", VA = "0xA918E8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA91A68", Offset = "0xA91A68", VA = "0xA91A68", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xA91BC8", Offset = "0xA91BC8", VA = "0xA91BC8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xA91C18", Offset = "0xA91C18", VA = "0xA91C18", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xA91C78", Offset = "0xA91C78", VA = "0xA91C78", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA91FD4", Offset = "0xA91FD4", VA = "0xA91FD4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA91FF4", Offset = "0xA91FF4", VA = "0xA91FF4")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA91CD0", Offset = "0xA91CD0", VA = "0xA91CD0")]
		private void Read()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xA92080", Offset = "0xA92080", VA = "0xA92080")]
		private void Write()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xA92504", Offset = "0xA92504", VA = "0xA92504")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200007B")]
		public enum BendModifier
		{
			[Token(Token = "0x4000340")]
			Animation,
			[Token(Token = "0x4000341")]
			Target,
			[Token(Token = "0x4000342")]
			Parent,
			[Token(Token = "0x4000343")]
			Arm,
			[Token(Token = "0x4000344")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0xA93C20", Offset = "0xA93C20", VA = "0xA93C20")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000062")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xA93C04", Offset = "0xA93C04", VA = "0xA93C04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xA927E0", Offset = "0xA927E0", VA = "0xA927E0")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xA92824", Offset = "0xA92824", VA = "0xA92824")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xA92890", Offset = "0xA92890", VA = "0xA92890", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xA92DD8", Offset = "0xA92DD8", VA = "0xA92DD8", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xA938F4", Offset = "0xA938F4", VA = "0xA938F4", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xA9399C", Offset = "0xA9399C", VA = "0xA9399C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xA93B6C", Offset = "0xA93B6C", VA = "0xA93B6C")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xA92BEC", Offset = "0xA92BEC", VA = "0xA92BEC")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA92E94", Offset = "0xA92E94", VA = "0xA92E94")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200007E")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000069")]
			public Vector3 forward
			{
				[Token(Token = "0x6000419")]
				[Address(RVA = "0xA95AC4", Offset = "0xA95AC4", VA = "0xA95AC4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0xA96174", Offset = "0xA96174", VA = "0xA96174")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0xA94BE0", Offset = "0xA94BE0", VA = "0xA94BE0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0xA94ED4", Offset = "0xA94ED4", VA = "0xA94ED4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0xA95E0C", Offset = "0xA95E0C", VA = "0xA95E0C")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000063")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xA94364", Offset = "0xA94364", VA = "0xA94364")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xA9450C", Offset = "0xA9450C", VA = "0xA9450C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		protected bool headIsValid
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xA94430", Offset = "0xA94430", VA = "0xA94430")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xA94530", Offset = "0xA94530", VA = "0xA94530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xA94440", Offset = "0xA94440", VA = "0xA94440")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xA9459C", Offset = "0xA9459C", VA = "0xA9459C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA93DBC", Offset = "0xA93DBC", VA = "0xA93DBC")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xA93DD8", Offset = "0xA93DD8", VA = "0xA93DD8")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA93E04", Offset = "0xA93E04", VA = "0xA93E04")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA93E3C", Offset = "0xA93E3C", VA = "0xA93E3C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA93E84", Offset = "0xA93E84", VA = "0xA93E84")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA93EDC", Offset = "0xA93EDC", VA = "0xA93EDC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA93F4C", Offset = "0xA93F4C", VA = "0xA93F4C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xA94064", Offset = "0xA94064", VA = "0xA94064")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA94070", Offset = "0xA94070", VA = "0xA94070", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA941A0", Offset = "0xA941A0", VA = "0xA941A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA945C0", Offset = "0xA945C0", VA = "0xA945C0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA94814", Offset = "0xA94814", VA = "0xA94814", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xA94974", Offset = "0xA94974", VA = "0xA94974")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xA94C10", Offset = "0xA94C10", VA = "0xA94C10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xA94FC0", Offset = "0xA94FC0", VA = "0xA94FC0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA95084", Offset = "0xA95084", VA = "0xA95084")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA952A0", Offset = "0xA952A0", VA = "0xA952A0")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA955E8", Offset = "0xA955E8", VA = "0xA955E8")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA95AF4", Offset = "0xA95AF4", VA = "0xA95AF4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA94A3C", Offset = "0xA94A3C", VA = "0xA94A3C")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xA95F14", Offset = "0xA95F14", VA = "0xA95F14")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000431")]
			[Address(RVA = "0xA9749C", Offset = "0xA9749C", VA = "0xA9749C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xA97D44", Offset = "0xA97D44", VA = "0xA97D44")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xA92860", Offset = "0xA92860", VA = "0xA92860")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xA97DE0", Offset = "0xA97DE0", VA = "0xA97DE0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xA9617C", Offset = "0xA9617C", VA = "0xA9617C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA96310", Offset = "0xA96310", VA = "0xA96310")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xA96490", Offset = "0xA96490", VA = "0xA96490")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xA9649C", Offset = "0xA9649C", VA = "0xA9649C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xA964B8", Offset = "0xA964B8", VA = "0xA964B8")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xA964C4", Offset = "0xA964C4", VA = "0xA964C4")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xA964CC", Offset = "0xA964CC", VA = "0xA964CC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xA965DC", Offset = "0xA965DC", VA = "0xA965DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xA966D4", Offset = "0xA966D4", VA = "0xA966D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xA96714", Offset = "0xA96714", VA = "0xA96714", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xA96764", Offset = "0xA96764", VA = "0xA96764", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xA96B38", Offset = "0xA96B38", VA = "0xA96B38")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xA96BB4", Offset = "0xA96BB4", VA = "0xA96BB4")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xA970A8", Offset = "0xA970A8", VA = "0xA970A8")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xA97200", Offset = "0xA97200", VA = "0xA97200", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xA973AC", Offset = "0xA973AC", VA = "0xA973AC")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xA9732C", Offset = "0xA9732C", VA = "0xA9732C")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xA9758C", Offset = "0xA9758C", VA = "0xA9758C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xA97DD4", Offset = "0xA97DD4", VA = "0xA97DD4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xA97DD8", Offset = "0xA97DD8", VA = "0xA97DD8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xA97DDC", Offset = "0xA97DDC", VA = "0xA97DDC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xA97B84", Offset = "0xA97B84", VA = "0xA97B84")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xA93A20", Offset = "0xA93A20", VA = "0xA93A20")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000082")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000083")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40003AB")]
				YawPitch,
				[Token(Token = "0x40003AC")]
				FromTo
			}

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Hand")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[LargeHeader("Shoulder")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[ShowRangeIf(0f, 1f, "shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the yaw (up) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderYawOffset;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the pitch (forward) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderPitchOffset;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Bending")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[LargeHeader("Stretching")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("'Time' represents (target distance / arm length) and 'value' represents the amount of stretching. So value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right by the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0xA9D9D0", Offset = "0xA9D9D0", VA = "0xA9D9D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xA9D9DC", Offset = "0xA9D9DC", VA = "0xA9D9DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0xA9D9E8", Offset = "0xA9D9E8", VA = "0xA9D9E8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000456")]
				[Address(RVA = "0xA9D9F4", Offset = "0xA9D9F4", VA = "0xA9D9F4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0xA9DA00", Offset = "0xA9DA00", VA = "0xA9DA00")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0xA9DA28", Offset = "0xA9DA28", VA = "0xA9DA28")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0xA9DA5C", Offset = "0xA9DA5C", VA = "0xA9DA5C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone hand
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0xA9DA9C", Offset = "0xA9DA9C", VA = "0xA9DA9C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xA9DADC", Offset = "0xA9DADC", VA = "0xA9DADC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xA9E43C", Offset = "0xA9E43C", VA = "0xA9E43C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0xA9E6E8", Offset = "0xA9E6E8", VA = "0xA9E6E8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xA9E70C", Offset = "0xA9E70C", VA = "0xA9E70C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xA9B834", Offset = "0xA9B834", VA = "0xA9B834")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xA9F140", Offset = "0xA9F140", VA = "0xA9F140", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xA9F198", Offset = "0xA9F198", VA = "0xA9F198", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xA9EA5C", Offset = "0xA9EA5C", VA = "0xA9EA5C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xA9EADC", Offset = "0xA9EADC", VA = "0xA9EADC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xA9F3A4", Offset = "0xA9F3A4", VA = "0xA9F3A4")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xA9D824", Offset = "0xA9D824", VA = "0xA9D824")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000072")]
			public float sqrMag
			{
				[Token(Token = "0x600046B")]
				[Address(RVA = "0xA9F560", Offset = "0xA9F560", VA = "0xA9F560")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046C")]
				[Address(RVA = "0xA9F568", Offset = "0xA9F568", VA = "0xA9F568")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000073")]
			public float mag
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xA9F570", Offset = "0xA9F570", VA = "0xA9F570")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xA9F578", Offset = "0xA9F578", VA = "0xA9F578")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000466")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000467")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x6000468")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000469")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x600046A")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xA9F580", Offset = "0xA9F580", VA = "0xA9F580")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xA92444", Offset = "0xA92444", VA = "0xA92444")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xA9F588", Offset = "0xA9F588", VA = "0xA9F588")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xA9F610", Offset = "0xA9F610", VA = "0xA9F610")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xA9F6A8", Offset = "0xA9F6A8", VA = "0xA9F6A8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xA9B70C", Offset = "0xA9B70C", VA = "0xA9B70C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0xA9EFD8", Offset = "0xA9EFD8", VA = "0xA9EFD8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0xA9F6F0", Offset = "0xA9F6F0", VA = "0xA9F6F0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0xA9F814", Offset = "0xA9F814", VA = "0xA9F814")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xA9F4BC", Offset = "0xA9F4BC", VA = "0xA9F4BC")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class Footstep
		{
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000074")]
			public bool isStepping
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0xA9F828", Offset = "0xA9F828", VA = "0xA9F828")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			public float stepProgress
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0xA9F83C", Offset = "0xA9F83C", VA = "0xA9F83C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600047B")]
				[Address(RVA = "0xA9F844", Offset = "0xA9F844", VA = "0xA9F844")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0xA9F84C", Offset = "0xA9F84C", VA = "0xA9F84C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xA9FA10", Offset = "0xA9FA10", VA = "0xA9FA10")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0xA9FA58", Offset = "0xA9FA58", VA = "0xA9FA58")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0xA9FC9C", Offset = "0xA9FC9C", VA = "0xA9FC9C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0xA9FE3C", Offset = "0xA9FE3C", VA = "0xA9FE3C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0xAA0034", Offset = "0xAA0034", VA = "0xAA0034")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Foot/Toe")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[LargeHeader("Bending")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[LargeHeader("Stretching")]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[Range(0.01f, 2f)]
			public float legLengthMlp;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x17000076")]
			public Vector3 position
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0xAA01A4", Offset = "0xAA01A4", VA = "0xAA01A4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000483")]
				[Address(RVA = "0xAA01B0", Offset = "0xAA01B0", VA = "0xAA01B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0xAA01BC", Offset = "0xAA01BC", VA = "0xAA01BC")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000485")]
				[Address(RVA = "0xAA01C8", Offset = "0xAA01C8", VA = "0xAA01C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public bool hasToes
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0xAA01D4", Offset = "0xAA01D4", VA = "0xAA01D4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0xAA01DC", Offset = "0xAA01DC", VA = "0xAA01DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0xAA01E8", Offset = "0xAA01E8", VA = "0xAA01E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0xAA0210", Offset = "0xAA0210", VA = "0xAA0210")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone foot
			{
				[Token(Token = "0x600048A")]
				[Address(RVA = "0xAA023C", Offset = "0xAA023C", VA = "0xAA023C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone toes
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0xAA0268", Offset = "0xAA0268", VA = "0xAA0268")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600048C")]
				[Address(RVA = "0xA9B6D8", Offset = "0xA9B6D8", VA = "0xA9B6D8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600048D")]
				[Address(RVA = "0xAA0294", Offset = "0xAA0294", VA = "0xAA0294")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600048E")]
				[Address(RVA = "0xAA02A0", Offset = "0xAA02A0", VA = "0xAA02A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x600048F")]
				[Address(RVA = "0xAA02AC", Offset = "0xAA02AC", VA = "0xAA02AC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000490")]
				[Address(RVA = "0xAA02BC", Offset = "0xAA02BC", VA = "0xAA02BC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x6000491")]
				[Address(RVA = "0xAA02CC", Offset = "0xAA02CC", VA = "0xAA02CC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000492")]
				[Address(RVA = "0xAA02DC", Offset = "0xAA02DC", VA = "0xAA02DC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xAA02EC", Offset = "0xAA02EC", VA = "0xAA02EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xAA089C", Offset = "0xAA089C", VA = "0xAA089C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xAA10CC", Offset = "0xAA10CC", VA = "0xAA10CC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0xAA107C", Offset = "0xAA107C", VA = "0xAA107C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0xAA0E30", Offset = "0xAA0E30", VA = "0xAA0E30")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0xA921F8", Offset = "0xA921F8", VA = "0xA921F8")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0xAA1940", Offset = "0xAA1940", VA = "0xAA1940")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0xAA15A8", Offset = "0xAA15A8", VA = "0xAA15A8")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0xAA1D98", Offset = "0xAA1D98", VA = "0xAA1D98", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0xAA1FA0", Offset = "0xAA1FA0", VA = "0xAA1FA0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0xA926F8", Offset = "0xA926F8", VA = "0xA926F8")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class Locomotion
		{
			[Serializable]
			[Token(Token = "0x2000088")]
			public enum Mode
			{
				[Token(Token = "0x4000425")]
				Procedural,
				[Token(Token = "0x4000426")]
				Animated
			}

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Procedural (legacy) or animated locomotion.")]
			public Mode mode;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Used for blending in/out of procedural/animated locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Start moving (horizontal distance to HMD + HMD velocity) threshold.")]
			public float moveThreshold;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[ShowLargeHeaderIf("Animation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte animationHeader;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Minimum locomotion animation speed.")]
			[ShowRangeIf(0.1f, 1f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float minAnimationSpeed;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum locomotion animation speed.")]
			[ShowRangeIf(1f, 10f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxAnimationSpeed;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Smoothing time for Vector3.SmoothDamping 'VRIK_Horizontal' and 'VRIK_Vertical' parameters. Larger values make animation smoother, but less responsive.")]
			[ShowRangeIf(0.05f, 0.2f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float animationSmoothTime;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			[ShowLargeHeaderIf("Root Position", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte rootPositionHeader;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("X and Z standing offset from the horizontal position of the HMD.")]
			public Vector2 standOffset;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while moving.")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while in transition from locomotion to idle state.")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while turning on spot.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Max horizontal distance from the root to the HMD.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootOffset;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[ShowLargeHeaderIf("Root Rotation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max root angle from head forward while moving (ik.solver.spine.maxRootAngle).")]
			public float maxRootAngleMoving;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Max root angle from head forward while standing (ik.solver.spine.maxRootAngle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleStanding;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[SerializeField]
			[HideInInspector]
			public float stepLengthMlp;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int VRIK_Horizontal;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int VRIK_Vertical;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int VRIK_Speed;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int VRIK_Turn;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float stepThreshold;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[ShowRangeIf(0.9f, 1f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[Tooltip("The speed of moving a foot to the next position.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float stepSpeed;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxBodyYOffset;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[Tooltip("Offset for the approximated center of mass.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public Vector3 offset;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private int leftFootIndex;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private int rightFootIndex;

			[Token(Token = "0x17000081")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0xAA4CE0", Offset = "0xAA4CE0", VA = "0xAA4CE0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0xAA4CF0", Offset = "0xAA4CF0", VA = "0xAA4CF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0xAA661C", Offset = "0xAA661C", VA = "0xAA661C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0xAA6650", Offset = "0xAA6650", VA = "0xAA6650")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000084")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0xAA6688", Offset = "0xAA6688", VA = "0xAA6688")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000085")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0xAA66BC", Offset = "0xAA66BC", VA = "0xAA66BC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xAA3080", Offset = "0xAA3080", VA = "0xAA3080")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0xAA34D0", Offset = "0xAA34D0", VA = "0xAA34D0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xAA3934", Offset = "0xAA3934", VA = "0xAA3934")]
			public void Relax()
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xAA3984", Offset = "0xAA3984", VA = "0xAA3984")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xAA3ECC", Offset = "0xAA3ECC", VA = "0xAA3ECC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xAA33F4", Offset = "0xAA33F4", VA = "0xAA33F4")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xAA4014", Offset = "0xAA4014", VA = "0xAA4014")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xAA36EC", Offset = "0xAA36EC", VA = "0xAA36EC")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xAA3DC4", Offset = "0xAA3DC4", VA = "0xAA3DC4")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xAA3FC4", Offset = "0xAA3FC4", VA = "0xAA3FC4")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xAA40CC", Offset = "0xAA40CC", VA = "0xAA40CC")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xAA30C0", Offset = "0xAA30C0", VA = "0xAA30C0")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xAA34F8", Offset = "0xAA34F8", VA = "0xAA34F8")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xAA3938", Offset = "0xAA3938", VA = "0xAA3938")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xAA39F4", Offset = "0xAA39F4", VA = "0xAA39F4")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xAA3F0C", Offset = "0xAA3F0C", VA = "0xAA3F0C")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xAA4D00", Offset = "0xAA4D00", VA = "0xAA4D00")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xAA6224", Offset = "0xAA6224", VA = "0xAA6224")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xAA63DC", Offset = "0xAA63DC", VA = "0xAA63DC")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xAA646C", Offset = "0xAA646C", VA = "0xAA646C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xAA66F4", Offset = "0xAA66F4", VA = "0xAA66F4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Head")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust its position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			public float headClampWeight;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Allows for more natural locomotion animation for 3rd person networked avatars by inheriting vertical head bob motion from the animation while head target height is close to head bone height.")]
			[Range(0f, 1f)]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("If abs(head target height - head bone height) < this value, will use head bone height as head target Y.")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Falloff range for the 'Use Animated Head Height Range' effect above. If head target height from head bone height is greater than useAnimatedHeadHeightRange + animatedHeadHeightBlend, then the head will be vertically locked to the head target again.")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Pelvis")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("How much will the pelvis maintain its animated position?")]
			[Range(0f, 1f)]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[LargeHeader("Chest")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(0f, 1f)]
			[LargeHeader("Spine")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[Range(0f, 180f)]
			[LargeHeader("Root Rotation")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x17000086")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x60004B9")]
				[Address(RVA = "0xAA61BC", Offset = "0xAA61BC", VA = "0xAA61BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0xAA6868", Offset = "0xAA6868", VA = "0xAA6868")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60004BB")]
				[Address(RVA = "0xAA689C", Offset = "0xAA689C", VA = "0xAA689C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			internal VirtualBone head
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0xAA61F0", Offset = "0xAA61F0", VA = "0xAA61F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004BD")]
				[Address(RVA = "0xAA68E4", Offset = "0xAA68E4", VA = "0xAA68E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60004BE")]
				[Address(RVA = "0xAA6918", Offset = "0xAA6918", VA = "0xAA6918")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0xAA692C", Offset = "0xAA692C", VA = "0xAA692C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0xAA6940", Offset = "0xAA6940", VA = "0xAA6940")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0xAA6954", Offset = "0xAA6954", VA = "0xAA6954")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xAA6968", Offset = "0xAA6968", VA = "0xAA6968", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xAA7698", Offset = "0xAA7698", VA = "0xAA7698", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xAA7AA4", Offset = "0xAA7AA4", VA = "0xAA7AA4", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xAA8248", Offset = "0xAA8248", VA = "0xAA8248")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xAA88A0", Offset = "0xAA88A0", VA = "0xAA88A0")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xAA92DC", Offset = "0xAA92DC", VA = "0xAA92DC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xAA9A88", Offset = "0xAA9A88", VA = "0xAA9A88")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xAAA44C", Offset = "0xAAA44C", VA = "0xAAA44C", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xAAA61C", Offset = "0xAAA61C", VA = "0xAAA61C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xAA84A8", Offset = "0xAA84A8", VA = "0xAA84A8")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xAA97B0", Offset = "0xAA97B0", VA = "0xAA97B0")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xAA8EBC", Offset = "0xAA8EBC", VA = "0xAA8EBC")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xAAA6F0", Offset = "0xAAA6F0", VA = "0xAAA6F0")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xAA988C", Offset = "0xAA988C", VA = "0xAA988C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xAA9540", Offset = "0xAA9540", VA = "0xAA9540")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xAAAB10", Offset = "0xAAAB10", VA = "0xAAAB10")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000461")]
			Pelvis,
			[Token(Token = "0x4000462")]
			Chest,
			[Token(Token = "0x4000463")]
			Head,
			[Token(Token = "0x4000464")]
			LeftHand,
			[Token(Token = "0x4000465")]
			RightHand,
			[Token(Token = "0x4000466")]
			LeftFoot,
			[Token(Token = "0x4000467")]
			RightFoot,
			[Token(Token = "0x4000468")]
			LeftHeel,
			[Token(Token = "0x4000469")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public enum RotationOffset
		{
			[Token(Token = "0x400046B")]
			Pelvis,
			[Token(Token = "0x400046C")]
			Chest,
			[Token(Token = "0x400046D")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class VirtualBone
		{
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xAA7608", Offset = "0xAA7608", VA = "0xAA7608")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xAA7678", Offset = "0xAA7678", VA = "0xAA7678")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xAAAC44", Offset = "0xAAAC44", VA = "0xAAAC44")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xAAAE44", Offset = "0xAAAE44", VA = "0xAAAE44")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xAAA9A0", Offset = "0xAAA9A0", VA = "0xAAA9A0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xAAAFA4", Offset = "0xAAAFA4", VA = "0xAAAFA4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xAAB14C", Offset = "0xAAB14C", VA = "0xAAB14C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xAAB2D4", Offset = "0xAAB2D4", VA = "0xAAB2D4")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xAAA068", Offset = "0xAAA068", VA = "0xAAA068")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xAAB378", Offset = "0xAAB378", VA = "0xAAB378")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xAA9C9C", Offset = "0xAA9C9C", VA = "0xAA9C9C")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xAAB4D0", Offset = "0xAAB4D0", VA = "0xAAB4D0")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xAAB5E4", Offset = "0xAAB5E4", VA = "0xAAB5E4")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700006A")]
		public Animator animator
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xA97DE8", Offset = "0xA97DE8", VA = "0xA97DE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xA97DF0", Offset = "0xA97DF0", VA = "0xA97DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xA9D528", Offset = "0xA9D528", VA = "0xA9D528")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xA9D530", Offset = "0xA9D530", VA = "0xA9D530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xA97DF8", Offset = "0xA97DF8", VA = "0xA97DF8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xA982C4", Offset = "0xA982C4", VA = "0xA982C4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xA98158", Offset = "0xA98158", VA = "0xA98158")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xA986D8", Offset = "0xA986D8", VA = "0xA986D8")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xA98820", Offset = "0xA98820", VA = "0xA98820")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xA98860", Offset = "0xA98860", VA = "0xA98860")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xA98984", Offset = "0xA98984", VA = "0xA98984")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xA98A60", Offset = "0xA98A60", VA = "0xA98A60")]
		public void Reset()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xA99250", Offset = "0xA99250", VA = "0xA99250", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xA993A4", Offset = "0xA993A4", VA = "0xA993A4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xA99590", Offset = "0xA99590", VA = "0xA99590", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xA99600", Offset = "0xA99600", VA = "0xA99600", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xA99670", Offset = "0xA99670", VA = "0xA99670", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA99878", Offset = "0xA99878", VA = "0xA99878")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xA985C4", Offset = "0xA985C4", VA = "0xA985C4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xA98B7C", Offset = "0xA98B7C", VA = "0xA98B7C")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xA99AE8", Offset = "0xA99AE8", VA = "0xA99AE8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA99B2C", Offset = "0xA99B2C", VA = "0xA99B2C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xA9B210", Offset = "0xA9B210", VA = "0xA9B210")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA98CCC", Offset = "0xA98CCC", VA = "0xA98CCC")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA99F48", Offset = "0xA99F48", VA = "0xA99F48")]
		private void Solve()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA9B664", Offset = "0xA9B664", VA = "0xA9B664")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xA9B6A0", Offset = "0xA9B6A0", VA = "0xA9B6A0")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA9B0CC", Offset = "0xA9B0CC", VA = "0xA9B0CC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA9CE44", Offset = "0xA9CE44", VA = "0xA9CE44")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA9D538", Offset = "0xA9D538", VA = "0xA9D538")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xAAB798", Offset = "0xAAB798", VA = "0xAAB798")]
		public void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xAABED4", Offset = "0xAABED4", VA = "0xAABED4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xAAC040", Offset = "0xAAC040", VA = "0xAAC040")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xAAC5D4", Offset = "0xAAC5D4", VA = "0xAAC5D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xAAC684", Offset = "0xAAC684", VA = "0xAAC684")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xAAC7BC", Offset = "0xAAC7BC", VA = "0xAAC7BC")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public class TwistSolver
	{
		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xAAC820", Offset = "0xAAC820", VA = "0xAAC820")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xAAB980", Offset = "0xAAB980", VA = "0xAAB980")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xAABF94", Offset = "0xAABF94", VA = "0xAABF94")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xAAC0F0", Offset = "0xAAC0F0", VA = "0xAAC0F0")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class InteractionEffector
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700008D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xAAC950", Offset = "0xAAC950", VA = "0xAAC950")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xAAC958", Offset = "0xAAC958", VA = "0xAAC958")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool isPaused
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xAAC960", Offset = "0xAAC960", VA = "0xAAC960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xAAC968", Offset = "0xAAC968", VA = "0xAAC968")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xAAC974", Offset = "0xAAC974", VA = "0xAAC974")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xAAC97C", Offset = "0xAAC97C", VA = "0xAAC97C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool inInteraction
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xAAC984", Offset = "0xAAC984", VA = "0xAAC984")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public float progress
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xAAF304", Offset = "0xAAF304", VA = "0xAAF304")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xAAC9E4", Offset = "0xAAC9E4", VA = "0xAAC9E4")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xAACA80", Offset = "0xAACA80", VA = "0xAACA80")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xAACB38", Offset = "0xAACB38", VA = "0xAACB38")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xAACCA4", Offset = "0xAACCA4", VA = "0xAACCA4")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xAAD07C", Offset = "0xAAD07C", VA = "0xAAD07C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xAAD19C", Offset = "0xAAD19C", VA = "0xAAD19C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xAAD1F0", Offset = "0xAAD1F0", VA = "0xAAD1F0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xAAD43C", Offset = "0xAAD43C", VA = "0xAAD43C")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xAADFB0", Offset = "0xAADFB0", VA = "0xAADFB0")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xAAEAF8", Offset = "0xAAEAF8", VA = "0xAAEAF8")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xAAED18", Offset = "0xAAED18", VA = "0xAAED18")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xAAF1EC", Offset = "0xAAF1EC", VA = "0xAAF1EC")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xAAF504", Offset = "0xAAF504", VA = "0xAAF504")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xAAF7CC", Offset = "0xAAF7CC", VA = "0xAAF7CC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xAAF8E8", Offset = "0xAAF8E8", VA = "0xAAF8E8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xAAF980", Offset = "0xAAF980", VA = "0xAAF980")]
		public void Update()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xAAFB88", Offset = "0xAAFB88", VA = "0xAAFB88")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xAAFC30", Offset = "0xAAFC30", VA = "0xAAFC30")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xAAFCDC", Offset = "0xAAFCDC", VA = "0xAAFCDC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000520")]
			[Address(RVA = "0xAAF334", Offset = "0xAAF334", VA = "0xAAF334")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xAB0C24", Offset = "0xAB0C24", VA = "0xAB0C24")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class Message
		{
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x40004C2")]
			private const string empty = "";

			[Token(Token = "0x6000522")]
			[Address(RVA = "0xAB0B2C", Offset = "0xAB0B2C", VA = "0xAB0B2C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xAB0C2C", Offset = "0xAB0C2C", VA = "0xAB0C2C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40004C9")]
			private const string empty = "";

			[Token(Token = "0x6000524")]
			[Address(RVA = "0xAB0A50", Offset = "0xAB0A50", VA = "0xAB0A50")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xAB0C34", Offset = "0xAB0C34", VA = "0xAB0C34")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xAB0CE4", Offset = "0xAB0CE4", VA = "0xAB0CE4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xAB0DBC", Offset = "0xAB0DBC", VA = "0xAB0DBC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000096")]
			public enum Type
			{
				[Token(Token = "0x40004CD")]
				PositionWeight,
				[Token(Token = "0x40004CE")]
				RotationWeight,
				[Token(Token = "0x40004CF")]
				PositionOffsetX,
				[Token(Token = "0x40004D0")]
				PositionOffsetY,
				[Token(Token = "0x40004D1")]
				PositionOffsetZ,
				[Token(Token = "0x40004D2")]
				Pull,
				[Token(Token = "0x40004D3")]
				Reach,
				[Token(Token = "0x40004D4")]
				RotateBoneWeight,
				[Token(Token = "0x40004D5")]
				Push,
				[Token(Token = "0x40004D6")]
				PushParent,
				[Token(Token = "0x40004D7")]
				PoserWeight,
				[Token(Token = "0x40004D8")]
				BendGoalWeight
			}

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x6000528")]
			[Address(RVA = "0xAB0388", Offset = "0xAB0388", VA = "0xAB0388")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xAB0DD0", Offset = "0xAB0DD0", VA = "0xAB0DD0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class Multiplier
		{
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xAB095C", Offset = "0xAB095C", VA = "0xAB095C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xAB0DD8", Offset = "0xAB0DD8", VA = "0xAB0DD8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000092")]
		public float length
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0xAAFF10", Offset = "0xAAFF10", VA = "0xAAFF10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xAAFF18", Offset = "0xAAFF18", VA = "0xAAFF18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xAAFF20", Offset = "0xAAFF20", VA = "0xAAFF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xAAFF28", Offset = "0xAAFF28", VA = "0xAAFF28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xAB00E8", Offset = "0xAB00E8", VA = "0xAB00E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xAAF3F8", Offset = "0xAAF3F8", VA = "0xAAF3F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xAAFCF0", Offset = "0xAAFCF0", VA = "0xAAFCF0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xAAFD34", Offset = "0xAAFD34", VA = "0xAAFD34")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xAAFD78", Offset = "0xAAFD78", VA = "0xAAFD78")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xAAFDBC", Offset = "0xAAFDBC", VA = "0xAAFDBC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xAAFE00", Offset = "0xAAFE00", VA = "0xAAFE00")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xAAFE44", Offset = "0xAAFE44", VA = "0xAAFE44")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xAAFE88", Offset = "0xAAFE88", VA = "0xAAFE88")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xAAFECC", Offset = "0xAAFECC", VA = "0xAAFECC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xAAFF30", Offset = "0xAAFF30", VA = "0xAAFF30")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xAB0168", Offset = "0xAB0168", VA = "0xAB0168")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xAAD8D4", Offset = "0xAAD8D4", VA = "0xAAD8D4")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xAB02B8", Offset = "0xAB02B8", VA = "0xAB02B8")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xAAD308", Offset = "0xAAD308", VA = "0xAAD308")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xAAD8CC", Offset = "0xAAD8CC", VA = "0xAAD8CC")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xAAE6F0", Offset = "0xAAE6F0", VA = "0xAAE6F0")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xAAEFE0", Offset = "0xAAEFE0", VA = "0xAAEFE0")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xAB098C", Offset = "0xAB098C", VA = "0xAB098C")]
		private void Start()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xAB03A4", Offset = "0xAB03A4", VA = "0xAB03A4")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xAB02C0", Offset = "0xAB02C0", VA = "0xAB02C0")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xAB0900", Offset = "0xAB0900", VA = "0xAB0900")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xAB0990", Offset = "0xAB0990", VA = "0xAB0990")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xAB09EC", Offset = "0xAB09EC", VA = "0xAB09EC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000098")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x2000099")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200009A")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Reference to the FBBIK component.")]
		[Space(10f)]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTime;

		[Token(Token = "0x17000096")]
		public bool inInteraction
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xAB1008", Offset = "0xAB1008", VA = "0xAB1008")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xAB2BB8", Offset = "0xAB2BB8", VA = "0xAB2BB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xAB2BC0", Offset = "0xAB2BC0", VA = "0xAB2BC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xAB2BC8", Offset = "0xAB2BC8", VA = "0xAB2BC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xAB2BD0", Offset = "0xAB2BD0", VA = "0xAB2BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool initiated
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xAB2BD8", Offset = "0xAB2BD8", VA = "0xAB2BD8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xAB2BE0", Offset = "0xAB2BE0", VA = "0xAB2BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xAB0DE8", Offset = "0xAB0DE8", VA = "0xAB0DE8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xAB0E2C", Offset = "0xAB0E2C", VA = "0xAB0E2C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xAB0E70", Offset = "0xAB0E70", VA = "0xAB0E70")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xAB0EB4", Offset = "0xAB0EB4", VA = "0xAB0EB4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xAB0EF8", Offset = "0xAB0EF8", VA = "0xAB0EF8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xAB0F3C", Offset = "0xAB0F3C", VA = "0xAB0F3C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xAB0F80", Offset = "0xAB0F80", VA = "0xAB0F80")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xAB0FC4", Offset = "0xAB0FC4", VA = "0xAB0FC4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xAB1180", Offset = "0xAB1180", VA = "0xAB1180")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xAB1238", Offset = "0xAB1238", VA = "0xAB1238")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xAB12F0", Offset = "0xAB12F0", VA = "0xAB12F0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xAB1388", Offset = "0xAB1388", VA = "0xAB1388")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xAB146C", Offset = "0xAB146C", VA = "0xAB146C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xAB1564", Offset = "0xAB1564", VA = "0xAB1564")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xAB166C", Offset = "0xAB166C", VA = "0xAB166C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xAB16F0", Offset = "0xAB16F0", VA = "0xAB16F0")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xAB1774", Offset = "0xAB1774", VA = "0xAB1774")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xAB17F8", Offset = "0xAB17F8", VA = "0xAB17F8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xAB1860", Offset = "0xAB1860", VA = "0xAB1860")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xAB18C8", Offset = "0xAB18C8", VA = "0xAB18C8")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xAB1924", Offset = "0xAB1924", VA = "0xAB1924")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xAB19A4", Offset = "0xAB19A4", VA = "0xAB19A4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xAB1A4C", Offset = "0xAB1A4C", VA = "0xAB1A4C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xAB1B1C", Offset = "0xAB1B1C", VA = "0xAB1B1C")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xAB1DAC", Offset = "0xAB1DAC", VA = "0xAB1DAC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xAB1F80", Offset = "0xAB1F80", VA = "0xAB1F80")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xAB21F0", Offset = "0xAB21F0", VA = "0xAB21F0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xAB247C", Offset = "0xAB247C", VA = "0xAB247C")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xAB24B4", Offset = "0xAB24B4", VA = "0xAB24B4")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xAB2514", Offset = "0xAB2514", VA = "0xAB2514")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xAB2640", Offset = "0xAB2640", VA = "0xAB2640")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xAB2824", Offset = "0xAB2824", VA = "0xAB2824")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xAB2A98", Offset = "0xAB2A98", VA = "0xAB2A98")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xAB22D8", Offset = "0xAB22D8", VA = "0xAB22D8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xAB2BEC", Offset = "0xAB2BEC", VA = "0xAB2BEC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xAB3510", Offset = "0xAB3510", VA = "0xAB3510")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xAB3530", Offset = "0xAB3530", VA = "0xAB3530")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xAB354C", Offset = "0xAB354C", VA = "0xAB354C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xAB3568", Offset = "0xAB3568", VA = "0xAB3568")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xAB35BC", Offset = "0xAB35BC", VA = "0xAB35BC")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xAB3740", Offset = "0xAB3740", VA = "0xAB3740")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xAB383C", Offset = "0xAB383C", VA = "0xAB383C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xAB39E8", Offset = "0xAB39E8", VA = "0xAB39E8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xAB3B00", Offset = "0xAB3B00", VA = "0xAB3B00")]
		public void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xAB3DC4", Offset = "0xAB3DC4", VA = "0xAB3DC4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xAB32B0", Offset = "0xAB32B0", VA = "0xAB32B0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xAB3EF4", Offset = "0xAB3EF4", VA = "0xAB3EF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xAB3F10", Offset = "0xAB3F10", VA = "0xAB3F10")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xAB404C", Offset = "0xAB404C", VA = "0xAB404C")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xAB40D4", Offset = "0xAB40D4", VA = "0xAB40D4")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xAB4194", Offset = "0xAB4194", VA = "0xAB4194")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xAB41AC", Offset = "0xAB41AC", VA = "0xAB41AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xAB10A0", Offset = "0xAB10A0", VA = "0xAB10A0")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xAB1C98", Offset = "0xAB1C98", VA = "0xAB1C98")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xAB4624", Offset = "0xAB4624", VA = "0xAB4624")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009C")]
		public enum RotationMode
		{
			[Token(Token = "0x4000502")]
			TwoDOF,
			[Token(Token = "0x4000503")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		public class Multiplier
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x600057E")]
			[Address(RVA = "0xAB4F40", Offset = "0xAB4F40", VA = "0xAB4F40")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		public float threeDOFWeight;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xAB4CAC", Offset = "0xAB4CAC", VA = "0xAB4CAC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xAB4CF0", Offset = "0xAB4CF0", VA = "0xAB4CF0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xAB4D34", Offset = "0xAB4D34", VA = "0xAB4D34")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xAB4D78", Offset = "0xAB4D78", VA = "0xAB4D78")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xAB4DBC", Offset = "0xAB4DBC", VA = "0xAB4DBC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xAB4E00", Offset = "0xAB4E00", VA = "0xAB4E00")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xAB4E44", Offset = "0xAB4E44", VA = "0xAB4E44")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xAB4E88", Offset = "0xAB4E88", VA = "0xAB4E88")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xAB0324", Offset = "0xAB0324", VA = "0xAB0324")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xAAF478", Offset = "0xAAF478", VA = "0xAAF478")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xAAD968", Offset = "0xAAD968", VA = "0xAAD968")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xAB4ECC", Offset = "0xAB4ECC", VA = "0xAB4ECC")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around its Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700009A")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000586")]
				[Address(RVA = "0xAB5364", Offset = "0xAB5364", VA = "0xAB5364")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xAB5370", Offset = "0xAB5370", VA = "0xAB5370")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xAB5430", Offset = "0xAB5430", VA = "0xAB5430")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xAB5B94", Offset = "0xAB5B94", VA = "0xAB5B94")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class CameraPosition
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600058A")]
			[Address(RVA = "0xAB5BA8", Offset = "0xAB5BA8", VA = "0xAB5BA8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xAB5D20", Offset = "0xAB5D20", VA = "0xAB5D20")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xAB6028", Offset = "0xAB6028", VA = "0xAB6028")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A1")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000A2")]
			public class Interaction
			{
				[Token(Token = "0x4000518")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000519")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x600058F")]
				[Address(RVA = "0xAB60AC", Offset = "0xAB60AC", VA = "0xAB60AC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600058D")]
			[Address(RVA = "0xAB5250", Offset = "0xAB5250", VA = "0xAB5250")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xAB609C", Offset = "0xAB609C", VA = "0xAB609C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xAB4F48", Offset = "0xAB4F48", VA = "0xAB4F48")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xAB4F8C", Offset = "0xAB4F8C", VA = "0xAB4F8C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xAB4FD0", Offset = "0xAB4FD0", VA = "0xAB4FD0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xAB5014", Offset = "0xAB5014", VA = "0xAB5014")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xAB5058", Offset = "0xAB5058", VA = "0xAB5058")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xAB509C", Offset = "0xAB509C", VA = "0xAB509C")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xAB5300", Offset = "0xAB5300", VA = "0xAB5300")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public class Map
		{
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000597")]
			[Address(RVA = "0xAB63AC", Offset = "0xAB63AC", VA = "0xAB63AC")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xAB6704", Offset = "0xAB6704", VA = "0xAB6704")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xAB66C4", Offset = "0xAB66C4", VA = "0xAB66C4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xAB6548", Offset = "0xAB6548", VA = "0xAB6548")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xAB60B4", Offset = "0xAB60B4", VA = "0xAB60B4", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xAB6454", Offset = "0xAB6454", VA = "0xAB6454", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xAB6458", Offset = "0xAB6458", VA = "0xAB6458", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xAB6668", Offset = "0xAB6668", VA = "0xAB6668", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xAB63F8", Offset = "0xAB63F8", VA = "0xAB63F8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xAB6318", Offset = "0xAB6318", VA = "0xAB6318")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xAB6748", Offset = "0xAB6748", VA = "0xAB6748")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xAB6768", Offset = "0xAB6768", VA = "0xAB6768", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xAB6838", Offset = "0xAB6838", VA = "0xAB6838", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xAB6A10", Offset = "0xAB6A10", VA = "0xAB6A10", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xAB6AF8", Offset = "0xAB6AF8", VA = "0xAB6AF8", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xAB6898", Offset = "0xAB6898", VA = "0xAB6898")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xAB6E28", Offset = "0xAB6E28", VA = "0xAB6E28")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60005A1")]
		public abstract void AutoMapping();

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xAB6E38", Offset = "0xAB6E38", VA = "0xAB6E38")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60005A3")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60005A4")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60005A5")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xAB6E44", Offset = "0xAB6E44", VA = "0xAB6E44", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xAB6E88", Offset = "0xAB6E88", VA = "0xAB6E88", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xAB6EB4", Offset = "0xAB6EB4", VA = "0xAB6EB4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xAB6758", Offset = "0xAB6758", VA = "0xAB6758")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public class Rigidbone
		{
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xAB7524", Offset = "0xAB7524", VA = "0xAB7524")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xAB80D0", Offset = "0xAB80D0", VA = "0xAB80D0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xAB7E90", Offset = "0xAB7E90", VA = "0xAB7E90")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		public class Child
		{
			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xAB76CC", Offset = "0xAB76CC", VA = "0xAB76CC")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xAB81E8", Offset = "0xAB81E8", VA = "0xAB81E8")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xAB81A4", Offset = "0xAB81A4", VA = "0xAB81A4")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700009E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0xAB8754", Offset = "0xAB8754", VA = "0xAB8754", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0xAB879C", Offset = "0xAB879C", VA = "0xAB879C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xAB7738", Offset = "0xAB7738", VA = "0xAB7738")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xAB8564", Offset = "0xAB8564", VA = "0xAB8564", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xAB8568", Offset = "0xAB8568", VA = "0xAB8568", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xAB875C", Offset = "0xAB875C", VA = "0xAB875C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700009C")]
		private bool isRagdoll
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xAB6EF8", Offset = "0xAB6EF8", VA = "0xAB6EF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		private bool ikUsed
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xAB7AC4", Offset = "0xAB7AC4", VA = "0xAB7AC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xAB6ECC", Offset = "0xAB6ECC", VA = "0xAB6ECC")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xAB6F5C", Offset = "0xAB6F5C", VA = "0xAB6F5C")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xAB7074", Offset = "0xAB7074", VA = "0xAB7074")]
		public void Start()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xAB7000", Offset = "0xAB7000", VA = "0xAB7000")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xAB7760", Offset = "0xAB7760", VA = "0xAB7760")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xAB7988", Offset = "0xAB7988", VA = "0xAB7988")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xAB7A28", Offset = "0xAB7A28", VA = "0xAB7A28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xAB7C18", Offset = "0xAB7C18", VA = "0xAB7C18")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xAB7A98", Offset = "0xAB7A98", VA = "0xAB7A98")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xAB7BE4", Offset = "0xAB7BE4", VA = "0xAB7BE4")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xAB7C98", Offset = "0xAB7C98", VA = "0xAB7C98")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xAB7C3C", Offset = "0xAB7C3C", VA = "0xAB7C3C")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xAB6FA4", Offset = "0xAB6FA4", VA = "0xAB6FA4")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xAB79BC", Offset = "0xAB79BC", VA = "0xAB79BC")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xAB82F8", Offset = "0xAB82F8", VA = "0xAB82F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xAB8430", Offset = "0xAB8430", VA = "0xAB8430")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A0")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xAB8C08", Offset = "0xAB8C08", VA = "0xAB8C08")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A1")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xAB8C14", Offset = "0xAB8C14", VA = "0xAB8C14")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xAB8C44", Offset = "0xAB8C44", VA = "0xAB8C44")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xAB8C4C", Offset = "0xAB8C4C", VA = "0xAB8C4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xAB87A4", Offset = "0xAB87A4", VA = "0xAB87A4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xAB87E0", Offset = "0xAB87E0", VA = "0xAB87E0")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xAB87F8", Offset = "0xAB87F8", VA = "0xAB87F8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xAB8B78", Offset = "0xAB8B78", VA = "0xAB8B78")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xAB8BDC", Offset = "0xAB8BDC", VA = "0xAB8BDC")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005D1")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xAB8A7C", Offset = "0xAB8A7C", VA = "0xAB8A7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xAB8C58", Offset = "0xAB8C58", VA = "0xAB8C58")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xAB8C5C", Offset = "0xAB8C5C", VA = "0xAB8C5C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xAB8C84", Offset = "0xAB8C84", VA = "0xAB8C84")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xAB8D58", Offset = "0xAB8D58", VA = "0xAB8D58")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xAB8FB0", Offset = "0xAB8FB0", VA = "0xAB8FB0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xAB9104", Offset = "0xAB9104", VA = "0xAB9104")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xAB9164", Offset = "0xAB9164", VA = "0xAB9164")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xAB91A8", Offset = "0xAB91A8", VA = "0xAB91A8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xAB91EC", Offset = "0xAB91EC", VA = "0xAB91EC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xAB9230", Offset = "0xAB9230", VA = "0xAB9230")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xAB9274", Offset = "0xAB9274", VA = "0xAB9274", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xAB92AC", Offset = "0xAB92AC", VA = "0xAB92AC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xAB95D0", Offset = "0xAB95D0", VA = "0xAB95D0")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xAB95E0", Offset = "0xAB95E0", VA = "0xAB95E0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xAB9624", Offset = "0xAB9624", VA = "0xAB9624")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xAB9668", Offset = "0xAB9668", VA = "0xAB9668")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xAB96AC", Offset = "0xAB96AC", VA = "0xAB96AC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xAB96F0", Offset = "0xAB96F0", VA = "0xAB96F0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xAB96F4", Offset = "0xAB96F4", VA = "0xAB96F4")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xAB9914", Offset = "0xAB9914", VA = "0xAB9914")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class ReachCone
		{
			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000A3")]
			public Vector3 o
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0xABB7C0", Offset = "0xABB7C0", VA = "0xABB7C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 a
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xABB7EC", Offset = "0xABB7EC", VA = "0xABB7EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 b
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xABB81C", Offset = "0xABB81C", VA = "0xABB81C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 c
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0xABB84C", Offset = "0xABB84C", VA = "0xABB84C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public bool isValid
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0xABACE8", Offset = "0xABACE8", VA = "0xABACE8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xABB18C", Offset = "0xABB18C", VA = "0xABB18C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xABB304", Offset = "0xABB304", VA = "0xABB304")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B0")]
		public class LimitPoint
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xABACF8", Offset = "0xABACF8", VA = "0xABACF8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xAB992C", Offset = "0xAB992C", VA = "0xAB992C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xAB9970", Offset = "0xAB9970", VA = "0xAB9970")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xAB99B4", Offset = "0xAB99B4", VA = "0xAB99B4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xAB99F8", Offset = "0xAB99F8", VA = "0xAB99F8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xAB9A3C", Offset = "0xAB9A3C", VA = "0xAB9A3C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xABA120", Offset = "0xABA120", VA = "0xABA120", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xABA1A8", Offset = "0xABA1A8", VA = "0xABA1A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xABA7F4", Offset = "0xABA7F4", VA = "0xABA7F4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xAB9AD4", Offset = "0xAB9AD4", VA = "0xAB9AD4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xABAD5C", Offset = "0xABAD5C", VA = "0xABAD5C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xABB578", Offset = "0xABB578", VA = "0xABB578")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xABB5C0", Offset = "0xABB5C0", VA = "0xABB5C0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xABB620", Offset = "0xABB620", VA = "0xABB620")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xABA550", Offset = "0xABA550", VA = "0xABA550")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xABB68C", Offset = "0xABB68C", VA = "0xABB68C")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xABB758", Offset = "0xABB758", VA = "0xABB758")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xABB87C", Offset = "0xABB87C", VA = "0xABB87C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xABB8C0", Offset = "0xABB8C0", VA = "0xABB8C0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xABB904", Offset = "0xABB904", VA = "0xABB904")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xABB948", Offset = "0xABB948", VA = "0xABB948")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xABB98C", Offset = "0xABB98C", VA = "0xABB98C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xABB9A8", Offset = "0xABB9A8", VA = "0xABB9A8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xABB9E0", Offset = "0xABB9E0", VA = "0xABB9E0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xABBD8C", Offset = "0xABBD8C", VA = "0xABBD8C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000611")]
				[Address(RVA = "0xABCD90", Offset = "0xABCD90", VA = "0xABCD90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0xABCDD8", Offset = "0xABCDD8", VA = "0xABCDD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xABCB90", Offset = "0xABCB90", VA = "0xABCB90")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xABCC9C", Offset = "0xABCC9C", VA = "0xABCC9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0xABCCA0", Offset = "0xABCCA0", VA = "0xABCCA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0xABCD98", Offset = "0xABCD98", VA = "0xABCD98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000A8")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0xABBE18", Offset = "0xABBE18", VA = "0xABBE18")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xABBD98", Offset = "0xABBD98", VA = "0xABBD98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xABBE9C", Offset = "0xABBE9C", VA = "0xABBE9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xABC6F4", Offset = "0xABC6F4", VA = "0xABC6F4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xABC878", Offset = "0xABC878", VA = "0xABC878")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xABCB1C", Offset = "0xABCB1C", VA = "0xABCB1C")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xABCBB8", Offset = "0xABCBB8", VA = "0xABCBB8")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Pose
		{
			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000617")]
			[Address(RVA = "0xABCEB0", Offset = "0xABCEB0", VA = "0xABCEB0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0xABD42C", Offset = "0xABD42C", VA = "0xABD42C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0xABD434", Offset = "0xABD434", VA = "0xABD434")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xABCDE0", Offset = "0xABCDE0", VA = "0xABCDE0")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xABD360", Offset = "0xABD360", VA = "0xABD360")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xABD3C0", Offset = "0xABD3C0", VA = "0xABD3C0")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000B8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000598")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000599")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600061F")]
				[Address(RVA = "0xABD8F8", Offset = "0xABD8F8", VA = "0xABD8F8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600061C")]
			[Address(RVA = "0xABD5A0", Offset = "0xABD5A0", VA = "0xABD5A0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xABD8D0", Offset = "0xABD8D0", VA = "0xABD8D0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xABD8E0", Offset = "0xABD8E0", VA = "0xABD8E0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xABD450", Offset = "0xABD450", VA = "0xABD450", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xABD8B0", Offset = "0xABD8B0", VA = "0xABD8B0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xABD900", Offset = "0xABD900", VA = "0xABD900", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xABD968", Offset = "0xABD968", VA = "0xABD968", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xABDC08", Offset = "0xABDC08", VA = "0xABDC08")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xABDC24", Offset = "0xABDC24", VA = "0xABDC24")]
		private void Start()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xABDD04", Offset = "0xABDD04", VA = "0xABDD04")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xABDF98", Offset = "0xABDF98", VA = "0xABDF98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xABE0C4", Offset = "0xABE0C4", VA = "0xABE0C4")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x170000AB")]
		public IK ik
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0xABE0D4", Offset = "0xABE0D4", VA = "0xABE0D4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0xABE0DC", Offset = "0xABE0DC", VA = "0xABE0DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xABE0E4", Offset = "0xABE0E4", VA = "0xABE0E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xABE284", Offset = "0xABE284", VA = "0xABE284")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xABE4E0", Offset = "0xABE4E0", VA = "0xABE4E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xABE61C", Offset = "0xABE61C", VA = "0xABE61C")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xABE7FC", Offset = "0xABE7FC", VA = "0xABE7FC")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xABEA10", Offset = "0xABEA10", VA = "0xABEA10")]
		public void Update()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xABEC94", Offset = "0xABEC94", VA = "0xABEC94")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000AC")]
		public bool poseStored
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0xABE360", Offset = "0xABE360", VA = "0xABE360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xABE698", Offset = "0xABE698", VA = "0xABE698")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xABE384", Offset = "0xABE384", VA = "0xABE384")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xABECF8", Offset = "0xABECF8", VA = "0xABECF8")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000AE")]
			public bool inProgress
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0xABEE30", Offset = "0xABEE30", VA = "0xABEE30")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AF")]
			protected float crossFader
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0xABF218", Offset = "0xABF218", VA = "0xABF218")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063A")]
				[Address(RVA = "0xABF220", Offset = "0xABF220", VA = "0xABF220")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			protected float timer
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0xABF228", Offset = "0xABF228", VA = "0xABF228")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063C")]
				[Address(RVA = "0xABF230", Offset = "0xABF230", VA = "0xABF230")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			protected Vector3 force
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0xABF238", Offset = "0xABF238", VA = "0xABF238")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0xABF244", Offset = "0xABF244", VA = "0xABF244")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xABF250", Offset = "0xABF250", VA = "0xABF250", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xABEF04", Offset = "0xABEF04", VA = "0xABEF04")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000641")]
			protected abstract float GetLength();

			[Token(Token = "0x6000642")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000643")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000644")]
			[Address(RVA = "0xABF35C", Offset = "0xABF35C", VA = "0xABF35C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C0")]
			public class EffectorLink
			{
				[Token(Token = "0x40005B6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40005B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000649")]
				[Address(RVA = "0xABF690", Offset = "0xABF690", VA = "0xABF690")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600064A")]
				[Address(RVA = "0xABF4EC", Offset = "0xABF4EC", VA = "0xABF4EC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600064B")]
				[Address(RVA = "0xABF740", Offset = "0xABF740", VA = "0xABF740")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000645")]
			[Address(RVA = "0xABF370", Offset = "0xABF370", VA = "0xABF370", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xABF48C", Offset = "0xABF48C", VA = "0xABF48C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xABF500", Offset = "0xABF500", VA = "0xABF500", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xABF72C", Offset = "0xABF72C", VA = "0xABF72C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C2")]
			public class BoneLink
			{
				[Token(Token = "0x40005BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x40005BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x40005C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000651")]
				[Address(RVA = "0xABFA78", Offset = "0xABFA78", VA = "0xABFA78")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000652")]
				[Address(RVA = "0xABF9AC", Offset = "0xABF9AC", VA = "0xABF9AC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000653")]
				[Address(RVA = "0xABFC18", Offset = "0xABFC18", VA = "0xABFC18")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0xABF748", Offset = "0xABF748", VA = "0xABF748", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xABF8C8", Offset = "0xABF8C8", VA = "0xABF8C8", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xABF954", Offset = "0xABF954", VA = "0xABF954", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xABF9B8", Offset = "0xABF9B8", VA = "0xABF9B8", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xABFC04", Offset = "0xABFC04", VA = "0xABFC04")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000AD")]
		public bool inProgress
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xABED94", Offset = "0xABED94", VA = "0xABED94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xABEE44", Offset = "0xABEE44", VA = "0xABEE44", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xABEFDC", Offset = "0xABEFDC", VA = "0xABEFDC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xABF208", Offset = "0xABF208", VA = "0xABF208")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public abstract class Offset
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000B2")]
			protected float crossFader
			{
				[Token(Token = "0x6000657")]
				[Address(RVA = "0xAC0068", Offset = "0xAC0068", VA = "0xAC0068")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000658")]
				[Address(RVA = "0xAC0070", Offset = "0xAC0070", VA = "0xAC0070")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected float timer
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0xAC0078", Offset = "0xAC0078", VA = "0xAC0078")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600065A")]
				[Address(RVA = "0xAC0080", Offset = "0xAC0080", VA = "0xAC0080")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0xAC0088", Offset = "0xAC0088", VA = "0xAC0088")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065C")]
				[Address(RVA = "0xAC0094", Offset = "0xAC0094", VA = "0xAC0094")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xAC00A0", Offset = "0xAC00A0", VA = "0xAC00A0", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xABFD34", Offset = "0xABFD34", VA = "0xABFD34")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600065F")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000660")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000661")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xAC01B4", Offset = "0xAC01B4", VA = "0xAC01B4")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C6")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40005D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40005D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000667")]
				[Address(RVA = "0xAC0598", Offset = "0xAC0598", VA = "0xAC0598")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0xAC03BC", Offset = "0xAC03BC", VA = "0xAC03BC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000669")]
				[Address(RVA = "0xAC062C", Offset = "0xAC062C", VA = "0xAC062C")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000663")]
			[Address(RVA = "0xAC01C8", Offset = "0xAC01C8", VA = "0xAC01C8", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xAC035C", Offset = "0xAC035C", VA = "0xAC035C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xAC03D0", Offset = "0xAC03D0", VA = "0xAC03D0", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xAC0610", Offset = "0xAC0610", VA = "0xAC0610")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C8")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40005D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x40005DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600066F")]
				[Address(RVA = "0xAC0B20", Offset = "0xAC0B20", VA = "0xAC0B20")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000670")]
				[Address(RVA = "0xAC08EC", Offset = "0xAC08EC", VA = "0xAC08EC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000671")]
				[Address(RVA = "0xAC0C3C", Offset = "0xAC0C3C", VA = "0xAC0C3C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x600066A")]
			[Address(RVA = "0xAC0634", Offset = "0xAC0634", VA = "0xAC0634", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0xAC07BC", Offset = "0xAC07BC", VA = "0xAC07BC", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0xAC0894", Offset = "0xAC0894", VA = "0xAC0894", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0xAC08F8", Offset = "0xAC08F8", VA = "0xAC08F8", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0xAC0C28", Offset = "0xAC0C28", VA = "0xAC0C28")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xABFC7C", Offset = "0xABFC7C", VA = "0xABFC7C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xABFE14", Offset = "0xABFE14", VA = "0xABFE14")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xAC0048", Offset = "0xAC0048", VA = "0xAC0048")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000CB")]
			public class EffectorLink
			{
				[Token(Token = "0x40005EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000678")]
				[Address(RVA = "0xAC1204", Offset = "0xAC1204", VA = "0xAC1204")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000675")]
			[Address(RVA = "0xAC0D0C", Offset = "0xAC0D0C", VA = "0xAC0D0C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xAC0E8C", Offset = "0xAC0E8C", VA = "0xAC0E8C")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xAC11E8", Offset = "0xAC11E8", VA = "0xAC11E8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xAC0CA0", Offset = "0xAC0CA0", VA = "0xAC0CA0")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xAC0DE8", Offset = "0xAC0DE8", VA = "0xAC0DE8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xAC11D8", Offset = "0xAC11D8", VA = "0xAC11D8")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000B5")]
		private Vector3 pivot
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0xAC1274", Offset = "0xAC1274", VA = "0xAC1274")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xAC120C", Offset = "0xAC120C", VA = "0xAC120C")]
		private void Start()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xAC12F8", Offset = "0xAC12F8", VA = "0xAC12F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xAC1800", Offset = "0xAC1800", VA = "0xAC1800")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xAC1984", Offset = "0xAC1984", VA = "0xAC1984")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xAC1BD0", Offset = "0xAC1BD0", VA = "0xAC1BD0")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x6000687")]
			[Address(RVA = "0xAC1DD8", Offset = "0xAC1DD8", VA = "0xAC1DD8")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xAC2068", Offset = "0xAC2068", VA = "0xAC2068")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xAC20D8", Offset = "0xAC20D8", VA = "0xAC20D8")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xAC2120", Offset = "0xAC2120", VA = "0xAC2120")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600068E")]
				[Address(RVA = "0xAC229C", Offset = "0xAC229C", VA = "0xAC229C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000690")]
				[Address(RVA = "0xAC22E4", Offset = "0xAC22E4", VA = "0xAC22E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xAC1CDC", Offset = "0xAC1CDC", VA = "0xAC1CDC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xAC2128", Offset = "0xAC2128", VA = "0xAC2128", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xAC212C", Offset = "0xAC212C", VA = "0xAC212C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xAC22A4", Offset = "0xAC22A4", VA = "0xAC22A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000B6")]
		protected float deltaTime
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xABD580", Offset = "0xABD580", VA = "0xABD580")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000680")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xABD948", Offset = "0xABD948", VA = "0xABD948", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xAC1C68", Offset = "0xAC1C68", VA = "0xAC1C68")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xAC1D04", Offset = "0xAC1D04", VA = "0xAC1D04")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xAC1130", Offset = "0xAC1130", VA = "0xAC1130")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xAC1F3C", Offset = "0xAC1F3C", VA = "0xAC1F3C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xABD8C0", Offset = "0xABD8C0", VA = "0xABD8C0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600069B")]
				[Address(RVA = "0xAC273C", Offset = "0xAC273C", VA = "0xAC273C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600069D")]
				[Address(RVA = "0xAC2784", Offset = "0xAC2784", VA = "0xAC2784", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0xAC23A0", Offset = "0xAC23A0", VA = "0xAC23A0")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xAC25C8", Offset = "0xAC25C8", VA = "0xAC25C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xAC25CC", Offset = "0xAC25CC", VA = "0xAC25CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xAC2744", Offset = "0xAC2744", VA = "0xAC2744", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000B9")]
		protected float deltaTime
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0xAC22EC", Offset = "0xAC22EC", VA = "0xAC22EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000692")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xAC230C", Offset = "0xAC230C", VA = "0xAC230C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xAC232C", Offset = "0xAC232C", VA = "0xAC232C")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xAC23C8", Offset = "0xAC23C8", VA = "0xAC23C8")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xAC249C", Offset = "0xAC249C", VA = "0xAC249C", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xAC0058", Offset = "0xAC0058", VA = "0xAC0058")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class EffectorLink
		{
			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xAC278C", Offset = "0xAC278C", VA = "0xAC278C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xAC2AE4", Offset = "0xAC2AE4", VA = "0xAC2AE4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xABDB54", Offset = "0xABDB54", VA = "0xABDB54")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xAC29DC", Offset = "0xAC29DC", VA = "0xAC29DC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xAC2A80", Offset = "0xAC2A80", VA = "0xAC2A80")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000D6")]
			public class EffectorLink
			{
				[Token(Token = "0x4000627")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000628")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x60006A9")]
				[Address(RVA = "0xAC3138", Offset = "0xAC3138", VA = "0xAC3138")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xAC2B5C", Offset = "0xAC2B5C", VA = "0xAC2B5C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xAC2CFC", Offset = "0xAC2CFC", VA = "0xAC2CFC")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xAC2E04", Offset = "0xAC2E04", VA = "0xAC2E04")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xAC3124", Offset = "0xAC3124", VA = "0xAC3124")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xAC2AEC", Offset = "0xAC2AEC", VA = "0xAC2AEC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xAC2CEC", Offset = "0xAC2CEC", VA = "0xAC2CEC")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000D9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000647")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000648")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006B9")]
				[Address(RVA = "0xAC4618", Offset = "0xAC4618", VA = "0xAC4618")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xAC32DC", Offset = "0xAC32DC", VA = "0xAC32DC")]
			public void Start()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xAC3E98", Offset = "0xAC3E98", VA = "0xAC3E98")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xAC4604", Offset = "0xAC4604", VA = "0xAC4604")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		public enum Handedness
		{
			[Token(Token = "0x400064A")]
			Right,
			[Token(Token = "0x400064B")]
			Left
		}

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
		public AimIK headIK;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000BC")]
		public bool isFinished
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xAC3140", Offset = "0xAC3140", VA = "0xAC3140")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xAC409C", Offset = "0xAC409C", VA = "0xAC409C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xAC40D8", Offset = "0xAC40D8", VA = "0xAC40D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xAC4064", Offset = "0xAC4064", VA = "0xAC4064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xAC4080", Offset = "0xAC4080", VA = "0xAC4080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xAC3164", Offset = "0xAC3164", VA = "0xAC3164")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xAC3190", Offset = "0xAC3190", VA = "0xAC3190")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xAC33B0", Offset = "0xAC33B0", VA = "0xAC33B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xAC4114", Offset = "0xAC4114", VA = "0xAC4114")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xAC429C", Offset = "0xAC429C", VA = "0xAC429C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xAC4374", Offset = "0xAC4374", VA = "0xAC4374", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xAC4578", Offset = "0xAC4578", VA = "0xAC4578")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xAC4620", Offset = "0xAC4620", VA = "0xAC4620")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xAC4734", Offset = "0xAC4734", VA = "0xAC4734")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xAC4810", Offset = "0xAC4810", VA = "0xAC4810")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xAC4C14", Offset = "0xAC4C14", VA = "0xAC4C14")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xAC4C48", Offset = "0xAC4C48", VA = "0xAC4C48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xAC4D74", Offset = "0xAC4D74", VA = "0xAC4D74")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class Settings
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0xAC9AE4", Offset = "0xAC9AE4", VA = "0xAC9AE4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000DF")]
			public class Target
			{
				[Token(Token = "0x400066A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400066B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400066C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60006D1")]
				[Address(RVA = "0xAC9C80", Offset = "0xAC9C80", VA = "0xAC9C80")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60006D2")]
				[Address(RVA = "0xAC9D34", Offset = "0xAC9D34", VA = "0xAC9D34")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0xAC9C78", Offset = "0xAC9C78", VA = "0xAC9C78")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xAC4D88", Offset = "0xAC4D88", VA = "0xAC4D88")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xAC4DA0", Offset = "0xAC4DA0", VA = "0xAC4DA0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xAC4EC8", Offset = "0xAC4EC8", VA = "0xAC4EC8")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xAC4DE8", Offset = "0xAC4DE8", VA = "0xAC4DE8")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xAC4EE0", Offset = "0xAC4EE0", VA = "0xAC4EE0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xAC61F0", Offset = "0xAC61F0", VA = "0xAC61F0")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xAC68D0", Offset = "0xAC68D0", VA = "0xAC68D0")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xAC7290", Offset = "0xAC7290", VA = "0xAC7290")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xAC7528", Offset = "0xAC7528", VA = "0xAC7528")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xAC7768", Offset = "0xAC7768", VA = "0xAC7768")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xAC7F14", Offset = "0xAC7F14", VA = "0xAC7F14")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xAC7CFC", Offset = "0xAC7CFC", VA = "0xAC7CFC")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xAC81C8", Offset = "0xAC81C8", VA = "0xAC81C8")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xAC86B8", Offset = "0xAC86B8", VA = "0xAC86B8")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xAC879C", Offset = "0xAC879C", VA = "0xAC879C")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000E0")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xAC9D90", Offset = "0xAC9D90", VA = "0xAC9D90")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xAC9DE8", Offset = "0xAC9DE8", VA = "0xAC9DE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xAC9E10", Offset = "0xAC9E10", VA = "0xAC9E10")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xAC9F30", Offset = "0xAC9F30", VA = "0xAC9F30")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000C1")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0xAC9F48", Offset = "0xAC9F48", VA = "0xAC9F48")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xAC9F54", Offset = "0xAC9F54", VA = "0xAC9F54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xAC9F60", Offset = "0xAC9F60", VA = "0xAC9F60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xACA07C", Offset = "0xACA07C", VA = "0xACA07C")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xACA290", Offset = "0xACA290", VA = "0xACA290")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xACA430", Offset = "0xACA430", VA = "0xACA430")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xACA7F8", Offset = "0xACA7F8", VA = "0xACA7F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xACA924", Offset = "0xACA924", VA = "0xACA924")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000E2")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Offset
		{
			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0xACA9E8", Offset = "0xACA9E8", VA = "0xACA9E8")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xACAC64", Offset = "0xACAC64", VA = "0xACAC64")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xACA92C", Offset = "0xACA92C", VA = "0xACA92C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xACA984", Offset = "0xACA984", VA = "0xACA984")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xACAB98", Offset = "0xACAB98", VA = "0xACAB98")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xACAC5C", Offset = "0xACAC5C", VA = "0xACAC5C")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xACAC6C", Offset = "0xACAC6C", VA = "0xACAC6C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xACACEC", Offset = "0xACACEC", VA = "0xACACEC")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction in which the weapon is aimed in animation (in character space). Tweak this value to adjust the aiming.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xACACF4", Offset = "0xACACF4", VA = "0xACACF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xACAD60", Offset = "0xACAD60", VA = "0xACAD60")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xACADC0", Offset = "0xACADC0", VA = "0xACADC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xACAE78", Offset = "0xACAE78", VA = "0xACAE78")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xACB1A4", Offset = "0xACB1A4", VA = "0xACB1A4")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xACB1AC", Offset = "0xACB1AC", VA = "0xACB1AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xACB1E4", Offset = "0xACB1E4", VA = "0xACB1E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xACB290", Offset = "0xACB290", VA = "0xACB290")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xACB3F8", Offset = "0xACB3F8", VA = "0xACB3F8")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xACB5B4", Offset = "0xACB5B4", VA = "0xACB5B4")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xACB644", Offset = "0xACB644", VA = "0xACB644")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xACB658", Offset = "0xACB658", VA = "0xACB658")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xACB7C4", Offset = "0xACB7C4", VA = "0xACB7C4")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xACB9C0", Offset = "0xACB9C0", VA = "0xACB9C0")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xACB9F0", Offset = "0xACB9F0", VA = "0xACB9F0")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xACBE1C", Offset = "0xACBE1C", VA = "0xACBE1C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000C2")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006F7")]
			[Address(RVA = "0xACBE3C", Offset = "0xACBE3C", VA = "0xACBE3C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xACBE48", Offset = "0xACBE48", VA = "0xACBE48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xACBE54", Offset = "0xACBE54", VA = "0xACBE54")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xACBE84", Offset = "0xACBE84", VA = "0xACBE84")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xACC808", Offset = "0xACC808", VA = "0xACC808")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xACC584", Offset = "0xACC584", VA = "0xACC584")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xACC918", Offset = "0xACC918", VA = "0xACC918")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000C3")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0xACC944", Offset = "0xACC944", VA = "0xACC944")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xACC9C4", Offset = "0xACC9C4", VA = "0xACC9C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xACCD08", Offset = "0xACCD08", VA = "0xACCD08")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600070F")]
				[Address(RVA = "0xACDD60", Offset = "0xACDD60", VA = "0xACDD60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000711")]
				[Address(RVA = "0xACDDA8", Offset = "0xACDDA8", VA = "0xACDDA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xACD9F8", Offset = "0xACD9F8", VA = "0xACD9F8")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xACDAB0", Offset = "0xACDAB0", VA = "0xACDAB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0xACDAB4", Offset = "0xACDAB4", VA = "0xACDAB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0xACDD68", Offset = "0xACDD68", VA = "0xACDD68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000C4")]
		public bool isStepping
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0xACCD1C", Offset = "0xACCD1C", VA = "0xACCD1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public Vector3 position
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xACC8E8", Offset = "0xACC8E8", VA = "0xACC8E8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xACCD30", Offset = "0xACCD30", VA = "0xACCD30")]
			set
			{
			}
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xACCD7C", Offset = "0xACCD7C", VA = "0xACCD7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xACCFFC", Offset = "0xACCFFC", VA = "0xACCFFC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xACD1D4", Offset = "0xACD1D4", VA = "0xACD1D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xACD3F8", Offset = "0xACD3F8", VA = "0xACD3F8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xACD658", Offset = "0xACD658", VA = "0xACD658")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xACD7C0", Offset = "0xACD7C0", VA = "0xACD7C0")]
		private void Update()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xACD348", Offset = "0xACD348", VA = "0xACD348")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xACDA20", Offset = "0xACDA20", VA = "0xACDA20")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xACDDB0", Offset = "0xACDDB0", VA = "0xACDDB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xACDE8C", Offset = "0xACDE8C", VA = "0xACDE8C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xACE100", Offset = "0xACE100", VA = "0xACE100")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public struct Warp
		{
			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public enum EffectorMode
		{
			[Token(Token = "0x40006EA")]
			PositionOffset,
			[Token(Token = "0x40006EB")]
			Position
		}

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xACE108", Offset = "0xACE108", VA = "0xACE108", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xACE128", Offset = "0xACE128", VA = "0xACE128")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xACE340", Offset = "0xACE340", VA = "0xACE340", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xACE5F8", Offset = "0xACE5F8", VA = "0xACE5F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xACE68C", Offset = "0xACE68C", VA = "0xACE68C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xACE694", Offset = "0xACE694", VA = "0xACE694", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xACE6EC", Offset = "0xACE6EC", VA = "0xACE6EC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xACE8F4", Offset = "0xACE8F4", VA = "0xACE8F4", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xACEB1C", Offset = "0xACEB1C", VA = "0xACEB1C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xACEB30", Offset = "0xACEB30", VA = "0xACEB30", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xACED04", Offset = "0xACED04", VA = "0xACED04", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xACED74", Offset = "0xACED74", VA = "0xACED74")]
		private void Read()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xACEEAC", Offset = "0xACEEAC", VA = "0xACEEAC")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xACEF08", Offset = "0xACEF08", VA = "0xACEF08")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xACF550", Offset = "0xACF550", VA = "0xACF550")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xACF364", Offset = "0xACF364", VA = "0xACF364")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xACF7F4", Offset = "0xACF7F4", VA = "0xACF7F4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xACF920", Offset = "0xACF920", VA = "0xACF920")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xACF93C", Offset = "0xACF93C", VA = "0xACF93C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xACF9A0", Offset = "0xACF9A0", VA = "0xACF9A0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xACFCDC", Offset = "0xACFCDC", VA = "0xACFCDC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xACFDCC", Offset = "0xACFDCC", VA = "0xACFDCC")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000C8")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0xAD0034", Offset = "0xAD0034", VA = "0xAD0034")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C9")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xAD00B4", Offset = "0xAD00B4", VA = "0xAD00B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xACFDD4", Offset = "0xACFDD4", VA = "0xACFDD4")]
		private void Start()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xACFE44", Offset = "0xACFE44", VA = "0xACFE44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xAD0134", Offset = "0xAD0134", VA = "0xAD0134")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xAD013C", Offset = "0xAD013C", VA = "0xAD013C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xAD0598", Offset = "0xAD0598", VA = "0xAD0598")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xAD05A0", Offset = "0xAD05A0", VA = "0xAD05A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xAD0658", Offset = "0xAD0658", VA = "0xAD0658")]
		private void Update()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xAD0AB4", Offset = "0xAD0AB4", VA = "0xAD0AB4")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xAD0B54", Offset = "0xAD0B54", VA = "0xAD0B54")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class Limb
		{
			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600073A")]
			[Address(RVA = "0xAD0CE8", Offset = "0xAD0CE8", VA = "0xAD0CE8")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xAD0E0C", Offset = "0xAD0E0C", VA = "0xAD0E0C")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xAD0BC4", Offset = "0xAD0BC4", VA = "0xAD0BC4")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xAD0D60", Offset = "0xAD0D60", VA = "0xAD0D60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xAD0DF8", Offset = "0xAD0DF8", VA = "0xAD0DF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xAD0DFC", Offset = "0xAD0DFC", VA = "0xAD0DFC")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xAD0E1C", Offset = "0xAD0E1C", VA = "0xAD0E1C")]
		private void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xAD0E84", Offset = "0xAD0E84", VA = "0xAD0E84")]
		private void Update()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xAD0F58", Offset = "0xAD0F58", VA = "0xAD0F58")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xAD0F60", Offset = "0xAD0F60", VA = "0xAD0F60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xAD0FB8", Offset = "0xAD0FB8", VA = "0xAD0FB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xAD1150", Offset = "0xAD1150", VA = "0xAD1150")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xAD1158", Offset = "0xAD1158", VA = "0xAD1158")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xAD1238", Offset = "0xAD1238", VA = "0xAD1238")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xAD12C4", Offset = "0xAD12C4", VA = "0xAD12C4")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xAD1798", Offset = "0xAD1798", VA = "0xAD1798")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xAD18C4", Offset = "0xAD18C4", VA = "0xAD18C4")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xAD18CC", Offset = "0xAD18CC", VA = "0xAD18CC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xAD1A68", Offset = "0xAD1A68", VA = "0xAD1A68")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xAD1A74", Offset = "0xAD1A74", VA = "0xAD1A74")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xAD1D34", Offset = "0xAD1D34", VA = "0xAD1D34")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xAD1FD0", Offset = "0xAD1FD0", VA = "0xAD1FD0")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xAD1B38", Offset = "0xAD1B38", VA = "0xAD1B38")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xAD2C88", Offset = "0xAD2C88", VA = "0xAD2C88")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xAD2CA8", Offset = "0xAD2CA8", VA = "0xAD2CA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xAD2D38", Offset = "0xAD2D38", VA = "0xAD2D38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xAD2E34", Offset = "0xAD2E34", VA = "0xAD2E34")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xAD2EE0", Offset = "0xAD2EE0", VA = "0xAD2EE0")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xAD2EF0", Offset = "0xAD2EF0", VA = "0xAD2EF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xAD3040", Offset = "0xAD3040", VA = "0xAD3040")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xAD31A4", Offset = "0xAD31A4", VA = "0xAD31A4")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xAD31B4", Offset = "0xAD31B4", VA = "0xAD31B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xAD3380", Offset = "0xAD3380", VA = "0xAD3380")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xAD3790", Offset = "0xAD3790", VA = "0xAD3790")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xAD37A0", Offset = "0xAD37A0", VA = "0xAD37A0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xAD3888", Offset = "0xAD3888", VA = "0xAD3888")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xAD3974", Offset = "0xAD3974", VA = "0xAD3974")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xAD397C", Offset = "0xAD397C", VA = "0xAD397C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xAD3E7C", Offset = "0xAD3E7C", VA = "0xAD3E7C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xAD3E84", Offset = "0xAD3E84", VA = "0xAD3E84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xAD3EDC", Offset = "0xAD3EDC", VA = "0xAD3EDC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xAD4188", Offset = "0xAD4188", VA = "0xAD4188")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class Partner
		{
			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000CA")]
			private Transform neck
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0xAD4994", Offset = "0xAD4994", VA = "0xAD4994")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xAD41B8", Offset = "0xAD41B8", VA = "0xAD41B8")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xAD4234", Offset = "0xAD4234", VA = "0xAD4234")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xAD482C", Offset = "0xAD482C", VA = "0xAD482C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xAD49E0", Offset = "0xAD49E0", VA = "0xAD49E0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xAD4190", Offset = "0xAD4190", VA = "0xAD4190")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xAD41D8", Offset = "0xAD41D8", VA = "0xAD41D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xAD481C", Offset = "0xAD481C", VA = "0xAD481C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000107")]
		public enum Mode
		{
			[Token(Token = "0x4000777")]
			Position,
			[Token(Token = "0x4000778")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public class Absorber
		{
			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xAD4B6C", Offset = "0xAD4B6C", VA = "0xAD4B6C")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xAD4D54", Offset = "0xAD4D54", VA = "0xAD4D54")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0xAD4D78", Offset = "0xAD4D78", VA = "0xAD4D78")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xAD4E88", Offset = "0xAD4E88", VA = "0xAD4E88")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xAD5040", Offset = "0xAD5040", VA = "0xAD5040")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xAD49F4", Offset = "0xAD49F4", VA = "0xAD49F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xAD4AEC", Offset = "0xAD4AEC", VA = "0xAD4AEC")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xAD4C48", Offset = "0xAD4C48", VA = "0xAD4C48", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xAD4E0C", Offset = "0xAD4E0C", VA = "0xAD4E0C")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xAD4EF8", Offset = "0xAD4EF8", VA = "0xAD4EF8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xAD5030", Offset = "0xAD5030", VA = "0xAD5030")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xAD50A0", Offset = "0xAD50A0", VA = "0xAD50A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xAD5118", Offset = "0xAD5118", VA = "0xAD5118")]
		private void Update()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xAD51E8", Offset = "0xAD51E8", VA = "0xAD51E8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xAD5330", Offset = "0xAD5330", VA = "0xAD5330")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class EffectorLink
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xAD58B8", Offset = "0xAD58B8", VA = "0xAD58B8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Optional. Assign the bone Transform that is closest to this OffsetEffector to be able to call OffsetEffector.Anchor() in LateUpdate to match its position and rotation to animation.")]
		public Transform anchor;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xAD5344", Offset = "0xAD5344", VA = "0xAD5344", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xAD558C", Offset = "0xAD558C", VA = "0xAD558C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xAD5704", Offset = "0xAD5704", VA = "0xAD5704")]
		public void Anchor()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xAD5860", Offset = "0xAD5860", VA = "0xAD5860")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xAD58C8", Offset = "0xAD58C8", VA = "0xAD58C8")]
		private void Start()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xAD5BDC", Offset = "0xAD5BDC", VA = "0xAD5BDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xAD63D8", Offset = "0xAD63D8", VA = "0xAD63D8")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000CB")]
		private bool holding
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xAD67D0", Offset = "0xAD67D0", VA = "0xAD67D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		private bool holdingLeft
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xAD68A0", Offset = "0xAD68A0", VA = "0xAD68A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private bool holdingRight
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xAD67F8", Offset = "0xAD67F8", VA = "0xAD67F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xAD6444", Offset = "0xAD6444", VA = "0xAD6444")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000780")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xAD6948", Offset = "0xAD6948", VA = "0xAD6948")]
		private void Start()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xAD6B38", Offset = "0xAD6B38", VA = "0xAD6B38")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xAD6CA8", Offset = "0xAD6CA8", VA = "0xAD6CA8")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xAD6D78", Offset = "0xAD6D78", VA = "0xAD6D78")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xAD6EA4", Offset = "0xAD6EA4", VA = "0xAD6EA4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xAD7024", Offset = "0xAD7024", VA = "0xAD7024")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xAD7260", Offset = "0xAD7260", VA = "0xAD7260")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600078B")]
		[Address(RVA = "0xAD7274", Offset = "0xAD7274", VA = "0xAD7274", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xAD7454", Offset = "0xAD7454", VA = "0xAD7454")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600078D")]
		[Address(RVA = "0xAD7468", Offset = "0xAD7468", VA = "0xAD7468", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xAD757C", Offset = "0xAD757C", VA = "0xAD757C")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xAD7590", Offset = "0xAD7590", VA = "0xAD7590")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xAD7628", Offset = "0xAD7628", VA = "0xAD7628")]
		private void Update()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xAD7740", Offset = "0xAD7740", VA = "0xAD7740")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xAD7748", Offset = "0xAD7748", VA = "0xAD7748")]
		private void Start()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xAD77A0", Offset = "0xAD77A0", VA = "0xAD77A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xAD77EC", Offset = "0xAD77EC", VA = "0xAD77EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xAD7884", Offset = "0xAD7884", VA = "0xAD7884")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000113")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0xAD7C14", Offset = "0xAD7C14", VA = "0xAD7C14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079F")]
				[Address(RVA = "0xAD7C5C", Offset = "0xAD7C5C", VA = "0xAD7C5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0xAD7A30", Offset = "0xAD7A30", VA = "0xAD7A30")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0xAD7A68", Offset = "0xAD7A68", VA = "0xAD7A68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xAD7A6C", Offset = "0xAD7A6C", VA = "0xAD7A6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xAD7C1C", Offset = "0xAD7C1C", VA = "0xAD7C1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xAD7894", Offset = "0xAD7894", VA = "0xAD7894")]
		private void Start()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xAD7958", Offset = "0xAD7958", VA = "0xAD7958")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xAD79AC", Offset = "0xAD79AC", VA = "0xAD79AC")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xAD7A58", Offset = "0xAD7A58", VA = "0xAD7A58")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000115")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0xAD7F00", Offset = "0xAD7F00", VA = "0xAD7F00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0xAD7F48", Offset = "0xAD7F48", VA = "0xAD7F48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xAD7D8C", Offset = "0xAD7D8C", VA = "0xAD7D8C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xAD7DBC", Offset = "0xAD7DBC", VA = "0xAD7DBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xAD7DC0", Offset = "0xAD7DC0", VA = "0xAD7DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xAD7F08", Offset = "0xAD7F08", VA = "0xAD7F08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xAD7C64", Offset = "0xAD7C64", VA = "0xAD7C64")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xAD7D18", Offset = "0xAD7D18", VA = "0xAD7D18")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xAD7DB4", Offset = "0xAD7DB4", VA = "0xAD7DB4")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000117")]
		public class EffectorLink
		{
			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0xAD7FB4", Offset = "0xAD7FB4", VA = "0xAD7FB4")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xAD8B88", Offset = "0xAD8B88", VA = "0xAD8B88")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xAD83BC", Offset = "0xAD83BC", VA = "0xAD83BC")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xAD8C70", Offset = "0xAD8C70", VA = "0xAD8C70")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xAD8D54", Offset = "0xAD8D54", VA = "0xAD8D54")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xAD8DE0", Offset = "0xAD8DE0", VA = "0xAD8DE0")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xAD8E68", Offset = "0xAD8E68", VA = "0xAD8E68")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xAD8974", Offset = "0xAD8974", VA = "0xAD8974")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xAD8EF0", Offset = "0xAD8EF0", VA = "0xAD8EF0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xAD7F50", Offset = "0xAD7F50", VA = "0xAD7F50")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xAD835C", Offset = "0xAD835C", VA = "0xAD835C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xAD88C4", Offset = "0xAD88C4", VA = "0xAD88C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xAD8B80", Offset = "0xAD8B80", VA = "0xAD8B80")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xAD8F2C", Offset = "0xAD8F2C", VA = "0xAD8F2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xAD8F5C", Offset = "0xAD8F5C", VA = "0xAD8F5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xAD900C", Offset = "0xAD900C", VA = "0xAD900C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Left hand poser (poses fingers to match the left hand target).")]
		public Poser leftHandPoser;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The weight of pinning the left hand to the prop.")]
		[Range(0f, 1f)]
		public float leftHandWeight;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xAD9020", Offset = "0xAD9020", VA = "0xAD9020")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xAD91F0", Offset = "0xAD91F0", VA = "0xAD91F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xAD94E8", Offset = "0xAD94E8", VA = "0xAD94E8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xAD9688", Offset = "0xAD9688", VA = "0xAD9688")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xAD97B4", Offset = "0xAD97B4", VA = "0xAD97B4")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xAD97C8", Offset = "0xAD97C8", VA = "0xAD97C8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xAD98E0", Offset = "0xAD98E0", VA = "0xAD98E0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xAD9AA8", Offset = "0xAD9AA8", VA = "0xAD9AA8")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xAD9AC4", Offset = "0xAD9AC4", VA = "0xAD9AC4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xAD9CCC", Offset = "0xAD9CCC", VA = "0xAD9CCC")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xAD9D38", Offset = "0xAD9D38", VA = "0xAD9D38")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0xADA4A8", Offset = "0xADA4A8", VA = "0xADA4A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0xADA4F0", Offset = "0xADA4F0", VA = "0xADA4F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xADA130", Offset = "0xADA130", VA = "0xADA130")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xADA320", Offset = "0xADA320", VA = "0xADA320", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xADA324", Offset = "0xADA324", VA = "0xADA324", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xADA4B0", Offset = "0xADA4B0", VA = "0xADA4B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xAD9D40", Offset = "0xAD9D40", VA = "0xAD9D40")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xAD9E7C", Offset = "0xAD9E7C", VA = "0xAD9E7C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xAD9E08", Offset = "0xAD9E08", VA = "0xAD9E08")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xADA158", Offset = "0xADA158", VA = "0xADA158")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xADA230", Offset = "0xADA230", VA = "0xADA230")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xADA304", Offset = "0xADA304", VA = "0xADA304")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xADA4F8", Offset = "0xADA4F8", VA = "0xADA4F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xADA560", Offset = "0xADA560", VA = "0xADA560")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xADA60C", Offset = "0xADA60C", VA = "0xADA60C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public class Part
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0xADA680", Offset = "0xADA680", VA = "0xADA680")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xADA7BC", Offset = "0xADA7BC", VA = "0xADA7BC")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xADA61C", Offset = "0xADA61C", VA = "0xADA61C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xADA7B4", Offset = "0xADA7B4", VA = "0xADA7B4")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xADA7C4", Offset = "0xADA7C4", VA = "0xADA7C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xADA914", Offset = "0xADA914", VA = "0xADA914")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xADAA78", Offset = "0xADAA78", VA = "0xADAA78")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class VRController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public enum InputMode
		{
			[Token(Token = "0x4000804")]
			Input,
			[Token(Token = "0x4000805")]
			WASDOnly
		}

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputMode inputMode;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float walkSpeed;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float runSpeed;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float walkForwardSpeedMlp;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float runForwardSpeedMlp;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 smoothInput;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 smoothInputV;

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xADAA88", Offset = "0xADAA88", VA = "0xADAA88")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xADAC7C", Offset = "0xADAC7C", VA = "0xADAC7C")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xADAFC4", Offset = "0xADAFC4", VA = "0xADAFC4")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Left Hand Controller")]
		[Header("Hands")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xADAFD8", Offset = "0xADAFD8", VA = "0xADAFD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xADB16C", Offset = "0xADB16C", VA = "0xADB16C")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xADB1E8", Offset = "0xADB1E8", VA = "0xADB1E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xADB34C", Offset = "0xADB34C", VA = "0xADB34C")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xADC3C0", Offset = "0xADC3C0", VA = "0xADC3C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xADC410", Offset = "0xADC410", VA = "0xADC410")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xADC5E8", Offset = "0xADC5E8", VA = "0xADC5E8")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xADC640", Offset = "0xADC640", VA = "0xADC640")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xADCB70", Offset = "0xADCB70", VA = "0xADCB70")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000D4")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0xADCBEC", Offset = "0xADCBEC", VA = "0xADCBEC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xADCBCC", Offset = "0xADCBCC", VA = "0xADCBCC", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xADCBF4", Offset = "0xADCBF4", VA = "0xADCBF4")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xADCC54", Offset = "0xADCC54", VA = "0xADCC54", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xADCDD8", Offset = "0xADCDD8", VA = "0xADCDD8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xADD054", Offset = "0xADD054", VA = "0xADD054", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xADCDE8", Offset = "0xADCDE8", VA = "0xADCDE8")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xADD064", Offset = "0xADD064", VA = "0xADD064")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xADD07C", Offset = "0xADD07C", VA = "0xADD07C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xADD0DC", Offset = "0xADD0DC", VA = "0xADD0DC", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xADD16C", Offset = "0xADD16C", VA = "0xADD16C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xADD290", Offset = "0xADD290", VA = "0xADD290")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000835")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000836")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000D5")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0xADD34C", Offset = "0xADD34C", VA = "0xADD34C", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xADD2A8", Offset = "0xADD2A8", VA = "0xADD2A8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xADD330", Offset = "0xADD330", VA = "0xADD330", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xADD440", Offset = "0xADD440", VA = "0xADD440", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xADD830", Offset = "0xADD830", VA = "0xADD830")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xADDA74", Offset = "0xADDA74", VA = "0xADDA74")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000844")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007F8")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xADDA98", Offset = "0xADDA98", VA = "0xADDA98")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xADDC84", Offset = "0xADDC84", VA = "0xADDC84", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xADDEB0", Offset = "0xADDEB0", VA = "0xADDEB0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xADE050", Offset = "0xADE050", VA = "0xADE050")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xADE0B0", Offset = "0xADE0B0", VA = "0xADE0B0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xADE214", Offset = "0xADE214", VA = "0xADE214")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xADE418", Offset = "0xADE418", VA = "0xADE418")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xADE43C", Offset = "0xADE43C", VA = "0xADE43C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xADE460", Offset = "0xADE460", VA = "0xADE460")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xADE5AC", Offset = "0xADE5AC", VA = "0xADE5AC")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200012D")]
		public enum MoveMode
		{
			[Token(Token = "0x4000883")]
			Directional,
			[Token(Token = "0x4000884")]
			Strafe
		}

		[Token(Token = "0x200012E")]
		public struct AnimState
		{
			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200012F")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600081A")]
				[Address(RVA = "0xAE10C8", Offset = "0xAE10C8", VA = "0xAE10C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081C")]
				[Address(RVA = "0xAE1110", Offset = "0xAE1110", VA = "0xAE1110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xAE0E88", Offset = "0xAE0E88", VA = "0xAE0E88")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xAE0FC4", Offset = "0xAE0FC4", VA = "0xAE0FC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xAE0FC8", Offset = "0xAE0FC8", VA = "0xAE0FC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0xAE10D0", Offset = "0xAE10D0", VA = "0xAE10D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000D6")]
		public bool fullRootMotion
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0xADE5CC", Offset = "0xADE5CC", VA = "0xADE5CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xADE5D4", Offset = "0xADE5D4", VA = "0xADE5D4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool onGround
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xADE5E0", Offset = "0xADE5E0", VA = "0xADE5E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xADE5E8", Offset = "0xADE5E8", VA = "0xADE5E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xADE5F4", Offset = "0xADE5F4", VA = "0xADE5F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xADE7E0", Offset = "0xADE7E0", VA = "0xADE7E0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xADE864", Offset = "0xADE864", VA = "0xADE864", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xADE978", Offset = "0xADE978", VA = "0xADE978")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xADFA0C", Offset = "0xADFA0C", VA = "0xADFA0C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xADFE9C", Offset = "0xADFE9C", VA = "0xADFE9C", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xADF06C", Offset = "0xADF06C", VA = "0xADF06C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xADFF74", Offset = "0xADFF74", VA = "0xADFF74")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xAE05FC", Offset = "0xAE05FC", VA = "0xAE05FC")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xADFA98", Offset = "0xADFA98", VA = "0xADFA98")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xAE06F4", Offset = "0xAE06F4", VA = "0xAE06F4", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xAE0B74", Offset = "0xAE0B74", VA = "0xAE0B74")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xAE0C9C", Offset = "0xAE0C9C", VA = "0xAE0C9C", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xAE0DF0", Offset = "0xAE0DF0", VA = "0xAE0DF0")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__79))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xADF4A0", Offset = "0xADF4A0", VA = "0xADF4A0")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xAE0EB0", Offset = "0xAE0EB0", VA = "0xAE0EB0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000131")]
		public enum RotationMode
		{
			[Token(Token = "0x40008A0")]
			Smooth,
			[Token(Token = "0x40008A1")]
			Linear
		}

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000DA")]
		public bool isGrounded
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0xAE1118", Offset = "0xAE1118", VA = "0xAE1118")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xAE1120", Offset = "0xAE1120", VA = "0xAE1120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xAE112C", Offset = "0xAE112C", VA = "0xAE112C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xAE11D4", Offset = "0xAE11D4", VA = "0xAE11D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xAE17EC", Offset = "0xAE17EC", VA = "0xAE17EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xAE121C", Offset = "0xAE121C", VA = "0xAE121C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xAE1584", Offset = "0xAE1584", VA = "0xAE1584")]
		private void Move()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xAE181C", Offset = "0xAE181C", VA = "0xAE181C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xAE18B4", Offset = "0xAE18B4", VA = "0xAE18B4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xAE1934", Offset = "0xAE1934", VA = "0xAE1934")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xAE195C", Offset = "0xAE195C", VA = "0xAE195C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xAE1AA4", Offset = "0xAE1AA4", VA = "0xAE1AA4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xAE211C", Offset = "0xAE211C", VA = "0xAE211C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xAE2308", Offset = "0xAE2308", VA = "0xAE2308")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000134")]
		public struct State
		{
			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xAE1998", Offset = "0xAE1998", VA = "0xAE1998", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xAE2334", Offset = "0xAE2334", VA = "0xAE2334", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xAE2324", Offset = "0xAE2324", VA = "0xAE2324")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0xAE2678", Offset = "0xAE2678", VA = "0xAE2678")]
		private void Update()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xAE26B0", Offset = "0xAE26B0", VA = "0xAE26B0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xAE26B8", Offset = "0xAE26B8", VA = "0xAE26B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xAE26E0", Offset = "0xAE26E0", VA = "0xAE26E0")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xAE2784", Offset = "0xAE2784", VA = "0xAE2784")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000137")]
	public class Navigator
	{
		[Token(Token = "0x2000138")]
		public enum State
		{
			[Token(Token = "0x40008C3")]
			Idle,
			[Token(Token = "0x40008C4")]
			Seeking,
			[Token(Token = "0x40008C5")]
			OnPath
		}

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000DB")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0xAE2798", Offset = "0xAE2798", VA = "0xAE2798")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xAE27A4", Offset = "0xAE27A4", VA = "0xAE27A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public State state
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xAE27B0", Offset = "0xAE27B0", VA = "0xAE27B0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xAE27B8", Offset = "0xAE27B8", VA = "0xAE27B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xAE19CC", Offset = "0xAE19CC", VA = "0xAE19CC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xAE1CC4", Offset = "0xAE1CC4", VA = "0xAE1CC4")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xAE2898", Offset = "0xAE2898", VA = "0xAE2898")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xAE28FC", Offset = "0xAE28FC", VA = "0xAE28FC")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xAE27C0", Offset = "0xAE27C0", VA = "0xAE27C0")]
		private void Stop()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xAE281C", Offset = "0xAE281C", VA = "0xAE281C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xAE2144", Offset = "0xAE2144", VA = "0xAE2144")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xAE2A30", Offset = "0xAE2A30", VA = "0xAE2A30")]
		public Navigator()
		{
		}
	}
}
