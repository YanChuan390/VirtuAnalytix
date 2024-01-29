using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator animator;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PuppetMaster puppetMaster;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ConfigurableJoint[] leftLeg;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConfigurableJoint[] rightLeg;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool leftLegRemoved;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool rightLegRemoved;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xFDA4E4", Offset = "0xFDA4E4", VA = "0xFDA4E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xFDA63C", Offset = "0xFDA63C", VA = "0xFDA63C")]
	public void OnRebuild()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xFDA6CC", Offset = "0xFDA6CC", VA = "0xFDA6CC")]
	private void OnMuscleDisconnected(Muscle m)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xFDA78C", Offset = "0xFDA78C", VA = "0xFDA78C")]
	private bool IsLegMuscle(Muscle m, out bool isLeft)
	{
		return default(bool);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xFDA8E4", Offset = "0xFDA8E4", VA = "0xFDA8E4")]
	public Skeleton()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000003")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000004")]
		public enum Mode
		{
			[Token(Token = "0x4000016")]
			AnimationClips,
			[Token(Token = "0x4000017")]
			AnimationStates,
			[Token(Token = "0x4000018")]
			PlayableDirector,
			[Token(Token = "0x4000019")]
			Realtime
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		[Range(1f, 90f)]
		public int frameRate;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		[Range(0f, 0.1f)]
		public float keyReductionError;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xFDA9FC", Offset = "0xFDA9FC", VA = "0xFDA9FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0xFDAA04", Offset = "0xFDAA04", VA = "0xFDAA04")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0xFDAA10", Offset = "0xFDAA10", VA = "0xFDAA10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0xFDAA18", Offset = "0xFDAA18", VA = "0xFDAA18")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0xFDAA20", Offset = "0xFDAA20", VA = "0xFDAA20")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xFDAA28", Offset = "0xFDAA28", VA = "0xFDAA28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xFDA8EC", Offset = "0xFDA8EC", VA = "0xFDA8EC")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xFDA930", Offset = "0xFDA930", VA = "0xFDA930")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xFDA974", Offset = "0xFDA974", VA = "0xFDA974")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xFDA9B8", Offset = "0xFDA9B8", VA = "0xFDA9B8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600000E")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600000F")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x6000010")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x6000011")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x6000012")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xFDAA30", Offset = "0xFDAA30", VA = "0xFDAA30")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xFDAA34", Offset = "0xFDAA34", VA = "0xFDAA34")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xFDAA38", Offset = "0xFDAA38", VA = "0xFDAA38")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xFDAA3C", Offset = "0xFDAA3C", VA = "0xFDAA3C")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xFDAB64", Offset = "0xFDAB64", VA = "0xFDAB64")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xFDAFA8", Offset = "0xFDAFA8", VA = "0xFDAFA8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xFDAFB0", Offset = "0xFDAFB0", VA = "0xFDAFB0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xFDB1EC", Offset = "0xFDB1EC", VA = "0xFDB1EC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xFDB450", Offset = "0xFDB450", VA = "0xFDB450", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xFDB768", Offset = "0xFDB768", VA = "0xFDB768", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xFDAD90", Offset = "0xFDAD90", VA = "0xFDAD90")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xFDAE48", Offset = "0xFDAE48", VA = "0xFDAE48")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xFDB9C8", Offset = "0xFDB9C8", VA = "0xFDB9C8")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class TQ
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xFDBA30", Offset = "0xFDBA30", VA = "0xFDBA30")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class AvatarUtility
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0xFDBA94", Offset = "0xFDBA94", VA = "0xFDBA94")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xFDBCF0", Offset = "0xFDBCF0", VA = "0xFDBCF0")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xFDBCD0", Offset = "0xFDBCD0", VA = "0xFDBCD0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xFDC360", Offset = "0xFDC360", VA = "0xFDC360")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xFDC368", Offset = "0xFDC368", VA = "0xFDC368")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xFDC3A0", Offset = "0xFDC3A0", VA = "0xFDC3A0")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xFDC764", Offset = "0xFDC764", VA = "0xFDC764")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xFDC944", Offset = "0xFDC944", VA = "0xFDC944")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xFDC948", Offset = "0xFDC948", VA = "0xFDC948")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xFDCADC", Offset = "0xFDCADC", VA = "0xFDCADC")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xFDCE40", Offset = "0xFDCE40", VA = "0xFDCE40")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xFDCCA8", Offset = "0xFDCCA8", VA = "0xFDCCA8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xFDD028", Offset = "0xFDD028", VA = "0xFDD028")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xFDD3B8", Offset = "0xFDD3B8", VA = "0xFDD3B8")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xFDD4A8", Offset = "0xFDD4A8", VA = "0xFDD4A8")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xFDD58C", Offset = "0xFDD58C", VA = "0xFDD58C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xFDD510", Offset = "0xFDD510", VA = "0xFDD510")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xFDD5F4", Offset = "0xFDD5F4", VA = "0xFDD5F4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xFDD69C", Offset = "0xFDD69C", VA = "0xFDD69C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000A")]
	public class BakerMuscle
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xFDD988", Offset = "0xFDD988", VA = "0xFDD988")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xFDD9F8", Offset = "0xFDD9F8", VA = "0xFDD9F8")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xFDE494", Offset = "0xFDE494", VA = "0xFDE494")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xFDE53C", Offset = "0xFDE53C", VA = "0xFDE53C")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xFDE42C", Offset = "0xFDE42C", VA = "0xFDE42C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xFDE630", Offset = "0xFDE630", VA = "0xFDE630")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xFDE66C", Offset = "0xFDE66C", VA = "0xFDE66C")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class BakerTransform
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xFDAF00", Offset = "0xFDAF00", VA = "0xFDAF00")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xFDB1D8", Offset = "0xFDB1D8", VA = "0xFDB1D8")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xFDB4B4", Offset = "0xFDB4B4", VA = "0xFDB4B4")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xFDE674", Offset = "0xFDE674", VA = "0xFDE674")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFDB080", Offset = "0xFDB080", VA = "0xFDB080")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xFDE8FC", Offset = "0xFDE8FC", VA = "0xFDE8FC")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xFDB7D4", Offset = "0xFDB7D4", VA = "0xFDB7D4")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xFDB258", Offset = "0xFDB258", VA = "0xFDB258")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		public int muscleFrameRateDiv;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xFDE964", Offset = "0xFDE964", VA = "0xFDE964")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xFDEEC4", Offset = "0xFDEEC4", VA = "0xFDEEC4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xFDEEE0", Offset = "0xFDEEE0", VA = "0xFDEEE0", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xFDEFBC", Offset = "0xFDEFBC", VA = "0xFDEFBC", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xFDF078", Offset = "0xFDF078", VA = "0xFDF078", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xFDF218", Offset = "0xFDF218", VA = "0xFDF218", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xFDF52C", Offset = "0xFDF52C", VA = "0xFDF52C")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFDF604", Offset = "0xFDF604", VA = "0xFDF604")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000E")]
		public enum UpdateMode
		{
			[Token(Token = "0x400007D")]
			Update,
			[Token(Token = "0x400007E")]
			FixedUpdate,
			[Token(Token = "0x400007F")]
			LateUpdate,
			[Token(Token = "0x4000080")]
			FixedLateUpdate
		}

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xFDF6B4", Offset = "0xFDF6B4", VA = "0xFDF6B4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xFDF6BC", Offset = "0xFDF6BC", VA = "0xFDF6BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xFDF6C4", Offset = "0xFDF6C4", VA = "0xFDF6C4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xFDF6CC", Offset = "0xFDF6CC", VA = "0xFDF6CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0xFDF6D4", Offset = "0xFDF6D4", VA = "0xFDF6D4")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xFDF6DC", Offset = "0xFDF6DC", VA = "0xFDF6DC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xFE0144", Offset = "0xFE0144", VA = "0xFE0144")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xFDF6E4", Offset = "0xFDF6E4", VA = "0xFDF6E4")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xFDF71C", Offset = "0xFDF71C", VA = "0xFDF71C")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xFDF724", Offset = "0xFDF724", VA = "0xFDF724", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xFDF85C", Offset = "0xFDF85C", VA = "0xFDF85C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xFDF8A4", Offset = "0xFDF8A4", VA = "0xFDF8A4", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xFDF8FC", Offset = "0xFDF8FC", VA = "0xFDF8FC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xFDF954", Offset = "0xFDF954", VA = "0xFDF954")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xFDF888", Offset = "0xFDF888", VA = "0xFDF888")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xFDFAE0", Offset = "0xFDFAE0", VA = "0xFDFAE0")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xFE0108", Offset = "0xFE0108", VA = "0xFE0108")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xFE01B0", Offset = "0xFE01B0", VA = "0xFE01B0")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xFE0278", Offset = "0xFE0278", VA = "0xFE0278")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xFE02A4", Offset = "0xFE02A4", VA = "0xFE02A4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xFE04C8", Offset = "0xFE04C8", VA = "0xFE04C8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xFE0504", Offset = "0xFE0504", VA = "0xFE0504")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public enum Axis
	{
		[Token(Token = "0x4000087")]
		X,
		[Token(Token = "0x4000088")]
		Y,
		[Token(Token = "0x4000089")]
		Z
	}
	[Token(Token = "0x2000011")]
	public class AxisTools
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0xFE0520", Offset = "0xFE0520", VA = "0xFE0520")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xFE0600", Offset = "0xFE0600", VA = "0xFE0600")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xFE0638", Offset = "0xFE0638", VA = "0xFE0638")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xFE0780", Offset = "0xFE0780", VA = "0xFE0780")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xFE0734", Offset = "0xFE0734", VA = "0xFE0734")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xFE087C", Offset = "0xFE087C", VA = "0xFE087C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xFE08C0", Offset = "0xFE08C0", VA = "0xFE08C0")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xFE0D4C", Offset = "0xFE0D4C", VA = "0xFE0D4C")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000013")]
		public class LimbOrientation
		{
			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000090")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x600006E")]
			[Address(RVA = "0xFE1080", Offset = "0xFE1080", VA = "0xFE1080")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xFE0DC8", Offset = "0xFE0DC8", VA = "0xFE0DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xFE10F4", Offset = "0xFE10F4", VA = "0xFE10F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xFE0D54", Offset = "0xFE0D54", VA = "0xFE0D54")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000014")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000015")]
		public enum BoneType
		{
			[Token(Token = "0x40000A4")]
			Unassigned,
			[Token(Token = "0x40000A5")]
			Spine,
			[Token(Token = "0x40000A6")]
			Head,
			[Token(Token = "0x40000A7")]
			Arm,
			[Token(Token = "0x40000A8")]
			Leg,
			[Token(Token = "0x40000A9")]
			Tail,
			[Token(Token = "0x40000AA")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000016")]
		public enum BoneSide
		{
			[Token(Token = "0x40000AC")]
			Center,
			[Token(Token = "0x40000AD")]
			Left,
			[Token(Token = "0x40000AE")]
			Right
		}

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xFE13AC", Offset = "0xFE13AC", VA = "0xFE13AC")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xFE1678", Offset = "0xFE1678", VA = "0xFE1678")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xFE18B4", Offset = "0xFE18B4", VA = "0xFE18B4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xFE1928", Offset = "0xFE1928", VA = "0xFE1928")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xFE19BC", Offset = "0xFE19BC", VA = "0xFE19BC")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xFE1560", Offset = "0xFE1560", VA = "0xFE1560")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xFE182C", Offset = "0xFE182C", VA = "0xFE182C")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xFE20F4", Offset = "0xFE20F4", VA = "0xFE20F4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xFE1F4C", Offset = "0xFE1F4C", VA = "0xFE1F4C")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xFE2020", Offset = "0xFE2020", VA = "0xFE2020")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xFE1BA4", Offset = "0xFE1BA4", VA = "0xFE1BA4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xFE1C40", Offset = "0xFE1C40", VA = "0xFE1C40")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xFE1CDC", Offset = "0xFE1CDC", VA = "0xFE1CDC")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xFE1D78", Offset = "0xFE1D78", VA = "0xFE1D78")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFE1E14", Offset = "0xFE1E14", VA = "0xFE1E14")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFE1EB0", Offset = "0xFE1EB0", VA = "0xFE1EB0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xFE22DC", Offset = "0xFE22DC", VA = "0xFE22DC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xFE1AD0", Offset = "0xFE1AD0", VA = "0xFE1AD0")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xFE2258", Offset = "0xFE2258", VA = "0xFE2258")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xFE233C", Offset = "0xFE233C", VA = "0xFE233C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xFE23FC", Offset = "0xFE23FC", VA = "0xFE23FC")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xFE21E4", Offset = "0xFE21E4", VA = "0xFE21E4")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xFE2174", Offset = "0xFE2174", VA = "0xFE2174")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class BipedReferences
	{
		[Token(Token = "0x2000018")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0xFE8EC4", Offset = "0xFE8EC4", VA = "0xFE8EC4")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xFE8EB0", Offset = "0xFE8EB0", VA = "0xFE8EB0")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xFE51EC", Offset = "0xFE51EC", VA = "0xFE51EC", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xFE5548", Offset = "0xFE5548", VA = "0xFE5548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xFE5558", Offset = "0xFE5558", VA = "0xFE5558", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xFE58E4", Offset = "0xFE58E4", VA = "0xFE58E4", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xFE5C74", Offset = "0xFE5C74", VA = "0xFE5C74")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xFE6398", Offset = "0xFE6398", VA = "0xFE6398")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xFE5F08", Offset = "0xFE5F08", VA = "0xFE5F08")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xFE6C28", Offset = "0xFE6C28", VA = "0xFE6C28")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xFE6D14", Offset = "0xFE6D14", VA = "0xFE6D14")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xFE7830", Offset = "0xFE7830", VA = "0xFE7830")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFE763C", Offset = "0xFE763C", VA = "0xFE763C")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xFE73DC", Offset = "0xFE73DC", VA = "0xFE73DC")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xFE6DB0", Offset = "0xFE6DB0", VA = "0xFE6DB0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xFE7730", Offset = "0xFE7730", VA = "0xFE7730")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xFE7910", Offset = "0xFE7910", VA = "0xFE7910")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xFE84B8", Offset = "0xFE84B8", VA = "0xFE84B8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xFE7F60", Offset = "0xFE7F60", VA = "0xFE7F60")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xFE8804", Offset = "0xFE8804", VA = "0xFE8804")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xFE82C0", Offset = "0xFE82C0", VA = "0xFE82C0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFE880C", Offset = "0xFE880C", VA = "0xFE880C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xFE8814", Offset = "0xFE8814", VA = "0xFE8814")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xFE89D4", Offset = "0xFE89D4", VA = "0xFE89D4")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xFE8E48", Offset = "0xFE8E48", VA = "0xFE8E48")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFE5E88", Offset = "0xFE5E88", VA = "0xFE5E88")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xFE8ECC", Offset = "0xFE8ECC", VA = "0xFE8ECC")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xFE8ED4", Offset = "0xFE8ED4", VA = "0xFE8ED4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xFE8FDC", Offset = "0xFE8FDC", VA = "0xFE8FDC")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class Hierarchy
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFE8DC4", Offset = "0xFE8DC4", VA = "0xFE8DC4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFE8CB8", Offset = "0xFE8CB8", VA = "0xFE8CB8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFE6F14", Offset = "0xFE6F14", VA = "0xFE6F14")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFE752C", Offset = "0xFE752C", VA = "0xFE752C")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFE7194", Offset = "0xFE7194", VA = "0xFE7194")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFE8FEC", Offset = "0xFE8FEC", VA = "0xFE8FEC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xFE7044", Offset = "0xFE7044", VA = "0xFE7044")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xFE90E0", Offset = "0xFE90E0", VA = "0xFE90E0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xFE944C", Offset = "0xFE944C", VA = "0xFE944C")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xFE9244", Offset = "0xFE9244", VA = "0xFE9244")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xFE95D4", Offset = "0xFE95D4", VA = "0xFE95D4")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xFE95DC", Offset = "0xFE95DC", VA = "0xFE95DC")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xFE9664", Offset = "0xFE9664", VA = "0xFE9664")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C8")]
		None,
		[Token(Token = "0x40000C9")]
		InOutCubic,
		[Token(Token = "0x40000CA")]
		InOutQuintic,
		[Token(Token = "0x40000CB")]
		InOutSine,
		[Token(Token = "0x40000CC")]
		InQuintic,
		[Token(Token = "0x40000CD")]
		InQuartic,
		[Token(Token = "0x40000CE")]
		InCubic,
		[Token(Token = "0x40000CF")]
		InQuadratic,
		[Token(Token = "0x40000D0")]
		InElastic,
		[Token(Token = "0x40000D1")]
		InElasticSmall,
		[Token(Token = "0x40000D2")]
		InElasticBig,
		[Token(Token = "0x40000D3")]
		InSine,
		[Token(Token = "0x40000D4")]
		InBack,
		[Token(Token = "0x40000D5")]
		OutQuintic,
		[Token(Token = "0x40000D6")]
		OutQuartic,
		[Token(Token = "0x40000D7")]
		OutCubic,
		[Token(Token = "0x40000D8")]
		OutInCubic,
		[Token(Token = "0x40000D9")]
		OutInQuartic,
		[Token(Token = "0x40000DA")]
		OutElastic,
		[Token(Token = "0x40000DB")]
		OutElasticSmall,
		[Token(Token = "0x40000DC")]
		OutElasticBig,
		[Token(Token = "0x40000DD")]
		OutSine,
		[Token(Token = "0x40000DE")]
		OutBack,
		[Token(Token = "0x40000DF")]
		OutBackCubic,
		[Token(Token = "0x40000E0")]
		OutBackQuartic,
		[Token(Token = "0x40000E1")]
		BackInCubic,
		[Token(Token = "0x40000E2")]
		BackInQuartic
	}
	[Token(Token = "0x200001E")]
	public class Interp
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xFE96F0", Offset = "0xFE96F0", VA = "0xFE96F0")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xFEA078", Offset = "0xFEA078", VA = "0xFEA078")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xFEA0E8", Offset = "0xFEA0E8", VA = "0xFEA0E8")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xFE9AF0", Offset = "0xFE9AF0", VA = "0xFE9AF0")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xFE9AFC", Offset = "0xFE9AFC", VA = "0xFE9AFC")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xFE9B20", Offset = "0xFE9B20", VA = "0xFE9B20")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xFE9B5C", Offset = "0xFE9B5C", VA = "0xFE9B5C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xFE9B74", Offset = "0xFE9B74", VA = "0xFE9B74")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xFE9B88", Offset = "0xFE9B88", VA = "0xFE9B88")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xFE9B9C", Offset = "0xFE9B9C", VA = "0xFE9B9C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xFE9BAC", Offset = "0xFE9BAC", VA = "0xFE9BAC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xFE9BF4", Offset = "0xFE9BF4", VA = "0xFE9BF4")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xFE9C2C", Offset = "0xFE9C2C", VA = "0xFE9C2C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xFE9C54", Offset = "0xFE9C54", VA = "0xFE9C54")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xFEA158", Offset = "0xFEA158", VA = "0xFEA158")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xFE9C88", Offset = "0xFE9C88", VA = "0xFE9C88")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xFE9CB0", Offset = "0xFE9CB0", VA = "0xFE9CB0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xFE9CE0", Offset = "0xFE9CE0", VA = "0xFE9CE0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xFE9D14", Offset = "0xFE9D14", VA = "0xFE9D14")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xFE9D58", Offset = "0xFE9D58", VA = "0xFE9D58")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xFE9DBC", Offset = "0xFE9DBC", VA = "0xFE9DBC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xFE9E20", Offset = "0xFE9E20", VA = "0xFE9E20")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xFE9E74", Offset = "0xFE9E74", VA = "0xFE9E74")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xFE9EC8", Offset = "0xFE9EC8", VA = "0xFE9EC8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xFE9F00", Offset = "0xFE9F00", VA = "0xFE9F00")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xFE9F34", Offset = "0xFE9F34", VA = "0xFE9F34")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xFEA18C", Offset = "0xFEA18C", VA = "0xFEA18C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xFE9F78", Offset = "0xFE9F78", VA = "0xFE9F78")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xFEA008", Offset = "0xFEA008", VA = "0xFEA008")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xFEA038", Offset = "0xFEA038", VA = "0xFEA038")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xFEA21C", Offset = "0xFEA21C", VA = "0xFEA21C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xFEA224", Offset = "0xFEA224", VA = "0xFEA224")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xFEA2AC", Offset = "0xFEA2AC", VA = "0xFEA2AC")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xFEA338", Offset = "0xFEA338", VA = "0xFEA338")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xFEA384", Offset = "0xFEA384", VA = "0xFEA384")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xFEA440", Offset = "0xFEA440", VA = "0xFEA440")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xFEA398", Offset = "0xFEA398", VA = "0xFEA398")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xFEA454", Offset = "0xFEA454", VA = "0xFEA454")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xFEA4E4", Offset = "0xFEA4E4", VA = "0xFEA4E4")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xFEA50C", Offset = "0xFEA50C", VA = "0xFEA50C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xFEA558", Offset = "0xFEA558", VA = "0xFEA558")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xFEA5C0", Offset = "0xFEA5C0", VA = "0xFEA5C0")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xFEA718", Offset = "0xFEA718", VA = "0xFEA718")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xFEA84C", Offset = "0xFEA84C", VA = "0xFEA84C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xFEA8A4", Offset = "0xFEA8A4", VA = "0xFEA8A4")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000021")]
	public static class QuaTools
	{
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xFEA8C8", Offset = "0xFEA8C8", VA = "0xFEA8C8")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFEA920", Offset = "0xFEA920", VA = "0xFEA920")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xFEAA50", Offset = "0xFEAA50", VA = "0xFEAA50")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xFEABD0", Offset = "0xFEABD0", VA = "0xFEABD0")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xFEACAC", Offset = "0xFEACAC", VA = "0xFEACAC")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xFEAD88", Offset = "0xFEAD88", VA = "0xFEAD88")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xFEAFA0", Offset = "0xFEAFA0", VA = "0xFEAFA0")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xFEAFEC", Offset = "0xFEAFEC", VA = "0xFEAFEC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xFEB038", Offset = "0xFEB038", VA = "0xFEB038")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xFEB13C", Offset = "0xFEB13C", VA = "0xFEB13C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xFEB240", Offset = "0xFEB240", VA = "0xFEB240")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xFEB354", Offset = "0xFEB354", VA = "0xFEB354")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xFEB3FC", Offset = "0xFEB3FC", VA = "0xFEB3FC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFEB508", Offset = "0xFEB508", VA = "0xFEB508")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xFEB670", Offset = "0xFEB670", VA = "0xFEB670")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFEB854", Offset = "0xFEB854", VA = "0xFEB854")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xFEB924", Offset = "0xFEB924", VA = "0xFEB924")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xFEBAA8", Offset = "0xFEBAA8", VA = "0xFEBAA8")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xFEBBB4", Offset = "0xFEBBB4", VA = "0xFEBBB4")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000022")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000F1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F2")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000F3")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xFEBD28", Offset = "0xFEBD28", VA = "0xFEBD28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xFEC024", Offset = "0xFEC024", VA = "0xFEC024")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xFEBC0C", Offset = "0xFEBC0C", VA = "0xFEBC0C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xFEBCA0", Offset = "0xFEBCA0", VA = "0xFEBCA0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xFEBCA4", Offset = "0xFEBCA4", VA = "0xFEBCA4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xFEBCA8", Offset = "0xFEBCA8", VA = "0xFEBCA8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xFEBCAC", Offset = "0xFEBCAC", VA = "0xFEBCAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xFEBD24", Offset = "0xFEBD24", VA = "0xFEBD24")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xFEBCD4", Offset = "0xFEBCD4", VA = "0xFEBCD4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xFEBFE8", Offset = "0xFEBFE8", VA = "0xFEBFE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xFEBDF4", Offset = "0xFEBDF4", VA = "0xFEBDF4")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xFEC0BC", Offset = "0xFEC0BC", VA = "0xFEC0BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xFEC108", Offset = "0xFEC108", VA = "0xFEC108")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xFEC154", Offset = "0xFEC154", VA = "0xFEC154")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xFEC18C", Offset = "0xFEC18C", VA = "0xFEC18C")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xFEC19C", Offset = "0xFEC19C", VA = "0xFEC19C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xFEC250", Offset = "0xFEC250", VA = "0xFEC250")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xFEC304", Offset = "0xFEC304", VA = "0xFEC304")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xFEC3B8", Offset = "0xFEC3B8", VA = "0xFEC3B8")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public static class V2Tools
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xFEC3C0", Offset = "0xFEC3C0", VA = "0xFEC3C0")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xFEC3C8", Offset = "0xFEC3C8", VA = "0xFEC3C8")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xFEC458", Offset = "0xFEC458", VA = "0xFEC458")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xFEC4EC", Offset = "0xFEC4EC", VA = "0xFEC4EC")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xFEC59C", Offset = "0xFEC59C", VA = "0xFEC59C")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000026")]
	public static class V3Tools
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xFEC5F8", Offset = "0xFEC5F8", VA = "0xFEC5F8")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xFEC618", Offset = "0xFEC618", VA = "0xFEC618")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xFEC6EC", Offset = "0xFEC6EC", VA = "0xFEC6EC")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFEC7A4", Offset = "0xFEC7A4", VA = "0xFEC7A4")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFEC800", Offset = "0xFEC800", VA = "0xFEC800")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFEC85C", Offset = "0xFEC85C", VA = "0xFEC85C")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFEC974", Offset = "0xFEC974", VA = "0xFEC974")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFEC9D0", Offset = "0xFEC9D0", VA = "0xFEC9D0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFECA08", Offset = "0xFECA08", VA = "0xFECA08")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFECB58", Offset = "0xFECB58", VA = "0xFECB58")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xFECCD4", Offset = "0xFECCD4", VA = "0xFECCD4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xFECF04", Offset = "0xFECF04", VA = "0xFECF04")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xFED154", Offset = "0xFED154", VA = "0xFED154")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xFED3AC", Offset = "0xFED3AC", VA = "0xFED3AC")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xFED558", Offset = "0xFED558", VA = "0xFED558")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xFED750", Offset = "0xFED750", VA = "0xFED750")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xFED7CC", Offset = "0xFED7CC", VA = "0xFED7CC")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xFED85C", Offset = "0xFED85C", VA = "0xFED85C")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xFED8F4", Offset = "0xFED8F4", VA = "0xFED8F4")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xFED8E4", Offset = "0xFED8E4", VA = "0xFED8E4")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000027")]
	public static class Warning
	{
		[Token(Token = "0x2000028")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xFED970", Offset = "0xFED970", VA = "0xFED970")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xFE6B74", Offset = "0xFE6B74", VA = "0xFE6B74")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Dynamics
{
	[Token(Token = "0x2000029")]
	public class AnimationBlocker : MonoBehaviour
	{
		[Token(Token = "0x6000126")]
		[Address(RVA = "0xFEDAF8", Offset = "0xFEDAF8", VA = "0xFEDAF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xFEDBBC", Offset = "0xFEDBBC", VA = "0xFEDBBC")]
		public AnimationBlocker()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public abstract class BehaviourBase : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		public delegate void BehaviourDelegate();

		[Token(Token = "0x200002C")]
		public delegate void BehaviourUpdateDelegate(float deltaTime);

		[Token(Token = "0x200002D")]
		public delegate void HitDelegate(MuscleHit hit);

		[Token(Token = "0x200002E")]
		public delegate void CollisionDelegate(MuscleCollision collision);

		[Serializable]
		[Token(Token = "0x200002F")]
		public struct PuppetEvent
		{
			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Another Puppet Behaviour to switch to on this event. This must be the exact Type of the the Behaviour, careful with spelling.")]
			public string switchToBehaviour;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Animations to cross-fade to on this event. This is separate from the UnityEvent below because UnityEvents can't handle calls with more than one parameter such as Animator.CrossFade.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x4000110")]
			private const string empty = "";

			[Token(Token = "0x17000011")]
			public bool switchBehaviour
			{
				[Token(Token = "0x6000167")]
				[Address(RVA = "0xFEEFF0", Offset = "0xFEEFF0", VA = "0xFEEFF0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0xFEF07C", Offset = "0xFEF07C", VA = "0xFEF07C")]
			public void Trigger(PuppetMaster puppetMaster, bool switchBehaviourEnabled = true)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000030")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000111")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animationState;

			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float crossfadeTime;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int layer;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000115")]
			private const string empty = "";

			[Token(Token = "0x6000169")]
			[Address(RVA = "0xFEF280", Offset = "0xFEF280", VA = "0xFEF280")]
			public void Activate(Animator animator, Animation animation)
			{
			}

			[Token(Token = "0x600016A")]
			[Address(RVA = "0xFEF33C", Offset = "0xFEF33C", VA = "0xFEF33C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0xFEF438", Offset = "0xFEF438", VA = "0xFEF438")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600016C")]
			[Address(RVA = "0xFEF510", Offset = "0xFEF510", VA = "0xFEF510")]
			public AnimatorEvent()
			{
			}
		}

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BehaviourDelegate OnPreActivate;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BehaviourDelegate OnPreInitiate;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BehaviourUpdateDelegate OnPreFixedUpdate;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BehaviourUpdateDelegate OnPreUpdate;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BehaviourUpdateDelegate OnPreLateUpdate;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourUpdateDelegate OnPreRead;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public BehaviourUpdateDelegate OnPreWrite;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BehaviourDelegate OnPreDeactivate;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public BehaviourDelegate OnPreFixTransforms;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public HitDelegate OnPreMuscleHit;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public CollisionDelegate OnPreMuscleCollision;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CollisionDelegate OnPreMuscleCollisionExit;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public BehaviourDelegate OnHierarchyChanged;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public BehaviourDelegate OnPostActivate;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public BehaviourDelegate OnPostInitiate;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BehaviourUpdateDelegate OnPostFixedUpdate;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BehaviourUpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public BehaviourUpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public BehaviourUpdateDelegate OnPostRead;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public BehaviourUpdateDelegate OnPostWrite;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public BehaviourDelegate OnPostDeactivate;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public BehaviourDelegate OnPostDrawGizmos;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public BehaviourDelegate OnPostFixTransforms;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public HitDelegate OnPostMuscleHit;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public CollisionDelegate OnPostMuscleCollision;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public CollisionDelegate OnPostMuscleCollisionExit;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public bool deactivated;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool initiated;

		[Token(Token = "0x400010C")]
		private const string typeSpringBase = "BehaviourBase";

		[Token(Token = "0x17000010")]
		public bool forceActive
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xFEDC50", Offset = "0xFEDC50", VA = "0xFEDC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xFEDC58", Offset = "0xFEDC58", VA = "0xFEDC58")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000128")]
		public abstract void OnReactivate();

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xFEDBC4", Offset = "0xFEDBC4", VA = "0xFEDBC4", Slot = "5")]
		public virtual void Resurrect()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xFEDBC8", Offset = "0xFEDBC8", VA = "0xFEDBC8", Slot = "6")]
		public virtual void Freeze()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xFEDBCC", Offset = "0xFEDBCC", VA = "0xFEDBCC", Slot = "7")]
		public virtual void Unfreeze()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xFEDBD0", Offset = "0xFEDBD0", VA = "0xFEDBD0", Slot = "8")]
		public virtual void KillStart()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFEDBD4", Offset = "0xFEDBD4", VA = "0xFEDBD4", Slot = "9")]
		public virtual void KillEnd()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xFEDBD8", Offset = "0xFEDBD8", VA = "0xFEDBD8", Slot = "10")]
		public virtual void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFEDBDC", Offset = "0xFEDBDC", VA = "0xFEDBDC", Slot = "11")]
		public virtual void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFEDBE0", Offset = "0xFEDBE0", VA = "0xFEDBE0", Slot = "12")]
		public virtual void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFEDBE4", Offset = "0xFEDBE4", VA = "0xFEDBE4", Slot = "13")]
		public virtual void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xFEDC00", Offset = "0xFEDC00", VA = "0xFEDC00", Slot = "14")]
		public virtual void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xFEDC1C", Offset = "0xFEDC1C", VA = "0xFEDC1C", Slot = "15")]
		protected virtual void OnActivate()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xFEDC20", Offset = "0xFEDC20", VA = "0xFEDC20", Slot = "16")]
		protected virtual void OnDeactivate()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xFEDC24", Offset = "0xFEDC24", VA = "0xFEDC24", Slot = "17")]
		protected virtual void OnInitiate()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xFEDC28", Offset = "0xFEDC28", VA = "0xFEDC28", Slot = "18")]
		protected virtual void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xFEDC2C", Offset = "0xFEDC2C", VA = "0xFEDC2C", Slot = "19")]
		protected virtual void OnUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xFEDC30", Offset = "0xFEDC30", VA = "0xFEDC30", Slot = "20")]
		protected virtual void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xFEDC34", Offset = "0xFEDC34", VA = "0xFEDC34", Slot = "21")]
		protected virtual void OnReadBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xFEDC38", Offset = "0xFEDC38", VA = "0xFEDC38", Slot = "22")]
		protected virtual void OnWriteBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xFEDC3C", Offset = "0xFEDC3C", VA = "0xFEDC3C", Slot = "23")]
		protected virtual void OnDrawGizmosBehaviour()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xFEDC40", Offset = "0xFEDC40", VA = "0xFEDC40", Slot = "24")]
		protected virtual void OnFixTransformsBehaviour()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xFEDC44", Offset = "0xFEDC44", VA = "0xFEDC44", Slot = "25")]
		protected virtual void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xFEDC48", Offset = "0xFEDC48", VA = "0xFEDC48", Slot = "26")]
		protected virtual void OnMuscleCollisionBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xFEDC4C", Offset = "0xFEDC4C", VA = "0xFEDC4C", Slot = "27")]
		protected virtual void OnMuscleCollisionExitBehaviour(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xFEDC64", Offset = "0xFEDC64", VA = "0xFEDC64")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xFEDCC4", Offset = "0xFEDCC4", VA = "0xFEDCC4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xFEDD30", Offset = "0xFEDD30", VA = "0xFEDD30")]
		public void OnRead(float deltaTime)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xFEDDB8", Offset = "0xFEDDB8", VA = "0xFEDDB8")]
		public void OnWrite(float deltaTime)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xFEDE40", Offset = "0xFEDE40", VA = "0xFEDE40")]
		public void OnMuscleHit(MuscleHit hit)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xFEDEE0", Offset = "0xFEDEE0", VA = "0xFEDEE0")]
		public void OnMuscleCollision(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xFEDFA4", Offset = "0xFEDFA4", VA = "0xFEDFA4")]
		public void OnMuscleCollisionExit(MuscleCollision collision)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xFEE068", Offset = "0xFEE068", VA = "0xFEE068")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xFEE078", Offset = "0xFEE078", VA = "0xFEE078")]
		public void Activate()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xFEE18C", Offset = "0xFEE18C", VA = "0xFEE18C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xFEE1EC", Offset = "0xFEE1EC", VA = "0xFEE1EC")]
		public void FixedUpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xFEE2C0", Offset = "0xFEE2C0", VA = "0xFEE2C0")]
		public void UpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xFEE394", Offset = "0xFEE394", VA = "0xFEE394")]
		public void LateUpdateB(float deltaTime)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xFEE468", Offset = "0xFEE468", VA = "0xFEE468", Slot = "28")]
		protected virtual void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xFEE4AC", Offset = "0xFEE4AC", VA = "0xFEE4AC", Slot = "29")]
		protected virtual string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xFEE4EC", Offset = "0xFEE4EC", VA = "0xFEE4EC")]
		protected void RotateTargetToRootMuscle()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xFEE60C", Offset = "0xFEE60C", VA = "0xFEE60C")]
		protected void TranslateTargetToRootMuscle(float maintainY)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xFEE740", Offset = "0xFEE740", VA = "0xFEE740")]
		protected void RemovePropMuscles()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xFEE848", Offset = "0xFEE848", VA = "0xFEE848", Slot = "30")]
		protected virtual void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xFEE7D8", Offset = "0xFEE7D8", VA = "0xFEE7D8")]
		protected bool ContainsRemovablePropMuscle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xFEEAE8", Offset = "0xFEEAE8", VA = "0xFEEAE8")]
		protected BehaviourBase()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourFall")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page11.html")]
	public class BehaviourFall : BehaviourBase
	{
		[Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class <SmoothActivate>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000128")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000129")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BehaviourFall <>4__this;

			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <fader>5__2;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600017E")]
				[Address(RVA = "0xFEFF68", Offset = "0xFEFF68", VA = "0xFEFF68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000180")]
				[Address(RVA = "0xFEFFB0", Offset = "0xFEFFB0", VA = "0xFEFFB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0xFEF6A8", Offset = "0xFEF6A8", VA = "0xFEF6A8")]
			[DebuggerHidden]
			public <SmoothActivate>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0xFEFD94", Offset = "0xFEFD94", VA = "0xFEFD94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0xFEFD98", Offset = "0xFEFD98", VA = "0xFEFD98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0xFEFF70", Offset = "0xFEFF70", VA = "0xFEFF70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000116")]
		private const string typeSpring = "BehaviourFall";

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("Animation State to crossfade to when this behaviour is activated.")]
		[LargeHeader("Animation State")]
		public string stateName;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("The duration of crossfading to 'State Name'. Value is in seconds.")]
		public float transitionDuration;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("Layer index containing the destination state. If no layer is specified or layer is -1, the first state that is found with the given name or hash will be played.")]
		public int layer;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("Start time of the current destination state. Value is in seconds. If no explicit fixedTime is specified or fixedTime value is float.NegativeInfinity, the state will either be played from the start if it's not already playing, or will continue playing from its current time and no transition will happen.")]
		public float fixedTime;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[Tooltip("The layers that will be raycasted against to find colliding objects.")]
		[LargeHeader("Blending")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("The parameter in the Animator that blends between catch fall and writhe animations.")]
		public string blendParameter;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("The height of the pelvis from the ground at which will blend to writhe animation.")]
		public float writheHeight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[Tooltip("The vertical velocity of the pelvis at which will blend to writhe animation.")]
		public float writheYVelocity;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Tooltip("The speed of blendig between the two falling animations.")]
		public float blendSpeed;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Tooltip("The speed of blending in mapping on activation.")]
		public float blendMappingSpeed;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[LargeHeader("Ending")]
		[Tooltip("If false, this behaviour will never end.")]
		public bool canEnd;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[Tooltip("The minimum time since this behaviour activated before it can end.")]
		public float minTime;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Tooltip("If the velocity of the pelvis falls below this value, can end the behaviour.")]
		public float maxEndVelocity;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Tooltip("Event triggered when all end conditions are met.")]
		public PuppetEvent onEnd;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float timer;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private bool endTriggered;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xFEF524", Offset = "0xFEF524", VA = "0xFEF524", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xFEF564", Offset = "0xFEF564", VA = "0xFEF564")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xFEF5A8", Offset = "0xFEF5A8", VA = "0xFEF5A8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xFEF5EC", Offset = "0xFEF5EC", VA = "0xFEF5EC", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xFEF694", Offset = "0xFEF694", VA = "0xFEF694", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xFEF69C", Offset = "0xFEF69C", VA = "0xFEF69C", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xFEF620", Offset = "0xFEF620", VA = "0xFEF620")]
		[IteratorStateMachine(typeof(<SmoothActivate>d__23))]
		private IEnumerator SmoothActivate()
		{
			return null;
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xFEF6D0", Offset = "0xFEF6D0", VA = "0xFEF6D0", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xFEFB70", Offset = "0xFEFB70", VA = "0xFEFB70", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xFEFC74", Offset = "0xFEFC74", VA = "0xFEFC74", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xFEFA08", Offset = "0xFEFA08", VA = "0xFEFA08")]
		private float GetBlendTarget(float groundHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xFEF90C", Offset = "0xFEF90C", VA = "0xFEF90C")]
		private float GetGroundHeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xFEFCC0", Offset = "0xFEFCC0", VA = "0xFEFCC0", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xFEFCE8", Offset = "0xFEFCE8", VA = "0xFEFCE8")]
		public BehaviourFall()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page10.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourPuppet")]
	public class BehaviourPuppet : BehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000034")]
		public enum State
		{
			[Token(Token = "0x4000163")]
			Puppet,
			[Token(Token = "0x4000164")]
			Unpinned,
			[Token(Token = "0x4000165")]
			GetUp
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		public enum NormalMode
		{
			[Token(Token = "0x4000167")]
			Active,
			[Token(Token = "0x4000168")]
			Unmapped,
			[Token(Token = "0x4000169")]
			Kinematic
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public class MasterProps
		{
			[Token(Token = "0x400016A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public NormalMode normalMode;

			[Token(Token = "0x400016B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float mappingBlendSpeed;

			[Token(Token = "0x400016C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool activateOnStaticCollisions;

			[Token(Token = "0x400016D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float activateOnImpulse;

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x100F2AC", Offset = "0x100F2AC", VA = "0x100F2AC")]
			public MasterProps()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000037")]
		public struct MuscleProps
		{
			[Token(Token = "0x400016E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("How much will collisions with muscles of this group unpin parent muscles?")]
			[Range(0f, 1f)]
			public float unpinParents;

			[Token(Token = "0x400016F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin child muscles?")]
			public float unpinChildren;

			[Token(Token = "0x4000170")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin muscles of the same group?")]
			public float unpinGroup;

			[Token(Token = "0x4000171")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("If 1, muscles of this group will always be mapped to the ragdoll.")]
			public float minMappingWeight;

			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("If 0, muscles of this group will not be mapped to the ragdoll pose even if they are unpinned.")]
			public float maxMappingWeight;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("Defines minimum pin weight for the muscles. Muscle pin weight can’t be reduced beyond this value when damage occurs from collisions.")]
			public float minPinWeight;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("If true, muscles of this group will have their colliders disabled while in puppet state (not unbalanced nor getting up).")]
			public bool disableColliders;

			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("How fast will muscles of this group regain their pin weight (multiplier)?")]
			public float regainPinSpeed;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Smaller value means more unpinning from collisions (multiplier).")]
			public float collisionResistance;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
			public float knockOutDistance;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Puppet or GetUp state. Using a lower friction material reduces the risk of muscles getting stuck and pulled out of their joints.")]
			public PhysicMaterial puppetMaterial;

			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Unpinned state.")]
			public PhysicMaterial unpinnedMaterial;
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		public struct MusclePropsGroup
		{
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Muscle groups to which those properties apply.")]
			public Muscle.Group[] groups;

			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The muscle properties for those muscle groups.")]
			public MuscleProps props;
		}

		[Serializable]
		[Token(Token = "0x2000039")]
		public struct CollisionResistanceMultiplier
		{
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LayerMask layers;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("Multiplier for the 'Collision Resistance' for these layers.")]
			public float multiplier;

			[Token(Token = "0x400017F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Overrides 'Collision Threshold' for these layers.")]
			public float collisionThreshold;
		}

		[Token(Token = "0x200003A")]
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);

		[Token(Token = "0x400012B")]
		private const string typeSpring = "BehaviourPuppet";

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[LargeHeader("Collision And Recovery")]
		public MasterProps masterProps;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Will ground the target to those layers when getting up.")]
		public LayerMask groundLayers;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Tooltip("Will unpin the muscles that collide with those layers.")]
		public LayerMask collisionLayers;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("The collision impulse sqrMagnitude threshold under which collisions will be ignored.")]
		public float collisionThreshold;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Weight collisionResistance;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("Multiplies collision resistance for the specified layers.")]
		public CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Range(1f, 30f)]
		[Tooltip("An optimisation. Will only process up to this number of collisions per physics step.")]
		public int maxCollisions;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[Tooltip("How fast will the muscles of this group regain their pin weight?")]
		[Range(0.001f, 10f)]
		public float regainPinSpeed;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Tooltip("'Boosting' is a term used for making muscles temporarily immune to collisions and/or deal more damage to the muscles of other characters. That is done by increasing Muscle.State.immunity and Muscle.State.impulseMlp. For example when you set muscle.state.immunity to 1, boostFalloff will determine how fast this value will fall back to normal (0). Use BehaviourPuppet.BoostImmunity() and BehaviourPuppet.BoostImpulseMlp() for boosting from your own scripts. It is helpful for making the puppet stronger and deliever more punch while playing a melee hitting/kicking animation.")]
		public float boostFalloff;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[LargeHeader("Muscle Group Properties")]
		[Tooltip("The default muscle properties. If there are no 'Group Overrides', this will be used for all muscles.")]
		public MuscleProps defaults;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[Tooltip("Overriding default muscle properties for some muscle groups (for example making the feet stiffer or the hands looser).")]
		public MusclePropsGroup[] groupOverrides;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[LargeHeader("Losing Balance")]
		[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
		[Range(0.001f, 10f)]
		public float knockOutDistance;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[Range(0f, 1f)]
		[Tooltip("Smaller value makes the muscles weaker when the puppet is knocked out.")]
		public float unpinnedMuscleWeightMlp;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[Tooltip("Most character controllers apply supernatural accelerations to characters when changing running direction or jumping. It will require major pinning forces to be applied on the ragdoll to keep up with that acceleration. When a puppet collides with something at that point and is unpinned, those forces might shoot the puppet off to space. This variable limits the velocity of the ragdoll's Rigidbodies when the puppet is unpinned.")]
		public float maxRigidbodyVelocity;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		[Range(0f, 1f)]
		[Tooltip("If a muscle has drifted farther than 'Knock Out Distance', will only unpin the puppet if it's pin weight is less than this value. Lowering this value will make puppets less likely to lose balance on minor collisions.")]
		public float pinWeightThreshold;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		[Tooltip("If false, will not unbalance the puppet by muscles that have their pin weight set to 0 in PuppetMaster muscle settings.")]
		public bool unpinnedMuscleKnockout;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		[Tooltip("If true, all muscles of the 'Prop' group will be detached from the puppet when it loses balance.")]
		public bool dropProps;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x182")]
		[Tooltip("If true, GetUp state will be triggerred automatically after 'Get Up Delay' and when the velocity of the hip muscle is less than 'Max Get Up Velocity'.")]
		[LargeHeader("Getting Up")]
		public bool canGetUp;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[Tooltip("Minimum delay for getting up after loosing balance. After that time has passed, will wait for the velocity of the hip muscle to come down below 'Max Get Up Velocity' and then switch to the GetUp state.")]
		public float getUpDelay;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[Tooltip("The duration of blending the animation target from the ragdoll pose to the getting up animation once the GetUp state has been triggered.")]
		public float blendToAnimationTime;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[Tooltip("Will not get up before the velocity of the hip muscle has come down to this value.")]
		public float maxGetUpVelocity;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		[Tooltip("The duration of the 'GetUp' state after which it switches to the 'Puppetä state.")]
		public float minGetUpDuration;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		[Tooltip("Collision resistance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpCollisionResistanceMlp;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[Tooltip("Regain pin weight speed multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpRegainPinSpeedMlp;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		[Tooltip("Knock out distance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpKnockOutDistanceMlp;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a prone pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetProne;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a supine pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetSupine;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[LargeHeader("Events")]
		[Tooltip("Called when the character starts getting up from a prone pose (facing down).")]
		public PuppetEvent onGetUpProne;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Tooltip("Called when the character starts getting up from a supine pose (facing up).")]
		public PuppetEvent onGetUpSupine;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Tooltip("Called when the character is knocked out (loses balance). Doesn't matter from which state.")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[Tooltip("Called when the character is knocked out (loses balance) only from the normal Puppet state.")]
		public PuppetEvent onLoseBalanceFromPuppet;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[Tooltip("Called when the character is knocked out (loses balance) only from the GetUp state.")]
		public PuppetEvent onLoseBalanceFromGetUp;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[Tooltip("Called when the character has fully recovered and switched to the Puppet state.")]
		public PuppetEvent onRegainBalance;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public CollisionDelegate OnCollision;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public CollisionImpulseDelegate OnCollisionImpulse;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		[HideInInspector]
		public bool canMoveTarget;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private float unpinnedTimer;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private float getUpTimer;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Vector3 hipsForward;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
		private Vector3 hipsUp;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float getupAnimationBlendWeight;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private bool getUpTargetFixed;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private NormalMode lastNormalMode;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private int collisions;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool eventsEnabled;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float lastKnockOutDistance;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private float knockOutDistanceSqr;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private bool getupDisabled;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29D")]
		private bool hasCollidedSinceGetUp;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29E")]
		private bool hasBoosted;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3 getUpPosition;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private bool dropPropFlag;

		[Token(Token = "0x17000014")]
		public State state
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x100B6C8", Offset = "0x100B6C8", VA = "0x100B6C8")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x100B6D0", Offset = "0x100B6D0", VA = "0x100B6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x100B600", Offset = "0x100B600", VA = "0x100B600", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x100B640", Offset = "0x100B640", VA = "0x100B640")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x100B684", Offset = "0x100B684", VA = "0x100B684")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x100B6D8", Offset = "0x100B6D8", VA = "0x100B6D8", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x100B92C", Offset = "0x100B92C", VA = "0x100B92C")]
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x100B994", Offset = "0x100B994", VA = "0x100B994", Slot = "10")]
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x100BA28", Offset = "0x100BA28", VA = "0x100BA28", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x100BFC8", Offset = "0x100BFC8", VA = "0x100BFC8", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x100C764", Offset = "0x100C764", VA = "0x100C764", Slot = "8")]
		public override void KillStart()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x100C7F4", Offset = "0x100C7F4", VA = "0x100C7F4", Slot = "9")]
		public override void KillEnd()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x100C7FC", Offset = "0x100C7FC", VA = "0x100C7FC", Slot = "5")]
		public override void Resurrect()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x100C868", Offset = "0x100C868", VA = "0x100C868", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x100C874", Offset = "0x100C874", VA = "0x100C874", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x100D044", Offset = "0x100D044", VA = "0x100D044", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x100D2EC", Offset = "0x100D2EC", VA = "0x100D2EC")]
		private bool SetKinematic()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x100D3A8", Offset = "0x100D3A8", VA = "0x100D3A8", Slot = "21")]
		protected override void OnReadBehaviour(float deltaTime)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x100D1A0", Offset = "0x100D1A0", VA = "0x100D1A0")]
		private void BlendMuscleMapping(int muscleIndex, ref bool to, float deltaTime)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x100DA0C", Offset = "0x100DA0C", VA = "0x100DA0C", Slot = "13")]
		public override void OnMuscleAdded(Muscle m)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x100DA44", Offset = "0x100DA44", VA = "0x100DA44", Slot = "14")]
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x100D7DC", Offset = "0x100D7DC", VA = "0x100D7DC")]
		protected void MoveTarget(Vector3 position)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x100DA74", Offset = "0x100DA74", VA = "0x100DA74")]
		protected void RotateTarget(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x100DAA8", Offset = "0x100DAA8", VA = "0x100DAA8", Slot = "30")]
		protected override void GroundTarget(LayerMask layers)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x100DAC0", Offset = "0x100DAC0", VA = "0x100DAC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x100DCAC", Offset = "0x100DCAC", VA = "0x100DCAC")]
		public void Boost(float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x100DD30", Offset = "0x100DD30", VA = "0x100DD30")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x100DE20", Offset = "0x100DE20", VA = "0x100DE20")]
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x100DFD4", Offset = "0x100DFD4", VA = "0x100DFD4")]
		public void BoostImmunity(float immunity)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x100DD70", Offset = "0x100DD70", VA = "0x100DD70")]
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x100E048", Offset = "0x100E048", VA = "0x100E048")]
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x100E0E0", Offset = "0x100E0E0", VA = "0x100E0E0")]
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x100DDCC", Offset = "0x100DDCC", VA = "0x100DDCC")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x100E14C", Offset = "0x100E14C", VA = "0x100E14C")]
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x100E1E4", Offset = "0x100E1E4", VA = "0x100E1E4")]
		public void Unpin()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x100E25C", Offset = "0x100E25C", VA = "0x100E25C", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x100E4C8", Offset = "0x100E4C8", VA = "0x100E4C8", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x100E940", Offset = "0x100E940", VA = "0x100E940")]
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x100E328", Offset = "0x100E328", VA = "0x100E328")]
		public void UnPin(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x100EBF4", Offset = "0x100EBF4", VA = "0x100EBF4")]
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x100EAB0", Offset = "0x100EAB0", VA = "0x100EAB0")]
		private bool Activate(Collision collision, float impulse)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x100EE10", Offset = "0x100EE10", VA = "0x100EE10")]
		public bool IsProne()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x100DF3C", Offset = "0x100DF3C", VA = "0x100DF3C")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x100EB3C", Offset = "0x100EB3C", VA = "0x100EB3C")]
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x100EEBC", Offset = "0x100EEBC", VA = "0x100EEBC")]
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x100CF58", Offset = "0x100CF58", VA = "0x100CF58")]
		private MuscleProps GetProps(Muscle.Group group)
		{
			return default(MuscleProps);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x100C05C", Offset = "0x100C05C", VA = "0x100C05C")]
		public void SetState(State newState)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x100F040", Offset = "0x100F040", VA = "0x100F040")]
		public void SetColliders(bool unpinned)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x100B788", Offset = "0x100B788", VA = "0x100B788")]
		public void SetColliders(Muscle m, bool unpinned)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x100F0BC", Offset = "0x100F0BC", VA = "0x100F0BC", Slot = "11")]
		public override void OnMuscleDisconnected(Muscle m)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x100F0EC", Offset = "0x100F0EC", VA = "0x100F0EC", Slot = "12")]
		public override void OnMuscleReconnected(Muscle m)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x100F184", Offset = "0x100F184", VA = "0x100F184")]
		public BehaviourPuppet()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourTemplate")]
	public class BehaviourTemplate : BehaviourBase
	{
		[Token(Token = "0x4000180")]
		private const string typeSpring = "BehaviourTemplate";

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SubBehaviourCOM centerOfMass;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuppetEvent onLoseBalance;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float loseBalanceAngle;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x100F45C", Offset = "0x100F45C", VA = "0x100F45C", Slot = "29")]
		protected override string GetTypeSpring()
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x100F49C", Offset = "0x100F49C", VA = "0x100F49C", Slot = "17")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x100F93C", Offset = "0x100F93C", VA = "0x100F93C", Slot = "15")]
		protected override void OnActivate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x100F940", Offset = "0x100F940", VA = "0x100F940", Slot = "4")]
		public override void OnReactivate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x100F944", Offset = "0x100F944", VA = "0x100F944", Slot = "16")]
		protected override void OnDeactivate()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x100F948", Offset = "0x100F948", VA = "0x100F948", Slot = "18")]
		protected override void OnFixedUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x100F988", Offset = "0x100F988", VA = "0x100F988", Slot = "20")]
		protected override void OnLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x100F98C", Offset = "0x100F98C", VA = "0x100F98C", Slot = "25")]
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x100F994", Offset = "0x100F994", VA = "0x100F994", Slot = "26")]
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x100F99C", Offset = "0x100F99C", VA = "0x100F99C")]
		public BehaviourTemplate()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class SubBehaviourBalancer : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		public class Settings
		{
			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Ankle joint damper / spring. Increase to make the balancing effect softer.")]
			public float damperForSpring;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier for joint max force.")]
			public float maxForceMlp;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Multiplier for the inertia tensor. Increasing this will increase the balancing forces.")]
			public float IMlp;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Velocity-based prediction.")]
			public float velocityF;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space offset for the center of pressure. Can be used to make the characer lean in a certain direction.")]
			public Vector3 copOffset;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The amount of torque applied to the lower legs to help keep the puppet balanced. Note that this is an external force (not coming from the joints themselves) and might make the simulation seem unnatural.")]
			public float torqueMlp;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Maximum magnitude of the torque applied to the lower legs if 'Torque Mlp' > 0.")]
			public float maxTorqueMag;

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x1010694", Offset = "0x1010694", VA = "0x1010694")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Settings settings;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform[] copPoints;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PressureSensor pressureSensor;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody Ibody;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 I;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion toJointSpace;

		[Token(Token = "0x17000015")]
		public ConfigurableJoint joint
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x100F9AC", Offset = "0x100F9AC", VA = "0x100F9AC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x100F9B4", Offset = "0x100F9B4", VA = "0x100F9B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 dir
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x100F9BC", Offset = "0x100F9BC", VA = "0x100F9BC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x100F9C8", Offset = "0x100F9C8", VA = "0x100F9C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Vector3 dirVel
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x100F9D4", Offset = "0x100F9D4", VA = "0x100F9D4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x100F9E0", Offset = "0x100F9E0", VA = "0x100F9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 cop
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x100F9EC", Offset = "0x100F9EC", VA = "0x100F9EC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x100F9F8", Offset = "0x100F9F8", VA = "0x100F9F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Vector3 com
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x100FA04", Offset = "0x100FA04", VA = "0x100FA04")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x100FA10", Offset = "0x100FA10", VA = "0x100FA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public Vector3 comV
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x100FA1C", Offset = "0x100FA1C", VA = "0x100FA1C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x100FA28", Offset = "0x100FA28", VA = "0x100FA28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x100FA34", Offset = "0x100FA34", VA = "0x100FA34")]
		public void Initiate(BehaviourBase behaviour, Settings settings, Rigidbody Ibody, Rigidbody[] rigidbodies, ConfigurableJoint joint, Transform[] copPoints, PressureSensor pressureSensor)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x100FC64", Offset = "0x100FC64", VA = "0x100FC64")]
		private void Solve(float deltaTime)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x10105B8", Offset = "0x10105B8", VA = "0x10105B8")]
		public SubBehaviourBalancer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public abstract class SubBehaviourBase
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected BehaviourBase behaviour;

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x10106B0", Offset = "0x10106B0", VA = "0x10106B0")]
		protected static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x10106B8", Offset = "0x10106B8", VA = "0x10106B8")]
		protected static Vector3 XYZ(Vector2 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x10106C4", Offset = "0x10106C4", VA = "0x10106C4")]
		protected static Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x10106CC", Offset = "0x10106CC", VA = "0x10106CC")]
		protected static Vector3 SetY(Vector3 v, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x101068C", Offset = "0x101068C", VA = "0x101068C")]
		protected SubBehaviourBase()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class SubBehaviourCOM : SubBehaviourBase
	{
		[Serializable]
		[Token(Token = "0x2000040")]
		public enum Mode
		{
			[Token(Token = "0x40001AD")]
			FeetCentroid,
			[Token(Token = "0x40001AE")]
			CenterOfPressure
		}

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode mode;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float velocityDamper;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float velocityLerpSpeed;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float velocityMax;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centerOfPressureSpeed;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public bool[] groundContacts;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3[] groundContactPoints;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private LayerMask groundLayers;

		[Token(Token = "0x1700001B")]
		public Vector3 position
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x10106D4", Offset = "0x10106D4", VA = "0x10106D4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x10106E0", Offset = "0x10106E0", VA = "0x10106E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public Vector3 direction
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x10106EC", Offset = "0x10106EC", VA = "0x10106EC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x10106F8", Offset = "0x10106F8", VA = "0x10106F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public float angle
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1010704", Offset = "0x1010704", VA = "0x1010704")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x101070C", Offset = "0x101070C", VA = "0x101070C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public Vector3 velocity
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1010714", Offset = "0x1010714", VA = "0x1010714")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x1010720", Offset = "0x1010720", VA = "0x1010720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public Vector3 centerOfPressure
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x101072C", Offset = "0x101072C", VA = "0x101072C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x1010738", Offset = "0x1010738", VA = "0x1010738")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Quaternion rotation
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x1010744", Offset = "0x1010744", VA = "0x1010744")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x1010750", Offset = "0x1010750", VA = "0x1010750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public Quaternion inverseRotation
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x101075C", Offset = "0x101075C", VA = "0x101075C")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1010768", Offset = "0x1010768", VA = "0x1010768")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isGrounded
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x1010774", Offset = "0x1010774", VA = "0x1010774")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x101077C", Offset = "0x101077C", VA = "0x101077C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public float lastGroundedTime
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x1010788", Offset = "0x1010788", VA = "0x1010788")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x1010790", Offset = "0x1010790", VA = "0x1010790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x100F4BC", Offset = "0x100F4BC", VA = "0x100F4BC")]
		public void Initiate(BehaviourBase behaviour, LayerMask groundLayers)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1010798", Offset = "0x1010798", VA = "0x1010798")]
		private void OnHierarchyChanged()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x101083C", Offset = "0x101083C", VA = "0x101083C")]
		private void OnPreMuscleCollision(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1010A1C", Offset = "0x1010A1C", VA = "0x1010A1C")]
		private void OnPreMuscleCollisionExit(MuscleCollision c)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1010AF8", Offset = "0x1010AF8", VA = "0x1010AF8")]
		private void OnPreActivate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1010ED8", Offset = "0x1010ED8", VA = "0x1010ED8")]
		private void OnPreLateUpdate(float deltaTime)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x10114E0", Offset = "0x10114E0", VA = "0x10114E0")]
		private void OnPreDeactivate()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1010920", Offset = "0x1010920", VA = "0x1010920")]
		private Vector3 GetCollisionCOP(Collision collision)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1011204", Offset = "0x1011204", VA = "0x1011204")]
		private bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1010CAC", Offset = "0x1010CAC", VA = "0x1010CAC")]
		private Vector3 GetCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1011348", Offset = "0x1011348", VA = "0x1011348")]
		private Vector3 GetCenterOfMassVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1011538", Offset = "0x1011538", VA = "0x1011538")]
		private Vector3 GetMomentum()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x101125C", Offset = "0x101125C", VA = "0x101125C")]
		private Vector3 GetCenterOfPressure()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1010DE0", Offset = "0x1010DE0", VA = "0x1010DE0")]
		private Vector3 GetFeetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x101166C", Offset = "0x101166C", VA = "0x101166C")]
		public SubBehaviourCOM()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class Booster
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("If true, all the muscles will be boosted and the 'Muscles' and 'Groups' properties below will be ignored.")]
		public bool fullBody;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Muscles to boost. Used only when 'Full Body' is false.")]
		public ConfigurableJoint[] muscles;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Muscle groups to boost. Used only when 'Full Body' is false.")]
		public Muscle.Group[] groups;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Immunity to apply to the muscles. If muscle immunity is 1, it can not be damaged.")]
		[Range(0f, 1f)]
		public float immunity;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Impulse multiplier to be applied to the muscles. This makes them deal more damage to other puppets.")]
		public float impulseMlp;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Falloff for parent muscles (power of kinship degree).")]
		public float boostParents;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Falloff for child muscles (power of kinship degree).")]
		public float boostChildren;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("This does nothing on it's own, you can use it in a 'yield return new WaitForseconds(delay);' call.")]
		public float delay;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1011680", Offset = "0x1011680", VA = "0x1011680")]
		public void Boost(BehaviourPuppet puppet)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1011874", Offset = "0x1011874", VA = "0x1011874")]
		public Booster()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class JointBreakBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1011910", Offset = "0x1011910", VA = "0x1011910")]
		private void OnJointBreak()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x101269C", Offset = "0x101269C", VA = "0x101269C")]
		public JointBreakBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class Muscle
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		public enum Group
		{
			[Token(Token = "0x4000206")]
			Hips,
			[Token(Token = "0x4000207")]
			Spine,
			[Token(Token = "0x4000208")]
			Head,
			[Token(Token = "0x4000209")]
			Arm,
			[Token(Token = "0x400020A")]
			Hand,
			[Token(Token = "0x400020B")]
			Leg,
			[Token(Token = "0x400020C")]
			Foot,
			[Token(Token = "0x400020D")]
			Tail,
			[Token(Token = "0x400020E")]
			Prop
		}

		[Serializable]
		[Token(Token = "0x2000045")]
		public class InternalCollisionIgnoreSettings
		{
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If true, internal collisions between this muscle and all other muscles will be ingored.")]
			public bool ignoreAll;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Ignore internal collisions with all muscles in this array.")]
			public ConfigurableJoint[] muscles;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Ignore internal collisions with all these groups.")]
			public Group[] groups;

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x10177F4", Offset = "0x10177F4", VA = "0x10177F4")]
			public InternalCollisionIgnoreSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000046")]
		public class Props
		{
			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Which body part does this muscle belong to?")]
			public Group group;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of mapping this muscle's target to the muscle.")]
			public float mappingWeight;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			[Tooltip("The weight (multiplier) of pinning this muscle to it's target's position using a simple AddForce command.")]
			public float pinWeight;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The muscle strength (multiplier).")]
			[Range(0f, 1f)]
			public float muscleWeight;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplier of the positionDamper of the ConfigurableJoints' Slerp Drive.")]
			[Range(0f, 1f)]
			public float muscleDamper;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Defines which muscles or muscle groups internal collisions are always ignored with.")]
			public InternalCollisionIgnoreSettings internalCollisionIgnores;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("List of animated bones parented to this muscle's Target, except for the bones that are targets or target children of any child muscles. This is used for stopping animation on those bones when the muscle has been disconnected using PuppetMaster.DisconnectMuscleRecursive().For example if you disconnected the spine02 muscle, you would want to have spine03 and clavicles in this list to stop them from animating.")]
			public Transform[] animatedTargetChildren;

			[Token(Token = "0x17000036")]
			public bool mapPosition
			{
				[Token(Token = "0x6000241")]
				[Address(RVA = "0x1017890", Offset = "0x1017890", VA = "0x1017890")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000242")]
				[Address(RVA = "0x1017898", Offset = "0x1017898", VA = "0x1017898")]
				set
				{
				}
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1017734", Offset = "0x1017734", VA = "0x1017734")]
			public Props()
			{
			}

			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1017900", Offset = "0x1017900", VA = "0x1017900")]
			public Props(float pinWeight, float muscleWeight, float mappingWeight, float muscleDamper, Group group = Group.Hips)
			{
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x1015E54", Offset = "0x1015E54", VA = "0x1015E54")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000047")]
		public struct State
		{
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float mappingWeightMlp;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float pinWeightMlp;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float muscleWeightMlp;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxForceMlp;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float muscleDamperMlp;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float muscleDamperAdd;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float immunity;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float impulseMlp;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 velocity;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 angularVelocity;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isDisconnected;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool resetFlag;

			[Token(Token = "0x17000037")]
			public static State Default
			{
				[Token(Token = "0x6000246")]
				[Address(RVA = "0x1012B14", Offset = "0x1012B14", VA = "0x1012B14")]
				get
				{
					return default(State);
				}
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x1015EA4", Offset = "0x1015EA4", VA = "0x1015EA4")]
			public void Clamp()
			{
			}
		}

		[Token(Token = "0x2000048")]
		public class TargetChild
		{
			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1014850", Offset = "0x1014850", VA = "0x1014850")]
			public TargetChild(Transform t)
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1016D4C", Offset = "0x1016D4C", VA = "0x1016D4C")]
			public void Map()
			{
			}
		}

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Props props;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public State state;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public int[] parentIndexes;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public int[] childIndexes;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public bool[] childFlags;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public int[] kinshipDegrees;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public MuscleCollisionBroadcaster broadcaster;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public JointBreakBroadcaster jointBreakBroadcaster;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector3 positionOffset;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public Transform additionalPinTarget;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public float additionalPinWeight;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[HideInInspector]
		public Vector3 mappedVelocity;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[HideInInspector]
		public Vector3 mappedAngularVelocity;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[HideInInspector]
		public bool isPropMuscle;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[HideInInspector]
		public int index;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Transform rebuildParent;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Vector3 rebuildPosition;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private Quaternion rebuildRotation;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 rebuildTargetPosition;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion rebuildTargetRotation;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ConfigurableJointMotion rebuildAngularXMotion;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private ConfigurableJointMotion rebuildAngularYMotion;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private ConfigurableJointMotion rebuildAngularZMotion;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[HideInInspector]
		public Vector3 targetMappedPosition;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		public Quaternion targetMappedRotation;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		public Vector3 targetSampledPosition;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		[HideInInspector]
		public Quaternion targetSampledRotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private JointDrive slerpDrive;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private float lastRotationDamper;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Vector3 lastMappedPosition;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private Quaternion toParentSpace;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2AC")]
		private Quaternion rotationRelativeToTarget;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
		private Quaternion lastMappedRotation;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private Transform targetParent;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private ConfigurableJointMotion angularXMotionDefault;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private ConfigurableJointMotion angularYMotionDefault;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private ConfigurableJointMotion angularZMotionDefault;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private bool directTargetParent;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FD")]
		private bool initiated;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Collider[] _colliders;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private float lastReadTime;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float lastWriteTime;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private bool[] disabledColliders;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private TargetChild[] targetChildren;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private Vector3 additionalTargetVelocity;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private Vector3 additionalPinTargetAnimatedCenterOfMass;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x344")]
		private Quaternion defaultTargetRotRelToMuscleInverse;

		[Token(Token = "0x17000024")]
		public Transform transform
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x10126A4", Offset = "0x10126A4", VA = "0x10126A4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x10126AC", Offset = "0x10126AC", VA = "0x10126AC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x10126B4", Offset = "0x10126B4", VA = "0x10126B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x10126BC", Offset = "0x10126BC", VA = "0x10126BC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public Transform connectedBodyTarget
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x10126C4", Offset = "0x10126C4", VA = "0x10126C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x10126CC", Offset = "0x10126CC", VA = "0x10126CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Vector3 targetAnimatedPosition
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x10126D4", Offset = "0x10126D4", VA = "0x10126D4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x10126E0", Offset = "0x10126E0", VA = "0x10126E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Quaternion targetAnimatedWorldRotation
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x10126EC", Offset = "0x10126EC", VA = "0x10126EC")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x10126F8", Offset = "0x10126F8", VA = "0x10126F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Collider[] colliders
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x1012704", Offset = "0x1012704", VA = "0x1012704")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x101270C", Offset = "0x101270C", VA = "0x101270C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Vector3 targetVelocity
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x101271C", Offset = "0x101271C", VA = "0x101271C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x1012728", Offset = "0x1012728", VA = "0x1012728")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Rigidbody additionalRigidbody
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x1012734", Offset = "0x1012734", VA = "0x1012734")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x101273C", Offset = "0x101273C", VA = "0x101273C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public Quaternion targetRotationRelative
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1012744", Offset = "0x1012744", VA = "0x1012744")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x1012758", Offset = "0x1012758", VA = "0x1012758")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Rigidbody rebuildConnectedBody
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1012944", Offset = "0x1012944", VA = "0x1012944")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x101294C", Offset = "0x101294C", VA = "0x101294C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public Transform rebuildTargetParent
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x101295C", Offset = "0x101295C", VA = "0x101295C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1012964", Offset = "0x1012964", VA = "0x1012964")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public Vector3 defaultTargetPosRelToMuscle
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1012974", Offset = "0x1012974", VA = "0x1012974")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1012984", Offset = "0x1012984", VA = "0x1012984")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public Quaternion defaultTargetRotRelToMuscle
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1012994", Offset = "0x1012994", VA = "0x1012994")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x10129A8", Offset = "0x10129A8", VA = "0x10129A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public Quaternion defaultMuscleRotRelToTarget
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x10129BC", Offset = "0x10129BC", VA = "0x10129BC")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x10129D0", Offset = "0x10129D0", VA = "0x10129D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x10141A8", Offset = "0x10141A8", VA = "0x10141A8")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000033")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1014320", Offset = "0x1014320", VA = "0x1014320")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000034")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1014268", Offset = "0x1014268", VA = "0x1014268")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000035")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x1014454", Offset = "0x1014454", VA = "0x1014454")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x101276C", Offset = "0x101276C", VA = "0x101276C")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x10129E4", Offset = "0x10129E4", VA = "0x10129E4")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1012B34", Offset = "0x1012B34", VA = "0x1012B34", Slot = "4")]
		public virtual void Initiate(Muscle[] colleagues)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1013EC8", Offset = "0x1013EC8", VA = "0x1013EC8")]
		public void InitiateAdditionalPin()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x101404C", Offset = "0x101404C", VA = "0x101404C")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1014C44", Offset = "0x1014C44", VA = "0x1014C44")]
		public void DisableColliders()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1014D38", Offset = "0x1014D38", VA = "0x1014D38")]
		public void EnableColliders()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x10148F0", Offset = "0x10148F0", VA = "0x10148F0")]
		private void AddColliders(Transform t, ref Collider[] C, bool includeMeshColliders)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1014B48", Offset = "0x1014B48", VA = "0x1014B48")]
		private void AddCompoundColliders(Transform t, ref Collider[] colliders)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1014DD8", Offset = "0x1014DD8", VA = "0x1014DD8")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1014F88", Offset = "0x1014F88", VA = "0x1014F88")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1015168", Offset = "0x1015168", VA = "0x1015168")]
		private bool ForceIgnore(Muscle otherMuscle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x10153AC", Offset = "0x10153AC", VA = "0x10153AC")]
		public void IgnoreAngularLimits(bool ignore)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1015448", Offset = "0x1015448", VA = "0x1015448")]
		public void ResetTargetLocalPosition()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1015474", Offset = "0x1015474", VA = "0x1015474")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10154D0", Offset = "0x10154D0", VA = "0x10154D0")]
		public void Reset()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10156D4", Offset = "0x10156D4", VA = "0x10156D4")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x100E410", Offset = "0x100E410", VA = "0x100E410")]
		public void SetKinematic(bool to)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1014594", Offset = "0x1014594", VA = "0x1014594")]
		public void Read()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x10158E0", Offset = "0x10158E0", VA = "0x10158E0")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1015A90", Offset = "0x1015A90", VA = "0x1015A90")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1015D38", Offset = "0x1015D38", VA = "0x1015D38", Slot = "5")]
		public virtual void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, float pinPow, float pinDistanceFalloff, bool rotationTargetChanged, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1016460", Offset = "0x1016460", VA = "0x1016460")]
		public void StoreTargetMappedPosition()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1016490", Offset = "0x1016490", VA = "0x1016490")]
		public void StoreTargetMappedRotation()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10164C4", Offset = "0x10164C4", VA = "0x10164C4")]
		public void Map(float mappingWeightMaster)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1016898", Offset = "0x1016898", VA = "0x1016898")]
		public void CalculateMappedVelocity()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1016C08", Offset = "0x1016C08", VA = "0x1016C08")]
		public void MapDisconnected()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1015EF8", Offset = "0x1015EF8", VA = "0x1015EF8")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning, float deltaTime)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1016D8C", Offset = "0x1016D8C", VA = "0x1016D8C")]
		private void Pin(Rigidbody r, Vector3 posOffset, Vector3 targetVel, float w, float pinDistanceFalloff, float deltaTime)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x10162B4", Offset = "0x10162B4", VA = "0x10162B4")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x101738C", Offset = "0x101738C", VA = "0x101738C")]
		public void SetMuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1017264", Offset = "0x1017264", VA = "0x1017264")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1015CD8", Offset = "0x1015CD8", VA = "0x1015CD8")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x10174E4", Offset = "0x10174E4", VA = "0x10174E4")]
		public Muscle()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public struct MuscleCollision
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collision collision;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isStay;

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10179E4", Offset = "0x10179E4", VA = "0x10179E4")]
		public MuscleCollision(int muscleIndex, Collision collision, bool isStay = false)
		{
		}
	}
	[Token(Token = "0x200004A")]
	public struct MuscleHit
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int muscleIndex;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float unPin;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3 force;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 position;

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1017A14", Offset = "0x1017A14", VA = "0x1017A14")]
		public MuscleHit(int muscleIndex, float unPin, Vector3 force, Vector3 position)
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Muscle Collision Broadcaster")]
	public class MuscleCollisionBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public int muscleIndex;

		[Token(Token = "0x4000231")]
		private const string onMuscleHit = "OnMuscleHit";

		[Token(Token = "0x4000232")]
		private const string onMuscleCollision = "OnMuscleCollision";

		[Token(Token = "0x4000233")]
		private const string onMuscleCollisionExit = "OnMuscleCollisionExit";

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MuscleCollisionBroadcaster otherBroadcaster;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1017A2C", Offset = "0x1017A2C", VA = "0x1017A2C")]
		public void Hit(float unPin, Vector3 force, Vector3 position)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1017B04", Offset = "0x1017B04", VA = "0x1017B04")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1017CC8", Offset = "0x1017CC8", VA = "0x1017CC8")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1017F38", Offset = "0x1017F38", VA = "0x1017F38")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10181A4", Offset = "0x10181A4", VA = "0x10181A4")]
		public MuscleCollisionBroadcaster()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public static class PhysXTools
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10181AC", Offset = "0x10181AC", VA = "0x10181AC")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1018244", Offset = "0x1018244", VA = "0x1018244")]
		public static void Predict(Rigidbody r, int steps, out Vector3 position, out Quaternion rotation, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1018340", Offset = "0x1018340", VA = "0x1018340")]
		public static void Predict(ref Vector3 position, ref Quaternion rotation, ref Vector3 velocity, ref Vector3 angularVelocity, Vector3 gravity, float drag, float angularDrag)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1018534", Offset = "0x1018534", VA = "0x1018534")]
		public static Vector3 GetCenterOfMass(PuppetMaster puppet)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1010170", Offset = "0x1010170", VA = "0x1010170")]
		public static Vector3 GetCenterOfMass(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10102CC", Offset = "0x10102CC", VA = "0x10102CC")]
		public static Vector3 GetCenterOfMassVelocity(Rigidbody[] rigidbodies)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x10186D4", Offset = "0x10186D4", VA = "0x10186D4")]
		public static void DivByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1010528", Offset = "0x1010528", VA = "0x1010528")]
		public static void ScaleByInertia(ref Vector3 v, Quaternion rotation, Vector3 inertiaTensor)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10169C0", Offset = "0x10169C0", VA = "0x10169C0")]
		public static Vector3 GetAngularVelocity(Quaternion lastRotation, Quaternion rotation, float deltaTime)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1010428", Offset = "0x1010428", VA = "0x1010428")]
		public static Vector3 GetFromToAcceleration(Vector3 fromV, Vector3 toV)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1016ECC", Offset = "0x1016ECC", VA = "0x1016ECC")]
		public static Vector3 GetAngularAcceleration(Quaternion fromR, Quaternion toR)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1018774", Offset = "0x1018774", VA = "0x1018774")]
		public static void AddFromToTorque(Rigidbody r, Quaternion toR, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1018944", Offset = "0x1018944", VA = "0x1018944")]
		public static void AddFromToTorque(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1018AEC", Offset = "0x1018AEC", VA = "0x1018AEC")]
		public static void AddFromToForce(Rigidbody r, Vector3 fromV, Vector3 toV, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1018C48", Offset = "0x1018C48", VA = "0x1018C48")]
		public static Vector3 GetLinearAcceleration(Vector3 fromPoint, Vector3 toPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x100FBB8", Offset = "0x100FBB8", VA = "0x100FBB8")]
		public static Quaternion ToJointSpace(ConfigurableJoint joint)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1014174", Offset = "0x1014174", VA = "0x1014174")]
		public static Vector3 CalculateInertiaTensorCuboid(Vector3 size, float mass)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1018764", Offset = "0x1018764", VA = "0x1018764")]
		public static Vector3 Div(Vector3 v, Vector3 v2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1018C88", Offset = "0x1018C88", VA = "0x1018C88")]
		public static bool RayCapsuleIntersectUnscaled(Vector3 origin, Vector3 direction, CapsuleCollider capsule)
		{
			return default(bool);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1018FC8", Offset = "0x1018FC8", VA = "0x1018FC8")]
		public static bool RayCapsuleIntersect(Vector3 origin, Vector3 direction, CapsuleCollider capsule, float uniformScale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1018DC4", Offset = "0x1018DC4", VA = "0x1018DC4")]
		public static bool RayCapsuleIntersect(Vector3 origin, Vector3 direction, Vector3 capsuleTransformPos, Quaternion capsuleTransformRot, Vector3 capsuleCenter, float capsuleRadius, float capsuleHeight, int capsuleDir, float scale)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x101910C", Offset = "0x101910C", VA = "0x101910C")]
		public static bool RayCapsuleIntersect(Vector3 rayOrigin, Vector3 rayDir, Vector3 c1, Vector3 c2, float cRadius)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004D")]
	public class PressureSensor : MonoBehaviour
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool visualize;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layers;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool fixedFrame;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 P;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int count;

		[Token(Token = "0x17000038")]
		public Vector3 center
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x101927C", Offset = "0x101927C", VA = "0x101927C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1019288", Offset = "0x1019288", VA = "0x1019288")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool inContact
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1019294", Offset = "0x1019294", VA = "0x1019294")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x101929C", Offset = "0x101929C", VA = "0x101929C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public Vector3 bottom
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x10192A8", Offset = "0x10192A8", VA = "0x10192A8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x10192B4", Offset = "0x10192B4", VA = "0x10192B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Rigidbody r
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x10192C0", Offset = "0x10192C0", VA = "0x10192C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x10192C8", Offset = "0x10192C8", VA = "0x10192C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10192D0", Offset = "0x10192D0", VA = "0x10192D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1019350", Offset = "0x1019350", VA = "0x1019350")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x10194A4", Offset = "0x10194A4", VA = "0x10194A4")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10194A8", Offset = "0x10194A8", VA = "0x10194A8")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10194B0", Offset = "0x10194B0", VA = "0x10194B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1019528", Offset = "0x1019528", VA = "0x1019528")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1019354", Offset = "0x1019354", VA = "0x1019354")]
		private void ProcessCollision(Collision c)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1019564", Offset = "0x1019564", VA = "0x1019564")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1019588", Offset = "0x1019588", VA = "0x1019588")]
		public PressureSensor()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public abstract class Prop : MonoBehaviour
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("This has no other purpose but helping you distinguish props by PropRoot.currentProp.propType.")]
		public int propType;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Muscle of this prop.")]
		[LargeHeader("Muscle")]
		public ConfigurableJoint muscle;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The muscle properties that will be applied to the Muscle on pickup.")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true, this prop's layer will be forced to PuppetMaster layer and target's layer forced to PuppetMaster's Target Root's layer when the prop is picked up.")]
		public bool forceLayers;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Optinal additional pin, useful for long melee weapons that would otherwise require a lot of muscle force and solver iterations to be swinged quickly. Should normally be without any colliders attached. The position of the pin, it's mass and the pin weight will effect how the prop will handle.")]
		[LargeHeader("Additional Pin")]
		public ConfigurableJoint additionalPin;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Target Transform for the additional pin.")]
		public Transform additionalPinTarget;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The pin weight of the additional pin. Increasing this weight will make the prop follow animation better, but will increase jitter when colliding with objects.")]
		public float additionalPinWeight;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[LargeHeader("Materials")]
		[Tooltip("If assigned, sets prop colliders to this PhysicMaterial when picked up.")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("If assigned, sets prop colliders to this PhysicMaterial when dropped.")]
		public PhysicMaterial droppedMaterial;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ConfigurableJointMotion xMotion;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ConfigurableJointMotion yMotion;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ConfigurableJointMotion zMotion;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJointMotion angularXMotion;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private ConfigurableJointMotion angularYMotion;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ConfigurableJointMotion angularZMotion;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] colliders;

		[Token(Token = "0x1700003C")]
		public bool isPickedUp
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1019590", Offset = "0x1019590", VA = "0x1019590")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public PropRoot propRoot
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x10195F0", Offset = "0x10195F0", VA = "0x10195F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x10195F8", Offset = "0x10195F8", VA = "0x10195F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool initiated
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x10198A8", Offset = "0x10198A8", VA = "0x10198A8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x10198B0", Offset = "0x10198B0", VA = "0x10198B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1019600", Offset = "0x1019600", VA = "0x1019600")]
		public void PickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x101986C", Offset = "0x101986C", VA = "0x101986C")]
		public void Drop()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x10198A0", Offset = "0x10198A0", VA = "0x10198A0")]
		public void StartPickedUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x10198BC", Offset = "0x10198BC", VA = "0x10198BC", Slot = "4")]
		protected virtual void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10198C0", Offset = "0x10198C0", VA = "0x10198C0", Slot = "5")]
		protected virtual void OnDrop()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x10198C4", Offset = "0x10198C4", VA = "0x10198C4", Slot = "6")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10198C8", Offset = "0x10198C8", VA = "0x10198C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1019B14", Offset = "0x1019B14", VA = "0x1019B14")]
		private void ReleaseJoint()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x10197AC", Offset = "0x10197AC", VA = "0x10197AC")]
		private void SetMaterial(PhysicMaterial material)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1019C48", Offset = "0x1019C48", VA = "0x1019C48")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1019DD0", Offset = "0x1019DD0", VA = "0x1019DD0")]
		protected Prop()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class PropMuscle : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		public delegate void PropDelegate(PuppetMasterProp prop);

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The PuppetMasterProp currently held by this Prop Muscle. To pick up a prop, just assign it as propMuscle.currentProp. To drop, set propMuscle.currentProp to null. Replacing this value with another prop drops any previously held props.")]
		public PuppetMasterProp currentProp;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Additional Pin")]
		[Tooltip("Offset of the additional pin from this Prop Muscle in local space.")]
		public Vector3 additionalPinOffset;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropDelegate OnPickUpProp;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PropDelegate OnDropProp;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Muscle _muscle;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PuppetMasterProp lastProp;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastAdditionalPinOffset;

		[Token(Token = "0x1700003F")]
		public Muscle muscle
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1019E80", Offset = "0x1019E80", VA = "0x1019E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public PuppetMasterProp activeProp
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1019F4C", Offset = "0x1019F4C", VA = "0x1019F4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1019F54", Offset = "0x1019F54", VA = "0x1019F54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1019F5C", Offset = "0x1019F5C", VA = "0x1019F5C")]
		public bool AddAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x101A400", Offset = "0x101A400", VA = "0x101A400")]
		public bool RemoveAdditionalPin()
		{
			return default(bool);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x101A590", Offset = "0x101A590", VA = "0x101A590")]
		public void OnInitiate()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x101A7BC", Offset = "0x101A7BC", VA = "0x101A7BC")]
		public void TakeOver()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x101A828", Offset = "0x101A828", VA = "0x101A828")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x101B040", Offset = "0x101B040", VA = "0x101B040")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x101B2D8", Offset = "0x101B2D8", VA = "0x101B2D8")]
		public PropMuscle()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Root")]
	public class PropRoot : MonoBehaviour
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If a prop is connected, what will it's joint be connected to?")]
		public Rigidbody connectTo;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Is there a Prop connected to this PropRoot? Simply assign this value to connect, replace or drop props.")]
		public Prop currentProp;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Prop lastProp;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool fixedUpdateCalled;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x101B480", Offset = "0x101B480", VA = "0x101B480")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x101B4C4", Offset = "0x101B4C4", VA = "0x101B4C4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x101B508", Offset = "0x101B508", VA = "0x101B508")]
		public void DropImmediate()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x101B5DC", Offset = "0x101B5DC", VA = "0x101B5DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x101B6CC", Offset = "0x101B6CC", VA = "0x101B6CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x101B7F4", Offset = "0x101B7F4", VA = "0x101B7F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x101B9DC", Offset = "0x101B9DC", VA = "0x101B9DC")]
		private void AttachProp(Prop prop)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x101C5E8", Offset = "0x101C5E8", VA = "0x101C5E8")]
		public PropRoot()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page6.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Prop Template")]
	public class PropTemplate : Prop
	{
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x101C5F0", Offset = "0x101C5F0", VA = "0x101C5F0", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x101C5F4", Offset = "0x101C5F4", VA = "0x101C5F4", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x101C5F8", Offset = "0x101C5F8", VA = "0x101C5F8", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x101C5FC", Offset = "0x101C5FC", VA = "0x101C5FC")]
		public PropTemplate()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Puppet Master")]
	[HelpURL("https://www.youtube.com/watch?v=LYusqeqHAUc")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000054")]
		public enum Mode
		{
			[Token(Token = "0x40002B4")]
			Active,
			[Token(Token = "0x40002B5")]
			Kinematic,
			[Token(Token = "0x40002B6")]
			Disabled
		}

		[Token(Token = "0x2000055")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000056")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x2000057")]
		public enum UpdateMode
		{
			[Token(Token = "0x40002B8")]
			Normal,
			[Token(Token = "0x40002B9")]
			AnimatePhysics,
			[Token(Token = "0x40002BA")]
			FixedUpdate
		}

		[Serializable]
		[Token(Token = "0x2000058")]
		public enum State
		{
			[Token(Token = "0x40002BC")]
			Alive,
			[Token(Token = "0x40002BD")]
			Dead,
			[Token(Token = "0x40002BE")]
			Frozen
		}

		[Serializable]
		[Token(Token = "0x2000059")]
		public struct StateSettings
		{
			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("How much does it take to weigh out muscle weight to deadMuscleWeight?")]
			public float killDuration;

			[Token(Token = "0x40002C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Tooltip("The muscle weight mlp while the puppet is Dead.")]
			public float deadMuscleWeight;

			[Token(Token = "0x40002C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("The muscle damper add while the puppet is Dead.")]
			public float deadMuscleDamper;

			[Token(Token = "0x40002C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Tooltip("The max square velocity of the ragdoll bones for freezing the puppet.")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x40002C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If true, PuppetMaster, all it's behaviours and the ragdoll will be destroyed when the puppet is frozen.")]
			public bool freezePermanently;

			[Token(Token = "0x40002C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Tooltip("If true, will enable angular limits when killing the puppet.")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[Tooltip("If true, will enable internal collisions when killing the puppet.")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000050")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000345")]
				[Address(RVA = "0x10448AC", Offset = "0x10448AC", VA = "0x10448AC")]
				get
				{
					return default(StateSettings);
				}
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1044888", Offset = "0x1044888", VA = "0x1044888")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class <DisabledToActive>d__174 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000349")]
				[Address(RVA = "0x1044B44", Offset = "0x1044B44", VA = "0x1044B44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600034B")]
				[Address(RVA = "0x1044B8C", Offset = "0x1044B8C", VA = "0x1044B8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x10448D0", Offset = "0x10448D0", VA = "0x10448D0")]
			[DebuggerHidden]
			public <DisabledToActive>d__174(int <>1__state)
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x10448F8", Offset = "0x10448F8", VA = "0x10448F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x10448FC", Offset = "0x10448FC", VA = "0x10448FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x1044B4C", Offset = "0x1044B4C", VA = "0x1044B4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class <KinematicToActive>d__176 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000053")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600034F")]
				[Address(RVA = "0x1044D90", Offset = "0x1044D90", VA = "0x1044D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000054")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x1044DD8", Offset = "0x1044DD8", VA = "0x1044DD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1044B94", Offset = "0x1044B94", VA = "0x1044B94")]
			[DebuggerHidden]
			public <KinematicToActive>d__176(int <>1__state)
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1044BBC", Offset = "0x1044BBC", VA = "0x1044BBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1044BC0", Offset = "0x1044BC0", VA = "0x1044BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1044D98", Offset = "0x1044D98", VA = "0x1044D98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class <ActiveToDisabled>d__177 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x1044F38", Offset = "0x1044F38", VA = "0x1044F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x1044F80", Offset = "0x1044F80", VA = "0x1044F80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1044DE0", Offset = "0x1044DE0", VA = "0x1044DE0")]
			[DebuggerHidden]
			public <ActiveToDisabled>d__177(int <>1__state)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1044E08", Offset = "0x1044E08", VA = "0x1044E08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1044E0C", Offset = "0x1044E0C", VA = "0x1044E0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1044F40", Offset = "0x1044F40", VA = "0x1044F40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class <ActiveToKinematic>d__178 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x1045118", Offset = "0x1045118", VA = "0x1045118", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x1045160", Offset = "0x1045160", VA = "0x1045160", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1044F88", Offset = "0x1044F88", VA = "0x1044F88")]
			[DebuggerHidden]
			public <ActiveToKinematic>d__178(int <>1__state)
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1044FB0", Offset = "0x1044FB0", VA = "0x1044FB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1044FB4", Offset = "0x1044FB4", VA = "0x1044FB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1045120", Offset = "0x1045120", VA = "0x1045120", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class <AliveToDead>d__229 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster <>4__this;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <range>5__2;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <mW>5__3;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x10454B8", Offset = "0x10454B8", VA = "0x10454B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x1045500", Offset = "0x1045500", VA = "0x1045500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x1045168", Offset = "0x1045168", VA = "0x1045168")]
			[DebuggerHidden]
			public <AliveToDead>d__229(int <>1__state)
			{
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1045190", Offset = "0x1045190", VA = "0x1045190", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1045194", Offset = "0x1045194", VA = "0x1045194", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x10454C0", Offset = "0x10454C0", VA = "0x10454C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Humanoid Config allows you to easily share PuppetMaster properties, including individual muscle props between Humanoid puppets.")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Simulation")]
		[Tooltip("Sets/sets the state of the puppet (Alive, Dead or Frozen). Frozen means the ragdoll will be deactivated once it comes to stop in dead state.")]
		public State state;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		[ContextMenuItem("Reset To Default", "ResetStateSettings")]
		public StateSettings stateSettings;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Active mode means all muscles are active and the character is physically simulated. Kinematic mode sets rigidbody.isKinematic to true for all the muscles and simply updates their position/rotation to match the target's. Disabled mode disables the ragdoll. Switching modes is done by simply changing this value, blending in/out will be handled automatically by the PuppetMaster.")]
		public Mode mode;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The time of blending when switching from Active to Kinematic/Disabled or from Kinematic/Disabled to Active. Switching from Kinematic to Disabled or vice versa will be done instantly.")]
		public float blendTime;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("If true, will fix the target character's Transforms to their default local positions and rotations in each update cycle to avoid drifting from additive reading-writing. Use this only if the target contains unanimated bones.")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Rigidbody.solverIterationCount for the muscles of this Puppet.")]
		public int solverIterationCount;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If true, will draw the target's pose as green lines in the Scene view. This runs in the Editor only. If you wish to profile PuppetMaster, switch this off.")]
		public bool visualizeTargetPose;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		[LargeHeader("Master Weights")]
		[Tooltip("The weight of mapping the animated character to the ragdoll pose.")]
		public float mappingWeight;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of pinning the muscles to the position of their animated targets using simple AddForce.")]
		[Range(0f, 1f)]
		public float pinWeight;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The normalized strength of the muscles.")]
		[Range(0f, 1f)]
		public float muscleWeight;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The positionSpring of the ConfigurableJoints' Slerp Drive.")]
		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("The positionDamper of the ConfigurableJoints' Slerp Drive.")]
		public float muscleDamper;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Adjusts the slope of the pinWeight curve. Has effect only while interpolating pinWeight from 0 to 1 and back.")]
		[Range(1f, 8f)]
		public float pinPow;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Reduces pinning force the farther away the target is. Bigger value loosens the pinning, resulting in sloppier behaviour.")]
		[Range(0f, 100f)]
		public float pinDistanceFalloff;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("If disabled, only world space AddForce will be used to pin the ragdoll to the animation while 'Pin Weight' > 0. If enabled, AddTorque will also be used for rotational pinning. Keep it disabled if you don't see any noticeable improvement from it to avoid wasting CPU resources.")]
		public bool angularPinning;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[Tooltip("When the target has animated bones between the muscle bones, the joint anchors need to be updated in every update cycle because the muscles' targets move relative to each other in position space. This gives much more accurate results, but is computationally expensive so consider leaving it off.")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[Tooltip("Enable this if any of the target's bones has translation animation.")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[Tooltip("Should the joints use angular limits? If the PuppetMaster fails to match the target's pose, it might be because the joint limits are too stiff and do not allow for such motion. Uncheck this to see if the limits are clamping the range of your puppet's animation. Since the joints are actuated, most PuppetMaster simulations will not actually require using joint limits at all.")]
		public bool angularLimits;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the muscles collide with each other? Consider leaving this off while the puppet is pinned for performance and better accuracy.  Since the joints are actuated, most PuppetMaster simulations will not actually require internal collisions at all.")]
		public bool internalCollisions;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Individual Muscle Settings")]
		[Tooltip("The Muscles managed by this PuppetMaster.")]
		public Muscle[] muscles;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public PropMuscle[] propMuscles;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MuscleDelegate OnMuscleDisconnected;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MuscleDelegate OnMuscleReconnected;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Animator _targetAnimator;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public List<SolverManager> solvers;

		[NonSerialized]
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public bool manualInternalCollisionControl;

		[NonSerialized]
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[HideInInspector]
		public bool manualAngularLimitControl;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[HideInInspector]
		public bool mapDisconnectedMuscles;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool fixedFrame;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSolverIterationCount;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool isLegacy;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool animatorDisabled;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool awakeFailed;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool interpolated;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool freezeFlag;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool hasBeenDisabled;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		private bool teleport;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 teleportPosition;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion teleportRotation;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool rebuildFlag;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		private bool onPostRebuildFlag;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool[] disconnectMuscleFlags;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private MuscleDisconnectMode[] muscleDisconnectModes;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool[] disconnectDeactivateFlags;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool[] reconnectMuscleFlags;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Muscle[] defaultMuscles;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 rebuildPelvisPos;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion rebuildPelvisRot;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float simulationDeltaTime;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool readInFixedUpdate;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Mode activeMode;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Mode lastMode;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private float mappingBlend;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private State activeState;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private State lastState;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		[HideInInspector]
		public bool storeTargetMappedState;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private bool targetMappedStateStored;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		private bool hasProp;

		[Token(Token = "0x17000041")]
		public Animator targetAnimator
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x101C7D4", Offset = "0x101C7D4", VA = "0x101C7D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x101C914", Offset = "0x101C914", VA = "0x101C914")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public Animation targetAnimation
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x101C91C", Offset = "0x101C91C", VA = "0x101C91C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x101C924", Offset = "0x101C924", VA = "0x101C924")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x101C92C", Offset = "0x101C92C", VA = "0x101C92C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x101C934", Offset = "0x101C934", VA = "0x101C934")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool isActive
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x100CEE4", Offset = "0x100CEE4", VA = "0x100CEE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public bool initiated
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x101C93C", Offset = "0x101C93C", VA = "0x101C93C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x101C944", Offset = "0x101C944", VA = "0x101C944")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x101C950", Offset = "0x101C950", VA = "0x101C950")]
			get
			{
				return default(UpdateMode);
			}
		}

		[Token(Token = "0x17000047")]
		public bool controlsAnimator
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x101CA60", Offset = "0x101CA60", VA = "0x101CA60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public bool isBlending
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x100D020", Offset = "0x100D020", VA = "0x100D020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private bool autoSimulate
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x101D508", Offset = "0x101D508", VA = "0x101D508")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x101C988", Offset = "0x101C988", VA = "0x101C988")]
			get
			{
				return default(AnimatorUpdateMode);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x10244BC", Offset = "0x10244BC", VA = "0x10244BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x10244C4", Offset = "0x10244C4", VA = "0x10244C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool isSwitchingState
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x101CAB4", Offset = "0x101CAB4", VA = "0x101CAB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool isKilling
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1027960", Offset = "0x1027960", VA = "0x1027960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1027968", Offset = "0x1027968", VA = "0x1027968")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool isAlive
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x100CF48", Offset = "0x100CF48", VA = "0x100CF48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public bool isFrozen
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x100D7CC", Offset = "0x100D7CC", VA = "0x100D7CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x101C600", Offset = "0x101C600", VA = "0x101C600")]
		[ContextMenu("User Manual (Setup)")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x101C644", Offset = "0x101C644", VA = "0x101C644")]
		[ContextMenu("User Manual (Component)")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x101C688", Offset = "0x101C688", VA = "0x101C688")]
		[ContextMenu("User Manual (Performance)")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x101C6CC", Offset = "0x101C6CC", VA = "0x101C6CC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x101C710", Offset = "0x101C710", VA = "0x101C710")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x101C754", Offset = "0x101C754", VA = "0x101C754")]
		[ContextMenu("TUTORIAL VIDEO (COMPONENT)")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x101C798", Offset = "0x101C798", VA = "0x101C798")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x101CAC8", Offset = "0x101CAC8", VA = "0x101CAC8")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x101D3C0", Offset = "0x101D3C0", VA = "0x101D3C0")]
		public void SetInternalCollisionsManual(bool collide, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x101D498", Offset = "0x101D498", VA = "0x101D498")]
		public void SetAngularLimitsManual(bool limited)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x101D510", Offset = "0x101D510", VA = "0x101D510")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x101D5A4", Offset = "0x101D5A4", VA = "0x101D5A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x101DC98", Offset = "0x101DC98", VA = "0x101DC98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x101E7B4", Offset = "0x101E7B4", VA = "0x101E7B4")]
		public void Start()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x101E860", Offset = "0x101E860", VA = "0x101E860")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x101DCD0", Offset = "0x101DCD0", VA = "0x101DCD0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x101F9E4", Offset = "0x101F9E4", VA = "0x101F9E4")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x101FAC0", Offset = "0x101FAC0", VA = "0x101FAC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x101FBB8", Offset = "0x101FBB8", VA = "0x101FBB8")]
		private bool IsInterpolated()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x101FC38", Offset = "0x101FC38", VA = "0x101FC38")]
		private void OnRebuild()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x101FF3C", Offset = "0x101FF3C", VA = "0x101FF3C")]
		public void OnPreSimulate(float deltaTime)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1020780", Offset = "0x1020780", VA = "0x1020780")]
		public void OnPostSimulate()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1020EA4", Offset = "0x1020EA4", VA = "0x1020EA4", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x102142C", Offset = "0x102142C", VA = "0x102142C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1021510", Offset = "0x1021510", VA = "0x1021510", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x102169C", Offset = "0x102169C", VA = "0x102169C", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1020AB8", Offset = "0x1020AB8", VA = "0x1020AB8")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x101CB08", Offset = "0x101CB08", VA = "0x101CB08")]
		private void Read()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1020590", Offset = "0x1020590", VA = "0x1020590")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x10219A4", Offset = "0x10219A4", VA = "0x10219A4")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1021C24", Offset = "0x1021C24", VA = "0x1021C24")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x101F904", Offset = "0x101F904", VA = "0x101F904")]
		public void FlagInternalCollisionsForUpdate()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x10206C8", Offset = "0x10206C8", VA = "0x10206C8")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1021F2C", Offset = "0x1021F2C", VA = "0x1021F2C")]
		public void UpdateInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1021E64", Offset = "0x1021E64", VA = "0x1021E64")]
		private void IgnoreInternalCollisions()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1021FC8", Offset = "0x1021FC8", VA = "0x1021FC8")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1021D94", Offset = "0x1021D94", VA = "0x1021D94")]
		private void ResetInternalCollisions()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1022048", Offset = "0x1022048", VA = "0x1022048")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x101F920", Offset = "0x101F920", VA = "0x101F920")]
		public void FlagAngularLimitsForUpdate()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x10206F0", Offset = "0x10206F0", VA = "0x10206F0")]
		private void UpdateAngularLimits()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x10220D0", Offset = "0x10220D0", VA = "0x10220D0")]
		public bool AddPropMuscle(ConfigurableJoint addPropMuscleTo, Vector3 position, Quaternion rotation, Vector3 additionalPinOffset, [Optional] Transform targetParent, [Optional] PuppetMasterProp initiateWithProp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x101ADE0", Offset = "0x101ADE0", VA = "0x101ADE0")]
		public bool IsDisconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x101AE10", Offset = "0x101AE10", VA = "0x101AE10")]
		public bool IsReconnecting(int muscleIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x101A668", Offset = "0x101A668", VA = "0x101A668")]
		public void DisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x101AE40", Offset = "0x101AE40", VA = "0x101AE40")]
		public void ReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x101BC10", Offset = "0x101BC10", VA = "0x101BC10")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1022C98", Offset = "0x1022C98", VA = "0x1022C98")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1011978", Offset = "0x1011978", VA = "0x1011978")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1022FDC", Offset = "0x1022FDC", VA = "0x1022FDC")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1023078", Offset = "0x1023078", VA = "0x1023078")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1023114", Offset = "0x1023114", VA = "0x1023114")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x10231B0", Offset = "0x10231B0", VA = "0x10231B0")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x102324C", Offset = "0x102324C", VA = "0x102324C")]
		[ContextMenu("Flatten Muscle Hierarchy")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1023344", Offset = "0x1023344", VA = "0x1023344")]
		[ContextMenu("Tree Muscle Hierarchy")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1023490", Offset = "0x1023490", VA = "0x1023490")]
		[ContextMenu("Fix Muscle Positions")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x10235A4", Offset = "0x10235A4", VA = "0x10235A4")]
		[ContextMenu("Fix Muscle Positions and Rotations")]
		public void FixMusclePositionsAndRotations()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x101F80C", Offset = "0x101F80C", VA = "0x101F80C")]
		public bool HierarchyIsFlat()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x10227B0", Offset = "0x10227B0", VA = "0x10227B0")]
		private int GetHighestDisconnectedParentIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1020430", Offset = "0x1020430", VA = "0x1020430")]
		private void ProcessDisconnects()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1020510", Offset = "0x1020510", VA = "0x1020510")]
		private void ProcessReconnects()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x10236F0", Offset = "0x10236F0", VA = "0x10236F0")]
		private void OnDisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1023B20", Offset = "0x1023B20", VA = "0x1023B20")]
		private void DisconnectMuscle(Muscle m, bool sever, bool deactivate)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x10239A4", Offset = "0x10239A4", VA = "0x10239A4")]
		private void OnReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1023FA0", Offset = "0x1023FA0", VA = "0x1023FA0")]
		private void ReconnectMuscle(Muscle m)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1024344", Offset = "0x1024344", VA = "0x1024344")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1022E70", Offset = "0x1022E70", VA = "0x1022E70")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1022F2C", Offset = "0x1022F2C", VA = "0x1022F2C")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x102449C", Offset = "0x102449C", VA = "0x102449C")]
		public void SwitchToActiveMode()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x10244A4", Offset = "0x10244A4", VA = "0x10244A4")]
		public void SwitchToKinematicMode()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x10244B0", Offset = "0x10244B0", VA = "0x10244B0")]
		public void SwitchToDisabledMode()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x10244D0", Offset = "0x10244D0", VA = "0x10244D0")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1024564", Offset = "0x1024564", VA = "0x1024564", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x10246A8", Offset = "0x10246A8", VA = "0x10246A8")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x10247F0", Offset = "0x10247F0", VA = "0x10247F0")]
		[IteratorStateMachine(typeof(<DisabledToActive>d__174))]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1024864", Offset = "0x1024864", VA = "0x1024864")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x10248F4", Offset = "0x10248F4", VA = "0x10248F4")]
		[IteratorStateMachine(typeof(<KinematicToActive>d__176))]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1024968", Offset = "0x1024968", VA = "0x1024968")]
		[IteratorStateMachine(typeof(<ActiveToDisabled>d__177))]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x10249DC", Offset = "0x10249DC", VA = "0x10249DC")]
		[IteratorStateMachine(typeof(<ActiveToKinematic>d__178))]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1024A50", Offset = "0x1024A50", VA = "0x1024A50")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1024AE4", Offset = "0x1024AE4", VA = "0x1024AE4")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1024E84", Offset = "0x1024E84", VA = "0x1024E84")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1025118", Offset = "0x1025118", VA = "0x1025118")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1025228", Offset = "0x1025228", VA = "0x1025228")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1025308", Offset = "0x1025308", VA = "0x1025308")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1024D40", Offset = "0x1024D40", VA = "0x1024D40")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x102538C", Offset = "0x102538C", VA = "0x102538C")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x10228C0", Offset = "0x10228C0", VA = "0x10228C0")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1019F04", Offset = "0x1019F04", VA = "0x1019F04")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x101FE6C", Offset = "0x101FE6C", VA = "0x101FE6C")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default(bool);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1024F08", Offset = "0x1024F08", VA = "0x1024F08")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default(int);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1024B68", Offset = "0x1024B68", VA = "0x1024B68")]
		public int GetMuscleIndex(Transform target)
		{
			return default(int);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x10253D4", Offset = "0x10253D4", VA = "0x10253D4")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default(int);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1022CA4", Offset = "0x1022CA4", VA = "0x1022CA4")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x10255AC", Offset = "0x10255AC", VA = "0x10255AC")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1026224", Offset = "0x1026224", VA = "0x1026224")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x102569C", Offset = "0x102569C", VA = "0x102569C")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1026394", Offset = "0x1026394", VA = "0x1026394")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1026B9C", Offset = "0x1026B9C", VA = "0x1026B9C")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1027538", Offset = "0x1027538", VA = "0x1027538")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default(Muscle.Group);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1026790", Offset = "0x1026790", VA = "0x1026790")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x102726C", Offset = "0x102726C", VA = "0x102726C")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1027974", Offset = "0x1027974", VA = "0x1027974")]
		public void Kill()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1027980", Offset = "0x1027980", VA = "0x1027980")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x102799C", Offset = "0x102799C", VA = "0x102799C")]
		public void Freeze()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x10279A8", Offset = "0x10279A8", VA = "0x10279A8")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x10279C4", Offset = "0x10279C4", VA = "0x10279C4")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x10279CC", Offset = "0x10279CC", VA = "0x10279CC", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1027AC0", Offset = "0x1027AC0", VA = "0x1027AC0")]
		[IteratorStateMachine(typeof(<AliveToDead>d__229))]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1020C54", Offset = "0x1020C54", VA = "0x1020C54")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1027B48", Offset = "0x1027B48", VA = "0x1027B48")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x101D9D8", Offset = "0x101D9D8", VA = "0x101D9D8")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1027C3C", Offset = "0x1027C3C", VA = "0x1027C3C")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1027C48", Offset = "0x1027C48", VA = "0x1027C48")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1027E4C", Offset = "0x1027E4C", VA = "0x1027E4C")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x101DAC0", Offset = "0x101DAC0", VA = "0x101DAC0")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1027F1C", Offset = "0x1027F1C", VA = "0x1027F1C")]
		private bool CanFreeze()
		{
			return default(bool);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x100EF88", Offset = "0x100EF88", VA = "0x100EF88")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x100D810", Offset = "0x100D810", VA = "0x100D810")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x101F93C", Offset = "0x101F93C", VA = "0x101F93C")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x101F590", Offset = "0x101F590", VA = "0x101F590")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1028514", Offset = "0x1028514", VA = "0x1028514")]
		private bool HasProp()
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x10283D4", Offset = "0x10283D4", VA = "0x10283D4")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1027FB4", Offset = "0x1027FB4", VA = "0x1027FB4")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1028574", Offset = "0x1028574", VA = "0x1028574")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x10286D4", Offset = "0x10286D4", VA = "0x10286D4")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x10282D4", Offset = "0x10282D4", VA = "0x10282D4")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x102898C", Offset = "0x102898C", VA = "0x102898C")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1028AD8", Offset = "0x1028AD8", VA = "0x1028AD8")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x10288D0", Offset = "0x10288D0", VA = "0x10288D0")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default(int);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x101EC08", Offset = "0x101EC08", VA = "0x101EC08")]
		public bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1022908", Offset = "0x1022908", VA = "0x1022908")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1022834", Offset = "0x1022834", VA = "0x1022834")]
		private bool CheckIfInitiated()
		{
			return default(bool);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1028D14", Offset = "0x1028D14", VA = "0x1028D14")]
		public PuppetMaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public enum MuscleRemoveMode
	{
		[Token(Token = "0x40002D9")]
		Sever,
		[Token(Token = "0x40002DA")]
		Explode,
		[Token(Token = "0x40002DB")]
		Numb
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public enum MuscleDisconnectMode
	{
		[Token(Token = "0x40002DD")]
		Sever,
		[Token(Token = "0x40002DE")]
		Explode
	}
	[Token(Token = "0x2000061")]
	[CreateAssetMenu(fileName = "PuppetMaster Humanoid Config", menuName = "PuppetMaster/Humanoid Config", order = 1)]
	public class PuppetMasterHumanoidConfig : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		public class HumanoidMuscle
		{
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Muscle.Props props;

			[Token(Token = "0x6000367")]
			[Address(RVA = "0x104597C", Offset = "0x104597C", VA = "0x104597C")]
			public HumanoidMuscle()
			{
			}
		}

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("Simulation")]
		public PuppetMaster.State state;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuppetMaster.Mode mode;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blendTime;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool fixTargetTransforms;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int solverIterationCount;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool visualizeTargetPose;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[LargeHeader("Master Weights")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float pinWeight;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float muscleWeight;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[LargeHeader("Joint and Muscle Settings")]
		public float muscleSpring;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float muscleDamper;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(1f, 8f)]
		public float pinPow;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 100f)]
		public float pinDistanceFalloff;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool angularPinning;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool updateJointAnchors;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool angularLimits;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool internalCollisions;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[LargeHeader("Individual Muscle Settings")]
		public HumanoidMuscle[] muscles;

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1045508", Offset = "0x1045508", VA = "0x1045508")]
		public void ApplyTo(PuppetMaster p)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x10457B0", Offset = "0x10457B0", VA = "0x10457B0")]
		private Muscle GetMuscle(HumanBodyBones boneId, Animator animator, PuppetMaster puppetMaster)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x10458C4", Offset = "0x10458C4", VA = "0x10458C4")]
		public PuppetMasterHumanoidConfig()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public interface ICollisionEventListener
	{
		[Token(Token = "0x6000368")]
		void OnCollisionEnterEvent(Collision collision, CollisionEventBroadcaster broadcaster);

		[Token(Token = "0x6000369")]
		void OnCollisionStayEvent(Collision collision, CollisionEventBroadcaster broadcaster);

		[Token(Token = "0x600036A")]
		void OnCollisionExitEvent(Collision collision, CollisionEventBroadcaster broadcaster);
	}
	[Token(Token = "0x2000064")]
	public class CollisionEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ICollisionEventListener listener;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MuscleLite muscle;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1045984", Offset = "0x1045984", VA = "0x1045984")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1045A38", Offset = "0x1045A38", VA = "0x1045A38")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1045AF0", Offset = "0x1045AF0", VA = "0x1045AF0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1045BA8", Offset = "0x1045BA8", VA = "0x1045BA8")]
		public CollisionEventBroadcaster()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class MuscleLite
	{
		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string name;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ConfigurableJoint joint;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float pinWeightMlp;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float muscleWeightMlp;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float muscleDamperMlp;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float mappingWeightMlp;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private JointDrive slerpDrive;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion toJointSpaceInverse;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion toJointSpaceDefault;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion targetAnimatedRotation;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Quaternion toParentSpace;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion localRotationConvert;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion targetAnimatedWorldRotation;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 defaultTargetLocalPosition;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private float lastJointDriveRotationWeight;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float lastRotationDamper;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private bool initiated;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform connectedBodyTarget;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform connectedBodyTransform;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Transform targetParent;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool directTargetParent;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 targetVelocity;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 targetAnimatedCenterOfMass;

		[Token(Token = "0x1700005B")]
		public Transform transform
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1045BB0", Offset = "0x1045BB0", VA = "0x1045BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1045BB8", Offset = "0x1045BB8", VA = "0x1045BB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1045BC0", Offset = "0x1045BC0", VA = "0x1045BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x1045BC8", Offset = "0x1045BC8", VA = "0x1045BC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public Vector3 positionOffset
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x1045BD0", Offset = "0x1045BD0", VA = "0x1045BD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1045BDC", Offset = "0x1045BDC", VA = "0x1045BDC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public int index
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1045BE8", Offset = "0x1045BE8", VA = "0x1045BE8")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1045BF0", Offset = "0x1045BF0", VA = "0x1045BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		private Quaternion localRotation
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1046818", Offset = "0x1046818", VA = "0x1046818")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000060")]
		private Quaternion targetLocalRotation
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x10466E0", Offset = "0x10466E0", VA = "0x10466E0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000061")]
		private Quaternion parentRotation
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x10465AC", Offset = "0x10465AC", VA = "0x10465AC")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000062")]
		private Quaternion targetParentRotation
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x10464F4", Offset = "0x10464F4", VA = "0x10464F4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1045BF8", Offset = "0x1045BF8", VA = "0x1045BF8")]
		public void Initiate(MuscleLite[] colleagues)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1046A88", Offset = "0x1046A88", VA = "0x1046A88")]
		public void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1046ADC", Offset = "0x1046ADC", VA = "0x1046ADC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1046CC0", Offset = "0x1046CC0", VA = "0x1046CC0")]
		public void MoveToTarget()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1046D7C", Offset = "0x1046D7C", VA = "0x1046D7C")]
		public void ClearVelocities()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x10468D8", Offset = "0x10468D8", VA = "0x10468D8")]
		public void Read()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1046E90", Offset = "0x1046E90", VA = "0x1046E90")]
		public void Update(float pinWeightMaster, float muscleWeightMaster, float muscleSpring, float muscleDamper, bool angularPinning)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1046EDC", Offset = "0x1046EDC", VA = "0x1046EDC")]
		private void Pin(float pinWeightMaster, float pinPow, float pinDistanceFalloff, bool angularPinning)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1047158", Offset = "0x1047158", VA = "0x1047158")]
		private void MuscleRotation(float muscleWeightMaster, float muscleSpring, float muscleDamper)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x10473E4", Offset = "0x10473E4", VA = "0x10473E4")]
		public void Map(float masterWeight)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x10476A4", Offset = "0x10476A4", VA = "0x10476A4")]
		public void UpdateAnchor(bool supportTranslationAnimation)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x10472CC", Offset = "0x10472CC", VA = "0x10472CC")]
		private Quaternion LocalToJointSpace(Quaternion localRotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x10478DC", Offset = "0x10478DC", VA = "0x10478DC")]
		private static Vector3 InverseTransformPointUnscaled(Vector3 position, Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x104793C", Offset = "0x104793C", VA = "0x104793C")]
		public MuscleLite()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class PuppetControllerLite : MonoBehaviour, ICollisionEventListener
	{
		[Serializable]
		[Token(Token = "0x2000067")]
		public class Group
		{
			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The muscle groups to apply this pinWeightMlp and muscleWeightMlp to.")]
			public int[] indices;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			public float pinWeightMlp;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			public float muscleWeightMlp;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("When the puppet is touched, sets muscle Rigidbody drag to this value to reduce the rubber chicken effect.")]
			public float drag;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The time of blending in this script's effects when the puppet is touched.")]
			public float blendInTime;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of blending out this script's effects when the puppet is not touched any more.")]
			public float blendOutTime;

			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float dam;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float damTime;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float damV;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float map;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float mapV;

			[Token(Token = "0x17000063")]
			public bool enabled
			{
				[Token(Token = "0x6000391")]
				[Address(RVA = "0x1048090", Offset = "0x1048090", VA = "0x1048090")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x1048098", Offset = "0x1048098", VA = "0x1048098")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public float mappingWeight
			{
				[Token(Token = "0x6000393")]
				[Address(RVA = "0x10480A4", Offset = "0x10480A4", VA = "0x10480A4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x10480AC", Offset = "0x10480AC", VA = "0x10480AC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1047FAC", Offset = "0x1047FAC", VA = "0x1047FAC")]
			public void TryDamage(Collision collision, CollisionEventBroadcaster broadcaster)
			{
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1047C00", Offset = "0x1047C00", VA = "0x1047C00")]
			public void Update(PuppetMasterLite puppetMaster)
			{
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x10480B4", Offset = "0x10480B4", VA = "0x10480B4")]
			public Group()
			{
			}
		}

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterLite puppetMaster;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask collisionLayers;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("When the puppet is touched, sets pin weight and muscle weight values for these groups.")]
		public Group[] groups;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x10479FC", Offset = "0x10479FC", VA = "0x10479FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1047AD8", Offset = "0x1047AD8", VA = "0x1047AD8")]
		private bool NeedToUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1047B2C", Offset = "0x1047B2C", VA = "0x1047B2C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1047E68", Offset = "0x1047E68", VA = "0x1047E68", Slot = "4")]
		public void OnCollisionEnterEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1047FA8", Offset = "0x1047FA8", VA = "0x1047FA8", Slot = "5")]
		public void OnCollisionStayEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1047E6C", Offset = "0x1047E6C", VA = "0x1047E6C")]
		private void ProcessCollisionEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1048028", Offset = "0x1048028", VA = "0x1048028", Slot = "6")]
		public void OnCollisionExitEvent(Collision collision, CollisionEventBroadcaster broadcaster)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x104802C", Offset = "0x104802C", VA = "0x104802C")]
		public PuppetControllerLite()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class PuppetMasterLite : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		public delegate void PuppetMasterLiteDelegate();

		[Token(Token = "0x200006A")]
		public enum UpdateMode
		{
			[Token(Token = "0x400033B")]
			Normal,
			[Token(Token = "0x400033C")]
			Fixed
		}

		[Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class <Activation>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterLite <>4__this;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003AD")]
				[Address(RVA = "0x1048D88", Offset = "0x1048D88", VA = "0x1048D88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0x1048DD0", Offset = "0x1048DD0", VA = "0x1048DD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x104855C", Offset = "0x104855C", VA = "0x104855C")]
			[DebuggerHidden]
			public <Activation>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x1048CA8", Offset = "0x1048CA8", VA = "0x1048CA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x1048CAC", Offset = "0x1048CAC", VA = "0x1048CAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1048D90", Offset = "0x1048D90", VA = "0x1048D90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class <Deactivation>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterLite <>4__this;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B3")]
				[Address(RVA = "0x1048EE8", Offset = "0x1048EE8", VA = "0x1048EE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x1048F30", Offset = "0x1048F30", VA = "0x1048F30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x104864C", Offset = "0x104864C", VA = "0x104864C")]
			[DebuggerHidden]
			public <Deactivation>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1048DD8", Offset = "0x1048DD8", VA = "0x1048DD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1048DDC", Offset = "0x1048DDC", VA = "0x1048DDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1048EF0", Offset = "0x1048EF0", VA = "0x1048EF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform targetRoot;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool fixTargetTransforms;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blendTime;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float mappingWeight;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float pinWeight;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float muscleWeight;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float muscleSpring;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float muscleDamper;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool updateJointAnchors;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		public bool angularPinning;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[LargeHeader("Individual Muscle Settings")]
		public MuscleLite[] muscles;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterLiteDelegate OnRead;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public PuppetMasterLiteDelegate OnWrite;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator targetAnimator;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool animatorDisabled;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool fixedFrame;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private UpdateMode updateMode;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1048134", Offset = "0x1048134", VA = "0x1048134")]
		private void Start()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10482F0", Offset = "0x10482F0", VA = "0x10482F0")]
		public void Activate()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x10484E8", Offset = "0x10484E8", VA = "0x10484E8")]
		[IteratorStateMachine(typeof(<Activation>d__21))]
		private IEnumerator Activation()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1048584", Offset = "0x1048584", VA = "0x1048584")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x10485D8", Offset = "0x10485D8", VA = "0x10485D8")]
		[IteratorStateMachine(typeof(<Deactivation>d__23))]
		private IEnumerator Deactivation()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1048138", Offset = "0x1048138", VA = "0x1048138")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1048674", Offset = "0x1048674", VA = "0x1048674")]
		private void Update()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1048714", Offset = "0x1048714", VA = "0x1048714")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1048778", Offset = "0x1048778", VA = "0x1048778")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x10488C8", Offset = "0x10488C8", VA = "0x10488C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1048424", Offset = "0x1048424", VA = "0x1048424")]
		private void Read()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1048928", Offset = "0x1048928", VA = "0x1048928")]
		private void Write()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x10489AC", Offset = "0x10489AC", VA = "0x10489AC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1048B44", Offset = "0x1048B44", VA = "0x1048B44")]
		public PuppetMasterLite()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class PuppetMasterProp : MonoBehaviour
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Mesh Root will be parented to Prop Muscle's target when this prop is picked up. To make sure the mesh and the colliders match up, Mesh Root's localPosition/Rotation must be zero.")]
		public Transform meshRoot;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The muscle properties that will be applied to the Prop Muscle when this prop is picked up.")]
		public Muscle.Props muscleProps;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, this prop's layer will be forced to PuppetMaster layer and target's layer forced to PuppetMaster's Target Root's layer when the prop is picked up.")]
		public bool forceLayers;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Mass of the prop while picked up. When dropped, mass of the original Rigidbody will be used.")]
		public float mass;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This has no other purpose but helping you distinguish props by PropMuscle.currentProp.propType.")]
		public int propType;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If assigned, sets prop colliders to this PhysicMaterial when picked up. If no material assigned, will maintain the original PhysicMaterial (unless otherwise controlled by BehaviourPuppet's Group Overrides).")]
		[LargeHeader("Materials")]
		public PhysicMaterial pickedUpMaterial;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Adds this to Prop Muscle's 'Additional Pin Offset' when this prop is picked up.")]
		[LargeHeader("Additional Pin")]
		public Vector3 additionalPinOffsetAdd;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The pin weight multiplier of the additional pin. Increasing this weight will make the prop follow animation better, but will increase jitter when colliding with objects.")]
		[Range(0f, 1f)]
		public float additionalPinWeight;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Multiplies the mass of the additional pin by this value when this prop is picked up. The Rigidbody on this prop will be destroyed on pick-up and reattached on drop, so it's mass is not used while picked up.")]
		public float additionalPinMass;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int defaultLayer;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform defaultParent;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Collider[] colliders;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PhysicMaterial[] droppedMaterials;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody r;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _mass;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _drag;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _angularDrag;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool _useGravity;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		private bool _isKinematic;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RigidbodyInterpolation _interpolation;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private CollisionDetectionMode _collisionDetectionMode;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RigidbodyConstraints _constraints;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] emptyColliders;

		[Token(Token = "0x17000069")]
		public bool isPickedUp
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1048F38", Offset = "0x1048F38", VA = "0x1048F38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1048F40", Offset = "0x1048F40", VA = "0x1048F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		protected Muscle propMuscle
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1048FEC", Offset = "0x1048FEC", VA = "0x1048FEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1048FF4", Offset = "0x1048FF4", VA = "0x1048FF4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1048F4C", Offset = "0x1048F4C", VA = "0x1048F4C")]
		public Rigidbody GetRigidbody()
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1048FE4", Offset = "0x1048FE4", VA = "0x1048FE4", Slot = "4")]
		protected virtual void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1048FE8", Offset = "0x1048FE8", VA = "0x1048FE8", Slot = "5")]
		protected virtual void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x1048FFC", Offset = "0x1048FFC", VA = "0x1048FFC")]
		public void PickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x104954C", Offset = "0x104954C", VA = "0x104954C")]
		public void Drop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x1049AE8", Offset = "0x1049AE8", VA = "0x1049AE8", Slot = "6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x1049C7C", Offset = "0x1049C7C", VA = "0x1049C7C", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1049E58", Offset = "0x1049E58", VA = "0x1049E58", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1049400", Offset = "0x1049400", VA = "0x1049400")]
		private void RemoveRigidbody()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1049988", Offset = "0x1049988", VA = "0x1049988")]
		private void ReattachRigidbody()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1049F30", Offset = "0x1049F30", VA = "0x1049F30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x104A078", Offset = "0x104A078", VA = "0x104A078")]
		public PuppetMasterProp()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/PuppetMaster Settings")]
	public class PuppetMasterSettings : Singleton<PuppetMasterSettings>
	{
		[Serializable]
		[Token(Token = "0x200006F")]
		public class PuppetUpdateLimit
		{
			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(1f, 100f)]
			public int puppetsPerFrame;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int index;

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x104A858", Offset = "0x104A858", VA = "0x104A858")]
			public PuppetUpdateLimit()
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x104A684", Offset = "0x104A684", VA = "0x104A684")]
			public void Step(int puppetCount)
			{
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x104A2E0", Offset = "0x104A2E0", VA = "0x104A2E0")]
			public bool Update(List<PuppetMaster> puppets, PuppetMaster puppetMaster)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Optimizations")]
		public PuppetUpdateLimit kinematicCollidersUpdateLimit;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuppetUpdateLimit freeUpdateLimit;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuppetUpdateLimit fixedUpdateLimit;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool collisionStayMessages;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool collisionExitMessages;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float activePuppetCollisionThresholdMlp;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<PuppetMaster> _puppets;

		[Token(Token = "0x1700006B")]
		public int currentlyActivePuppets
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x104A148", Offset = "0x104A148", VA = "0x104A148")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x104A150", Offset = "0x104A150", VA = "0x104A150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public int currentlyKinematicPuppets
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x104A158", Offset = "0x104A158", VA = "0x104A158")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x104A160", Offset = "0x104A160", VA = "0x104A160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public int currentlyDisabledPuppets
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x104A168", Offset = "0x104A168", VA = "0x104A168")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x104A170", Offset = "0x104A170", VA = "0x104A170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public List<PuppetMaster> puppets
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x104A178", Offset = "0x104A178", VA = "0x104A178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x104A180", Offset = "0x104A180", VA = "0x104A180")]
		public void Register(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x104A264", Offset = "0x104A264", VA = "0x104A264")]
		public void Unregister(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x104A2BC", Offset = "0x104A2BC", VA = "0x104A2BC")]
		public bool UpdateMoveToTarget(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x104A400", Offset = "0x104A400", VA = "0x104A400")]
		public bool UpdateFree(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x104A424", Offset = "0x104A424", VA = "0x104A424")]
		public bool UpdateFixed(PuppetMaster puppetMaster)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x104A448", Offset = "0x104A448", VA = "0x104A448")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x104A6A0", Offset = "0x104A6A0", VA = "0x104A6A0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x104A708", Offset = "0x104A708", VA = "0x104A708")]
		public PuppetMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class PuppetMasterTools
	{
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x104A878", Offset = "0x104A878", VA = "0x104A878")]
		public static void PositionRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x104AE4C", Offset = "0x104AE4C", VA = "0x104AE4C")]
		public static void RealignRagdoll(PuppetMaster puppetMaster)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x104B744", Offset = "0x104B744", VA = "0x104B744")]
		private static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x104B824", Offset = "0x104B824", VA = "0x104B824")]
		private static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000071")]
	public class RigidbodyController : MonoBehaviour
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool useTargetVelocity;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody r;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 lastTargetPos;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion lastTargetRot;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x104B95C", Offset = "0x104B95C", VA = "0x104B95C")]
		public void OnTargetTeleported()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x104B9A0", Offset = "0x104B9A0", VA = "0x104B9A0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x104BA00", Offset = "0x104BA00", VA = "0x104BA00")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x104BD34", Offset = "0x104BD34", VA = "0x104BD34")]
		public RigidbodyController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class Weight
	{
		[Serializable]
		[Token(Token = "0x2000073")]
		public enum Mode
		{
			[Token(Token = "0x4000373")]
			Float,
			[Token(Token = "0x4000374")]
			Curve
		}

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mode mode;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float floatValue;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve curve;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string tooltip;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x104BD98", Offset = "0x104BD98", VA = "0x104BD98")]
		public Weight(float floatValue)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x104BE04", Offset = "0x104BE04", VA = "0x104BE04")]
		public Weight(float floatValue, string tooltip)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x104BE8C", Offset = "0x104BE8C", VA = "0x104BE8C")]
		public float GetValue(float param)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000074")]
	public class InitialVelocity : MonoBehaviour
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 initialVelocity;

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x104BEC0", Offset = "0x104BEC0", VA = "0x104BEC0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x104BF20", Offset = "0x104BF20", VA = "0x104BF20")]
		public InitialVelocity()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Biped Ragdoll Creator")]
	public class BipedRagdollCreator : RagdollCreator
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public struct Options
		{
			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float weight;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[Header("Optional Bones")]
			public bool spine;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool chest;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			public bool hands;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
			public bool feet;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Header("Joints")]
			public JointType joints;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float jointRange;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Header("Colliders")]
			public float colliderLengthOverlap;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ColliderType torsoColliders;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ColliderType headCollider;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColliderType armColliders;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ColliderType handColliders;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ColliderType legColliders;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ColliderType footColliders;

			[Token(Token = "0x1700006F")]
			public static Options Default
			{
				[Token(Token = "0x60003F6")]
				[Address(RVA = "0x104C1A8", Offset = "0x104C1A8", VA = "0x104C1A8")]
				get
				{
					return default(Options);
				}
			}
		}

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool canBuild;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedRagdollReferences references;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Options options;

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x104BF28", Offset = "0x104BF28", VA = "0x104BF28")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x104BF6C", Offset = "0x104BF6C", VA = "0x104BF6C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x104BFB0", Offset = "0x104BFB0", VA = "0x104BFB0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x104BFF4", Offset = "0x104BFF4", VA = "0x104BFF4")]
		public static Options AutodetectOptions(BipedRagdollReferences r)
		{
			return default(Options);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x104C258", Offset = "0x104C258", VA = "0x104C258")]
		public static void Create(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x104CD78", Offset = "0x104CD78", VA = "0x104CD78")]
		private static void CreateColliders(BipedRagdollReferences r, Options options)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x104ED80", Offset = "0x104ED80", VA = "0x104ED80")]
		private static void CreateHandCollider(Transform hand, Transform lowerArm, Transform root, Options options)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x104F178", Offset = "0x104F178", VA = "0x104F178")]
		private static void CreateFootCollider(Transform foot, Transform lowerLeg, Transform upperLeg, Transform root, Options options)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x104F870", Offset = "0x104F870", VA = "0x104F870")]
		private static Vector3 GetChildCentroid(Transform t, Vector3 fallback)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x104DB6C", Offset = "0x104DB6C", VA = "0x104DB6C")]
		private static void MassDistribution(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x104DFB8", Offset = "0x104DFB8", VA = "0x104DFB8")]
		private static void CreateJoints(BipedRagdollReferences r, Options o)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x104FFC4", Offset = "0x104FFC4", VA = "0x104FFC4")]
		private static void CreateLimbJoints(Transform connectedBone, Transform bone1, Transform bone2, Transform bone3, Transform root, Vector3 defaultWorldDirection, JointType jointType, CreateJointParams.Limits limits1, CreateJointParams.Limits limits2, CreateJointParams.Limits limits3)
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1050744", Offset = "0x1050744", VA = "0x1050744")]
		public static void ClearBipedRagdoll(BipedRagdollReferences r)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1050D9C", Offset = "0x1050D9C", VA = "0x1050D9C")]
		public static bool IsClear(BipedRagdollReferences r)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x104E628", Offset = "0x104E628", VA = "0x104E628")]
		private static Vector3 GetUpperArmToHeadCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x104C1E0", Offset = "0x104C1E0", VA = "0x104C1E0")]
		private static Vector3 GetUpperArmCentroid(BipedRagdollReferences r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1050E84", Offset = "0x1050E84", VA = "0x1050E84")]
		public BipedRagdollCreator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public struct BipedRagdollReferences
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Transform root;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Transform hips;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform spine;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform chest;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform head;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftUpperLeg;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftLowerLeg;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform leftFoot;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightUpperLeg;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightLowerLeg;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightFoot;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftLowerArm;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform leftHand;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightLowerArm;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform rightHand;

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x104C398", Offset = "0x104C398", VA = "0x104C398")]
		public bool IsValid(ref string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1050EC8", Offset = "0x1050EC8", VA = "0x1050EC8")]
		private bool IsChildRecursive(Transform t, Transform parent)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1050FB0", Offset = "0x1050FB0", VA = "0x1050FB0")]
		public bool IsEmpty(bool considerRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x10512AC", Offset = "0x10512AC", VA = "0x10512AC")]
		public bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x10507A4", Offset = "0x10507A4", VA = "0x10507A4")]
		public Transform[] GetRagdollTransforms()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x10515B4", Offset = "0x10515B4", VA = "0x10515B4")]
		public static BipedRagdollReferences FromAvatar(Animator animator)
		{
			return default(BipedRagdollReferences);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1051830", Offset = "0x1051830", VA = "0x1051830")]
		public static BipedRagdollReferences FromBipedReferences(BipedReferences biped)
		{
			return default(BipedRagdollReferences);
		}
	}
	[Token(Token = "0x2000078")]
	public static class JointConverter
	{
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x10519D4", Offset = "0x10519D4", VA = "0x10519D4")]
		public static void ToConfigurable(GameObject root)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1051EDC", Offset = "0x1051EDC", VA = "0x1051EDC")]
		public static void HingeToConfigurable(HingeJoint src)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x10521CC", Offset = "0x10521CC", VA = "0x10521CC")]
		public static void FixedToConfigurable(FixedJoint src)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1052320", Offset = "0x1052320", VA = "0x1052320")]
		public static void SpringToConfigurable(SpringJoint src)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1051CA4", Offset = "0x1051CA4", VA = "0x1051CA4")]
		public static void CharacterToConfigurable(CharacterJoint src)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x10524C4", Offset = "0x10524C4", VA = "0x10524C4")]
		private static void ConvertJoint(ref ConfigurableJoint conf, Joint src)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x10525F0", Offset = "0x10525F0", VA = "0x10525F0")]
		private static SoftJointLimit ConvertToHighSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x105269C", Offset = "0x105269C", VA = "0x105269C")]
		private static SoftJointLimit ConvertToLowSoftJointLimit(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1052648", Offset = "0x1052648", VA = "0x1052648")]
		private static SoftJointLimitSpring ConvertToSoftJointLimitSpring(JointLimits src, JointSpring spring, bool useSpring)
		{
			return default(SoftJointLimitSpring);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x10526F4", Offset = "0x10526F4", VA = "0x10526F4")]
		private static SoftJointLimit CopyLimit(SoftJointLimit src)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1052750", Offset = "0x1052750", VA = "0x1052750")]
		private static SoftJointLimitSpring CopyLimitSpring(SoftJointLimitSpring src)
		{
			return default(SoftJointLimitSpring);
		}
	}
	[Token(Token = "0x2000079")]
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007A")]
		public enum ColliderType
		{
			[Token(Token = "0x4000399")]
			Box,
			[Token(Token = "0x400039A")]
			Capsule
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public enum JointType
		{
			[Token(Token = "0x400039C")]
			Configurable,
			[Token(Token = "0x400039D")]
			Character
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public enum Direction
		{
			[Token(Token = "0x400039F")]
			X,
			[Token(Token = "0x40003A0")]
			Y,
			[Token(Token = "0x40003A1")]
			Z
		}

		[Token(Token = "0x200007D")]
		public struct CreateJointParams
		{
			[Token(Token = "0x200007E")]
			public struct Limits
			{
				[Token(Token = "0x40003A8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float minSwing;

				[Token(Token = "0x40003A9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float maxSwing;

				[Token(Token = "0x40003AA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float swing2;

				[Token(Token = "0x40003AB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float twist;

				[Token(Token = "0x6000419")]
				[Address(RVA = "0x104F970", Offset = "0x104F970", VA = "0x104F970")]
				public Limits(float minSwing, float maxSwing, float swing2, float twist)
				{
				}
			}

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rigidbody rigidbody;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rigidbody connectedBody;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform child;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 worldSwingAxis;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Limits limits;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public JointType type;

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x104F97C", Offset = "0x104F97C", VA = "0x104F97C")]
			public CreateJointParams(Rigidbody rigidbody, Rigidbody connectedBody, Transform child, Vector3 worldSwingAxis, Limits limits, JointType type)
			{
			}
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x104CB98", Offset = "0x104CB98", VA = "0x104CB98")]
		public static void ClearAll(Transform root)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1050B8C", Offset = "0x1050B8C", VA = "0x1050B8C")]
		protected static void ClearTransform(Transform transform)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x104EA38", Offset = "0x104EA38", VA = "0x104EA38")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x104E6B0", Offset = "0x104E6B0", VA = "0x104E6B0")]
		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x105279C", Offset = "0x105279C", VA = "0x105279C")]
		protected static float GetScaleF(Transform t)
		{
			return default(float);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1052900", Offset = "0x1052900", VA = "0x1052900")]
		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1052910", Offset = "0x1052910", VA = "0x1052910")]
		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x105292C", Offset = "0x105292C", VA = "0x105292C")]
		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1052A0C", Offset = "0x1052A0C", VA = "0x1052A0C")]
		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x10527C8", Offset = "0x10527C8", VA = "0x10527C8")]
		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return default(int);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1052AEC", Offset = "0x1052AEC", VA = "0x1052AEC")]
		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1052D64", Offset = "0x1052D64", VA = "0x1052D64")]
		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x104FA20", Offset = "0x104FA20", VA = "0x104FA20")]
		protected static void CreateJoint(CreateJointParams p)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1052F04", Offset = "0x1052F04", VA = "0x1052F04")]
		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1050EC0", Offset = "0x1050EC0", VA = "0x1050EC0")]
		protected RagdollCreator()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[HelpURL("https://www.youtube.com/watch?v=y-luLRVmL7E&index=1&list=PLVxSIA1OaTOuE2SB9NUbckQ9r2hTg4mvL")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/Ragdoll Manager/Ragdoll Editor")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000080")]
		public enum Mode
		{
			[Token(Token = "0x40003B1")]
			Colliders,
			[Token(Token = "0x40003B2")]
			Joints
		}

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public Collider selectedCollider;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool symmetry;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public Mode mode;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1052F34", Offset = "0x1052F34", VA = "0x1052F34")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1052F78", Offset = "0x1052F78", VA = "0x1052F78")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1052FBC", Offset = "0x1052FBC", VA = "0x1052FBC")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1053000", Offset = "0x1053000", VA = "0x1053000")]
		public RagdollEditor()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000081")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000082")]
		public class Offset
		{
			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x10530CC", Offset = "0x10530CC", VA = "0x10530CC")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x1053348", Offset = "0x1053348", VA = "0x1053348")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1053010", Offset = "0x1053010", VA = "0x1053010")]
		private void Start()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1053068", Offset = "0x1053068", VA = "0x1053068")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x105327C", Offset = "0x105327C", VA = "0x105327C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1053340", Offset = "0x1053340", VA = "0x1053340")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x2000083")]
	[RequireComponent(typeof(Animator))]
	public class AnimatorIKDemo : MonoBehaviour
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftHandIKTarget;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1053350", Offset = "0x1053350", VA = "0x1053350")]
		private void Start()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10533A8", Offset = "0x10533A8", VA = "0x10533A8")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1053400", Offset = "0x1053400", VA = "0x1053400")]
		public AnimatorIKDemo()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class BallShooter : MonoBehaviour
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode keyCode;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ball;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 spawnOffset;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 force;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float mass;

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1053408", Offset = "0x1053408", VA = "0x1053408")]
		private void Update()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1053624", Offset = "0x1053624", VA = "0x1053624")]
		public BallShooter()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class BoardController : MonoBehaviour
	{
		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int groundLayer;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationTarget;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float torque;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float skidDrag;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float turnSensitivity;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody r;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isGrounded;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1053650", Offset = "0x1053650", VA = "0x1053650")]
		private void Awake()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10536A8", Offset = "0x10536A8", VA = "0x10536A8")]
		private void Update()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1053840", Offset = "0x1053840", VA = "0x1053840")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1053C08", Offset = "0x1053C08", VA = "0x1053C08")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1053C58", Offset = "0x1053C58", VA = "0x1053C58")]
		private void OnCollisionStay(Collision c)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1053CA8", Offset = "0x1053CA8", VA = "0x1053CA8")]
		private void OnCollisionExit(Collision c)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1053CF4", Offset = "0x1053CF4", VA = "0x1053CF4")]
		public BoardController()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class CharacterAnimationMeleeDemo : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x17000070")]
		private CharacterMeleeDemo melee
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1053D18", Offset = "0x1053D18", VA = "0x1053D18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1053D94", Offset = "0x1053D94", VA = "0x1053D94", Slot = "9")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1053EC4", Offset = "0x1053EC4", VA = "0x1053EC4")]
		public CharacterAnimationMeleeDemo()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class CharacterMeleeDemo : CharacterPuppet
	{
		[Serializable]
		[Token(Token = "0x2000088")]
		public class Action
		{
			[Serializable]
			[Token(Token = "0x2000089")]
			public class Anim
			{
				[Token(Token = "0x40003D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string stateName;

				[Token(Token = "0x40003D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public int layer;

				[Token(Token = "0x40003D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public float transitionDuration;

				[Token(Token = "0x40003D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public float fixedTime;

				[Token(Token = "0x6000439")]
				[Address(RVA = "0x1054438", Offset = "0x1054438", VA = "0x1054438")]
				public Anim()
				{
				}
			}

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int inputActionIndex;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float duration;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float minFrequency;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Anim anim;

			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] requiredPropTypes;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Booster[] boosters;

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1054428", Offset = "0x1054428", VA = "0x1054428")]
			public Action()
			{
			}
		}

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[Header("Melee")]
		public Action[] actions;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[HideInInspector]
		public int currentActionIndex;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[HideInInspector]
		public float lastActionTime;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private float lastActionMoveMag;

		[Token(Token = "0x17000071")]
		public Action currentAction
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x1053E84", Offset = "0x1053E84", VA = "0x1053E84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1053ECC", Offset = "0x1053ECC", VA = "0x1053ECC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1053F58", Offset = "0x1053F58", VA = "0x1053F58", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1054294", Offset = "0x1054294", VA = "0x1054294")]
		private bool StartAction(Action action)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1054410", Offset = "0x1054410", VA = "0x1054410")]
		public CharacterMeleeDemo()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Header("Puppet")]
		public PropMuscle propMuscle;

		[Token(Token = "0x17000072")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1054440", Offset = "0x1054440", VA = "0x1054440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x1054448", Offset = "0x1054448", VA = "0x1054448")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1053ED8", Offset = "0x1053ED8", VA = "0x1053ED8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1054458", Offset = "0x1054458", VA = "0x1054458", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x10544D8", Offset = "0x10544D8", VA = "0x10544D8", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x10546D0", Offset = "0x10546D0", VA = "0x10546D0", Slot = "10")]
		protected override bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1054420", Offset = "0x1054420", VA = "0x1054420")]
		public CharacterPuppet()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class CreatePuppetInRuntime : MonoBehaviour
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Creating a Puppet from a ragdoll character prefab.")]
		public Transform ragdollPrefab;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("What will the Puppet be named?")]
		public string instanceName;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1054700", Offset = "0x1054700", VA = "0x1054700")]
		private void Start()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x105486C", Offset = "0x105486C", VA = "0x105486C")]
		public CreatePuppetInRuntime()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class CreateRagdollInRuntime : MonoBehaviour
	{
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The character prefab/FBX.")]
		public GameObject prefab;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x10548C4", Offset = "0x10548C4", VA = "0x10548C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1054A0C", Offset = "0x1054A0C", VA = "0x1054A0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1054A10", Offset = "0x1054A10", VA = "0x1054A10")]
		public CreateRagdollInRuntime()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class DeathBaker : MonoBehaviour
	{
		[Token(Token = "0x200008E")]
		[CompilerGenerated]
		private sealed class <Bake>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x1054FD4", Offset = "0x1054FD4", VA = "0x1054FD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x105501C", Offset = "0x105501C", VA = "0x105501C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x1054E0C", Offset = "0x1054E0C", VA = "0x1054E0C")]
			[DebuggerHidden]
			public <Bake>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x1054EF8", Offset = "0x1054EF8", VA = "0x1054EF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x1054EFC", Offset = "0x1054EFC", VA = "0x1054EFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x1054FDC", Offset = "0x1054FDC", VA = "0x1054FDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class <FadeOutPinWeight>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x10550DC", Offset = "0x10550DC", VA = "0x10550DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x1055124", Offset = "0x1055124", VA = "0x1055124", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x1054E34", Offset = "0x1054E34", VA = "0x1054E34")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x1055024", Offset = "0x1055024", VA = "0x1055024", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1055028", Offset = "0x1055028", VA = "0x1055028", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x10550E4", Offset = "0x10550E4", VA = "0x10550E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class <FadeOutMuscleWeight>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DeathBaker <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x10551E4", Offset = "0x10551E4", VA = "0x10551E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x105522C", Offset = "0x105522C", VA = "0x105522C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000458")]
			[Address(RVA = "0x1054E5C", Offset = "0x1054E5C", VA = "0x1054E5C")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0x105512C", Offset = "0x105512C", VA = "0x105512C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0x1055130", Offset = "0x1055130", VA = "0x1055130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x10551EC", Offset = "0x10551EC", VA = "0x10551EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the HumanoidBaker to bake PuppetMaster phsycics to AnimationClips.")]
		public HumanoidBaker baker;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The duration of baking in seconds.")]
		public float bakeTime;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The speed of fading out PuppetMaster.pinWeight.")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The speed of fading out PuppetMaster.muscleWeight.")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The muscle weight to fade out to.")]
		public float deadMuscleWeight;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool isDead;

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1054A18", Offset = "0x1054A18", VA = "0x1054A18")]
		private void Start()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1054AB8", Offset = "0x1054AB8", VA = "0x1054AB8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1054D98", Offset = "0x1054D98", VA = "0x1054D98")]
		[IteratorStateMachine(typeof(<Bake>d__12))]
		private IEnumerator Bake()
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1054CB0", Offset = "0x1054CB0", VA = "0x1054CB0")]
		[IteratorStateMachine(typeof(<FadeOutPinWeight>d__13))]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1054D24", Offset = "0x1054D24", VA = "0x1054D24")]
		[IteratorStateMachine(typeof(<FadeOutMuscleWeight>d__14))]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1054E84", Offset = "0x1054E84", VA = "0x1054E84")]
		public DeathBaker()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class <Destruct>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Destructor <>4__this;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x10553FC", Offset = "0x10553FC", VA = "0x10553FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1055444", Offset = "0x1055444", VA = "0x1055444", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x10552C8", Offset = "0x10552C8", VA = "0x10552C8")]
			[DebuggerHidden]
			public <Destruct>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1055300", Offset = "0x1055300", VA = "0x1055300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1055304", Offset = "0x1055304", VA = "0x1055304", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x1055404", Offset = "0x1055404", VA = "0x1055404", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1055234", Offset = "0x1055234", VA = "0x1055234")]
		private void Start()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1055254", Offset = "0x1055254", VA = "0x1055254")]
		[IteratorStateMachine(typeof(<Destruct>d__2))]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x10552F0", Offset = "0x10552F0", VA = "0x10552F0")]
		public Destructor()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class <FadeOutPinWeight>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600046F")]
				[Address(RVA = "0x1055910", Offset = "0x1055910", VA = "0x1055910", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x1055958", Offset = "0x1055958", VA = "0x1055958", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x105579C", Offset = "0x105579C", VA = "0x105579C")]
			[DebuggerHidden]
			public <FadeOutPinWeight>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1055858", Offset = "0x1055858", VA = "0x1055858", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x105585C", Offset = "0x105585C", VA = "0x105585C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000470")]
			[Address(RVA = "0x1055918", Offset = "0x1055918", VA = "0x1055918", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class <FadeOutMuscleWeight>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dying <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000475")]
				[Address(RVA = "0x1055A18", Offset = "0x1055A18", VA = "0x1055A18", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x1055A60", Offset = "0x1055A60", VA = "0x1055A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x10557C4", Offset = "0x10557C4", VA = "0x10557C4")]
			[DebuggerHidden]
			public <FadeOutMuscleWeight>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1055960", Offset = "0x1055960", VA = "0x1055960", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x1055964", Offset = "0x1055964", VA = "0x1055964", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x1055A20", Offset = "0x1055A20", VA = "0x1055A20", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The speed of fading out PuppetMaster.pinWeight.")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The speed of fading out PuppetMaster.muscleWeight.")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The muscle weight to fade out to.")]
		public float deadMuscleWeight;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x105544C", Offset = "0x105544C", VA = "0x105544C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x10554EC", Offset = "0x10554EC", VA = "0x10554EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10556B4", Offset = "0x10556B4", VA = "0x10556B4")]
		[IteratorStateMachine(typeof(<FadeOutPinWeight>d__10))]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1055728", Offset = "0x1055728", VA = "0x1055728")]
		[IteratorStateMachine(typeof(<FadeOutMuscleWeight>d__11))]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10557EC", Offset = "0x10557EC", VA = "0x10557EC")]
		public Dying()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[RequireComponent(typeof(ParticleSystem))]
	public class FXCollisionBlood : MonoBehaviour
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minCollisionImpulse;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int emission;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float emissionImpulseAdd;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int maxEmission;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem particles;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1055A68", Offset = "0x1055A68", VA = "0x1055A68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1055B78", Offset = "0x1055B78", VA = "0x1055B78")]
		private void OnCollisionImpulse(MuscleCollision m, float impulse)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1055DB8", Offset = "0x1055DB8", VA = "0x1055DB8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1055EE0", Offset = "0x1055EE0", VA = "0x1055EE0")]
		public FXCollisionBlood()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class Grab : MonoBehaviour
	{
		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The PuppetMaster this muscle belongs to.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Used for switching walk/run by default.")]
		public UserControlMelee userControl;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The layers we wish to grab (optimization).")]
		public int grabLayer;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool grabbed;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider c;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BehaviourPuppet otherPuppet;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider otherCollider;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConfigurableJoint joint;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float nextGrabTime;

		[Token(Token = "0x4000412")]
		private const float massMlp = 5f;

		[Token(Token = "0x4000413")]
		private const int solverIterationMlp = 10;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1055F00", Offset = "0x1055F00", VA = "0x1055F00")]
		private void Start()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1055F90", Offset = "0x1055F90", VA = "0x1055F90")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x1056384", Offset = "0x1056384", VA = "0x1056384")]
		private void Update()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x10564BC", Offset = "0x10564BC", VA = "0x10564BC")]
		public Grab()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class Killing : MonoBehaviour
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the PuppetMaster component.")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Settings for killing and freezing the puppet.")]
		public PuppetMaster.StateSettings stateSettings;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x10703F0", Offset = "0x10703F0", VA = "0x10703F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x10704B4", Offset = "0x10704B4", VA = "0x10704B4")]
		public Killing()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("References")]
		[Tooltip("Reference to the character controller gameobject (the one that has the capsule collider/CharacterController.")]
		public Transform characterController;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Layers")]
		[Tooltip("The layer to assign the character controller to. Collisions between this layer and the 'Ragdoll Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int characterControllerLayer;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The layer to assign the PuppetMaster and all it's muscles to. Collisions between this layer and the 'Character Controller Layer' will be ignored, or else the ragdoll would collide with the character controller.")]
		public int ragdollLayer;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Layers that will be ignored by the character controller")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Layers that will not collide with the Ragdoll layer.")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x10704FC", Offset = "0x10704FC", VA = "0x10704FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1070700", Offset = "0x1070700", VA = "0x1070700")]
		public LayerSetup()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class NavMeshPuppet : MonoBehaviour
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NavMeshAgent agent;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Animator animator;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1070708", Offset = "0x1070708", VA = "0x1070708")]
		private void Update()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1070854", Offset = "0x1070854", VA = "0x1070854")]
		public NavMeshPuppet()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class Planet : MonoBehaviour
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float mass;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x107085C", Offset = "0x107085C", VA = "0x107085C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x107094C", Offset = "0x107094C", VA = "0x107094C")]
		public Planet()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class PlanetaryGravity : MonoBehaviour
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Planet planet;

		[Token(Token = "0x4000422")]
		private const float G = 6.672E-11f;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody _r;

		[Token(Token = "0x1700007F")]
		private Rigidbody r
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x107095C", Offset = "0x107095C", VA = "0x107095C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1070A04", Offset = "0x1070A04", VA = "0x1070A04")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1070AD4", Offset = "0x1070AD4", VA = "0x1070AD4")]
		private void ApplyGravity(Rigidbody r)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1070BD0", Offset = "0x1070BD0", VA = "0x1070BD0")]
		public PlanetaryGravity()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class PropDemo : MonoBehaviour
	{
		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Prop you wish to pick up.")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Prop Muscle of the left hand.")]
		public PropMuscle propMuscleLeft;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Prop Muscle of the right hand.")]
		public PropMuscle propMuscleRight;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true, the prop will be picked up when PuppetMaster initiates")]
		public bool pickUpOnAwake;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool right;

		[Token(Token = "0x17000080")]
		private PropMuscle connectTo
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x1070C20", Offset = "0x1070C20", VA = "0x1070C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1070BD8", Offset = "0x1070BD8", VA = "0x1070BD8")]
		private void Start()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1070C3C", Offset = "0x1070C3C", VA = "0x1070C3C")]
		private void Update()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1070D04", Offset = "0x1070D04", VA = "0x1070D04")]
		public PropDemo()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class <Action>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropMelee <>4__this;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <additionalPinMuscleIndex>5__2;

			[Token(Token = "0x17000081")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000499")]
				[Address(RVA = "0x10711D4", Offset = "0x10711D4", VA = "0x10711D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000082")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x107121C", Offset = "0x107121C", VA = "0x107121C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1070DD4", Offset = "0x1070DD4", VA = "0x1070DD4")]
			[DebuggerHidden]
			public <Action>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x1070FB0", Offset = "0x1070FB0", VA = "0x1070FB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1070FB4", Offset = "0x1070FB4", VA = "0x1070FB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x10711DC", Offset = "0x10711DC", VA = "0x10711DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[LargeHeader("Melee")]
		[Tooltip("Switch to a CapsuleCollider when the prop is picked up so it behaves more smoothly when colliding with objects.")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("The default BoxCollider used when this prop is not picked up.")]
		public BoxCollider boxCollider;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("Temporarily increase the radius of the capsule collider when a hitting action is triggered, so it would not pass colliders too easily.")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Tooltip("Temporarily set (increase) the pin weight of the additional pin when a hitting action is triggered.")]
		[Range(0f, 1f)]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("Temporarily increase the mass of the Rigidbody when a hitting action is triggered.")]
		[Range(0.1f, 10f)]
		public float actionMassMlp;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Tooltip("Offset to the default center of mass of the Rigidbody (might improve prop handling).")]
		public Vector3 COMOffset;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float defaultMass;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float defaultAddMass;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Rigidbody r;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1070D14", Offset = "0x1070D14", VA = "0x1070D14")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1070D50", Offset = "0x1070D50", VA = "0x1070D50")]
		[IteratorStateMachine(typeof(<Action>d__11))]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1070DFC", Offset = "0x1070DFC", VA = "0x1070DFC", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1070EC0", Offset = "0x1070EC0", VA = "0x1070EC0", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1070F2C", Offset = "0x1070F2C", VA = "0x1070F2C", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1070F98", Offset = "0x1070F98", VA = "0x1070F98")]
		public PropMelee()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class PropPickUpTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterProp prop;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask characterLayers;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterPuppet characterPuppet;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1071224", Offset = "0x1071224", VA = "0x1071224")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x10713B4", Offset = "0x10713B4", VA = "0x10713B4")]
		public PropPickUpTrigger()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class PuppetBoard : MonoBehaviour
	{
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Board target Rigidbody.")]
		public Rigidbody target;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Pivot Transform of the body target.")]
		public Transform bodyTargetPivot;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The body target keeps the puppet upright by a SpringJoint connected to the body.")]
		public Transform bodyTarget;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody r;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x10713BC", Offset = "0x10713BC", VA = "0x10713BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1071468", Offset = "0x1071468", VA = "0x1071468")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1071650", Offset = "0x1071650", VA = "0x1071650")]
		public PuppetBoard()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class PuppetMasterPropMelee : PuppetMasterProp
	{
		[Token(Token = "0x20000A3")]
		[CompilerGenerated]
		private sealed class <Action>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMasterPropMelee <>4__this;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x17000083")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0x10719CC", Offset = "0x10719CC", VA = "0x10719CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000084")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004AC")]
				[Address(RVA = "0x1071A14", Offset = "0x1071A14", VA = "0x1071A14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x1071718", Offset = "0x1071718", VA = "0x1071718")]
			[DebuggerHidden]
			public <Action>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x10718B4", Offset = "0x10718B4", VA = "0x10718B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x10718B8", Offset = "0x10718B8", VA = "0x10718B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x10719D4", Offset = "0x10719D4", VA = "0x10719D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("Switch to a CapsuleCollider when the prop is picked up so it behaves more smoothly when colliding with objects.")]
		[LargeHeader("Melee")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("The default BoxCollider used when this prop is not picked up.")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Temporarily increase the radius of the capsule collider when a hitting action is triggered, so it would not pass colliders too easily.")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("Temporarily set (increase) the pin weight of the additional pin when a hitting action is triggered.")]
		[Range(0f, 1f)]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Range(1f, 10f)]
		[Tooltip("Temporarily increase the mass of the Rigidbody when a hitting action is triggered.")]
		public float actionMassMlp;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("Offset to the default center of mass of the Rigidbody (might improve prop handling).")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float defaultMass;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float defaultAdditionalPinWeight;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1071658", Offset = "0x1071658", VA = "0x1071658")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1071694", Offset = "0x1071694", VA = "0x1071694")]
		[IteratorStateMachine(typeof(<Action>d__10))]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1071740", Offset = "0x1071740", VA = "0x1071740", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x10717A0", Offset = "0x10717A0", VA = "0x10717A0", Slot = "4")]
		protected override void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1071844", Offset = "0x1071844", VA = "0x1071844", Slot = "5")]
		protected override void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x107189C", Offset = "0x107189C", VA = "0x107189C")]
		public PuppetMasterPropMelee()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class PuppetScaling : MonoBehaviour
	{
		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0.01f, 10f)]
		public float masterScale;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int muscleIndex;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0.01f, 10f)]
		public float muscleScale;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float defaultMuscleSpring;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1071A1C", Offset = "0x1071A1C", VA = "0x1071A1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1071A44", Offset = "0x1071A44", VA = "0x1071A44")]
		private void Update()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1071DF4", Offset = "0x1071DF4", VA = "0x1071DF4")]
		public PuppetScaling()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class RaycastShooter : MonoBehaviour
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layers;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unpin;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem blood;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1071E08", Offset = "0x1071E08", VA = "0x1071E08")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1072054", Offset = "0x1072054", VA = "0x1072054")]
		public RaycastShooter()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Respawning : MonoBehaviour
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Pooled characters will be parented to this deactivated GameObject.")]
		public Transform pool;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the BehaviourPuppet component of the character you wish to respawn.")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The animation to play on respawn.")]
		public string idleAnimation;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform puppetRoot;

		[Token(Token = "0x17000085")]
		private bool isPooled
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1072064", Offset = "0x1072064", VA = "0x1072064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x10720EC", Offset = "0x10720EC", VA = "0x10720EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1072148", Offset = "0x1072148", VA = "0x1072148")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x107226C", Offset = "0x107226C", VA = "0x107226C")]
		private void Pool()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1072290", Offset = "0x1072290", VA = "0x1072290")]
		private void Respawn(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x10723A4", Offset = "0x10723A4", VA = "0x10723A4")]
		public Respawning()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class RotateShoulderToTarget : MonoBehaviour
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform shoulder;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 euler;

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x10723AC", Offset = "0x10723AC", VA = "0x10723AC")]
		private void OnPuppetMasterRead()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x107249C", Offset = "0x107249C", VA = "0x107249C")]
		public RotateShoulderToTarget()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class SkeletonDisconnector : MonoBehaviour
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BehaviourPuppet puppet;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleDisconnectMode disconnectMuscleMode;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PuppetMasterProp prop;

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x10724A4", Offset = "0x10724A4", VA = "0x10724A4")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1072864", Offset = "0x1072864", VA = "0x1072864")]
		public SkeletonDisconnector()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class SkeletonShooter : MonoBehaviour
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Skeleton skeleton;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuscleRemoveMode removeMuscleMode;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask layers;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float unpin;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float force;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParticleSystem particles;

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1072874", Offset = "0x1072874", VA = "0x1072874")]
		private void Update()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1072BA8", Offset = "0x1072BA8", VA = "0x1072BA8")]
		public SkeletonShooter()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x17000086")]
		private Transform moveTarget
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x1072BB8", Offset = "0x1072BB8", VA = "0x1072BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1072C00", Offset = "0x1072C00", VA = "0x1072C00", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1072EE4", Offset = "0x1072EE4", VA = "0x1072EE4")]
		private bool CanAttack()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1073028", Offset = "0x1073028", VA = "0x1073028")]
		public UserControlAIMelee()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1073054", Offset = "0x1073054", VA = "0x1073054", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x10733C0", Offset = "0x10733C0", VA = "0x10733C0")]
		public UserControlMelee()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x17000087")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x10733F0", Offset = "0x10733F0", VA = "0x10733F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x10733D0", Offset = "0x10733D0", VA = "0x10733D0", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x10733F8", Offset = "0x10733F8", VA = "0x10733F8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1073458", Offset = "0x1073458", VA = "0x1073458", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x10735DC", Offset = "0x10735DC", VA = "0x10735DC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1073858", Offset = "0x1073858", VA = "0x1073858", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x10735EC", Offset = "0x10735EC", VA = "0x10735EC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1073868", Offset = "0x1073868", VA = "0x1073868")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1073880", Offset = "0x1073880", VA = "0x1073880", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x10738E0", Offset = "0x10738E0", VA = "0x10738E0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1073970", Offset = "0x1073970", VA = "0x1073970")]
		private void Update()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1073A94", Offset = "0x1073A94", VA = "0x1073A94")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000483")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000484")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x17000088")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1073B50", Offset = "0x1073B50", VA = "0x1073B50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1073AAC", Offset = "0x1073AAC", VA = "0x1073AAC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1073B34", Offset = "0x1073B34", VA = "0x1073B34", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1073C44", Offset = "0x1073C44", VA = "0x1073C44", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1074034", Offset = "0x1074034", VA = "0x1074034")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x107415C", Offset = "0x107415C", VA = "0x107415C")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		[Header("Base Parameters")]
		public Transform gravityTarget;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000492")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60004D6")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1074180", Offset = "0x1074180", VA = "0x1074180")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x107436C", Offset = "0x107436C", VA = "0x107436C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1074598", Offset = "0x1074598", VA = "0x1074598", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1074738", Offset = "0x1074738", VA = "0x1074738")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1074798", Offset = "0x1074798", VA = "0x1074798")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x10748FC", Offset = "0x10748FC", VA = "0x10748FC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1074B00", Offset = "0x1074B00", VA = "0x1074B00")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1074B24", Offset = "0x1074B24", VA = "0x1074B24")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1074B48", Offset = "0x1074B48", VA = "0x1074B48")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1074C94", Offset = "0x1074C94", VA = "0x1074C94")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public enum MoveMode
		{
			[Token(Token = "0x40004D0")]
			Directional,
			[Token(Token = "0x40004D1")]
			Strafe
		}

		[Token(Token = "0x20000B2")]
		public struct AnimState
		{
			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004F6")]
				[Address(RVA = "0x1077728", Offset = "0x1077728", VA = "0x1077728", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004F8")]
				[Address(RVA = "0x1077770", Offset = "0x1077770", VA = "0x1077770", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x10774E8", Offset = "0x10774E8", VA = "0x10774E8")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x1077624", Offset = "0x1077624", VA = "0x1077624", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x1077628", Offset = "0x1077628", VA = "0x1077628", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x1077730", Offset = "0x1077730", VA = "0x1077730", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x17000089")]
		public bool onGround
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1074CB4", Offset = "0x1074CB4", VA = "0x1074CB4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1074CBC", Offset = "0x1074CBC", VA = "0x1074CBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1074CC8", Offset = "0x1074CC8", VA = "0x1074CC8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1074EB4", Offset = "0x1074EB4", VA = "0x1074EB4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1074F38", Offset = "0x1074F38", VA = "0x1074F38", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x107504C", Offset = "0x107504C", VA = "0x107504C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1076074", Offset = "0x1076074", VA = "0x1076074", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1076504", Offset = "0x1076504", VA = "0x1076504", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1075700", Offset = "0x1075700", VA = "0x1075700")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x10765DC", Offset = "0x10765DC", VA = "0x10765DC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1076C64", Offset = "0x1076C64", VA = "0x1076C64")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1076100", Offset = "0x1076100", VA = "0x1076100")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1076D54", Offset = "0x1076D54", VA = "0x1076D54", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x10771D4", Offset = "0x10771D4", VA = "0x10771D4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x10772FC", Offset = "0x10772FC", VA = "0x10772FC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1077450", Offset = "0x1077450", VA = "0x1077450")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1075B14", Offset = "0x1075B14", VA = "0x1075B14")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1077510", Offset = "0x1077510", VA = "0x1077510")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public enum RotationMode
		{
			[Token(Token = "0x40004ED")]
			Smooth,
			[Token(Token = "0x40004EE")]
			Linear
		}

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700008C")]
		public bool isGrounded
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x1077778", Offset = "0x1077778", VA = "0x1077778")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x1077780", Offset = "0x1077780", VA = "0x1077780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x107778C", Offset = "0x107778C", VA = "0x107778C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1077834", Offset = "0x1077834", VA = "0x1077834")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1077E4C", Offset = "0x1077E4C", VA = "0x1077E4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x107787C", Offset = "0x107787C", VA = "0x107787C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1077BE4", Offset = "0x1077BE4", VA = "0x1077BE4")]
		private void Move()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1077E7C", Offset = "0x1077E7C", VA = "0x1077E7C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1077F14", Offset = "0x1077F14", VA = "0x1077F14")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1077F94", Offset = "0x1077F94", VA = "0x1077F94")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1077FBC", Offset = "0x1077FBC", VA = "0x1077FBC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1078104", Offset = "0x1078104", VA = "0x1078104", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x107877C", Offset = "0x107877C", VA = "0x107877C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1078968", Offset = "0x1078968", VA = "0x1078968")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		public struct State
		{
			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1077FF8", Offset = "0x1077FF8", VA = "0x1077FF8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x107307C", Offset = "0x107307C", VA = "0x107307C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1073044", Offset = "0x1073044", VA = "0x1073044")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1078984", Offset = "0x1078984", VA = "0x1078984")]
		private void Update()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x10789BC", Offset = "0x10789BC", VA = "0x10789BC")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x10789C4", Offset = "0x10789C4", VA = "0x10789C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x10789EC", Offset = "0x10789EC", VA = "0x10789EC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1078A90", Offset = "0x1078A90", VA = "0x1078A90")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BB")]
	public class Navigator
	{
		[Token(Token = "0x20000BC")]
		public enum State
		{
			[Token(Token = "0x4000510")]
			Idle,
			[Token(Token = "0x4000511")]
			Seeking,
			[Token(Token = "0x4000512")]
			OnPath
		}

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700008D")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x1078AA4", Offset = "0x1078AA4", VA = "0x1078AA4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x1078AB0", Offset = "0x1078AB0", VA = "0x1078AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public State state
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1078ABC", Offset = "0x1078ABC", VA = "0x1078ABC")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x1078AC4", Offset = "0x1078AC4", VA = "0x1078AC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x107802C", Offset = "0x107802C", VA = "0x107802C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1078324", Offset = "0x1078324", VA = "0x1078324")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1078BA4", Offset = "0x1078BA4", VA = "0x1078BA4")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1078C08", Offset = "0x1078C08", VA = "0x1078C08")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1078ACC", Offset = "0x1078ACC", VA = "0x1078ACC")]
		private void Stop()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1078B28", Offset = "0x1078B28", VA = "0x1078B28")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x10787A4", Offset = "0x10787A4", VA = "0x10787A4")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1078D3C", Offset = "0x1078D3C", VA = "0x1078D3C")]
		public Navigator()
		{
		}
	}
}
