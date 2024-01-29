using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
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
			[Address(RVA = "0xA3C17C", Offset = "0xA3C17C", VA = "0xA3C17C")]
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
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
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
			[Address(RVA = "0xA3BE80", Offset = "0xA3BE80", VA = "0xA3BE80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0xA3BE88", Offset = "0xA3BE88", VA = "0xA3BE88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0xA3BE94", Offset = "0xA3BE94", VA = "0xA3BE94")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xA3BE9C", Offset = "0xA3BE9C", VA = "0xA3BE9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xA3BEA4", Offset = "0xA3BEA4", VA = "0xA3BEA4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0xA3BEAC", Offset = "0xA3BEAC", VA = "0xA3BEAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0xA3BD70", Offset = "0xA3BD70", VA = "0xA3BD70")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xA3BDB4", Offset = "0xA3BDB4", VA = "0xA3BDB4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xA3BDF8", Offset = "0xA3BDF8", VA = "0xA3BDF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xA3BE3C", Offset = "0xA3BE3C", VA = "0xA3BE3C")]
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
		[Address(RVA = "0xA3BEB4", Offset = "0xA3BEB4", VA = "0xA3BEB4")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xA3BEB8", Offset = "0xA3BEB8", VA = "0xA3BEB8")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xA3BEBC", Offset = "0xA3BEBC", VA = "0xA3BEBC")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xA3BEC0", Offset = "0xA3BEC0", VA = "0xA3BEC0")]
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
		[Address(RVA = "0xA3C184", Offset = "0xA3C184", VA = "0xA3C184")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xA3C5C8", Offset = "0xA3C5C8", VA = "0xA3C5C8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xA3C5D0", Offset = "0xA3C5D0", VA = "0xA3C5D0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xA3C80C", Offset = "0xA3C80C", VA = "0xA3C80C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xA3CA70", Offset = "0xA3CA70", VA = "0xA3CA70", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xA3CD88", Offset = "0xA3CD88", VA = "0xA3CD88", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xA3C3B0", Offset = "0xA3C3B0", VA = "0xA3C3B0")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xA3C468", Offset = "0xA3C468", VA = "0xA3C468")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xA3CFE8", Offset = "0xA3CFE8", VA = "0xA3CFE8")]
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
		[Address(RVA = "0xA3D050", Offset = "0xA3D050", VA = "0xA3D050")]
		public TQ()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xA3D058", Offset = "0xA3D058", VA = "0xA3D058")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000024")]
		[Address(RVA = "0xA3D0BC", Offset = "0xA3D0BC", VA = "0xA3D0BC")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA3D318", Offset = "0xA3D318", VA = "0xA3D318")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA3D988", Offset = "0xA3D988", VA = "0xA3D988")]
		public static TQ WorldSpaceIKGoalToBone(TQ goalTQ, Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA3DE50", Offset = "0xA3DE50", VA = "0xA3DE50")]
		public static TQ GetWorldSpaceIKGoal(BakerHumanoidQT ikQT, BakerHumanoidQT rootQT, float time, float humanScale)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA3D2F8", Offset = "0xA3D2F8", VA = "0xA3D2F8")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA3E03C", Offset = "0xA3E03C", VA = "0xA3E03C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA3E044", Offset = "0xA3E044", VA = "0xA3E044")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xA3E07C", Offset = "0xA3E07C", VA = "0xA3E07C")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA3E440", Offset = "0xA3E440", VA = "0xA3E440")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA3E620", Offset = "0xA3E620", VA = "0xA3E620")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA3E624", Offset = "0xA3E624", VA = "0xA3E624")]
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
		[Address(RVA = "0xA3E7B8", Offset = "0xA3E7B8", VA = "0xA3E7B8")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xA3EB1C", Offset = "0xA3EB1C", VA = "0xA3EB1C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xA3ED04", Offset = "0xA3ED04", VA = "0xA3ED04")]
		public Quaternion EvaluateRotation(float time)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xA3ED94", Offset = "0xA3ED94", VA = "0xA3ED94")]
		public Vector3 EvaluatePosition(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xA3DF74", Offset = "0xA3DF74", VA = "0xA3DF74")]
		public TQ Evaluate(float time)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xA3EE08", Offset = "0xA3EE08", VA = "0xA3EE08")]
		public void GetCurvesFromClip(AnimationClip clip, Animator animator)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xA3E984", Offset = "0xA3E984", VA = "0xA3E984")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xA3EE0C", Offset = "0xA3EE0C", VA = "0xA3EE0C")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xA3F19C", Offset = "0xA3F19C", VA = "0xA3F19C")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xA3F28C", Offset = "0xA3F28C", VA = "0xA3F28C")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xA3F370", Offset = "0xA3F370", VA = "0xA3F370")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xA3F3D8", Offset = "0xA3F3D8", VA = "0xA3F3D8")]
		public void SetRootLoopFrame(float time)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xA3F2F4", Offset = "0xA3F2F4", VA = "0xA3F2F4")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xA3F3DC", Offset = "0xA3F3DC", VA = "0xA3F3DC")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xA3F484", Offset = "0xA3F484", VA = "0xA3F484")]
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
		[Address(RVA = "0xA3F770", Offset = "0xA3F770", VA = "0xA3F770")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xA3F7E0", Offset = "0xA3F7E0", VA = "0xA3F7E0")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xA4027C", Offset = "0xA4027C", VA = "0xA4027C")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xA40324", Offset = "0xA40324", VA = "0xA40324")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xA40214", Offset = "0xA40214", VA = "0xA40214")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xA40418", Offset = "0xA40418", VA = "0xA40418")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xA40454", Offset = "0xA40454", VA = "0xA40454")]
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
		[Address(RVA = "0xA3C520", Offset = "0xA3C520", VA = "0xA3C520")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xA3C7F8", Offset = "0xA3C7F8", VA = "0xA3C7F8")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xA3CAD4", Offset = "0xA3CAD4", VA = "0xA3CAD4")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xA4045C", Offset = "0xA4045C", VA = "0xA4045C")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xA3C6A0", Offset = "0xA3C6A0", VA = "0xA3C6A0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xA406E4", Offset = "0xA406E4", VA = "0xA406E4")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xA3CDF4", Offset = "0xA3CDF4", VA = "0xA3CDF4")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xA3C878", Offset = "0xA3C878", VA = "0xA3C878")]
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
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
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
		[Address(RVA = "0xA4074C", Offset = "0xA4074C", VA = "0xA4074C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xA40CAC", Offset = "0xA40CAC", VA = "0xA40CAC", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xA40CC8", Offset = "0xA40CC8", VA = "0xA40CC8", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xA40DA0", Offset = "0xA40DA0", VA = "0xA40DA0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xA40E5C", Offset = "0xA40E5C", VA = "0xA40E5C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xA40FFC", Offset = "0xA40FFC", VA = "0xA40FFC", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xA41320", Offset = "0xA41320", VA = "0xA41320")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xA41400", Offset = "0xA41400", VA = "0xA41400")]
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
			[Address(RVA = "0xA414B0", Offset = "0xA414B0", VA = "0xA414B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xA414B8", Offset = "0xA414B8", VA = "0xA414B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xA414C0", Offset = "0xA414C0", VA = "0xA414C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xA414C8", Offset = "0xA414C8", VA = "0xA414C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0xA414D0", Offset = "0xA414D0", VA = "0xA414D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xA414D8", Offset = "0xA414D8", VA = "0xA414D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xA41F40", Offset = "0xA41F40", VA = "0xA41F40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xA414E0", Offset = "0xA414E0", VA = "0xA414E0")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xA41518", Offset = "0xA41518", VA = "0xA41518")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xA41520", Offset = "0xA41520", VA = "0xA41520", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xA41658", Offset = "0xA41658", VA = "0xA41658", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xA416A0", Offset = "0xA416A0", VA = "0xA416A0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xA416F8", Offset = "0xA416F8", VA = "0xA416F8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xA41750", Offset = "0xA41750", VA = "0xA41750")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xA41684", Offset = "0xA41684", VA = "0xA41684")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xA418DC", Offset = "0xA418DC", VA = "0xA418DC")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xA41F04", Offset = "0xA41F04", VA = "0xA41F04")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xA41FAC", Offset = "0xA41FAC", VA = "0xA41FAC")]
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
		[Address(RVA = "0xA42074", Offset = "0xA42074", VA = "0xA42074")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xA420A0", Offset = "0xA420A0", VA = "0xA420A0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xA422C4", Offset = "0xA422C4", VA = "0xA422C4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xA42300", Offset = "0xA42300", VA = "0xA42300")]
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
		[Address(RVA = "0xA4231C", Offset = "0xA4231C", VA = "0xA4231C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xA423FC", Offset = "0xA423FC", VA = "0xA423FC")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xA42434", Offset = "0xA42434", VA = "0xA42434")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA4257C", Offset = "0xA4257C", VA = "0xA4257C")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xA42530", Offset = "0xA42530", VA = "0xA42530")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xA42678", Offset = "0xA42678", VA = "0xA42678")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xA426BC", Offset = "0xA426BC", VA = "0xA426BC")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xA4297C", Offset = "0xA4297C", VA = "0xA4297C")]
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
			[Address(RVA = "0xA42CB0", Offset = "0xA42CB0", VA = "0xA42CB0")]
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
			[Address(RVA = "0xA429F8", Offset = "0xA429F8", VA = "0xA429F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xA42D24", Offset = "0xA42D24", VA = "0xA42D24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xA42984", Offset = "0xA42984", VA = "0xA42984")]
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
		[Address(RVA = "0xA42FDC", Offset = "0xA42FDC", VA = "0xA42FDC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA432A8", Offset = "0xA432A8", VA = "0xA432A8")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA434E4", Offset = "0xA434E4", VA = "0xA434E4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA43558", Offset = "0xA43558", VA = "0xA43558")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA435EC", Offset = "0xA435EC", VA = "0xA435EC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA43190", Offset = "0xA43190", VA = "0xA43190")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xA4345C", Offset = "0xA4345C", VA = "0xA4345C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA43D24", Offset = "0xA43D24", VA = "0xA43D24")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xA43B7C", Offset = "0xA43B7C", VA = "0xA43B7C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA43C50", Offset = "0xA43C50", VA = "0xA43C50")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xA437D4", Offset = "0xA437D4", VA = "0xA437D4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xA43870", Offset = "0xA43870", VA = "0xA43870")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA4390C", Offset = "0xA4390C", VA = "0xA4390C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xA439A8", Offset = "0xA439A8", VA = "0xA439A8")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xA43A44", Offset = "0xA43A44", VA = "0xA43A44")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xA43AE0", Offset = "0xA43AE0", VA = "0xA43AE0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA43F0C", Offset = "0xA43F0C", VA = "0xA43F0C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xA43700", Offset = "0xA43700", VA = "0xA43700")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xA43E88", Offset = "0xA43E88", VA = "0xA43E88")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xA43F6C", Offset = "0xA43F6C", VA = "0xA43F6C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA4402C", Offset = "0xA4402C", VA = "0xA4402C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA43E14", Offset = "0xA43E14", VA = "0xA43E14")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA43DA4", Offset = "0xA43DA4", VA = "0xA43DA4")]
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
				[Address(RVA = "0xA4AAE4", Offset = "0xA4AAE4", VA = "0xA4AAE4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xA4AAD0", Offset = "0xA4AAD0", VA = "0xA4AAD0")]
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
			[Address(RVA = "0xA46E1C", Offset = "0xA46E1C", VA = "0xA46E1C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xA47178", Offset = "0xA47178", VA = "0xA47178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xA47188", Offset = "0xA47188", VA = "0xA47188", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xA47514", Offset = "0xA47514", VA = "0xA47514", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xA478A4", Offset = "0xA478A4", VA = "0xA478A4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xA47FC8", Offset = "0xA47FC8", VA = "0xA47FC8")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xA47B38", Offset = "0xA47B38", VA = "0xA47B38")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xA48848", Offset = "0xA48848", VA = "0xA48848")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xA48934", Offset = "0xA48934", VA = "0xA48934")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xA49450", Offset = "0xA49450", VA = "0xA49450")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xA4925C", Offset = "0xA4925C", VA = "0xA4925C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xA48FFC", Offset = "0xA48FFC", VA = "0xA48FFC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xA489D0", Offset = "0xA489D0", VA = "0xA489D0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA49350", Offset = "0xA49350", VA = "0xA49350")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA49530", Offset = "0xA49530", VA = "0xA49530")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA4A0D8", Offset = "0xA4A0D8", VA = "0xA4A0D8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA49B80", Offset = "0xA49B80", VA = "0xA49B80")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xA4A424", Offset = "0xA4A424", VA = "0xA4A424")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xA49EE0", Offset = "0xA49EE0", VA = "0xA49EE0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA4A42C", Offset = "0xA4A42C", VA = "0xA4A42C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA4A434", Offset = "0xA4A434", VA = "0xA4A434")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA4A5F4", Offset = "0xA4A5F4", VA = "0xA4A5F4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xA4AA68", Offset = "0xA4AA68", VA = "0xA4AA68")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA47AB8", Offset = "0xA47AB8", VA = "0xA47AB8")]
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
		[Address(RVA = "0xA4AAEC", Offset = "0xA4AAEC", VA = "0xA4AAEC")]
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
		[Address(RVA = "0xA4AAF4", Offset = "0xA4AAF4", VA = "0xA4AAF4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA4ABEC", Offset = "0xA4ABEC", VA = "0xA4ABEC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class Hierarchy
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA4A9E4", Offset = "0xA4A9E4", VA = "0xA4A9E4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA4A8D8", Offset = "0xA4A8D8", VA = "0xA4A8D8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA48B34", Offset = "0xA48B34", VA = "0xA48B34")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA4914C", Offset = "0xA4914C", VA = "0xA4914C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA48DB4", Offset = "0xA48DB4", VA = "0xA48DB4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA4ABFC", Offset = "0xA4ABFC", VA = "0xA4ABFC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA48C64", Offset = "0xA48C64", VA = "0xA48C64")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xA4ACF0", Offset = "0xA4ACF0", VA = "0xA4ACF0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xA4B05C", Offset = "0xA4B05C", VA = "0xA4B05C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xA4AE54", Offset = "0xA4AE54", VA = "0xA4AE54")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xA4B1E4", Offset = "0xA4B1E4", VA = "0xA4B1E4")]
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
		[Address(RVA = "0xA4B1EC", Offset = "0xA4B1EC", VA = "0xA4B1EC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xA4B274", Offset = "0xA4B274", VA = "0xA4B274")]
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
		[Address(RVA = "0xA4B300", Offset = "0xA4B300", VA = "0xA4B300")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xA4BC88", Offset = "0xA4BC88", VA = "0xA4BC88")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xA4BCF8", Offset = "0xA4BCF8", VA = "0xA4BCF8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xA4B700", Offset = "0xA4B700", VA = "0xA4B700")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xA4B70C", Offset = "0xA4B70C", VA = "0xA4B70C")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xA4B730", Offset = "0xA4B730", VA = "0xA4B730")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xA4B76C", Offset = "0xA4B76C", VA = "0xA4B76C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xA4B784", Offset = "0xA4B784", VA = "0xA4B784")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xA4B798", Offset = "0xA4B798", VA = "0xA4B798")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xA4B7AC", Offset = "0xA4B7AC", VA = "0xA4B7AC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xA4B7BC", Offset = "0xA4B7BC", VA = "0xA4B7BC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA4B804", Offset = "0xA4B804", VA = "0xA4B804")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xA4B83C", Offset = "0xA4B83C", VA = "0xA4B83C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xA4B864", Offset = "0xA4B864", VA = "0xA4B864")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA4BD68", Offset = "0xA4BD68", VA = "0xA4BD68")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA4B898", Offset = "0xA4B898", VA = "0xA4B898")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA4B8C0", Offset = "0xA4B8C0", VA = "0xA4B8C0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA4B8F0", Offset = "0xA4B8F0", VA = "0xA4B8F0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xA4B924", Offset = "0xA4B924", VA = "0xA4B924")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xA4B968", Offset = "0xA4B968", VA = "0xA4B968")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xA4B9CC", Offset = "0xA4B9CC", VA = "0xA4B9CC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xA4BA30", Offset = "0xA4BA30", VA = "0xA4BA30")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xA4BA84", Offset = "0xA4BA84", VA = "0xA4BA84")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xA4BAD8", Offset = "0xA4BAD8", VA = "0xA4BAD8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xA4BB10", Offset = "0xA4BB10", VA = "0xA4BB10")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xA4BB44", Offset = "0xA4BB44", VA = "0xA4BB44")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xA4BD9C", Offset = "0xA4BD9C", VA = "0xA4BD9C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xA4BB88", Offset = "0xA4BB88", VA = "0xA4BB88")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xA4BC18", Offset = "0xA4BC18", VA = "0xA4BC18")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xA4BC48", Offset = "0xA4BC48", VA = "0xA4BC48")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xA4BE2C", Offset = "0xA4BE2C", VA = "0xA4BE2C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xA4BE34", Offset = "0xA4BE34", VA = "0xA4BE34")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xA4BE80", Offset = "0xA4BE80", VA = "0xA4BE80")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xA4BF3C", Offset = "0xA4BF3C", VA = "0xA4BF3C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xA4BE94", Offset = "0xA4BE94", VA = "0xA4BE94")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xA4BF50", Offset = "0xA4BF50", VA = "0xA4BF50")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xA4BFE0", Offset = "0xA4BFE0", VA = "0xA4BFE0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xA4C008", Offset = "0xA4C008", VA = "0xA4C008")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xA4C054", Offset = "0xA4C054", VA = "0xA4C054")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xA4C0BC", Offset = "0xA4C0BC", VA = "0xA4C0BC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xA4C218", Offset = "0xA4C218", VA = "0xA4C218")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xA4C350", Offset = "0xA4C350", VA = "0xA4C350")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xA4C3A8", Offset = "0xA4C3A8", VA = "0xA4C3A8")]
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
			[Address(RVA = "0xA4C3CC", Offset = "0xA4C3CC", VA = "0xA4C3CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xA4C3D4", Offset = "0xA4C3D4", VA = "0xA4C3D4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public object propValue
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xA4C3DC", Offset = "0xA4C3DC", VA = "0xA4C3DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xA4C3E4", Offset = "0xA4C3E4", VA = "0xA4C3E4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public object otherPropValue
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xA4C3EC", Offset = "0xA4C3EC", VA = "0xA4C3EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xA4C3F4", Offset = "0xA4C3F4", VA = "0xA4C3F4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool indent
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xA4C3FC", Offset = "0xA4C3FC", VA = "0xA4C3FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xA4C404", Offset = "0xA4C404", VA = "0xA4C404")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public ShowIfMode mode
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xA4C410", Offset = "0xA4C410", VA = "0xA4C410")]
			[CompilerGenerated]
			get
			{
				return default(ShowIfMode);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xA4C418", Offset = "0xA4C418", VA = "0xA4C418")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xA4C420", Offset = "0xA4C420", VA = "0xA4C420")]
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
			[Address(RVA = "0xA4C4A0", Offset = "0xA4C4A0", VA = "0xA4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xA4C4A8", Offset = "0xA4C4A8", VA = "0xA4C4A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public float max
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xA4C4B0", Offset = "0xA4C4B0", VA = "0xA4C4B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xA4C4B8", Offset = "0xA4C4B8", VA = "0xA4C4B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xA4C4C0", Offset = "0xA4C4C0", VA = "0xA4C4C0")]
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
		[Address(RVA = "0xA4C4EC", Offset = "0xA4C4EC", VA = "0xA4C4EC")]
		public ShowLargeHeaderIf(string name, string propertyName, [Optional] object propertyValue, [Optional] object otherPropertyValue, bool indent = false, ShowIfMode mode = ShowIfMode.Hidden)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xA4C5A8", Offset = "0xA4C5A8", VA = "0xA4C5A8")]
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
		[Address(RVA = "0xA4C670", Offset = "0xA4C670", VA = "0xA4C670")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xA4C6F8", Offset = "0xA4C6F8", VA = "0xA4C6F8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class QuaTools
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xA4C784", Offset = "0xA4C784", VA = "0xA4C784")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xA4C7DC", Offset = "0xA4C7DC", VA = "0xA4C7DC")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xA4C90C", Offset = "0xA4C90C", VA = "0xA4C90C")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xA4CA8C", Offset = "0xA4CA8C", VA = "0xA4CA8C")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xA4CB68", Offset = "0xA4CB68", VA = "0xA4CB68")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xA4CC44", Offset = "0xA4CC44", VA = "0xA4CC44")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xA4CE5C", Offset = "0xA4CE5C", VA = "0xA4CE5C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xA4CEA8", Offset = "0xA4CEA8", VA = "0xA4CEA8")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xA4CEF4", Offset = "0xA4CEF4", VA = "0xA4CEF4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xA4CFF8", Offset = "0xA4CFF8", VA = "0xA4CFF8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xA4D0FC", Offset = "0xA4D0FC", VA = "0xA4D0FC")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xA4D210", Offset = "0xA4D210", VA = "0xA4D210")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xA4D2B8", Offset = "0xA4D2B8", VA = "0xA4D2B8")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xA4D3C4", Offset = "0xA4D3C4", VA = "0xA4D3C4")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xA4D52C", Offset = "0xA4D52C", VA = "0xA4D52C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xA4D710", Offset = "0xA4D710", VA = "0xA4D710")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xA4D7E0", Offset = "0xA4D7E0", VA = "0xA4D7E0")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetAxis1, Vector3 targetAxis2, Vector3 axis1, Vector3 axis2)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xA4D964", Offset = "0xA4D964", VA = "0xA4D964")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xA4DA70", Offset = "0xA4DA70", VA = "0xA4DA70")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xA4DAC8", Offset = "0xA4DAC8", VA = "0xA4DAC8")]
		public static Quaternion MirrorYZ(Quaternion r, Quaternion space)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xA4DCEC", Offset = "0xA4DCEC", VA = "0xA4DCEC")]
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
			[Address(RVA = "0xA4DF10", Offset = "0xA4DF10", VA = "0xA4DF10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private bool isAnimated
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xA4E20C", Offset = "0xA4E20C", VA = "0xA4E20C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xA4DDF4", Offset = "0xA4DDF4", VA = "0xA4DDF4")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xA4DE88", Offset = "0xA4DE88", VA = "0xA4DE88", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xA4DE8C", Offset = "0xA4DE8C", VA = "0xA4DE8C", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xA4DE90", Offset = "0xA4DE90", VA = "0xA4DE90", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xA4DE94", Offset = "0xA4DE94", VA = "0xA4DE94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xA4DF0C", Offset = "0xA4DF0C", VA = "0xA4DF0C")]
		private void Start()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xA4DEBC", Offset = "0xA4DEBC", VA = "0xA4DEBC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xA4E1D0", Offset = "0xA4E1D0", VA = "0xA4E1D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xA4DFDC", Offset = "0xA4DFDC", VA = "0xA4DFDC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xA4E2A4", Offset = "0xA4E2A4", VA = "0xA4E2A4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xA4E2F0", Offset = "0xA4E2F0", VA = "0xA4E2F0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xA4E33C", Offset = "0xA4E33C", VA = "0xA4E33C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xA4E374", Offset = "0xA4E374", VA = "0xA4E374")]
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
		[Address(RVA = "0xA4E384", Offset = "0xA4E384", VA = "0xA4E384")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xA4E438", Offset = "0xA4E438", VA = "0xA4E438")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xA4E4EC", Offset = "0xA4E4EC", VA = "0xA4E4EC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xA4E5A0", Offset = "0xA4E5A0", VA = "0xA4E5A0")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0xA4E5A8", Offset = "0xA4E5A8", VA = "0xA4E5A8")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xA4E5B0", Offset = "0xA4E5B0", VA = "0xA4E5B0")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA4E640", Offset = "0xA4E640", VA = "0xA4E640")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA4E6D4", Offset = "0xA4E6D4", VA = "0xA4E6D4")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA4E784", Offset = "0xA4E784", VA = "0xA4E784")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002F")]
	public static class V3Tools
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA4E7E0", Offset = "0xA4E7E0", VA = "0xA4E7E0")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA4E800", Offset = "0xA4E800", VA = "0xA4E800")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA4E8D4", Offset = "0xA4E8D4", VA = "0xA4E8D4")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA4E98C", Offset = "0xA4E98C", VA = "0xA4E98C")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA4E9E8", Offset = "0xA4E9E8", VA = "0xA4E9E8")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA4EA44", Offset = "0xA4EA44", VA = "0xA4EA44")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA4EB5C", Offset = "0xA4EB5C", VA = "0xA4EB5C")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA4EBB8", Offset = "0xA4EBB8", VA = "0xA4EBB8")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA4EBF0", Offset = "0xA4EBF0", VA = "0xA4EBF0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA4EDC0", Offset = "0xA4EDC0", VA = "0xA4EDC0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xA4EFC4", Offset = "0xA4EFC4", VA = "0xA4EFC4")]
		public static Vector3 Flatten(Vector3 v, Vector3 normal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA4F13C", Offset = "0xA4F13C", VA = "0xA4F13C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xA4F36C", Offset = "0xA4F36C", VA = "0xA4F36C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xA4F5BC", Offset = "0xA4F5BC", VA = "0xA4F5BC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xA4F814", Offset = "0xA4F814", VA = "0xA4F814")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xA4F9C0", Offset = "0xA4F9C0", VA = "0xA4F9C0")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xA4FBB8", Offset = "0xA4FBB8", VA = "0xA4FBB8")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xA4FC34", Offset = "0xA4FC34", VA = "0xA4FC34")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xA4FCC4", Offset = "0xA4FCC4", VA = "0xA4FCC4")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xA4FD5C", Offset = "0xA4FD5C", VA = "0xA4FD5C")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xA4FD4C", Offset = "0xA4FD4C", VA = "0xA4FD4C")]
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
		[Address(RVA = "0xA4FDD8", Offset = "0xA4FDD8", VA = "0xA4FDD8")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xA48794", Offset = "0xA48794", VA = "0xA48794")]
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
		[Address(RVA = "0xA4FF94", Offset = "0xA4FF94", VA = "0xA4FF94")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xA4FFD8", Offset = "0xA4FFD8", VA = "0xA4FFD8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xA5001C", Offset = "0xA5001C", VA = "0xA5001C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xA50060", Offset = "0xA50060", VA = "0xA50060")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xA500A4", Offset = "0xA500A4", VA = "0xA500A4")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xA5013C", Offset = "0xA5013C", VA = "0xA5013C")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xA50158", Offset = "0xA50158", VA = "0xA50158")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xA50184", Offset = "0xA50184", VA = "0xA50184")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA501B0", Offset = "0xA501B0", VA = "0xA501B0")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xA501EC", Offset = "0xA501EC", VA = "0xA501EC")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA5022C", Offset = "0xA5022C", VA = "0xA5022C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA5024C", Offset = "0xA5024C", VA = "0xA5024C")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xA5026C", Offset = "0xA5026C", VA = "0xA5026C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xA50290", Offset = "0xA50290", VA = "0xA50290")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xA502B8", Offset = "0xA502B8", VA = "0xA502B8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xA502E0", Offset = "0xA502E0", VA = "0xA502E0")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xA500C0", Offset = "0xA500C0", VA = "0xA500C0")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xA50304", Offset = "0xA50304", VA = "0xA50304")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xA50310", Offset = "0xA50310", VA = "0xA50310")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xA5031C", Offset = "0xA5031C", VA = "0xA5031C")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xA505D0", Offset = "0xA505D0", VA = "0xA505D0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xA5066C", Offset = "0xA5066C", VA = "0xA5066C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xA50990", Offset = "0xA50990", VA = "0xA50990", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xA50DFC", Offset = "0xA50DFC", VA = "0xA50DFC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xA50E20", Offset = "0xA50E20", VA = "0xA50E20")]
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
			[Address(RVA = "0xA50458", Offset = "0xA50458", VA = "0xA50458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xA510BC", Offset = "0xA510BC", VA = "0xA510BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xA5081C", Offset = "0xA5081C", VA = "0xA5081C")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xA50ED0", Offset = "0xA50ED0", VA = "0xA50ED0")]
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
			[Address(RVA = "0xA512E4", Offset = "0xA512E4", VA = "0xA512E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000166")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xA51344", Offset = "0xA51344", VA = "0xA51344")]
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
		[Address(RVA = "0xA5134C", Offset = "0xA5134C", VA = "0xA5134C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xA513E4", Offset = "0xA513E4", VA = "0xA513E4")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xA513EC", Offset = "0xA513EC", VA = "0xA513EC")]
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
			[Address(RVA = "0xA51520", Offset = "0xA51520", VA = "0xA51520")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xA5141C", Offset = "0xA5141C", VA = "0xA5141C", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xA5157C", Offset = "0xA5157C", VA = "0xA5157C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xA51584", Offset = "0xA51584", VA = "0xA51584")]
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
		[Address(RVA = "0xA515B4", Offset = "0xA515B4", VA = "0xA515B4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xA51630", Offset = "0xA51630", VA = "0xA51630")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xA51638", Offset = "0xA51638", VA = "0xA51638")]
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
			[Address(RVA = "0xA5176C", Offset = "0xA5176C", VA = "0xA5176C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xA51668", Offset = "0xA51668", VA = "0xA51668", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xA517C4", Offset = "0xA517C4", VA = "0xA517C4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xA517CC", Offset = "0xA517CC", VA = "0xA517CC")]
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
		[Address(RVA = "0xA517FC", Offset = "0xA517FC", VA = "0xA517FC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xA5093C", Offset = "0xA5093C", VA = "0xA5093C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xA50B04", Offset = "0xA50B04", VA = "0xA50B04")]
		public void Update()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xA512DC", Offset = "0xA512DC", VA = "0xA512DC")]
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
			[Address(RVA = "0xA5185C", Offset = "0xA5185C", VA = "0xA5185C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xA51864", Offset = "0xA51864", VA = "0xA51864")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xA51870", Offset = "0xA51870", VA = "0xA51870")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xA51890", Offset = "0xA51890", VA = "0xA51890")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xA518B0", Offset = "0xA518B0", VA = "0xA518B0")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xA518D0", Offset = "0xA518D0", VA = "0xA518D0")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xA518F0", Offset = "0xA518F0", VA = "0xA518F0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xA519E8", Offset = "0xA519E8", VA = "0xA519E8")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xA5206C", Offset = "0xA5206C", VA = "0xA5206C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xA52138", Offset = "0xA52138", VA = "0xA52138")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xA521F0", Offset = "0xA521F0", VA = "0xA521F0")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xA52790", Offset = "0xA52790", VA = "0xA52790")]
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
			[Address(RVA = "0xA537A0", Offset = "0xA537A0", VA = "0xA537A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xA537A8", Offset = "0xA537A8", VA = "0xA537A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xA537B4", Offset = "0xA537B4", VA = "0xA537B4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xA5382C", Offset = "0xA5382C", VA = "0xA5382C")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xA53B8C", Offset = "0xA53B8C", VA = "0xA53B8C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xA53D48", Offset = "0xA53D48", VA = "0xA53D48")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xA53A9C", Offset = "0xA53A9C", VA = "0xA53A9C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xA53EC8", Offset = "0xA53EC8", VA = "0xA53EC8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xA53F78", Offset = "0xA53F78", VA = "0xA53F78")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xA53FE0", Offset = "0xA53FE0", VA = "0xA53FE0")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xA5404C", Offset = "0xA5404C", VA = "0xA5404C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xA540AC", Offset = "0xA540AC", VA = "0xA540AC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xA540B0", Offset = "0xA540B0", VA = "0xA540B0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xA540C4", Offset = "0xA540C4", VA = "0xA540C4")]
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
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
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
			[Address(RVA = "0xA54130", Offset = "0xA54130", VA = "0xA54130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xA54138", Offset = "0xA54138", VA = "0xA54138")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000194")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xA54144", Offset = "0xA54144", VA = "0xA54144")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xA543F4", Offset = "0xA543F4", VA = "0xA543F4")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xA54208", Offset = "0xA54208", VA = "0xA54208")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xA5441C", Offset = "0xA5441C", VA = "0xA5441C")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019B")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600019C")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xA54590", Offset = "0xA54590", VA = "0xA54590")]
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
		[Address(RVA = "0xA54894", Offset = "0xA54894", VA = "0xA54894", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xA548D8", Offset = "0xA548D8", VA = "0xA548D8", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xA5491C", Offset = "0xA5491C", VA = "0xA5491C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xA549FC", Offset = "0xA549FC", VA = "0xA549FC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xA54A9C", Offset = "0xA54A9C", VA = "0xA54A9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xA54AF0", Offset = "0xA54AF0", VA = "0xA54AF0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xA55110", Offset = "0xA55110", VA = "0xA55110")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xA55150", Offset = "0xA55150", VA = "0xA55150")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xA557C8", Offset = "0xA557C8", VA = "0xA557C8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xA558F0", Offset = "0xA558F0", VA = "0xA558F0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xA55AEC", Offset = "0xA55AEC", VA = "0xA55AEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xA55CC4", Offset = "0xA55CC4", VA = "0xA55CC4")]
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
			[Address(RVA = "0xA56B58", Offset = "0xA56B58", VA = "0xA56B58")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xA56B68", Offset = "0xA56B68", VA = "0xA56B68")]
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
		[Address(RVA = "0xA55D68", Offset = "0xA55D68", VA = "0xA55D68")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xA55DAC", Offset = "0xA55DAC", VA = "0xA55DAC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xA55DF0", Offset = "0xA55DF0", VA = "0xA55DF0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xA55E34", Offset = "0xA55E34", VA = "0xA55E34", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xA55E9C", Offset = "0xA55E9C", VA = "0xA55E9C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xA55F24", Offset = "0xA55F24", VA = "0xA55F24")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xA56264", Offset = "0xA56264", VA = "0xA56264")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xA56270", Offset = "0xA56270", VA = "0xA56270")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xA55F80", Offset = "0xA55F80", VA = "0xA55F80")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xA5627C", Offset = "0xA5627C", VA = "0xA5627C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xA565EC", Offset = "0xA565EC", VA = "0xA565EC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xA56770", Offset = "0xA56770", VA = "0xA56770")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xA568D0", Offset = "0xA568D0", VA = "0xA568D0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xA568EC", Offset = "0xA568EC", VA = "0xA568EC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xA56AB4", Offset = "0xA56AB4", VA = "0xA56AB4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
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
		[Address(RVA = "0xA56BAC", Offset = "0xA56BAC", VA = "0xA56BAC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xA56BF0", Offset = "0xA56BF0", VA = "0xA56BF0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xA56C34", Offset = "0xA56C34", VA = "0xA56C34", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xA56E24", Offset = "0xA56E24", VA = "0xA56E24")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xA57044", Offset = "0xA57044", VA = "0xA57044")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xA57124", Offset = "0xA57124", VA = "0xA57124")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xA57810", Offset = "0xA57810", VA = "0xA57810")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xA57CC8", Offset = "0xA57CC8", VA = "0xA57CC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xA57E74", Offset = "0xA57E74", VA = "0xA57E74")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xA581FC", Offset = "0xA581FC", VA = "0xA581FC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xA58400", Offset = "0xA58400", VA = "0xA58400")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xA58628", Offset = "0xA58628", VA = "0xA58628")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
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
			[Address(RVA = "0xA59370", Offset = "0xA59370", VA = "0xA59370")]
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
		[Address(RVA = "0xA586CC", Offset = "0xA586CC", VA = "0xA586CC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xA58710", Offset = "0xA58710", VA = "0xA58710", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xA58754", Offset = "0xA58754", VA = "0xA58754", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xA588D0", Offset = "0xA588D0", VA = "0xA588D0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xA589D4", Offset = "0xA589D4", VA = "0xA589D4")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xA58BCC", Offset = "0xA58BCC", VA = "0xA58BCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xA58C30", Offset = "0xA58C30", VA = "0xA58C30")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xA58C88", Offset = "0xA58C88", VA = "0xA58C88")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xA58FD4", Offset = "0xA58FD4", VA = "0xA58FD4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xA593D0", Offset = "0xA593D0", VA = "0xA593D0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xA59460", Offset = "0xA59460", VA = "0xA59460")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xA598B0", Offset = "0xA598B0", VA = "0xA598B0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xA59F74", Offset = "0xA59F74", VA = "0xA59F74")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xA5A22C", Offset = "0xA5A22C", VA = "0xA5A22C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xA5A360", Offset = "0xA5A360", VA = "0xA5A360")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xA5A658", Offset = "0xA5A658", VA = "0xA5A658")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xA5A688", Offset = "0xA5A688", VA = "0xA5A688")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xA5A8A8", Offset = "0xA5A8A8", VA = "0xA5A8A8")]
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
				[Address(RVA = "0xA5C724", Offset = "0xA5C724", VA = "0xA5C724")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000203")]
				[Address(RVA = "0xA5C72C", Offset = "0xA5C72C", VA = "0xA5C72C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002C")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000204")]
				[Address(RVA = "0xA5C738", Offset = "0xA5C738", VA = "0xA5C738")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000205")]
				[Address(RVA = "0xA5C744", Offset = "0xA5C744", VA = "0xA5C744")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002D")]
			public bool initiated
			{
				[Token(Token = "0x6000206")]
				[Address(RVA = "0xA5C750", Offset = "0xA5C750", VA = "0xA5C750")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000207")]
				[Address(RVA = "0xA5C758", Offset = "0xA5C758", VA = "0xA5C758")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002E")]
			public float heightFromGround
			{
				[Token(Token = "0x6000208")]
				[Address(RVA = "0xA5C764", Offset = "0xA5C764", VA = "0xA5C764")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000209")]
				[Address(RVA = "0xA5C76C", Offset = "0xA5C76C", VA = "0xA5C76C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public Vector3 velocity
			{
				[Token(Token = "0x600020A")]
				[Address(RVA = "0xA5C774", Offset = "0xA5C774", VA = "0xA5C774")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600020B")]
				[Address(RVA = "0xA5C780", Offset = "0xA5C780", VA = "0xA5C780")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public Transform transform
			{
				[Token(Token = "0x600020C")]
				[Address(RVA = "0xA5C78C", Offset = "0xA5C78C", VA = "0xA5C78C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600020D")]
				[Address(RVA = "0xA5C794", Offset = "0xA5C794", VA = "0xA5C794")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public float IKOffset
			{
				[Token(Token = "0x600020E")]
				[Address(RVA = "0xA5C79C", Offset = "0xA5C79C", VA = "0xA5C79C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600020F")]
				[Address(RVA = "0xA5C7A4", Offset = "0xA5C7A4", VA = "0xA5C7A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000032")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x6000210")]
				[Address(RVA = "0xA5C7AC", Offset = "0xA5C7AC", VA = "0xA5C7AC")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000211")]
				[Address(RVA = "0xA5C7C4", Offset = "0xA5C7C4", VA = "0xA5C7C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000033")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x6000212")]
				[Address(RVA = "0xA5C7E4", Offset = "0xA5C7E4", VA = "0xA5C7E4")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x6000213")]
				[Address(RVA = "0xA5C7FC", Offset = "0xA5C7FC", VA = "0xA5C7FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x6000214")]
				[Address(RVA = "0xA5C81C", Offset = "0xA5C81C", VA = "0xA5C81C")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x17000035")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x600021A")]
				[Address(RVA = "0xA5D0D8", Offset = "0xA5D0D8", VA = "0xA5D0D8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000036")]
			private float rootYOffset
			{
				[Token(Token = "0x6000223")]
				[Address(RVA = "0xA5D228", Offset = "0xA5D228", VA = "0xA5D228")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000215")]
			[Address(RVA = "0xA5C864", Offset = "0xA5C864", VA = "0xA5C864")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000216")]
			[Address(RVA = "0xA5AEA0", Offset = "0xA5AEA0", VA = "0xA5AEA0")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000217")]
			[Address(RVA = "0xA5C878", Offset = "0xA5C878", VA = "0xA5C878")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000218")]
			[Address(RVA = "0xA5BBB4", Offset = "0xA5BBB4", VA = "0xA5BBB4")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000219")]
			[Address(RVA = "0xA5AFB4", Offset = "0xA5AFB4", VA = "0xA5AFB4")]
			public void Process()
			{
			}

			[Token(Token = "0x600021B")]
			[Address(RVA = "0xA5CD04", Offset = "0xA5CD04", VA = "0xA5CD04")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600021C")]
			[Address(RVA = "0xA5C8B8", Offset = "0xA5C8B8", VA = "0xA5C8B8")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600021D")]
			[Address(RVA = "0xA5D16C", Offset = "0xA5D16C", VA = "0xA5D16C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600021E")]
			[Address(RVA = "0xA5CB6C", Offset = "0xA5CB6C", VA = "0xA5CB6C")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600021F")]
			[Address(RVA = "0xA5CBEC", Offset = "0xA5CBEC", VA = "0xA5CBEC")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x6000220")]
			[Address(RVA = "0xA5D1D8", Offset = "0xA5D1D8", VA = "0xA5D1D8")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0xA5D10C", Offset = "0xA5D10C", VA = "0xA5D10C")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0xA5D2B4", Offset = "0xA5D2B4", VA = "0xA5D2B4")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0xA5AE00", Offset = "0xA5AE00", VA = "0xA5AE00")]
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
				[Address(RVA = "0xA5D464", Offset = "0xA5D464", VA = "0xA5D464")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000226")]
				[Address(RVA = "0xA5D470", Offset = "0xA5D470", VA = "0xA5D470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000038")]
			public float heightOffset
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0xA5D47C", Offset = "0xA5D47C", VA = "0xA5D47C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000228")]
				[Address(RVA = "0xA5D484", Offset = "0xA5D484", VA = "0xA5D484")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0xA5AF78", Offset = "0xA5AF78", VA = "0xA5AF78")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0xA5BB20", Offset = "0xA5BB20", VA = "0xA5BB20")]
			public void Reset()
			{
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0xA5D48C", Offset = "0xA5D48C", VA = "0xA5D48C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0xA5B934", Offset = "0xA5B934", VA = "0xA5B934")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0xA5AE98", Offset = "0xA5AE98", VA = "0xA5AE98")]
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
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
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
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
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
			[Address(RVA = "0xA5A9AC", Offset = "0xA5A9AC", VA = "0xA5A9AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0xA5A9B4", Offset = "0xA5A9B4", VA = "0xA5A9B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xA5A9BC", Offset = "0xA5A9BC", VA = "0xA5A9BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xA5A9C4", Offset = "0xA5A9C4", VA = "0xA5A9C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool isGrounded
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0xA5A9CC", Offset = "0xA5A9CC", VA = "0xA5A9CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0xA5A9D4", Offset = "0xA5A9D4", VA = "0xA5A9D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform root
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0xA5A9E0", Offset = "0xA5A9E0", VA = "0xA5A9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0xA5A9E8", Offset = "0xA5A9E8", VA = "0xA5A9E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xA5A9F0", Offset = "0xA5A9F0", VA = "0xA5A9F0")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0xA5AA08", Offset = "0xA5AA08", VA = "0xA5AA08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xA5AA28", Offset = "0xA5AA28", VA = "0xA5AA28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public Vector3 up
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0xA55888", Offset = "0xA55888", VA = "0xA55888")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002A")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xA5BC48", Offset = "0xA5BC48", VA = "0xA5BC48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xA5AA70", Offset = "0xA5AA70", VA = "0xA5AA70")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xA5ACF8", Offset = "0xA5ACF8", VA = "0xA5ACF8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xA54E4C", Offset = "0xA54E4C", VA = "0xA54E4C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xA555C8", Offset = "0xA555C8", VA = "0xA555C8")]
		public void Update()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xA57698", Offset = "0xA57698", VA = "0xA57698")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xA54984", Offset = "0xA54984", VA = "0xA54984")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xA5AF9C", Offset = "0xA5AF9C", VA = "0xA5AF9C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xA5BCFC", Offset = "0xA5BCFC", VA = "0xA5BCFC")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xA5BD80", Offset = "0xA5BD80", VA = "0xA5BD80")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xA5BED4", Offset = "0xA5BED4", VA = "0xA5BED4")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xA54608", Offset = "0xA54608", VA = "0xA54608")]
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
		[Address(RVA = "0xA5D4E0", Offset = "0xA5D4E0", VA = "0xA5D4E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xA5D524", Offset = "0xA5D524", VA = "0xA5D524", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xA5D568", Offset = "0xA5D568", VA = "0xA5D568")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xA5D5AC", Offset = "0xA5D5AC", VA = "0xA5D5AC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xA5D5F0", Offset = "0xA5D5F0", VA = "0xA5D5F0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xA5D634", Offset = "0xA5D634", VA = "0xA5D634", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA5D63C", Offset = "0xA5D63C", VA = "0xA5D63C")]
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
		[Address(RVA = "0xA5D6B8", Offset = "0xA5D6B8", VA = "0xA5D6B8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xA5D6FC", Offset = "0xA5D6FC", VA = "0xA5D6FC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xA5D740", Offset = "0xA5D740", VA = "0xA5D740")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xA5D784", Offset = "0xA5D784", VA = "0xA5D784")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xA5D7C8", Offset = "0xA5D7C8", VA = "0xA5D7C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xA5D7D0", Offset = "0xA5D7D0", VA = "0xA5D7D0")]
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
		[Address(RVA = "0xA5D844", Offset = "0xA5D844", VA = "0xA5D844", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA5D888", Offset = "0xA5D888", VA = "0xA5D888", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xA5D8CC", Offset = "0xA5D8CC", VA = "0xA5D8CC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xA5D910", Offset = "0xA5D910", VA = "0xA5D910")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA5D954", Offset = "0xA5D954", VA = "0xA5D954", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA5D95C", Offset = "0xA5D95C", VA = "0xA5D95C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xA5D9D0", Offset = "0xA5D9D0", VA = "0xA5D9D0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xA5DA14", Offset = "0xA5DA14", VA = "0xA5DA14", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA5DA58", Offset = "0xA5DA58", VA = "0xA5DA58")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xA5DA9C", Offset = "0xA5DA9C", VA = "0xA5DA9C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xA5DAE0", Offset = "0xA5DAE0", VA = "0xA5DAE0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xA5DAE8", Offset = "0xA5DAE8", VA = "0xA5DAE8")]
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
		[Address(RVA = "0xA5DB5C", Offset = "0xA5DB5C", VA = "0xA5DB5C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xA5DBA0", Offset = "0xA5DBA0", VA = "0xA5DBA0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xA5DBE4", Offset = "0xA5DBE4", VA = "0xA5DBE4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xA5DC28", Offset = "0xA5DC28", VA = "0xA5DC28")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xA5DC6C", Offset = "0xA5DC6C", VA = "0xA5DC6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xA5DC74", Offset = "0xA5DC74", VA = "0xA5DC74")]
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
		[Address(RVA = "0xA5DCE8", Offset = "0xA5DCE8", VA = "0xA5DCE8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA5DD2C", Offset = "0xA5DD2C", VA = "0xA5DD2C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA5DD70", Offset = "0xA5DD70", VA = "0xA5DD70")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xA5DDB4", Offset = "0xA5DDB4", VA = "0xA5DDB4")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA5DDF8", Offset = "0xA5DDF8", VA = "0xA5DDF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA5DE3C", Offset = "0xA5DE3C", VA = "0xA5DE3C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA5DE80", Offset = "0xA5DE80", VA = "0xA5DE80")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA5DEC0", Offset = "0xA5DEC0", VA = "0xA5DEC0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA5DEC8", Offset = "0xA5DEC8", VA = "0xA5DEC8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA5E098", Offset = "0xA5E098", VA = "0xA5E098")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA5E554", Offset = "0xA5E554", VA = "0xA5E554")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA5E574", Offset = "0xA5E574", VA = "0xA5E574")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA5E664", Offset = "0xA5E664", VA = "0xA5E664")]
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
		[Address(RVA = "0xA5E714", Offset = "0xA5E714", VA = "0xA5E714", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA5E78C", Offset = "0xA5E78C", VA = "0xA5E78C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA5E7FC", Offset = "0xA5E7FC", VA = "0xA5E7FC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600025E")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600025F")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA5D6B0", Offset = "0xA5D6B0", VA = "0xA5D6B0")]
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
			[Address(RVA = "0xA5E84C", Offset = "0xA5E84C", VA = "0xA5E84C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA5E8D8", Offset = "0xA5E8D8", VA = "0xA5E8D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xA5E93C", Offset = "0xA5E93C", VA = "0xA5E93C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xA5E9DC", Offset = "0xA5E9DC", VA = "0xA5E9DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA5EA08", Offset = "0xA5EA08", VA = "0xA5EA08")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xA5E960", Offset = "0xA5E960", VA = "0xA5E960")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xA5EA8C", Offset = "0xA5EA8C", VA = "0xA5EA8C")]
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
		[Address(RVA = "0xA5EA94", Offset = "0xA5EA94", VA = "0xA5EA94", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xA5EAD8", Offset = "0xA5EAD8", VA = "0xA5EAD8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xA5EB1C", Offset = "0xA5EB1C", VA = "0xA5EB1C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xA5EB60", Offset = "0xA5EB60", VA = "0xA5EB60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA5EBA4", Offset = "0xA5EBA4", VA = "0xA5EBA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xA5EBAC", Offset = "0xA5EBAC", VA = "0xA5EBAC")]
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
		[Address(RVA = "0xA5EC20", Offset = "0xA5EC20", VA = "0xA5EC20", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xA5EC64", Offset = "0xA5EC64", VA = "0xA5EC64", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xA5ECA8", Offset = "0xA5ECA8", VA = "0xA5ECA8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xA5ECEC", Offset = "0xA5ECEC", VA = "0xA5ECEC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xA5ED30", Offset = "0xA5ED30", VA = "0xA5ED30", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xA5ED38", Offset = "0xA5ED38", VA = "0xA5ED38")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xA5EDAC", Offset = "0xA5EDAC", VA = "0xA5EDAC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA5EDF0", Offset = "0xA5EDF0", VA = "0xA5EDF0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA5EE34", Offset = "0xA5EE34", VA = "0xA5EE34")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA5EE78", Offset = "0xA5EE78", VA = "0xA5EE78")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA5EEBC", Offset = "0xA5EEBC", VA = "0xA5EEBC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA5EEC4", Offset = "0xA5EEC4", VA = "0xA5EEC4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA5EF38", Offset = "0xA5EF38", VA = "0xA5EF38", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA5EF7C", Offset = "0xA5EF7C", VA = "0xA5EF7C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA5EFC0", Offset = "0xA5EFC0", VA = "0xA5EFC0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA5F004", Offset = "0xA5F004", VA = "0xA5F004")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA5F048", Offset = "0xA5F048", VA = "0xA5F048", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA5F050", Offset = "0xA5F050", VA = "0xA5F050")]
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
			[LargeHeader("Left Arm")]
			[Tooltip("Optional")]
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
				[Address(RVA = "0xA5FAA0", Offset = "0xA5FAA0", VA = "0xA5FAA0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700003B")]
			public bool isEmpty
			{
				[Token(Token = "0x600028D")]
				[Address(RVA = "0xA5F6E4", Offset = "0xA5F6E4", VA = "0xA5F6E4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0xA601DC", Offset = "0xA601DC", VA = "0xA601DC")]
			public References()
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0xA601E4", Offset = "0xA601E4", VA = "0xA601E4")]
			public References(BipedReferences b)
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0xA603D4", Offset = "0xA603D4", VA = "0xA603D4")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0xA5F1AC", Offset = "0xA5F1AC", VA = "0xA5F1AC")]
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
		[Address(RVA = "0xA5F0C4", Offset = "0xA5F0C4", VA = "0xA5F0C4", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA5F108", Offset = "0xA5F108", VA = "0xA5F108", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA5F14C", Offset = "0xA5F14C", VA = "0xA5F14C")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA5F190", Offset = "0xA5F190", VA = "0xA5F190")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA5F648", Offset = "0xA5F648", VA = "0xA5F648")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA5F670", Offset = "0xA5F670", VA = "0xA5F670", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xA5F678", Offset = "0xA5F678", VA = "0xA5F678", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xA5FF9C", Offset = "0xA5FF9C", VA = "0xA5FF9C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xA6012C", Offset = "0xA6012C", VA = "0xA6012C")]
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
		[Address(RVA = "0xA60918", Offset = "0xA60918", VA = "0xA60918")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xA609E8", Offset = "0xA609E8", VA = "0xA609E8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xA60A08", Offset = "0xA60A08", VA = "0xA60A08")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xA60C5C", Offset = "0xA60C5C", VA = "0xA60C5C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xA60AC8", Offset = "0xA60AC8", VA = "0xA60AC8")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xA60D40", Offset = "0xA60D40", VA = "0xA60D40")]
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
		[Address(RVA = "0xA60DAC", Offset = "0xA60DAC", VA = "0xA60DAC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xA6125C", Offset = "0xA6125C", VA = "0xA6125C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xA613F0", Offset = "0xA613F0", VA = "0xA613F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xA6151C", Offset = "0xA6151C", VA = "0xA6151C")]
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
			[Address(RVA = "0xA64780", Offset = "0xA64780", VA = "0xA64780")]
			public BendBone()
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0xA647E0", Offset = "0xA647E0", VA = "0xA647E0")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xA61E14", Offset = "0xA61E14", VA = "0xA61E14")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xA621E4", Offset = "0xA621E4", VA = "0xA621E4")]
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
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		[LargeHeader("Position")]
		public float positionWeight;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
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
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the body")]
		public float bodyClampWeight;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Clamping the rotation of the head")]
		[Range(0f, 1f)]
		public float headClampWeight;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		[Range(0f, 1f)]
		public float bendWeight;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
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
		[Address(RVA = "0xA61524", Offset = "0xA61524", VA = "0xA61524")]
		private void Start()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xA61964", Offset = "0xA61964", VA = "0xA61964")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xA61E40", Offset = "0xA61E40", VA = "0xA61E40")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xA6220C", Offset = "0xA6220C", VA = "0xA6220C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xA62B08", Offset = "0xA62B08", VA = "0xA62B08")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xA62F00", Offset = "0xA62F00", VA = "0xA62F00")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xA63310", Offset = "0xA63310", VA = "0xA63310")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xA63C90", Offset = "0xA63C90", VA = "0xA63C90")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xA6284C", Offset = "0xA6284C", VA = "0xA6284C")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xA63ECC", Offset = "0xA63ECC", VA = "0xA63ECC")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xA63BA8", Offset = "0xA63BA8", VA = "0xA63BA8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xA63AA8", Offset = "0xA63AA8", VA = "0xA63AA8")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xA641D0", Offset = "0xA641D0", VA = "0xA641D0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xA6456C", Offset = "0xA6456C", VA = "0xA6456C")]
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
				[Address(RVA = "0xA66B4C", Offset = "0xA66B4C", VA = "0xA66B4C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002C0")]
				[Address(RVA = "0xA66B54", Offset = "0xA66B54", VA = "0xA66B54")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700003D")]
			public bool isRigid
			{
				[Token(Token = "0x60002C1")]
				[Address(RVA = "0xA66B5C", Offset = "0xA66B5C", VA = "0xA66B5C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002C2")]
				[Address(RVA = "0xA66B64", Offset = "0xA66B64", VA = "0xA66B64")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xA66B70", Offset = "0xA66B70", VA = "0xA66B70")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xA66BCC", Offset = "0xA66BCC", VA = "0xA66BCC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0xA66D2C", Offset = "0xA66D2C", VA = "0xA66D2C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0xA66F10", Offset = "0xA66F10", VA = "0xA66F10")]
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
		[Address(RVA = "0xA64868", Offset = "0xA64868", VA = "0xA64868")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xA64998", Offset = "0xA64998", VA = "0xA64998")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xA64B0C", Offset = "0xA64B0C", VA = "0xA64B0C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xA64C3C", Offset = "0xA64C3C", VA = "0xA64C3C")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xA64CF8", Offset = "0xA64CF8", VA = "0xA64CF8")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xA64E14", Offset = "0xA64E14", VA = "0xA64E14")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xA65564", Offset = "0xA65564", VA = "0xA65564")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xA64F9C", Offset = "0xA64F9C", VA = "0xA64F9C")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xA6594C", Offset = "0xA6594C", VA = "0xA6594C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xA65BE0", Offset = "0xA65BE0", VA = "0xA65BE0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xA65EB0", Offset = "0xA65EB0", VA = "0xA65EB0")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xA6624C", Offset = "0xA6624C", VA = "0xA6624C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xA66748", Offset = "0xA66748", VA = "0xA66748")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xA66948", Offset = "0xA66948", VA = "0xA66948")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xA66634", Offset = "0xA66634", VA = "0xA66634")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xA660EC", Offset = "0xA660EC", VA = "0xA660EC")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xA665CC", Offset = "0xA665CC", VA = "0xA665CC")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xA66A24", Offset = "0xA66A24", VA = "0xA66A24")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xA664F8", Offset = "0xA664F8", VA = "0xA664F8")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xA6684C", Offset = "0xA6684C", VA = "0xA6684C")]
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
			[Address(RVA = "0xA67324", Offset = "0xA67324", VA = "0xA67324")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0xA6732C", Offset = "0xA6732C", VA = "0xA6732C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xA6714C", Offset = "0xA6714C", VA = "0xA6714C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xA67338", Offset = "0xA67338", VA = "0xA67338")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xA673A4", Offset = "0xA673A4", VA = "0xA673A4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xA67438", Offset = "0xA67438", VA = "0xA67438")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xA6747C", Offset = "0xA6747C", VA = "0xA6747C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xA67884", Offset = "0xA67884", VA = "0xA67884")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xA67BD8", Offset = "0xA67BD8", VA = "0xA67BD8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xA67FA0", Offset = "0xA67FA0", VA = "0xA67FA0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xA6774C", Offset = "0xA6774C", VA = "0xA6774C")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xA677E8", Offset = "0xA677E8", VA = "0xA677E8")]
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
			[Address(RVA = "0xA68664", Offset = "0xA68664", VA = "0xA68664")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0xA6866C", Offset = "0xA6866C", VA = "0xA6866C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xA68608", Offset = "0xA68608", VA = "0xA68608")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xA68678", Offset = "0xA68678", VA = "0xA68678")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xA686FC", Offset = "0xA686FC", VA = "0xA686FC")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xA688CC", Offset = "0xA688CC", VA = "0xA688CC")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xA68AD8", Offset = "0xA68AD8", VA = "0xA68AD8")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA68DE0", Offset = "0xA68DE0", VA = "0xA68DE0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA690A4", Offset = "0xA690A4", VA = "0xA690A4")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA691BC", Offset = "0xA691BC", VA = "0xA691BC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA69258", Offset = "0xA69258", VA = "0xA69258")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA698F8", Offset = "0xA698F8", VA = "0xA698F8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xA69950", Offset = "0xA69950", VA = "0xA69950")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xA69B18", Offset = "0xA69B18", VA = "0xA69B18")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xA69D60", Offset = "0xA69D60", VA = "0xA69D60")]
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
				[Address(RVA = "0xA6A2C0", Offset = "0xA6A2C0", VA = "0xA6A2C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000041")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002EB")]
				[Address(RVA = "0xA6A378", Offset = "0xA6A378", VA = "0xA6A378")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000042")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0xA6A758", Offset = "0xA6A758", VA = "0xA6A758")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xA6A280", Offset = "0xA6A280", VA = "0xA6A280")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xA6A2F0", Offset = "0xA6A2F0", VA = "0xA6A2F0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xA6A334", Offset = "0xA6A334", VA = "0xA6A334")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xA6A388", Offset = "0xA6A388", VA = "0xA6A388")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xA6A45C", Offset = "0xA6A45C", VA = "0xA6A45C")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xA6A464", Offset = "0xA6A464", VA = "0xA6A464")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xA6A530", Offset = "0xA6A530", VA = "0xA6A530")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xA6A59C", Offset = "0xA6A59C", VA = "0xA6A59C")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xA6A648", Offset = "0xA6A648", VA = "0xA6A648")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xA6A8C0", Offset = "0xA6A8C0", VA = "0xA6A8C0")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xA6A8EC", Offset = "0xA6A8EC", VA = "0xA6A8EC")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xA6A918", Offset = "0xA6A918", VA = "0xA6A918")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xA6A940", Offset = "0xA6A940", VA = "0xA6A940")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xA6AA00", Offset = "0xA6AA00", VA = "0xA6AA00")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xA6AB84", Offset = "0xA6AB84", VA = "0xA6AB84")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xA6ABA8", Offset = "0xA6ABA8", VA = "0xA6ABA8")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xA6ACC8", Offset = "0xA6ACC8", VA = "0xA6ACC8")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xA6AD2C", Offset = "0xA6AD2C", VA = "0xA6AD2C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xA6AEAC", Offset = "0xA6AEAC", VA = "0xA6AEAC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xA6B02C", Offset = "0xA6B02C", VA = "0xA6B02C")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xA6B0A8", Offset = "0xA6B0A8", VA = "0xA6B0A8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xA6AA74", Offset = "0xA6AA74", VA = "0xA6AA74")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0xA6B1C4", Offset = "0xA6B1C4", VA = "0xA6B1C4")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xA6A010", Offset = "0xA6A010", VA = "0xA6A010", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xA6A018", Offset = "0xA6A018", VA = "0xA6A018", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xA6A01C", Offset = "0xA6A01C", VA = "0xA6A01C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xA6A164", Offset = "0xA6A164", VA = "0xA6A164")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xA6A278", Offset = "0xA6A278", VA = "0xA6A278")]
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
		[Address(RVA = "0xA6B1E0", Offset = "0xA6B1E0", VA = "0xA6B1E0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xA6B288", Offset = "0xA6B288", VA = "0xA6B288")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xA6B318", Offset = "0xA6B318", VA = "0xA6B318")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xA6B3C4", Offset = "0xA6B3C4", VA = "0xA6B3C4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xA6B3DC", Offset = "0xA6B3DC", VA = "0xA6B3DC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xA6B3F8", Offset = "0xA6B3F8", VA = "0xA6B3F8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xA6B4A0", Offset = "0xA6B4A0", VA = "0xA6B4A0")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xA6B4B8", Offset = "0xA6B4B8", VA = "0xA6B4B8")]
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
		[Address(RVA = "0xA6B4DC", Offset = "0xA6B4DC", VA = "0xA6B4DC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xA6B550", Offset = "0xA6B550", VA = "0xA6B550")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xA6B618", Offset = "0xA6B618", VA = "0xA6B618")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xA6B8D0", Offset = "0xA6B8D0", VA = "0xA6B8D0")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xA6BA1C", Offset = "0xA6BA1C", VA = "0xA6BA1C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xA6BBA0", Offset = "0xA6BBA0", VA = "0xA6BBA0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xA6BC00", Offset = "0xA6BC00", VA = "0xA6BC00")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xA6BC98", Offset = "0xA6BC98", VA = "0xA6BC98")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xA6BD40", Offset = "0xA6BD40", VA = "0xA6BD40", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xA6BFF4", Offset = "0xA6BFF4", VA = "0xA6BFF4")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xA6C054", Offset = "0xA6C054", VA = "0xA6C054")]
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
		[Address(RVA = "0xA6C198", Offset = "0xA6C198", VA = "0xA6C198", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xA6C4C4", Offset = "0xA6C4C4", VA = "0xA6C4C4")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xA6C63C", Offset = "0xA6C63C", VA = "0xA6C63C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xA6C7F4", Offset = "0xA6C7F4", VA = "0xA6C7F4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xA6C868", Offset = "0xA6C868", VA = "0xA6C868")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xA6C8C4", Offset = "0xA6C8C4", VA = "0xA6C8C4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xA6C93C", Offset = "0xA6C93C", VA = "0xA6C93C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xA6CFB4", Offset = "0xA6CFB4", VA = "0xA6CFB4")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xA6CFEC", Offset = "0xA6CFEC", VA = "0xA6CFEC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xA6D250", Offset = "0xA6D250", VA = "0xA6D250")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xA6D570", Offset = "0xA6D570", VA = "0xA6D570")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xA6D650", Offset = "0xA6D650", VA = "0xA6D650")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xA6D704", Offset = "0xA6D704", VA = "0xA6D704")]
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
			[Address(RVA = "0xA6DFE0", Offset = "0xA6DFE0", VA = "0xA6DFE0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0xA6E024", Offset = "0xA6E024", VA = "0xA6E024")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0xA6E104", Offset = "0xA6E104", VA = "0xA6E104")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0xA6E130", Offset = "0xA6E130", VA = "0xA6E130")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0xA6E15C", Offset = "0xA6E15C", VA = "0xA6E15C")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0xA6E1A0", Offset = "0xA6E1A0", VA = "0xA6E1A0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600033D")]
			[Address(RVA = "0xA6E1E4", Offset = "0xA6E1E4", VA = "0xA6E1E4")]
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
				[Address(RVA = "0xA6E244", Offset = "0xA6E244", VA = "0xA6E244")]
				get
				{
					return null;
				}
				[Token(Token = "0x600033F")]
				[Address(RVA = "0xA6E334", Offset = "0xA6E334", VA = "0xA6E334")]
				set
				{
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0xA6E3B8", Offset = "0xA6E3B8", VA = "0xA6E3B8")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0xA6E624", Offset = "0xA6E624", VA = "0xA6E624")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0xA6E8E0", Offset = "0xA6E8E0", VA = "0xA6E8E0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000343")]
			[Address(RVA = "0xA6EAD4", Offset = "0xA6EAD4", VA = "0xA6EAD4")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0xA6EAFC", Offset = "0xA6EAFC", VA = "0xA6EAFC")]
			public Bone()
			{
			}

			[Token(Token = "0x6000345")]
			[Address(RVA = "0xA6EB68", Offset = "0xA6EB68", VA = "0xA6EB68")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0xA6EBE8", Offset = "0xA6EBE8", VA = "0xA6EBE8")]
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
			[Address(RVA = "0xA6EC7C", Offset = "0xA6EC7C", VA = "0xA6EC7C")]
			public Node()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0xA6EC80", Offset = "0xA6EC80", VA = "0xA6EC80")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000349")]
			[Address(RVA = "0xA6ECAC", Offset = "0xA6ECAC", VA = "0xA6ECAC")]
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
			[Address(RVA = "0xA6DBEC", Offset = "0xA6DBEC", VA = "0xA6DBEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0xA6DBF4", Offset = "0xA6DBF4", VA = "0xA6DBF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xA6D940", Offset = "0xA6D940", VA = "0xA6D940")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xA6D9B4", Offset = "0xA6D9B4", VA = "0xA6D9B4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xA6DB38", Offset = "0xA6DB38", VA = "0xA6DB38")]
		public void Update()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xA6DBA8", Offset = "0xA6DBA8", VA = "0xA6DBA8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xA6DBB4", Offset = "0xA6DBB4", VA = "0xA6DBB4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xA6DBC0", Offset = "0xA6DBC0", VA = "0xA6DBC0")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xA6DBC8", Offset = "0xA6DBC8", VA = "0xA6DBC8")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xA6DBE4", Offset = "0xA6DBE4", VA = "0xA6DBE4")]
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
		[Address(RVA = "0xA6DC00", Offset = "0xA6DC00", VA = "0xA6DC00")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xA6DC18", Offset = "0xA6DC18", VA = "0xA6DC18")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xA6DD3C", Offset = "0xA6DD3C", VA = "0xA6DD3C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xA6DDD4", Offset = "0xA6DDD4", VA = "0xA6DDD4")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xA6DFC8", Offset = "0xA6DFC8", VA = "0xA6DFC8")]
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
			[Address(RVA = "0xA6F0A8", Offset = "0xA6F0A8", VA = "0xA6F0A8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0xA6F0D8", Offset = "0xA6F0D8", VA = "0xA6F0D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000047")]
		protected override int minBones
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xA6FD28", Offset = "0xA6FD28", VA = "0xA6FD28", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xA70268", Offset = "0xA70268", VA = "0xA70268", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xA6EF70", Offset = "0xA6EF70", VA = "0xA6EF70")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xA6F108", Offset = "0xA6F108", VA = "0xA6F108", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xA6F394", Offset = "0xA6F394", VA = "0xA6F394", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xA6FC80", Offset = "0xA6FC80", VA = "0xA6FC80")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xA6F91C", Offset = "0xA6F91C", VA = "0xA6F91C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xA6FD30", Offset = "0xA6FD30", VA = "0xA6FD30")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xA702C8", Offset = "0xA702C8", VA = "0xA702C8")]
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
		[Address(RVA = "0xA7036C", Offset = "0xA7036C", VA = "0xA7036C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xA70710", Offset = "0xA70710", VA = "0xA70710")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xA707C0", Offset = "0xA707C0", VA = "0xA707C0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xA70940", Offset = "0xA70940", VA = "0xA70940", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xA70AA0", Offset = "0xA70AA0", VA = "0xA70AA0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xA70AE0", Offset = "0xA70AE0", VA = "0xA70AE0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xA70B30", Offset = "0xA70B30", VA = "0xA70B30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xA70E90", Offset = "0xA70E90", VA = "0xA70E90", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xA70EB0", Offset = "0xA70EB0", VA = "0xA70EB0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xA70B88", Offset = "0xA70B88", VA = "0xA70B88")]
		private void Read()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xA70F18", Offset = "0xA70F18", VA = "0xA70F18")]
		private void Write()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xA71090", Offset = "0xA71090", VA = "0xA71090")]
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
		[Address(RVA = "0xA71284", Offset = "0xA71284", VA = "0xA71284")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xA712F4", Offset = "0xA712F4", VA = "0xA712F4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xA71364", Offset = "0xA71364", VA = "0xA71364", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xA71618", Offset = "0xA71618", VA = "0xA71618")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xA71CA8", Offset = "0xA71CA8", VA = "0xA71CA8")]
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
			[Address(RVA = "0xA72C6C", Offset = "0xA72C6C", VA = "0xA72C6C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xA71CB0", Offset = "0xA71CB0", VA = "0xA71CB0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xA72290", Offset = "0xA72290", VA = "0xA72290")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xA723C0", Offset = "0xA723C0", VA = "0xA723C0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xA72448", Offset = "0xA72448", VA = "0xA72448", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xA72960", Offset = "0xA72960", VA = "0xA72960", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xA72C74", Offset = "0xA72C74", VA = "0xA72C74")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xA71D88", Offset = "0xA71D88", VA = "0xA71D88")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xA72378", Offset = "0xA72378", VA = "0xA72378")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xA72C24", Offset = "0xA72C24", VA = "0xA72C24")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xA72124", Offset = "0xA72124", VA = "0xA72124")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xA73320", Offset = "0xA73320", VA = "0xA73320")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xA73388", Offset = "0xA73388", VA = "0xA73388")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xA73458", Offset = "0xA73458", VA = "0xA73458")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xA73520", Offset = "0xA73520", VA = "0xA73520")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xA726D8", Offset = "0xA726D8", VA = "0xA726D8")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xA7281C", Offset = "0xA7281C", VA = "0xA7281C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xA73610", Offset = "0xA73610", VA = "0xA73610")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xA72F10", Offset = "0xA72F10", VA = "0xA72F10")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xA72368", Offset = "0xA72368", VA = "0xA72368")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xA73C80", Offset = "0xA73C80", VA = "0xA73C80")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xA737D0", Offset = "0xA737D0", VA = "0xA737D0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xA72D90", Offset = "0xA72D90", VA = "0xA72D90")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xA72E60", Offset = "0xA72E60", VA = "0xA72E60")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xA73D38", Offset = "0xA73D38", VA = "0xA73D38")]
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
		[Address(RVA = "0xA73DD4", Offset = "0xA73DD4", VA = "0xA73DD4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xA74498", Offset = "0xA74498", VA = "0xA74498", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xA74524", Offset = "0xA74524", VA = "0xA74524", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xA745B8", Offset = "0xA745B8", VA = "0xA745B8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xA746B0", Offset = "0xA746B0", VA = "0xA746B0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xA74740", Offset = "0xA74740", VA = "0xA74740", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xA74B40", Offset = "0xA74B40", VA = "0xA74B40", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xA74D38", Offset = "0xA74D38", VA = "0xA74D38", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xA74BE0", Offset = "0xA74BE0", VA = "0xA74BE0")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xA74918", Offset = "0xA74918", VA = "0xA74918")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xA74DBC", Offset = "0xA74DBC", VA = "0xA74DBC")]
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
		[Address(RVA = "0xA74E38", Offset = "0xA74E38", VA = "0xA74E38")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xA74F14", Offset = "0xA74F14", VA = "0xA74F14")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xA66C18", Offset = "0xA66C18", VA = "0xA66C18")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xA685B8", Offset = "0xA685B8", VA = "0xA685B8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xA676D8", Offset = "0xA676D8", VA = "0xA676D8")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xA74F5C", Offset = "0xA74F5C", VA = "0xA74F5C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xA750FC", Offset = "0xA750FC", VA = "0xA750FC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xA75258", Offset = "0xA75258", VA = "0xA75258", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xA75458", Offset = "0xA75458", VA = "0xA75458", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xA75528", Offset = "0xA75528", VA = "0xA75528", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xA75604", Offset = "0xA75604", VA = "0xA75604", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xA75760", Offset = "0xA75760", VA = "0xA75760", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xA758F8", Offset = "0xA758F8", VA = "0xA758F8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xA75B20", Offset = "0xA75B20", VA = "0xA75B20", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xA75DF0", Offset = "0xA75DF0", VA = "0xA75DF0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xA75E28", Offset = "0xA75E28", VA = "0xA75E28", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xA75F00", Offset = "0xA75F00", VA = "0xA75F00")]
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
			[Address(RVA = "0xA76054", Offset = "0xA76054", VA = "0xA76054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xA76194", Offset = "0xA76194", VA = "0xA76194")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xA7619C", Offset = "0xA7619C", VA = "0xA7619C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0xA761A4", Offset = "0xA761A4", VA = "0xA761A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0xA761AC", Offset = "0xA761AC", VA = "0xA761AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xA761B4", Offset = "0xA761B4", VA = "0xA761B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0xA761BC", Offset = "0xA761BC", VA = "0xA761BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xA761C4", Offset = "0xA761C4", VA = "0xA761C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0xA761CC", Offset = "0xA761CC", VA = "0xA761CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xA761D4", Offset = "0xA761D4", VA = "0xA761D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xA76200", Offset = "0xA76200", VA = "0xA76200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xA7622C", Offset = "0xA7622C", VA = "0xA7622C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0xA76258", Offset = "0xA76258", VA = "0xA76258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xA76284", Offset = "0xA76284", VA = "0xA76284")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0xA762AC", Offset = "0xA762AC", VA = "0xA762AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xA762D8", Offset = "0xA762D8", VA = "0xA762D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xA76304", Offset = "0xA76304", VA = "0xA76304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xA76330", Offset = "0xA76330", VA = "0xA76330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0xA784FC", Offset = "0xA784FC", VA = "0xA784FC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0xA78508", Offset = "0xA78508", VA = "0xA78508")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xA76358", Offset = "0xA76358", VA = "0xA76358")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xA76458", Offset = "0xA76458", VA = "0xA76458")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xA763A8", Offset = "0xA763A8", VA = "0xA763A8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xA764D0", Offset = "0xA764D0", VA = "0xA764D0")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xA7605C", Offset = "0xA7605C", VA = "0xA7605C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xA76598", Offset = "0xA76598", VA = "0xA76598")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xA76648", Offset = "0xA76648", VA = "0xA76648")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xA766F4", Offset = "0xA766F4", VA = "0xA766F4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xA767A0", Offset = "0xA767A0", VA = "0xA767A0")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xA767A8", Offset = "0xA767A8", VA = "0xA767A8")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xA767D0", Offset = "0xA767D0", VA = "0xA767D0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xA76890", Offset = "0xA76890", VA = "0xA76890", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xA76A24", Offset = "0xA76A24", VA = "0xA76A24")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xA77E00", Offset = "0xA77E00", VA = "0xA77E00")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xA783B0", Offset = "0xA783B0", VA = "0xA783B0")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xA7840C", Offset = "0xA7840C", VA = "0xA7840C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xA78250", Offset = "0xA78250", VA = "0xA78250")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xA78300", Offset = "0xA78300", VA = "0xA78300")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xA78514", Offset = "0xA78514", VA = "0xA78514")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xA785D8", Offset = "0xA785D8", VA = "0xA785D8", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xA786A4", Offset = "0xA786A4", VA = "0xA786A4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xA787C0", Offset = "0xA787C0", VA = "0xA787C0")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xA78950", Offset = "0xA78950", VA = "0xA78950")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xA78AC8", Offset = "0xA78AC8", VA = "0xA78AC8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xA78D24", Offset = "0xA78D24", VA = "0xA78D24", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xA78D9C", Offset = "0xA78D9C", VA = "0xA78D9C")]
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
			[Address(RVA = "0xA7963C", Offset = "0xA7963C", VA = "0xA7963C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005E")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0xA79644", Offset = "0xA79644", VA = "0xA79644", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xA7964C", Offset = "0xA7964C", VA = "0xA7964C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000060")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xA79AF0", Offset = "0xA79AF0", VA = "0xA79AF0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000061")]
		protected float positionOffset
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xA79BAC", Offset = "0xA79BAC", VA = "0xA79BAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xA78DA8", Offset = "0xA78DA8", VA = "0xA78DA8")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xA78F58", Offset = "0xA78F58", VA = "0xA78F58")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xA790A4", Offset = "0xA790A4", VA = "0xA790A4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xA79104", Offset = "0xA79104", VA = "0xA79104", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xA79178", Offset = "0xA79178", VA = "0xA79178", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xA79558", Offset = "0xA79558", VA = "0xA79558", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xA79560", Offset = "0xA79560", VA = "0xA79560", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xA79654", Offset = "0xA79654", VA = "0xA79654", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xA79658", Offset = "0xA79658", VA = "0xA79658", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xA7965C", Offset = "0xA7965C", VA = "0xA7965C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xA79BF4", Offset = "0xA79BF4", VA = "0xA79BF4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xA79FAC", Offset = "0xA79FAC", VA = "0xA79FAC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xA7A240", Offset = "0xA7A240", VA = "0xA7A240")]
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
		[Address(RVA = "0xA7A2B4", Offset = "0xA7A2B4", VA = "0xA7A2B4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xA7A658", Offset = "0xA7A658", VA = "0xA7A658")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xA7A70C", Offset = "0xA7A70C", VA = "0xA7A70C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xA7A88C", Offset = "0xA7A88C", VA = "0xA7A88C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xA7A9EC", Offset = "0xA7A9EC", VA = "0xA7A9EC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xA7AA3C", Offset = "0xA7AA3C", VA = "0xA7AA3C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xA7AA9C", Offset = "0xA7AA9C", VA = "0xA7AA9C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xA7ADF8", Offset = "0xA7ADF8", VA = "0xA7ADF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xA7AE18", Offset = "0xA7AE18", VA = "0xA7AE18")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xA7AAF4", Offset = "0xA7AAF4", VA = "0xA7AAF4")]
		private void Read()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xA7AEA4", Offset = "0xA7AEA4", VA = "0xA7AEA4")]
		private void Write()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xA7B328", Offset = "0xA7B328", VA = "0xA7B328")]
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
			[Address(RVA = "0xA7CA44", Offset = "0xA7CA44", VA = "0xA7CA44")]
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
			[Address(RVA = "0xA7CA28", Offset = "0xA7CA28", VA = "0xA7CA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xA7B604", Offset = "0xA7B604", VA = "0xA7B604")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xA7B648", Offset = "0xA7B648", VA = "0xA7B648")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xA7B6B4", Offset = "0xA7B6B4", VA = "0xA7B6B4", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xA7BBFC", Offset = "0xA7BBFC", VA = "0xA7BBFC", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xA7C718", Offset = "0xA7C718", VA = "0xA7C718", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xA7C7C0", Offset = "0xA7C7C0", VA = "0xA7C7C0")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xA7C990", Offset = "0xA7C990", VA = "0xA7C990")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xA7BA10", Offset = "0xA7BA10", VA = "0xA7BA10")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xA7BCB8", Offset = "0xA7BCB8", VA = "0xA7BCB8")]
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
				[Address(RVA = "0xA7E8E8", Offset = "0xA7E8E8", VA = "0xA7E8E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0xA7EF98", Offset = "0xA7EF98", VA = "0xA7EF98")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0xA7DA04", Offset = "0xA7DA04", VA = "0xA7DA04")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0xA7DCF8", Offset = "0xA7DCF8", VA = "0xA7DCF8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0xA7EC30", Offset = "0xA7EC30", VA = "0xA7EC30")]
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
			[Address(RVA = "0xA7D188", Offset = "0xA7D188", VA = "0xA7D188")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0xA7D330", Offset = "0xA7D330", VA = "0xA7D330")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		protected bool headIsValid
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0xA7D254", Offset = "0xA7D254", VA = "0xA7D254")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xA7D354", Offset = "0xA7D354", VA = "0xA7D354")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xA7D264", Offset = "0xA7D264", VA = "0xA7D264")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xA7D3C0", Offset = "0xA7D3C0", VA = "0xA7D3C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xA7CBE0", Offset = "0xA7CBE0", VA = "0xA7CBE0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xA7CBFC", Offset = "0xA7CBFC", VA = "0xA7CBFC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xA7CC28", Offset = "0xA7CC28", VA = "0xA7CC28")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xA7CC60", Offset = "0xA7CC60", VA = "0xA7CC60")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xA7CCA8", Offset = "0xA7CCA8", VA = "0xA7CCA8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xA7CD00", Offset = "0xA7CD00", VA = "0xA7CD00")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xA7CD70", Offset = "0xA7CD70", VA = "0xA7CD70", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xA7CE88", Offset = "0xA7CE88", VA = "0xA7CE88")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xA7CE94", Offset = "0xA7CE94", VA = "0xA7CE94", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xA7CFC4", Offset = "0xA7CFC4", VA = "0xA7CFC4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xA7D3E4", Offset = "0xA7D3E4", VA = "0xA7D3E4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xA7D638", Offset = "0xA7D638", VA = "0xA7D638", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xA7D798", Offset = "0xA7D798", VA = "0xA7D798")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xA7DA34", Offset = "0xA7DA34", VA = "0xA7DA34", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xA7DDE4", Offset = "0xA7DDE4", VA = "0xA7DDE4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xA7DEA8", Offset = "0xA7DEA8", VA = "0xA7DEA8")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xA7E0C4", Offset = "0xA7E0C4", VA = "0xA7E0C4")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xA7E40C", Offset = "0xA7E40C", VA = "0xA7E40C")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xA7E918", Offset = "0xA7E918", VA = "0xA7E918")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xA7D860", Offset = "0xA7D860", VA = "0xA7D860")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xA7ED38", Offset = "0xA7ED38", VA = "0xA7ED38")]
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
			[Address(RVA = "0xA802C0", Offset = "0xA802C0", VA = "0xA802C0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xA80B68", Offset = "0xA80B68", VA = "0xA80B68")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xA7B684", Offset = "0xA7B684", VA = "0xA7B684")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0xA80C04", Offset = "0xA80C04", VA = "0xA80C04")]
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
		[Address(RVA = "0xA7EFA0", Offset = "0xA7EFA0", VA = "0xA7EFA0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xA7F134", Offset = "0xA7F134", VA = "0xA7F134")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xA7F2B4", Offset = "0xA7F2B4", VA = "0xA7F2B4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xA7F2C0", Offset = "0xA7F2C0", VA = "0xA7F2C0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xA7F2DC", Offset = "0xA7F2DC", VA = "0xA7F2DC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xA7F2E8", Offset = "0xA7F2E8", VA = "0xA7F2E8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xA7F2F0", Offset = "0xA7F2F0", VA = "0xA7F2F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xA7F400", Offset = "0xA7F400", VA = "0xA7F400", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xA7F4F8", Offset = "0xA7F4F8", VA = "0xA7F4F8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xA7F538", Offset = "0xA7F538", VA = "0xA7F538", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xA7F588", Offset = "0xA7F588", VA = "0xA7F588", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xA7F95C", Offset = "0xA7F95C", VA = "0xA7F95C")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xA7F9D8", Offset = "0xA7F9D8", VA = "0xA7F9D8")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xA7FECC", Offset = "0xA7FECC", VA = "0xA7FECC")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xA80024", Offset = "0xA80024", VA = "0xA80024", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xA801D0", Offset = "0xA801D0", VA = "0xA801D0")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xA80150", Offset = "0xA80150", VA = "0xA80150")]
		public void InitiateBones()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xA803B0", Offset = "0xA803B0", VA = "0xA803B0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xA80BF8", Offset = "0xA80BF8", VA = "0xA80BF8", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xA80BFC", Offset = "0xA80BFC", VA = "0xA80BFC", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xA80C00", Offset = "0xA80C00", VA = "0xA80C00", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xA809A8", Offset = "0xA809A8", VA = "0xA809A8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xA7C844", Offset = "0xA7C844", VA = "0xA7C844")]
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
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust its position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			[LargeHeader("Hand")]
			public Transform target;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[LargeHeader("Shoulder")]
			[Tooltip("The weight of shoulder rotation")]
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
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("Tweak this value to adjust shoulder rotation around the yaw (up) axis.")]
			public float shoulderYawOffset;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Tweak this value to adjust shoulder rotation around the pitch (forward) axis.")]
			[ShowIf("shoulderRotationWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float shoulderPitchOffset;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			[LargeHeader("Bending")]
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
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[LargeHeader("Stretching")]
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
				[Address(RVA = "0xA867F4", Offset = "0xA867F4", VA = "0xA867F4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000454")]
				[Address(RVA = "0xA86800", Offset = "0xA86800", VA = "0xA86800")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0xA8680C", Offset = "0xA8680C", VA = "0xA8680C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000456")]
				[Address(RVA = "0xA86818", Offset = "0xA86818", VA = "0xA86818")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0xA86824", Offset = "0xA86824", VA = "0xA86824")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006F")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0xA8684C", Offset = "0xA8684C", VA = "0xA8684C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0xA86880", Offset = "0xA86880", VA = "0xA86880")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone hand
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0xA868C0", Offset = "0xA868C0", VA = "0xA868C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xA86900", Offset = "0xA86900", VA = "0xA86900", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xA87260", Offset = "0xA87260", VA = "0xA87260", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x600045D")]
			[Address(RVA = "0xA8750C", Offset = "0xA8750C", VA = "0xA8750C", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xA87530", Offset = "0xA87530", VA = "0xA87530")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600045F")]
			[Address(RVA = "0xA84658", Offset = "0xA84658", VA = "0xA84658")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0xA87F64", Offset = "0xA87F64", VA = "0xA87F64", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0xA87FBC", Offset = "0xA87FBC", VA = "0xA87FBC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0xA87880", Offset = "0xA87880", VA = "0xA87880")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0xA87900", Offset = "0xA87900", VA = "0xA87900")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0xA881C8", Offset = "0xA881C8", VA = "0xA881C8")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0xA86648", Offset = "0xA86648", VA = "0xA86648")]
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
				[Address(RVA = "0xA88384", Offset = "0xA88384", VA = "0xA88384")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046C")]
				[Address(RVA = "0xA8838C", Offset = "0xA8838C", VA = "0xA8838C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000073")]
			public float mag
			{
				[Token(Token = "0x600046D")]
				[Address(RVA = "0xA88394", Offset = "0xA88394", VA = "0xA88394")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600046E")]
				[Address(RVA = "0xA8839C", Offset = "0xA8839C", VA = "0xA8839C")]
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
			[Address(RVA = "0xA883A4", Offset = "0xA883A4", VA = "0xA883A4")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0xA7B268", Offset = "0xA7B268", VA = "0xA7B268")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0xA883AC", Offset = "0xA883AC", VA = "0xA883AC")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0xA88434", Offset = "0xA88434", VA = "0xA88434")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0xA884CC", Offset = "0xA884CC", VA = "0xA884CC")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0xA84530", Offset = "0xA84530", VA = "0xA84530")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0xA87DFC", Offset = "0xA87DFC", VA = "0xA87DFC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0xA88514", Offset = "0xA88514", VA = "0xA88514")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0xA88638", Offset = "0xA88638", VA = "0xA88638")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xA882E0", Offset = "0xA882E0", VA = "0xA882E0")]
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
				[Address(RVA = "0xA8864C", Offset = "0xA8864C", VA = "0xA8864C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000075")]
			public float stepProgress
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0xA88660", Offset = "0xA88660", VA = "0xA88660")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600047B")]
				[Address(RVA = "0xA88668", Offset = "0xA88668", VA = "0xA88668")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0xA88670", Offset = "0xA88670", VA = "0xA88670")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0xA88834", Offset = "0xA88834", VA = "0xA88834")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0xA8887C", Offset = "0xA8887C", VA = "0xA8887C")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0xA88AC0", Offset = "0xA88AC0", VA = "0xA88AC0")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0xA88C60", Offset = "0xA88C60", VA = "0xA88C60")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed, float deltaTime)
			{
			}

			[Token(Token = "0x6000481")]
			[Address(RVA = "0xA88E58", Offset = "0xA88E58", VA = "0xA88E58")]
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
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			[LargeHeader("Bending")]
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
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
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
				[Address(RVA = "0xA88FC8", Offset = "0xA88FC8", VA = "0xA88FC8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000483")]
				[Address(RVA = "0xA88FD4", Offset = "0xA88FD4", VA = "0xA88FD4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000077")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0xA88FE0", Offset = "0xA88FE0", VA = "0xA88FE0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000485")]
				[Address(RVA = "0xA88FEC", Offset = "0xA88FEC", VA = "0xA88FEC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000078")]
			public bool hasToes
			{
				[Token(Token = "0x6000486")]
				[Address(RVA = "0xA88FF8", Offset = "0xA88FF8", VA = "0xA88FF8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000487")]
				[Address(RVA = "0xA89000", Offset = "0xA89000", VA = "0xA89000")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000079")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000488")]
				[Address(RVA = "0xA8900C", Offset = "0xA8900C", VA = "0xA8900C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000489")]
				[Address(RVA = "0xA89034", Offset = "0xA89034", VA = "0xA89034")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private VirtualBone foot
			{
				[Token(Token = "0x600048A")]
				[Address(RVA = "0xA89060", Offset = "0xA89060", VA = "0xA89060")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private VirtualBone toes
			{
				[Token(Token = "0x600048B")]
				[Address(RVA = "0xA8908C", Offset = "0xA8908C", VA = "0xA8908C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x600048C")]
				[Address(RVA = "0xA844FC", Offset = "0xA844FC", VA = "0xA844FC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x600048D")]
				[Address(RVA = "0xA890B8", Offset = "0xA890B8", VA = "0xA890B8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600048E")]
				[Address(RVA = "0xA890C4", Offset = "0xA890C4", VA = "0xA890C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700007F")]
			public Vector3 bendNormalRelToPelvis
			{
				[Token(Token = "0x600048F")]
				[Address(RVA = "0xA890D0", Offset = "0xA890D0", VA = "0xA890D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000490")]
				[Address(RVA = "0xA890E0", Offset = "0xA890E0", VA = "0xA890E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Vector3 bendNormalRelToTarget
			{
				[Token(Token = "0x6000491")]
				[Address(RVA = "0xA890F0", Offset = "0xA890F0", VA = "0xA890F0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000492")]
				[Address(RVA = "0xA89100", Offset = "0xA89100", VA = "0xA89100")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0xA89110", Offset = "0xA89110", VA = "0xA89110", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0xA896C0", Offset = "0xA896C0", VA = "0xA896C0", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0xA89EF0", Offset = "0xA89EF0", VA = "0xA89EF0", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0xA89EA0", Offset = "0xA89EA0", VA = "0xA89EA0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0xA89C54", Offset = "0xA89C54", VA = "0xA89C54")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0xA7B01C", Offset = "0xA7B01C", VA = "0xA7B01C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x6000499")]
			[Address(RVA = "0xA8A764", Offset = "0xA8A764", VA = "0xA8A764")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0xA8A3CC", Offset = "0xA8A3CC", VA = "0xA8A3CC")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0xA8ABBC", Offset = "0xA8ABBC", VA = "0xA8ABBC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0xA8ADC4", Offset = "0xA8ADC4", VA = "0xA8ADC4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0xA7B51C", Offset = "0xA7B51C", VA = "0xA7B51C")]
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
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural/animated locomotion.")]
			public float weight;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Start moving (horizontal distance to HMD + HMD velocity) threshold.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float moveThreshold;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[ShowLargeHeaderIf("Animation", "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[SerializeField]
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
			[Tooltip("X and Z standing offset from the horizontal position of the HMD.")]
			[ShowIf("mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public Vector2 standOffset;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while moving.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileMoving;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while in transition from locomotion to idle state.")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float rootLerpSpeedWhileStopping;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[ShowRangeIf(0f, 50f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			[Tooltip("Lerp root towards the horizontal position of the HMD with this speed while turning on spot.")]
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
			[Tooltip("Max root angle from head forward while moving (ik.solver.spine.maxRootAngle).")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleMoving;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Max root angle from head forward while standing (ik.solver.spine.maxRootAngle.")]
			[ShowRangeIf(0f, 180f, "mode", Mode.Animated, null, false, ShowIfMode.Hidden)]
			public float maxRootAngleStanding;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[HideInInspector]
			[SerializeField]
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
			[Tooltip("Tries to maintain this distance between the legs.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float footDistance;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float stepThreshold;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float angleThreshold;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float comAngleMlp;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxVelocity;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float velocityFactor;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[ShowRangeIf(0.9f, 1f, "mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
			public float maxLegStretch;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			[ShowIf("mode", Mode.Procedural, null, false, ShowIfMode.Hidden)]
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
			[SerializeField]
			[HideInInspector]
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
				[Address(RVA = "0xA8CB04", Offset = "0xA8CB04", VA = "0xA8CB04")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0xA8CB14", Offset = "0xA8CB14", VA = "0xA8CB14")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60004B1")]
				[Address(RVA = "0xA8E440", Offset = "0xA8E440", VA = "0xA8E440")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60004B2")]
				[Address(RVA = "0xA8E474", Offset = "0xA8E474", VA = "0xA8E474")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000084")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60004B3")]
				[Address(RVA = "0xA8E4AC", Offset = "0xA8E4AC", VA = "0xA8E4AC")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000085")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60004B4")]
				[Address(RVA = "0xA8E4E0", Offset = "0xA8E4E0", VA = "0xA8E4E0")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0xA8AEA4", Offset = "0xA8AEA4", VA = "0xA8AEA4")]
			public void Initiate(Animator animator, Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0xA8B2F4", Offset = "0xA8B2F4", VA = "0xA8B2F4")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xA8B758", Offset = "0xA8B758", VA = "0xA8B758")]
			public void Relax()
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xA8B7A8", Offset = "0xA8B7A8", VA = "0xA8B7A8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xA8BCF0", Offset = "0xA8BCF0", VA = "0xA8BCF0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xA8B218", Offset = "0xA8B218", VA = "0xA8B218")]
			public void Initiate_Animated(Animator animator, Vector3[] positions)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xA8BE38", Offset = "0xA8BE38", VA = "0xA8BE38")]
			private void ResetParams(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xA8B510", Offset = "0xA8B510", VA = "0xA8B510")]
			public void Reset_Animated(Vector3[] positions)
			{
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xA8BBE8", Offset = "0xA8BBE8", VA = "0xA8BBE8")]
			private void AddDeltaRotation_Animated(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xA8BDE8", Offset = "0xA8BDE8", VA = "0xA8BDE8")]
			private void AddDeltaPosition_Animated(Vector3 delta)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0xA8BEF0", Offset = "0xA8BEF0", VA = "0xA8BEF0")]
			public void Solve_Animated(IKSolverVR solver, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xA8AEE4", Offset = "0xA8AEE4", VA = "0xA8AEE4")]
			private void Initiate_Procedural(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xA8B31C", Offset = "0xA8B31C", VA = "0xA8B31C")]
			private void Reset_Procedural(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xA8B75C", Offset = "0xA8B75C", VA = "0xA8B75C")]
			private void Relax_Procedural()
			{
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0xA8B818", Offset = "0xA8B818", VA = "0xA8B818")]
			private void AddDeltaRotation_Procedural(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xA8BD30", Offset = "0xA8BD30", VA = "0xA8BD30")]
			private void AddDeltaPosition_Procedural(Vector3 delta)
			{
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0xA8CB24", Offset = "0xA8CB24", VA = "0xA8CB24")]
			public void Solve_Procedural(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale, float deltaTime)
			{
			}

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xA8E048", Offset = "0xA8E048", VA = "0xA8E048")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0xA8E200", Offset = "0xA8E200", VA = "0xA8E200")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0xA8E290", Offset = "0xA8E290", VA = "0xA8E290")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0xA8E518", Offset = "0xA8E518", VA = "0xA8E518")]
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
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust its position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			[LargeHeader("Head")]
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
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
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
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			[Tooltip("If abs(head target height - head bone height) < this value, will use head bone height as head target Y.")]
			public float useAnimatedHeadHeightRange;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Falloff range for the 'Use Animated Head Height Range' effect above. If head target height from head bone height is greater than useAnimatedHeadHeightRange + animatedHeadHeightBlend, then the head will be vertically locked to the head target again.")]
			[ShowIf("useAnimatedHeadHeightWeight", 0f, float.PositiveInfinity, false, ShowIfMode.Hidden)]
			public float animatedHeadHeightBlend;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[LargeHeader("Pelvis")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain its animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[LargeHeader("Chest")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Range(0f, 1f)]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			public float chestGoalWeight;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			public float chestClampWeight;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[LargeHeader("Spine")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[LargeHeader("Root Rotation")]
			[Range(0f, 180f)]
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
				[Address(RVA = "0xA8DFE0", Offset = "0xA8DFE0", VA = "0xA8DFE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			internal VirtualBone firstSpineBone
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0xA8E68C", Offset = "0xA8E68C", VA = "0xA8E68C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000088")]
			internal VirtualBone chest
			{
				[Token(Token = "0x60004BB")]
				[Address(RVA = "0xA8E6C0", Offset = "0xA8E6C0", VA = "0xA8E6C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			internal VirtualBone head
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0xA8E014", Offset = "0xA8E014", VA = "0xA8E014")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008A")]
			private VirtualBone neck
			{
				[Token(Token = "0x60004BD")]
				[Address(RVA = "0xA8E708", Offset = "0xA8E708", VA = "0xA8E708")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			internal Quaternion anchorRotation
			{
				[Token(Token = "0x60004BE")]
				[Address(RVA = "0xA8E73C", Offset = "0xA8E73C", VA = "0xA8E73C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004BF")]
				[Address(RVA = "0xA8E750", Offset = "0xA8E750", VA = "0xA8E750")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700008C")]
			internal Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x60004C0")]
				[Address(RVA = "0xA8E764", Offset = "0xA8E764", VA = "0xA8E764")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60004C1")]
				[Address(RVA = "0xA8E778", Offset = "0xA8E778", VA = "0xA8E778")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xA8E78C", Offset = "0xA8E78C", VA = "0xA8E78C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0xA8F4BC", Offset = "0xA8F4BC", VA = "0xA8F4BC", Slot = "5")]
			public override void PreSolve(float scale)
			{
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xA8F8C8", Offset = "0xA8F8C8", VA = "0xA8F8C8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xA9006C", Offset = "0xA9006C", VA = "0xA9006C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xA906C4", Offset = "0xA906C4", VA = "0xA906C4")]
			public void Solve(Animator animator, VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xA91100", Offset = "0xA91100", VA = "0xA91100")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xA918AC", Offset = "0xA918AC", VA = "0xA918AC")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xA92270", Offset = "0xA92270", VA = "0xA92270", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xA92440", Offset = "0xA92440", VA = "0xA92440", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xA902CC", Offset = "0xA902CC", VA = "0xA902CC")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0xA915D4", Offset = "0xA915D4", VA = "0xA915D4")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xA90CE0", Offset = "0xA90CE0", VA = "0xA90CE0")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0xA92514", Offset = "0xA92514", VA = "0xA92514")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0xA916B0", Offset = "0xA916B0", VA = "0xA916B0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0xA91364", Offset = "0xA91364", VA = "0xA91364")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xA92934", Offset = "0xA92934", VA = "0xA92934")]
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
			[Address(RVA = "0xA8F42C", Offset = "0xA8F42C", VA = "0xA8F42C")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xA8F49C", Offset = "0xA8F49C", VA = "0xA8F49C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0xA92A68", Offset = "0xA92A68", VA = "0xA92A68")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xA92C68", Offset = "0xA92C68", VA = "0xA92C68")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xA927C4", Offset = "0xA927C4", VA = "0xA927C4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xA92DC8", Offset = "0xA92DC8", VA = "0xA92DC8")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0xA92F70", Offset = "0xA92F70", VA = "0xA92F70")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xA930F8", Offset = "0xA930F8", VA = "0xA930F8")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0xA91E8C", Offset = "0xA91E8C", VA = "0xA91E8C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0xA9319C", Offset = "0xA9319C", VA = "0xA9319C")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0xA91AC0", Offset = "0xA91AC0", VA = "0xA91AC0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xA932F4", Offset = "0xA932F4", VA = "0xA932F4")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0xA93408", Offset = "0xA93408", VA = "0xA93408")]
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
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
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
			[Address(RVA = "0xA80C0C", Offset = "0xA80C0C", VA = "0xA80C0C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xA80C14", Offset = "0xA80C14", VA = "0xA80C14")]
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
			[Address(RVA = "0xA8634C", Offset = "0xA8634C", VA = "0xA8634C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xA86354", Offset = "0xA86354", VA = "0xA86354")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xA80C1C", Offset = "0xA80C1C", VA = "0xA80C1C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xA810E8", Offset = "0xA810E8", VA = "0xA810E8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xA80F7C", Offset = "0xA80F7C", VA = "0xA80F7C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xA814FC", Offset = "0xA814FC", VA = "0xA814FC")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xA81644", Offset = "0xA81644", VA = "0xA81644")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xA81684", Offset = "0xA81684", VA = "0xA81684")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xA817A8", Offset = "0xA817A8", VA = "0xA817A8")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xA81884", Offset = "0xA81884", VA = "0xA81884")]
		public void Reset()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xA82074", Offset = "0xA82074", VA = "0xA82074", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xA821C8", Offset = "0xA821C8", VA = "0xA821C8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xA823B4", Offset = "0xA823B4", VA = "0xA823B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xA82424", Offset = "0xA82424", VA = "0xA82424", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xA82494", Offset = "0xA82494", VA = "0xA82494", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xA8269C", Offset = "0xA8269C", VA = "0xA8269C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xA813E8", Offset = "0xA813E8", VA = "0xA813E8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xA819A0", Offset = "0xA819A0", VA = "0xA819A0")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xA8290C", Offset = "0xA8290C", VA = "0xA8290C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xA82950", Offset = "0xA82950", VA = "0xA82950", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xA84034", Offset = "0xA84034", VA = "0xA84034")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xA81AF0", Offset = "0xA81AF0", VA = "0xA81AF0")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, bool hasArms)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xA82D6C", Offset = "0xA82D6C", VA = "0xA82D6C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA84488", Offset = "0xA84488", VA = "0xA84488")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xA844C4", Offset = "0xA844C4", VA = "0xA844C4")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xA83EF0", Offset = "0xA83EF0", VA = "0xA83EF0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xA85C68", Offset = "0xA85C68", VA = "0xA85C68")]
		private Vector3 GetPelvisOffset(float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xA8635C", Offset = "0xA8635C", VA = "0xA8635C")]
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
		[Address(RVA = "0xA935BC", Offset = "0xA935BC", VA = "0xA935BC")]
		public void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xA93CF8", Offset = "0xA93CF8", VA = "0xA93CF8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xA93E64", Offset = "0xA93E64", VA = "0xA93E64")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xA943F8", Offset = "0xA943F8", VA = "0xA943F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xA944A8", Offset = "0xA944A8", VA = "0xA944A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xA945E0", Offset = "0xA945E0", VA = "0xA945E0")]
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
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
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
		[Address(RVA = "0xA94644", Offset = "0xA94644", VA = "0xA94644")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xA937A4", Offset = "0xA937A4", VA = "0xA937A4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xA93DB8", Offset = "0xA93DB8", VA = "0xA93DB8")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xA93F14", Offset = "0xA93F14", VA = "0xA93F14")]
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
			[Address(RVA = "0xA94774", Offset = "0xA94774", VA = "0xA94774")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xA9477C", Offset = "0xA9477C", VA = "0xA9477C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public bool isPaused
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xA94784", Offset = "0xA94784", VA = "0xA94784")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0xA9478C", Offset = "0xA9478C", VA = "0xA9478C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xA94798", Offset = "0xA94798", VA = "0xA94798")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xA947A0", Offset = "0xA947A0", VA = "0xA947A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public bool inInteraction
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xA947A8", Offset = "0xA947A8", VA = "0xA947A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public float progress
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xA97128", Offset = "0xA97128", VA = "0xA97128")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xA94808", Offset = "0xA94808", VA = "0xA94808")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xA948A4", Offset = "0xA948A4", VA = "0xA948A4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xA9495C", Offset = "0xA9495C", VA = "0xA9495C")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xA94AC8", Offset = "0xA94AC8", VA = "0xA94AC8")]
		public bool ResetToDefaults(float speed, float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xA94EA0", Offset = "0xA94EA0", VA = "0xA94EA0")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xA94FC0", Offset = "0xA94FC0", VA = "0xA94FC0")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xA95014", Offset = "0xA95014", VA = "0xA95014")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xA95260", Offset = "0xA95260", VA = "0xA95260")]
		public bool Start(InteractionObject interactionObject, InteractionTarget interactionTarget, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xA95DD4", Offset = "0xA95DD4", VA = "0xA95DD4")]
		public void Update(Transform root, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xA9691C", Offset = "0xA9691C", VA = "0xA9691C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xA96B3C", Offset = "0xA96B3C", VA = "0xA96B3C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xA97010", Offset = "0xA97010", VA = "0xA97010")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xA97328", Offset = "0xA97328", VA = "0xA97328")]
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
		[Address(RVA = "0xA975F0", Offset = "0xA975F0", VA = "0xA975F0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xA9770C", Offset = "0xA9770C", VA = "0xA9770C")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xA977A4", Offset = "0xA977A4", VA = "0xA977A4")]
		public void Update()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xA979AC", Offset = "0xA979AC", VA = "0xA979AC")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xA97A54", Offset = "0xA97A54", VA = "0xA97A54")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xA97B00", Offset = "0xA97B00", VA = "0xA97B00")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
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
			[Address(RVA = "0xA97158", Offset = "0xA97158", VA = "0xA97158")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000521")]
			[Address(RVA = "0xA98A48", Offset = "0xA98A48", VA = "0xA98A48")]
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
			[Address(RVA = "0xA98950", Offset = "0xA98950", VA = "0xA98950")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000523")]
			[Address(RVA = "0xA98A50", Offset = "0xA98A50", VA = "0xA98A50")]
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
			[Address(RVA = "0xA98874", Offset = "0xA98874", VA = "0xA98874")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000525")]
			[Address(RVA = "0xA98A58", Offset = "0xA98A58", VA = "0xA98A58")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x6000526")]
			[Address(RVA = "0xA98B08", Offset = "0xA98B08", VA = "0xA98B08")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x6000527")]
			[Address(RVA = "0xA98BE0", Offset = "0xA98BE0", VA = "0xA98BE0")]
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
			[Address(RVA = "0xA981AC", Offset = "0xA981AC", VA = "0xA981AC")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xA98BF4", Offset = "0xA98BF4", VA = "0xA98BF4")]
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
			[Address(RVA = "0xA98780", Offset = "0xA98780", VA = "0xA98780")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0xA98BFC", Offset = "0xA98BFC", VA = "0xA98BFC")]
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
			[Address(RVA = "0xA97D34", Offset = "0xA97D34", VA = "0xA97D34")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xA97D3C", Offset = "0xA97D3C", VA = "0xA97D3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xA97D44", Offset = "0xA97D44", VA = "0xA97D44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xA97D4C", Offset = "0xA97D4C", VA = "0xA97D4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xA97F0C", Offset = "0xA97F0C", VA = "0xA97F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xA9721C", Offset = "0xA9721C", VA = "0xA9721C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xA97B14", Offset = "0xA97B14", VA = "0xA97B14")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xA97B58", Offset = "0xA97B58", VA = "0xA97B58")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xA97B9C", Offset = "0xA97B9C", VA = "0xA97B9C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xA97BE0", Offset = "0xA97BE0", VA = "0xA97BE0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xA97C24", Offset = "0xA97C24", VA = "0xA97C24")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xA97C68", Offset = "0xA97C68", VA = "0xA97C68")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xA97CAC", Offset = "0xA97CAC", VA = "0xA97CAC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xA97CF0", Offset = "0xA97CF0", VA = "0xA97CF0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xA97D54", Offset = "0xA97D54", VA = "0xA97D54")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xA97F8C", Offset = "0xA97F8C", VA = "0xA97F8C")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xA956F8", Offset = "0xA956F8", VA = "0xA956F8")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xA980DC", Offset = "0xA980DC", VA = "0xA980DC")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xA9512C", Offset = "0xA9512C", VA = "0xA9512C")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xA956F0", Offset = "0xA956F0", VA = "0xA956F0")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xA96514", Offset = "0xA96514", VA = "0xA96514")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xA96E04", Offset = "0xA96E04", VA = "0xA96E04")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xA987B0", Offset = "0xA987B0", VA = "0xA987B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xA981C8", Offset = "0xA981C8", VA = "0xA981C8")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xA980E4", Offset = "0xA980E4", VA = "0xA980E4")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xA98724", Offset = "0xA98724", VA = "0xA98724")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xA987B4", Offset = "0xA987B4", VA = "0xA987B4")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xA98810", Offset = "0xA98810", VA = "0xA98810")]
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
		[FormerlySerializedAs("collider")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
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
		[Space(10f)]
		[Tooltip("Reference to the FBBIK component.")]
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
			[Address(RVA = "0xA98E2C", Offset = "0xA98E2C", VA = "0xA98E2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xA9A9DC", Offset = "0xA9A9DC", VA = "0xA9A9DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xA9A9E4", Offset = "0xA9A9E4", VA = "0xA9A9E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xA9A9EC", Offset = "0xA9A9EC", VA = "0xA9A9EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000552")]
			[Address(RVA = "0xA9A9F4", Offset = "0xA9A9F4", VA = "0xA9A9F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool initiated
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0xA9A9FC", Offset = "0xA9A9FC", VA = "0xA9A9FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0xA9AA04", Offset = "0xA9AA04", VA = "0xA9AA04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xA98C0C", Offset = "0xA98C0C", VA = "0xA98C0C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xA98C50", Offset = "0xA98C50", VA = "0xA98C50")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xA98C94", Offset = "0xA98C94", VA = "0xA98C94")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xA98CD8", Offset = "0xA98CD8", VA = "0xA98CD8")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xA98D1C", Offset = "0xA98D1C", VA = "0xA98D1C")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xA98D60", Offset = "0xA98D60", VA = "0xA98D60")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xA98DA4", Offset = "0xA98DA4", VA = "0xA98DA4")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xA98DE8", Offset = "0xA98DE8", VA = "0xA98DE8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xA98FA4", Offset = "0xA98FA4", VA = "0xA98FA4")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xA9905C", Offset = "0xA9905C", VA = "0xA9905C")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xA99114", Offset = "0xA99114", VA = "0xA99114")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xA991AC", Offset = "0xA991AC", VA = "0xA991AC")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xA99290", Offset = "0xA99290", VA = "0xA99290")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xA99388", Offset = "0xA99388", VA = "0xA99388")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionTarget target, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xA99490", Offset = "0xA99490", VA = "0xA99490")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xA99514", Offset = "0xA99514", VA = "0xA99514")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xA99598", Offset = "0xA99598", VA = "0xA99598")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xA9961C", Offset = "0xA9961C", VA = "0xA9961C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xA99684", Offset = "0xA99684", VA = "0xA99684")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xA996EC", Offset = "0xA996EC", VA = "0xA996EC")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xA99748", Offset = "0xA99748", VA = "0xA99748")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xA997C8", Offset = "0xA997C8", VA = "0xA997C8")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xA99870", Offset = "0xA99870", VA = "0xA99870")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xA99940", Offset = "0xA99940", VA = "0xA99940")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xA99BD0", Offset = "0xA99BD0", VA = "0xA99BD0")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xA99DA4", Offset = "0xA99DA4", VA = "0xA99DA4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xA9A014", Offset = "0xA9A014", VA = "0xA9A014")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xA9A2A0", Offset = "0xA9A2A0", VA = "0xA9A2A0")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xA9A2D8", Offset = "0xA9A2D8", VA = "0xA9A2D8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xA9A338", Offset = "0xA9A338", VA = "0xA9A338")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xA9A464", Offset = "0xA9A464", VA = "0xA9A464")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xA9A648", Offset = "0xA9A648", VA = "0xA9A648")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xA9A8BC", Offset = "0xA9A8BC", VA = "0xA9A8BC")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xA9A0FC", Offset = "0xA9A0FC", VA = "0xA9A0FC")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xA9AA10", Offset = "0xA9AA10", VA = "0xA9AA10")]
		public void Start()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xA9B334", Offset = "0xA9B334", VA = "0xA9B334")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xA9B354", Offset = "0xA9B354", VA = "0xA9B354")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xA9B370", Offset = "0xA9B370", VA = "0xA9B370")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xA9B38C", Offset = "0xA9B38C", VA = "0xA9B38C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xA9B3E0", Offset = "0xA9B3E0", VA = "0xA9B3E0")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xA9B564", Offset = "0xA9B564", VA = "0xA9B564")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xA9B660", Offset = "0xA9B660", VA = "0xA9B660")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xA9B80C", Offset = "0xA9B80C", VA = "0xA9B80C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xA9B924", Offset = "0xA9B924", VA = "0xA9B924")]
		public void Update()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xA9BBE8", Offset = "0xA9BBE8", VA = "0xA9BBE8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xA9B0D4", Offset = "0xA9B0D4", VA = "0xA9B0D4")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xA9BD18", Offset = "0xA9BD18", VA = "0xA9BD18")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xA9BD34", Offset = "0xA9BD34", VA = "0xA9BD34")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xA9BE70", Offset = "0xA9BE70", VA = "0xA9BE70")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xA9BEF8", Offset = "0xA9BEF8", VA = "0xA9BEF8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xA9BFB8", Offset = "0xA9BFB8", VA = "0xA9BFB8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xA9BFD0", Offset = "0xA9BFD0", VA = "0xA9BFD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xA98EC4", Offset = "0xA98EC4", VA = "0xA98EC4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xA99ABC", Offset = "0xA99ABC", VA = "0xA99ABC")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xA9C448", Offset = "0xA9C448", VA = "0xA9C448")]
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
			[Address(RVA = "0xA9CD64", Offset = "0xA9CD64", VA = "0xA9CD64")]
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
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
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
		[Address(RVA = "0xA9CAD0", Offset = "0xA9CAD0", VA = "0xA9CAD0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xA9CB14", Offset = "0xA9CB14", VA = "0xA9CB14")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xA9CB58", Offset = "0xA9CB58", VA = "0xA9CB58")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xA9CB9C", Offset = "0xA9CB9C", VA = "0xA9CB9C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xA9CBE0", Offset = "0xA9CBE0", VA = "0xA9CBE0")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xA9CC24", Offset = "0xA9CC24", VA = "0xA9CC24")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xA9CC68", Offset = "0xA9CC68", VA = "0xA9CC68")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xA9CCAC", Offset = "0xA9CCAC", VA = "0xA9CCAC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xA98148", Offset = "0xA98148", VA = "0xA98148")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xA9729C", Offset = "0xA9729C", VA = "0xA9729C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xA9578C", Offset = "0xA9578C", VA = "0xA9578C")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xA9CCF0", Offset = "0xA9CCF0", VA = "0xA9CCF0")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
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
				[Address(RVA = "0xA9D188", Offset = "0xA9D188", VA = "0xA9D188")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0xA9D194", Offset = "0xA9D194", VA = "0xA9D194")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0xA9D254", Offset = "0xA9D254", VA = "0xA9D254")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0xA9D9B8", Offset = "0xA9D9B8", VA = "0xA9D9B8")]
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
			[Address(RVA = "0xA9D9CC", Offset = "0xA9D9CC", VA = "0xA9D9CC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0xA9DB44", Offset = "0xA9DB44", VA = "0xA9DB44")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0xA9DE4C", Offset = "0xA9DE4C", VA = "0xA9DE4C")]
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
				[Address(RVA = "0xA9DED0", Offset = "0xA9DED0", VA = "0xA9DED0")]
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
			[Address(RVA = "0xA9D074", Offset = "0xA9D074", VA = "0xA9D074")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0xA9DEC0", Offset = "0xA9DEC0", VA = "0xA9DEC0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or its camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xA9CD6C", Offset = "0xA9CD6C", VA = "0xA9CD6C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xA9CDB0", Offset = "0xA9CDB0", VA = "0xA9CDB0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xA9CDF4", Offset = "0xA9CDF4", VA = "0xA9CDF4")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xA9CE38", Offset = "0xA9CE38", VA = "0xA9CE38")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xA9CE7C", Offset = "0xA9CE7C", VA = "0xA9CE7C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xA9CEC0", Offset = "0xA9CEC0", VA = "0xA9CEC0")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xA9D124", Offset = "0xA9D124", VA = "0xA9D124")]
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
			[Address(RVA = "0xA9E1D0", Offset = "0xA9E1D0", VA = "0xA9E1D0")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0xA9E528", Offset = "0xA9E528", VA = "0xA9E528")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0xA9E4E8", Offset = "0xA9E4E8", VA = "0xA9E4E8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0xA9E36C", Offset = "0xA9E36C", VA = "0xA9E36C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xA9DED8", Offset = "0xA9DED8", VA = "0xA9DED8", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xA9E278", Offset = "0xA9E278", VA = "0xA9E278", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xA9E27C", Offset = "0xA9E27C", VA = "0xA9E27C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xA9E48C", Offset = "0xA9E48C", VA = "0xA9E48C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xA9E21C", Offset = "0xA9E21C", VA = "0xA9E21C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xA9E13C", Offset = "0xA9E13C", VA = "0xA9E13C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xA9E56C", Offset = "0xA9E56C", VA = "0xA9E56C")]
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
		[Address(RVA = "0xA9E58C", Offset = "0xA9E58C", VA = "0xA9E58C", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xA9E65C", Offset = "0xA9E65C", VA = "0xA9E65C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xA9E834", Offset = "0xA9E834", VA = "0xA9E834", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xA9E91C", Offset = "0xA9E91C", VA = "0xA9E91C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xA9E6BC", Offset = "0xA9E6BC", VA = "0xA9E6BC")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xA9EC4C", Offset = "0xA9EC4C", VA = "0xA9EC4C")]
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
		[Address(RVA = "0xA9EC5C", Offset = "0xA9EC5C", VA = "0xA9EC5C")]
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
		[Address(RVA = "0xA9EC68", Offset = "0xA9EC68", VA = "0xA9EC68", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xA9ECAC", Offset = "0xA9ECAC", VA = "0xA9ECAC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xA9ECD8", Offset = "0xA9ECD8", VA = "0xA9ECD8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xA9E57C", Offset = "0xA9E57C", VA = "0xA9E57C")]
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
			[Address(RVA = "0xA9F348", Offset = "0xA9F348", VA = "0xA9F348")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xA9FEF4", Offset = "0xA9FEF4", VA = "0xA9FEF4")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xA9FCB4", Offset = "0xA9FCB4", VA = "0xA9FCB4")]
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
			[Address(RVA = "0xA9F4F0", Offset = "0xA9F4F0", VA = "0xA9F4F0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xAA000C", Offset = "0xAA000C", VA = "0xAA000C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xA9FFC8", Offset = "0xA9FFC8", VA = "0xA9FFC8")]
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
				[Address(RVA = "0xAA0578", Offset = "0xAA0578", VA = "0xAA0578", Slot = "4")]
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
				[Address(RVA = "0xAA05C0", Offset = "0xAA05C0", VA = "0xAA05C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xA9F55C", Offset = "0xA9F55C", VA = "0xA9F55C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xAA0388", Offset = "0xAA0388", VA = "0xAA0388", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xAA038C", Offset = "0xAA038C", VA = "0xAA038C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xAA0580", Offset = "0xAA0580", VA = "0xAA0580", Slot = "8")]
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
			[Address(RVA = "0xA9ED1C", Offset = "0xA9ED1C", VA = "0xA9ED1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		private bool ikUsed
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xA9F8E8", Offset = "0xA9F8E8", VA = "0xA9F8E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xA9ECF0", Offset = "0xA9ECF0", VA = "0xA9ECF0")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xA9ED80", Offset = "0xA9ED80", VA = "0xA9ED80")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xA9EE98", Offset = "0xA9EE98", VA = "0xA9EE98")]
		public void Start()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xA9EE24", Offset = "0xA9EE24", VA = "0xA9EE24")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xA9F584", Offset = "0xA9F584", VA = "0xA9F584")]
		private void Update()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xA9F7AC", Offset = "0xA9F7AC", VA = "0xA9F7AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xA9F84C", Offset = "0xA9F84C", VA = "0xA9F84C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xA9FA3C", Offset = "0xA9FA3C", VA = "0xA9FA3C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xA9F8BC", Offset = "0xA9F8BC", VA = "0xA9F8BC")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xA9FA08", Offset = "0xA9FA08", VA = "0xA9FA08")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xA9FABC", Offset = "0xA9FABC", VA = "0xA9FABC")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xA9FA60", Offset = "0xA9FA60", VA = "0xA9FA60")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xA9EDC8", Offset = "0xA9EDC8", VA = "0xA9EDC8")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xA9F7E0", Offset = "0xA9F7E0", VA = "0xA9F7E0")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xAA011C", Offset = "0xAA011C", VA = "0xAA011C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xAA0254", Offset = "0xAA0254", VA = "0xAA0254")]
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
			[Address(RVA = "0xAA0A2C", Offset = "0xAA0A2C", VA = "0xAA0A2C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A1")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xAA0A38", Offset = "0xAA0A38", VA = "0xAA0A38")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000A2")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xAA0A68", Offset = "0xAA0A68", VA = "0xAA0A68")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xAA0A70", Offset = "0xAA0A70", VA = "0xAA0A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xAA05C8", Offset = "0xAA05C8", VA = "0xAA05C8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xAA0604", Offset = "0xAA0604", VA = "0xAA0604")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xAA061C", Offset = "0xAA061C", VA = "0xAA061C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xAA099C", Offset = "0xAA099C", VA = "0xAA099C")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xAA0A00", Offset = "0xAA0A00", VA = "0xAA0A00")]
		public void Disable()
		{
		}

		[Token(Token = "0x60005D1")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xAA08A0", Offset = "0xAA08A0", VA = "0xAA08A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xAA0A7C", Offset = "0xAA0A7C", VA = "0xAA0A7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xAA0A80", Offset = "0xAA0A80", VA = "0xAA0A80")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xAA0AA8", Offset = "0xAA0AA8", VA = "0xAA0AA8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xAA0B7C", Offset = "0xAA0B7C", VA = "0xAA0B7C")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xAA0DD4", Offset = "0xAA0DD4", VA = "0xAA0DD4")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xAA0F28", Offset = "0xAA0F28", VA = "0xAA0F28")]
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
		[Address(RVA = "0xAA0F88", Offset = "0xAA0F88", VA = "0xAA0F88")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xAA0FCC", Offset = "0xAA0FCC", VA = "0xAA0FCC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xAA1010", Offset = "0xAA1010", VA = "0xAA1010")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xAA1054", Offset = "0xAA1054", VA = "0xAA1054")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xAA1098", Offset = "0xAA1098", VA = "0xAA1098", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xAA10D0", Offset = "0xAA10D0", VA = "0xAA10D0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xAA13F4", Offset = "0xAA13F4", VA = "0xAA13F4")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
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
		[Address(RVA = "0xAA1404", Offset = "0xAA1404", VA = "0xAA1404")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xAA1448", Offset = "0xAA1448", VA = "0xAA1448")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xAA148C", Offset = "0xAA148C", VA = "0xAA148C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xAA14D0", Offset = "0xAA14D0", VA = "0xAA14D0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xAA1514", Offset = "0xAA1514", VA = "0xAA1514", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xAA1518", Offset = "0xAA1518", VA = "0xAA1518")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xAA1738", Offset = "0xAA1738", VA = "0xAA1738")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
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
				[Address(RVA = "0xAA35E4", Offset = "0xAA35E4", VA = "0xAA35E4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A4")]
			public Vector3 a
			{
				[Token(Token = "0x60005F8")]
				[Address(RVA = "0xAA3610", Offset = "0xAA3610", VA = "0xAA3610")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 b
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xAA3640", Offset = "0xAA3640", VA = "0xAA3640")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A6")]
			public Vector3 c
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0xAA3670", Offset = "0xAA3670", VA = "0xAA3670")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A7")]
			public bool isValid
			{
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0xAA2B0C", Offset = "0xAA2B0C", VA = "0xAA2B0C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xAA2FB0", Offset = "0xAA2FB0", VA = "0xAA2FB0")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0xAA3128", Offset = "0xAA3128", VA = "0xAA3128")]
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
			[Address(RVA = "0xAA2B1C", Offset = "0xAA2B1C", VA = "0xAA2B1C")]
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
		[Address(RVA = "0xAA1750", Offset = "0xAA1750", VA = "0xAA1750")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xAA1794", Offset = "0xAA1794", VA = "0xAA1794")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xAA17D8", Offset = "0xAA17D8", VA = "0xAA17D8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xAA181C", Offset = "0xAA181C", VA = "0xAA181C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xAA1860", Offset = "0xAA1860", VA = "0xAA1860")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xAA1F44", Offset = "0xAA1F44", VA = "0xAA1F44", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xAA1FCC", Offset = "0xAA1FCC", VA = "0xAA1FCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xAA2618", Offset = "0xAA2618", VA = "0xAA2618")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xAA18F8", Offset = "0xAA18F8", VA = "0xAA18F8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xAA2B80", Offset = "0xAA2B80", VA = "0xAA2B80")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xAA339C", Offset = "0xAA339C", VA = "0xAA339C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xAA33E4", Offset = "0xAA33E4", VA = "0xAA33E4")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xAA3444", Offset = "0xAA3444", VA = "0xAA3444")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xAA2374", Offset = "0xAA2374", VA = "0xAA2374")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xAA34B0", Offset = "0xAA34B0", VA = "0xAA34B0")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xAA357C", Offset = "0xAA357C", VA = "0xAA357C")]
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
		[Address(RVA = "0xAA36A0", Offset = "0xAA36A0", VA = "0xAA36A0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xAA36E4", Offset = "0xAA36E4", VA = "0xAA36E4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xAA3728", Offset = "0xAA3728", VA = "0xAA3728")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xAA376C", Offset = "0xAA376C", VA = "0xAA376C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xAA37B0", Offset = "0xAA37B0", VA = "0xAA37B0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xAA37CC", Offset = "0xAA37CC", VA = "0xAA37CC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xAA3804", Offset = "0xAA3804", VA = "0xAA3804")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xAA3BB0", Offset = "0xAA3BB0", VA = "0xAA3BB0")]
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
				[Address(RVA = "0xAA4BB4", Offset = "0xAA4BB4", VA = "0xAA4BB4", Slot = "4")]
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
				[Address(RVA = "0xAA4BFC", Offset = "0xAA4BFC", VA = "0xAA4BFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0xAA49B4", Offset = "0xAA49B4", VA = "0xAA49B4")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0xAA4AC0", Offset = "0xAA4AC0", VA = "0xAA4AC0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0xAA4AC4", Offset = "0xAA4AC4", VA = "0xAA4AC4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0xAA4BBC", Offset = "0xAA4BBC", VA = "0xAA4BBC", Slot = "8")]
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
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
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
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
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
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
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
			[Address(RVA = "0xAA3C3C", Offset = "0xAA3C3C", VA = "0xAA3C3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xAA3BBC", Offset = "0xAA3BBC", VA = "0xAA3BBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xAA3CC0", Offset = "0xAA3CC0", VA = "0xAA3CC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xAA4518", Offset = "0xAA4518", VA = "0xAA4518")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xAA469C", Offset = "0xAA469C", VA = "0xAA469C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xAA4940", Offset = "0xAA4940", VA = "0xAA4940")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xAA49DC", Offset = "0xAA49DC", VA = "0xAA49DC")]
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
			[Address(RVA = "0xAA4CD4", Offset = "0xAA4CD4", VA = "0xAA4CD4")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0xAA5250", Offset = "0xAA5250", VA = "0xAA5250")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0xAA5258", Offset = "0xAA5258", VA = "0xAA5258")]
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
		[Address(RVA = "0xAA4C04", Offset = "0xAA4C04", VA = "0xAA4C04")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xAA5184", Offset = "0xAA5184", VA = "0xAA5184")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xAA51E4", Offset = "0xAA51E4", VA = "0xAA51E4")]
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
				[Address(RVA = "0xAA571C", Offset = "0xAA571C", VA = "0xAA571C")]
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
			[Address(RVA = "0xAA53C4", Offset = "0xAA53C4", VA = "0xAA53C4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0xAA56F4", Offset = "0xAA56F4", VA = "0xAA56F4")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0xAA5704", Offset = "0xAA5704", VA = "0xAA5704")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xAA5274", Offset = "0xAA5274", VA = "0xAA5274", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xAA56D4", Offset = "0xAA56D4", VA = "0xAA56D4")]
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
		[Address(RVA = "0xAA5724", Offset = "0xAA5724", VA = "0xAA5724", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xAA578C", Offset = "0xAA578C", VA = "0xAA578C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xAA5A2C", Offset = "0xAA5A2C", VA = "0xAA5A2C")]
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
		[Address(RVA = "0xAA5A48", Offset = "0xAA5A48", VA = "0xAA5A48")]
		private void Start()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xAA5B28", Offset = "0xAA5B28", VA = "0xAA5B28")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xAA5DBC", Offset = "0xAA5DBC", VA = "0xAA5DBC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xAA5EE8", Offset = "0xAA5EE8", VA = "0xAA5EE8")]
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
			[Address(RVA = "0xAA5EF8", Offset = "0xAA5EF8", VA = "0xAA5EF8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0xAA5F00", Offset = "0xAA5F00", VA = "0xAA5F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xAA5F08", Offset = "0xAA5F08", VA = "0xAA5F08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xAA60A8", Offset = "0xAA60A8", VA = "0xAA60A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xAA6304", Offset = "0xAA6304", VA = "0xAA6304")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xAA6440", Offset = "0xAA6440", VA = "0xAA6440")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xAA6620", Offset = "0xAA6620", VA = "0xAA6620")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xAA6834", Offset = "0xAA6834", VA = "0xAA6834")]
		public void Update()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xAA6AB8", Offset = "0xAA6AB8", VA = "0xAA6AB8")]
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
			[Address(RVA = "0xAA6184", Offset = "0xAA6184", VA = "0xAA6184")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xAA64BC", Offset = "0xAA64BC", VA = "0xAA64BC")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xAA61A8", Offset = "0xAA61A8", VA = "0xAA61A8")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xAA6B1C", Offset = "0xAA6B1C", VA = "0xAA6B1C")]
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
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
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
				[Address(RVA = "0xAA6C54", Offset = "0xAA6C54", VA = "0xAA6C54")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AF")]
			protected float crossFader
			{
				[Token(Token = "0x6000639")]
				[Address(RVA = "0xAA703C", Offset = "0xAA703C", VA = "0xAA703C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063A")]
				[Address(RVA = "0xAA7044", Offset = "0xAA7044", VA = "0xAA7044")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			protected float timer
			{
				[Token(Token = "0x600063B")]
				[Address(RVA = "0xAA704C", Offset = "0xAA704C", VA = "0xAA704C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600063C")]
				[Address(RVA = "0xAA7054", Offset = "0xAA7054", VA = "0xAA7054")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			protected Vector3 force
			{
				[Token(Token = "0x600063D")]
				[Address(RVA = "0xAA705C", Offset = "0xAA705C", VA = "0xAA705C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600063E")]
				[Address(RVA = "0xAA7068", Offset = "0xAA7068", VA = "0xAA7068")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0xAA7074", Offset = "0xAA7074", VA = "0xAA7074", Slot = "4")]
			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0xAA6D28", Offset = "0xAA6D28", VA = "0xAA6D28")]
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
			[Address(RVA = "0xAA7180", Offset = "0xAA7180", VA = "0xAA7180")]
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
				[Address(RVA = "0xAA74B4", Offset = "0xAA74B4", VA = "0xAA74B4")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600064A")]
				[Address(RVA = "0xAA7310", Offset = "0xAA7310", VA = "0xAA7310")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600064B")]
				[Address(RVA = "0xAA7564", Offset = "0xAA7564", VA = "0xAA7564")]
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
			[Address(RVA = "0xAA7194", Offset = "0xAA7194", VA = "0xAA7194", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0xAA72B0", Offset = "0xAA72B0", VA = "0xAA72B0", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000647")]
			[Address(RVA = "0xAA7324", Offset = "0xAA7324", VA = "0xAA7324", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0xAA7550", Offset = "0xAA7550", VA = "0xAA7550")]
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
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x40005C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40005C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000651")]
				[Address(RVA = "0xAA789C", Offset = "0xAA789C", VA = "0xAA789C")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000652")]
				[Address(RVA = "0xAA77D0", Offset = "0xAA77D0", VA = "0xAA77D0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000653")]
				[Address(RVA = "0xAA7A3C", Offset = "0xAA7A3C", VA = "0xAA7A3C")]
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
			[Address(RVA = "0xAA756C", Offset = "0xAA756C", VA = "0xAA756C", Slot = "4")]
			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0xAA76EC", Offset = "0xAA76EC", VA = "0xAA76EC", Slot = "5")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0xAA7778", Offset = "0xAA7778", VA = "0xAA7778", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0xAA77DC", Offset = "0xAA77DC", VA = "0xAA77DC", Slot = "7")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0xAA7A28", Offset = "0xAA7A28", VA = "0xAA7A28")]
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
			[Address(RVA = "0xAA6BB8", Offset = "0xAA6BB8", VA = "0xAA6BB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xAA6C68", Offset = "0xAA6C68", VA = "0xAA6C68", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xAA6E00", Offset = "0xAA6E00", VA = "0xAA6E00")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xAA702C", Offset = "0xAA702C", VA = "0xAA702C")]
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
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
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
				[Address(RVA = "0xAA7E8C", Offset = "0xAA7E8C", VA = "0xAA7E8C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000658")]
				[Address(RVA = "0xAA7E94", Offset = "0xAA7E94", VA = "0xAA7E94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B3")]
			protected float timer
			{
				[Token(Token = "0x6000659")]
				[Address(RVA = "0xAA7E9C", Offset = "0xAA7E9C", VA = "0xAA7E9C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600065A")]
				[Address(RVA = "0xAA7EA4", Offset = "0xAA7EA4", VA = "0xAA7EA4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			protected Vector3 force
			{
				[Token(Token = "0x600065B")]
				[Address(RVA = "0xAA7EAC", Offset = "0xAA7EAC", VA = "0xAA7EAC")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065C")]
				[Address(RVA = "0xAA7EB8", Offset = "0xAA7EB8", VA = "0xAA7EB8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0xAA7EC4", Offset = "0xAA7EC4", VA = "0xAA7EC4", Slot = "4")]
			public virtual void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0xAA7B58", Offset = "0xAA7B58", VA = "0xAA7B58")]
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
			[Address(RVA = "0xAA7FD8", Offset = "0xAA7FD8", VA = "0xAA7FD8")]
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
				[Address(RVA = "0xAA83BC", Offset = "0xAA83BC", VA = "0xAA83BC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000668")]
				[Address(RVA = "0xAA81E0", Offset = "0xAA81E0", VA = "0xAA81E0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000669")]
				[Address(RVA = "0xAA8450", Offset = "0xAA8450", VA = "0xAA8450")]
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
			[Address(RVA = "0xAA7FEC", Offset = "0xAA7FEC", VA = "0xAA7FEC", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000664")]
			[Address(RVA = "0xAA8180", Offset = "0xAA8180", VA = "0xAA8180", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000665")]
			[Address(RVA = "0xAA81F4", Offset = "0xAA81F4", VA = "0xAA81F4", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0xAA8434", Offset = "0xAA8434", VA = "0xAA8434")]
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
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x40005DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40005DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x600066F")]
				[Address(RVA = "0xAA8944", Offset = "0xAA8944", VA = "0xAA8944")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000670")]
				[Address(RVA = "0xAA8710", Offset = "0xAA8710", VA = "0xAA8710")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000671")]
				[Address(RVA = "0xAA8A60", Offset = "0xAA8A60", VA = "0xAA8A60")]
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
			[Address(RVA = "0xAA8458", Offset = "0xAA8458", VA = "0xAA8458", Slot = "4")]
			public override void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0xAA85E0", Offset = "0xAA85E0", VA = "0xAA85E0", Slot = "5")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0xAA86B8", Offset = "0xAA86B8", VA = "0xAA86B8", Slot = "6")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0xAA871C", Offset = "0xAA871C", VA = "0xAA871C", Slot = "7")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0xAA8A4C", Offset = "0xAA8A4C", VA = "0xAA8A4C")]
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
		[Address(RVA = "0xAA7AA0", Offset = "0xAA7AA0", VA = "0xAA7AA0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xAA7C38", Offset = "0xAA7C38", VA = "0xAA7C38")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xAA7E6C", Offset = "0xAA7E6C", VA = "0xAA7E6C")]
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
				[Address(RVA = "0xAA9028", Offset = "0xAA9028", VA = "0xAA9028")]
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
			[Address(RVA = "0xAA8B30", Offset = "0xAA8B30", VA = "0xAA8B30")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0xAA8CB0", Offset = "0xAA8CB0", VA = "0xAA8CB0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0xAA900C", Offset = "0xAA900C", VA = "0xAA900C")]
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
		[Address(RVA = "0xAA8AC4", Offset = "0xAA8AC4", VA = "0xAA8AC4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xAA8C0C", Offset = "0xAA8C0C", VA = "0xAA8C0C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xAA8FFC", Offset = "0xAA8FFC", VA = "0xAA8FFC")]
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
		[Header("Target Smoothing")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
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
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
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
			[Address(RVA = "0xAA9098", Offset = "0xAA9098", VA = "0xAA9098")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xAA9030", Offset = "0xAA9030", VA = "0xAA9030")]
		private void Start()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xAA911C", Offset = "0xAA911C", VA = "0xAA911C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xAA9624", Offset = "0xAA9624", VA = "0xAA9624")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xAA97A8", Offset = "0xAA97A8", VA = "0xAA97A8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xAA99F4", Offset = "0xAA99F4", VA = "0xAA99F4")]
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
			[Address(RVA = "0xAA9BFC", Offset = "0xAA9BFC", VA = "0xAA9BFC")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0xAA9E8C", Offset = "0xAA9E8C", VA = "0xAA9E8C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0xAA9EFC", Offset = "0xAA9EFC", VA = "0xAA9EFC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0xAA9F44", Offset = "0xAA9F44", VA = "0xAA9F44")]
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
				[Address(RVA = "0xAAA0C0", Offset = "0xAAA0C0", VA = "0xAAA0C0", Slot = "4")]
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
				[Address(RVA = "0xAAA108", Offset = "0xAAA108", VA = "0xAAA108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0xAA9B00", Offset = "0xAA9B00", VA = "0xAA9B00")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0xAA9F4C", Offset = "0xAA9F4C", VA = "0xAA9F4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0xAA9F50", Offset = "0xAA9F50", VA = "0xAA9F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0xAAA0C8", Offset = "0xAAA0C8", VA = "0xAAA0C8", Slot = "8")]
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
			[Address(RVA = "0xAA53A4", Offset = "0xAA53A4", VA = "0xAA53A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000680")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xAA576C", Offset = "0xAA576C", VA = "0xAA576C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xAA9A8C", Offset = "0xAA9A8C", VA = "0xAA9A8C")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xAA9B28", Offset = "0xAA9B28", VA = "0xAA9B28")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xAA8F54", Offset = "0xAA8F54", VA = "0xAA8F54")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xAA9D60", Offset = "0xAA9D60", VA = "0xAA9D60", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xAA56E4", Offset = "0xAA56E4", VA = "0xAA56E4")]
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
				[Address(RVA = "0xAAA560", Offset = "0xAAA560", VA = "0xAAA560", Slot = "4")]
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
				[Address(RVA = "0xAAA5A8", Offset = "0xAAA5A8", VA = "0xAAA5A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0xAAA1C4", Offset = "0xAAA1C4", VA = "0xAAA1C4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000699")]
			[Address(RVA = "0xAAA3EC", Offset = "0xAAA3EC", VA = "0xAAA3EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0xAAA3F0", Offset = "0xAAA3F0", VA = "0xAAA3F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0xAAA568", Offset = "0xAAA568", VA = "0xAAA568", Slot = "8")]
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
			[Address(RVA = "0xAAA110", Offset = "0xAAA110", VA = "0xAAA110")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000692")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xAAA130", Offset = "0xAAA130", VA = "0xAAA130", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xAAA150", Offset = "0xAAA150", VA = "0xAAA150")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xAAA1EC", Offset = "0xAAA1EC", VA = "0xAAA1EC")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xAAA2C0", Offset = "0xAAA2C0", VA = "0xAAA2C0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xAA7E7C", Offset = "0xAA7E7C", VA = "0xAA7E7C")]
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
			[Address(RVA = "0xAAA5B0", Offset = "0xAAA5B0", VA = "0xAAA5B0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xAAA908", Offset = "0xAAA908", VA = "0xAAA908")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xAA5978", Offset = "0xAA5978", VA = "0xAA5978")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xAAA800", Offset = "0xAAA800", VA = "0xAAA800")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xAAA8A4", Offset = "0xAAA8A4", VA = "0xAAA8A4")]
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
				[Address(RVA = "0xAAAF5C", Offset = "0xAAAF5C", VA = "0xAAAF5C")]
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
			[Address(RVA = "0xAAA980", Offset = "0xAAA980", VA = "0xAAA980")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xAAAB20", Offset = "0xAAAB20", VA = "0xAAAB20")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xAAAC28", Offset = "0xAAAC28", VA = "0xAAAC28")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xAAAF48", Offset = "0xAAAF48", VA = "0xAAAF48")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xAAA910", Offset = "0xAAA910", VA = "0xAAA910", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xAAAB10", Offset = "0xAAAB10", VA = "0xAAAB10")]
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
				[Address(RVA = "0xAAC43C", Offset = "0xAAC43C", VA = "0xAAC43C")]
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
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			[Range(0f, 1f)]
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
			[Address(RVA = "0xAAB100", Offset = "0xAAB100", VA = "0xAAB100")]
			public void Start()
			{
			}

			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xAABCBC", Offset = "0xAABCBC", VA = "0xAABCBC")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xAAC428", Offset = "0xAAC428", VA = "0xAAC428")]
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
			[Address(RVA = "0xAAAF64", Offset = "0xAAAF64", VA = "0xAAAF64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xAABEC0", Offset = "0xAABEC0", VA = "0xAABEC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xAABEFC", Offset = "0xAABEFC", VA = "0xAABEFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		private Transform primaryHand
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xAABE88", Offset = "0xAABE88", VA = "0xAABE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xAABEA4", Offset = "0xAABEA4", VA = "0xAABEA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xAAAF88", Offset = "0xAAAF88", VA = "0xAAAF88")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xAAAFB4", Offset = "0xAAAFB4", VA = "0xAAAFB4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xAAB1D4", Offset = "0xAAB1D4", VA = "0xAAB1D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xAABF38", Offset = "0xAABF38", VA = "0xAABF38")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xAAC0C0", Offset = "0xAAC0C0", VA = "0xAAC0C0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xAAC198", Offset = "0xAAC198", VA = "0xAAC198", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xAAC39C", Offset = "0xAAC39C", VA = "0xAAC39C")]
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
		[Address(RVA = "0xAAC444", Offset = "0xAAC444", VA = "0xAAC444")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xAAC558", Offset = "0xAAC558", VA = "0xAAC558")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xAAC634", Offset = "0xAAC634", VA = "0xAAC634")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xAACA38", Offset = "0xAACA38", VA = "0xAACA38")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xAACA6C", Offset = "0xAACA6C", VA = "0xAACA6C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xAACB98", Offset = "0xAACB98", VA = "0xAACB98")]
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
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
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
			[Address(RVA = "0xAB1908", Offset = "0xAB1908", VA = "0xAB1908")]
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
				[Address(RVA = "0xAB1AA4", Offset = "0xAB1AA4", VA = "0xAB1AA4")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60006D2")]
				[Address(RVA = "0xAB1B58", Offset = "0xAB1B58", VA = "0xAB1B58")]
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
			[Address(RVA = "0xAB1A9C", Offset = "0xAB1A9C", VA = "0xAB1A9C")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xAACBAC", Offset = "0xAACBAC", VA = "0xAACBAC")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xAACBC4", Offset = "0xAACBC4", VA = "0xAACBC4")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xAACCEC", Offset = "0xAACCEC", VA = "0xAACCEC")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xAACC0C", Offset = "0xAACC0C", VA = "0xAACC0C")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xAACD04", Offset = "0xAACD04", VA = "0xAACD04")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xAAE014", Offset = "0xAAE014", VA = "0xAAE014")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xAAE6F4", Offset = "0xAAE6F4", VA = "0xAAE6F4")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xAAF0B4", Offset = "0xAAF0B4", VA = "0xAAF0B4")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xAAF34C", Offset = "0xAAF34C", VA = "0xAAF34C")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xAAF58C", Offset = "0xAAF58C", VA = "0xAAF58C")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xAAFD38", Offset = "0xAAFD38", VA = "0xAAFD38")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xAAFB20", Offset = "0xAAFB20", VA = "0xAAFB20")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xAAFFEC", Offset = "0xAAFFEC", VA = "0xAAFFEC")]
		private static void CalibrateHand(VRIK ik, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xAB04DC", Offset = "0xAB04DC", VA = "0xAB04DC")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xAB05C0", Offset = "0xAB05C0", VA = "0xAB05C0")]
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
		[Address(RVA = "0xAB1BB4", Offset = "0xAB1BB4", VA = "0xAB1BB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xAB1C0C", Offset = "0xAB1C0C", VA = "0xAB1C0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xAB1C34", Offset = "0xAB1C34", VA = "0xAB1C34")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xAB1D54", Offset = "0xAB1D54", VA = "0xAB1D54")]
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
			[Address(RVA = "0xAB1D6C", Offset = "0xAB1D6C", VA = "0xAB1D6C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xAB1D78", Offset = "0xAB1D78", VA = "0xAB1D78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xAB1D84", Offset = "0xAB1D84", VA = "0xAB1D84")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xAB1EA0", Offset = "0xAB1EA0", VA = "0xAB1EA0")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xAB20B4", Offset = "0xAB20B4", VA = "0xAB20B4")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xAB2254", Offset = "0xAB2254", VA = "0xAB2254")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xAB261C", Offset = "0xAB261C", VA = "0xAB261C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xAB2748", Offset = "0xAB2748", VA = "0xAB2748")]
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
			[Address(RVA = "0xAB280C", Offset = "0xAB280C", VA = "0xAB280C")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006E4")]
			[Address(RVA = "0xAB2A88", Offset = "0xAB2A88", VA = "0xAB2A88")]
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
		[Address(RVA = "0xAB2750", Offset = "0xAB2750", VA = "0xAB2750")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xAB27A8", Offset = "0xAB27A8", VA = "0xAB27A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xAB29BC", Offset = "0xAB29BC", VA = "0xAB29BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xAB2A80", Offset = "0xAB2A80", VA = "0xAB2A80")]
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
		[Address(RVA = "0xAB2A90", Offset = "0xAB2A90", VA = "0xAB2A90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xAB2B10", Offset = "0xAB2B10", VA = "0xAB2B10")]
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
		[Address(RVA = "0xAB2B18", Offset = "0xAB2B18", VA = "0xAB2B18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xAB2B84", Offset = "0xAB2B84", VA = "0xAB2B84")]
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
		[Address(RVA = "0xAB2BE4", Offset = "0xAB2BE4", VA = "0xAB2BE4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xAB2C9C", Offset = "0xAB2C9C", VA = "0xAB2C9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xAB2FC8", Offset = "0xAB2FC8", VA = "0xAB2FC8")]
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
		[Address(RVA = "0xAB2FD0", Offset = "0xAB2FD0", VA = "0xAB2FD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xAB3008", Offset = "0xAB3008", VA = "0xAB3008")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xAB30B4", Offset = "0xAB30B4", VA = "0xAB30B4")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xAB321C", Offset = "0xAB321C", VA = "0xAB321C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xAB33D8", Offset = "0xAB33D8", VA = "0xAB33D8")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xAB3468", Offset = "0xAB3468", VA = "0xAB3468")]
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
		[Address(RVA = "0xAB347C", Offset = "0xAB347C", VA = "0xAB347C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xAB35E8", Offset = "0xAB35E8", VA = "0xAB35E8")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xAB37E4", Offset = "0xAB37E4", VA = "0xAB37E4")]
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
		[Address(RVA = "0xAB3814", Offset = "0xAB3814", VA = "0xAB3814")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xAB3C40", Offset = "0xAB3C40", VA = "0xAB3C40")]
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
			[Address(RVA = "0xAB3C60", Offset = "0xAB3C60", VA = "0xAB3C60")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0xAB3C6C", Offset = "0xAB3C6C", VA = "0xAB3C6C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xAB3C78", Offset = "0xAB3C78", VA = "0xAB3C78")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xAB3CA8", Offset = "0xAB3CA8", VA = "0xAB3CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xAB462C", Offset = "0xAB462C", VA = "0xAB462C")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xAB43A8", Offset = "0xAB43A8", VA = "0xAB43A8")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xAB473C", Offset = "0xAB473C", VA = "0xAB473C")]
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
			[Address(RVA = "0xAB4768", Offset = "0xAB4768", VA = "0xAB4768")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xAB47E8", Offset = "0xAB47E8", VA = "0xAB47E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xAB4B2C", Offset = "0xAB4B2C", VA = "0xAB4B2C")]
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
				[Address(RVA = "0xAB5B84", Offset = "0xAB5B84", VA = "0xAB5B84", Slot = "4")]
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
				[Address(RVA = "0xAB5BCC", Offset = "0xAB5BCC", VA = "0xAB5BCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0xAB581C", Offset = "0xAB581C", VA = "0xAB581C")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0xAB58D4", Offset = "0xAB58D4", VA = "0xAB58D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0xAB58D8", Offset = "0xAB58D8", VA = "0xAB58D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0xAB5B8C", Offset = "0xAB5B8C", VA = "0xAB5B8C", Slot = "8")]
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
			[Address(RVA = "0xAB4B40", Offset = "0xAB4B40", VA = "0xAB4B40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public Vector3 position
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xAB470C", Offset = "0xAB470C", VA = "0xAB470C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xAB4B54", Offset = "0xAB4B54", VA = "0xAB4B54")]
			set
			{
			}
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xAB4BA0", Offset = "0xAB4BA0", VA = "0xAB4BA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xAB4E20", Offset = "0xAB4E20", VA = "0xAB4E20")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xAB4FF8", Offset = "0xAB4FF8", VA = "0xAB4FF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xAB521C", Offset = "0xAB521C", VA = "0xAB521C")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xAB547C", Offset = "0xAB547C", VA = "0xAB547C")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xAB55E4", Offset = "0xAB55E4", VA = "0xAB55E4")]
		private void Update()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xAB516C", Offset = "0xAB516C", VA = "0xAB516C")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xAB5844", Offset = "0xAB5844", VA = "0xAB5844")]
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
		[Address(RVA = "0xAB5BD4", Offset = "0xAB5BD4", VA = "0xAB5BD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xAB5CB0", Offset = "0xAB5CB0", VA = "0xAB5CB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xAB5F24", Offset = "0xAB5F24", VA = "0xAB5F24")]
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
		[Address(RVA = "0xAB5F2C", Offset = "0xAB5F2C", VA = "0xAB5F2C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xAB5F4C", Offset = "0xAB5F4C", VA = "0xAB5F4C")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xAB6164", Offset = "0xAB6164", VA = "0xAB6164", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xAB641C", Offset = "0xAB641C", VA = "0xAB641C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xAB64B0", Offset = "0xAB64B0", VA = "0xAB64B0")]
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
		[Address(RVA = "0xAB64B8", Offset = "0xAB64B8", VA = "0xAB64B8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xAB6510", Offset = "0xAB6510", VA = "0xAB6510")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xAB6718", Offset = "0xAB6718", VA = "0xAB6718", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xAB6940", Offset = "0xAB6940", VA = "0xAB6940")]
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
		[Address(RVA = "0xAB6954", Offset = "0xAB6954", VA = "0xAB6954", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xAB6B28", Offset = "0xAB6B28", VA = "0xAB6B28", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xAB6B98", Offset = "0xAB6B98", VA = "0xAB6B98")]
		private void Read()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xAB6CD0", Offset = "0xAB6CD0", VA = "0xAB6CD0")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xAB6D2C", Offset = "0xAB6D2C", VA = "0xAB6D2C")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xAB7374", Offset = "0xAB7374", VA = "0xAB7374")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xAB7188", Offset = "0xAB7188", VA = "0xAB7188")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xAB7618", Offset = "0xAB7618", VA = "0xAB7618")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xAB7744", Offset = "0xAB7744", VA = "0xAB7744")]
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
		[Address(RVA = "0xAB7760", Offset = "0xAB7760", VA = "0xAB7760", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xAB77C4", Offset = "0xAB77C4", VA = "0xAB77C4", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xAB7B00", Offset = "0xAB7B00", VA = "0xAB7B00")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xAB7BF0", Offset = "0xAB7BF0", VA = "0xAB7BF0")]
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
			[Address(RVA = "0xAB7E58", Offset = "0xAB7E58", VA = "0xAB7E58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000C9")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xAB7ED8", Offset = "0xAB7ED8", VA = "0xAB7ED8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xAB7BF8", Offset = "0xAB7BF8", VA = "0xAB7BF8")]
		private void Start()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xAB7C68", Offset = "0xAB7C68", VA = "0xAB7C68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xAB7F58", Offset = "0xAB7F58", VA = "0xAB7F58")]
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
		[Address(RVA = "0xAB7F60", Offset = "0xAB7F60", VA = "0xAB7F60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xAB83BC", Offset = "0xAB83BC", VA = "0xAB83BC")]
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
		[Address(RVA = "0xAB83C4", Offset = "0xAB83C4", VA = "0xAB83C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xAB847C", Offset = "0xAB847C", VA = "0xAB847C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xAB88D8", Offset = "0xAB88D8", VA = "0xAB88D8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xAB8978", Offset = "0xAB8978", VA = "0xAB8978")]
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
			[Address(RVA = "0xAB8B0C", Offset = "0xAB8B0C", VA = "0xAB8B0C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xAB8C30", Offset = "0xAB8C30", VA = "0xAB8C30")]
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
		[Address(RVA = "0xAB89E8", Offset = "0xAB89E8", VA = "0xAB89E8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xAB8B84", Offset = "0xAB8B84", VA = "0xAB8B84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xAB8C1C", Offset = "0xAB8C1C", VA = "0xAB8C1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xAB8C20", Offset = "0xAB8C20", VA = "0xAB8C20")]
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
		[Address(RVA = "0xAB8C40", Offset = "0xAB8C40", VA = "0xAB8C40")]
		private void Start()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xAB8CA8", Offset = "0xAB8CA8", VA = "0xAB8CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xAB8D7C", Offset = "0xAB8D7C", VA = "0xAB8D7C")]
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
		[Address(RVA = "0xAB8D84", Offset = "0xAB8D84", VA = "0xAB8D84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xAB8DDC", Offset = "0xAB8DDC", VA = "0xAB8DDC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xAB8F74", Offset = "0xAB8F74", VA = "0xAB8F74")]
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
		[Address(RVA = "0xAB8F7C", Offset = "0xAB8F7C", VA = "0xAB8F7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xAB905C", Offset = "0xAB905C", VA = "0xAB905C")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xAB90E8", Offset = "0xAB90E8", VA = "0xAB90E8")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xAB95BC", Offset = "0xAB95BC", VA = "0xAB95BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xAB96E8", Offset = "0xAB96E8", VA = "0xAB96E8")]
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
		[Address(RVA = "0xAB96F0", Offset = "0xAB96F0", VA = "0xAB96F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xAB988C", Offset = "0xAB988C", VA = "0xAB988C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xAB9898", Offset = "0xAB9898", VA = "0xAB9898")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xAB9B58", Offset = "0xAB9B58", VA = "0xAB9B58")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xAB9DF4", Offset = "0xAB9DF4", VA = "0xAB9DF4")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xAB995C", Offset = "0xAB995C", VA = "0xAB995C")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xABAAAC", Offset = "0xABAAAC", VA = "0xABAAAC")]
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
		[Address(RVA = "0xABAACC", Offset = "0xABAACC", VA = "0xABAACC")]
		private void Start()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xABAB5C", Offset = "0xABAB5C", VA = "0xABAB5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xABAC58", Offset = "0xABAC58", VA = "0xABAC58")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xABAD04", Offset = "0xABAD04", VA = "0xABAD04")]
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
		[Address(RVA = "0xABAD14", Offset = "0xABAD14", VA = "0xABAD14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xABAE64", Offset = "0xABAE64", VA = "0xABAE64")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xABAFC8", Offset = "0xABAFC8", VA = "0xABAFC8")]
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
		[Address(RVA = "0xABAFD8", Offset = "0xABAFD8", VA = "0xABAFD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xABB1A4", Offset = "0xABB1A4", VA = "0xABB1A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xABB5B4", Offset = "0xABB5B4", VA = "0xABB5B4")]
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
		[Address(RVA = "0xABB5C4", Offset = "0xABB5C4", VA = "0xABB5C4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xABB6AC", Offset = "0xABB6AC", VA = "0xABB6AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xABB798", Offset = "0xABB798", VA = "0xABB798")]
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
		[Address(RVA = "0xABB7A0", Offset = "0xABB7A0", VA = "0xABB7A0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xABBCA0", Offset = "0xABBCA0", VA = "0xABBCA0")]
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
		[Address(RVA = "0xABBCA8", Offset = "0xABBCA8", VA = "0xABBCA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xABBD00", Offset = "0xABBD00", VA = "0xABBD00")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xABBFAC", Offset = "0xABBFAC", VA = "0xABBFAC")]
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
				[Address(RVA = "0xABC7B8", Offset = "0xABC7B8", VA = "0xABC7B8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xABBFDC", Offset = "0xABBFDC", VA = "0xABBFDC")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xABC058", Offset = "0xABC058", VA = "0xABC058")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xABC650", Offset = "0xABC650", VA = "0xABC650")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0xABC804", Offset = "0xABC804", VA = "0xABC804")]
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
		[Address(RVA = "0xABBFB4", Offset = "0xABBFB4", VA = "0xABBFB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xABBFFC", Offset = "0xABBFFC", VA = "0xABBFFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xABC640", Offset = "0xABC640", VA = "0xABC640")]
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
			[Address(RVA = "0xABC990", Offset = "0xABC990", VA = "0xABC990")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0xABCB78", Offset = "0xABCB78", VA = "0xABCB78")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0xABCB9C", Offset = "0xABCB9C", VA = "0xABCB9C")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xABCCAC", Offset = "0xABCCAC", VA = "0xABCCAC")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xABCE64", Offset = "0xABCE64", VA = "0xABCE64")]
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
		[Address(RVA = "0xABC818", Offset = "0xABC818", VA = "0xABC818", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xABC910", Offset = "0xABC910", VA = "0xABC910")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xABCA6C", Offset = "0xABCA6C", VA = "0xABCA6C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xABCC30", Offset = "0xABCC30", VA = "0xABCC30")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xABCD1C", Offset = "0xABCD1C", VA = "0xABCD1C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xABCE54", Offset = "0xABCE54", VA = "0xABCE54")]
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
		[Address(RVA = "0xABCEC4", Offset = "0xABCEC4", VA = "0xABCEC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xABCF3C", Offset = "0xABCF3C", VA = "0xABCF3C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xABD00C", Offset = "0xABD00C", VA = "0xABD00C")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xABD154", Offset = "0xABD154", VA = "0xABD154")]
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
			[Address(RVA = "0xABD6DC", Offset = "0xABD6DC", VA = "0xABD6DC")]
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
		[Address(RVA = "0xABD168", Offset = "0xABD168", VA = "0xABD168", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xABD3B0", Offset = "0xABD3B0", VA = "0xABD3B0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xABD528", Offset = "0xABD528", VA = "0xABD528")]
		public void Anchor()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xABD684", Offset = "0xABD684", VA = "0xABD684")]
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
		[Address(RVA = "0xABD6EC", Offset = "0xABD6EC", VA = "0xABD6EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xABDA00", Offset = "0xABDA00", VA = "0xABDA00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xABE1FC", Offset = "0xABE1FC", VA = "0xABE1FC")]
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
			[Address(RVA = "0xABE5F4", Offset = "0xABE5F4", VA = "0xABE5F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		private bool holdingLeft
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xABE6C4", Offset = "0xABE6C4", VA = "0xABE6C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CD")]
		private bool holdingRight
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xABE61C", Offset = "0xABE61C", VA = "0xABE61C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xABE268", Offset = "0xABE268", VA = "0xABE268")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000780")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xABE76C", Offset = "0xABE76C", VA = "0xABE76C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xABE95C", Offset = "0xABE95C", VA = "0xABE95C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xABEACC", Offset = "0xABEACC", VA = "0xABEACC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0xABEB9C", Offset = "0xABEB9C", VA = "0xABEB9C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0xABECC8", Offset = "0xABECC8", VA = "0xABECC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xABEE48", Offset = "0xABEE48", VA = "0xABEE48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xABF084", Offset = "0xABF084", VA = "0xABF084")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600078B")]
		[Address(RVA = "0xABF098", Offset = "0xABF098", VA = "0xABF098", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xABF278", Offset = "0xABF278", VA = "0xABF278")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600078D")]
		[Address(RVA = "0xABF28C", Offset = "0xABF28C", VA = "0xABF28C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xABF3A0", Offset = "0xABF3A0", VA = "0xABF3A0")]
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
		[Address(RVA = "0xABF3B4", Offset = "0xABF3B4", VA = "0xABF3B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xABF44C", Offset = "0xABF44C", VA = "0xABF44C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xABF564", Offset = "0xABF564", VA = "0xABF564")]
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
		[Address(RVA = "0xABF56C", Offset = "0xABF56C", VA = "0xABF56C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xABF5C4", Offset = "0xABF5C4", VA = "0xABF5C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xABF610", Offset = "0xABF610", VA = "0xABF610")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xABF6A8", Offset = "0xABF6A8", VA = "0xABF6A8")]
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
				[Address(RVA = "0xABFA38", Offset = "0xABFA38", VA = "0xABFA38", Slot = "4")]
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
				[Address(RVA = "0xABFA80", Offset = "0xABFA80", VA = "0xABFA80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0xABF854", Offset = "0xABF854", VA = "0xABF854")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0xABF88C", Offset = "0xABF88C", VA = "0xABF88C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0xABF890", Offset = "0xABF890", VA = "0xABF890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0xABFA40", Offset = "0xABFA40", VA = "0xABFA40", Slot = "8")]
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
		[Address(RVA = "0xABF6B8", Offset = "0xABF6B8", VA = "0xABF6B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xABF77C", Offset = "0xABF77C", VA = "0xABF77C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xABF7D0", Offset = "0xABF7D0", VA = "0xABF7D0")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xABF87C", Offset = "0xABF87C", VA = "0xABF87C")]
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
				[Address(RVA = "0xABFD24", Offset = "0xABFD24", VA = "0xABFD24", Slot = "4")]
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
				[Address(RVA = "0xABFD6C", Offset = "0xABFD6C", VA = "0xABFD6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0xABFBB0", Offset = "0xABFBB0", VA = "0xABFBB0")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xABFBE0", Offset = "0xABFBE0", VA = "0xABFBE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0xABFBE4", Offset = "0xABFBE4", VA = "0xABFBE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0xABFD2C", Offset = "0xABFD2C", VA = "0xABFD2C", Slot = "8")]
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
		[Address(RVA = "0xABFA88", Offset = "0xABFA88", VA = "0xABFA88")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xABFB3C", Offset = "0xABFB3C", VA = "0xABFB3C")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xABFBD8", Offset = "0xABFBD8", VA = "0xABFBD8")]
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
			[Address(RVA = "0xABFDD8", Offset = "0xABFDD8", VA = "0xABFDD8")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0xAC09AC", Offset = "0xAC09AC", VA = "0xAC09AC")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0xAC01E0", Offset = "0xAC01E0", VA = "0xAC01E0")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xAC0A94", Offset = "0xAC0A94", VA = "0xAC0A94")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0xAC0B78", Offset = "0xAC0B78", VA = "0xAC0B78")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xAC0C04", Offset = "0xAC0C04", VA = "0xAC0C04")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xAC0C8C", Offset = "0xAC0C8C", VA = "0xAC0C8C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0xAC0798", Offset = "0xAC0798", VA = "0xAC0798")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0xAC0D14", Offset = "0xAC0D14", VA = "0xAC0D14")]
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
		[Address(RVA = "0xABFD74", Offset = "0xABFD74", VA = "0xABFD74")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xAC0180", Offset = "0xAC0180", VA = "0xAC0180")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xAC06E8", Offset = "0xAC06E8", VA = "0xAC06E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xAC09A4", Offset = "0xAC09A4", VA = "0xAC09A4")]
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
		[Address(RVA = "0xAC0D50", Offset = "0xAC0D50", VA = "0xAC0D50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xAC0D80", Offset = "0xAC0D80", VA = "0xAC0D80")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xAC0E30", Offset = "0xAC0E30", VA = "0xAC0E30")]
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
		[Address(RVA = "0xAC0E44", Offset = "0xAC0E44", VA = "0xAC0E44")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xAC1014", Offset = "0xAC1014", VA = "0xAC1014")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xAC130C", Offset = "0xAC130C", VA = "0xAC130C")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xAC14AC", Offset = "0xAC14AC", VA = "0xAC14AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xAC15D8", Offset = "0xAC15D8", VA = "0xAC15D8")]
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
		[Address(RVA = "0xAC15EC", Offset = "0xAC15EC", VA = "0xAC15EC", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xAC1704", Offset = "0xAC1704", VA = "0xAC1704")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xAC18CC", Offset = "0xAC18CC", VA = "0xAC18CC")]
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
		[Address(RVA = "0xAC18E8", Offset = "0xAC18E8", VA = "0xAC18E8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xAC1AF0", Offset = "0xAC1AF0", VA = "0xAC1AF0")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xAC1B5C", Offset = "0xAC1B5C", VA = "0xAC1B5C")]
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
				[Address(RVA = "0xAC22CC", Offset = "0xAC22CC", VA = "0xAC22CC", Slot = "4")]
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
				[Address(RVA = "0xAC2314", Offset = "0xAC2314", VA = "0xAC2314", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xAC1F54", Offset = "0xAC1F54", VA = "0xAC1F54")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xAC2144", Offset = "0xAC2144", VA = "0xAC2144", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xAC2148", Offset = "0xAC2148", VA = "0xAC2148", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xAC22D4", Offset = "0xAC22D4", VA = "0xAC22D4", Slot = "8")]
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
		[Address(RVA = "0xAC1B64", Offset = "0xAC1B64", VA = "0xAC1B64")]
		private void Start()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xAC1CA0", Offset = "0xAC1CA0", VA = "0xAC1CA0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xAC1C2C", Offset = "0xAC1C2C", VA = "0xAC1C2C")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xAC1F7C", Offset = "0xAC1F7C", VA = "0xAC1F7C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xAC2054", Offset = "0xAC2054", VA = "0xAC2054")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xAC2128", Offset = "0xAC2128", VA = "0xAC2128")]
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
		[Address(RVA = "0xAC231C", Offset = "0xAC231C", VA = "0xAC231C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xAC2384", Offset = "0xAC2384", VA = "0xAC2384")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xAC2430", Offset = "0xAC2430", VA = "0xAC2430")]
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
			[Address(RVA = "0xAC24A4", Offset = "0xAC24A4", VA = "0xAC24A4")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0xAC25E0", Offset = "0xAC25E0", VA = "0xAC25E0")]
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
		[Address(RVA = "0xAC2440", Offset = "0xAC2440", VA = "0xAC2440")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xAC25D8", Offset = "0xAC25D8", VA = "0xAC25D8")]
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
		[Address(RVA = "0xAC25E8", Offset = "0xAC25E8", VA = "0xAC25E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xAC2738", Offset = "0xAC2738", VA = "0xAC2738")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xAC289C", Offset = "0xAC289C", VA = "0xAC289C")]
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
		[Address(RVA = "0xAC28AC", Offset = "0xAC28AC", VA = "0xAC28AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xAC2AA0", Offset = "0xAC2AA0", VA = "0xAC2AA0")]
		private Vector3 GetInput()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xAC2DE8", Offset = "0xAC2DE8", VA = "0xAC2DE8")]
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
		[Tooltip("HMD.")]
		[Header("Head")]
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
		[Tooltip("Multiplies the scale of the root.")]
		[Header("Scale")]
		public float scaleMlp;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xAC2DFC", Offset = "0xAC2DFC", VA = "0xAC2DFC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xAC2F90", Offset = "0xAC2F90", VA = "0xAC2F90")]
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
		[Address(RVA = "0xAC300C", Offset = "0xAC300C", VA = "0xAC300C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xAC3170", Offset = "0xAC3170", VA = "0xAC3170")]
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
		[Address(RVA = "0xAC41E4", Offset = "0xAC41E4", VA = "0xAC41E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xAC4234", Offset = "0xAC4234", VA = "0xAC4234")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xAC440C", Offset = "0xAC440C", VA = "0xAC440C")]
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
		[Address(RVA = "0xAC4464", Offset = "0xAC4464", VA = "0xAC4464")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xAC4994", Offset = "0xAC4994", VA = "0xAC4994")]
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
			[Address(RVA = "0xAC4A10", Offset = "0xAC4A10", VA = "0xAC4A10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xAC49F0", Offset = "0xAC49F0", VA = "0xAC49F0", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xAC4A18", Offset = "0xAC4A18", VA = "0xAC4A18")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xAC4A78", Offset = "0xAC4A78", VA = "0xAC4A78", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xAC4BFC", Offset = "0xAC4BFC", VA = "0xAC4BFC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xAC4E78", Offset = "0xAC4E78", VA = "0xAC4E78", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xAC4C0C", Offset = "0xAC4C0C", VA = "0xAC4C0C")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xAC4E88", Offset = "0xAC4E88", VA = "0xAC4E88")]
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
		[Address(RVA = "0xAC4EA0", Offset = "0xAC4EA0", VA = "0xAC4EA0", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xAC4F00", Offset = "0xAC4F00", VA = "0xAC4F00", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xAC4F90", Offset = "0xAC4F90", VA = "0xAC4F90")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xAC50B4", Offset = "0xAC50B4", VA = "0xAC50B4")]
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
			[Address(RVA = "0xAC5170", Offset = "0xAC5170", VA = "0xAC5170", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0xAC50CC", Offset = "0xAC50CC", VA = "0xAC50CC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xAC5154", Offset = "0xAC5154", VA = "0xAC5154", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xAC5264", Offset = "0xAC5264", VA = "0xAC5264", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xAC5654", Offset = "0xAC5654", VA = "0xAC5654")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xAC5898", Offset = "0xAC5898", VA = "0xAC5898")]
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
		[Address(RVA = "0xAC58BC", Offset = "0xAC58BC", VA = "0xAC58BC")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xAC5AA8", Offset = "0xAC5AA8", VA = "0xAC5AA8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xAC5CD4", Offset = "0xAC5CD4", VA = "0xAC5CD4", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xAC5E74", Offset = "0xAC5E74", VA = "0xAC5E74")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xAC5ED4", Offset = "0xAC5ED4", VA = "0xAC5ED4")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xAC6038", Offset = "0xAC6038", VA = "0xAC6038")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xAC623C", Offset = "0xAC623C", VA = "0xAC623C")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xAC6260", Offset = "0xAC6260", VA = "0xAC6260")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xAC6284", Offset = "0xAC6284", VA = "0xAC6284")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xAC63D0", Offset = "0xAC63D0", VA = "0xAC63D0")]
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
				[Address(RVA = "0xAC8EEC", Offset = "0xAC8EEC", VA = "0xAC8EEC", Slot = "4")]
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
				[Address(RVA = "0xAC8F34", Offset = "0xAC8F34", VA = "0xAC8F34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xAC8CAC", Offset = "0xAC8CAC", VA = "0xAC8CAC")]
			[DebuggerHidden]
			public <JumpSmooth>d__79(int <>1__state)
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xAC8DE8", Offset = "0xAC8DE8", VA = "0xAC8DE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xAC8DEC", Offset = "0xAC8DEC", VA = "0xAC8DEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0xAC8EF4", Offset = "0xAC8EF4", VA = "0xAC8EF4", Slot = "8")]
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
			[Address(RVA = "0xAC63F0", Offset = "0xAC63F0", VA = "0xAC63F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0xAC63F8", Offset = "0xAC63F8", VA = "0xAC63F8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public bool onGround
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xAC6404", Offset = "0xAC6404", VA = "0xAC6404")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000806")]
			[Address(RVA = "0xAC640C", Offset = "0xAC640C", VA = "0xAC640C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xAC6418", Offset = "0xAC6418", VA = "0xAC6418", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xAC6604", Offset = "0xAC6604", VA = "0xAC6604")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xAC6688", Offset = "0xAC6688", VA = "0xAC6688", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xAC679C", Offset = "0xAC679C", VA = "0xAC679C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xAC7830", Offset = "0xAC7830", VA = "0xAC7830", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xAC7CC0", Offset = "0xAC7CC0", VA = "0xAC7CC0", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xAC6E90", Offset = "0xAC6E90", VA = "0xAC6E90")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xAC7D98", Offset = "0xAC7D98", VA = "0xAC7D98")]
		private void WallRun()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xAC8420", Offset = "0xAC8420", VA = "0xAC8420")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0xAC78BC", Offset = "0xAC78BC", VA = "0xAC78BC")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xAC8518", Offset = "0xAC8518", VA = "0xAC8518", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xAC8998", Offset = "0xAC8998", VA = "0xAC8998")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xAC8AC0", Offset = "0xAC8AC0", VA = "0xAC8AC0", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xAC8C14", Offset = "0xAC8C14", VA = "0xAC8C14")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__79))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xAC72C4", Offset = "0xAC72C4", VA = "0xAC72C4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xAC8CD4", Offset = "0xAC8CD4", VA = "0xAC8CD4")]
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
			[Address(RVA = "0xAC8F3C", Offset = "0xAC8F3C", VA = "0xAC8F3C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0xAC8F44", Offset = "0xAC8F44", VA = "0xAC8F44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xAC8F50", Offset = "0xAC8F50", VA = "0xAC8F50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xAC8FF8", Offset = "0xAC8FF8", VA = "0xAC8FF8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xAC9610", Offset = "0xAC9610", VA = "0xAC9610")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xAC9040", Offset = "0xAC9040", VA = "0xAC9040")]
		private void Rotate()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xAC93A8", Offset = "0xAC93A8", VA = "0xAC93A8")]
		private void Move()
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xAC9640", Offset = "0xAC9640", VA = "0xAC9640")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xAC96D8", Offset = "0xAC96D8", VA = "0xAC96D8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xAC9758", Offset = "0xAC9758", VA = "0xAC9758")]
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
		[Address(RVA = "0xAC9780", Offset = "0xAC9780", VA = "0xAC9780", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xAC98C8", Offset = "0xAC98C8", VA = "0xAC98C8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xAC9F40", Offset = "0xAC9F40", VA = "0xAC9F40")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xACA12C", Offset = "0xACA12C", VA = "0xACA12C")]
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
		[Address(RVA = "0xAC97BC", Offset = "0xAC97BC", VA = "0xAC97BC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xACA158", Offset = "0xACA158", VA = "0xACA158", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xACA148", Offset = "0xACA148", VA = "0xACA148")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0xACA49C", Offset = "0xACA49C", VA = "0xACA49C")]
		private void Update()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xACA4D4", Offset = "0xACA4D4", VA = "0xACA4D4")]
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
		[Address(RVA = "0xACA4DC", Offset = "0xACA4DC", VA = "0xACA4DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xACA504", Offset = "0xACA504", VA = "0xACA504")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xACA5A8", Offset = "0xACA5A8", VA = "0xACA5A8")]
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
			[Address(RVA = "0xACA5BC", Offset = "0xACA5BC", VA = "0xACA5BC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000834")]
			[Address(RVA = "0xACA5C8", Offset = "0xACA5C8", VA = "0xACA5C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public State state
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0xACA5D4", Offset = "0xACA5D4", VA = "0xACA5D4")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000836")]
			[Address(RVA = "0xACA5DC", Offset = "0xACA5DC", VA = "0xACA5DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xAC97F0", Offset = "0xAC97F0", VA = "0xAC97F0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xAC9AE8", Offset = "0xAC9AE8", VA = "0xAC9AE8")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xACA6BC", Offset = "0xACA6BC", VA = "0xACA6BC")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xACA720", Offset = "0xACA720", VA = "0xACA720")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xACA5E4", Offset = "0xACA5E4", VA = "0xACA5E4")]
		private void Stop()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xACA640", Offset = "0xACA640", VA = "0xACA640")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xAC9F68", Offset = "0xAC9F68", VA = "0xAC9F68")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xACA854", Offset = "0xACA854", VA = "0xACA854")]
		public Navigator()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x2000139")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x200013A")]
		public class Node
		{
			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x170000DD")]
			public TValue Key
			{
				[Token(Token = "0x6000845")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			public Node Prev
			{
				[Token(Token = "0x6000846")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			public Node Next
			{
				[Token(Token = "0x6000847")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000848")]
			public Node()
			{
			}
		}

		[Token(Token = "0x200013B")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x600083F")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000840")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000843")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x200013C")]
	internal static class Geom
	{
		[Token(Token = "0x600084D")]
		[Address(RVA = "0xACA8C4", Offset = "0xACA8C4", VA = "0xACA8C4")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xACA970", Offset = "0xACA970", VA = "0xACA970")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xACA9C0", Offset = "0xACA9C0", VA = "0xACA9C0")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xACAA00", Offset = "0xACAA00", VA = "0xACAA00")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xACAA4C", Offset = "0xACAA4C", VA = "0xACAA4C")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xACAABC", Offset = "0xACAABC", VA = "0xACAABC")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xACAB1C", Offset = "0xACAB1C", VA = "0xACAB1C")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xACAB68", Offset = "0xACAB68", VA = "0xACAB68")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xACABD8", Offset = "0xACABD8", VA = "0xACABD8")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xACAC38", Offset = "0xACAC38", VA = "0xACAC38")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xACAC7C", Offset = "0xACAC7C", VA = "0xACAC7C")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xACACA0", Offset = "0xACACA0", VA = "0xACACA0")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0xACAD24", Offset = "0xACAD24", VA = "0xACAD24")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xACAD6C", Offset = "0xACAD6C", VA = "0xACAD6C")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xACADC8", Offset = "0xACADC8", VA = "0xACADC8")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xACADFC", Offset = "0xACADFC", VA = "0xACADFC")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x200013D")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xACB274", Offset = "0xACB274", VA = "0xACB274")]
		public LTMesh()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xACB590", Offset = "0xACB590", VA = "0xACB590", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xACB5D8", Offset = "0xACB5D8", VA = "0xACB5D8", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xACB6E0", Offset = "0xACB6E0", VA = "0xACB6E0")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xACBA8C", Offset = "0xACBA8C", VA = "0xACBA8C")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0xACBD50", Offset = "0xACBD50", VA = "0xACBD50")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xACBF54", Offset = "0xACBF54", VA = "0xACBF54")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xACBFEC", Offset = "0xACBFEC", VA = "0xACBFEC")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xACC0E8", Offset = "0xACC0E8", VA = "0xACC0E8")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xACC1DC", Offset = "0xACC1DC", VA = "0xACC1DC")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xACC338", Offset = "0xACC338", VA = "0xACC338")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0xACC4FC", Offset = "0xACC4FC", VA = "0xACC4FC")]
		[Conditional("DEBUG")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public struct Vec3
	{
		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x170000E0")]
		public float this[int index]
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xACC594", Offset = "0xACC594", VA = "0xACC594")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xACC600", Offset = "0xACC600", VA = "0xACC600")]
			set
			{
			}
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xACC66C", Offset = "0xACC66C", VA = "0xACC66C")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xACC690", Offset = "0xACC690", VA = "0xACC690")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xACC6AC", Offset = "0xACC6AC", VA = "0xACC6AC")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xACC6D8", Offset = "0xACC6D8", VA = "0xACC6D8")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xACC774", Offset = "0xACC774", VA = "0xACC774")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xACC834", Offset = "0xACC834", VA = "0xACC834", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200013F")]
	internal static class MeshUtils
	{
		[Token(Token = "0x2000140")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x600087A")]
			public abstract void Reset();

			[Token(Token = "0x600087B")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x600087C")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x600087D")]
			public void Free()
			{
			}

			[Token(Token = "0x600087E")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x2000141")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x600087F")]
			[Address(RVA = "0xACC990", Offset = "0xACC990", VA = "0xACC990", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xACCA3C", Offset = "0xACCA3C", VA = "0xACCA3C")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x2000142")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x170000E1")]
			internal int VertsCount
			{
				[Token(Token = "0x6000881")]
				[Address(RVA = "0xACC4AC", Offset = "0xACC4AC", VA = "0xACC4AC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xACCA84", Offset = "0xACCA84", VA = "0xACCA84", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0xACCAD8", Offset = "0xACCAD8", VA = "0xACCAD8")]
			public Face()
			{
			}
		}

		[Token(Token = "0x2000143")]
		public struct EdgePair
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xACB4C0", Offset = "0xACB4C0", VA = "0xACB4C0")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0xACCB20", Offset = "0xACCB20", VA = "0xACCB20")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000144")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x170000E2")]
			internal Face _Rface
			{
				[Token(Token = "0x6000886")]
				[Address(RVA = "0xACBE78", Offset = "0xACBE78", VA = "0xACBE78")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000887")]
				[Address(RVA = "0xACC0CC", Offset = "0xACC0CC", VA = "0xACC0CC")]
				set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			internal Vertex _Dst
			{
				[Token(Token = "0x6000888")]
				[Address(RVA = "0xACAC60", Offset = "0xACAC60", VA = "0xACAC60")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000889")]
				[Address(RVA = "0xACC0B0", Offset = "0xACC0B0", VA = "0xACC0B0")]
				set
				{
				}
			}

			[Token(Token = "0x170000E4")]
			internal Edge _Oprev
			{
				[Token(Token = "0x600088A")]
				[Address(RVA = "0xACBE94", Offset = "0xACBE94", VA = "0xACBE94")]
				get
				{
					return null;
				}
				[Token(Token = "0x600088B")]
				[Address(RVA = "0xACCB48", Offset = "0xACCB48", VA = "0xACCB48")]
				set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			internal Edge _Lprev
			{
				[Token(Token = "0x600088C")]
				[Address(RVA = "0xACC4E0", Offset = "0xACC4E0", VA = "0xACC4E0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600088D")]
				[Address(RVA = "0xACCB64", Offset = "0xACCB64", VA = "0xACCB64")]
				set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			internal Edge _Dprev
			{
				[Token(Token = "0x600088E")]
				[Address(RVA = "0xACCB80", Offset = "0xACCB80", VA = "0xACCB80")]
				get
				{
					return null;
				}
				[Token(Token = "0x600088F")]
				[Address(RVA = "0xACCB9C", Offset = "0xACCB9C", VA = "0xACCB9C")]
				set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			internal Edge _Rprev
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0xACCBB8", Offset = "0xACCBB8", VA = "0xACCBB8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000891")]
				[Address(RVA = "0xACCBD4", Offset = "0xACCBD4", VA = "0xACCBD4")]
				set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			internal Edge _Dnext
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0xACCBF0", Offset = "0xACCBF0", VA = "0xACCBF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000893")]
				[Address(RVA = "0xACCC14", Offset = "0xACCC14", VA = "0xACCC14")]
				set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			internal Edge _Rnext
			{
				[Token(Token = "0x6000894")]
				[Address(RVA = "0xACCC38", Offset = "0xACCC38", VA = "0xACCC38")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000895")]
				[Address(RVA = "0xACCC5C", Offset = "0xACCC5C", VA = "0xACCC5C")]
				set
				{
				}
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0xACC8FC", Offset = "0xACC8FC", VA = "0xACC8FC")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0xACCC80", Offset = "0xACCC80", VA = "0xACCC80", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0xACCD20", Offset = "0xACCD20", VA = "0xACCD20")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x40008D3")]
		public const int Undef = -1;

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xACB730", Offset = "0xACB730", VA = "0xACB730")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xACBCCC", Offset = "0xACBCCC", VA = "0xACBCCC")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0xACB8A4", Offset = "0xACB8A4", VA = "0xACB8A4")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xACB988", Offset = "0xACB988", VA = "0xACB988")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xACBEB0", Offset = "0xACBEB0", VA = "0xACBEB0")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xACBB64", Offset = "0xACBB64", VA = "0xACBB64")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0xACBC18", Offset = "0xACBC18", VA = "0xACBC18")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xACC930", Offset = "0xACC930", VA = "0xACC930")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000145")]
	internal struct PQHandle
	{
		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x2000146")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x2000147")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x2000148")]
		protected class HandleElem
		{
			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x60008A7")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000EA")]
		public bool Empty
		{
			[Token(Token = "0x600089A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600089B")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x600089C")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x600089D")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x600089E")]
		public void Init()
		{
		}

		[Token(Token = "0x600089F")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x60008A0")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x60008A1")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x60008A2")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x2000149")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x200014A")]
		private class StackItem
		{
			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x60008B0")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170000EB")]
		public bool Empty
		{
			[Token(Token = "0x60008A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008A9")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x60008AA")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x60008AB")]
		public void Init()
		{
		}

		[Token(Token = "0x60008AC")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x60008AD")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x60008AE")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x60008AF")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x200014B")]
	public class Tess
	{
		[Token(Token = "0x200014C")]
		internal class ActiveRegion
		{
			[Token(Token = "0x400091A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x400091B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x400091C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xACD1B0", Offset = "0xACD1B0", VA = "0xACD1B0")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x170000EC")]
		public Vec3 Normal
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xACF138", Offset = "0xACF138", VA = "0xACF138")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xACF144", Offset = "0xACF144", VA = "0xACF144")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xACF150", Offset = "0xACF150", VA = "0xACF150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public int VertexCount
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xACF158", Offset = "0xACF158", VA = "0xACF158")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EF")]
		public int[] Elements
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xACF160", Offset = "0xACF160", VA = "0xACF160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		public int ElementCount
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xACF168", Offset = "0xACF168", VA = "0xACF168")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0xACCDB4", Offset = "0xACCDB4", VA = "0xACCDB4")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xACCDDC", Offset = "0xACCDDC", VA = "0xACCDDC")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xACCE04", Offset = "0xACCE04", VA = "0xACCE04")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xACCF00", Offset = "0xACCF00", VA = "0xACCF00")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xACCF70", Offset = "0xACCF70", VA = "0xACCF70")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xACCFCC", Offset = "0xACCFCC", VA = "0xACCFCC")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xACD07C", Offset = "0xACD07C", VA = "0xACD07C")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xACD0D0", Offset = "0xACD0D0", VA = "0xACD0D0")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xACD1B8", Offset = "0xACD1B8", VA = "0xACD1B8")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xACD20C", Offset = "0xACD20C", VA = "0xACD20C")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xACD258", Offset = "0xACD258", VA = "0xACD258")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xACD374", Offset = "0xACD374", VA = "0xACD374")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xACD8EC", Offset = "0xACD8EC", VA = "0xACD8EC")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xACD904", Offset = "0xACD904", VA = "0xACD904")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xACD9F4", Offset = "0xACD9F4", VA = "0xACD9F4")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xACD530", Offset = "0xACD530", VA = "0xACD530")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xACDCBC", Offset = "0xACDCBC", VA = "0xACDCBC")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xACDE20", Offset = "0xACDE20", VA = "0xACDE20")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xACD6BC", Offset = "0xACD6BC", VA = "0xACD6BC")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xACE3D8", Offset = "0xACE3D8", VA = "0xACE3D8")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xACE5D4", Offset = "0xACE5D4", VA = "0xACE5D4")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xACE798", Offset = "0xACE798", VA = "0xACE798")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xACE6CC", Offset = "0xACE6CC", VA = "0xACE6CC")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xACE9BC", Offset = "0xACE9BC", VA = "0xACE9BC")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xACEAD8", Offset = "0xACEAD8", VA = "0xACEAD8")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xACEBC8", Offset = "0xACEBC8", VA = "0xACEBC8")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xACEC50", Offset = "0xACEC50", VA = "0xACEC50")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xACED88", Offset = "0xACED88", VA = "0xACED88")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xACEF88", Offset = "0xACEF88", VA = "0xACEF88")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xACEF94", Offset = "0xACEF94", VA = "0xACEF94")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xACF020", Offset = "0xACF020", VA = "0xACF020")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xACF170", Offset = "0xACF170", VA = "0xACF170")]
		public Tess()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xACF23C", Offset = "0xACF23C", VA = "0xACF23C")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xACF924", Offset = "0xACF924", VA = "0xACF924")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xACFA20", Offset = "0xACFA20", VA = "0xACFA20")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xACFCF8", Offset = "0xACFCF8", VA = "0xACFCF8")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xACFED8", Offset = "0xACFED8", VA = "0xACFED8")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xACFF38", Offset = "0xACFF38", VA = "0xACFF38")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xACFF94", Offset = "0xACFF94", VA = "0xACFF94")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xAD0040", Offset = "0xAD0040", VA = "0xAD0040")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xAD0078", Offset = "0xAD0078", VA = "0xAD0078")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xAD04C0", Offset = "0xAD04C0", VA = "0xAD04C0")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xAD0718", Offset = "0xAD0718", VA = "0xAD0718")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xAD07AC", Offset = "0xAD07AC", VA = "0xAD07AC")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xAD07B4", Offset = "0xAD07B4", VA = "0xAD07B4")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xAD09A0", Offset = "0xAD09A0", VA = "0xAD09A0")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xAD09A8", Offset = "0xAD09A8", VA = "0xAD09A8")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x200014D")]
	public enum WindingRule
	{
		[Token(Token = "0x4000922")]
		EvenOdd,
		[Token(Token = "0x4000923")]
		NonZero,
		[Token(Token = "0x4000924")]
		Positive,
		[Token(Token = "0x4000925")]
		Negative,
		[Token(Token = "0x4000926")]
		AbsGeqTwo
	}
	[Token(Token = "0x200014E")]
	public enum ElementType
	{
		[Token(Token = "0x4000928")]
		Polygons,
		[Token(Token = "0x4000929")]
		ConnectedPolygons,
		[Token(Token = "0x400092A")]
		BoundaryContours
	}
	[Token(Token = "0x200014F")]
	public enum ContourOrientation
	{
		[Token(Token = "0x400092C")]
		Original,
		[Token(Token = "0x400092D")]
		Clockwise,
		[Token(Token = "0x400092E")]
		CounterClockwise
	}
	[Token(Token = "0x2000150")]
	public struct ContourVertex
	{
		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xAD0B0C", Offset = "0xAD0B0C", VA = "0xAD0B0C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000151")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x2000152")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xAD0D34", Offset = "0xAD0D34", VA = "0xAD0D34")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xAD0D38", Offset = "0xAD0D38", VA = "0xAD0D38")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x2000153")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xAD0D4C", Offset = "0xAD0D4C", VA = "0xAD0D4C")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000154")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xAD0D50", Offset = "0xAD0D50", VA = "0xAD0D50")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xAD0E0C", Offset = "0xAD0E0C", VA = "0xAD0E0C")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xAD0E7C", Offset = "0xAD0E7C", VA = "0xAD0E7C")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xAD0F40", Offset = "0xAD0F40", VA = "0xAD0F40")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x2000155")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x170000F1")]
		string Path
		{
			[Token(Token = "0x60008F3")]
			get;
		}
	}
	[Token(Token = "0x2000156")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x2000157")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x2000158")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x2000159")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xAD100C", Offset = "0xAD100C", VA = "0xAD100C")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x170000F2")]
		public int TypeSort
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xAD103C", Offset = "0xAD103C", VA = "0xAD103C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xAD1044", Offset = "0xAD1044", VA = "0xAD1044")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xAD104C", Offset = "0xAD104C", VA = "0xAD104C", Slot = "5")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xAD1118", Offset = "0xAD1118", VA = "0xAD1118")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x170000F3")]
		public string Path
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xAD1150", Offset = "0xAD1150", VA = "0xAD1150", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xAD1158", Offset = "0xAD1158", VA = "0xAD1158")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xAD123C", Offset = "0xAD123C", VA = "0xAD123C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xAD1244", Offset = "0xAD1244", VA = "0xAD1244")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xAD1250", Offset = "0xAD1250", VA = "0xAD1250")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x200015C")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x200015D")]
		public enum ActionEnum
		{
			[Token(Token = "0x4000942")]
			Show,
			[Token(Token = "0x4000943")]
			Hide,
			[Token(Token = "0x4000944")]
			Enable,
			[Token(Token = "0x4000945")]
			Disable,
			[Token(Token = "0x4000946")]
			ShowInfo,
			[Token(Token = "0x4000947")]
			ShowWarning,
			[Token(Token = "0x4000948")]
			ShowError,
			[Token(Token = "0x4000949")]
			Callback
		}

		[Token(Token = "0x200015E")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x400094B")]
			Above,
			[Token(Token = "0x400094C")]
			Below
		}

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xAD1298", Offset = "0xAD1298", VA = "0xAD1298")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xAD12F4", Offset = "0xAD12F4", VA = "0xAD12F4")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x200015F")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x2000160")]
		public enum OperatorEnum
		{
			[Token(Token = "0x400094F")]
			AND,
			[Token(Token = "0x4000950")]
			OR
		}

		[Token(Token = "0x2000161")]
		public class Condition
		{
			[Token(Token = "0x4000951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x4000952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x4000953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x4000954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x6000906")]
			[Address(RVA = "0xAD166C", Offset = "0xAD166C", VA = "0xAD166C")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xAD1508", Offset = "0xAD1508", VA = "0xAD1508")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xAD1674", Offset = "0xAD1674", VA = "0xAD1674")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xAD186C", Offset = "0xAD186C", VA = "0xAD186C")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xAD1B00", Offset = "0xAD1B00", VA = "0xAD1B00")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xAD1C48", Offset = "0xAD1C48", VA = "0xAD1C48", Slot = "6")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xAD1D00", Offset = "0xAD1D00", VA = "0xAD1D00")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000162")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000907")]
		[Address(RVA = "0xAD2064", Offset = "0xAD2064", VA = "0xAD2064")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000163")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000908")]
		[Address(RVA = "0xAD2098", Offset = "0xAD2098", VA = "0xAD2098")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x2000164")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xAD20EC", Offset = "0xAD20EC", VA = "0xAD20EC")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xAD219C", Offset = "0xAD219C", VA = "0xAD219C")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000165")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xAD233C", Offset = "0xAD233C", VA = "0xAD233C")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x2000166")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x600090C")]
		[Address(RVA = "0xAD23AC", Offset = "0xAD23AC", VA = "0xAD23AC")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x2000167")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600090D")]
		[Address(RVA = "0xAD2438", Offset = "0xAD2438", VA = "0xAD2438")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600090E")]
		[Address(RVA = "0xAD2464", Offset = "0xAD2464", VA = "0xAD2464")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x2000169")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xAD2490", Offset = "0xAD2490", VA = "0xAD2490")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000910")]
		[Address(RVA = "0xAD24C8", Offset = "0xAD24C8", VA = "0xAD24C8")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000911")]
		[Address(RVA = "0xAD2524", Offset = "0xAD2524", VA = "0xAD2524")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x200016C")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000912")]
		[Address(RVA = "0xAD2580", Offset = "0xAD2580", VA = "0xAD2580")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xAD25CC", Offset = "0xAD25CC", VA = "0xAD25CC")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xAD25D8", Offset = "0xAD25D8", VA = "0xAD25D8")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xAD25F8", Offset = "0xAD25F8", VA = "0xAD25F8")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x6000916")]
		[Address(RVA = "0xAD25FC", Offset = "0xAD25FC", VA = "0xAD25FC")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xAD2604", Offset = "0xAD2604", VA = "0xAD2604")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xAD2610", Offset = "0xAD2610", VA = "0xAD2610")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xAD2630", Offset = "0xAD2630", VA = "0xAD2630")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x170000F5")]
		public T1 First
		{
			[Token(Token = "0x600091A")]
			[CompilerGenerated]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x600091B")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public T2 Second
		{
			[Token(Token = "0x600091C")]
			[CompilerGenerated]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x600091D")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600091E")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016F")]
	public struct FloatRegion : IEquatable<FloatRegion>
	{
		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x170000F7")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0xAD2650", Offset = "0xAD2650", VA = "0xAD2650")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x170000F8")]
		public bool Positive
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0xAD270C", Offset = "0xAD270C", VA = "0xAD270C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F9")]
		public float Low
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0xAD26C4", Offset = "0xAD26C4", VA = "0xAD26C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0xAD26D4", Offset = "0xAD26D4", VA = "0xAD26D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public float High
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0xAD26E8", Offset = "0xAD26E8", VA = "0xAD26E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000928")]
			[Address(RVA = "0xAD26F8", Offset = "0xAD26F8", VA = "0xAD26F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public float Random
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0xAD271C", Offset = "0xAD271C", VA = "0xAD271C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FC")]
		public float Next
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0xAD2728", Offset = "0xAD2728", VA = "0xAD2728")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FD")]
		public float Length
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0xAD2744", Offset = "0xAD2744", VA = "0xAD2744")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FE")]
		public float LengthPositive
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0xAD2750", Offset = "0xAD2750", VA = "0xAD2750")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0xAD2634", Offset = "0xAD2634", VA = "0xAD2634")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xAD2644", Offset = "0xAD2644", VA = "0xAD2644")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xAD265C", Offset = "0xAD265C", VA = "0xAD265C")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xAD2670", Offset = "0xAD2670", VA = "0xAD2670")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xAD2768", Offset = "0xAD2768", VA = "0xAD2768", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xAD2808", Offset = "0xAD2808", VA = "0xAD2808", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xAD283C", Offset = "0xAD283C", VA = "0xAD283C", Slot = "4")]
		public bool Equals(FloatRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xAD2888", Offset = "0xAD2888", VA = "0xAD2888", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xAD2924", Offset = "0xAD2924", VA = "0xAD2924")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xAD2958", Offset = "0xAD2958", VA = "0xAD2958")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xAD298C", Offset = "0xAD298C", VA = "0xAD298C")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xAD29A4", Offset = "0xAD29A4", VA = "0xAD29A4")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xAD29CC", Offset = "0xAD29CC", VA = "0xAD29CC")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xAD29F4", Offset = "0xAD29F4", VA = "0xAD29F4")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xAD2A1C", Offset = "0xAD2A1C", VA = "0xAD2A1C")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xAD2AFC", Offset = "0xAD2AFC", VA = "0xAD2AFC")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000170")]
	public struct IntRegion : IEquatable<IntRegion>
	{
		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x170000FF")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0xAD2BF8", Offset = "0xAD2BF8", VA = "0xAD2BF8")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x17000100")]
		public bool Positive
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0xAD2CB4", Offset = "0xAD2CB4", VA = "0xAD2CB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000101")]
		public int Low
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0xAD2C6C", Offset = "0xAD2C6C", VA = "0xAD2C6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000940")]
			[Address(RVA = "0xAD2C7C", Offset = "0xAD2C7C", VA = "0xAD2C7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public int High
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0xAD2C90", Offset = "0xAD2C90", VA = "0xAD2C90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0xAD2CA0", Offset = "0xAD2CA0", VA = "0xAD2CA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public int Random
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0xAD2CC4", Offset = "0xAD2CC4", VA = "0xAD2CC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000104")]
		public int Length
		{
			[Token(Token = "0x6000944")]
			[Address(RVA = "0xAD2CD4", Offset = "0xAD2CD4", VA = "0xAD2CD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000105")]
		public int LengthPositive
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0xAD2CE0", Offset = "0xAD2CE0", VA = "0xAD2CE0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xAD2BDC", Offset = "0xAD2BDC", VA = "0xAD2BDC")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xAD2BEC", Offset = "0xAD2BEC", VA = "0xAD2BEC")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0xAD2C04", Offset = "0xAD2C04", VA = "0xAD2C04")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0xAD2C18", Offset = "0xAD2C18", VA = "0xAD2C18")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xAD2CF4", Offset = "0xAD2CF4", VA = "0xAD2CF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xAD2D94", Offset = "0xAD2D94", VA = "0xAD2D94", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xAD2DC8", Offset = "0xAD2DC8", VA = "0xAD2DC8", Slot = "4")]
		public bool Equals(IntRegion other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xAD2E0C", Offset = "0xAD2E0C", VA = "0xAD2E0C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xAD2E9C", Offset = "0xAD2E9C", VA = "0xAD2E9C")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xAD2EB8", Offset = "0xAD2EB8", VA = "0xAD2EB8")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xAD2ED4", Offset = "0xAD2ED4", VA = "0xAD2ED4")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xAD2EE8", Offset = "0xAD2EE8", VA = "0xAD2EE8")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xAD2F00", Offset = "0xAD2F00", VA = "0xAD2F00")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xAD2F1C", Offset = "0xAD2F1C", VA = "0xAD2F1C")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xAD2F34", Offset = "0xAD2F34", VA = "0xAD2F34")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xAD2F60", Offset = "0xAD2F60", VA = "0xAD2F60")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000171")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x17000106")]
		public int Seed
		{
			[Token(Token = "0x6000952")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000953")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x6000954")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000955")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		private int Capacity
		{
			[Token(Token = "0x6000956")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000109")]
		public int Size
		{
			[Token(Token = "0x6000957")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000958")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x6000959")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x600095A")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x600095B")]
		public void Reset()
		{
		}

		[Token(Token = "0x600095C")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x1700010A")]
		public int Size
		{
			[Token(Token = "0x600095D")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600095E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public T this[int index]
		{
			[Token(Token = "0x6000965")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000966")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public int Count
		{
			[Token(Token = "0x600096A")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700010D")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600096B")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600095F")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x6000960")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000961")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000962")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000963")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000964")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000967")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000969")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600096C")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600096D")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000173")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x1700010E")]
		public string Identifier
		{
			[Token(Token = "0x600096E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600096F")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000971")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public Type Type
		{
			[Token(Token = "0x6000972")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000111")]
		public int Count
		{
			[Token(Token = "0x6000977")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000973")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x6000974")]
		public void Update()
		{
		}

		[Token(Token = "0x6000975")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000976")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000978")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x6000979")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x600097A")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x600097B")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x600097C")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x600097D")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x600097E")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x600097F")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000174")]
	public class PoolSettings
	{
		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Positive]
		[SerializeField]
		private int m_MinItems;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Positive]
		[SerializeField]
		private int m_Threshold;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000112")]
		public bool Prewarm
		{
			[Token(Token = "0x6000982")]
			[Address(RVA = "0xAD30E0", Offset = "0xAD30E0", VA = "0xAD30E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000983")]
			[Address(RVA = "0xAD3060", Offset = "0xAD3060", VA = "0xAD3060")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public bool AutoCreate
		{
			[Token(Token = "0x6000984")]
			[Address(RVA = "0xAD30E8", Offset = "0xAD30E8", VA = "0xAD30E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000985")]
			[Address(RVA = "0xAD3078", Offset = "0xAD3078", VA = "0xAD3078")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x6000986")]
			[Address(RVA = "0xAD30F0", Offset = "0xAD30F0", VA = "0xAD30F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000987")]
			[Address(RVA = "0xAD30F8", Offset = "0xAD30F8", VA = "0xAD30F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public int MinItems
		{
			[Token(Token = "0x6000988")]
			[Address(RVA = "0xAD3110", Offset = "0xAD3110", VA = "0xAD3110")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000989")]
			[Address(RVA = "0xAD3090", Offset = "0xAD3090", VA = "0xAD3090")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public int Threshold
		{
			[Token(Token = "0x600098A")]
			[Address(RVA = "0xAD3118", Offset = "0xAD3118", VA = "0xAD3118")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600098B")]
			[Address(RVA = "0xAD30A8", Offset = "0xAD30A8", VA = "0xAD30A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public float Speed
		{
			[Token(Token = "0x600098C")]
			[Address(RVA = "0xAD3120", Offset = "0xAD3120", VA = "0xAD3120")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600098D")]
			[Address(RVA = "0xAD30C4", Offset = "0xAD30C4", VA = "0xAD30C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0xAD2F8C", Offset = "0xAD2F8C", VA = "0xAD2F8C")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0xAD2FA4", Offset = "0xAD2FA4", VA = "0xAD2FA4")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0xAD3128", Offset = "0xAD3128", VA = "0xAD3128")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public interface IPool
	{
		[Token(Token = "0x17000118")]
		string Identifier
		{
			[Token(Token = "0x600098F")]
			get;
			[Token(Token = "0x6000990")]
			set;
		}

		[Token(Token = "0x17000119")]
		PoolSettings Settings
		{
			[Token(Token = "0x6000991")]
			get;
		}

		[Token(Token = "0x1700011A")]
		int Count
		{
			[Token(Token = "0x6000995")]
			get;
		}

		[Token(Token = "0x6000992")]
		void Clear();

		[Token(Token = "0x6000993")]
		void Reset();

		[Token(Token = "0x6000994")]
		void Update();
	}
	[Token(Token = "0x2000176")]
	public interface IPoolable
	{
		[Token(Token = "0x6000996")]
		void OnBeforePush();

		[Token(Token = "0x6000997")]
		void OnAfterPop();
	}
	[Token(Token = "0x2000177")]
	public static class DTTween
	{
		[Token(Token = "0x2000178")]
		public enum EasingMethod
		{
			[Token(Token = "0x400097E")]
			Linear,
			[Token(Token = "0x400097F")]
			ExponentialIn,
			[Token(Token = "0x4000980")]
			ExponentialOut,
			[Token(Token = "0x4000981")]
			ExponentialInOut,
			[Token(Token = "0x4000982")]
			ExponentialOutIn,
			[Token(Token = "0x4000983")]
			CircularIn,
			[Token(Token = "0x4000984")]
			CircularOut,
			[Token(Token = "0x4000985")]
			CircularInOut,
			[Token(Token = "0x4000986")]
			CircularOutIn,
			[Token(Token = "0x4000987")]
			QuadraticIn,
			[Token(Token = "0x4000988")]
			QuadraticOut,
			[Token(Token = "0x4000989")]
			QuadraticInOut,
			[Token(Token = "0x400098A")]
			QuadraticOutIn,
			[Token(Token = "0x400098B")]
			SinusIn,
			[Token(Token = "0x400098C")]
			SinusOut,
			[Token(Token = "0x400098D")]
			SinusInOut,
			[Token(Token = "0x400098E")]
			SinusOutIn,
			[Token(Token = "0x400098F")]
			CubicIn,
			[Token(Token = "0x4000990")]
			CubicOut,
			[Token(Token = "0x4000991")]
			CubicInOut,
			[Token(Token = "0x4000992")]
			CubicOutIn,
			[Token(Token = "0x4000993")]
			QuarticIn,
			[Token(Token = "0x4000994")]
			QuarticOut,
			[Token(Token = "0x4000995")]
			QuarticInOut,
			[Token(Token = "0x4000996")]
			QuarticOutIn,
			[Token(Token = "0x4000997")]
			QuinticIn,
			[Token(Token = "0x4000998")]
			QuinticOut,
			[Token(Token = "0x4000999")]
			QuinticInOut,
			[Token(Token = "0x400099A")]
			QuinticOutIn
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xAD3164", Offset = "0xAD3164", VA = "0xAD3164")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xAD3FFC", Offset = "0xAD3FFC", VA = "0xAD3FFC")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xAD3FDC", Offset = "0xAD3FDC", VA = "0xAD3FDC")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xAD4D0C", Offset = "0xAD4D0C", VA = "0xAD4D0C")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xAD35B8", Offset = "0xAD35B8", VA = "0xAD35B8")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xAD451C", Offset = "0xAD451C", VA = "0xAD451C")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xAD3564", Offset = "0xAD3564", VA = "0xAD3564")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xAD44D4", Offset = "0xAD44D4", VA = "0xAD44D4")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xAD3618", Offset = "0xAD3618", VA = "0xAD3618")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xAD4560", Offset = "0xAD4560", VA = "0xAD4560")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xAD36B0", Offset = "0xAD36B0", VA = "0xAD36B0")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xAD45F4", Offset = "0xAD45F4", VA = "0xAD45F4")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xAD37B4", Offset = "0xAD37B4", VA = "0xAD37B4")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xAD46B0", Offset = "0xAD46B0", VA = "0xAD46B0")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xAD3780", Offset = "0xAD3780", VA = "0xAD3780")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xAD4688", Offset = "0xAD4688", VA = "0xAD4688")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xAD37E4", Offset = "0xAD37E4", VA = "0xAD37E4")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xAD46D8", Offset = "0xAD46D8", VA = "0xAD46D8")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xAD3844", Offset = "0xAD3844", VA = "0xAD3844")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xAD472C", Offset = "0xAD472C", VA = "0xAD472C")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xAD38F8", Offset = "0xAD38F8", VA = "0xAD38F8")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xAD47B4", Offset = "0xAD47B4", VA = "0xAD47B4")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xAD38D4", Offset = "0xAD38D4", VA = "0xAD38D4")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xAD47A0", Offset = "0xAD47A0", VA = "0xAD47A0")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xAD3924", Offset = "0xAD3924", VA = "0xAD3924")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xAD47D0", Offset = "0xAD47D0", VA = "0xAD47D0")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xAD3984", Offset = "0xAD3984", VA = "0xAD3984")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xAD4824", Offset = "0xAD4824", VA = "0xAD4824")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xAD3A50", Offset = "0xAD3A50", VA = "0xAD3A50")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xAD48B4", Offset = "0xAD48B4", VA = "0xAD48B4")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xAD3A04", Offset = "0xAD3A04", VA = "0xAD3A04")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xAD4878", Offset = "0xAD4878", VA = "0xAD4878")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xAD3A98", Offset = "0xAD3A98", VA = "0xAD3A98")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xAD48EC", Offset = "0xAD48EC", VA = "0xAD48EC")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xAD3B2C", Offset = "0xAD3B2C", VA = "0xAD3B2C")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xAD4970", Offset = "0xAD4970", VA = "0xAD4970")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xAD3BFC", Offset = "0xAD3BFC", VA = "0xAD3BFC")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xAD4A04", Offset = "0xAD4A04", VA = "0xAD4A04")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xAD3BD4", Offset = "0xAD3BD4", VA = "0xAD3BD4")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xAD49EC", Offset = "0xAD49EC", VA = "0xAD49EC")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xAD3C2C", Offset = "0xAD3C2C", VA = "0xAD3C2C")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xAD4A2C", Offset = "0xAD4A2C", VA = "0xAD4A2C")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xAD3C90", Offset = "0xAD3C90", VA = "0xAD3C90")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xAD4A80", Offset = "0xAD4A80", VA = "0xAD4A80")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xAD3D40", Offset = "0xAD3D40", VA = "0xAD3D40")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0xAD4AFC", Offset = "0xAD4AFC", VA = "0xAD4AFC")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0xAD3D14", Offset = "0xAD3D14", VA = "0xAD3D14")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0xAD4AE0", Offset = "0xAD4AE0", VA = "0xAD4AE0")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0xAD3D74", Offset = "0xAD3D74", VA = "0xAD3D74")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0xAD4B24", Offset = "0xAD4B24", VA = "0xAD4B24")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xAD3DDC", Offset = "0xAD3DDC", VA = "0xAD3DDC")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xAD4B80", Offset = "0xAD4B80", VA = "0xAD4B80")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xAD3E9C", Offset = "0xAD3E9C", VA = "0xAD3E9C")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xAD4C08", Offset = "0xAD4C08", VA = "0xAD4C08")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xAD3E6C", Offset = "0xAD3E6C", VA = "0xAD3E6C")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xAD4BE8", Offset = "0xAD4BE8", VA = "0xAD4BE8")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xAD3ED4", Offset = "0xAD3ED4", VA = "0xAD3ED4")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xAD4C38", Offset = "0xAD4C38", VA = "0xAD4C38")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xAD3F48", Offset = "0xAD3F48", VA = "0xAD3F48")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xAD4C9C", Offset = "0xAD4C9C", VA = "0xAD4C9C")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000179")]
	public class DTObjectDump
	{
		[Token(Token = "0x400099B")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xAD4D1C", Offset = "0xAD4D1C", VA = "0xAD4D1C")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xAD5E3C", Offset = "0xAD5E3C", VA = "0xAD5E3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xAD508C", Offset = "0xAD508C", VA = "0xAD508C")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xAD5118", Offset = "0xAD5118", VA = "0xAD5118")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x200017A")]
	public static class DTUtility
	{
		[Token(Token = "0x1700011B")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xAD5F0C", Offset = "0xAD5F0C", VA = "0xAD5F0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xAD5F04", Offset = "0xAD5F04", VA = "0xAD5F04")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xAD5F14", Offset = "0xAD5F14", VA = "0xAD5F14")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x60009DB")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x60009DC")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xAD6164", Offset = "0xAD6164", VA = "0xAD6164")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xAD618C", Offset = "0xAD618C", VA = "0xAD618C")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xAD61F4", Offset = "0xAD61F4", VA = "0xAD61F4")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xAD6338", Offset = "0xAD6338", VA = "0xAD6338")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009E1")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x200017B")]
	public static class DTTime
	{
		[Token(Token = "0x400099F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x40009A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x1700011C")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xAD63A4", Offset = "0xAD63A4", VA = "0xAD63A4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700011D")]
		public static float deltaTime
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xAD63BC", Offset = "0xAD63BC", VA = "0xAD63BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0xAD6414", Offset = "0xAD6414", VA = "0xAD6414")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xAD6468", Offset = "0xAD6468", VA = "0xAD6468")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x40009A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x1700011E")]
		public double LastTicks
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0xAD6614", Offset = "0xAD6614", VA = "0xAD6614")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700011F")]
		public double LastMS
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0xAD6690", Offset = "0xAD6690", VA = "0xAD6690")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000120")]
		public double AverageMS
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xAD66AC", Offset = "0xAD66AC", VA = "0xAD66AC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000121")]
		public double MinimumMS
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0xAD67EC", Offset = "0xAD67EC", VA = "0xAD67EC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000122")]
		public double MaximumMS
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xAD68F0", Offset = "0xAD68F0", VA = "0xAD68F0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000123")]
		public double AverageTicks
		{
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0xAD69F4", Offset = "0xAD69F4", VA = "0xAD69F4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000124")]
		public double MinimumTicks
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xAD6AC0", Offset = "0xAD6AC0", VA = "0xAD6AC0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000125")]
		public double MaximumTicks
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0xAD6BB8", Offset = "0xAD6BB8", VA = "0xAD6BB8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xAD64C4", Offset = "0xAD64C4", VA = "0xAD64C4")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xAD655C", Offset = "0xAD655C", VA = "0xAD655C")]
		public void Start()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xAD6578", Offset = "0xAD6578", VA = "0xAD6578")]
		public void Stop()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xAD65F8", Offset = "0xAD65F8", VA = "0xAD65F8")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x200017D")]
	public static class DTMath
	{
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xAD6CAC", Offset = "0xAD6CAC", VA = "0xAD6CAC")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xAD6E58", Offset = "0xAD6E58", VA = "0xAD6E58")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xAD6E90", Offset = "0xAD6E90", VA = "0xAD6E90")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xAD6EC8", Offset = "0xAD6EC8", VA = "0xAD6EC8")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xAD6784", Offset = "0xAD6784", VA = "0xAD6784")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xAD6EE4", Offset = "0xAD6EE4", VA = "0xAD6EE4")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xAD6F4C", Offset = "0xAD6F4C", VA = "0xAD6F4C")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0xAD7024", Offset = "0xAD7024", VA = "0xAD7024")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0xAD716C", Offset = "0xAD716C", VA = "0xAD716C")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0xAD7188", Offset = "0xAD7188", VA = "0xAD7188")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0xAD7238", Offset = "0xAD7238", VA = "0xAD7238")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0xAD7280", Offset = "0xAD7280", VA = "0xAD7280")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0xAD72E8", Offset = "0xAD72E8", VA = "0xAD72E8")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0xAD73B4", Offset = "0xAD73B4", VA = "0xAD73B4")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0xAD7480", Offset = "0xAD7480", VA = "0xAD7480")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xAD7794", Offset = "0xAD7794", VA = "0xAD7794")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xAD78B4", Offset = "0xAD78B4", VA = "0xAD78B4")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xAD7A04", Offset = "0xAD7A04", VA = "0xAD7A04")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200017E")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x6000A04")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x6000A05")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A06")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x6000A07")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public static class DTLog
	{
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0xAD7B18", Offset = "0xAD7B18", VA = "0xAD7B18")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0xAD7B70", Offset = "0xAD7B70", VA = "0xAD7B70")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0xAD7BD8", Offset = "0xAD7BD8", VA = "0xAD7BD8")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xAD7C30", Offset = "0xAD7C30", VA = "0xAD7C30")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0xAD7C98", Offset = "0xAD7C98", VA = "0xAD7C98")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0xAD7D00", Offset = "0xAD7D00", VA = "0xAD7D00")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0xAD7D70", Offset = "0xAD7D70", VA = "0xAD7D70")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0xAD7DC8", Offset = "0xAD7DC8", VA = "0xAD7DC8")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0xAD7E30", Offset = "0xAD7E30", VA = "0xAD7E30")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xAD7E98", Offset = "0xAD7E98", VA = "0xAD7E98")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xAD7F08", Offset = "0xAD7F08", VA = "0xAD7F08")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0xAD7F60", Offset = "0xAD7F60", VA = "0xAD7F60")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0xAD7FC8", Offset = "0xAD7FC8", VA = "0xAD7FC8")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0xAD8030", Offset = "0xAD8030", VA = "0xAD8030")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Token(Token = "0x2000180")]
	public enum DTMessageType
	{
		[Token(Token = "0x40009A6")]
		None,
		[Token(Token = "0x40009A7")]
		Info,
		[Token(Token = "0x40009A8")]
		Warning,
		[Token(Token = "0x40009A9")]
		Error
	}
	[Token(Token = "0x2000181")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x40009AB")]
		None = 0,
		[Token(Token = "0x40009AC")]
		Compact = 1,
		[Token(Token = "0x40009AD")]
		Clipboard = 128,
		[Token(Token = "0x40009AE")]
		Zero = 256,
		[Token(Token = "0x40009AF")]
		One = 512,
		[Token(Token = "0x40009B0")]
		Negate = 1024,
		[Token(Token = "0x40009B1")]
		Full = 1920,
		[Token(Token = "0x40009B2")]
		FullCompact = 1921
	}
	[Token(Token = "0x2000182")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Label;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Tooltip;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Color;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int Precision;

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0xAD80A0", Offset = "0xAD80A0", VA = "0xAD80A0")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000183")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0xAD80EC", Offset = "0xAD80EC", VA = "0xAD80EC")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0xAD8138", Offset = "0xAD8138", VA = "0xAD8138")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0xAD813C", Offset = "0xAD813C", VA = "0xAD813C")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0xAD8140", Offset = "0xAD8140", VA = "0xAD8140")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0xAD8144", Offset = "0xAD8144", VA = "0xAD8144")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0xAD8148", Offset = "0xAD8148", VA = "0xAD8148")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0xAD8164", Offset = "0xAD8164", VA = "0xAD8164")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinValue;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0xAD8180", Offset = "0xAD8180", VA = "0xAD8180")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0xAD81A4", Offset = "0xAD81A4", VA = "0xAD81A4")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xAD81D8", Offset = "0xAD81D8", VA = "0xAD81D8")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x200018B")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MaxValue;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xAD822C", Offset = "0xAD822C", VA = "0xAD822C")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xAD8250", Offset = "0xAD8250", VA = "0xAD8250")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinValue;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float MaxValue;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool Slider;

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xAD8284", Offset = "0xAD8284", VA = "0xAD8284")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xAD82B8", Offset = "0xAD82B8", VA = "0xAD82B8")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xAD8308", Offset = "0xAD8308", VA = "0xAD8308")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xAD8354", Offset = "0xAD8354", VA = "0xAD8354")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200018D")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly string MaxValueField;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float Min;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Max;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xAD83A4", Offset = "0xAD83A4", VA = "0xAD83A4")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xAD83E8", Offset = "0xAD83E8", VA = "0xAD83E8")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xAD83EC", Offset = "0xAD83EC", VA = "0xAD83EC")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000190")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x2000191")]
		public enum DialogMode
		{
			[Token(Token = "0x40009CC")]
			OpenFile,
			[Token(Token = "0x40009CD")]
			OpenFolder,
			[Token(Token = "0x40009CE")]
			CreateFile
		}

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly DialogMode Mode;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Title;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Directory;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string Extension;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string DefaultName;

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xAD83F0", Offset = "0xAD83F0", VA = "0xAD83F0")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x2000192")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xAD8464", Offset = "0xAD8464", VA = "0xAD8464")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool RegionIsOptional;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UseSlider;

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xAD8468", Offset = "0xAD8468", VA = "0xAD8468")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000194")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xAD84BC", Offset = "0xAD84BC", VA = "0xAD84BC")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xAD84C0", Offset = "0xAD84C0", VA = "0xAD84C0")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x2000196")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x17000126")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x6000A2F")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x6000A30")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x2000197")]
	public enum DTValueClamping
	{
		[Token(Token = "0x40009DC")]
		None,
		[Token(Token = "0x40009DD")]
		Min,
		[Token(Token = "0x40009DE")]
		Max,
		[Token(Token = "0x40009DF")]
		Range
	}
	[Token(Token = "0x2000198")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x40009E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x6000A31")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x6000A32")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000A33")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A34")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000A35")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000A36")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000199")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x6000A39")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x6000A3A")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000A3B")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x200019A")]
	internal class QueuedCallback
	{
		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xAD84C4", Offset = "0xAD84C4", VA = "0xAD84C4")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x200019B")]
	internal class LoopState<T>
	{
		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x40009EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x6000A3D")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x200019C")]
	public class ThreadPoolWorker : IDisposable
	{
		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xAD84CC", Offset = "0xAD84CC", VA = "0xAD84CC")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xAD8568", Offset = "0xAD8568", VA = "0xAD8568")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x6000A40")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0xAD8688", Offset = "0xAD8688", VA = "0xAD8688")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0xAD84D4", Offset = "0xAD84D4", VA = "0xAD84D4")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0xAD8570", Offset = "0xAD8570", VA = "0xAD8570")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0xAD8854", Offset = "0xAD8854", VA = "0xAD8854")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0xAD8990", Offset = "0xAD8990", VA = "0xAD8990")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xAD8860", Offset = "0xAD8860", VA = "0xAD8860")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xAD8ACC", Offset = "0xAD8ACC", VA = "0xAD8ACC")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xAD89E4", Offset = "0xAD89E4", VA = "0xAD89E4")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xAD87CC", Offset = "0xAD87CC", VA = "0xAD87CC")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xAD8BDC", Offset = "0xAD8BDC", VA = "0xAD8BDC", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xAD8C94", Offset = "0xAD8C94", VA = "0xAD8C94")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x200019F")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Component> mObjects;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x17000127")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0xAD8D38", Offset = "0xAD8D38", VA = "0xAD8D38", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0xAD8D40", Offset = "0xAD8D40", VA = "0xAD8D40")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0xAD8DA8", Offset = "0xAD8DA8", VA = "0xAD8DA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		public string Identifier
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0xAD8E50", Offset = "0xAD8E50", VA = "0xAD8E50", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0xAD8E58", Offset = "0xAD8E58", VA = "0xAD8E58", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public Type Type
		{
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0xAD8EA8", Offset = "0xAD8EA8", VA = "0xAD8EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012B")]
		public int Count
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0xAD8F7C", Offset = "0xAD8F7C", VA = "0xAD8F7C", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xAD8FC4", Offset = "0xAD8FC4", VA = "0xAD8FC4")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xAD922C", Offset = "0xAD922C", VA = "0xAD922C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xAD9254", Offset = "0xAD9254", VA = "0xAD9254")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xAD92F8", Offset = "0xAD92F8", VA = "0xAD92F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xAD92FC", Offset = "0xAD92FC", VA = "0xAD92FC", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0xAD9080", Offset = "0xAD9080", VA = "0xAD9080", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0xAD97E8", Offset = "0xAD97E8", VA = "0xAD97E8")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0xAD98E0", Offset = "0xAD98E0", VA = "0xAD98E0", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0xAD99D4", Offset = "0xAD99D4", VA = "0xAD99D4")]
		public void Push(Component item)
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0xAD9D20", Offset = "0xAD9D20", VA = "0xAD9D20")]
		public Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000A62")]
		public T Pop<T>(Transform parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xAD9710", Offset = "0xAD9710", VA = "0xAD9710")]
		private Component create()
		{
			return null;
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xAD966C", Offset = "0xAD966C", VA = "0xAD966C")]
		private void destroy(Component item)
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0xADA0C4", Offset = "0xADA0C4", VA = "0xADA0C4")]
		private void setParent(Component item, Transform parent)
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0xAD9F18", Offset = "0xAD9F18", VA = "0xAD9F18")]
		private void sendAfterPop(Component item)
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0xAD9B78", Offset = "0xAD9B78", VA = "0xAD9B78")]
		private void sendBeforePush(Component item)
		{
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0xAD9590", Offset = "0xAD9590", VA = "0xAD9590")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0xADA164", Offset = "0xADA164", VA = "0xADA164", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0xADA168", Offset = "0xADA168", VA = "0xADA168", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0xADA4E0", Offset = "0xADA4E0", VA = "0xADA4E0")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x20001A1")]
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x1700012C")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000A6E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		public static T Instance
		{
			[Token(Token = "0x6000A6F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A70")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x6000A71")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000A72")]
		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000A73")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x6000A74")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x20001A2")]
	public interface IDTSingleton
	{
		[Token(Token = "0x6000A76")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x20001A3")]
	public class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		[Token(Token = "0x1700012E")]
		public string Version
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0xADA5A0", Offset = "0xADA5A0", VA = "0xADA5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0xADA5A8", Offset = "0xADA5A8", VA = "0xADA5A8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0xADA5B0", Offset = "0xADA5B0", VA = "0xADA5B0")]
		[Obsolete("This upgrading mechanism is tied to the Editor. Meaning it does not work when in Play mode. A better way to handle upgrading would be to use Unity's ISerializationCallbackReceiver")]
		protected void CheckForVersionUpgrade()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0xADA5B4", Offset = "0xADA5B4", VA = "0xADA5B4", Slot = "4")]
		[Obsolete("This upgrading mechanism is tied to the Editor. Meaning it does not work when in Play mode. A better way to handle upgrading would be to use Unity's ISerializationCallbackReceiver")]
		protected virtual bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0xADA894", Offset = "0xADA894", VA = "0xADA894")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0xADA91C", Offset = "0xADA91C", VA = "0xADA91C")]
		public DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20001A4")]
	[ExecuteInEditMode]
	public class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x1700012F")]
		public MeshFilter Filter
		{
			[Token(Token = "0x6000A7D")]
			[Address(RVA = "0xADA924", Offset = "0xADA924", VA = "0xADA924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0xADA9CC", Offset = "0xADA9CC", VA = "0xADA9CC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0xADAC1C", Offset = "0xADAC1C", VA = "0xADAC1C")]
		public DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[TextArea(5, 20)]
		[SerializeField]
		private string m_Note;

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0xADAC24", Offset = "0xADAC24", VA = "0xADAC24")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Section("General", true, false, 100)]
		private bool m_AutoCreatePools;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AsGroup(null, Expanded = false)]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x17000130")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0xADAC2C", Offset = "0xADAC2C", VA = "0xADAC2C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0xADAC34", Offset = "0xADAC34", VA = "0xADAC34")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0xADAC4C", Offset = "0xADAC4C", VA = "0xADAC4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0xADAC54", Offset = "0xADAC54", VA = "0xADAC54")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0xADACBC", Offset = "0xADACBC", VA = "0xADACBC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0xADACC4", Offset = "0xADACC4", VA = "0xADACC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public int Count
		{
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0xADACD0", Offset = "0xADACD0", VA = "0xADACD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0xADAD54", Offset = "0xADAD54", VA = "0xADAD54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0xADAD5C", Offset = "0xADAD5C", VA = "0xADAD5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0xADAF08", Offset = "0xADAF08", VA = "0xADAF08")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0xADB34C", Offset = "0xADB34C", VA = "0xADB34C")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x6000A8C")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x6000A8D")]
		public ComponentPool GetComponentPool<T>() where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0xADB3FC", Offset = "0xADB3FC", VA = "0xADB3FC")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x6000A8F")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x6000A90")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xADB4F4", Offset = "0xADB4F4", VA = "0xADB4F4")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xADB7B8", Offset = "0xADB7B8", VA = "0xADB7B8")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0xADBA08", Offset = "0xADBA08", VA = "0xADBA08")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0xADBAAC", Offset = "0xADBAAC", VA = "0xADBAAC")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x6000A95")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0xADBC74", Offset = "0xADBC74", VA = "0xADBC74")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	[RequireComponent(typeof(PoolManager))]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[FieldCondition("m_Identifier", "", false, ActionAttribute.ActionEnum.ShowWarning, "Please enter an identifier! (Select a prefab to set automatically)", ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		private string m_Identifier;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x17000134")]
		public string Identifier
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0xADBDD0", Offset = "0xADBDD0", VA = "0xADBDD0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0xADBDD8", Offset = "0xADBDD8", VA = "0xADBDD8", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0xADBEF0", Offset = "0xADBEF0", VA = "0xADBEF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0xADBEF8", Offset = "0xADBEF8", VA = "0xADBEF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0xADBF10", Offset = "0xADBF10", VA = "0xADBF10", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0xADBF18", Offset = "0xADBF18", VA = "0xADBF18")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public PoolManager Manager
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0xADBE48", Offset = "0xADBE48", VA = "0xADBE48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public int Count
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0xADC3EC", Offset = "0xADC3EC", VA = "0xADC3EC", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0xADBF80", Offset = "0xADBF80", VA = "0xADBF80")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0xADBF84", Offset = "0xADBF84", VA = "0xADBF84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0xADB688", Offset = "0xADB688", VA = "0xADB688")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0xADC158", Offset = "0xADC158", VA = "0xADC158", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0xADBFAC", Offset = "0xADBFAC", VA = "0xADBFAC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0xADC73C", Offset = "0xADC73C", VA = "0xADC73C", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0xADC830", Offset = "0xADC830", VA = "0xADC830")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0xADCA74", Offset = "0xADCA74", VA = "0xADCA74", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0xADC568", Offset = "0xADC568", VA = "0xADC568")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0xADC510", Offset = "0xADC510", VA = "0xADC510")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xADC434", Offset = "0xADC434", VA = "0xADC434")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0xADCCBC", Offset = "0xADCCBC", VA = "0xADCCBC")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0xADCA1C", Offset = "0xADCA1C", VA = "0xADCA1C")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0xADCC64", Offset = "0xADCC64", VA = "0xADCC64")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0xADCD50", Offset = "0xADCD50", VA = "0xADCD50")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x20001A8")]
	[Obsolete("Will get removed since it is not used by Curvy")]
	public static class TransformExt
	{
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0xADCE08", Offset = "0xADCE08", VA = "0xADCE08")]
		public static void CopyFrom(this Transform t, Transform other)
		{
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0xADCE74", Offset = "0xADCE74", VA = "0xADCE74")]
		public static void SetChildrenHideFlags(this Transform t, HideFlags flags)
		{
		}
	}
	[Token(Token = "0x20001A9")]
	public static class ObjectExt
	{
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0xADCF34", Offset = "0xADCF34", VA = "0xADCF34")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0xADCF8C", Offset = "0xADCF8C", VA = "0xADCF8C")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AA")]
	public static class Vector2Ext
	{
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0xADCFF8", Offset = "0xADCFF8", VA = "0xADCFF8")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0xADD04C", Offset = "0xADD04C", VA = "0xADD04C")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0xADD15C", Offset = "0xADD15C", VA = "0xADD15C")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0xADD170", Offset = "0xADD170", VA = "0xADD170")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0xADD180", Offset = "0xADD180", VA = "0xADD180")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xADD1D0", Offset = "0xADD1D0", VA = "0xADD1D0")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x20001AB")]
	public static class Vector3Ext
	{
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xADD1D4", Offset = "0xADD1D4", VA = "0xADD1D4")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0xADD244", Offset = "0xADD244", VA = "0xADD244")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0xADD2A0", Offset = "0xADD2A0", VA = "0xADD2A0")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0xADD2A4", Offset = "0xADD2A4", VA = "0xADD2A4")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0xADD2D8", Offset = "0xADD2D8", VA = "0xADD2D8")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001AC")]
	public static class QuaternionExt
	{
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0xADD30C", Offset = "0xADD30C", VA = "0xADD30C")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0xADD3CC", Offset = "0xADD3CC", VA = "0xADD3CC")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001AD")]
	public static class CameraExt
	{
		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0xADD48C", Offset = "0xADD48C", VA = "0xADD48C")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0xADD750", Offset = "0xADD750", VA = "0xADD750")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001AE")]
	public static class GameObjectExt
	{
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0xADDB1C", Offset = "0xADDB1C", VA = "0xADDB1C")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0xADDC0C", Offset = "0xADDC0C", VA = "0xADDC0C")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x20001AF")]
	public static class ComponentExt
	{
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0xADDEB8", Offset = "0xADDEB8", VA = "0xADDEB8")]
		public static void StripComponents(this Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0xADDF94", Offset = "0xADDF94", VA = "0xADDF94")]
		public static GameObject AddChildGameObject(this Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x6000AC6")]
		public static T AddChildGameObject<T>(this Component c, string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000AC7")]
		public static T DuplicateGameObject<T>(this Component source, Transform newParent, bool keepPrefabConnection = false) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0xADE038", Offset = "0xADE038", VA = "0xADE038")]
		public static Component DuplicateGameObject(this Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B0")]
	public static class ColorExt
	{
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0xADE270", Offset = "0xADE270", VA = "0xADE270")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B1")]
	public static class EnumExt
	{
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0xADE6E0", Offset = "0xADE6E0", VA = "0xADE6E0")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACB")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACC")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x6000ACD")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}

		[Token(Token = "0x6000ACE")]
		[Obsolete("Will get removed since it is not used by Curvy")]
		public static T Toggle<T>(this Enum value, T toggleValue)
		{
			return (T)null;
		}

		[Token(Token = "0x6000ACF")]
		[Obsolete("Will get removed since it is not used by Curvy")]
		public static T SetAll<T>(this Enum value)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20001B2")]
	public static class RectExt
	{
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0xADE8F4", Offset = "0xADE8F4", VA = "0xADE8F4")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0xADE94C", Offset = "0xADE94C", VA = "0xADE94C")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0xADE9A4", Offset = "0xADE9A4", VA = "0xADE9A4")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0xADEA0C", Offset = "0xADEA0C", VA = "0xADEA0C")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0xADEA74", Offset = "0xADEA74", VA = "0xADEA74")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0xADEABC", Offset = "0xADEABC", VA = "0xADEABC")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0xADEB24", Offset = "0xADEB24", VA = "0xADEB24")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0xADEB2C", Offset = "0xADEB2C", VA = "0xADEB2C")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0xADEC00", Offset = "0xADEC00", VA = "0xADEC00")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0xADEC8C", Offset = "0xADEC8C", VA = "0xADEC8C")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x20001B3")]
	public static class StringExt
	{
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0xADED84", Offset = "0xADED84", VA = "0xADED84")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0xADF028", Offset = "0xADF028", VA = "0xADF028")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0xADF078", Offset = "0xADF078", VA = "0xADF078")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B4")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x6000ADD")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public static class ArrayExt
	{
		[Token(Token = "0x6000ADE")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x6000ADF")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000AE0")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x6000AE1")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x6000AE2")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x6000AE3")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x6000AE4")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x6000AE5")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000AE6")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B6")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0xADF0D4", Offset = "0xADF0D4", VA = "0xADF0D4")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0xADF24C", Offset = "0xADF24C", VA = "0xADF24C")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public static class TypeExt
	{
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0xADF738", Offset = "0xADF738", VA = "0xADF738")]
		[Obsolete("Use GetLoadedTypes() instead")]
		public static Type[] GetAllTypes(this Type typeFromAssembly)
		{
			return null;
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0xADA3B8", Offset = "0xADA3B8", VA = "0xADA3B8")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0xADF76C", Offset = "0xADF76C", VA = "0xADF76C")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x6000AEC")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x6000AED")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000AEE")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0xADF78C", Offset = "0xADF78C", VA = "0xADF78C")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0xADF924", Offset = "0xADF924", VA = "0xADF924")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0xADFADC", Offset = "0xADFADC", VA = "0xADFADC")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0xAD4EE4", Offset = "0xAD4EE4", VA = "0xAD4EE4")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0xAD5C94", Offset = "0xAD5C94", VA = "0xAD5C94")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0xADFC74", Offset = "0xADFC74", VA = "0xADFC74")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0xADFD74", Offset = "0xADFD74", VA = "0xADFD74")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0xAD5E5C", Offset = "0xAD5E5C", VA = "0xAD5E5C")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0xADFE58", Offset = "0xADFE58", VA = "0xADFE58")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0xADF7BC", Offset = "0xADF7BC", VA = "0xADF7BC")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0xADF964", Offset = "0xADF964", VA = "0xADF964")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0xADFB0C", Offset = "0xADFB0C", VA = "0xADFB0C")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0xAE0278", Offset = "0xAE0278", VA = "0xAE0278")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001B9")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x6000AFF")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
