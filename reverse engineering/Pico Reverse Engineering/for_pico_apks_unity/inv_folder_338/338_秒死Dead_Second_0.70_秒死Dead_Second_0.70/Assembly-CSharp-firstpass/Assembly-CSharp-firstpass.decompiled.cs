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
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x17000001")]
		public bool isBaking
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x9734AC", Offset = "0x9734AC", VA = "0x9734AC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x9734B4", Offset = "0x9734B4", VA = "0x9734B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float bakingProgress
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x9734C0", Offset = "0x9734C0", VA = "0x9734C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x9734C8", Offset = "0x9734C8", VA = "0x9734C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		protected float clipLength
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x9734D0", Offset = "0x9734D0", VA = "0x9734D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x9734D8", Offset = "0x9734D8", VA = "0x9734D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x97339C", Offset = "0x97339C", VA = "0x97339C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x9733E0", Offset = "0x9733E0", VA = "0x9733E0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x973424", Offset = "0x973424", VA = "0x973424")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x973468", Offset = "0x973468", VA = "0x973468")]
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
		[Address(RVA = "0x9734E0", Offset = "0x9734E0", VA = "0x9734E0")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x9734E4", Offset = "0x9734E4", VA = "0x9734E4")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x9734E8", Offset = "0x9734E8", VA = "0x9734E8")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x9734EC", Offset = "0x9734EC", VA = "0x9734EC")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
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
		[Address(RVA = "0x9735E4", Offset = "0x9735E4", VA = "0x9735E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x973A00", Offset = "0x973A00", VA = "0x973A00", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x973A08", Offset = "0x973A08", VA = "0x973A08", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x973BF4", Offset = "0x973BF4", VA = "0x973BF4", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x973E58", Offset = "0x973E58", VA = "0x973E58", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x974170", Offset = "0x974170", VA = "0x974170", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x9737FC", Offset = "0x9737FC", VA = "0x9737FC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x9738B4", Offset = "0x9738B4", VA = "0x9738B4")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x9743D0", Offset = "0x9743D0", VA = "0x9743D0")]
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
		[Address(RVA = "0x97442C", Offset = "0x97442C", VA = "0x97442C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000006")]
	public class AvatarUtility
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x974490", Offset = "0x974490", VA = "0x974490")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9746E0", Offset = "0x9746E0", VA = "0x9746E0")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9746C0", Offset = "0x9746C0", VA = "0x9746C0")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x974D38", Offset = "0x974D38", VA = "0x974D38")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x974D40", Offset = "0x974D40", VA = "0x974D40")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x974D78", Offset = "0x974D78", VA = "0x974D78")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x97513C", Offset = "0x97513C", VA = "0x97513C")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x97531C", Offset = "0x97531C", VA = "0x97531C")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x975320", Offset = "0x975320", VA = "0x975320")]
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
		[Address(RVA = "0x9754B4", Offset = "0x9754B4", VA = "0x9754B4")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x975770", Offset = "0x975770", VA = "0x975770")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x97562C", Offset = "0x97562C", VA = "0x97562C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x9758F8", Offset = "0x9758F8", VA = "0x9758F8")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x975C88", Offset = "0x975C88", VA = "0x975C88")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x975D78", Offset = "0x975D78", VA = "0x975D78")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x975E5C", Offset = "0x975E5C", VA = "0x975E5C")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x975DE0", Offset = "0x975DE0", VA = "0x975DE0")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x975EC4", Offset = "0x975EC4", VA = "0x975EC4")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x975F6C", Offset = "0x975F6C", VA = "0x975F6C")]
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
		[Address(RVA = "0x976258", Offset = "0x976258", VA = "0x976258")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x9762BC", Offset = "0x9762BC", VA = "0x9762BC")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x976D50", Offset = "0x976D50", VA = "0x976D50")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x976DF8", Offset = "0x976DF8", VA = "0x976DF8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x976CF0", Offset = "0x976CF0", VA = "0x976CF0")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x976EEC", Offset = "0x976EEC", VA = "0x976EEC")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x976F28", Offset = "0x976F28", VA = "0x976F28")]
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
		[Address(RVA = "0x97396C", Offset = "0x97396C", VA = "0x97396C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x973BE0", Offset = "0x973BE0", VA = "0x973BE0")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x973EBC", Offset = "0x973EBC", VA = "0x973EBC")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x976F30", Offset = "0x976F30", VA = "0x976F30")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x973AD8", Offset = "0x973AD8", VA = "0x973AD8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x9771B8", Offset = "0x9771B8", VA = "0x9771B8")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x9741DC", Offset = "0x9741DC", VA = "0x9741DC")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x973C60", Offset = "0x973C60", VA = "0x973C60")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(1f, 9f)]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
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
		[Address(RVA = "0x977220", Offset = "0x977220", VA = "0x977220")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x9776D8", Offset = "0x9776D8", VA = "0x9776D8", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x9776F4", Offset = "0x9776F4", VA = "0x9776F4", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x9777D0", Offset = "0x9777D0", VA = "0x9777D0", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x97788C", Offset = "0x97788C", VA = "0x97788C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x977A2C", Offset = "0x977A2C", VA = "0x977A2C", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x977D40", Offset = "0x977D40", VA = "0x977D40")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x977E18", Offset = "0x977E18", VA = "0x977E18")]
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
			[Token(Token = "0x4000077")]
			Update,
			[Token(Token = "0x4000078")]
			FixedUpdate,
			[Token(Token = "0x4000079")]
			LateUpdate,
			[Token(Token = "0x400007A")]
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
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
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
		[Header("Distance")]
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
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x977EBC", Offset = "0x977EBC", VA = "0x977EBC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x977EC4", Offset = "0x977EC4", VA = "0x977EC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x977ECC", Offset = "0x977ECC", VA = "0x977ECC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x977ED4", Offset = "0x977ED4", VA = "0x977ED4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x977EDC", Offset = "0x977EDC", VA = "0x977EDC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x977EE4", Offset = "0x977EE4", VA = "0x977EE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x97893C", Offset = "0x97893C", VA = "0x97893C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x977EEC", Offset = "0x977EEC", VA = "0x977EEC")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x977F24", Offset = "0x977F24", VA = "0x977F24")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x977F2C", Offset = "0x977F2C", VA = "0x977F2C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x978054", Offset = "0x978054", VA = "0x978054", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x97809C", Offset = "0x97809C", VA = "0x97809C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x9780F4", Offset = "0x9780F4", VA = "0x9780F4", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x97814C", Offset = "0x97814C", VA = "0x97814C")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x978080", Offset = "0x978080", VA = "0x978080")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x9782D8", Offset = "0x9782D8", VA = "0x9782D8")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x978900", Offset = "0x978900", VA = "0x978900")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x9789A8", Offset = "0x9789A8", VA = "0x9789A8")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x978A70", Offset = "0x978A70", VA = "0x978A70")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x978A9C", Offset = "0x978A9C", VA = "0x978A9C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x978CC0", Offset = "0x978CC0", VA = "0x978CC0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x978CFC", Offset = "0x978CFC", VA = "0x978CFC")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public enum Axis
	{
		[Token(Token = "0x4000081")]
		X,
		[Token(Token = "0x4000082")]
		Y,
		[Token(Token = "0x4000083")]
		Z
	}
	[Token(Token = "0x2000010")]
	public class AxisTools
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x978D18", Offset = "0x978D18", VA = "0x978D18")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x978DF8", Offset = "0x978DF8", VA = "0x978DF8")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x978E30", Offset = "0x978E30", VA = "0x978E30")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x978F78", Offset = "0x978F78", VA = "0x978F78")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x978F2C", Offset = "0x978F2C", VA = "0x978F2C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x979074", Offset = "0x979074", VA = "0x979074")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x9790B8", Offset = "0x9790B8", VA = "0x9790B8")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x979544", Offset = "0x979544", VA = "0x979544")]
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
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x979840", Offset = "0x979840", VA = "0x979840")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000008")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x97958C", Offset = "0x97958C", VA = "0x97958C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x9798B4", Offset = "0x9798B4", VA = "0x9798B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x97954C", Offset = "0x97954C", VA = "0x97954C")]
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
			[Token(Token = "0x400009E")]
			Unassigned,
			[Token(Token = "0x400009F")]
			Spine,
			[Token(Token = "0x40000A0")]
			Head,
			[Token(Token = "0x40000A1")]
			Arm,
			[Token(Token = "0x40000A2")]
			Leg,
			[Token(Token = "0x40000A3")]
			Tail,
			[Token(Token = "0x40000A4")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000015")]
		public enum BoneSide
		{
			[Token(Token = "0x40000A6")]
			Center,
			[Token(Token = "0x40000A7")]
			Left,
			[Token(Token = "0x40000A8")]
			Right
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x979B68", Offset = "0x979B68", VA = "0x979B68")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x979E2C", Offset = "0x979E2C", VA = "0x979E2C")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x97A060", Offset = "0x97A060", VA = "0x97A060")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x97A0D4", Offset = "0x97A0D4", VA = "0x97A0D4")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x97A168", Offset = "0x97A168", VA = "0x97A168")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x979D14", Offset = "0x979D14", VA = "0x979D14")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x979FD8", Offset = "0x979FD8", VA = "0x979FD8")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x97A8A0", Offset = "0x97A8A0", VA = "0x97A8A0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x97A6F8", Offset = "0x97A6F8", VA = "0x97A6F8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x97A7CC", Offset = "0x97A7CC", VA = "0x97A7CC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x97A350", Offset = "0x97A350", VA = "0x97A350")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x97A3EC", Offset = "0x97A3EC", VA = "0x97A3EC")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x97A488", Offset = "0x97A488", VA = "0x97A488")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x97A524", Offset = "0x97A524", VA = "0x97A524")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x97A5C0", Offset = "0x97A5C0", VA = "0x97A5C0")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x97A65C", Offset = "0x97A65C", VA = "0x97A65C")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x97AA88", Offset = "0x97AA88", VA = "0x97AA88")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x97A27C", Offset = "0x97A27C", VA = "0x97A27C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x97AA04", Offset = "0x97AA04", VA = "0x97AA04")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x97AAE8", Offset = "0x97AAE8", VA = "0x97AAE8")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x97ABA8", Offset = "0x97ABA8", VA = "0x97ABA8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x97A990", Offset = "0x97A990", VA = "0x97A990")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x97A920", Offset = "0x97A920", VA = "0x97A920")]
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
			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40000BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700000C")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x9804BC", Offset = "0x9804BC", VA = "0x9804BC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x9804A8", Offset = "0x9804A8", VA = "0x9804A8")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700000A")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x97CBA0", Offset = "0x97CBA0", VA = "0x97CBA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isEmpty
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x97CEFC", Offset = "0x97CEFC", VA = "0x97CEFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x97CF0C", Offset = "0x97CF0C", VA = "0x97CF0C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x97D298", Offset = "0x97D298", VA = "0x97D298", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x97D628", Offset = "0x97D628", VA = "0x97D628")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x97DC4C", Offset = "0x97DC4C", VA = "0x97DC4C")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x97D888", Offset = "0x97D888", VA = "0x97D888")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x97E448", Offset = "0x97E448", VA = "0x97E448")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x97E528", Offset = "0x97E528", VA = "0x97E528")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x97EFA0", Offset = "0x97EFA0", VA = "0x97EFA0")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x97EDC0", Offset = "0x97EDC0", VA = "0x97EDC0")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x97EB60", Offset = "0x97EB60", VA = "0x97EB60")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x97E5C4", Offset = "0x97E5C4", VA = "0x97E5C4")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x97EEB4", Offset = "0x97EEB4", VA = "0x97EEB4")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x97F080", Offset = "0x97F080", VA = "0x97F080")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x97FB40", Offset = "0x97FB40", VA = "0x97FB40")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x97F600", Offset = "0x97F600", VA = "0x97F600")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x97FE14", Offset = "0x97FE14", VA = "0x97FE14")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x97F954", Offset = "0x97F954", VA = "0x97F954")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x97FE1C", Offset = "0x97FE1C", VA = "0x97FE1C")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x97FE24", Offset = "0x97FE24", VA = "0x97FE24")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x97FFD8", Offset = "0x97FFD8", VA = "0x97FFD8")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x980440", Offset = "0x980440", VA = "0x980440")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x97D820", Offset = "0x97D820", VA = "0x97D820")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9804C4", Offset = "0x9804C4", VA = "0x9804C4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9804CC", Offset = "0x9804CC", VA = "0x9804CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9805C4", Offset = "0x9805C4", VA = "0x9805C4")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class Hierarchy
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9803BC", Offset = "0x9803BC", VA = "0x9803BC")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9802B0", Offset = "0x9802B0", VA = "0x9802B0")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x97E6A0", Offset = "0x97E6A0", VA = "0x97E6A0")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x97ECB0", Offset = "0x97ECB0", VA = "0x97ECB0")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x97E920", Offset = "0x97E920", VA = "0x97E920")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9805D4", Offset = "0x9805D4", VA = "0x9805D4")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x97E7D0", Offset = "0x97E7D0", VA = "0x97E7D0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9806C8", Offset = "0x9806C8", VA = "0x9806C8")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x980A34", Offset = "0x980A34", VA = "0x980A34")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x98082C", Offset = "0x98082C", VA = "0x98082C")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x980BBC", Offset = "0x980BBC", VA = "0x980BBC")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x980BC4", Offset = "0x980BC4", VA = "0x980BC4")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x980C2C", Offset = "0x980C2C", VA = "0x980C2C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000C2")]
		None,
		[Token(Token = "0x40000C3")]
		InOutCubic,
		[Token(Token = "0x40000C4")]
		InOutQuintic,
		[Token(Token = "0x40000C5")]
		InOutSine,
		[Token(Token = "0x40000C6")]
		InQuintic,
		[Token(Token = "0x40000C7")]
		InQuartic,
		[Token(Token = "0x40000C8")]
		InCubic,
		[Token(Token = "0x40000C9")]
		InQuadratic,
		[Token(Token = "0x40000CA")]
		InElastic,
		[Token(Token = "0x40000CB")]
		InElasticSmall,
		[Token(Token = "0x40000CC")]
		InElasticBig,
		[Token(Token = "0x40000CD")]
		InSine,
		[Token(Token = "0x40000CE")]
		InBack,
		[Token(Token = "0x40000CF")]
		OutQuintic,
		[Token(Token = "0x40000D0")]
		OutQuartic,
		[Token(Token = "0x40000D1")]
		OutCubic,
		[Token(Token = "0x40000D2")]
		OutInCubic,
		[Token(Token = "0x40000D3")]
		OutInQuartic,
		[Token(Token = "0x40000D4")]
		OutElastic,
		[Token(Token = "0x40000D5")]
		OutElasticSmall,
		[Token(Token = "0x40000D6")]
		OutElasticBig,
		[Token(Token = "0x40000D7")]
		OutSine,
		[Token(Token = "0x40000D8")]
		OutBack,
		[Token(Token = "0x40000D9")]
		OutBackCubic,
		[Token(Token = "0x40000DA")]
		OutBackQuartic,
		[Token(Token = "0x40000DB")]
		BackInCubic,
		[Token(Token = "0x40000DC")]
		BackInQuartic
	}
	[Token(Token = "0x200001D")]
	public class Interp
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x980C94", Offset = "0x980C94", VA = "0x980C94")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x98161C", Offset = "0x98161C", VA = "0x98161C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x98168C", Offset = "0x98168C", VA = "0x98168C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x981094", Offset = "0x981094", VA = "0x981094")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x9810A0", Offset = "0x9810A0", VA = "0x9810A0")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x9810C4", Offset = "0x9810C4", VA = "0x9810C4")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x981100", Offset = "0x981100", VA = "0x981100")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x981118", Offset = "0x981118", VA = "0x981118")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x98112C", Offset = "0x98112C", VA = "0x98112C")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x981140", Offset = "0x981140", VA = "0x981140")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x981150", Offset = "0x981150", VA = "0x981150")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x981198", Offset = "0x981198", VA = "0x981198")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9811D0", Offset = "0x9811D0", VA = "0x9811D0")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9811F8", Offset = "0x9811F8", VA = "0x9811F8")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x9816FC", Offset = "0x9816FC", VA = "0x9816FC")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x98122C", Offset = "0x98122C", VA = "0x98122C")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x981254", Offset = "0x981254", VA = "0x981254")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x981284", Offset = "0x981284", VA = "0x981284")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9812B8", Offset = "0x9812B8", VA = "0x9812B8")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x9812FC", Offset = "0x9812FC", VA = "0x9812FC")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x981360", Offset = "0x981360", VA = "0x981360")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x9813C4", Offset = "0x9813C4", VA = "0x9813C4")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x981418", Offset = "0x981418", VA = "0x981418")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x98146C", Offset = "0x98146C", VA = "0x98146C")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9814A4", Offset = "0x9814A4", VA = "0x9814A4")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x9814D8", Offset = "0x9814D8", VA = "0x9814D8")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x981730", Offset = "0x981730", VA = "0x981730")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x98151C", Offset = "0x98151C", VA = "0x98151C")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9815AC", Offset = "0x9815AC", VA = "0x9815AC")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x9815DC", Offset = "0x9815DC", VA = "0x9815DC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x9817C0", Offset = "0x9817C0", VA = "0x9817C0")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x9817C8", Offset = "0x9817C8", VA = "0x9817C8")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x981830", Offset = "0x981830", VA = "0x981830")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x200001F")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x981898", Offset = "0x981898", VA = "0x981898")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9818E4", Offset = "0x9818E4", VA = "0x9818E4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x9819A0", Offset = "0x9819A0", VA = "0x9819A0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x9818F8", Offset = "0x9818F8", VA = "0x9818F8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x9819B4", Offset = "0x9819B4", VA = "0x9819B4")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x981A44", Offset = "0x981A44", VA = "0x981A44")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x981A6C", Offset = "0x981A6C", VA = "0x981A6C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x981AB8", Offset = "0x981AB8", VA = "0x981AB8")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x981B20", Offset = "0x981B20", VA = "0x981B20")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x981C74", Offset = "0x981C74", VA = "0x981C74")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x981DAC", Offset = "0x981DAC", VA = "0x981DAC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x981E04", Offset = "0x981E04", VA = "0x981E04")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	public static class QuaTools
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x981E28", Offset = "0x981E28", VA = "0x981E28")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x981E80", Offset = "0x981E80", VA = "0x981E80")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x981FB0", Offset = "0x981FB0", VA = "0x981FB0")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x982130", Offset = "0x982130", VA = "0x982130")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x98220C", Offset = "0x98220C", VA = "0x98220C")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x9822E8", Offset = "0x9822E8", VA = "0x9822E8")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x982500", Offset = "0x982500", VA = "0x982500")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x98254C", Offset = "0x98254C", VA = "0x98254C")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x982598", Offset = "0x982598", VA = "0x982598")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x98269C", Offset = "0x98269C", VA = "0x98269C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9827A0", Offset = "0x9827A0", VA = "0x9827A0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x9828B4", Offset = "0x9828B4", VA = "0x9828B4")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x98295C", Offset = "0x98295C", VA = "0x98295C")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x982A68", Offset = "0x982A68", VA = "0x982A68")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x982BD0", Offset = "0x982BD0", VA = "0x982BD0")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x982DB4", Offset = "0x982DB4", VA = "0x982DB4")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x982E84", Offset = "0x982E84", VA = "0x982E84")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x983008", Offset = "0x983008", VA = "0x983008")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x983114", Offset = "0x983114", VA = "0x983114")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000021")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700000D")]
		public static T instance
		{
			[Token(Token = "0x60000EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000ED")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60000EE")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x983288", Offset = "0x983288", VA = "0x983288")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool isAnimated
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x983548", Offset = "0x983548", VA = "0x983548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x98316C", Offset = "0x98316C", VA = "0x98316C")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x983200", Offset = "0x983200", VA = "0x983200", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x983204", Offset = "0x983204", VA = "0x983204", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x983208", Offset = "0x983208", VA = "0x983208", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x98320C", Offset = "0x98320C", VA = "0x98320C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x983284", Offset = "0x983284", VA = "0x983284")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x983234", Offset = "0x983234", VA = "0x983234")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x98350C", Offset = "0x98350C", VA = "0x98350C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x983354", Offset = "0x983354", VA = "0x983354")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x9835E0", Offset = "0x9835E0", VA = "0x9835E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x98362C", Offset = "0x98362C", VA = "0x98362C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x983678", Offset = "0x983678", VA = "0x983678")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x9836B0", Offset = "0x9836B0", VA = "0x9836B0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x9836C0", Offset = "0x9836C0", VA = "0x9836C0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x983774", Offset = "0x983774", VA = "0x983774")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x983828", Offset = "0x983828", VA = "0x983828")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x9838DC", Offset = "0x9838DC", VA = "0x9838DC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public static class V2Tools
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x9838E4", Offset = "0x9838E4", VA = "0x9838E4")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x9838EC", Offset = "0x9838EC", VA = "0x9838EC")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x98397C", Offset = "0x98397C", VA = "0x98397C")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x983A10", Offset = "0x983A10", VA = "0x983A10")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x983AC0", Offset = "0x983AC0", VA = "0x983AC0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000025")]
	public static class V3Tools
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x983B1C", Offset = "0x983B1C", VA = "0x983B1C")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x983B3C", Offset = "0x983B3C", VA = "0x983B3C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x983C10", Offset = "0x983C10", VA = "0x983C10")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x983CC8", Offset = "0x983CC8", VA = "0x983CC8")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x983D24", Offset = "0x983D24", VA = "0x983D24")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x983D80", Offset = "0x983D80", VA = "0x983D80")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x983E98", Offset = "0x983E98", VA = "0x983E98")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x983EF4", Offset = "0x983EF4", VA = "0x983EF4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x983F2C", Offset = "0x983F2C", VA = "0x983F2C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x98407C", Offset = "0x98407C", VA = "0x98407C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x9841F8", Offset = "0x9841F8", VA = "0x9841F8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x984428", Offset = "0x984428", VA = "0x984428")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x984678", Offset = "0x984678", VA = "0x984678")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x9848D0", Offset = "0x9848D0", VA = "0x9848D0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x984A7C", Offset = "0x984A7C", VA = "0x984A7C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x984C74", Offset = "0x984C74", VA = "0x984C74")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x984CF0", Offset = "0x984CF0", VA = "0x984CF0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x984D80", Offset = "0x984D80", VA = "0x984D80")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x984E18", Offset = "0x984E18", VA = "0x984E18")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x984E08", Offset = "0x984E08", VA = "0x984E08")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000026")]
	public static class Warning
	{
		[Token(Token = "0x2000027")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x984E94", Offset = "0x984E94", VA = "0x984E94")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x97E394", Offset = "0x97E394", VA = "0x97E394")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000028")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x985040", Offset = "0x985040", VA = "0x985040")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x985084", Offset = "0x985084", VA = "0x985084")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x9850C8", Offset = "0x9850C8", VA = "0x9850C8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x98510C", Offset = "0x98510C", VA = "0x98510C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x985150", Offset = "0x985150", VA = "0x985150")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x9851E8", Offset = "0x9851E8", VA = "0x9851E8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x985204", Offset = "0x985204", VA = "0x985204")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x985230", Offset = "0x985230", VA = "0x985230")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x98525C", Offset = "0x98525C", VA = "0x98525C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x985298", Offset = "0x985298", VA = "0x985298")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x9852D8", Offset = "0x9852D8", VA = "0x9852D8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x9852F8", Offset = "0x9852F8", VA = "0x9852F8")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x985318", Offset = "0x985318", VA = "0x985318")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x98533C", Offset = "0x98533C", VA = "0x98533C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x985364", Offset = "0x985364", VA = "0x985364")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x98538C", Offset = "0x98538C", VA = "0x98538C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x98516C", Offset = "0x98516C", VA = "0x98516C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x9853B0", Offset = "0x9853B0", VA = "0x9853B0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x9853BC", Offset = "0x9853BC", VA = "0x9853BC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x9853C8", Offset = "0x9853C8", VA = "0x9853C8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x985634", Offset = "0x985634", VA = "0x985634", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x9856D0", Offset = "0x9856D0", VA = "0x9856D0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x9859F0", Offset = "0x9859F0", VA = "0x9859F0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x985E5C", Offset = "0x985E5C", VA = "0x985E5C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x985E80", Offset = "0x985E80", VA = "0x985E80")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000010")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x985504", Offset = "0x985504", VA = "0x985504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x9860A4", Offset = "0x9860A4", VA = "0x9860A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x985880", Offset = "0x985880", VA = "0x985880")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x985F18", Offset = "0x985F18", VA = "0x985F18")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000012")]
		public bool isValid
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x986260", Offset = "0x986260", VA = "0x986260")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x9862C0", Offset = "0x9862C0", VA = "0x9862C0")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9862C8", Offset = "0x9862C8", VA = "0x9862C8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x986360", Offset = "0x986360", VA = "0x986360")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x986368", Offset = "0x986368", VA = "0x986368")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002C")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000013")]
		private bool positionChanged
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x986494", Offset = "0x986494", VA = "0x986494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x986390", Offset = "0x986390", VA = "0x986390", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9864F0", Offset = "0x9864F0", VA = "0x9864F0")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9864F8", Offset = "0x9864F8", VA = "0x9864F8")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x986520", Offset = "0x986520", VA = "0x986520", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x98659C", Offset = "0x98659C", VA = "0x98659C")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x9865A4", Offset = "0x9865A4", VA = "0x9865A4")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000014")]
		private bool rotationChanged
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x9866D0", Offset = "0x9866D0", VA = "0x9866D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x9865CC", Offset = "0x9865CC", VA = "0x9865CC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x986728", Offset = "0x986728", VA = "0x986728")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x986730", Offset = "0x986730", VA = "0x986730")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Constraints
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x986758", Offset = "0x986758", VA = "0x986758")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x9859A0", Offset = "0x9859A0", VA = "0x9859A0")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x985B64", Offset = "0x985B64", VA = "0x985B64")]
		public void Update()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x986258", Offset = "0x986258", VA = "0x986258")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x2000031")]
		public enum DOF
		{
			[Token(Token = "0x400011D")]
			One,
			[Token(Token = "0x400011E")]
			Three
		}

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000015")]
		public bool initiated
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x9867B8", Offset = "0x9867B8", VA = "0x9867B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x9867C0", Offset = "0x9867C0", VA = "0x9867C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x9867CC", Offset = "0x9867CC", VA = "0x9867CC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x9867EC", Offset = "0x9867EC", VA = "0x9867EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x98680C", Offset = "0x98680C", VA = "0x98680C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x98682C", Offset = "0x98682C", VA = "0x98682C")]
			set
			{
			}
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x98684C", Offset = "0x98684C", VA = "0x98684C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x986938", Offset = "0x986938", VA = "0x986938")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x986FA0", Offset = "0x986FA0", VA = "0x986FA0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x98706C", Offset = "0x98706C", VA = "0x98706C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x987124", Offset = "0x987124", VA = "0x987124")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x9876BC", Offset = "0x9876BC", VA = "0x9876BC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The master weight for all fingers.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x17000018")]
		public bool initiated
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x9876CC", Offset = "0x9876CC", VA = "0x9876CC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x9876D4", Offset = "0x9876D4", VA = "0x9876D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x9876E0", Offset = "0x9876E0", VA = "0x9876E0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x987754", Offset = "0x987754", VA = "0x987754")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x987A60", Offset = "0x987A60", VA = "0x987A60")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x987BCC", Offset = "0x987BCC", VA = "0x987BCC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x987978", Offset = "0x987978", VA = "0x987978")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x987D2C", Offset = "0x987D2C", VA = "0x987D2C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x987DD4", Offset = "0x987DD4", VA = "0x987DD4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x987E38", Offset = "0x987E38", VA = "0x987E38")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x987EA0", Offset = "0x987EA0", VA = "0x987EA0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x987EFC", Offset = "0x987EFC", VA = "0x987EFC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x987F00", Offset = "0x987F00", VA = "0x987F00", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x987F14", Offset = "0x987F14", VA = "0x987F14")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x17000019")]
		public bool initiated
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x987F7C", Offset = "0x987F7C", VA = "0x987F7C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x987F84", Offset = "0x987F84", VA = "0x987F84")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600016D")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x987F90", Offset = "0x987F90", VA = "0x987F90")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x988240", Offset = "0x988240", VA = "0x988240")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x988054", Offset = "0x988054", VA = "0x988054")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x988268", Offset = "0x988268", VA = "0x988268")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000175")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9883DC", Offset = "0x9883DC", VA = "0x9883DC")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x9885E4", Offset = "0x9885E4", VA = "0x9885E4", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x988628", Offset = "0x988628", VA = "0x988628", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x98866C", Offset = "0x98866C", VA = "0x98866C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x98874C", Offset = "0x98874C", VA = "0x98874C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x9887EC", Offset = "0x9887EC", VA = "0x9887EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x988840", Offset = "0x988840", VA = "0x988840")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x988DB4", Offset = "0x988DB4", VA = "0x988DB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x988DF4", Offset = "0x988DF4", VA = "0x988DF4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x98946C", Offset = "0x98946C", VA = "0x98946C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x989594", Offset = "0x989594", VA = "0x989594")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x989764", Offset = "0x989764", VA = "0x989764")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x98990C", Offset = "0x98990C", VA = "0x98990C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000037")]
		public class SpineEffector
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x6000195")]
			[Address(RVA = "0x98A5A4", Offset = "0x98A5A4", VA = "0x98A5A4")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0x98A5B4", Offset = "0x98A5B4", VA = "0x98A5B4")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x989998", Offset = "0x989998", VA = "0x989998")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x9899DC", Offset = "0x9899DC", VA = "0x9899DC", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x989A20", Offset = "0x989A20", VA = "0x989A20", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x989A64", Offset = "0x989A64", VA = "0x989A64", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x989ACC", Offset = "0x989ACC", VA = "0x989ACC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x989B54", Offset = "0x989B54", VA = "0x989B54")]
		private void Update()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x989DC4", Offset = "0x989DC4", VA = "0x989DC4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x989DD0", Offset = "0x989DD0", VA = "0x989DD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x989BB0", Offset = "0x989BB0", VA = "0x989BB0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x989DDC", Offset = "0x989DDC", VA = "0x989DDC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x98A14C", Offset = "0x98A14C", VA = "0x98A14C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x98A2D0", Offset = "0x98A2D0", VA = "0x98A2D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x98A404", Offset = "0x98A404", VA = "0x98A404")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x98A518", Offset = "0x98A518", VA = "0x98A518")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x98A5F8", Offset = "0x98A5F8", VA = "0x98A5F8", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x98A63C", Offset = "0x98A63C", VA = "0x98A63C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x98A680", Offset = "0x98A680", VA = "0x98A680", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x98A698", Offset = "0x98A698", VA = "0x98A698")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x98A8B8", Offset = "0x98A8B8", VA = "0x98A8B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x98A998", Offset = "0x98A998", VA = "0x98A998")]
		private void Update()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x98B084", Offset = "0x98B084", VA = "0x98B084")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x98B4E4", Offset = "0x98B4E4", VA = "0x98B4E4")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x98B690", Offset = "0x98B690", VA = "0x98B690")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x98BA18", Offset = "0x98BA18", VA = "0x98BA18")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x98BBF0", Offset = "0x98BBF0", VA = "0x98BBF0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x98BDF4", Offset = "0x98BDF4", VA = "0x98BDF4")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200003A")]
		public struct Foot
		{
			[Token(Token = "0x4000165")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000166")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000167")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000168")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x98C950", Offset = "0x98C950", VA = "0x98C950")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x98BE80", Offset = "0x98BE80", VA = "0x98BE80", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x98BEC4", Offset = "0x98BEC4", VA = "0x98BEC4", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x98BF08", Offset = "0x98BF08", VA = "0x98BF08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x98BF30", Offset = "0x98BF30", VA = "0x98BF30")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x98C034", Offset = "0x98C034", VA = "0x98C034")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x98C22C", Offset = "0x98C22C", VA = "0x98C22C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x98C290", Offset = "0x98C290", VA = "0x98C290")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x98C2E8", Offset = "0x98C2E8", VA = "0x98C2E8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x98C5FC", Offset = "0x98C5FC", VA = "0x98C5FC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x98C984", Offset = "0x98C984", VA = "0x98C984")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x98CA14", Offset = "0x98CA14", VA = "0x98CA14")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x98CE64", Offset = "0x98CE64", VA = "0x98CE64")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x98D524", Offset = "0x98D524", VA = "0x98D524")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x98D7DC", Offset = "0x98D7DC", VA = "0x98D7DC")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x98D910", Offset = "0x98D910", VA = "0x98D910")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x98DBD8", Offset = "0x98DBD8", VA = "0x98DBD8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x98DC08", Offset = "0x98DC08", VA = "0x98DC08")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x98DE04", Offset = "0x98DE04", VA = "0x98DE04")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x98DF34", Offset = "0x98DF34", VA = "0x98DF34")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x98DF78", Offset = "0x98DF78", VA = "0x98DF78", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x98DFBC", Offset = "0x98DFBC", VA = "0x98DFBC", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x98E000", Offset = "0x98E000", VA = "0x98E000", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x98E018", Offset = "0x98E018", VA = "0x98E018")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x98E0A0", Offset = "0x98E0A0", VA = "0x98E0A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x98E0F4", Offset = "0x98E0F4", VA = "0x98E0F4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x98E32C", Offset = "0x98E32C", VA = "0x98E32C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x98E520", Offset = "0x98E520", VA = "0x98E520")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x98E5A4", Offset = "0x98E5A4", VA = "0x98E5A4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x98E840", Offset = "0x98E840", VA = "0x98E840")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x98E974", Offset = "0x98E974", VA = "0x98E974")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x98EB0C", Offset = "0x98EB0C", VA = "0x98EB0C")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200003D")]
		public enum Quality
		{
			[Token(Token = "0x4000184")]
			Fastest,
			[Token(Token = "0x4000185")]
			Simple,
			[Token(Token = "0x4000186")]
			Best
		}

		[Token(Token = "0x200003E")]
		public class Leg
		{
			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000022")]
			public bool isGrounded
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x9900A0", Offset = "0x9900A0", VA = "0x9900A0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0x9900A8", Offset = "0x9900A8", VA = "0x9900A8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001DD")]
				[Address(RVA = "0x9900B4", Offset = "0x9900B4", VA = "0x9900B4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0x9900C0", Offset = "0x9900C0", VA = "0x9900C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001DF")]
				[Address(RVA = "0x9900CC", Offset = "0x9900CC", VA = "0x9900CC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001E0")]
				[Address(RVA = "0x9900D4", Offset = "0x9900D4", VA = "0x9900D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x9900E0", Offset = "0x9900E0", VA = "0x9900E0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E2")]
				[Address(RVA = "0x9900E8", Offset = "0x9900E8", VA = "0x9900E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001E3")]
				[Address(RVA = "0x9900F0", Offset = "0x9900F0", VA = "0x9900F0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001E4")]
				[Address(RVA = "0x9900FC", Offset = "0x9900FC", VA = "0x9900FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001E5")]
				[Address(RVA = "0x990108", Offset = "0x990108", VA = "0x990108")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001E6")]
				[Address(RVA = "0x990110", Offset = "0x990110", VA = "0x990110")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001E7")]
				[Address(RVA = "0x990118", Offset = "0x990118", VA = "0x990118")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60001E8")]
				[Address(RVA = "0x990120", Offset = "0x990120", VA = "0x990120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001E9")]
				[Address(RVA = "0x990128", Offset = "0x990128", VA = "0x990128")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x990140", Offset = "0x990140", VA = "0x990140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001EB")]
				[Address(RVA = "0x990160", Offset = "0x990160", VA = "0x990160")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x990178", Offset = "0x990178", VA = "0x990178")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x990198", Offset = "0x990198", VA = "0x990198")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001F3")]
				[Address(RVA = "0x990A88", Offset = "0x990A88", VA = "0x990A88")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001FC")]
				[Address(RVA = "0x990BD8", Offset = "0x990BD8", VA = "0x990BD8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x9901E0", Offset = "0x9901E0", VA = "0x9901E0")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x98F020", Offset = "0x98F020", VA = "0x98F020")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x9901F4", Offset = "0x9901F4", VA = "0x9901F4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x98FD10", Offset = "0x98FD10", VA = "0x98FD10")]
			public void Reset()
			{
			}

			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x98F110", Offset = "0x98F110", VA = "0x98F110")]
			public void Process()
			{
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x990698", Offset = "0x990698", VA = "0x990698")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x990234", Offset = "0x990234", VA = "0x990234")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x990B1C", Offset = "0x990B1C", VA = "0x990B1C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x990500", Offset = "0x990500", VA = "0x990500")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x990580", Offset = "0x990580", VA = "0x990580")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x990B88", Offset = "0x990B88", VA = "0x990B88")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x990ABC", Offset = "0x990ABC", VA = "0x990ABC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x990C64", Offset = "0x990C64", VA = "0x990C64")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x98EF80", Offset = "0x98EF80", VA = "0x98EF80")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200003F")]
		public class Pelvis
		{
			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x1700002E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001FE")]
				[Address(RVA = "0x990E14", Offset = "0x990E14", VA = "0x990E14")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001FF")]
				[Address(RVA = "0x990E20", Offset = "0x990E20", VA = "0x990E20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x6000200")]
				[Address(RVA = "0x990E2C", Offset = "0x990E2C", VA = "0x990E2C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000201")]
				[Address(RVA = "0x990E34", Offset = "0x990E34", VA = "0x990E34")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x98F0E8", Offset = "0x98F0E8", VA = "0x98F0E8")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x98FC7C", Offset = "0x98FC7C", VA = "0x98FC7C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x990E3C", Offset = "0x990E3C", VA = "0x990E3C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0x98FA90", Offset = "0x98FA90", VA = "0x98FA90")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0x98F018", Offset = "0x98F018", VA = "0x98F018")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		[Range(0f, 1f)]
		public float pelvisDamper;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700001A")]
		public Leg[] legs
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x98EB60", Offset = "0x98EB60", VA = "0x98EB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x98EB68", Offset = "0x98EB68", VA = "0x98EB68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x98EB70", Offset = "0x98EB70", VA = "0x98EB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x98EB78", Offset = "0x98EB78", VA = "0x98EB78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x98EB80", Offset = "0x98EB80", VA = "0x98EB80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x98EB88", Offset = "0x98EB88", VA = "0x98EB88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x98EB94", Offset = "0x98EB94", VA = "0x98EB94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x98EB9C", Offset = "0x98EB9C", VA = "0x98EB9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x98EBA4", Offset = "0x98EBA4", VA = "0x98EBA4")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x98EBBC", Offset = "0x98EBBC", VA = "0x98EBBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x98EBDC", Offset = "0x98EBDC", VA = "0x98EBDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x98952C", Offset = "0x98952C", VA = "0x98952C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x98FDA4", Offset = "0x98FDA4", VA = "0x98FDA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x98EC24", Offset = "0x98EC24", VA = "0x98EC24")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x98EE84", Offset = "0x98EE84", VA = "0x98EE84")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x988B40", Offset = "0x988B40", VA = "0x988B40")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x98926C", Offset = "0x98926C", VA = "0x98926C")]
		public void Update()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x98AF0C", Offset = "0x98AF0C", VA = "0x98AF0C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x9886D4", Offset = "0x9886D4", VA = "0x9886D4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x98F0F8", Offset = "0x98F0F8", VA = "0x98F0F8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x98FE58", Offset = "0x98FE58", VA = "0x98FE58")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x98FEDC", Offset = "0x98FEDC", VA = "0x98FEDC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x990030", Offset = "0x990030", VA = "0x990030")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x988494", Offset = "0x988494", VA = "0x988494")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x990E90", Offset = "0x990E90", VA = "0x990E90", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x990ED4", Offset = "0x990ED4", VA = "0x990ED4", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x990F18", Offset = "0x990F18", VA = "0x990F18")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x990F5C", Offset = "0x990F5C", VA = "0x990F5C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x990FA0", Offset = "0x990FA0", VA = "0x990FA0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x990FE4", Offset = "0x990FE4", VA = "0x990FE4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x990FEC", Offset = "0x990FEC", VA = "0x990FEC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	public class ArmIK : IK
	{
		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x99105C", Offset = "0x99105C", VA = "0x99105C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x9910A0", Offset = "0x9910A0", VA = "0x9910A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x9910E4", Offset = "0x9910E4", VA = "0x9910E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x991128", Offset = "0x991128", VA = "0x991128")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x99116C", Offset = "0x99116C", VA = "0x99116C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x991174", Offset = "0x991174", VA = "0x991174")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x9911DC", Offset = "0x9911DC", VA = "0x9911DC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x991220", Offset = "0x991220", VA = "0x991220", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x991264", Offset = "0x991264", VA = "0x991264")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9912A8", Offset = "0x9912A8", VA = "0x9912A8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9912EC", Offset = "0x9912EC", VA = "0x9912EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x9912F4", Offset = "0x9912F4", VA = "0x9912F4")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x99135C", Offset = "0x99135C", VA = "0x99135C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9913A0", Offset = "0x9913A0", VA = "0x9913A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9913E4", Offset = "0x9913E4", VA = "0x9913E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x991428", Offset = "0x991428", VA = "0x991428")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x99146C", Offset = "0x99146C", VA = "0x99146C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x991474", Offset = "0x991474", VA = "0x991474")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9914DC", Offset = "0x9914DC", VA = "0x9914DC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x991520", Offset = "0x991520", VA = "0x991520", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x991564", Offset = "0x991564", VA = "0x991564")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9915A8", Offset = "0x9915A8", VA = "0x9915A8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9915EC", Offset = "0x9915EC", VA = "0x9915EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9915F4", Offset = "0x9915F4", VA = "0x9915F4")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x99165C", Offset = "0x99165C", VA = "0x99165C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9916A0", Offset = "0x9916A0", VA = "0x9916A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9916E4", Offset = "0x9916E4", VA = "0x9916E4")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x991728", Offset = "0x991728", VA = "0x991728")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x99176C", Offset = "0x99176C", VA = "0x99176C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9917B0", Offset = "0x9917B0", VA = "0x9917B0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9917F4", Offset = "0x9917F4", VA = "0x9917F4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x991818", Offset = "0x991818", VA = "0x991818", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x991820", Offset = "0x991820", VA = "0x991820")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9919DC", Offset = "0x9919DC", VA = "0x9919DC")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x991E8C", Offset = "0x991E8C", VA = "0x991E8C")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x991EAC", Offset = "0x991EAC", VA = "0x991EAC")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x991F84", Offset = "0x991F84", VA = "0x991F84")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000233")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x99201C", Offset = "0x99201C", VA = "0x99201C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x992094", Offset = "0x992094", VA = "0x992094", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x992104", Offset = "0x992104", VA = "0x992104", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000237")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000238")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x991054", Offset = "0x991054", VA = "0x991054")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x992154", Offset = "0x992154", VA = "0x992154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x9921E0", Offset = "0x9921E0", VA = "0x9921E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x992244", Offset = "0x992244", VA = "0x992244")]
		private void Update()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x9922E4", Offset = "0x9922E4", VA = "0x9922E4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x992310", Offset = "0x992310", VA = "0x992310")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x992268", Offset = "0x992268", VA = "0x992268")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x992394", Offset = "0x992394", VA = "0x992394")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x99239C", Offset = "0x99239C", VA = "0x99239C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x9923E0", Offset = "0x9923E0", VA = "0x9923E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x992424", Offset = "0x992424", VA = "0x992424")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x992468", Offset = "0x992468", VA = "0x992468")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x9924AC", Offset = "0x9924AC", VA = "0x9924AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x9924B4", Offset = "0x9924B4", VA = "0x9924B4")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x99251C", Offset = "0x99251C", VA = "0x99251C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x992560", Offset = "0x992560", VA = "0x992560", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x9925A4", Offset = "0x9925A4", VA = "0x9925A4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x9925E8", Offset = "0x9925E8", VA = "0x9925E8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x99262C", Offset = "0x99262C", VA = "0x99262C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x992634", Offset = "0x992634", VA = "0x992634")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x99269C", Offset = "0x99269C", VA = "0x99269C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x9926E0", Offset = "0x9926E0", VA = "0x9926E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x992724", Offset = "0x992724", VA = "0x992724")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x992768", Offset = "0x992768", VA = "0x992768")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x9927AC", Offset = "0x9927AC", VA = "0x9927AC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x9927B4", Offset = "0x9927B4", VA = "0x9927B4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x99281C", Offset = "0x99281C", VA = "0x99281C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x992860", Offset = "0x992860", VA = "0x992860", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x9928A4", Offset = "0x9928A4", VA = "0x9928A4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x9928E8", Offset = "0x9928E8", VA = "0x9928E8")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x99292C", Offset = "0x99292C", VA = "0x99292C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x992934", Offset = "0x992934", VA = "0x992934")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200004D")]
		public class References
		{
			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x17000031")]
			public bool isFilled
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x993268", Offset = "0x993268", VA = "0x993268")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000032")]
			public bool isEmpty
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x992EAC", Offset = "0x992EAC", VA = "0x992EAC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x993854", Offset = "0x993854", VA = "0x993854")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x992A84", Offset = "0x992A84", VA = "0x992A84")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x99384C", Offset = "0x99384C", VA = "0x99384C")]
			public References()
			{
			}
		}

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x99299C", Offset = "0x99299C", VA = "0x99299C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x9929E0", Offset = "0x9929E0", VA = "0x9929E0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x992A24", Offset = "0x992A24", VA = "0x992A24")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x992A68", Offset = "0x992A68", VA = "0x992A68")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x992E10", Offset = "0x992E10", VA = "0x992E10")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x992E38", Offset = "0x992E38", VA = "0x992E38", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x992E40", Offset = "0x992E40", VA = "0x992E40", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x993624", Offset = "0x993624", VA = "0x993624", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x9937B4", Offset = "0x9937B4", VA = "0x9937B4")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class FABRIKChain
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x993C90", Offset = "0x993C90", VA = "0x993C90")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x993D54", Offset = "0x993D54", VA = "0x993D54")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x993D74", Offset = "0x993D74", VA = "0x993D74")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x993FC8", Offset = "0x993FC8", VA = "0x993FC8")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x993E34", Offset = "0x993E34", VA = "0x993E34")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x9940AC", Offset = "0x9940AC", VA = "0x9940AC")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x99410C", Offset = "0x99410C", VA = "0x99410C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x9945A8", Offset = "0x9945A8", VA = "0x9945A8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x99473C", Offset = "0x99473C", VA = "0x99473C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x994848", Offset = "0x994848", VA = "0x994848")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		public class BendBone
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x99794C", Offset = "0x99794C", VA = "0x99794C")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x9979AC", Offset = "0x9979AC", VA = "0x9979AC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x9950B0", Offset = "0x9950B0", VA = "0x9950B0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x995480", Offset = "0x995480", VA = "0x995480")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The weight of moving the thighs along with the head")]
		public float thighWeight;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		public float rotationWeight;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Smoothing the CCD effect.")]
		[Range(0f, 1000f)]
		public float damper;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x994850", Offset = "0x994850", VA = "0x994850")]
		private void Start()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x994C3C", Offset = "0x994C3C", VA = "0x994C3C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x9950DC", Offset = "0x9950DC", VA = "0x9950DC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x9954A8", Offset = "0x9954A8", VA = "0x9954A8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x995DA4", Offset = "0x995DA4", VA = "0x995DA4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x99619C", Offset = "0x99619C", VA = "0x99619C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9965AC", Offset = "0x9965AC", VA = "0x9965AC")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x996F2C", Offset = "0x996F2C", VA = "0x996F2C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x995AE8", Offset = "0x995AE8", VA = "0x995AE8")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x997168", Offset = "0x997168", VA = "0x997168")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x996E44", Offset = "0x996E44", VA = "0x996E44")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x996D44", Offset = "0x996D44", VA = "0x996D44")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x99746C", Offset = "0x99746C", VA = "0x99746C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x9977A4", Offset = "0x9977A4", VA = "0x9977A4")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000053")]
		public class ChildConstraint
		{
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x17000033")]
			public float nominalDistance
			{
				[Token(Token = "0x6000297")]
				[Address(RVA = "0x99AC00", Offset = "0x99AC00", VA = "0x99AC00")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x99AC08", Offset = "0x99AC08", VA = "0x99AC08")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000034")]
			public bool isRigid
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x99AC10", Offset = "0x99AC10", VA = "0x99AC10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x99AC18", Offset = "0x99AC18", VA = "0x99AC18")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x99AC24", Offset = "0x99AC24", VA = "0x99AC24")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x99AC64", Offset = "0x99AC64", VA = "0x99AC64")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x99ADC4", Offset = "0x99ADC4", VA = "0x99ADC4")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x99AFA8", Offset = "0x99AFA8", VA = "0x99AFA8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000054")]
		public enum Smoothing
		{
			[Token(Token = "0x4000228")]
			None,
			[Token(Token = "0x4000229")]
			Exponential,
			[Token(Token = "0x400022A")]
			Cubic
		}

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x400021C")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x997A28", Offset = "0x997A28", VA = "0x997A28")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x997B28", Offset = "0x997B28", VA = "0x997B28")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x997C60", Offset = "0x997C60", VA = "0x997C60")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x997D78", Offset = "0x997D78", VA = "0x997D78")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x997E34", Offset = "0x997E34", VA = "0x997E34")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x997F40", Offset = "0x997F40", VA = "0x997F40")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x998618", Offset = "0x998618", VA = "0x998618")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x9980BC", Offset = "0x9980BC", VA = "0x9980BC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x998A00", Offset = "0x998A00", VA = "0x998A00")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x998C94", Offset = "0x998C94", VA = "0x998C94")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x998F64", Offset = "0x998F64", VA = "0x998F64")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x999300", Offset = "0x999300", VA = "0x999300")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x9997FC", Offset = "0x9997FC", VA = "0x9997FC")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x9999FC", Offset = "0x9999FC", VA = "0x9999FC")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x9996E8", Offset = "0x9996E8", VA = "0x9996E8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x9991A0", Offset = "0x9991A0", VA = "0x9991A0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x999680", Offset = "0x999680", VA = "0x999680")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x999AD8", Offset = "0x999AD8", VA = "0x999AD8")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x9995AC", Offset = "0x9995AC", VA = "0x9995AC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x999900", Offset = "0x999900", VA = "0x999900")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKConstraintBend
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000035")]
		public bool initiated
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x99B3BC", Offset = "0x99B3BC", VA = "0x99B3BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x99B3C4", Offset = "0x99B3C4", VA = "0x99B3C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x99B1E4", Offset = "0x99B1E4", VA = "0x99B1E4")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x99B3D0", Offset = "0x99B3D0", VA = "0x99B3D0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x99B43C", Offset = "0x99B43C", VA = "0x99B43C")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x99B4C8", Offset = "0x99B4C8", VA = "0x99B4C8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x99B4D4", Offset = "0x99B4D4", VA = "0x99B4D4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x99B8DC", Offset = "0x99B8DC", VA = "0x99B8DC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x99BC30", Offset = "0x99BC30", VA = "0x99BC30")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x99BFF8", Offset = "0x99BFF8", VA = "0x99BFF8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x99B7A4", Offset = "0x99B7A4", VA = "0x99B7A4")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x99B840", Offset = "0x99B840", VA = "0x99B840")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKEffector
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000036")]
		public bool isEndEffector
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x99C6BC", Offset = "0x99C6BC", VA = "0x99C6BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x99C6C4", Offset = "0x99C6C4", VA = "0x99C6C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x99C660", Offset = "0x99C660", VA = "0x99C660")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x99C6D0", Offset = "0x99C6D0", VA = "0x99C6D0")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x99C754", Offset = "0x99C754", VA = "0x99C754")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x99C8F4", Offset = "0x99C8F4", VA = "0x99C8F4")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x99CAB0", Offset = "0x99CAB0", VA = "0x99CAB0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x99CDA4", Offset = "0x99CDA4", VA = "0x99CDA4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x99D030", Offset = "0x99D030", VA = "0x99D030")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x99D148", Offset = "0x99D148", VA = "0x99D148")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x99D1E4", Offset = "0x99D1E4", VA = "0x99D1E4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x99D884", Offset = "0x99D884", VA = "0x99D884")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x99D8DC", Offset = "0x99D8DC", VA = "0x99D8DC")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x99DAA4", Offset = "0x99DAA4", VA = "0x99DAA4")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x99DCEC", Offset = "0x99DCEC", VA = "0x99DCEC")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000058")]
		public class BoneMap
		{
			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400026A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400026B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400026C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x17000037")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60002C0")]
				[Address(RVA = "0x99E228", Offset = "0x99E228", VA = "0x99E228")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000038")]
			public bool isNodeBone
			{
				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x99E2E0", Offset = "0x99E2E0", VA = "0x99E2E0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000039")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60002D7")]
				[Address(RVA = "0x99E69C", Offset = "0x99E69C", VA = "0x99E69C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x99E200", Offset = "0x99E200", VA = "0x99E200")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x99E258", Offset = "0x99E258", VA = "0x99E258")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x99E29C", Offset = "0x99E29C", VA = "0x99E29C")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x99E2F0", Offset = "0x99E2F0", VA = "0x99E2F0")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x99E3C4", Offset = "0x99E3C4", VA = "0x99E3C4")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x99E3CC", Offset = "0x99E3CC", VA = "0x99E3CC")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x99E498", Offset = "0x99E498", VA = "0x99E498")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x99E504", Offset = "0x99E504", VA = "0x99E504")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x99E58C", Offset = "0x99E58C", VA = "0x99E58C")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x99E804", Offset = "0x99E804", VA = "0x99E804")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x99E830", Offset = "0x99E830", VA = "0x99E830")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x99E85C", Offset = "0x99E85C", VA = "0x99E85C")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x99E884", Offset = "0x99E884", VA = "0x99E884")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x99E944", Offset = "0x99E944", VA = "0x99E944")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x99EAC8", Offset = "0x99EAC8", VA = "0x99EAC8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x99EAEC", Offset = "0x99EAEC", VA = "0x99EAEC")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x99EC0C", Offset = "0x99EC0C", VA = "0x99EC0C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x99EC70", Offset = "0x99EC70", VA = "0x99EC70")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x99EDF0", Offset = "0x99EDF0", VA = "0x99EDF0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x99EF70", Offset = "0x99EF70", VA = "0x99EF70")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x99EFEC", Offset = "0x99EFEC", VA = "0x99EFEC")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x99E9B8", Offset = "0x99E9B8", VA = "0x99E9B8")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x99F108", Offset = "0x99F108", VA = "0x99F108")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x99DF9C", Offset = "0x99DF9C", VA = "0x99DF9C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x99DFA4", Offset = "0x99DFA4", VA = "0x99DFA4", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x99DFA8", Offset = "0x99DFA8", VA = "0x99DFA8")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x99E0E4", Offset = "0x99E0E4", VA = "0x99E0E4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x99E1F8", Offset = "0x99E1F8", VA = "0x99E1F8")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x99F124", Offset = "0x99F124", VA = "0x99F124", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x99F1C0", Offset = "0x99F1C0", VA = "0x99F1C0")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x99F244", Offset = "0x99F244", VA = "0x99F244")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x99F2DC", Offset = "0x99F2DC", VA = "0x99F2DC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x99F2F4", Offset = "0x99F2F4", VA = "0x99F2F4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x99F310", Offset = "0x99F310", VA = "0x99F310", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x99F39C", Offset = "0x99F39C", VA = "0x99F39C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x99F3B4", Offset = "0x99F3B4", VA = "0x99F3B4")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005A")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000282")]
			Parent,
			[Token(Token = "0x4000283")]
			Bone1,
			[Token(Token = "0x4000284")]
			Bone2,
			[Token(Token = "0x4000285")]
			Bone3
		}

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x99F3D8", Offset = "0x99F3D8", VA = "0x99F3D8", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x99F44C", Offset = "0x99F44C", VA = "0x99F44C")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x99F514", Offset = "0x99F514", VA = "0x99F514")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x99F7CC", Offset = "0x99F7CC", VA = "0x99F7CC")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x99F8E8", Offset = "0x99F8E8", VA = "0x99F8E8")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x99FA30", Offset = "0x99FA30", VA = "0x99FA30")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x99FA3C", Offset = "0x99FA3C", VA = "0x99FA3C")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x99FAD4", Offset = "0x99FAD4", VA = "0x99FAD4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x99FB7C", Offset = "0x99FB7C", VA = "0x99FB7C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x99FDD8", Offset = "0x99FDD8", VA = "0x99FDD8")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x99FE38", Offset = "0x99FE38", VA = "0x99FE38")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x99FF7C", Offset = "0x99FF7C", VA = "0x99FF7C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x9A029C", Offset = "0x9A029C", VA = "0x9A029C")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x9A03D8", Offset = "0x9A03D8", VA = "0x9A03D8")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x9A0548", Offset = "0x9A0548", VA = "0x9A0548")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x9A0558", Offset = "0x9A0558", VA = "0x9A0558")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x9A05B4", Offset = "0x9A05B4", VA = "0x9A05B4")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x9A062C", Offset = "0x9A062C", VA = "0x9A062C", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x9A0C40", Offset = "0x9A0C40", VA = "0x9A0C40")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x9A0C78", Offset = "0x9A0C78", VA = "0x9A0C78")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x9A0EDC", Offset = "0x9A0EDC", VA = "0x9A0EDC")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x9A11FC", Offset = "0x9A11FC", VA = "0x9A11FC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x9A12DC", Offset = "0x9A12DC", VA = "0x9A12DC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x9A1390", Offset = "0x9A1390", VA = "0x9A1390")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x200005E")]
		public class Point
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x9A1C60", Offset = "0x9A1C60", VA = "0x9A1C60")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x9A1CA4", Offset = "0x9A1CA4", VA = "0x9A1CA4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x9A1D84", Offset = "0x9A1D84", VA = "0x9A1D84")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x9A1DB0", Offset = "0x9A1DB0", VA = "0x9A1DB0")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000313")]
			[Address(RVA = "0x9A1DDC", Offset = "0x9A1DDC", VA = "0x9A1DDC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x9A1E20", Offset = "0x9A1E20", VA = "0x9A1E20")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0x9A1E64", Offset = "0x9A1E64", VA = "0x9A1E64")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public class Bone : Point
		{
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40002A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x1700003B")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0x9A1EC4", Offset = "0x9A1EC4", VA = "0x9A1EC4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000317")]
				[Address(RVA = "0x9A1FA4", Offset = "0x9A1FA4", VA = "0x9A1FA4")]
				set
				{
				}
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x9A201C", Offset = "0x9A201C", VA = "0x9A201C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x9A2288", Offset = "0x9A2288", VA = "0x9A2288")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x9A2544", Offset = "0x9A2544", VA = "0x9A2544")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x9A2738", Offset = "0x9A2738", VA = "0x9A2738")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x9A2760", Offset = "0x9A2760", VA = "0x9A2760")]
			public Bone()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x9A27CC", Offset = "0x9A27CC", VA = "0x9A27CC")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x9A2844", Offset = "0x9A2844", VA = "0x9A2844")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public class Node : Point
		{
			[Token(Token = "0x40002A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40002AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x9A28CC", Offset = "0x9A28CC", VA = "0x9A28CC")]
			public Node()
			{
			}

			[Token(Token = "0x6000320")]
			[Address(RVA = "0x9A28D0", Offset = "0x9A28D0", VA = "0x9A28D0")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x9A28F4", Offset = "0x9A28F4", VA = "0x9A28F4")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000061")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000062")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x1700003A")]
		public bool initiated
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x9A186C", Offset = "0x9A186C", VA = "0x9A186C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x9A1874", Offset = "0x9A1874", VA = "0x9A1874")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x9A15CC", Offset = "0x9A15CC", VA = "0x9A15CC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x9A1640", Offset = "0x9A1640", VA = "0x9A1640")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x9A17B8", Offset = "0x9A17B8", VA = "0x9A17B8")]
		public void Update()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x9A1828", Offset = "0x9A1828", VA = "0x9A1828", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x9A1834", Offset = "0x9A1834", VA = "0x9A1834")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x9A1840", Offset = "0x9A1840", VA = "0x9A1840")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x9A1848", Offset = "0x9A1848", VA = "0x9A1848")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x9A1864", Offset = "0x9A1864", VA = "0x9A1864")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000305")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000306")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000307")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000308")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000309")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x9A1880", Offset = "0x9A1880", VA = "0x9A1880")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x9A1898", Offset = "0x9A1898", VA = "0x9A1898")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x9A19BC", Offset = "0x9A19BC", VA = "0x9A19BC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x9A1A54", Offset = "0x9A1A54", VA = "0x9A1A54")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x9A1C48", Offset = "0x9A1C48", VA = "0x9A1C48")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x1700003C")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x9A2CC4", Offset = "0x9A2CC4", VA = "0x9A2CC4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003D")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x9A2CF4", Offset = "0x9A2CF4", VA = "0x9A2CF4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003E")]
		protected override int minBones
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x9A3928", Offset = "0x9A3928", VA = "0x9A3928", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003F")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x9A3E68", Offset = "0x9A3E68", VA = "0x9A3E68", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x9A2B8C", Offset = "0x9A2B8C", VA = "0x9A2B8C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x9A2D24", Offset = "0x9A2D24", VA = "0x9A2D24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x9A2FB0", Offset = "0x9A2FB0", VA = "0x9A2FB0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x9A3880", Offset = "0x9A3880", VA = "0x9A3880")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x9A351C", Offset = "0x9A351C", VA = "0x9A351C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x9A3930", Offset = "0x9A3930", VA = "0x9A3930")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x9A3EC8", Offset = "0x9A3EC8", VA = "0x9A3EC8")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x9A3F6C", Offset = "0x9A3F6C", VA = "0x9A3F6C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x9A42C8", Offset = "0x9A42C8", VA = "0x9A42C8")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9A4328", Offset = "0x9A4328", VA = "0x9A4328", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9A446C", Offset = "0x9A446C", VA = "0x9A446C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x9A45CC", Offset = "0x9A45CC", VA = "0x9A45CC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x9A460C", Offset = "0x9A460C", VA = "0x9A460C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9A465C", Offset = "0x9A465C", VA = "0x9A465C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9A49BC", Offset = "0x9A49BC", VA = "0x9A49BC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x9A49DC", Offset = "0x9A49DC", VA = "0x9A49DC")]
		private void Solve()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9A46B4", Offset = "0x9A46B4", VA = "0x9A46B4")]
		private void Read()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9A4A40", Offset = "0x9A4A40", VA = "0x9A4A40")]
		private void Write()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x9A4BB8", Offset = "0x9A4BB8", VA = "0x9A4BB8")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000065")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9A4D4C", Offset = "0x9A4D4C", VA = "0x9A4D4C")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x9A4DBC", Offset = "0x9A4DBC", VA = "0x9A4DBC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x9A4E2C", Offset = "0x9A4E2C", VA = "0x9A4E2C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x9A50E0", Offset = "0x9A50E0", VA = "0x9A50E0")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x9A5770", Offset = "0x9A5770", VA = "0x9A5770")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000066")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000040")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x9A6718", Offset = "0x9A6718", VA = "0x9A6718", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x9A5778", Offset = "0x9A5778", VA = "0x9A5778")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9A5D58", Offset = "0x9A5D58", VA = "0x9A5D58")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x9A5E88", Offset = "0x9A5E88", VA = "0x9A5E88", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x9A5F10", Offset = "0x9A5F10", VA = "0x9A5F10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x9A640C", Offset = "0x9A640C", VA = "0x9A640C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x9A6720", Offset = "0x9A6720", VA = "0x9A6720")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9A5850", Offset = "0x9A5850", VA = "0x9A5850")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9A5E40", Offset = "0x9A5E40", VA = "0x9A5E40")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x9A66D0", Offset = "0x9A66D0", VA = "0x9A66D0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x9A5BEC", Offset = "0x9A5BEC", VA = "0x9A5BEC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x9A6DCC", Offset = "0x9A6DCC", VA = "0x9A6DCC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x9A6E34", Offset = "0x9A6E34", VA = "0x9A6E34")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x9A6F04", Offset = "0x9A6F04", VA = "0x9A6F04")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x9A6FCC", Offset = "0x9A6FCC", VA = "0x9A6FCC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x9A6184", Offset = "0x9A6184", VA = "0x9A6184")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x9A62C8", Offset = "0x9A62C8", VA = "0x9A62C8")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x9A70BC", Offset = "0x9A70BC", VA = "0x9A70BC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x9A69BC", Offset = "0x9A69BC", VA = "0x9A69BC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x9A5E30", Offset = "0x9A5E30", VA = "0x9A5E30")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x9A772C", Offset = "0x9A772C", VA = "0x9A772C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x9A727C", Offset = "0x9A727C", VA = "0x9A727C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x9A683C", Offset = "0x9A683C", VA = "0x9A683C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x9A690C", Offset = "0x9A690C", VA = "0x9A690C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x9A77E4", Offset = "0x9A77E4", VA = "0x9A77E4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000067")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x9A7868", Offset = "0x9A7868", VA = "0x9A7868", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x9A7EBC", Offset = "0x9A7EBC", VA = "0x9A7EBC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x9A7F48", Offset = "0x9A7F48", VA = "0x9A7F48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x9A7FDC", Offset = "0x9A7FDC", VA = "0x9A7FDC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x9A80C4", Offset = "0x9A80C4", VA = "0x9A80C4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x9A8154", Offset = "0x9A8154", VA = "0x9A8154", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x9A8554", Offset = "0x9A8554", VA = "0x9A8554", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x9A872C", Offset = "0x9A872C", VA = "0x9A872C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9A85F4", Offset = "0x9A85F4", VA = "0x9A85F4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x9A832C", Offset = "0x9A832C", VA = "0x9A832C")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x9A87B0", Offset = "0x9A87B0", VA = "0x9A87B0")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x9A8820", Offset = "0x9A8820", VA = "0x9A8820")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x9A88FC", Offset = "0x9A88FC", VA = "0x9A88FC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x99ACB0", Offset = "0x99ACB0", VA = "0x99ACB0")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x99C610", Offset = "0x99C610", VA = "0x99C610")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x99B730", Offset = "0x99B730", VA = "0x99B730")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x9A8944", Offset = "0x9A8944", VA = "0x9A8944", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x9A8ADC", Offset = "0x9A8ADC", VA = "0x9A8ADC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x9A8C38", Offset = "0x9A8C38", VA = "0x9A8C38", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x9A8E34", Offset = "0x9A8E34", VA = "0x9A8E34", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x9A8F04", Offset = "0x9A8F04", VA = "0x9A8F04", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x9A8FE0", Offset = "0x9A8FE0", VA = "0x9A8FE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x9A913C", Offset = "0x9A913C", VA = "0x9A913C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x9A92D4", Offset = "0x9A92D4", VA = "0x9A92D4", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x9A94FC", Offset = "0x9A94FC", VA = "0x9A94FC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x9A97CC", Offset = "0x9A97CC", VA = "0x9A97CC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x9A9804", Offset = "0x9A9804", VA = "0x9A9804", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x9A98DC", Offset = "0x9A98DC", VA = "0x9A98DC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000069")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40002DF")]
		Body,
		[Token(Token = "0x40002E0")]
		LeftShoulder,
		[Token(Token = "0x40002E1")]
		RightShoulder,
		[Token(Token = "0x40002E2")]
		LeftThigh,
		[Token(Token = "0x40002E3")]
		RightThigh,
		[Token(Token = "0x40002E4")]
		LeftHand,
		[Token(Token = "0x40002E5")]
		RightHand,
		[Token(Token = "0x40002E6")]
		LeftFoot,
		[Token(Token = "0x40002E7")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40002E9")]
		LeftArm,
		[Token(Token = "0x40002EA")]
		RightArm,
		[Token(Token = "0x40002EB")]
		LeftLeg,
		[Token(Token = "0x40002EC")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000041")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x9A99F4", Offset = "0x9A99F4", VA = "0x9A99F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x9A9B34", Offset = "0x9A9B34", VA = "0x9A9B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x9A9B3C", Offset = "0x9A9B3C", VA = "0x9A9B3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x9A9B44", Offset = "0x9A9B44", VA = "0x9A9B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x9A9B4C", Offset = "0x9A9B4C", VA = "0x9A9B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x9A9B54", Offset = "0x9A9B54", VA = "0x9A9B54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x9A9B5C", Offset = "0x9A9B5C", VA = "0x9A9B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x9A9B64", Offset = "0x9A9B64", VA = "0x9A9B64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x9A9B6C", Offset = "0x9A9B6C", VA = "0x9A9B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x9A9B74", Offset = "0x9A9B74", VA = "0x9A9B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x9A9BA0", Offset = "0x9A9BA0", VA = "0x9A9BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x9A9BCC", Offset = "0x9A9BCC", VA = "0x9A9BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x9A9BF8", Offset = "0x9A9BF8", VA = "0x9A9BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x9A9C24", Offset = "0x9A9C24", VA = "0x9A9C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x9A9C4C", Offset = "0x9A9C4C", VA = "0x9A9C4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x9A9C78", Offset = "0x9A9C78", VA = "0x9A9C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x9A9CA4", Offset = "0x9A9CA4", VA = "0x9A9CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x9A9CD0", Offset = "0x9A9CD0", VA = "0x9A9CD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x9ABA30", Offset = "0x9ABA30", VA = "0x9ABA30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x9ABA3C", Offset = "0x9ABA3C", VA = "0x9ABA3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x9A9CF8", Offset = "0x9A9CF8", VA = "0x9A9CF8")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x9A9DF8", Offset = "0x9A9DF8", VA = "0x9A9DF8")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x9A9D48", Offset = "0x9A9D48", VA = "0x9A9D48")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x9A9E70", Offset = "0x9A9E70", VA = "0x9A9E70")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x9A99FC", Offset = "0x9A99FC", VA = "0x9A99FC")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x9A9F38", Offset = "0x9A9F38", VA = "0x9A9F38")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x9A9FE8", Offset = "0x9A9FE8", VA = "0x9A9FE8")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x9AA094", Offset = "0x9AA094", VA = "0x9AA094")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x9AA140", Offset = "0x9AA140", VA = "0x9AA140")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x9AA148", Offset = "0x9AA148", VA = "0x9AA148")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x9AA170", Offset = "0x9AA170", VA = "0x9AA170")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x9AA230", Offset = "0x9AA230", VA = "0x9AA230", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x9AA3C0", Offset = "0x9AA3C0", VA = "0x9AA3C0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x9AB334", Offset = "0x9AB334", VA = "0x9AB334")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x9AB8E4", Offset = "0x9AB8E4", VA = "0x9AB8E4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9AB940", Offset = "0x9AB940", VA = "0x9AB940")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9AB784", Offset = "0x9AB784", VA = "0x9AB784")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9AB834", Offset = "0x9AB834", VA = "0x9AB834")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9ABA48", Offset = "0x9ABA48", VA = "0x9ABA48")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x9ABB0C", Offset = "0x9ABB0C", VA = "0x9ABB0C", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x9ABBD8", Offset = "0x9ABBD8", VA = "0x9ABBD8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x9ABCF4", Offset = "0x9ABCF4", VA = "0x9ABCF4")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x9ABE84", Offset = "0x9ABE84", VA = "0x9ABE84")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x9ABFFC", Offset = "0x9ABFFC", VA = "0x9ABFFC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x9AC258", Offset = "0x9AC258", VA = "0x9AC258", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9AC2D0", Offset = "0x9AC2D0", VA = "0x9AC2D0")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x17000054")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x9ACB10", Offset = "0x9ACB10", VA = "0x9ACB10", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x9ACB18", Offset = "0x9ACB18", VA = "0x9ACB18", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x9ACB20", Offset = "0x9ACB20", VA = "0x9ACB20", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x9ACFC4", Offset = "0x9ACFC4", VA = "0x9ACFC4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000058")]
		protected float positionOffset
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x9AD080", Offset = "0x9AD080", VA = "0x9AD080")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9AC2DC", Offset = "0x9AC2DC", VA = "0x9AC2DC")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x9AC460", Offset = "0x9AC460", VA = "0x9AC460")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x9AC58C", Offset = "0x9AC58C", VA = "0x9AC58C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x9AC5EC", Offset = "0x9AC5EC", VA = "0x9AC5EC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x9AC660", Offset = "0x9AC660", VA = "0x9AC660", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x9ACA2C", Offset = "0x9ACA2C", VA = "0x9ACA2C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9ACA34", Offset = "0x9ACA34", VA = "0x9ACA34", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9ACB28", Offset = "0x9ACB28", VA = "0x9ACB28", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9ACB2C", Offset = "0x9ACB2C", VA = "0x9ACB2C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9ACB30", Offset = "0x9ACB30", VA = "0x9ACB30")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x9AD0C8", Offset = "0x9AD0C8", VA = "0x9AD0C8")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x9AD480", Offset = "0x9AD480", VA = "0x9AD480")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x9AD714", Offset = "0x9AD714", VA = "0x9AD714")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006D")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x9AD77C", Offset = "0x9AD77C", VA = "0x9AD77C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x9ADAD8", Offset = "0x9ADAD8", VA = "0x9ADAD8")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9ADB3C", Offset = "0x9ADB3C", VA = "0x9ADB3C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x9ADC80", Offset = "0x9ADC80", VA = "0x9ADC80", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x9ADDE0", Offset = "0x9ADDE0", VA = "0x9ADDE0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x9ADE30", Offset = "0x9ADE30", VA = "0x9ADE30", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x9ADE90", Offset = "0x9ADE90", VA = "0x9ADE90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x9AE1EC", Offset = "0x9AE1EC", VA = "0x9AE1EC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x9AE20C", Offset = "0x9AE20C", VA = "0x9AE20C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x9ADEE8", Offset = "0x9ADEE8", VA = "0x9ADEE8")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x9AE294", Offset = "0x9AE294", VA = "0x9AE294")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x9AE718", Offset = "0x9AE718", VA = "0x9AE718")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006E")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200006F")]
		public enum BendModifier
		{
			[Token(Token = "0x4000317")]
			Animation,
			[Token(Token = "0x4000318")]
			Target,
			[Token(Token = "0x4000319")]
			Parent,
			[Token(Token = "0x400031A")]
			Arm,
			[Token(Token = "0x400031B")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x2000070")]
		public struct AxisDirection
		{
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x9AFD74", Offset = "0x9AFD74", VA = "0x9AFD74")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000059")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x9AFD58", Offset = "0x9AFD58", VA = "0x9AFD58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x9AE988", Offset = "0x9AE988", VA = "0x9AE988")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x9AE9CC", Offset = "0x9AE9CC", VA = "0x9AE9CC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x9AEA38", Offset = "0x9AEA38", VA = "0x9AEA38", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x9AEF80", Offset = "0x9AEF80", VA = "0x9AEF80", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x9AFA9C", Offset = "0x9AFA9C", VA = "0x9AFA9C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x9AFB44", Offset = "0x9AFB44", VA = "0x9AFB44")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x9AFCD8", Offset = "0x9AFCD8", VA = "0x9AFCD8")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x9AED94", Offset = "0x9AED94", VA = "0x9AED94")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x9AF03C", Offset = "0x9AF03C", VA = "0x9AF03C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x17000060")]
			public Vector3 forward
			{
				[Token(Token = "0x60003F1")]
				[Address(RVA = "0x9B1B40", Offset = "0x9B1B40", VA = "0x9B1B40")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x9B2198", Offset = "0x9B2198", VA = "0x9B2198")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x9B0CA0", Offset = "0x9B0CA0", VA = "0x9B0CA0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x9B0F50", Offset = "0x9B0F50", VA = "0x9B0F50")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x9B1E88", Offset = "0x9B1E88", VA = "0x9B1E88")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x1700005A")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x9B04A4", Offset = "0x9B04A4", VA = "0x9B04A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x9B064C", Offset = "0x9B064C", VA = "0x9B064C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		protected bool headIsValid
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x9B0570", Offset = "0x9B0570", VA = "0x9B0570")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x9B0670", Offset = "0x9B0670", VA = "0x9B0670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x9B0580", Offset = "0x9B0580", VA = "0x9B0580")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x9B06DC", Offset = "0x9B06DC", VA = "0x9B06DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x9AFF10", Offset = "0x9AFF10", VA = "0x9AFF10")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x9AFF2C", Offset = "0x9AFF2C", VA = "0x9AFF2C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9AFF58", Offset = "0x9AFF58", VA = "0x9AFF58")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x9AFF90", Offset = "0x9AFF90", VA = "0x9AFF90")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x9AFFD8", Offset = "0x9AFFD8", VA = "0x9AFFD8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x9B0030", Offset = "0x9B0030", VA = "0x9B0030")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x9B00A0", Offset = "0x9B00A0", VA = "0x9B00A0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9B01B8", Offset = "0x9B01B8", VA = "0x9B01B8")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x9B01C4", Offset = "0x9B01C4", VA = "0x9B01C4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x9B02F4", Offset = "0x9B02F4", VA = "0x9B02F4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x9B0700", Offset = "0x9B0700", VA = "0x9B0700", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x9B0924", Offset = "0x9B0924", VA = "0x9B0924", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x9B0A84", Offset = "0x9B0A84", VA = "0x9B0A84")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x9B0CC8", Offset = "0x9B0CC8", VA = "0x9B0CC8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x9B103C", Offset = "0x9B103C", VA = "0x9B103C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x9B1100", Offset = "0x9B1100", VA = "0x9B1100")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x9B131C", Offset = "0x9B131C", VA = "0x9B131C")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x9B1664", Offset = "0x9B1664", VA = "0x9B1664")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x9B1B70", Offset = "0x9B1B70", VA = "0x9B1B70")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x9B0B34", Offset = "0x9B0B34", VA = "0x9B0B34")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x9B1F90", Offset = "0x9B1F90", VA = "0x9B1F90")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000074")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x9B343C", Offset = "0x9B343C", VA = "0x9B343C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x9B3CE4", Offset = "0x9B3CE4", VA = "0x9B3CE4")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x9AEA08", Offset = "0x9AEA08", VA = "0x9AEA08")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x9B3D80", Offset = "0x9B3D80", VA = "0x9B3D80")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x9B21A0", Offset = "0x9B21A0", VA = "0x9B21A0")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x9B2334", Offset = "0x9B2334", VA = "0x9B2334")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x9B24B4", Offset = "0x9B24B4", VA = "0x9B24B4")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x9B24C0", Offset = "0x9B24C0", VA = "0x9B24C0")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x9B24DC", Offset = "0x9B24DC", VA = "0x9B24DC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x9B24E8", Offset = "0x9B24E8", VA = "0x9B24E8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x9B24F0", Offset = "0x9B24F0", VA = "0x9B24F0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x9B25DC", Offset = "0x9B25DC", VA = "0x9B25DC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x9B26D4", Offset = "0x9B26D4", VA = "0x9B26D4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x9B2714", Offset = "0x9B2714", VA = "0x9B2714", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x9B2764", Offset = "0x9B2764", VA = "0x9B2764", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x9B2B08", Offset = "0x9B2B08", VA = "0x9B2B08")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x9B2B54", Offset = "0x9B2B54", VA = "0x9B2B54")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x9B3048", Offset = "0x9B3048", VA = "0x9B3048")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x9B31A0", Offset = "0x9B31A0", VA = "0x9B31A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x9B334C", Offset = "0x9B334C", VA = "0x9B334C")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x9B32CC", Offset = "0x9B32CC", VA = "0x9B32CC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x9B352C", Offset = "0x9B352C", VA = "0x9B352C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x9B3D74", Offset = "0x9B3D74", VA = "0x9B3D74", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x9B3D78", Offset = "0x9B3D78", VA = "0x9B3D78", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x9B3D7C", Offset = "0x9B3D7C", VA = "0x9B3D7C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x9B3B24", Offset = "0x9B3B24", VA = "0x9B3B24")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x9AFBB0", Offset = "0x9AFBB0", VA = "0x9AFBB0")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000075")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000077")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x400037F")]
				YawPitch,
				[Token(Token = "0x4000380")]
				FromTo
			}

			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("The weight of shoulder rotation")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			[Range(0f, 1f)]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			[Range(0.01f, 2f)]
			public float armLengthMlp;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x400037C")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400037D")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000062")]
			public Vector3 position
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0x9B9678", Offset = "0x9B9678", VA = "0x9B9678")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600042A")]
				[Address(RVA = "0x9B9684", Offset = "0x9B9684", VA = "0x9B9684")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public Quaternion rotation
			{
				[Token(Token = "0x600042B")]
				[Address(RVA = "0x9B9690", Offset = "0x9B9690", VA = "0x9B9690")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600042C")]
				[Address(RVA = "0x9B969C", Offset = "0x9B969C", VA = "0x9B969C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600042D")]
				[Address(RVA = "0x9B96A8", Offset = "0x9B96A8", VA = "0x9B96A8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600042E")]
				[Address(RVA = "0x9B96D0", Offset = "0x9B96D0", VA = "0x9B96D0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600042F")]
				[Address(RVA = "0x9B9704", Offset = "0x9B9704", VA = "0x9B9704")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000067")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000430")]
				[Address(RVA = "0x9B9744", Offset = "0x9B9744", VA = "0x9B9744")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x9B9784", Offset = "0x9B9784", VA = "0x9B9784", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x9BA084", Offset = "0x9BA084", VA = "0x9BA084", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x9BA330", Offset = "0x9BA330", VA = "0x9BA330", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x9BA354", Offset = "0x9BA354", VA = "0x9BA354")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x9B75C4", Offset = "0x9B75C4", VA = "0x9B75C4")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x9BAD88", Offset = "0x9BAD88", VA = "0x9BAD88", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x9BADE0", Offset = "0x9BADE0", VA = "0x9BADE0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x9BA6A4", Offset = "0x9BA6A4", VA = "0x9BA6A4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x9BA724", Offset = "0x9BA724", VA = "0x9BA724")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x9BAFEC", Offset = "0x9BAFEC", VA = "0x9BAFEC")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x9B94EC", Offset = "0x9B94EC", VA = "0x9B94EC")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000078")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x17000068")]
			public float sqrMag
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x9BB19C", Offset = "0x9BB19C", VA = "0x9BB19C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000442")]
				[Address(RVA = "0x9BB1A4", Offset = "0x9BB1A4", VA = "0x9BB1A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public float mag
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0x9BB1AC", Offset = "0x9BB1AC", VA = "0x9BB1AC")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000444")]
				[Address(RVA = "0x9BB1B4", Offset = "0x9BB1B4", VA = "0x9BB1B4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600043C")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600043D")]
			public abstract void PreSolve();

			[Token(Token = "0x600043E")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600043F")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000440")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x9BB1BC", Offset = "0x9BB1BC", VA = "0x9BB1BC")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x9AE658", Offset = "0x9AE658", VA = "0x9AE658")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x9BB1C4", Offset = "0x9BB1C4", VA = "0x9BB1C4")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x9BB24C", Offset = "0x9BB24C", VA = "0x9BB24C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000449")]
			[Address(RVA = "0x9BB2E4", Offset = "0x9BB2E4", VA = "0x9BB2E4")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x9B749C", Offset = "0x9B749C", VA = "0x9B749C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600044B")]
			[Address(RVA = "0x9BAC20", Offset = "0x9BAC20", VA = "0x9BAC20")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x9BB32C", Offset = "0x9BB32C", VA = "0x9BB32C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600044D")]
			[Address(RVA = "0x9BB450", Offset = "0x9BB450", VA = "0x9BB450")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x9BB104", Offset = "0x9BB104", VA = "0x9BB104")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Footstep
		{
			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700006A")]
			public bool isStepping
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x9BB464", Offset = "0x9BB464", VA = "0x9BB464")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700006B")]
			public float stepProgress
			{
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x9BB478", Offset = "0x9BB478", VA = "0x9BB478")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x9BB480", Offset = "0x9BB480", VA = "0x9BB480")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x9BB488", Offset = "0x9BB488", VA = "0x9BB488")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x9BB64C", Offset = "0x9BB64C", VA = "0x9BB64C")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x9BB694", Offset = "0x9BB694", VA = "0x9BB694")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0x9BB8D8", Offset = "0x9BB8D8", VA = "0x9BB8D8")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000456")]
			[Address(RVA = "0x9BBAE0", Offset = "0x9BBAE0", VA = "0x9BBAE0")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0x9BBCC4", Offset = "0x9BBCC4", VA = "0x9BBCC4")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			[Range(0f, 1f)]
			public float bendGoalWeight;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Angular offset of knee bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			public float bendToTargetWeight;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x40003B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x40003B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x1700006C")]
			public Vector3 position
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x9BBE38", Offset = "0x9BBE38", VA = "0x9BBE38")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x9BBE44", Offset = "0x9BBE44", VA = "0x9BBE44")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006D")]
			public Quaternion rotation
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x9BBE50", Offset = "0x9BBE50", VA = "0x9BBE50")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x9BBE5C", Offset = "0x9BBE5C", VA = "0x9BBE5C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006E")]
			public bool hasToes
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x9BBE68", Offset = "0x9BBE68", VA = "0x9BBE68")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x9BBE70", Offset = "0x9BBE70", VA = "0x9BBE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006F")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x9BBE7C", Offset = "0x9BBE7C", VA = "0x9BBE7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000070")]
			private VirtualBone calf
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x9BBEA4", Offset = "0x9BBEA4", VA = "0x9BBEA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000071")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000460")]
				[Address(RVA = "0x9BBED0", Offset = "0x9BBED0", VA = "0x9BBED0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000461")]
				[Address(RVA = "0x9BBEFC", Offset = "0x9BBEFC", VA = "0x9BBEFC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000462")]
				[Address(RVA = "0x9B7468", Offset = "0x9B7468", VA = "0x9B7468")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000463")]
				[Address(RVA = "0x9BBF28", Offset = "0x9BBF28", VA = "0x9BBF28")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000464")]
				[Address(RVA = "0x9BBF34", Offset = "0x9BBF34", VA = "0x9BBF34")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x9BBF40", Offset = "0x9BBF40", VA = "0x9BBF40", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000466")]
			[Address(RVA = "0x9BC4A8", Offset = "0x9BC4A8", VA = "0x9BC4A8", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x9BCCD8", Offset = "0x9BCCD8", VA = "0x9BCCD8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000468")]
			[Address(RVA = "0x9BCC88", Offset = "0x9BCC88", VA = "0x9BCC88")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000469")]
			[Address(RVA = "0x9BCA3C", Offset = "0x9BCA3C", VA = "0x9BCA3C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600046A")]
			[Address(RVA = "0x9AE40C", Offset = "0x9AE40C", VA = "0x9AE40C")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600046B")]
			[Address(RVA = "0x9BD590", Offset = "0x9BD590", VA = "0x9BD590")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600046C")]
			[Address(RVA = "0x9BD1B4", Offset = "0x9BD1B4", VA = "0x9BD1B4")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x9BD9E8", Offset = "0x9BD9E8", VA = "0x9BD9E8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x9BDBF0", Offset = "0x9BDBF0", VA = "0x9BDBF0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x9AE8AC", Offset = "0x9AE8AC", VA = "0x9AE8AC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public class Locomotion
		{
			[Token(Token = "0x40003B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x40003B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x40003B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x40003B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x40003B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x40003B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 180f)]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x40003C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x40003CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x17000075")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x9BECD0", Offset = "0x9BECD0", VA = "0x9BECD0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000471")]
				[Address(RVA = "0x9BECDC", Offset = "0x9BECDC", VA = "0x9BECDC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000076")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000478")]
				[Address(RVA = "0x9C0FBC", Offset = "0x9C0FBC", VA = "0x9C0FBC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000077")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0x9C0FF0", Offset = "0x9C0FF0", VA = "0x9C0FF0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000078")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600047A")]
				[Address(RVA = "0x9C1028", Offset = "0x9C1028", VA = "0x9C1028")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x17000079")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0x9C105C", Offset = "0x9C105C", VA = "0x9C105C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000472")]
			[Address(RVA = "0x9BECE8", Offset = "0x9BECE8", VA = "0x9BECE8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000473")]
			[Address(RVA = "0x9BEFF8", Offset = "0x9BEFF8", VA = "0x9BEFF8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000474")]
			[Address(RVA = "0x9BF1E4", Offset = "0x9BF1E4", VA = "0x9BF1E4")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000475")]
			[Address(RVA = "0x9BF230", Offset = "0x9BF230", VA = "0x9BF230")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0x9BF5F8", Offset = "0x9BF5F8", VA = "0x9BF5F8")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0x9BF6B0", Offset = "0x9BF6B0", VA = "0x9BF6B0")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x9C0BC8", Offset = "0x9C0BC8", VA = "0x9C0BC8")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x9C0D7C", Offset = "0x9C0D7C", VA = "0x9C0D7C")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x9C0E0C", Offset = "0x9C0E0C", VA = "0x9C0E0C")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600047F")]
			[Address(RVA = "0x9C1094", Offset = "0x9C1094", VA = "0x9C1094")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x40003D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			[Range(0f, 1f)]
			public float bodyPosStiffness;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[FormerlySerializedAs("chestRotationWeight")]
			public float neckStiffness;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			[Range(0f, 1f)]
			public float rotateChestByHands;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			[Range(0f, 1f)]
			public float chestClampWeight;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			[Range(0f, 180f)]
			public float maxRootAngle;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x1700007A")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000480")]
				[Address(RVA = "0x9C0B60", Offset = "0x9C0B60", VA = "0x9C0B60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x9C118C", Offset = "0x9C118C", VA = "0x9C118C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000482")]
				[Address(RVA = "0x9C11C0", Offset = "0x9C11C0", VA = "0x9C11C0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000483")]
				[Address(RVA = "0x9C1208", Offset = "0x9C1208", VA = "0x9C1208")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			public VirtualBone head
			{
				[Token(Token = "0x6000484")]
				[Address(RVA = "0x9C0B94", Offset = "0x9C0B94", VA = "0x9C0B94")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x9C123C", Offset = "0x9C123C", VA = "0x9C123C")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000486")]
				[Address(RVA = "0x9C1250", Offset = "0x9C1250", VA = "0x9C1250")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x9C1264", Offset = "0x9C1264", VA = "0x9C1264")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000488")]
				[Address(RVA = "0x9C1278", Offset = "0x9C1278", VA = "0x9C1278")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000489")]
			[Address(RVA = "0x9C128C", Offset = "0x9C128C", VA = "0x9C128C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600048A")]
			[Address(RVA = "0x9C1F7C", Offset = "0x9C1F7C", VA = "0x9C1F7C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600048B")]
			[Address(RVA = "0x9C2164", Offset = "0x9C2164", VA = "0x9C2164", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600048C")]
			[Address(RVA = "0x9C290C", Offset = "0x9C290C", VA = "0x9C290C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600048D")]
			[Address(RVA = "0x9C2F48", Offset = "0x9C2F48", VA = "0x9C2F48")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600048E")]
			[Address(RVA = "0x9C38AC", Offset = "0x9C38AC", VA = "0x9C38AC")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600048F")]
			[Address(RVA = "0x9C4054", Offset = "0x9C4054", VA = "0x9C4054")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000490")]
			[Address(RVA = "0x9C4A18", Offset = "0x9C4A18", VA = "0x9C4A18", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000491")]
			[Address(RVA = "0x9C4BE8", Offset = "0x9C4BE8", VA = "0x9C4BE8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000492")]
			[Address(RVA = "0x9C2B50", Offset = "0x9C2B50", VA = "0x9C2B50")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000493")]
			[Address(RVA = "0x9C3D7C", Offset = "0x9C3D7C", VA = "0x9C3D7C")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000494")]
			[Address(RVA = "0x9C348C", Offset = "0x9C348C", VA = "0x9C348C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000495")]
			[Address(RVA = "0x9C4CBC", Offset = "0x9C4CBC", VA = "0x9C4CBC")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x9C3E58", Offset = "0x9C3E58", VA = "0x9C3E58")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000497")]
			[Address(RVA = "0x9C3B0C", Offset = "0x9C3B0C", VA = "0x9C3B0C")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000498")]
			[Address(RVA = "0x9C50D4", Offset = "0x9C50D4", VA = "0x9C50D4")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000408")]
			Pelvis,
			[Token(Token = "0x4000409")]
			Chest,
			[Token(Token = "0x400040A")]
			Head,
			[Token(Token = "0x400040B")]
			LeftHand,
			[Token(Token = "0x400040C")]
			RightHand,
			[Token(Token = "0x400040D")]
			LeftFoot,
			[Token(Token = "0x400040E")]
			RightFoot,
			[Token(Token = "0x400040F")]
			LeftHeel,
			[Token(Token = "0x4000410")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000412")]
			Pelvis,
			[Token(Token = "0x4000413")]
			Chest,
			[Token(Token = "0x4000414")]
			Head
		}

		[Serializable]
		[Token(Token = "0x200007F")]
		public class VirtualBone
		{
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000499")]
			[Address(RVA = "0x9C1EEC", Offset = "0x9C1EEC", VA = "0x9C1EEC")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049A")]
			[Address(RVA = "0x9C1F5C", Offset = "0x9C1F5C", VA = "0x9C1F5C")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049B")]
			[Address(RVA = "0x9C51F0", Offset = "0x9C51F0", VA = "0x9C51F0")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600049C")]
			[Address(RVA = "0x9C53F0", Offset = "0x9C53F0", VA = "0x9C53F0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600049D")]
			[Address(RVA = "0x9C4F64", Offset = "0x9C4F64", VA = "0x9C4F64")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049E")]
			[Address(RVA = "0x9C5550", Offset = "0x9C5550", VA = "0x9C5550")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600049F")]
			[Address(RVA = "0x9C56F8", Offset = "0x9C56F8", VA = "0x9C56F8")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x9C5880", Offset = "0x9C5880", VA = "0x9C5880")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x9C4634", Offset = "0x9C4634", VA = "0x9C4634")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x9C5924", Offset = "0x9C5924", VA = "0x9C5924")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x9C4268", Offset = "0x9C4268", VA = "0x9C4268")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x9C5A7C", Offset = "0x9C5A7C", VA = "0x9C5A7C")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x9C5B90", Offset = "0x9C5B90", VA = "0x9C5B90")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		[Range(0f, 2f)]
		public int LOD;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000061")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x9B92A8", Offset = "0x9B92A8", VA = "0x9B92A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x9B92B0", Offset = "0x9B92B0", VA = "0x9B92B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x9B3D88", Offset = "0x9B3D88", VA = "0x9B3D88")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x9B41A8", Offset = "0x9B41A8", VA = "0x9B41A8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x9B405C", Offset = "0x9B405C", VA = "0x9B405C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x9B45BC", Offset = "0x9B45BC", VA = "0x9B45BC")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x9B4700", Offset = "0x9B4700", VA = "0x9B4700")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x9B4740", Offset = "0x9B4740", VA = "0x9B4740")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x9B4864", Offset = "0x9B4864", VA = "0x9B4864")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x9B4940", Offset = "0x9B4940", VA = "0x9B4940")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x9B50B8", Offset = "0x9B50B8", VA = "0x9B50B8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x9B520C", Offset = "0x9B520C", VA = "0x9B520C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x9B53F8", Offset = "0x9B53F8", VA = "0x9B53F8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x9B5468", Offset = "0x9B5468", VA = "0x9B5468", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x9B54D8", Offset = "0x9B54D8", VA = "0x9B54D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x9B56D4", Offset = "0x9B56D4", VA = "0x9B56D4")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x9B44A8", Offset = "0x9B44A8", VA = "0x9B44A8")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x9B4A54", Offset = "0x9B4A54", VA = "0x9B4A54")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x9B5944", Offset = "0x9B5944", VA = "0x9B5944", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x9B5980", Offset = "0x9B5980", VA = "0x9B5980", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x9B6FA0", Offset = "0x9B6FA0", VA = "0x9B6FA0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x9B4BA4", Offset = "0x9B4BA4", VA = "0x9B4BA4")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x9B5D8C", Offset = "0x9B5D8C", VA = "0x9B5D8C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x9B73F4", Offset = "0x9B73F4", VA = "0x9B73F4")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x9B7430", Offset = "0x9B7430", VA = "0x9B7430")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x9B6E64", Offset = "0x9B6E64", VA = "0x9B6E64")]
		private void Write()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x9B8BBC", Offset = "0x9B8BBC", VA = "0x9B8BBC")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x9B92B8", Offset = "0x9B92B8", VA = "0x9B92B8")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x9C5D44", Offset = "0x9C5D44", VA = "0x9C5D44")]
		public void Start()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x9C6370", Offset = "0x9C6370", VA = "0x9C6370")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x9C6904", Offset = "0x9C6904", VA = "0x9C6904")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x9C69B4", Offset = "0x9C69B4", VA = "0x9C69B4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x9C6ACC", Offset = "0x9C6ACC", VA = "0x9C6ACC")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class TwistSolver
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Rotation offset around the twist axis.")]
		[Range(-180f, 180f)]
		public float twistAngleOffset;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x9C6B24", Offset = "0x9C6B24", VA = "0x9C6B24")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x9C5F0C", Offset = "0x9C5F0C", VA = "0x9C5F0C")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x9C6420", Offset = "0x9C6420", VA = "0x9C6420")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class InteractionEffector
	{
		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x17000081")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x9C6C0C", Offset = "0x9C6C0C", VA = "0x9C6C0C")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x9C6C14", Offset = "0x9C6C14", VA = "0x9C6C14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool isPaused
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x9C6C1C", Offset = "0x9C6C1C", VA = "0x9C6C1C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x9C6C24", Offset = "0x9C6C24", VA = "0x9C6C24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x9C6C30", Offset = "0x9C6C30", VA = "0x9C6C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x9C6C38", Offset = "0x9C6C38", VA = "0x9C6C38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x9C6C40", Offset = "0x9C6C40", VA = "0x9C6C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public float progress
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x9C9428", Offset = "0x9C9428", VA = "0x9C9428")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x9C6CA0", Offset = "0x9C6CA0", VA = "0x9C6CA0")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x9C6D30", Offset = "0x9C6D30", VA = "0x9C6D30")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x9C6DBC", Offset = "0x9C6DBC", VA = "0x9C6DBC")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x9C6F28", Offset = "0x9C6F28", VA = "0x9C6F28")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x9C7304", Offset = "0x9C7304", VA = "0x9C7304")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x9C7424", Offset = "0x9C7424", VA = "0x9C7424")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x9C7478", Offset = "0x9C7478", VA = "0x9C7478")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x9C8104", Offset = "0x9C8104", VA = "0x9C8104")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x9C8BEC", Offset = "0x9C8BEC", VA = "0x9C8BEC")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x9C8E0C", Offset = "0x9C8E0C", VA = "0x9C8E0C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x9C92E0", Offset = "0x9C92E0", VA = "0x9C92E0")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x9C9628", Offset = "0x9C9628", VA = "0x9C9628")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x9C98F0", Offset = "0x9C98F0", VA = "0x9C98F0")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x9C9A00", Offset = "0x9C9A00", VA = "0x9C9A00")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x9C9A98", Offset = "0x9C9A98", VA = "0x9C9A98")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x9C9C88", Offset = "0x9C9C88", VA = "0x9C9C88")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x9C9D30", Offset = "0x9C9D30", VA = "0x9C9D30")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x9C9DDC", Offset = "0x9C9DDC", VA = "0x9C9DDC")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000085")]
		public class InteractionEvent
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x9C9458", Offset = "0x9C9458", VA = "0x9C9458")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x9CAD44", Offset = "0x9CAD44", VA = "0x9CAD44")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class Message
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x4000467")]
			private const string empty = "";

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x9CAC4C", Offset = "0x9CAC4C", VA = "0x9CAC4C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x9CAD4C", Offset = "0x9CAD4C", VA = "0x9CAD4C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400046E")]
			private const string empty = "";

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x9CAB70", Offset = "0x9CAB70", VA = "0x9CAB70")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x9CAD54", Offset = "0x9CAD54", VA = "0x9CAD54")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x9CAE04", Offset = "0x9CAE04", VA = "0x9CAE04")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x9CAEDC", Offset = "0x9CAEDC", VA = "0x9CAEDC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000088")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000089")]
			public enum Type
			{
				[Token(Token = "0x4000472")]
				PositionWeight,
				[Token(Token = "0x4000473")]
				RotationWeight,
				[Token(Token = "0x4000474")]
				PositionOffsetX,
				[Token(Token = "0x4000475")]
				PositionOffsetY,
				[Token(Token = "0x4000476")]
				PositionOffsetZ,
				[Token(Token = "0x4000477")]
				Pull,
				[Token(Token = "0x4000478")]
				Reach,
				[Token(Token = "0x4000479")]
				RotateBoneWeight,
				[Token(Token = "0x400047A")]
				Push,
				[Token(Token = "0x400047B")]
				PushParent,
				[Token(Token = "0x400047C")]
				PoserWeight,
				[Token(Token = "0x400047D")]
				BendGoalWeight
			}

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x9CA480", Offset = "0x9CA480", VA = "0x9CA480")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x9CAEF0", Offset = "0x9CAEF0", VA = "0x9CAEF0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public class Multiplier
		{
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x9CAA88", Offset = "0x9CAA88", VA = "0x9CAA88")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x9CAEF8", Offset = "0x9CAEF8", VA = "0x9CAEF8")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x17000086")]
		public float length
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x9CA010", Offset = "0x9CA010", VA = "0x9CA010")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x9CA018", Offset = "0x9CA018", VA = "0x9CA018")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x9CA020", Offset = "0x9CA020", VA = "0x9CA020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x9CA028", Offset = "0x9CA028", VA = "0x9CA028")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x9CA1E0", Offset = "0x9CA1E0", VA = "0x9CA1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x9C951C", Offset = "0x9C951C", VA = "0x9C951C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x9C9DF0", Offset = "0x9C9DF0", VA = "0x9C9DF0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x9C9E34", Offset = "0x9C9E34", VA = "0x9C9E34")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x9C9E78", Offset = "0x9C9E78", VA = "0x9C9E78")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x9C9EBC", Offset = "0x9C9EBC", VA = "0x9C9EBC")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x9C9F00", Offset = "0x9C9F00", VA = "0x9C9F00")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x9C9F44", Offset = "0x9C9F44", VA = "0x9C9F44")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x9C9F88", Offset = "0x9C9F88", VA = "0x9C9F88")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x9C9FCC", Offset = "0x9C9FCC", VA = "0x9C9FCC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x9CA030", Offset = "0x9CA030", VA = "0x9CA030")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x9CA260", Offset = "0x9CA260", VA = "0x9CA260")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x9C7A30", Offset = "0x9C7A30", VA = "0x9C7A30")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x9CA3B0", Offset = "0x9CA3B0", VA = "0x9CA3B0")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x9C78F4", Offset = "0x9C78F4", VA = "0x9C78F4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x9C7A28", Offset = "0x9C7A28", VA = "0x9C7A28")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x9C87E4", Offset = "0x9C87E4", VA = "0x9C87E4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x9C90D4", Offset = "0x9C90D4", VA = "0x9C90D4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x9CAAB8", Offset = "0x9CAAB8", VA = "0x9CAAB8")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x9CA49C", Offset = "0x9CA49C", VA = "0x9CA49C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x9CA3B8", Offset = "0x9CA3B8", VA = "0x9CA3B8")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x9CAA2C", Offset = "0x9CAA2C", VA = "0x9CAA2C")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x9CAABC", Offset = "0x9CAABC", VA = "0x9CAABC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x9CAB18", Offset = "0x9CAB18", VA = "0x9CAB18")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200008D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("collider")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[Header("Triggering")]
		public Collider characterCollider;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("camera")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		public Transform FPSCamera;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("Reference to the FBBIK component.")]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x1700008A")]
		public bool inInteraction
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x9CB128", Offset = "0x9CB128", VA = "0x9CB128")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x9CCB88", Offset = "0x9CCB88", VA = "0x9CCB88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x9CCB90", Offset = "0x9CCB90", VA = "0x9CCB90")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x9CCB98", Offset = "0x9CCB98", VA = "0x9CCB98")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x9CCBA0", Offset = "0x9CCBA0", VA = "0x9CCBA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool initiated
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x9CCBA8", Offset = "0x9CCBA8", VA = "0x9CCBA8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x9CCBB0", Offset = "0x9CCBB0", VA = "0x9CCBB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x9CAF08", Offset = "0x9CAF08", VA = "0x9CAF08")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x9CAF4C", Offset = "0x9CAF4C", VA = "0x9CAF4C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x9CAF90", Offset = "0x9CAF90", VA = "0x9CAF90")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x9CAFD4", Offset = "0x9CAFD4", VA = "0x9CAFD4")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x9CB018", Offset = "0x9CB018", VA = "0x9CB018")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x9CB05C", Offset = "0x9CB05C", VA = "0x9CB05C")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x9CB0A0", Offset = "0x9CB0A0", VA = "0x9CB0A0")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x9CB0E4", Offset = "0x9CB0E4", VA = "0x9CB0E4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x9CB2A0", Offset = "0x9CB2A0", VA = "0x9CB2A0")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x9CB358", Offset = "0x9CB358", VA = "0x9CB358")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x9CB410", Offset = "0x9CB410", VA = "0x9CB410")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x9CB4A8", Offset = "0x9CB4A8", VA = "0x9CB4A8")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x9CB58C", Offset = "0x9CB58C", VA = "0x9CB58C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x9CB684", Offset = "0x9CB684", VA = "0x9CB684")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x9CB708", Offset = "0x9CB708", VA = "0x9CB708")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x9CB78C", Offset = "0x9CB78C", VA = "0x9CB78C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x9CB810", Offset = "0x9CB810", VA = "0x9CB810")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x9CB878", Offset = "0x9CB878", VA = "0x9CB878")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x9CB8E0", Offset = "0x9CB8E0", VA = "0x9CB8E0")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x9CB93C", Offset = "0x9CB93C", VA = "0x9CB93C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x9CB9BC", Offset = "0x9CB9BC", VA = "0x9CB9BC")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x9CBA64", Offset = "0x9CBA64", VA = "0x9CBA64")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x9CBB34", Offset = "0x9CBB34", VA = "0x9CBB34")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x9CBDC4", Offset = "0x9CBDC4", VA = "0x9CBDC4")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x9CBF80", Offset = "0x9CBF80", VA = "0x9CBF80")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x9CC1E8", Offset = "0x9CC1E8", VA = "0x9CC1E8")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x9CC474", Offset = "0x9CC474", VA = "0x9CC474")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x9CC4AC", Offset = "0x9CC4AC", VA = "0x9CC4AC")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x9CC50C", Offset = "0x9CC50C", VA = "0x9CC50C")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x9CC614", Offset = "0x9CC614", VA = "0x9CC614")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x9CC7F4", Offset = "0x9CC7F4", VA = "0x9CC7F4")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x9CCA68", Offset = "0x9CCA68", VA = "0x9CCA68")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x9CC2D0", Offset = "0x9CC2D0", VA = "0x9CC2D0")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x9CCBBC", Offset = "0x9CCBBC", VA = "0x9CCBBC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x9CD408", Offset = "0x9CD408", VA = "0x9CD408")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x9CD428", Offset = "0x9CD428", VA = "0x9CD428")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x9CD444", Offset = "0x9CD444", VA = "0x9CD444")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9CD460", Offset = "0x9CD460", VA = "0x9CD460")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x9CD4B4", Offset = "0x9CD4B4", VA = "0x9CD4B4")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x9CD620", Offset = "0x9CD620", VA = "0x9CD620")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x9CD71C", Offset = "0x9CD71C", VA = "0x9CD71C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x9CDA78", Offset = "0x9CDA78", VA = "0x9CDA78")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x9CDB5C", Offset = "0x9CDB5C", VA = "0x9CDB5C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9CDE1C", Offset = "0x9CDE1C", VA = "0x9CDE1C")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x9CD1C0", Offset = "0x9CD1C0", VA = "0x9CD1C0")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x9CDF4C", Offset = "0x9CDF4C", VA = "0x9CDF4C")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x9CE058", Offset = "0x9CE058", VA = "0x9CE058")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x9CE0E0", Offset = "0x9CE0E0", VA = "0x9CE0E0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x9CE1A0", Offset = "0x9CE1A0", VA = "0x9CE1A0")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x9CE1B8", Offset = "0x9CE1B8", VA = "0x9CE1B8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x9CB1C0", Offset = "0x9CB1C0", VA = "0x9CB1C0")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x9CBCB0", Offset = "0x9CBCB0", VA = "0x9CBCB0")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x9CE5A0", Offset = "0x9CE5A0", VA = "0x9CE5A0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200008F")]
		public enum RotationMode
		{
			[Token(Token = "0x40004A6")]
			TwoDOF,
			[Token(Token = "0x40004A7")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class Multiplier
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000540")]
			[Address(RVA = "0x9CEE04", Offset = "0x9CEE04", VA = "0x9CEE04")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		public float threeDOFWeight;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x9CEB70", Offset = "0x9CEB70", VA = "0x9CEB70")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x9CEBB4", Offset = "0x9CEBB4", VA = "0x9CEBB4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x9CEBF8", Offset = "0x9CEBF8", VA = "0x9CEBF8")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x9CEC3C", Offset = "0x9CEC3C", VA = "0x9CEC3C")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x9CEC80", Offset = "0x9CEC80", VA = "0x9CEC80")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x9CECC4", Offset = "0x9CECC4", VA = "0x9CECC4")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x9CED08", Offset = "0x9CED08", VA = "0x9CED08")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x9CED4C", Offset = "0x9CED4C", VA = "0x9CED4C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x9CA41C", Offset = "0x9CA41C", VA = "0x9CA41C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x9C959C", Offset = "0x9C959C", VA = "0x9C959C")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x9C7AC4", Offset = "0x9C7AC4", VA = "0x9C7AC4")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x9CED90", Offset = "0x9CED90", VA = "0x9CED90")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000092")]
		public class CharacterPosition
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x1700008E")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000548")]
				[Address(RVA = "0x9CF068", Offset = "0x9CF068", VA = "0x9CF068")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000549")]
				[Address(RVA = "0x9CF074", Offset = "0x9CF074", VA = "0x9CF074")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x9CF134", Offset = "0x9CF134", VA = "0x9CF134")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x9CF898", Offset = "0x9CF898", VA = "0x9CF898")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class CameraPosition
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x9CF8AC", Offset = "0x9CF8AC", VA = "0x9CF8AC")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x9CFA24", Offset = "0x9CFA24", VA = "0x9CFA24")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x9CFD2C", Offset = "0x9CFD2C", VA = "0x9CFD2C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x2000095")]
			public class Interaction
			{
				[Token(Token = "0x40004BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40004BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000551")]
				[Address(RVA = "0x9CFDB0", Offset = "0x9CFDB0", VA = "0x9CFDB0")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x9CEF60", Offset = "0x9CEF60", VA = "0x9CEF60")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x9CFDA0", Offset = "0x9CFDA0", VA = "0x9CFDA0")]
			public Range()
			{
			}
		}

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x9CEE0C", Offset = "0x9CEE0C", VA = "0x9CEE0C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x9CEE50", Offset = "0x9CEE50", VA = "0x9CEE50")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x9CEE94", Offset = "0x9CEE94", VA = "0x9CEE94")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x9CEED8", Offset = "0x9CEED8", VA = "0x9CEED8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x9CEF1C", Offset = "0x9CEF1C", VA = "0x9CEF1C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x9CD8C4", Offset = "0x9CD8C4", VA = "0x9CD8C4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x9CF010", Offset = "0x9CF010", VA = "0x9CF010")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000097")]
		public class Map
		{
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x9D00A4", Offset = "0x9D00A4", VA = "0x9D00A4")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x9D03E0", Offset = "0x9D03E0", VA = "0x9D03E0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0x9D03A0", Offset = "0x9D03A0", VA = "0x9D03A0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x9D0224", Offset = "0x9D0224", VA = "0x9D0224")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x9CFDB8", Offset = "0x9CFDB8", VA = "0x9CFDB8", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x9D0130", Offset = "0x9D0130", VA = "0x9D0130", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x9D0134", Offset = "0x9D0134", VA = "0x9D0134", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x9D0344", Offset = "0x9D0344", VA = "0x9D0344", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x9D00D4", Offset = "0x9D00D4", VA = "0x9D00D4")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x9D0010", Offset = "0x9D0010", VA = "0x9D0010")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x9D0424", Offset = "0x9D0424", VA = "0x9D0424")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x9D0444", Offset = "0x9D0444", VA = "0x9D0444", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x9D0500", Offset = "0x9D0500", VA = "0x9D0500", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x9D06A4", Offset = "0x9D06A4", VA = "0x9D06A4", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x9D078C", Offset = "0x9D078C", VA = "0x9D078C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x9D0554", Offset = "0x9D0554", VA = "0x9D0554")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x9D0ABC", Offset = "0x9D0ABC", VA = "0x9D0ABC")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000563")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9D0ACC", Offset = "0x9D0ACC", VA = "0x9D0ACC")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000565")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000566")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000567")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x9D0AD8", Offset = "0x9D0AD8", VA = "0x9D0AD8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x9D0B1C", Offset = "0x9D0B1C", VA = "0x9D0B1C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x9D0B48", Offset = "0x9D0B48", VA = "0x9D0B48", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x9D0434", Offset = "0x9D0434", VA = "0x9D0434")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public class Rigidbone
		{
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x9D1A60", Offset = "0x9D1A60", VA = "0x9D1A60")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x9D1BB4", Offset = "0x9D1BB4", VA = "0x9D1BB4")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x9D1C88", Offset = "0x9D1C88", VA = "0x9D1C88")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public class Child
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x9D1EC8", Offset = "0x9D1EC8", VA = "0x9D1EC8")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x9D1F24", Offset = "0x9D1F24", VA = "0x9D1F24")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x9D2034", Offset = "0x9D2034", VA = "0x9D2034")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000092")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0x9D2284", Offset = "0x9D2284", VA = "0x9D2284", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000093")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000589")]
				[Address(RVA = "0x9D22CC", Offset = "0x9D22CC", VA = "0x9D22CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x9D2078", Offset = "0x9D2078", VA = "0x9D2078")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x9D20A0", Offset = "0x9D20A0", VA = "0x9D20A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x9D20A4", Offset = "0x9D20A4", VA = "0x9D20A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x9D228C", Offset = "0x9D228C", VA = "0x9D228C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000090")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x9D0B8C", Offset = "0x9D0B8C", VA = "0x9D0B8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ikUsed
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x9D147C", Offset = "0x9D147C", VA = "0x9D147C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x9D0B60", Offset = "0x9D0B60", VA = "0x9D0B60")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x9D0BF0", Offset = "0x9D0BF0", VA = "0x9D0BF0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x9D0D00", Offset = "0x9D0D00", VA = "0x9D0D00")]
		public void Start()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x9D0C98", Offset = "0x9D0C98", VA = "0x9D0C98")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x9D1114", Offset = "0x9D1114", VA = "0x9D1114")]
		private void Update()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x9D133C", Offset = "0x9D133C", VA = "0x9D133C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x9D13E0", Offset = "0x9D13E0", VA = "0x9D13E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x9D15D0", Offset = "0x9D15D0", VA = "0x9D15D0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x9D1450", Offset = "0x9D1450", VA = "0x9D1450")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x9D159C", Offset = "0x9D159C", VA = "0x9D159C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x9D1654", Offset = "0x9D1654", VA = "0x9D1654")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x9D15F4", Offset = "0x9D15F4", VA = "0x9D15F4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x9D0C38", Offset = "0x9D0C38", VA = "0x9D0C38")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x9D1370", Offset = "0x9D1370", VA = "0x9D1370")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x9D1850", Offset = "0x9D1850", VA = "0x9D1850")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x9D1968", Offset = "0x9D1968", VA = "0x9D1968")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000094")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x9D2738", Offset = "0x9D2738", VA = "0x9D2738")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000095")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x9D2744", Offset = "0x9D2744", VA = "0x9D2744")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000096")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x9D2774", Offset = "0x9D2774", VA = "0x9D2774")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x9D277C", Offset = "0x9D277C", VA = "0x9D277C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x9D22D4", Offset = "0x9D22D4", VA = "0x9D22D4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x9D2310", Offset = "0x9D2310", VA = "0x9D2310")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x9D2328", Offset = "0x9D2328", VA = "0x9D2328")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x9D26A8", Offset = "0x9D26A8", VA = "0x9D26A8")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x9D270C", Offset = "0x9D270C", VA = "0x9D270C")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000593")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x9D25AC", Offset = "0x9D25AC", VA = "0x9D25AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x9D2788", Offset = "0x9D2788", VA = "0x9D2788")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x9D278C", Offset = "0x9D278C", VA = "0x9D278C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x9D27B4", Offset = "0x9D27B4", VA = "0x9D27B4")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x9D2888", Offset = "0x9D2888", VA = "0x9D2888")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x9D2AE0", Offset = "0x9D2AE0", VA = "0x9D2AE0")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x9D2C34", Offset = "0x9D2C34", VA = "0x9D2C34")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x9D2C94", Offset = "0x9D2C94", VA = "0x9D2C94")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x9D2CD8", Offset = "0x9D2CD8", VA = "0x9D2CD8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x9D2D1C", Offset = "0x9D2D1C", VA = "0x9D2D1C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x9D2D60", Offset = "0x9D2D60", VA = "0x9D2D60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x9D2DA4", Offset = "0x9D2DA4", VA = "0x9D2DA4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x9D2DDC", Offset = "0x9D2DDC", VA = "0x9D2DDC")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x9D3100", Offset = "0x9D3100", VA = "0x9D3100")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x9D3110", Offset = "0x9D3110", VA = "0x9D3110")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x9D3154", Offset = "0x9D3154", VA = "0x9D3154")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x9D3198", Offset = "0x9D3198", VA = "0x9D3198")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x9D31DC", Offset = "0x9D31DC", VA = "0x9D31DC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x9D3220", Offset = "0x9D3220", VA = "0x9D3220", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x9D3224", Offset = "0x9D3224", VA = "0x9D3224")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x9D3444", Offset = "0x9D3444", VA = "0x9D3444")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public class ReachCone
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000097")]
			public Vector3 o
			{
				[Token(Token = "0x60005B9")]
				[Address(RVA = "0x9D518C", Offset = "0x9D518C", VA = "0x9D518C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000098")]
			public Vector3 a
			{
				[Token(Token = "0x60005BA")]
				[Address(RVA = "0x9D51B8", Offset = "0x9D51B8", VA = "0x9D51B8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 b
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x9D51E8", Offset = "0x9D51E8", VA = "0x9D51E8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009A")]
			public Vector3 c
			{
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x9D5218", Offset = "0x9D5218", VA = "0x9D5218")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700009B")]
			public bool isValid
			{
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x9D46D4", Offset = "0x9D46D4", VA = "0x9D46D4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x9D4B78", Offset = "0x9D4B78", VA = "0x9D4B78")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x9D4CDC", Offset = "0x9D4CDC", VA = "0x9D4CDC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public class LimitPoint
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x9D46E4", Offset = "0x9D46E4", VA = "0x9D46E4")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x9D345C", Offset = "0x9D345C", VA = "0x9D345C")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x9D34A0", Offset = "0x9D34A0", VA = "0x9D34A0")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x9D34E4", Offset = "0x9D34E4", VA = "0x9D34E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x9D3528", Offset = "0x9D3528", VA = "0x9D3528")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x9D356C", Offset = "0x9D356C", VA = "0x9D356C")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x9D3BA4", Offset = "0x9D3BA4", VA = "0x9D3BA4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x9D3C2C", Offset = "0x9D3C2C", VA = "0x9D3C2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x9D420C", Offset = "0x9D420C", VA = "0x9D420C")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x9D35F8", Offset = "0x9D35F8", VA = "0x9D35F8")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x9D4748", Offset = "0x9D4748", VA = "0x9D4748")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x9D4F50", Offset = "0x9D4F50", VA = "0x9D4F50")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x9D4F98", Offset = "0x9D4F98", VA = "0x9D4F98")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x9D4FF8", Offset = "0x9D4FF8", VA = "0x9D4FF8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x9D3F68", Offset = "0x9D3F68", VA = "0x9D3F68")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x9D5064", Offset = "0x9D5064", VA = "0x9D5064")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x9D5130", Offset = "0x9D5130", VA = "0x9D5130")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x9D5248", Offset = "0x9D5248", VA = "0x9D5248")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x9D528C", Offset = "0x9D528C", VA = "0x9D528C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x9D52D0", Offset = "0x9D52D0", VA = "0x9D52D0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x9D5314", Offset = "0x9D5314", VA = "0x9D5314")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x9D5358", Offset = "0x9D5358", VA = "0x9D5358")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x9D5374", Offset = "0x9D5374", VA = "0x9D5374", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x9D53AC", Offset = "0x9D53AC", VA = "0x9D53AC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x9D5758", Offset = "0x9D5758", VA = "0x9D5758")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005D3")]
				[Address(RVA = "0x9D6738", Offset = "0x9D6738", VA = "0x9D6738", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x9D6780", Offset = "0x9D6780", VA = "0x9D6780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x9D6544", Offset = "0x9D6544", VA = "0x9D6544")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x9D6650", Offset = "0x9D6650", VA = "0x9D6650", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x9D6654", Offset = "0x9D6654", VA = "0x9D6654", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x9D6740", Offset = "0x9D6740", VA = "0x9D6740", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Master weight of the IK solver.")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Target Smoothing")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		public Transform target;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("RootRotation")]
		[Range(0f, 180f)]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		public float maxRootAngle;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		[Header("Mode")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700009C")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x9D57E0", Offset = "0x9D57E0", VA = "0x9D57E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x9D5764", Offset = "0x9D5764", VA = "0x9D5764")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x9D5864", Offset = "0x9D5864", VA = "0x9D5864")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x9D60B4", Offset = "0x9D60B4", VA = "0x9D60B4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x9D6238", Offset = "0x9D6238", VA = "0x9D6238")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x9D64DC", Offset = "0x9D64DC", VA = "0x9D64DC")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x9D656C", Offset = "0x9D656C", VA = "0x9D656C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public class Pose
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x9D6858", Offset = "0x9D6858", VA = "0x9D6858")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x9D6DC8", Offset = "0x9D6DC8", VA = "0x9D6DC8")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x9D6DD0", Offset = "0x9D6DD0", VA = "0x9D6DD0")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x9D6788", Offset = "0x9D6788", VA = "0x9D6788")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x9D6D08", Offset = "0x9D6D08", VA = "0x9D6D08")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x9D6D68", Offset = "0x9D6D68", VA = "0x9D6D68")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000AB")]
			public class EffectorLink
			{
				[Token(Token = "0x400053C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400053D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x9D7294", Offset = "0x9D7294", VA = "0x9D7294")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x9D6F3C", Offset = "0x9D6F3C", VA = "0x9D6F3C")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x9D726C", Offset = "0x9D726C", VA = "0x9D726C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x9D727C", Offset = "0x9D727C", VA = "0x9D727C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x9D6DEC", Offset = "0x9D6DEC", VA = "0x9D6DEC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x9D724C", Offset = "0x9D724C", VA = "0x9D724C")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x9D729C", Offset = "0x9D729C", VA = "0x9D729C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x9D7304", Offset = "0x9D7304", VA = "0x9D7304", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x9D75A4", Offset = "0x9D75A4", VA = "0x9D75A4")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x9D75C0", Offset = "0x9D75C0", VA = "0x9D75C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x9D7690", Offset = "0x9D7690", VA = "0x9D7690")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9D7924", Offset = "0x9D7924", VA = "0x9D7924")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x9D7A30", Offset = "0x9D7A30", VA = "0x9D7A30")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x1700009F")]
		public IK ik
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x9D7A40", Offset = "0x9D7A40", VA = "0x9D7A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x9D7A48", Offset = "0x9D7A48", VA = "0x9D7A48")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x9D7A50", Offset = "0x9D7A50", VA = "0x9D7A50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x9D7BC4", Offset = "0x9D7BC4", VA = "0x9D7BC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x9D7E20", Offset = "0x9D7E20", VA = "0x9D7E20")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x9D7F4C", Offset = "0x9D7F4C", VA = "0x9D7F4C")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9D8100", Offset = "0x9D8100", VA = "0x9D8100")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9D8304", Offset = "0x9D8304", VA = "0x9D8304")]
		public void Update()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x9D8578", Offset = "0x9D8578", VA = "0x9D8578")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x170000A0")]
		public bool poseStored
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x9D7CA0", Offset = "0x9D7CA0", VA = "0x9D7CA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x9D7FC0", Offset = "0x9D7FC0", VA = "0x9D7FC0")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x9D7CC4", Offset = "0x9D7CC4", VA = "0x9D7CC4")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x9D85D0", Offset = "0x9D85D0", VA = "0x9D85D0")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A2")]
			public bool inProgress
			{
				[Token(Token = "0x60005FA")]
				[Address(RVA = "0x9D86F0", Offset = "0x9D86F0", VA = "0x9D86F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A3")]
			protected float crossFader
			{
				[Token(Token = "0x60005FB")]
				[Address(RVA = "0x9D8BF0", Offset = "0x9D8BF0", VA = "0x9D8BF0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FC")]
				[Address(RVA = "0x9D8BF8", Offset = "0x9D8BF8", VA = "0x9D8BF8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A4")]
			protected float timer
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0x9D8C00", Offset = "0x9D8C00", VA = "0x9D8C00")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005FE")]
				[Address(RVA = "0x9D8C08", Offset = "0x9D8C08", VA = "0x9D8C08")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A5")]
			protected Vector3 force
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0x9D8C10", Offset = "0x9D8C10", VA = "0x9D8C10")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000600")]
				[Address(RVA = "0x9D8C1C", Offset = "0x9D8C1C", VA = "0x9D8C1C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A6")]
			protected Vector3 point
			{
				[Token(Token = "0x6000601")]
				[Address(RVA = "0x9D8C28", Offset = "0x9D8C28", VA = "0x9D8C28")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000602")]
				[Address(RVA = "0x9D8C34", Offset = "0x9D8C34", VA = "0x9D8C34")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x9D8AB8", Offset = "0x9D8AB8", VA = "0x9D8AB8")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x9D87C4", Offset = "0x9D87C4", VA = "0x9D87C4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000605")]
			protected abstract float GetLength();

			[Token(Token = "0x6000606")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000607")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x9D8C40", Offset = "0x9D8C40", VA = "0x9D8C40")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B3")]
			public class EffectorLink
			{
				[Token(Token = "0x400055B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400055C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x400055D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400055E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600060D")]
				[Address(RVA = "0x9D8F74", Offset = "0x9D8F74", VA = "0x9D8F74")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600060E")]
				[Address(RVA = "0x9D8DD0", Offset = "0x9D8DD0", VA = "0x9D8DD0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600060F")]
				[Address(RVA = "0x9D9024", Offset = "0x9D9024", VA = "0x9D9024")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x9D8C54", Offset = "0x9D8C54", VA = "0x9D8C54", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600060A")]
			[Address(RVA = "0x9D8D70", Offset = "0x9D8D70", VA = "0x9D8D70", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x9D8DE4", Offset = "0x9D8DE4", VA = "0x9D8DE4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x9D9010", Offset = "0x9D9010", VA = "0x9D9010")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000B5")]
			public class BoneLink
			{
				[Token(Token = "0x4000562")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x4000563")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				[Token(Token = "0x4000564")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000565")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000614")]
				[Address(RVA = "0x9D92E4", Offset = "0x9D92E4", VA = "0x9D92E4")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000615")]
				[Address(RVA = "0x9D9110", Offset = "0x9D9110", VA = "0x9D9110")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000616")]
				[Address(RVA = "0x9D9484", Offset = "0x9D9484", VA = "0x9D9484")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x9D902C", Offset = "0x9D902C", VA = "0x9D902C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x9D90B8", Offset = "0x9D90B8", VA = "0x9D90B8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x9D911C", Offset = "0x9D911C", VA = "0x9D911C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000613")]
			[Address(RVA = "0x9D9470", Offset = "0x9D9470", VA = "0x9D9470")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x170000A1")]
		public bool inProgress
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x9D8654", Offset = "0x9D8654", VA = "0x9D8654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x9D8704", Offset = "0x9D8704", VA = "0x9D8704", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x9D889C", Offset = "0x9D889C", VA = "0x9D889C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x9D8BE0", Offset = "0x9D8BE0", VA = "0x9D8BE0")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public abstract class Offset
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			private float crossFadeTime;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000A7")]
			protected float crossFader
			{
				[Token(Token = "0x600061A")]
				[Address(RVA = "0x9D99F4", Offset = "0x9D99F4", VA = "0x9D99F4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061B")]
				[Address(RVA = "0x9D99FC", Offset = "0x9D99FC", VA = "0x9D99FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A8")]
			protected float timer
			{
				[Token(Token = "0x600061C")]
				[Address(RVA = "0x9D9A04", Offset = "0x9D9A04", VA = "0x9D9A04")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600061D")]
				[Address(RVA = "0x9D9A0C", Offset = "0x9D9A0C", VA = "0x9D9A0C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A9")]
			protected Vector3 force
			{
				[Token(Token = "0x600061E")]
				[Address(RVA = "0x9D9A14", Offset = "0x9D9A14", VA = "0x9D9A14")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600061F")]
				[Address(RVA = "0x9D9A20", Offset = "0x9D9A20", VA = "0x9D9A20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000AA")]
			protected Vector3 point
			{
				[Token(Token = "0x6000620")]
				[Address(RVA = "0x9D9A2C", Offset = "0x9D9A2C", VA = "0x9D9A2C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000621")]
				[Address(RVA = "0x9D9A38", Offset = "0x9D9A38", VA = "0x9D9A38")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000622")]
			[Address(RVA = "0x9D98A4", Offset = "0x9D98A4", VA = "0x9D98A4")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000623")]
			[Address(RVA = "0x9D95A0", Offset = "0x9D95A0", VA = "0x9D95A0")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000624")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000625")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000626")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000627")]
			[Address(RVA = "0x9D9A44", Offset = "0x9D9A44", VA = "0x9D9A44")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B8")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000B9")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000576")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000577")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x4000578")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000579")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600062C")]
				[Address(RVA = "0x9D9E28", Offset = "0x9D9E28", VA = "0x9D9E28")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600062D")]
				[Address(RVA = "0x9D9C4C", Offset = "0x9D9C4C", VA = "0x9D9C4C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600062E")]
				[Address(RVA = "0x9D9EBC", Offset = "0x9D9EBC", VA = "0x9D9EBC")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x9D9A58", Offset = "0x9D9A58", VA = "0x9D9A58", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x9D9BEC", Offset = "0x9D9BEC", VA = "0x9D9BEC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x9D9C60", Offset = "0x9D9C60", VA = "0x9D9C60", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x9D9EA0", Offset = "0x9D9EA0", VA = "0x9D9EA0")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000BB")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x400057D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x400057E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x400057F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000580")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000633")]
				[Address(RVA = "0x9DA27C", Offset = "0x9DA27C", VA = "0x9DA27C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000634")]
				[Address(RVA = "0x9D9FF4", Offset = "0x9D9FF4", VA = "0x9D9FF4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000635")]
				[Address(RVA = "0x9DA398", Offset = "0x9DA398", VA = "0x9DA398")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x9D9EC4", Offset = "0x9D9EC4", VA = "0x9D9EC4", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x9D9F9C", Offset = "0x9D9F9C", VA = "0x9D9F9C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000631")]
			[Address(RVA = "0x9DA000", Offset = "0x9DA000", VA = "0x9DA000", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000632")]
			[Address(RVA = "0x9DA384", Offset = "0x9DA384", VA = "0x9DA384")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x9D94E8", Offset = "0x9D94E8", VA = "0x9D94E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x9D9680", Offset = "0x9D9680", VA = "0x9D9680")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x9D99D4", Offset = "0x9D99D4", VA = "0x9D99D4")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000BE")]
			public class EffectorLink
			{
				[Token(Token = "0x400058E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400058F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600063C")]
				[Address(RVA = "0x9DA960", Offset = "0x9DA960", VA = "0x9DA960")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x9DA468", Offset = "0x9DA468", VA = "0x9DA468")]
			public void Reset()
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x9DA5E8", Offset = "0x9DA5E8", VA = "0x9DA5E8")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x9DA944", Offset = "0x9DA944", VA = "0x9DA944")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x9DA3FC", Offset = "0x9DA3FC", VA = "0x9DA3FC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x9DA544", Offset = "0x9DA544", VA = "0x9DA544", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x9DA934", Offset = "0x9DA934", VA = "0x9DA934")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		[Header("Turning Towards The Target")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x170000AB")]
		private Vector3 pivot
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x9DA9D0", Offset = "0x9DA9D0", VA = "0x9DA9D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9DA968", Offset = "0x9DA968", VA = "0x9DA968")]
		private void Start()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x9DAA54", Offset = "0x9DAA54", VA = "0x9DAA54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x9DAF54", Offset = "0x9DAF54", VA = "0x9DAF54")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x9DB0D8", Offset = "0x9DB0D8", VA = "0x9DB0D8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9DB324", Offset = "0x9DB324", VA = "0x9DB324")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class OffsetLimits
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x9DB520", Offset = "0x9DB520", VA = "0x9DB520")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x9DB790", Offset = "0x9DB790", VA = "0x9DB790")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x9DB800", Offset = "0x9DB800", VA = "0x9DB800")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x9DB848", Offset = "0x9DB848", VA = "0x9DB848")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000AD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x9DB9A4", Offset = "0x9DB9A4", VA = "0x9DB9A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x9DB9EC", Offset = "0x9DB9EC", VA = "0x9DB9EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x9DB424", Offset = "0x9DB424", VA = "0x9DB424")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x9DB850", Offset = "0x9DB850", VA = "0x9DB850", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x9DB854", Offset = "0x9DB854", VA = "0x9DB854", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x9DB9AC", Offset = "0x9DB9AC", VA = "0x9DB9AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x170000AC")]
		protected float deltaTime
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x9D6F1C", Offset = "0x9D6F1C", VA = "0x9D6F1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000644")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x9D72E4", Offset = "0x9D72E4", VA = "0x9D72E4", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x9DB3BC", Offset = "0x9DB3BC", VA = "0x9DB3BC")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x9DB44C", Offset = "0x9DB44C", VA = "0x9DB44C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x9DA88C", Offset = "0x9DA88C", VA = "0x9DA88C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x9DB684", Offset = "0x9DB684", VA = "0x9DB684", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x9D725C", Offset = "0x9D725C", VA = "0x9D725C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x9DBDF8", Offset = "0x9DBDF8", VA = "0x9DBDF8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000661")]
				[Address(RVA = "0x9DBE40", Offset = "0x9DBE40", VA = "0x9DBE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x9DBA9C", Offset = "0x9DBA9C", VA = "0x9DBA9C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x9DBCA4", Offset = "0x9DBCA4", VA = "0x9DBCA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600065E")]
			[Address(RVA = "0x9DBCA8", Offset = "0x9DBCA8", VA = "0x9DBCA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000660")]
			[Address(RVA = "0x9DBE00", Offset = "0x9DBE00", VA = "0x9DBE00", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x170000AF")]
		protected float deltaTime
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x9DB9F4", Offset = "0x9DB9F4", VA = "0x9DB9F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000656")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x9DBA14", Offset = "0x9DBA14", VA = "0x9DBA14", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x9DBA34", Offset = "0x9DBA34", VA = "0x9DBA34")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x9DBAC4", Offset = "0x9DBAC4", VA = "0x9DBAC4")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x9DBB98", Offset = "0x9DBB98", VA = "0x9DBB98", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x9D99E4", Offset = "0x9D99E4", VA = "0x9D99E4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public class EffectorLink
		{
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000665")]
			[Address(RVA = "0x9DBE48", Offset = "0x9DBE48", VA = "0x9DBE48")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000666")]
			[Address(RVA = "0x9DC194", Offset = "0x9DC194", VA = "0x9DC194")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x9D74F0", Offset = "0x9D74F0", VA = "0x9D74F0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x9DC098", Offset = "0x9DC098", VA = "0x9DC098")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x9DC13C", Offset = "0x9DC13C", VA = "0x9DC13C")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C8")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000C9")]
			public class EffectorLink
			{
				[Token(Token = "0x40005CB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40005CC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x600066D")]
				[Address(RVA = "0x9DC7E8", Offset = "0x9DC7E8", VA = "0x9DC7E8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000669")]
			[Address(RVA = "0x9DC20C", Offset = "0x9DC20C", VA = "0x9DC20C")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600066A")]
			[Address(RVA = "0x9DC3AC", Offset = "0x9DC3AC", VA = "0x9DC3AC")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x9DC4B4", Offset = "0x9DC4B4", VA = "0x9DC4B4")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x9DC7D4", Offset = "0x9DC7D4", VA = "0x9DC7D4")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x9DC19C", Offset = "0x9DC19C", VA = "0x9DC19C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x9DC39C", Offset = "0x9DC39C", VA = "0x9DC39C")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000CC")]
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

				[Token(Token = "0x600067D")]
				[Address(RVA = "0x9DDB3C", Offset = "0x9DDB3C", VA = "0x9DDB3C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x9DC98C", Offset = "0x9DC98C", VA = "0x9DC98C")]
			public void Start()
			{
			}

			[Token(Token = "0x600067B")]
			[Address(RVA = "0x9DD4E8", Offset = "0x9DD4E8", VA = "0x9DD4E8")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600067C")]
			[Address(RVA = "0x9DDB28", Offset = "0x9DDB28", VA = "0x9DDB28")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public enum Handedness
		{
			[Token(Token = "0x40005ED")]
			Right,
			[Token(Token = "0x40005EE")]
			Left
		}

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Space(10f)]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x170000B2")]
		public bool isFinished
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x9DC7F0", Offset = "0x9DC7F0", VA = "0x9DC7F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x9DD6EC", Offset = "0x9DD6EC", VA = "0x9DD6EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x9DD728", Offset = "0x9DD728", VA = "0x9DD728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x9DD6B4", Offset = "0x9DD6B4", VA = "0x9DD6B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x9DD6D0", Offset = "0x9DD6D0", VA = "0x9DD6D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x9DC814", Offset = "0x9DC814", VA = "0x9DC814")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x9DC840", Offset = "0x9DC840", VA = "0x9DC840")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x9DCA60", Offset = "0x9DCA60", VA = "0x9DCA60", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x9DD764", Offset = "0x9DD764", VA = "0x9DD764")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x9DD87C", Offset = "0x9DD87C", VA = "0x9DD87C")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x9DD8CC", Offset = "0x9DD8CC", VA = "0x9DD8CC", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x9DDA9C", Offset = "0x9DDA9C", VA = "0x9DDA9C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x9DDB44", Offset = "0x9DDB44", VA = "0x9DDB44")]
		private void Start()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x9DDC34", Offset = "0x9DDC34", VA = "0x9DDC34")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x9DDD10", Offset = "0x9DDD10", VA = "0x9DDD10")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x9DE114", Offset = "0x9DE114", VA = "0x9DE114")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x9DE148", Offset = "0x9DE148", VA = "0x9DE148")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x9DE254", Offset = "0x9DE254", VA = "0x9DE254")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Settings
		{
			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(-180f, 180f)]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			public float footHeadingOffset;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x9E2084", Offset = "0x9E2084", VA = "0x9E2084")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D1")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000D2")]
			public class Target
			{
				[Token(Token = "0x400060D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x400060E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400060F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000695")]
				[Address(RVA = "0x9DFE7C", Offset = "0x9DFE7C", VA = "0x9DFE7C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000696")]
				[Address(RVA = "0x9E082C", Offset = "0x9E082C", VA = "0x9E082C")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x9DF5FC", Offset = "0x9DF5FC", VA = "0x9DF5FC")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x9DE268", Offset = "0x9DE268", VA = "0x9DE268")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x9DE280", Offset = "0x9DE280", VA = "0x9DE280")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x9DE3A8", Offset = "0x9DE3A8", VA = "0x9DE3A8")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x9DE2C8", Offset = "0x9DE2C8", VA = "0x9DE2C8")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x9DE3C0", Offset = "0x9DE3C0", VA = "0x9DE3C0")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x9DF604", Offset = "0x9DF604", VA = "0x9DF604")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x9DFF30", Offset = "0x9DFF30", VA = "0x9DFF30")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x9E0888", Offset = "0x9E0888", VA = "0x9E0888")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x9E0C48", Offset = "0x9E0C48", VA = "0x9E0C48")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x9E0E58", Offset = "0x9E0E58", VA = "0x9E0E58")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x9E1618", Offset = "0x9E1618", VA = "0x9E1618")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x9E13E0", Offset = "0x9E13E0", VA = "0x9E13E0")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x9E18C0", Offset = "0x9E18C0", VA = "0x9E18C0")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x9E1C58", Offset = "0x9E1C58", VA = "0x9E1C58")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x9E1D3C", Offset = "0x9E1D3C", VA = "0x9E1D3C")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000D3")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x9E2218", Offset = "0x9E2218", VA = "0x9E2218")]
		private void Start()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x9E2268", Offset = "0x9E2268", VA = "0x9E2268")]
		private void Update()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x9E2290", Offset = "0x9E2290", VA = "0x9E2290")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x9E23B0", Offset = "0x9E23B0", VA = "0x9E23B0")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x170000B7")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x9E23C8", Offset = "0x9E23C8", VA = "0x9E23C8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x9E23D4", Offset = "0x9E23D4", VA = "0x9E23D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x9E23E0", Offset = "0x9E23E0", VA = "0x9E23E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x9DFCBC", Offset = "0x9DFCBC", VA = "0x9DFCBC")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x9E0AF0", Offset = "0x9E0AF0", VA = "0x9E0AF0")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x9E24D4", Offset = "0x9E24D4", VA = "0x9E24D4")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x9E289C", Offset = "0x9E289C", VA = "0x9E289C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x9E29A8", Offset = "0x9E29A8", VA = "0x9E29A8")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000D5")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Offset
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x9E2A64", Offset = "0x9E2A64", VA = "0x9E2A64")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x9E2CCC", Offset = "0x9E2CCC", VA = "0x9E2CCC")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x9E29B0", Offset = "0x9E29B0", VA = "0x9E29B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x9E2A00", Offset = "0x9E2A00", VA = "0x9E2A00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x9E2C0C", Offset = "0x9E2C0C", VA = "0x9E2C0C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x9E2CC4", Offset = "0x9E2CC4", VA = "0x9E2CC4")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x9E2CD4", Offset = "0x9E2CD4", VA = "0x9E2CD4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x9E2D54", Offset = "0x9E2D54", VA = "0x9E2D54")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x9E2D5C", Offset = "0x9E2D5C", VA = "0x9E2D5C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x9E2DC8", Offset = "0x9E2DC8", VA = "0x9E2DC8")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x9E2E28", Offset = "0x9E2E28", VA = "0x9E2E28")]
		private void Start()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x9E2E60", Offset = "0x9E2E60", VA = "0x9E2E60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x9E311C", Offset = "0x9E311C", VA = "0x9E311C")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x9E3124", Offset = "0x9E3124", VA = "0x9E3124")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x9E315C", Offset = "0x9E315C", VA = "0x9E315C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x9E32A8", Offset = "0x9E32A8", VA = "0x9E32A8")]
		private void Pose()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x9E3410", Offset = "0x9E3410", VA = "0x9E3410")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x9E35F4", Offset = "0x9E35F4", VA = "0x9E35F4")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x9E3684", Offset = "0x9E3684", VA = "0x9E3684")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9E3698", Offset = "0x9E3698", VA = "0x9E3698")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x9E3804", Offset = "0x9E3804", VA = "0x9E3804")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x9E3A00", Offset = "0x9E3A00", VA = "0x9E3A00")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x9E3A30", Offset = "0x9E3A30", VA = "0x9E3A30")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x9E3E5C", Offset = "0x9E3E5C", VA = "0x9E3E5C")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x170000B8")]
		public Vector3 velocity
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x9E3E7C", Offset = "0x9E3E7C", VA = "0x9E3E7C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x9E3E88", Offset = "0x9E3E88", VA = "0x9E3E88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x9E3E94", Offset = "0x9E3E94", VA = "0x9E3E94")]
		private void Start()
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x9E3EC4", Offset = "0x9E3EC4", VA = "0x9E3EC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x9E4848", Offset = "0x9E4848", VA = "0x9E4848")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x9E45C4", Offset = "0x9E45C4", VA = "0x9E45C4")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x9E4958", Offset = "0x9E4958", VA = "0x9E4958")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x170000B9")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x9E4984", Offset = "0x9E4984", VA = "0x9E4984")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x9E4A04", Offset = "0x9E4A04", VA = "0x9E4A04")]
		private void Update()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x9E4D48", Offset = "0x9E4D48", VA = "0x9E4D48")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170000BC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x9E5D50", Offset = "0x9E5D50", VA = "0x9E5D50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x9E5D98", Offset = "0x9E5D98", VA = "0x9E5D98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x9E59F4", Offset = "0x9E59F4", VA = "0x9E59F4")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x9E5AAC", Offset = "0x9E5AAC", VA = "0x9E5AAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x9E5AB0", Offset = "0x9E5AB0", VA = "0x9E5AB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x9E5D58", Offset = "0x9E5D58", VA = "0x9E5D58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170000BA")]
		public bool isStepping
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x9E4D5C", Offset = "0x9E4D5C", VA = "0x9E4D5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		public Vector3 position
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x9E4928", Offset = "0x9E4928", VA = "0x9E4928")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x9E4D70", Offset = "0x9E4D70", VA = "0x9E4D70")]
			set
			{
			}
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x9E4DBC", Offset = "0x9E4DBC", VA = "0x9E4DBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x9E5004", Offset = "0x9E5004", VA = "0x9E5004")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x9E51DC", Offset = "0x9E51DC", VA = "0x9E51DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x9E53F4", Offset = "0x9E53F4", VA = "0x9E53F4")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x9E5654", Offset = "0x9E5654", VA = "0x9E5654")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x9E57BC", Offset = "0x9E57BC", VA = "0x9E57BC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x9E5350", Offset = "0x9E5350", VA = "0x9E5350")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x9E5A1C", Offset = "0x9E5A1C", VA = "0x9E5A1C")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x9E5DA0", Offset = "0x9E5DA0", VA = "0x9E5DA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x9E5E6C", Offset = "0x9E5E6C", VA = "0x9E5E6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x9E60E0", Offset = "0x9E60E0", VA = "0x9E60E0")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public struct Warp
		{
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum EffectorMode
		{
			[Token(Token = "0x400068C")]
			PositionOffset,
			[Token(Token = "0x400068D")]
			Position
		}

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x9E60E8", Offset = "0x9E60E8", VA = "0x9E60E8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x9E6108", Offset = "0x9E6108", VA = "0x9E6108")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x9E6320", Offset = "0x9E6320", VA = "0x9E6320", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x9E65D8", Offset = "0x9E65D8", VA = "0x9E65D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x9E666C", Offset = "0x9E666C", VA = "0x9E666C")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x9E6674", Offset = "0x9E6674", VA = "0x9E6674", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x9E66C4", Offset = "0x9E66C4", VA = "0x9E66C4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x9E68CC", Offset = "0x9E68CC", VA = "0x9E68CC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x9E6AF4", Offset = "0x9E6AF4", VA = "0x9E6AF4")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x9E6B08", Offset = "0x9E6B08", VA = "0x9E6B08", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x9E6C9C", Offset = "0x9E6C9C", VA = "0x9E6C9C", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x9E6D0C", Offset = "0x9E6D0C", VA = "0x9E6D0C")]
		private void Read()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x9E6E44", Offset = "0x9E6E44", VA = "0x9E6E44")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x9E6EA0", Offset = "0x9E6EA0", VA = "0x9E6EA0")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x9E74E8", Offset = "0x9E74E8", VA = "0x9E74E8")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x9E72FC", Offset = "0x9E72FC", VA = "0x9E72FC")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x9E778C", Offset = "0x9E778C", VA = "0x9E778C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x9E7898", Offset = "0x9E7898", VA = "0x9E7898")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x9E78B4", Offset = "0x9E78B4", VA = "0x9E78B4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x9E7988", Offset = "0x9E7988", VA = "0x9E7988", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x9E7CDC", Offset = "0x9E7CDC", VA = "0x9E7CDC")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x9E7DCC", Offset = "0x9E7DCC", VA = "0x9E7DCC")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x170000BE")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x9E806C", Offset = "0x9E806C", VA = "0x9E806C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000BF")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x9E80EC", Offset = "0x9E80EC", VA = "0x9E80EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x9E7E14", Offset = "0x9E7E14", VA = "0x9E7E14")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x9E7E7C", Offset = "0x9E7E7C", VA = "0x9E7E7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x9E816C", Offset = "0x9E816C", VA = "0x9E816C")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x9E8174", Offset = "0x9E8174", VA = "0x9E8174", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x9E85D0", Offset = "0x9E85D0", VA = "0x9E85D0")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x9E85D8", Offset = "0x9E85D8", VA = "0x9E85D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x9E867C", Offset = "0x9E867C", VA = "0x9E867C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x9E8AD8", Offset = "0x9E8AD8", VA = "0x9E8AD8")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x9E8B78", Offset = "0x9E8B78", VA = "0x9E8B78")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EC")]
		public class Limb
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x9E8D0C", Offset = "0x9E8D0C", VA = "0x9E8D0C")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x9E8E30", Offset = "0x9E8E30", VA = "0x9E8E30")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x9E8BE8", Offset = "0x9E8BE8", VA = "0x9E8BE8")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x9E8D84", Offset = "0x9E8D84", VA = "0x9E8D84")]
		private void Start()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x9E8E1C", Offset = "0x9E8E1C", VA = "0x9E8E1C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x9E8E20", Offset = "0x9E8E20", VA = "0x9E8E20")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x9E8E40", Offset = "0x9E8E40", VA = "0x9E8E40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x9E8EA8", Offset = "0x9E8EA8", VA = "0x9E8EA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x9E8F70", Offset = "0x9E8F70", VA = "0x9E8F70")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x9E8F78", Offset = "0x9E8F78", VA = "0x9E8F78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x9E8FC8", Offset = "0x9E8FC8", VA = "0x9E8FC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x9E9160", Offset = "0x9E9160", VA = "0x9E9160")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x9E9168", Offset = "0x9E9168", VA = "0x9E9168")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x9E9238", Offset = "0x9E9238", VA = "0x9E9238")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x9E92C4", Offset = "0x9E92C4", VA = "0x9E92C4")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x9E9798", Offset = "0x9E9798", VA = "0x9E9798")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x9E98A4", Offset = "0x9E98A4", VA = "0x9E98A4")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x9E98AC", Offset = "0x9E98AC", VA = "0x9E98AC")]
		private void Start()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x9E9A48", Offset = "0x9E9A48", VA = "0x9E9A48")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x9E9A54", Offset = "0x9E9A54", VA = "0x9E9A54")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x9E9D14", Offset = "0x9E9D14", VA = "0x9E9D14")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x9E9FB8", Offset = "0x9E9FB8", VA = "0x9E9FB8")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x9E9B18", Offset = "0x9E9B18", VA = "0x9E9B18")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x9EAC70", Offset = "0x9EAC70", VA = "0x9EAC70")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x9EAC90", Offset = "0x9EAC90", VA = "0x9EAC90")]
		private void Start()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x9EAD0C", Offset = "0x9EAD0C", VA = "0x9EAD0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x9EAE08", Offset = "0x9EAE08", VA = "0x9EAE08")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x9EAEB4", Offset = "0x9EAEB4", VA = "0x9EAEB4")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x9EAEC4", Offset = "0x9EAEC4", VA = "0x9EAEC4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x9EB008", Offset = "0x9EB008", VA = "0x9EB008")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x9EB16C", Offset = "0x9EB16C", VA = "0x9EB16C")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x9EB17C", Offset = "0x9EB17C", VA = "0x9EB17C")]
		private void Start()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x9EB348", Offset = "0x9EB348", VA = "0x9EB348")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x9EB758", Offset = "0x9EB758", VA = "0x9EB758")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x9EB768", Offset = "0x9EB768", VA = "0x9EB768")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x9EB850", Offset = "0x9EB850", VA = "0x9EB850")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x9EB93C", Offset = "0x9EB93C", VA = "0x9EB93C")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x9EB944", Offset = "0x9EB944", VA = "0x9EB944")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x9EBE44", Offset = "0x9EBE44", VA = "0x9EBE44")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x9EBE4C", Offset = "0x9EBE4C", VA = "0x9EBE4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x9EBE9C", Offset = "0x9EBE9C", VA = "0x9EBE9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x9EC148", Offset = "0x9EC148", VA = "0x9EC148")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Partner
		{
			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x170000C0")]
			private Transform neck
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0x9EC954", Offset = "0x9EC954", VA = "0x9EC954")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x9EC178", Offset = "0x9EC178", VA = "0x9EC178")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x9EC1F4", Offset = "0x9EC1F4", VA = "0x9EC1F4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x9EC7EC", Offset = "0x9EC7EC", VA = "0x9EC7EC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x9EC9A0", Offset = "0x9EC9A0", VA = "0x9EC9A0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x9EC150", Offset = "0x9EC150", VA = "0x9EC150")]
		private void Start()
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x9EC198", Offset = "0x9EC198", VA = "0x9EC198")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x9EC7DC", Offset = "0x9EC7DC", VA = "0x9EC7DC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public enum Mode
		{
			[Token(Token = "0x4000719")]
			Position,
			[Token(Token = "0x400071A")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x20000FB")]
		public class Absorber
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x9ECB18", Offset = "0x9ECB18", VA = "0x9ECB18")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x9ECCEC", Offset = "0x9ECCEC", VA = "0x9ECCEC")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000734")]
			[Address(RVA = "0x9ECD10", Offset = "0x9ECD10", VA = "0x9ECD10")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000735")]
			[Address(RVA = "0x9ECE20", Offset = "0x9ECE20", VA = "0x9ECE20")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000736")]
			[Address(RVA = "0x9ECFB8", Offset = "0x9ECFB8", VA = "0x9ECFB8")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x9EC9B4", Offset = "0x9EC9B4", VA = "0x9EC9B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x9ECA98", Offset = "0x9ECA98", VA = "0x9ECA98")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x9ECBE0", Offset = "0x9ECBE0", VA = "0x9ECBE0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x9ECDA4", Offset = "0x9ECDA4", VA = "0x9ECDA4")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9ECE90", Offset = "0x9ECE90", VA = "0x9ECE90", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x9ECFA8", Offset = "0x9ECFA8", VA = "0x9ECFA8")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x9ED018", Offset = "0x9ED018", VA = "0x9ED018")]
		private void Start()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x9ED088", Offset = "0x9ED088", VA = "0x9ED088")]
		private void Update()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x9ED158", Offset = "0x9ED158", VA = "0x9ED158")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x9ED2A0", Offset = "0x9ED2A0", VA = "0x9ED2A0")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FE")]
		public class EffectorLink
		{
			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600073E")]
			[Address(RVA = "0x9ED520", Offset = "0x9ED520", VA = "0x9ED520")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x9ED2B4", Offset = "0x9ED2B4", VA = "0x9ED2B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x9ED3A0", Offset = "0x9ED3A0", VA = "0x9ED3A0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x9ED518", Offset = "0x9ED518", VA = "0x9ED518")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x9ED530", Offset = "0x9ED530", VA = "0x9ED530")]
		private void Start()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x9ED830", Offset = "0x9ED830", VA = "0x9ED830")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x9EE02C", Offset = "0x9EE02C", VA = "0x9EE02C")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x170000C1")]
		private bool holding
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x9EE424", Offset = "0x9EE424", VA = "0x9EE424")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C2")]
		private bool holdingLeft
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x9EE4F4", Offset = "0x9EE4F4", VA = "0x9EE4F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool holdingRight
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x9EE44C", Offset = "0x9EE44C", VA = "0x9EE44C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x9EE098", Offset = "0x9EE098", VA = "0x9EE098")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000743")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x9EE59C", Offset = "0x9EE59C", VA = "0x9EE59C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x9EE75C", Offset = "0x9EE75C", VA = "0x9EE75C")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x9EE8CC", Offset = "0x9EE8CC", VA = "0x9EE8CC")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x9EE99C", Offset = "0x9EE99C", VA = "0x9EE99C")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x9EEAC8", Offset = "0x9EEAC8", VA = "0x9EEAC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x9EEC48", Offset = "0x9EEC48", VA = "0x9EEC48")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x9EEE44", Offset = "0x9EEE44", VA = "0x9EEE44")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x9EEE58", Offset = "0x9EEE58", VA = "0x9EEE58", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x9EF038", Offset = "0x9EF038", VA = "0x9EF038")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x9EF04C", Offset = "0x9EF04C", VA = "0x9EF04C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x9EF160", Offset = "0x9EF160", VA = "0x9EF160")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x9EF174", Offset = "0x9EF174", VA = "0x9EF174")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x9EF20C", Offset = "0x9EF20C", VA = "0x9EF20C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x9EF324", Offset = "0x9EF324", VA = "0x9EF324")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x9EF32C", Offset = "0x9EF32C", VA = "0x9EF32C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x9EF37C", Offset = "0x9EF37C", VA = "0x9EF37C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x9EF3C8", Offset = "0x9EF3C8", VA = "0x9EF3C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x9EF460", Offset = "0x9EF460", VA = "0x9EF460")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000106")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000760")]
				[Address(RVA = "0x9EF7A0", Offset = "0x9EF7A0", VA = "0x9EF7A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000762")]
				[Address(RVA = "0x9EF7E8", Offset = "0x9EF7E8", VA = "0x9EF7E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x9EF5D4", Offset = "0x9EF5D4", VA = "0x9EF5D4")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x9EF60C", Offset = "0x9EF60C", VA = "0x9EF60C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x9EF610", Offset = "0x9EF610", VA = "0x9EF610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x9EF7A8", Offset = "0x9EF7A8", VA = "0x9EF7A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x9EF470", Offset = "0x9EF470", VA = "0x9EF470")]
		private void Start()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x9EF520", Offset = "0x9EF520", VA = "0x9EF520")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x9EF55C", Offset = "0x9EF55C", VA = "0x9EF55C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x9EF5FC", Offset = "0x9EF5FC", VA = "0x9EF5FC")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x170000C6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000769")]
				[Address(RVA = "0x9EFA5C", Offset = "0x9EFA5C", VA = "0x9EFA5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076B")]
				[Address(RVA = "0x9EFAA4", Offset = "0x9EFAA4", VA = "0x9EFAA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x9EF900", Offset = "0x9EF900", VA = "0x9EF900")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x9EF930", Offset = "0x9EF930", VA = "0x9EF930", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x9EF934", Offset = "0x9EF934", VA = "0x9EF934", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x9EFA64", Offset = "0x9EFA64", VA = "0x9EFA64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x9EF7F0", Offset = "0x9EF7F0", VA = "0x9EF7F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x9EF898", Offset = "0x9EF898", VA = "0x9EF898")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x9EF928", Offset = "0x9EF928", VA = "0x9EF928")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class EffectorLink
		{
			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x9EFB10", Offset = "0x9EFB10", VA = "0x9EFB10")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x9F064C", Offset = "0x9F064C", VA = "0x9F064C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x9EFED4", Offset = "0x9EFED4", VA = "0x9EFED4")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x9F0734", Offset = "0x9F0734", VA = "0x9F0734")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x9F0818", Offset = "0x9F0818", VA = "0x9F0818")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x9F08A4", Offset = "0x9F08A4", VA = "0x9F08A4")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x9F092C", Offset = "0x9F092C", VA = "0x9F092C")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x9F048C", Offset = "0x9F048C", VA = "0x9F048C")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x9F09B4", Offset = "0x9F09B4", VA = "0x9F09B4")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x9EFAAC", Offset = "0x9EFAAC", VA = "0x9EFAAC")]
		private void Start()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x9EFE74", Offset = "0x9EFE74", VA = "0x9EFE74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x9F03DC", Offset = "0x9F03DC", VA = "0x9F03DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x9F0644", Offset = "0x9F0644", VA = "0x9F0644")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x9F09F0", Offset = "0x9F09F0", VA = "0x9F09F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x9F0A20", Offset = "0x9F0A20", VA = "0x9F0A20")]
		private void Update()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x9F0AD0", Offset = "0x9F0AD0", VA = "0x9F0AD0")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x9F0AE4", Offset = "0x9F0AE4", VA = "0x9F0AE4")]
		private void Start()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x9F0CC8", Offset = "0x9F0CC8", VA = "0x9F0CC8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x9F0F64", Offset = "0x9F0F64", VA = "0x9F0F64")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x9F102C", Offset = "0x9F102C", VA = "0x9F102C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x9F1138", Offset = "0x9F1138", VA = "0x9F1138")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x9F1140", Offset = "0x9F1140", VA = "0x9F1140", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x9F1258", Offset = "0x9F1258", VA = "0x9F1258")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x9F1420", Offset = "0x9F1420", VA = "0x9F1420")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x9F143C", Offset = "0x9F143C", VA = "0x9F143C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x9F1644", Offset = "0x9F1644", VA = "0x9F1644")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x9F16B0", Offset = "0x9F16B0", VA = "0x9F16B0")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x2000110")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x170000C8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000790")]
				[Address(RVA = "0x9F1DFC", Offset = "0x9F1DFC", VA = "0x9F1DFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000792")]
				[Address(RVA = "0x9F1E44", Offset = "0x9F1E44", VA = "0x9F1E44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x9F1A90", Offset = "0x9F1A90", VA = "0x9F1A90")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x9F1C80", Offset = "0x9F1C80", VA = "0x9F1C80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x9F1C84", Offset = "0x9F1C84", VA = "0x9F1C84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x9F1E04", Offset = "0x9F1E04", VA = "0x9F1E04", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x9F16B8", Offset = "0x9F16B8", VA = "0x9F16B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x9F17DC", Offset = "0x9F17DC", VA = "0x9F17DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x9F1774", Offset = "0x9F1774", VA = "0x9F1774")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x9F1AB8", Offset = "0x9F1AB8", VA = "0x9F1AB8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x9F1B90", Offset = "0x9F1B90", VA = "0x9F1B90")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x9F1C64", Offset = "0x9F1C64", VA = "0x9F1C64")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x9F1E4C", Offset = "0x9F1E4C", VA = "0x9F1E4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x9F1EB4", Offset = "0x9F1EB4", VA = "0x9F1EB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x9F1F60", Offset = "0x9F1F60", VA = "0x9F1F60")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class Part
		{
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x9F1FD4", Offset = "0x9F1FD4", VA = "0x9F1FD4")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x9F20F4", Offset = "0x9F20F4", VA = "0x9F20F4")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x9F1F70", Offset = "0x9F1F70", VA = "0x9F1F70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x9F20EC", Offset = "0x9F20EC", VA = "0x9F20EC")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x9F20FC", Offset = "0x9F20FC", VA = "0x9F20FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x9F2240", Offset = "0x9F2240", VA = "0x9F2240")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x9F23A4", Offset = "0x9F23A4", VA = "0x9F23A4")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Head")]
		[Tooltip("HMD.")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Hands")]
		[Tooltip("Left Hand Controller")]
		public Transform leftHandAnchor;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Scale")]
		[Tooltip("Multiplies the scale of the root.")]
		public float scaleMlp;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x9F23B4", Offset = "0x9F23B4", VA = "0x9F23B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x9F253C", Offset = "0x9F253C", VA = "0x9F253C")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x9F25AC", Offset = "0x9F25AC", VA = "0x9F25AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x9F2704", Offset = "0x9F2704", VA = "0x9F2704")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x9F276C", Offset = "0x9F276C", VA = "0x9F276C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x9F27BC", Offset = "0x9F27BC", VA = "0x9F27BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x9F2994", Offset = "0x9F2994", VA = "0x9F2994")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x9F29EC", Offset = "0x9F29EC", VA = "0x9F29EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x9F2F0C", Offset = "0x9F2F0C", VA = "0x9F2F0C")]
		public VRIKPlatformController()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x170000CA")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x9F2F88", Offset = "0x9F2F88", VA = "0x9F2F88", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x9F2F68", Offset = "0x9F2F68", VA = "0x9F2F68", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x9F2F90", Offset = "0x9F2F90", VA = "0x9F2F90")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x9F2FF0", Offset = "0x9F2FF0", VA = "0x9F2FF0", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x9E7CCC", Offset = "0x9E7CCC", VA = "0x9E7CCC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x9F33E0", Offset = "0x9F33E0", VA = "0x9F33E0", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x9F3174", Offset = "0x9F3174", VA = "0x9F3174")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x9F33F0", Offset = "0x9F33F0", VA = "0x9F33F0")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x9F3408", Offset = "0x9F3408", VA = "0x9F3408", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x9F3460", Offset = "0x9F3460", VA = "0x9F3460", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x9F34F0", Offset = "0x9F34F0", VA = "0x9F34F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x9F3614", Offset = "0x9F3614", VA = "0x9F3614")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		[Range(0.1f, 3f)]
		private float animSpeedMultiplier;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x40007C5")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x40007C6")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x170000CB")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x9F3648", Offset = "0x9F3648", VA = "0x9F3648", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x9E790C", Offset = "0x9E790C", VA = "0x9E790C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x9F362C", Offset = "0x9F362C", VA = "0x9F362C", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x9F373C", Offset = "0x9F373C", VA = "0x9F373C", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x9F3B2C", Offset = "0x9F3B2C", VA = "0x9F3B2C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x9E7DF0", Offset = "0x9E7DF0", VA = "0x9E7DF0")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x40007D4")]
		protected const float half = 0.5f;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60007B8")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x9F3C54", Offset = "0x9F3C54", VA = "0x9F3C54")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x9F3E40", Offset = "0x9F3E40", VA = "0x9F3E40", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x9F3FF0", Offset = "0x9F3FF0", VA = "0x9F3FF0", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x9F4190", Offset = "0x9F4190", VA = "0x9F4190")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x9F41F0", Offset = "0x9F41F0", VA = "0x9F41F0")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x9F4354", Offset = "0x9F4354", VA = "0x9F4354")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x9F4558", Offset = "0x9F4558", VA = "0x9F4558")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9F457C", Offset = "0x9F457C", VA = "0x9F457C")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x9F45A0", Offset = "0x9F45A0", VA = "0x9F45A0")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x9F46EC", Offset = "0x9F46EC", VA = "0x9F46EC")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		public enum MoveMode
		{
			[Token(Token = "0x4000812")]
			Directional,
			[Token(Token = "0x4000813")]
			Strafe
		}

		[Token(Token = "0x200011F")]
		public struct AnimState
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000120")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x170000CD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D8")]
				[Address(RVA = "0x9F714C", Offset = "0x9F714C", VA = "0x9F714C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x9F7194", Offset = "0x9F7194", VA = "0x9F7194", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x9F702C", Offset = "0x9F702C", VA = "0x9F702C")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x9F7054", Offset = "0x9F7054", VA = "0x9F7054", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x9F7058", Offset = "0x9F7058", VA = "0x9F7058", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x9F7154", Offset = "0x9F7154", VA = "0x9F7154", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x170000CC")]
		public bool onGround
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x9F470C", Offset = "0x9F470C", VA = "0x9F470C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x9F4714", Offset = "0x9F4714", VA = "0x9F4714")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x9F4720", Offset = "0x9F4720", VA = "0x9F4720", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x9F48F0", Offset = "0x9F48F0", VA = "0x9F48F0")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x9F4974", Offset = "0x9F4974", VA = "0x9F4974", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x9F4A88", Offset = "0x9F4A88", VA = "0x9F4A88")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x9F5AB0", Offset = "0x9F5AB0", VA = "0x9F5AB0", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x9F5F40", Offset = "0x9F5F40", VA = "0x9F5F40", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x9F513C", Offset = "0x9F513C", VA = "0x9F513C")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x9F6018", Offset = "0x9F6018", VA = "0x9F6018")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x9F66A0", Offset = "0x9F66A0", VA = "0x9F66A0")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x9F5B3C", Offset = "0x9F5B3C", VA = "0x9F5B3C")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x9F6790", Offset = "0x9F6790", VA = "0x9F6790", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x9F6C10", Offset = "0x9F6C10", VA = "0x9F6C10")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x9F6D38", Offset = "0x9F6D38", VA = "0x9F6D38", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x9F6E8C", Offset = "0x9F6E8C", VA = "0x9F6E8C")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x9F5550", Offset = "0x9F5550", VA = "0x9F5550")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x9F6F18", Offset = "0x9F6F18", VA = "0x9F6F18")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000122")]
		public enum RotationMode
		{
			[Token(Token = "0x400082F")]
			Smooth,
			[Token(Token = "0x4000830")]
			Linear
		}

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x170000CF")]
		public bool isGrounded
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x9F719C", Offset = "0x9F719C", VA = "0x9F719C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x9F71A4", Offset = "0x9F71A4", VA = "0x9F71A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x9F71B0", Offset = "0x9F71B0", VA = "0x9F71B0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x9F7244", Offset = "0x9F7244", VA = "0x9F7244")]
		private void Update()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x9F785C", Offset = "0x9F785C", VA = "0x9F785C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x9F728C", Offset = "0x9F728C", VA = "0x9F728C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x9F75F4", Offset = "0x9F75F4", VA = "0x9F75F4")]
		private void Move()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x9F788C", Offset = "0x9F788C", VA = "0x9F788C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x9F7924", Offset = "0x9F7924", VA = "0x9F7924")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x9F79A4", Offset = "0x9F79A4", VA = "0x9F79A4")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x9F79CC", Offset = "0x9F79CC", VA = "0x9F79CC", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x9F7AE8", Offset = "0x9F7AE8", VA = "0x9F7AE8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x9F814C", Offset = "0x9F814C", VA = "0x9F814C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x9F8338", Offset = "0x9F8338", VA = "0x9F8338")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000125")]
		public struct State
		{
			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x9F7A08", Offset = "0x9F7A08", VA = "0x9F7A08", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x9F8364", Offset = "0x9F8364", VA = "0x9F8364", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x9F8354", Offset = "0x9F8354", VA = "0x9F8354")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x9F86A8", Offset = "0x9F86A8", VA = "0x9F86A8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x9F86E0", Offset = "0x9F86E0", VA = "0x9F86E0")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x9F86E8", Offset = "0x9F86E8", VA = "0x9F86E8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x9F8710", Offset = "0x9F8710", VA = "0x9F8710")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x9F87B4", Offset = "0x9F87B4", VA = "0x9F87B4")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000128")]
	public class Navigator
	{
		[Token(Token = "0x2000129")]
		public enum State
		{
			[Token(Token = "0x4000852")]
			Idle,
			[Token(Token = "0x4000853")]
			Seeking,
			[Token(Token = "0x4000854")]
			OnPath
		}

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x170000D0")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x9F87C8", Offset = "0x9F87C8", VA = "0x9F87C8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x9F87D4", Offset = "0x9F87D4", VA = "0x9F87D4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public State state
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x9F87E0", Offset = "0x9F87E0", VA = "0x9F87E0")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x9F87E8", Offset = "0x9F87E8", VA = "0x9F87E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x9F7A34", Offset = "0x9F7A34", VA = "0x9F7A34")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x9F7D08", Offset = "0x9F7D08", VA = "0x9F7D08")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x9F88C8", Offset = "0x9F88C8", VA = "0x9F88C8")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x9F892C", Offset = "0x9F892C", VA = "0x9F892C")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x9F87F0", Offset = "0x9F87F0", VA = "0x9F87F0")]
		private void Stop()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x9F884C", Offset = "0x9F884C", VA = "0x9F884C")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x9F8174", Offset = "0x9F8174", VA = "0x9F8174")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x9F8A60", Offset = "0x9F8A60", VA = "0x9F8A60")]
		public Navigator()
		{
		}
	}
}
