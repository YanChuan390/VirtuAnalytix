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
	public abstract class AnimationModifier : MonoBehaviour
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Animator animator;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Baker baker;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xCC9450", Offset = "0xCC9450", VA = "0xCC9450", Slot = "4")]
		public virtual void OnInitiate(Baker baker, Animator animator)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xCC9480", Offset = "0xCC9480", VA = "0xCC9480", Slot = "5")]
		public virtual void OnStartClip(AnimationClip clip)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xCC9484", Offset = "0xCC9484", VA = "0xCC9484", Slot = "6")]
		public virtual void OnBakerUpdate(float normalizedTime)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xCC9488", Offset = "0xCC9488", VA = "0xCC9488")]
		protected AnimationModifier()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class AnimationModifierStack : MonoBehaviour
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationModifier[] modifiers;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Baker baker;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xCC9490", Offset = "0xCC9490", VA = "0xCC9490")]
		private void Start()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xCC979C", Offset = "0xCC979C", VA = "0xCC979C")]
		private void OnBakerStartClip(AnimationClip clip, float normalizedTime)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xCC9808", Offset = "0xCC9808", VA = "0xCC9808")]
		private void OnBakerUpdateClip(AnimationClip clip, float normalizedTime)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xCC9890", Offset = "0xCC9890", VA = "0xCC9890")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xCC9A08", Offset = "0xCC9A08", VA = "0xCC9A08")]
		public AnimationModifierStack()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000005")]
		public enum Mode
		{
			[Token(Token = "0x4000019")]
			AnimationClips,
			[Token(Token = "0x400001A")]
			AnimationStates,
			[Token(Token = "0x400001B")]
			PlayableDirector,
			[Token(Token = "0x400001C")]
			Realtime
		}

		[Token(Token = "0x2000006")]
		public delegate void BakerDelegate(AnimationClip clip, float time);

		[Serializable]
		[Token(Token = "0x2000007")]
		public class ClipSettings
		{
			[Serializable]
			[Token(Token = "0x2000008")]
			public enum BasedUponRotation
			{
				[Token(Token = "0x400002A")]
				Original,
				[Token(Token = "0x400002B")]
				BodyOrientation
			}

			[Serializable]
			[Token(Token = "0x2000009")]
			public enum BasedUponY
			{
				[Token(Token = "0x400002D")]
				Original,
				[Token(Token = "0x400002E")]
				CenterOfMass,
				[Token(Token = "0x400002F")]
				Feet
			}

			[Serializable]
			[Token(Token = "0x200000A")]
			public enum BasedUponXZ
			{
				[Token(Token = "0x4000031")]
				Original,
				[Token(Token = "0x4000032")]
				CenterOfMass
			}

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool loopTime;

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool loopBlend;

			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float cycleOffset;

			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool loopBlendOrientation;

			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public BasedUponRotation basedUponRotation;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float orientationOffsetY;

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool loopBlendPositionY;

			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BasedUponY basedUponY;

			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float level;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool loopBlendPositionXZ;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public BasedUponXZ basedUponXZ;

			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool mirror;

			[Token(Token = "0x6000021")]
			[Address(RVA = "0xCC9D90", Offset = "0xCC9D90", VA = "0xCC9D90")]
			public ClipSettings()
			{
			}
		}

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BakerDelegate OnStartClip;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public BakerDelegate OnUpdateClip;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("If enabled, baked clips will have the same AnimationClipSettings as the clips used for baking. If disabled, clip settings from below will be applied to all the baked clips.")]
		public bool inheritClipSettings;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("AnimationClipSettings applied to the baked animation clip.")]
		public ClipSettings clipSettings;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		protected bool addLoopFrame;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xCC9B7C", Offset = "0xCC9B7C", VA = "0xCC9B7C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xCC9B84", Offset = "0xCC9B84", VA = "0xCC9B84")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0xCC9B90", Offset = "0xCC9B90", VA = "0xCC9B90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0xCC9B98", Offset = "0xCC9B98", VA = "0xCC9B98")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xCC9BA0", Offset = "0xCC9BA0", VA = "0xCC9BA0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xCC9BA8", Offset = "0xCC9BA8", VA = "0xCC9BA8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xCC9A6C", Offset = "0xCC9A6C", VA = "0xCC9A6C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xCC9AB0", Offset = "0xCC9AB0", VA = "0xCC9AB0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xCC9AF4", Offset = "0xCC9AF4", VA = "0xCC9AF4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xCC9B38", Offset = "0xCC9B38", VA = "0xCC9B38")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000012")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x6000013")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000014")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000015")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000016")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xCC9BB0", Offset = "0xCC9BB0", VA = "0xCC9BB0")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xCC9BB4", Offset = "0xCC9BB4", VA = "0xCC9BB4")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xCC9BB8", Offset = "0xCC9BB8", VA = "0xCC9BB8")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xCC9BBC", Offset = "0xCC9BBC", VA = "0xCC9BBC")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerTransform[] children;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerTransform rootChild;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int rootChildIndex;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xCC9D98", Offset = "0xCC9D98", VA = "0xCC9D98")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xCCA1DC", Offset = "0xCCA1DC", VA = "0xCCA1DC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xCCA1E4", Offset = "0xCCA1E4", VA = "0xCCA1E4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xCCA420", Offset = "0xCCA420", VA = "0xCCA420", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xCCA684", Offset = "0xCCA684", VA = "0xCCA684", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xCCA99C", Offset = "0xCCA99C", VA = "0xCCA99C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xCC9FC4", Offset = "0xCC9FC4", VA = "0xCC9FC4")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xCCA07C", Offset = "0xCCA07C", VA = "0xCCA07C")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xCCABFC", Offset = "0xCCABFC", VA = "0xCCABFC")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class TQ
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xCCAC64", Offset = "0xCCAC64", VA = "0xCCAC64")]
		public TQ()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xCCAC6C", Offset = "0xCCAC6C", VA = "0xCCAC6C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AvatarUtility
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xCCACD0", Offset = "0xCCACD0", VA = "0xCCACD0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xCCAF2C", Offset = "0xCCAF2C", VA = "0xCCAF2C")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xCCB59C", Offset = "0xCCB59C", VA = "0xCCB59C")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xCCBA64", Offset = "0xCCBA64", VA = "0xCCBA64")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xCCAF0C", Offset = "0xCCAF0C", VA = "0xCCAF0C")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xCCBC50", Offset = "0xCCBC50", VA = "0xCCBC50")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xCCBC58", Offset = "0xCCBC58", VA = "0xCCBC58")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xCCBC90", Offset = "0xCCBC90", VA = "0xCCBC90")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xCCC054", Offset = "0xCCC054", VA = "0xCCC054")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xCCC234", Offset = "0xCCC234", VA = "0xCCC234")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xCCC238", Offset = "0xCCC238", VA = "0xCCC238")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xCCC3CC", Offset = "0xCCC3CC", VA = "0xCCC3CC")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xCCC730", Offset = "0xCCC730", VA = "0xCCC730")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xCCC918", Offset = "0xCCC918", VA = "0xCCC918")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xCCC9A8", Offset = "0xCCC9A8", VA = "0xCCC9A8")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xCCBB88", Offset = "0xCCBB88", VA = "0xCCBB88")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xCCCA1C", Offset = "0xCCCA1C", VA = "0xCCCA1C")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xCCC598", Offset = "0xCCC598", VA = "0xCCC598")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xCCCA20", Offset = "0xCCCA20", VA = "0xCCCA20")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xCCCDB0", Offset = "0xCCCDB0", VA = "0xCCCDB0")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xCCCEA0", Offset = "0xCCCEA0", VA = "0xCCCEA0")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xCCCF84", Offset = "0xCCCF84", VA = "0xCCCF84")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xCCCFEC", Offset = "0xCCCFEC", VA = "0xCCCFEC")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xCCCF08", Offset = "0xCCCF08", VA = "0xCCCF08")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xCCCFF0", Offset = "0xCCCFF0", VA = "0xCCCFF0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xCCD098", Offset = "0xCCD098", VA = "0xCCD098")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class BakerMuscle
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xCCD384", Offset = "0xCCD384", VA = "0xCCD384")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xCCD3F4", Offset = "0xCCD3F4", VA = "0xCCD3F4")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xCCDE90", Offset = "0xCCDE90", VA = "0xCCDE90")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xCCDF38", Offset = "0xCCDF38", VA = "0xCCDF38")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xCCDE28", Offset = "0xCCDE28", VA = "0xCCDE28")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xCCE02C", Offset = "0xCCE02C", VA = "0xCCE02C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xCCE068", Offset = "0xCCE068", VA = "0xCCE068")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class BakerTransform
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xCCA134", Offset = "0xCCA134", VA = "0xCCA134")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xCCA40C", Offset = "0xCCA40C", VA = "0xCCA40C")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xCCA6E8", Offset = "0xCCA6E8", VA = "0xCCA6E8")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xCCE070", Offset = "0xCCE070", VA = "0xCCE070")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xCCA2B4", Offset = "0xCCA2B4", VA = "0xCCA2B4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xCCE2F8", Offset = "0xCCE2F8", VA = "0xCCE2F8")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xCCAA08", Offset = "0xCCAA08", VA = "0xCCAA08")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xCCA48C", Offset = "0xCCA48C", VA = "0xCCA48C")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float[] muscles;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private HumanPose pose;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private HumanPoseHandler handler;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 bodyPosition;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Quaternion bodyRotation;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mN;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xCCE360", Offset = "0xCCE360", VA = "0xCCE360")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xCCE8C0", Offset = "0xCCE8C0", VA = "0xCCE8C0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xCCE8DC", Offset = "0xCCE8DC", VA = "0xCCE8DC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xCCE9B4", Offset = "0xCCE9B4", VA = "0xCCE9B4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xCCEA70", Offset = "0xCCEA70", VA = "0xCCEA70", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xCCEC10", Offset = "0xCCEC10", VA = "0xCCEC10", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xCCEF34", Offset = "0xCCEF34", VA = "0xCCEF34")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xCCF014", Offset = "0xCCF014", VA = "0xCCF014")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000014")]
		public enum UpdateMode
		{
			[Token(Token = "0x4000096")]
			Update,
			[Token(Token = "0x4000097")]
			FixedUpdate,
			[Token(Token = "0x4000098")]
			LateUpdate,
			[Token(Token = "0x4000099")]
			FixedLateUpdate
		}

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0xCCF0C4", Offset = "0xCCF0C4", VA = "0xCCF0C4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005F")]
			[Address(RVA = "0xCCF0CC", Offset = "0xCCF0CC", VA = "0xCCF0CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0xCCF0D4", Offset = "0xCCF0D4", VA = "0xCCF0D4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000061")]
			[Address(RVA = "0xCCF0DC", Offset = "0xCCF0DC", VA = "0xCCF0DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0xCCF0E4", Offset = "0xCCF0E4", VA = "0xCCF0E4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xCCF0EC", Offset = "0xCCF0EC", VA = "0xCCF0EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xCCFB54", Offset = "0xCCFB54", VA = "0xCCFB54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xCCF0F4", Offset = "0xCCF0F4", VA = "0xCCF0F4")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xCCF12C", Offset = "0xCCF12C", VA = "0xCCF12C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xCCF134", Offset = "0xCCF134", VA = "0xCCF134", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xCCF26C", Offset = "0xCCF26C", VA = "0xCCF26C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xCCF2B4", Offset = "0xCCF2B4", VA = "0xCCF2B4", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xCCF30C", Offset = "0xCCF30C", VA = "0xCCF30C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xCCF364", Offset = "0xCCF364", VA = "0xCCF364")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xCCF298", Offset = "0xCCF298", VA = "0xCCF298")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xCCF4F0", Offset = "0xCCF4F0", VA = "0xCCF4F0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xCCFB18", Offset = "0xCCFB18", VA = "0xCCFB18")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xCCFBC0", Offset = "0xCCFBC0", VA = "0xCCFBC0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xCCFC88", Offset = "0xCCFC88", VA = "0xCCFC88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xCCFCB4", Offset = "0xCCFCB4", VA = "0xCCFCB4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xCCFED8", Offset = "0xCCFED8", VA = "0xCCFED8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xCCFF14", Offset = "0xCCFF14", VA = "0xCCFF14")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000016")]
	public enum Axis
	{
		[Token(Token = "0x40000A0")]
		X,
		[Token(Token = "0x40000A1")]
		Y,
		[Token(Token = "0x40000A2")]
		Z
	}
	[Token(Token = "0x2000017")]
	public class AxisTools
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xCCFF30", Offset = "0xCCFF30", VA = "0xCCFF30")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xCD0010", Offset = "0xCD0010", VA = "0xCD0010")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xCD0048", Offset = "0xCD0048", VA = "0xCD0048")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xCD0190", Offset = "0xCD0190", VA = "0xCD0190")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xCD0144", Offset = "0xCD0144", VA = "0xCD0144")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xCD028C", Offset = "0xCD028C", VA = "0xCD028C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xCD02D0", Offset = "0xCD02D0", VA = "0xCD02D0")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xCD0590", Offset = "0xCD0590", VA = "0xCD0590")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000018")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000019")]
		public class LimbOrientation
		{
			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600007F")]
			[Address(RVA = "0xCD08C4", Offset = "0xCD08C4", VA = "0xCD08C4")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xCD060C", Offset = "0xCD060C", VA = "0xCD060C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xCD0938", Offset = "0xCD0938", VA = "0xCD0938")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xCD0598", Offset = "0xCD0598", VA = "0xCD0598")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200001B")]
		public enum BoneType
		{
			[Token(Token = "0x40000BD")]
			Unassigned,
			[Token(Token = "0x40000BE")]
			Spine,
			[Token(Token = "0x40000BF")]
			Head,
			[Token(Token = "0x40000C0")]
			Arm,
			[Token(Token = "0x40000C1")]
			Leg,
			[Token(Token = "0x40000C2")]
			Tail,
			[Token(Token = "0x40000C3")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		public enum BoneSide
		{
			[Token(Token = "0x40000C5")]
			Center,
			[Token(Token = "0x40000C6")]
			Left,
			[Token(Token = "0x40000C7")]
			Right
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xCD0BF0", Offset = "0xCD0BF0", VA = "0xCD0BF0")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xCD0EBC", Offset = "0xCD0EBC", VA = "0xCD0EBC")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xCD10F8", Offset = "0xCD10F8", VA = "0xCD10F8")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xCD116C", Offset = "0xCD116C", VA = "0xCD116C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xCD1200", Offset = "0xCD1200", VA = "0xCD1200")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xCD0DA4", Offset = "0xCD0DA4", VA = "0xCD0DA4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xCD1070", Offset = "0xCD1070", VA = "0xCD1070")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xCD1938", Offset = "0xCD1938", VA = "0xCD1938")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xCD1790", Offset = "0xCD1790", VA = "0xCD1790")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xCD1864", Offset = "0xCD1864", VA = "0xCD1864")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xCD13E8", Offset = "0xCD13E8", VA = "0xCD13E8")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xCD1484", Offset = "0xCD1484", VA = "0xCD1484")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xCD1520", Offset = "0xCD1520", VA = "0xCD1520")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xCD15BC", Offset = "0xCD15BC", VA = "0xCD15BC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xCD1658", Offset = "0xCD1658", VA = "0xCD1658")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xCD16F4", Offset = "0xCD16F4", VA = "0xCD16F4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xCD1B20", Offset = "0xCD1B20", VA = "0xCD1B20")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xCD1314", Offset = "0xCD1314", VA = "0xCD1314")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xCD1A9C", Offset = "0xCD1A9C", VA = "0xCD1A9C")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xCD1B80", Offset = "0xCD1B80", VA = "0xCD1B80")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xCD1C40", Offset = "0xCD1C40", VA = "0xCD1C40")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xCD1A28", Offset = "0xCD1A28", VA = "0xCD1A28")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xCD19B8", Offset = "0xCD19B8", VA = "0xCD19B8")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class BipedReferences
	{
		[Token(Token = "0x200001E")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0xCD86F8", Offset = "0xCD86F8", VA = "0xCD86F8")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xCD86E4", Offset = "0xCD86E4", VA = "0xCD86E4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xCD4A30", Offset = "0xCD4A30", VA = "0xCD4A30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xCD4D8C", Offset = "0xCD4D8C", VA = "0xCD4D8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xCD4D9C", Offset = "0xCD4D9C", VA = "0xCD4D9C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xCD5128", Offset = "0xCD5128", VA = "0xCD5128", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xCD54B8", Offset = "0xCD54B8", VA = "0xCD54B8")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xCD5BDC", Offset = "0xCD5BDC", VA = "0xCD5BDC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xCD574C", Offset = "0xCD574C", VA = "0xCD574C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xCD645C", Offset = "0xCD645C", VA = "0xCD645C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xCD6548", Offset = "0xCD6548", VA = "0xCD6548")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xCD7064", Offset = "0xCD7064", VA = "0xCD7064")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xCD6E70", Offset = "0xCD6E70", VA = "0xCD6E70")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xCD6C10", Offset = "0xCD6C10", VA = "0xCD6C10")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xCD65E4", Offset = "0xCD65E4", VA = "0xCD65E4")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xCD6F64", Offset = "0xCD6F64", VA = "0xCD6F64")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xCD7144", Offset = "0xCD7144", VA = "0xCD7144")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xCD7CEC", Offset = "0xCD7CEC", VA = "0xCD7CEC")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xCD7794", Offset = "0xCD7794", VA = "0xCD7794")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xCD8038", Offset = "0xCD8038", VA = "0xCD8038")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xCD7AF4", Offset = "0xCD7AF4", VA = "0xCD7AF4")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xCD8040", Offset = "0xCD8040", VA = "0xCD8040")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xCD8048", Offset = "0xCD8048", VA = "0xCD8048")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xCD8208", Offset = "0xCD8208", VA = "0xCD8208")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xCD867C", Offset = "0xCD867C", VA = "0xCD867C")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xCD56CC", Offset = "0xCD56CC", VA = "0xCD56CC")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xCD8700", Offset = "0xCD8700", VA = "0xCD8700")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xCD8708", Offset = "0xCD8708", VA = "0xCD8708")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xCD8800", Offset = "0xCD8800", VA = "0xCD8800")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class Hierarchy
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xCD85F8", Offset = "0xCD85F8", VA = "0xCD85F8")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xCD84EC", Offset = "0xCD84EC", VA = "0xCD84EC")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xCD6748", Offset = "0xCD6748", VA = "0xCD6748")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xCD6D60", Offset = "0xCD6D60", VA = "0xCD6D60")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xCD69C8", Offset = "0xCD69C8", VA = "0xCD69C8")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xCD8810", Offset = "0xCD8810", VA = "0xCD8810")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xCD6878", Offset = "0xCD6878", VA = "0xCD6878")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xCD8904", Offset = "0xCD8904", VA = "0xCD8904")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xCD8C70", Offset = "0xCD8C70", VA = "0xCD8C70")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xCD8A68", Offset = "0xCD8A68", VA = "0xCD8A68")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xCD8DF8", Offset = "0xCD8DF8", VA = "0xCD8DF8")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xCD8E00", Offset = "0xCD8E00", VA = "0xCD8E00")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xCD8E88", Offset = "0xCD8E88", VA = "0xCD8E88")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000E1")]
		None,
		[Token(Token = "0x40000E2")]
		InOutCubic,
		[Token(Token = "0x40000E3")]
		InOutQuintic,
		[Token(Token = "0x40000E4")]
		InOutSine,
		[Token(Token = "0x40000E5")]
		InQuintic,
		[Token(Token = "0x40000E6")]
		InQuartic,
		[Token(Token = "0x40000E7")]
		InCubic,
		[Token(Token = "0x40000E8")]
		InQuadratic,
		[Token(Token = "0x40000E9")]
		InElastic,
		[Token(Token = "0x40000EA")]
		InElasticSmall,
		[Token(Token = "0x40000EB")]
		InElasticBig,
		[Token(Token = "0x40000EC")]
		InSine,
		[Token(Token = "0x40000ED")]
		InBack,
		[Token(Token = "0x40000EE")]
		OutQuintic,
		[Token(Token = "0x40000EF")]
		OutQuartic,
		[Token(Token = "0x40000F0")]
		OutCubic,
		[Token(Token = "0x40000F1")]
		OutInCubic,
		[Token(Token = "0x40000F2")]
		OutInQuartic,
		[Token(Token = "0x40000F3")]
		OutElastic,
		[Token(Token = "0x40000F4")]
		OutElasticSmall,
		[Token(Token = "0x40000F5")]
		OutElasticBig,
		[Token(Token = "0x40000F6")]
		OutSine,
		[Token(Token = "0x40000F7")]
		OutBack,
		[Token(Token = "0x40000F8")]
		OutBackCubic,
		[Token(Token = "0x40000F9")]
		OutBackQuartic,
		[Token(Token = "0x40000FA")]
		BackInCubic,
		[Token(Token = "0x40000FB")]
		BackInQuartic
	}
	[Token(Token = "0x2000024")]
	public class Interp
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xCD8F14", Offset = "0xCD8F14", VA = "0xCD8F14")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xCD989C", Offset = "0xCD989C", VA = "0xCD989C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xCD990C", Offset = "0xCD990C", VA = "0xCD990C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xCD9314", Offset = "0xCD9314", VA = "0xCD9314")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xCD9320", Offset = "0xCD9320", VA = "0xCD9320")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xCD9344", Offset = "0xCD9344", VA = "0xCD9344")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xCD9380", Offset = "0xCD9380", VA = "0xCD9380")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xCD9398", Offset = "0xCD9398", VA = "0xCD9398")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xCD93AC", Offset = "0xCD93AC", VA = "0xCD93AC")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xCD93C0", Offset = "0xCD93C0", VA = "0xCD93C0")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xCD93D0", Offset = "0xCD93D0", VA = "0xCD93D0")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xCD9418", Offset = "0xCD9418", VA = "0xCD9418")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xCD9450", Offset = "0xCD9450", VA = "0xCD9450")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xCD9478", Offset = "0xCD9478", VA = "0xCD9478")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xCD997C", Offset = "0xCD997C", VA = "0xCD997C")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xCD94AC", Offset = "0xCD94AC", VA = "0xCD94AC")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xCD94D4", Offset = "0xCD94D4", VA = "0xCD94D4")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xCD9504", Offset = "0xCD9504", VA = "0xCD9504")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xCD9538", Offset = "0xCD9538", VA = "0xCD9538")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xCD957C", Offset = "0xCD957C", VA = "0xCD957C")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xCD95E0", Offset = "0xCD95E0", VA = "0xCD95E0")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xCD9644", Offset = "0xCD9644", VA = "0xCD9644")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xCD9698", Offset = "0xCD9698", VA = "0xCD9698")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xCD96EC", Offset = "0xCD96EC", VA = "0xCD96EC")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xCD9724", Offset = "0xCD9724", VA = "0xCD9724")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xCD9758", Offset = "0xCD9758", VA = "0xCD9758")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xCD99B0", Offset = "0xCD99B0", VA = "0xCD99B0")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xCD979C", Offset = "0xCD979C", VA = "0xCD979C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xCD982C", Offset = "0xCD982C", VA = "0xCD982C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xCD985C", Offset = "0xCD985C", VA = "0xCD985C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xCD9A40", Offset = "0xCD9A40", VA = "0xCD9A40")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xCD9A48", Offset = "0xCD9A48", VA = "0xCD9A48")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xCD9A94", Offset = "0xCD9A94", VA = "0xCD9A94")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xCD9B50", Offset = "0xCD9B50", VA = "0xCD9B50")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xCD9AA8", Offset = "0xCD9AA8", VA = "0xCD9AA8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xCD9B64", Offset = "0xCD9B64", VA = "0xCD9B64")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xCD9BF4", Offset = "0xCD9BF4", VA = "0xCD9BF4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xCD9C1C", Offset = "0xCD9C1C", VA = "0xCD9C1C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xCD9C68", Offset = "0xCD9C68", VA = "0xCD9C68")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xCD9CD0", Offset = "0xCD9CD0", VA = "0xCD9CD0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xCD9E2C", Offset = "0xCD9E2C", VA = "0xCD9E2C")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xCD9F64", Offset = "0xCD9F64", VA = "0xCD9F64")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xCD9FBC", Offset = "0xCD9FBC", VA = "0xCD9FBC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000026")]
	public abstract class LazySingleton<T> : MonoBehaviour where T : LazySingleton<T>
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static bool hasInstance
		{
			[Token(Token = "0x60000ED")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public static T instance
		{
			[Token(Token = "0x60000EE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000F0")]
		protected LazySingleton()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public enum ShowIfMode
	{
		[Token(Token = "0x40000FE")]
		Disabled,
		[Token(Token = "0x40000FF")]
		Hidden
	}
	[Token(Token = "0x2000028")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x1700000F")]
		public string propName
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xCD9FE0", Offset = "0xCD9FE0", VA = "0xCD9FE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xCD9FE8", Offset = "0xCD9FE8", VA = "0xCD9FE8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public object propValue
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xCD9FF0", Offset = "0xCD9FF0", VA = "0xCD9FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xCD9FF8", Offset = "0xCD9FF8", VA = "0xCD9FF8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public object otherPropValue
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xCDA000", Offset = "0xCDA000", VA = "0xCDA000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xCDA008", Offset = "0xCDA008", VA = "0xCDA008")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool indent
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xCDA010", Offset = "0xCDA010", VA = "0xCDA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xCDA018", Offset = "0xCDA018", VA = "0xCDA018")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xCDA024", Offset = "0xCDA024", VA = "0xCDA024")]
			[CompilerGenerated]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xCDA02C", Offset = "0xCDA02C", VA = "0xCDA02C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xCDA034", Offset = "0xCDA034", VA = "0xCDA034")]
		public ShowIfAttribute(string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	public class ShowRangeIfAttribute : ShowIfAttribute
	{
		[Token(Token = "0x17000014")]
		public float min
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xCDA0B4", Offset = "0xCDA0B4", VA = "0xCDA0B4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xCDA0BC", Offset = "0xCDA0BC", VA = "0xCDA0BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float max
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xCDA0C4", Offset = "0xCDA0C4", VA = "0xCDA0C4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0xCDA0CC", Offset = "0xCDA0CC", VA = "0xCDA0CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xCDA0D4", Offset = "0xCDA0D4", VA = "0xCDA0D4")]
		public ShowRangeIfAttribute(float min, float max, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class ShowLargeHeaderIf : ShowIfAttribute
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string color;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xCDA100", Offset = "0xCDA100", VA = "0xCDA100")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xCDA1BC", Offset = "0xCDA1BC", VA = "0xCDA1BC")]
		public ShowLargeHeaderIf(string name, string color, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string color;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xCDA284", Offset = "0xCDA284", VA = "0xCDA284")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xCDA30C", Offset = "0xCDA30C", VA = "0xCDA30C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class QuaTools
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xCDA398", Offset = "0xCDA398", VA = "0xCDA398")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xCDA3F0", Offset = "0xCDA3F0", VA = "0xCDA3F0")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xCDA520", Offset = "0xCDA520", VA = "0xCDA520")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xCDA6A0", Offset = "0xCDA6A0", VA = "0xCDA6A0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xCDA77C", Offset = "0xCDA77C", VA = "0xCDA77C")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xCDA858", Offset = "0xCDA858", VA = "0xCDA858")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xCDAA70", Offset = "0xCDAA70", VA = "0xCDAA70")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xCDAABC", Offset = "0xCDAABC", VA = "0xCDAABC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xCDAB08", Offset = "0xCDAB08", VA = "0xCDAB08")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xCDAC0C", Offset = "0xCDAC0C", VA = "0xCDAC0C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xCDAD10", Offset = "0xCDAD10", VA = "0xCDAD10")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xCDAE24", Offset = "0xCDAE24", VA = "0xCDAE24")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xCDAECC", Offset = "0xCDAECC", VA = "0xCDAECC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xCDAFD8", Offset = "0xCDAFD8", VA = "0xCDAFD8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xCDB140", Offset = "0xCDB140", VA = "0xCDB140")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xCDB324", Offset = "0xCDB324", VA = "0xCDB324")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xCDB3F4", Offset = "0xCDB3F4", VA = "0xCDB3F4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xCDB578", Offset = "0xCDB578", VA = "0xCDB578")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xCDB684", Offset = "0xCDB684", VA = "0xCDB684")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xCDB6DC", Offset = "0xCDB6DC", VA = "0xCDB6DC")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xCDB900", Offset = "0xCDB900", VA = "0xCDB900")]
		public static Quaternion MirrorYZ(Quaternion r)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x200002D")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000016")]
		public static T instance
		{
			[Token(Token = "0x600011A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011B")]
		public static void Clear()
		{
		}

		[Token(Token = "0x600011C")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600011D")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000017")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xCDBB24", Offset = "0xCDBB24", VA = "0xCDBB24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private bool isAnimated
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xCDBE20", Offset = "0xCDBE20", VA = "0xCDBE20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xCDBA08", Offset = "0xCDBA08", VA = "0xCDBA08")]
		public void Disable()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xCDBA9C", Offset = "0xCDBA9C", VA = "0xCDBA9C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xCDBAA0", Offset = "0xCDBAA0", VA = "0xCDBAA0", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xCDBAA4", Offset = "0xCDBAA4", VA = "0xCDBAA4", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xCDBAA8", Offset = "0xCDBAA8", VA = "0xCDBAA8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xCDBB20", Offset = "0xCDBB20", VA = "0xCDBB20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xCDBAD0", Offset = "0xCDBAD0", VA = "0xCDBAD0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xCDBDE4", Offset = "0xCDBDE4", VA = "0xCDBDE4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xCDBBF0", Offset = "0xCDBBF0", VA = "0xCDBBF0")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xCDBEB8", Offset = "0xCDBEB8", VA = "0xCDBEB8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xCDBF04", Offset = "0xCDBF04", VA = "0xCDBF04")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xCDBF50", Offset = "0xCDBF50", VA = "0xCDBF50")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xCDBF88", Offset = "0xCDBF88", VA = "0xCDBF88")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xCDBF98", Offset = "0xCDBF98", VA = "0xCDBF98")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xCDC04C", Offset = "0xCDC04C", VA = "0xCDC04C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xCDC100", Offset = "0xCDC100", VA = "0xCDC100")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xCDC1B4", Offset = "0xCDC1B4", VA = "0xCDC1B4")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public static class V2Tools
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0xCDC1BC", Offset = "0xCDC1BC", VA = "0xCDC1BC")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xCDC1C4", Offset = "0xCDC1C4", VA = "0xCDC1C4")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xCDC254", Offset = "0xCDC254", VA = "0xCDC254")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xCDC2E8", Offset = "0xCDC2E8", VA = "0xCDC2E8")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xCDC398", Offset = "0xCDC398", VA = "0xCDC398")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public static class V3Tools
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xCDC3F4", Offset = "0xCDC3F4", VA = "0xCDC3F4")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xCDC414", Offset = "0xCDC414", VA = "0xCDC414")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xCDC4E8", Offset = "0xCDC4E8", VA = "0xCDC4E8")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xCDC5A0", Offset = "0xCDC5A0", VA = "0xCDC5A0")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xCDC5FC", Offset = "0xCDC5FC", VA = "0xCDC5FC")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xCDC658", Offset = "0xCDC658", VA = "0xCDC658")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xCDC770", Offset = "0xCDC770", VA = "0xCDC770")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xCDC7CC", Offset = "0xCDC7CC", VA = "0xCDC7CC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xCDC804", Offset = "0xCDC804", VA = "0xCDC804")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xCDC9D4", Offset = "0xCDC9D4", VA = "0xCDC9D4")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xCDCBD8", Offset = "0xCDCBD8", VA = "0xCDCBD8")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xCDCD50", Offset = "0xCDCD50", VA = "0xCDCD50")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xCDCF80", Offset = "0xCDCF80", VA = "0xCDCF80")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xCDD1D0", Offset = "0xCDD1D0", VA = "0xCDD1D0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xCDD428", Offset = "0xCDD428", VA = "0xCDD428")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xCDD5D4", Offset = "0xCDD5D4", VA = "0xCDD5D4")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xCDD7CC", Offset = "0xCDD7CC", VA = "0xCDD7CC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xCDD848", Offset = "0xCDD848", VA = "0xCDD848")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xCDD8D8", Offset = "0xCDD8D8", VA = "0xCDD8D8")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xCDD970", Offset = "0xCDD970", VA = "0xCDD970")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xCDD960", Offset = "0xCDD960", VA = "0xCDD960")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000032")]
	public static class Warning
	{
		[Token(Token = "0x2000033")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xCDD9EC", Offset = "0xCDD9EC", VA = "0xCDD9EC")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xCD63A8", Offset = "0xCD63A8", VA = "0xCD63A8")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000034")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xCDDBA8", Offset = "0xCDDBA8", VA = "0xCDDBA8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xCDDBEC", Offset = "0xCDDBEC", VA = "0xCDDBEC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xCDDC30", Offset = "0xCDDC30", VA = "0xCDDC30")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xCDDC74", Offset = "0xCDDC74", VA = "0xCDDC74")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xCDDCB8", Offset = "0xCDDCB8", VA = "0xCDDCB8")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xCDDD50", Offset = "0xCDDD50", VA = "0xCDDD50")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xCDDD6C", Offset = "0xCDDD6C", VA = "0xCDDD6C")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xCDDD98", Offset = "0xCDDD98", VA = "0xCDDD98")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xCDDDC4", Offset = "0xCDDDC4", VA = "0xCDDDC4")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xCDDE00", Offset = "0xCDDE00", VA = "0xCDDE00")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xCDDE40", Offset = "0xCDDE40", VA = "0xCDDE40")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xCDDE60", Offset = "0xCDDE60", VA = "0xCDDE60")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xCDDE80", Offset = "0xCDDE80", VA = "0xCDDE80")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xCDDEA4", Offset = "0xCDDEA4", VA = "0xCDDEA4")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xCDDECC", Offset = "0xCDDECC", VA = "0xCDDECC")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xCDDEF4", Offset = "0xCDDEF4", VA = "0xCDDEF4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xCDDCD4", Offset = "0xCDDCD4", VA = "0xCDDCD4")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xCDDF18", Offset = "0xCDDF18", VA = "0xCDDF18")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xCDDF24", Offset = "0xCDDF24", VA = "0xCDDF24")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xCDDF30", Offset = "0xCDDF30", VA = "0xCDDF30")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xCDE1E4", Offset = "0xCDE1E4", VA = "0xCDE1E4", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xCDE2D4", Offset = "0xCDE2D4", VA = "0xCDE2D4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xCDE620", Offset = "0xCDE620", VA = "0xCDE620", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xCDEA8C", Offset = "0xCDEA8C", VA = "0xCDEA8C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xCDEAB0", Offset = "0xCDEAB0", VA = "0xCDEAB0")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000019")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xCDE06C", Offset = "0xCDE06C", VA = "0xCDE06C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xCDED4C", Offset = "0xCDED4C", VA = "0xCDED4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xCDE484", Offset = "0xCDE484", VA = "0xCDE484")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xCDEB60", Offset = "0xCDEB60", VA = "0xCDEB60")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public abstract class Constraint
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700001B")]
		public bool isValid
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xCDEF74", Offset = "0xCDEF74", VA = "0xCDEF74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016F")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xCDEFD4", Offset = "0xCDEFD4", VA = "0xCDEFD4")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xCDEFDC", Offset = "0xCDEFDC", VA = "0xCDEFDC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xCDF074", Offset = "0xCDF074", VA = "0xCDF074")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xCDF07C", Offset = "0xCDF07C", VA = "0xCDF07C")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x1700001C")]
		private bool positionChanged
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xCDF1B0", Offset = "0xCDF1B0", VA = "0xCDF1B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xCDF0AC", Offset = "0xCDF0AC", VA = "0xCDF0AC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xCDF20C", Offset = "0xCDF20C", VA = "0xCDF20C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xCDF214", Offset = "0xCDF214", VA = "0xCDF214")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xCDF244", Offset = "0xCDF244", VA = "0xCDF244", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xCDF2C0", Offset = "0xCDF2C0", VA = "0xCDF2C0")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xCDF2C8", Offset = "0xCDF2C8", VA = "0xCDF2C8")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x1700001D")]
		private bool rotationChanged
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xCDF3FC", Offset = "0xCDF3FC", VA = "0xCDF3FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xCDF2F8", Offset = "0xCDF2F8", VA = "0xCDF2F8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xCDF454", Offset = "0xCDF454", VA = "0xCDF454")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xCDF45C", Offset = "0xCDF45C", VA = "0xCDF45C")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class Constraints
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xCDF48C", Offset = "0xCDF48C", VA = "0xCDF48C")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xCDE5A4", Offset = "0xCDE5A4", VA = "0xCDE5A4")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xCDE294", Offset = "0xCDE294", VA = "0xCDE294")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xCDE794", Offset = "0xCDE794", VA = "0xCDE794")]
		public void Update()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xCDEF6C", Offset = "0xCDEF6C", VA = "0xCDEF6C")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		public enum DOF
		{
			[Token(Token = "0x400014B")]
			One,
			[Token(Token = "0x400014C")]
			Three
		}

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		public float rotationWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x1700001E")]
		public bool initiated
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xCE04EC", Offset = "0xCE04EC", VA = "0xCE04EC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xCE04F4", Offset = "0xCE04F4", VA = "0xCE04F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xCE0500", Offset = "0xCE0500", VA = "0xCE0500")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xCE0520", Offset = "0xCE0520", VA = "0xCE0520")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xCE0540", Offset = "0xCE0540", VA = "0xCE0540")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xCE0560", Offset = "0xCE0560", VA = "0xCE0560")]
			set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xCE0580", Offset = "0xCE0580", VA = "0xCE0580")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xCE0678", Offset = "0xCE0678", VA = "0xCE0678")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xCE0D00", Offset = "0xCE0D00", VA = "0xCE0D00")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xCE0DCC", Offset = "0xCE0DCC", VA = "0xCE0DCC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xCE0E84", Offset = "0xCE0E84", VA = "0xCE0E84")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xCE1424", Offset = "0xCE1424", VA = "0xCE1424")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000021")]
		public bool initiated
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0xCE1434", Offset = "0xCE1434", VA = "0xCE1434")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xCE143C", Offset = "0xCE143C", VA = "0xCE143C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xCE1448", Offset = "0xCE1448", VA = "0xCE1448")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xCE14BC", Offset = "0xCE14BC", VA = "0xCE14BC")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xCE1834", Offset = "0xCE1834", VA = "0xCE1834")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xCE19EC", Offset = "0xCE19EC", VA = "0xCE19EC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xCE1744", Offset = "0xCE1744", VA = "0xCE1744")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xCE1B6C", Offset = "0xCE1B6C", VA = "0xCE1B6C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xCE1C14", Offset = "0xCE1C14", VA = "0xCE1C14")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xCE1C78", Offset = "0xCE1C78", VA = "0xCE1C78")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xCE1CE0", Offset = "0xCE1CE0", VA = "0xCE1CE0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xCE1D3C", Offset = "0xCE1D3C", VA = "0xCE1D3C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xCE1D40", Offset = "0xCE1D40", VA = "0xCE1D40", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xCE1D54", Offset = "0xCE1D54", VA = "0xCE1D54")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000040")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderDelegate OnPostIK;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xCE1DC0", Offset = "0xCE1DC0", VA = "0xCE1DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xCE1DC8", Offset = "0xCE1DC8", VA = "0xCE1DC8")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600019E")]
		public abstract void ResetPosition();

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xCE1DD4", Offset = "0xCE1DD4", VA = "0xCE1DD4")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xCE2084", Offset = "0xCE2084", VA = "0xCE2084")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xCE1E98", Offset = "0xCE1E98", VA = "0xCE1E98")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xCE20AC", Offset = "0xCE20AC", VA = "0xCE20AC")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A5")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60001A6")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xCE2220", Offset = "0xCE2220", VA = "0xCE2220")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 spineOffset;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float lastWeight;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xCE2524", Offset = "0xCE2524", VA = "0xCE2524", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xCE2568", Offset = "0xCE2568", VA = "0xCE2568", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xCE25AC", Offset = "0xCE25AC", VA = "0xCE25AC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xCE268C", Offset = "0xCE268C", VA = "0xCE268C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xCE272C", Offset = "0xCE272C", VA = "0xCE272C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xCE2780", Offset = "0xCE2780", VA = "0xCE2780")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xCE2DA0", Offset = "0xCE2DA0", VA = "0xCE2DA0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xCE2DE0", Offset = "0xCE2DE0", VA = "0xCE2DE0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xCE3458", Offset = "0xCE3458", VA = "0xCE3458")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xCE3580", Offset = "0xCE3580", VA = "0xCE3580")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xCE377C", Offset = "0xCE377C", VA = "0xCE377C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xCE3954", Offset = "0xCE3954", VA = "0xCE3954")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000043")]
		public class SpineEffector
		{
			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xCE47E8", Offset = "0xCE47E8", VA = "0xCE47E8")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xCE47F8", Offset = "0xCE47F8", VA = "0xCE47F8")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] feet;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool firstSolve;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xCE39F8", Offset = "0xCE39F8", VA = "0xCE39F8")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xCE3A3C", Offset = "0xCE3A3C", VA = "0xCE3A3C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xCE3A80", Offset = "0xCE3A80", VA = "0xCE3A80", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xCE3AC4", Offset = "0xCE3AC4", VA = "0xCE3AC4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xCE3B2C", Offset = "0xCE3B2C", VA = "0xCE3B2C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xCE3BB4", Offset = "0xCE3BB4", VA = "0xCE3BB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xCE3EF4", Offset = "0xCE3EF4", VA = "0xCE3EF4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xCE3F00", Offset = "0xCE3F00", VA = "0xCE3F00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xCE3C10", Offset = "0xCE3C10", VA = "0xCE3C10")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xCE3F0C", Offset = "0xCE3F0C", VA = "0xCE3F0C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xCE427C", Offset = "0xCE427C", VA = "0xCE427C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xCE4400", Offset = "0xCE4400", VA = "0xCE4400")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xCE4560", Offset = "0xCE4560", VA = "0xCE4560")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xCE457C", Offset = "0xCE457C", VA = "0xCE457C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xCE4744", Offset = "0xCE4744", VA = "0xCE4744")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IK[] legs;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] feet;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int solvedFeet;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool solved;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float lastWeight;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xCE483C", Offset = "0xCE483C", VA = "0xCE483C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xCE4880", Offset = "0xCE4880", VA = "0xCE4880", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xCE48C4", Offset = "0xCE48C4", VA = "0xCE48C4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xCE4AB4", Offset = "0xCE4AB4", VA = "0xCE4AB4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xCE4CD4", Offset = "0xCE4CD4", VA = "0xCE4CD4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xCE4DB4", Offset = "0xCE4DB4", VA = "0xCE4DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xCE54A0", Offset = "0xCE54A0", VA = "0xCE54A0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xCE5958", Offset = "0xCE5958", VA = "0xCE5958")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xCE5B04", Offset = "0xCE5B04", VA = "0xCE5B04")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xCE5E8C", Offset = "0xCE5E8C", VA = "0xCE5E8C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xCE6090", Offset = "0xCE6090", VA = "0xCE6090")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xCE62B8", Offset = "0xCE62B8", VA = "0xCE62B8")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000046")]
		public struct Foot
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xCE7000", Offset = "0xCE7000", VA = "0xCE7000")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("The head (optional, if you intend to maintain its rotation).")]
		public Transform head;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] legs;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IK[] forelegs;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Foot[] feet;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int solvedFeet;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool solved;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float angle;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Quaternion headRotation;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float lastWeight;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xCE635C", Offset = "0xCE635C", VA = "0xCE635C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xCE63A0", Offset = "0xCE63A0", VA = "0xCE63A0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xCE63E4", Offset = "0xCE63E4", VA = "0xCE63E4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xCE6560", Offset = "0xCE6560", VA = "0xCE6560")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xCE6664", Offset = "0xCE6664", VA = "0xCE6664")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xCE685C", Offset = "0xCE685C", VA = "0xCE685C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xCE68C0", Offset = "0xCE68C0", VA = "0xCE68C0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xCE6918", Offset = "0xCE6918", VA = "0xCE6918")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xCE6C64", Offset = "0xCE6C64", VA = "0xCE6C64")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xCE7060", Offset = "0xCE7060", VA = "0xCE7060")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xCE70F0", Offset = "0xCE70F0", VA = "0xCE70F0")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xCE7540", Offset = "0xCE7540", VA = "0xCE7540")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xCE7C04", Offset = "0xCE7C04", VA = "0xCE7C04")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xCE7EBC", Offset = "0xCE7EBC", VA = "0xCE7EBC")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xCE7FF0", Offset = "0xCE7FF0", VA = "0xCE7FF0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xCE82E8", Offset = "0xCE82E8", VA = "0xCE82E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xCE8318", Offset = "0xCE8318", VA = "0xCE8318")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xCE8538", Offset = "0xCE8538", VA = "0xCE8538")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000048")]
		public enum Quality
		{
			[Token(Token = "0x40001B4")]
			Fastest,
			[Token(Token = "0x40001B5")]
			Simple,
			[Token(Token = "0x40001B6")]
			Best
		}

		[Token(Token = "0x2000049")]
		public delegate bool OnRaycastDelegate(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x200004A")]
		public delegate bool OnCapsuleCastDelegate(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x200004B")]
		public delegate bool OnSphereCastDelegate(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

		[Token(Token = "0x200004C")]
		public class Leg
		{
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x1700002B")]
			public bool isGrounded
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0xCEA3B4", Offset = "0xCEA3B4", VA = "0xCEA3B4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600020D")]
				[Address(RVA = "0xCEA3BC", Offset = "0xCEA3BC", VA = "0xCEA3BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0xCEA3C8", Offset = "0xCEA3C8", VA = "0xCEA3C8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600020F")]
				[Address(RVA = "0xCEA3D4", Offset = "0xCEA3D4", VA = "0xCEA3D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool initiated
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0xCEA3E0", Offset = "0xCEA3E0", VA = "0xCEA3E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000211")]
				[Address(RVA = "0xCEA3E8", Offset = "0xCEA3E8", VA = "0xCEA3E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0xCEA3F4", Offset = "0xCEA3F4", VA = "0xCEA3F4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000213")]
				[Address(RVA = "0xCEA3FC", Offset = "0xCEA3FC", VA = "0xCEA3FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0xCEA404", Offset = "0xCEA404", VA = "0xCEA404")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000215")]
				[Address(RVA = "0xCEA410", Offset = "0xCEA410", VA = "0xCEA410")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public Transform transform
			{
				[Token(Token = "0x6000216")]
				[Address(RVA = "0xCEA41C", Offset = "0xCEA41C", VA = "0xCEA41C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000217")]
				[Address(RVA = "0xCEA424", Offset = "0xCEA424", VA = "0xCEA424")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public float IKOffset
			{
				[Token(Token = "0x6000218")]
				[Address(RVA = "0xCEA42C", Offset = "0xCEA42C", VA = "0xCEA42C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000219")]
				[Address(RVA = "0xCEA434", Offset = "0xCEA434", VA = "0xCEA434")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0xCEA43C", Offset = "0xCEA43C", VA = "0xCEA43C")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600021B")]
				[Address(RVA = "0xCEA454", Offset = "0xCEA454", VA = "0xCEA454")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x600021C")]
				[Address(RVA = "0xCEA474", Offset = "0xCEA474", VA = "0xCEA474")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x600021D")]
				[Address(RVA = "0xCEA48C", Offset = "0xCEA48C", VA = "0xCEA48C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x600021E")]
				[Address(RVA = "0xCEA4AC", Offset = "0xCEA4AC", VA = "0xCEA4AC")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000035")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000224")]
				[Address(RVA = "0xCEAD68", Offset = "0xCEAD68", VA = "0xCEAD68")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000036")]
			private float rootYOffset
			{
				[Token(Token = "0x600022D")]
				[Address(RVA = "0xCEAEB8", Offset = "0xCEAEB8", VA = "0xCEAEB8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0xCEA4F4", Offset = "0xCEA4F4", VA = "0xCEA4F4")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xCE8B30", Offset = "0xCE8B30", VA = "0xCE8B30")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0xCEA508", Offset = "0xCEA508", VA = "0xCEA508")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0xCE9844", Offset = "0xCE9844", VA = "0xCE9844")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0xCE8C44", Offset = "0xCE8C44", VA = "0xCE8C44")]
			public void Process()
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0xCEA994", Offset = "0xCEA994", VA = "0xCEA994")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0xCEA548", Offset = "0xCEA548", VA = "0xCEA548")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x6000227")]
			[Address(RVA = "0xCEADFC", Offset = "0xCEADFC", VA = "0xCEADFC")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0xCEA7FC", Offset = "0xCEA7FC", VA = "0xCEA7FC")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0xCEA87C", Offset = "0xCEA87C", VA = "0xCEA87C")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0xCEAE68", Offset = "0xCEAE68", VA = "0xCEAE68")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0xCEAD9C", Offset = "0xCEAD9C", VA = "0xCEAD9C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0xCEAF44", Offset = "0xCEAF44", VA = "0xCEAF44")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0xCE8A90", Offset = "0xCE8A90", VA = "0xCE8A90")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200004D")]
		public class Pelvis
		{
			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000037")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x600022F")]
				[Address(RVA = "0xCEB0F4", Offset = "0xCEB0F4", VA = "0xCEB0F4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000230")]
				[Address(RVA = "0xCEB100", Offset = "0xCEB100", VA = "0xCEB100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000038")]
			public float heightOffset
			{
				[Token(Token = "0x6000231")]
				[Address(RVA = "0xCEB10C", Offset = "0xCEB10C", VA = "0xCEB10C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000232")]
				[Address(RVA = "0xCEB114", Offset = "0xCEB114", VA = "0xCEB114")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0xCE8C08", Offset = "0xCE8C08", VA = "0xCE8C08")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0xCE97B0", Offset = "0xCE97B0", VA = "0xCE97B0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0xCEB11C", Offset = "0xCEB11C", VA = "0xCEB11C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000236")]
			[Address(RVA = "0xCE95C4", Offset = "0xCE95C4", VA = "0xCE95C4")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0xCE8B28", Offset = "0xCE8B28", VA = "0xCE8B28")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public OnRaycastDelegate Raycast;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OnCapsuleCastDelegate CapsuleCast;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public OnSphereCastDelegate SphereCast;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool initiated;

		[Token(Token = "0x17000023")]
		public Leg[] legs
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xCE863C", Offset = "0xCE863C", VA = "0xCE863C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xCE8644", Offset = "0xCE8644", VA = "0xCE8644")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0xCE864C", Offset = "0xCE864C", VA = "0xCE864C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xCE8654", Offset = "0xCE8654", VA = "0xCE8654")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool isGrounded
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0xCE865C", Offset = "0xCE865C", VA = "0xCE865C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0xCE8664", Offset = "0xCE8664", VA = "0xCE8664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform root
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0xCE8670", Offset = "0xCE8670", VA = "0xCE8670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xCE8678", Offset = "0xCE8678", VA = "0xCE8678")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xCE8680", Offset = "0xCE8680", VA = "0xCE8680")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xCE8698", Offset = "0xCE8698", VA = "0xCE8698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xCE86B8", Offset = "0xCE86B8", VA = "0xCE86B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3 up
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0xCE3518", Offset = "0xCE3518", VA = "0xCE3518")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002A")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0xCE98D8", Offset = "0xCE98D8", VA = "0xCE98D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xCE8700", Offset = "0xCE8700", VA = "0xCE8700")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xCE8988", Offset = "0xCE8988", VA = "0xCE8988")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xCE2ADC", Offset = "0xCE2ADC", VA = "0xCE2ADC")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xCE3258", Offset = "0xCE3258", VA = "0xCE3258")]
		public void Update()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xCE5328", Offset = "0xCE5328", VA = "0xCE5328")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xCE2614", Offset = "0xCE2614", VA = "0xCE2614")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xCE8C2C", Offset = "0xCE8C2C", VA = "0xCE8C2C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xCE998C", Offset = "0xCE998C", VA = "0xCE998C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xCE9A10", Offset = "0xCE9A10", VA = "0xCE9A10")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xCE9B64", Offset = "0xCE9B64", VA = "0xCE9B64")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xCE2298", Offset = "0xCE2298", VA = "0xCE2298")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xCEB170", Offset = "0xCEB170", VA = "0xCEB170", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xCEB1B4", Offset = "0xCEB1B4", VA = "0xCEB1B4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xCEB1F8", Offset = "0xCEB1F8", VA = "0xCEB1F8")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xCEB23C", Offset = "0xCEB23C", VA = "0xCEB23C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xCEB280", Offset = "0xCEB280", VA = "0xCEB280")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xCEB2C4", Offset = "0xCEB2C4", VA = "0xCEB2C4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xCEB2CC", Offset = "0xCEB2CC", VA = "0xCEB2CC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xCEB348", Offset = "0xCEB348", VA = "0xCEB348", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xCEB38C", Offset = "0xCEB38C", VA = "0xCEB38C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xCEB3D0", Offset = "0xCEB3D0", VA = "0xCEB3D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xCEB414", Offset = "0xCEB414", VA = "0xCEB414")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xCEB458", Offset = "0xCEB458", VA = "0xCEB458", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xCEB460", Offset = "0xCEB460", VA = "0xCEB460")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xCEB4D4", Offset = "0xCEB4D4", VA = "0xCEB4D4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xCEB518", Offset = "0xCEB518", VA = "0xCEB518", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xCEB55C", Offset = "0xCEB55C", VA = "0xCEB55C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xCEB5A0", Offset = "0xCEB5A0", VA = "0xCEB5A0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xCEB5E4", Offset = "0xCEB5E4", VA = "0xCEB5E4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xCEB5EC", Offset = "0xCEB5EC", VA = "0xCEB5EC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xCEB660", Offset = "0xCEB660", VA = "0xCEB660", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xCEB6A4", Offset = "0xCEB6A4", VA = "0xCEB6A4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xCEB6E8", Offset = "0xCEB6E8", VA = "0xCEB6E8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xCEB72C", Offset = "0xCEB72C", VA = "0xCEB72C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xCEB770", Offset = "0xCEB770", VA = "0xCEB770", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xCEB778", Offset = "0xCEB778", VA = "0xCEB778")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xCEB7EC", Offset = "0xCEB7EC", VA = "0xCEB7EC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xCEB830", Offset = "0xCEB830", VA = "0xCEB830", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xCEB874", Offset = "0xCEB874", VA = "0xCEB874")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xCEB8B8", Offset = "0xCEB8B8", VA = "0xCEB8B8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xCEB8FC", Offset = "0xCEB8FC", VA = "0xCEB8FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xCEB904", Offset = "0xCEB904", VA = "0xCEB904")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xCEB978", Offset = "0xCEB978", VA = "0xCEB978", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xCEB9BC", Offset = "0xCEB9BC", VA = "0xCEB9BC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xCEBA00", Offset = "0xCEBA00", VA = "0xCEBA00")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xCEBA44", Offset = "0xCEBA44", VA = "0xCEBA44")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xCEBA88", Offset = "0xCEBA88", VA = "0xCEBA88")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xCEBACC", Offset = "0xCEBACC", VA = "0xCEBACC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xCEBB10", Offset = "0xCEBB10", VA = "0xCEBB10")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xCEBB50", Offset = "0xCEBB50", VA = "0xCEBB50", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xCEBB58", Offset = "0xCEBB58", VA = "0xCEBB58")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xCEBD28", Offset = "0xCEBD28", VA = "0xCEBD28")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xCEC1E4", Offset = "0xCEC1E4", VA = "0xCEC1E4")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xCEC204", Offset = "0xCEC204", VA = "0xCEC204")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xCEC2F4", Offset = "0xCEC2F4", VA = "0xCEC2F4")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000264")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xCEC3A4", Offset = "0xCEC3A4", VA = "0xCEC3A4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xCEC41C", Offset = "0xCEC41C", VA = "0xCEC41C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xCEC48C", Offset = "0xCEC48C", VA = "0xCEC48C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000268")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000269")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xCEB340", Offset = "0xCEB340", VA = "0xCEB340")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000039")]
		private bool animatePhysics
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xCEC4DC", Offset = "0xCEC4DC", VA = "0xCEC4DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xCEC568", Offset = "0xCEC568", VA = "0xCEC568")]
		private void Start()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xCEC5CC", Offset = "0xCEC5CC", VA = "0xCEC5CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xCEC66C", Offset = "0xCEC66C", VA = "0xCEC66C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xCEC698", Offset = "0xCEC698", VA = "0xCEC698")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xCEC5F0", Offset = "0xCEC5F0", VA = "0xCEC5F0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xCEC71C", Offset = "0xCEC71C", VA = "0xCEC71C")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xCEC724", Offset = "0xCEC724", VA = "0xCEC724", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xCEC768", Offset = "0xCEC768", VA = "0xCEC768", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xCEC7AC", Offset = "0xCEC7AC", VA = "0xCEC7AC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xCEC7F0", Offset = "0xCEC7F0", VA = "0xCEC7F0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xCEC834", Offset = "0xCEC834", VA = "0xCEC834", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xCEC83C", Offset = "0xCEC83C", VA = "0xCEC83C")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xCEC8B0", Offset = "0xCEC8B0", VA = "0xCEC8B0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xCEC8F4", Offset = "0xCEC8F4", VA = "0xCEC8F4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xCEC938", Offset = "0xCEC938", VA = "0xCEC938")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xCEC97C", Offset = "0xCEC97C", VA = "0xCEC97C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xCEC9C0", Offset = "0xCEC9C0", VA = "0xCEC9C0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xCEC9C8", Offset = "0xCEC9C8", VA = "0xCEC9C8")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xCECA3C", Offset = "0xCECA3C", VA = "0xCECA3C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xCECA80", Offset = "0xCECA80", VA = "0xCECA80", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xCECAC4", Offset = "0xCECAC4", VA = "0xCECAC4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xCECB08", Offset = "0xCECB08", VA = "0xCECB08")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xCECB4C", Offset = "0xCECB4C", VA = "0xCECB4C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xCECB54", Offset = "0xCECB54", VA = "0xCECB54")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xCECBC8", Offset = "0xCECBC8", VA = "0xCECBC8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xCECC0C", Offset = "0xCECC0C", VA = "0xCECC0C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xCECC50", Offset = "0xCECC50", VA = "0xCECC50")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xCECC94", Offset = "0xCECC94", VA = "0xCECC94")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xCECCD8", Offset = "0xCECCD8", VA = "0xCECCD8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xCECCE0", Offset = "0xCECCE0", VA = "0xCECCE0")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public class References
		{
			[Token(Token = "0x40001E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[LargeHeader("Spine")]
			public Transform pelvis;

			[Token(Token = "0x40001E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[LargeHeader("Left Arm")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x40001EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftForearm;

			[Token(Token = "0x40001EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform leftHand;

			[Token(Token = "0x40001ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			[LargeHeader("Right Arm")]
			public Transform rightShoulder;

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightForearm;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("VRIK also supports armless characters.If you do not wish to use arms, leave all arm references empty.")]
			public Transform rightHand;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[LargeHeader("Left Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[LargeHeader("Right Leg")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x1700003A")]
			public bool isFilled
			{
				[Token(Token = "0x6000296")]
				[Address(RVA = "0xCED730", Offset = "0xCED730", VA = "0xCED730")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003B")]
			public bool isEmpty
			{
				[Token(Token = "0x6000297")]
				[Address(RVA = "0xCED374", Offset = "0xCED374", VA = "0xCED374")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000293")]
			[Address(RVA = "0xCEDE6C", Offset = "0xCEDE6C", VA = "0xCEDE6C")]
			public References()
			{
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0xCEDE74", Offset = "0xCEDE74", VA = "0xCEDE74")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0xCEE064", Offset = "0xCEE064", VA = "0xCEE064")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0xCECE3C", Offset = "0xCECE3C", VA = "0xCECE3C")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xCECD54", Offset = "0xCECD54", VA = "0xCECD54", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xCECD98", Offset = "0xCECD98", VA = "0xCECD98", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xCECDDC", Offset = "0xCECDDC", VA = "0xCECDDC")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xCECE20", Offset = "0xCECE20", VA = "0xCECE20")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xCED2D8", Offset = "0xCED2D8", VA = "0xCED2D8")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xCED300", Offset = "0xCED300", VA = "0xCED300", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xCED308", Offset = "0xCED308", VA = "0xCED308", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xCEDC2C", Offset = "0xCEDC2C", VA = "0xCEDC2C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xCEDDBC", Offset = "0xCEDDBC", VA = "0xCEDDBC")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xCEE5A8", Offset = "0xCEE5A8", VA = "0xCEE5A8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xCEE678", Offset = "0xCEE678", VA = "0xCEE678")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xCEE698", Offset = "0xCEE698", VA = "0xCEE698")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xCEE8EC", Offset = "0xCEE8EC", VA = "0xCEE8EC")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xCEE758", Offset = "0xCEE758", VA = "0xCEE758")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xCEE9D0", Offset = "0xCEE9D0", VA = "0xCEE9D0")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xCEEA3C", Offset = "0xCEEA3C", VA = "0xCEEA3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xCEEEEC", Offset = "0xCEEEEC", VA = "0xCEEEEC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xCEF080", Offset = "0xCEF080", VA = "0xCEF080")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xCEF1AC", Offset = "0xCEF1AC", VA = "0xCEF1AC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005F")]
		public class BendBone
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000234")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0xCF2410", Offset = "0xCF2410", VA = "0xCF2410")]
			public BendBone()
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xCF2470", Offset = "0xCF2470", VA = "0xCF2470")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xCEFAA4", Offset = "0xCEFAA4", VA = "0xCEFAA4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xCEFE74", Offset = "0xCEFE74", VA = "0xCEFE74")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		[LargeHeader("Position")]
		public float positionWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[LargeHeader("Rotation")]
		[Tooltip("The weight of rotating the head bone after solving")]
		public float rotationWeight;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Range(0f, 1f)]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		public float postStretchWeight;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xCEF1B4", Offset = "0xCEF1B4", VA = "0xCEF1B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xCEF5F4", Offset = "0xCEF5F4", VA = "0xCEF5F4")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xCEFAD0", Offset = "0xCEFAD0", VA = "0xCEFAD0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xCEFE9C", Offset = "0xCEFE9C", VA = "0xCEFE9C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xCF0798", Offset = "0xCF0798", VA = "0xCF0798")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xCF0B90", Offset = "0xCF0B90", VA = "0xCF0B90")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xCF0FA0", Offset = "0xCF0FA0", VA = "0xCF0FA0")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xCF1920", Offset = "0xCF1920", VA = "0xCF1920")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xCF04DC", Offset = "0xCF04DC", VA = "0xCF04DC")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xCF1B5C", Offset = "0xCF1B5C", VA = "0xCF1B5C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xCF1838", Offset = "0xCF1838", VA = "0xCF1838")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xCF1738", Offset = "0xCF1738", VA = "0xCF1738")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xCF1E60", Offset = "0xCF1E60", VA = "0xCF1E60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xCF21FC", Offset = "0xCF21FC", VA = "0xCF21FC")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public class ChildConstraint
		{
			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000256")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700003C")]
			public float nominalDistance
			{
				[Token(Token = "0x60002C9")]
				[Address(RVA = "0xCF47DC", Offset = "0xCF47DC", VA = "0xCF47DC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0xCF47E4", Offset = "0xCF47E4", VA = "0xCF47E4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public bool isRigid
			{
				[Token(Token = "0x60002CB")]
				[Address(RVA = "0xCF47EC", Offset = "0xCF47EC", VA = "0xCF47EC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002CC")]
				[Address(RVA = "0xCF47F4", Offset = "0xCF47F4", VA = "0xCF47F4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0xCF4800", Offset = "0xCF4800", VA = "0xCF4800")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xCF485C", Offset = "0xCF485C", VA = "0xCF485C")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0xCF49BC", Offset = "0xCF49BC", VA = "0xCF49BC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0xCF4BA0", Offset = "0xCF4BA0", VA = "0xCF4BA0")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		public enum Smoothing
		{
			[Token(Token = "0x4000258")]
			None,
			[Token(Token = "0x4000259")]
			Exponential,
			[Token(Token = "0x400025A")]
			Cubic
		}

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400024C")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xCF24F8", Offset = "0xCF24F8", VA = "0xCF24F8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xCF2628", Offset = "0xCF2628", VA = "0xCF2628")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xCF279C", Offset = "0xCF279C", VA = "0xCF279C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xCF28CC", Offset = "0xCF28CC", VA = "0xCF28CC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xCF2988", Offset = "0xCF2988", VA = "0xCF2988")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xCF2AA4", Offset = "0xCF2AA4", VA = "0xCF2AA4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xCF31F4", Offset = "0xCF31F4", VA = "0xCF31F4")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xCF2C2C", Offset = "0xCF2C2C", VA = "0xCF2C2C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xCF35DC", Offset = "0xCF35DC", VA = "0xCF35DC")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xCF3870", Offset = "0xCF3870", VA = "0xCF3870")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xCF3B40", Offset = "0xCF3B40", VA = "0xCF3B40")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xCF3EDC", Offset = "0xCF3EDC", VA = "0xCF3EDC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xCF43D8", Offset = "0xCF43D8", VA = "0xCF43D8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xCF45D8", Offset = "0xCF45D8", VA = "0xCF45D8")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xCF42C4", Offset = "0xCF42C4", VA = "0xCF42C4")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xCF3D7C", Offset = "0xCF3D7C", VA = "0xCF3D7C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xCF425C", Offset = "0xCF425C", VA = "0xCF425C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xCF46B4", Offset = "0xCF46B4", VA = "0xCF46B4")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xCF4188", Offset = "0xCF4188", VA = "0xCF4188")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xCF44DC", Offset = "0xCF44DC", VA = "0xCF44DC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x1700003E")]
		public bool initiated
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xCF4FB4", Offset = "0xCF4FB4", VA = "0xCF4FB4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xCF4FBC", Offset = "0xCF4FBC", VA = "0xCF4FBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xCF4DDC", Offset = "0xCF4DDC", VA = "0xCF4DDC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xCF4FC8", Offset = "0xCF4FC8", VA = "0xCF4FC8")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xCF5034", Offset = "0xCF5034", VA = "0xCF5034")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xCF50C8", Offset = "0xCF50C8", VA = "0xCF50C8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xCF510C", Offset = "0xCF510C", VA = "0xCF510C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xCF5514", Offset = "0xCF5514", VA = "0xCF5514")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xCF5868", Offset = "0xCF5868", VA = "0xCF5868")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xCF5C30", Offset = "0xCF5C30", VA = "0xCF5C30")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xCF53DC", Offset = "0xCF53DC", VA = "0xCF53DC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xCF5478", Offset = "0xCF5478", VA = "0xCF5478")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKEffector
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x1700003F")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xCF62F4", Offset = "0xCF62F4", VA = "0xCF62F4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xCF62FC", Offset = "0xCF62FC", VA = "0xCF62FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xCF6298", Offset = "0xCF6298", VA = "0xCF6298")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xCF6308", Offset = "0xCF6308", VA = "0xCF6308")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xCF638C", Offset = "0xCF638C", VA = "0xCF638C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xCF655C", Offset = "0xCF655C", VA = "0xCF655C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xCF6768", Offset = "0xCF6768", VA = "0xCF6768")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xCF6A70", Offset = "0xCF6A70", VA = "0xCF6A70")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xCF6D34", Offset = "0xCF6D34", VA = "0xCF6D34")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xCF6E4C", Offset = "0xCF6E4C", VA = "0xCF6E4C")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xCF6EE8", Offset = "0xCF6EE8", VA = "0xCF6EE8")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xCF7588", Offset = "0xCF7588", VA = "0xCF7588")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xCF75E0", Offset = "0xCF75E0", VA = "0xCF75E0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xCF77A8", Offset = "0xCF77A8", VA = "0xCF77A8")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xCF79F0", Offset = "0xCF79F0", VA = "0xCF79F0")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public class BoneMap
		{
			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000040")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002F2")]
				[Address(RVA = "0xCF7F50", Offset = "0xCF7F50", VA = "0xCF7F50")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000041")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002F5")]
				[Address(RVA = "0xCF8008", Offset = "0xCF8008", VA = "0xCF8008")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000042")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0xCF83E8", Offset = "0xCF83E8", VA = "0xCF83E8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xCF7F10", Offset = "0xCF7F10", VA = "0xCF7F10")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xCF7F80", Offset = "0xCF7F80", VA = "0xCF7F80")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xCF7FC4", Offset = "0xCF7FC4", VA = "0xCF7FC4")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xCF8018", Offset = "0xCF8018", VA = "0xCF8018")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xCF80EC", Offset = "0xCF80EC", VA = "0xCF80EC")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xCF80F4", Offset = "0xCF80F4", VA = "0xCF80F4")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xCF81C0", Offset = "0xCF81C0", VA = "0xCF81C0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xCF822C", Offset = "0xCF822C", VA = "0xCF822C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xCF82D8", Offset = "0xCF82D8", VA = "0xCF82D8")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xCF8550", Offset = "0xCF8550", VA = "0xCF8550")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xCF857C", Offset = "0xCF857C", VA = "0xCF857C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xCF85A8", Offset = "0xCF85A8", VA = "0xCF85A8")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xCF85D0", Offset = "0xCF85D0", VA = "0xCF85D0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0xCF8690", Offset = "0xCF8690", VA = "0xCF8690")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000301")]
			[Address(RVA = "0xCF8814", Offset = "0xCF8814", VA = "0xCF8814")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0xCF8838", Offset = "0xCF8838", VA = "0xCF8838")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0xCF8958", Offset = "0xCF8958", VA = "0xCF8958")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0xCF89BC", Offset = "0xCF89BC", VA = "0xCF89BC")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0xCF8B3C", Offset = "0xCF8B3C", VA = "0xCF8B3C")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0xCF8CBC", Offset = "0xCF8CBC", VA = "0xCF8CBC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000307")]
			[Address(RVA = "0xCF8D38", Offset = "0xCF8D38", VA = "0xCF8D38")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xCF8704", Offset = "0xCF8704", VA = "0xCF8704")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0xCF8E54", Offset = "0xCF8E54", VA = "0xCF8E54")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xCF7CA0", Offset = "0xCF7CA0", VA = "0xCF7CA0", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xCF7CA8", Offset = "0xCF7CA8", VA = "0xCF7CA8", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xCF7CAC", Offset = "0xCF7CAC", VA = "0xCF7CAC")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xCF7DF4", Offset = "0xCF7DF4", VA = "0xCF7DF4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xCF7F08", Offset = "0xCF7F08", VA = "0xCF7F08")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xCF8E70", Offset = "0xCF8E70", VA = "0xCF8E70", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xCF8F18", Offset = "0xCF8F18", VA = "0xCF8F18")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xCF8FA8", Offset = "0xCF8FA8", VA = "0xCF8FA8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xCF9054", Offset = "0xCF9054", VA = "0xCF9054")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xCF906C", Offset = "0xCF906C", VA = "0xCF906C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xCF9088", Offset = "0xCF9088", VA = "0xCF9088", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xCF9130", Offset = "0xCF9130", VA = "0xCF9130")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xCF9148", Offset = "0xCF9148", VA = "0xCF9148")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000069")]
		public enum BoneMapType
		{
			[Token(Token = "0x40002B2")]
			Parent,
			[Token(Token = "0x40002B3")]
			Bone1,
			[Token(Token = "0x40002B4")]
			Bone2,
			[Token(Token = "0x40002B5")]
			Bone3
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xCF916C", Offset = "0xCF916C", VA = "0xCF916C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xCF91E0", Offset = "0xCF91E0", VA = "0xCF91E0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xCF92A8", Offset = "0xCF92A8", VA = "0xCF92A8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xCF9560", Offset = "0xCF9560", VA = "0xCF9560")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xCF96AC", Offset = "0xCF96AC", VA = "0xCF96AC")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xCF9830", Offset = "0xCF9830", VA = "0xCF9830")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xCF9890", Offset = "0xCF9890", VA = "0xCF9890")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xCF9928", Offset = "0xCF9928", VA = "0xCF9928")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xCF99D0", Offset = "0xCF99D0", VA = "0xCF99D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xCF9C84", Offset = "0xCF9C84", VA = "0xCF9C84")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xCF9CE4", Offset = "0xCF9CE4", VA = "0xCF9CE4")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xCF9E28", Offset = "0xCF9E28", VA = "0xCF9E28", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xCFA154", Offset = "0xCFA154", VA = "0xCFA154")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xCFA2CC", Offset = "0xCFA2CC", VA = "0xCFA2CC")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xCFA484", Offset = "0xCFA484", VA = "0xCFA484")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xCFA4F8", Offset = "0xCFA4F8", VA = "0xCFA4F8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xCFA554", Offset = "0xCFA554", VA = "0xCFA554")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xCFA5CC", Offset = "0xCFA5CC", VA = "0xCFA5CC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xCFAC44", Offset = "0xCFAC44", VA = "0xCFAC44")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xCFAC7C", Offset = "0xCFAC7C", VA = "0xCFAC7C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xCFAEE0", Offset = "0xCFAEE0", VA = "0xCFAEE0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xCFB200", Offset = "0xCFB200", VA = "0xCFB200")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xCFB2E0", Offset = "0xCFB2E0", VA = "0xCFB2E0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xCFB394", Offset = "0xCFB394", VA = "0xCFB394")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200006C")]
		public class Point
		{
			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000341")]
			[Address(RVA = "0xCFBC70", Offset = "0xCFBC70", VA = "0xCFBC70")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xCFBCB4", Offset = "0xCFBCB4", VA = "0xCFBCB4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0xCFBD94", Offset = "0xCFBD94", VA = "0xCFBD94")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0xCFBDC0", Offset = "0xCFBDC0", VA = "0xCFBDC0")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0xCFBDEC", Offset = "0xCFBDEC", VA = "0xCFBDEC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0xCFBE30", Offset = "0xCFBE30", VA = "0xCFBE30")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0xCFBE74", Offset = "0xCFBE74", VA = "0xCFBE74")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006D")]
		public class Bone : Point
		{
			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000044")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000348")]
				[Address(RVA = "0xCFBED4", Offset = "0xCFBED4", VA = "0xCFBED4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000349")]
				[Address(RVA = "0xCFBFC4", Offset = "0xCFBFC4", VA = "0xCFBFC4")]
				set
				{
				}
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0xCFC048", Offset = "0xCFC048", VA = "0xCFC048")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0xCFC2B4", Offset = "0xCFC2B4", VA = "0xCFC2B4")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0xCFC570", Offset = "0xCFC570", VA = "0xCFC570")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0xCFC764", Offset = "0xCFC764", VA = "0xCFC764")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0xCFC78C", Offset = "0xCFC78C", VA = "0xCFC78C")]
			public Bone()
			{
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0xCFC7F8", Offset = "0xCFC7F8", VA = "0xCFC7F8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0xCFC878", Offset = "0xCFC878", VA = "0xCFC878")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006E")]
		public class Node : Point
		{
			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000351")]
			[Address(RVA = "0xCFC90C", Offset = "0xCFC90C", VA = "0xCFC90C")]
			public Node()
			{
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0xCFC910", Offset = "0xCFC910", VA = "0xCFC910")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0xCFC93C", Offset = "0xCFC93C", VA = "0xCFC93C")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200006F")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000070")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000043")]
		public bool initiated
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0xCFB87C", Offset = "0xCFB87C", VA = "0xCFB87C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xCFB884", Offset = "0xCFB884", VA = "0xCFB884")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xCFB5D0", Offset = "0xCFB5D0", VA = "0xCFB5D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xCFB644", Offset = "0xCFB644", VA = "0xCFB644")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xCFB7C8", Offset = "0xCFB7C8", VA = "0xCFB7C8")]
		public void Update()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xCFB838", Offset = "0xCFB838", VA = "0xCFB838", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xCFB844", Offset = "0xCFB844", VA = "0xCFB844")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xCFB850", Offset = "0xCFB850", VA = "0xCFB850")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xCFB858", Offset = "0xCFB858", VA = "0xCFB858")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xCFB874", Offset = "0xCFB874", VA = "0xCFB874")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000337")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000338")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000339")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600033A")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600033B")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xCFB890", Offset = "0xCFB890", VA = "0xCFB890")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xCFB8A8", Offset = "0xCFB8A8", VA = "0xCFB8A8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xCFB9CC", Offset = "0xCFB9CC", VA = "0xCFB9CC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xCFBA64", Offset = "0xCFBA64", VA = "0xCFBA64")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xCFBC58", Offset = "0xCFBC58", VA = "0xCFBC58")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000045")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xCFCD38", Offset = "0xCFCD38", VA = "0xCFCD38")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xCFCD68", Offset = "0xCFCD68", VA = "0xCFCD68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		protected override int minBones
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0xCFD9B8", Offset = "0xCFD9B8", VA = "0xCFD9B8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0xCFDEF8", Offset = "0xCFDEF8", VA = "0xCFDEF8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xCFCC00", Offset = "0xCFCC00", VA = "0xCFCC00")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xCFCD98", Offset = "0xCFCD98", VA = "0xCFCD98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xCFD024", Offset = "0xCFD024", VA = "0xCFD024", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xCFD910", Offset = "0xCFD910", VA = "0xCFD910")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xCFD5AC", Offset = "0xCFD5AC", VA = "0xCFD5AC")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xCFD9C0", Offset = "0xCFD9C0", VA = "0xCFD9C0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xCFDF58", Offset = "0xCFDF58", VA = "0xCFDF58")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xCFDFFC", Offset = "0xCFDFFC", VA = "0xCFDFFC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xCFE3A0", Offset = "0xCFE3A0", VA = "0xCFE3A0")]
		public void SetRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xCFE3A8", Offset = "0xCFE3A8", VA = "0xCFE3A8")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xCFE458", Offset = "0xCFE458", VA = "0xCFE458", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xCFE5D8", Offset = "0xCFE5D8", VA = "0xCFE5D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xCFE738", Offset = "0xCFE738", VA = "0xCFE738", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xCFE778", Offset = "0xCFE778", VA = "0xCFE778", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xCFE7C8", Offset = "0xCFE7C8", VA = "0xCFE7C8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xCFEB28", Offset = "0xCFEB28", VA = "0xCFEB28", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xCFEB48", Offset = "0xCFEB48", VA = "0xCFEB48")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xCFE820", Offset = "0xCFE820", VA = "0xCFE820")]
		private void Read()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xCFEBB0", Offset = "0xCFEBB0", VA = "0xCFEBB0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xCFED28", Offset = "0xCFED28", VA = "0xCFED28")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xCFEF1C", Offset = "0xCFEF1C", VA = "0xCFEF1C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xCFEF8C", Offset = "0xCFEF8C", VA = "0xCFEF8C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xCFEFFC", Offset = "0xCFEFFC", VA = "0xCFEFFC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xCFF2B0", Offset = "0xCFF2B0", VA = "0xCFF2B0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xCFF940", Offset = "0xCFF940", VA = "0xCFF940")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000049")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0xD00904", Offset = "0xD00904", VA = "0xD00904", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xCFF948", Offset = "0xCFF948", VA = "0xCFF948")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xCFFF28", Offset = "0xCFFF28", VA = "0xCFFF28")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xD00058", Offset = "0xD00058", VA = "0xD00058", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xD000E0", Offset = "0xD000E0", VA = "0xD000E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xD005F8", Offset = "0xD005F8", VA = "0xD005F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xD0090C", Offset = "0xD0090C", VA = "0xD0090C")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xCFFA20", Offset = "0xCFFA20", VA = "0xCFFA20")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xD00010", Offset = "0xD00010", VA = "0xD00010")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xD008BC", Offset = "0xD008BC", VA = "0xD008BC")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xCFFDBC", Offset = "0xCFFDBC", VA = "0xCFFDBC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xD00FB8", Offset = "0xD00FB8", VA = "0xD00FB8")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xD01020", Offset = "0xD01020", VA = "0xD01020")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xD010F0", Offset = "0xD010F0", VA = "0xD010F0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xD011B8", Offset = "0xD011B8", VA = "0xD011B8")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xD00370", Offset = "0xD00370", VA = "0xD00370")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xD004B4", Offset = "0xD004B4", VA = "0xD004B4")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xD012A8", Offset = "0xD012A8", VA = "0xD012A8")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xD00BA8", Offset = "0xD00BA8", VA = "0xD00BA8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xD00000", Offset = "0xD00000", VA = "0xD00000")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xD01918", Offset = "0xD01918", VA = "0xD01918")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xD01468", Offset = "0xD01468", VA = "0xD01468")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xD00A28", Offset = "0xD00A28", VA = "0xD00A28")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xD00AF8", Offset = "0xD00AF8", VA = "0xD00AF8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xD019D0", Offset = "0xD019D0", VA = "0xD019D0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xD01A6C", Offset = "0xD01A6C", VA = "0xD01A6C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xD02130", Offset = "0xD02130", VA = "0xD02130", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xD021BC", Offset = "0xD021BC", VA = "0xD021BC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xD02250", Offset = "0xD02250", VA = "0xD02250", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xD02348", Offset = "0xD02348", VA = "0xD02348")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xD023D8", Offset = "0xD023D8", VA = "0xD023D8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xD027D8", Offset = "0xD027D8", VA = "0xD027D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xD029D0", Offset = "0xD029D0", VA = "0xD029D0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xD02878", Offset = "0xD02878", VA = "0xD02878")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xD025B0", Offset = "0xD025B0", VA = "0xD025B0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xD02A54", Offset = "0xD02A54", VA = "0xD02A54")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xD02AD0", Offset = "0xD02AD0", VA = "0xD02AD0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xD02BAC", Offset = "0xD02BAC", VA = "0xD02BAC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xCF48A8", Offset = "0xCF48A8", VA = "0xCF48A8")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xCF6248", Offset = "0xCF6248", VA = "0xCF6248")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xCF5368", Offset = "0xCF5368", VA = "0xCF5368")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xD02BF4", Offset = "0xD02BF4", VA = "0xD02BF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xD02D94", Offset = "0xD02D94", VA = "0xD02D94", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xD02EF0", Offset = "0xD02EF0", VA = "0xD02EF0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xD030F0", Offset = "0xD030F0", VA = "0xD030F0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xD031C0", Offset = "0xD031C0", VA = "0xD031C0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD0329C", Offset = "0xD0329C", VA = "0xD0329C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xD033F8", Offset = "0xD033F8", VA = "0xD033F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xD03590", Offset = "0xD03590", VA = "0xD03590", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xD037B8", Offset = "0xD037B8", VA = "0xD037B8", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD03A88", Offset = "0xD03A88", VA = "0xD03A88", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD03AC0", Offset = "0xD03AC0", VA = "0xD03AC0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD03B98", Offset = "0xD03B98", VA = "0xD03B98")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400030F")]
		Body,
		[Token(Token = "0x4000310")]
		LeftShoulder,
		[Token(Token = "0x4000311")]
		RightShoulder,
		[Token(Token = "0x4000312")]
		LeftThigh,
		[Token(Token = "0x4000313")]
		RightThigh,
		[Token(Token = "0x4000314")]
		LeftHand,
		[Token(Token = "0x4000315")]
		RightHand,
		[Token(Token = "0x4000316")]
		LeftFoot,
		[Token(Token = "0x4000317")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000319")]
		LeftArm,
		[Token(Token = "0x400031A")]
		RightArm,
		[Token(Token = "0x400031B")]
		LeftLeg,
		[Token(Token = "0x400031C")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000079")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x1700004A")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xD03CEC", Offset = "0xD03CEC", VA = "0xD03CEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xD03E2C", Offset = "0xD03E2C", VA = "0xD03E2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xD03E34", Offset = "0xD03E34", VA = "0xD03E34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xD03E3C", Offset = "0xD03E3C", VA = "0xD03E3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xD03E44", Offset = "0xD03E44", VA = "0xD03E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xD03E4C", Offset = "0xD03E4C", VA = "0xD03E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xD03E54", Offset = "0xD03E54", VA = "0xD03E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0xD03E5C", Offset = "0xD03E5C", VA = "0xD03E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xD03E64", Offset = "0xD03E64", VA = "0xD03E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0xD03E6C", Offset = "0xD03E6C", VA = "0xD03E6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0xD03E98", Offset = "0xD03E98", VA = "0xD03E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xD03EC4", Offset = "0xD03EC4", VA = "0xD03EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xD03EF0", Offset = "0xD03EF0", VA = "0xD03EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0xD03F1C", Offset = "0xD03F1C", VA = "0xD03F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xD03F44", Offset = "0xD03F44", VA = "0xD03F44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0xD03F70", Offset = "0xD03F70", VA = "0xD03F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0xD03F9C", Offset = "0xD03F9C", VA = "0xD03F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xD03FC8", Offset = "0xD03FC8", VA = "0xD03FC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xD06194", Offset = "0xD06194", VA = "0xD06194")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xD061A0", Offset = "0xD061A0", VA = "0xD061A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xD03FF0", Offset = "0xD03FF0", VA = "0xD03FF0")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xD040F0", Offset = "0xD040F0", VA = "0xD040F0")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xD04040", Offset = "0xD04040", VA = "0xD04040")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD04168", Offset = "0xD04168", VA = "0xD04168")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD03CF4", Offset = "0xD03CF4", VA = "0xD03CF4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD04230", Offset = "0xD04230", VA = "0xD04230")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xD042E0", Offset = "0xD042E0", VA = "0xD042E0")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xD0438C", Offset = "0xD0438C", VA = "0xD0438C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD04438", Offset = "0xD04438", VA = "0xD04438")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD04440", Offset = "0xD04440", VA = "0xD04440")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD04468", Offset = "0xD04468", VA = "0xD04468")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xD04528", Offset = "0xD04528", VA = "0xD04528", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xD046BC", Offset = "0xD046BC", VA = "0xD046BC")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xD05A98", Offset = "0xD05A98", VA = "0xD05A98")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xD06048", Offset = "0xD06048", VA = "0xD06048")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD060A4", Offset = "0xD060A4", VA = "0xD060A4")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xD05EE8", Offset = "0xD05EE8", VA = "0xD05EE8")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xD05F98", Offset = "0xD05F98", VA = "0xD05F98")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xD061AC", Offset = "0xD061AC", VA = "0xD061AC")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xD06270", Offset = "0xD06270", VA = "0xD06270", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xD0633C", Offset = "0xD0633C", VA = "0xD0633C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xD06458", Offset = "0xD06458", VA = "0xD06458")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xD065E8", Offset = "0xD065E8", VA = "0xD065E8")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD06760", Offset = "0xD06760", VA = "0xD06760", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xD069BC", Offset = "0xD069BC", VA = "0xD069BC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xD06A34", Offset = "0xD06A34", VA = "0xD06A34")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007A")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700005D")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xD072D4", Offset = "0xD072D4", VA = "0xD072D4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xD072DC", Offset = "0xD072DC", VA = "0xD072DC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xD072E4", Offset = "0xD072E4", VA = "0xD072E4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xD07788", Offset = "0xD07788", VA = "0xD07788", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		protected float positionOffset
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xD07844", Offset = "0xD07844", VA = "0xD07844")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD06A40", Offset = "0xD06A40", VA = "0xD06A40")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD06BF0", Offset = "0xD06BF0", VA = "0xD06BF0")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD06D3C", Offset = "0xD06D3C", VA = "0xD06D3C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD06D9C", Offset = "0xD06D9C", VA = "0xD06D9C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD06E10", Offset = "0xD06E10", VA = "0xD06E10", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD071F0", Offset = "0xD071F0", VA = "0xD071F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xD071F8", Offset = "0xD071F8", VA = "0xD071F8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xD072EC", Offset = "0xD072EC", VA = "0xD072EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xD072F0", Offset = "0xD072F0", VA = "0xD072F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD072F4", Offset = "0xD072F4", VA = "0xD072F4")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD0788C", Offset = "0xD0788C", VA = "0xD0788C")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD07C44", Offset = "0xD07C44", VA = "0xD07C44")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD07ED8", Offset = "0xD07ED8", VA = "0xD07ED8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD07F4C", Offset = "0xD07F4C", VA = "0xD07F4C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD082F0", Offset = "0xD082F0", VA = "0xD082F0")]
		public void SetRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xD082F8", Offset = "0xD082F8", VA = "0xD082F8")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xD083AC", Offset = "0xD083AC", VA = "0xD083AC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD0852C", Offset = "0xD0852C", VA = "0xD0852C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xD0868C", Offset = "0xD0868C", VA = "0xD0868C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xD086DC", Offset = "0xD086DC", VA = "0xD086DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xD0873C", Offset = "0xD0873C", VA = "0xD0873C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xD08A98", Offset = "0xD08A98", VA = "0xD08A98", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xD08AB8", Offset = "0xD08AB8", VA = "0xD08AB8")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD08794", Offset = "0xD08794", VA = "0xD08794")]
		private void Read()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD08B44", Offset = "0xD08B44", VA = "0xD08B44")]
		private void Write()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD08FC8", Offset = "0xD08FC8", VA = "0xD08FC8")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		public enum BendModifier
		{
			[Token(Token = "0x4000347")]
			Animation,
			[Token(Token = "0x4000348")]
			Target,
			[Token(Token = "0x4000349")]
			Parent,
			[Token(Token = "0x400034A")]
			Arm,
			[Token(Token = "0x400034B")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public struct AxisDirection
		{
			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000405")]
			[Address(RVA = "0xD0A6E4", Offset = "0xD0A6E4", VA = "0xD0A6E4")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000062")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xD0A6C8", Offset = "0xD0A6C8", VA = "0xD0A6C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD092A4", Offset = "0xD092A4", VA = "0xD092A4")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD092E8", Offset = "0xD092E8", VA = "0xD092E8")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD09354", Offset = "0xD09354", VA = "0xD09354", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD0989C", Offset = "0xD0989C", VA = "0xD0989C", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD0A3B8", Offset = "0xD0A3B8", VA = "0xD0A3B8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD0A460", Offset = "0xD0A460", VA = "0xD0A460")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xD0A630", Offset = "0xD0A630", VA = "0xD0A630")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD096B0", Offset = "0xD096B0", VA = "0xD096B0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD09958", Offset = "0xD09958", VA = "0xD09958")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000069")]
			public Vector3 forward
			{
				[Token(Token = "0x6000425")]
				[Address(RVA = "0xD0C588", Offset = "0xD0C588", VA = "0xD0C588")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0xD0CC38", Offset = "0xD0CC38", VA = "0xD0CC38")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0xD0B6A4", Offset = "0xD0B6A4", VA = "0xD0B6A4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0xD0B998", Offset = "0xD0B998", VA = "0xD0B998")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0xD0C8D0", Offset = "0xD0C8D0", VA = "0xD0C8D0")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x17000063")]
		protected bool spineIsValid
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xD0AE28", Offset = "0xD0AE28", VA = "0xD0AE28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xD0AFD0", Offset = "0xD0AFD0", VA = "0xD0AFD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		protected bool headIsValid
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xD0AEF4", Offset = "0xD0AEF4", VA = "0xD0AEF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xD0AFF4", Offset = "0xD0AFF4", VA = "0xD0AFF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xD0AF04", Offset = "0xD0AF04", VA = "0xD0AF04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xD0B060", Offset = "0xD0B060", VA = "0xD0B060")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD0A880", Offset = "0xD0A880", VA = "0xD0A880")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD0A89C", Offset = "0xD0A89C", VA = "0xD0A89C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD0A8C8", Offset = "0xD0A8C8", VA = "0xD0A8C8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD0A900", Offset = "0xD0A900", VA = "0xD0A900")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD0A948", Offset = "0xD0A948", VA = "0xD0A948")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD0A9A0", Offset = "0xD0A9A0", VA = "0xD0A9A0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD0AA10", Offset = "0xD0AA10", VA = "0xD0AA10", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD0AB28", Offset = "0xD0AB28", VA = "0xD0AB28")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD0AB34", Offset = "0xD0AB34", VA = "0xD0AB34", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD0AC64", Offset = "0xD0AC64", VA = "0xD0AC64", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xD0B084", Offset = "0xD0B084", VA = "0xD0B084", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD0B2D8", Offset = "0xD0B2D8", VA = "0xD0B2D8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xD0B438", Offset = "0xD0B438", VA = "0xD0B438")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD0B6D4", Offset = "0xD0B6D4", VA = "0xD0B6D4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD0BA84", Offset = "0xD0BA84", VA = "0xD0BA84", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD0BB48", Offset = "0xD0BB48", VA = "0xD0BB48")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD0BD64", Offset = "0xD0BD64", VA = "0xD0BD64")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xD0C0AC", Offset = "0xD0C0AC", VA = "0xD0C0AC")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xD0C5B8", Offset = "0xD0C5B8", VA = "0xD0C5B8")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xD0B500", Offset = "0xD0B500", VA = "0xD0B500")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xD0C9D8", Offset = "0xD0C9D8", VA = "0xD0C9D8")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000082")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600043D")]
			[Address(RVA = "0xD0DF60", Offset = "0xD0DF60", VA = "0xD0DF60")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xD0E808", Offset = "0xD0E808", VA = "0xD0E808")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xD09324", Offset = "0xD09324", VA = "0xD09324")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xD0E8A4", Offset = "0xD0E8A4", VA = "0xD0E8A4")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xD0CC40", Offset = "0xD0CC40", VA = "0xD0CC40")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xD0CDD4", Offset = "0xD0CDD4", VA = "0xD0CDD4")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xD0CF54", Offset = "0xD0CF54", VA = "0xD0CF54")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xD0CF60", Offset = "0xD0CF60", VA = "0xD0CF60")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xD0CF7C", Offset = "0xD0CF7C", VA = "0xD0CF7C")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xD0CF88", Offset = "0xD0CF88", VA = "0xD0CF88")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xD0CF90", Offset = "0xD0CF90", VA = "0xD0CF90", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD0D0A0", Offset = "0xD0D0A0", VA = "0xD0D0A0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xD0D198", Offset = "0xD0D198", VA = "0xD0D198", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xD0D1D8", Offset = "0xD0D1D8", VA = "0xD0D1D8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xD0D228", Offset = "0xD0D228", VA = "0xD0D228", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xD0D5FC", Offset = "0xD0D5FC", VA = "0xD0D5FC")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xD0D678", Offset = "0xD0D678", VA = "0xD0D678")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xD0DB6C", Offset = "0xD0DB6C", VA = "0xD0DB6C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xD0DCC4", Offset = "0xD0DCC4", VA = "0xD0DCC4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xD0DE70", Offset = "0xD0DE70", VA = "0xD0DE70")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xD0DDF0", Offset = "0xD0DDF0", VA = "0xD0DDF0")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xD0E050", Offset = "0xD0E050", VA = "0xD0E050", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xD0E898", Offset = "0xD0E898", VA = "0xD0E898", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xD0E89C", Offset = "0xD0E89C", VA = "0xD0E89C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xD0E8A0", Offset = "0xD0E8A0", VA = "0xD0E8A0", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xD0E648", Offset = "0xD0E648", VA = "0xD0E648")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xD0A4E4", Offset = "0xD0A4E4", VA = "0xD0A4E4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000084")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000085")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40003B2")]
				YawPitch,
				[Token(Token = "0x40003B3")]
				FromTo
			}

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			[LargeHeader("Hand")]
			public Transform target;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[LargeHeader("Shoulder")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[ShowRangeIf(0f, 1f, "shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderTwistWeight;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the yaw (up) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderYawOffset;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the pitch (forward) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderPitchOffset;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Bending")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of the elbow bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[LargeHeader("Stretching")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("'Time' represents (target distance / arm length) and 'value' represents the amount of stretching. So value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right by the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool hasShoulder;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion chestRotation;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Vector3 chestForward;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 chestUp;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0xD144A0", Offset = "0xD144A0", VA = "0xD144A0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000461")]
				[Address(RVA = "0xD144AC", Offset = "0xD144AC", VA = "0xD144AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0xD144B8", Offset = "0xD144B8", VA = "0xD144B8")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000463")]
				[Address(RVA = "0xD144C4", Offset = "0xD144C4", VA = "0xD144C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0xD144D0", Offset = "0xD144D0", VA = "0xD144D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000465")]
				[Address(RVA = "0xD144F8", Offset = "0xD144F8", VA = "0xD144F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0xD1452C", Offset = "0xD1452C", VA = "0xD1452C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000467")]
				[Address(RVA = "0xD1456C", Offset = "0xD1456C", VA = "0xD1456C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0xD145AC", Offset = "0xD145AC", VA = "0xD145AC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0xD14F0C", Offset = "0xD14F0C", VA = "0xD14F0C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0xD151B8", Offset = "0xD151B8", VA = "0xD151B8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0xD151DC", Offset = "0xD151DC", VA = "0xD151DC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0xD12300", Offset = "0xD12300", VA = "0xD12300")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0xD15C10", Offset = "0xD15C10", VA = "0xD15C10", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0xD15C68", Offset = "0xD15C68", VA = "0xD15C68", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0xD1552C", Offset = "0xD1552C", VA = "0xD1552C")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xD155AC", Offset = "0xD155AC", VA = "0xD155AC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xD15E74", Offset = "0xD15E74", VA = "0xD15E74")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xD142F4", Offset = "0xD142F4", VA = "0xD142F4")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000072")]
			public float sqrMag
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0xD16030", Offset = "0xD16030", VA = "0xD16030")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000479")]
				[Address(RVA = "0xD16038", Offset = "0xD16038", VA = "0xD16038")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000073")]
			public float mag
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0xD16040", Offset = "0xD16040", VA = "0xD16040")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600047B")]
				[Address(RVA = "0xD16048", Offset = "0xD16048", VA = "0xD16048")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000473")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x6000474")]
			public abstract void PreSolve(float scale);

			[Token(Token = "0x6000475")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000476")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000477")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600047C")]
			[Address(RVA = "0xD16050", Offset = "0xD16050", VA = "0xD16050")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xD08F08", Offset = "0xD08F08", VA = "0xD08F08")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0xD16058", Offset = "0xD16058", VA = "0xD16058")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0xD160E0", Offset = "0xD160E0", VA = "0xD160E0")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0xD16178", Offset = "0xD16178", VA = "0xD16178")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0xD121D8", Offset = "0xD121D8", VA = "0xD121D8")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0xD15AA8", Offset = "0xD15AA8", VA = "0xD15AA8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0xD161C0", Offset = "0xD161C0", VA = "0xD161C0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0xD162E4", Offset = "0xD162E4", VA = "0xD162E4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000485")]
			[Address(RVA = "0xD15F8C", Offset = "0xD15F8C", VA = "0xD15F8C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class Footstep
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x17000074")]
			public bool isStepping
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0xD162F8", Offset = "0xD162F8", VA = "0xD162F8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			public float stepProgress
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0xD1630C", Offset = "0xD1630C", VA = "0xD1630C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000488")]
				[Address(RVA = "0xD16314", Offset = "0xD16314", VA = "0xD16314")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0xD1631C", Offset = "0xD1631C", VA = "0xD1631C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0xD164E0", Offset = "0xD164E0", VA = "0xD164E0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0xD16528", Offset = "0xD16528", VA = "0xD16528")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0xD1676C", Offset = "0xD1676C", VA = "0xD1676C")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0xD1690C", Offset = "0xD1690C", VA = "0xD1690C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0xD16B04", Offset = "0xD16B04", VA = "0xD16B04")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep, float deltaTime)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			[LargeHeader("Foot/Toe")]
			public Transform target;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			[LargeHeader("Bending")]
			public Transform bendGoal;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			[LargeHeader("Stretching")]
			public float legLengthMlp;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x17000076")]
			public Vector3 position
			{
				[Token(Token = "0x600048F")]
				[Address(RVA = "0xD16C74", Offset = "0xD16C74", VA = "0xD16C74")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000490")]
				[Address(RVA = "0xD16C80", Offset = "0xD16C80", VA = "0xD16C80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000491")]
				[Address(RVA = "0xD16C8C", Offset = "0xD16C8C", VA = "0xD16C8C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000492")]
				[Address(RVA = "0xD16C98", Offset = "0xD16C98", VA = "0xD16C98")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public bool hasToes
			{
				[Token(Token = "0x6000493")]
				[Address(RVA = "0xD16CA4", Offset = "0xD16CA4", VA = "0xD16CA4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000494")]
				[Address(RVA = "0xD16CAC", Offset = "0xD16CAC", VA = "0xD16CAC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000495")]
				[Address(RVA = "0xD16CB8", Offset = "0xD16CB8", VA = "0xD16CB8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000496")]
				[Address(RVA = "0xD16CE0", Offset = "0xD16CE0", VA = "0xD16CE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000497")]
				[Address(RVA = "0xD16D0C", Offset = "0xD16D0C", VA = "0xD16D0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000498")]
				[Address(RVA = "0xD16D38", Offset = "0xD16D38", VA = "0xD16D38")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0xD121A4", Offset = "0xD121A4", VA = "0xD121A4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600049A")]
				[Address(RVA = "0xD16D64", Offset = "0xD16D64", VA = "0xD16D64")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049B")]
				[Address(RVA = "0xD16D70", Offset = "0xD16D70", VA = "0xD16D70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0xD16D7C", Offset = "0xD16D7C", VA = "0xD16D7C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049D")]
				[Address(RVA = "0xD16D8C", Offset = "0xD16D8C", VA = "0xD16D8C")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x600049E")]
				[Address(RVA = "0xD16D9C", Offset = "0xD16D9C", VA = "0xD16D9C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600049F")]
				[Address(RVA = "0xD16DAC", Offset = "0xD16DAC", VA = "0xD16DAC")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xD16DBC", Offset = "0xD16DBC", VA = "0xD16DBC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xD1736C", Offset = "0xD1736C", VA = "0xD1736C", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xD17B9C", Offset = "0xD17B9C", VA = "0xD17B9C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xD17B4C", Offset = "0xD17B4C", VA = "0xD17B4C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xD17900", Offset = "0xD17900", VA = "0xD17900")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xD08CBC", Offset = "0xD08CBC", VA = "0xD08CBC")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xD18410", Offset = "0xD18410", VA = "0xD18410")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xD18078", Offset = "0xD18078", VA = "0xD18078")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xD18868", Offset = "0xD18868", VA = "0xD18868", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xD18A70", Offset = "0xD18A70", VA = "0xD18A70", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xD091BC", Offset = "0xD091BC", VA = "0xD091BC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class Locomotion
		{
			[Serializable]
			[Token(Token = "0x200008A")]
			public enum Mode
			{
				[Token(Token = "0x400042C")]
				Procedural,
				[Token(Token = "0x400042D")]
				Animated
			}

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Procedural (legacy) or animated locomotion.")]
			public Mode mode;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Used for blending in/out of procedural/animated locomotion.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Start moving (horizontal distance to HMD + HMD velocity) threshold.")]
			public float moveThreshold;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[ShowLargeHeaderIf("Animation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			private byte animationHeader;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Minimum locomotion animation speed.")]
			[ShowRangeIf(0.1f, 1f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float minAnimationSpeed;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum locomotion animation speed.")]
			[ShowRangeIf(1f, 10f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxAnimationSpeed;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Smoothing time for Vector3.SmoothDamping 'VRIK_Horizontal' and 'VRIK_Vertical' parameters. Larger values make animation smoother, but less responsive.")]
			[ShowRangeIf(0.05f, 0.2f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float animationSmoothTime;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[ShowLargeHeaderIf("Root Position", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte rootPositionHeader;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("X and Z standing offset from the horizontal position of the HMD.")]
			public Vector2 standOffset;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while moving.")]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while in transition from locomotion to idle state.")]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while turning on spot.")]
			public float rootLerpSpeedWhileTurning;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Max horizontal distance from the root to the HMD.")]
			public float maxRootOffset;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[ShowLargeHeaderIf("Root Rotation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
			private byte rootRotationHeader;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Tooltip("Max root angle from head forward while moving (ik.solver.spine.maxRootAngle).")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleMoving;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Max root angle from head forward while standing (ik.solver.spine.maxRootAngle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleStanding;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			[SerializeField]
			public float stepLengthMlp;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Animator animator;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 velocityLocal;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private Vector3 velocityLocalV;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private Vector3 lastCorrection;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 lastHeadTargetPos;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Vector3 lastSpeedRootPos;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private Vector3 lastEndRootPos;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float rootLerpSpeed;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float rootVelocityV;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private float animSpeed;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private float animSpeedV;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float stopMoveTimer;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float turn;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private float maxRootAngleV;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private float currentAnimationSmoothTime;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private bool isMoving;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
			private bool firstFrame;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int VRIK_Horizontal;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private static int VRIK_Vertical;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static int VRIK_IsMoving;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private static int VRIK_Speed;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static int VRIK_Turn;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private static bool isHashed;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private float lastVelLocalMag;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[ShowRangeIf(0.9f, 1f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			public float maxLegStretch;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[Tooltip("The speed of moving a foot to the next position.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float stepSpeed;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxBodyYOffset;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[Tooltip("Offset for the approximated center of mass.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public Vector3 offset;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[SerializeField]
			[HideInInspector]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[SerializeField]
			[HideInInspector]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private int leftFootIndex;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private int rightFootIndex;

			[Token(Token = "0x17000081")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60004B6")]
				[Address(RVA = "0xD1A8BC", Offset = "0xD1A8BC", VA = "0xD1A8BC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004B7")]
				[Address(RVA = "0xD1A8CC", Offset = "0xD1A8CC", VA = "0xD1A8CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60004BE")]
				[Address(RVA = "0xD1C1F8", Offset = "0xD1C1F8", VA = "0xD1C1F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0xD1C22C", Offset = "0xD1C22C", VA = "0xD1C22C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000084")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0xD1C264", Offset = "0xD1C264", VA = "0xD1C264")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000085")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0xD1C298", Offset = "0xD1C298", VA = "0xD1C298")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xD18B50", Offset = "0xD18B50", VA = "0xD18B50")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xD18FA0", Offset = "0xD18FA0", VA = "0xD18FA0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xD19404", Offset = "0xD19404", VA = "0xD19404")]
			public void Relax()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xD19454", Offset = "0xD19454", VA = "0xD19454")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xD1999C", Offset = "0xD1999C", VA = "0xD1999C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xD18EC4", Offset = "0xD18EC4", VA = "0xD18EC4")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xD19AE4", Offset = "0xD19AE4", VA = "0xD19AE4")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xD191BC", Offset = "0xD191BC", VA = "0xD191BC")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xD19894", Offset = "0xD19894", VA = "0xD19894")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0xD19A94", Offset = "0xD19A94", VA = "0xD19A94")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xD19B9C", Offset = "0xD19B9C", VA = "0xD19B9C")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xD18B90", Offset = "0xD18B90", VA = "0xD18B90")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xD18FC8", Offset = "0xD18FC8", VA = "0xD18FC8")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xD19408", Offset = "0xD19408", VA = "0xD19408")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xD194C4", Offset = "0xD194C4", VA = "0xD194C4")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xD199DC", Offset = "0xD199DC", VA = "0xD199DC")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xD1A8DC", Offset = "0xD1A8DC", VA = "0xD1A8DC")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xD1BE00", Offset = "0xD1BE00", VA = "0xD1BE00")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xD1BFB8", Offset = "0xD1BFB8", VA = "0xD1BFB8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xD1C048", Offset = "0xD1C048", VA = "0xD1C048")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xD1C2D0", Offset = "0xD1C2D0", VA = "0xD1C2D0")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[LargeHeader("Head")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust its position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Allows for more natural locomotion animation for 3rd person networked avatars by inheriting vertical head bob motion from the animation while head target height is close to head bone height.")]
			[Range(0f, 1f)]
			public float useAnimatedHeadHeightWeight;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("If abs(head target height - head bone height) < this value, will use head bone height as head target Y.")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Falloff range for the 'Use Animated Head Height Range' effect above. If head target height from head bone height is greater than useAnimatedHeadHeightRange + animatedHeadHeightBlend, then the head will be vertically locked to the head target again.")]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Pelvis")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain its animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			[LargeHeader("Chest")]
			public Transform chestGoal;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[LargeHeader("Spine")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[LargeHeader("Root Rotation")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[HideInInspector]
			internal Vector3 headPosition;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
			private Quaternion headRotation;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int pelvisIndex;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int spineIndex;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int chestIndex;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private int neckIndex;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private int headIndex;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float length;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private bool hasChest;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
			private bool hasNeck;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21A")]
			private bool hasLegs;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private float headHeight;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
			private float sizeMlp;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
			private Vector3 chestForward;

			[Token(Token = "0x17000086")]
			internal VirtualBone pelvis
			{
				[Token(Token = "0x60004C6")]
				[Address(RVA = "0xD1BD98", Offset = "0xD1BD98", VA = "0xD1BD98")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60004C7")]
				[Address(RVA = "0xD1C444", Offset = "0xD1C444", VA = "0xD1C444")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60004C8")]
				[Address(RVA = "0xD1C478", Offset = "0xD1C478", VA = "0xD1C478")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			internal VirtualBone head
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0xD1BDCC", Offset = "0xD1BDCC", VA = "0xD1BDCC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0xD1C4C0", Offset = "0xD1C4C0", VA = "0xD1C4C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0xD1C4F4", Offset = "0xD1C4F4", VA = "0xD1C4F4")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0xD1C508", Offset = "0xD1C508", VA = "0xD1C508")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0xD1C51C", Offset = "0xD1C51C", VA = "0xD1C51C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004CE")]
				[Address(RVA = "0xD1C530", Offset = "0xD1C530", VA = "0xD1C530")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xD1C544", Offset = "0xD1C544", VA = "0xD1C544", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xD1D274", Offset = "0xD1D274", VA = "0xD1D274", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xD1D680", Offset = "0xD1D680", VA = "0xD1D680", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0xD1DE24", Offset = "0xD1DE24", VA = "0xD1DE24")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xD1E47C", Offset = "0xD1E47C", VA = "0xD1E47C")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xD1EEE4", Offset = "0xD1EEE4", VA = "0xD1EEE4")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xD1F690", Offset = "0xD1F690", VA = "0xD1F690")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xD20054", Offset = "0xD20054", VA = "0xD20054", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xD20224", Offset = "0xD20224", VA = "0xD20224", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xD1E084", Offset = "0xD1E084", VA = "0xD1E084")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xD1F3B8", Offset = "0xD1F3B8", VA = "0xD1F3B8")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xD1EAC4", Offset = "0xD1EAC4", VA = "0xD1EAC4")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xD202F8", Offset = "0xD202F8", VA = "0xD202F8")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xD1F494", Offset = "0xD1F494", VA = "0xD1F494")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xD1F148", Offset = "0xD1F148", VA = "0xD1F148")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xD20718", Offset = "0xD20718", VA = "0xD20718")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000468")]
			Pelvis,
			[Token(Token = "0x4000469")]
			Chest,
			[Token(Token = "0x400046A")]
			Head,
			[Token(Token = "0x400046B")]
			LeftHand,
			[Token(Token = "0x400046C")]
			RightHand,
			[Token(Token = "0x400046D")]
			LeftFoot,
			[Token(Token = "0x400046E")]
			RightFoot,
			[Token(Token = "0x400046F")]
			LeftHeel,
			[Token(Token = "0x4000470")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000472")]
			Pelvis,
			[Token(Token = "0x4000473")]
			Chest,
			[Token(Token = "0x4000474")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public class VirtualBone
		{
			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xD1D1E4", Offset = "0xD1D1E4", VA = "0xD1D1E4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xD1D254", Offset = "0xD1D254", VA = "0xD1D254")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xD2084C", Offset = "0xD2084C", VA = "0xD2084C")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xD20A4C", Offset = "0xD20A4C", VA = "0xD20A4C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xD205A8", Offset = "0xD205A8", VA = "0xD205A8")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xD20BAC", Offset = "0xD20BAC", VA = "0xD20BAC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xD20D54", Offset = "0xD20D54", VA = "0xD20D54")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xD20EDC", Offset = "0xD20EDC", VA = "0xD20EDC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xD1FC70", Offset = "0xD1FC70", VA = "0xD1FC70")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xD20F80", Offset = "0xD20F80", VA = "0xD20F80")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xD1F8A4", Offset = "0xD1F8A4", VA = "0xD1F8A4")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xD210D8", Offset = "0xD210D8", VA = "0xD210D8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xD211EC", Offset = "0xD211EC", VA = "0xD211EC")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool hasChest;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool hasNeck;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool hasShoulders;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool hasToes;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool hasLegs;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool hasArms;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int lastLOD;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float lastLocomotionWeight;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Leg[] legs;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Arm[] arms;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 headPosition;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 debugPos4;

		[Token(Token = "0x1700006A")]
		public Animator animator
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xD0E8AC", Offset = "0xD0E8AC", VA = "0xD0E8AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xD0E8B4", Offset = "0xD0E8B4", VA = "0xD0E8B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0xD13FF4", Offset = "0xD13FF4", VA = "0xD13FF4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xD13FFC", Offset = "0xD13FFC", VA = "0xD13FFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xD0E8BC", Offset = "0xD0E8BC", VA = "0xD0E8BC")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xD0ED88", Offset = "0xD0ED88", VA = "0xD0ED88")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xD0EC1C", Offset = "0xD0EC1C", VA = "0xD0EC1C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xD0F19C", Offset = "0xD0F19C", VA = "0xD0F19C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xD0F2E4", Offset = "0xD0F2E4", VA = "0xD0F2E4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xD0F324", Offset = "0xD0F324", VA = "0xD0F324")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xD0F448", Offset = "0xD0F448", VA = "0xD0F448")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xD0F524", Offset = "0xD0F524", VA = "0xD0F524")]
		public void Reset()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xD0FD14", Offset = "0xD0FD14", VA = "0xD0FD14", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xD0FE68", Offset = "0xD0FE68", VA = "0xD0FE68", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xD10054", Offset = "0xD10054", VA = "0xD10054", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xD100C4", Offset = "0xD100C4", VA = "0xD100C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xD10134", Offset = "0xD10134", VA = "0xD10134", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xD1033C", Offset = "0xD1033C", VA = "0xD1033C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xD0F088", Offset = "0xD0F088", VA = "0xD0F088")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xD0F640", Offset = "0xD0F640", VA = "0xD0F640")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xD105AC", Offset = "0xD105AC", VA = "0xD105AC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xD105F0", Offset = "0xD105F0", VA = "0xD105F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xD11CDC", Offset = "0xD11CDC", VA = "0xD11CDC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xD0F790", Offset = "0xD0F790", VA = "0xD0F790")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xD10A0C", Offset = "0xD10A0C", VA = "0xD10A0C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xD12130", Offset = "0xD12130", VA = "0xD12130")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xD1216C", Offset = "0xD1216C", VA = "0xD1216C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xD11B98", Offset = "0xD11B98", VA = "0xD11B98")]
		private void Write()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xD13910", Offset = "0xD13910", VA = "0xD13910")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xD14004", Offset = "0xD14004", VA = "0xD14004")]
		public void updateHasLeg(VRIK.References vrRef)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xD14008", Offset = "0xD14008", VA = "0xD14008")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xD213A0", Offset = "0xD213A0", VA = "0xD213A0")]
		public void Start()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xD21ADC", Offset = "0xD21ADC", VA = "0xD21ADC")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xD21C48", Offset = "0xD21C48", VA = "0xD21C48")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xD222C4", Offset = "0xD222C4", VA = "0xD222C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xD22374", Offset = "0xD22374", VA = "0xD22374")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xD224AC", Offset = "0xD224AC", VA = "0xD224AC")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class TwistSolver
	{
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		public float weight;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultChildLocalRotations;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xD22510", Offset = "0xD22510", VA = "0xD22510")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xD22640", Offset = "0xD22640", VA = "0xD22640")]
		public TwistSolver(Transform t)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xD21588", Offset = "0xD21588", VA = "0xD21588")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xD21B9C", Offset = "0xD21B9C", VA = "0xD21B9C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xD21CF8", Offset = "0xD21CF8", VA = "0xD21CF8")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class InteractionEffector
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float defaultPoserWeight;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float resetTimer;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool positionWeightUsed;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool pullUsed;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool reachUsed;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool pushUsed;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pushParentUsed;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool poserUsed;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool pickedUp;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool defaults;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x1700008D")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xD2278C", Offset = "0xD2278C", VA = "0xD2278C")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xD22794", Offset = "0xD22794", VA = "0xD22794")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool isPaused
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xD2279C", Offset = "0xD2279C", VA = "0xD2279C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xD227A4", Offset = "0xD227A4", VA = "0xD227A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xD227B0", Offset = "0xD227B0", VA = "0xD227B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xD227B8", Offset = "0xD227B8", VA = "0xD227B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool inInteraction
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xD227C0", Offset = "0xD227C0", VA = "0xD227C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public float progress
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xD24C3C", Offset = "0xD24C3C", VA = "0xD24C3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xD22820", Offset = "0xD22820", VA = "0xD22820")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xD228BC", Offset = "0xD228BC", VA = "0xD228BC")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xD22974", Offset = "0xD22974", VA = "0xD22974")]
		public void StoreDefaults()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xD22B74", Offset = "0xD22B74", VA = "0xD22B74")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xD22F44", Offset = "0xD22F44", VA = "0xD22F44")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xD23064", Offset = "0xD23064", VA = "0xD23064")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xD230B8", Offset = "0xD230B8", VA = "0xD230B8")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xD232DC", Offset = "0xD232DC", VA = "0xD232DC")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xD23870", Offset = "0xD23870", VA = "0xD23870")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xD24424", Offset = "0xD24424", VA = "0xD24424")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xD24644", Offset = "0xD24644", VA = "0xD24644")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xD24B20", Offset = "0xD24B20", VA = "0xD24B20")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xD24DB0", Offset = "0xD24DB0", VA = "0xD24DB0")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xD25078", Offset = "0xD25078", VA = "0xD25078")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xD25194", Offset = "0xD25194", VA = "0xD25194")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xD2522C", Offset = "0xD2522C", VA = "0xD2522C")]
		public void Update()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xD25434", Offset = "0xD25434", VA = "0xD25434")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xD254DC", Offset = "0xD254DC", VA = "0xD254DC")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xD25588", Offset = "0xD25588", VA = "0xD25588")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000094")]
		public class InteractionEvent
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x600052E")]
			[Address(RVA = "0xD24C6C", Offset = "0xD24C6C", VA = "0xD24C6C")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0xD2646C", Offset = "0xD2646C", VA = "0xD2646C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class Message
		{
			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x40004CB")]
			private const string empty = "";

			[Token(Token = "0x6000530")]
			[Address(RVA = "0xD26374", Offset = "0xD26374", VA = "0xD26374")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0xD26474", Offset = "0xD26474", VA = "0xD26474")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40004D2")]
			private const string empty = "";

			[Token(Token = "0x6000532")]
			[Address(RVA = "0xD26298", Offset = "0xD26298", VA = "0xD26298")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0xD2647C", Offset = "0xD2647C", VA = "0xD2647C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0xD2652C", Offset = "0xD2652C", VA = "0xD2652C")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0xD26604", Offset = "0xD26604", VA = "0xD26604")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000098")]
			public enum Type
			{
				[Token(Token = "0x40004D6")]
				PositionWeight,
				[Token(Token = "0x40004D7")]
				RotationWeight,
				[Token(Token = "0x40004D8")]
				PositionOffsetX,
				[Token(Token = "0x40004D9")]
				PositionOffsetY,
				[Token(Token = "0x40004DA")]
				PositionOffsetZ,
				[Token(Token = "0x40004DB")]
				Pull,
				[Token(Token = "0x40004DC")]
				Reach,
				[Token(Token = "0x40004DD")]
				RotateBoneWeight,
				[Token(Token = "0x40004DE")]
				Push,
				[Token(Token = "0x40004DF")]
				PushParent,
				[Token(Token = "0x40004E0")]
				PoserWeight,
				[Token(Token = "0x40004E1")]
				BendGoalWeight
			}

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x6000536")]
			[Address(RVA = "0xD25BD0", Offset = "0xD25BD0", VA = "0xD25BD0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0xD26618", Offset = "0xD26618", VA = "0xD26618")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class Multiplier
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x6000538")]
			[Address(RVA = "0xD261A4", Offset = "0xD261A4", VA = "0xD261A4")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0xD26620", Offset = "0xD26620", VA = "0xD26620")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000092")]
		public float length
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0xD257BC", Offset = "0xD257BC", VA = "0xD257BC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xD257C4", Offset = "0xD257C4", VA = "0xD257C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600051C")]
			[Address(RVA = "0xD257CC", Offset = "0xD257CC", VA = "0xD257CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600051D")]
			[Address(RVA = "0xD257D4", Offset = "0xD257D4", VA = "0xD257D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0xD25994", Offset = "0xD25994", VA = "0xD25994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xD24D30", Offset = "0xD24D30", VA = "0xD24D30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xD2559C", Offset = "0xD2559C", VA = "0xD2559C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xD255E0", Offset = "0xD255E0", VA = "0xD255E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xD25624", Offset = "0xD25624", VA = "0xD25624")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xD25668", Offset = "0xD25668", VA = "0xD25668")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xD256AC", Offset = "0xD256AC", VA = "0xD256AC")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xD256F0", Offset = "0xD256F0", VA = "0xD256F0")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xD25734", Offset = "0xD25734", VA = "0xD25734")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xD25778", Offset = "0xD25778", VA = "0xD25778")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xD257DC", Offset = "0xD257DC", VA = "0xD257DC")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xD25A14", Offset = "0xD25A14", VA = "0xD25A14")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xD237DC", Offset = "0xD237DC", VA = "0xD237DC")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xD25B64", Offset = "0xD25B64", VA = "0xD25B64")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xD231A8", Offset = "0xD231A8", VA = "0xD231A8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xD237D4", Offset = "0xD237D4", VA = "0xD237D4")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xD23FC4", Offset = "0xD23FC4", VA = "0xD23FC4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight, bool isPaused)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xD2490C", Offset = "0xD2490C", VA = "0xD2490C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xD261D4", Offset = "0xD261D4", VA = "0xD261D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xD25BEC", Offset = "0xD25BEC", VA = "0xD25BEC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xD25B6C", Offset = "0xD25B6C", VA = "0xD25B6C")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xD26148", Offset = "0xD26148", VA = "0xD26148")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xD261D8", Offset = "0xD261D8", VA = "0xD261D8")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xD26234", Offset = "0xD26234", VA = "0xD26234")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200009A")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200009C")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Space(10f)]
		[SerializeField]
		[Tooltip("Reference to the FBBIK component.")]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTime;

		[Token(Token = "0x17000096")]
		public bool inInteraction
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0xD26850", Offset = "0xD26850", VA = "0xD26850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xD286E8", Offset = "0xD286E8", VA = "0xD286E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000561")]
			[Address(RVA = "0xD286F0", Offset = "0xD286F0", VA = "0xD286F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0xD286F8", Offset = "0xD286F8", VA = "0xD286F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000563")]
			[Address(RVA = "0xD28700", Offset = "0xD28700", VA = "0xD28700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool initiated
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0xD28708", Offset = "0xD28708", VA = "0xD28708")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0xD28710", Offset = "0xD28710", VA = "0xD28710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xD26630", Offset = "0xD26630", VA = "0xD26630")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xD26674", Offset = "0xD26674", VA = "0xD26674")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xD266B8", Offset = "0xD266B8", VA = "0xD266B8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xD266FC", Offset = "0xD266FC", VA = "0xD266FC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xD26740", Offset = "0xD26740", VA = "0xD26740")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xD26784", Offset = "0xD26784", VA = "0xD26784")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xD267C8", Offset = "0xD267C8", VA = "0xD267C8")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xD2680C", Offset = "0xD2680C", VA = "0xD2680C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xD269C8", Offset = "0xD269C8", VA = "0xD269C8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xD26A80", Offset = "0xD26A80", VA = "0xD26A80")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xD26B38", Offset = "0xD26B38", VA = "0xD26B38")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xD26BD0", Offset = "0xD26BD0", VA = "0xD26BD0")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xD26CB4", Offset = "0xD26CB4", VA = "0xD26CB4")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xD26DAC", Offset = "0xD26DAC", VA = "0xD26DAC")]
		public bool StartInteractionWithClosestTarget(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xD26F04", Offset = "0xD26F04", VA = "0xD26F04")]
		private int GetClosestTargetIndex(FullBodyBipedEffector effectorType, InteractionObject obj)
		{
			return default(int);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xD27038", Offset = "0xD27038", VA = "0xD27038")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xD27140", Offset = "0xD27140", VA = "0xD27140")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xD271C4", Offset = "0xD271C4", VA = "0xD271C4")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xD27248", Offset = "0xD27248", VA = "0xD27248")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xD272CC", Offset = "0xD272CC", VA = "0xD272CC")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xD27334", Offset = "0xD27334", VA = "0xD27334")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xD2739C", Offset = "0xD2739C", VA = "0xD2739C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xD273F8", Offset = "0xD273F8", VA = "0xD273F8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xD27478", Offset = "0xD27478", VA = "0xD27478")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xD27520", Offset = "0xD27520", VA = "0xD27520")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xD275F0", Offset = "0xD275F0", VA = "0xD275F0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xD27880", Offset = "0xD27880", VA = "0xD27880")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xD27A54", Offset = "0xD27A54", VA = "0xD27A54")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xD27CC4", Offset = "0xD27CC4", VA = "0xD27CC4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xD27F50", Offset = "0xD27F50", VA = "0xD27F50")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xD27F88", Offset = "0xD27F88", VA = "0xD27F88")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xD27FE8", Offset = "0xD27FE8", VA = "0xD27FE8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xD28114", Offset = "0xD28114", VA = "0xD28114")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xD282F8", Offset = "0xD282F8", VA = "0xD282F8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xD2856C", Offset = "0xD2856C", VA = "0xD2856C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xD27DAC", Offset = "0xD27DAC", VA = "0xD27DAC")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xD2868C", Offset = "0xD2868C", VA = "0xD2868C")]
		public void StoreDefaults()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xD2871C", Offset = "0xD2871C", VA = "0xD2871C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xD28F7C", Offset = "0xD28F7C", VA = "0xD28F7C")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xD28F9C", Offset = "0xD28F9C", VA = "0xD28F9C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xD28FB8", Offset = "0xD28FB8", VA = "0xD28FB8")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xD28FD4", Offset = "0xD28FD4", VA = "0xD28FD4")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xD29028", Offset = "0xD29028", VA = "0xD29028")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xD291AC", Offset = "0xD291AC", VA = "0xD291AC")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xD292A8", Offset = "0xD292A8", VA = "0xD292A8")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xD29454", Offset = "0xD29454", VA = "0xD29454")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xD2956C", Offset = "0xD2956C", VA = "0xD2956C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xD29830", Offset = "0xD29830", VA = "0xD29830")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xD28D1C", Offset = "0xD28D1C", VA = "0xD28D1C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xD29960", Offset = "0xD29960", VA = "0xD29960")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xD2997C", Offset = "0xD2997C", VA = "0xD2997C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xD29AB8", Offset = "0xD29AB8", VA = "0xD29AB8")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xD29B40", Offset = "0xD29B40", VA = "0xD29B40")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xD29C00", Offset = "0xD29C00", VA = "0xD29C00")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xD29C18", Offset = "0xD29C18", VA = "0xD29C18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xD268E8", Offset = "0xD268E8", VA = "0xD268E8")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xD2776C", Offset = "0xD2776C", VA = "0xD2776C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xD2A0A0", Offset = "0xD2A0A0", VA = "0xD2A0A0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public enum RotationMode
		{
			[Token(Token = "0x400050C")]
			TwoDOF,
			[Token(Token = "0x400050D")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x200009F")]
		public class Multiplier
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x600058F")]
			[Address(RVA = "0xD2B1C8", Offset = "0xD2B1C8", VA = "0xD2B1C8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[Tooltip("Will not set HandPoser's pose target and allows you to use a pose target from a previous interaction if disabled.")]
		public bool usePoser;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xD2A7FC", Offset = "0xD2A7FC", VA = "0xD2A7FC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xD2A840", Offset = "0xD2A840", VA = "0xD2A840")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xD2A884", Offset = "0xD2A884", VA = "0xD2A884")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xD2A8C8", Offset = "0xD2A8C8", VA = "0xD2A8C8")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xD2A90C", Offset = "0xD2A90C", VA = "0xD2A90C")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xD2A950", Offset = "0xD2A950", VA = "0xD2A950")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xD2A994", Offset = "0xD2A994", VA = "0xD2A994")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xD2A9D8", Offset = "0xD2A9D8", VA = "0xD2A9D8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xD2AA1C", Offset = "0xD2AA1C", VA = "0xD2AA1C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xD2AA80", Offset = "0xD2AA80", VA = "0xD2AA80")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xD2AB0C", Offset = "0xD2AB0C", VA = "0xD2AB0C")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xD2B154", Offset = "0xD2B154", VA = "0xD2B154")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around its Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700009A")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000597")]
				[Address(RVA = "0xD2B5EC", Offset = "0xD2B5EC", VA = "0xD2B5EC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000598")]
				[Address(RVA = "0xD2B5F8", Offset = "0xD2B5F8", VA = "0xD2B5F8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xD2B6B8", Offset = "0xD2B6B8", VA = "0xD2B6B8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xD2BE1C", Offset = "0xD2BE1C", VA = "0xD2BE1C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class CameraPosition
		{
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600059B")]
			[Address(RVA = "0xD2BE30", Offset = "0xD2BE30", VA = "0xD2BE30")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0xD2BFA8", Offset = "0xD2BFA8", VA = "0xD2BFA8")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0xD2C2B0", Offset = "0xD2C2B0", VA = "0xD2C2B0")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000A4")]
			public class Interaction
			{
				[Token(Token = "0x4000522")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000523")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60005A0")]
				[Address(RVA = "0xD2C334", Offset = "0xD2C334", VA = "0xD2C334")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600059E")]
			[Address(RVA = "0xD2B4D8", Offset = "0xD2B4D8", VA = "0xD2B4D8")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0xD2C324", Offset = "0xD2C324", VA = "0xD2C324")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xD2B1D0", Offset = "0xD2B1D0", VA = "0xD2B1D0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xD2B214", Offset = "0xD2B214", VA = "0xD2B214")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xD2B258", Offset = "0xD2B258", VA = "0xD2B258")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xD2B29C", Offset = "0xD2B29C", VA = "0xD2B29C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xD2B2E0", Offset = "0xD2B2E0", VA = "0xD2B2E0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xD2B324", Offset = "0xD2B324", VA = "0xD2B324")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xD2B588", Offset = "0xD2B588", VA = "0xD2B588")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public class Map
		{
			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0xD2C634", Offset = "0xD2C634", VA = "0xD2C634")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xD2C98C", Offset = "0xD2C98C", VA = "0xD2C98C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0xD2C94C", Offset = "0xD2C94C", VA = "0xD2C94C")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xD2C7D0", Offset = "0xD2C7D0", VA = "0xD2C7D0")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xD2C33C", Offset = "0xD2C33C", VA = "0xD2C33C", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xD2C6DC", Offset = "0xD2C6DC", VA = "0xD2C6DC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xD2C6E0", Offset = "0xD2C6E0", VA = "0xD2C6E0", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xD2C8F0", Offset = "0xD2C8F0", VA = "0xD2C8F0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xD2C680", Offset = "0xD2C680", VA = "0xD2C680")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xD2C5A0", Offset = "0xD2C5A0", VA = "0xD2C5A0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xD2C9D0", Offset = "0xD2C9D0", VA = "0xD2C9D0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xD2C9F0", Offset = "0xD2C9F0", VA = "0xD2C9F0", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xD2CAC0", Offset = "0xD2CAC0", VA = "0xD2CAC0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xD2CC98", Offset = "0xD2CC98", VA = "0xD2CC98", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xD2CD80", Offset = "0xD2CD80", VA = "0xD2CD80", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xD2CB20", Offset = "0xD2CB20", VA = "0xD2CB20")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xD2D0B0", Offset = "0xD2D0B0", VA = "0xD2D0B0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60005B2")]
		public abstract void AutoMapping();

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xD2D0C0", Offset = "0xD2D0C0", VA = "0xD2D0C0")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x60005B4")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60005B5")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60005B6")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xD2D0CC", Offset = "0xD2D0CC", VA = "0xD2D0CC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xD2D110", Offset = "0xD2D110", VA = "0xD2D110", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xD2D13C", Offset = "0xD2D13C", VA = "0xD2D13C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xD2C9E0", Offset = "0xD2C9E0", VA = "0xD2C9E0")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		public class Rigidbone
		{
			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xD2D7AC", Offset = "0xD2D7AC", VA = "0xD2D7AC")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xD2E358", Offset = "0xD2E358", VA = "0xD2E358")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xD2E118", Offset = "0xD2E118", VA = "0xD2E118")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000AB")]
		public class Child
		{
			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xD2D954", Offset = "0xD2D954", VA = "0xD2D954")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xD2E470", Offset = "0xD2E470", VA = "0xD2E470")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xD2E42C", Offset = "0xD2E42C", VA = "0xD2E42C")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x1700009E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0xD2E9DC", Offset = "0xD2E9DC", VA = "0xD2E9DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0xD2EA24", Offset = "0xD2EA24", VA = "0xD2EA24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xD2D9C0", Offset = "0xD2D9C0", VA = "0xD2D9C0")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xD2E7EC", Offset = "0xD2E7EC", VA = "0xD2E7EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xD2E7F0", Offset = "0xD2E7F0", VA = "0xD2E7F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xD2E9E4", Offset = "0xD2E9E4", VA = "0xD2E9E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x1700009C")]
		private bool isRagdoll
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xD2D180", Offset = "0xD2D180", VA = "0xD2D180")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		private bool ikUsed
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xD2DD4C", Offset = "0xD2DD4C", VA = "0xD2DD4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xD2D154", Offset = "0xD2D154", VA = "0xD2D154")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xD2D1E4", Offset = "0xD2D1E4", VA = "0xD2D1E4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xD2D2FC", Offset = "0xD2D2FC", VA = "0xD2D2FC")]
		public void Start()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xD2D288", Offset = "0xD2D288", VA = "0xD2D288")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xD2D9E8", Offset = "0xD2D9E8", VA = "0xD2D9E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xD2DC10", Offset = "0xD2DC10", VA = "0xD2DC10")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xD2DCB0", Offset = "0xD2DCB0", VA = "0xD2DCB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xD2DEA0", Offset = "0xD2DEA0", VA = "0xD2DEA0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xD2DD20", Offset = "0xD2DD20", VA = "0xD2DD20")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xD2DE6C", Offset = "0xD2DE6C", VA = "0xD2DE6C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xD2DF20", Offset = "0xD2DF20", VA = "0xD2DF20")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xD2DEC4", Offset = "0xD2DEC4", VA = "0xD2DEC4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xD2D22C", Offset = "0xD2D22C", VA = "0xD2D22C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xD2DC44", Offset = "0xD2DC44", VA = "0xD2DC44")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xD2E580", Offset = "0xD2E580", VA = "0xD2E580")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xD2E6B8", Offset = "0xD2E6B8", VA = "0xD2E6B8")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x170000A0")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0xD2EE90", Offset = "0xD2EE90", VA = "0xD2EE90")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A1")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xD2EE9C", Offset = "0xD2EE9C", VA = "0xD2EE9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0xD2EECC", Offset = "0xD2EECC", VA = "0xD2EECC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xD2EED4", Offset = "0xD2EED4", VA = "0xD2EED4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xD2EA2C", Offset = "0xD2EA2C", VA = "0xD2EA2C")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xD2EA68", Offset = "0xD2EA68", VA = "0xD2EA68")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xD2EA80", Offset = "0xD2EA80", VA = "0xD2EA80")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xD2EE00", Offset = "0xD2EE00", VA = "0xD2EE00")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xD2EE64", Offset = "0xD2EE64", VA = "0xD2EE64")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005E2")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xD2ED04", Offset = "0xD2ED04", VA = "0xD2ED04")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xD2EEE0", Offset = "0xD2EEE0", VA = "0xD2EEE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xD2EEE4", Offset = "0xD2EEE4", VA = "0xD2EEE4")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xD2EF0C", Offset = "0xD2EF0C", VA = "0xD2EF0C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xD2EFE0", Offset = "0xD2EFE0", VA = "0xD2EFE0")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xD2F238", Offset = "0xD2F238", VA = "0xD2F238")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xD2F38C", Offset = "0xD2F38C", VA = "0xD2F38C")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xD2F3EC", Offset = "0xD2F3EC", VA = "0xD2F3EC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xD2F430", Offset = "0xD2F430", VA = "0xD2F430")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xD2F474", Offset = "0xD2F474", VA = "0xD2F474")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xD2F4B8", Offset = "0xD2F4B8", VA = "0xD2F4B8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xD2F4FC", Offset = "0xD2F4FC", VA = "0xD2F4FC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xD2F534", Offset = "0xD2F534", VA = "0xD2F534")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xD2F858", Offset = "0xD2F858", VA = "0xD2F858")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xD2F868", Offset = "0xD2F868", VA = "0xD2F868")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xD2F8AC", Offset = "0xD2F8AC", VA = "0xD2F8AC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xD2F8F0", Offset = "0xD2F8F0", VA = "0xD2F8F0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xD2F934", Offset = "0xD2F934", VA = "0xD2F934")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xD2F978", Offset = "0xD2F978", VA = "0xD2F978", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xD2F97C", Offset = "0xD2F97C", VA = "0xD2F97C")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xD2FB9C", Offset = "0xD2FB9C", VA = "0xD2FB9C")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class ReachCone
		{
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000A3")]
			public Vector3 o
			{
				[Token(Token = "0x6000608")]
				[Address(RVA = "0xD31A48", Offset = "0xD31A48", VA = "0xD31A48")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 a
			{
				[Token(Token = "0x6000609")]
				[Address(RVA = "0xD31A74", Offset = "0xD31A74", VA = "0xD31A74")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 b
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0xD31AA4", Offset = "0xD31AA4", VA = "0xD31AA4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 c
			{
				[Token(Token = "0x600060B")]
				[Address(RVA = "0xD31AD4", Offset = "0xD31AD4", VA = "0xD31AD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public bool isValid
			{
				[Token(Token = "0x600060D")]
				[Address(RVA = "0xD30F70", Offset = "0xD30F70", VA = "0xD30F70")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0xD31414", Offset = "0xD31414", VA = "0xD31414")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xD3158C", Offset = "0xD3158C", VA = "0xD3158C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class LimitPoint
		{
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xD30F80", Offset = "0xD30F80", VA = "0xD30F80")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xD2FBB4", Offset = "0xD2FBB4", VA = "0xD2FBB4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xD2FBF8", Offset = "0xD2FBF8", VA = "0xD2FBF8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xD2FC3C", Offset = "0xD2FC3C", VA = "0xD2FC3C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xD2FC80", Offset = "0xD2FC80", VA = "0xD2FC80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xD2FCC4", Offset = "0xD2FCC4", VA = "0xD2FCC4")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xD303A8", Offset = "0xD303A8", VA = "0xD303A8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xD30430", Offset = "0xD30430", VA = "0xD30430")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xD30A7C", Offset = "0xD30A7C", VA = "0xD30A7C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xD2FD5C", Offset = "0xD2FD5C", VA = "0xD2FD5C")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xD30FE4", Offset = "0xD30FE4", VA = "0xD30FE4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xD31800", Offset = "0xD31800", VA = "0xD31800")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xD31848", Offset = "0xD31848", VA = "0xD31848")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xD318A8", Offset = "0xD318A8", VA = "0xD318A8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xD307D8", Offset = "0xD307D8", VA = "0xD307D8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xD31914", Offset = "0xD31914", VA = "0xD31914")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xD319E0", Offset = "0xD319E0", VA = "0xD319E0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xD31B04", Offset = "0xD31B04", VA = "0xD31B04")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xD31B48", Offset = "0xD31B48", VA = "0xD31B48")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xD31B8C", Offset = "0xD31B8C", VA = "0xD31B8C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xD31BD0", Offset = "0xD31BD0", VA = "0xD31BD0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xD31C14", Offset = "0xD31C14", VA = "0xD31C14")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xD31C30", Offset = "0xD31C30", VA = "0xD31C30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xD31C68", Offset = "0xD31C68", VA = "0xD31C68")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xD32014", Offset = "0xD32014", VA = "0xD32014")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000622")]
				[Address(RVA = "0xD33018", Offset = "0xD33018", VA = "0xD33018", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000624")]
				[Address(RVA = "0xD33060", Offset = "0xD33060", VA = "0xD33060", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600061F")]
			[Address(RVA = "0xD32E18", Offset = "0xD32E18", VA = "0xD32E18")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x6000620")]
			[Address(RVA = "0xD32F24", Offset = "0xD32F24", VA = "0xD32F24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000621")]
			[Address(RVA = "0xD32F28", Offset = "0xD32F28", VA = "0xD32F28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0xD33020", Offset = "0xD33020", VA = "0xD33020", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		public float maxRootAngle;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x170000A8")]
		private Vector3 pivot
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0xD320A0", Offset = "0xD320A0", VA = "0xD320A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xD32020", Offset = "0xD32020", VA = "0xD32020")]
		private void Start()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xD32124", Offset = "0xD32124", VA = "0xD32124")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xD3297C", Offset = "0xD3297C", VA = "0xD3297C")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xD32B00", Offset = "0xD32B00", VA = "0xD32B00")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xD32DA4", Offset = "0xD32DA4", VA = "0xD32DA4")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xD32E40", Offset = "0xD32E40", VA = "0xD32E40")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class Pose
		{
			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000628")]
			[Address(RVA = "0xD33138", Offset = "0xD33138", VA = "0xD33138")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0xD336B4", Offset = "0xD336B4", VA = "0xD336B4")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0xD336BC", Offset = "0xD336BC", VA = "0xD336BC")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xD33068", Offset = "0xD33068", VA = "0xD33068")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xD335E8", Offset = "0xD335E8", VA = "0xD335E8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xD33648", Offset = "0xD33648", VA = "0xD33648")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BA")]
			public class EffectorLink
			{
				[Token(Token = "0x40005A2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005A3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x6000630")]
				[Address(RVA = "0xD33B80", Offset = "0xD33B80", VA = "0xD33B80")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x600062D")]
			[Address(RVA = "0xD33828", Offset = "0xD33828", VA = "0xD33828")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0xD33B58", Offset = "0xD33B58", VA = "0xD33B58")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0xD33B68", Offset = "0xD33B68", VA = "0xD33B68")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xD336D8", Offset = "0xD336D8", VA = "0xD336D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xD33B38", Offset = "0xD33B38", VA = "0xD33B38")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xD33B88", Offset = "0xD33B88", VA = "0xD33B88", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xD33BF0", Offset = "0xD33BF0", VA = "0xD33BF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xD33E90", Offset = "0xD33E90", VA = "0xD33E90")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xD33EAC", Offset = "0xD33EAC", VA = "0xD33EAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xD33F8C", Offset = "0xD33F8C", VA = "0xD33F8C")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xD34220", Offset = "0xD34220", VA = "0xD34220")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xD3434C", Offset = "0xD3434C", VA = "0xD3434C")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x170000AB")]
		public IK ik
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0xD3435C", Offset = "0xD3435C", VA = "0xD3435C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0xD34364", Offset = "0xD34364", VA = "0xD34364")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xD3436C", Offset = "0xD3436C", VA = "0xD3436C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xD3450C", Offset = "0xD3450C", VA = "0xD3450C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xD34768", Offset = "0xD34768", VA = "0xD34768")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xD348A4", Offset = "0xD348A4", VA = "0xD348A4")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xD34A84", Offset = "0xD34A84", VA = "0xD34A84")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xD34C98", Offset = "0xD34C98", VA = "0xD34C98")]
		public void Update()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xD34F1C", Offset = "0xD34F1C", VA = "0xD34F1C")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000AC")]
		public bool poseStored
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0xD345E8", Offset = "0xD345E8", VA = "0xD345E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xD34920", Offset = "0xD34920", VA = "0xD34920")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xD3460C", Offset = "0xD3460C", VA = "0xD3460C")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xD34F80", Offset = "0xD34F80", VA = "0xD34F80")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class FABRIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FABRIK ik;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xD3501C", Offset = "0xD3501C", VA = "0xD3501C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xD350FC", Offset = "0xD350FC", VA = "0xD350FC")]
		private void OnPreIteration(int it)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xD35210", Offset = "0xD35210", VA = "0xD35210")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xD3533C", Offset = "0xD3533C", VA = "0xD3533C")]
		public FABRIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000AE")]
			public bool inProgress
			{
				[Token(Token = "0x600064D")]
				[Address(RVA = "0xD353E8", Offset = "0xD353E8", VA = "0xD353E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AF")]
			protected float crossFader
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0xD357D0", Offset = "0xD357D0", VA = "0xD357D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600064F")]
				[Address(RVA = "0xD357D8", Offset = "0xD357D8", VA = "0xD357D8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			protected float timer
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0xD357E0", Offset = "0xD357E0", VA = "0xD357E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000651")]
				[Address(RVA = "0xD357E8", Offset = "0xD357E8", VA = "0xD357E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			protected Vector3 force
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0xD357F0", Offset = "0xD357F0", VA = "0xD357F0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000653")]
				[Address(RVA = "0xD357FC", Offset = "0xD357FC", VA = "0xD357FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0xD35808", Offset = "0xD35808", VA = "0xD35808", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0xD354BC", Offset = "0xD354BC", VA = "0xD354BC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000656")]
			protected abstract float GetLength();

			[Token(Token = "0x6000657")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000658")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000659")]
			[Address(RVA = "0xD35914", Offset = "0xD35914", VA = "0xD35914")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C3")]
			public class EffectorLink
			{
				[Token(Token = "0x40005C2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40005C4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005C5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600065E")]
				[Address(RVA = "0xD35C48", Offset = "0xD35C48", VA = "0xD35C48")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600065F")]
				[Address(RVA = "0xD35AA4", Offset = "0xD35AA4", VA = "0xD35AA4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000660")]
				[Address(RVA = "0xD35CF8", Offset = "0xD35CF8", VA = "0xD35CF8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x600065A")]
			[Address(RVA = "0xD35928", Offset = "0xD35928", VA = "0xD35928", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0xD35A44", Offset = "0xD35A44", VA = "0xD35A44", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0xD35AB8", Offset = "0xD35AB8", VA = "0xD35AB8", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xD35CE4", Offset = "0xD35CE4", VA = "0xD35CE4")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000C5")]
			public class BoneLink
			{
				[Token(Token = "0x40005CA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x40005CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005CD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000666")]
				[Address(RVA = "0xD36030", Offset = "0xD36030", VA = "0xD36030")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000667")]
				[Address(RVA = "0xD35F64", Offset = "0xD35F64", VA = "0xD35F64")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0xD361D0", Offset = "0xD361D0", VA = "0xD361D0")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector3 comAxis;

			[Token(Token = "0x6000661")]
			[Address(RVA = "0xD35D00", Offset = "0xD35D00", VA = "0xD35D00", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000662")]
			[Address(RVA = "0xD35E80", Offset = "0xD35E80", VA = "0xD35E80", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000663")]
			[Address(RVA = "0xD35F0C", Offset = "0xD35F0C", VA = "0xD35F0C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xD35F70", Offset = "0xD35F70", VA = "0xD35F70", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xD361BC", Offset = "0xD361BC", VA = "0xD361BC")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000AD")]
		public bool inProgress
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0xD3534C", Offset = "0xD3534C", VA = "0xD3534C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xD353FC", Offset = "0xD353FC", VA = "0xD353FC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xD35594", Offset = "0xD35594", VA = "0xD35594")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xD357C0", Offset = "0xD357C0", VA = "0xD357C0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public abstract class Offset
		{
			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float length;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float crossFadeSpeed;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float lastTime;

			[Token(Token = "0x170000B2")]
			protected float crossFader
			{
				[Token(Token = "0x600066C")]
				[Address(RVA = "0xD36620", Offset = "0xD36620", VA = "0xD36620")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600066D")]
				[Address(RVA = "0xD36628", Offset = "0xD36628", VA = "0xD36628")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected float timer
			{
				[Token(Token = "0x600066E")]
				[Address(RVA = "0xD36630", Offset = "0xD36630", VA = "0xD36630")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600066F")]
				[Address(RVA = "0xD36638", Offset = "0xD36638", VA = "0xD36638")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Token(Token = "0x6000670")]
				[Address(RVA = "0xD36640", Offset = "0xD36640", VA = "0xD36640")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000671")]
				[Address(RVA = "0xD3664C", Offset = "0xD3664C", VA = "0xD3664C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0xD36658", Offset = "0xD36658", VA = "0xD36658", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0xD362EC", Offset = "0xD362EC", VA = "0xD362EC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000674")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000675")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000676")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xD3676C", Offset = "0xD3676C", VA = "0xD3676C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000C9")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40005DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40005DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40005DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40005E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600067C")]
				[Address(RVA = "0xD36B50", Offset = "0xD36B50", VA = "0xD36B50")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600067D")]
				[Address(RVA = "0xD36974", Offset = "0xD36974", VA = "0xD36974")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600067E")]
				[Address(RVA = "0xD36BE4", Offset = "0xD36BE4", VA = "0xD36BE4")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000678")]
			[Address(RVA = "0xD36780", Offset = "0xD36780", VA = "0xD36780", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0xD36914", Offset = "0xD36914", VA = "0xD36914", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0xD36988", Offset = "0xD36988", VA = "0xD36988", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0xD36BC8", Offset = "0xD36BC8", VA = "0xD36BC8")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000CB")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40005E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40005E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x40005E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000684")]
				[Address(RVA = "0xD370D8", Offset = "0xD370D8", VA = "0xD370D8")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000685")]
				[Address(RVA = "0xD36EA4", Offset = "0xD36EA4", VA = "0xD36EA4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000686")]
				[Address(RVA = "0xD371F4", Offset = "0xD371F4", VA = "0xD371F4")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Rigidbody rigidbody;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector3 comAxis;

			[Token(Token = "0x600067F")]
			[Address(RVA = "0xD36BEC", Offset = "0xD36BEC", VA = "0xD36BEC", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0xD36D74", Offset = "0xD36D74", VA = "0xD36D74", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0xD36E4C", Offset = "0xD36E4C", VA = "0xD36E4C", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0xD36EB0", Offset = "0xD36EB0", VA = "0xD36EB0", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0xD371E0", Offset = "0xD371E0", VA = "0xD371E0")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xD36234", Offset = "0xD36234", VA = "0xD36234", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xD363CC", Offset = "0xD363CC", VA = "0xD363CC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xD36600", Offset = "0xD36600", VA = "0xD36600")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000CE")]
			public class EffectorLink
			{
				[Token(Token = "0x40005F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600068D")]
				[Address(RVA = "0xD377BC", Offset = "0xD377BC", VA = "0xD377BC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 1f)]
			[Tooltip("Matching target velocity")]
			public float matchVelocity;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xD372C4", Offset = "0xD372C4", VA = "0xD372C4")]
			public void Reset()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xD37444", Offset = "0xD37444", VA = "0xD37444")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xD377A0", Offset = "0xD377A0", VA = "0xD377A0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xD37258", Offset = "0xD37258", VA = "0xD37258")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xD373A0", Offset = "0xD373A0", VA = "0xD373A0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xD37790", Offset = "0xD37790", VA = "0xD37790")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		public Transform target;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 180f)]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		public float maxRootAngle;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000B5")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0xD3782C", Offset = "0xD3782C", VA = "0xD3782C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xD377C4", Offset = "0xD377C4", VA = "0xD377C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xD378B0", Offset = "0xD378B0", VA = "0xD378B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xD37DB8", Offset = "0xD37DB8", VA = "0xD37DB8")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xD37F3C", Offset = "0xD37F3C", VA = "0xD37F3C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xD38188", Offset = "0xD38188", VA = "0xD38188")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class OffsetLimits
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xD38390", Offset = "0xD38390", VA = "0xD38390")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0xD38620", Offset = "0xD38620", VA = "0xD38620")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0xD38690", Offset = "0xD38690", VA = "0xD38690")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0xD386D8", Offset = "0xD386D8", VA = "0xD386D8")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006A3")]
				[Address(RVA = "0xD38854", Offset = "0xD38854", VA = "0xD38854", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006A5")]
				[Address(RVA = "0xD3889C", Offset = "0xD3889C", VA = "0xD3889C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xD38294", Offset = "0xD38294", VA = "0xD38294")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xD386E0", Offset = "0xD386E0", VA = "0xD386E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xD386E4", Offset = "0xD386E4", VA = "0xD386E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xD3885C", Offset = "0xD3885C", VA = "0xD3885C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000B6")]
		protected float deltaTime
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0xD33808", Offset = "0xD33808", VA = "0xD33808")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000695")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xD33BD0", Offset = "0xD33BD0", VA = "0xD33BD0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xD38220", Offset = "0xD38220", VA = "0xD38220")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xD382BC", Offset = "0xD382BC", VA = "0xD382BC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xD376E8", Offset = "0xD376E8", VA = "0xD376E8")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xD384F4", Offset = "0xD384F4", VA = "0xD384F4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xD33B48", Offset = "0xD33B48", VA = "0xD33B48")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000BA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B0")]
				[Address(RVA = "0xD38CF4", Offset = "0xD38CF4", VA = "0xD38CF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B2")]
				[Address(RVA = "0xD38D3C", Offset = "0xD38D3C", VA = "0xD38D3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xD38958", Offset = "0xD38958", VA = "0xD38958")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xD38B80", Offset = "0xD38B80", VA = "0xD38B80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xD38B84", Offset = "0xD38B84", VA = "0xD38B84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xD38CFC", Offset = "0xD38CFC", VA = "0xD38CFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000B9")]
		protected float deltaTime
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xD388A4", Offset = "0xD388A4", VA = "0xD388A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006A7")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xD388C4", Offset = "0xD388C4", VA = "0xD388C4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xD388E4", Offset = "0xD388E4", VA = "0xD388E4")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xD38980", Offset = "0xD38980", VA = "0xD38980")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xD38A54", Offset = "0xD38A54", VA = "0xD38A54", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xD36610", Offset = "0xD36610", VA = "0xD36610")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class EffectorLink
		{
			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xD38D44", Offset = "0xD38D44", VA = "0xD38D44")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xD3909C", Offset = "0xD3909C", VA = "0xD3909C")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xD33DDC", Offset = "0xD33DDC", VA = "0xD33DDC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xD38F94", Offset = "0xD38F94", VA = "0xD38F94")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xD39038", Offset = "0xD39038", VA = "0xD39038")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000D9")]
			public class EffectorLink
			{
				[Token(Token = "0x4000633")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000634")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x60006BE")]
				[Address(RVA = "0xD396F0", Offset = "0xD396F0", VA = "0xD396F0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			public float raycastRadius;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xD39114", Offset = "0xD39114", VA = "0xD39114")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xD392B4", Offset = "0xD392B4", VA = "0xD392B4")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xD393BC", Offset = "0xD393BC", VA = "0xD393BC")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xD396DC", Offset = "0xD396DC", VA = "0xD396DC")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xD390A4", Offset = "0xD390A4", VA = "0xD390A4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xD392A4", Offset = "0xD392A4", VA = "0xD392A4")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000DC")]
			public class EffectorLink
			{
				[Token(Token = "0x4000653")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000654")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006CE")]
				[Address(RVA = "0xD3ABD0", Offset = "0xD3ABD0", VA = "0xD3ABD0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xD39894", Offset = "0xD39894", VA = "0xD39894")]
			public void Start()
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xD3A450", Offset = "0xD3A450", VA = "0xD3A450")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xD3ABBC", Offset = "0xD3ABBC", VA = "0xD3ABBC")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DD")]
		public enum Handedness
		{
			[Token(Token = "0x4000656")]
			Right,
			[Token(Token = "0x4000657")]
			Left
		}

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Optional head AimIK solver. This solver should only use neck and head bones and have the head as Aim Transform")]
		public AimIK headIK;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float magnitudeMlp;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float endTime;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion handRotation;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float length;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private bool initiated;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float blendWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float w;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool handRotationsSet;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000BC")]
		public bool isFinished
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xD396F8", Offset = "0xD396F8", VA = "0xD396F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xD3A654", Offset = "0xD3A654", VA = "0xD3A654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xD3A690", Offset = "0xD3A690", VA = "0xD3A690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xD3A61C", Offset = "0xD3A61C", VA = "0xD3A61C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xD3A638", Offset = "0xD3A638", VA = "0xD3A638")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xD3971C", Offset = "0xD3971C", VA = "0xD3971C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xD39748", Offset = "0xD39748", VA = "0xD39748")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xD39968", Offset = "0xD39968", VA = "0xD39968", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xD3A6CC", Offset = "0xD3A6CC", VA = "0xD3A6CC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xD3A854", Offset = "0xD3A854", VA = "0xD3A854")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xD3A92C", Offset = "0xD3A92C", VA = "0xD3A92C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xD3AB30", Offset = "0xD3AB30", VA = "0xD3AB30")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xD3ABD8", Offset = "0xD3ABD8", VA = "0xD3ABD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xD3ACEC", Offset = "0xD3ACEC", VA = "0xD3ACEC")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xD3ADC8", Offset = "0xD3ADC8", VA = "0xD3ADC8")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xD3B1CC", Offset = "0xD3B1CC", VA = "0xD3B1CC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xD3B200", Offset = "0xD3B200", VA = "0xD3B200")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xD3B32C", Offset = "0xD3B32C", VA = "0xD3B32C")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Settings
		{
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xD3F09C", Offset = "0xD3F09C", VA = "0xD3F09C")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000E2")]
			public class Target
			{
				[Token(Token = "0x4000676")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000677")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x4000678")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60006E6")]
				[Address(RVA = "0xD3F238", Offset = "0xD3F238", VA = "0xD3F238")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60006E7")]
				[Address(RVA = "0xD3F2EC", Offset = "0xD3F2EC", VA = "0xD3F2EC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0xD3F230", Offset = "0xD3F230", VA = "0xD3F230")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xD3B340", Offset = "0xD3B340", VA = "0xD3B340")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xD3B358", Offset = "0xD3B358", VA = "0xD3B358")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xD3B480", Offset = "0xD3B480", VA = "0xD3B480")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xD3B3A0", Offset = "0xD3B3A0", VA = "0xD3B3A0")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xD3B498", Offset = "0xD3B498", VA = "0xD3B498")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xD3C7A8", Offset = "0xD3C7A8", VA = "0xD3C7A8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xD3CE88", Offset = "0xD3CE88", VA = "0xD3CE88")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xD3D848", Offset = "0xD3D848", VA = "0xD3D848")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xD3DAE0", Offset = "0xD3DAE0", VA = "0xD3DAE0")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xD3DD20", Offset = "0xD3DD20", VA = "0xD3DD20")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xD3E4CC", Offset = "0xD3E4CC", VA = "0xD3E4CC")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xD3E2B4", Offset = "0xD3E2B4", VA = "0xD3E2B4")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xD3E780", Offset = "0xD3E780", VA = "0xD3E780")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xD3EC70", Offset = "0xD3EC70", VA = "0xD3EC70")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xD3ED54", Offset = "0xD3ED54", VA = "0xD3ED54")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000E3")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xD3F348", Offset = "0xD3F348", VA = "0xD3F348")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xD3F3A0", Offset = "0xD3F3A0", VA = "0xD3F3A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xD3F3C8", Offset = "0xD3F3C8", VA = "0xD3F3C8")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xD3F4E8", Offset = "0xD3F4E8", VA = "0xD3F4E8")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000C1")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0xD3F500", Offset = "0xD3F500", VA = "0xD3F500")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0xD3F50C", Offset = "0xD3F50C", VA = "0xD3F50C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xD3F518", Offset = "0xD3F518", VA = "0xD3F518")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xD3F634", Offset = "0xD3F634", VA = "0xD3F634")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xD3F848", Offset = "0xD3F848", VA = "0xD3F848")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xD3F9E8", Offset = "0xD3F9E8", VA = "0xD3F9E8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xD3FDB0", Offset = "0xD3FDB0", VA = "0xD3FDB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xD3FEDC", Offset = "0xD3FEDC", VA = "0xD3FEDC")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000E5")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class Offset
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xD3FFA0", Offset = "0xD3FFA0", VA = "0xD3FFA0")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xD4021C", Offset = "0xD4021C", VA = "0xD4021C")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xD3FEE4", Offset = "0xD3FEE4", VA = "0xD3FEE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xD3FF3C", Offset = "0xD3FF3C", VA = "0xD3FF3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xD40150", Offset = "0xD40150", VA = "0xD40150")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xD40214", Offset = "0xD40214", VA = "0xD40214")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xD40224", Offset = "0xD40224", VA = "0xD40224")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xD402A4", Offset = "0xD402A4", VA = "0xD402A4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction in which the weapon is aimed in animation (in character space). Tweak this value to adjust the aiming.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xD402AC", Offset = "0xD402AC", VA = "0xD402AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xD40318", Offset = "0xD40318", VA = "0xD40318")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GrounderFBBIK grounder;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xD40378", Offset = "0xD40378", VA = "0xD40378")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xD40430", Offset = "0xD40430", VA = "0xD40430")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xD4075C", Offset = "0xD4075C", VA = "0xD4075C")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xD40764", Offset = "0xD40764", VA = "0xD40764")]
		private void Start()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xD4079C", Offset = "0xD4079C", VA = "0xD4079C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xD40848", Offset = "0xD40848", VA = "0xD40848")]
		private void Pose()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xD409B0", Offset = "0xD409B0", VA = "0xD409B0")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xD40B6C", Offset = "0xD40B6C", VA = "0xD40B6C")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xD40BFC", Offset = "0xD40BFC", VA = "0xD40BFC")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xD40C10", Offset = "0xD40C10", VA = "0xD40C10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xD40D7C", Offset = "0xD40D7C", VA = "0xD40D7C")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xD40F78", Offset = "0xD40F78", VA = "0xD40F78")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xD40FA8", Offset = "0xD40FA8", VA = "0xD40FA8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xD413D4", Offset = "0xD413D4", VA = "0xD413D4")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000C2")]
		public Vector3 velocity
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0xD413F4", Offset = "0xD413F4", VA = "0xD413F4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0xD41400", Offset = "0xD41400", VA = "0xD41400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xD4140C", Offset = "0xD4140C", VA = "0xD4140C")]
		private void Start()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xD4143C", Offset = "0xD4143C", VA = "0xD4143C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xD41DC0", Offset = "0xD41DC0", VA = "0xD41DC0")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xD41B3C", Offset = "0xD41B3C", VA = "0xD41B3C")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xD41ED0", Offset = "0xD41ED0", VA = "0xD41ED0")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000C3")]
		public Vector3 inputVector
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0xD41EFC", Offset = "0xD41EFC", VA = "0xD41EFC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xD41F7C", Offset = "0xD41F7C", VA = "0xD41F7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xD422C0", Offset = "0xD422C0", VA = "0xD422C0")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000724")]
				[Address(RVA = "0xD43318", Offset = "0xD43318", VA = "0xD43318", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000726")]
				[Address(RVA = "0xD43360", Offset = "0xD43360", VA = "0xD43360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0xD42FB0", Offset = "0xD42FB0", VA = "0xD42FB0")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0xD43068", Offset = "0xD43068", VA = "0xD43068", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0xD4306C", Offset = "0xD4306C", VA = "0xD4306C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0xD43320", Offset = "0xD43320", VA = "0xD43320", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000C4")]
		public bool isStepping
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0xD422D4", Offset = "0xD422D4", VA = "0xD422D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public Vector3 position
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xD41EA0", Offset = "0xD41EA0", VA = "0xD41EA0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xD422E8", Offset = "0xD422E8", VA = "0xD422E8")]
			set
			{
			}
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xD42334", Offset = "0xD42334", VA = "0xD42334")]
		private void Awake()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xD425B4", Offset = "0xD425B4", VA = "0xD425B4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xD4278C", Offset = "0xD4278C", VA = "0xD4278C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xD429B0", Offset = "0xD429B0", VA = "0xD429B0")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xD42C10", Offset = "0xD42C10", VA = "0xD42C10")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xD42D78", Offset = "0xD42D78", VA = "0xD42D78")]
		private void Update()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xD42900", Offset = "0xD42900", VA = "0xD42900")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xD42FD8", Offset = "0xD42FD8", VA = "0xD42FD8")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xD43368", Offset = "0xD43368", VA = "0xD43368")]
		private void Start()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xD43444", Offset = "0xD43444", VA = "0xD43444")]
		private void Update()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xD436B8", Offset = "0xD436B8", VA = "0xD436B8")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		public struct Warp
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000F4")]
		public enum EffectorMode
		{
			[Token(Token = "0x40006F6")]
			PositionOffset,
			[Token(Token = "0x40006F7")]
			Position
		}

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xD436C0", Offset = "0xD436C0", VA = "0xD436C0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xD436E0", Offset = "0xD436E0", VA = "0xD436E0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xD438F8", Offset = "0xD438F8", VA = "0xD438F8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xD43BB0", Offset = "0xD43BB0", VA = "0xD43BB0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xD43C44", Offset = "0xD43C44", VA = "0xD43C44")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xD43C4C", Offset = "0xD43C4C", VA = "0xD43C4C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xD43CA4", Offset = "0xD43CA4", VA = "0xD43CA4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xD43EAC", Offset = "0xD43EAC", VA = "0xD43EAC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xD440D4", Offset = "0xD440D4", VA = "0xD440D4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xD440E8", Offset = "0xD440E8", VA = "0xD440E8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xD442BC", Offset = "0xD442BC", VA = "0xD442BC", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xD4432C", Offset = "0xD4432C", VA = "0xD4432C")]
		private void Read()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xD44464", Offset = "0xD44464", VA = "0xD44464")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xD444C0", Offset = "0xD444C0", VA = "0xD444C0")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xD44B08", Offset = "0xD44B08", VA = "0xD44B08")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xD4491C", Offset = "0xD4491C", VA = "0xD4491C")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xD44DAC", Offset = "0xD44DAC", VA = "0xD44DAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xD44ED8", Offset = "0xD44ED8", VA = "0xD44ED8")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xD44EF4", Offset = "0xD44EF4", VA = "0xD44EF4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xD44F58", Offset = "0xD44F58", VA = "0xD44F58", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xD45294", Offset = "0xD45294", VA = "0xD45294")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xD45384", Offset = "0xD45384", VA = "0xD45384")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000C8")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xD455EC", Offset = "0xD455EC", VA = "0xD455EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C9")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0xD4566C", Offset = "0xD4566C", VA = "0xD4566C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xD4538C", Offset = "0xD4538C", VA = "0xD4538C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xD453FC", Offset = "0xD453FC", VA = "0xD453FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xD456EC", Offset = "0xD456EC", VA = "0xD456EC")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xD456F4", Offset = "0xD456F4", VA = "0xD456F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xD45B50", Offset = "0xD45B50", VA = "0xD45B50")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xD45B58", Offset = "0xD45B58", VA = "0xD45B58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xD45C10", Offset = "0xD45C10", VA = "0xD45C10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xD4606C", Offset = "0xD4606C", VA = "0xD4606C")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xD4610C", Offset = "0xD4610C", VA = "0xD4610C")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FC")]
		public class Limb
		{
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xD462A0", Offset = "0xD462A0", VA = "0xD462A0")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0xD463C4", Offset = "0xD463C4", VA = "0xD463C4")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xD4617C", Offset = "0xD4617C", VA = "0xD4617C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xD46318", Offset = "0xD46318", VA = "0xD46318")]
		private void Start()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xD463B0", Offset = "0xD463B0", VA = "0xD463B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xD463B4", Offset = "0xD463B4", VA = "0xD463B4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xD463D4", Offset = "0xD463D4", VA = "0xD463D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xD4643C", Offset = "0xD4643C", VA = "0xD4643C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xD46510", Offset = "0xD46510", VA = "0xD46510")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xD46518", Offset = "0xD46518", VA = "0xD46518")]
		private void Start()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xD46570", Offset = "0xD46570", VA = "0xD46570")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xD46708", Offset = "0xD46708", VA = "0xD46708")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xD46710", Offset = "0xD46710", VA = "0xD46710")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xD467F0", Offset = "0xD467F0", VA = "0xD467F0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xD4687C", Offset = "0xD4687C", VA = "0xD4687C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xD46D50", Offset = "0xD46D50", VA = "0xD46D50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xD46E7C", Offset = "0xD46E7C", VA = "0xD46E7C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xD46E84", Offset = "0xD46E84", VA = "0xD46E84")]
		private void Start()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xD47020", Offset = "0xD47020", VA = "0xD47020")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xD4702C", Offset = "0xD4702C", VA = "0xD4702C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xD472EC", Offset = "0xD472EC", VA = "0xD472EC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xD47588", Offset = "0xD47588", VA = "0xD47588")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xD470F0", Offset = "0xD470F0", VA = "0xD470F0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xD48240", Offset = "0xD48240", VA = "0xD48240")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xD48260", Offset = "0xD48260", VA = "0xD48260")]
		private void Start()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0xD482F0", Offset = "0xD482F0", VA = "0xD482F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0xD483EC", Offset = "0xD483EC", VA = "0xD483EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xD48498", Offset = "0xD48498", VA = "0xD48498")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000767")]
		[Address(RVA = "0xD484A8", Offset = "0xD484A8", VA = "0xD484A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xD485F8", Offset = "0xD485F8", VA = "0xD485F8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xD4875C", Offset = "0xD4875C", VA = "0xD4875C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xD4876C", Offset = "0xD4876C", VA = "0xD4876C")]
		private void Start()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xD48938", Offset = "0xD48938", VA = "0xD48938")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xD48D48", Offset = "0xD48D48", VA = "0xD48D48")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xD48D58", Offset = "0xD48D58", VA = "0xD48D58")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xD48E40", Offset = "0xD48E40", VA = "0xD48E40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xD48F2C", Offset = "0xD48F2C", VA = "0xD48F2C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xD48F34", Offset = "0xD48F34", VA = "0xD48F34")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xD49434", Offset = "0xD49434", VA = "0xD49434")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xD4943C", Offset = "0xD4943C", VA = "0xD4943C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xD49494", Offset = "0xD49494", VA = "0xD49494")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xD49740", Offset = "0xD49740", VA = "0xD49740")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class Partner
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000CA")]
			private Transform neck
			{
				[Token(Token = "0x600077A")]
				[Address(RVA = "0xD49F4C", Offset = "0xD49F4C", VA = "0xD49F4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0xD49770", Offset = "0xD49770", VA = "0xD49770")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0xD497EC", Offset = "0xD497EC", VA = "0xD497EC")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xD49DE4", Offset = "0xD49DE4", VA = "0xD49DE4")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0xD49F98", Offset = "0xD49F98", VA = "0xD49F98")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(1f, 4f)]
		public int iterations;

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xD49748", Offset = "0xD49748", VA = "0xD49748")]
		private void Start()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xD49790", Offset = "0xD49790", VA = "0xD49790")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xD49DD4", Offset = "0xD49DD4", VA = "0xD49DD4")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public enum Mode
		{
			[Token(Token = "0x4000783")]
			Position,
			[Token(Token = "0x4000784")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x200010B")]
		public class Absorber
		{
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xD4A124", Offset = "0xD4A124", VA = "0xD4A124")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xD4A30C", Offset = "0xD4A30C", VA = "0xD4A30C")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xD4A330", Offset = "0xD4A330", VA = "0xD4A330")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xD4A440", Offset = "0xD4A440", VA = "0xD4A440")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0xD4A5F8", Offset = "0xD4A5F8", VA = "0xD4A5F8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xD49FAC", Offset = "0xD49FAC", VA = "0xD49FAC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xD4A0A4", Offset = "0xD4A0A4", VA = "0xD4A0A4")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xD4A200", Offset = "0xD4A200", VA = "0xD4A200", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xD4A3C4", Offset = "0xD4A3C4", VA = "0xD4A3C4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xD4A4B0", Offset = "0xD4A4B0", VA = "0xD4A4B0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xD4A5E8", Offset = "0xD4A5E8", VA = "0xD4A5E8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xD4A658", Offset = "0xD4A658", VA = "0xD4A658")]
		private void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xD4A6D0", Offset = "0xD4A6D0", VA = "0xD4A6D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xD4A7A0", Offset = "0xD4A7A0", VA = "0xD4A7A0")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xD4A8E8", Offset = "0xD4A8E8", VA = "0xD4A8E8")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200010E")]
		public class EffectorLink
		{
			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000790")]
			[Address(RVA = "0xD4AE70", Offset = "0xD4AE70", VA = "0xD4AE70")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Optional. Assign the bone Transform that is closest to this OffsetEffector to be able to call OffsetEffector.Anchor() in LateUpdate to match its position and rotation to animation.")]
		public Transform anchor;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 posRelToAnchor;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion rotRelToAnchor;

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xD4A8FC", Offset = "0xD4A8FC", VA = "0xD4A8FC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xD4AB44", Offset = "0xD4AB44", VA = "0xD4AB44", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xD4ACBC", Offset = "0xD4ACBC", VA = "0xD4ACBC")]
		public void Anchor()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xD4AE18", Offset = "0xD4AE18", VA = "0xD4AE18")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight of this script.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xD4AE80", Offset = "0xD4AE80", VA = "0xD4AE80")]
		private void Start()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xD4B194", Offset = "0xD4B194", VA = "0xD4B194")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xD4B990", Offset = "0xD4B990", VA = "0xD4B990")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000CB")]
		private bool holding
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xD4BD88", Offset = "0xD4BD88", VA = "0xD4BD88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		private bool holdingLeft
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0xD4BE58", Offset = "0xD4BE58", VA = "0xD4BE58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private bool holdingRight
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0xD4BDB0", Offset = "0xD4BDB0", VA = "0xD4BDB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xD4B9FC", Offset = "0xD4B9FC", VA = "0xD4B9FC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000795")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xD4BF00", Offset = "0xD4BF00", VA = "0xD4BF00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xD4C0F0", Offset = "0xD4C0F0", VA = "0xD4C0F0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xD4C260", Offset = "0xD4C260", VA = "0xD4C260")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xD4C330", Offset = "0xD4C330", VA = "0xD4C330")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xD4C45C", Offset = "0xD4C45C", VA = "0xD4C45C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0xD4C5DC", Offset = "0xD4C5DC", VA = "0xD4C5DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xD4C818", Offset = "0xD4C818", VA = "0xD4C818")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xD4C82C", Offset = "0xD4C82C", VA = "0xD4C82C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xD4CB10", Offset = "0xD4CB10", VA = "0xD4CB10")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xD4CB24", Offset = "0xD4CB24", VA = "0xD4CB24", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xD4CC38", Offset = "0xD4CC38", VA = "0xD4CC38")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xD4CC4C", Offset = "0xD4CC4C", VA = "0xD4CC4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xD4CCE4", Offset = "0xD4CCE4", VA = "0xD4CCE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xD4CDFC", Offset = "0xD4CDFC", VA = "0xD4CDFC")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xD4CE04", Offset = "0xD4CE04", VA = "0xD4CE04")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xD4CE5C", Offset = "0xD4CE5C", VA = "0xD4CE5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xD4CEA8", Offset = "0xD4CEA8", VA = "0xD4CEA8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xD4CF40", Offset = "0xD4CF40", VA = "0xD4CF40")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000116")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0xD4D2D0", Offset = "0xD4D2D0", VA = "0xD4D2D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0xD4D318", Offset = "0xD4D318", VA = "0xD4D318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xD4D0EC", Offset = "0xD4D0EC", VA = "0xD4D0EC")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xD4D124", Offset = "0xD4D124", VA = "0xD4D124", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xD4D128", Offset = "0xD4D128", VA = "0xD4D128", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xD4D2D8", Offset = "0xD4D2D8", VA = "0xD4D2D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xD4CF50", Offset = "0xD4CF50", VA = "0xD4CF50")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xD4D014", Offset = "0xD4D014", VA = "0xD4D014")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xD4D068", Offset = "0xD4D068", VA = "0xD4D068")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xD4D114", Offset = "0xD4D114", VA = "0xD4D114")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007BB")]
				[Address(RVA = "0xD4D5BC", Offset = "0xD4D5BC", VA = "0xD4D5BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007BD")]
				[Address(RVA = "0xD4D604", Offset = "0xD4D604", VA = "0xD4D604", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xD4D448", Offset = "0xD4D448", VA = "0xD4D448")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xD4D478", Offset = "0xD4D478", VA = "0xD4D478", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xD4D47C", Offset = "0xD4D47C", VA = "0xD4D47C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xD4D5C4", Offset = "0xD4D5C4", VA = "0xD4D5C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xD4D320", Offset = "0xD4D320", VA = "0xD4D320")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xD4D3D4", Offset = "0xD4D3D4", VA = "0xD4D3D4")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xD4D470", Offset = "0xD4D470", VA = "0xD4D470")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public class EffectorLink
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x40007DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xD4D670", Offset = "0xD4D670", VA = "0xD4D670")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C3")]
			[Address(RVA = "0xD4E244", Offset = "0xD4E244", VA = "0xD4E244")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xD4DA78", Offset = "0xD4DA78", VA = "0xD4DA78")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0xD4E32C", Offset = "0xD4E32C", VA = "0xD4E32C")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xD4E4A8", Offset = "0xD4E4A8", VA = "0xD4E4A8")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xD4E534", Offset = "0xD4E534", VA = "0xD4E534")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xD4E5BC", Offset = "0xD4E5BC", VA = "0xD4E5BC")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0xD4E030", Offset = "0xD4E030", VA = "0xD4E030")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xD4E644", Offset = "0xD4E644", VA = "0xD4E644")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xD4D60C", Offset = "0xD4D60C", VA = "0xD4D60C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xD4DA18", Offset = "0xD4DA18", VA = "0xD4DA18")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xD4DF80", Offset = "0xD4DF80", VA = "0xD4DF80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xD4E23C", Offset = "0xD4E23C", VA = "0xD4E23C")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("The amount of motion to transfer.")]
		public float transferMotion;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xD4E680", Offset = "0xD4E680", VA = "0xD4E680")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xD4E6B0", Offset = "0xD4E6B0", VA = "0xD4E6B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xD4E760", Offset = "0xD4E760", VA = "0xD4E760")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Left hand poser (poses fingers to match the left hand target).")]
		public Poser leftHandPoser;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of pinning the left hand to the prop.")]
		public float leftHandWeight;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xD4E774", Offset = "0xD4E774", VA = "0xD4E774")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xD4E944", Offset = "0xD4E944", VA = "0xD4E944")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xD4EC3C", Offset = "0xD4EC3C", VA = "0xD4EC3C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xD4EDDC", Offset = "0xD4EDDC", VA = "0xD4EDDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xD4EF08", Offset = "0xD4EF08", VA = "0xD4EF08")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xD4EF1C", Offset = "0xD4EF1C", VA = "0xD4EF1C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xD4F034", Offset = "0xD4F034", VA = "0xD4F034")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xD4F1FC", Offset = "0xD4F1FC", VA = "0xD4F1FC")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xD4F218", Offset = "0xD4F218", VA = "0xD4F218")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xD4F420", Offset = "0xD4F420", VA = "0xD4F420")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xD4F48C", Offset = "0xD4F48C", VA = "0xD4F48C")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0xD4FBFC", Offset = "0xD4FBFC", VA = "0xD4FBFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0xD4FC44", Offset = "0xD4FC44", VA = "0xD4FC44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0xD4F884", Offset = "0xD4F884", VA = "0xD4F884")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0xD4FA74", Offset = "0xD4FA74", VA = "0xD4FA74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0xD4FA78", Offset = "0xD4FA78", VA = "0xD4FA78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0xD4FC04", Offset = "0xD4FC04", VA = "0xD4FC04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xD4F494", Offset = "0xD4F494", VA = "0xD4F494")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xD4F5D0", Offset = "0xD4F5D0", VA = "0xD4F5D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xD4F55C", Offset = "0xD4F55C", VA = "0xD4F55C")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xD4F8AC", Offset = "0xD4F8AC", VA = "0xD4F8AC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xD4F984", Offset = "0xD4F984", VA = "0xD4F984")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xD4FA58", Offset = "0xD4FA58", VA = "0xD4FA58")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xD4FC4C", Offset = "0xD4FC4C", VA = "0xD4FC4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xD4FCB4", Offset = "0xD4FCB4", VA = "0xD4FCB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xD4FD60", Offset = "0xD4FD60", VA = "0xD4FD60")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000123")]
		public class Part
		{
			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xD4FDD4", Offset = "0xD4FDD4", VA = "0xD4FDD4")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0xD4FF10", Offset = "0xD4FF10", VA = "0xD4FF10")]
			public Part()
			{
			}
		}

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xD4FD70", Offset = "0xD4FD70", VA = "0xD4FD70")]
		private void Update()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xD4FF08", Offset = "0xD4FF08", VA = "0xD4FF08")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xD4FF18", Offset = "0xD4FF18", VA = "0xD4FF18")]
		private void Update()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xD50068", Offset = "0xD50068", VA = "0xD50068")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xD501CC", Offset = "0xD501CC", VA = "0xD501CC")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class VRController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000126")]
		public enum InputMode
		{
			[Token(Token = "0x4000810")]
			Input,
			[Token(Token = "0x4000811")]
			WASDOnly
		}

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputMode inputMode;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VRIK ik;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float walkSpeed;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float runSpeed;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float walkForwardSpeedMlp;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float runForwardSpeedMlp;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 smoothInput;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 smoothInputV;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xD501DC", Offset = "0xD501DC", VA = "0xD501DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xD503D0", Offset = "0xD503D0", VA = "0xD503D0")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xD50718", Offset = "0xD50718", VA = "0xD50718")]
		public VRController()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class VRIKArmMocap : MonoBehaviour
	{
		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftElbowTarget;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightElbowTarget;

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xD5072C", Offset = "0xD5072C", VA = "0xD5072C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xD5080C", Offset = "0xD5080C", VA = "0xD5080C")]
		private void AfterVRIK()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xD50884", Offset = "0xD50884", VA = "0xD50884")]
		private static void UpdateArm(Transform upperArm, Transform forearm, Transform hand, Transform elbowTarget, Transform handTarget)
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xD50B90", Offset = "0xD50B90", VA = "0xD50B90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xD50CBC", Offset = "0xD50CBC", VA = "0xD50CBC")]
		public VRIKArmMocap()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xD51CC4", Offset = "0xD51CC4", VA = "0xD51CC4")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xD51D1C", Offset = "0xD51D1C", VA = "0xD51D1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xD51EB0", Offset = "0xD51EB0", VA = "0xD51EB0")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xD51F2C", Offset = "0xD51F2C", VA = "0xD51F2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xD52090", Offset = "0xD52090", VA = "0xD52090")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xD52104", Offset = "0xD52104", VA = "0xD52104")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xD52154", Offset = "0xD52154", VA = "0xD52154")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xD5232C", Offset = "0xD5232C", VA = "0xD5232C")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xD52384", Offset = "0xD52384", VA = "0xD52384")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xD528B4", Offset = "0xD528B4", VA = "0xD528B4")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000D4")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0xD52930", Offset = "0xD52930", VA = "0xD52930", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xD52910", Offset = "0xD52910", VA = "0xD52910", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xD52938", Offset = "0xD52938", VA = "0xD52938")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xD52998", Offset = "0xD52998", VA = "0xD52998", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xD52B1C", Offset = "0xD52B1C", VA = "0xD52B1C", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xD52D98", Offset = "0xD52D98", VA = "0xD52D98", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xD52B2C", Offset = "0xD52B2C", VA = "0xD52B2C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xD52DA8", Offset = "0xD52DA8", VA = "0xD52DA8")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xD52DC0", Offset = "0xD52DC0", VA = "0xD52DC0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xD52E20", Offset = "0xD52E20", VA = "0xD52E20", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xD52EB0", Offset = "0xD52EB0", VA = "0xD52EB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xD52FD4", Offset = "0xD52FD4", VA = "0xD52FD4")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000844")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000845")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000D5")]
		public override bool animationGrounded
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0xD53090", Offset = "0xD53090", VA = "0xD53090", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xD52FEC", Offset = "0xD52FEC", VA = "0xD52FEC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xD53074", Offset = "0xD53074", VA = "0xD53074", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xD53184", Offset = "0xD53184", VA = "0xD53184", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xD53574", Offset = "0xD53574", VA = "0xD53574")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xD537B8", Offset = "0xD537B8", VA = "0xD537B8")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		[Header("Base Parameters")]
		public Transform gravityTarget;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000853")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x6000813")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xD537DC", Offset = "0xD537DC", VA = "0xD537DC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xD539C8", Offset = "0xD539C8", VA = "0xD539C8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xD53BF4", Offset = "0xD53BF4", VA = "0xD53BF4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xD53D94", Offset = "0xD53D94", VA = "0xD53D94")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xD53DF4", Offset = "0xD53DF4", VA = "0xD53DF4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xD53F58", Offset = "0xD53F58", VA = "0xD53F58")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xD5415C", Offset = "0xD5415C", VA = "0xD5415C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xD54180", Offset = "0xD54180", VA = "0xD54180")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xD541A4", Offset = "0xD541A4", VA = "0xD541A4")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xD542F0", Offset = "0xD542F0", VA = "0xD542F0")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000131")]
		public enum MoveMode
		{
			[Token(Token = "0x4000892")]
			Directional,
			[Token(Token = "0x4000893")]
			Strafe
		}

		[Token(Token = "0x2000132")]
		public struct AnimState
		{
			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000133")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000835")]
				[Address(RVA = "0xD56E0C", Offset = "0xD56E0C", VA = "0xD56E0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000837")]
				[Address(RVA = "0xD56E54", Offset = "0xD56E54", VA = "0xD56E54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xD56BCC", Offset = "0xD56BCC", VA = "0xD56BCC")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0xD56D08", Offset = "0xD56D08", VA = "0xD56D08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xD56D0C", Offset = "0xD56D0C", VA = "0xD56D0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xD56E14", Offset = "0xD56E14", VA = "0xD56E14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000D6")]
		public bool fullRootMotion
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xD54310", Offset = "0xD54310", VA = "0xD54310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0xD54318", Offset = "0xD54318", VA = "0xD54318")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool onGround
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0xD54324", Offset = "0xD54324", VA = "0xD54324")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xD5432C", Offset = "0xD5432C", VA = "0xD5432C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xD54338", Offset = "0xD54338", VA = "0xD54338", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xD54524", Offset = "0xD54524", VA = "0xD54524")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xD545A8", Offset = "0xD545A8", VA = "0xD545A8", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xD546BC", Offset = "0xD546BC", VA = "0xD546BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xD55750", Offset = "0xD55750", VA = "0xD55750", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xD55BE0", Offset = "0xD55BE0", VA = "0xD55BE0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xD54DB0", Offset = "0xD54DB0", VA = "0xD54DB0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xD55CB8", Offset = "0xD55CB8", VA = "0xD55CB8")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xD56340", Offset = "0xD56340", VA = "0xD56340")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xD557DC", Offset = "0xD557DC", VA = "0xD557DC")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xD56438", Offset = "0xD56438", VA = "0xD56438", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xD568B8", Offset = "0xD568B8", VA = "0xD568B8")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xD569E0", Offset = "0xD569E0", VA = "0xD569E0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xD56B34", Offset = "0xD56B34", VA = "0xD56B34")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__79))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xD551E4", Offset = "0xD551E4", VA = "0xD551E4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xD56BF4", Offset = "0xD56BF4", VA = "0xD56BF4")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000135")]
		public enum RotationMode
		{
			[Token(Token = "0x40008AF")]
			Smooth,
			[Token(Token = "0x40008B0")]
			Linear
		}

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000DA")]
		public bool isGrounded
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0xD56E5C", Offset = "0xD56E5C", VA = "0xD56E5C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000839")]
			[Address(RVA = "0xD56E64", Offset = "0xD56E64", VA = "0xD56E64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xD56E70", Offset = "0xD56E70", VA = "0xD56E70")]
		private void Start()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xD56F18", Offset = "0xD56F18", VA = "0xD56F18")]
		private void Update()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xD57530", Offset = "0xD57530", VA = "0xD57530")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xD56F60", Offset = "0xD56F60", VA = "0xD56F60")]
		private void Rotate()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xD572C8", Offset = "0xD572C8", VA = "0xD572C8")]
		private void Move()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xD57560", Offset = "0xD57560", VA = "0xD57560")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xD575F8", Offset = "0xD575F8", VA = "0xD575F8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xD57678", Offset = "0xD57678", VA = "0xD57678")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xD576A0", Offset = "0xD576A0", VA = "0xD576A0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xD577E8", Offset = "0xD577E8", VA = "0xD577E8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xD57E60", Offset = "0xD57E60", VA = "0xD57E60")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xD5804C", Offset = "0xD5804C", VA = "0xD5804C")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000138")]
		public struct State
		{
			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xD576DC", Offset = "0xD576DC", VA = "0xD576DC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xD58078", Offset = "0xD58078", VA = "0xD58078", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xD58068", Offset = "0xD58068", VA = "0xD58068")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x6000849")]
		[Address(RVA = "0xD583BC", Offset = "0xD583BC", VA = "0xD583BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xD583F4", Offset = "0xD583F4", VA = "0xD583F4")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200013A")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xD583FC", Offset = "0xD583FC", VA = "0xD583FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xD58424", Offset = "0xD58424", VA = "0xD58424")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xD584C8", Offset = "0xD584C8", VA = "0xD584C8")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200013B")]
	public class Navigator
	{
		[Token(Token = "0x200013C")]
		public enum State
		{
			[Token(Token = "0x40008D2")]
			Idle,
			[Token(Token = "0x40008D3")]
			Seeking,
			[Token(Token = "0x40008D4")]
			OnPath
		}

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000DB")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0xD584DC", Offset = "0xD584DC", VA = "0xD584DC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0xD584E8", Offset = "0xD584E8", VA = "0xD584E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public State state
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xD584F4", Offset = "0xD584F4", VA = "0xD584F4")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0xD584FC", Offset = "0xD584FC", VA = "0xD584FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xD57710", Offset = "0xD57710", VA = "0xD57710")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xD57A08", Offset = "0xD57A08", VA = "0xD57A08")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xD585DC", Offset = "0xD585DC", VA = "0xD585DC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xD58640", Offset = "0xD58640", VA = "0xD58640")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xD58504", Offset = "0xD58504", VA = "0xD58504")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xD58560", Offset = "0xD58560", VA = "0xD58560")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xD57E88", Offset = "0xD57E88", VA = "0xD57E88")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xD58774", Offset = "0xD58774", VA = "0xD58774")]
		public Navigator()
		{
		}
	}
}
