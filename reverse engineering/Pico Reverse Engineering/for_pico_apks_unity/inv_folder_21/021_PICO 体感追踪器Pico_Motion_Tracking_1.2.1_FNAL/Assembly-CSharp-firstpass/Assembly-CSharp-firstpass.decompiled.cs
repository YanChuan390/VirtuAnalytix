using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using Unity.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
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
			[Address(RVA = "0x1026018", Offset = "0x1026018", VA = "0x1026018")]
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
			[Address(RVA = "0x1025D60", Offset = "0x1025D60", VA = "0x1025D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x1025D68", Offset = "0x1025D68", VA = "0x1025D68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1025D74", Offset = "0x1025D74", VA = "0x1025D74")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1025D7C", Offset = "0x1025D7C", VA = "0x1025D7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1025D84", Offset = "0x1025D84", VA = "0x1025D84")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1025D8C", Offset = "0x1025D8C", VA = "0x1025D8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1025C50", Offset = "0x1025C50", VA = "0x1025C50")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1025C94", Offset = "0x1025C94", VA = "0x1025C94")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1025CD8", Offset = "0x1025CD8", VA = "0x1025CD8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1025D1C", Offset = "0x1025D1C", VA = "0x1025D1C")]
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
		[Address(RVA = "0x1025D94", Offset = "0x1025D94", VA = "0x1025D94")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1025D98", Offset = "0x1025D98", VA = "0x1025D98")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1025D9C", Offset = "0x1025D9C", VA = "0x1025D9C")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1025DA0", Offset = "0x1025DA0", VA = "0x1025DA0")]
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
		[Address(RVA = "0x1026020", Offset = "0x1026020", VA = "0x1026020")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x102643C", Offset = "0x102643C", VA = "0x102643C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1026444", Offset = "0x1026444", VA = "0x1026444", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1026630", Offset = "0x1026630", VA = "0x1026630", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1026894", Offset = "0x1026894", VA = "0x1026894", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1026BAC", Offset = "0x1026BAC", VA = "0x1026BAC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1026238", Offset = "0x1026238", VA = "0x1026238")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x10262F0", Offset = "0x10262F0", VA = "0x10262F0")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1026E0C", Offset = "0x1026E0C", VA = "0x1026E0C")]
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
		[Address(RVA = "0x1026E68", Offset = "0x1026E68", VA = "0x1026E68")]
		public TQ()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1026E70", Offset = "0x1026E70", VA = "0x1026E70")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1026ED4", Offset = "0x1026ED4", VA = "0x1026ED4")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1027124", Offset = "0x1027124", VA = "0x1027124")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x102777C", Offset = "0x102777C", VA = "0x102777C")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1027C2C", Offset = "0x1027C2C", VA = "0x1027C2C")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1027104", Offset = "0x1027104", VA = "0x1027104")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1027E18", Offset = "0x1027E18", VA = "0x1027E18")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1027E20", Offset = "0x1027E20", VA = "0x1027E20")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1027E58", Offset = "0x1027E58", VA = "0x1027E58")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x102821C", Offset = "0x102821C", VA = "0x102821C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x10283FC", Offset = "0x10283FC", VA = "0x10283FC")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1028400", Offset = "0x1028400", VA = "0x1028400")]
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
		[Address(RVA = "0x1028594", Offset = "0x1028594", VA = "0x1028594")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1028850", Offset = "0x1028850", VA = "0x1028850")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10289D8", Offset = "0x10289D8", VA = "0x10289D8")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1028A68", Offset = "0x1028A68", VA = "0x1028A68")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1027D50", Offset = "0x1027D50", VA = "0x1027D50")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1028ADC", Offset = "0x1028ADC", VA = "0x1028ADC")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x102870C", Offset = "0x102870C", VA = "0x102870C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1028AE0", Offset = "0x1028AE0", VA = "0x1028AE0")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1028E70", Offset = "0x1028E70", VA = "0x1028E70")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1028F60", Offset = "0x1028F60", VA = "0x1028F60")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1029044", Offset = "0x1029044", VA = "0x1029044")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x10290AC", Offset = "0x10290AC", VA = "0x10290AC")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1028FC8", Offset = "0x1028FC8", VA = "0x1028FC8")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x10290B0", Offset = "0x10290B0", VA = "0x10290B0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1029158", Offset = "0x1029158", VA = "0x1029158")]
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
		[Address(RVA = "0x1029444", Offset = "0x1029444", VA = "0x1029444")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x10294A8", Offset = "0x10294A8", VA = "0x10294A8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1029F3C", Offset = "0x1029F3C", VA = "0x1029F3C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1029FE4", Offset = "0x1029FE4", VA = "0x1029FE4")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1029EDC", Offset = "0x1029EDC", VA = "0x1029EDC")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x102A0D8", Offset = "0x102A0D8", VA = "0x102A0D8")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x102A114", Offset = "0x102A114", VA = "0x102A114")]
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
		[Address(RVA = "0x10263A8", Offset = "0x10263A8", VA = "0x10263A8")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x102661C", Offset = "0x102661C", VA = "0x102661C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x10268F8", Offset = "0x10268F8", VA = "0x10268F8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x102A11C", Offset = "0x102A11C", VA = "0x102A11C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1026514", Offset = "0x1026514", VA = "0x1026514")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x102A3A4", Offset = "0x102A3A4", VA = "0x102A3A4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1026C18", Offset = "0x1026C18", VA = "0x1026C18")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x102669C", Offset = "0x102669C", VA = "0x102669C")]
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
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
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
		[Address(RVA = "0x102A40C", Offset = "0x102A40C", VA = "0x102A40C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x102A8C4", Offset = "0x102A8C4", VA = "0x102A8C4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x102A8E0", Offset = "0x102A8E0", VA = "0x102A8E0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x102A9B8", Offset = "0x102A9B8", VA = "0x102A9B8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x102AA74", Offset = "0x102AA74", VA = "0x102AA74", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x102AC14", Offset = "0x102AC14", VA = "0x102AC14", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x102AF38", Offset = "0x102AF38", VA = "0x102AF38")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x102B018", Offset = "0x102B018", VA = "0x102B018")]
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
			[Address(RVA = "0x102B0BC", Offset = "0x102B0BC", VA = "0x102B0BC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x102B0C4", Offset = "0x102B0C4", VA = "0x102B0C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x102B0CC", Offset = "0x102B0CC", VA = "0x102B0CC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x102B0D4", Offset = "0x102B0D4", VA = "0x102B0D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x102B0DC", Offset = "0x102B0DC", VA = "0x102B0DC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x102B0E4", Offset = "0x102B0E4", VA = "0x102B0E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x102BB3C", Offset = "0x102BB3C", VA = "0x102BB3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x102B0EC", Offset = "0x102B0EC", VA = "0x102B0EC")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x102B124", Offset = "0x102B124", VA = "0x102B124")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x102B12C", Offset = "0x102B12C", VA = "0x102B12C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x102B254", Offset = "0x102B254", VA = "0x102B254", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x102B29C", Offset = "0x102B29C", VA = "0x102B29C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x102B2F4", Offset = "0x102B2F4", VA = "0x102B2F4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x102B34C", Offset = "0x102B34C", VA = "0x102B34C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x102B280", Offset = "0x102B280", VA = "0x102B280")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x102B4D8", Offset = "0x102B4D8", VA = "0x102B4D8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x102BB00", Offset = "0x102BB00", VA = "0x102BB00")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x102BBA8", Offset = "0x102BBA8", VA = "0x102BBA8")]
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
		[Address(RVA = "0x102BC70", Offset = "0x102BC70", VA = "0x102BC70")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x102BC9C", Offset = "0x102BC9C", VA = "0x102BC9C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x102BEC0", Offset = "0x102BEC0", VA = "0x102BEC0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x102BEFC", Offset = "0x102BEFC", VA = "0x102BEFC")]
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
		[Address(RVA = "0x102BF18", Offset = "0x102BF18", VA = "0x102BF18")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x102BFF8", Offset = "0x102BFF8", VA = "0x102BFF8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x102C030", Offset = "0x102C030", VA = "0x102C030")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x102C178", Offset = "0x102C178", VA = "0x102C178")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x102C12C", Offset = "0x102C12C", VA = "0x102C12C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x102C274", Offset = "0x102C274", VA = "0x102C274")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x102C2B8", Offset = "0x102C2B8", VA = "0x102C2B8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x102C578", Offset = "0x102C578", VA = "0x102C578")]
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
			[Address(RVA = "0x102C874", Offset = "0x102C874", VA = "0x102C874")]
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
			[Address(RVA = "0x102C5C0", Offset = "0x102C5C0", VA = "0x102C5C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x102C8E8", Offset = "0x102C8E8", VA = "0x102C8E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x102C580", Offset = "0x102C580", VA = "0x102C580")]
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
		[Address(RVA = "0x102CB9C", Offset = "0x102CB9C", VA = "0x102CB9C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x102CE60", Offset = "0x102CE60", VA = "0x102CE60")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x102D094", Offset = "0x102D094", VA = "0x102D094")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x102D108", Offset = "0x102D108", VA = "0x102D108")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x102D19C", Offset = "0x102D19C", VA = "0x102D19C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x102CD48", Offset = "0x102CD48", VA = "0x102CD48")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x102D00C", Offset = "0x102D00C", VA = "0x102D00C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x102D8D4", Offset = "0x102D8D4", VA = "0x102D8D4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x102D72C", Offset = "0x102D72C", VA = "0x102D72C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x102D800", Offset = "0x102D800", VA = "0x102D800")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x102D384", Offset = "0x102D384", VA = "0x102D384")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x102D420", Offset = "0x102D420", VA = "0x102D420")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x102D4BC", Offset = "0x102D4BC", VA = "0x102D4BC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x102D558", Offset = "0x102D558", VA = "0x102D558")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x102D5F4", Offset = "0x102D5F4", VA = "0x102D5F4")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x102D690", Offset = "0x102D690", VA = "0x102D690")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x102DABC", Offset = "0x102DABC", VA = "0x102DABC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x102D2B0", Offset = "0x102D2B0", VA = "0x102D2B0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x102DA38", Offset = "0x102DA38", VA = "0x102DA38")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x102DB1C", Offset = "0x102DB1C", VA = "0x102DB1C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x102DBDC", Offset = "0x102DBDC", VA = "0x102DBDC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x102D9C4", Offset = "0x102D9C4", VA = "0x102D9C4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x102D954", Offset = "0x102D954", VA = "0x102D954")]
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
				[Address(RVA = "0x10334F0", Offset = "0x10334F0", VA = "0x10334F0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x10334DC", Offset = "0x10334DC", VA = "0x10334DC")]
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
			[Address(RVA = "0x102FBD4", Offset = "0x102FBD4", VA = "0x102FBD4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x102FF30", Offset = "0x102FF30", VA = "0x102FF30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x102FF40", Offset = "0x102FF40", VA = "0x102FF40", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x10302CC", Offset = "0x10302CC", VA = "0x10302CC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x103065C", Offset = "0x103065C", VA = "0x103065C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1030C80", Offset = "0x1030C80", VA = "0x1030C80")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x10308BC", Offset = "0x10308BC", VA = "0x10308BC")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x103147C", Offset = "0x103147C", VA = "0x103147C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x103155C", Offset = "0x103155C", VA = "0x103155C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1031FD4", Offset = "0x1031FD4", VA = "0x1031FD4")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1031DF4", Offset = "0x1031DF4", VA = "0x1031DF4")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1031B94", Offset = "0x1031B94", VA = "0x1031B94")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x10315F8", Offset = "0x10315F8", VA = "0x10315F8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1031EE8", Offset = "0x1031EE8", VA = "0x1031EE8")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x10320B4", Offset = "0x10320B4", VA = "0x10320B4")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1032B74", Offset = "0x1032B74", VA = "0x1032B74")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1032634", Offset = "0x1032634", VA = "0x1032634")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1032E48", Offset = "0x1032E48", VA = "0x1032E48")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1032988", Offset = "0x1032988", VA = "0x1032988")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1032E50", Offset = "0x1032E50", VA = "0x1032E50")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1032E58", Offset = "0x1032E58", VA = "0x1032E58")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x103300C", Offset = "0x103300C", VA = "0x103300C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1033474", Offset = "0x1033474", VA = "0x1033474")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1030854", Offset = "0x1030854", VA = "0x1030854")]
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
		[Address(RVA = "0x10334F8", Offset = "0x10334F8", VA = "0x10334F8")]
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
		[Address(RVA = "0x1033500", Offset = "0x1033500", VA = "0x1033500")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10335F8", Offset = "0x10335F8", VA = "0x10335F8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Hierarchy
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x10333F0", Offset = "0x10333F0", VA = "0x10333F0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x10332E4", Offset = "0x10332E4", VA = "0x10332E4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x10316D4", Offset = "0x10316D4", VA = "0x10316D4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1031CE4", Offset = "0x1031CE4", VA = "0x1031CE4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1031954", Offset = "0x1031954", VA = "0x1031954")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1033608", Offset = "0x1033608", VA = "0x1033608")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1031804", Offset = "0x1031804", VA = "0x1031804")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x10336FC", Offset = "0x10336FC", VA = "0x10336FC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1033A68", Offset = "0x1033A68", VA = "0x1033A68")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1033860", Offset = "0x1033860", VA = "0x1033860")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1033BF0", Offset = "0x1033BF0", VA = "0x1033BF0")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1033BF8", Offset = "0x1033BF8", VA = "0x1033BF8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1033C60", Offset = "0x1033C60", VA = "0x1033C60")]
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
		[Address(RVA = "0x1033CC8", Offset = "0x1033CC8", VA = "0x1033CC8")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1034650", Offset = "0x1034650", VA = "0x1034650")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x10346C0", Offset = "0x10346C0", VA = "0x10346C0")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x10340C8", Offset = "0x10340C8", VA = "0x10340C8")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x10340D4", Offset = "0x10340D4", VA = "0x10340D4")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x10340F8", Offset = "0x10340F8", VA = "0x10340F8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1034134", Offset = "0x1034134", VA = "0x1034134")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x103414C", Offset = "0x103414C", VA = "0x103414C")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1034160", Offset = "0x1034160", VA = "0x1034160")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1034174", Offset = "0x1034174", VA = "0x1034174")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1034184", Offset = "0x1034184", VA = "0x1034184")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x10341CC", Offset = "0x10341CC", VA = "0x10341CC")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1034204", Offset = "0x1034204", VA = "0x1034204")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x103422C", Offset = "0x103422C", VA = "0x103422C")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1034730", Offset = "0x1034730", VA = "0x1034730")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1034260", Offset = "0x1034260", VA = "0x1034260")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1034288", Offset = "0x1034288", VA = "0x1034288")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x10342B8", Offset = "0x10342B8", VA = "0x10342B8")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x10342EC", Offset = "0x10342EC", VA = "0x10342EC")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1034330", Offset = "0x1034330", VA = "0x1034330")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1034394", Offset = "0x1034394", VA = "0x1034394")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x10343F8", Offset = "0x10343F8", VA = "0x10343F8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x103444C", Offset = "0x103444C", VA = "0x103444C")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x10344A0", Offset = "0x10344A0", VA = "0x10344A0")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x10344D8", Offset = "0x10344D8", VA = "0x10344D8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x103450C", Offset = "0x103450C", VA = "0x103450C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1034764", Offset = "0x1034764", VA = "0x1034764")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1034550", Offset = "0x1034550", VA = "0x1034550")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x10345E0", Offset = "0x10345E0", VA = "0x10345E0")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1034610", Offset = "0x1034610", VA = "0x1034610")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x10347F4", Offset = "0x10347F4", VA = "0x10347F4")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x10347FC", Offset = "0x10347FC", VA = "0x10347FC")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1034848", Offset = "0x1034848", VA = "0x1034848")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1034904", Offset = "0x1034904", VA = "0x1034904")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x103485C", Offset = "0x103485C", VA = "0x103485C")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1034918", Offset = "0x1034918", VA = "0x1034918")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x10349A8", Offset = "0x10349A8", VA = "0x10349A8")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x10349D0", Offset = "0x10349D0", VA = "0x10349D0")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1034A1C", Offset = "0x1034A1C", VA = "0x1034A1C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1034A84", Offset = "0x1034A84", VA = "0x1034A84")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1034BD8", Offset = "0x1034BD8", VA = "0x1034BD8")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1034D10", Offset = "0x1034D10", VA = "0x1034D10")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1034D68", Offset = "0x1034D68", VA = "0x1034D68")]
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
			[Address(RVA = "0x1034D8C", Offset = "0x1034D8C", VA = "0x1034D8C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1034D94", Offset = "0x1034D94", VA = "0x1034D94")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public object propValue
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1034D9C", Offset = "0x1034D9C", VA = "0x1034D9C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1034DA4", Offset = "0x1034DA4", VA = "0x1034DA4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public object otherPropValue
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1034DAC", Offset = "0x1034DAC", VA = "0x1034DAC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1034DB4", Offset = "0x1034DB4", VA = "0x1034DB4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool indent
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1034DBC", Offset = "0x1034DBC", VA = "0x1034DBC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1034DC4", Offset = "0x1034DC4", VA = "0x1034DC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1034DD0", Offset = "0x1034DD0", VA = "0x1034DD0")]
			[CompilerGenerated]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1034DD8", Offset = "0x1034DD8", VA = "0x1034DD8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1034DE0", Offset = "0x1034DE0", VA = "0x1034DE0")]
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
			[Address(RVA = "0x1034E38", Offset = "0x1034E38", VA = "0x1034E38")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1034E40", Offset = "0x1034E40", VA = "0x1034E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float max
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1034E48", Offset = "0x1034E48", VA = "0x1034E48")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1034E50", Offset = "0x1034E50", VA = "0x1034E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1034E58", Offset = "0x1034E58", VA = "0x1034E58")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string color;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1034EC4", Offset = "0x1034EC4", VA = "0x1034EC4")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1034F64", Offset = "0x1034F64", VA = "0x1034F64")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x103500C", Offset = "0x103500C", VA = "0x103500C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1035074", Offset = "0x1035074", VA = "0x1035074")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x10350DC", Offset = "0x10350DC", VA = "0x10350DC")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1035134", Offset = "0x1035134", VA = "0x1035134")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1035264", Offset = "0x1035264", VA = "0x1035264")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x10353E4", Offset = "0x10353E4", VA = "0x10353E4")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10354C0", Offset = "0x10354C0", VA = "0x10354C0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x103559C", Offset = "0x103559C", VA = "0x103559C")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x10357B4", Offset = "0x10357B4", VA = "0x10357B4")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1035800", Offset = "0x1035800", VA = "0x1035800")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x103584C", Offset = "0x103584C", VA = "0x103584C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1035950", Offset = "0x1035950", VA = "0x1035950")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1035A54", Offset = "0x1035A54", VA = "0x1035A54")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1035B68", Offset = "0x1035B68", VA = "0x1035B68")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1035C10", Offset = "0x1035C10", VA = "0x1035C10")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1035D1C", Offset = "0x1035D1C", VA = "0x1035D1C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1035E84", Offset = "0x1035E84", VA = "0x1035E84")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1036068", Offset = "0x1036068", VA = "0x1036068")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1036138", Offset = "0x1036138", VA = "0x1036138")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10362BC", Offset = "0x10362BC", VA = "0x10362BC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10363C8", Offset = "0x10363C8", VA = "0x10363C8")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1036420", Offset = "0x1036420", VA = "0x1036420")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1036644", Offset = "0x1036644", VA = "0x1036644")]
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
			[Address(RVA = "0x1036868", Offset = "0x1036868", VA = "0x1036868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private bool isAnimated
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x1036B28", Offset = "0x1036B28", VA = "0x1036B28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x103674C", Offset = "0x103674C", VA = "0x103674C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x10367E0", Offset = "0x10367E0", VA = "0x10367E0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x10367E4", Offset = "0x10367E4", VA = "0x10367E4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x10367E8", Offset = "0x10367E8", VA = "0x10367E8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x10367EC", Offset = "0x10367EC", VA = "0x10367EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1036864", Offset = "0x1036864", VA = "0x1036864")]
		private void Start()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1036814", Offset = "0x1036814", VA = "0x1036814")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1036AEC", Offset = "0x1036AEC", VA = "0x1036AEC")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1036934", Offset = "0x1036934", VA = "0x1036934")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1036BC0", Offset = "0x1036BC0", VA = "0x1036BC0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1036C0C", Offset = "0x1036C0C", VA = "0x1036C0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1036C58", Offset = "0x1036C58", VA = "0x1036C58")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1036C90", Offset = "0x1036C90", VA = "0x1036C90")]
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
		[Address(RVA = "0x1036CA0", Offset = "0x1036CA0", VA = "0x1036CA0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1036D54", Offset = "0x1036D54", VA = "0x1036D54")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1036E08", Offset = "0x1036E08", VA = "0x1036E08")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1036EBC", Offset = "0x1036EBC", VA = "0x1036EBC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1036EC4", Offset = "0x1036EC4", VA = "0x1036EC4")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1036ECC", Offset = "0x1036ECC", VA = "0x1036ECC")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1036F5C", Offset = "0x1036F5C", VA = "0x1036F5C")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1036FF0", Offset = "0x1036FF0", VA = "0x1036FF0")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10370A0", Offset = "0x10370A0", VA = "0x10370A0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002F")]
	public static class V3Tools
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10370FC", Offset = "0x10370FC", VA = "0x10370FC")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x103711C", Offset = "0x103711C", VA = "0x103711C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10371F0", Offset = "0x10371F0", VA = "0x10371F0")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10372A8", Offset = "0x10372A8", VA = "0x10372A8")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1037304", Offset = "0x1037304", VA = "0x1037304")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1037360", Offset = "0x1037360", VA = "0x1037360")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1037478", Offset = "0x1037478", VA = "0x1037478")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x10374D4", Offset = "0x10374D4", VA = "0x10374D4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x103750C", Offset = "0x103750C", VA = "0x103750C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x10376DC", Offset = "0x10376DC", VA = "0x10376DC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10378E0", Offset = "0x10378E0", VA = "0x10378E0")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1037A58", Offset = "0x1037A58", VA = "0x1037A58")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1037C88", Offset = "0x1037C88", VA = "0x1037C88")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1037ED8", Offset = "0x1037ED8", VA = "0x1037ED8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1038130", Offset = "0x1038130", VA = "0x1038130")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x10382DC", Offset = "0x10382DC", VA = "0x10382DC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x10384D4", Offset = "0x10384D4", VA = "0x10384D4")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1038550", Offset = "0x1038550", VA = "0x1038550")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x10385E0", Offset = "0x10385E0", VA = "0x10385E0")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1038678", Offset = "0x1038678", VA = "0x1038678")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1038668", Offset = "0x1038668", VA = "0x1038668")]
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
		[Address(RVA = "0x10386F4", Offset = "0x10386F4", VA = "0x10386F4")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x10313C8", Offset = "0x10313C8", VA = "0x10313C8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000032")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x10388A0", Offset = "0x10388A0", VA = "0x10388A0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x10388E4", Offset = "0x10388E4", VA = "0x10388E4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1038928", Offset = "0x1038928", VA = "0x1038928")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x103896C", Offset = "0x103896C", VA = "0x103896C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x10389B0", Offset = "0x10389B0", VA = "0x10389B0")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1038A48", Offset = "0x1038A48", VA = "0x1038A48")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1038A64", Offset = "0x1038A64", VA = "0x1038A64")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1038A90", Offset = "0x1038A90", VA = "0x1038A90")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1038ABC", Offset = "0x1038ABC", VA = "0x1038ABC")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1038AF8", Offset = "0x1038AF8", VA = "0x1038AF8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1038B38", Offset = "0x1038B38", VA = "0x1038B38")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1038B58", Offset = "0x1038B58", VA = "0x1038B58")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1038B78", Offset = "0x1038B78", VA = "0x1038B78")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1038B9C", Offset = "0x1038B9C", VA = "0x1038B9C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1038BC4", Offset = "0x1038BC4", VA = "0x1038BC4")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1038BEC", Offset = "0x1038BEC", VA = "0x1038BEC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x10389CC", Offset = "0x10389CC", VA = "0x10389CC")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1038C10", Offset = "0x1038C10", VA = "0x1038C10")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1038C1C", Offset = "0x1038C1C", VA = "0x1038C1C")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1038C28", Offset = "0x1038C28", VA = "0x1038C28")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1038E94", Offset = "0x1038E94", VA = "0x1038E94", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1038F30", Offset = "0x1038F30", VA = "0x1038F30", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1039250", Offset = "0x1039250", VA = "0x1039250", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10396BC", Offset = "0x10396BC", VA = "0x10396BC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10396E0", Offset = "0x10396E0", VA = "0x10396E0")]
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
			[Address(RVA = "0x1038D64", Offset = "0x1038D64", VA = "0x1038D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x1039904", Offset = "0x1039904", VA = "0x1039904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10390E0", Offset = "0x10390E0", VA = "0x10390E0")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1039778", Offset = "0x1039778", VA = "0x1039778")]
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
			[Address(RVA = "0x1039AC0", Offset = "0x1039AC0", VA = "0x1039AC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000166")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1039B20", Offset = "0x1039B20", VA = "0x1039B20")]
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
		[Address(RVA = "0x1039B28", Offset = "0x1039B28", VA = "0x1039B28", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1039BC0", Offset = "0x1039BC0", VA = "0x1039BC0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1039BC8", Offset = "0x1039BC8", VA = "0x1039BC8")]
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
			[Address(RVA = "0x1039CF4", Offset = "0x1039CF4", VA = "0x1039CF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1039BF0", Offset = "0x1039BF0", VA = "0x1039BF0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1039D50", Offset = "0x1039D50", VA = "0x1039D50")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1039D58", Offset = "0x1039D58", VA = "0x1039D58")]
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
		[Address(RVA = "0x1039D80", Offset = "0x1039D80", VA = "0x1039D80", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1039DFC", Offset = "0x1039DFC", VA = "0x1039DFC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1039E04", Offset = "0x1039E04", VA = "0x1039E04")]
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
			[Address(RVA = "0x1039F30", Offset = "0x1039F30", VA = "0x1039F30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1039E2C", Offset = "0x1039E2C", VA = "0x1039E2C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1039F88", Offset = "0x1039F88", VA = "0x1039F88")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1039F90", Offset = "0x1039F90", VA = "0x1039F90")]
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
		[Address(RVA = "0x1039FB8", Offset = "0x1039FB8", VA = "0x1039FB8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1039200", Offset = "0x1039200", VA = "0x1039200")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x10393C4", Offset = "0x10393C4", VA = "0x10393C4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1039AB8", Offset = "0x1039AB8", VA = "0x1039AB8")]
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
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
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
			[Address(RVA = "0x103A018", Offset = "0x103A018", VA = "0x103A018")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x103A020", Offset = "0x103A020", VA = "0x103A020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x103A02C", Offset = "0x103A02C", VA = "0x103A02C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x103A04C", Offset = "0x103A04C", VA = "0x103A04C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x103A06C", Offset = "0x103A06C", VA = "0x103A06C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x103A08C", Offset = "0x103A08C", VA = "0x103A08C")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x103A0AC", Offset = "0x103A0AC", VA = "0x103A0AC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x103A198", Offset = "0x103A198", VA = "0x103A198")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x103A800", Offset = "0x103A800", VA = "0x103A800")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x103A8CC", Offset = "0x103A8CC", VA = "0x103A8CC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x103A984", Offset = "0x103A984", VA = "0x103A984")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x103AF1C", Offset = "0x103AF1C", VA = "0x103AF1C")]
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
			[Address(RVA = "0x13A3CA4", Offset = "0x13A3CA4", VA = "0x13A3CA4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x13A3CAC", Offset = "0x13A3CAC", VA = "0x13A3CAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x13A3CB8", Offset = "0x13A3CB8", VA = "0x13A3CB8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x13A3D30", Offset = "0x13A3D30", VA = "0x13A3D30")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x13A4024", Offset = "0x13A4024", VA = "0x13A4024")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x13A4194", Offset = "0x13A4194", VA = "0x13A4194")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x13A3F3C", Offset = "0x13A3F3C", VA = "0x13A3F3C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x13A42F8", Offset = "0x13A42F8", VA = "0x13A42F8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x13A43A8", Offset = "0x13A43A8", VA = "0x13A43A8")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x13A4410", Offset = "0x13A4410", VA = "0x13A4410")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x13A447C", Offset = "0x13A447C", VA = "0x13A447C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x13A44DC", Offset = "0x13A44DC", VA = "0x13A44DC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x13A44E0", Offset = "0x13A44E0", VA = "0x13A44E0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x13A44F4", Offset = "0x13A44F4", VA = "0x13A44F4")]
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
			[Address(RVA = "0x13A4554", Offset = "0x13A4554", VA = "0x13A4554")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x13A455C", Offset = "0x13A455C", VA = "0x13A455C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000194")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x13A4568", Offset = "0x13A4568", VA = "0x13A4568")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x13A4818", Offset = "0x13A4818", VA = "0x13A4818")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x13A462C", Offset = "0x13A462C", VA = "0x13A462C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x13A4840", Offset = "0x13A4840", VA = "0x13A4840")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600019C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x13A49B4", Offset = "0x13A49B4", VA = "0x13A49B4")]
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
		[Address(RVA = "0x13A4C78", Offset = "0x13A4C78", VA = "0x13A4C78", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x13A4CBC", Offset = "0x13A4CBC", VA = "0x13A4CBC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x13A4D00", Offset = "0x13A4D00", VA = "0x13A4D00", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x13A4DE0", Offset = "0x13A4DE0", VA = "0x13A4DE0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x13A4E80", Offset = "0x13A4E80", VA = "0x13A4E80")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x13A4ED4", Offset = "0x13A4ED4", VA = "0x13A4ED4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x13A5448", Offset = "0x13A5448", VA = "0x13A5448")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x13A5488", Offset = "0x13A5488", VA = "0x13A5488")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x13A5B00", Offset = "0x13A5B00", VA = "0x13A5B00")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x13A5C28", Offset = "0x13A5C28", VA = "0x13A5C28")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x13A5E24", Offset = "0x13A5E24", VA = "0x13A5E24")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x13A5FCC", Offset = "0x13A5FCC", VA = "0x13A5FCC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
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
			[Address(RVA = "0x13A6D88", Offset = "0x13A6D88", VA = "0x13A6D88")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x13A6D98", Offset = "0x13A6D98", VA = "0x13A6D98")]
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
		[Address(RVA = "0x13A6058", Offset = "0x13A6058", VA = "0x13A6058")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x13A609C", Offset = "0x13A609C", VA = "0x13A609C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x13A60E0", Offset = "0x13A60E0", VA = "0x13A60E0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x13A6124", Offset = "0x13A6124", VA = "0x13A6124", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x13A618C", Offset = "0x13A618C", VA = "0x13A618C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x13A6214", Offset = "0x13A6214", VA = "0x13A6214")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x13A6508", Offset = "0x13A6508", VA = "0x13A6508")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x13A6514", Offset = "0x13A6514", VA = "0x13A6514")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x13A6270", Offset = "0x13A6270", VA = "0x13A6270")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x13A6520", Offset = "0x13A6520", VA = "0x13A6520")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x13A6890", Offset = "0x13A6890", VA = "0x13A6890")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x13A6A14", Offset = "0x13A6A14", VA = "0x13A6A14")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x13A6B48", Offset = "0x13A6B48", VA = "0x13A6B48")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x13A6B64", Offset = "0x13A6B64", VA = "0x13A6B64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x13A6CFC", Offset = "0x13A6CFC", VA = "0x13A6CFC")]
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
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
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
		[Address(RVA = "0x13A6DDC", Offset = "0x13A6DDC", VA = "0x13A6DDC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x13A6E20", Offset = "0x13A6E20", VA = "0x13A6E20", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x13A6E64", Offset = "0x13A6E64", VA = "0x13A6E64", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x13A7054", Offset = "0x13A7054", VA = "0x13A7054")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x13A7274", Offset = "0x13A7274", VA = "0x13A7274")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x13A7354", Offset = "0x13A7354", VA = "0x13A7354")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x13A7A40", Offset = "0x13A7A40", VA = "0x13A7A40")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x13A7EA0", Offset = "0x13A7EA0", VA = "0x13A7EA0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x13A804C", Offset = "0x13A804C", VA = "0x13A804C")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x13A83D4", Offset = "0x13A83D4", VA = "0x13A83D4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x13A85D8", Offset = "0x13A85D8", VA = "0x13A85D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x13A87DC", Offset = "0x13A87DC", VA = "0x13A87DC")]
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
			[Address(RVA = "0x13A948C", Offset = "0x13A948C", VA = "0x13A948C")]
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
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
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
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
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
		[Address(RVA = "0x13A8868", Offset = "0x13A8868", VA = "0x13A8868", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x13A88AC", Offset = "0x13A88AC", VA = "0x13A88AC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x13A88F0", Offset = "0x13A88F0", VA = "0x13A88F0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x13A8A6C", Offset = "0x13A8A6C", VA = "0x13A8A6C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x13A8B70", Offset = "0x13A8B70", VA = "0x13A8B70")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x13A8D68", Offset = "0x13A8D68", VA = "0x13A8D68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x13A8DCC", Offset = "0x13A8DCC", VA = "0x13A8DCC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x13A8E24", Offset = "0x13A8E24", VA = "0x13A8E24")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x13A9138", Offset = "0x13A9138", VA = "0x13A9138")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x13A94C0", Offset = "0x13A94C0", VA = "0x13A94C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x13A9550", Offset = "0x13A9550", VA = "0x13A9550")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x13A99A0", Offset = "0x13A99A0", VA = "0x13A99A0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x13AA064", Offset = "0x13AA064", VA = "0x13AA064")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x13AA31C", Offset = "0x13AA31C", VA = "0x13AA31C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x13AA450", Offset = "0x13AA450", VA = "0x13AA450")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x13AA748", Offset = "0x13AA748", VA = "0x13AA748")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x13AA778", Offset = "0x13AA778", VA = "0x13AA778")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x13AA974", Offset = "0x13AA974", VA = "0x13AA974")]
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
				[Address(RVA = "0x13AC76C", Offset = "0x13AC76C", VA = "0x13AC76C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000203")]
				[Address(RVA = "0x13AC774", Offset = "0x13AC774", VA = "0x13AC774")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0x13AC780", Offset = "0x13AC780", VA = "0x13AC780")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000205")]
				[Address(RVA = "0x13AC78C", Offset = "0x13AC78C", VA = "0x13AC78C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool initiated
			{
				[Token(Token = "0x6000206")]
				[Address(RVA = "0x13AC798", Offset = "0x13AC798", VA = "0x13AC798")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000207")]
				[Address(RVA = "0x13AC7A0", Offset = "0x13AC7A0", VA = "0x13AC7A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0x13AC7AC", Offset = "0x13AC7AC", VA = "0x13AC7AC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000209")]
				[Address(RVA = "0x13AC7B4", Offset = "0x13AC7B4", VA = "0x13AC7B4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public Vector3 velocity
			{
				[Token(Token = "0x600020A")]
				[Address(RVA = "0x13AC7BC", Offset = "0x13AC7BC", VA = "0x13AC7BC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600020B")]
				[Address(RVA = "0x13AC7C8", Offset = "0x13AC7C8", VA = "0x13AC7C8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public Transform transform
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0x13AC7D4", Offset = "0x13AC7D4", VA = "0x13AC7D4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600020D")]
				[Address(RVA = "0x13AC7DC", Offset = "0x13AC7DC", VA = "0x13AC7DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public float IKOffset
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0x13AC7E4", Offset = "0x13AC7E4", VA = "0x13AC7E4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600020F")]
				[Address(RVA = "0x13AC7EC", Offset = "0x13AC7EC", VA = "0x13AC7EC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0x13AC7F4", Offset = "0x13AC7F4", VA = "0x13AC7F4")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000211")]
				[Address(RVA = "0x13AC80C", Offset = "0x13AC80C", VA = "0x13AC80C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0x13AC82C", Offset = "0x13AC82C", VA = "0x13AC82C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000213")]
				[Address(RVA = "0x13AC844", Offset = "0x13AC844", VA = "0x13AC844")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0x13AC864", Offset = "0x13AC864", VA = "0x13AC864")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000035")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0x13AD120", Offset = "0x13AD120", VA = "0x13AD120")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000036")]
			private float rootYOffset
			{
				[Token(Token = "0x6000223")]
				[Address(RVA = "0x13AD270", Offset = "0x13AD270", VA = "0x13AD270")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0x13AC8AC", Offset = "0x13AC8AC", VA = "0x13AC8AC")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0x13AAF3C", Offset = "0x13AAF3C", VA = "0x13AAF3C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0x13AC8C0", Offset = "0x13AC8C0", VA = "0x13AC8C0")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0x13ABC2C", Offset = "0x13ABC2C", VA = "0x13ABC2C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0x13AB02C", Offset = "0x13AB02C", VA = "0x13AB02C")]
			public void Process()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0x13ACD4C", Offset = "0x13ACD4C", VA = "0x13ACD4C")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0x13AC900", Offset = "0x13AC900", VA = "0x13AC900")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0x13AD1B4", Offset = "0x13AD1B4", VA = "0x13AD1B4")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0x13ACBB4", Offset = "0x13ACBB4", VA = "0x13ACBB4")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0x13ACC34", Offset = "0x13ACC34", VA = "0x13ACC34")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0x13AD220", Offset = "0x13AD220", VA = "0x13AD220")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x13AD154", Offset = "0x13AD154", VA = "0x13AD154")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x13AD2FC", Offset = "0x13AD2FC", VA = "0x13AD2FC")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x13AAE9C", Offset = "0x13AAE9C", VA = "0x13AAE9C")]
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
				[Address(RVA = "0x13AD4AC", Offset = "0x13AD4AC", VA = "0x13AD4AC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000226")]
				[Address(RVA = "0x13AD4B8", Offset = "0x13AD4B8", VA = "0x13AD4B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000038")]
			public float heightOffset
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x13AD4C4", Offset = "0x13AD4C4", VA = "0x13AD4C4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000228")]
				[Address(RVA = "0x13AD4CC", Offset = "0x13AD4CC", VA = "0x13AD4CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x13AB004", Offset = "0x13AB004", VA = "0x13AB004")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x13ABB98", Offset = "0x13ABB98", VA = "0x13ABB98")]
			public void Reset()
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x13AD4D4", Offset = "0x13AD4D4", VA = "0x13AD4D4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x13AB9AC", Offset = "0x13AB9AC", VA = "0x13AB9AC")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x13AAF34", Offset = "0x13AAF34", VA = "0x13AAF34")]
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
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
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
			[Address(RVA = "0x13AAA54", Offset = "0x13AAA54", VA = "0x13AAA54")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x13AAA5C", Offset = "0x13AAA5C", VA = "0x13AAA5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x13AAA64", Offset = "0x13AAA64", VA = "0x13AAA64")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x13AAA6C", Offset = "0x13AAA6C", VA = "0x13AAA6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool isGrounded
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x13AAA74", Offset = "0x13AAA74", VA = "0x13AAA74")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x13AAA7C", Offset = "0x13AAA7C", VA = "0x13AAA7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform root
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x13AAA88", Offset = "0x13AAA88", VA = "0x13AAA88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x13AAA90", Offset = "0x13AAA90", VA = "0x13AAA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x13AAA98", Offset = "0x13AAA98", VA = "0x13AAA98")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x13AAAB0", Offset = "0x13AAAB0", VA = "0x13AAAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x13AAAD0", Offset = "0x13AAAD0", VA = "0x13AAAD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3 up
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x13A5BC0", Offset = "0x13A5BC0", VA = "0x13A5BC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002A")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x13ABCC0", Offset = "0x13ABCC0", VA = "0x13ABCC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x13AAB18", Offset = "0x13AAB18", VA = "0x13AAB18")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x13AADA0", Offset = "0x13AADA0", VA = "0x13AADA0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x13A51D4", Offset = "0x13A51D4", VA = "0x13A51D4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x13A5900", Offset = "0x13A5900", VA = "0x13A5900")]
		public void Update()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x13A78C8", Offset = "0x13A78C8", VA = "0x13A78C8")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x13A4D68", Offset = "0x13A4D68", VA = "0x13A4D68")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x13AB014", Offset = "0x13AB014", VA = "0x13AB014")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x13ABD74", Offset = "0x13ABD74", VA = "0x13ABD74")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x13ABDF8", Offset = "0x13ABDF8", VA = "0x13ABDF8")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x13ABF4C", Offset = "0x13ABF4C", VA = "0x13ABF4C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x13A4A20", Offset = "0x13A4A20", VA = "0x13A4A20")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x13AD528", Offset = "0x13AD528", VA = "0x13AD528", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x13AD56C", Offset = "0x13AD56C", VA = "0x13AD56C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x13AD5B0", Offset = "0x13AD5B0", VA = "0x13AD5B0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x13AD5F4", Offset = "0x13AD5F4", VA = "0x13AD5F4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x13AD638", Offset = "0x13AD638", VA = "0x13AD638")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x13AD67C", Offset = "0x13AD67C", VA = "0x13AD67C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x13AD684", Offset = "0x13AD684", VA = "0x13AD684")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x13AD6F4", Offset = "0x13AD6F4", VA = "0x13AD6F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x13AD738", Offset = "0x13AD738", VA = "0x13AD738", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x13AD77C", Offset = "0x13AD77C", VA = "0x13AD77C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x13AD7C0", Offset = "0x13AD7C0", VA = "0x13AD7C0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x13AD804", Offset = "0x13AD804", VA = "0x13AD804", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x13AD80C", Offset = "0x13AD80C", VA = "0x13AD80C")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x13AD874", Offset = "0x13AD874", VA = "0x13AD874", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x13AD8B8", Offset = "0x13AD8B8", VA = "0x13AD8B8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x13AD8FC", Offset = "0x13AD8FC", VA = "0x13AD8FC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x13AD940", Offset = "0x13AD940", VA = "0x13AD940")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x13AD984", Offset = "0x13AD984", VA = "0x13AD984", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x13AD98C", Offset = "0x13AD98C", VA = "0x13AD98C")]
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
		[Address(RVA = "0x13AD9F4", Offset = "0x13AD9F4", VA = "0x13AD9F4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x13ADA38", Offset = "0x13ADA38", VA = "0x13ADA38", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x13ADA7C", Offset = "0x13ADA7C", VA = "0x13ADA7C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x13ADAC0", Offset = "0x13ADAC0", VA = "0x13ADAC0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x13ADB04", Offset = "0x13ADB04", VA = "0x13ADB04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x13ADB0C", Offset = "0x13ADB0C", VA = "0x13ADB0C")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x13ADB74", Offset = "0x13ADB74", VA = "0x13ADB74", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x13ADBB8", Offset = "0x13ADBB8", VA = "0x13ADBB8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x13ADBFC", Offset = "0x13ADBFC", VA = "0x13ADBFC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x13ADC40", Offset = "0x13ADC40", VA = "0x13ADC40")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x13ADC84", Offset = "0x13ADC84", VA = "0x13ADC84", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x13ADC8C", Offset = "0x13ADC8C", VA = "0x13ADC8C")]
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
		[Address(RVA = "0x13ADCF4", Offset = "0x13ADCF4", VA = "0x13ADCF4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x13ADD38", Offset = "0x13ADD38", VA = "0x13ADD38", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x13ADD7C", Offset = "0x13ADD7C", VA = "0x13ADD7C")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x13ADDC0", Offset = "0x13ADDC0", VA = "0x13ADDC0")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x13ADE04", Offset = "0x13ADE04", VA = "0x13ADE04")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x13ADE48", Offset = "0x13ADE48", VA = "0x13ADE48")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x13ADE8C", Offset = "0x13ADE8C", VA = "0x13ADE8C")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x13ADEB0", Offset = "0x13ADEB0", VA = "0x13ADEB0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x13ADEB8", Offset = "0x13ADEB8", VA = "0x13ADEB8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x13AE074", Offset = "0x13AE074", VA = "0x13AE074")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x13AE524", Offset = "0x13AE524", VA = "0x13AE524")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x13AE544", Offset = "0x13AE544", VA = "0x13AE544")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x13AE61C", Offset = "0x13AE61C", VA = "0x13AE61C")]
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
		[Address(RVA = "0x13AE6B4", Offset = "0x13AE6B4", VA = "0x13AE6B4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x13AE72C", Offset = "0x13AE72C", VA = "0x13AE72C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x13AE79C", Offset = "0x13AE79C", VA = "0x13AE79C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600025E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600025F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x13AD6EC", Offset = "0x13AD6EC", VA = "0x13AD6EC")]
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
			[Address(RVA = "0x13AE7EC", Offset = "0x13AE7EC", VA = "0x13AE7EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x13AE878", Offset = "0x13AE878", VA = "0x13AE878")]
		private void Start()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x13AE8DC", Offset = "0x13AE8DC", VA = "0x13AE8DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x13AE97C", Offset = "0x13AE97C", VA = "0x13AE97C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x13AE9A8", Offset = "0x13AE9A8", VA = "0x13AE9A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x13AE900", Offset = "0x13AE900", VA = "0x13AE900")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x13AEA2C", Offset = "0x13AEA2C", VA = "0x13AEA2C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x13AEA34", Offset = "0x13AEA34", VA = "0x13AEA34", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x13AEA78", Offset = "0x13AEA78", VA = "0x13AEA78", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x13AEABC", Offset = "0x13AEABC", VA = "0x13AEABC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x13AEB00", Offset = "0x13AEB00", VA = "0x13AEB00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x13AEB44", Offset = "0x13AEB44", VA = "0x13AEB44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x13AEB4C", Offset = "0x13AEB4C", VA = "0x13AEB4C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x13AEBB4", Offset = "0x13AEBB4", VA = "0x13AEBB4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x13AEBF8", Offset = "0x13AEBF8", VA = "0x13AEBF8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x13AEC3C", Offset = "0x13AEC3C", VA = "0x13AEC3C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x13AEC80", Offset = "0x13AEC80", VA = "0x13AEC80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x13AECC4", Offset = "0x13AECC4", VA = "0x13AECC4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x13AECCC", Offset = "0x13AECCC", VA = "0x13AECCC")]
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
		[Address(RVA = "0x13AED34", Offset = "0x13AED34", VA = "0x13AED34", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x13AED78", Offset = "0x13AED78", VA = "0x13AED78", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x13AEDBC", Offset = "0x13AEDBC", VA = "0x13AEDBC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x13AEE00", Offset = "0x13AEE00", VA = "0x13AEE00")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x13AEE44", Offset = "0x13AEE44", VA = "0x13AEE44", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x13AEE4C", Offset = "0x13AEE4C", VA = "0x13AEE4C")]
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
		[Address(RVA = "0x13AEEB4", Offset = "0x13AEEB4", VA = "0x13AEEB4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x13AEEF8", Offset = "0x13AEEF8", VA = "0x13AEEF8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x13AEF3C", Offset = "0x13AEF3C", VA = "0x13AEF3C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x13AEF80", Offset = "0x13AEF80", VA = "0x13AEF80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x13AEFC4", Offset = "0x13AEFC4", VA = "0x13AEFC4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x13AEFCC", Offset = "0x13AEFCC", VA = "0x13AEFCC")]
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
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			[LargeHeader("Left Leg")]
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
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			[LargeHeader("Right Leg")]
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
				[Address(RVA = "0x13AF900", Offset = "0x13AF900", VA = "0x13AF900")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003B")]
			public bool isEmpty
			{
				[Token(Token = "0x600028D")]
				[Address(RVA = "0x13AF544", Offset = "0x13AF544", VA = "0x13AF544")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x13B0024", Offset = "0x13B0024", VA = "0x13B0024")]
			public References()
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x13B002C", Offset = "0x13B002C", VA = "0x13B002C")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x13B012C", Offset = "0x13B012C", VA = "0x13B012C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x13AF11C", Offset = "0x13AF11C", VA = "0x13AF11C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		public References references;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x13AF034", Offset = "0x13AF034", VA = "0x13AF034", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x13AF078", Offset = "0x13AF078", VA = "0x13AF078", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x13AF0BC", Offset = "0x13AF0BC", VA = "0x13AF0BC")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x13AF100", Offset = "0x13AF100", VA = "0x13AF100")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x13AF4A8", Offset = "0x13AF4A8", VA = "0x13AF4A8")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x13AF4D0", Offset = "0x13AF4D0", VA = "0x13AF4D0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x13AF4D8", Offset = "0x13AF4D8", VA = "0x13AF4D8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x13AFDFC", Offset = "0x13AFDFC", VA = "0x13AFDFC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x13AFF8C", Offset = "0x13AFF8C", VA = "0x13AFF8C")]
		public VRIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/Aim IKJ")]
	public class AimIKJ : MonoBehaviour
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional secondary target for another axis of the 'Aim Transform'. Needs 'Pole Weight' to be greater than 0 to have any effect.")]
		public Transform poleTarget;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The transform that you want to be aimed at the target. Needs to be a lineal descendant of the bone hierarchy. For example, if you wish to aim a gun, it should be the gun, one of it's children or the hand bone.")]
		public Transform aimTransform;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisX;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisY;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want to be aimed at IKPosition.")]
		public float axisZ;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Space(5f)]
		[Tooltip("The X value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisX;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Y value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisY;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The Z value of the local axis of the 'Aim Transform' that you want oriented towards the 'Pole Target'.")]
		public float poleAxisZ;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Space(5f)]
		[Tooltip("The master weight of this solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of the 'Pole Target'")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Minimum angular offset from last reached angle. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Clamping rotation of the solver. 0 is free rotation, 1 is completely clamped to animated rotation.")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 2f)]
		[Tooltip("Number of sine smoothing iterations applied on clamping to make the clamping point smoother.")]
		public int clampSmoothing;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		[Space(5f)]
		public Transform[] bones;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PlayableGraph graph;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AimIKJob job;

		[Token(Token = "0x1700003C")]
		public bool initiated
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x13B0568", Offset = "0x13B0568", VA = "0x13B0568")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x13B0570", Offset = "0x13B0570", VA = "0x13B0570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 axis
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x13B057C", Offset = "0x13B057C", VA = "0x13B057C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x13B0588", Offset = "0x13B0588", VA = "0x13B0588")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public Vector3 poleAxis
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x13B0594", Offset = "0x13B0594", VA = "0x13B0594")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x13B05A0", Offset = "0x13B05A0", VA = "0x13B05A0")]
			set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x13B05AC", Offset = "0x13B05AC", VA = "0x13B05AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x13B132C", Offset = "0x13B132C", VA = "0x13B132C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x13B1680", Offset = "0x13B1680", VA = "0x13B1680")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x13B177C", Offset = "0x13B177C", VA = "0x13B177C")]
		public AimIKJ()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public struct AimIKJob : IAnimationJob
	{
		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float step;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x13B0B98", Offset = "0x13B0B98", VA = "0x13B0B98")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x13B1804", Offset = "0x13B1804", VA = "0x13B1804")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x13B1F90", Offset = "0x13B1F90", VA = "0x13B1F90")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x13B20BC", Offset = "0x13B20BC", VA = "0x13B20BC", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x13B20C0", Offset = "0x13B20C0", VA = "0x13B20C0", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x13B20F4", Offset = "0x13B20F4", VA = "0x13B20F4")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x13B2F74", Offset = "0x13B2F74", VA = "0x13B2F74")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x13B2D3C", Offset = "0x13B2D3C", VA = "0x13B2D3C")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return default(float);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x13B2A7C", Offset = "0x13B2A7C", VA = "0x13B2A7C")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x13B2EE4", Offset = "0x13B2EE4", VA = "0x13B2EE4")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x13B3DBC", Offset = "0x13B3DBC", VA = "0x13B3DBC")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x13B1704", Offset = "0x13B1704", VA = "0x13B1704")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(Animator))]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK Jobs/CCD IKJ")]
	public class CCDIKJ : MonoBehaviour
	{
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target Transform of this solver.")]
		public Transform target;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this solver.")]
		public float weight;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Minimum offset from last reached position. Will stop solving if offset is less than tolerance.If tolerance is zero, will iterate until maxIterations.")]
		public float tolerance;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Max solver iterations per frame. If target position offset is less than 'Tolerance', will stop solving.")]
		public int maxIterations;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If true, rotation limits (if existing) will be applied on each iteration. Only RotationLimitAngle and RotationLimitHinge can be used with this solver.")]
		public bool useRotationLimits;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Tooltip("Useful for 2D games. If true, will solve only in the XY plane.")]
		public bool XY;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The list of bones used by the solver. Must be assigned in order of hierarchy. All bones must be in the same hierarchy branch.")]
		public Transform[] bones;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayableGraph graph;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AnimationScriptPlayable IKPlayable;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CCDIKJob job;

		[Token(Token = "0x1700003F")]
		public bool initiated
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x13B3DE8", Offset = "0x13B3DE8", VA = "0x13B3DE8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x13B3DF0", Offset = "0x13B3DF0", VA = "0x13B3DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x13B3DFC", Offset = "0x13B3DFC", VA = "0x13B3DFC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x13B4688", Offset = "0x13B4688", VA = "0x13B4688")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x13B4814", Offset = "0x13B4814", VA = "0x13B4814")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x13B4930", Offset = "0x13B4930", VA = "0x13B4930")]
		public CCDIKJ()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public struct CCDIKJob : IAnimationJob
	{
		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x13B41BC", Offset = "0x13B41BC", VA = "0x13B41BC")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x13B49A0", Offset = "0x13B49A0", VA = "0x13B49A0")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x13B512C", Offset = "0x13B512C", VA = "0x13B512C")]
		private void DisposeRotationLimits()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x13B5258", Offset = "0x13B5258", VA = "0x13B5258", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x13B525C", Offset = "0x13B525C", VA = "0x13B525C", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x13B5290", Offset = "0x13B5290", VA = "0x13B5290")]
		private void Update(AnimationStream s)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x13B5744", Offset = "0x13B5744", VA = "0x13B5744")]
		private void Read(AnimationStream s)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x13B5CC8", Offset = "0x13B5CC8", VA = "0x13B5CC8")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x13B5B44", Offset = "0x13B5B44", VA = "0x13B5B44")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x13B5C9C", Offset = "0x13B5C9C", VA = "0x13B5C9C")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x13B5888", Offset = "0x13B5888", VA = "0x13B5888")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x13B6780", Offset = "0x13B6780", VA = "0x13B6780")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x13B4898", Offset = "0x13B4898", VA = "0x13B4898")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class IKJBoneParams : MonoBehaviour
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x14E5FE4", Offset = "0x14E5FE4", VA = "0x14E5FE4")]
		public IKJBoneParams()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public static class RotationLimitUtilities
	{
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x14E5FF4", Offset = "0x14E5FF4", VA = "0x14E5FF4")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x14E62B4", Offset = "0x14E62B4", VA = "0x14E62B4")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x14E6388", Offset = "0x14E6388", VA = "0x14E6388")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x14E63EC", Offset = "0x14E63EC", VA = "0x14E63EC")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x14E670C", Offset = "0x14E670C", VA = "0x14E670C")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class FABRIKChain
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x14E6964", Offset = "0x14E6964", VA = "0x14E6964")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x14E6A28", Offset = "0x14E6A28", VA = "0x14E6A28")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x14E6A48", Offset = "0x14E6A48", VA = "0x14E6A48")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x14E6C9C", Offset = "0x14E6C9C", VA = "0x14E6C9C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x14E6B08", Offset = "0x14E6B08", VA = "0x14E6B08")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x14E6D80", Offset = "0x14E6D80", VA = "0x14E6D80")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x14E6DE0", Offset = "0x14E6DE0", VA = "0x14E6DE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x14E7334", Offset = "0x14E7334", VA = "0x14E7334")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x14E74C8", Offset = "0x14E74C8", VA = "0x14E74C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x14E75D0", Offset = "0x14E75D0", VA = "0x14E75D0")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000063")]
		public class BendBone
		{
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x14EA7C4", Offset = "0x14EA7C4", VA = "0x14EA7C4")]
			public BendBone()
			{
			}

			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x14EA824", Offset = "0x14EA824", VA = "0x14EA824")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x14E7EE8", Offset = "0x14E7EE8", VA = "0x14E7EE8")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x14E82B8", Offset = "0x14E82B8", VA = "0x14E82B8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x14E75D8", Offset = "0x14E75D8", VA = "0x14E75D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x14E7A74", Offset = "0x14E7A74", VA = "0x14E7A74")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x14E7F14", Offset = "0x14E7F14", VA = "0x14E7F14")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x14E82E0", Offset = "0x14E82E0", VA = "0x14E82E0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x14E8BDC", Offset = "0x14E8BDC", VA = "0x14E8BDC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x14E8FD4", Offset = "0x14E8FD4", VA = "0x14E8FD4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x14E93E4", Offset = "0x14E93E4", VA = "0x14E93E4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x14E9D5C", Offset = "0x14E9D5C", VA = "0x14E9D5C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x14E8920", Offset = "0x14E8920", VA = "0x14E8920")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x14E9F98", Offset = "0x14E9F98", VA = "0x14E9F98")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x14E9C7C", Offset = "0x14E9C7C", VA = "0x14E9C7C")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x14E9B7C", Offset = "0x14E9B7C", VA = "0x14E9B7C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x14EA2F8", Offset = "0x14EA2F8", VA = "0x14EA2F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x14EA61C", Offset = "0x14EA61C", VA = "0x14EA61C")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000065")]
		public class ChildConstraint
		{
			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000040")]
			public float nominalDistance
			{
				[Token(Token = "0x60002EE")]
				[Address(RVA = "0x14ED7F8", Offset = "0x14ED7F8", VA = "0x14ED7F8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002EF")]
				[Address(RVA = "0x14ED800", Offset = "0x14ED800", VA = "0x14ED800")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000041")]
			public bool isRigid
			{
				[Token(Token = "0x60002F0")]
				[Address(RVA = "0x14ED808", Offset = "0x14ED808", VA = "0x14ED808")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002F1")]
				[Address(RVA = "0x14ED810", Offset = "0x14ED810", VA = "0x14ED810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x14ED81C", Offset = "0x14ED81C", VA = "0x14ED81C")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x14EB504", Offset = "0x14EB504", VA = "0x14EB504")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x14EBBB0", Offset = "0x14EBBB0", VA = "0x14EBBB0")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x14ED5BC", Offset = "0x14ED5BC", VA = "0x14ED5BC")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000066")]
		public enum Smoothing
		{
			[Token(Token = "0x40002AD")]
			None,
			[Token(Token = "0x40002AE")]
			Exponential,
			[Token(Token = "0x40002AF")]
			Cubic
		}

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40002A1")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x14EA8A0", Offset = "0x14EA8A0", VA = "0x14EA8A0")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x14EAA08", Offset = "0x14EAA08", VA = "0x14EAA08")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x14EAB3C", Offset = "0x14EAB3C", VA = "0x14EAB3C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x14EAC74", Offset = "0x14EAC74", VA = "0x14EAC74")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x14EAD30", Offset = "0x14EAD30", VA = "0x14EAD30")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x14EAE3C", Offset = "0x14EAE3C", VA = "0x14EAE3C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x14EB7CC", Offset = "0x14EB7CC", VA = "0x14EB7CC")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x14EAFA8", Offset = "0x14EAFA8", VA = "0x14EAFA8")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x14EBD94", Offset = "0x14EBD94", VA = "0x14EBD94")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x14EC028", Offset = "0x14EC028", VA = "0x14EC028")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x14EC2F8", Offset = "0x14EC2F8", VA = "0x14EC2F8")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x14ECCC0", Offset = "0x14ECCC0", VA = "0x14ECCC0")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x14ED1B8", Offset = "0x14ED1B8", VA = "0x14ED1B8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x14ED3B8", Offset = "0x14ED3B8", VA = "0x14ED3B8")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x14ED0A4", Offset = "0x14ED0A4", VA = "0x14ED0A4")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x14ECB60", Offset = "0x14ECB60", VA = "0x14ECB60")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x14ED040", Offset = "0x14ED040", VA = "0x14ED040")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x14ED494", Offset = "0x14ED494", VA = "0x14ED494")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x14ECF6C", Offset = "0x14ECF6C", VA = "0x14ECF6C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x14ED2BC", Offset = "0x14ED2BC", VA = "0x14ED2BC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000042")]
		public bool initiated
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x14EDA34", Offset = "0x14EDA34", VA = "0x14EDA34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x14EDA3C", Offset = "0x14EDA3C", VA = "0x14EDA3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x14ED85C", Offset = "0x14ED85C", VA = "0x14ED85C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x14EA99C", Offset = "0x14EA99C", VA = "0x14EA99C")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x14EDA48", Offset = "0x14EDA48", VA = "0x14EDA48")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x14EB558", Offset = "0x14EB558", VA = "0x14EB558")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x14EB564", Offset = "0x14EB564", VA = "0x14EB564")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x14EDC1C", Offset = "0x14EDC1C", VA = "0x14EDC1C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x14EDF70", Offset = "0x14EDF70", VA = "0x14EDF70")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x14EC530", Offset = "0x14EC530", VA = "0x14EC530")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x14EDAD4", Offset = "0x14EDAD4", VA = "0x14EDAD4")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x14EDB78", Offset = "0x14EDB78", VA = "0x14EDB78")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKEffector
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000043")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x14EE338", Offset = "0x14EE338", VA = "0x14EE338")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x14EE340", Offset = "0x14EE340", VA = "0x14EE340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x14EA29C", Offset = "0x14EA29C", VA = "0x14EA29C")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x14EE34C", Offset = "0x14EE34C", VA = "0x14EE34C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x14EE3D0", Offset = "0x14EE3D0", VA = "0x14EE3D0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14EE570", Offset = "0x14EE570", VA = "0x14EE570")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x14EE72C", Offset = "0x14EE72C", VA = "0x14EE72C")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x14EEA20", Offset = "0x14EEA20", VA = "0x14EEA20")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x14EECC0", Offset = "0x14EECC0", VA = "0x14EECC0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x14EEDE0", Offset = "0x14EEDE0", VA = "0x14EEDE0")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x14EEE7C", Offset = "0x14EEE7C", VA = "0x14EEE7C")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x14EF530", Offset = "0x14EF530", VA = "0x14EF530")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x14EF588", Offset = "0x14EF588", VA = "0x14EF588")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x14EF75C", Offset = "0x14EF75C", VA = "0x14EF75C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x14EF9B8", Offset = "0x14EF9B8", VA = "0x14EF9B8")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x200006A")]
		public class BoneMap
		{
			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40002E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40002E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000044")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x14EFF04", Offset = "0x14EFF04", VA = "0x14EFF04")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000045")]
			public bool isNodeBone
			{
				[Token(Token = "0x600031A")]
				[Address(RVA = "0x14EFFBC", Offset = "0x14EFFBC", VA = "0x14EFFBC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000046")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x14F0384", Offset = "0x14F0384", VA = "0x14F0384")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x14EFED8", Offset = "0x14EFED8", VA = "0x14EFED8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x14EFF34", Offset = "0x14EFF34", VA = "0x14EFF34")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x14EFF78", Offset = "0x14EFF78", VA = "0x14EFF78")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x14EFFCC", Offset = "0x14EFFCC", VA = "0x14EFFCC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x14F00A0", Offset = "0x14F00A0", VA = "0x14F00A0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x14F00A8", Offset = "0x14F00A8", VA = "0x14F00A8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x14F0174", Offset = "0x14F0174", VA = "0x14F0174")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x14F01E0", Offset = "0x14F01E0", VA = "0x14F01E0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x14F0274", Offset = "0x14F0274", VA = "0x14F0274")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x14F04EC", Offset = "0x14F04EC", VA = "0x14F04EC")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x14F0518", Offset = "0x14F0518", VA = "0x14F0518")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x14F0544", Offset = "0x14F0544", VA = "0x14F0544")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x14F056C", Offset = "0x14F056C", VA = "0x14F056C")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x14F0630", Offset = "0x14F0630", VA = "0x14F0630")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x14F07C4", Offset = "0x14F07C4", VA = "0x14F07C4")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x14F07E8", Offset = "0x14F07E8", VA = "0x14F07E8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x14F0908", Offset = "0x14F0908", VA = "0x14F0908")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x14F096C", Offset = "0x14F096C", VA = "0x14F096C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x14F0AEC", Offset = "0x14F0AEC", VA = "0x14F0AEC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x14F0C6C", Offset = "0x14F0C6C", VA = "0x14F0C6C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x14F0CE8", Offset = "0x14F0CE8", VA = "0x14F0CE8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x14F06A8", Offset = "0x14F06A8", VA = "0x14F06A8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x14F0E10", Offset = "0x14F0E10", VA = "0x14F0E10")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x14EFC74", Offset = "0x14EFC74", VA = "0x14EFC74", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x14EFC7C", Offset = "0x14EFC7C", VA = "0x14EFC7C", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x14EFC80", Offset = "0x14EFC80", VA = "0x14EFC80")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x14EFDBC", Offset = "0x14EFDBC", VA = "0x14EFDBC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x14EFED0", Offset = "0x14EFED0", VA = "0x14EFED0")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x14F0E2C", Offset = "0x14F0E2C", VA = "0x14F0E2C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x14F0EC8", Offset = "0x14F0EC8", VA = "0x14F0EC8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x14F0F4C", Offset = "0x14F0F4C", VA = "0x14F0F4C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x14F0FE4", Offset = "0x14F0FE4", VA = "0x14F0FE4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x14F0FFC", Offset = "0x14F0FFC", VA = "0x14F0FFC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x14F1018", Offset = "0x14F1018", VA = "0x14F1018", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x14F10A4", Offset = "0x14F10A4", VA = "0x14F10A4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x14F10BC", Offset = "0x14F10BC", VA = "0x14F10BC")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000307")]
			Parent,
			[Token(Token = "0x4000308")]
			Bone1,
			[Token(Token = "0x4000309")]
			Bone2,
			[Token(Token = "0x400030A")]
			Bone3
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x14F10E0", Offset = "0x14F10E0", VA = "0x14F10E0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x14F1154", Offset = "0x14F1154", VA = "0x14F1154")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x14F121C", Offset = "0x14F121C", VA = "0x14F121C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x14F14D4", Offset = "0x14F14D4", VA = "0x14F14D4")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x14F15F0", Offset = "0x14F15F0", VA = "0x14F15F0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x14F1738", Offset = "0x14F1738", VA = "0x14F1738")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x14F1744", Offset = "0x14F1744", VA = "0x14F1744")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x14F17DC", Offset = "0x14F17DC", VA = "0x14F17DC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14F1884", Offset = "0x14F1884", VA = "0x14F1884", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x14F1AE0", Offset = "0x14F1AE0", VA = "0x14F1AE0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x14F1B40", Offset = "0x14F1B40", VA = "0x14F1B40")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x14F1C88", Offset = "0x14F1C88", VA = "0x14F1C88", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x14F1FA8", Offset = "0x14F1FA8", VA = "0x14F1FA8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x14F20E4", Offset = "0x14F20E4", VA = "0x14F20E4")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x14F2254", Offset = "0x14F2254", VA = "0x14F2254")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x14F2264", Offset = "0x14F2264", VA = "0x14F2264")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x14F22C0", Offset = "0x14F22C0", VA = "0x14F22C0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x14F2338", Offset = "0x14F2338", VA = "0x14F2338", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x14F294C", Offset = "0x14F294C", VA = "0x14F294C")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x14F2984", Offset = "0x14F2984", VA = "0x14F2984")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x14F2BE8", Offset = "0x14F2BE8", VA = "0x14F2BE8")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14F2F10", Offset = "0x14F2F10", VA = "0x14F2F10")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x14F2FF0", Offset = "0x14F2FF0", VA = "0x14F2FF0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x14F30A4", Offset = "0x14F30A4", VA = "0x14F30A4")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000070")]
		public class Point
		{
			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x14F397C", Offset = "0x14F397C", VA = "0x14F397C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x14F39C0", Offset = "0x14F39C0", VA = "0x14F39C0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x14F3AA0", Offset = "0x14F3AA0", VA = "0x14F3AA0")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000369")]
			[Address(RVA = "0x14F3ACC", Offset = "0x14F3ACC", VA = "0x14F3ACC")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x14F3AF8", Offset = "0x14F3AF8", VA = "0x14F3AF8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x14F3B3C", Offset = "0x14F3B3C", VA = "0x14F3B3C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x14F3B80", Offset = "0x14F3B80", VA = "0x14F3B80")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public class Bone : Point
		{
			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000048")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x14F3BE0", Offset = "0x14F3BE0", VA = "0x14F3BE0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x14F3CC0", Offset = "0x14F3CC0", VA = "0x14F3CC0")]
				set
				{
				}
			}

			[Token(Token = "0x600036F")]
			[Address(RVA = "0x14F3D38", Offset = "0x14F3D38", VA = "0x14F3D38")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x14F3FA4", Offset = "0x14F3FA4", VA = "0x14F3FA4")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x14F4260", Offset = "0x14F4260", VA = "0x14F4260")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x14F4454", Offset = "0x14F4454", VA = "0x14F4454")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000373")]
			[Address(RVA = "0x14F447C", Offset = "0x14F447C", VA = "0x14F447C")]
			public Bone()
			{
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x14F44E8", Offset = "0x14F44E8", VA = "0x14F44E8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x14F4560", Offset = "0x14F4560", VA = "0x14F4560")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000072")]
		public class Node : Point
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x14F45E8", Offset = "0x14F45E8", VA = "0x14F45E8")]
			public Node()
			{
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x14EAC50", Offset = "0x14EAC50", VA = "0x14EAC50")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x14F45EC", Offset = "0x14F45EC", VA = "0x14F45EC")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000073")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000074")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		protected Transform root;

		[Token(Token = "0x17000047")]
		public bool initiated
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x14F3588", Offset = "0x14F3588", VA = "0x14F3588")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x14F3590", Offset = "0x14F3590", VA = "0x14F3590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x14F32E8", Offset = "0x14F32E8", VA = "0x14F32E8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x14F335C", Offset = "0x14F335C", VA = "0x14F335C")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x14F34D4", Offset = "0x14F34D4", VA = "0x14F34D4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x14F3544", Offset = "0x14F3544", VA = "0x14F3544", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x14F3550", Offset = "0x14F3550", VA = "0x14F3550")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x14F355C", Offset = "0x14F355C", VA = "0x14F355C")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x14F3564", Offset = "0x14F3564", VA = "0x14F3564")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x14F3580", Offset = "0x14F3580", VA = "0x14F3580")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600035C")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600035D")]
		public abstract void FixTransforms();

		[Token(Token = "0x600035E")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600035F")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000360")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x14F359C", Offset = "0x14F359C", VA = "0x14F359C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x14F35B4", Offset = "0x14F35B4", VA = "0x14F35B4")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x14F36D8", Offset = "0x14F36D8", VA = "0x14F36D8")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x14F3770", Offset = "0x14F3770", VA = "0x14F3770")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x14F3964", Offset = "0x14F3964", VA = "0x14F3964")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000049")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x14F483C", Offset = "0x14F483C", VA = "0x14F483C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x14F486C", Offset = "0x14F486C", VA = "0x14F486C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004B")]
		protected override int minBones
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x14F54A0", Offset = "0x14F54A0", VA = "0x14F54A0", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x14F59E0", Offset = "0x14F59E0", VA = "0x14F59E0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x14F4704", Offset = "0x14F4704", VA = "0x14F4704")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x14F489C", Offset = "0x14F489C", VA = "0x14F489C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x14F4B28", Offset = "0x14F4B28", VA = "0x14F4B28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x14F53F8", Offset = "0x14F53F8", VA = "0x14F53F8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x14F5094", Offset = "0x14F5094", VA = "0x14F5094")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x14F54A8", Offset = "0x14F54A8", VA = "0x14F54A8")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x14F5A40", Offset = "0x14F5A40", VA = "0x14F5A40")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x14F5AE4", Offset = "0x14F5AE4", VA = "0x14F5AE4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x14F5E40", Offset = "0x14F5E40", VA = "0x14F5E40")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x14F5EA0", Offset = "0x14F5EA0", VA = "0x14F5EA0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x14F5FE4", Offset = "0x14F5FE4", VA = "0x14F5FE4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x14F6144", Offset = "0x14F6144", VA = "0x14F6144", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x14F6184", Offset = "0x14F6184", VA = "0x14F6184", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x14F61D4", Offset = "0x14F61D4", VA = "0x14F61D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x14F6534", Offset = "0x14F6534", VA = "0x14F6534", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x14F6554", Offset = "0x14F6554", VA = "0x14F6554")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x14F622C", Offset = "0x14F622C", VA = "0x14F622C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x14F65BC", Offset = "0x14F65BC", VA = "0x14F65BC")]
		private void Write()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x14F6734", Offset = "0x14F6734", VA = "0x14F6734")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x14F68C8", Offset = "0x14F68C8", VA = "0x14F68C8")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x14F6938", Offset = "0x14F6938", VA = "0x14F6938", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x14F69A8", Offset = "0x14F69A8", VA = "0x14F69A8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x14F6C5C", Offset = "0x14F6C5C", VA = "0x14F6C5C")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x14F72EC", Offset = "0x14F72EC", VA = "0x14F72EC")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700004D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x159A4F4", Offset = "0x159A4F4", VA = "0x159A4F4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1598CA0", Offset = "0x1598CA0", VA = "0x1598CA0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x159927C", Offset = "0x159927C", VA = "0x159927C")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x15993A8", Offset = "0x15993A8", VA = "0x15993A8", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1599430", Offset = "0x1599430", VA = "0x1599430", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1599DBC", Offset = "0x1599DBC", VA = "0x1599DBC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x159A4FC", Offset = "0x159A4FC", VA = "0x159A4FC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1598D74", Offset = "0x1598D74", VA = "0x1598D74")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1599360", Offset = "0x1599360", VA = "0x1599360")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x159A4AC", Offset = "0x159A4AC", VA = "0x159A4AC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1599110", Offset = "0x1599110", VA = "0x1599110")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x159ABB0", Offset = "0x159ABB0", VA = "0x159ABB0")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x159AC18", Offset = "0x159AC18", VA = "0x159AC18")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x159ACE8", Offset = "0x159ACE8", VA = "0x159ACE8")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x159ADB0", Offset = "0x159ADB0", VA = "0x159ADB0")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1599B34", Offset = "0x1599B34", VA = "0x1599B34")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1599C78", Offset = "0x1599C78", VA = "0x1599C78")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x159AEA0", Offset = "0x159AEA0", VA = "0x159AEA0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x159A79C", Offset = "0x159A79C", VA = "0x159A79C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1599350", Offset = "0x1599350", VA = "0x1599350")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x159B518", Offset = "0x159B518", VA = "0x159B518")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x159B064", Offset = "0x159B064", VA = "0x159B064")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x159A618", Offset = "0x159A618", VA = "0x159A618")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x159A6EC", Offset = "0x159A6EC", VA = "0x159A6EC")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x159B5D0", Offset = "0x159B5D0", VA = "0x159B5D0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x159B6B8", Offset = "0x159B6B8", VA = "0x159B6B8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x159BD0C", Offset = "0x159BD0C", VA = "0x159BD0C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x159BD98", Offset = "0x159BD98", VA = "0x159BD98", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x159BE2C", Offset = "0x159BE2C", VA = "0x159BE2C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x159BF14", Offset = "0x159BF14", VA = "0x159BF14")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x159BFA4", Offset = "0x159BFA4", VA = "0x159BFA4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x159C3A4", Offset = "0x159C3A4", VA = "0x159C3A4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x159C57C", Offset = "0x159C57C", VA = "0x159C57C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x159C444", Offset = "0x159C444", VA = "0x159C444")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x159C17C", Offset = "0x159C17C", VA = "0x159C17C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x159C600", Offset = "0x159C600", VA = "0x159C600")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x159C660", Offset = "0x159C660", VA = "0x159C660")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x159C73C", Offset = "0x159C73C", VA = "0x159C73C")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x159C784", Offset = "0x159C784", VA = "0x159C784")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x159C898", Offset = "0x159C898", VA = "0x159C898")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x159C8E8", Offset = "0x159C8E8", VA = "0x159C8E8")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x159C95C", Offset = "0x159C95C", VA = "0x159C95C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x159CAF4", Offset = "0x159CAF4", VA = "0x159CAF4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x159CC50", Offset = "0x159CC50", VA = "0x159CC50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x159CE50", Offset = "0x159CE50", VA = "0x159CE50", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x159CF24", Offset = "0x159CF24", VA = "0x159CF24", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x159D00C", Offset = "0x159D00C", VA = "0x159D00C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x159D16C", Offset = "0x159D16C", VA = "0x159D16C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x159D308", Offset = "0x159D308", VA = "0x159D308", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x159D540", Offset = "0x159D540", VA = "0x159D540", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x159D820", Offset = "0x159D820", VA = "0x159D820", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x159D858", Offset = "0x159D858", VA = "0x159D858", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x159D93C", Offset = "0x159D93C", VA = "0x159D93C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000364")]
		Body,
		[Token(Token = "0x4000365")]
		LeftShoulder,
		[Token(Token = "0x4000366")]
		RightShoulder,
		[Token(Token = "0x4000367")]
		LeftThigh,
		[Token(Token = "0x4000368")]
		RightThigh,
		[Token(Token = "0x4000369")]
		LeftHand,
		[Token(Token = "0x400036A")]
		RightHand,
		[Token(Token = "0x400036B")]
		LeftFoot,
		[Token(Token = "0x400036C")]
		RightFoot,
		[Token(Token = "0x400036D")]
		LeftElbow,
		[Token(Token = "0x400036E")]
		RightElbow,
		[Token(Token = "0x400036F")]
		LeftKnee,
		[Token(Token = "0x4000370")]
		RightKnee
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000372")]
		LeftArm,
		[Token(Token = "0x4000373")]
		RightArm,
		[Token(Token = "0x4000374")]
		LeftLeg,
		[Token(Token = "0x4000375")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004E")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x159DA4C", Offset = "0x159DA4C", VA = "0x159DA4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x159DB8C", Offset = "0x159DB8C", VA = "0x159DB8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x159DB94", Offset = "0x159DB94", VA = "0x159DB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x159DB9C", Offset = "0x159DB9C", VA = "0x159DB9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x159DBA4", Offset = "0x159DBA4", VA = "0x159DBA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x159DBAC", Offset = "0x159DBAC", VA = "0x159DBAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x159DBB4", Offset = "0x159DBB4", VA = "0x159DBB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x159DBBC", Offset = "0x159DBBC", VA = "0x159DBBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x159DBC4", Offset = "0x159DBC4", VA = "0x159DBC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IKEffector leftElbowEffector
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x159DBCC", Offset = "0x159DBCC", VA = "0x159DBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IKEffector rightElbowEffector
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x159DBD4", Offset = "0x159DBD4", VA = "0x159DBD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKEffector leftKneeEffector
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x159DBDC", Offset = "0x159DBDC", VA = "0x159DBDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKEffector rightKneeEffector
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x159DBE4", Offset = "0x159DBE4", VA = "0x159DBE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x159DBEC", Offset = "0x159DBEC", VA = "0x159DBEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x159DC18", Offset = "0x159DC18", VA = "0x159DC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x159DC44", Offset = "0x159DC44", VA = "0x159DC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x159DC70", Offset = "0x159DC70", VA = "0x159DC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x159DC9C", Offset = "0x159DC9C", VA = "0x159DC9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x159DCC4", Offset = "0x159DCC4", VA = "0x159DCC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x159DCF0", Offset = "0x159DCF0", VA = "0x159DCF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x159DD1C", Offset = "0x159DD1C", VA = "0x159DD1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x159DD48", Offset = "0x159DD48", VA = "0x159DD48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x159FB38", Offset = "0x159FB38", VA = "0x159FB38")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x159FB44", Offset = "0x159FB44", VA = "0x159FB44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x159DD70", Offset = "0x159DD70", VA = "0x159DD70")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x159DE70", Offset = "0x159DE70", VA = "0x159DE70")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x159DDC0", Offset = "0x159DDC0", VA = "0x159DDC0")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x159DEE8", Offset = "0x159DEE8", VA = "0x159DEE8")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x159DA54", Offset = "0x159DA54", VA = "0x159DA54")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x159DFB0", Offset = "0x159DFB0", VA = "0x159DFB0")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x159E060", Offset = "0x159E060", VA = "0x159E060")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x159E10C", Offset = "0x159E10C", VA = "0x159E10C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x159E1B8", Offset = "0x159E1B8", VA = "0x159E1B8")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x159E1C0", Offset = "0x159E1C0", VA = "0x159E1C0")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x159E1E8", Offset = "0x159E1E8", VA = "0x159E1E8")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x159E2A8", Offset = "0x159E2A8", VA = "0x159E2A8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x159E438", Offset = "0x159E438", VA = "0x159E438")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x159F430", Offset = "0x159F430", VA = "0x159F430")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x159F9E0", Offset = "0x159F9E0", VA = "0x159F9E0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x159FA3C", Offset = "0x159FA3C", VA = "0x159FA3C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x159F880", Offset = "0x159F880", VA = "0x159F880")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x159F930", Offset = "0x159F930", VA = "0x159F930")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x159FB50", Offset = "0x159FB50", VA = "0x159FB50")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x159FC14", Offset = "0x159FC14", VA = "0x159FC14", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x159FCE4", Offset = "0x159FCE4", VA = "0x159FCE4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x159FE00", Offset = "0x159FE00", VA = "0x159FE00")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x159FF90", Offset = "0x159FF90", VA = "0x159FF90")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x15A0108", Offset = "0x15A0108", VA = "0x15A0108", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x15A0368", Offset = "0x15A0368", VA = "0x15A0368", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x15A03E0", Offset = "0x15A03E0", VA = "0x15A03E0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000065")]
		protected virtual int minBones
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x15A0C20", Offset = "0x15A0C20", VA = "0x15A0C20", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x15A0C28", Offset = "0x15A0C28", VA = "0x15A0C28", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x15A0C30", Offset = "0x15A0C30", VA = "0x15A0C30", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x15A0C40", Offset = "0x15A0C40", VA = "0x15A0C40", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000069")]
		protected float positionOffset
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x159A464", Offset = "0x159A464", VA = "0x159A464")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x15A03EC", Offset = "0x15A03EC", VA = "0x15A03EC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x15A0570", Offset = "0x15A0570", VA = "0x15A0570")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x15A069C", Offset = "0x15A069C", VA = "0x15A069C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x15A06FC", Offset = "0x15A06FC", VA = "0x15A06FC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x15A0770", Offset = "0x15A0770", VA = "0x15A0770", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x15A0B3C", Offset = "0x15A0B3C", VA = "0x15A0B3C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x15A0B44", Offset = "0x15A0B44", VA = "0x15A0B44", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x15A0C38", Offset = "0x15A0C38", VA = "0x15A0C38", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x15A0C3C", Offset = "0x15A0C3C", VA = "0x15A0C3C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x15996A0", Offset = "0x15996A0", VA = "0x15996A0")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x159A0AC", Offset = "0x159A0AC", VA = "0x159A0AC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x15A0CFC", Offset = "0x15A0CFC", VA = "0x15A0CFC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x159B650", Offset = "0x159B650", VA = "0x159B650")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x15A0F90", Offset = "0x15A0F90", VA = "0x15A0F90", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x15A12EC", Offset = "0x15A12EC", VA = "0x15A12EC")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x15A1350", Offset = "0x15A1350", VA = "0x15A1350", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x15A1494", Offset = "0x15A1494", VA = "0x15A1494", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x15A15F4", Offset = "0x15A15F4", VA = "0x15A15F4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x15A1644", Offset = "0x15A1644", VA = "0x15A1644", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x15A16A4", Offset = "0x15A16A4", VA = "0x15A16A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x15A1A04", Offset = "0x15A1A04", VA = "0x15A1A04", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x15A1A24", Offset = "0x15A1A24", VA = "0x15A1A24")]
		private void Solve()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x15A16FC", Offset = "0x15A16FC", VA = "0x15A16FC")]
		private void Read()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x15A1AB4", Offset = "0x15A1AB4", VA = "0x15A1AB4")]
		private void Write()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x15A1C2C", Offset = "0x15A1C2C", VA = "0x15A1C2C")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		public enum BendModifier
		{
			[Token(Token = "0x40003A0")]
			Animation,
			[Token(Token = "0x40003A1")]
			Target,
			[Token(Token = "0x40003A2")]
			Parent,
			[Token(Token = "0x40003A3")]
			Arm,
			[Token(Token = "0x40003A4")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public struct AxisDirection
		{
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x15A31B0", Offset = "0x15A31B0", VA = "0x15A31B0")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700006A")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x15A3194", Offset = "0x15A3194", VA = "0x15A3194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x15A1DC4", Offset = "0x15A1DC4", VA = "0x15A1DC4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x15A1E08", Offset = "0x15A1E08", VA = "0x15A1E08")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x15A1E74", Offset = "0x15A1E74", VA = "0x15A1E74", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x15A23BC", Offset = "0x15A23BC", VA = "0x15A23BC", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x15A2ED8", Offset = "0x15A2ED8", VA = "0x15A2ED8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x15A2F80", Offset = "0x15A2F80", VA = "0x15A2F80")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x15A3114", Offset = "0x15A3114", VA = "0x15A3114")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x15A21D0", Offset = "0x15A21D0", VA = "0x15A21D0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x15A2478", Offset = "0x15A2478", VA = "0x15A2478")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000071")]
			public Vector3 forward
			{
				[Token(Token = "0x600044C")]
				[Address(RVA = "0x15A4F7C", Offset = "0x15A4F7C", VA = "0x15A4F7C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x15A55D4", Offset = "0x15A55D4", VA = "0x15A55D4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x15A40DC", Offset = "0x15A40DC", VA = "0x15A40DC")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x15A438C", Offset = "0x15A438C", VA = "0x15A438C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x15A52C4", Offset = "0x15A52C4", VA = "0x15A52C4")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x1700006B")]
		protected bool spineIsValid
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x15A38E0", Offset = "0x15A38E0", VA = "0x15A38E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x15A3A88", Offset = "0x15A3A88", VA = "0x15A3A88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		protected bool headIsValid
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x15A39AC", Offset = "0x15A39AC", VA = "0x15A39AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x15A3AAC", Offset = "0x15A3AAC", VA = "0x15A3AAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x15A39BC", Offset = "0x15A39BC", VA = "0x15A39BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x15A3B18", Offset = "0x15A3B18", VA = "0x15A3B18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x15A334C", Offset = "0x15A334C", VA = "0x15A334C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x15A3368", Offset = "0x15A3368", VA = "0x15A3368")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x15A3394", Offset = "0x15A3394", VA = "0x15A3394")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x15A33CC", Offset = "0x15A33CC", VA = "0x15A33CC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x15A3414", Offset = "0x15A3414", VA = "0x15A3414")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x15A346C", Offset = "0x15A346C", VA = "0x15A346C")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x15A34DC", Offset = "0x15A34DC", VA = "0x15A34DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x15A35F4", Offset = "0x15A35F4", VA = "0x15A35F4")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x15A3600", Offset = "0x15A3600", VA = "0x15A3600", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x15A3730", Offset = "0x15A3730", VA = "0x15A3730", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x15A3B3C", Offset = "0x15A3B3C", VA = "0x15A3B3C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x15A3D60", Offset = "0x15A3D60", VA = "0x15A3D60", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x15A3EC0", Offset = "0x15A3EC0", VA = "0x15A3EC0")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x15A4104", Offset = "0x15A4104", VA = "0x15A4104", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x15A4478", Offset = "0x15A4478", VA = "0x15A4478", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x15A453C", Offset = "0x15A453C", VA = "0x15A453C")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x15A4758", Offset = "0x15A4758", VA = "0x15A4758")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x15A4AA0", Offset = "0x15A4AA0", VA = "0x15A4AA0")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x15A4FAC", Offset = "0x15A4FAC", VA = "0x15A4FAC")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x15A3F70", Offset = "0x15A3F70", VA = "0x15A3F70")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x15A53CC", Offset = "0x15A53CC", VA = "0x15A53CC")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000086")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x15A6878", Offset = "0x15A6878", VA = "0x15A6878")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x15A7120", Offset = "0x15A7120", VA = "0x15A7120")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x15A1E44", Offset = "0x15A1E44", VA = "0x15A1E44")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x15A71BC", Offset = "0x15A71BC", VA = "0x15A71BC")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x15A55DC", Offset = "0x15A55DC", VA = "0x15A55DC")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x15A5770", Offset = "0x15A5770", VA = "0x15A5770")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x15A58F0", Offset = "0x15A58F0", VA = "0x15A58F0")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x15A58FC", Offset = "0x15A58FC", VA = "0x15A58FC")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x15A5918", Offset = "0x15A5918", VA = "0x15A5918")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x15A5924", Offset = "0x15A5924", VA = "0x15A5924")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x15A592C", Offset = "0x15A592C", VA = "0x15A592C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x15A5A18", Offset = "0x15A5A18", VA = "0x15A5A18", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x15A5B10", Offset = "0x15A5B10", VA = "0x15A5B10", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x15A5B50", Offset = "0x15A5B50", VA = "0x15A5B50", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x15A5BA0", Offset = "0x15A5BA0", VA = "0x15A5BA0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x15A5F44", Offset = "0x15A5F44", VA = "0x15A5F44")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x15A5F90", Offset = "0x15A5F90", VA = "0x15A5F90")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x15A6484", Offset = "0x15A6484", VA = "0x15A6484")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x15A65DC", Offset = "0x15A65DC", VA = "0x15A65DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x15A6788", Offset = "0x15A6788", VA = "0x15A6788")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x15A6708", Offset = "0x15A6708", VA = "0x15A6708")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x15A6968", Offset = "0x15A6968", VA = "0x15A6968", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x15A71B0", Offset = "0x15A71B0", VA = "0x15A71B0", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x15A71B4", Offset = "0x15A71B4", VA = "0x15A71B4", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x15A71B8", Offset = "0x15A71B8", VA = "0x15A71B8", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x15A6F60", Offset = "0x15A6F60", VA = "0x15A6F60")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x15A2FEC", Offset = "0x15A2FEC", VA = "0x15A2FEC")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000089")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400040B")]
				YawPitch,
				[Token(Token = "0x400040C")]
				FromTo
			}

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Hand")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("The weight of shoulder rotation")]
			[LargeHeader("Shoulder")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[ShowRangeIf(0f, 1f, "shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderTwistWeight;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the yaw (up) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderYawOffset;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the pitch (forward) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderPitchOffset;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Bending")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0.01f, 2f)]
			[LargeHeader("Stretching")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			public float armLengthMlp;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("'Time' represents (target distance / arm length) and 'value' represents the amount of stretching. So value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right by the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x17000074")]
			public Vector3 position
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x12506D8", Offset = "0x12506D8", VA = "0x12506D8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x12506E4", Offset = "0x12506E4", VA = "0x12506E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000075")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x12506F0", Offset = "0x12506F0", VA = "0x12506F0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000489")]
				[Address(RVA = "0x12506FC", Offset = "0x12506FC", VA = "0x12506FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600048A")]
				[Address(RVA = "0x1250708", Offset = "0x1250708", VA = "0x1250708")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0x1250730", Offset = "0x1250730", VA = "0x1250730")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600048C")]
				[Address(RVA = "0x1250764", Offset = "0x1250764", VA = "0x1250764")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000079")]
			private VirtualBone hand
			{
				[Token(Token = "0x600048D")]
				[Address(RVA = "0x12507A4", Offset = "0x12507A4", VA = "0x12507A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x12507E4", Offset = "0x12507E4", VA = "0x12507E4", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x12511A4", Offset = "0x12511A4", VA = "0x12511A4", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x1251450", Offset = "0x1251450", VA = "0x1251450", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x1251474", Offset = "0x1251474", VA = "0x1251474")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x12517C4", Offset = "0x12517C4", VA = "0x12517C4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x1253A08", Offset = "0x1253A08", VA = "0x1253A08", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x1253A60", Offset = "0x1253A60", VA = "0x1253A60", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x1252DBC", Offset = "0x1252DBC", VA = "0x1252DBC")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1252FC4", Offset = "0x1252FC4", VA = "0x1252FC4")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1253C6C", Offset = "0x1253C6C", VA = "0x1253C6C")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1253D84", Offset = "0x1253D84", VA = "0x1253D84")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public abstract class BodyPart
		{
			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x1700007A")]
			public float sqrMag
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0x1253FBC", Offset = "0x1253FBC", VA = "0x1253FBC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600049F")]
				[Address(RVA = "0x1253FC4", Offset = "0x1253FC4", VA = "0x1253FC4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007B")]
			public float mag
			{
				[Token(Token = "0x60004A0")]
				[Address(RVA = "0x1253FCC", Offset = "0x1253FCC", VA = "0x1253FCC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0x1253FD4", Offset = "0x1253FD4", VA = "0x1253FD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000499")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600049A")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x600049B")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600049C")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x600049D")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1253FDC", Offset = "0x1253FDC", VA = "0x1253FDC")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1253FE4", Offset = "0x1253FE4", VA = "0x1253FE4")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1254200", Offset = "0x1254200", VA = "0x1254200")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x1254288", Offset = "0x1254288", VA = "0x1254288")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x125448C", Offset = "0x125448C", VA = "0x125448C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x12544D4", Offset = "0x12544D4", VA = "0x12544D4")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x12538A4", Offset = "0x12538A4", VA = "0x12538A4")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x12545F8", Offset = "0x12545F8", VA = "0x12545F8")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x125471C", Offset = "0x125471C", VA = "0x125471C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x1253F24", Offset = "0x1253F24", VA = "0x1253F24")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Footstep
		{
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700007C")]
			public bool isStepping
			{
				[Token(Token = "0x60004AC")]
				[Address(RVA = "0x1254730", Offset = "0x1254730", VA = "0x1254730")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700007D")]
			public float stepProgress
			{
				[Token(Token = "0x60004AD")]
				[Address(RVA = "0x1254744", Offset = "0x1254744", VA = "0x1254744")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60004AE")]
				[Address(RVA = "0x125474C", Offset = "0x125474C", VA = "0x125474C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x1254754", Offset = "0x1254754", VA = "0x1254754")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x1254918", Offset = "0x1254918", VA = "0x1254918")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x1254960", Offset = "0x1254960", VA = "0x1254960")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1254BA4", Offset = "0x1254BA4", VA = "0x1254BA4")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1254D44", Offset = "0x1254D44", VA = "0x1254D44")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1254F3C", Offset = "0x1254F3C", VA = "0x1254F3C")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Foot/Toe")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			[LargeHeader("Bending")]
			public Transform bendGoal;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[LargeHeader("Stretching")]
			public float legLengthMlp;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x1700007E")]
			public Vector3 position
			{
				[Token(Token = "0x60004B5")]
				[Address(RVA = "0x12550AC", Offset = "0x12550AC", VA = "0x12550AC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B6")]
				[Address(RVA = "0x12550B8", Offset = "0x12550B8", VA = "0x12550B8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion rotation
			{
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0x12550C4", Offset = "0x12550C4", VA = "0x12550C4")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004B8")]
				[Address(RVA = "0x12550D0", Offset = "0x12550D0", VA = "0x12550D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public bool hasToes
			{
				[Token(Token = "0x60004B9")]
				[Address(RVA = "0x12550DC", Offset = "0x12550DC", VA = "0x12550DC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0x12550E4", Offset = "0x12550E4", VA = "0x12550E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60004BB")]
				[Address(RVA = "0x12550F0", Offset = "0x12550F0", VA = "0x12550F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private VirtualBone calf
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x1255118", Offset = "0x1255118", VA = "0x1255118")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private VirtualBone foot
			{
				[Token(Token = "0x60004BD")]
				[Address(RVA = "0x1255144", Offset = "0x1255144", VA = "0x1255144")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private VirtualBone toes
			{
				[Token(Token = "0x60004BE")]
				[Address(RVA = "0x1255170", Offset = "0x1255170", VA = "0x1255170")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0x125519C", Offset = "0x125519C", VA = "0x125519C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000086")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0x12551D0", Offset = "0x12551D0", VA = "0x12551D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0x12551DC", Offset = "0x12551DC", VA = "0x12551DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000087")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0x12551E8", Offset = "0x12551E8", VA = "0x12551E8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0x12551F8", Offset = "0x12551F8", VA = "0x12551F8")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000088")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0x1255208", Offset = "0x1255208", VA = "0x1255208")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0x1255218", Offset = "0x1255218", VA = "0x1255218")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x1255228", Offset = "0x1255228", VA = "0x1255228", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x1255750", Offset = "0x1255750", VA = "0x1255750", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x1255F80", Offset = "0x1255F80", VA = "0x1255F80", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x1255F30", Offset = "0x1255F30", VA = "0x1255F30")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1255CE4", Offset = "0x1255CE4", VA = "0x1255CE4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x125645C", Offset = "0x125645C", VA = "0x125645C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1256A38", Offset = "0x1256A38", VA = "0x1256A38")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x12566A0", Offset = "0x12566A0", VA = "0x12566A0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1256E90", Offset = "0x1256E90", VA = "0x1256E90", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x1257098", Offset = "0x1257098", VA = "0x1257098", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1257178", Offset = "0x1257178", VA = "0x1257178")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public class Locomotion
		{
			[Serializable]
			[Token(Token = "0x200008E")]
			public enum Mode
			{
				[Token(Token = "0x4000485")]
				Procedural,
				[Token(Token = "0x4000486")]
				Animated
			}

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Procedural (legacy) or animated locomotion.")]
			public Mode mode;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural/animated locomotion.")]
			public float weight;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Start moving (horizontal distance to HMD + HMD velocity) threshold.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float moveThreshold;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[ShowLargeHeaderIf("Animation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte animationHeader;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[ShowRangeIf(0.1f, 1f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Minimum locomotion animation speed.")]
			public float minAnimationSpeed;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[ShowRangeIf(1f, 10f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Maximum locomotion animation speed.")]
			public float maxAnimationSpeed;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[ShowRangeIf(0.05f, 0.2f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Smoothing time for Vector3.SmoothDamping 'VRIK_Horizontal' and 'VRIK_Vertical' parameters. Larger values make animation smoother, but less responsive.")]
			public float animationSmoothTime;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			[ShowLargeHeaderIf("Root Position", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte rootPositionHeader;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("X and Z standing offset from the horizontal position of the HMD.")]
			public Vector2 standOffset;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while moving.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while in transition from locomotion to idle state.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while turning on spot.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max horizontal distance from the root to the HMD.")]
			public float maxRootOffset;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[ShowLargeHeaderIf("Root Rotation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Max root angle from head forward while moving (ik.solver.spine.maxRootAngle).")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleMoving;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max root angle from head forward while standing (ik.solver.spine.maxRootAngle.")]
			public float maxRootAngleStanding;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			[SerializeField]
			public float stepLengthMlp;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int VRIK_Horizontal;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int VRIK_Vertical;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int VRIK_Speed;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int VRIK_Turn;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float angleThreshold;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxVelocity;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float velocityFactor;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[ShowRangeIf(0.9f, 1f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[Tooltip("The speed of moving a foot to the next position.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float stepSpeed;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[Tooltip("Interpolation mode of the step.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			[SerializeField]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private int leftFootIndex;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private int rightFootIndex;

			[Token(Token = "0x17000089")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x1258E78", Offset = "0x1258E78", VA = "0x1258E78")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004DD")]
				[Address(RVA = "0x1258E88", Offset = "0x1258E88", VA = "0x1258E88")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008A")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60004E4")]
				[Address(RVA = "0x125A758", Offset = "0x125A758", VA = "0x125A758")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008B")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0x125A78C", Offset = "0x125A78C", VA = "0x125A78C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008C")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60004E6")]
				[Address(RVA = "0x125A7C4", Offset = "0x125A7C4", VA = "0x125A7C4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x1700008D")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x125A7F8", Offset = "0x125A7F8", VA = "0x125A7F8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1257254", Offset = "0x1257254", VA = "0x1257254")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1257670", Offset = "0x1257670", VA = "0x1257670")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x1257ACC", Offset = "0x1257ACC", VA = "0x1257ACC")]
			public void Relax()
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1257B1C", Offset = "0x1257B1C", VA = "0x1257B1C")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x1258064", Offset = "0x1258064", VA = "0x1258064")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x12575A0", Offset = "0x12575A0", VA = "0x12575A0")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x12581AC", Offset = "0x12581AC", VA = "0x12581AC")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1257884", Offset = "0x1257884", VA = "0x1257884")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x1257F5C", Offset = "0x1257F5C", VA = "0x1257F5C")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x125815C", Offset = "0x125815C", VA = "0x125815C")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x1258264", Offset = "0x1258264", VA = "0x1258264")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x1257294", Offset = "0x1257294", VA = "0x1257294")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x1257698", Offset = "0x1257698", VA = "0x1257698")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x1257AD0", Offset = "0x1257AD0", VA = "0x1257AD0")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1257B8C", Offset = "0x1257B8C", VA = "0x1257B8C")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x12580A4", Offset = "0x12580A4", VA = "0x12580A4")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x1258E98", Offset = "0x1258E98", VA = "0x1258E98")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x125A384", Offset = "0x125A384", VA = "0x125A384")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x125A53C", Offset = "0x125A53C", VA = "0x125A53C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x125A5A8", Offset = "0x125A5A8", VA = "0x125A5A8")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x125A830", Offset = "0x125A830", VA = "0x125A830")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Head")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust its position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Allows for more natural locomotion animation for 3rd person networked avatars by inheriting vertical head bob motion from the animation while head target height is close to head bone height.")]
			[Range(0f, 1f)]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("If abs(head target height - head bone height) < this value, will use head bone height as head target Y.")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Falloff range for the 'Use Animated Head Height Range' effect above. If head target height from head bone height is greater than useAnimatedHeadHeightRange + animatedHeadHeightBlend, then the head will be vertically locked to the head target again.")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Pelvis")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain its animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[LargeHeader("Chest")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[LargeHeader("Spine")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("chestRotationWeight")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			public float neckStiffness;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			[LargeHeader("Root Rotation")]
			public float maxRootAngle;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x1700008E")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x60004EC")]
				[Address(RVA = "0x125A31C", Offset = "0x125A31C", VA = "0x125A31C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60004ED")]
				[Address(RVA = "0x125A980", Offset = "0x125A980", VA = "0x125A980")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60004EE")]
				[Address(RVA = "0x125A9B4", Offset = "0x125A9B4", VA = "0x125A9B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000091")]
			internal VirtualBone head
			{
				[Token(Token = "0x60004EF")]
				[Address(RVA = "0x125A350", Offset = "0x125A350", VA = "0x125A350")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004F0")]
				[Address(RVA = "0x125A9FC", Offset = "0x125A9FC", VA = "0x125A9FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x125AA30", Offset = "0x125AA30", VA = "0x125AA30")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004F2")]
				[Address(RVA = "0x125AA44", Offset = "0x125AA44", VA = "0x125AA44")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004F3")]
				[Address(RVA = "0x125AA58", Offset = "0x125AA58", VA = "0x125AA58")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004F4")]
				[Address(RVA = "0x125AA6C", Offset = "0x125AA6C", VA = "0x125AA6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x125AA80", Offset = "0x125AA80", VA = "0x125AA80", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x125B6E0", Offset = "0x125B6E0", VA = "0x125B6E0", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x125BAEC", Offset = "0x125BAEC", VA = "0x125BAEC", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x125C290", Offset = "0x125C290", VA = "0x125C290")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x125C8E8", Offset = "0x125C8E8", VA = "0x125C8E8")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x125D320", Offset = "0x125D320", VA = "0x125D320")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x125DAC8", Offset = "0x125DAC8", VA = "0x125DAC8")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x125E0A8", Offset = "0x125E0A8", VA = "0x125E0A8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x125E278", Offset = "0x125E278", VA = "0x125E278", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x125C4F0", Offset = "0x125C4F0", VA = "0x125C4F0")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x125D7F4", Offset = "0x125D7F4", VA = "0x125D7F4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000500")]
			[Address(RVA = "0x125CF04", Offset = "0x125CF04", VA = "0x125CF04")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x125E34C", Offset = "0x125E34C", VA = "0x125E34C")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x125D8CC", Offset = "0x125D8CC", VA = "0x125D8CC")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000503")]
			[Address(RVA = "0x125D584", Offset = "0x125D584", VA = "0x125D584")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000504")]
			[Address(RVA = "0x125E5F0", Offset = "0x125E5F0", VA = "0x125E5F0")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public enum PositionOffset
		{
			[Token(Token = "0x40004C1")]
			Pelvis,
			[Token(Token = "0x40004C2")]
			Chest,
			[Token(Token = "0x40004C3")]
			Head,
			[Token(Token = "0x40004C4")]
			LeftHand,
			[Token(Token = "0x40004C5")]
			RightHand,
			[Token(Token = "0x40004C6")]
			LeftFoot,
			[Token(Token = "0x40004C7")]
			RightFoot,
			[Token(Token = "0x40004C8")]
			LeftHeel,
			[Token(Token = "0x40004C9")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public enum RotationOffset
		{
			[Token(Token = "0x40004CB")]
			Pelvis,
			[Token(Token = "0x40004CC")]
			Chest,
			[Token(Token = "0x40004CD")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class VirtualBone
		{
			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1251114", Offset = "0x1251114", VA = "0x1251114")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1251184", Offset = "0x1251184", VA = "0x1251184")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000507")]
			[Address(RVA = "0x125E720", Offset = "0x125E720", VA = "0x125E720")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000508")]
			[Address(RVA = "0x12540A0", Offset = "0x12540A0", VA = "0x12540A0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x125431C", Offset = "0x125431C", VA = "0x125431C")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x125E920", Offset = "0x125E920", VA = "0x125E920")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1252E3C", Offset = "0x1252E3C", VA = "0x1252E3C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x125EAC8", Offset = "0x125EAC8", VA = "0x125EAC8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600050D")]
			[Address(RVA = "0x12534C0", Offset = "0x12534C0", VA = "0x12534C0")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0x125EB6C", Offset = "0x125EB6C", VA = "0x125EB6C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600050F")]
			[Address(RVA = "0x125DCDC", Offset = "0x125DCDC", VA = "0x125DCDC")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000510")]
			[Address(RVA = "0x125ECC4", Offset = "0x125ECC4", VA = "0x125ECC4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000511")]
			[Address(RVA = "0x125EDD8", Offset = "0x125EDD8", VA = "0x125EDD8")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000072")]
		public Animator animator
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x15A71C4", Offset = "0x15A71C4", VA = "0x15A71C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x15A71CC", Offset = "0x15A71CC", VA = "0x15A71CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000073")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x15AB118", Offset = "0x15AB118", VA = "0x15AB118")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x15AB120", Offset = "0x15AB120", VA = "0x15AB120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x15A71D4", Offset = "0x15A71D4", VA = "0x15A71D4")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x15A7648", Offset = "0x15A7648", VA = "0x15A7648")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x15A74FC", Offset = "0x15A74FC", VA = "0x15A74FC")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x15A7A5C", Offset = "0x15A7A5C", VA = "0x15A7A5C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x15A7BA4", Offset = "0x15A7BA4", VA = "0x15A7BA4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15A7BE4", Offset = "0x15A7BE4", VA = "0x15A7BE4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x15A7D08", Offset = "0x15A7D08", VA = "0x15A7D08")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x15A7DE4", Offset = "0x15A7DE4", VA = "0x15A7DE4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x15A858C", Offset = "0x15A858C", VA = "0x15A858C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x15A86E0", Offset = "0x15A86E0", VA = "0x15A86E0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x15A88CC", Offset = "0x15A88CC", VA = "0x15A88CC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x15A893C", Offset = "0x15A893C", VA = "0x15A893C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x15A89AC", Offset = "0x15A89AC", VA = "0x15A89AC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x15A8BA8", Offset = "0x15A8BA8", VA = "0x15A8BA8")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x15A7948", Offset = "0x15A7948", VA = "0x15A7948")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x15A7F00", Offset = "0x15A7F00", VA = "0x15A7F00")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x15A8E18", Offset = "0x15A8E18", VA = "0x15A8E18", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x15A8E5C", Offset = "0x15A8E5C", VA = "0x15A8E5C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x15AA56C", Offset = "0x15AA56C", VA = "0x15AA56C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x15A8050", Offset = "0x15A8050", VA = "0x15A8050")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x15A9278", Offset = "0x15A9278", VA = "0x15A9278")]
		private void Solve()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x15AA9C0", Offset = "0x15AA9C0", VA = "0x15AA9C0")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x15AA9FC", Offset = "0x15AA9FC", VA = "0x15AA9FC")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x15AA428", Offset = "0x15AA428", VA = "0x15AA428")]
		private void Write()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x15AAA34", Offset = "0x15AAA34", VA = "0x15AAA34")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x15AB128", Offset = "0x15AB128", VA = "0x15AB128")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x125EF8C", Offset = "0x125EF8C", VA = "0x125EF8C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x125F664", Offset = "0x125F664", VA = "0x125F664")]
		private void Update()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x125F7D0", Offset = "0x125F7D0", VA = "0x125F7D0")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x125FD64", Offset = "0x125FD64", VA = "0x125FD64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x125FE14", Offset = "0x125FE14", VA = "0x125FE14")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x125FF2C", Offset = "0x125FF2C", VA = "0x125FF2C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000094")]
	public class TwistSolver
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x125FF84", Offset = "0x125FF84", VA = "0x125FF84")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x125F154", Offset = "0x125F154", VA = "0x125F154")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x125F724", Offset = "0x125F724", VA = "0x125F724")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x125F880", Offset = "0x125F880", VA = "0x125F880")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class InteractionEffector
	{
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000095")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x12600A4", Offset = "0x12600A4", VA = "0x12600A4")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x12600AC", Offset = "0x12600AC", VA = "0x12600AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public bool isPaused
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x12600B4", Offset = "0x12600B4", VA = "0x12600B4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x12600BC", Offset = "0x12600BC", VA = "0x12600BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x12600C8", Offset = "0x12600C8", VA = "0x12600C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x12600D0", Offset = "0x12600D0", VA = "0x12600D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public bool inInteraction
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x12600D8", Offset = "0x12600D8", VA = "0x12600D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public float progress
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x1261B58", Offset = "0x1261B58", VA = "0x1261B58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1260138", Offset = "0x1260138", VA = "0x1260138")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x12601C8", Offset = "0x12601C8", VA = "0x12601C8")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1260254", Offset = "0x1260254", VA = "0x1260254")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x12603C0", Offset = "0x12603C0", VA = "0x12603C0")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1260798", Offset = "0x1260798", VA = "0x1260798")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x12608B8", Offset = "0x12608B8", VA = "0x12608B8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x126090C", Offset = "0x126090C", VA = "0x126090C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1260A08", Offset = "0x1260A08", VA = "0x1260A08")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1260E7C", Offset = "0x1260E7C", VA = "0x1260E7C")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1261560", Offset = "0x1261560", VA = "0x1261560")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1261784", Offset = "0x1261784", VA = "0x1261784")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1261A54", Offset = "0x1261A54", VA = "0x1261A54")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1261B88", Offset = "0x1261B88", VA = "0x1261B88")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x12D08B8", Offset = "0x12D08B8", VA = "0x12D08B8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x12D09C8", Offset = "0x12D09C8", VA = "0x12D09C8")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x12D0A60", Offset = "0x12D0A60", VA = "0x12D0A60")]
		public void Update()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x12D0C50", Offset = "0x12D0C50", VA = "0x12D0C50")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x12D0CF8", Offset = "0x12D0CF8", VA = "0x12D0CF8")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x12D0DA4", Offset = "0x12D0DA4", VA = "0x12D0DA4")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000098")]
		public class InteractionEvent
		{
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x12D2368", Offset = "0x12D2368", VA = "0x12D2368")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x12D2600", Offset = "0x12D2600", VA = "0x12D2600")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class Message
		{
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000522")]
			private const string empty = "";

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x12D2508", Offset = "0x12D2508", VA = "0x12D2508")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x12D2608", Offset = "0x12D2608", VA = "0x12D2608")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000529")]
			private const string empty = "";

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x12D242C", Offset = "0x12D242C", VA = "0x12D242C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x12D2610", Offset = "0x12D2610", VA = "0x12D2610")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x12D26C0", Offset = "0x12D26C0", VA = "0x12D26C0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x12D2798", Offset = "0x12D2798", VA = "0x12D2798")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009B")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x200009C")]
			public enum Type
			{
				[Token(Token = "0x400052D")]
				PositionWeight,
				[Token(Token = "0x400052E")]
				RotationWeight,
				[Token(Token = "0x400052F")]
				PositionOffsetX,
				[Token(Token = "0x4000530")]
				PositionOffsetY,
				[Token(Token = "0x4000531")]
				PositionOffsetZ,
				[Token(Token = "0x4000532")]
				Pull,
				[Token(Token = "0x4000533")]
				Reach,
				[Token(Token = "0x4000534")]
				RotateBoneWeight,
				[Token(Token = "0x4000535")]
				Push,
				[Token(Token = "0x4000536")]
				PushParent,
				[Token(Token = "0x4000537")]
				PoserWeight,
				[Token(Token = "0x4000538")]
				BendGoalWeight
			}

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x12D1AA0", Offset = "0x12D1AA0", VA = "0x12D1AA0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x12D27AC", Offset = "0x12D27AC", VA = "0x12D27AC")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200009D")]
		public class Multiplier
		{
			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x600055D")]
			[Address(RVA = "0x12D2074", Offset = "0x12D2074", VA = "0x12D2074")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600055E")]
			[Address(RVA = "0x12D27B4", Offset = "0x12D27B4", VA = "0x12D27B4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700009A")]
		public float length
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x12D0FD8", Offset = "0x12D0FD8", VA = "0x12D0FD8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x12D0FE0", Offset = "0x12D0FE0", VA = "0x12D0FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x12D0FE8", Offset = "0x12D0FE8", VA = "0x12D0FE8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x12D0FF0", Offset = "0x12D0FF0", VA = "0x12D0FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x12D1228", Offset = "0x12D1228", VA = "0x12D1228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x12D11A8", Offset = "0x12D11A8", VA = "0x12D11A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x12D0DB8", Offset = "0x12D0DB8", VA = "0x12D0DB8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x12D0DFC", Offset = "0x12D0DFC", VA = "0x12D0DFC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x12D0E40", Offset = "0x12D0E40", VA = "0x12D0E40")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x12D0E84", Offset = "0x12D0E84", VA = "0x12D0E84")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x12D0EC8", Offset = "0x12D0EC8", VA = "0x12D0EC8")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x12D0F0C", Offset = "0x12D0F0C", VA = "0x12D0F0C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x12D0F50", Offset = "0x12D0F50", VA = "0x12D0F50")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x12D0F94", Offset = "0x12D0F94", VA = "0x12D0F94")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x12D0FF8", Offset = "0x12D0FF8", VA = "0x12D0FF8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x12D12A8", Offset = "0x12D12A8", VA = "0x12D12A8")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x12D13F8", Offset = "0x12D13F8", VA = "0x12D13F8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x12D148C", Offset = "0x12D148C", VA = "0x12D148C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x12D1494", Offset = "0x12D1494", VA = "0x12D1494")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x12D162C", Offset = "0x12D162C", VA = "0x12D162C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x12D1634", Offset = "0x12D1634", VA = "0x12D1634")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x12D20A4", Offset = "0x12D20A4", VA = "0x12D20A4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x12D22B0", Offset = "0x12D22B0", VA = "0x12D22B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x12D1ABC", Offset = "0x12D1ABC", VA = "0x12D1ABC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x12D15C8", Offset = "0x12D15C8", VA = "0x12D15C8")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x12D2018", Offset = "0x12D2018", VA = "0x12D2018")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x12D22B4", Offset = "0x12D22B4", VA = "0x12D22B4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x12D2310", Offset = "0x12D2310", VA = "0x12D2310")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200009F")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000A0")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		public Collider characterCollider;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("Reference to the FBBIK component.")]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTime;

		[Token(Token = "0x1700009E")]
		public bool inInteraction
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x12D29E4", Offset = "0x12D29E4", VA = "0x12D29E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009F")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x12D4548", Offset = "0x12D4548", VA = "0x12D4548")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x12D4550", Offset = "0x12D4550", VA = "0x12D4550")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x12D4558", Offset = "0x12D4558", VA = "0x12D4558")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x12D4560", Offset = "0x12D4560", VA = "0x12D4560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool initiated
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x12D4568", Offset = "0x12D4568", VA = "0x12D4568")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x12D4570", Offset = "0x12D4570", VA = "0x12D4570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x12D27C4", Offset = "0x12D27C4", VA = "0x12D27C4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x12D2808", Offset = "0x12D2808", VA = "0x12D2808")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x12D284C", Offset = "0x12D284C", VA = "0x12D284C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x12D2890", Offset = "0x12D2890", VA = "0x12D2890")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x12D28D4", Offset = "0x12D28D4", VA = "0x12D28D4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x12D2918", Offset = "0x12D2918", VA = "0x12D2918")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x12D295C", Offset = "0x12D295C", VA = "0x12D295C")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x12D29A0", Offset = "0x12D29A0", VA = "0x12D29A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x12D2B60", Offset = "0x12D2B60", VA = "0x12D2B60")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x12D2C1C", Offset = "0x12D2C1C", VA = "0x12D2C1C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x12D2CD8", Offset = "0x12D2CD8", VA = "0x12D2CD8")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x12D2D74", Offset = "0x12D2D74", VA = "0x12D2D74")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x12D2E5C", Offset = "0x12D2E5C", VA = "0x12D2E5C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x12D2F58", Offset = "0x12D2F58", VA = "0x12D2F58")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x12D3064", Offset = "0x12D3064", VA = "0x12D3064")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x12D30EC", Offset = "0x12D30EC", VA = "0x12D30EC")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x12D3174", Offset = "0x12D3174", VA = "0x12D3174")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x12D31FC", Offset = "0x12D31FC", VA = "0x12D31FC")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x12D3268", Offset = "0x12D3268", VA = "0x12D3268")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x12D32D4", Offset = "0x12D32D4", VA = "0x12D32D4")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x12D3334", Offset = "0x12D3334", VA = "0x12D3334")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x12D33B4", Offset = "0x12D33B4", VA = "0x12D33B4")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x12D343C", Offset = "0x12D343C", VA = "0x12D343C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x12D34F4", Offset = "0x12D34F4", VA = "0x12D34F4")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x12D3784", Offset = "0x12D3784", VA = "0x12D3784")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x12D3940", Offset = "0x12D3940", VA = "0x12D3940")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x12D3BA8", Offset = "0x12D3BA8", VA = "0x12D3BA8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x12D3E34", Offset = "0x12D3E34", VA = "0x12D3E34")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x12D3E6C", Offset = "0x12D3E6C", VA = "0x12D3E6C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x12D3ECC", Offset = "0x12D3ECC", VA = "0x12D3ECC")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x12D3FD4", Offset = "0x12D3FD4", VA = "0x12D3FD4")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x12D41B4", Offset = "0x12D41B4", VA = "0x12D41B4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x12D4428", Offset = "0x12D4428", VA = "0x12D4428")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x12D3C90", Offset = "0x12D3C90", VA = "0x12D3C90")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x12D457C", Offset = "0x12D457C", VA = "0x12D457C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x12D4DCC", Offset = "0x12D4DCC", VA = "0x12D4DCC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x12D4DEC", Offset = "0x12D4DEC", VA = "0x12D4DEC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x12D4E08", Offset = "0x12D4E08", VA = "0x12D4E08")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x12D4E24", Offset = "0x12D4E24", VA = "0x12D4E24")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x12D4E78", Offset = "0x12D4E78", VA = "0x12D4E78")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x12D4FE4", Offset = "0x12D4FE4", VA = "0x12D4FE4")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x12D50E0", Offset = "0x12D50E0", VA = "0x12D50E0")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x12D543C", Offset = "0x12D543C", VA = "0x12D543C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x12D5520", Offset = "0x12D5520", VA = "0x12D5520")]
		public void Update()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x12D57E0", Offset = "0x12D57E0", VA = "0x12D57E0")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x12D4B84", Offset = "0x12D4B84", VA = "0x12D4B84")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x12D5910", Offset = "0x12D5910", VA = "0x12D5910")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x12D592C", Offset = "0x12D592C", VA = "0x12D592C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x12D5A70", Offset = "0x12D5A70", VA = "0x12D5A70")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x12D5AF8", Offset = "0x12D5AF8", VA = "0x12D5AF8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x12D5BBC", Offset = "0x12D5BBC", VA = "0x12D5BBC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x12D5BD4", Offset = "0x12D5BD4", VA = "0x12D5BD4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x12D2A80", Offset = "0x12D2A80", VA = "0x12D2A80")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x12D3670", Offset = "0x12D3670", VA = "0x12D3670")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x12D5FBC", Offset = "0x12D5FBC", VA = "0x12D5FBC")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public enum RotationMode
		{
			[Token(Token = "0x4000562")]
			TwoDOF,
			[Token(Token = "0x4000563")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Multiplier
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x12D6F10", Offset = "0x12D6F10", VA = "0x12D6F10")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x12D65B0", Offset = "0x12D65B0", VA = "0x12D65B0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x12D65F4", Offset = "0x12D65F4", VA = "0x12D65F4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x12D6638", Offset = "0x12D6638", VA = "0x12D6638")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x12D667C", Offset = "0x12D667C", VA = "0x12D667C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x12D66C0", Offset = "0x12D66C0", VA = "0x12D66C0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x12D6704", Offset = "0x12D6704", VA = "0x12D6704")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x12D6748", Offset = "0x12D6748", VA = "0x12D6748")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x12D678C", Offset = "0x12D678C", VA = "0x12D678C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x12D1A3C", Offset = "0x12D1A3C", VA = "0x12D1A3C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x12D67D0", Offset = "0x12D67D0", VA = "0x12D67D0")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x12D685C", Offset = "0x12D685C", VA = "0x12D685C")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x12D6E9C", Offset = "0x12D6E9C", VA = "0x12D6E9C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A5")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around its Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x170000A2")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x12D7174", Offset = "0x12D7174", VA = "0x12D7174")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A3")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x12D7180", Offset = "0x12D7180", VA = "0x12D7180")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x12D7240", Offset = "0x12D7240", VA = "0x12D7240")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x12D79A4", Offset = "0x12D79A4", VA = "0x12D79A4")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A6")]
		public class CameraPosition
		{
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x12D79B8", Offset = "0x12D79B8", VA = "0x12D79B8")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x12D7B30", Offset = "0x12D7B30", VA = "0x12D7B30")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x12D7E38", Offset = "0x12D7E38", VA = "0x12D7E38")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A7")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000A8")]
			public class Interaction
			{
				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x12D7EBC", Offset = "0x12D7EBC", VA = "0x12D7EBC")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x12D706C", Offset = "0x12D706C", VA = "0x12D706C")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x12D7EAC", Offset = "0x12D7EAC", VA = "0x12D7EAC")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x12D6F18", Offset = "0x12D6F18", VA = "0x12D6F18")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x12D6F5C", Offset = "0x12D6F5C", VA = "0x12D6F5C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x12D6FA0", Offset = "0x12D6FA0", VA = "0x12D6FA0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x12D6FE4", Offset = "0x12D6FE4", VA = "0x12D6FE4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x12D7028", Offset = "0x12D7028", VA = "0x12D7028")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x12D5288", Offset = "0x12D5288", VA = "0x12D5288")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x12D711C", Offset = "0x12D711C", VA = "0x12D711C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Map
		{
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x12D81B0", Offset = "0x12D81B0", VA = "0x12D81B0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x12D84EC", Offset = "0x12D84EC", VA = "0x12D84EC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x12D84AC", Offset = "0x12D84AC", VA = "0x12D84AC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x12D8330", Offset = "0x12D8330", VA = "0x12D8330")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x12D7EC4", Offset = "0x12D7EC4", VA = "0x12D7EC4", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x12D823C", Offset = "0x12D823C", VA = "0x12D823C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x12D8240", Offset = "0x12D8240", VA = "0x12D8240", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x12D8450", Offset = "0x12D8450", VA = "0x12D8450", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x12D81E0", Offset = "0x12D81E0", VA = "0x12D81E0")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x12D811C", Offset = "0x12D811C", VA = "0x12D811C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x12D8530", Offset = "0x12D8530", VA = "0x12D8530")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x12D8550", Offset = "0x12D8550", VA = "0x12D8550", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x12D860C", Offset = "0x12D860C", VA = "0x12D860C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x12D87B0", Offset = "0x12D87B0", VA = "0x12D87B0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x12D8898", Offset = "0x12D8898", VA = "0x12D8898", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x12D8660", Offset = "0x12D8660", VA = "0x12D8660")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x12D8BC8", Offset = "0x12D8BC8", VA = "0x12D8BC8")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60005D4")]
		public abstract void AutoMapping();

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x12D8BD8", Offset = "0x12D8BD8", VA = "0x12D8BD8")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60005D6")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60005D7")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60005D8")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x12D8BE4", Offset = "0x12D8BE4", VA = "0x12D8BE4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x12D8C28", Offset = "0x12D8C28", VA = "0x12D8C28", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x12D8C54", Offset = "0x12D8C54", VA = "0x12D8C54", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x12D8540", Offset = "0x12D8540", VA = "0x12D8540")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		public class Rigidbone
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x12D9214", Offset = "0x12D9214", VA = "0x12D9214")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x12D9D5C", Offset = "0x12D9D5C", VA = "0x12D9D5C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x12D9B1C", Offset = "0x12D9B1C", VA = "0x12D9B1C")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000AF")]
		public class Child
		{
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x12D9368", Offset = "0x12D9368", VA = "0x12D9368")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x12D9E74", Offset = "0x12D9E74", VA = "0x12D9E74")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x12D9E30", Offset = "0x12D9E30", VA = "0x12D9E30")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0x12DA378", Offset = "0x12DA378", VA = "0x12DA378", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x12DA3C0", Offset = "0x12DA3C0", VA = "0x12DA3C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x12D93C4", Offset = "0x12D93C4", VA = "0x12D93C4")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x12DA194", Offset = "0x12DA194", VA = "0x12DA194", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x12DA198", Offset = "0x12DA198", VA = "0x12DA198", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x12DA380", Offset = "0x12DA380", VA = "0x12DA380", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x170000A4")]
		private bool isRagdoll
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x12D8C98", Offset = "0x12D8C98", VA = "0x12D8C98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		private bool ikUsed
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x12D9750", Offset = "0x12D9750", VA = "0x12D9750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x12D8C6C", Offset = "0x12D8C6C", VA = "0x12D8C6C")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x12D8CFC", Offset = "0x12D8CFC", VA = "0x12D8CFC")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x12D8E08", Offset = "0x12D8E08", VA = "0x12D8E08")]
		public void Start()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x12D8DA0", Offset = "0x12D8DA0", VA = "0x12D8DA0")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x12D93EC", Offset = "0x12D93EC", VA = "0x12D93EC")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x12D9614", Offset = "0x12D9614", VA = "0x12D9614")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x12D96B4", Offset = "0x12D96B4", VA = "0x12D96B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x12D98A4", Offset = "0x12D98A4", VA = "0x12D98A4")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x12D9724", Offset = "0x12D9724", VA = "0x12D9724")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x12D9870", Offset = "0x12D9870", VA = "0x12D9870")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x12D9924", Offset = "0x12D9924", VA = "0x12D9924")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x12D98C8", Offset = "0x12D98C8", VA = "0x12D98C8")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x12D8D44", Offset = "0x12D8D44", VA = "0x12D8D44")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x12D9648", Offset = "0x12D9648", VA = "0x12D9648")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x12D9F84", Offset = "0x12D9F84", VA = "0x12D9F84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x12DA09C", Offset = "0x12DA09C", VA = "0x12DA09C")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A8")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x12DA82C", Offset = "0x12DA82C", VA = "0x12DA82C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A9")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x12DA838", Offset = "0x12DA838", VA = "0x12DA838")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000AA")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x12DA868", Offset = "0x12DA868", VA = "0x12DA868")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x12DA870", Offset = "0x12DA870", VA = "0x12DA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x12DA3C8", Offset = "0x12DA3C8", VA = "0x12DA3C8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x12DA404", Offset = "0x12DA404", VA = "0x12DA404")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x12DA41C", Offset = "0x12DA41C", VA = "0x12DA41C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x12DA79C", Offset = "0x12DA79C", VA = "0x12DA79C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x12DA800", Offset = "0x12DA800", VA = "0x12DA800")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000604")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x12DA6A0", Offset = "0x12DA6A0", VA = "0x12DA6A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x12DA87C", Offset = "0x12DA87C", VA = "0x12DA87C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x12DA880", Offset = "0x12DA880", VA = "0x12DA880")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x12DA8A8", Offset = "0x12DA8A8", VA = "0x12DA8A8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x12DA97C", Offset = "0x12DA97C", VA = "0x12DA97C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x12DABD4", Offset = "0x12DABD4", VA = "0x12DABD4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x12DAD28", Offset = "0x12DAD28", VA = "0x12DAD28")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x12DAD88", Offset = "0x12DAD88", VA = "0x12DAD88")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x12DADCC", Offset = "0x12DADCC", VA = "0x12DADCC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x12DAE10", Offset = "0x12DAE10", VA = "0x12DAE10")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x12DAE54", Offset = "0x12DAE54", VA = "0x12DAE54")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x12DAE98", Offset = "0x12DAE98", VA = "0x12DAE98", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x12DAED0", Offset = "0x12DAED0", VA = "0x12DAED0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x12DB1F4", Offset = "0x12DB1F4", VA = "0x12DB1F4")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x12DB204", Offset = "0x12DB204", VA = "0x12DB204")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x12DB248", Offset = "0x12DB248", VA = "0x12DB248")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x12DB28C", Offset = "0x12DB28C", VA = "0x12DB28C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x12DB2D0", Offset = "0x12DB2D0", VA = "0x12DB2D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x12DB314", Offset = "0x12DB314", VA = "0x12DB314", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x12DB318", Offset = "0x12DB318", VA = "0x12DB318")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x12DB538", Offset = "0x12DB538", VA = "0x12DB538")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public class ReachCone
		{
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000AB")]
			public Vector3 o
			{
				[Token(Token = "0x600062A")]
				[Address(RVA = "0x12DD280", Offset = "0x12DD280", VA = "0x12DD280")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AC")]
			public Vector3 a
			{
				[Token(Token = "0x600062B")]
				[Address(RVA = "0x12DD2AC", Offset = "0x12DD2AC", VA = "0x12DD2AC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AD")]
			public Vector3 b
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x12DD2DC", Offset = "0x12DD2DC", VA = "0x12DD2DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AE")]
			public Vector3 c
			{
				[Token(Token = "0x600062D")]
				[Address(RVA = "0x12DD30C", Offset = "0x12DD30C", VA = "0x12DD30C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AF")]
			public bool isValid
			{
				[Token(Token = "0x600062F")]
				[Address(RVA = "0x12DC7C8", Offset = "0x12DC7C8", VA = "0x12DC7C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x12DCC6C", Offset = "0x12DCC6C", VA = "0x12DCC6C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x12DCDD0", Offset = "0x12DCDD0", VA = "0x12DCDD0")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class LimitPoint
		{
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x12DC7D8", Offset = "0x12DC7D8", VA = "0x12DC7D8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x12DB550", Offset = "0x12DB550", VA = "0x12DB550")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x12DB594", Offset = "0x12DB594", VA = "0x12DB594")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x12DB5D8", Offset = "0x12DB5D8", VA = "0x12DB5D8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x12DB61C", Offset = "0x12DB61C", VA = "0x12DB61C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x12DB660", Offset = "0x12DB660", VA = "0x12DB660")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x12DBC98", Offset = "0x12DBC98", VA = "0x12DBC98", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x12DBD20", Offset = "0x12DBD20", VA = "0x12DBD20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x12DC300", Offset = "0x12DC300", VA = "0x12DC300")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x12DB6EC", Offset = "0x12DB6EC", VA = "0x12DB6EC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x12DC83C", Offset = "0x12DC83C", VA = "0x12DC83C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x12DD044", Offset = "0x12DD044", VA = "0x12DD044")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x12DD08C", Offset = "0x12DD08C", VA = "0x12DD08C")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x12DD0EC", Offset = "0x12DD0EC", VA = "0x12DD0EC")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x12DC05C", Offset = "0x12DC05C", VA = "0x12DC05C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x12DD158", Offset = "0x12DD158", VA = "0x12DD158")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x12DD224", Offset = "0x12DD224", VA = "0x12DD224")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x12DD33C", Offset = "0x12DD33C", VA = "0x12DD33C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x12DD380", Offset = "0x12DD380", VA = "0x12DD380")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x12DD3C4", Offset = "0x12DD3C4", VA = "0x12DD3C4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x12DD408", Offset = "0x12DD408", VA = "0x12DD408")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x12DD44C", Offset = "0x12DD44C", VA = "0x12DD44C")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x12DD468", Offset = "0x12DD468", VA = "0x12DD468", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x12DD4A0", Offset = "0x12DD4A0", VA = "0x12DD4A0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x12DD84C", Offset = "0x12DD84C", VA = "0x12DD84C")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000B9")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000644")]
				[Address(RVA = "0x12DE82C", Offset = "0x12DE82C", VA = "0x12DE82C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000646")]
				[Address(RVA = "0x12DE874", Offset = "0x12DE874", VA = "0x12DE874", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x12DE638", Offset = "0x12DE638", VA = "0x12DE638")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x12DE744", Offset = "0x12DE744", VA = "0x12DE744", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000643")]
			[Address(RVA = "0x12DE748", Offset = "0x12DE748", VA = "0x12DE748", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x12DE834", Offset = "0x12DE834", VA = "0x12DE834", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000B0")]
		private Vector3 pivot
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x12DD8D4", Offset = "0x12DD8D4", VA = "0x12DD8D4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x12DD858", Offset = "0x12DD858", VA = "0x12DD858")]
		private void Start()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x12DD958", Offset = "0x12DD958", VA = "0x12DD958")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x12DE1A8", Offset = "0x12DE1A8", VA = "0x12DE1A8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x12DE32C", Offset = "0x12DE32C", VA = "0x12DE32C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x12DE5D0", Offset = "0x12DE5D0", VA = "0x12DE5D0")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x12DE660", Offset = "0x12DE660", VA = "0x12DE660")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class Pose
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x12DE94C", Offset = "0x12DE94C", VA = "0x12DE94C")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x12DEEBC", Offset = "0x12DEEBC", VA = "0x12DEEBC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x12DEEC4", Offset = "0x12DEEC4", VA = "0x12DEEC4")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x12DE87C", Offset = "0x12DE87C", VA = "0x12DE87C")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x12DEDFC", Offset = "0x12DEDFC", VA = "0x12DEDFC")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x12DEE5C", Offset = "0x12DEE5C", VA = "0x12DEE5C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public class EffectorLink
			{
				[Token(Token = "0x40005F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000652")]
				[Address(RVA = "0x12DF350", Offset = "0x12DF350", VA = "0x12DF350")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x12DF010", Offset = "0x12DF010", VA = "0x12DF010")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x12DF328", Offset = "0x12DF328", VA = "0x12DF328")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x12DF338", Offset = "0x12DF338", VA = "0x12DF338")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x12DEEE0", Offset = "0x12DEEE0", VA = "0x12DEEE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x12DF320", Offset = "0x12DF320", VA = "0x12DF320")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x12DF358", Offset = "0x12DF358", VA = "0x12DF358", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x12DF394", Offset = "0x12DF394", VA = "0x12DF394", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x12DF580", Offset = "0x12DF580", VA = "0x12DF580")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x12DF594", Offset = "0x12DF594", VA = "0x12DF594")]
		private void Start()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x12DF664", Offset = "0x12DF664", VA = "0x12DF664")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x12DF8F8", Offset = "0x12DF8F8", VA = "0x12DF8F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x12DFA04", Offset = "0x12DFA04", VA = "0x12DFA04")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x170000B3")]
		public IK ik
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x12DFA14", Offset = "0x12DFA14", VA = "0x12DFA14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x12DFA1C", Offset = "0x12DFA1C", VA = "0x12DFA1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x12DFA24", Offset = "0x12DFA24", VA = "0x12DFA24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x12DFB98", Offset = "0x12DFB98", VA = "0x12DFB98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x12DFDF4", Offset = "0x12DFDF4", VA = "0x12DFDF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x12DFF20", Offset = "0x12DFF20", VA = "0x12DFF20")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x12E00D4", Offset = "0x12E00D4", VA = "0x12E00D4")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x12E02D8", Offset = "0x12E02D8", VA = "0x12E02D8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x12E054C", Offset = "0x12E054C", VA = "0x12E054C")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000B4")]
		public bool poseStored
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x12DFC74", Offset = "0x12DFC74", VA = "0x12DFC74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x12DFF94", Offset = "0x12DFF94", VA = "0x12DFF94")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x12DFC98", Offset = "0x12DFC98", VA = "0x12DFC98")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x12E05A4", Offset = "0x12E05A4", VA = "0x12E05A4")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000B6")]
			public bool inProgress
			{
				[Token(Token = "0x600066B")]
				[Address(RVA = "0x12E06C4", Offset = "0x12E06C4", VA = "0x12E06C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B7")]
			protected float crossFader
			{
				[Token(Token = "0x600066C")]
				[Address(RVA = "0x12E0AA4", Offset = "0x12E0AA4", VA = "0x12E0AA4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600066D")]
				[Address(RVA = "0x12E0AAC", Offset = "0x12E0AAC", VA = "0x12E0AAC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			protected float timer
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0x12E0AB4", Offset = "0x12E0AB4", VA = "0x12E0AB4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600066F")]
				[Address(RVA = "0x12E0ABC", Offset = "0x12E0ABC", VA = "0x12E0ABC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B9")]
			protected Vector3 force
			{
				[Token(Token = "0x6000670")]
				[Address(RVA = "0x12E0AC4", Offset = "0x12E0AC4", VA = "0x12E0AC4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000671")]
				[Address(RVA = "0x12E0AD0", Offset = "0x12E0AD0", VA = "0x12E0AD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x12E0ADC", Offset = "0x12E0ADC", VA = "0x12E0ADC", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x12E0798", Offset = "0x12E0798", VA = "0x12E0798")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000674")]
			protected abstract float GetLength();

			[Token(Token = "0x6000675")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000676")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x12E0BE8", Offset = "0x12E0BE8", VA = "0x12E0BE8")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C6")]
			public class EffectorLink
			{
				[Token(Token = "0x4000616")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000617")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000618")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000619")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600067C")]
				[Address(RVA = "0x12E0F1C", Offset = "0x12E0F1C", VA = "0x12E0F1C")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600067D")]
				[Address(RVA = "0x12E0D78", Offset = "0x12E0D78", VA = "0x12E0D78")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600067E")]
				[Address(RVA = "0x12E0FCC", Offset = "0x12E0FCC", VA = "0x12E0FCC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x12E0BFC", Offset = "0x12E0BFC", VA = "0x12E0BFC", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x12E0D18", Offset = "0x12E0D18", VA = "0x12E0D18", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x12E0D8C", Offset = "0x12E0D8C", VA = "0x12E0D8C", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x12E0FB8", Offset = "0x12E0FB8", VA = "0x12E0FB8")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C8")]
			public class BoneLink
			{
				[Token(Token = "0x400061E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x400061F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x4000620")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000621")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000684")]
				[Address(RVA = "0x12E12F4", Offset = "0x12E12F4", VA = "0x12E12F4")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000685")]
				[Address(RVA = "0x12E1228", Offset = "0x12E1228", VA = "0x12E1228")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000686")]
				[Address(RVA = "0x12E1494", Offset = "0x12E1494", VA = "0x12E1494")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x12E0FD4", Offset = "0x12E0FD4", VA = "0x12E0FD4", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x12E1144", Offset = "0x12E1144", VA = "0x12E1144", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x12E11D0", Offset = "0x12E11D0", VA = "0x12E11D0", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x12E1234", Offset = "0x12E1234", VA = "0x12E1234", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x12E1480", Offset = "0x12E1480", VA = "0x12E1480")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000B5")]
		public bool inProgress
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x12E0628", Offset = "0x12E0628", VA = "0x12E0628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x12E06D8", Offset = "0x12E06D8", VA = "0x12E06D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x12E0870", Offset = "0x12E0870", VA = "0x12E0870")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x12E0A9C", Offset = "0x12E0A9C", VA = "0x12E0A9C")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public abstract class Offset
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000BA")]
			protected float crossFader
			{
				[Token(Token = "0x600068A")]
				[Address(RVA = "0x12E18CC", Offset = "0x12E18CC", VA = "0x12E18CC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600068B")]
				[Address(RVA = "0x12E18D4", Offset = "0x12E18D4", VA = "0x12E18D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			protected float timer
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x12E18DC", Offset = "0x12E18DC", VA = "0x12E18DC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600068D")]
				[Address(RVA = "0x12E18E4", Offset = "0x12E18E4", VA = "0x12E18E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			protected Vector3 force
			{
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x12E18EC", Offset = "0x12E18EC", VA = "0x12E18EC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600068F")]
				[Address(RVA = "0x12E18F8", Offset = "0x12E18F8", VA = "0x12E18F8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x12E1904", Offset = "0x12E1904", VA = "0x12E1904", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x12E15B0", Offset = "0x12E15B0", VA = "0x12E15B0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000692")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000693")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000694")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x12E1A18", Offset = "0x12E1A18", VA = "0x12E1A18")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000CC")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000631")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000632")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000633")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000634")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600069A")]
				[Address(RVA = "0x12E1DFC", Offset = "0x12E1DFC", VA = "0x12E1DFC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600069B")]
				[Address(RVA = "0x12E1C20", Offset = "0x12E1C20", VA = "0x12E1C20")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600069C")]
				[Address(RVA = "0x12E1E90", Offset = "0x12E1E90", VA = "0x12E1E90")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x12E1A2C", Offset = "0x12E1A2C", VA = "0x12E1A2C", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x12E1BC0", Offset = "0x12E1BC0", VA = "0x12E1BC0", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x12E1C34", Offset = "0x12E1C34", VA = "0x12E1C34", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x12E1E74", Offset = "0x12E1E74", VA = "0x12E1E74")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000CE")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000639")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400063A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x400063B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x400063C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60006A2")]
				[Address(RVA = "0x12E2368", Offset = "0x12E2368", VA = "0x12E2368")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60006A3")]
				[Address(RVA = "0x12E2148", Offset = "0x12E2148", VA = "0x12E2148")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60006A4")]
				[Address(RVA = "0x12E2484", Offset = "0x12E2484", VA = "0x12E2484")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x12E1E98", Offset = "0x12E1E98", VA = "0x12E1E98", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x12E2018", Offset = "0x12E2018", VA = "0x12E2018", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x12E20F0", Offset = "0x12E20F0", VA = "0x12E20F0", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x12E2154", Offset = "0x12E2154", VA = "0x12E2154", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x12E2470", Offset = "0x12E2470", VA = "0x12E2470")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x12E14F8", Offset = "0x12E14F8", VA = "0x12E14F8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x12E1690", Offset = "0x12E1690", VA = "0x12E1690")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x12E18C4", Offset = "0x12E18C4", VA = "0x12E18C4")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000D1")]
			public class EffectorLink
			{
				[Token(Token = "0x400064A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400064B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006AB")]
				[Address(RVA = "0x12E29A0", Offset = "0x12E29A0", VA = "0x12E29A0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x12E2554", Offset = "0x12E2554", VA = "0x12E2554")]
			public void Reset()
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x12E26D8", Offset = "0x12E26D8", VA = "0x12E26D8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x12E2984", Offset = "0x12E2984", VA = "0x12E2984")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x12E24E8", Offset = "0x12E24E8", VA = "0x12E24E8")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x12E2630", Offset = "0x12E2630", VA = "0x12E2630", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x12E297C", Offset = "0x12E297C", VA = "0x12E297C")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		public float maxRootAngle;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000BD")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x12E2A10", Offset = "0x12E2A10", VA = "0x12E2A10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x12E29A8", Offset = "0x12E29A8", VA = "0x12E29A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x12E2A94", Offset = "0x12E2A94", VA = "0x12E2A94")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x12E2F94", Offset = "0x12E2F94", VA = "0x12E2F94")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x12E3118", Offset = "0x12E3118", VA = "0x12E3118")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x12E3364", Offset = "0x12E3364", VA = "0x12E3364")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x119E658", Offset = "0x119E658", VA = "0x119E658")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x119E8D8", Offset = "0x119E8D8", VA = "0x119E8D8")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x119E948", Offset = "0x119E948", VA = "0x119E948")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x119E990", Offset = "0x119E990", VA = "0x119E990")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C1")]
				[Address(RVA = "0x119EAEC", Offset = "0x119EAEC", VA = "0x119EAEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x119EB34", Offset = "0x119EB34", VA = "0x119EB34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x119E4B4", Offset = "0x119E4B4", VA = "0x119E4B4")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x119E998", Offset = "0x119E998", VA = "0x119E998", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x119E99C", Offset = "0x119E99C", VA = "0x119E99C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x119EAF4", Offset = "0x119EAF4", VA = "0x119EAF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000BE")]
		protected float deltaTime
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x119E40C", Offset = "0x119E40C", VA = "0x119E40C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006B3")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x119E42C", Offset = "0x119E42C", VA = "0x119E42C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x119E44C", Offset = "0x119E44C", VA = "0x119E44C")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x119E4DC", Offset = "0x119E4DC", VA = "0x119E4DC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x119E5B0", Offset = "0x119E5B0", VA = "0x119E5B0")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x119E7BC", Offset = "0x119E7BC", VA = "0x119E7BC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x119E8C8", Offset = "0x119E8C8", VA = "0x119E8C8")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006CE")]
				[Address(RVA = "0x119EF50", Offset = "0x119EF50", VA = "0x119EF50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x119EF98", Offset = "0x119EF98", VA = "0x119EF98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x119EBE4", Offset = "0x119EBE4", VA = "0x119EBE4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x119EDFC", Offset = "0x119EDFC", VA = "0x119EDFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x119EE00", Offset = "0x119EE00", VA = "0x119EE00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x119EF58", Offset = "0x119EF58", VA = "0x119EF58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000C1")]
		protected float deltaTime
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x119EB3C", Offset = "0x119EB3C", VA = "0x119EB3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006C5")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x119EB5C", Offset = "0x119EB5C", VA = "0x119EB5C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x119EB7C", Offset = "0x119EB7C", VA = "0x119EB7C")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x119EC0C", Offset = "0x119EC0C", VA = "0x119EC0C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x119ECE0", Offset = "0x119ECE0", VA = "0x119ECE0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x119EDEC", Offset = "0x119EDEC", VA = "0x119EDEC")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class EffectorLink
		{
			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x119F054", Offset = "0x119F054", VA = "0x119F054")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x119F3A0", Offset = "0x119F3A0", VA = "0x119F3A0")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x119EFA0", Offset = "0x119EFA0", VA = "0x119EFA0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x119F2A4", Offset = "0x119F2A4", VA = "0x119F2A4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x119F348", Offset = "0x119F348", VA = "0x119F348")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000DC")]
			public class EffectorLink
			{
				[Token(Token = "0x4000687")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000688")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x119F9F4", Offset = "0x119F9F4", VA = "0x119F9F4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x119F418", Offset = "0x119F418", VA = "0x119F418")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x119F5B8", Offset = "0x119F5B8", VA = "0x119F5B8")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x119F6C0", Offset = "0x119F6C0", VA = "0x119F6C0")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x119F9E0", Offset = "0x119F9E0", VA = "0x119F9E0")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x119F3A8", Offset = "0x119F3A8", VA = "0x119F3A8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x119F5A8", Offset = "0x119F5A8", VA = "0x119F5A8")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000DF")]
			public class EffectorLink
			{
				[Token(Token = "0x40006A7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006EC")]
				[Address(RVA = "0x11A0E7C", Offset = "0x11A0E7C", VA = "0x11A0E7C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
			public float additivity;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x119FB98", Offset = "0x119FB98", VA = "0x119FB98")]
			public void Start()
			{
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x11A0730", Offset = "0x11A0730", VA = "0x11A0730")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x11A0E68", Offset = "0x11A0E68", VA = "0x11A0E68")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public enum Handedness
		{
			[Token(Token = "0x40006AA")]
			Right,
			[Token(Token = "0x40006AB")]
			Left
		}

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
		public AimIK headIK;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000C4")]
		public bool isFinished
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x119F9FC", Offset = "0x119F9FC", VA = "0x119F9FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x11A0934", Offset = "0x11A0934", VA = "0x11A0934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x11A0970", Offset = "0x11A0970", VA = "0x11A0970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x11A08FC", Offset = "0x11A08FC", VA = "0x11A08FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x11A0918", Offset = "0x11A0918", VA = "0x11A0918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x119FA20", Offset = "0x119FA20", VA = "0x119FA20")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x119FA4C", Offset = "0x119FA4C", VA = "0x119FA4C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x119FC6C", Offset = "0x119FC6C", VA = "0x119FC6C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x11A09AC", Offset = "0x11A09AC", VA = "0x11A09AC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x11A0B34", Offset = "0x11A0B34", VA = "0x11A0B34")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x11A0C0C", Offset = "0x11A0C0C", VA = "0x11A0C0C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x11A0DDC", Offset = "0x11A0DDC", VA = "0x11A0DDC")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x11A0E84", Offset = "0x11A0E84", VA = "0x11A0E84")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x11A0F74", Offset = "0x11A0F74", VA = "0x11A0F74")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x11A1050", Offset = "0x11A1050", VA = "0x11A1050")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x11A1454", Offset = "0x11A1454", VA = "0x11A1454")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x11A1488", Offset = "0x11A1488", VA = "0x11A1488")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x11A1594", Offset = "0x11A1594", VA = "0x11A1594")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Settings
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Space(10f)]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			public Vector3 headOffset;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x11A54E4", Offset = "0x11A54E4", VA = "0x11A54E4")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000E5")]
			public class Target
			{
				[Token(Token = "0x40006CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40006CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40006CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000704")]
				[Address(RVA = "0x11A31BC", Offset = "0x11A31BC", VA = "0x11A31BC")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000705")]
				[Address(RVA = "0x11A3B6C", Offset = "0x11A3B6C", VA = "0x11A3B6C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x11A293C", Offset = "0x11A293C", VA = "0x11A293C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x11A15A8", Offset = "0x11A15A8", VA = "0x11A15A8")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x11A15C0", Offset = "0x11A15C0", VA = "0x11A15C0")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x11A16E8", Offset = "0x11A16E8", VA = "0x11A16E8")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x11A1608", Offset = "0x11A1608", VA = "0x11A1608")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x11A1700", Offset = "0x11A1700", VA = "0x11A1700")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x11A2944", Offset = "0x11A2944", VA = "0x11A2944")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x11A3270", Offset = "0x11A3270", VA = "0x11A3270")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x11A3BC8", Offset = "0x11A3BC8", VA = "0x11A3BC8")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x11A3F88", Offset = "0x11A3F88", VA = "0x11A3F88")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x11A4198", Offset = "0x11A4198", VA = "0x11A4198")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x11A4920", Offset = "0x11A4920", VA = "0x11A4920")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x11A4720", Offset = "0x11A4720", VA = "0x11A4720")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x11A4BC8", Offset = "0x11A4BC8", VA = "0x11A4BC8")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x11A50B8", Offset = "0x11A50B8", VA = "0x11A50B8")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x11A519C", Offset = "0x11A519C", VA = "0x11A519C")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000E6")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x11A5678", Offset = "0x11A5678", VA = "0x11A5678")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x11A56C8", Offset = "0x11A56C8", VA = "0x11A56C8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x11A56F0", Offset = "0x11A56F0", VA = "0x11A56F0")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x11A5810", Offset = "0x11A5810", VA = "0x11A5810")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000C9")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x11A5828", Offset = "0x11A5828", VA = "0x11A5828")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x11A5834", Offset = "0x11A5834", VA = "0x11A5834")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x11A5840", Offset = "0x11A5840", VA = "0x11A5840")]
		private void Awake()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x11A2FFC", Offset = "0x11A2FFC", VA = "0x11A2FFC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x11A3E30", Offset = "0x11A3E30", VA = "0x11A3E30")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x11A5934", Offset = "0x11A5934", VA = "0x11A5934")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x11A5CFC", Offset = "0x11A5CFC", VA = "0x11A5CFC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x11A5E08", Offset = "0x11A5E08", VA = "0x11A5E08")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000E8")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E9")]
		public class Offset
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x11A5EC4", Offset = "0x11A5EC4", VA = "0x11A5EC4")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x11A612C", Offset = "0x11A612C", VA = "0x11A612C")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x11A5E10", Offset = "0x11A5E10", VA = "0x11A5E10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x11A5E60", Offset = "0x11A5E60", VA = "0x11A5E60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x11A606C", Offset = "0x11A606C", VA = "0x11A606C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x11A6124", Offset = "0x11A6124", VA = "0x11A6124")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x11A6134", Offset = "0x11A6134", VA = "0x11A6134")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x11A61B4", Offset = "0x11A61B4", VA = "0x11A61B4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction in which the weapon is aimed in animation (in character space). Tweak this value to adjust the aiming.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x11A61BC", Offset = "0x11A61BC", VA = "0x11A61BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x11A6228", Offset = "0x11A6228", VA = "0x11A6228")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x11A6288", Offset = "0x11A6288", VA = "0x11A6288")]
		private void Start()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x11A6340", Offset = "0x11A6340", VA = "0x11A6340")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x11A666C", Offset = "0x11A666C", VA = "0x11A666C")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x11A6674", Offset = "0x11A6674", VA = "0x11A6674")]
		private void Start()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x11A66AC", Offset = "0x11A66AC", VA = "0x11A66AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x11A6758", Offset = "0x11A6758", VA = "0x11A6758")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x11A68A4", Offset = "0x11A68A4", VA = "0x11A68A4")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x11A6A60", Offset = "0x11A6A60", VA = "0x11A6A60")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x11A6AF0", Offset = "0x11A6AF0", VA = "0x11A6AF0")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x11A6B04", Offset = "0x11A6B04", VA = "0x11A6B04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x11A6C70", Offset = "0x11A6C70", VA = "0x11A6C70")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x11A6E6C", Offset = "0x11A6E6C", VA = "0x11A6E6C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x11A6E9C", Offset = "0x11A6E9C", VA = "0x11A6E9C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x11A72C8", Offset = "0x11A72C8", VA = "0x11A72C8")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000CA")]
		public Vector3 velocity
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x11A72E8", Offset = "0x11A72E8", VA = "0x11A72E8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x11A72F4", Offset = "0x11A72F4", VA = "0x11A72F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x11A7300", Offset = "0x11A7300", VA = "0x11A7300")]
		private void Start()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x11A7330", Offset = "0x11A7330", VA = "0x11A7330")]
		private void Update()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x11A7CB4", Offset = "0x11A7CB4", VA = "0x11A7CB4")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x11A7A30", Offset = "0x11A7A30", VA = "0x11A7A30")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x11A7DC4", Offset = "0x11A7DC4", VA = "0x11A7DC4")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000CB")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x11A7DF0", Offset = "0x11A7DF0", VA = "0x11A7DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x11A7E70", Offset = "0x11A7E70", VA = "0x11A7E70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x11A81B4", Offset = "0x11A81B4", VA = "0x11A81B4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000742")]
				[Address(RVA = "0x11A91BC", Offset = "0x11A91BC", VA = "0x11A91BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000744")]
				[Address(RVA = "0x11A9204", Offset = "0x11A9204", VA = "0x11A9204", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073F")]
			[Address(RVA = "0x11A8E60", Offset = "0x11A8E60", VA = "0x11A8E60")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x11A8F18", Offset = "0x11A8F18", VA = "0x11A8F18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x11A8F1C", Offset = "0x11A8F1C", VA = "0x11A8F1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x11A91C4", Offset = "0x11A91C4", VA = "0x11A91C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000CC")]
		public bool isStepping
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x11A81C8", Offset = "0x11A81C8", VA = "0x11A81C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		public Vector3 position
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x11A7D94", Offset = "0x11A7D94", VA = "0x11A7D94")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x11A81DC", Offset = "0x11A81DC", VA = "0x11A81DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x11A8228", Offset = "0x11A8228", VA = "0x11A8228")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x11A8470", Offset = "0x11A8470", VA = "0x11A8470")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x11A8648", Offset = "0x11A8648", VA = "0x11A8648")]
		private void Start()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x11A8860", Offset = "0x11A8860", VA = "0x11A8860")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x11A8AC0", Offset = "0x11A8AC0", VA = "0x11A8AC0")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x11A8C28", Offset = "0x11A8C28", VA = "0x11A8C28")]
		private void Update()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x11A87BC", Offset = "0x11A87BC", VA = "0x11A87BC")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x11A8E88", Offset = "0x11A8E88", VA = "0x11A8E88")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x11A920C", Offset = "0x11A920C", VA = "0x11A920C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x11A92D8", Offset = "0x11A92D8", VA = "0x11A92D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x11A954C", Offset = "0x11A954C", VA = "0x11A954C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public struct Warp
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public enum EffectorMode
		{
			[Token(Token = "0x400074A")]
			PositionOffset,
			[Token(Token = "0x400074B")]
			Position
		}

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x11A9554", Offset = "0x11A9554", VA = "0x11A9554", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x11A9580", Offset = "0x11A9580", VA = "0x11A9580")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x11A9798", Offset = "0x11A9798", VA = "0x11A9798", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x11A9A50", Offset = "0x11A9A50", VA = "0x11A9A50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x11A9AE4", Offset = "0x11A9AE4", VA = "0x11A9AE4")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x11A9AF4", Offset = "0x11A9AF4", VA = "0x11A9AF4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x11A9B44", Offset = "0x11A9B44", VA = "0x11A9B44")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x11A9D4C", Offset = "0x11A9D4C", VA = "0x11A9D4C", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x11A9F74", Offset = "0x11A9F74", VA = "0x11A9F74")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x11A9F88", Offset = "0x11A9F88", VA = "0x11A9F88", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x11AA11C", Offset = "0x11AA11C", VA = "0x11AA11C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x11AA18C", Offset = "0x11AA18C", VA = "0x11AA18C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x11AA2C4", Offset = "0x11AA2C4", VA = "0x11AA2C4")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x11AA320", Offset = "0x11AA320", VA = "0x11AA320")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x11AA988", Offset = "0x11AA988", VA = "0x11AA988")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x11AA79C", Offset = "0x11AA79C", VA = "0x11AA79C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x11AAC2C", Offset = "0x11AAC2C", VA = "0x11AAC2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x11AAD38", Offset = "0x11AAD38", VA = "0x11AAD38")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x11AAD54", Offset = "0x11AAD54", VA = "0x11AAD54", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x11AADB0", Offset = "0x11AADB0", VA = "0x11AADB0", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x11AB0EC", Offset = "0x11AB0EC", VA = "0x11AB0EC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x11AB1DC", Offset = "0x11AB1DC", VA = "0x11AB1DC")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000D0")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x11AB43C", Offset = "0x11AB43C", VA = "0x11AB43C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000D1")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x11AB4BC", Offset = "0x11AB4BC", VA = "0x11AB4BC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x11AB1E4", Offset = "0x11AB1E4", VA = "0x11AB1E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x11AB24C", Offset = "0x11AB24C", VA = "0x11AB24C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x11AB53C", Offset = "0x11AB53C", VA = "0x11AB53C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x11AB544", Offset = "0x11AB544", VA = "0x11AB544", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x11AB9A0", Offset = "0x11AB9A0", VA = "0x11AB9A0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x11AB9B0", Offset = "0x11AB9B0", VA = "0x11AB9B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x11ABA54", Offset = "0x11ABA54", VA = "0x11ABA54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x11ABEB0", Offset = "0x11ABEB0", VA = "0x11ABEB0")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x11ABF50", Offset = "0x11ABF50", VA = "0x11ABF50")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public class Limb
		{
			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x11AC0E4", Offset = "0x11AC0E4", VA = "0x11AC0E4")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x11AC208", Offset = "0x11AC208", VA = "0x11AC208")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x11ABFC0", Offset = "0x11ABFC0", VA = "0x11ABFC0")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x11AC15C", Offset = "0x11AC15C", VA = "0x11AC15C")]
		private void Start()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x11AC1F4", Offset = "0x11AC1F4", VA = "0x11AC1F4")]
		private void Update()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x11AC1F8", Offset = "0x11AC1F8", VA = "0x11AC1F8")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x11AC218", Offset = "0x11AC218", VA = "0x11AC218")]
		private void Start()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x11AC280", Offset = "0x11AC280", VA = "0x11AC280")]
		private void Update()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x11AC348", Offset = "0x11AC348", VA = "0x11AC348")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x11AC350", Offset = "0x11AC350", VA = "0x11AC350")]
		private void Start()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x11AC3A0", Offset = "0x11AC3A0", VA = "0x11AC3A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x11AC538", Offset = "0x11AC538", VA = "0x11AC538")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x11AC540", Offset = "0x11AC540", VA = "0x11AC540")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x11AC610", Offset = "0x11AC610", VA = "0x11AC610")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x11AC69C", Offset = "0x11AC69C", VA = "0x11AC69C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x11ACB70", Offset = "0x11ACB70", VA = "0x11ACB70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x11ACC7C", Offset = "0x11ACC7C", VA = "0x11ACC7C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x11ACC84", Offset = "0x11ACC84", VA = "0x11ACC84")]
		private void Start()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x11ACE20", Offset = "0x11ACE20", VA = "0x11ACE20")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x11ACE2C", Offset = "0x11ACE2C", VA = "0x11ACE2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x11AD0EC", Offset = "0x11AD0EC", VA = "0x11AD0EC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x11AD388", Offset = "0x11AD388", VA = "0x11AD388")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x11ACEF0", Offset = "0x11ACEF0", VA = "0x11ACEF0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x11AE050", Offset = "0x11AE050", VA = "0x11AE050")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x11AE070", Offset = "0x11AE070", VA = "0x11AE070")]
		private void Start()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x11AE0EC", Offset = "0x11AE0EC", VA = "0x11AE0EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x11AE1E8", Offset = "0x11AE1E8", VA = "0x11AE1E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x11AE294", Offset = "0x11AE294", VA = "0x11AE294")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x11AE2A4", Offset = "0x11AE2A4", VA = "0x11AE2A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x11AE3E8", Offset = "0x11AE3E8", VA = "0x11AE3E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x11AE54C", Offset = "0x11AE54C", VA = "0x11AE54C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x11AE55C", Offset = "0x11AE55C", VA = "0x11AE55C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x11AE728", Offset = "0x11AE728", VA = "0x11AE728")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x11AEB38", Offset = "0x11AEB38", VA = "0x11AEB38")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x11AEB48", Offset = "0x11AEB48", VA = "0x11AEB48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x11AEC30", Offset = "0x11AEC30", VA = "0x11AEC30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x11AED1C", Offset = "0x11AED1C", VA = "0x11AED1C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x11AED24", Offset = "0x11AED24", VA = "0x11AED24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x11AF224", Offset = "0x11AF224", VA = "0x11AF224")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x11AF22C", Offset = "0x11AF22C", VA = "0x11AF22C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x11AF27C", Offset = "0x11AF27C", VA = "0x11AF27C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x11AF528", Offset = "0x11AF528", VA = "0x11AF528")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010B")]
		public class Partner
		{
			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000D2")]
			private Transform neck
			{
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x11002A0", Offset = "0x11002A0", VA = "0x11002A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x10FFB30", Offset = "0x10FFB30", VA = "0x10FFB30")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x10FFB50", Offset = "0x10FFB50", VA = "0x10FFB50")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1100138", Offset = "0x1100138", VA = "0x1100138")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x11002EC", Offset = "0x11002EC", VA = "0x11002EC")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x11AF530", Offset = "0x11AF530", VA = "0x11AF530")]
		private void Start()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x11AF560", Offset = "0x11AF560", VA = "0x11AF560")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x11AF5C4", Offset = "0x11AF5C4", VA = "0x11AF5C4")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010D")]
		public enum Mode
		{
			[Token(Token = "0x40007D7")]
			Position,
			[Token(Token = "0x40007D8")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200010E")]
		public class Absorber
		{
			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1100464", Offset = "0x1100464", VA = "0x1100464")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1100638", Offset = "0x1100638", VA = "0x1100638")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x110065C", Offset = "0x110065C", VA = "0x110065C")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x110076C", Offset = "0x110076C", VA = "0x110076C")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x1100904", Offset = "0x1100904", VA = "0x1100904")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1100300", Offset = "0x1100300", VA = "0x1100300", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x11003E4", Offset = "0x11003E4", VA = "0x11003E4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x110052C", Offset = "0x110052C", VA = "0x110052C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x11006F0", Offset = "0x11006F0", VA = "0x11006F0")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x11007DC", Offset = "0x11007DC", VA = "0x11007DC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x11008F4", Offset = "0x11008F4", VA = "0x11008F4")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1100964", Offset = "0x1100964", VA = "0x1100964")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x11009D4", Offset = "0x11009D4", VA = "0x11009D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1100AA4", Offset = "0x1100AA4", VA = "0x1100AA4")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1100BEC", Offset = "0x1100BEC", VA = "0x1100BEC")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public class EffectorLink
		{
			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x1101174", Offset = "0x1101174", VA = "0x1101174")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Optional. Assign the bone Transform that is closest to this OffsetEffector to be able to call OffsetEffector.Anchor() in LateUpdate to match its position and rotation to animation.")]
		public Transform anchor;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1100C00", Offset = "0x1100C00", VA = "0x1100C00", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1100E48", Offset = "0x1100E48", VA = "0x1100E48", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1100FC0", Offset = "0x1100FC0", VA = "0x1100FC0")]
		public void Anchor()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x110111C", Offset = "0x110111C", VA = "0x110111C")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1101184", Offset = "0x1101184", VA = "0x1101184")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1101484", Offset = "0x1101484", VA = "0x1101484")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1101C80", Offset = "0x1101C80", VA = "0x1101C80")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000D3")]
		private bool holding
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x1102078", Offset = "0x1102078", VA = "0x1102078")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D4")]
		private bool holdingLeft
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x1102148", Offset = "0x1102148", VA = "0x1102148")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D5")]
		private bool holdingRight
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x11020A0", Offset = "0x11020A0", VA = "0x11020A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1101CEC", Offset = "0x1101CEC", VA = "0x1101CEC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007B3")]
		protected abstract void RotatePivot();

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x11021F0", Offset = "0x11021F0", VA = "0x11021F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x11023B0", Offset = "0x11023B0", VA = "0x11023B0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1102520", Offset = "0x1102520", VA = "0x1102520")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x11025F0", Offset = "0x11025F0", VA = "0x11025F0")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x110271C", Offset = "0x110271C", VA = "0x110271C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x110289C", Offset = "0x110289C", VA = "0x110289C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1102A98", Offset = "0x1102A98", VA = "0x1102A98")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1102AAC", Offset = "0x1102AAC", VA = "0x1102AAC", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1102C8C", Offset = "0x1102C8C", VA = "0x1102C8C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1102CA0", Offset = "0x1102CA0", VA = "0x1102CA0", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1102DB4", Offset = "0x1102DB4", VA = "0x1102DB4")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1102DC8", Offset = "0x1102DC8", VA = "0x1102DC8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1102E60", Offset = "0x1102E60", VA = "0x1102E60")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1102F78", Offset = "0x1102F78", VA = "0x1102F78")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1102F80", Offset = "0x1102F80", VA = "0x1102F80")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1102FD0", Offset = "0x1102FD0", VA = "0x1102FD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x110301C", Offset = "0x110301C", VA = "0x110301C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x11030B4", Offset = "0x11030B4", VA = "0x11030B4")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000119")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D0")]
				[Address(RVA = "0x110340C", Offset = "0x110340C", VA = "0x110340C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0x1103454", Offset = "0x1103454", VA = "0x1103454", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1103240", Offset = "0x1103240", VA = "0x1103240")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x1103278", Offset = "0x1103278", VA = "0x1103278", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x110327C", Offset = "0x110327C", VA = "0x110327C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1103414", Offset = "0x1103414", VA = "0x1103414", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x11030C4", Offset = "0x11030C4", VA = "0x11030C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1103174", Offset = "0x1103174", VA = "0x1103174")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x11031C8", Offset = "0x11031C8", VA = "0x11031C8")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1103268", Offset = "0x1103268", VA = "0x1103268")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x200011B")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x11036C8", Offset = "0x11036C8", VA = "0x11036C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x1103710", Offset = "0x1103710", VA = "0x1103710", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x110356C", Offset = "0x110356C", VA = "0x110356C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x110359C", Offset = "0x110359C", VA = "0x110359C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x11035A0", Offset = "0x11035A0", VA = "0x11035A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x11036D0", Offset = "0x11036D0", VA = "0x11036D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x110345C", Offset = "0x110345C", VA = "0x110345C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x1103504", Offset = "0x1103504", VA = "0x1103504")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1103594", Offset = "0x1103594", VA = "0x1103594")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public class EffectorLink
		{
			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x110377C", Offset = "0x110377C", VA = "0x110377C")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x11042B8", Offset = "0x11042B8", VA = "0x11042B8")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x1103B40", Offset = "0x1103B40", VA = "0x1103B40")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x11043A0", Offset = "0x11043A0", VA = "0x11043A0")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1104484", Offset = "0x1104484", VA = "0x1104484")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1104510", Offset = "0x1104510", VA = "0x1104510")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1104598", Offset = "0x1104598", VA = "0x1104598")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x11040F8", Offset = "0x11040F8", VA = "0x11040F8")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1104620", Offset = "0x1104620", VA = "0x1104620")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1103718", Offset = "0x1103718", VA = "0x1103718")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1103AE0", Offset = "0x1103AE0", VA = "0x1103AE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1104048", Offset = "0x1104048", VA = "0x1104048")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x11042B0", Offset = "0x11042B0", VA = "0x11042B0")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x110465C", Offset = "0x110465C", VA = "0x110465C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x110468C", Offset = "0x110468C", VA = "0x110468C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x110473C", Offset = "0x110473C", VA = "0x110473C")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Left hand poser (poses fingers to match the left hand target).")]
		public Poser leftHandPoser;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of pinning the left hand to the prop.")]
		public float leftHandWeight;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1104750", Offset = "0x1104750", VA = "0x1104750")]
		private void Start()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x11048EC", Offset = "0x11048EC", VA = "0x11048EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x1104BE4", Offset = "0x1104BE4", VA = "0x1104BE4")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1104D84", Offset = "0x1104D84", VA = "0x1104D84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1104E90", Offset = "0x1104E90", VA = "0x1104E90")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x1104EA4", Offset = "0x1104EA4", VA = "0x1104EA4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x11052FC", Offset = "0x11052FC", VA = "0x11052FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x11054C4", Offset = "0x11054C4", VA = "0x11054C4")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x11054F8", Offset = "0x11054F8", VA = "0x11054F8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1105700", Offset = "0x1105700", VA = "0x1105700")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x110576C", Offset = "0x110576C", VA = "0x110576C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000123")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000DA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000800")]
				[Address(RVA = "0x1105EB8", Offset = "0x1105EB8", VA = "0x1105EB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000802")]
				[Address(RVA = "0x1105F00", Offset = "0x1105F00", VA = "0x1105F00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1105B4C", Offset = "0x1105B4C", VA = "0x1105B4C")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1105D3C", Offset = "0x1105D3C", VA = "0x1105D3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1105D40", Offset = "0x1105D40", VA = "0x1105D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x1105EC0", Offset = "0x1105EC0", VA = "0x1105EC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1105774", Offset = "0x1105774", VA = "0x1105774")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x1105898", Offset = "0x1105898", VA = "0x1105898")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x1105830", Offset = "0x1105830", VA = "0x1105830")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x1105B74", Offset = "0x1105B74", VA = "0x1105B74")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1105C4C", Offset = "0x1105C4C", VA = "0x1105C4C")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x1105D20", Offset = "0x1105D20", VA = "0x1105D20")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1105F08", Offset = "0x1105F08", VA = "0x1105F08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1105F70", Offset = "0x1105F70", VA = "0x1105F70")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x110601C", Offset = "0x110601C", VA = "0x110601C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000126")]
		public class Part
		{
			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x1106090", Offset = "0x1106090", VA = "0x1106090")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x11061B0", Offset = "0x11061B0", VA = "0x11061B0")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x110602C", Offset = "0x110602C", VA = "0x110602C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x11061A8", Offset = "0x11061A8", VA = "0x11061A8")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x11061B8", Offset = "0x11061B8", VA = "0x11061B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x11062FC", Offset = "0x11062FC", VA = "0x11062FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1106460", Offset = "0x1106460", VA = "0x1106460")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class VRController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000129")]
		public enum InputMode
		{
			[Token(Token = "0x4000864")]
			Input,
			[Token(Token = "0x4000865")]
			WASDOnly
		}

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputMode inputMode;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float walkSpeed;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float runSpeed;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float walkForwardSpeedMlp;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float runForwardSpeedMlp;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 smoothInput;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 smoothInputV;

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x1106470", Offset = "0x1106470", VA = "0x1106470")]
		private void Update()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x1106664", Offset = "0x1106664", VA = "0x1106664")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x11069AC", Offset = "0x11069AC", VA = "0x11069AC")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("HMD.")]
		[Header("Head")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Multiplies the scale of the root.")]
		[Header("Scale")]
		public float scaleMlp;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x11069C0", Offset = "0x11069C0", VA = "0x11069C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x1106B48", Offset = "0x1106B48", VA = "0x1106B48")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x1106BB8", Offset = "0x1106BB8", VA = "0x1106BB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1106D10", Offset = "0x1106D10", VA = "0x1106D10")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x1106D78", Offset = "0x1106D78", VA = "0x1106D78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x1106DC8", Offset = "0x1106DC8", VA = "0x1106DC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1106FA0", Offset = "0x1106FA0", VA = "0x1106FA0")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x1106FF8", Offset = "0x1106FF8", VA = "0x1106FF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1107518", Offset = "0x1107518", VA = "0x1107518")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000DC")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x1107594", Offset = "0x1107594", VA = "0x1107594", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1107574", Offset = "0x1107574", VA = "0x1107574", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x110759C", Offset = "0x110759C", VA = "0x110759C")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x11075FC", Offset = "0x11075FC", VA = "0x11075FC", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1107780", Offset = "0x1107780", VA = "0x1107780", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x11079FC", Offset = "0x11079FC", VA = "0x11079FC", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x1107790", Offset = "0x1107790", VA = "0x1107790")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1107A0C", Offset = "0x1107A0C", VA = "0x1107A0C")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1107A24", Offset = "0x1107A24", VA = "0x1107A24", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x1107A7C", Offset = "0x1107A7C", VA = "0x1107A7C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x1107B0C", Offset = "0x1107B0C", VA = "0x1107B0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x1107C30", Offset = "0x1107C30", VA = "0x1107C30")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000895")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000896")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000DD")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1107CE0", Offset = "0x1107CE0", VA = "0x1107CE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x1107C48", Offset = "0x1107C48", VA = "0x1107C48", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1107CC4", Offset = "0x1107CC4", VA = "0x1107CC4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x1107DD4", Offset = "0x1107DD4", VA = "0x1107DD4", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x11081C4", Offset = "0x11081C4", VA = "0x11081C4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x1108408", Offset = "0x1108408", VA = "0x1108408")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		[Header("Base Parameters")]
		public Transform gravityTarget;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40008A4")]
		protected const float half = 0.5f;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x600082B")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x110842C", Offset = "0x110842C", VA = "0x110842C")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1108618", Offset = "0x1108618", VA = "0x1108618", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x11087C8", Offset = "0x11087C8", VA = "0x11087C8", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x1108968", Offset = "0x1108968", VA = "0x1108968")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x11089C8", Offset = "0x11089C8", VA = "0x11089C8")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1108B2C", Offset = "0x1108B2C", VA = "0x1108B2C")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x1108D30", Offset = "0x1108D30", VA = "0x1108D30")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x1108D54", Offset = "0x1108D54", VA = "0x1108D54")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1108D78", Offset = "0x1108D78", VA = "0x1108D78")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1108EC4", Offset = "0x1108EC4", VA = "0x1108EC4")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000133")]
		public enum MoveMode
		{
			[Token(Token = "0x40008E3")]
			Directional,
			[Token(Token = "0x40008E4")]
			Strafe
		}

		[Token(Token = "0x2000134")]
		public struct AnimState
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000135")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000E0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600084D")]
				[Address(RVA = "0x110B9AC", Offset = "0x110B9AC", VA = "0x110B9AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084F")]
				[Address(RVA = "0x110B9F4", Offset = "0x110B9F4", VA = "0x110B9F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x110B778", Offset = "0x110B778", VA = "0x110B778")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x110B8B4", Offset = "0x110B8B4", VA = "0x110B8B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x110B8B8", Offset = "0x110B8B8", VA = "0x110B8B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x110B9B4", Offset = "0x110B9B4", VA = "0x110B9B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000DE")]
		public bool fullRootMotion
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1108EE4", Offset = "0x1108EE4", VA = "0x1108EE4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1108EEC", Offset = "0x1108EEC", VA = "0x1108EEC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool onGround
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x1108EF8", Offset = "0x1108EF8", VA = "0x1108EF8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x1108F00", Offset = "0x1108F00", VA = "0x1108F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1108F0C", Offset = "0x1108F0C", VA = "0x1108F0C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x11090DC", Offset = "0x11090DC", VA = "0x11090DC")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1109160", Offset = "0x1109160", VA = "0x1109160", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1109274", Offset = "0x1109274", VA = "0x1109274")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x110A308", Offset = "0x110A308", VA = "0x110A308", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x110A798", Offset = "0x110A798", VA = "0x110A798", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x1109968", Offset = "0x1109968", VA = "0x1109968")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x110A870", Offset = "0x110A870", VA = "0x110A870")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x110AEF8", Offset = "0x110AEF8", VA = "0x110AEF8")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x110A394", Offset = "0x110A394", VA = "0x110A394")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x110AFF0", Offset = "0x110AFF0", VA = "0x110AFF0", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x110B470", Offset = "0x110B470", VA = "0x110B470")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x110B598", Offset = "0x110B598", VA = "0x110B598", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x110B6EC", Offset = "0x110B6EC", VA = "0x110B6EC")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__79))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1109D9C", Offset = "0x1109D9C", VA = "0x1109D9C")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x110B7A0", Offset = "0x110B7A0", VA = "0x110B7A0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000137")]
		public enum RotationMode
		{
			[Token(Token = "0x4000900")]
			Smooth,
			[Token(Token = "0x4000901")]
			Linear
		}

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000E2")]
		public bool isGrounded
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x110B9FC", Offset = "0x110B9FC", VA = "0x110B9FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x110BA04", Offset = "0x110BA04", VA = "0x110BA04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x110BA10", Offset = "0x110BA10", VA = "0x110BA10")]
		private void Start()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x110BAA4", Offset = "0x110BAA4", VA = "0x110BAA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x110C0BC", Offset = "0x110C0BC", VA = "0x110C0BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x110BAEC", Offset = "0x110BAEC", VA = "0x110BAEC")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x110BE54", Offset = "0x110BE54", VA = "0x110BE54")]
		private void Move()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x110C0EC", Offset = "0x110C0EC", VA = "0x110C0EC")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x110C184", Offset = "0x110C184", VA = "0x110C184")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x110C204", Offset = "0x110C204", VA = "0x110C204")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x110C22C", Offset = "0x110C22C", VA = "0x110C22C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x110C348", Offset = "0x110C348", VA = "0x110C348", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x110C9AC", Offset = "0x110C9AC", VA = "0x110C9AC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x110CB98", Offset = "0x110CB98", VA = "0x110CB98")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x200013A")]
		public struct State
		{
			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400090E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400090F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x110C268", Offset = "0x110C268", VA = "0x110C268", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x1104FB8", Offset = "0x1104FB8", VA = "0x1104FB8", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x11054E8", Offset = "0x11054E8", VA = "0x11054E8")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x200013B")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x110CBB4", Offset = "0x110CBB4", VA = "0x110CBB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x110CBEC", Offset = "0x110CBEC", VA = "0x110CBEC")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x110CBF4", Offset = "0x110CBF4", VA = "0x110CBF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x110CC1C", Offset = "0x110CC1C", VA = "0x110CC1C")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x110CCC0", Offset = "0x110CCC0", VA = "0x110CCC0")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013D")]
	public class Navigator
	{
		[Token(Token = "0x200013E")]
		public enum State
		{
			[Token(Token = "0x4000923")]
			Idle,
			[Token(Token = "0x4000924")]
			Seeking,
			[Token(Token = "0x4000925")]
			OnPath
		}

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000E3")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x110CCD4", Offset = "0x110CCD4", VA = "0x110CCD4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x110CCE0", Offset = "0x110CCE0", VA = "0x110CCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public State state
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x110CCEC", Offset = "0x110CCEC", VA = "0x110CCEC")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x110CCF4", Offset = "0x110CCF4", VA = "0x110CCF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x110C294", Offset = "0x110C294", VA = "0x110C294")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x110C568", Offset = "0x110C568", VA = "0x110C568")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x110CDD4", Offset = "0x110CDD4", VA = "0x110CDD4")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x110CE38", Offset = "0x110CE38", VA = "0x110CE38")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x110CCFC", Offset = "0x110CCFC", VA = "0x110CCFC")]
		private void Stop()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x110CD58", Offset = "0x110CD58", VA = "0x110CD58")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x110C9D4", Offset = "0x110C9D4", VA = "0x110C9D4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x110CF6C", Offset = "0x110CF6C", VA = "0x110CF6C")]
		public Navigator()
		{
		}
	}
}
